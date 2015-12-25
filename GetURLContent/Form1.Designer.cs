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
            this.btnGetURLsLink = new System.Windows.Forms.Button();
            this.tbSourceURL = new System.Windows.Forms.TextBox();
            this.radioButtonImagezilla = new System.Windows.Forms.RadioButton();
            this.radioButtonGallerysense = new System.Windows.Forms.RadioButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelErrorFlag = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.progressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(616, 32);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 23);
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
            this.tbExtractResultURLs.Size = new System.Drawing.Size(370, 500);
            this.tbExtractResultURLs.TabIndex = 3;
            // 
            // tbSourceURLs
            // 
            this.tbSourceURLs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSourceURLs.Location = new System.Drawing.Point(0, 0);
            this.tbSourceURLs.Multiline = true;
            this.tbSourceURLs.Name = "tbSourceURLs";
            this.tbSourceURLs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSourceURLs.Size = new System.Drawing.Size(367, 500);
            this.tbSourceURLs.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGetURLsLink);
            this.panel1.Controls.Add(this.tbSourceURL);
            this.panel1.Controls.Add(this.radioButtonImagezilla);
            this.panel1.Controls.Add(this.radioButtonGallerysense);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 61);
            this.panel1.TabIndex = 5;
            // 
            // btnGetURLsLink
            // 
            this.btnGetURLsLink.Location = new System.Drawing.Point(491, 32);
            this.btnGetURLsLink.Name = "btnGetURLsLink";
            this.btnGetURLsLink.Size = new System.Drawing.Size(120, 23);
            this.btnGetURLsLink.TabIndex = 5;
            this.btnGetURLsLink.Text = "Get URLs link";
            this.btnGetURLsLink.UseVisualStyleBackColor = true;
            this.btnGetURLsLink.Click += new System.EventHandler(this.btnGetURLsLink_Click);
            // 
            // tbSourceURL
            // 
            this.tbSourceURL.Location = new System.Drawing.Point(0, 32);
            this.tbSourceURL.Name = "tbSourceURL";
            this.tbSourceURL.Size = new System.Drawing.Size(485, 20);
            this.tbSourceURL.TabIndex = 4;
            // 
            // radioButtonImagezilla
            // 
            this.radioButtonImagezilla.AutoSize = true;
            this.radioButtonImagezilla.Location = new System.Drawing.Point(110, 9);
            this.radioButtonImagezilla.Name = "radioButtonImagezilla";
            this.radioButtonImagezilla.Size = new System.Drawing.Size(88, 17);
            this.radioButtonImagezilla.TabIndex = 3;
            this.radioButtonImagezilla.Text = "imagezilla.net";
            this.radioButtonImagezilla.UseVisualStyleBackColor = true;
            // 
            // radioButtonGallerysense
            // 
            this.radioButtonGallerysense.AutoSize = true;
            this.radioButtonGallerysense.Checked = true;
            this.radioButtonGallerysense.Location = new System.Drawing.Point(9, 9);
            this.radioButtonGallerysense.Name = "radioButtonGallerysense";
            this.radioButtonGallerysense.Size = new System.Drawing.Size(97, 17);
            this.radioButtonGallerysense.TabIndex = 2;
            this.radioButtonGallerysense.TabStop = true;
            this.radioButtonGallerysense.Text = "gallerysense.se";
            this.radioButtonGallerysense.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(367, 82);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 500);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelErrorFlag,
            this.toolStripSplitButton1,
            this.progressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 582);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(740, 22);
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
            this.progressBar1.Size = new System.Drawing.Size(300, 16);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbSourceURLs);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 500);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbExtractResultURLs);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(370, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(370, 500);
            this.panel3.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 61);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(740, 21);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 604);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get URL Content v0.0.5  b21.12.15";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbExtractResultURLs;
        private System.Windows.Forms.TextBox tbSourceURLs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
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
    }
}

