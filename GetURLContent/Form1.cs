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
            this.textBox1.Lines = this.GlobalArray;
          // String[] GlobalArray = new String[this.textBox2.Lines.Count()];

            //GenerateURLResource BJ = new GenerateURLResource();
            // BJ.GenerateURLResourceP(this.textBox2.Lines.ToArray(), this.textBox2);
            // ThreadStart ts = new ThreadStart(GlobalArray=BJ.MainApp);
            // Thread t = new Thread(ts);
            // t.Start();


            return;

           System.Net.WebClient  client = new System.Net.WebClient();

            string content = client.DownloadString(this.tbURLList.Text);
            this.tbContent.Text = content;
            //this.tbFirstPattern.Text = Properties.Settings.Default.RegExPatternFirst;
            // foreach (Match match in Regex.Matches(content, Properties.Settings.Default.RegExPatternFirst))
            // this.textBox1.AppendText(match.Groups[1].Value);
           //Match match = Regex.Match(content, Properties.Settings.Default.RegExPatternFirst);



            Regex MyRegexFirst = new Regex(Properties.Settings.Default.RegExPatternFirst, RegexOptions.IgnoreCase);
            Match match = MyRegexFirst.Match(content);  
            //this.textBox1.AppendText(match.Value);
            Regex MyRegexSecond = new Regex(Properties.Settings.Default.RegexPatternSecond, RegexOptions.IgnoreCase);
            Match match1 = MyRegexSecond.Match(match.ToString());
            this.textBox1.AppendText(match1.Value + Environment.NewLine) ;
            //first regex (\$\("#myUniqueImg"\)\.attr\("src",")(\b(?:(?:https?|ftp|file|[A-Za-z]+):\/\/|www\.|ftp\.)(?:\([-A-Z0-9+&@#\/%=~_ |$?!:,.]*\)|[-A-Z0-9+&@#\/%=~_ |$?!:,.])*(?:\([-A-Z0-9+&@#\/%=~_ |$?!:,.]*\)|[A-Z0-9+&@#\/%=~_ |$]))
            //second regex (\b(?:(?:https?|ftp|file|[A-Za-z]+):\/\/|www\.|ftp\.)(?:\([-A-Z0-9+&@#\/%=~_ |$?!:,.]*\)|[-A-Z0-9+&@#\/%=~_ |$?!:,.])*(?:\([-A-Z0-9+&@#\/%=~_ |$?!:,.]*\)|[A-Z0-9+&@#\/%=~_ |$]))







        }

        private String[] TboxIntoArray()
        {
            String[] my_array = new String[this.textBox2.Lines.Count()];
            my_array = this.textBox2.Lines.ToArray();
            foreach (string s in my_array)
                Console.WriteLine(s);
            return my_array;
        }



  
        private void  MainApp()
        {
            System.Net.WebClient client = new System.Net.WebClient();

            String[] my_array = new String[this.textBox2.Lines.Count()];
            List<string> ContentList = new List<string>();



            my_array = this.textBox2.Lines.ToArray();
            foreach (string s in my_array)
            {
                string content = client.DownloadString(s);
                //this.tbContent.Text = content;
                Regex MyRegexFirst = new Regex(Properties.Settings.Default.RegExPatternFirst, RegexOptions.IgnoreCase);
                Match match = MyRegexFirst.Match(content);
                Regex MyRegexSecond = new Regex(Properties.Settings.Default.RegexPatternSecond, RegexOptions.IgnoreCase);
                Match match1 = MyRegexSecond.Match(match.ToString());
                this.textBox1.AppendText(match1.Value + Environment.NewLine);
                ContentList.Add(match1.Value);                
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



        }
}
