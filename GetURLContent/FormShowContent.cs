using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace GetURLContent
{
    public partial class FormShowContent : Form
    {
        string SourceURL;
        string TmpDir;
        public FormShowContent(string SourceURL, string TmpDir)
        {
            InitializeComponent();
            this.SourceURL = SourceURL;
            this.TmpDir = TmpDir + System.IO.Path.GetFileName(this.SourceURL) ;
            DownloadFile(this.SourceURL, this.TmpDir);
        }

        private void DownloadFile(string URLLink,string TmpDir)
        {

            Uri uri = new Uri(URLLink);
            //string filename = System.IO.Path.GetFileName(uri.AbsolutePath);
            this.progressBarDownload.Maximum = 100;
            this.progressBarDownload.Value = 0;

            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(delegate (object sender, DownloadProgressChangedEventArgs e)
                {
                    //Console.WriteLine("Downloaded:" + e.ProgressPercentage.ToString());
                    this.progressBarDownload.Value = e.ProgressPercentage;
                }
            );

                webClient.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler
                    (delegate (object sender, System.ComponentModel.AsyncCompletedEventArgs e)
                    {
                        if (e.Error == null && !e.Cancelled)
                        {
                            Console.WriteLine("Download completed!");
                            this.pictBox.Load(TmpDir);
                        }

                    }
                  );

                webClient.DownloadFileAsync(new Uri(URLLink), TmpDir);
            }

        }

        private void tlbtnRefresh_Click(object sender, EventArgs e)
        {
            pictBox.Image.Dispose();// = null;
            DownloadFile(this.SourceURL, this.TmpDir);
        }

        private void tlbtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
