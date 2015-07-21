using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogRes = MessageBox.Show("Really quit?", "Quit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogRes == DialogResult.OK)
            {
                //Use Application.Exit() to close the program
                Application.Exit();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "")
            {
                textBox1.Cut();
            }
        }
    }
}
