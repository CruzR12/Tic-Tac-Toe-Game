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

        private void upperleft_btn_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                upperleft_btn.Text = "X";
                turn += 1;
            }
            else if (turn == 1)
            {
                upperleft_btn.Text = "O";
                turn -= 1;
            }
        }

        private void uppermid_btn_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                uppermid_btn.Text = "X";
                turn += 1;
            }
            else if (turn == 1)
            {
                uppermid_btn.Text = "O";
                turn -= 1;
            }
        }

        private void upperright_btn_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                upperright_btn.Text = "X";
                turn += 1;
            }
            else if (turn == 1)
            {
                upperright_btn.Text = "O";
                turn -= 1;
            }
        }

        private void midleft_btn_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                midleft_btn.Text = "X";
                turn += 1;
            }
            else if (turn == 1)
            {
                midleft_btn.Text = "O";
                turn -= 1;
            }
        }

        private void middle_btn_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                middle_btn.Text = "X";
                turn += 1;
            }
            else if (turn == 1)
            {
                middle_btn.Text = "O";
                turn -= 1;
            }
        }

        private void midright_btn_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                midright_btn.Text = "X";
                turn += 1;
            }
            else if (turn == 1)
            {
                midright_btn.Text = "O";
                turn -= 1;
            }
        }

        private void lowerleft_btn_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                lowerleft_btn.Text = "X";
                turn += 1;
            }
            else if (turn == 1)
            {
                lowerleft_btn.Text = "O";
                turn -= 1;
            }
        }
    }
}
