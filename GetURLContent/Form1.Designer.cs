namespace GetURLContent
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
            this.btnStart = new System.Windows.Forms.Button();
            this.tbExtractResultURLs = new System.Windows.Forms.TextBox();
            this.tbSourceURLs = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCountOfRandomUrls = new System.Windows.Forms.TextBox();
            this.checkBoxIsRandomGen = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNumberOfEndUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPartOfUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.tbNumberOfBeginUrl = new System.Windows.Forms.TextBox();
            this.tbEndOfUrl = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonGallerysense = new System.Windows.Forms.RadioButton();
            this.btnGetURLsLink = new System.Windows.Forms.Button();
            this.radioButtonImagezilla = new System.Windows.Forms.RadioButton();
            this.tbSourceURL = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelErrorFlag = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.progressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chbUseSourceURLList = new System.Windows.Forms.CheckBox();
            this.btnPauseAllTask = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnStartEx = new System.Windows.Forms.Button();
            this.btnStopAllTask = new System.Windows.Forms.Button();
            this.tbCountOfTask = new System.Windows.Forms.TextBox();
            this.btnStartTask = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbDirectoryStart = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(103, 68);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbExtractResultURLs
            // 
            this.tbExtractResultURLs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbExtractResultURLs.Location = new System.Drawing.Point(0, 0);
            this.tbExtractResultURLs.Multiline = true;
            this.tbExtractResultURLs.Name = "tbExtractResultURLs";
            this.tbExtractResultURLs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbExtractResultURLs.Size = new System.Drawing.Size(511, 448);
            this.tbExtractResultURLs.TabIndex = 3;
            // 
            // tbSourceURLs
            // 
            this.tbSourceURLs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSourceURLs.Location = new System.Drawing.Point(0, 0);
            this.tbSourceURLs.Multiline = true;
            this.tbSourceURLs.Name = "tbSourceURLs";
            this.tbSourceURLs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSourceURLs.Size = new System.Drawing.Size(398, 448);
            this.tbSourceURLs.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 110);
            this.panel1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbCountOfRandomUrls);
            this.groupBox2.Controls.Add(this.checkBoxIsRandomGen);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbNumberOfEndUrl);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbPartOfUrl);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnBegin);
            this.groupBox2.Controls.Add(this.tbNumberOfBeginUrl);
            this.groupBox2.Controls.Add(this.tbEndOfUrl);
            this.groupBox2.Location = new System.Drawing.Point(446, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Count of Random URL";
            // 
            // tbCountOfRandomUrls
            // 
            this.tbCountOfRandomUrls.Location = new System.Drawing.Point(307, 70);
            this.tbCountOfRandomUrls.Name = "tbCountOfRandomUrls";
            this.tbCountOfRandomUrls.Size = new System.Drawing.Size(55, 20);
            this.tbCountOfRandomUrls.TabIndex = 27;
            this.tbCountOfRandomUrls.Text = "100";
            // 
            // checkBoxIsRandomGen
            // 
            this.checkBoxIsRandomGen.AutoSize = true;
            this.checkBoxIsRandomGen.Location = new System.Drawing.Point(369, 72);
            this.checkBoxIsRandomGen.Name = "checkBoxIsRandomGen";
            this.checkBoxIsRandomGen.Size = new System.Drawing.Size(86, 17);
            this.checkBoxIsRandomGen.TabIndex = 6;
            this.checkBoxIsRandomGen.Text = "RandomGen";
            this.checkBoxIsRandomGen.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "End of URL";
            // 
            // tbNumberOfEndUrl
            // 
            this.tbNumberOfEndUrl.Location = new System.Drawing.Point(308, 44);
            this.tbNumberOfEndUrl.Name = "tbNumberOfEndUrl";
            this.tbNumberOfEndUrl.Size = new System.Drawing.Size(55, 20);
            this.tbNumberOfEndUrl.TabIndex = 25;
            this.tbNumberOfEndUrl.Text = "903915";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Part URL";
            // 
            // tbPartOfUrl
            // 
            this.tbPartOfUrl.Location = new System.Drawing.Point(71, 16);
            this.tbPartOfUrl.Name = "tbPartOfUrl";
            this.tbPartOfUrl.Size = new System.Drawing.Size(387, 20);
            this.tbPartOfUrl.TabIndex = 23;
            this.tbPartOfUrl.Text = "http://gallerynova.se/site/v/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Begin of URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "End of URL";
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(72, 68);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(87, 23);
            this.btnBegin.TabIndex = 18;
            this.btnBegin.Text = "GenURLS";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // tbNumberOfBeginUrl
            // 
            this.tbNumberOfBeginUrl.Location = new System.Drawing.Point(184, 44);
            this.tbNumberOfBeginUrl.Name = "tbNumberOfBeginUrl";
            this.tbNumberOfBeginUrl.Size = new System.Drawing.Size(55, 20);
            this.tbNumberOfBeginUrl.TabIndex = 17;
            this.tbNumberOfBeginUrl.Text = "900000";
            // 
            // tbEndOfUrl
            // 
            this.tbEndOfUrl.Location = new System.Drawing.Point(72, 44);
            this.tbEndOfUrl.Name = "tbEndOfUrl";
            this.tbEndOfUrl.Size = new System.Drawing.Size(38, 20);
            this.tbEndOfUrl.TabIndex = 15;
            this.tbEndOfUrl.Text = ".jpg";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonGallerysense);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.btnGetURLsLink);
            this.groupBox1.Controls.Add(this.radioButtonImagezilla);
            this.groupBox1.Controls.Add(this.tbSourceURL);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonGallerysense
            // 
            this.radioButtonGallerysense.AutoSize = true;
            this.radioButtonGallerysense.Checked = true;
            this.radioButtonGallerysense.Location = new System.Drawing.Point(21, 19);
            this.radioButtonGallerysense.Name = "radioButtonGallerysense";
            this.radioButtonGallerysense.Size = new System.Drawing.Size(97, 17);
            this.radioButtonGallerysense.TabIndex = 2;
            this.radioButtonGallerysense.TabStop = true;
            this.radioButtonGallerysense.Text = "gallerysense.se";
            this.radioButtonGallerysense.UseVisualStyleBackColor = true;
            // 
            // btnGetURLsLink
            // 
            this.btnGetURLsLink.Location = new System.Drawing.Point(12, 68);
            this.btnGetURLsLink.Name = "btnGetURLsLink";
            this.btnGetURLsLink.Size = new System.Drawing.Size(85, 23);
            this.btnGetURLsLink.TabIndex = 5;
            this.btnGetURLsLink.Text = "Get URLs link";
            this.btnGetURLsLink.UseVisualStyleBackColor = true;
            this.btnGetURLsLink.Click += new System.EventHandler(this.btnGetURLsLink_Click);
            // 
            // radioButtonImagezilla
            // 
            this.radioButtonImagezilla.AutoSize = true;
            this.radioButtonImagezilla.Location = new System.Drawing.Point(122, 19);
            this.radioButtonImagezilla.Name = "radioButtonImagezilla";
            this.radioButtonImagezilla.Size = new System.Drawing.Size(88, 17);
            this.radioButtonImagezilla.TabIndex = 3;
            this.radioButtonImagezilla.Text = "imagezilla.net";
            this.radioButtonImagezilla.UseVisualStyleBackColor = true;
            // 
            // tbSourceURL
            // 
            this.tbSourceURL.Location = new System.Drawing.Point(12, 42);
            this.tbSourceURL.Name = "tbSourceURL";
            this.tbSourceURL.Size = new System.Drawing.Size(416, 20);
            this.tbSourceURL.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelErrorFlag,
            this.toolStripSplitButton1,
            this.progressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 582);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(909, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelErrorFlag
            // 
            this.toolStripStatusLabelErrorFlag.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.toolStripStatusLabelErrorFlag.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabelErrorFlag.IsLink = true;
            this.toolStripStatusLabelErrorFlag.LinkColor = System.Drawing.Color.Red;
            this.toolStripStatusLabelErrorFlag.Name = "toolStripStatusLabelErrorFlag";
            this.toolStripStatusLabelErrorFlag.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabelErrorFlag.Text = "Error List";
            this.toolStripStatusLabelErrorFlag.Visible = false;
            this.toolStripStatusLabelErrorFlag.Click += new System.EventHandler(this.toolStripStatusLabelErrorFlag_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(16, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // progressBar1
            // 
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(350, 16);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(81, 17);
            this.toolStripStatusLabel1.Text = "Active Task {0}";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbSourceURLs);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 448);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbExtractResultURLs);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(401, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(511, 448);
            this.panel3.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 113);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(909, 21);
            this.panel5.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "_";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "_";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(923, 633);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitter1);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(915, 607);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SingleMode";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(401, 134);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 448);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(915, 607);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MultiTaskMode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 108);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(909, 496);
            this.panel6.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(909, 496);
            this.dataGridView1.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(909, 105);
            this.panel4.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.chbUseSourceURLList);
            this.groupBox3.Controls.Add(this.btnPauseAllTask);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnStartEx);
            this.groupBox3.Controls.Add(this.btnStopAllTask);
            this.groupBox3.Controls.Add(this.tbCountOfTask);
            this.groupBox3.Controls.Add(this.btnStartTask);
            this.groupBox3.Location = new System.Drawing.Point(5, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(899, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // chbUseSourceURLList
            // 
            this.chbUseSourceURLList.AutoSize = true;
            this.chbUseSourceURLList.Location = new System.Drawing.Point(6, 48);
            this.chbUseSourceURLList.Name = "chbUseSourceURLList";
            this.chbUseSourceURLList.Size = new System.Drawing.Size(65, 17);
            this.chbUseSourceURLList.TabIndex = 6;
            this.chbUseSourceURLList.Text = "Verbose";
            this.chbUseSourceURLList.UseVisualStyleBackColor = true;
            this.chbUseSourceURLList.CheckedChanged += new System.EventHandler(this.chbUseSourceURLList_CheckedChanged);
            // 
            // btnPauseAllTask
            // 
            this.btnPauseAllTask.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPauseAllTask.Location = new System.Drawing.Point(132, 71);
            this.btnPauseAllTask.Name = "btnPauseAllTask";
            this.btnPauseAllTask.Size = new System.Drawing.Size(75, 23);
            this.btnPauseAllTask.TabIndex = 5;
            this.btnPauseAllTask.Text = "PauseAll";
            this.btnPauseAllTask.UseVisualStyleBackColor = true;
            this.btnPauseAllTask.Click += new System.EventHandler(this.btnPauseAllTask_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Max Task";
            // 
            // btnStartEx
            // 
            this.btnStartEx.Location = new System.Drawing.Point(296, 71);
            this.btnStartEx.Name = "btnStartEx";
            this.btnStartEx.Size = new System.Drawing.Size(120, 23);
            this.btnStartEx.TabIndex = 3;
            this.btnStartEx.Text = "GetDBData";
            this.btnStartEx.UseVisualStyleBackColor = true;
            this.btnStartEx.Click += new System.EventHandler(this.btnStartEx_Click);
            // 
            // btnStopAllTask
            // 
            this.btnStopAllTask.Location = new System.Drawing.Point(215, 71);
            this.btnStopAllTask.Name = "btnStopAllTask";
            this.btnStopAllTask.Size = new System.Drawing.Size(75, 23);
            this.btnStopAllTask.TabIndex = 1;
            this.btnStopAllTask.Text = "StopAll";
            this.btnStopAllTask.UseVisualStyleBackColor = true;
            this.btnStopAllTask.Click += new System.EventHandler(this.btnStopAllTask_Click);
            // 
            // tbCountOfTask
            // 
            this.tbCountOfTask.Location = new System.Drawing.Point(6, 19);
            this.tbCountOfTask.Name = "tbCountOfTask";
            this.tbCountOfTask.Size = new System.Drawing.Size(27, 20);
            this.tbCountOfTask.TabIndex = 0;
            this.tbCountOfTask.Text = "10";
            this.tbCountOfTask.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbCountOfTask.TextChanged += new System.EventHandler(this.tbCountOfTask_TextChanged);
            // 
            // btnStartTask
            // 
            this.btnStartTask.Location = new System.Drawing.Point(6, 71);
            this.btnStartTask.Name = "btnStartTask";
            this.btnStartTask.Size = new System.Drawing.Size(120, 23);
            this.btnStartTask.TabIndex = 1;
            this.btnStartTask.Text = "StartTask";
            this.btnStartTask.UseVisualStyleBackColor = true;
            this.btnStartTask.Click += new System.EventHandler(this.btnStartTask_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.panel7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(915, 607);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 133);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(909, 471);
            this.textBox1.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.groupBox4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(909, 130);
            this.panel7.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.tbDirectoryStart);
            this.groupBox4.Controls.Add(this.btnSelectFolder);
            this.groupBox4.Location = new System.Drawing.Point(5, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(571, 100);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Count of file total";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "GetFiles";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbDirectoryStart
            // 
            this.tbDirectoryStart.Location = new System.Drawing.Point(6, 18);
            this.tbDirectoryStart.Name = "tbDirectoryStart";
            this.tbDirectoryStart.Size = new System.Drawing.Size(362, 20);
            this.tbDirectoryStart.TabIndex = 0;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(410, 18);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(120, 23);
            this.btnSelectFolder.TabIndex = 1;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(77, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Use Source URL List";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 633);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get URL Content v0.1.2  b18.02.16";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbExtractResultURLs;
        private System.Windows.Forms.TextBox tbSourceURLs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.RadioButton radioButtonImagezilla;
        private System.Windows.Forms.RadioButton radioButtonGallerysense;
        private System.Windows.Forms.Button btnGetURLsLink;
        private System.Windows.Forms.TextBox tbSourceURL;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelErrorFlag;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripProgressBar progressBar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnStartTask;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNumberOfEndUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPartOfUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.TextBox tbNumberOfBeginUrl;
        private System.Windows.Forms.TextBox tbEndOfUrl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCountOfRandomUrls;
        private System.Windows.Forms.CheckBox checkBoxIsRandomGen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStartEx;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbDirectoryStart;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCountOfTask;
        private System.Windows.Forms.Button btnStopAllTask;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPauseAllTask;
        private System.Windows.Forms.CheckBox chbUseSourceURLList;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

