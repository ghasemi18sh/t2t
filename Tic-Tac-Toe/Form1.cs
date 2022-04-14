using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        Button[,] xbutton;
        int Player;
        public Form1()
        {
            InitializeComponent();

             xbutton = new Button[3, 3] { { button1,button2,button3},
                                          {button4,button5,button6 },
                                          {button7,button8,button9 }};

            new_game();
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button this_button = (sender as Button);
            if (this_button.Text == "")
            {
                if (Player == 1)
                {
                    this_button.Text = "X";
                    this_button.BackColor = Color.Yellow;
                    this_button.ForeColor = Color.Black;
                    Player = 2;
                }
                else if (Player == 2)
                {
                    this_button.Text = "O";
                    this_button.BackColor = Color.Purple;
                    this_button.ForeColor = Color.Black;
                    Player = 1;
                }

                check_game();
            }
        }
        private void button9_MouseHover(object sender, EventArgs e)
        {

        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            new_game();
        }

        private void new_game()
        {
            Player = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    xbutton[i, j].Text = "";
                    xbutton[i, j].BackColor = Color.Transparent;
                }
            }
        }

        private void check_game()
        {
            if(xbutton[0,0].Text=="X" && xbutton[0, 1].Text == "X" && xbutton[0, 2].Text == "X")
            {
                MessageBox.Show("bazikon aval barande shod !");
                new_game();
            }
            if (xbutton[1, 0].Text == "X" && xbutton[1, 1].Text == "X" && xbutton[1, 2].Text == "X")
            {
                MessageBox.Show("bazikon aval barande shod !");
                new_game();
            }
            if (xbutton[2, 0].Text == "X" && xbutton[2, 1].Text == "X" && xbutton[2, 2].Text == "X")
            {
                MessageBox.Show("bazikon aval barande shod !");
                new_game();
            }
            if (xbutton[0, 0].Text == "X" && xbutton[1, 0].Text == "X" && xbutton[2, 0].Text == "X")
            {
                MessageBox.Show("bazikon aval barande shod !");
                new_game();
            }
            if (xbutton[0, 1].Text == "X" && xbutton[1, 1].Text == "X" && xbutton[2, 1].Text == "X")
            {
                MessageBox.Show("bazikon aval barande shod !");
                new_game();
            }
            if (xbutton[0, 2].Text == "X" && xbutton[1, 2].Text == "X" && xbutton[2, 2].Text == "X")
            {
                MessageBox.Show("bazikon aval barande shod !");
                new_game();
            }
            if (xbutton[0, 0].Text == "X" && xbutton[1, 1].Text == "X" && xbutton[2, 2].Text == "X")
            {
                MessageBox.Show("bazikon aval barande shod !");
                new_game();
            }
            if (xbutton[0, 2].Text == "X" && xbutton[1, 1].Text == "X" && xbutton[2, 0].Text == "X")
            {
                MessageBox.Show("bazikon aval barande shod !");
                new_game();
            }


            if (xbutton[0, 0].Text == "O" && xbutton[0, 1].Text == "O" && xbutton[0, 2].Text == "O")
            {
                MessageBox.Show("Bazikon Dovom barande shod");
                new_game();
            }
            if (xbutton[1, 0].Text == "O" && xbutton[1, 1].Text == "O" && xbutton[1, 2].Text == "O")
            {
                MessageBox.Show("Bazikon Dovom barande shod");
                new_game();
            }
            if (xbutton[2, 0].Text == "O" && xbutton[2, 1].Text == "O" && xbutton[2, 2].Text == "O")
            {
                MessageBox.Show("Bazikon Dovom barande shod");
                new_game();
            }
            if (xbutton[0, 0].Text == "O" && xbutton[1, 0].Text == "O" && xbutton[2, 0].Text == "O")
            {
                MessageBox.Show("Bazikon Dovom barande shod");
                new_game();
            }
            if (xbutton[0, 1].Text == "O" && xbutton[1, 1].Text == "O" && xbutton[2, 1].Text == "O")
            {
                MessageBox.Show("Bazikon Dovom barande shod");
                new_game();
            }
            if (xbutton[0, 2].Text == "O" && xbutton[1, 2].Text == "O" && xbutton[2, 2].Text == "O")
            {
                MessageBox.Show("Bazikon Dovom barande shod");
                new_game();
            }
            if (xbutton[0, 0].Text == "O" && xbutton[1, 1].Text == "O" && xbutton[2, 2].Text == "O")
            {
                MessageBox.Show("Bazikon Dovom barande shod");
                new_game();
            }
            if (xbutton[0, 2].Text == "O" && xbutton[1, 1].Text == "O" && xbutton[2, 0].Text == "O")
            {
                MessageBox.Show("Bazikon Dovom barande shod");
                new_game();
            }
            else if (xbutton[0, 0].Text != "" && xbutton[0, 1].Text != "" && xbutton[0, 2].Text != "" && xbutton[1, 0].Text != "" && xbutton[1, 1].Text != "" && xbutton[1, 2].Text != "" && xbutton[2, 0].Text != "" && xbutton[2, 1].Text != "" && xbutton[2, 2].Text != "")
            {
                MessageBox.Show("Mosavi shod");
                new_game();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

