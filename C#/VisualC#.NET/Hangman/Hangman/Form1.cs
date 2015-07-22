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
        private string currentWord; //tracks the current word being used (hidden from user)
        private int currentWordLength;
        private string hiddenWord; //the hidden word displayed to the user

        public Form1()
        {
            InitializeComponent();
            words = new string[NUM_WORDS]
            {
                "ELEPHANT",
                "BASKET",
                "SHIRT",
                "ANTIDISESTABLISHMENTARIANISM",
                "TO",
                "POSTER",
                "DRAGON",
                "BEACH",
                "HECK",
                "GUITAR"
            };
            used = new int[NUM_WORDS];
            random = new Random();
            currentWordLength = 0;
            currentWord = "";
            hiddenWord = "";
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            checkLetter(buttonA.Text[0]);
            buttonA.Enabled = false;
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            checkLetter(buttonB.Text[0]);
            buttonB.Enabled = false;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            checkLetter(buttonC.Text[0]);
            buttonC.Enabled = false;
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            checkLetter(buttonD.Text[0]);
            buttonD.Enabled = false;
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            checkLetter(buttonE.Text[0]);
            buttonE.Enabled = false;
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            checkLetter(buttonF.Text[0]);
            buttonF.Enabled = false;
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            checkLetter(buttonG.Text[0]);
            buttonG.Enabled = false;
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            checkLetter(buttonH.Text[0]);
            buttonH.Enabled = false;
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            checkLetter(buttonI.Text[0]);
            buttonI.Enabled = false;
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            checkLetter(buttonJ.Text[0]);
            buttonJ.Enabled = false;
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            checkLetter(buttonK.Text[0]);
            buttonK.Enabled = false;
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            checkLetter(buttonL.Text[0]);
            buttonL.Enabled = false;
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            checkLetter(buttonM.Text[0]);
            buttonM.Enabled = false;
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            checkLetter(buttonN.Text[0]);
            buttonN.Enabled = false;
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            checkLetter(buttonO.Text[0]);
            buttonO.Enabled = false;
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            checkLetter(buttonP.Text[0]);
            buttonP.Enabled = false;
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            checkLetter(buttonQ.Text[0]);
            buttonQ.Enabled = false;
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            checkLetter(buttonR.Text[0]);
            buttonR.Enabled = false;
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            checkLetter(buttonS.Text[0]);
            buttonS.Enabled = false;
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            checkLetter(buttonT.Text[0]);
            buttonT.Enabled = false;
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            checkLetter(buttonU.Text[0]);
            buttonU.Enabled = false;
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            checkLetter(buttonV.Text[0]);
            buttonV.Enabled = false;
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            checkLetter(buttonW.Text[0]);
            buttonW.Enabled = false;
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            checkLetter(buttonX.Text[0]);
            buttonX.Enabled = false;
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            checkLetter(buttonY.Text[0]);
            buttonY.Enabled = false;
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            checkLetter(buttonZ.Text[0]);
            buttonZ.Enabled = false;
        }

        private void buttonNewWord_Click(object sender, EventArgs e)
        {
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
                currentWord = words[index]; //save the new word
                currentWordLength = currentWord.Length;
                hiddenWord = new string('*', currentWordLength); //construct a hidden version of the new word using asterisks
                updateDisplay();
            }
        }

        private bool checkLetter(char letter)
        {
            letter = Char.ToUpper(letter); //convert letter to uppercase
            List<int> foundIndexes = new List<int>();
            //Search for instances of the given letter in the current word
            for (int i = 0; i < currentWordLength; i++)
            {
                if (currentWord[i] == letter)
                {
                    foundIndexes.Add(i);
                }
            }
            if (foundIndexes.Count > 0) //if any instances of the letter were found
            {
                //Construct new hidden word with guessed letter exposed
                StringBuilder sb = new StringBuilder(hiddenWord);
                foreach (int i in foundIndexes)
                {
                    sb[i] = letter;
                }
                hiddenWord = sb.ToString(); //store the new hidden word with exposed letters
                updateDisplay();

                return true;
            }
            else
            {
                return false;
            }
        }

        /*  Updates the display with the most recent hidden word.
            Checks whether the user has won the game. */
        private void updateDisplay()
        {
            textBoxWord.Text = hiddenWord;
            if (hiddenWord == currentWord) //the hidden word is fully exposed and the user has won the game
            {
                MessageBox.Show("You Win!", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
