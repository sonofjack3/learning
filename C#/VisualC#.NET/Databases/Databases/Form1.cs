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
            DatabaseConnect();
        }

        private void NavigateRecords()
        {
            dataRow = dataSet.Tables[0].Rows[inc];

            textBoxFirstName.Text = dataRow.ItemArray.GetValue(1).ToString();
            textBoxLastName.Text = dataRow.ItemArray.GetValue(2).ToString();
            textBoxJobTitle.Text = dataRow.ItemArray.GetValue(3).ToString();
            textBoxDepartment.Text = dataRow.ItemArray.GetValue(4).ToString();

            EnableDisableButtons();
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

        private void EnableDisableButtons()
        {
            if (inc == 0)
            {
                buttonPrevious.Enabled = false;
            }
            else if (inc > 0 && inc < maxRows - 1)
            {
                buttonPrevious.Enabled = true;
                buttonNext.Enabled = true;
            }
            else
            {
                buttonNext.Enabled = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form2 formAdd = new Form2();
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                DatabaseConnect();
            }
        }

        private void DatabaseConnect()
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
                Debug.WriteLine("Max rows " + maxRows);
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
