namespace freelancehunt
{
    partial class cntrlMessageInfo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.LinkLabel();
            this.lblAutorL = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pcbAttach = new System.Windows.Forms.PictureBox();
            this.pcbNewMail = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSubject = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNewMail)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(60, 58);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::freelancehunt.Properties.Resources.DefaultAva;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTime.Font = new System.Drawing.Font("Open Sans", 9F);
            this.lblTime.Location = new System.Drawing.Point(1, 4);
            this.lblTime.Margin = new System.Windows.Forms.Padding(3, 5, 3, 24);
            this.lblTime.MinimumSize = new System.Drawing.Size(120, 24);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(120, 24);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "label1";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.BackColor = System.Drawing.Color.Transparent;
            this.lblAutor.Font = new System.Drawing.Font("Open Sans", 10F);
            this.lblAutor.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblAutor.Location = new System.Drawing.Point(4, 0);
            this.lblAutor.MaximumSize = new System.Drawing.Size(178, 0);
            this.lblAutor.MinimumSize = new System.Drawing.Size(0, 24);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(50, 24);
            this.lblAutor.TabIndex = 5;
            this.lblAutor.TabStop = true;
            this.lblAutor.Text = "Автор";
            this.lblAutor.Click += new System.EventHandler(this.lblSubject_Click);
            // 
            // lblAutorL
            // 
            this.lblAutorL.AutoSize = true;
            this.lblAutorL.BackColor = System.Drawing.Color.Transparent;
            this.lblAutorL.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAutorL.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblAutorL.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAutorL.Location = new System.Drawing.Point(4, 24);
            this.lblAutorL.MaximumSize = new System.Drawing.Size(178, 0);
            this.lblAutorL.MinimumSize = new System.Drawing.Size(0, 24);
            this.lblAutorL.Name = "lblAutorL";
            this.lblAutorL.Size = new System.Drawing.Size(39, 24);
            this.lblAutorL.TabIndex = 10;
            this.lblAutorL.TabStop = true;
            this.lblAutorL.Text = "Автор";
            this.lblAutorL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAutorL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAutor_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(672, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1, 4, 0, 0);
            this.panel1.Size = new System.Drawing.Size(126, 58);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pcbAttach);
            this.panel3.Controls.Add(this.pcbNewMail);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(242, 26);
            this.panel3.MaximumSize = new System.Drawing.Size(0, 46);
            this.panel3.MinimumSize = new System.Drawing.Size(0, 27);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2);
            this.panel3.Size = new System.Drawing.Size(430, 34);
            this.panel3.TabIndex = 8;
            // 
            // pcbAttach
            // 
            this.pcbAttach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbAttach.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbAttach.Image = global::freelancehunt.Properties.Resources.disk;
            this.pcbAttach.Location = new System.Drawing.Point(18, 2);
            this.pcbAttach.MaximumSize = new System.Drawing.Size(16, 24);
            this.pcbAttach.MinimumSize = new System.Drawing.Size(16, 24);
            this.pcbAttach.Name = "pcbAttach";
            this.pcbAttach.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pcbAttach.Size = new System.Drawing.Size(16, 24);
            this.pcbAttach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbAttach.TabIndex = 2;
            this.pcbAttach.TabStop = false;
            this.pcbAttach.MouseHover += new System.EventHandler(this.pcbAttach_MouseHover);
            // 
            // pcbNewMail
            // 
            this.pcbNewMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbNewMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbNewMail.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbNewMail.Image = global::freelancehunt.Properties.Resources.mail_open;
            this.pcbNewMail.Location = new System.Drawing.Point(2, 2);
            this.pcbNewMail.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.pcbNewMail.MaximumSize = new System.Drawing.Size(16, 24);
            this.pcbNewMail.MinimumSize = new System.Drawing.Size(16, 24);
            this.pcbNewMail.Name = "pcbNewMail";
            this.pcbNewMail.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pcbNewMail.Size = new System.Drawing.Size(16, 24);
            this.pcbNewMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbNewMail.TabIndex = 3;
            this.pcbNewMail.TabStop = false;
            this.pcbNewMail.Click += new System.EventHandler(this.lblSubject_Click);
            this.pcbNewMail.MouseHover += new System.EventHandler(this.pcbNewMail_MouseHover);
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblAutor);
            this.panel4.Controls.Add(this.lblAutorL);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(62, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 3, 9, 3);
            this.panel4.MaximumSize = new System.Drawing.Size(180, 0);
            this.panel4.MinimumSize = new System.Drawing.Size(180, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 58);
            this.panel4.TabIndex = 11;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoEllipsis = true;
            this.lblSubject.AutoSize = true;
            this.lblSubject.BackColor = System.Drawing.Color.Transparent;
            this.lblSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubject.Font = new System.Drawing.Font("Open Sans", 10F);
            this.lblSubject.Location = new System.Drawing.Point(0, 0);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblSubject.MinimumSize = new System.Drawing.Size(0, 24);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(73, 24);
            this.lblSubject.TabIndex = 9;
            this.lblSubject.Text = "Без темы";
            this.lblSubject.Click += new System.EventHandler(this.lblSubject_Click);
            this.lblSubject.MouseHover += new System.EventHandler(this.lblSubject_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.lblSubject);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(242, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(430, 24);
            this.panel5.TabIndex = 12;
            // 
            // cntrlMessageInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(800, 60);
            this.Name = "cntrlMessageInfo";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(800, 62);
            this.Load += new System.EventHandler(this.cntrlMessageInfo_Load);
            this.SizeChanged += new System.EventHandler(this.cntrlMessageInfo_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.cntrlMessageInfo_Paint);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNewMail)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.LinkLabel lblAutor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pcbAttach;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pcbNewMail;
        private System.Windows.Forms.LinkLabel lblAutorL;
        private System.Windows.Forms.Panel panel5;
        
    }
}
