using freelancehunt.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace freelancehunt
{
    public partial class cntrlProject : UserControl
    {
        public clsProject project = (clsProject)null;
        private int imgDownloadTryCount = 0;

        public cntrlProject(clsProject project)
        {
            InitializeComponent();
            this.project = project;
            this.lblAutor.Text = project.from.login;
            

            this.lblTime.Text = "";// +
            this.lblName.Text = project.name;
            
            /*"budget_amount":"10",
            "budget_currency_code":"EUR",*/

            if (project.budget_amount != null || project.budget_amount != "") 
            { 
                this.lblBudget.Text = project.budget_amount;
                if (project.budget_currency_code != null || project.budget_currency_code != "") 
                {
                    if      (project.budget_currency_code == "EUR") { this.lblBudget.Text += " €"; }
                    else if (project.budget_currency_code == "USD") { this.lblBudget.Text += " $"; }
                    else if (project.budget_currency_code == "UAH") { this.lblBudget.Text += " ₴"; }
                    else if (project.budget_currency_code == "RUB") { this.lblBudget.Text += " ₽"; }
                    else this.lblBudget.Text += project.budget_currency_code;
                }
            }
            else {
                this.lblBudget.Text = "";
                this.lblBudget.Visible = false;
                //this.lblBudget.Width = 1;
            }
            //if (lblBudget.Text == "")
            //{
            //    int yy = (panel2.Height - pcbAvatar.Height) / 2;
            //    int xx = pcbAvatar.Location.X;
            //    pcbAvatar.Location = new Point(xx,yy);
            //}

            //this.lblState.Text = project.status_name;
            //this.lblNumber.Text = "#" + project.id.ToString();
            //this.pcbIsFeatured.Image = project.is_featured ? (Image)Resources.prj_is_featured : (Image)Resources.prj_is_featured_gray;
            //this.pcbIsIdentityVerified.Image = project.is_identity_verified ? (Image)Resources.prj_is_identity_verified : (Image)Resources.prj_is_identity_verified_gray;
            //this.pcbIsJob.Image = project.is_job ? (Image)Resources.prj_is_job : (Image)Resources.prj_is_job_gray;
            //this.lblDescription.Text += project.publication_time;

            if (project.is_featured) {
                
                //this.Height += this.pcbAvatar.Width - this.pcbAvatar.Height;
                //this.pcbAvatar.Height = this.pcbAvatar.Width;
            }

            #region ставки
            this.lblBidCount.Text = project.bid_count.ToString();
            if (project.bid_count == 1 || project.bid_count == 21 || project.bid_count == 31 || project.bid_count == 41 || project.bid_count == 51 || project.bid_count == 61 || project.bid_count == 71 || project.bid_count == 81 || project.bid_count == 91 || project.bid_count == 101) { this.lblBidCount.Text += " ставка  "; }
            else if (project.bid_count >= 2 && project.bid_count <= 4 || project.bid_count >= 22 && project.bid_count <= 24 || project.bid_count >= 32 && project.bid_count <= 34 || project.bid_count >= 42 && project.bid_count <= 44 || project.bid_count >= 52 && project.bid_count <= 54 || project.bid_count >= 62 && project.bid_count <= 64 || project.bid_count >= 72 && project.bid_count <= 74 || project.bid_count >= 82 && project.bid_count <= 84 || project.bid_count >= 92 && project.bid_count <= 94) { this.lblBidCount.Text += " ставки  "; }
            else this.lblBidCount.Text += " ставок  ";
            #endregion

            #region время
            if (project.publication_time != null || project.publication_time != "")
            {
                DateTime DT;
                try { DT = DateTime.Parse(project.publication_time); }
                catch (Exception)
                {
                    this.lblTime.Text = " ";
                    new Thread(new ThreadStart(this.downLoadImage)).Start();
                    return;
                }

                TimeSpan dtn = DateTime.Now - DT;

                
                if (dtn.Days == 0) { this.lblTime.Text += ""; }
                else if (dtn.Days == 1) { this.lblTime.Text += "1 день "; }
                else if (dtn.Days >= 2 && dtn.Days <= 4) { this.lblTime.Text += dtn.Days + " дня "; }
                else if (dtn.Days >= 5 && dtn.Days <= 20) { this.lblTime.Text += dtn.Days + " дней "; }
                else
                {
                    this.lblTime.Text += " более 21-го дня назад ";
                    new Thread(new ThreadStart(this.downLoadImage)).Start();
                    return;
                }

                if (dtn.Hours == 0) { this.lblTime.Text += ""; }
                else if (dtn.Hours == 1 || dtn.Hours == 21) { this.lblTime.Text += dtn.Hours + " час "; }
                else if (dtn.Hours >= 2 && dtn.Hours <= 4 || dtn.Hours >= 22 && dtn.Hours <= 24) { this.lblTime.Text += dtn.Hours + " часа "; }
                else if (dtn.Hours >= 5 && dtn.Hours <= 20) { this.lblTime.Text += dtn.Hours + " часов "; }
                
                if (dtn.Minutes == 0) { this.lblTime.Text += "назад  "; }
                else if (dtn.Minutes == 1 || dtn.Minutes == 21 || dtn.Minutes == 31 || dtn.Minutes == 41 || dtn.Minutes == 51) { this.lblTime.Text += dtn.Minutes + " минуту назад  "; }
                else if (dtn.Minutes >= 2 && dtn.Minutes <= 4 || dtn.Minutes >= 22 && dtn.Minutes <= 24 || dtn.Minutes >= 32 && dtn.Minutes <= 34 || dtn.Minutes >= 42 && dtn.Minutes <= 44 || dtn.Minutes >= 52 && dtn.Minutes <= 54) { this.lblTime.Text += dtn.Minutes + " минуты назад  "; }
                else this.lblTime.Text += dtn.Minutes + " минут назад  ";
            }
            if (this.lblTime.Text.Trim() == "назад") { this.lblTime.Text = "только что"; }
            #endregion
            
            new Thread(new ThreadStart(this.downLoadImage)).Start();

            #region skills
            lblCategories.Text = "";
            if (this.project.skills != null)
            {
                foreach (KeyValuePair<int, string> keyValuePair in this.project.skills)
                { lblCategories.Text += keyValuePair.Value + ", "; }
            }
            if (lblCategories.Text.EndsWith(", "))
            {
                lblCategories.Text = lblCategories.Text.Substring(0, lblCategories.Text.Length - 2);
            }
            #endregion

            #region skills
           /* if (project.skills != null)
            {
                foreach (KeyValuePair<int, string> keyValuePair in project.skills)
                {
                    cntrlTagtext cntrlTagtext = new cntrlTagtext(keyValuePair.Value);
                    cntrlTagtext.Dock = DockStyle.Left;
                    cntrlTagtext.Parent = (Control)this.pnlSkills;
                }
            }*/
            #endregion
        }

        private void downLoadImage()
        {
            try
            {
                Image img = (Image)Resources.freelancehunt;
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
                this.pcbAvatar.BeginInvoke(new Action(() => this.pcbAvatar.Image = img));
            } catch (Exception) {
                try
                {
                    ++this.imgDownloadTryCount;
                    if (this.imgDownloadTryCount < 15)
                    {
                        Thread.Sleep(300);
                        new Thread(new ThreadStart(this.downLoadImage)).Start();
                    }
                    else
                        this.pcbAvatar.BeginInvoke(new Action(() => this.pcbAvatar.Image = (Image)Resources.DefaultAva));
                } catch (Exception) { }
            }
        }

        private void cntrlProject_Paint(object sender, PaintEventArgs e)
        {
            //Size size = this.Size;
            //size.Height -= 1;
            //size.Width -= 1;

            //LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Point(0, 0),
            //                                                                  new Point(0, size.Height),
            //                                                                  Color.White,
            //                                                                  Color.White);
            //Rectangle rect = new Rectangle(new Point(1, 1), size);
            
            //#region окантовка
            //e.Graphics.FillRectangle((Brush)linearGradientBrush, rect);
            //--rect.Height;
            //--rect.Width;
            //GraphicsPath gp = clsColors.GetBarShape(rect, 5);//size.Height / 5
            

            //if (project.is_featured) 
            //{ 
            //    e.Graphics.DrawRectangle(clsColors.borderPenFeaturedB, rect); 
            //}
            //else 
            //{
            //***************************************************
            //e.Graphics.DrawRectangle(clsColors.borderPenB, rect); 
            //***************************************************
            //}
            

            //e.Graphics.FillRectangle(linearGradientBrush, rect);
            

            //e.Graphics.DrawRectangle(clsColors.borderPen, rect);
            //#endregion

            //#region круглая картинка

            /////////////////////
            /*
            Rectangle r = new Rectangle(0, 0, pcbAvatar.Width -1, pcbAvatar.Height - 1);
            System.Drawing.Drawing2D.GraphicsPath gp1 = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 5;
            gp1.AddArc(r.X, r.Y, d, d, 180, 90);
            //gp1.AddArc(r.X, r.Y, d,d,
            gp1.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp1.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp1.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            pcbAvatar.Region = new Region(gp1);
            */
            /////////////////////
            /*Size sizeA = pcbAvatar.Size;
            sizeA.Height -= 4;
            sizeA.Width -= 4;

            Rectangle rectA = new Rectangle(new Point(1, 1), sizeA);//pcbAvatar.Location
            GraphicsPath path = new GraphicsPath();
            path = clsColors.GetBarShape(rectA, 3);
            Region rgn = new Region(path);
            //e.Graphics.DrawPath(new Pen(Color.Red, 1), path);
            pcbAvatar.Region = rgn;
            pcbAvatar.BackColor = Color.Transparent;
            */
            //#endregion
        }

        /*private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.project.url))
            { Process.Start(this.project.url); }
        }*/

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.project.from.url))
            { Process.Start(this.project.from.url); } 
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.project.from.url))
            { Process.Start(this.project.from.url); } 
        }

        private void lblAutor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.project.from.url))
            { Process.Start(this.project.from.url); } 
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.project.url))
            { Process.Start(this.project.url); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            //pcbNewMail.Cursor = Cursors.Hand;
            timer1.Stop();
        }

        private void pcbShowInWondow_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            timer1.Start();

            foreach (Form form in (ReadOnlyCollectionBase)Application.OpenForms)
            {
                if (form is frmProjectFullInfo && (long)form.Tag == this.project.id)
                {
                    form.Focus();
                    return;
                }
            }
            frmProjectFullInfo frmProjectFullInfo = new frmProjectFullInfo(this.project.id, this.project.from.profile_id);
            frmProjectFullInfo.Tag = (object)this.project.id;
            ((Control)frmProjectFullInfo).Show();
        }

        private void pcbAvatar_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pcbAvatar, this.project.from.fname + " " + this.project.from.sname);
        }

        private void lblDescription_MouseHover(object sender, EventArgs e)
        {
            DateTime dt;
            try { dt = DateTime.Parse(project.publication_time); }
            catch { return; }

            if (dt != null)
            {
                ToolTip tt = new ToolTip();
                tt.SetToolTip(this.lblTime, dt.ToLongDateString() + " " + dt.ToShortTimeString());
                ToolTip tt1 = new ToolTip();
                tt1.SetToolTip(this.pictureBox1, dt.ToLongDateString() + " " + dt.ToShortTimeString());
            }
        }

        private void lblName_MouseHover(object sender, EventArgs e)
        {
            /*if (!String.IsNullOrEmpty(this.project.description))
            {
                ToolTip tt = new ToolTip();
                tt.AutoPopDelay = (this.project.description.Length / 4) * 1000;
                tt.IsBalloon = true;
                //tt.ReshowDelay = 1;
                tt.SetToolTip(this.lblName, this.project.description);
            }
            else if (!String.IsNullOrEmpty(this.project.description_text))
            {
                ToolTip tt = new ToolTip();
                tt.SetToolTip(this.lblName, this.project.description_text);
            }
            */
        }
    }
}