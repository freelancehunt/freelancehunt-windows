using System.Windows.Forms;
using System.Drawing;
using System;
using freelancehunt.Properties;
namespace freelancehunt
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLoading = new System.Windows.Forms.TabPage();
            this.panel25 = new System.Windows.Forms.Panel();
            this.pcbLoadOrange = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabMessages = new System.Windows.Forms.TabPage();
            this.scrollMessages = new System.Windows.Forms.ScrollableControl();
            this.panel26 = new System.Windows.Forms.Panel();
            this.cBPgNum = new System.Windows.Forms.ComboBox();
            this.btnNxtPgMsg = new System.Windows.Forms.Button();
            this.btnPrvPgMsg = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabFeeds = new System.Windows.Forms.TabPage();
            this.scrollFeed = new System.Windows.Forms.ScrollableControl();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGoToProfileURL = new System.Windows.Forms.Button();
            this.btnProfileSendMessage = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pcbUserNegative = new System.Windows.Forms.PictureBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pcbUserPositive = new System.Windows.Forms.PictureBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pnlUserParam = new System.Windows.Forms.Panel();
            this.pcbUser_OKPAY = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pcbUser_WMID = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pcbUser_Day = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pcbUser_email = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pcbUser_Phone = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pcbProfileAvatar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFindUser = new System.Windows.Forms.Button();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabProjects = new System.Windows.Forms.TabPage();
            this.panel22 = new System.Windows.Forms.Panel();
            this.scrollProjects = new System.Windows.Forms.ScrollableControl();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPrewPage = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.tabSearchProj = new System.Windows.Forms.TabPage();
            this.scrollSearchedProject = new System.Windows.Forms.ScrollableControl();
            this.panel13 = new System.Windows.Forms.Panel();
            this.pnlPageNavigation = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.cmbPageNum = new System.Windows.Forms.ComboBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.pcbPagePlus = new System.Windows.Forms.PictureBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.pcbPageMinus = new System.Windows.Forms.PictureBox();
            this.btnFltr = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.grpSkills = new System.Windows.Forms.GroupBox();
            this.lstSkill = new System.Windows.Forms.CheckedListBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnSaveSkills = new System.Windows.Forms.ToolStripButton();
            this.btnOpenSkill = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.btnFilterOnOff = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuSkills_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSkills_Cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSkills_selectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSkills_unSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSkills_invert = new System.Windows.Forms.ToolStripMenuItem();
            this.tabDialog = new System.Windows.Forms.TabPage();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel24 = new System.Windows.Forms.Panel();
            this.scrollMessDialog = new System.Windows.Forms.ScrollableControl();
            this.panel23 = new System.Windows.Forms.Panel();
            this.txtNewMessage = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.tabUserList = new System.Windows.Forms.TabPage();
            this.panel15 = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panel21 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.mnuPopup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuShow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuChangeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLastAction = new System.Windows.Forms.Label();
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.pcbPing = new System.Windows.Forms.PictureBox();
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new freelancehunt.cProgressBar();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabLoading.SuspendLayout();
            this.panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoadOrange)).BeginInit();
            this.tabMessages.SuspendLayout();
            this.panel26.SuspendLayout();
            this.tabFeeds.SuspendLayout();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserNegative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserPositive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnlUserParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser_OKPAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser_WMID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser_Day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser_Phone)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfileAvatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabProjects.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel20.SuspendLayout();
            this.tabSearchProj.SuspendLayout();
            this.panel13.SuspendLayout();
            this.pnlPageNavigation.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPagePlus)).BeginInit();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPageMinus)).BeginInit();
            this.grpSkills.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabDialog.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel23.SuspendLayout();
            this.tabUserList.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.mnuPopup.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPing)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(159)))), ((int)(((byte)(79)))));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Open Sans", 9F);
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(55, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(171, 561);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.AutoToolTip = false;
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripButton1.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripButton1.Image = global::freelancehunt.Properties.Resources.msg_ico1;
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(169, 60);
            this.toolStripButton1.Text = "СООБЩЕНИЯ";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            this.toolStripButton1.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripButton_Paint);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.AutoToolTip = false;
            this.toolStripButton2.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton2.ForeColor = System.Drawing.Color.White;
            this.toolStripButton2.Image = global::freelancehunt.Properties.Resources.news_ico1;
            this.toolStripButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(169, 60);
            this.toolStripButton2.Text = "ЛЕНТА";
            this.toolStripButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            this.toolStripButton2.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripButton_Paint);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.AutoToolTip = false;
            this.toolStripButton3.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton3.ForeColor = System.Drawing.Color.White;
            this.toolStripButton3.Image = global::freelancehunt.Properties.Resources.user_ico1;
            this.toolStripButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(169, 60);
            this.toolStripButton3.Text = "ПОЛЬЗОВАТЕЛИ";
            this.toolStripButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton3.Visible = false;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            this.toolStripButton3.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripButton_Paint);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.AutoSize = false;
            this.toolStripButton4.AutoToolTip = false;
            this.toolStripButton4.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(96)))), ((int)(((byte)(34)))));
            this.toolStripButton4.Image = global::freelancehunt.Properties.Resources.about_ico1;
            this.toolStripButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Yellow;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(169, 40);
            this.toolStripButton4.Text = "О ПРОГРАММЕ";
            this.toolStripButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            this.toolStripButton4.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripButton_Paint);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.AutoSize = false;
            this.toolStripButton5.AutoToolTip = false;
            this.toolStripButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButton5.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton5.ForeColor = System.Drawing.Color.White;
            this.toolStripButton5.Image = global::freelancehunt.Properties.Resources.proj_ico1;
            this.toolStripButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(169, 60);
            this.toolStripButton5.Text = "ПРОЕКТЫ";
            this.toolStripButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            this.toolStripButton5.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripButton_Paint);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.AutoSize = false;
            this.toolStripButton6.AutoToolTip = false;
            this.toolStripButton6.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton6.ForeColor = System.Drawing.Color.White;
            this.toolStripButton6.Image = global::freelancehunt.Properties.Resources.srch_ico1;
            this.toolStripButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(169, 60);
            this.toolStripButton6.Text = "ФИЛЬТР";
            this.toolStripButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton6.Visible = false;
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            this.toolStripButton6.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripButton_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLoading);
            this.tabControl1.Controls.Add(this.tabMessages);
            this.tabControl1.Controls.Add(this.tabFeeds);
            this.tabControl1.Controls.Add(this.tabUsers);
            this.tabControl1.Controls.Add(this.tabProjects);
            this.tabControl1.Controls.Add(this.tabSearchProj);
            this.tabControl1.Controls.Add(this.tabDialog);
            this.tabControl1.Controls.Add(this.tabUserList);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(171, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(813, 560);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabLoading
            // 
            this.tabLoading.BackColor = System.Drawing.Color.White;
            this.tabLoading.Controls.Add(this.panel25);
            this.tabLoading.Controls.Add(this.label4);
            this.tabLoading.Location = new System.Drawing.Point(4, 24);
            this.tabLoading.Name = "tabLoading";
            this.tabLoading.Size = new System.Drawing.Size(805, 532);
            this.tabLoading.TabIndex = 7;
            this.tabLoading.Text = "tabLoading";
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.SystemColors.Control;
            this.panel25.Controls.Add(this.pcbLoadOrange);
            this.panel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel25.Location = new System.Drawing.Point(0, 47);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(805, 485);
            this.panel25.TabIndex = 3;
            this.panel25.SizeChanged += new System.EventHandler(this.panel25_SizeChanged);
            // 
            // pcbLoadOrange
            // 
            this.pcbLoadOrange.BackColor = System.Drawing.SystemColors.Control;
            this.pcbLoadOrange.BackgroundImage = global::freelancehunt.Properties.Resources.load_orange;
            this.pcbLoadOrange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbLoadOrange.Image = global::freelancehunt.Properties.Resources.load_gray_1;
            this.pcbLoadOrange.Location = new System.Drawing.Point(16, 14);
            this.pcbLoadOrange.Name = "pcbLoadOrange";
            this.pcbLoadOrange.Size = new System.Drawing.Size(360, 360);
            this.pcbLoadOrange.TabIndex = 2;
            this.pcbLoadOrange.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(805, 47);
            this.label4.TabIndex = 0;
            this.label4.Text = "Идет загрузка";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabMessages
            // 
            this.tabMessages.BackColor = System.Drawing.Color.White;
            this.tabMessages.Controls.Add(this.scrollMessages);
            this.tabMessages.Controls.Add(this.panel26);
            this.tabMessages.Location = new System.Drawing.Point(4, 22);
            this.tabMessages.Margin = new System.Windows.Forms.Padding(0);
            this.tabMessages.Name = "tabMessages";
            this.tabMessages.Size = new System.Drawing.Size(805, 534);
            this.tabMessages.TabIndex = 0;
            this.tabMessages.Text = "tabMessages";
            this.tabMessages.UseVisualStyleBackColor = true;
            // 
            // scrollMessages
            // 
            this.scrollMessages.AutoScroll = true;
            this.scrollMessages.BackColor = System.Drawing.SystemColors.Control;
            this.scrollMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollMessages.Location = new System.Drawing.Point(0, 0);
            this.scrollMessages.Margin = new System.Windows.Forms.Padding(0);
            this.scrollMessages.Name = "scrollMessages";
            this.scrollMessages.Size = new System.Drawing.Size(805, 507);
            this.scrollMessages.TabIndex = 1;
            this.scrollMessages.Text = "scrollableControl1";
            // 
            // panel26
            // 
            this.panel26.BackColor = System.Drawing.SystemColors.Control;
            this.panel26.Controls.Add(this.cBPgNum);
            this.panel26.Controls.Add(this.btnNxtPgMsg);
            this.panel26.Controls.Add(this.btnPrvPgMsg);
            this.panel26.Controls.Add(this.label6);
            this.panel26.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel26.Location = new System.Drawing.Point(0, 507);
            this.panel26.MaximumSize = new System.Drawing.Size(0, 27);
            this.panel26.MinimumSize = new System.Drawing.Size(0, 27);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(805, 27);
            this.panel26.TabIndex = 2;
            // 
            // cBPgNum
            // 
            this.cBPgNum.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBPgNum.ForeColor = System.Drawing.Color.DimGray;
            this.cBPgNum.FormattingEnabled = true;
            this.cBPgNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cBPgNum.Location = new System.Drawing.Point(104, 1);
            this.cBPgNum.Name = "cBPgNum";
            this.cBPgNum.Size = new System.Drawing.Size(40, 25);
            this.cBPgNum.TabIndex = 7;
            this.cBPgNum.Text = "1";
            this.cBPgNum.SelectedValueChanged += new System.EventHandler(this.cBPgNum_SelectedValueChanged);
            this.cBPgNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBPgNum_KeyPress);
            // 
            // btnNxtPgMsg
            // 
            this.btnNxtPgMsg.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNxtPgMsg.Image = global::freelancehunt.Properties.Resources.bullet_arrow_right;
            this.btnNxtPgMsg.Location = new System.Drawing.Point(142, 0);
            this.btnNxtPgMsg.Name = "btnNxtPgMsg";
            this.btnNxtPgMsg.Size = new System.Drawing.Size(27, 27);
            this.btnNxtPgMsg.TabIndex = 6;
            this.btnNxtPgMsg.UseVisualStyleBackColor = true;
            this.btnNxtPgMsg.Click += new System.EventHandler(this.btnNxtPgMsg_Click);
            this.btnNxtPgMsg.MouseHover += new System.EventHandler(this.btnNxtPgMsg_MouseHover);
            // 
            // btnPrvPgMsg
            // 
            this.btnPrvPgMsg.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrvPgMsg.Image = global::freelancehunt.Properties.Resources.bullet_arrow_left;
            this.btnPrvPgMsg.Location = new System.Drawing.Point(79, 0);
            this.btnPrvPgMsg.Name = "btnPrvPgMsg";
            this.btnPrvPgMsg.Size = new System.Drawing.Size(27, 27);
            this.btnPrvPgMsg.TabIndex = 5;
            this.btnPrvPgMsg.UseVisualStyleBackColor = true;
            this.btnPrvPgMsg.Click += new System.EventHandler(this.btnPrvPgMsg_Click);
            this.btnPrvPgMsg.MouseHover += new System.EventHandler(this.btnPrvPgMsg_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Страница";
            // 
            // tabFeeds
            // 
            this.tabFeeds.BackColor = System.Drawing.SystemColors.Control;
            this.tabFeeds.Controls.Add(this.scrollFeed);
            this.tabFeeds.Location = new System.Drawing.Point(4, 22);
            this.tabFeeds.Margin = new System.Windows.Forms.Padding(0);
            this.tabFeeds.Name = "tabFeeds";
            this.tabFeeds.Size = new System.Drawing.Size(805, 534);
            this.tabFeeds.TabIndex = 1;
            this.tabFeeds.Text = "tabFeeds";
            // 
            // scrollFeed
            // 
            this.scrollFeed.AutoScroll = true;
            this.scrollFeed.BackColor = System.Drawing.SystemColors.Control;
            this.scrollFeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollFeed.Location = new System.Drawing.Point(0, 0);
            this.scrollFeed.Margin = new System.Windows.Forms.Padding(0);
            this.scrollFeed.MinimumSize = new System.Drawing.Size(300, 300);
            this.scrollFeed.Name = "scrollFeed";
            this.scrollFeed.Padding = new System.Windows.Forms.Padding(3);
            this.scrollFeed.Size = new System.Drawing.Size(805, 534);
            this.scrollFeed.TabIndex = 0;
            this.scrollFeed.Text = "scrollableControl1";
            // 
            // tabUsers
            // 
            this.tabUsers.BackColor = System.Drawing.Color.White;
            this.tabUsers.Controls.Add(this.dataGridView1);
            this.tabUsers.Controls.Add(this.panel3);
            this.tabUsers.Controls.Add(this.panel1);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Margin = new System.Windows.Forms.Padding(0);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Size = new System.Drawing.Size(805, 534);
            this.tabUsers.TabIndex = 2;
            this.tabUsers.Text = "tabUsers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 122);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(805, 412);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Параметр";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Значение";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGoToProfileURL);
            this.panel3.Controls.Add(this.btnProfileSendMessage);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.pnlUserParam);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(805, 91);
            this.panel3.TabIndex = 2;
            // 
            // btnGoToProfileURL
            // 
            this.btnGoToProfileURL.Location = new System.Drawing.Point(58, 64);
            this.btnGoToProfileURL.Name = "btnGoToProfileURL";
            this.btnGoToProfileURL.Size = new System.Drawing.Size(150, 23);
            this.btnGoToProfileURL.TabIndex = 3;
            this.btnGoToProfileURL.Text = "Перейти на страницу";
            this.btnGoToProfileURL.UseVisualStyleBackColor = true;
            this.btnGoToProfileURL.Click += new System.EventHandler(this.btnGoToProfileURL_Click);
            // 
            // btnProfileSendMessage
            // 
            this.btnProfileSendMessage.Location = new System.Drawing.Point(214, 64);
            this.btnProfileSendMessage.Name = "btnProfileSendMessage";
            this.btnProfileSendMessage.Size = new System.Drawing.Size(150, 23);
            this.btnProfileSendMessage.TabIndex = 3;
            this.btnProfileSendMessage.Text = "Написать сообщение";
            this.btnProfileSendMessage.UseVisualStyleBackColor = true;
            this.btnProfileSendMessage.Click += new System.EventHandler(this.btnProfileSendMessage_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(52, 20);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(753, 45);
            this.panel9.TabIndex = 4;
            this.panel9.SizeChanged += new System.EventHandler(this.panel9_SizeChanged);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.pcbUserNegative);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.pictureBox1);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 20);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(2);
            this.panel11.Size = new System.Drawing.Size(753, 20);
            this.panel11.TabIndex = 2;
            // 
            // pcbUserNegative
            // 
            this.pcbUserNegative.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbUserNegative.Location = new System.Drawing.Point(20, 2);
            this.pcbUserNegative.Name = "pcbUserNegative";
            this.pcbUserNegative.Size = new System.Drawing.Size(109, 16);
            this.pcbUserNegative.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUserNegative.TabIndex = 8;
            this.pcbUserNegative.TabStop = false;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(18, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(2, 16);
            this.panel12.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::freelancehunt.Properties.Resources.thumb;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.pcbUserPositive);
            this.panel10.Controls.Add(this.panel14);
            this.panel10.Controls.Add(this.pictureBox5);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(2);
            this.panel10.Size = new System.Drawing.Size(753, 20);
            this.panel10.TabIndex = 1;
            // 
            // pcbUserPositive
            // 
            this.pcbUserPositive.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbUserPositive.Location = new System.Drawing.Point(20, 2);
            this.pcbUserPositive.Name = "pcbUserPositive";
            this.pcbUserPositive.Size = new System.Drawing.Size(109, 16);
            this.pcbUserPositive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUserPositive.TabIndex = 8;
            this.pcbUserPositive.TabStop = false;
            // 
            // panel14
            // 
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(18, 2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(2, 16);
            this.panel14.TabIndex = 12;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox5.Image = global::freelancehunt.Properties.Resources.thumb_up;
            this.pictureBox5.Location = new System.Drawing.Point(2, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(16, 16);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pnlUserParam
            // 
            this.pnlUserParam.Controls.Add(this.pcbUser_OKPAY);
            this.pnlUserParam.Controls.Add(this.panel7);
            this.pnlUserParam.Controls.Add(this.pcbUser_WMID);
            this.pnlUserParam.Controls.Add(this.panel6);
            this.pnlUserParam.Controls.Add(this.pcbUser_Day);
            this.pnlUserParam.Controls.Add(this.panel5);
            this.pnlUserParam.Controls.Add(this.pcbUser_email);
            this.pnlUserParam.Controls.Add(this.panel8);
            this.pnlUserParam.Controls.Add(this.pcbUser_Phone);
            this.pnlUserParam.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserParam.Location = new System.Drawing.Point(52, 0);
            this.pnlUserParam.Name = "pnlUserParam";
            this.pnlUserParam.Padding = new System.Windows.Forms.Padding(2);
            this.pnlUserParam.Size = new System.Drawing.Size(753, 20);
            this.pnlUserParam.TabIndex = 0;
            // 
            // pcbUser_OKPAY
            // 
            this.pcbUser_OKPAY.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbUser_OKPAY.Location = new System.Drawing.Point(80, 2);
            this.pcbUser_OKPAY.Name = "pcbUser_OKPAY";
            this.pcbUser_OKPAY.Size = new System.Drawing.Size(16, 16);
            this.pcbUser_OKPAY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUser_OKPAY.TabIndex = 6;
            this.pcbUser_OKPAY.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(78, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(2, 16);
            this.panel7.TabIndex = 11;
            // 
            // pcbUser_WMID
            // 
            this.pcbUser_WMID.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbUser_WMID.Location = new System.Drawing.Point(62, 2);
            this.pcbUser_WMID.Name = "pcbUser_WMID";
            this.pcbUser_WMID.Size = new System.Drawing.Size(16, 16);
            this.pcbUser_WMID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUser_WMID.TabIndex = 4;
            this.pcbUser_WMID.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(57, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 16);
            this.panel6.TabIndex = 10;
            // 
            // pcbUser_Day
            // 
            this.pcbUser_Day.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbUser_Day.Location = new System.Drawing.Point(41, 2);
            this.pcbUser_Day.Name = "pcbUser_Day";
            this.pcbUser_Day.Size = new System.Drawing.Size(16, 16);
            this.pcbUser_Day.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUser_Day.TabIndex = 2;
            this.pcbUser_Day.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(36, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 16);
            this.panel5.TabIndex = 9;
            // 
            // pcbUser_email
            // 
            this.pcbUser_email.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbUser_email.Location = new System.Drawing.Point(20, 2);
            this.pcbUser_email.Name = "pcbUser_email";
            this.pcbUser_email.Size = new System.Drawing.Size(16, 16);
            this.pcbUser_email.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUser_email.TabIndex = 8;
            this.pcbUser_email.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(18, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(2, 16);
            this.panel8.TabIndex = 7;
            // 
            // pcbUser_Phone
            // 
            this.pcbUser_Phone.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbUser_Phone.Location = new System.Drawing.Point(2, 2);
            this.pcbUser_Phone.Name = "pcbUser_Phone";
            this.pcbUser_Phone.Size = new System.Drawing.Size(16, 16);
            this.pcbUser_Phone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUser_Phone.TabIndex = 0;
            this.pcbUser_Phone.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pcbProfileAvatar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(2);
            this.panel4.Size = new System.Drawing.Size(52, 91);
            this.panel4.TabIndex = 2;
            // 
            // pcbProfileAvatar
            // 
            this.pcbProfileAvatar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbProfileAvatar.Location = new System.Drawing.Point(2, 2);
            this.pcbProfileAvatar.Name = "pcbProfileAvatar";
            this.pcbProfileAvatar.Size = new System.Drawing.Size(50, 87);
            this.pcbProfileAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbProfileAvatar.TabIndex = 2;
            this.pcbProfileAvatar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFindUser);
            this.panel1.Controls.Add(this.txtProfileName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 31);
            this.panel1.TabIndex = 0;
            // 
            // btnFindUser
            // 
            this.btnFindUser.Location = new System.Drawing.Point(280, 3);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Size = new System.Drawing.Size(75, 23);
            this.btnFindUser.TabIndex = 2;
            this.btnFindUser.Text = "Найти";
            this.btnFindUser.UseVisualStyleBackColor = true;
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(74, 5);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(200, 22);
            this.txtProfileName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // tabProjects
            // 
            this.tabProjects.BackColor = System.Drawing.SystemColors.Control;
            this.tabProjects.Controls.Add(this.panel22);
            this.tabProjects.Controls.Add(this.panel19);
            this.tabProjects.Controls.Add(this.panel20);
            this.tabProjects.Location = new System.Drawing.Point(4, 24);
            this.tabProjects.Margin = new System.Windows.Forms.Padding(0);
            this.tabProjects.Name = "tabProjects";
            this.tabProjects.Size = new System.Drawing.Size(805, 532);
            this.tabProjects.TabIndex = 3;
            this.tabProjects.Text = "tabProjects";
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.scrollProjects);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel22.Location = new System.Drawing.Point(0, 0);
            this.panel22.Margin = new System.Windows.Forms.Padding(0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(805, 447);
            this.panel22.TabIndex = 2;
            // 
            // scrollProjects
            // 
            this.scrollProjects.AutoScroll = true;
            this.scrollProjects.BackColor = System.Drawing.SystemColors.Control;
            this.scrollProjects.Cursor = System.Windows.Forms.Cursors.Default;
            this.scrollProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollProjects.Location = new System.Drawing.Point(0, 0);
            this.scrollProjects.MinimumSize = new System.Drawing.Size(0, 300);
            this.scrollProjects.Name = "scrollProjects";
            this.scrollProjects.Padding = new System.Windows.Forms.Padding(3);
            this.scrollProjects.Size = new System.Drawing.Size(805, 447);
            this.scrollProjects.TabIndex = 0;
            this.scrollProjects.Text = "scrollableControl1";
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.SystemColors.Control;
            this.panel19.Controls.Add(this.progressBar1);
            this.panel19.Controls.Add(this.label3);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel19.Location = new System.Drawing.Point(0, 447);
            this.panel19.Name = "panel19";
            this.panel19.Padding = new System.Windows.Forms.Padding(95, 4, 95, 4);
            this.panel19.Size = new System.Drawing.Size(805, 58);
            this.panel19.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.label3.Location = new System.Drawing.Point(98, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Обновление проектов...";
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.SystemColors.Control;
            this.panel20.Controls.Add(this.label5);
            this.panel20.Controls.Add(this.btnFilter);
            this.panel20.Controls.Add(this.comboBox1);
            this.panel20.Controls.Add(this.btnNextPage);
            this.panel20.Controls.Add(this.btnPrewPage);
            this.panel20.Controls.Add(this.lblPage);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel20.Location = new System.Drawing.Point(0, 505);
            this.panel20.Name = "panel20";
            this.panel20.Padding = new System.Windows.Forms.Padding(95, 1, 3, 1);
            this.panel20.Size = new System.Drawing.Size(805, 27);
            this.panel20.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(552, 1);
            this.label5.MinimumSize = new System.Drawing.Size(0, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Проекты не отображаются? Нажмите тут";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.ForeColor = System.Drawing.Color.DimGray;
            this.btnFilter.Location = new System.Drawing.Point(4, 0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(78, 27);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Фильтр";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox1.Location = new System.Drawing.Point(199, 1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(48, 25);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "1";
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNextPage.Image = global::freelancehunt.Properties.Resources.bullet_arrow_right;
            this.btnNextPage.Location = new System.Drawing.Point(245, 0);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(27, 27);
            this.btnNextPage.TabIndex = 2;
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            this.btnNextPage.MouseHover += new System.EventHandler(this.btnNextPage_MouseHover);
            // 
            // btnPrewPage
            // 
            this.btnPrewPage.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrewPage.Image = global::freelancehunt.Properties.Resources.bullet_arrow_left;
            this.btnPrewPage.Location = new System.Drawing.Point(174, 0);
            this.btnPrewPage.Name = "btnPrewPage";
            this.btnPrewPage.Size = new System.Drawing.Size(27, 27);
            this.btnPrewPage.TabIndex = 1;
            this.btnPrewPage.UseVisualStyleBackColor = true;
            this.btnPrewPage.Click += new System.EventHandler(this.btnPrewPage_Click);
            this.btnPrewPage.MouseHover += new System.EventHandler(this.btnPrewPage_MouseHover);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPage.ForeColor = System.Drawing.Color.DimGray;
            this.lblPage.Location = new System.Drawing.Point(99, 5);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(67, 17);
            this.lblPage.TabIndex = 0;
            this.lblPage.Text = "Страница";
            // 
            // tabSearchProj
            // 
            this.tabSearchProj.BackColor = System.Drawing.Color.White;
            this.tabSearchProj.Controls.Add(this.scrollSearchedProject);
            this.tabSearchProj.Controls.Add(this.panel13);
            this.tabSearchProj.Controls.Add(this.splitter1);
            this.tabSearchProj.Controls.Add(this.grpSkills);
            this.tabSearchProj.Location = new System.Drawing.Point(4, 24);
            this.tabSearchProj.Margin = new System.Windows.Forms.Padding(0);
            this.tabSearchProj.Name = "tabSearchProj";
            this.tabSearchProj.Size = new System.Drawing.Size(805, 532);
            this.tabSearchProj.TabIndex = 4;
            this.tabSearchProj.Text = "tabSearchProj";
            // 
            // scrollSearchedProject
            // 
            this.scrollSearchedProject.AutoScroll = true;
            this.scrollSearchedProject.BackColor = System.Drawing.SystemColors.Control;
            this.scrollSearchedProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollSearchedProject.Location = new System.Drawing.Point(233, 0);
            this.scrollSearchedProject.Name = "scrollSearchedProject";
            this.scrollSearchedProject.Size = new System.Drawing.Size(572, 502);
            this.scrollSearchedProject.TabIndex = 4;
            this.scrollSearchedProject.Text = "scrollableControl1";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.Control;
            this.panel13.Controls.Add(this.pnlPageNavigation);
            this.panel13.Controls.Add(this.btnFltr);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(233, 502);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(572, 30);
            this.panel13.TabIndex = 2;
            // 
            // pnlPageNavigation
            // 
            this.pnlPageNavigation.Controls.Add(this.panel18);
            this.pnlPageNavigation.Controls.Add(this.panel17);
            this.pnlPageNavigation.Controls.Add(this.panel16);
            this.pnlPageNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPageNavigation.Location = new System.Drawing.Point(125, 0);
            this.pnlPageNavigation.Name = "pnlPageNavigation";
            this.pnlPageNavigation.Size = new System.Drawing.Size(115, 30);
            this.pnlPageNavigation.TabIndex = 0;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.SystemColors.Control;
            this.panel18.Controls.Add(this.cmbPageNum);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(32, 0);
            this.panel18.MaximumSize = new System.Drawing.Size(58, 0);
            this.panel18.Name = "panel18";
            this.panel18.Padding = new System.Windows.Forms.Padding(5, 4, 5, 0);
            this.panel18.Size = new System.Drawing.Size(51, 30);
            this.panel18.TabIndex = 3;
            // 
            // cmbPageNum
            // 
            this.cmbPageNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPageNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPageNum.FormattingEnabled = true;
            this.cmbPageNum.Location = new System.Drawing.Point(5, 4);
            this.cmbPageNum.Name = "cmbPageNum";
            this.cmbPageNum.Size = new System.Drawing.Size(41, 23);
            this.cmbPageNum.TabIndex = 0;
            this.cmbPageNum.SelectedIndexChanged += new System.EventHandler(this.cmbPageNum_SelectedIndexChanged);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.pcbPagePlus);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel17.Location = new System.Drawing.Point(83, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(32, 30);
            this.panel17.TabIndex = 2;
            // 
            // pcbPagePlus
            // 
            this.pcbPagePlus.BackColor = System.Drawing.SystemColors.Control;
            this.pcbPagePlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbPagePlus.Image = global::freelancehunt.Properties.Resources.bullet_arrow_right;
            this.pcbPagePlus.Location = new System.Drawing.Point(0, 0);
            this.pcbPagePlus.Name = "pcbPagePlus";
            this.pcbPagePlus.Size = new System.Drawing.Size(32, 30);
            this.pcbPagePlus.TabIndex = 1;
            this.pcbPagePlus.TabStop = false;
            this.pcbPagePlus.Click += new System.EventHandler(this.pcbPagePlus_Click);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.pcbPageMinus);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(32, 30);
            this.panel16.TabIndex = 1;
            // 
            // pcbPageMinus
            // 
            this.pcbPageMinus.BackColor = System.Drawing.SystemColors.Control;
            this.pcbPageMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbPageMinus.Image = global::freelancehunt.Properties.Resources.bullet_arrow_left;
            this.pcbPageMinus.Location = new System.Drawing.Point(0, 0);
            this.pcbPageMinus.Name = "pcbPageMinus";
            this.pcbPageMinus.Size = new System.Drawing.Size(32, 30);
            this.pcbPageMinus.TabIndex = 0;
            this.pcbPageMinus.TabStop = false;
            this.pcbPageMinus.Click += new System.EventHandler(this.pcbPageMinus_Click);
            // 
            // btnFltr
            // 
            this.btnFltr.AutoSize = true;
            this.btnFltr.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFltr.Location = new System.Drawing.Point(0, 0);
            this.btnFltr.Name = "btnFltr";
            this.btnFltr.Size = new System.Drawing.Size(125, 30);
            this.btnFltr.TabIndex = 1;
            this.btnFltr.Text = ">> Показать навыки";
            this.btnFltr.UseVisualStyleBackColor = true;
            this.btnFltr.Click += new System.EventHandler(this.btnFltr_Click);
            this.btnFltr.MouseHover += new System.EventHandler(this.btnFltr_MouseHover);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.Control;
            this.splitter1.Location = new System.Drawing.Point(230, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 532);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            this.splitter1.Visible = false;
            // 
            // grpSkills
            // 
            this.grpSkills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(163)))), ((int)(((byte)(89)))));
            this.grpSkills.Controls.Add(this.lstSkill);
            this.grpSkills.Controls.Add(this.toolStrip2);
            this.grpSkills.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpSkills.ForeColor = System.Drawing.Color.White;
            this.grpSkills.Location = new System.Drawing.Point(0, 0);
            this.grpSkills.MaximumSize = new System.Drawing.Size(300, 0);
            this.grpSkills.MinimumSize = new System.Drawing.Size(230, 0);
            this.grpSkills.Name = "grpSkills";
            this.grpSkills.Size = new System.Drawing.Size(230, 532);
            this.grpSkills.TabIndex = 0;
            this.grpSkills.TabStop = false;
            this.grpSkills.Text = "Навыки";
            this.grpSkills.Visible = false;
            // 
            // lstSkill
            // 
            this.lstSkill.BackColor = System.Drawing.Color.White;
            this.lstSkill.CheckOnClick = true;
            this.lstSkill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSkill.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstSkill.FormattingEnabled = true;
            this.lstSkill.Location = new System.Drawing.Point(3, 43);
            this.lstSkill.Name = "lstSkill";
            this.lstSkill.Size = new System.Drawing.Size(224, 486);
            this.lstSkill.TabIndex = 0;
            this.lstSkill.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstSkill_ItemCheck_1);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(163)))), ((int)(((byte)(89)))));
            this.toolStrip2.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveSkills,
            this.btnOpenSkill,
            this.toolStripButton7,
            this.btnFilterOnOff,
            this.toolStripDropDownButton1});
            this.toolStrip2.Location = new System.Drawing.Point(3, 18);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.Size = new System.Drawing.Size(224, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnSaveSkills
            // 
            this.btnSaveSkills.AutoToolTip = false;
            this.btnSaveSkills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(163)))), ((int)(((byte)(89)))));
            this.btnSaveSkills.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSaveSkills.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.btnSaveSkills.ForeColor = System.Drawing.Color.White;
            this.btnSaveSkills.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(143)))), ((int)(((byte)(69)))));
            this.btnSaveSkills.Name = "btnSaveSkills";
            this.btnSaveSkills.Size = new System.Drawing.Size(70, 22);
            this.btnSaveSkills.Text = "Сохранить";
            this.btnSaveSkills.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSaveSkills.ToolTipText = "Сохранить текущий выбор";
            this.btnSaveSkills.Visible = false;
            this.btnSaveSkills.Click += new System.EventHandler(this.btnSaveSkills_Click);
            this.btnSaveSkills.MouseEnter += new System.EventHandler(this.btnToolStrip2_MouseEnter);
            // 
            // btnOpenSkill
            // 
            this.btnOpenSkill.AutoToolTip = false;
            this.btnOpenSkill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(163)))), ((int)(((byte)(89)))));
            this.btnOpenSkill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOpenSkill.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.btnOpenSkill.ForeColor = System.Drawing.Color.White;
            this.btnOpenSkill.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(143)))), ((int)(((byte)(69)))));
            this.btnOpenSkill.Name = "btnOpenSkill";
            this.btnOpenSkill.Size = new System.Drawing.Size(65, 22);
            this.btnOpenSkill.Text = "Отменить";
            this.btnOpenSkill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOpenSkill.ToolTipText = "Откатить изменения в выборке до последнего сохраненного состояния";
            this.btnOpenSkill.Visible = false;
            this.btnOpenSkill.Click += new System.EventHandler(this.btnOpenSkill_Click);
            this.btnOpenSkill.MouseEnter += new System.EventHandler(this.btnToolStrip2_MouseEnter);
            this.btnOpenSkill.MouseLeave += new System.EventHandler(this.btnToolStrip2_MouseLeave);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.AutoToolTip = false;
            this.toolStripButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(163)))), ((int)(((byte)(89)))));
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton7.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.toolStripButton7.ForeColor = System.Drawing.Color.White;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(143)))), ((int)(((byte)(69)))));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(44, 22);
            this.toolStripButton7.Text = "Найти";
            this.toolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton7.ToolTipText = "Найти проекты";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            this.toolStripButton7.MouseEnter += new System.EventHandler(this.btnToolStrip2_MouseEnter);
            this.toolStripButton7.MouseLeave += new System.EventHandler(this.btnToolStrip2_MouseLeave);
            // 
            // btnFilterOnOff
            // 
            this.btnFilterOnOff.AutoToolTip = false;
            this.btnFilterOnOff.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFilterOnOff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilterOnOff.Name = "btnFilterOnOff";
            this.btnFilterOnOff.Size = new System.Drawing.Size(65, 22);
            this.btnFilterOnOff.Text = "Включить";
            this.btnFilterOnOff.ToolTipText = "Включить/Отключить показ проектов только из выбранных категорий";
            this.btnFilterOnOff.Click += new System.EventHandler(this.btnFilterOnOff_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.AutoToolTip = false;
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(163)))), ((int)(((byte)(89)))));
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSkills_Save,
            this.mnuSkills_Cancel,
            this.mnuSkills_selectAll,
            this.mnuSkills_unSelectAll,
            this.mnuSkills_invert});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(143)))), ((int)(((byte)(69)))));
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(68, 22);
            this.toolStripDropDownButton1.Text = "Выборка";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripDropDownButton1.MouseEnter += new System.EventHandler(this.btnToolStrip2_MouseEnter);
            this.toolStripDropDownButton1.MouseLeave += new System.EventHandler(this.btnToolStrip2_MouseLeave);
            // 
            // mnuSkills_Save
            // 
            this.mnuSkills_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(163)))), ((int)(((byte)(89)))));
            this.mnuSkills_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuSkills_Save.ForeColor = System.Drawing.Color.White;
            this.mnuSkills_Save.Name = "mnuSkills_Save";
            this.mnuSkills_Save.Size = new System.Drawing.Size(190, 22);
            this.mnuSkills_Save.Text = "Сохранить";
            this.mnuSkills_Save.ToolTipText = "Сохранить текущий выбор";
            this.mnuSkills_Save.Click += new System.EventHandler(this.btnSaveSkills_Click);
            // 
            // mnuSkills_Cancel
            // 
            this.mnuSkills_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(163)))), ((int)(((byte)(89)))));
            this.mnuSkills_Cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuSkills_Cancel.ForeColor = System.Drawing.Color.White;
            this.mnuSkills_Cancel.Name = "mnuSkills_Cancel";
            this.mnuSkills_Cancel.Size = new System.Drawing.Size(190, 22);
            this.mnuSkills_Cancel.Text = "Отменить изменения";
            this.mnuSkills_Cancel.ToolTipText = "Откатить изменения в выборке до последнего сохраненного состояния";
            this.mnuSkills_Cancel.Click += new System.EventHandler(this.btnOpenSkill_Click);
            // 
            // mnuSkills_selectAll
            // 
            this.mnuSkills_selectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(163)))), ((int)(((byte)(89)))));
            this.mnuSkills_selectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuSkills_selectAll.ForeColor = System.Drawing.Color.White;
            this.mnuSkills_selectAll.Name = "mnuSkills_selectAll";
            this.mnuSkills_selectAll.Size = new System.Drawing.Size(190, 22);
            this.mnuSkills_selectAll.Text = "Выбрать все";
            this.mnuSkills_selectAll.Click += new System.EventHandler(this.mnuSkills_selectAll_Click);
            this.mnuSkills_selectAll.MouseEnter += new System.EventHandler(this.btnToolStrip2_MouseEnter);
            this.mnuSkills_selectAll.MouseLeave += new System.EventHandler(this.btnToolStrip2_MouseLeave);
            // 
            // mnuSkills_unSelectAll
            // 
            this.mnuSkills_unSelectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(163)))), ((int)(((byte)(89)))));
            this.mnuSkills_unSelectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuSkills_unSelectAll.ForeColor = System.Drawing.Color.White;
            this.mnuSkills_unSelectAll.Name = "mnuSkills_unSelectAll";
            this.mnuSkills_unSelectAll.Size = new System.Drawing.Size(190, 22);
            this.mnuSkills_unSelectAll.Text = "Очистить выбор";
            this.mnuSkills_unSelectAll.Click += new System.EventHandler(this.mnuSkills_unSelectAll_Click);
            this.mnuSkills_unSelectAll.MouseEnter += new System.EventHandler(this.btnToolStrip2_MouseEnter);
            this.mnuSkills_unSelectAll.MouseLeave += new System.EventHandler(this.btnToolStrip2_MouseLeave);
            // 
            // mnuSkills_invert
            // 
            this.mnuSkills_invert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(163)))), ((int)(((byte)(89)))));
            this.mnuSkills_invert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuSkills_invert.ForeColor = System.Drawing.Color.White;
            this.mnuSkills_invert.Name = "mnuSkills_invert";
            this.mnuSkills_invert.Size = new System.Drawing.Size(190, 22);
            this.mnuSkills_invert.Text = "Инвертировать";
            this.mnuSkills_invert.Click += new System.EventHandler(this.mnuSkills_invert_Click);
            this.mnuSkills_invert.MouseEnter += new System.EventHandler(this.btnToolStrip2_MouseEnter);
            this.mnuSkills_invert.MouseLeave += new System.EventHandler(this.btnToolStrip2_MouseLeave);
            // 
            // tabDialog
            // 
            this.tabDialog.BackColor = System.Drawing.Color.White;
            this.tabDialog.Controls.Add(this.splitter2);
            this.tabDialog.Controls.Add(this.panel24);
            this.tabDialog.Controls.Add(this.panel23);
            this.tabDialog.Location = new System.Drawing.Point(4, 22);
            this.tabDialog.Margin = new System.Windows.Forms.Padding(0);
            this.tabDialog.Name = "tabDialog";
            this.tabDialog.Size = new System.Drawing.Size(805, 534);
            this.tabDialog.TabIndex = 5;
            this.tabDialog.Text = "tabDialog";
            this.tabDialog.UseVisualStyleBackColor = true;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitter2.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 488);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(805, 2);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.scrollMessDialog);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel24.Location = new System.Drawing.Point(0, 0);
            this.panel24.Margin = new System.Windows.Forms.Padding(0);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(805, 490);
            this.panel24.TabIndex = 5;
            // 
            // scrollMessDialog
            // 
            this.scrollMessDialog.AutoScroll = true;
            this.scrollMessDialog.BackColor = System.Drawing.SystemColors.Control;
            this.scrollMessDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollMessDialog.Location = new System.Drawing.Point(0, 0);
            this.scrollMessDialog.Name = "scrollMessDialog";
            this.scrollMessDialog.Padding = new System.Windows.Forms.Padding(3);
            this.scrollMessDialog.Size = new System.Drawing.Size(805, 490);
            this.scrollMessDialog.TabIndex = 1;
            this.scrollMessDialog.Text = "scrollMessDialog";
            this.scrollMessDialog.SizeChanged += new System.EventHandler(this.scrollMessDialog_SizeChanged);
            this.scrollMessDialog.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.scrollMessDialog_ControlAdded);
            // 
            // panel23
            // 
            this.panel23.AutoScroll = true;
            this.panel23.Controls.Add(this.txtNewMessage);
            this.panel23.Controls.Add(this.btnSendMessage);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel23.Location = new System.Drawing.Point(0, 490);
            this.panel23.Margin = new System.Windows.Forms.Padding(0);
            this.panel23.MaximumSize = new System.Drawing.Size(0, 180);
            this.panel23.MinimumSize = new System.Drawing.Size(0, 25);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(805, 44);
            this.panel23.TabIndex = 4;
            // 
            // txtNewMessage
            // 
            this.txtNewMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewMessage.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNewMessage.Location = new System.Drawing.Point(0, 0);
            this.txtNewMessage.MaximumSize = new System.Drawing.Size(0, 180);
            this.txtNewMessage.MinimumSize = new System.Drawing.Size(0, 25);
            this.txtNewMessage.Multiline = true;
            this.txtNewMessage.Name = "txtNewMessage";
            this.txtNewMessage.Size = new System.Drawing.Size(725, 44);
            this.txtNewMessage.TabIndex = 3;
            this.txtNewMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewMessage_KeyPress);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.btnSendMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSendMessage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.btnSendMessage.FlatAppearance.BorderSize = 0;
            this.btnSendMessage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.btnSendMessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.btnSendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMessage.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSendMessage.ForeColor = System.Drawing.Color.White;
            this.btnSendMessage.Location = new System.Drawing.Point(725, 0);
            this.btnSendMessage.MaximumSize = new System.Drawing.Size(80, 180);
            this.btnSendMessage.MinimumSize = new System.Drawing.Size(80, 25);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(80, 44);
            this.btnSendMessage.TabIndex = 2;
            this.btnSendMessage.Text = "Отправить";
            this.btnSendMessage.UseVisualStyleBackColor = false;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // tabUserList
            // 
            this.tabUserList.BackColor = System.Drawing.Color.White;
            this.tabUserList.Controls.Add(this.panel15);
            this.tabUserList.Location = new System.Drawing.Point(4, 22);
            this.tabUserList.Margin = new System.Windows.Forms.Padding(0);
            this.tabUserList.Name = "tabUserList";
            this.tabUserList.Size = new System.Drawing.Size(805, 534);
            this.tabUserList.TabIndex = 6;
            this.tabUserList.Text = "tabUserList";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panel15.Controls.Add(this.tbSearch);
            this.panel15.Controls.Add(this.panel21);
            this.panel15.Controls.Add(this.button1);
            this.panel15.Controls.Add(this.pictureBox3);
            this.panel15.Controls.Add(this.label2);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Margin = new System.Windows.Forms.Padding(0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(805, 54);
            this.panel15.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.BackColor = System.Drawing.Color.White;
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch.Location = new System.Drawing.Point(120, 19);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 16, 3, 3);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(549, 16);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // panel21
            // 
            this.panel21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel21.BackColor = System.Drawing.Color.White;
            this.panel21.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel21.Location = new System.Drawing.Point(117, 6);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(555, 42);
            this.panel21.TabIndex = 4;
            this.panel21.Click += new System.EventHandler(this.panel21_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::freelancehunt.Properties.Resources.srch_go_btn;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(675, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Поиск";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn1FindUser_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 54);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(59, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 54);
            this.label2.TabIndex = 0;
            this.label2.Text = "Логин";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notify
            // 
            this.notify.ContextMenuStrip = this.mnuPopup;
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "Freelancehunt Monitor";
            this.notify.Visible = true;
            this.notify.Click += new System.EventHandler(this.notify_Click);
            this.notify.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notify_MouseDown);
            // 
            // mnuPopup
            // 
            this.mnuPopup.BackColor = System.Drawing.Color.White;
            this.mnuPopup.Font = new System.Drawing.Font("Open Sans", 9F);
            this.mnuPopup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRefresh,
            this.toolStripMenuItem2,
            this.mnuShow,
            this.mnuShowConfig,
            this.toolStripMenuItem3,
            this.mnuChangeUser,
            this.mnuExit});
            this.mnuPopup.Name = "mnuPopup";
            this.mnuPopup.Size = new System.Drawing.Size(215, 126);
            // 
            // mnuRefresh
            // 
            this.mnuRefresh.Name = "mnuRefresh";
            this.mnuRefresh.Size = new System.Drawing.Size(214, 22);
            this.mnuRefresh.Text = "Обновить";
            this.mnuRefresh.Click += new System.EventHandler(this.mnuRefresh_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(211, 6);
            // 
            // mnuShow
            // 
            this.mnuShow.Name = "mnuShow";
            this.mnuShow.Size = new System.Drawing.Size(214, 22);
            this.mnuShow.Text = "Показать";
            this.mnuShow.Click += new System.EventHandler(this.mnuShow_Click);
            // 
            // mnuShowConfig
            // 
            this.mnuShowConfig.Name = "mnuShowConfig";
            this.mnuShowConfig.Size = new System.Drawing.Size(214, 22);
            this.mnuShowConfig.Text = "Настройки";
            this.mnuShowConfig.Click += new System.EventHandler(this.mnuShowConfig_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(211, 6);
            // 
            // mnuChangeUser
            // 
            this.mnuChangeUser.Name = "mnuChangeUser";
            this.mnuChangeUser.Size = new System.Drawing.Size(214, 22);
            this.mnuChangeUser.Text = "Сменить пользователя";
            this.mnuChangeUser.Click += new System.EventHandler(this.mnuChangeUser_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(214, 22);
            this.mnuExit.Text = "Выход";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblLastAction);
            this.panel2.Controls.Add(this.lblLastUpdate);
            this.panel2.Controls.Add(this.pcbPing);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(171, 560);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(813, 1);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // lblLastAction
            // 
            this.lblLastAction.Location = new System.Drawing.Point(30, 0);
            this.lblLastAction.Name = "lblLastAction";
            this.lblLastAction.Size = new System.Drawing.Size(492, 24);
            this.lblLastAction.TabIndex = 1;
            this.lblLastAction.Text = "--";
            this.lblLastAction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.Location = new System.Drawing.Point(522, 0);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(137, 24);
            this.lblLastUpdate.TabIndex = 0;
            this.lblLastUpdate.Text = "--";
            this.lblLastUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbPing
            // 
            this.pcbPing.Image = global::freelancehunt.Properties.Resources.world_gray;
            this.pcbPing.Location = new System.Drawing.Point(0, 0);
            this.pcbPing.Name = "pcbPing";
            this.pcbPing.Size = new System.Drawing.Size(24, 24);
            this.pcbPing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPing.TabIndex = 2;
            this.pcbPing.TabStop = false;
            // 
            // timerProgress
            // 
            this.timerProgress.Interval = 250;
            this.timerProgress.Tick += new System.EventHandler(this.timerProgress_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(205)))), ((int)(((byte)(192)))));
            this.progressBar1.BgrColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.progressBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(205)))), ((int)(((byte)(192)))));
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.FillStyle = freelancehunt.cProgressBar.FillStyles.Solid;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(205)))), ((int)(((byte)(192)))));
            this.progressBar1.Location = new System.Drawing.Point(95, 29);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Minimum = 0;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(615, 25);
            this.progressBar1.Step = 10;
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 0;
            this.progressBar1.радиус_скругления = 6;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(159)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.Text = "Freelancehunt Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabLoading.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoadOrange)).EndInit();
            this.tabMessages.ResumeLayout(false);
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.tabFeeds.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserNegative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserPositive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnlUserParam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser_OKPAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser_WMID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser_Day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser_Phone)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfileAvatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabProjects.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.tabSearchProj.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.pnlPageNavigation.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPagePlus)).EndInit();
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPageMinus)).EndInit();
            this.grpSkills.ResumeLayout(false);
            this.grpSkills.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabDialog.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.tabUserList.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.mnuPopup.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        //private static TabControl tabControl1;
        private TabControl tabControl1;
        private TabPage tabMessages;
        private TabPage tabFeeds;
        private TabPage tabUsers;
        private TabPage tabProjects;
        private TabPage tabSearchProj;
        private TabPage tabDialog;
		
		private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private NotifyIcon notify;
        private ScrollableControl scrollMessDialog;
        private ScrollableControl scrollMessages;
        private ScrollableControl scrollFeed;
        private Panel panel2;
        private PictureBox pcbPing;
        private Label lblLastAction;
        private Label lblLastUpdate;
        private Panel panel1;
        private Label label1;
        private Button btnFindUser;
        private TextBox txtProfileName;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pcbProfileAvatar;
        private Panel pnlUserParam;
        private PictureBox pcbUser_Phone;
        private Panel panel8;
        private PictureBox pcbUser_email;
        private PictureBox pcbUser_Day;
        private Panel panel5;
        private PictureBox pcbUser_WMID;
        private Panel panel6;
        private PictureBox pcbUser_OKPAY;
        private Panel panel7;
        private Panel panel9;
        private Panel panel10;
        private Panel panel14;
        private PictureBox pictureBox5;
        private PictureBox pcbUserPositive;
        private Panel panel11;
        private PictureBox pcbUserNegative;
        private Panel panel12;
        private PictureBox pictureBox1;
        private Button btnProfileSendMessage;
        private Button btnGoToProfileURL;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private ScrollableControl scrollProjects;
        private GroupBox grpSkills;
        private Splitter splitter1;
        private CheckedListBox lstSkill;
        private ToolStrip toolStrip2;
        private ToolStripButton btnOpenSkill;
        private ToolStripButton toolStripButton7;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem mnuSkills_selectAll;
        private ToolStripMenuItem mnuSkills_unSelectAll;
        private ToolStripMenuItem mnuSkills_invert;
        private ContextMenuStrip mnuPopup;
        private ToolStripMenuItem mnuRefresh;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem mnuShow;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem mnuExit;
        private ScrollableControl scrollSearchedProject;
        private Panel panel13;
        private Panel pnlPageNavigation;
        private Panel panel18;
        private Panel panel17;
        private Panel panel16;
        private PictureBox pcbPageMinus;
        private ComboBox cmbPageNum;
        private PictureBox pcbPagePlus;
        private ToolStrip toolStrip1;
        private TabPage tabUserList;
        private Panel panel15;
        private Label label2;
        private PictureBox pictureBox3;
        private Button button1;
        private TextBox tbSearch;
        private Panel panel19;
        private Label label3;
        private TabPage tabLoading;
        private Label label4;
        private Panel panel22;
        private Panel panel21;
        //private ProgressBar progressBar1;
        private cProgressBar progressBar1;
        private Panel panel20;
        private Label lblPage;
        private ComboBox comboBox1;
        private Button btnNextPage;
        private Button btnPrewPage;
        private Panel panel23;
        private TextBox txtNewMessage;
        private Button btnSendMessage;
        private ToolStripMenuItem mnuShowConfig;
        private Timer timerProgress;
        private Button btnFilter;
        private Button btnFltr;
        private Label label5;
        private Splitter splitter2;
        private Panel panel24;
        private PictureBox pcbLoadOrange;
        private Panel panel25;
        private ToolStripMenuItem mnuChangeUser;
        private Panel panel26;
        private ComboBox cBPgNum;
        private Button btnNxtPgMsg;
        private Button btnPrvPgMsg;
        private Label label6;
        private ToolStripButton btnFilterOnOff;
        private ToolStripButton btnSaveSkills;
        private ToolStripMenuItem mnuSkills_Save;
        private ToolStripMenuItem mnuSkills_Cancel;
    }
}

