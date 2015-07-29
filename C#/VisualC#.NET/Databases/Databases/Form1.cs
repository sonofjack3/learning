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
    public partial class Form1 : Form
    {
        private Properties.DatabaseConnection databaseConn;
        private string connString;
        private DataSet dataSet;
        private DataRow dataRow;
        private int maxRows;
        private int inc = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //Called when the form is loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                databaseConn = new Properties.DatabaseConnection();
                connString = Properties.Settings.Default.EmployeesConnectionString;
                databaseConn.connection_string = connString;
                databaseConn.Sql = Properties.Settings.Default.SQL;
                dataSet = databaseConn.GetConnection;
                maxRows = dataSet.Tables[0].Rows.Count;
                NavigateRecords();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void NavigateRecords()
        {
            dataRow = dataSet.Tables[0].Rows[inc];

            textBoxFirstName.Text = dataRow.ItemArray.GetValue(1).ToString();
            textBoxLastName.Text = dataRow.ItemArray.GetValue(2).ToString();
            textBoxJobTitle.Text = dataRow.ItemArray.GetValue(3).ToString();
            textBoxDepartment.Text = dataRow.ItemArray.GetValue(4).ToString();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (inc < maxRows - 1)
            {
                inc++;
                NavigateRecords();
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (inc > 0)
            {
                inc--;
                NavigateRecords();
            }
        }
    }
}
