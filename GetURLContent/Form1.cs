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
using System.Diagnostics;
using System.Data.SQLite;


// tutorial http://www.sergechel.info/ru/content/using-sqllite-with-c-sharp-part-4-sqlite-net

namespace GetURLContent
{
    public partial class Form1 : Form
    {
        public String[] GlobalArray;
        public String[] ErrorArrayList;
        public static List<string> GlobalStringlist = new List<string>();
        public static List<string> GlobalErrStringlist = new List<string>();
        public static List<Task> GlobalTaskList = new List<Task>();
        public static List<Thread> GlobalTaskListT = new List<Thread>();
        public static TextBox TransferTextResult = new TextBox();
        public static TextBox TransferTextSource = new TextBox();
        public static TextBox ClearTextSource = new TextBox();
        public static TextBox ActiveTaskCount = new TextBox();
        public static int CountOfTask = new int(); // 20.02.16 max count of active task
        public static bool ExitOnDemand = new bool(); // 23.02.16 .T. - break all of task  
        public static bool PauseOnDemand = new bool(); // 24.02.16 .T. - pause all of tasks that not started yet  

        static object GlobalTaskListLocker = new object();
        static object TransferTextResultLocker = new object();
        static object TransferTextSourceLocker = new object();
        static object GlobalStringlistLocker = new object();
        static object GlobalErrStringlistLocker = new object();
        static object ActiveTaskCountLocker = new object();


        delegate void SetTextCallback(string text);

        public Form1()
        {
            InitializeComponent();
            TransferTextResult.TextChanged += TransferTextResult_TextChanged;
            TransferTextSource.TextChanged += TransferTextSource_TextChanged;
            ClearTextSource.TextChanged += ClearTextSource_TextChanged;
            ActiveTaskCount.TextChanged += ActiveTaskCount_TextChanged;
            Control.CheckForIllegalCrossThreadCalls = false;
            CountOfTask = int.Parse(tbCountOfTask.Text); 
        }

        // Print count of active task
        private void ActiveTaskCount_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Format("Active Task {0}", ActiveTaskCount.Text);
            btnStartTask.ForeColor = (int.Parse(ActiveTaskCount.Text) > 0 && !PauseOnDemand) ? Color.DarkGreen : SystemColors.ControlText;
        }

        private void ClearTextSource_TextChanged(object sender, EventArgs e)
        {
            tbSourceURLs.Clear();
        }

        // task mode, output source url 
        private void TransferTextSource_TextChanged(object sender, EventArgs e)
        {
          if (chbVerboseTask.Checked) this.tbSourceURLs.AppendText(TransferTextSource.Text + System.Environment.NewLine);
        }

        // task mode, output extracted url 
        private void TransferTextResult_TextChanged(object sender, EventArgs e)
        {
          if (chbVerboseTask.Checked)  this.tbExtractResultURLs.AppendText(TransferTextResult.Text + System.Environment.NewLine)  ;
        }



        private void btnStart_Click(object sender, EventArgs e)
        {


             this.MainApp();
             return;

            //ThreadStart ts = new ThreadStart(MainAppTPL);
            //Thread t = new Thread(ts);
            //t.Start();

            // Thread t = new Thread(new ParameterizedThreadStart(MainAppTPL));
            // t.Start(this.tbSourceURLs);
             Thread t = new Thread(new ParameterizedThreadStart(MainAppTask));
             t.Start(this.tbSourceURLs);


            this.tbExtractResultURLs.Lines = this.GlobalArray;
            // String[] GlobalArray = new String[this.textBox2.Lines.Count()];

            //GenerateURLResource BJ = new GenerateURLResource();
            // BJ.GenerateURLResourceP(this.textBox2.Lines.ToArray(), this.textBox2);
            // ThreadStart ts = new ThreadStart(GlobalArray=BJ.MainApp);
            // Thread t = new Thread(ts);
            // t.Start();


            return;

            System.Net.WebClient client = new System.Net.WebClient();

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




        // Operations for single thread mode
        private void MainApp()
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

                Regex MyRegexFirst = new Regex(this.radioButtonGallerysense.Checked ? Properties.Settings.Default.RegExPatternFirst : Properties.Settings.Default.RegExPatternFirstImagezilla, RegexOptions.IgnoreCase);
                Match match = MyRegexFirst.Match(content);
                Regex MyRegexSecond = new Regex(Properties.Settings.Default.RegexPatternSecond, RegexOptions.IgnoreCase);
                Match match1 = MyRegexSecond.Match(match.ToString());

                //Regex MyRegexFirst = new Regex(Properties.Settings.Default.RegExPatternFirst, RegexOptions.IgnoreCase);
                //Match match = MyRegexFirst.Match(content);
                //Regex MyRegexSecond = new Regex(Properties.Settings.Default.RegexPatternSecond, RegexOptions.IgnoreCase);
                //Match match1 = MyRegexSecond.Match(match.ToString());


                this.tbExtractResultURLs.AppendText(match1.Value + Environment.NewLine);
                ContentList.Add(match1.Value);
                content = string.Empty;
                this.progressBar1.Value = this.progressBar1.Value + 1;









            }
            //GlobalArray = ContentList.ToArray();
            //this.textBox1.Lines = ContentList.ToArray();
        }

        public static void MainAppTask(object UrlCollection)
        {

            TextBox vUrlCollection = (TextBox)UrlCollection;
            lock (GlobalTaskListLocker) { GlobalTaskList.Clear(); }
            

            //String[] my_array = new String[vUrlCollection.Lines.Count()];

            URLList UL = new URLList(100, "http://gallerynova.se/site/v/",string.Empty); //  генерячу рандомні урли щоб не набивать їх в текстове поле
            String[] my_array = UL.GetRandomURLs(900000, 903915); //  генерячу рандомні урли щоб не набивать їх в текстове поле

            Object[] my_par = new Object[2];

            //my_array = vUrlCollection.Lines.ToArray();

            foreach (string s in my_array)
            {
                if (GlobalTaskList.Count() <= 9)
                {
                    //Task task1 = new Task(() => GetURLContentTask(my_par));
                    Task task1 = new Task(delegate { GetURLContentTask(my_par); });
                    

                    my_par[0] = s;
                    my_par[1] = task1;

                    lock (GlobalTaskListLocker) { GlobalTaskList.Add(task1); }
                    Debug.WriteLine(string.Format("Added In TaskList Id {0},Url {1}", task1.Id.ToString(), s));
                    task1.Start();
                   Debug.WriteLine(string.Format("Start(M) Task Id {0},Url {1}",task1.Id.ToString(),s));
                }
                else
                {
                    do
                    {
                        Thread.Sleep(10);
                    } while (GlobalTaskList.Count() > 9);

                    Task task1 = new Task(() => GetURLContentTask(my_par));

                    my_par[0] = s;
                    my_par[1] = task1;

                    lock (GlobalTaskListLocker) { GlobalTaskList.Add(task1); }
                    Debug.WriteLine(string.Format("Added In TaskList Id {0},Url {1}", task1.Id.ToString(), s));
                    task1.Start();
                    Debug.WriteLine(string.Format("Start(E) Task Id {0},Url {1}", task1.Id.ToString(), s));
                    

                }

            }



        }





        public static void GetURLContentTask(object[] URLAddress)
        {
            string intURL = (string)URLAddress[0];
            System.Net.WebClient client = new System.Net.WebClient();
            int ErrFlag = 0;
            string content = string.Empty;
            try { content = client.DownloadString(intURL); }
            catch
            {
                lock (GlobalErrStringlistLocker) { GlobalErrStringlist.Add(intURL); }
                ErrFlag = 1;
            }

            Regex MyRegexFirst = new Regex(Properties.Settings.Default.RegExPatternFirst, RegexOptions.IgnoreCase);
            Match match = MyRegexFirst.Match(content);
            Regex MyRegexSecond = new Regex(Properties.Settings.Default.RegexPatternSecond, RegexOptions.IgnoreCase);
            Match match1 = MyRegexSecond.Match(match.ToString());
            lock (GlobalStringlistLocker) { GlobalStringlist.Add(match1.Value); }
            lock (GlobalTaskListLocker)
            {
                Debug.WriteLine(string.Format("End Task Id {0},Founded Url {1}", ((Task)URLAddress[1]).Id.ToString(), match1.Value));
                GlobalTaskList.Remove((Task)URLAddress[1]);
                Debug.WriteLine(string.Format("GlobalTaskList Containts Task Id {0}, {1}", ((Task)URLAddress[1]).Id.ToString(), GlobalTaskList.Contains((Task)URLAddress[1]) ? "True" : "false"));
            }
            lock(TransferTextResultLocker) { TransferTextResult.Text = match1.Value; }
            lock(TransferTextSourceLocker) { TransferTextSource.Text = intURL; }
            DBOperations db = new DBOperations();
            db.InsertNewURLData(new string[] { System.IO.Path.GetFileName(intURL), "1", intURL, match1.Value,ErrFlag.ToString(), System.IO.Path.GetFileName(match1.Value) });

        }




        public static void   MainAppTPL(object UrlCollection)
        {
            TextBox vUrlCollection = (TextBox) UrlCollection ;

            String[] my_array = new String[vUrlCollection.Lines.Count()];

            my_array = vUrlCollection.Lines.ToArray();
            foreach (string s in my_array)
            {
                Thread t = new Thread(new ParameterizedThreadStart(GetURLContent));
                t.Start(s);
            }


        }

        public static void GetURLContent(object URLAddress)
        {
            string intURL = (string)URLAddress;
            System.Net.WebClient client = new System.Net.WebClient();

            //Console.WriteLine("Thread {0} started", (string) URLAddress);
            //Thread.Sleep(5000 + (int.Parse((string) URLAddress)*10) );
            //Console.WriteLine("Thread {0} ended", (string) URLAddress);
            //lock (GlobalStringlist);
            //GlobalStringlist.Add((string)URLAddress);

                string content = string.Empty;
                try { content = client.DownloadString(intURL); }
                catch
                {
                    lock (GlobalErrStringlistLocker) { GlobalErrStringlist.Add(intURL); }
                }

                Regex MyRegexFirst = new Regex(Properties.Settings.Default.RegExPatternFirst, RegexOptions.IgnoreCase);
                Match match = MyRegexFirst.Match(content);
                Regex MyRegexSecond = new Regex(Properties.Settings.Default.RegexPatternSecond, RegexOptions.IgnoreCase);
                Match match1 = MyRegexSecond.Match(match.ToString());
                lock (GlobalStringlistLocker) { GlobalStringlist.Add(match1.Value); }
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

        // генерить випадкові урли з діапазону доступних
        public class URLList
        {
            private int CountOfURL;
            private List<string> LS = new List<string>();
            private string PartOfUrl;
            private string FileExtension;

            public URLList(int CountOfURL, string URL, string FileExt)
            {
                this.CountOfURL = CountOfURL;
                this.PartOfUrl = URL;
                this.FileExtension = FileExt;
            }

            public string[] GetRandomURLs(int MinVal, int MaxVal, bool IsRandom = true)
            {
                string v = PartOfUrl;
                Random r = new Random();
                if (IsRandom)
                {
                    do
                    {
                        LS.Add(v + r.Next(MinVal, MaxVal) + FileExtension);
                    } while (LS.Count < CountOfURL);
                }else
                {
                    do
                    {
                        LS.Add(v + ( (MinVal = MinVal + 1).ToString() ) + FileExtension);
                    } while (MinVal < MaxVal);

                }

                return LS.ToArray();
            }


        }


 


        private DataSet GetDBMainData(SQLiteConnection cn)
        {

            DataSet dt = new DataSet();
            dt.Reset();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.CommandText = "select * from UrlList";
            cmd.Connection = cn;
            SQLiteDataAdapter ad = new SQLiteDataAdapter(cmd);



            if (cn.State == ConnectionState.Open)
                try
                {
                    ad.Fill(dt, "UrlList");
                }
                catch (SQLiteException ex)
                {
                    throw ex;
                }

            return dt;

            //this.gridControl1.DataSource = this.GetDBMainData().Tables[0];

            //this.cn.Close();
            //this.cn.Dispose();


        }




        public class DBOperations
        {
            public void InsertNewURLData(string[] URLdata)
            {
                SQLiteConnection cn = EstablistSQLiteConnection();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"INSERT INTO UrlList(SourceSiteID,SourceSiteTypeID,SourceURL,ExtractedURL,ExtractedURLFileName) 
                                            VALUES (@SourceSiteID,@SourceSiteTypeID,@SourceURL,@ExtractedURL,@ExtractedURLFileName);";
                //cmd.Parameters.AddWithValue("@first_name", "Sergey");
                //cmd.Parameters.Add(new SQLiteParameter("@last_name", "Petrov"));
                //SQLiteParameter param = new SQLiteParameter("@sex", DbType.Int32);
                //param.Value = 0;
                //cmd.Parameters.Add(param);
                //cmd.Parameters.Add("@birth_date", DbType.DateTime).Value = DateTime.Parse("2000-01-15");
                cmd.Parameters.AddWithValue("@SourceSiteID", URLdata[0]);
                cmd.Parameters.AddWithValue("@SourceSiteTypeID", URLdata[1]);
                cmd.Parameters.AddWithValue("@SourceURL", URLdata[2]);
                cmd.Parameters.AddWithValue("@ExtractedURL", URLdata[3]);
                cmd.Parameters.AddWithValue("@ExtractedURLError", URLdata[4]);                
                cmd.Parameters.AddWithValue("@ExtractedURLFileName", URLdata[5]);

                cmd.ExecuteNonQuery();

                cn.Close();
                cn.Dispose();
            }


            public SQLiteConnection EstablistSQLiteConnection()
            {
                string RelPath = String.Empty;
                string DbFilePath;
                DbFilePath = Environment.CurrentDirectory;
                var st = DbFilePath.Split('\\');
                foreach (var q in st)
                {
                    RelPath = q.ToUpper() == "BIN" ? RelPath + @"Sqlite\DB\" : RelPath + q + @"\";
                    if (q.ToUpper() == "BIN")
                        break;

                }



                //DbFilePath = DbFilePath.Contains(@"\Debug") ? DbFilePath.Replace(@"\Debug", @"\") : DbFilePath.Contains(@"\Release") ? DbFilePath.Replace(@"\Release", @"\") : DbFilePath;
                SQLiteConnection cn = new SQLiteConnection("Data Source=" + RelPath + "URLContent.db; Version=3;");

                try
                {

                    cn.Open();

                    //Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Opera Software\opera stable\History";
                    //SQLiteConnection con = new SQLiteConnection("DataSource=" + opera + "; version=3; new =false;compress=true;");
                    //SQLiteDataAdapter sd = new SQLiteDataAdapter("select * from URLS", con);
                    //DataSet ds = new DataSet();
                    //sd.Fill(ds);

                    //dataGridView1.DataSource = ds.Tables[0]; con.Close();
                }
                catch (SQLiteException ex)
                {
                    cn.Dispose();
                    throw ex;
                }

                return cn;
            }
        }


        private void btnStartEx_Click(object sender, EventArgs e)
        {
            DBOperations db = new DBOperations();
            SQLiteConnection cn = db.EstablistSQLiteConnection();
            //this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.DataSource = GetDBMainData(cn).Tables["UrlList"];

        }

        // 29.01.16 Generate URL
        private void btnBegin_Click(object sender, EventArgs e)
        {
            if (!checkBoxIsRandomGen.Checked)
            {
                int vBegNumber = int.Parse(this.tbNumberOfBeginUrl.Text);
                int vEndNumber = int.Parse(this.tbNumberOfEndUrl.Text);
                string vUrl = string.Empty;
                this.tbSourceURLs.Clear();

                List<String> t = new List<String>();
                this.progressBar1.Maximum = vEndNumber;
                this.progressBar1.Value = 0;

                for (int i = vBegNumber; i < vEndNumber + 1; i++)
                {
                    vUrl = string.Format("{0}{1}{2}{3}", this.tbPartOfUrl.Text, i.ToString(), this.tbEndOfUrl.Text, System.Environment.NewLine);
                    t.Add(vUrl);
                    this.progressBar1.Value = i;
                }
                this.tbSourceURLs.Text = String.Join("", t.ToArray());
            } else
            {
                URLList UL = new URLList(int.Parse(tbCountOfRandomUrls.Text), tbPartOfUrl.Text,tbEndOfUrl.Text); //  генерячу рандомні урли щоб не набивать їх в текстове поле
                String[] my_array = UL.GetRandomURLs(int.Parse(tbNumberOfBeginUrl.Text), int.Parse(tbNumberOfEndUrl.Text)); //  генерячу рандомні урли щоб не набивать їх в текстове поле
                this.tbSourceURLs.Lines = my_array;
            }
        }

        private void btnStartTask_Click(object sender, EventArgs e)
        {
            //Thread t = new Thread(new ParameterizedThreadStart(MainAppTask));
            //t.Start(this.tbSourceURLs);

            //Task task1 = new Task(() => GetURLContentTask(my_par));
            ExitOnDemand = false;
            PauseOnDemand = false;
            Object[] my_par = new Object[8];
            MultiT GT = new MultiT();
            Task task1 = new Task(delegate { GT.MainAppTaskCL(my_par); });
            //Task task1 = new Task(new Action(GT.MainAppTaskCL));

            my_par[0] = tbSourceURLs;
            my_par[1] = task1;
            my_par[2] = tbPartOfUrl;
            my_par[3] = tbEndOfUrl;
            my_par[4] = tbNumberOfBeginUrl;
            my_par[5] = tbNumberOfEndUrl;
            my_par[6] = tbCountOfRandomUrls;
            my_par[7] = checkBoxIsRandomGen;

            task1.Start();
        }


        public class MultiT
        {
            List<String> g = new List<string>();
            List<String> q = new List<string>();
            private object[] TUrlCollection;
            TextBox vUrlCollection = new TextBox(); 

            public  void MainAppTaskCL(object[] UrlCollection)
            {
                TUrlCollection =  UrlCollection;
                vUrlCollection.Lines = ((TextBox)TUrlCollection[0]).Lines;
                lock (GlobalTaskListLocker) { GlobalTaskList.Clear(); }
                ClearTextSource.Text = "0"; //Clear tbSourceURLs by eventHandler on ClearTextSource.TextChanged
                URLList UL;
                String[] my_array;

               
                if (((TextBox)TUrlCollection[0]).Lines.Count() == 0) // генерячу рандомні урли щоб не набивать їх в текстове поле якщо tbSourceURLs пустий
                {
                    UL = new URLList(int.Parse(((TextBox)TUrlCollection[6]).Text), ((TextBox)TUrlCollection[2]).Text, ((TextBox)TUrlCollection[3]).Text);
                    my_array = UL.GetRandomURLs(int.Parse(((TextBox)TUrlCollection[4]).Text), int.Parse(((TextBox)TUrlCollection[5]).Text), ((CheckBox)TUrlCollection[7]).Checked); //  генерячу рандомні урли щоб не набивать їх в текстове поле
                }
                else my_array = vUrlCollection.Lines.ToArray(); // якщо не пустий список то беру звідти дані для роботи


                foreach (string s in my_array)
                {
                   
                    if (GlobalTaskList.Count() <= CountOfTask)
                    {
                        Object[] my_par = new Object[3];
                        //Task task1 = new Task(() => GetURLContentTask(my_par));
                        //Task task1 = new Task(delegate { GetURLContentTask(my_par); });
                        //Task task1 = new Task(new Action(FT.GetURLContentTaskT));
                        URLContentTask FT = new URLContentTask(my_par);
                        Task task1 = new Task(delegate { FT.GetURLContentTask(); });
                        //Task task1 =  Task.Factory.StartNew(delegate { PrepareRunTask(my_par); });


                        my_par[0] = s;
                        my_par[1] = task1;

                        lock (GlobalTaskListLocker) { GlobalTaskList.Add(task1);}
                        Debug.WriteLine(string.Format("Added(M) In TaskList Id {0},Url {1}", task1.Id.ToString(), s));
                         task1.Start();
                        Debug.WriteLine(string.Format("Start(M) Task Id {0},Url {1}", task1.Id.ToString(), s));
                    }
                    else
                    {
                        do
                        {
                            Thread.Sleep(10);
                        } while (GlobalTaskList.Count() > CountOfTask);

                        Object[] my_par = new Object[3];
                        //Task task1 = new Task(() => GetURLContentTask(my_par));
                        //Task task1 = new Task(delegate { GetURLContentTask(my_par); });
                        //Task task1 = new Task(new Action(FT.GetURLContentTaskT));
                        URLContentTask FT = new URLContentTask(my_par);
                        Task task1 = new Task(delegate { FT.GetURLContentTask(); });
                        //Task task1 =  Task.Factory.StartNew(delegate { PrepareRunTask(my_par); });


                        my_par[0] = s;
                        my_par[1] = task1;

                        lock (GlobalTaskListLocker) { GlobalTaskList.Add(task1); }
                        Debug.WriteLine(string.Format("Added(E) In TaskList Id {0},Url {1}", task1.Id.ToString(), s));
                        task1.Start();
                        Debug.WriteLine(string.Format("Start(E) Task Id {0},Url {1}", task1.Id.ToString(), s));
                        
                    }

                    // Begin Service code
                    if (ExitOnDemand) break; // exit when user press btn "StopAll"

                    // do void cycles where user press btn Pause, it make pause all of tasks that not started yet  
                    while (PauseOnDemand)
                    {
                        Thread.Sleep(500);
                    }
                    // End service Code
                }



            }

            public static object CloneObject(object obj)
            {
                if (obj == null) return null;

                Type t1 = obj.GetType();
                object ret = Activator.CreateInstance(t1);

                var properties = t1.GetProperties().ToArray();
                for (int i = 0; i < properties.Length; i++)
                {
                    properties[i].SetValue(
                            ret,
                            properties[i].GetValue(obj)
                        );
                }
                return ret;
            }





        }

        public class URLContentTask
        {
            object[] vURLAddress;
            public URLContentTask(object[] URLAddress)
            {
                vURLAddress = URLAddress;
            }
            public void GetURLContentTask()
            {
                string intURL = (string)vURLAddress[0];
                System.Net.WebClient client = new System.Net.WebClient();
                int ErrFlag = 0;
                string content = string.Empty;
                try { content = client.DownloadString(intURL); }
                catch
                {
                    lock (GlobalErrStringlistLocker) { GlobalErrStringlist.Add(intURL); }
                    ErrFlag = 1;
                }

                Regex MyRegexFirst = new Regex(Properties.Settings.Default.RegExPatternFirst, RegexOptions.IgnoreCase);
                Match match = MyRegexFirst.Match(content);
                Regex MyRegexSecond = new Regex(Properties.Settings.Default.RegexPatternSecond, RegexOptions.IgnoreCase);
                Match match1 = MyRegexSecond.Match(match.ToString());
                lock (GlobalStringlistLocker) { GlobalStringlist.Add(match1.Value); }
                lock (GlobalTaskListLocker)
                {
                    Debug.WriteLine(string.Format("End Task Id {0},Source URL {1},Founded Url {2}", ((Task)vURLAddress[1]).Id.ToString(), intURL, match1.Value));
                    GlobalTaskList.Remove((Task)vURLAddress[1]);
                    Debug.WriteLine(string.Format("GlobalTaskList Containts Task Id {0}, {1}", ((Task)vURLAddress[1]).Id.ToString(), GlobalTaskList.Contains((Task)vURLAddress[1]) ? "True" : "false"));
                };
                lock (ActiveTaskCountLocker) { ActiveTaskCount.Text = GlobalTaskList.Count().ToString();  }
                lock (TransferTextResultLocker) { TransferTextResult.Text = match1.Value; }
                lock (TransferTextSourceLocker) { TransferTextSource.Text = intURL; }
                DBOperations db = new DBOperations();
                db.InsertNewURLData(new string[] { System.IO.Path.GetFileName(intURL), "1", intURL, match1.Value, ErrFlag.ToString(), System.IO.Path.GetFileName(match1.Value) });

            }

        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            { tbDirectoryStart.Text = folderBrowserDialog1.SelectedPath; }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string[] filePaths = Directory.GetFiles(tbDirectoryStart.Text, "*.jpg", SearchOption.AllDirectories);
                textBox1.Lines = filePaths;
                label8.Text = string.Format("Count of file total {0}", textBox1.Lines.Count());

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        // Max count of active task
        private void tbCountOfTask_TextChanged(object sender, EventArgs e)
        {
            CountOfTask = int.Parse(tbCountOfTask.Text);
        }

        // 23.02.16 break all of task
        private void btnStopAllTask_Click(object sender, EventArgs e)
        {
            ExitOnDemand = true;
        }

        // 24.02.16 Make pause
        private void btnPauseAllTask_Click(object sender, EventArgs e)
        {
            PauseOnDemand = !PauseOnDemand;
            //btnPauseAllTask.FlatStyle = PauseOnDemand ? FlatStyle.Flat  : FlatStyle.Standard;
            btnPauseAllTask.ForeColor = PauseOnDemand ? Color.Red : SystemColors.ControlText;
        }
    }
}
