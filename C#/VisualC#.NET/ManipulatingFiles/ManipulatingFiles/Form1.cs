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
            //An object of the StreamReader class can be used to read from a file
            StreamReader reader1, reader2;
            //This assumes there is a file on the computer Desktop called "test1.txt"
            string fileName1 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\test1.txt";
            try {
                reader1 = new StreamReader(fileName1);
                //The ReadToEnd() method of a StreamReader object reads all contents of a file
                textBox1.Text = reader1.ReadToEnd();
                //Remember to always close the stream (also don't cross them)
                reader1.Close();
            }
            catch (FileNotFoundException fe)
            {
                textBox1.Text = "No file test1.txt on Desktop!";
            }

            //This assumes there is a file on the computer Desktop called "test2.txt"
            string fileName2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\test2.txt";
            try
            {
                reader2 = new StreamReader(fileName2);
                string textLine = "";
                int lineCount = 0;
                //The Peek() method of StreamReader checks one character at a time and returns -1 when no new character is found
                while (reader2.Peek() != -1)
                {
                    //The ReadLine() method of StreamReader reads a file one line at a time
                    textLine += reader2.ReadLine() + "\r\n";
                    lineCount++;
                }
                textLine += "The file has " + lineCount + " lines";
                textBox2.Text = textLine;
                reader2.Close();
            }
            catch (FileNotFoundException fe)
            {
                textBox2.Text = "No file test2.txt on Desktop!";
            }
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            //An object of the StreamWriter class can be used to write to a file
            StreamWriter writer1;
            //We will write to a text file on the user's desktop
            string fileName1 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\test3.txt";
            writer1 = new StreamWriter(fileName1);
            //Take the text from textBox3 and write it to the file
            writer1.Write(textBox3.Text);
            //Remember to close the stream
            writer1.Close();
        }
    }
}
