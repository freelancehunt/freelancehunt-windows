using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace freelancehunt
{
    public partial class cntrlFeed : UserControl
    {
        public clsFeed feed = null;

        int imgDownloadTryCount = 0;

        void downLoadImage()
        {
            try
            {
                Image img = Properties.Resources.DefaultAva;

                using (WebClient wClient = new WebClient())
                {
                    Uri uri = new Uri(this.feed.from.avatar);

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
            catch (Exception) 
            {
                try
                {
                    imgDownloadTryCount++;

                    if (imgDownloadTryCount < 10)
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

        public cntrlFeed(clsFeed feed)
        {
            InitializeComponent();

            this.feed = feed;

            Thread th = new Thread(downLoadImage);
            th.Start();
        }

        private void cntrlFeed_Load(object sender, EventArgs e)
        {
            if (feed == null) return;


            if (String.IsNullOrEmpty(this.feed.from.fname) && String.IsNullOrEmpty(this.feed.from.sname))
            { lblAutor.Text = this.feed.from.login; }
            else { lblAutor.Text = this.feed.from.fname + " " + this.feed.from.sname; }

            lblMessage.Text = this.feed.justMessage;
            
            if (!String.IsNullOrEmpty(this.feed.linkVK)) { panel4.Visible = true; pcbVK.Visible = true; }
            if (!String.IsNullOrEmpty(this.feed.linkFB)) { panel4.Visible = true; pcbFB.Visible = true; }
            if (!String.IsNullOrEmpty(this.feed.linkTW)) { panel4.Visible = true; pcbTW.Visible = true; }
            if (!String.IsNullOrEmpty(this.feed.linkGP)) { panel4.Visible = true; pcbGP.Visible = true; }

            if (!String.IsNullOrEmpty(this.feed.linkBtn1)) { panel1.Visible = true; btn1.Text = this.feed.Btn1Text; btn1.Visible = true; }
            if (!String.IsNullOrEmpty(this.feed.linkBtn2)) { panel1.Visible = true; btn2.Text = this.feed.Btn2Text; btn2.Visible = true; }
            if (!String.IsNullOrEmpty(this.feed.linkBtn3)) { panel1.Visible = true; btn3.Text = this.feed.Btn3Text; btn3.Visible = true; }
            if (!String.IsNullOrEmpty(this.feed.linkBtn4)) { panel1.Visible = true; btn4.Text = this.feed.Btn3Text; btn4.Visible = true; }

        }

        private void cntrlFeed_Paint(object sender, PaintEventArgs e)
        {
            //Size size = this.Size;

            //size.Height -= 4;
            //size.Width -= 4;

            //LinearGradientBrush linGrBrush = new LinearGradientBrush(
            //                                 new Point(0, 0),
            //                                 new Point(0, size.Height),
            //                                 Color.White,
            //                                 Color.White);
            //                                 //clsColors.lnrColorTop,
            //                                 //clsColors.lnrColorBottom);

            //Rectangle rect = new Rectangle(new Point(2, 2), size);

            #region окантовка
            //rect.Height--;
            //rect.Width--;
            //e.Graphics.DrawRectangle(clsColors.borderPen, rect);
            //GraphicsPath gp = clsColors.GetBarShape(rect, 5);
            //e.Graphics.DrawRectangle(clsColors.borderPen, rect);
            //e.Graphics.FillRectangle(linGrBrush, rect);
            #endregion

            #region круглая картинка
            //GraphicsPath path = new GraphicsPath();
            //path.AddEllipse(-1, -1, pictureBox1.Width + 1, pictureBox1.Height + 1);
            //Region rgn = new Region(path);
            //pictureBox1.Region = rgn;
            //pictureBox1.BackColor = Color.Transparent;
            #endregion
        }

        private void lblAutor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.feed.from.url))
            { System.Diagnostics.Process.Start(this.feed.from.url); }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.feed.from.url))
            { System.Diagnostics.Process.Start(this.feed.from.url); }
            //clsUpdate.proFile = this.feed.from.login;
            //clsUpdate.Pause = false;
        }

        private void pcbVK_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.feed.linkVK))
            {
                System.Diagnostics.Process.Start(this.feed.linkVK);
            }
        }

        private void pcbVK_MouseHover(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.feed.linkVK))
            {
                ToolTip tt = new ToolTip();
                tt.SetToolTip(this.pcbVK, this.feed.linkVK);
            }
        }

        private void pcbFB_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.feed.linkFB))
            {
                System.Diagnostics.Process.Start(this.feed.linkFB);
            }
        }

        private void pcbFB_MouseHover(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.feed.linkFB))
            {
                ToolTip tt = new ToolTip();
                tt.SetToolTip(this.pcbFB, this.feed.linkFB);
            }
        }

        private void pcbTW_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.feed.linkTW))
            {
                System.Diagnostics.Process.Start(this.feed.linkTW);
            }
        }

        private void pcbTW_MouseHover(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.feed.linkTW))
            {
                ToolTip tt = new ToolTip();
                tt.SetToolTip(this.pcbTW, this.feed.linkTW);
            }
        }

        private void pcbGP_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.feed.linkGP))
            {
                System.Diagnostics.Process.Start(this.feed.linkGP);
            }
        }

        private void pcbGP_MouseHover(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.feed.linkGP))
            {
                ToolTip tt = new ToolTip();
                tt.SetToolTip(this.pcbTW, this.feed.linkGP);
            }
        }

        private void lblMessage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.feed.link))
            {
                System.Diagnostics.Process.Start(this.feed.link);
            }
        }

        private void lblMessage_MouseHover(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.feed.link))
            {
                ToolTip tt = new ToolTip();
                tt.SetToolTip(this.lblMessage, this.feed.link);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.feed.linkBtn1))
            {
                System.Diagnostics.Process.Start(this.feed.linkBtn1);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.feed.linkBtn2))
            {
                System.Diagnostics.Process.Start(this.feed.linkBtn2);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.feed.linkBtn3))
            {
                System.Diagnostics.Process.Start(this.feed.linkBtn3);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.feed.linkBtn4))
            {
                System.Diagnostics.Process.Start(this.feed.linkBtn4);
            }
        }

        private void btn1_MouseHover(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.feed.linkBtn1))
            {
                ToolTip tt = new ToolTip();
                tt.SetToolTip(this.btn1, this.feed.linkBtn1);
            }
        }

        private void btn2_MouseHover(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.feed.linkBtn2))
            {
                ToolTip tt = new ToolTip();
                tt.SetToolTip(this.btn2, this.feed.linkBtn2);
            }
        }

        private void btn3_MouseHover(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.feed.linkBtn3))
            {
                ToolTip tt = new ToolTip();
                tt.SetToolTip(this.btn3, this.feed.linkBtn3);
            }
        }

        private void btn4_MouseHover(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.feed.linkBtn4))
            {
                ToolTip tt = new ToolTip();
                tt.SetToolTip(this.btn4, this.feed.linkBtn4);
            }
        }

        

    }
}