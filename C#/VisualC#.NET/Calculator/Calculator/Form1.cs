using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        private double result; //the current result

        // Enumerated type for calculator operations
        private enum Operation
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }

        private Operation lastOp; //the most recent operation that has been performed

        public CalculatorForm()
        {
            InitializeComponent();
            result = 0;
        }

        //************************************************************
        //  Event handler methods for buttons
        //***********************************************************

        private void button0_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += button0.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += button2.Text; ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += button3.Text; ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += button4.Text; ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += button5.Text; ;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += button6.Text; ;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += button7.Text; ;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += button8.Text; ;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += button9.Text; ;
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            //Only allow one decimal to be entered
            if (displayTextBox.Text.IndexOf('.', 0) < 0)
            {
                displayTextBox.Text += buttonDecimal.Text; ;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            add(); //add to current result
            lastOp = Operation.Add; //update most recent operation
            displayTextBox.Clear(); //clear display
            Debug.WriteLine("Current result: {0}", result);
            Debug.WriteLine("Most recent operation: {0}", lastOp);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {

        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {

        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {

        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (displayTextBox.Text != "")
            {
                add(); //add to current sum
            }
            displayTextBox.Text = result.ToString(); //show sum in display
            result = 0; //reset sum to 0
            Debug.WriteLine("Final sum: {0}", result);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            displayTextBox.Clear();
        }

        /*  Adds value of the display box to the current sum */
        private void add()
        {
            result += double.Parse(displayTextBox.Text);
        }
    }
}
