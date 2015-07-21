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
                //Use the Cut() method of the TextBox class to cut selected text from a text box
                textBox1.Cut();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.CanUndo)
            {
                //Use the Undo() method of the TextBox class to undo changes made to the text box
                textBox1.Undo();
            }
        }
    }
}
