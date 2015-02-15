namespace freelancehunt
{
    partial class frmUpdateInfo
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
            this.components = new System.ComponentModel.Container();
            this.pcbClose = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnFeed = new System.Windows.Forms.Button();
            this.btnProj = new System.Windows.Forms.Button();
            this.btnMsg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbClose
            // 
            this.pcbClose.Image = global::freelancehunt.Properties.Resources.cross;
            this.pcbClose.Location = new System.Drawing.Point(276, 0);
            this.pcbClose.Name = "pcbClose";
            this.pcbClose.Size = new System.Drawing.Size(24, 24);
            this.pcbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbClose.TabIndex = 1;
            this.pcbClose.TabStop = false;
            this.pcbClose.Click += new System.EventHandler(this.pcbClose_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnFeed
            // 
            this.btnFeed.BackColor = System.Drawing.Color.Transparent;
            this.btnFeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFeed.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFeed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.btnFeed.FlatAppearance.BorderSize = 0;
            this.btnFeed.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.btnFeed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.btnFeed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.btnFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeed.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFeed.ForeColor = System.Drawing.Color.White;
            this.btnFeed.Image = global::freelancehunt.Properties.Resources.UpdateFeed;
            this.btnFeed.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFeed.Location = new System.Drawing.Point(200, 0);
            this.btnFeed.MaximumSize = new System.Drawing.Size(100, 100);
            this.btnFeed.MinimumSize = new System.Drawing.Size(100, 100);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(100, 100);
            this.btnFeed.TabIndex = 5;
            this.btnFeed.Text = "Лента";
            this.btnFeed.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFeed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFeed.UseVisualStyleBackColor = false;
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click);
            // 
            // btnProj
            // 
            this.btnProj.BackColor = System.Drawing.Color.Transparent;
            this.btnProj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProj.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.btnProj.FlatAppearance.BorderSize = 0;
            this.btnProj.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.btnProj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.btnProj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.btnProj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProj.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProj.ForeColor = System.Drawing.Color.White;
            this.btnProj.Image = global::freelancehunt.Properties.Resources.UpdateHummer;
            this.btnProj.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProj.Location = new System.Drawing.Point(100, 0);
            this.btnProj.MaximumSize = new System.Drawing.Size(100, 100);
            this.btnProj.MinimumSize = new System.Drawing.Size(100, 100);
            this.btnProj.Name = "btnProj";
            this.btnProj.Size = new System.Drawing.Size(100, 100);
            this.btnProj.TabIndex = 4;
            this.btnProj.Text = "Проекты";
            this.btnProj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProj.UseVisualStyleBackColor = false;
            this.btnProj.Click += new System.EventHandler(this.btnProj_Click);
            // 
            // btnMsg
            // 
            this.btnMsg.BackColor = System.Drawing.Color.Transparent;
            this.btnMsg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMsg.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMsg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.btnMsg.FlatAppearance.BorderSize = 0;
            this.btnMsg.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.btnMsg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.btnMsg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.btnMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMsg.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMsg.ForeColor = System.Drawing.Color.White;
            this.btnMsg.Image = global::freelancehunt.Properties.Resources.UpdateMessage;
            this.btnMsg.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMsg.Location = new System.Drawing.Point(0, 0);
            this.btnMsg.MaximumSize = new System.Drawing.Size(100, 100);
            this.btnMsg.MinimumSize = new System.Drawing.Size(100, 100);
            this.btnMsg.Name = "btnMsg";
            this.btnMsg.Size = new System.Drawing.Size(100, 100);
            this.btnMsg.TabIndex = 3;
            this.btnMsg.Text = "Сообщения";
            this.btnMsg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMsg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMsg.UseVisualStyleBackColor = false;
            this.btnMsg.Click += new System.EventHandler(this.btnMsg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(108)))));
            this.label2.Image = global::freelancehunt.Properties.Resources.UpdateBck4Digit;
            this.label2.Location = new System.Drawing.Point(36, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.MaximumSize = new System.Drawing.Size(29, 29);
            this.label2.MinimumSize = new System.Drawing.Size(29, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 29);
            this.label2.TabIndex = 7;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.btnMsg_Click);
            this.label2.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(108)))));
            this.label3.Image = global::freelancehunt.Properties.Resources.UpdateBck4Digit;
            this.label3.Location = new System.Drawing.Point(136, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.MaximumSize = new System.Drawing.Size(29, 29);
            this.label3.MinimumSize = new System.Drawing.Size(29, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 29);
            this.label3.TabIndex = 8;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.btnProj_Click);
            this.label3.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_Paint);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(108)))));
            this.label4.Image = global::freelancehunt.Properties.Resources.UpdateBck4Digit;
            this.label4.Location = new System.Drawing.Point(236, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.MaximumSize = new System.Drawing.Size(29, 29);
            this.label4.MinimumSize = new System.Drawing.Size(29, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 29);
            this.label4.TabIndex = 9;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.btnFeed_Click);
            this.label4.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_Paint);
            // 
            // frmUpdateInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(300, 100);
            this.Controls.Add(this.pcbClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFeed);
            this.Controls.Add(this.btnProj);
            this.Controls.Add(this.btnMsg);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(300, 100);
            this.Name = "frmUpdateInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pcbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbClose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnMsg;
        private System.Windows.Forms.Button btnProj;
        private System.Windows.Forms.Button btnFeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}