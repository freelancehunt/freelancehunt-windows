namespace freelancehunt
{
    partial class frmProjectFullInfo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjectFullInfo));
            this.lblBidCount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pcbProfileAvatar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfileAvatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBidCount
            // 
            this.lblBidCount.AutoSize = true;
            this.lblBidCount.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblBidCount.Location = new System.Drawing.Point(6, 5);
            this.lblBidCount.Name = "lblBidCount";
            this.lblBidCount.Size = new System.Drawing.Size(63, 22);
            this.lblBidCount.TabIndex = 0;
            this.lblBidCount.Text = "Ставки";
            this.lblBidCount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmProjectFullInfo_MouseDown);
            this.lblBidCount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmProjectFullInfo_MouseMove);
            this.lblBidCount.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmProjectFullInfo_MouseUp);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblName.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblName.ForeColor = System.Drawing.Color.DimGray;
            this.lblName.Location = new System.Drawing.Point(10, 35);
            this.lblName.MaximumSize = new System.Drawing.Size(560, 0);
            this.lblName.MinimumSize = new System.Drawing.Size(100, 40);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblName.Size = new System.Drawing.Size(100, 40);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Название";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescription.Location = new System.Drawing.Point(1, 0);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(5);
            this.lblDescription.MaximumSize = new System.Drawing.Size(650, 0);
            this.lblDescription.MinimumSize = new System.Drawing.Size(650, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Padding = new System.Windows.Forms.Padding(5);
            this.lblDescription.Size = new System.Drawing.Size(650, 29);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Описание";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.BackColor = System.Drawing.SystemColors.Control;
            this.lblCategories.Font = new System.Drawing.Font("Open Sans", 9F);
            this.lblCategories.Location = new System.Drawing.Point(6, 29);
            this.lblCategories.MinimumSize = new System.Drawing.Size(190, 20);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(190, 20);
            this.lblCategories.TabIndex = 0;
            this.lblCategories.Text = "Категории";
            this.lblCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCategories.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmProjectFullInfo_MouseDown);
            this.lblCategories.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmProjectFullInfo_MouseMove);
            this.lblCategories.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmProjectFullInfo_MouseUp);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(668, 80);
            this.panel3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.lblName);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(80, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10, 3, 3, 5);
            this.panel5.Size = new System.Drawing.Size(588, 80);
            this.panel5.TabIndex = 10;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmProjectFullInfo_MouseDown);
            this.panel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmProjectFullInfo_MouseMove);
            this.panel5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmProjectFullInfo_MouseUp);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblTime);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.lblLogin);
            this.panel6.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(10, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(575, 30);
            this.panel6.TabIndex = 10;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmProjectFullInfo_MouseDown);
            this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmProjectFullInfo_MouseMove);
            this.panel6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmProjectFullInfo_MouseUp);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTime.Font = new System.Drawing.Font("Open Sans", 10.5F);
            this.lblTime.Location = new System.Drawing.Point(482, 0);
            this.lblTime.MinimumSize = new System.Drawing.Size(0, 28);
            this.lblTime.Name = "lblTime";
            this.lblTime.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblTime.Size = new System.Drawing.Size(63, 28);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "Время";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmProjectFullInfo_MouseDown);
            this.lblTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmProjectFullInfo_MouseMove);
            this.lblTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmProjectFullInfo_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::freelancehunt.Properties.Resources.closeProjDet;
            this.pictureBox1.Location = new System.Drawing.Point(545, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLogin.Font = new System.Drawing.Font("Open Sans", 11F);
            this.lblLogin.ForeColor = System.Drawing.Color.Black;
            this.lblLogin.Location = new System.Drawing.Point(0, 0);
            this.lblLogin.MinimumSize = new System.Drawing.Size(0, 28);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(55, 28);
            this.lblLogin.TabIndex = 9;
            this.lblLogin.Text = "Логин";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLogin.Click += new System.EventHandler(this.btnGoToProfileURL_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.pcbProfileAvatar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(2);
            this.panel4.Size = new System.Drawing.Size(80, 80);
            this.panel4.TabIndex = 2;
            // 
            // pcbProfileAvatar
            // 
            this.pcbProfileAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbProfileAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbProfileAvatar.Image = global::freelancehunt.Properties.Resources.DefaultAva;
            this.pcbProfileAvatar.Location = new System.Drawing.Point(2, 2);
            this.pcbProfileAvatar.MaximumSize = new System.Drawing.Size(75, 75);
            this.pcbProfileAvatar.Name = "pcbProfileAvatar";
            this.pcbProfileAvatar.Size = new System.Drawing.Size(75, 75);
            this.pcbProfileAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbProfileAvatar.TabIndex = 2;
            this.pcbProfileAvatar.TabStop = false;
            this.pcbProfileAvatar.Click += new System.EventHandler(this.btnGoToProfileURL_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblCategories);
            this.panel1.Controls.Add(this.lblBidCount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(1, 133);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(668, 55);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmProjectFullInfo_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmProjectFullInfo_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmProjectFullInfo_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(522, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сделать ставку!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.webBrowser1);
            this.panel2.Controls.Add(this.lblDescription);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 81);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.MaximumSize = new System.Drawing.Size(668, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(668, 52);
            this.panel2.TabIndex = 7;
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(1, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(667, 52);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // frmProjectFullInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(670, 189);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(670, 700);
            this.Name = "frmProjectFullInfo";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о проекте";
            this.Load += new System.EventHandler(this.frmProjectFullInfo_Load);
            this.Shown += new System.EventHandler(this.frmProjectFullInfo_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmProjectFullInfo_Paint);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfileAvatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBidCount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pcbProfileAvatar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}