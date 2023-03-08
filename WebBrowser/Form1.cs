using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            string url = toolStripTextBox1.Text;
            if (!string.IsNullOrWhiteSpace(url))
            {
                webBrowser1.Navigate(url);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            webBrowser1.Refresh();
        }

    }
}
