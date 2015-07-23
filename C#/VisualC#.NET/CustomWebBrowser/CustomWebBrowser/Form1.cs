using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomWebBrowser
{
    public partial class Form1 : Form
    {
        private string home = "http://www.google.ca";

        public Form1()
        {
            InitializeComponent();
            webBrowser1.Navigate(home);
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            string address = textBoxAddress.Text.Trim();
            webBrowser1.Navigate(address);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(home);
        }
    }
}
