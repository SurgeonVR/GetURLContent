using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetURLContent
{
    public partial class FormErrorList : Form
    {
        private string[] vErrList;
        public FormErrorList(string[] errlist)
        {
            InitializeComponent();
            this.vErrList = errlist;
            this.BindingData(this.vErrList);
        }

        private void BindingData(string[] errlist)
        {
            this.tbErrorList.Clear();
            this.tbErrorList.Lines = errlist;
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
