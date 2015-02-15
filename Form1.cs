using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;

namespace freelancehunt
{
    public partial class Form1 : Form
    {
        SolidBrush textBrush = null;
        StringFormat textFormat = new StringFormat();
        
        #region списки
        List<cntrlFeed> lstFeeds = new List<cntrlFeed>();
        List<cntrlMessageInfo> lstMessages = new List<cntrlMessageInfo>();
        List<cntrlMessDialog> lstMessDialog = new List<cntrlMessDialog>();
        List<cntrlProject> lstProjects = new List<cntrlProject>();
        List<frmUpdateInfo> lstFrmInfo = new List<frmUpdateInfo>();
        
        /// <summary>
        /// найденные проекты
        /// </summary>
        List<clsSerchedProject> searchedProject = new List<clsSerchedProject>();
        #endregion
        
        frmUpdateInfo frmUpdInfo = new frmUpdateInfo();
        frmConfig frmConf = (frmConfig)null;

        #region флаги
        bool is_init = true;
        bool is_init_m = true;
        bool is_init_f = true;
        bool is_init_u = true;
        bool is_init_p = true;
        bool is_init_ps = true;

        bool is_Skills_saved = true;

        public static bool is_forse_upd = false;

        public static bool is_customer = false;
        #endregion

        #region файлы данных
        string fileErrors = Application.StartupPath + @"\errors.log";
        string fileID_and_Psss = Application.StartupPath + @"\id_and_pass.txt";
        #endregion

        #region данные для идентификаторов проектов

        /// <summary>
        /// дата 1 янв 2014
        /// </summary>
        DateTime dt2014 = new DateTime(2014, 1, 1);
        /// <summary>
        /// путь к номерам проектов
        /// </summary>
        string projectsIDs = Application.StartupPath + @"\projects.log";
        /// <summary>
        /// первое это ИД второе время от 1 янв 2014 г
        /// </summary>
        Dictionary<Int64, Int64> prjIDs = new Dictionary<long, long>(); 

        #endregion

        string skillsURL = string.Empty;

        int imgDownloadTryCount = 0;
        
        clsProfile profile = null;

        void downLoadImage()
        {
            try
            {
                Image img = Properties.Resources.DefaultAva;

                if (this.profile == null) return;

                using (WebClient wClient = new WebClient())
                {
                    Uri uri = new Uri(this.profile.url_avatar);

                    byte[] imageByte = wClient.DownloadData(uri);
                    using (MemoryStream ms = new MemoryStream(imageByte, 0, imageByte.Length))
                    {
                        ms.Write(imageByte, 0, imageByte.Length);
                        img = Image.FromStream(ms, true);
                    }
                }

                pcbProfileAvatar.BeginInvoke(new Action(() =>
                {
                    pcbProfileAvatar.Image = img;
                }));
            }
            catch (Exception)
            {
                try
                {
                    imgDownloadTryCount++;

                    if (imgDownloadTryCount < 10)
                    {
                        Thread.Sleep(270);

                        Thread th = new Thread(downLoadImage);
                        th.Start();

                        return;
                    }
                }
                catch (Exception) { }
            }
        }

        /// <summary>
        /// добавить идентификатор в файл
        /// </summary>
        /// <param name="id"></param>
        void addProjectIDToFile(Int64 id)
        {
            using (StreamWriter wr = new StreamWriter(projectsIDs, true, Encoding.GetEncoding(1251)))
            {
                Int64 timeStamp = (Int64)(DateTime.Now - dt2014).TotalSeconds;

                wr.WriteLine(id.ToString() + "\t" + timeStamp);
                wr.Flush();
                wr.Close();

                prjIDs.Add(id, timeStamp);
            }
        }
        
        void setSizeForReviews()
        {
            if (this.profile == null) return;

            #region размеры

            int wMax = panel10.Width - 20;
            try
            {
                panel9.BeginInvoke(new Action(() =>
                    {
                        pcbUserNegative.Visible = pcbUserPositive.Visible = false;

                        int sum = profile.negative_reviews + profile.positive_reviews;

                        if (sum > 0)
                        {
                            float byOne = 1.0F * wMax / sum;

                            pcbUserNegative.Width = (int)(profile.negative_reviews * byOne);
                            pcbUserPositive.Width = (int)(profile.positive_reviews * byOne);

                            pcbUserNegative.Visible = pcbUserPositive.Visible = true;
                        }
                    }));
            }
            catch (Exception) { }
            #endregion
        }

        string uniq()
        {
            string ret = string.Empty;

            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            
            foreach (ManagementObject mo in moc)
            {
                ret += mo.Properties["ProcessorId"].Value.ToString();
            }

            return ret;
        }

        byte[] uncBytes()
        {
            return System.Text.Encoding.UTF8.GetBytes(uniq());
        }

        public string encode(string text)
        {
            byte[] bytes = uncBytes();

            byte[] mybyte = System.Text.Encoding.UTF8.GetBytes(text);

            int num = 0;

            for (int i = 0; i < mybyte.Count(); i++ )
            {
                mybyte[i] = (byte)(mybyte[i] ^ bytes[num]);

                num++;
                if (num >= bytes.Count())
                    num = 0;
            }

            string returntext = System.Convert.ToBase64String(mybyte);
            return returntext;
        }

        public string decode(string text)
        {
            byte[] bytes = uncBytes();

            byte[] mybyte = System.Convert.FromBase64String(text);

            int num = 0;

            for (int i = 0; i < mybyte.Count(); i++)
            {
                mybyte[i] = (byte)(mybyte[i] ^ bytes[num]);

                num++;
                if (num >= bytes.Count())
                    num = 0;
            }

            string returntext = System.Text.Encoding.UTF8.GetString(mybyte);
            return returntext;
        }


        public Form1()
        {
            #region это первая запущенныя копия?
            /*string pr = Process.GetCurrentProcess().ProcessName;
            
            Process[] prList1 = Process.GetProcessesByName(pr);
            if (Process.GetProcessesByName(pr).Length > 0)
            {
                Process[] prList = Process.GetProcessesByName(pr);
                //var item = Core.Collections.Items.FirstOrDefault(itm => itm.UserID == bytereader.readInt());
                Process pr1 = prList.FirstOrDefault();
                if (prList.Contains(Process.GetCurrentProcess()))
                {
                    pr1 = prList.FirstOrDefault(itm => itm != Process.GetCurrentProcess());
                    //Process pr1 = Process.GetProcessesByName(pr).FirstOrDefault();
                    //pr1.MainWindowHandle;
                }
                
                IntPtr hWindow = pr1.MainWindowHandle;//.ToPointer();
                MessageBox.Show("hWindow \n" + hWindow.ToString());

                try {

                    ShowWindow(hWindow, WinStyle.ShowMaximized);


                 //   Form oldMainForm = (Form)Form.FromHandle(hWindow);
                 //   MessageBox.Show("oldMainForm \n" + oldMainForm.ToString());
                 //   oldMainForm.WindowState = FormWindowState.Maximized;
                 //   MessageBox.Show("oldMainForm.WindowState = FormWindowState.Maximized;");
                 //   oldMainForm.BringToFront();
                 //   oldMainForm.TopMost = true;
                 //   oldMainForm.TopMost = false;
                //    MessageBox.Show("oldMainForm.BringToFront();");
                } catch {}


                Thread.Sleep(2000);
                try { Process.GetCurrentProcess().Kill(); }
                catch (Exception) { }
                
                //DialogResult dr = MessageBox.Show("Программа уже запущена. \nЗапустить еще раз?", "Программа запущена", MessageBoxButtons.YesNo, MessageBoxIcon.Question);// + Process.GetProcessesByName(pr).Length);
                //switch (dr)
                //{
                //    case DialogResult.Yes:
                //        { break; }
                //    case DialogResult.No:
                //        {
                //        Process.GetCurrentProcess().Kill();
                //        break;
                //        }
                //}
            }*/
            #endregion

            textBrush = new SolidBrush(clsColors.textColor1);
            textFormat.Alignment = StringAlignment.Near;
            textFormat.LineAlignment = StringAlignment.Center;
            clsConfig.loadConfig();
            
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            
            this.WindowState = FormWindowState.Maximized;
            if (clsConfig.StartHidden) { this.WindowState = FormWindowState.Minimized; }
            
            if (clsConfig.ShowInterestProjOnly) { 
                //toolStripButton6.Visible = false;
                btnFilterOnOff.Text = "Отключить";
            }
            else { 
                //toolStripButton6.Visible = true; 
                btnFilterOnOff.Text = "Включить";
            }


            #region скрываем переключатель у таб элемента
            
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            //tabControl1.i
            tabControl1.SizeMode = TabSizeMode.Fixed;
            
            #endregion

            #region идентификаторы проектов из файла

            if (File.Exists(projectsIDs))
            {
                using (StreamReader rd = new StreamReader(projectsIDs, Encoding.GetEncoding(1251)))
                {
                    while (!rd.EndOfStream)
                    {
                        string line = rd.ReadLine();

                        if (string.IsNullOrEmpty(line)) continue;

                        string[] data = line.Split('\t');

                        Int64 _i = 0;

                        Int64 id = 0;
                        Int64 timeStamp = 0;

                        if (!Int64.TryParse(data[0], out _i)) continue;
                        id = _i;
                        if (!Int64.TryParse(data[1], out _i)) continue;
                        timeStamp = _i;

                        prjIDs.Add(id, timeStamp);
                    }
                }
            }

            #endregion

            //frmUpdInfo.Parent = this;
            frmUpdInfo.Show();
            frmUpdInfo.Hide();

        }

        private void toolStripButton_Paint(object sender, PaintEventArgs e)
        {
            Size size = ((ToolStripButton)sender).Size;
            

            LinearGradientBrush linGrBrush = new LinearGradientBrush(
                                             new Point(0, 0),
                                             new Point(0, size.Height),
                                             clsColors.lnrColorTop1,
                                             clsColors.lnrColorBottom1);  

            Rectangle rect = new Rectangle(new Point(0, 0), size);

            e.Graphics.FillRectangle(linGrBrush, rect);

            ((ToolStripButton)sender).TextImageRelation = TextImageRelation.ImageAboveText;
            
            
            #region картинка

            Image img = ((ToolStripButton)sender).Image;
            
            int y = (size.Height - img.Height) / 2;

            //e.Graphics.DrawImage( )
            e.Graphics.DrawImage(img, 3, y);

            #endregion

            #region текст

            string abt = "О ПРОГРАММЕ";
            if (((ToolStripButton)sender).Text.Equals(abt))    //public static Color textColor1 = Color.FromArgb(255, 255, 255, 255);
            { textBrush = new SolidBrush(clsColors.textColor2); }
            else { textBrush = new SolidBrush(clsColors.textColor1); }
            rect.X += 55;
            e.Graphics.DrawString(((ToolStripButton)sender).Text, ((ToolStripButton)sender).Font, textBrush, rect, textFormat);
            
            rect.X -= 55;
            #endregion
            

        /*    #region окантовка
            
            rect.Height--;
            rect.Width--;
            e.Graphics.DrawRectangle(clsColors.borderPen, rect); 

            #endregion    */
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (!File.Exists(fileID_and_Psss))
            {
                using (frmLogin frm = new frmLogin())
                {
                    while (frm.ShowDialog() == DialogResult.OK )
                    {
                        
                            #region проверка данных
                            if (string.IsNullOrEmpty(frm.txtLogin.Text) || string.IsNullOrEmpty(frm.txtPass.Text)) { continue; }
                            #endregion

                            clsUpdate.id = frm.txtLogin.Text;
                            clsUpdate.pass = frm.txtPass.Text;

                            using (StreamWriter wr = new StreamWriter(fileID_and_Psss, false, Encoding.GetEncoding(1251)))
                            {
                                //wr.WriteLine(clsUpdate.id + "," + clsUpdate.pass);
                                wr.WriteLine(encode(clsUpdate.id + "," + clsUpdate.pass));
                                wr.Flush();
                                wr.Close();
                            }
                            this.WindowState = FormWindowState.Maximized;
                            break;
                        
                    }
                }
            }
            else
            {
                using (StreamReader rd = new StreamReader(fileID_and_Psss, Encoding.GetEncoding(1251)))
                {
                    try
                    {
                        string[] data = decode(rd.ReadLine()).Split(',');
                        rd.Close();

                        if (data.Count() == 2)
                        {
                            clsUpdate.id = data[0];
                            clsUpdate.pass = data[1];
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка в ключах", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mnuExit.PerformClick();
                        return;
                    }
                }
            }

            if (string.IsNullOrEmpty(clsUpdate.id) || string.IsNullOrEmpty(clsUpdate.pass))
            {
                Close();
                return;
            }

            timerProgress.Start();
            

            clsUpdate.evRefresh += new clsUpdate.evRefreshHandle(clsMeessages_evRefresh);
            clsUpdate.evRefreshStart += new clsUpdate.evRefreshStartHandle(clsUpdate_evRefreshStart);
            clsUpdate.evRefreshEnd += new clsUpdate.evRefreshEndHandle(clsUpdate_evRefreshEnd);

            clsPing.evInternetConnectChange += new clsPing.evInternetConnectChangeHandle(clsPing_evInternetConnectChange);

            Thread th = new Thread(clsUpdate.autoRefresh);
            th.Start();
            //is_init = true;
        }

        void gtSklls() 
        {
            if (clsGlobalSkills.skills == null || clsGlobalSkills.skills.Count < 2 || lstSkill.Items.Count < 2)
            {
                clsGlobalSkills.Refresh();

                if (clsGlobalSkills.skills == null || clsGlobalSkills.skills.Count < 2)
                {
                    Thread.Sleep(100);
                    gtSklls();
                    return;
                }
                try { lstSkill.BeginInvoke(new Action(() => { foreach (KeyValuePair<int, string> key in clsGlobalSkills.skills) { lstSkill.Items.Add(key.Value); } })); }
                catch (Exception) { }
            }
        }

        void clsPing_evInternetConnectChange(bool connect)
        {
            try
            { pcbPing.BeginInvoke(new Action(() => pcbPing.Image = connect ? Properties.Resources.world : Properties.Resources.world_gray)); }
            catch (Exception) { }

            if (clsGlobalSkills.skills == null)
            {
                clsGlobalSkills.Refresh();

                if (clsGlobalSkills.skills == null) gtSklls();
                try
                {
                    lstSkill.BeginInvoke(new Action(() =>
                        {
                            foreach (KeyValuePair<int, string> key in clsGlobalSkills.skills)
                                lstSkill.Items.Add(key.Value);
                        }));
                } catch (Exception) { }
            }
        }

        void clsUpdate_evRefreshEnd(getInfoType type)
        {
            try
            {
                lblLastAction.BeginInvoke(new Action(() =>
                    {
                        lblLastAction.Text = "Обновление: ";
                        switch (type)
                        {
                            case getInfoType.feed:
                                lblLastAction.Text += "лента";
                                break;

                            case getInfoType.messagesFrom:
                            case getInfoType.messages:
                                lblLastAction.Text += "сообщения";
                                break;

                            //case getInfoType.profileList:
                            case getInfoType.profiles:
                                lblLastAction.Text += "профиля";
                                break;

                            case getInfoType.projects:
                                lblLastAction.Text += "проектов";
                                break;
                        }

                        lblLastAction.Text += ", закончено";
                    }));
            }
            catch (Exception) { }
        }

        void clsUpdate_evRefreshStart(getInfoType type)
        {
            try
            {
                lblLastAction.BeginInvoke(new Action(() =>
                        {
                            lblLastAction.Text = "Обновление: ";
                            switch (type)
                            {
                                
                                case getInfoType.feed:
                                    lblLastAction.Text += "лента";
                                    break;

                                case getInfoType.messagesFrom:
                                case getInfoType.messages:
                                    lblLastAction.Text += "сообщения";
                                    break;

                                //case getInfoType.profileList:
                                case getInfoType.profiles:
                                    lblLastAction.Text += "профиля";
                                    break;

                                case getInfoType.projects:
                                    lblLastAction.Text += "проектов";
                                    break;
                            }

                            lblLastAction.Text += ", начато";
                        }));
            }
            catch (Exception) { }
        }

        void saveError(string title, string message)
        {
            using (StreamWriter wr = new StreamWriter(fileErrors, true, Encoding.GetEncoding(1251)))
            {
                wr.WriteLine(DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToShortTimeString());

                wr.WriteLine(title);
                wr.WriteLine(message);
                wr.WriteLine("");

                wr.Flush();
                wr.Close();
            }
        }



        void clsMeessages_evRefresh(getInfoType type, string text)
        {
            if (is_init) {OpenSkill();}
                        
            List<clsJSON> jsons = null;
            if      (type == getInfoType.messagesFrom || type == getInfoType.messagesFrom1) { jsons = clsJSON.parceMessage(text); }
            else if (type == getInfoType.projects     || type == getInfoType.projectsF)     { jsons = clsJSON.parceProj(text); }
            else { jsons = clsJSON.parce(text); }

            if (jsons == null || jsons.Count == 0) return;

            if (text.LastIndexOf("error") > -1)
            {
                #region обработка ошибок

                if (jsons == null)
                {
                    saveError("Обновление " + type.ToString(), "Ничего не получено");
                    return;
                }

                if (jsons.Count == 1)
                {
                    if (jsons[0].bloks != null)
                    {
                        if (jsons[0].bloks.Count > 0)
                        {
                            clsJSON_block block = jsons[0].bloks.FirstOrDefault(b => b.name.ToLower().CompareTo("error") == 0);

                            if (block != null)
                            {
                                string inf = clsUpdate.cmdReq(type) + "\r\n";

                                foreach (string[] line in block.data)
                                {
                                    inf += line[0] + ":" + line[1] + "\r\n";
                                }

                                saveError("Обновление " + type.ToString(), inf);
                            }
                        }
                    }
                }

                #endregion
            }
           
            #region обновление ленты
            
            if (type == getInfoType.feed)
            {
                foreach (clsJSON json in jsons)
                {
                    #region проверка на ошибку
                    
                    if (json.bloks != null)
                    {
                        clsJSON_block block = json.bloks.FirstOrDefault(b => b.name.ToLower().CompareTo("error") == 0);

                        if (block != null) continue;
                    } 

                    #endregion

                    clsFeed feed = new clsFeed(json);
                    
                    cntrlFeed ff = null;
                    try { ff = lstFeeds.FirstOrDefault(f => f.feed.message.CompareTo(feed.message) == 0); }
                    catch (Exception) {  }

                    if (ff != null) continue;

                    cntrlFeed cf = new cntrlFeed(feed);

                    lstFeeds.Add(cf);

                    cf.Dock = DockStyle.Top;
                    
                    try
                    {
                        if (is_init_f)
                        {
                            scrollFeed.BeginInvoke(new Action(() =>
                            {
                                cf.Parent = scrollFeed;
                                cf.BringToFront();
                            }));
                        } else { scrollFeed.BeginInvoke(new Action(() => { cf.Parent = scrollFeed; })); }
                    }
                    catch (Exception) { }

                    if (feed.is_new && clsConfig.ShowUpdateWindow) { frmUpdInfo.addMessage("Новый пост в ленте от ", this, tabControl1); }
                }
                if (is_init_f) {
                    try { tabControl1.BeginInvoke(new Action(() => {
                        if (tabControl1.SelectedTab == tabControl1.TabPages["tabLoading"]) 
                            { tabControl1.SelectedTab = tabControl1.TabPages["tabFeeds"]; } 
                    }));
                    } catch (Exception) { }

                    is_init_f = false; 
                }
            }
 
            #endregion

            #region переписка

            if (type == getInfoType.messagesFrom || type == getInfoType.messagesFrom1)
            {
                #region очистить scrollMessDialog от предыдущего диалога и переключить на вкладку tabLoading
                try 
                { 
                    scrollMessDialog.BeginInvoke(new Action(() => 
                    {   
                        tabControl1.SelectedTab = tabControl1.TabPages["tabLoading"];
                        scrollMessDialog.Controls.Clear();
                    })); 
                }
                catch (Exception) { }
                #endregion

                if (jsons.Count > 110)
                {
                    jsons.RemoveRange(0, jsons.Count - 100);
                }

                foreach (clsJSON json in jsons)
                {
                    #region проверка на ошибку
                    if (json.bloks != null)
                    {
                        clsJSON_block block = json.bloks.FirstOrDefault(b => b.name.ToLower().CompareTo("error") == 0);
                        if (block != null) continue;
                    }
                    #endregion

                    clsMessDialog msg = new clsMessDialog(json);

                    int w = scrollMessages.Width - 25 - 95;
                    cntrlMessDialog cf = new cntrlMessDialog(msg, w);
					lstMessDialog.Add(cf);

					cf.Dock = DockStyle.Top;

                    
                    try
                    {
                        scrollMessDialog.BeginInvoke(new Action(() =>
                        {
                            cf.Parent = scrollMessDialog;
                            cf.BringToFront();
                        }));
                    } catch (Exception) { }
                    //cf.chSize();
                }

                #region переключить на вкладку tabDialog и прокрутить к последнему сообщению
                try 
                { 
                    scrollMessDialog.BeginInvoke(new Action(() => 
                    { 
                        tabControl1.SelectedTab = tabControl1.TabPages["tabDialog"];
                        scrollMessDialog.Focus();
                        scrollMessDialog.VerticalScroll.Value = scrollMessDialog.VerticalScroll.Maximum;
                        scrollMessDialog.VerticalScroll.Value = scrollMessDialog.VerticalScroll.Maximum;
                    }));
                } catch (Exception) { }
                #endregion
            }
            #endregion

            #region сообщения

            if (type == getInfoType.messages)
            {
                lstMessages.Clear();
                
                int newMessCnt = 0;
                try
                {
                    scrollMessages.BeginInvoke(new Action(() =>
                    {
                        scrollMessages.Controls.Clear();
                        scrollMessages.Visible = false;
                    }));
                }
                catch (Exception) { }
                foreach (clsJSON json in jsons)
                {
                    #region проверка на ошибку

                    if (json.bloks != null)
                    {
                        clsJSON_block block = json.bloks.FirstOrDefault(b => b.name.ToLower().CompareTo("error") == 0);

                        if (block != null) continue;
                    }

                    #endregion

                    clsMessage msg = new clsMessage(json);

                    //cntrlMessageInfo fmi = lstMessages.FirstOrDefault(f => f.message.post_time.CompareTo(msg.post_time) == 0);
                    //cntrlMessageInfo fmi1 = lstMessages.FirstOrDefault(f => f.message.last_post_time.CompareTo(msg.last_post_time) == 0);
                    //if (fmi != null || fmi1 != null) continue;

                    int w = scrollMessages.Width - 400;
                    
                    cntrlMessageInfo cf = new cntrlMessageInfo(msg, w);
                    lstMessages.Add(cf);
                    cf.Dock = DockStyle.Top;
                    try
                    {
                        scrollMessages.BeginInvoke(new Action(() =>
                        {
                            cf.Parent = scrollMessages;
                            cf.BringToFront();
                        }));
                    }
                    catch (Exception) { }

                    if (msg.unread_count > 0 || msg.is_unread) {
                        newMessCnt++;
                    }
                }

                try { scrollMessages.BeginInvoke(new Action(() => { scrollMessages.Visible = true; })); }
                catch (Exception) { }

                if (newMessCnt > 0)
                {
                    if (clsConfig.ShowUpdateWindow)
                    {
                        frmUpdInfo.addMessage("Новое сообщение " + newMessCnt, this, tabControl1);
                    }
                   
                    #region notify.Text
                    string notifyText = "Freelancehunt Monitor \n" + newMessCnt;
                    if (newMessCnt == 1 || newMessCnt == 21 || newMessCnt == 31 || newMessCnt == 41 || newMessCnt == 51 || newMessCnt == 61 || newMessCnt == 71 || newMessCnt == 81 || newMessCnt == 91 || newMessCnt == 101) { notifyText += " новое сообщение "; }
                    else if (newMessCnt >= 2 && newMessCnt <= 4 || newMessCnt >= 22 && newMessCnt <= 24 || newMessCnt >= 32 && newMessCnt <= 34 || newMessCnt >= 42 && newMessCnt <= 44 || newMessCnt >= 52 && newMessCnt <= 54 || newMessCnt >= 62 && newMessCnt <= 64 || newMessCnt >= 72 && newMessCnt <= 74 || newMessCnt >= 82 && newMessCnt <= 84 || newMessCnt >= 92 && newMessCnt <= 94) { notifyText += " новых сообщения "; }
                    else notifyText += " новых сообшений ";
                    this.notify.Text = notifyText;
                    #endregion

                    #region notify.icon
                    if (newMessCnt == 1) { notify.Icon = ((System.Drawing.Icon)(Properties.Resources.favicon_nnm1)); }
                    if (newMessCnt == 2) { notify.Icon = ((System.Drawing.Icon)(Properties.Resources.favicon_nnm2)); }
                    if (newMessCnt == 3) { notify.Icon = ((System.Drawing.Icon)(Properties.Resources.favicon_nnm3)); }
                    if (newMessCnt == 4) { notify.Icon = ((System.Drawing.Icon)(Properties.Resources.favicon_nnm4)); }
                    if (newMessCnt == 5) { notify.Icon = ((System.Drawing.Icon)(Properties.Resources.favicon_nnm5)); }
                    if (newMessCnt == 6) { notify.Icon = ((System.Drawing.Icon)(Properties.Resources.favicon_nnm6)); }
                    if (newMessCnt == 7) { notify.Icon = ((System.Drawing.Icon)(Properties.Resources.favicon_nnm7)); }
                    if (newMessCnt == 8) { notify.Icon = ((System.Drawing.Icon)(Properties.Resources.favicon_nnm8)); }
                    if (newMessCnt == 9) { notify.Icon = ((System.Drawing.Icon)(Properties.Resources.favicon_nnm9)); }
                    if (newMessCnt >  9) { notify.Icon = ((System.Drawing.Icon)(Properties.Resources.favicon_nnm9_)); }
                    #endregion
                }
                else { 
                    this.notify.Text = "Freelancehunt Monitor";
                    notify.Icon = ((System.Drawing.Icon)(Properties.Resources.favicon1));
                }

                if (is_init_m) {
                    //tabControl1.SelectedTab = tabControl1.TabPages["tabMessages"];
                    try { tabControl1.BeginInvoke(new Action(() => { tabControl1.SelectedTab = tabControl1.TabPages["tabMessages"]; })); }
                    catch (Exception) { }
                    is_init_m = false;
                }
                if (is_forse_upd)
                {
                    try { tabControl1.BeginInvoke(new Action(() => { if (tabControl1.SelectedTab == tabControl1.TabPages["tabMessages"]) { scrollMessages.Focus(); } })); }
                    catch (Exception) { }
                    is_forse_upd = false;
                }
                
                //if (is_init) 
            }
 
            #endregion

            #region профайл

            if (type == getInfoType.profiles)
            {
                #region проверка на ошибку

                if (jsons == null) return;
                if (jsons.Count != 1) return;

                if (jsons[0].bloks != null)
                {
                    clsJSON_block block = jsons[0].bloks.FirstOrDefault(b => b.name.ToLower().CompareTo("error") == 0);

                    if (block != null) {

                        //try { this.BeginInvoke(new Action(() => { 
                        //    tabControl1.SelectedTab = tabControl1.TabPages["tabUserList"];
                        //    //MessageBox.Show("Пользователь с логином \"" + txtProfileName.Text.Trim() + "\" не найден!","Ошибка" );
                        //})); }
                        //catch (Exception) { }
                        return;
                    }
                }

                #endregion

                profile = new clsProfile(jsons[0]);

                if (is_init_u)
                {
                    is_customer = !profile.is_freelancer;
                    is_init_u = false; 
                }
                
                #region данные профиля 
                //dataGridView1.BeginInvoke(new Action(() =>
                //    {
                //        dataGridView1.Rows.Clear();

                //        foreach (object[] line in profile.table)
                //            dataGridView1.Rows.Add(line);
                //    }));

                //frmUpdInfo.addMessage("Информация о профиле " + profile.fname + " " + profile.sname + " (" + profile.login + ")", this);
                #endregion
                #region изображения

                //pnlUserParam.BeginInvoke(new Action(() =>
                //    {
                //        pcbUser_Day.Image = profile.is_birth_date_verified ? Properties.Resources.user_date : Properties.Resources.user_date_gray;
                //        pcbUser_email.Image = profile.is_email_verified ? Properties.Resources.user_email : Properties.Resources.user_email_gray;
                //        pcbUser_OKPAY.Image = profile.is_okpay_verified ? Properties.Resources.user_okpay : Properties.Resources.user_okpay_gray;
                //        pcbUser_Phone.Image = profile.is_phone_verifie ? Properties.Resources.user_phone : Properties.Resources.user_phone_gray;
                //        pcbUser_WMID.Image = profile.is_wmid_verified ? Properties.Resources.user_wmid : Properties.Resources.user_wmid_gray;
                //    }));

                //pcbProfileAvatar.BeginInvoke(new Action(() => pcbProfileAvatar.Image = Properties.Resources.DefaultAva));
                //txtProfileName.BeginInvoke(new Action(() => txtProfileName.Text = profile.login));

                //imgDownloadTryCount = 0;

                //Thread th = new Thread(downLoadImage);
                //th.Start();

                //setSizeForReviews();

                #endregion

                //try { scrollMessDialog.BeginInvoke(new Action(() => { tabControl1.SelectedTab = tabControl1.TabPages["tabUsers"]; })); }
                //catch (Exception) { }
                //if (is_init_u) { is_init_u = false; }
            }

            #endregion

            #region проекты

            if (type == getInfoType.projects || type == getInfoType.projectsF)
            {
                lstProjects.Clear();

                int newProjCnt = 0;
                try
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        panel19.Visible = true;
                        progressBar1.Value = 40;
                    }));
                } catch (Exception) { }
                int step = 960 / jsons.Count;

                if (jsons.Count < 2) {
                    try
                    {
                        this.BeginInvoke(new Action(() => { progressBar1.Value = 1000; }));
                        this.BeginInvoke(new Action(() => { panel19.Visible = false; }));
                    } catch (Exception) { }
                }

                foreach (clsJSON json in jsons)
                {
                    #region проверка на ошибку

                    if (json.bloks != null)
                    {
                        clsJSON_block block = json.bloks.FirstOrDefault(b => b.name.ToLower().CompareTo("error") == 0);
                        if (block != null) continue;
                    }

                    #endregion

                    try { this.BeginInvoke(new Action(() => { progressBar1.Value += (step / 8); })); } catch (Exception) { }

                    clsProject prj = new clsProject(json);

                    cntrlProject fp = lstProjects.FirstOrDefault(p => p.project.id == prj.id);

                    try { this.BeginInvoke(new Action(() => { progressBar1.Value += (step / 8); })); } catch (Exception) { }

                    if (fp != null) continue;

                    cntrlProject cp = new cntrlProject(prj);

                    try { this.BeginInvoke(new Action(() => { progressBar1.Value += (step / 8); })); } catch (Exception) { }
                    
                    lstProjects.Add(cp);
                    
                    try { this.BeginInvoke(new Action(() => { progressBar1.Value += (step / 8); })); } catch (Exception) { }
                    
                    //try
                    //{
                    //    scrollProjects.BeginInvoke(new Action(() =>
                    //    {
                    //        cp.Parent = scrollProjects;
                    //        cp.BringToFront();
                    //    }));
                    //}
                    //catch (Exception) { }
                    
                    try { this.BeginInvoke(new Action(() => { progressBar1.Value += (step / 8); })); } catch (Exception) { }
                    if (!prjIDs.ContainsKey(prj.id) )
                    {
                        addProjectIDToFile(prj.id);
                        newProjCnt++;
                        //if (!is_customer && !clsConfig.NotifyInterestProjOnly)
                        //{ frmUpdInfo.addMessage("Новый проект, #" + prj.id, this, tabControl1); }
                    }
                    try { this.BeginInvoke(new Action(() => { progressBar1.Value += (step / 8); })); } catch (Exception) { }
                }
                #region скрыть scrollProjects
                try {
                    scrollProjects.BeginInvoke(new Action(() =>
                    {
                        scrollProjects.Visible = false;
                        scrollProjects.Controls.Clear();
                    }));
                } catch (Exception) { }
                #endregion

                Thread.Sleep(100);//надо для разделения во времени BeginInvoke'ов
                
                try { this.BeginInvoke(new Action(() => { progressBar1.Value = 900; })); } catch (Exception) { }
                
                #region добавить каждый элемент на scrollProjects
                foreach (cntrlProject cpr in lstProjects)
                {
                    cpr.Dock = DockStyle.Top;
                    try
                    {
                        scrollProjects.BeginInvoke(new Action(() =>
                        {
                            cpr.Parent = scrollProjects;
                            cpr.BringToFront();
                        }));
                    }
                    catch (Exception) { }
                }
                #endregion

                Thread.Sleep(100);//надо для разделения во времени BeginInvoke'ов

                try { this.BeginInvoke(new Action(() => { progressBar1.Value = 1000; })); } catch (Exception) { }

                #region показать scrollProjects и скрыть panel19
                try { 
                    this.BeginInvoke(new Action(() => { 
                        panel19.Visible = false;
                        scrollProjects.Visible = true;
                    }));
                } catch (Exception) { }
                #endregion

                if (!is_customer && !clsConfig.NotifyInterestProjOnly && clsConfig.ShowUpdateWindow)
                { frmUpdInfo.addMessage("Новый проект " + newProjCnt, this, tabControl1); }

                if (is_init_p) {
                    if (!clsConfig.ShowInterestProjOnly)
                    {
                        try
                        {
                            tabControl1.BeginInvoke(new Action(() =>
                            {
                                if (tabControl1.SelectedTab == tabControl1.TabPages["tabLoading"])
                                { tabControl1.SelectedTab = tabControl1.TabPages["tabProjects"]; }
                            }));
                        }
                        catch (Exception) { }
                    }

                    is_init_p = false; 
                }
                if (is_forse_upd)
                {
                    try { tabControl1.BeginInvoke(new Action(() => { if (tabControl1.SelectedTab == tabControl1.TabPages["tabProjects"]) { scrollProjects.Focus(); } })); }
                    catch (Exception) { }
                    is_forse_upd = false;
                }
                #region фильтр проектов
                 
                try {
                    this.BeginInvoke(new Action(() => { 
                        initData();
                        loadProjectes();
                    })); 
                } catch (Exception) { }
                
                if(is_init_ps) 
                {
                    if (clsConfig.ShowInterestProjOnly)
                    {
                        try
                        {
                            tabControl1.BeginInvoke(new Action(() =>
                            {
                                if (tabControl1.SelectedTab == tabControl1.TabPages["tabLoading"])
                                { tabControl1.SelectedTab = tabControl1.TabPages["tabSearchProj"]; }
                            }));
                        }
                        catch (Exception) { }
                    }
                    is_init_ps = false;
                }
                if (is_forse_upd)
                {
                    try
                    {
                        tabControl1.BeginInvoke(new Action(() =>
                        {
                            if (tabControl1.SelectedTab == tabControl1.TabPages["tabSearchProj"]) { scrollSearchedProject.Focus(); }
                        }));
                    }
                    catch (Exception) { }
                    is_forse_upd = false;
                }

                #endregion

            }
            try{ this.BeginInvoke(new Action(() => { scrollProjects.Visible = true; })); } 
            catch (Exception) { }
            #endregion

            if (is_init) { is_init = false; }
        }



        void frm_evClose(frmUpdateInfo sender)
        {
            sender.Dispose();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (!is_init_m)
            {
                tabControl1.SelectedTab = tabControl1.TabPages["tabMessages"];
                scrollMessages.Focus();
            } 
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (!is_init_f)
            {
                if (tabControl1.SelectedTab == tabControl1.TabPages["tabMessages"] && cBPgNum.Text != "1"){
                    cBPgNum.Text = "1";
                }

                this.tabControl1.SelectedTab = this.tabControl1.TabPages["tabFeeds"];
                if (!scrollFeed.Visible)
                {
                    scrollFeed.Visible = true;
                }
                scrollFeed.Focus();
            }
            //else this.tabControl1.SelectedTab = this.tabControl1.TabPages["tabLoading"];
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //tabControl1.SelectedTab = tabControl1.TabPages["tabUsers"];
            tabControl1.SelectedTab = tabControl1.TabPages["tabUserList"];
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            using (frmAbout frm = new frmAbout())
                frm.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (!is_init_p && !clsConfig.ShowInterestProjOnly)
            {
                if (tabControl1.SelectedTab == tabControl1.TabPages["tabMessages"] && cBPgNum.Text != "1")
                { cBPgNum.Text = "1"; }

                tabControl1.SelectedTab = tabControl1.TabPages["tabProjects"];
                scrollProjects.Focus();
                if (clsUpdate.Pause == true && scrollProjects.Visible == false)
                {
                    scrollProjects.Visible = true;
                }
            }
            if (!is_init_ps && clsConfig.ShowInterestProjOnly)//|| lstSkill.CheckedItems.Count > 0
            {
                if (tabControl1.SelectedTab == tabControl1.TabPages["tabMessages"] && cBPgNum.Text != "1")
                { cBPgNum.Text = "1"; }

                tabControl1.SelectedTab = tabControl1.TabPages["tabSearchProj"];
                if (clsUpdate.Pause == true && scrollSearchedProject.Visible == false)
                {
                    scrollSearchedProject.Visible = true;
                }
                scrollSearchedProject.Focus();
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (!is_init_ps)
            {
                tabControl1.SelectedTab = tabControl1.TabPages["tabSearchProj"];
                scrollSearchedProject.Focus();
            }
        }

        private void initData() 
        {
            #region начальные данные

            this.skillsURL = "skills=";

            searchedProject.Clear();

            searchedProject = new List<clsSerchedProject>();

            cmbPageNum.Items.Clear();
            cmbPageNum.Items.Add("1");
            cmbPageNum.SelectedIndex = 0;

            for (int i = 0; i < lstSkill.Items.Count; i++)
            {
                if (lstSkill.GetItemChecked(i))
                {
                    string skill = clsGlobalSkills.skills.ElementAt(i).Key.ToString();
                    this.skillsURL += skill + ",";
                }
            }

            if (this.skillsURL.EndsWith(","))
                this.skillsURL = this.skillsURL.Substring(0, this.skillsURL.Length - 1);

            #endregion
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            initData();
            loadProjectes();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.WindowState = FormWindowState.Normal;
                if (this.tabControl1.SelectedTab == tabControl1.TabPages["tabDialog"])
                { tabControl1.SelectedTab = tabControl1.TabPages["tabMessages"]; }
            }
        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtProfileName.Text.Trim())) return;

            clsUpdate.proFile = txtProfileName.Text.Trim();
            clsUpdate.Pause = false;
            tbSearch.Text = txtProfileName.Text.Trim();
            tabControl1.SelectedTab = tabControl1.TabPages["tabUsers"];
        }

        private void btn1FindUser_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbSearch.Text.Trim())) return;
            clsUpdate.proFile = tbSearch.Text.Trim();
            clsUpdate.Pause = false;
            try
            {
                this.BeginInvoke(new Action(() =>
                {
                    //tabControl1.SelectedTab = tabControl1.TabPages["tabUsers"];
                    tabControl1.SelectedTab = tabControl1.TabPages["tabLoading"];
                }));
            }
            catch (Exception) { }
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
            if (this.tabControl1.SelectedTab == tabControl1.TabPages["tabDialog"])
            { tabControl1.SelectedTab = tabControl1.TabPages["tabMessages"]; }
        }

        private void mnuChangeUser_Click(object sender, EventArgs e)
        {
            clsUpdate.isStop = true;

            #region удаление старого fileID_and_Psss
            clsUpdate.id = String.Empty;
            clsUpdate.pass = String.Empty;
            try { System.IO.File.Delete(fileID_and_Psss); }
            catch (Exception) { }
            #endregion

            #region очистка скроллов от старых данных
            try
            {
                scrollMessages.Controls.Clear();
                scrollMessDialog.Controls.Clear();
                scrollFeed.Controls.Clear();
                lstFeeds.Clear();
                scrollProjects.Controls.Clear();
                scrollSearchedProject.Controls.Clear();
            }
            catch (Exception) { }
            #endregion

            notify.Visible = false;

            #region запрос ввода новых данных
            
            using (frmLogin frm = new frmLogin())
            {
                while (frm.ShowDialog() == DialogResult.OK)
                {

                    #region проверка данных
                    if (string.IsNullOrEmpty(frm.txtLogin.Text) || string.IsNullOrEmpty(frm.txtPass.Text)) { continue; }
                    #endregion

                    clsUpdate.id = frm.txtLogin.Text;
                    clsUpdate.pass = frm.txtPass.Text;

                    using (StreamWriter wr = new StreamWriter(fileID_and_Psss, false, Encoding.GetEncoding(1251)))
                    {
                        //wr.WriteLine(clsUpdate.id + "," + clsUpdate.pass);
                        wr.WriteLine(encode(clsUpdate.id + "," + clsUpdate.pass));
                        wr.Flush();
                        wr.Close();
                    }
                    this.WindowState = FormWindowState.Maximized;
                    break;

                }
            }
            
            #endregion

            is_init = is_init_f = is_init_m = is_init_p = is_init_ps = is_init_u = true;

            clsUpdate.proFile = "me";

            tabControl1.SelectedTab = tabControl1.TabPages["tabLoading"];

            timerProgress.Start();

            notify.Visible = true;

            this.Show();
            this.WindowState = FormWindowState.Maximized;

            //clsUpdate.evRefresh += new clsUpdate.evRefreshHandle(clsMeessages_evRefresh);
            //clsUpdate.evRefreshStart += new clsUpdate.evRefreshStartHandle(clsUpdate_evRefreshStart);
            //clsUpdate.evRefreshEnd += new clsUpdate.evRefreshEndHandle(clsUpdate_evRefreshEnd);

            //clsPing.evInternetConnectChange += new clsPing.evInternetConnectChangeHandle(clsPing_evInternetConnectChange);
            
            clsUpdate.isStop = false;
            Thread th = new Thread(clsUpdate.autoRefresh);
            th.Start();


        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            #region Сохранить cписок навыков
            if (!is_Skills_saved) {
                DialogResult result = MessageBox.Show("Список навыков не сохранен! \nСохранить?", "Список навыков не сохранен!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                switch (result)
                {
                    case DialogResult.Yes:
                        {
                            SaveSkills();
                            break;
                        }
                    case DialogResult.No: { break; }
                    case DialogResult.Cancel: { return; }
                }
            }
            #endregion

            this.Hide();

            clsUpdate.isStop = true;
            notify.Visible = false;
            notify.Dispose();

            if(!clsConfig.AutoLogin) 
            {
                try { System.IO.File.Delete(fileID_and_Psss); }
                catch (Exception) { }
            }
            
            Thread.Sleep(3000);

            try { Process.GetCurrentProcess().Kill(); }
            catch (Exception) { }
        }

        private void mnuRefresh_Click(object sender, EventArgs e)
        {
            clsUpdate.Pause = false;
        }

        private void notify_Click(object sender, EventArgs e)
        {
            /*
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Maximized;
            }*/
            
        }

        private void notify_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.tabControl1.SelectedTab == tabControl1.TabPages["tabDialog"])
                {
                    tabControl1.SelectedTab = tabControl1.TabPages["tabMessages"];
                    scrollMessages.Focus();
                }
                this.Show();
                this.Focus();
                this.TopMost = true;
                this.WindowState = FormWindowState.Maximized;
                this.TopMost = false;
            }
        }

        private void mnuShow_Click(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedTab == tabControl1.TabPages["tabDialog"])
            {
                tabControl1.SelectedTab = tabControl1.TabPages["tabMessages"];
                scrollMessages.Focus();
            }
            this.Show();
            this.Focus();
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = false;
        }

        private void mnuShowConfig_Click(object sender, EventArgs e)
        {
            if (frmConf == null || frmConf.IsDisposed) { frmConf = new frmConfig(); }
            else {}
            frmConf.Show();
            frmConf.Focus();
            frmConf.TopMost = true;
            frmConf.TopMost = false;
        }

        private void btnGoToProfileURL_Click(object sender, EventArgs e)
        {
            if (this.profile == null) return;
            System.Diagnostics.Process.Start(this.profile.url);
        }

        private void btnProfileSendMessage_Click(object sender, EventArgs e)
        {
            if (this.profile == null) return;
            System.Diagnostics.Process.Start(this.profile.url_private_message);
        }

        private void reviews_Paint(object sender, PaintEventArgs e)
        {
            if (this.profile == null) return;

            PictureBox pcb = (PictureBox)sender;

            Rectangle rect = new Rectangle(0, 0, pcb.Width, pcb.Height);

            LinearGradientBrush lnr = new LinearGradientBrush(rect, pcb == pcbUserPositive ? clsColors.posiriveColor : clsColors.negativeColor, Color.White, 90);

            e.Graphics.FillRectangle(lnr, rect);

            rect.Width--;
            rect.Height--;
            e.Graphics.DrawRectangle(clsColors.borderPen, rect);
        }

        private void panel9_SizeChanged(object sender, EventArgs e)
        {
            //setSizeForReviews();
        }

        private void SaveSkills()
        {
            string str = string.Empty;

            for (int i = 0; i < lstSkill.Items.Count; i++)
            {
                if (lstSkill.GetItemChecked(i))
                { str += clsGlobalSkills.skills.ElementAt(i).Key.ToString() + ","; }
            }

            try
            {
                using (StreamWriter wr = new StreamWriter(Directory.GetCurrentDirectory() + "\\UserSkills.txt", false, Encoding.GetEncoding(1251)))
                {
                    wr.Write(str);
                    wr.Flush();
                    wr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка сохранения фильтра проектов", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            is_Skills_saved = true;
            //btnSaveSkills.Enabled = false;
            //btnOpenSkill.Enabled = false;
            //btnSaveSkills.Visible = false;
            //btnOpenSkill.Visible = false;

            mnuSkills_Save.Enabled = mnuSkills_Cancel.Enabled = false;

            MessageBox.Show("Навыки успешно сохранены", "Навыки сохранены", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSaveSkills_Click(object sender, EventArgs e)
        {
            SaveSkills();
        }

        private void OpenSkill() 
        {
            string[] data = null;

            if (File.Exists(Directory.GetCurrentDirectory() + "\\UserSkills.txt"))
            {
                try
                {
                    using (StreamReader rd = new StreamReader(Directory.GetCurrentDirectory() + "\\UserSkills.txt", Encoding.GetEncoding(1251)))
                    {
                        data = rd.ReadLine().Split(',');
                        rd.Close();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка открытия списка навыков", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else return;
            
            if (data == null) return;

            List<int> _int = new List<int>();

            foreach (string str in data)
            {
                if (string.IsNullOrEmpty(str)) continue;

                int _i = 0;
                if (int.TryParse(str, out _i))
                    _int.Add(_i);
            }


            try { lstSkill.Items.Clear(); }
            catch (Exception) 
            { 
                //MessageBox.Show(ex.Message); 
                return; 
            }

            foreach (KeyValuePair<int, string> key in clsGlobalSkills.skills)
            {
                int _i = _int.FirstOrDefault(i => i == key.Key);

                lstSkill.Items.Add(key.Value, _i > 0);
            }
            is_Skills_saved = true;
            try
            {
                //btnSaveSkills.Enabled = false;
                //btnOpenSkill.Enabled = false;
                //btnSaveSkills.Visible = false;
                //btnOpenSkill.Visible = false;

                mnuSkills_Save.Enabled = mnuSkills_Cancel.Enabled = false;
            }
            catch (Exception) { }
        }

        private void btnOpenSkill_Click(object sender, EventArgs e)
        {
            OpenSkill();
        }

        private void mnuSkills_selectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSkill.Items.Count; i++)
                lstSkill.SetItemChecked(i, true);
        }

        private void mnuSkills_unSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSkill.Items.Count; i++)
                lstSkill.SetItemChecked(i, false);
        }

        private void mnuSkills_invert_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSkill.Items.Count; i++)
                lstSkill.SetItemChecked(i, !lstSkill.GetItemChecked(i));
        }

        private void lstSkill_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            searchedProject.Clear();

            searchedProject = new List<clsSerchedProject>();

            cmbPageNum.Items.Clear();
            cmbPageNum.Items.Add("1");
            cmbPageNum.SelectedIndex = 0;
            skillsURL = string.Empty;
        }

        private void pcbPageMinus_Click(object sender, EventArgs e)
        {
            if (cmbPageNum.Items.Count == 0) return;
            if (cmbPageNum.SelectedIndex == 0) return;

            cmbPageNum.SelectedIndex--;
        }

        private void pcbPagePlus_Click(object sender, EventArgs e)
        {
            if (cmbPageNum.Items.Count == 0) return;

            if (cmbPageNum.SelectedIndex == cmbPageNum.Items.Count - 1)
            {
                cmbPageNum.Items.Add((cmbPageNum.Items.Count + 1).ToString());
            }
            
            cmbPageNum.SelectedIndex++;
        }

        void loadProjectes()
        {
            //scrollProjects.Visible = true;
            scrollSearchedProject.Controls.Clear();

            int PageNum = cmbPageNum.SelectedIndex + 1;

            {
                var lst = from z in searchedProject where z.pageNum == PageNum select z;

                if (lst != null && lst.Count() > 0)
                {
                    scrollSearchedProject.Visible = false;
                    int npc = 0; //счетчик нвых проектов
                    foreach (clsSerchedProject p in lst)
                    {
                        p.control.Dock = DockStyle.Top;
                        p.control.Parent = scrollSearchedProject;
                        p.control.BringToFront();
                        
                        #region новый проект
                        if (!prjIDs.ContainsKey(p.control.project.id) )
                        {
                            addProjectIDToFile(p.control.project.id);
                            if (!is_customer && clsConfig.NotifyInterestProjOnly && clsConfig.ShowUpdateWindow)
                            {
                                npc++;
                            }
                        }
                        #endregion
                    }

                    scrollSearchedProject.Visible = true;
                    frmUpdInfo.addMessage("Новый проект " + npc, this, tabControl1); 
                    return;
                }
            }

            string s = getSkills();
            string data = clsUpdate.getProgectes(s, PageNum);

            List<clsJSON> jsons = clsJSON.parce(data);
            
            #region обработка ошибок
            if (jsons == null)
            {
                if (this.Size.Height > 400)//если форма свернута это не показывать
                {
                    MessageBox.Show("Ошибка при получении списка проектов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

            if (jsons.Count == 0)
            {
                if (this.Size.Height > 400) //если форма свернута это не показывать
                {
                    MessageBox.Show("Ничего не найднео", "информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                return;
            }
            #endregion

            foreach (clsJSON json in jsons)
            {
                clsProject pro = new clsProject(json);
                cntrlProject cp = new cntrlProject(pro);

                searchedProject.Add(new clsSerchedProject(PageNum, cp));
            }

            {
                var lst = from z in searchedProject where z.pageNum == PageNum select z;

                if (lst != null && lst.Count() > 0)
                {
                    scrollSearchedProject.Visible = false;
                    int npc = 0; //счетчик нвых проектов
                    foreach (clsSerchedProject p in lst)
                    {
                        p.control.Dock = DockStyle.Top;
                        p.control.Parent = scrollSearchedProject;
                        p.control.BringToFront();
                        
                        #region новый проект
                        
                        if (!prjIDs.ContainsKey(p.control.project.id) )
                        {
                            addProjectIDToFile(p.control.project.id);
                            if (!is_customer && clsConfig.NotifyInterestProjOnly)
                            { npc++; }
                        }
                        #endregion
                    }

                    scrollSearchedProject.Visible = true;
                    frmUpdInfo.addMessage("Новый проект " + npc, this, tabControl1); 
                }
            }
        }

        string getSkills()
        {
            string str = "skills=";

            for (int i = 0; i < lstSkill.Items.Count; i++)
            {
                if (lstSkill.GetItemChecked(i))
                {
                    string skill = clsGlobalSkills.skills.ElementAt(i).Key.ToString();
                    str += skill + ",";
                }
            }

            if (str.EndsWith(","))
                str = str.Substring(0, str.Length - 1);

            return str;
        }

        private void cmbPageNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadProjectes();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        { }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btn1FindUser_Click(sender, e);
                e.Handled = true;
            }
        }

        private void panel21_Click(object sender, EventArgs e)
        {
            tbSearch.Focus();
        }

        #region постраничная навигация проектов

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13)) {
                clsUpdate.ProjPage = comboBox1.Text;
                clsUpdate.ProjFirst = true;
                clsUpdate.Pause = false;
                is_forse_upd = true;
                panel19.Visible = true;
                progressBar1.Value = 20; 
            }
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            { e.Handled = true; }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            clsUpdate.ProjPage = comboBox1.Text;
            clsUpdate.ProjFirst = true;
            clsUpdate.Pause = false;
            is_forse_upd = true;
            panel19.Visible = true;
            progressBar1.Value = 20; 
            scrollProjects.Focus();
        }

        private void btnPrewPage_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(comboBox1.Text) > 1)
            {
                comboBox1.Text = Convert.ToString(Convert.ToInt32(comboBox1.Text) - 1);
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            comboBox1.Text = Convert.ToString(Convert.ToInt32(comboBox1.Text) + 1);
        }

        private void btnNextPage_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.btnNextPage, "Следующая страница");
        }

        private void btnPrewPage_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.btnPrewPage, "Предыдущая страница");
        }
        
        #endregion

        #region постраничная навигация списка переписок

        private void btnNxtPgMsg_Click(object sender, EventArgs e)
        {
            if (scrollMessages.Controls.Count > 19)
            {
                cBPgNum.Text = Convert.ToString(Convert.ToInt32(cBPgNum.Text) + 1);
            }
        }

        private void btnPrvPgMsg_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cBPgNum.Text) > 1)
            {
                cBPgNum.Text = Convert.ToString(Convert.ToInt32(cBPgNum.Text) - 1);
            }
        }

        private void cBPgNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                is_forse_upd = true;
                clsUpdate.messPage = cBPgNum.Text;
                clsUpdate.Pause = false;
            }
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            { e.Handled = true; }
        }

        private void cBPgNum_SelectedValueChanged(object sender, EventArgs e)
        {
            is_forse_upd = true;
            clsUpdate.messPage = cBPgNum.Text;
            clsUpdate.Pause = false;
        }

        private void btnNxtPgMsg_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.btnNxtPgMsg, "Следующая страница");
        }

        private void btnPrvPgMsg_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.btnPrvPgMsg, "Предыдущая страница");
        }

        #endregion

        #region отправка сообщения
        /// <summary>
        /// отправка сообщения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (txtNewMessage.Text.Trim() != "")
            {
                string ans = String.Empty;

                ans = clsUpdate.sendMess(txtNewMessage.Text);

                if (ans.Trim() != String.Empty)
                {
                    #region обработка ответа
                    string text = ans;
                    List<clsJSON> jsons = null;
                    jsons = clsJSON.parceMessage(text);

                    if (jsons == null || jsons.Count == 0) { return; }

                    foreach (clsJSON json in jsons)
                    {
                        #region проверка на ошибку
                        if (json.bloks != null)
                        {
                            clsJSON_block block = json.bloks.FirstOrDefault(b => b.name.ToLower().CompareTo("error") == 0);
                            if (block != null) continue;
                        }
                        #endregion

                        clsMessDialog msg = new clsMessDialog(json);

                        int w = scrollMessDialog.Width - 25 - 95;
                        cntrlMessDialog cf = new cntrlMessDialog(msg, w);
                        lstMessDialog.Add(cf);

                        cf.Dock = DockStyle.Top;

                        try
                        {
                            scrollMessDialog.BeginInvoke(new Action(() =>
                            {
                                cf.Parent = scrollMessDialog;
                                cf.BringToFront();
                            }));
                        }
                        catch (Exception) { }
                    }
                    #endregion
                }
                else return;

                scrollMessDialog.Focus();
                txtNewMessage.Text = "";
            } 


        }

        private void txtNewMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '{' || e.KeyChar == '}' || e.KeyChar == '<' || e.KeyChar == '>')
            { e.Handled = true; }
            else if (e.KeyChar == 13) {
                if (panel23.Height < panel23.MaximumSize.Height)
                { panel23.Height += 18; }
            }
            if (e.KeyChar == 10)
            {
                btnSendMessage.PerformClick();
                e.Handled = true; 
            }

        }
        #endregion

        #region спиннер загрузки

        int pos = 1;

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            if (pos == 1)
            {
                pcbLoadOrange.Image = Properties.Resources.load_gray_2;
                //pcbLoadOrange.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pos = 2;
            }
            else if (pos == 2)
            {
                pcbLoadOrange.Image = Properties.Resources.load_gray_3;
                //pcbLoadOrange.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                pos = 3;
            }
            else if (pos == 3)
            {
                pcbLoadOrange.Image = Properties.Resources.load_gray_4;
                //pcbLoadOrange.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pos = 4;
            }
            else if (pos == 4)
            {
                pcbLoadOrange.Image = Properties.Resources.load_gray_1;
                //pcbLoadOrange.Image.RotateFlip(RotateFlipType.RotateNoneFlipNone);
                pos = 1;
            }

            


            //if (lblDots.Text == ". . . . . . . . . . .")
            //{ lblDots.Text = "."; }
            //else { lblDots.Text += " . ."; }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabLoading"] )
                { timerProgress.Start(); } 
            else 
            {
                timerProgress.Stop();
                pcbLoadOrange.Image = global::freelancehunt.Properties.Resources.load_gray_1;
                //pcbLoadOrange.Image.RotateFlip(RotateFlipType.RotateNoneFlipNone);
                pos = 1;
                //lblDots.Text = ".";
            }
        }

        private void panel25_SizeChanged(object sender, EventArgs e)
        {
            centerPcbLoad();
        }

        private void centerPcbLoad()
        {
            int px = (panel25.Width - pcbLoadOrange.Width) / 2;
            int py = (panel25.Height - pcbLoadOrange.Height) / 2;
            
            pcbLoadOrange.Location = new Point(px, py);
        }



        #endregion

        #region фильтр
        private void btnFltr_Click(object sender, EventArgs e)
        {
            if (grpSkills.Visible) { 
                scrollSearchedProject.Visible = false;
                grpSkills.Visible = false;
                splitter1.Visible = false;
                scrollSearchedProject.Visible = true;
                btnFltr.Text = ">> Показать навыки";
            } else {
                scrollSearchedProject.Visible = false;
                grpSkills.Visible = true;
                splitter1.Visible = true;
                scrollSearchedProject.Visible = true;
                btnFltr.Text = "<< Скрыть навыки";
            }
        }
        
        private void btnFltr_MouseHover(object sender, EventArgs e)
        { }

        private void btnFilter_Click(object sender, EventArgs e)
        {

            tabControl1.SelectedTab = tabControl1.TabPages["tabSearchProj"];
            scrollSearchedProject.Focus();
            //if (grpSkills.Visible == false) 
            //{
            //        grpSkills.Visible = true;
            //        splitter1.Visible = true;
            //        btnFltr.Text = "<< Скрыть навыки";
            //}
        }

        private void lstSkill_ItemCheck_1(object sender, ItemCheckEventArgs e)
        {
            //btnSaveSkills.Enabled = true;
            //btnOpenSkill.Enabled = true;
            //btnSaveSkills.Visible = true;
            //btnOpenSkill.Visible = true;

            mnuSkills_Save.Enabled = mnuSkills_Cancel.Enabled = true;
            
            is_Skills_saved = false;
        }

        private void btnFilterOnOff_Click(object sender, EventArgs e)
        {
            if (clsConfig.ShowInterestProjOnly)
            {
                clsConfig.ShowInterestProjOnly = false;
                clsConfig.NotifyInterestProjOnly = false;
                //toolStripButton6.Visible = true;
                clsConfig.saveConfig();
                btnFilterOnOff.Text = "Включить";
            }
            else
            {
                clsConfig.ShowInterestProjOnly = true;
                clsConfig.NotifyInterestProjOnly = true;
                //toolStripButton6.Visible = false;
                clsConfig.saveConfig();
                btnFilterOnOff.Text = "Отключить";
            }
        }
        #endregion

        #region автопрокрутка диалора вниз
        private void scrollMessDialog_SizeChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabDialog"])
            {
                scrollMessDialog.VerticalScroll.Value = scrollMessDialog.VerticalScroll.Maximum;
                scrollMessDialog.VerticalScroll.Value = scrollMessDialog.VerticalScroll.Maximum;
            }
        }

        private void scrollMessDialog_ControlAdded(object sender, ControlEventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabDialog"])
            {
                scrollMessDialog.VerticalScroll.Value = scrollMessDialog.VerticalScroll.Maximum;
                scrollMessDialog.VerticalScroll.Value = scrollMessDialog.VerticalScroll.Maximum;
            }
        }
        #endregion
        
        private void label5_Click(object sender, EventArgs e)
        {
            scrollProjects.Visible = true;
        }
        private void btnToolStrip2_MouseEnter(object sender, EventArgs e)
        { }
        private void btnToolStrip2_MouseLeave(object sender, EventArgs e)
        { }







        

        




    }
}