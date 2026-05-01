using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class RPS : Form
    {
        int Player1, Player2, win;
        int Player1Score = 0, Player2Score = 0;
        int time = 0;
        public RPS()
        {
            InitializeComponent();
        }

        private void RPS_Load(object sender, EventArgs e)
        {

        }

        private void rbtnRock1_CheckedChanged(object sender, EventArgs e)
        {
            Player1 = 1;
        }

        private void rbtnPaper1_CheckedChanged(object sender, EventArgs e)
        {
            Player1 = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Player1 = 3;
        }

        private void rbtnRock2_CheckedChanged(object sender, EventArgs e)
        {
            Player2 = 1;
        }

        private void rbtnPaper2_CheckedChanged(object sender, EventArgs e)
        {
            Player2 = 2;
        }

        private void rbtnSci2_CheckedChanged(object sender, EventArgs e)
        {
            Player2 = 3;
        }

        private void btnLock1_Click(object sender, EventArgs e)
        {
            //Hiding the group box
            gbPlayer1.Hide();

            //Changing text
            btnLock1.Text = "Locked in";
            btnLock1.Enabled = false;
        }

        private void btnLock2_Click(object sender, EventArgs e)
        {
            //Hiding the group box
            gbPlayer2.Hide();

            //Changing text
            btnLock2.Text = "Locked in";
            btnLock2.Enabled = false;
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            var MainMenu = new Main_menu();
            MainMenu.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;

            if(time == 1)
            {
                pbRock1_1.Visible = true;
                pbRock1_2.Visible = false;

                pbRock2_1.Visible = true;
                pbRock2_2.Visible = false;

            }
            if (time == 2)
            {
                pbRock1_1.Visible = false;
                pbRock1_2.Visible = true;

                pbRock2_1.Visible = false;
                pbRock2_2.Visible = true;

            }
            if (time == 3)
            {
                pbRock1_1.Visible = true;
                pbRock1_2.Visible = false;

                pbRock2_1.Visible = true;
                pbRock2_2.Visible = false;

            }
            if (time == 4)
            {
                pbRock1_1.Visible = false;
                pbRock1_2.Visible = true;

                pbRock2_1.Visible = false;
                pbRock2_2.Visible = true;

            }
            if (time == 5)
            {
                pbRock1_1.Visible = true;
                pbRock1_2.Visible = false;

                pbRock2_1.Visible = true;
                pbRock2_2.Visible = false;

            }
            if(time == 6)
            {
                pbRock1_1.Visible = false;
                pbRock2_1.Visible = false;

                //Player 1
                if (rbtnRock1.Checked)
                {
                    pbRock1_2.Visible = true;
                }
                else if(rbtnPaper1.Checked)
                {
                    pbPaper1_1.Visible = true;
                }
                else if(rbtnSci1.Checked)
                {
                    pbScissors1_1.Visible = true;
                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("A player has not selected theirweapon");

                    //Hiding the hands again
                    time = 0;

                    pbRock1_2.Visible = false;
                    pbPaper1_1.Visible = false;
                    pbScissors1_1.Visible = false;

                    pbRock2_2.Visible = false;
                    pbPaper2_1.Visible = false;
                    pbScissors2_1.Visible = false;
                }

                //Player 2
                if (rbtnRock2.Checked)
                {
                    pbRock2_2.Visible = true;
                }
                else if (rbtnPaper2.Checked)
                {
                    pbPaper2_1.Visible = true;
                }
                else if (rbtnSci2.Checked)
                {
                    pbScissors2_1.Visible = true;
                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("A player has not selected theirweapon");

                    //Hiding the hands again
                    time = 0;

                    pbRock1_2.Visible = false;
                    pbPaper1_1.Visible = false;
                    pbScissors1_1.Visible = false;

                    pbRock2_2.Visible = false;
                    pbPaper2_1.Visible = false;
                    pbScissors2_1.Visible = false;
                }
            }

            if (time == 7)
            {
                timer1.Stop();

                //checks the winner
                if (Player1 == Player2)
                {
                    MessageBox.Show("Draw");
                    win = 3;
                }
                else if ((Player1 == 1) && (Player2 == 2))
                {
                    MessageBox.Show("Player 2 won");
                    win = 2;
                }
                else if ((Player1 == 1) && (Player2 == 3))
                {
                    MessageBox.Show("Player 1 won");
                    win = 1;
                }
                else if ((Player1 == 2) && (Player2 == 1))
                {
                    MessageBox.Show("Player 1 won");
                    win = 1;
                }
                else if ((Player1 == 2) && (Player2 == 3))
                {
                    MessageBox.Show("Player 2 won");
                    win = 2;
                }
                else if ((Player1 == 3) && (Player2 == 1))
                {
                    MessageBox.Show("Player 2 won");
                    win = 2;
                }
                else if ((Player1 == 3) && (Player2 == 2))
                {
                    MessageBox.Show("Player 1 won");
                    win = 1;
                }

                //Showing the group box
                gbPlayer1.Show();
                gbPlayer2.Show();

                //Scoring
                if (win == 1)
                {
                    Player1Score = Player1Score + 1;
                    lblP1score.Text = Convert.ToString(Player1Score);
                }

                else if (win == 2)
                {
                    Player2Score = Player2Score + 1;
                    lblP2score.Text = Convert.ToString(Player2Score);
                }

                else if (win == 3)
                {
                    Player1Score = Player1Score + 0;
                    lblP1score.Text = Convert.ToString(Player1Score);

                    Player2Score = Player2Score + 0;
                    lblP2score.Text = Convert.ToString(Player2Score);
                }

                //Hiding the hands again
                time = 0;

                pbRock1_2.Visible = false;
                pbPaper1_1.Visible = false;
                pbScissors1_1.Visible = false;

                pbRock2_2.Visible = false;
                pbPaper2_1.Visible = false;
                pbScissors2_1.Visible = false;
            }
        }

        private void gbPlayer1_Enter(object sender, EventArgs e)
        {
            //Changing text
            btnLock1.Text = "Lock-in";
            btnLock1.Enabled = true;
        }

        private void gbPlayer2_Enter(object sender, EventArgs e)
        {
            //Changing text
            btnLock2.Text = "Lock-in";
            btnLock2.Enabled = true;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
