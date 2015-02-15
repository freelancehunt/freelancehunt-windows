using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;


namespace freelancehunt
{
    public partial class cntrlMessDialog : UserControl
    {
        public clsMessDialog mess = null;
        
        int imgDownloadTryCount = 0;
        
        void downLoadImage()
        {
            try
            {
                Image img = Properties.Resources.freelancehunt;

                using (WebClient wClient = new WebClient())
                {
                    Uri uri = new Uri(this.mess.from.avatar);

                    byte[] imageByte = wClient.DownloadData(uri);
                    using (MemoryStream ms = new MemoryStream(imageByte, 0, imageByte.Length))
                    {
                        ms.Write(imageByte, 0, imageByte.Length);
                        img = Image.FromStream(ms, true);
                    }
                }

                pictureBox1.BeginInvoke(new Action(() =>
                {
                    pictureBox1.Image = img;
                }));
            }
            catch (Exception) {
                try
                {
                    imgDownloadTryCount++;

                    if (imgDownloadTryCount < 15)
                    {
                        Thread.Sleep(250);

                        Thread th = new Thread(downLoadImage);
                        th.Start();

                        return;
                    }

                    pictureBox1.BeginInvoke(new Action(() =>
                    {
                        pictureBox1.Image = Properties.Resources.DefaultAva;
                    }));
                }
                catch (Exception) { }
            }
        }

        public string message_rtb;
        public string message_lbl;
        public cntrlMessDialog(clsMessDialog mess,int w)
        {
            InitializeComponent();
            
            this.mess = mess;

            if (this.mess.message_html.Contains("<br />n")) 
                 { message_rtb = clsHTMLtoRTF.ConvertHtmlToText(this.mess.message_html.Replace("<br />n", "<br />")); }
            else { message_rtb = clsHTMLtoRTF.ConvertHtmlToText(this.mess.message_html); }
            
            message_lbl = insN(w, message_rtb);
            
            Thread th = new Thread(downLoadImage);
            th.Start();
        }

        private string insN(int w, string ms) 
        {
            string retStr = "";
            string n = " \n";
            foreach (string line in ms.Split('\n'))
            {
                int cnt = line.Length / (w / 7);
                string ln = "";
                string lin = line;
                if (cnt > 0)
                {
                    for (int i = 0; i < cnt; i++)
                    {
                        int q;
                        q = w / 7 + ((w / 7) * i);
                        ln = lin.Insert(q, n);
                        lin = ln;
                    }
                }
                retStr += ln + "\n";
            }
            return retStr;
        }


        //bool quote = false;

        private void cntrlMessDialog_Load(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(this.mess.from.fname) || !String.IsNullOrEmpty(this.mess.from.sname))
            { lblAutor.Text = this.mess.from.fname + " " + this.mess.from.sname; }
            else { lblAutor.Text = this.mess.from.login; }

            lblTime.Text = this.mess.post_time.ToLongDateString() + " " + this.mess.post_time.ToShortTimeString();
            label1.Text = message_lbl;
            richTextBox1.Text = message_rtb;

            #region цитата
            if (richTextBox1.Text.Contains("|blockquote|") && richTextBox1.Text.Contains("|/blockquote|"))
            {
                System.Drawing.Font currentFont = richTextBox1.Font;
                System.Drawing.FontStyle newFontStyle = FontStyle.Italic;
                //string[] lines = richTextBox1.Text.Split("\n");

               

                while (richTextBox1.Text.Contains("|blockquote|") && richTextBox1.Text.Contains("|/blockquote|"))
                {
                    try
                    {
                            int a, b = 0;
                            if (richTextBox1.Text.TrimStart().StartsWith("|blockquote|"))
                            {
                                a = richTextBox1.Text.IndexOf("|blockquote|") - 3;
                                b = richTextBox1.Text.IndexOf("|/blockquote|") - richTextBox1.Text.IndexOf("|blockquote|") - 9;
                            }
                            else
                            {
                                a = richTextBox1.Text.IndexOf("|blockquote|");
                                b = richTextBox1.Text.IndexOf("|/blockquote|") - richTextBox1.Text.IndexOf("|blockquote|") - 12;
                            }

                            richTextBox1.Text = richTextBox1.Text.Replace("|blockquote|", "").Replace("|/blockquote|", "");

                            richTextBox1.Select(a, b);
                            richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                            richTextBox1.SelectionBackColor = Color.GhostWhite;
                            richTextBox1.DeselectAll();
                    }
                    catch (Exception)//exquote
                    {
                        //MessageBox.Show("цитата \n-\n" + exquote.Message + "\n-\n" + exquote.Source + "\n-\n" + exquote.InnerException);
                        continue;
                    }
                
                }


            }
            #endregion
            
            #region Login
            if (clsUpdate.fromLogin != this.mess.from.login) {
                pnlAvatar.Dock = DockStyle.Right;
                //lblAutor.Dock  = DockStyle.Right;
                //lblTime.Dock   = DockStyle.Left;
            }
            #endregion

            #region приложения
            if (mess.url_Attachments != null && mess.url_Attachments.Count > 0)
            {
                for (int v = 0; v < mess.url_Attachments.Count(); v++)
                {
                    try
                    {
                        string s = mess.url_Attachments[v];
                        cntrlTagtext cntrlTagtext = new cntrlTagtext(s);
                        cntrlTagtext.Parent = (Control)this.pnlAttach;
                        cntrlTagtext.Dock = DockStyle.Right;
                    }
                    catch (Exception) //exAp
                    {
                        //MessageBox.Show("приложения \n-\n" + exAp.Message + "\n-\n" + exAp.Source + "\n-\n" + exAp.InnerException);
                        continue;
                    }


                }
            }
            else { 
                //pnlAttach.AutoSize = true;
                //pnlAttach.BackColor = Color.BurlyWood;
                //pnlAttach.Visible = false;
            }
            #endregion          

        }

        private void cntrlMessDialog_Paint(object sender, PaintEventArgs e)
        {
            

            //Size size = this.panel2.Size;

            //size.Height -= 4;
            //size.Width -= 4;

            //Size size1 = this.pictureBox1.Size;

            //size1.Height += 16;
            //size1.Width += 16;

            //LinearGradientBrush linGrBrush = new LinearGradientBrush(
            //                                 new Point(0, 0),
            //                                 new Point(0, size.Height),
            //                                 clsColors.lnrColorTop,
            //                                 clsColors.lnrColorBottom);


            #region круглая картинка

            //GraphicsPath path = new GraphicsPath();
            //path.AddEllipse(-1, -1, pictureBox1.Width + 1, pictureBox1.Height + 1);
            //Region rgn = new Region(path);
            //pictureBox1.Region = rgn;
            //pictureBox1.BackColor = Color.Transparent;

            #endregion

            #region круглая окантовка вокруг картинки

            //GraphicsPath path1 = new GraphicsPath();
            //path1.AddEllipse(pictureBox1.Location.X - 4 + pnlAvatar.Location.X, pictureBox1.Location.Y - 4 + pnlAvatar.Location.Y, pictureBox1.Width + 7, pictureBox1.Height + 7);

            //Rectangle rectP = new Rectangle(new Point(pnlAvatar.Location.X + 1, pnlAvatar.Location.Y + 1), size1);
            //rectP.Height--;
            //rectP.Width--;
            //GraphicsPath path1 = clsColors.GetBarShape(rectP, 5);
            
            //e.Graphics.DrawPath(clsColors.borderPen, path1);

            #endregion
            
            #region окантовка

            //Rectangle rect = new Rectangle(new Point(panel2.Location.X + 1, panel2.Location.Y + 1), size);
            //rect.Height--;
            //rect.Width--;
            //GraphicsPath gp = clsColors.GetBarShape(rect, 5);
            //e.Graphics.DrawPath(clsColors.borderPen, gp);
            //e.Graphics.DrawRectangle(clsColors.borderPen, rect);

            #endregion

        }

        private void lblAutor_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.mess.from.url))
            {
                System.Diagnostics.Process.Start(this.mess.from.url);
            }
        }



        private void richTextBox1_Click(object sender, EventArgs e)
        {
           //richTextBox1.Visible = false;
           //label1.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //richTextBox1.Visible = true;
            //label1.Visible = false;
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void cntrlMessDialog_SizeChanged(object sender, EventArgs e)
        {
            int w = this.Size.Width - 20 - 95;
            message_lbl = insN(w, message_rtb);
            label1.Text = message_lbl;
        }

        private void cntrlMessDialog_Enter(object sender, EventArgs e)
        {
            //this.Parent.Focus();
        }

        private void richTextBox1_MouseWheel(object sender, EventArgs e)
        {this.Parent.Focus();}

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.mess.from.url))
            {
                System.Diagnostics.Process.Start(this.mess.from.url);
            }
        }

    }
}
