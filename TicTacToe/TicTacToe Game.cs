using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int turn = 0;
        int counter = 0;

        private void upperleft_btn_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                upperleft_btn.Text = "X";
                turn += 1;
                upperleft_btn.Enabled = false;
                counter += 1;
                checkforwinner();
            }
            else if (turn == 1)
            {
                upperleft_btn.Text = "O";
                turn -= 1;
                upperleft_btn.Enabled = false;
                counter += 1;
                checkforwinner();
            }
        }
        private void uppermid_btn_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                uppermid_btn.Text = "X";
                turn += 1;
                uppermid_btn.Enabled = false;
                counter += 1;
                checkforwinner();
            }
            else if (turn == 1)
            {
                uppermid_btn.Text = "O";
                turn -= 1;
                uppermid_btn.Enabled = false;
                counter += 1;
                checkforwinner();
            }
        }
        private void upperright_btn_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                upperright_btn.Text = "X";
                turn += 1;
                upperright_btn.Enabled = false;
                counter += 1;
                checkforwinner();
            }
            else if (turn == 1)
            {
                upperright_btn.Text = "O";
                turn -= 1;
                upperright_btn.Enabled = false;
                counter += 1;
                checkforwinner();
            }
        }
        private void midleft_btn_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                midleft_btn.Text = "X";
                turn += 1;
                midleft_btn.Enabled = false;
                counter += 1;
                checkforwinner();
            }
            else if (turn == 1)
            {
                midleft_btn.Text = "O";
                turn -= 1;
                midleft_btn.Enabled = false;
                counter += 1;
                checkforwinner();
            }
        }
        private void middle_btn_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                middle_btn.Text = "X";
                turn += 1;
                middle_btn.Enabled = false;
                counter += 1;
                checkforwinner();
            }
            else if (turn == 1)
            {
                middle_btn.Text = "O";
                turn -= 1;
                middle_btn.Enabled = false;
                counter += 1;
                checkforwinner();
            }
        }
        private void midright_btn_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                midright_btn.Text = "X";
                turn += 1;
                midright_btn.Enabled = false;
                counter += 1;
                checkforwinner();
            }
            else if (turn == 1)
            {
                midright_btn.Text = "O";
                turn -= 1;
                midright_btn.Enabled = false;
                counter += 1;
                checkforwinner();
            }
        }
        private void lowerleft_btn_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                lowerleft_btn.Text = "X";
                turn += 1;
                lowerleft_btn.Enabled = false;
                counter += 1;
                checkforwinner();
            }
            else if (turn == 1)
            {
                lowerleft_btn.Text = "O";
                turn -= 1;
                lowerleft_btn.Enabled = false;
                counter += 1;
                checkforwinner();
            }
        }
        private void lowermid_btn_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                lowermid_btn.Text = "X";
                turn += 1;
                lowermid_btn.Enabled = false;
                counter += 1;
                checkforwinner();
            }
            else if (turn == 1)
            {
                lowermid_btn.Text = "O";
                turn -= 1;
                lowermid_btn.Enabled = false;
                counter += 1;
                checkforwinner();
            }
        }
        private void lowerright_btn_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                lowerright_btn.Text = "X";
                turn += 1;
                lowerright_btn.Enabled = false;
                counter += 1;
                checkforwinner();
            }
            else if (turn == 1)
            {
                lowerright_btn.Text = "O";
                turn -= 1;
                lowerright_btn.Enabled = false;
                counter += 1;
                checkforwinner();
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            upperleft_btn.Text = "";
            upperleft_btn.Enabled = true;
            uppermid_btn.Text = "";
            uppermid_btn.Enabled = true;
            upperright_btn.Text = "";
            upperright_btn.Enabled = true;
            midleft_btn.Text = "";
            midleft_btn.Enabled = true;
            middle_btn.Text = "";
            middle_btn.Enabled = true;
            midright_btn.Text = "";
            midright_btn.Enabled = true;
            lowerleft_btn.Text = "";
            lowerleft_btn.Enabled = true;
            lowermid_btn.Text = "";
            lowermid_btn.Enabled = true;
            lowerright_btn.Text = "";
            lowerright_btn.Enabled = true;
            counter = 0;
            turn = 0;
            p1_score.Text = "";
            p2_score.Text = "";
        }

        bool winner = false;
        private void checkforwinner()
        {
            //Horizontal winner checker
            if ((upperleft_btn.Text == uppermid_btn.Text) && (uppermid_btn.Text == upperright_btn.Text) && (!upperleft_btn.Enabled))
            {
                winner = true;
            }

            if ((midleft_btn.Text == middle_btn.Text) && (middle_btn.Text == midright_btn.Text) && (!midleft_btn.Enabled))
            {
                winner = true;
            }

            if ((lowerleft_btn.Text == lowermid_btn.Text) && (lowermid_btn.Text == lowerright_btn.Text) && (!lowerleft_btn.Enabled))
            {
                winner = true;
            }

            //Vertical winner checker
            if ((upperleft_btn.Text == midleft_btn.Text) && (midleft_btn.Text == lowerleft_btn.Text) && (!upperleft_btn.Enabled))
            {
                winner = true;
            }

            if ((uppermid_btn.Text == middle_btn.Text) && (middle_btn.Text == lowermid_btn.Text) && (!uppermid_btn.Enabled))
            {
                winner = true;
            }

            if ((upperright_btn.Text == midright_btn.Text) && (midright_btn.Text == lowerright_btn.Text) && (!upperright_btn.Enabled))
            {
                winner = true;
            }

            //Diagonal winner checker
            if ((upperleft_btn.Text == middle_btn.Text) && (middle_btn.Text == lowerright_btn.Text) && (!upperleft_btn.Enabled))
            {
                winner = true;
            }

            if ((lowerleft_btn.Text == middle_btn.Text) && (middle_btn.Text == upperright_btn.Text) && (!lowerleft_btn.Enabled))
            {
                winner = true;
            }

            //winner message code
            if (winner)
            {
                if (turn == 1)
                {
                    MessageBox.Show("X player won!", "Yehey! :>");
                    upperleft_btn.Text = "";
                    upperleft_btn.Enabled = true;
                    uppermid_btn.Text = "";
                    uppermid_btn.Enabled = true;
                    upperright_btn.Text = "";
                    upperright_btn.Enabled = true;
                    midleft_btn.Text = "";
                    midleft_btn.Enabled = true;
                    middle_btn.Text = "";
                    middle_btn.Enabled = true;
                    midright_btn.Text = "";
                    midright_btn.Enabled = true;
                    lowerleft_btn.Text = "";
                    lowerleft_btn.Enabled = true;
                    lowermid_btn.Text = "";
                    lowermid_btn.Enabled = true;
                    lowerright_btn.Text = "";
                    lowerright_btn.Enabled = true;
                    counter = 0;
                    turn = 0;
                    winner = false;
                    p1_score.Text += "I";
                    
                }
                else if (turn == 0)
                {
                    MessageBox.Show("O player won!", "Yehey! :>");
                    upperleft_btn.Text = "";
                    upperleft_btn.Enabled = true;
                    uppermid_btn.Text = "";
                    uppermid_btn.Enabled = true;
                    upperright_btn.Text = "";
                    upperright_btn.Enabled = true;
                    midleft_btn.Text = "";
                    midleft_btn.Enabled = true;
                    middle_btn.Text = "";
                    middle_btn.Enabled = true;
                    midright_btn.Text = "";
                    midright_btn.Enabled = true;
                    lowerleft_btn.Text = "";
                    lowerleft_btn.Enabled = true;
                    lowermid_btn.Text = "";
                    lowermid_btn.Enabled = true;
                    lowerright_btn.Text = "";
                    lowerright_btn.Enabled = true;
                    counter = 0;
                    turn = 0;
                    winner = false;
                    p2_score.Text += "I";

                }
            }

            //draw checker
            if (counter == 9)
            {
                MessageBox.Show("Game is draw, please try again.", "Aw :<");
                upperleft_btn.Text = "";
                upperleft_btn.Enabled = true;
                uppermid_btn.Text = "";
                uppermid_btn.Enabled = true;
                upperright_btn.Text = "";
                upperright_btn.Enabled = true;
                midleft_btn.Text = "";
                midleft_btn.Enabled = true;
                middle_btn.Text = "";
                middle_btn.Enabled = true;
                midright_btn.Text = "";
                midright_btn.Enabled = true;
                lowerleft_btn.Text = "";
                lowerleft_btn.Enabled = true;
                lowermid_btn.Text = "";
                lowermid_btn.Enabled = true;
                lowerright_btn.Text = "";
                lowerright_btn.Enabled = true;
                counter = 0;
                turn = 0;
            }
        }
    }
}