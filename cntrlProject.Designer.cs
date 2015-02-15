using System.Windows.Forms;
using System.Drawing;
using System;
using freelancehunt.Properties;
namespace freelancehunt
{
    partial class cntrlProject
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pcbAvatar = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblAutor = new System.Windows.Forms.LinkLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBidCount = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlSkills = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvatar)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlSkills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pcbAvatar);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.MaximumSize = new System.Drawing.Size(76, 76);
            this.panel2.MinimumSize = new System.Drawing.Size(76, 76);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(76, 76);
            this.panel2.TabIndex = 4;
            // 
            // pcbAvatar
            // 
            this.pcbAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pcbAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbAvatar.Image = global::freelancehunt.Properties.Resources.DefaultAva;
            this.pcbAvatar.Location = new System.Drawing.Point(13, 13);
            this.pcbAvatar.Name = "pcbAvatar";
            this.pcbAvatar.Size = new System.Drawing.Size(50, 50);
            this.pcbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbAvatar.TabIndex = 0;
            this.pcbAvatar.TabStop = false;
            this.pcbAvatar.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pcbAvatar.MouseHover += new System.EventHandler(this.pcbAvatar_MouseHover);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.lblAutor);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(81, 80);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(570, 24);
            this.panel5.TabIndex = 6;
            // 
            // lblAutor
            // 
            this.lblAutor.BackColor = System.Drawing.Color.Transparent;
            this.lblAutor.Location = new System.Drawing.Point(0, 0);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(523, 24);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.TabStop = true;
            this.lblAutor.Text = "Автор";
            this.lblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAutor.Visible = false;
            this.lblAutor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAutor_LinkClicked);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Controls.Add(this.pictureBox4);
            this.panel6.Location = new System.Drawing.Point(523, 0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 6, 2, 3);
            this.panel6.Size = new System.Drawing.Size(51, 24);
            this.panel6.TabIndex = 0;
            this.panel6.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = global::freelancehunt.Properties.Resources.information;
            this.pictureBox3.Location = new System.Drawing.Point(5, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox4.Image = global::freelancehunt.Properties.Resources.world;
            this.pictureBox4.Location = new System.Drawing.Point(27, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 15);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBudget.Font = new System.Drawing.Font("Open Sans", 10F);
            this.lblBudget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(159)))), ((int)(((byte)(43)))));
            this.lblBudget.Location = new System.Drawing.Point(517, 4);
            this.lblBudget.MinimumSize = new System.Drawing.Size(0, 50);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(53, 50);
            this.lblBudget.TabIndex = 1;
            this.lblBudget.Text = "1000 $";
            this.lblBudget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Open Sans", 11F);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(0, 4);
            this.lblName.MinimumSize = new System.Drawing.Size(0, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 51);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Название";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName.Click += new System.EventHandler(this.pcbShowInWondow_Click);
            this.lblName.MouseHover += new System.EventHandler(this.lblName_MouseHover);
            // 
            // lblBidCount
            // 
            this.lblBidCount.AutoSize = true;
            this.lblBidCount.BackColor = System.Drawing.Color.Transparent;
            this.lblBidCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBidCount.Font = new System.Drawing.Font("Open Sans", 9.65F);
            this.lblBidCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblBidCount.Location = new System.Drawing.Point(523, 1);
            this.lblBidCount.Name = "lblBidCount";
            this.lblBidCount.Size = new System.Drawing.Size(51, 18);
            this.lblBidCount.TabIndex = 9;
            this.lblBidCount.Text = "Ставки";
            this.lblBidCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBidCount.Click += new System.EventHandler(this.pcbShowInWondow_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTime.Font = new System.Drawing.Font("Open Sans", 9.65F);
            this.lblTime.ForeColor = System.Drawing.Color.DimGray;
            this.lblTime.Location = new System.Drawing.Point(455, 1);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(48, 18);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Время";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTime.Click += new System.EventHandler(this.pcbShowInWondow_Click);
            this.lblTime.MouseHover += new System.EventHandler(this.lblDescription_MouseHover);
            // 
            // pnlSkills
            // 
            this.pnlSkills.BackColor = System.Drawing.Color.White;
            this.pnlSkills.Controls.Add(this.pictureBox1);
            this.pnlSkills.Controls.Add(this.lblTime);
            this.pnlSkills.Controls.Add(this.pictureBox2);
            this.pnlSkills.Controls.Add(this.lblBidCount);
            this.pnlSkills.Controls.Add(this.lblCategories);
            this.pnlSkills.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSkills.Location = new System.Drawing.Point(78, 53);
            this.pnlSkills.Name = "pnlSkills";
            this.pnlSkills.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.pnlSkills.Size = new System.Drawing.Size(574, 25);
            this.pnlSkills.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::freelancehunt.Properties.Resources.proj_time_ico;
            this.pictureBox1.InitialImage = global::freelancehunt.Properties.Resources.proj_time_ico;
            this.pictureBox1.Location = new System.Drawing.Point(435, 1);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pcbShowInWondow_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.lblDescription_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::freelancehunt.Properties.Resources.proj_hammer_ico;
            this.pictureBox2.InitialImage = global::freelancehunt.Properties.Resources.proj_hammer_ico;
            this.pictureBox2.Location = new System.Drawing.Point(503, 1);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(20, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pcbShowInWondow_Click);
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCategories.Font = new System.Drawing.Font("Open Sans", 9.65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCategories.ForeColor = System.Drawing.Color.DimGray;
            this.lblCategories.Location = new System.Drawing.Point(0, 1);
            this.lblCategories.MinimumSize = new System.Drawing.Size(0, 20);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(11, 20);
            this.lblCategories.TabIndex = 11;
            this.lblCategories.Text = " ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblBudget);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(78, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 4, 4, 0);
            this.panel1.Size = new System.Drawing.Size(574, 51);
            this.panel1.TabIndex = 11;
            // 
            // cntrlProject
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSkills);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(600, 80);
            this.Name = "cntrlProject";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(654, 80);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.cntrlProject_Paint);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvatar)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlSkills.ResumeLayout(false);
            this.pnlSkills.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel2;
        private PictureBox pcbAvatar;
        private Panel panel5;
        private Label lblName;
        private Label lblBidCount;
        private PictureBox pictureBox1;
        private Label lblTime;
        private Panel pnlSkills;
        private PictureBox pictureBox2;
        private Label lblBudget;
        private LinkLabel lblAutor;
        private Panel panel6;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Timer timer1;
        private Panel panel1;
        private Label lblCategories;


	

    }
}

