using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Databases
{
    public partial class Form2 : Form
    {
        private string firstName, lastName, department, jobTitle;
        private Properties.DatabaseConnection databaseConn;
        private string connString;
        private DataSet dataSet;
        private DataRow dataRow;
        private int maxRows;

        public string FirstName
        {
            get { return firstName; }
        }

        public string LastName
        {
            get { return lastName; }
        }

        public string Department
        {
            get { return department; }
        }

        public string JobTitle
        {
            get { return jobTitle; }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            firstName = textBoxFirstName.Text.ToString();
            lastName = textBoxLastName.Text.ToString();
            department = textBoxDepartment.Text.ToString();
            jobTitle = textBoxJobTitle.Text.ToString();
            this.DialogResult = DialogResult.OK;
        }

        public Form2()
        {
            InitializeComponent();
        }
    }
}
