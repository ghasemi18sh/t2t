using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t2t_new
{
    public partial class Form1 : Form
    {
        Button[,] mybuttons;
      
        int Player;
        public Form1()
        {
            InitializeComponent();
            mybuttons = new Button[3, 3];
            sazandebutton();
            new_game();
    
        }
        private void sazandebutton()
        {
 
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mybuttons[i, j] = new Button();
                    mybuttons[i, j].Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                    mybuttons[i, j].Click += new EventHandler(button1_Click);
                    tableLayoutPanel1.Controls.Add(mybuttons[i, j], i, j);

                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button this_button = (sender as Button);
            if (this_button.Text == "")
            {
                if (Player == 1)
                {
                    this_button.Text = "X";
                    this_button.BackColor = Color.Pink;
                    this_button.ForeColor = Color.Black;
                    Player = 2;
                }
                else if (Player == 2)
                {
                    this_button.Text = "O";
                    this_button.BackColor = Color.Green;
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
                    mybuttons[i, j].Text = "";
                    mybuttons[i, j].BackColor = Color.Transparent;
                }
            }
        }
  private void check_game()
        {
            if(mybuttons[0,0].Text=="X" && mybuttons[0, 1].Text == "X" && mybuttons[0, 2].Text == "X")
            {
                MessageBox.Show("بازیکن اول برنده شد");
                new_game();
            }
            if (mybuttons[1, 0].Text == "X" && mybuttons[1, 1].Text == "X" && mybuttons[1, 2].Text == "X")
            {
                MessageBox.Show("بازیکن اول برنده شد");
                new_game();
            }
            if (mybuttons[2, 0].Text == "X" && mybuttons[2, 1].Text == "X" && mybuttons[2, 2].Text == "X")
            {
                MessageBox.Show("بازیکن اول برنده شد");
                new_game();
            }
            if (mybuttons[0, 0].Text == "X" && mybuttons[1, 0].Text == "X" && mybuttons[2, 0].Text == "X")
            {
                MessageBox.Show("بازیکن اول برنده شد");
                new_game();
            }
            if (mybuttons[0, 1].Text == "X" && mybuttons[1, 1].Text == "X" && mybuttons[2, 1].Text == "X")
            {
                MessageBox.Show("بازیکن اول برنده شد");
                new_game();
            }
            if (mybuttons[0, 2].Text == "X" && mybuttons[1, 2].Text == "X" && mybuttons[2, 2].Text == "X")
            {
                MessageBox.Show("بازیکن اول برنده شد");
                new_game();
            }
            if (mybuttons[0, 0].Text == "X" && mybuttons[1, 1].Text == "X" && mybuttons[2, 2].Text == "X")
            {
                MessageBox.Show("بازیکن اول برنده شد");
                new_game();
            }
            if (mybuttons[0, 2].Text == "X" && mybuttons[1, 1].Text == "X" && mybuttons[2, 0].Text == "X")
            {
                MessageBox.Show("بازیکن اول برنده شد");
                new_game();
            }


            if (mybuttons[0, 0].Text == "O" && mybuttons[0, 1].Text == "O" && mybuttons[0, 2].Text == "O")
            {
                MessageBox.Show("بازیکن دوم برنده شد");
                new_game();
            }
            if (mybuttons[1, 0].Text == "O" && mybuttons[1, 1].Text == "O" && mybuttons[1, 2].Text == "O")
            {
                MessageBox.Show("بازیکن دوم برنده شد");
                new_game();
            }
            if (mybuttons[2, 0].Text == "O" && mybuttons[2, 1].Text == "O" && mybuttons[2, 2].Text == "O")
            {
                MessageBox.Show("بازیکن دوم برنده شد");
                new_game();
            }
            if (mybuttons[0, 0].Text == "O" && mybuttons[1, 0].Text == "O" && mybuttons[2, 0].Text == "O")
            {
                MessageBox.Show("بازیکن دوم برنده شد");
                new_game();
            }
            if (mybuttons[0, 1].Text == "O" && mybuttons[1, 1].Text == "O" && mybuttons[2, 1].Text == "O")
            {
                MessageBox.Show("بازیکن دوم برنده شد");
                new_game();
            }
            if (mybuttons[0, 2].Text == "O" && mybuttons[1, 2].Text == "O" && mybuttons[2, 2].Text == "O")
            {
                MessageBox.Show("بازیکن دوم برنده شد");
                new_game();
            }
            if (mybuttons[0, 0].Text == "O" && mybuttons[1, 1].Text == "O" && mybuttons[2, 2].Text == "O")
            {
                MessageBox.Show("بازیکن دوم برنده شد");
                new_game();
            }
            if (mybuttons[0, 2].Text == "O" && mybuttons[1, 1].Text == "O" && mybuttons[2, 0].Text == "O")
            {
                MessageBox.Show("بازیکن دوم برنده شد");
                new_game();
            }
            else if (mybuttons[0, 0].Text != "" && mybuttons[0, 1].Text != "" && mybuttons[0, 2].Text != "" && mybuttons[1, 0].Text != "" && mybuttons[1, 1].Text != "" && mybuttons[1, 2].Text != "" && mybuttons[2, 0].Text != "" && mybuttons[2, 1].Text != "" && mybuttons[2, 2].Text != "")
            {
                MessageBox.Show("مساوی شدند");
                new_game();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
