using freelancehunt.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace freelancehunt
{
    public partial class frmProjectFullInfo : Form
    {

        private long projectId = 0L;
        private long profileId = 0L;
        private int imgDownloadTryCount = 0;
        
        private clsProject project = (clsProject)null;
        
        public frmProjectFullInfo(long projectId, long profileId)
        {
            this.projectId = projectId;
            this.profileId = profileId;
            InitializeComponent();

        }

        
        #region перемещение формы по экрану
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void frmProjectFullInfo_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmProjectFullInfo_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmProjectFullInfo_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion
        
        private void downLoadImage()
        {
            try
            {
                Image img = (Image)Resources.DefaultAva;
                if (this.project == null)
                    return;
                using (WebClient webClient = new WebClient())
                {
                    Uri address = new Uri(this.project.from.avatar);
                    byte[] buffer = webClient.DownloadData(address);
                    using (MemoryStream memoryStream = new MemoryStream(buffer, 0, buffer.Length))
                    {
                        memoryStream.Write(buffer, 0, buffer.Length);
                        img = Image.FromStream((Stream)memoryStream, true);
                    }
                }
                this.pcbProfileAvatar.BeginInvoke(new Action(() => this.pcbProfileAvatar.Image = img));
            }
            catch (Exception)
            {
                try
                {
                    ++this.imgDownloadTryCount;
                    if (this.imgDownloadTryCount < 20)
                        new Thread(new ThreadStart(this.downLoadImage)).Start();
                }
                catch (Exception) { }
            }
        }
                
        private void frmProjectFullInfo_Load(object sender, EventArgs e)
        {
            string str = clsUpdate.getProjectFullInfo(this.projectId);

            List<clsJSON> list = clsJSON.parceProj(str);
            
            #region проверка на ошибку
            if (list == null)
                this.Close();
            else if (list.Count != 1)
                this.Close();
            else if (list[0].bloks == null)
                this.Close();
            else if (list[0].bloks.Count == 0)
                this.Close();
            else if (Enumerable.FirstOrDefault<clsJSON_block>((IEnumerable<clsJSON_block>)list[0].bloks, (Func<clsJSON_block, bool>)(b => b.name.CompareTo("from") == 0)) == null)
            { this.Close(); }
            #endregion
            
            else 
            {
                this.project = new clsProject(list[0]);
                
                this.lblName.Text = this.project.name;
                
                this.lblTime.Text = DateTime.Parse(this.project.publication_time).ToLongDateString() + " " + DateTime.Parse(this.project.publication_time).ToShortTimeString();
                this.lblDescription.Text = this.project.description.Replace("n", "\n");

                string descHtml =  this.project.description_html;

                #region убираем пустые строки в конце описани€

                while (descHtml.EndsWith("<p></p>"))
                {
                    descHtml = descHtml.Remove(descHtml.Length - 7);
                }
                while (descHtml.EndsWith("<p><br /></p>"))
                {
                    descHtml = descHtml.Remove(descHtml.Length - 13);
                }
                #endregion

                #region корректировка высоты окна

                int i = descHtml.Split(new string[] { "<p>" }, StringSplitOptions.None).Count();
                
                int ns = 0;
                foreach (char c in this.lblDescription.Text) { if (c == '\n') { ns++; } }
                ns = (ns * 7) / 10 + 1;
                i = (i * 7) / 10 + 1;
                //MessageBox.Show(i+"\n"+ns);
                while (i > 0) 
                {
                    this.lblDescription.Text += "\n ";
                    i--;
                }
                #endregion


                this.webBrowser1.DocumentText = "<font size=\"2\" face=\"Open Sans\">" + descHtml + "</font>";
                
                #region skills
                lblCategories.Text = "";
                if (this.project.skills != null)
                {
                    foreach (KeyValuePair<int, string> keyValuePair in this.project.skills) 
                    { lblCategories.Text += keyValuePair.Value + ", "; }
                }
                if (lblCategories.Text.EndsWith(", ")) {
                    lblCategories.Text = lblCategories.Text.Substring(0, lblCategories.Text.Length - 2);
                }
                #endregion

                #region ставки
                this.lblBidCount.Text = this.project.bid_count.ToString();
                if (this.project.bid_count == 1 || this.project.bid_count == 21 || this.project.bid_count == 31 || this.project.bid_count == 41 || this.project.bid_count == 51 || this.project.bid_count == 61 || this.project.bid_count == 71 || this.project.bid_count == 81 || this.project.bid_count == 91 || this.project.bid_count == 101) { this.lblBidCount.Text += " ставка  "; }
                else if (this.project.bid_count >= 2 && this.project.bid_count <= 4 || this.project.bid_count >= 22 && this.project.bid_count <= 24 || this.project.bid_count >= 32 && this.project.bid_count <= 34 || this.project.bid_count >= 42 && this.project.bid_count <= 44 || this.project.bid_count >= 52 && this.project.bid_count <= 54 || this.project.bid_count >= 62 && this.project.bid_count <= 64 || this.project.bid_count >= 72 && this.project.bid_count <= 74 || this.project.bid_count >= 82 && this.project.bid_count <= 84 || this.project.bid_count >= 92 && this.project.bid_count <= 94) { this.lblBidCount.Text += " ставки  "; }
                else this.lblBidCount.Text += " ставок  ";
                #endregion

                this.lblLogin.Text = this.project.from.fname + " " + this.project.from.sname + " (" + this.project.from.login + ")";

                this.pcbProfileAvatar.BeginInvoke(new Action(() => this.pcbProfileAvatar.Image = (Image)Resources.DefaultAva));
                this.imgDownloadTryCount = 0;
                new Thread(new ThreadStart(this.downLoadImage)).Start();

                if (this.project.is_bid_added)
                {
                    button1.BackColor = Color.LightSteelBlue;
                    button1.Cursor = Cursors.No;
                }

                if (Form1.is_customer) { button1.Visible = false; }

                this.TopMost = true;
            }
        }

        private void lblStateName_Click(object sender, EventArgs e) { }

        
        private void btnGoToProfileURL_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.project.from.url))
            { Process.Start(this.project.from.url); }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!this.project.is_bid_added)
            {
                if (!String.IsNullOrEmpty(this.project.url_api))
                {
                    frmAddBid frmNB = new frmAddBid(this.project.url_api, this.project.is_safe_project);
                    frmNB.Show();
                    frmNB.Focus();
                    frmNB.TopMost = true;
                }
            }
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.project.url))
            { Process.Start(this.project.url); }
        }

        private void frmProjectFullInfo_Shown(object sender, EventArgs e)
        {
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            if (this.Height > h) {
                this.Height = h - 4;
                this.StartPosition = FormStartPosition.Manual;
                this.CenterToScreen();
            }

        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (e.Url.AbsoluteUri != "about:blank")
            {
                if (!String.IsNullOrEmpty(e.Url.AbsoluteUri))
                { Process.Start(e.Url.AbsoluteUri); }
                e.Cancel = true;
            }

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            if (this.project.is_bid_added)
            { tt.SetToolTip(this.button1, "¬ы уже добавили ставку к этому проекту"); }
            else { tt.RemoveAll(); }
        }

        private void frmProjectFullInfo_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}

