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

namespace ManipulatingFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            //This assumes there is a file on the computer Desktop called "test1.txt"
            string fileName = "\\test1.txt";
            fileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + fileName;
            //An object of the StreamReader class can be used to read from a text file
            StreamReader reader = new StreamReader(fileName);
            //The ReadToEnd() method of a StreamReader object reads all contents of a file
            textBox1.Text = reader.ReadToEnd();
            //Remember to always close the stream (also don't cross them)
            reader.Close();
        }
    }
}
