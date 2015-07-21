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
        private double buffer; //stores the previous value of the display

        // Enumerated type for calculator operations
        private enum Operation
        {
            None,
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
            lastOp = Operation.None;
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
            buffer = double.Parse(displayTextBox.Text); //store display value in buffer
            Calculate(); //perform calculation
            lastOp = Operation.Add; //update most recent operation
            displayTextBox.Clear(); //clear display
            WriteToDebug();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            buffer = double.Parse(displayTextBox.Text); //store display value in buffer
            Calculate(); //perform calculation
            lastOp = Operation.Subtract; //update most recent operation
            displayTextBox.Clear(); //clear display
            WriteToDebug();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            buffer = double.Parse(displayTextBox.Text); //store display value in buffer
            Calculate(); //perform calculation
            lastOp = Operation.Multiply; //update most recent operation
            displayTextBox.Clear(); //clear display
            WriteToDebug();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            buffer = double.Parse(displayTextBox.Text); //store display value in buffer
            Calculate(); //perform calculation
            lastOp = Operation.Divide; //update most recent operation
            displayTextBox.Clear(); //clear display
            WriteToDebug();
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            buffer = double.Parse(displayTextBox.Text); //store display value in buffer
            Calculate(); //perform calculation
            displayTextBox.Text = result.ToString(); //show sum in display
            WriteToDebug();
            result = 0; //reset result to 0
            buffer = 0; //reset buffer to 0
            lastOp = Operation.None; //reset most recent operation
            WriteToDebug();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            displayTextBox.Clear();
        }

        /*  Calculate new result using the buffer, the current result and the most recent operation entered */
        private void Calculate()
        {
            switch (lastOp)
            {
                case Operation.Add:
                    result += buffer;
                    break;
                case Operation.Subtract:
                    result -= buffer;
                    break;
                case Operation.Multiply:
                    result *= buffer;
                    break;
                case Operation.Divide:
                    result /= buffer;
                    break;
                //In this case, lastOp is set to None, so simply set the value of result to the buffer
                default:
                    SetResult();
                    break;
            }
        }

        /*  Sets the value of result to the value of the buffer */
        private void SetResult()
        {
            result = buffer;
        }

        /*  Write to debug window */
        private void WriteToDebug()
        {
            Debug.WriteLine("Most recent operation: {0}", lastOp);
            Debug.WriteLine("Current result: {0}", result);
            Debug.WriteLine("Current buffer value: {0}", buffer);
        }
    }
}
