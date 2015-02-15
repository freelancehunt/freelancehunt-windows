namespace freelancehunt
{
    partial class frmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.chBxIsHide = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nUDShowTime = new System.Windows.Forms.NumericUpDown();
            this.chBxNotifyInterestProjOnly = new System.Windows.Forms.CheckBox();
            this.chBxAutoRun = new System.Windows.Forms.CheckBox();
            this.chBxAutoLogin = new System.Windows.Forms.CheckBox();
            this.chBxStartHidden = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nUDUpdFreq = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chBxIsShow = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDShowTime)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDUpdFreq)).BeginInit();
            this.SuspendLayout();
            // 
            // chBxIsHide
            // 
            this.chBxIsHide.AutoSize = true;
            this.chBxIsHide.Location = new System.Drawing.Point(4, 142);
            this.chBxIsHide.Name = "chBxIsHide";
            this.chBxIsHide.Size = new System.Drawing.Size(235, 23);
            this.chBxIsHide.TabIndex = 0;
            this.chBxIsHide.Text = "Скрывать всплывающее окно";
            this.chBxIsHide.UseVisualStyleBackColor = true;
            this.chBxIsHide.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Время отображения всплывающего окна (сек.)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Частота обновления (мин.)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chBxIsShow);
            this.panel1.Controls.Add(this.nUDShowTime);
            this.panel1.Controls.Add(this.chBxNotifyInterestProjOnly);
            this.panel1.Controls.Add(this.chBxAutoRun);
            this.panel1.Controls.Add(this.chBxAutoLogin);
            this.panel1.Controls.Add(this.chBxStartHidden);
            this.panel1.Controls.Add(this.chBxIsHide);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 202);
            this.panel1.TabIndex = 5;
            // 
            // nUDShowTime
            // 
            this.nUDShowTime.Location = new System.Drawing.Point(352, 170);
            this.nUDShowTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDShowTime.Name = "nUDShowTime";
            this.nUDShowTime.Size = new System.Drawing.Size(48, 26);
            this.nUDShowTime.TabIndex = 5;
            this.nUDShowTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDShowTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShowTime_KeyPress);
            // 
            // chBxNotifyInterestProjOnly
            // 
            this.chBxNotifyInterestProjOnly.AutoSize = true;
            this.chBxNotifyInterestProjOnly.Location = new System.Drawing.Point(4, 90);
            this.chBxNotifyInterestProjOnly.Name = "chBxNotifyInterestProjOnly";
            this.chBxNotifyInterestProjOnly.Size = new System.Drawing.Size(418, 23);
            this.chBxNotifyInterestProjOnly.TabIndex = 9;
            this.chBxNotifyInterestProjOnly.Text = "Уведомлять только о проектах из выбранных категорий";
            this.chBxNotifyInterestProjOnly.UseVisualStyleBackColor = true;
            // 
            // chBxAutoRun
            // 
            this.chBxAutoRun.AutoSize = true;
            this.chBxAutoRun.Location = new System.Drawing.Point(4, 4);
            this.chBxAutoRun.Name = "chBxAutoRun";
            this.chBxAutoRun.Size = new System.Drawing.Size(225, 23);
            this.chBxAutoRun.TabIndex = 11;
            this.chBxAutoRun.Text = "Запускать вместе с Windows";
            this.chBxAutoRun.UseVisualStyleBackColor = true;
            // 
            // chBxAutoLogin
            // 
            this.chBxAutoLogin.AutoSize = true;
            this.chBxAutoLogin.Location = new System.Drawing.Point(4, 32);
            this.chBxAutoLogin.Name = "chBxAutoLogin";
            this.chBxAutoLogin.Size = new System.Drawing.Size(235, 23);
            this.chBxAutoLogin.TabIndex = 10;
            this.chBxAutoLogin.Text = "Автоматическая авторизация";
            this.chBxAutoLogin.UseVisualStyleBackColor = true;
            // 
            // chBxStartHidden
            // 
            this.chBxStartHidden.AutoSize = true;
            this.chBxStartHidden.Location = new System.Drawing.Point(4, 61);
            this.chBxStartHidden.Name = "chBxStartHidden";
            this.chBxStartHidden.Size = new System.Drawing.Size(177, 23);
            this.chBxStartHidden.TabIndex = 9;
            this.chBxStartHidden.Text = "Запускать свернутым";
            this.chBxStartHidden.UseVisualStyleBackColor = true;
            this.chBxStartHidden.CheckedChanged += new System.EventHandler(this.chBxStartHidden_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nUDUpdFreq);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 38);
            this.panel2.TabIndex = 6;
            // 
            // nUDUpdFreq
            // 
            this.nUDUpdFreq.Location = new System.Drawing.Point(215, 5);
            this.nUDUpdFreq.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nUDUpdFreq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDUpdFreq.Name = "nUDUpdFreq";
            this.nUDUpdFreq.Size = new System.Drawing.Size(48, 26);
            this.nUDUpdFreq.TabIndex = 6;
            this.nUDUpdFreq.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDUpdFreq.ValueChanged += new System.EventHandler(this.nUDUpdFreq_ValueChanged);
            this.nUDUpdFreq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShowTime_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chBxIsShow
            // 
            this.chBxIsShow.AutoSize = true;
            this.chBxIsShow.Location = new System.Drawing.Point(4, 116);
            this.chBxIsShow.Name = "chBxIsShow";
            this.chBxIsShow.Size = new System.Drawing.Size(250, 23);
            this.chBxIsShow.TabIndex = 12;
            this.chBxIsShow.Text = "Показывать всплывающее окно";
            this.chBxIsShow.UseVisualStyleBackColor = true;
            this.chBxIsShow.CheckedChanged += new System.EventHandler(this.chBxIsShow_CheckedChanged);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 276);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(440, 315);
            this.MinimumSize = new System.Drawing.Size(440, 315);
            this.Name = "frmConfig";
            this.Text = "Настройки";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDShowTime)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDUpdFreq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chBxIsHide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chBxStartHidden;
        private System.Windows.Forms.CheckBox chBxAutoLogin;
        private System.Windows.Forms.CheckBox chBxAutoRun;
        private System.Windows.Forms.CheckBox chBxNotifyInterestProjOnly;
        private System.Windows.Forms.NumericUpDown nUDShowTime;
        private System.Windows.Forms.NumericUpDown nUDUpdFreq;
        private System.Windows.Forms.CheckBox chBxIsShow;
    }
}