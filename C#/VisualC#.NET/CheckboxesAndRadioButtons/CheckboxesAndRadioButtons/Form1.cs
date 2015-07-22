using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckboxesAndRadioButtons
{
    public partial class Form1 : Form
    {  
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSelectedMovies_Click(object sender, EventArgs e)
        {
            string userGenres = "Your favorite genres: ";
            if (checkBoxComedy.Checked)
            {
                userGenres += "Comedy ";
            }
            if (checkBoxAction.Checked)
            {
                userGenres += "Action ";
            }
            if (checkBoxDrama.Checked)
            {
                userGenres += "Drama ";
            }
            if (checkBoxFantasy.Checked)
            {
                userGenres += "Fantasy ";
            }
            if (checkBoxHorror.Checked)
            {
                userGenres += "Horror ";
            }
            MessageBox.Show(userGenres, "Favorite genres");
        }
    }
}
