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

namespace freelancehunt
{
    public partial class cntrlMessageInfo : UserControl
    {
        public clsMessage message = null;

        void downLoadImage()
        {
            try
            {
                Image img = Properties.Resources.freelancehunt;

                using (WebClient wClient = new WebClient())
                {
                    Uri uri = new Uri(this.message.from.avatar);

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
            catch (Exception) { }
        }

        private string subjectN = "";
        public cntrlMessageInfo(clsMessage message, int w )
        {
            InitializeComponent();
            this.message = message;

            Thread th = new Thread(downLoadImage);
            th.Start();

            subjectN = insN(w, this.message.subject);
        }

        private string insN(int w, string ms)
        {
            string retStr = "";
            string n = "\n";
            foreach (string line in ms.Split('\n'))
            {
                if (w < 7) {
                    w = Screen.PrimaryScreen.WorkingArea.Width - 170 - 400;
                }

                int cnt = line.Length / (w / 9) + 1;
                string ln = "";
                string l = "";
                string lin = line;
                if (cnt > 0)
                {
                    for (int i = 0; i < cnt; i++)
                    {
                        int q;
                        q = w / 7 + ((w / 7) * i);

                        if (lin.Length < q) { ln = lin; }
                        else
                        {
                            l = lin.Substring(0, q);
                            ln = lin.Insert(l.LastIndexOf(" ") + 1, n);
                        }

                        lin = ln;
                    }
                }
                retStr += ln; //+ "\n";
            }
            return retStr;
        }

        private void cntrlMessageInfo_Load(object sender, EventArgs e)
        {
            lblAutor.Text = this.message.from.fname + " " + this.message.from.sname;
            lblAutorL.Text = this.message.from.login;

            if (!String.IsNullOrEmpty(this.message.subject))
            { lblSubject.Text = subjectN; }// + this.message.subject
            //richTextBox1.Text = this.message.subject;

            lblTime.Text = this.message.last_post_time.ToLongDateString() + " " + this.message.last_post_time.ToShortTimeString();
            lblTime.Text = lblTime.Text.Insert(lblTime.Text.Length - 5, "\n");

            if (this.message.attachCount > 0) { pcbAttach.Visible = true; }
            else { pcbAttach.Visible = false; }

            if (this.message.unread_count > 0 || this.message.is_unread) 
            { 
                pcbNewMail.Image = Properties.Resources.mail; 
            }
            else 
            { 
                pcbNewMail.Image = Properties.Resources.mail_open; 
            }

        }


        private void lblAutor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.message.from.url))
            { System.Diagnostics.Process.Start(this.message.from.url); }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.message.from.url))
            { System.Diagnostics.Process.Start(this.message.from.url); }
        }
        
        private void pcbGo_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.message.url))
            { System.Diagnostics.Process.Start(this.message.url); }
        }

        private void cntrlMessageInfo_Paint(object sender, PaintEventArgs e)
        {
            if (this.message.unread_count > 0 || this.message.is_unread)
            {
                Size size = this.Size;

                size.Height -= 3;
                size.Width -= 3;

                Rectangle rect = new Rectangle(new Point(2, 2), size);

                //e.Graphics.FillRectangle(linGrBrush, rect);
                                
                //rect.Height--;
                //rect.Width--;
            
                //e.Graphics.DrawRectangle(clsColors.borderPen, rect);
                //GraphicsPath gp = rect;
                            
                e.Graphics.DrawRectangle(clsColors.borderPenFeatured, rect);

                //e.Graphics.FillPath(linGrBrush, gp);
            }
        }

        private void lblSubject_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.message.url_api) && !String.IsNullOrEmpty(this.message.from.login))
            {
                lblSubject.Cursor = Cursors.WaitCursor;
                this.Cursor       = Cursors.WaitCursor;
                pcbNewMail.Cursor = Cursors.WaitCursor;
                clsUpdate.thrdUri = this.message.url_api;
                clsUpdate.thrdUriToSend = this.message.url_api;
                clsUpdate.fromLogin = this.message.from.login;
                clsUpdate.Pause = false;

                pcbNewMail.Image = Properties.Resources.mail_open;
                this.message.is_unread = false;

                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSubject.Cursor = Cursors.Hand;
            this.Cursor = Cursors.Default;
            pcbNewMail.Cursor = Cursors.Hand;
            timer1.Stop();
        }

        private void pcbNewMail_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            if (this.message.unread_count > 0 || this.message.is_unread)
            {
                tt.SetToolTip(this.pcbNewMail, "Есть непрочитанные сообщения");
            } else {
                tt.SetToolTip(this.pcbNewMail, "Новых сообщений нет");
            }
        }

        private void pcbAttach_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pcbAttach, "Есть вложения");
        }

        private void lblSubject_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.lblSubject, "Читать сообщения");
        }

        private void cntrlMessageInfo_SizeChanged(object sender, EventArgs e)
        {
            int w = this.Size.Width - this.panel1.Width - this.panel4.Width - 60 - 30;
            subjectN = insN(w, this.message.subject);
            lblSubject.Text = subjectN;
        }



    }
}
