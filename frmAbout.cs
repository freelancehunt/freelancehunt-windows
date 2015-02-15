using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing.Drawing2D;

namespace freelancehunt
{
    public partial class frmAbout : Form
    {
        Color lnrColorTop = Color.LightGray;

        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            lblMe.ForeColor =
            lblInfo.ForeColor =
            lblVersion.ForeColor = Color.FromArgb(255, 79, 115, 175);
            lblVersion.Text += Assembly.GetExecutingAssembly().GetName().Version.ToString();
/*
            try
            {
                pictureBox2.ImageLocation = "http://wf.mail.ru/custom/ub/41ac1ded4b66acce/e89e99ab3694b98be95ff5d5b7bd4abc/bar.jpg";
            }
            catch (Exception)
            {
                pictureBox2.Image = (Image)Properties.Resources.bar;
            }*/
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            
        }

        private void frmAbout_Paint(object sender, PaintEventArgs e)
        {
            Size size = this.Size;
            size.Height = 60;

            LinearGradientBrush linGrBrush = new LinearGradientBrush(
                                             new Point(0, 0),
                                             new Point(0, size.Height),
                                             lnrColorTop,
                                             clsColors.lnrColorBottom);

            Rectangle rect = new Rectangle(new Point(0, 0), size);

            e.Graphics.FillRectangle(linGrBrush, rect);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://freelancehunt.com/");
        }
    }
}
