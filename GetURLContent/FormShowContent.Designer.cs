namespace GetURLContent
{
    partial class FormShowContent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowContent));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBarDownload = new System.Windows.Forms.ToolStripProgressBar();
            this.tlbtnClose = new System.Windows.Forms.ToolStripDropDownButton();
            this.tlbtnRefresh = new System.Windows.Forms.ToolStripDropDownButton();
            this.pictBox = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBarDownload,
            this.tlbtnClose,
            this.tlbtnRefresh});
            this.statusStrip1.Location = new System.Drawing.Point(0, 393);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(525, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBarDownload
            // 
            this.progressBarDownload.Name = "progressBarDownload";
            this.progressBarDownload.Size = new System.Drawing.Size(350, 16);
            this.progressBarDownload.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // tlbtnClose
            // 
            this.tlbtnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tlbtnClose.Image = ((System.Drawing.Image)(resources.GetObject("tlbtnClose.Image")));
            this.tlbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbtnClose.Name = "tlbtnClose";
            this.tlbtnClose.Size = new System.Drawing.Size(46, 20);
            this.tlbtnClose.Text = "Close";
            this.tlbtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tlbtnClose.Click += new System.EventHandler(this.tlbtnClose_Click);
            // 
            // tlbtnRefresh
            // 
            this.tlbtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tlbtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tlbtnRefresh.Image")));
            this.tlbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbtnRefresh.Name = "tlbtnRefresh";
            this.tlbtnRefresh.Size = new System.Drawing.Size(58, 20);
            this.tlbtnRefresh.Text = "Refresh";
            this.tlbtnRefresh.Click += new System.EventHandler(this.tlbtnRefresh_Click);
            // 
            // pictBox
            // 
            this.pictBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictBox.Location = new System.Drawing.Point(0, 0);
            this.pictBox.Name = "pictBox";
            this.pictBox.Size = new System.Drawing.Size(525, 393);
            this.pictBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBox.TabIndex = 9;
            this.pictBox.TabStop = false;
            // 
            // FormShowContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 415);
            this.Controls.Add(this.pictBox);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FormShowContent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormShowContent";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBarDownload;
        private System.Windows.Forms.ToolStripDropDownButton tlbtnClose;
        private System.Windows.Forms.ToolStripDropDownButton tlbtnRefresh;
        private System.Windows.Forms.PictureBox pictBox;
    }
}