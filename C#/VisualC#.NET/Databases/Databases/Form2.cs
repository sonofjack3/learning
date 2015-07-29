using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                databaseConn = new Properties.DatabaseConnection();
                connString = Properties.Settings.Default.EmployeesConnectionString;
                databaseConn.connection_string = connString;
                databaseConn.Sql = Properties.Settings.Default.SQL;
                dataSet = databaseConn.GetConnection;
                maxRows = dataSet.Tables[0].Rows.Count;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            firstName = textBoxFirstName.Text.ToString();
            lastName = textBoxLastName.Text.ToString();
            department = textBoxDepartment.Text.ToString();
            jobTitle = textBoxJobTitle.Text.ToString();

            dataRow = dataSet.Tables[0].NewRow();
            dataRow[1] = firstName;
            dataRow[2] = lastName;
            dataRow[3] = jobTitle;
            dataRow[4] = department;

            dataSet.Tables[0].Rows.Add(dataRow);

            try
            {
                databaseConn.UpdateDatabase(dataSet);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Form2()
        {
            InitializeComponent();
        }
    }
}
