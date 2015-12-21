using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GetURLContent
{
    public partial class FormURLLink : Form
    {
        private string vURL;
        private String[] URLLinkArray ;

        public FormURLLink(string URLInput)
        {
            InitializeComponent();
            this.vURL = URLInput;
            this.GetAllURLs();
            
        }

        public void GetAllURLs()
        {

            System.Net.WebClient client = new System.Net.WebClient();
            string content = client.DownloadString(this.vURL);

            Regex MyRegexFirst = new Regex(Properties.Settings.Default.RegExPatternFirstForLinks, RegexOptions.IgnoreCase);
            foreach (Match match in MyRegexFirst.Matches(content))
            {

              Regex MyRegexSecond = new Regex(Properties.Settings.Default.RegexPatternSecond, RegexOptions.IgnoreCase);
              Match matchn = MyRegexSecond.Match(match.Groups[1].Value);
              this.listBox1.Items.Add(matchn.ToString());

                // this.textBox1.AppendText(match.Groups[1].Value + Environment.NewLine);
                // this.checkedListBox1.Items.Add(match.Groups[1].Value);
                // this.listBox1.Items.Add(match.Groups[1].Value);



            }

            //Regex MyRegexSecond = new Regex(Properties.Settings.Default.RegexPatternSecond, RegexOptions.IgnoreCase);
            //Match match1 = MyRegexSecond.Match(match.ToString());
            //this.tbExtractResultURLs.AppendText(match1.Value + Environment.NewLine);



            //my_array = (TbLines as TextBox).Lines.ToArray();
            //foreach (string s in my_array)
            //{
            //    string content = client.DownloadString(s);
            //    //this.tbContent.Text = content;
            //    Regex MyRegexFirst = new Regex(Properties.Settings.Default.RegExPatternFirst, RegexOptions.IgnoreCase);
            //    Match match = MyRegexFirst.Match(content);
            //    Regex MyRegexSecond = new Regex(Properties.Settings.Default.RegexPatternSecond, RegexOptions.IgnoreCase);
            //    Match match1 = MyRegexSecond.Match(match.ToString());
            //    //this.textBox1.AppendText(match1.Value + Environment.NewLine);
            //    ContentList.Add(match1.Value);
            //}

            // return ContentList.ToArray();


        }



        private void btnCopyToClipBoard_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (object o in listBox1.SelectedItems)
            {
               // s += o.ToString() + Environment.NewLine ;
                s = s + o.ToString() + Environment.NewLine;
            }
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(s, TextDataFormat.Text);
            }
            catch { }
        }

        private void btnGetSelectedURLs_Click(object sender, EventArgs e)
        {
            List<string> ContentList = new List<string>();
            foreach (object o in listBox1.SelectedItems)
            {
                ContentList.Add(o.ToString());
            }
            this.URLLinkArray = ContentList.ToArray();
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        public string[] getUrlLinkArray()
        {
            return this.URLLinkArray;
        }
    }
}
