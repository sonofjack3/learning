using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* Event handler called when Loop button is clicked */
        private void buttonLoop_Click(object sender, EventArgs e)
        {
            int start = int.Parse(textBoxStart.Text);
            int end = int.Parse(textBoxEnd.Text);
            string line;
            for (int i = start; i <= end; i++)
            {
                line = String.Format("{0} times 10 is {1}", i, i * 10);
                listBoxResults.Items.Add(line);
            }
        }
    }
}
