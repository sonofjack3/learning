using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*  This method is an event handler and handles the event of button1 being clicked */
        private void button1_Click(object sender, EventArgs e)
        {
            /*  "sender" indicates which object sent the event */
            MessageBox.Show("Sender object: " + sender.ToString());
            /*  "e" is an object of the EventArgs class and indicates what event has been raised */
            MessageBox.Show("EventArgs: " + e.ToString());
        }
    }
}
