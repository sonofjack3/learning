using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*  This method controls what happens when button1 is clicked. */
        private void button1_Click(object sender, EventArgs e)
        {
            /* The MessageBox class can be used to display popup boxes with text */
            /* The MessageBoxButtons class can be used to specify what buttons appear in a MessageBox */
            /* The MessageBoxIcons class can be used to specify the icon to be displayed with the MessageBox */
            MessageBox.Show("This is a message", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
