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

namespace Hangman
{
    public partial class Form1 : Form
    {
        private const int NUM_WORDS = 10; //number of possible words in this game
        private string[] words; //words to be used in the game
        private int[] used; //tracks used words
        private Random random; //Random object for generating next word

        public Form1()
        {
            InitializeComponent();
            words = new string[NUM_WORDS]
            {
                "Elephant",
                "Basket",
                "Shirt",
                "Antidisestablishmentarianism",
                "To",
                "Poster",
                "Dragon",
                "Beach",
                "Heaven",
                "Guitar"
            };
            used = new int[NUM_WORDS];
            random = new Random();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {

        }

        private void buttonB_Click(object sender, EventArgs e)
        {

        }

        private void buttonC_Click(object sender, EventArgs e)
        {

        }

        private void buttonD_Click(object sender, EventArgs e)
        {

        }

        private void buttonE_Click(object sender, EventArgs e)
        {

        }

        private void buttonF_Click(object sender, EventArgs e)
        {

        }

        private void buttonG_Click(object sender, EventArgs e)
        {

        }

        private void buttonH_Click(object sender, EventArgs e)
        {

        }

        private void buttonI_Click(object sender, EventArgs e)
        {

        }

        private void buttonJ_Click(object sender, EventArgs e)
        {

        }

        private void buttonK_Click(object sender, EventArgs e)
        {

        }

        private void buttonL_Click(object sender, EventArgs e)
        {

        }

        private void buttonM_Click(object sender, EventArgs e)
        {

        }

        private void buttonN_Click(object sender, EventArgs e)
        {

        }

        private void buttonO_Click(object sender, EventArgs e)
        {

        }

        private void buttonP_Click(object sender, EventArgs e)
        {

        }

        private void buttonQ_Click(object sender, EventArgs e)
        {

        }

        private void buttonR_Click(object sender, EventArgs e)
        {

        }

        private void buttonS_Click(object sender, EventArgs e)
        {

        }

        private void buttonT_Click(object sender, EventArgs e)
        {

        }

        private void buttonU_Click(object sender, EventArgs e)
        {

        }

        private void buttonV_Click(object sender, EventArgs e)
        {

        }

        private void buttonW_Click(object sender, EventArgs e)
        {

        }

        private void buttonX_Click(object sender, EventArgs e)
        {

        }

        private void buttonY_Click(object sender, EventArgs e)
        {

        }

        private void buttonZ_Click(object sender, EventArgs e)
        {

        }

        private void buttonNewWord_Click(object sender, EventArgs e)
        {
            string newWord;
            int index = random.Next(0, NUM_WORDS - 1); //generate an index for the new word
            Debug.WriteLine(index);
            int count = 0; //track how many times a random number has been generated (don't exceed NUM_WORDS)
            while (used[index] > 0 && count < NUM_WORDS) //look for an unused index
            {
                index = random.Next(0, NUM_WORDS - 1);
                count++;
            }
            if (count == 10) //if a random number has been generated NUM_WORDS times, we're out of words
            {
                MessageBox.Show("No more words!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else //otherwise, show the new word and start the game
            {
                used[index] = 1; //mark this index as used
                newWord = words[index]; //save the new word
                int newWordLength = newWord.Length;
                string hiddenWord = new string('*', newWordLength); //construct a hidden version of the new word using asterisks
                textBoxWord.Text = hiddenWord; //display the (hidden) word
            }
        }
    }
}
