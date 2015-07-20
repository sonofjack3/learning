using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "9";
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += ".";
        }
    }
}
