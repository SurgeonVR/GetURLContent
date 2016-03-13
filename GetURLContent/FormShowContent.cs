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
        WebClient webClient = new WebClient();
        public FormShowContent(string SourceURL, string TmpDir)
        {
            InitializeComponent();
            this.SourceURL = SourceURL;
            this.TmpDir = TmpDir + System.IO.Path.GetFileName(this.SourceURL) ;
           // long q = CheckURLFile(this.SourceURL);
           // if (q > 0)
           // {
                DownloadFile(this.SourceURL, this.TmpDir);
                //tlslFileSize.Text = string.Format("File Size {0} Kb ", q/1024);
           // }
           // else
           // {
           //     MessageBox.Show("File does not exists on server", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
           // }
        }

        private void DownloadFile(string URLLink,string TmpDir)
        {

            Uri uri = new Uri(URLLink);
            //string filename = System.IO.Path.GetFileName(uri.AbsolutePath);
            this.progressBarDownload.Maximum = 100;
            this.progressBarDownload.Value = 0;

            using ( webClient)
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
                        tlbtnReJectWebRequest.Enabled = false;
                        if (e.Error == null && !e.Cancelled)
                        {
                            Console.WriteLine("Download completed!");
                            this.pictBox.Load(TmpDir);
                            tlslFileSize.Text = string.Format("File Size {0} Kb ", new System.IO.FileInfo(TmpDir).Length / 1024);
                        }
                        else
                        {
                            MessageBox.Show( e.Error.ToString(),"Error ",MessageBoxButtons.OK,MessageBoxIcon.Error );                            
                        }

                    }
                  );

                webClient.DownloadFileAsync(new Uri(URLLink), TmpDir);
                tlbtnReJectWebRequest.Enabled = !tlbtnReJectWebRequest.Enabled;
            }

        }


        private long CheckURLFile(string SourceURL)
        {
            HttpWebResponse webResponse;
            long fileSize = 0;
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(new Uri(SourceURL));
            webRequest.Credentials = CredentialCache.DefaultCredentials;
            try
            {
                webResponse = (HttpWebResponse)webRequest.GetResponse();
                fileSize = webResponse.ContentLength;
            }
            catch (Exception e)
            { }

            return fileSize; 
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

        private void tlbtnReJectWebRequest_Click(object sender, EventArgs e)
        {
            if (webClient.IsBusy) 
                webClient.CancelAsync();
        }
    }
}
