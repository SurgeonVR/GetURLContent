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
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace GetURLContent
{
    public partial class Form1 : Form
    {
        public String[] GlobalArray;
        public String[] ErrorArrayList;
        public Form1()
        {
            InitializeComponent();            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {


            this.MainApp();
            return;

            ThreadStart ts = new ThreadStart(MainApp);
            Thread t = new Thread(ts);
            t.Start();
            this.tbExtractResultURLs.Lines = this.GlobalArray;
          // String[] GlobalArray = new String[this.textBox2.Lines.Count()];

            //GenerateURLResource BJ = new GenerateURLResource();
            // BJ.GenerateURLResourceP(this.textBox2.Lines.ToArray(), this.textBox2);
            // ThreadStart ts = new ThreadStart(GlobalArray=BJ.MainApp);
            // Thread t = new Thread(ts);
            // t.Start();


            return;

           System.Net.WebClient  client = new System.Net.WebClient();

           // string content = client.DownloadString(this.tbURLList.Text);
            //this.tbContent.Text = content;
            //this.tbFirstPattern.Text = Properties.Settings.Default.RegExPatternFirst;
            // foreach (Match match in Regex.Matches(content, Properties.Settings.Default.RegExPatternFirst))
            // this.textBox1.AppendText(match.Groups[1].Value);
           //Match match = Regex.Match(content, Properties.Settings.Default.RegExPatternFirst);



            Regex MyRegexFirst = new Regex(Properties.Settings.Default.RegExPatternFirst, RegexOptions.IgnoreCase);
            //Match match = MyRegexFirst.Match(content);  
            //this.textBox1.AppendText(match.Value);
            Regex MyRegexSecond = new Regex(Properties.Settings.Default.RegexPatternSecond, RegexOptions.IgnoreCase);
            //Match match1 = MyRegexSecond.Match(match.ToString());
            //this.textBox1.AppendText(match1.Value + Environment.NewLine) ;
            //first regex (\$\("#myUniqueImg"\)\.attr\("src",")(\b(?:(?:https?|ftp|file|[A-Za-z]+):\/\/|www\.|ftp\.)(?:\([-A-Z0-9+&@#\/%=~_ |$?!:,.]*\)|[-A-Z0-9+&@#\/%=~_ |$?!:,.])*(?:\([-A-Z0-9+&@#\/%=~_ |$?!:,.]*\)|[A-Z0-9+&@#\/%=~_ |$]))
            //second regex (\b(?:(?:https?|ftp|file|[A-Za-z]+):\/\/|www\.|ftp\.)(?:\([-A-Z0-9+&@#\/%=~_ |$?!:,.]*\)|[-A-Z0-9+&@#\/%=~_ |$?!:,.])*(?:\([-A-Z0-9+&@#\/%=~_ |$?!:,.]*\)|[A-Z0-9+&@#\/%=~_ |$]))







        }

        private String[] TboxIntoArray()
        {
            String[] my_array = new String[this.tbSourceURLs.Lines.Count()];
            my_array = this.tbSourceURLs.Lines.ToArray();
            foreach (string s in my_array)
                Console.WriteLine(s);
            return my_array;
        }



  
        private void  MainApp()
        {
            System.Net.WebClient client = new System.Net.WebClient();

            this.progressBar1.Maximum = this.tbSourceURLs.Lines.Count();
            this.progressBar1.Value = 0;
            this.tbExtractResultURLs.Clear();
            this.toolStripStatusLabelErrorFlag.Visible = false;
            this.label2.Text = this.label1.Text;

            String[] my_array = new String[this.tbSourceURLs.Lines.Count()];
            List<string> ContentList = new List<string>();
            List<string> ErrorList = new List<string>();
            string content = string.Empty;



            my_array = this.tbSourceURLs.Lines.ToArray();
            foreach (string s in my_array)
            {
                try { content = client.DownloadString(s); }
                catch
                {
                    ErrorList.Add(s);
                    this.toolStripStatusLabelErrorFlag.Visible = true;
                }
                finally { this.ErrorArrayList = ErrorList.ToArray(); }
                //this.tbContent.Text = content;
                Regex MyRegexFirst = new Regex(this.radioButtonGallerysense.Checked ? Properties.Settings.Default.RegExPatternFirst : Properties.Settings.Default.RegExPatternFirstImagezilla, RegexOptions.IgnoreCase);
                Match match = MyRegexFirst.Match(content);
                Regex MyRegexSecond = new Regex(Properties.Settings.Default.RegexPatternSecond, RegexOptions.IgnoreCase);
                Match match1 = MyRegexSecond.Match(match.ToString());
                this.tbExtractResultURLs.AppendText(match1.Value + Environment.NewLine);
                ContentList.Add(match1.Value);
                content = string.Empty;
                this.progressBar1.Value = this.progressBar1.Value + 1;
            }
            //GlobalArray = ContentList.ToArray();
            //this.textBox1.Lines = ContentList.ToArray();
        }



        public class GenerateURLResource
        {
            private String[] InArray;
            private Object TbLines;
            public void GenerateURLResourceP(String[] InArray, Object TbLines)
            {
                this.InArray = InArray;
                this.TbLines = TbLines;
            }

            public String[] MainApp()
            {
                System.Net.WebClient client = new System.Net.WebClient();

                String[] my_array = InArray;
                List<string> ContentList = new List<string>();


                my_array = (TbLines as TextBox).Lines.ToArray();
                foreach (string s in my_array)
                {
                    string content = client.DownloadString(s);
                    //this.tbContent.Text = content;
                    Regex MyRegexFirst = new Regex(Properties.Settings.Default.RegExPatternFirst, RegexOptions.IgnoreCase);
                    Match match = MyRegexFirst.Match(content);
                    Regex MyRegexSecond = new Regex(Properties.Settings.Default.RegexPatternSecond, RegexOptions.IgnoreCase);
                    Match match1 = MyRegexSecond.Match(match.ToString());
                    //this.textBox1.AppendText(match1.Value + Environment.NewLine);
                    ContentList.Add(match1.Value);
                }

                return ContentList.ToArray();
                
            }

        }

        private void btnGetURLsLink_Click(object sender, EventArgs e)
        {
            FormURLLink FU = new FormURLLink(this.tbSourceURL.Text,this.radioButtonGallerysense.Checked ? SiteType.GallerySense : SiteType.ImageZilla);

            FU.Activate();

            DialogResult Rs =  FU.ShowDialog();

            if (Rs == DialogResult.OK)
            {
                this.tbSourceURLs.Clear();
                this.tbSourceURLs.Lines = (FU.getUrlLinkArray());
                this.label1.Text = FU.getURLOper();
            }

        }

        private void toolStripStatusLabelErrorFlag_Click(object sender, EventArgs e)
        {
            FormErrorList ER = new FormErrorList(this.ErrorArrayList);
            ER.Show();
        }


        public enum SiteType : int
        {
            GallerySense = 1,
            ImageZilla = 2
        }
    }
}
