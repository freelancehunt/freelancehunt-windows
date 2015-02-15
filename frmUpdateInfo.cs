using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace freelancehunt
{
    public partial class frmUpdateInfo : Form
    {
        StringFormat textFormat = new StringFormat();

        public delegate void evCloseHandler(frmUpdateInfo sender);
        public event evCloseHandler evClose;

        public int cntMsg = 0;
        public int cntPrj = 0;
        public int cntFeed = 0;

        Form prnt = null;
        TabControl tc = null;

        Dictionary<cntrlNewAction, DateTime> dicAllLabel = new Dictionary<cntrlNewAction, DateTime>();

        void RefreshLebel()
        {
            /*int i = 0;

            while (i < dicAllLabel.Count)
            {
                if (dicAllLabel.ElementAt(i).Value < DateTime.Now)
                {
                    this.Controls.Remove(dicAllLabel.ElementAt(i).Key);
                    dicAllLabel.Remove(dicAllLabel.ElementAt(i).Key);
                }
                else
                    i++;
            }*/

            if ( cntMsg == 0 && cntPrj == 0 && cntFeed == 0)//dicAllLabel.Count == 0 &&
                this.Hide();
            else 
                //setSize(dicAllLabel.ElementAt(0).Key.Height);
                setSize();
        }

        void setSize(int unitHeight)
        {
            if (cntMsg == 0 && cntPrj == 0 && cntFeed == 0) {this.Hide();}
            else
            {
                this.BeginInvoke(new Action(() =>
                    {
                        this.Height = 25 + dicAllLabel.Count * unitHeight;

                        Rectangle rect = Screen.PrimaryScreen.WorkingArea;

                        this.Left = rect.Width - this.Width;
                        this.Top = rect.Height - this.Height;

                        this.Show();
                    }));
            }
        }
        //********************************
        void setSize()
        {
            if (cntMsg == 0 && cntPrj == 0 && cntFeed == 0) { this.BeginInvoke(new Action(() => { this.Hide(); })); }
            else
            {
                this.BeginInvoke(new Action(() =>
                {
                    Rectangle rect = Screen.PrimaryScreen.WorkingArea;

                    this.Left = rect.Width - this.Width;
                    this.Top = rect.Height - this.Height;
                    if (clsConfig.AutoHideUpdateWindow)
                    {
                        st = 1;
                        showTime = clsConfig.HideUpdateWindowTime;
                        timer1.Start();
                    }
                    
                    this.Show();

                }));
            }
        }
        //********************************

        public frmUpdateInfo()
        {
            InitializeComponent();
        }

        private void pcbClose_Click(object sender, EventArgs e)
        {
            if (evClose != null)
                evClose(this);

            //Hide();
            dicAllLabel.Clear();
            cntMsg = 0;
            cntPrj = 0;
            cntFeed = 0;
            RefreshLebel();
           
            timer1.Stop(); 
            st = 1;
            //this.Hide();
        }

        private void playSound(string path)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = path;
            player.Load();
            player.Play();
        }

        public void addMessage(string text, Form frm, TabControl f1tc)
        {
            prnt = frm;
            tc = f1tc;
            if (text.StartsWith("Новый пост в ленте от"))
            {
                cntFeed++;
                this.BeginInvoke(new Action(() =>
                {
                    //btnFeed.Text = "Лента+" + cntFeed.ToString();
                    label4.Text = cntFeed.ToString();
                }));
            }
            else if (text.StartsWith("Новый проект "))
            {
                string t2 = text.Split(' ')[2];
                string exMsg = "";
                int d2 = 0;
                try { d2 = Convert.ToInt16(t2); }
                catch (Exception ex) { exMsg = ex.ToString(); }
                if (exMsg == "")
                {
                    cntPrj += d2;
                    this.BeginInvoke(new Action(() => { label3.Text = cntPrj.ToString(); }));
                    

                }
            }
            else if (text.StartsWith("Новое сообщение "))
            {
                string t2 = text.Split(' ')[2];
                string exMsg = "";
                int d2 = 0;
                try { d2 = Convert.ToInt16(t2); }
                catch (Exception ex) { exMsg = ex.ToString(); }
                if (exMsg == "")
                {
                    cntMsg = d2;
                    this.BeginInvoke(new Action(() => { label2.Text = cntMsg.ToString(); }));
                }
            }
            else return;

            if (cntMsg < 1) { this.BeginInvoke(new Action(() => { label2.Visible = false; })); }
            else { this.BeginInvoke(new Action(() => { label2.Visible = true; } )); }

            if (cntPrj < 1) { this.BeginInvoke(new Action(() => { label3.Visible = false; })); }
            else { this.BeginInvoke(new Action(() => { label3.Visible = true; })); }

            if (cntFeed < 1) { this.BeginInvoke(new Action(() => { label4.Visible = false; })); }
            else { this.BeginInvoke(new Action(() => { label4.Visible = true; })); }

            st = 1;
            showTime = clsConfig.HideUpdateWindowTime;
            if (cntMsg > 0 || cntPrj > 0 || cntFeed > 0)
            {
                setSize();
            }
            
            //setSize(_new.Height);
            /*this.BeginInvoke(new Action(() => 
                {
                    this.Show();
                }));*/
/*
            cntrlNewAction _new = new cntrlNewAction();
            _new.pcbImage.Image = img;
            _new.lblTime.Text = DateTime.Now.ToShortTimeString();
            _new.lblMessage.Text = text;
            _new.Dock = DockStyle.Bottom;
            _new.BackColor = Color.White;
            _new.lblTime.ForeColor = clsColors.textColor;
            _new.lblMessage.ForeColor = clsColors.textColor;

            this.BeginInvoke(new Action(() =>
                {
                    _new.Parent = this;

                    dicAllLabel.Add(_new, DateTime.Now.AddMinutes(2));

                    
                })); */
        }

        void lbl_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            
            path.AddEllipse(0, 0, label2.Width - 1, label2.Height - 1);
            Region rgn = new Region(path);
            label2.Region = rgn;
            label2.BackColor = Color.Transparent;
            label3.Region = rgn;
            label3.BackColor = Color.Transparent;
            label4.Region = rgn;
            label4.BackColor = Color.Transparent;
        }


        private int showTime = clsConfig.HideUpdateWindowTime;
        private int st = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (st >= showTime)
            {
                if (evClose != null) 
                    evClose(this);
                this.Hide();
                dicAllLabel.Clear();
                //st = 1;
                timer1.Stop();
                //RefreshLebel();
            } else {
                st++;
                //RefreshLebel();
            }

        }

        private void btnMsg_Click(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                prnt.Show();
                prnt.WindowState = FormWindowState.Maximized;
                tc.SelectedTab = tc.TabPages["tabMessages"];
                prnt.TopMost = true;
                prnt.TopMost = false;
            }));
            cntMsg = 0;
            label2.Text = cntMsg.ToString();
            label2.Visible = false;
            if (cntMsg == 0 && cntPrj == 0 && cntFeed == 0)
            {
                //pcbClose.PerformClick();
                if (evClose != null) evClose(this);
                this.Hide();
                dicAllLabel.Clear();
                //RefreshLebel();
                timer1.Stop();
            }

        }

        private void btnProj_Click(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                prnt.Show();
                prnt.WindowState = FormWindowState.Maximized;
                if (clsConfig.NotifyInterestProjOnly) 
                     { tc.SelectedTab = tc.TabPages["tabSearchProj"]; } 
                else { 
                    tc.SelectedTab = tc.TabPages["tabProjects"];
                    Control[] sp = tc.Controls.Find("scrollProjects", true);
                    if (sp.Length > 0) { sp.FirstOrDefault().Visible = true; }
                }
                prnt.TopMost = true;
                prnt.TopMost = false;
            }));
            cntPrj = 0;
            label3.Text = cntPrj.ToString();
            label3.Visible = false;
            if (cntMsg == 0 && cntPrj == 0 && cntFeed == 0)
            {
                this.Hide();
                if (evClose != null) evClose(this);
                dicAllLabel.Clear();
                //RefreshLebel();
                timer1.Stop();
            }
        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                prnt.Show();
                prnt.WindowState = FormWindowState.Maximized;
                tc.SelectedTab = tc.TabPages["tabFeeds"];
                prnt.TopMost = true;
                prnt.TopMost = false;
            }));
            cntFeed = 0;
            label4.Text = cntFeed.ToString();
            label4.Visible = false;
            if (cntMsg == 0 && cntPrj == 0 && cntFeed == 0)
            {
                this.Hide();
                if (evClose != null) evClose(this);
                dicAllLabel.Clear();
                //RefreshLebel();
                timer1.Stop();
            }
        }
    }
}
