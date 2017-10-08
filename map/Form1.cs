using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace map
{
    public partial class map : Form
    {
        public map()
        {
            InitializeComponent();
            string path = System.Environment.CurrentDirectory;
           
            this.webBrowser1.Navigate(path+"\\login.html");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
        }

        private void 虎丘区银行查询系统_Load(object sender, EventArgs e)
        {

        }
    }
}
