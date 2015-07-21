using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

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

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "")
            {
                //Use the Copy() method of the TextBox class to copy selected text from a text box
                textBox1.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Paste text into textBox2
            textBox2.Paste();
        }

        private void viewTextBoxesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (viewTextBoxesToolStripMenuItem.Checked)
            {
                textBox1.Show();
                textBox2.Show();
            }
            else
            {
                textBox1.Hide();
                textBox2.Hide();
            }
        }

        private void viewImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (viewImagesToolStripMenuItem.Checked)
            {
                pictureBox1.Show();
            }
            else
            {
                pictureBox1.Hide();
            }
        }

        private void insertImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display open file dialog
            openFileDialog1.ShowDialog();
            //Get name of file
            string fileName = "";
            fileName = openFileDialog1.FileName;
            //Display image in picture box
            try
            {
                //Create an image from a filename using the following
                pictureBox1.Image = Image.FromFile(fileName);
            }
            catch (FileNotFoundException fe)
            {
                //Access resource files using the following
                pictureBox1.Image = Properties.Resources.maxresdefault;
            }
        }
    }
}
