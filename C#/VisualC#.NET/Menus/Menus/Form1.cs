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
                richTextBox1.Show();
            }
            else
            {
                textBox1.Hide();
                textBox2.Hide();
                richTextBox1.Hide();
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

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display open file dialog
            openFileDialogImage.ShowDialog();
            //Set default location to look for files
            openFileDialogImage.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            //Get name of file
            string fileName = "";
            fileName = openFileDialogImage.FileName;
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
                Debug.WriteLine(fe);
            }
        }

        private void openTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display open file dialog
            openFileDialogText.ShowDialog();
            //Set default location to look for files
            openFileDialogText.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //Get name of file
            string fileName = "";
            fileName = openFileDialogText.FileName;
            //Show text in rich text box
            try
            {
                //Use the LoadFile() method from the RichTextBox class to load from a text file
                richTextBox1.LoadFile(fileName, RichTextBoxStreamType.PlainText);
            }
            catch (FileNotFoundException fe)
            {
                Debug.WriteLine(fe);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set default location to save files
            openFileDialogText.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileName = "";
            //Save the file
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                fileName = saveFileDialog1.FileName;
                //The SaveFile() method of the RichTextBox class does the actual saving
                richTextBox1.SaveFile(fileName, RichTextBoxStreamType.PlainText);
            }
        }
    }
}
