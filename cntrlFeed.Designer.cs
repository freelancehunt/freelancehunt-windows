namespace freelancehunt
{
    partial class cntrlFeed
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAutor = new System.Windows.Forms.LinkLabel();
            this.lblMessage = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pcbGP = new System.Windows.Forms.PictureBox();
            this.pcbTW = new System.Windows.Forms.PictureBox();
            this.pcbFB = new System.Windows.Forms.PictureBox();
            this.pcbVK = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn4 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVK)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.MaximumSize = new System.Drawing.Size(46, 46);
            this.panel2.MinimumSize = new System.Drawing.Size(46, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(46, 46);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::freelancehunt.Properties.Resources.DefaultAva;
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.BackColor = System.Drawing.Color.Transparent;
            this.lblAutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAutor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAutor.Font = new System.Drawing.Font("Open Sans", 10F);
            this.lblAutor.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblAutor.Location = new System.Drawing.Point(0, 0);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.lblAutor.MinimumSize = new System.Drawing.Size(0, 40);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(50, 40);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.TabStop = true;
            this.lblAutor.Text = "Автор";
            this.lblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAutor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAutor_LinkClicked);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMessage.Font = new System.Drawing.Font("Open Sans", 10F);
            this.lblMessage.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblMessage.LinkColor = System.Drawing.Color.Black;
            this.lblMessage.Location = new System.Drawing.Point(50, 0);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblMessage.MinimumSize = new System.Drawing.Size(0, 40);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(89, 40);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.TabStop = true;
            this.lblMessage.Text = "Сообщение";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMessage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblMessage_LinkClicked);
            this.lblMessage.MouseHover += new System.EventHandler(this.lblMessage_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.lblMessage);
            this.panel3.Controls.Add(this.lblAutor);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel3.Location = new System.Drawing.Point(48, 2);
            this.panel3.MaximumSize = new System.Drawing.Size(0, 46);
            this.panel3.MinimumSize = new System.Drawing.Size(0, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 46);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.pcbGP);
            this.panel4.Controls.Add(this.pcbTW);
            this.panel4.Controls.Add(this.pcbFB);
            this.panel4.Controls.Add(this.pcbVK);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(249, 0);
            this.panel4.MinimumSize = new System.Drawing.Size(50, 44);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(2, 6, 2, 9);
            this.panel4.Size = new System.Drawing.Size(124, 46);
            this.panel4.TabIndex = 6;
            this.panel4.Visible = false;
            // 
            // pcbGP
            // 
            this.pcbGP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbGP.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbGP.Image = global::freelancehunt.Properties.Resources.ico_google_;
            this.pcbGP.Location = new System.Drawing.Point(92, 6);
            this.pcbGP.Margin = new System.Windows.Forms.Padding(5);
            this.pcbGP.MaximumSize = new System.Drawing.Size(30, 30);
            this.pcbGP.MinimumSize = new System.Drawing.Size(30, 30);
            this.pcbGP.Name = "pcbGP";
            this.pcbGP.Size = new System.Drawing.Size(30, 30);
            this.pcbGP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGP.TabIndex = 3;
            this.pcbGP.TabStop = false;
            this.pcbGP.Visible = false;
            this.pcbGP.Click += new System.EventHandler(this.pcbGP_Click);
            this.pcbGP.MouseHover += new System.EventHandler(this.pcbGP_MouseHover);
            // 
            // pcbTW
            // 
            this.pcbTW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbTW.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbTW.Image = global::freelancehunt.Properties.Resources.ico_twitter;
            this.pcbTW.Location = new System.Drawing.Point(62, 6);
            this.pcbTW.Margin = new System.Windows.Forms.Padding(5);
            this.pcbTW.MaximumSize = new System.Drawing.Size(30, 30);
            this.pcbTW.MinimumSize = new System.Drawing.Size(30, 30);
            this.pcbTW.Name = "pcbTW";
            this.pcbTW.Size = new System.Drawing.Size(30, 30);
            this.pcbTW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbTW.TabIndex = 2;
            this.pcbTW.TabStop = false;
            this.pcbTW.Visible = false;
            this.pcbTW.Click += new System.EventHandler(this.pcbTW_Click);
            this.pcbTW.MouseHover += new System.EventHandler(this.pcbTW_MouseHover);
            // 
            // pcbFB
            // 
            this.pcbFB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbFB.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbFB.Image = global::freelancehunt.Properties.Resources.ico_facebook;
            this.pcbFB.Location = new System.Drawing.Point(32, 6);
            this.pcbFB.Margin = new System.Windows.Forms.Padding(5);
            this.pcbFB.MaximumSize = new System.Drawing.Size(30, 30);
            this.pcbFB.MinimumSize = new System.Drawing.Size(30, 30);
            this.pcbFB.Name = "pcbFB";
            this.pcbFB.Size = new System.Drawing.Size(30, 30);
            this.pcbFB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbFB.TabIndex = 1;
            this.pcbFB.TabStop = false;
            this.pcbFB.Visible = false;
            this.pcbFB.Click += new System.EventHandler(this.pcbFB_Click);
            this.pcbFB.MouseHover += new System.EventHandler(this.pcbFB_MouseHover);
            // 
            // pcbVK
            // 
            this.pcbVK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbVK.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbVK.Image = global::freelancehunt.Properties.Resources.ico_vk1;
            this.pcbVK.Location = new System.Drawing.Point(2, 6);
            this.pcbVK.Margin = new System.Windows.Forms.Padding(5);
            this.pcbVK.MaximumSize = new System.Drawing.Size(30, 30);
            this.pcbVK.MinimumSize = new System.Drawing.Size(30, 30);
            this.pcbVK.Name = "pcbVK";
            this.pcbVK.Size = new System.Drawing.Size(30, 30);
            this.pcbVK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbVK.TabIndex = 0;
            this.pcbVK.TabStop = false;
            this.pcbVK.Visible = false;
            this.pcbVK.Click += new System.EventHandler(this.pcbVK_Click);
            this.pcbVK.MouseHover += new System.EventHandler(this.pcbVK_MouseHover);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(139, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(110, 44);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1, 8, 1, 10);
            this.panel1.Size = new System.Drawing.Size(110, 46);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // btn3
            // 
            this.btn3.AutoSize = true;
            this.btn3.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn3.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn3.Location = new System.Drawing.Point(53, 8);
            this.btn3.MaximumSize = new System.Drawing.Size(0, 26);
            this.btn3.MinimumSize = new System.Drawing.Size(26, 26);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(26, 26);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Visible = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            this.btn3.MouseHover += new System.EventHandler(this.btn3_MouseHover);
            // 
            // btn2
            // 
            this.btn2.AutoSize = true;
            this.btn2.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn2.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2.Location = new System.Drawing.Point(27, 8);
            this.btn2.MaximumSize = new System.Drawing.Size(0, 26);
            this.btn2.MinimumSize = new System.Drawing.Size(26, 26);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(26, 26);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Visible = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            this.btn2.MouseHover += new System.EventHandler(this.btn2_MouseHover);
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn1.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1.Location = new System.Drawing.Point(1, 8);
            this.btn1.MaximumSize = new System.Drawing.Size(0, 26);
            this.btn1.MinimumSize = new System.Drawing.Size(26, 26);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(26, 26);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Visible = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            this.btn1.MouseHover += new System.EventHandler(this.btn1_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::freelancehunt.Properties.Resources.img_cntrl_Feed;
            this.pictureBox2.Location = new System.Drawing.Point(510, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(5, 8, 10, 10);
            this.pictureBox2.Size = new System.Drawing.Size(40, 46);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btn4
            // 
            this.btn4.AutoSize = true;
            this.btn4.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn4.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn4.Location = new System.Drawing.Point(79, 8);
            this.btn4.MaximumSize = new System.Drawing.Size(0, 26);
            this.btn4.MinimumSize = new System.Drawing.Size(26, 26);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(26, 26);
            this.btn4.TabIndex = 3;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Visible = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            this.btn4.MouseHover += new System.EventHandler(this.btn4_MouseHover);
            // 
            // cntrlFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "cntrlFeed";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(600, 50);
            this.Load += new System.EventHandler(this.cntrlFeed_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.cntrlFeed_Paint);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbGP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVK)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel lblAutor;
        private System.Windows.Forms.LinkLabel lblMessage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pcbVK;
        private System.Windows.Forms.PictureBox pcbTW;
        private System.Windows.Forms.PictureBox pcbFB;
        private System.Windows.Forms.PictureBox pcbGP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
    }
}
