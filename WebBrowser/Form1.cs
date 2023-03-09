using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        private List<string> historyList = new List<string>(); // ukládání historie

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            string url = toolStripComboBox1.Text;
            if (!string.IsNullOrWhiteSpace(url))
            {
                webBrowser2.Navigate(url);
                historyList.Add(url); // přidání stránky do historie
                toolStripComboBox2.Items.Add(url); // přidání stránky do historie v ComboBoxu
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (webBrowser2.CanGoBack)
            {
                webBrowser2.GoBack();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (webBrowser2.CanGoForward)
            {
                webBrowser2.GoForward();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser2.Refresh();
        }
        // domovksá stránka, není natvrdo -> dodělat
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("https://www.seznam.cz/");
        }
        // stránky https -> dodělat
        private void DisplayHomePage()
        {
            string homePage = toolStripComboBox1.SelectedItem.ToString();
            webBrowser2.Navigate("http://" + homePage);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.SelectedIndex = 0;
            DisplayHomePage();
            this.WindowState = FormWindowState.Maximized;
            webBrowser2.Dock = DockStyle.Fill;
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayHomePage();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            webBrowser2.Stop();
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUrl = toolStripComboBox2.SelectedItem.ToString();
            webBrowser2.Navigate(selectedUrl);
        }
    }
}
