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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.radioButtonGallerysense = new System.Windows.Forms.RadioButton();
            this.radioButtonImagezilla = new System.Windows.Forms.RadioButton();
            this.tbSourceURL = new System.Windows.Forms.TextBox();
            this.btnGetURLsLink = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(617, 5);
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
            this.tbExtractResultURLs.Location = new System.Drawing.Point(412, 61);
            this.tbExtractResultURLs.Multiline = true;
            this.tbExtractResultURLs.Name = "tbExtractResultURLs";
            this.tbExtractResultURLs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbExtractResultURLs.Size = new System.Drawing.Size(328, 498);
            this.tbExtractResultURLs.TabIndex = 3;
            // 
            // tbSourceURLs
            // 
            this.tbSourceURLs.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbSourceURLs.Location = new System.Drawing.Point(3, 61);
            this.tbSourceURLs.Multiline = true;
            this.tbSourceURLs.Name = "tbSourceURLs";
            this.tbSourceURLs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSourceURLs.Size = new System.Drawing.Size(409, 498);
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
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 61);
            this.panel1.TabIndex = 5;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 604);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(3, 582);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(737, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(3, 559);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(737, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 8;
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
            // tbSourceURL
            // 
            this.tbSourceURL.Location = new System.Drawing.Point(0, 32);
            this.tbSourceURL.Name = "tbSourceURL";
            this.tbSourceURL.Size = new System.Drawing.Size(611, 20);
            this.tbSourceURL.TabIndex = 4;
            // 
            // btnGetURLsLink
            // 
            this.btnGetURLsLink.Location = new System.Drawing.Point(617, 30);
            this.btnGetURLsLink.Name = "btnGetURLsLink";
            this.btnGetURLsLink.Size = new System.Drawing.Size(120, 23);
            this.btnGetURLsLink.TabIndex = 5;
            this.btnGetURLsLink.Text = "Get URLs link";
            this.btnGetURLsLink.UseVisualStyleBackColor = true;
            this.btnGetURLsLink.Click += new System.EventHandler(this.btnGetURLsLink_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 604);
            this.Controls.Add(this.tbExtractResultURLs);
            this.Controls.Add(this.tbSourceURLs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get URL Content v0.0.5  b21.12.15";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton radioButtonImagezilla;
        private System.Windows.Forms.RadioButton radioButtonGallerysense;
        private System.Windows.Forms.Button btnGetURLsLink;
        private System.Windows.Forms.TextBox tbSourceURL;
    }
}

