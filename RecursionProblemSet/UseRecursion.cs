using System;
using System.Windows.Forms;

/* Jathurshan Theivikaran
 * November 2019
 * this program uses recursion to solve different cases involving strings and integers
 */

namespace RecursionProblemSet
{
    public partial class UseRecursion : Form
    {
        public UseRecursion()
        {
            InitializeComponent();
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            //adds hyphens in better each character
            string Word = txtA.Text;

            string Output = Expand(Word);
            lblOutput.Text = Output;
        }

        public string Expand(string Word)
        {
            if (Word.Length == 0)
            {
                return string.Empty;
            }
            else if (Word.Length == 1)
            {
                return Word;
            }
            else
            {
                return Word[0] + "-" + Expand(Word.Substring(1, Word.Length - 1));
            }
        }

        private void btnGCD_Click(object sender, EventArgs e)
        {
            //find greatest commom factor between two numbers
            int a = int.Parse(txtB.Text);
            int b = int.Parse(txtC.Text);
            int Output = GCD(a, b);
            lblOutput.Text = Output.ToString();
        }

        int GCD(int a, int b)
        {
            if (a % b == 0)
            {
                return b;
            }
            else
            {
                return GCD(b, a % b);
            }
        }

        private void btmCompact_Click(object sender, EventArgs e)
        {
            //delete spaces in word
            string Line = txtA.Text;

            string Output = Compact(Line);
            
            lblOutput.Text = Output;
        }

        string Compact(string Line)
        {
            if (Line.IndexOf(" ") == -1)
            {
                return Line;
            }
            else
            {
                return Compact(Line.Substring(0, Line.IndexOf(" ")) + Line.Substring(Line.IndexOf(" ") + 1, Line.Length - Line.IndexOf(" ") - 1));
            }
        }

        private void btnPalindrome_Click(object sender, EventArgs e)
        {
            //determine if word is a palindrome
            string Word = txtA.Text;

            bool Output = Palidrome(Word);

            lblOutput.Text = Output.ToString();
        }

        bool Palidrome(string Word)
        {
            if (Word.Length != 0 && Word[0] != Word[Word.Length - 1])
            {
                return false;
            }
            else if (Word.Length == 1 || Word.Length == 0)
            {
                return true;
            }
            else
            {
                return Palidrome(Word.Substring(1, Word.Length - 2));
            }
        }
    }
}