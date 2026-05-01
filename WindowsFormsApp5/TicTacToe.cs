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
    public partial class TicTacToe : Form
    {
        int p2score = 0;
        int p1score = 0;
        public TicTacToe()
        {
            InitializeComponent();

            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtResult.Visible = false;
        }

        private void btnTopLeft_Click(object sender, EventArgs e)
        {
            //Alternating X and O
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled == false)
                btnTopLeft.Text = "X";
            else if (timer1.Enabled == true)
                btnTopLeft.Text = "O";

            //Checking for winner
            if ((btnTopLeft.Text == "X" && btnTopMid.Text == "X" && btnTopRight.Text == "X") || (btnMidLeft.Text == "X" && btnMidMid.Text == "X" && btnMidRight.Text == "X") || (btnBottomLeft.Text == "X" && btnBottomMid.Text == "X" && btnBottomRight.Text == "X") || (btnTopLeft.Text == "X" && btnMidMid.Text == "X" && btnBottomRight.Text == "X") || (btnTopRight.Text == "X" && btnMidMid.Text == "X" && btnBottomLeft.Text == "X") || (btnTopLeft.Text == "X" && btnMidLeft.Text == "X" && btnBottomLeft.Text == "X") || (btnTopMid.Text == "X" && btnMidMid.Text == "X" && btnBottomMid.Text == "X") || (btnTopRight.Text == "X" && btnMidRight.Text == "X" && btnBottomRight.Text == "X"))
            {
                txtResult.Text = "Player 1 wins!";
                //Shows the result textbox
                txtResult.Visible = true;
            }
            else if ((btnTopLeft.Text == "O" && btnTopMid.Text == "O" && btnTopRight.Text == "O") || (btnMidLeft.Text == "O" && btnMidMid.Text == "O" && btnMidRight.Text == "O") || (btnBottomLeft.Text == "O" && btnBottomMid.Text == "O" && btnBottomRight.Text == "O") || (btnTopLeft.Text == "O" && btnMidMid.Text == "O" && btnBottomRight.Text == "O") || (btnTopRight.Text == "O" && btnMidMid.Text == "O" && btnBottomLeft.Text == "O") || (btnTopLeft.Text == "O" && btnMidLeft.Text == "O" && btnBottomLeft.Text == "O") || (btnTopMid.Text == "O" && btnMidMid.Text == "O" && btnBottomMid.Text == "O") || (btnTopRight.Text == "O" && btnMidRight.Text == "O" && btnBottomRight.Text == "O"))
            {
                txtResult.Text = "Player 2 wins!";
                //Shows the result textbox
                txtResult.Visible = true;
            }

            //Disabling button
            btnTopLeft.Enabled = false;
        }

        private void btnTopMid_Click(object sender, EventArgs e)
        {
            //Alternating X and O
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled == false)
                btnTopMid.Text = "X";
            else if (timer1.Enabled == true)
                btnTopMid.Text = "O";

            //Checking for winner
            if ((btnTopLeft.Text == "X" && btnTopMid.Text == "X" && btnTopRight.Text == "X") || (btnMidLeft.Text == "X" && btnMidMid.Text == "X" && btnMidRight.Text == "X") || (btnBottomLeft.Text == "X" && btnBottomMid.Text == "X" && btnBottomRight.Text == "X") || (btnTopLeft.Text == "X" && btnMidMid.Text == "X" && btnBottomRight.Text == "X") || (btnTopRight.Text == "X" && btnMidMid.Text == "X" && btnBottomLeft.Text == "X") || (btnTopLeft.Text == "X" && btnMidLeft.Text == "X" && btnBottomLeft.Text == "X") || (btnTopMid.Text == "X" && btnMidMid.Text == "X" && btnBottomMid.Text == "X") || (btnTopRight.Text == "X" && btnMidRight.Text == "X" && btnBottomRight.Text == "X"))
            {
                txtResult.Text = "Player 1 wins!";
                //Shows the result textbox
                txtResult.Visible = true;
            }
            else if ((btnTopLeft.Text == "O" && btnTopMid.Text == "O" && btnTopRight.Text == "O") || (btnMidLeft.Text == "O" && btnMidMid.Text == "O" && btnMidRight.Text == "O") || (btnBottomLeft.Text == "O" && btnBottomMid.Text == "O" && btnBottomRight.Text == "O") || (btnTopLeft.Text == "O" && btnMidMid.Text == "O" && btnBottomRight.Text == "O") || (btnTopRight.Text == "O" && btnMidMid.Text == "O" && btnBottomLeft.Text == "O") || (btnTopLeft.Text == "O" && btnMidLeft.Text == "O" && btnBottomLeft.Text == "O") || (btnTopMid.Text == "O" && btnMidMid.Text == "O" && btnBottomMid.Text == "O") || (btnTopRight.Text == "O" && btnMidRight.Text == "O" && btnBottomRight.Text == "O"))
            {
                txtResult.Text = "Player 2 wins!";
                //Shows the result textbox
                txtResult.Visible = true;
            }

            //Disabling button
            btnTopMid.Enabled = false;
        }

        private void btnTopRight_Click(object sender, EventArgs e)
        {
            //Alternating X and O
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled == false)
                btnTopRight.Text = "X";
            else if (timer1.Enabled == true)
                btnTopRight.Text = "O";

            //Checking for winner
            if ((btnTopLeft.Text == "X" && btnTopMid.Text == "X" && btnTopRight.Text == "X") || (btnMidLeft.Text == "X" && btnMidMid.Text == "X" && btnMidRight.Text == "X") || (btnBottomLeft.Text == "X" && btnBottomMid.Text == "X" && btnBottomRight.Text == "X") || (btnTopLeft.Text == "X" && btnMidMid.Text == "X" && btnBottomRight.Text == "X") || (btnTopRight.Text == "X" && btnMidMid.Text == "X" && btnBottomLeft.Text == "X") || (btnTopLeft.Text == "X" && btnMidLeft.Text == "X" && btnBottomLeft.Text == "X") || (btnTopMid.Text == "X" && btnMidMid.Text == "X" && btnBottomMid.Text == "X") || (btnTopRight.Text == "X" && btnMidRight.Text == "X" && btnBottomRight.Text == "X"))
            {
                txtResult.Text = "Player 1 wins!";
                //Shows the result textbox
                txtResult.Visible = true;
            }
            else if ((btnTopLeft.Text == "O" && btnTopMid.Text == "O" && btnTopRight.Text == "O") || (btnMidLeft.Text == "O" && btnMidMid.Text == "O" && btnMidRight.Text == "O") || (btnBottomLeft.Text == "O" && btnBottomMid.Text == "O" && btnBottomRight.Text == "O") || (btnTopLeft.Text == "O" && btnMidMid.Text == "O" && btnBottomRight.Text == "O") || (btnTopRight.Text == "O" && btnMidMid.Text == "O" && btnBottomLeft.Text == "O") || (btnTopLeft.Text == "O" && btnMidLeft.Text == "O" && btnBottomLeft.Text == "O") || (btnTopMid.Text == "O" && btnMidMid.Text == "O" && btnBottomMid.Text == "O") || (btnTopRight.Text == "O" && btnMidRight.Text == "O" && btnBottomRight.Text == "O"))
            {
                txtResult.Text = "Player 2 wins!";
                //Shows the result textbox
                txtResult.Visible = true;
            }

            //Disabling button
            btnTopRight.Enabled = false;
        }

        private void btnMidLeft_Click(object sender, EventArgs e)
        {
            //Alternating X and O
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled == false)
                btnMidLeft.Text = "X";
            else if (timer1.Enabled == true)
                btnMidLeft.Text = "O";

            //Checking for winner
            if ((btnTopLeft.Text == "X" && btnTopMid.Text == "X" && btnTopRight.Text == "X") || (btnMidLeft.Text == "X" && btnMidMid.Text == "X" && btnMidRight.Text == "X") || (btnBottomLeft.Text == "X" && btnBottomMid.Text == "X" && btnBottomRight.Text == "X") || (btnTopLeft.Text == "X" && btnMidMid.Text == "X" && btnBottomRight.Text == "X") || (btnTopRight.Text == "X" && btnMidMid.Text == "X" && btnBottomLeft.Text == "X") || (btnTopLeft.Text == "X" && btnMidLeft.Text == "X" && btnBottomLeft.Text == "X") || (btnTopMid.Text == "X" && btnMidMid.Text == "X" && btnBottomMid.Text == "X") || (btnTopRight.Text == "X" && btnMidRight.Text == "X" && btnBottomRight.Text == "X"))
            {
                txtResult.Text = "Player 1 wins!";
                //Shows the result textbox
                txtResult.Visible = true;
            }
            else if ((btnTopLeft.Text == "O" && btnTopMid.Text == "O" && btnTopRight.Text == "O") || (btnMidLeft.Text == "O" && btnMidMid.Text == "O" && btnMidRight.Text == "O") || (btnBottomLeft.Text == "O" && btnBottomMid.Text == "O" && btnBottomRight.Text == "O") || (btnTopLeft.Text == "O" && btnMidMid.Text == "O" && btnBottomRight.Text == "O") || (btnTopRight.Text == "O" && btnMidMid.Text == "O" && btnBottomLeft.Text == "O") || (btnTopLeft.Text == "O" && btnMidLeft.Text == "O" && btnBottomLeft.Text == "O") || (btnTopMid.Text == "O" && btnMidMid.Text == "O" && btnBottomMid.Text == "O") || (btnTopRight.Text == "O" && btnMidRight.Text == "O" && btnBottomRight.Text == "O"))
            {
                txtResult.Text = "Player 2 wins!";
                //Shows the result textbox
                txtResult.Visible = true;
            }

            //Disabling button
            btnMidLeft.Enabled = false;
        }

        private void btnMidMid_Click(object sender, EventArgs e)
        {
            //Alternating X and O
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled == false)
                btnMidMid.Text = "X";
            else if (timer1.Enabled == true)
                btnMidMid.Text = "O";

            //Checking for winner
            if ((btnTopLeft.Text == "X" && btnTopMid.Text == "X" && btnTopRight.Text == "X") || (btnMidLeft.Text == "X" && btnMidMid.Text == "X" && btnMidRight.Text == "X") || (btnBottomLeft.Text == "X" && btnBottomMid.Text == "X" && btnBottomRight.Text == "X") || (btnTopLeft.Text == "X" && btnMidMid.Text == "X" && btnBottomRight.Text == "X") || (btnTopRight.Text == "X" && btnMidMid.Text == "X" && btnBottomLeft.Text == "X") || (btnTopLeft.Text == "X" && btnMidLeft.Text == "X" && btnBottomLeft.Text == "X") || (btnTopMid.Text == "X" && btnMidMid.Text == "X" && btnBottomMid.Text == "X") || (btnTopRight.Text == "X" && btnMidRight.Text == "X" && btnBottomRight.Text == "X"))
            {
                txtResult.Text = "Player 1 wins!";
                //Shows the result textbox
                txtResult.Visible = true;
            }
            else if ((btnTopLeft.Text == "O" && btnTopMid.Text == "O" && btnTopRight.Text == "O") || (btnMidLeft.Text == "O" && btnMidMid.Text == "O" && btnMidRight.Text == "O") || (btnBottomLeft.Text == "O" && btnBottomMid.Text == "O" && btnBottomRight.Text == "O") || (btnTopLeft.Text == "O" && btnMidMid.Text == "O" && btnBottomRight.Text == "O") || (btnTopRight.Text == "O" && btnMidMid.Text == "O" && btnBottomLeft.Text == "O") || (btnTopLeft.Text == "O" && btnMidLeft.Text == "O" && btnBottomLeft.Text == "O") || (btnTopMid.Text == "O" && btnMidMid.Text == "O" && btnBottomMid.Text == "O") || (btnTopRight.Text == "O" && btnMidRight.Text == "O" && btnBottomRight.Text == "O"))
            {
                txtResult.Text = "Player 2 wins!";
                //Shows the result textbox
                txtResult.Visible = true;
            }

            //Disabling button
            btnMidMid.Enabled = false;
        }

        private void btnMidRight_Click(object sender, EventArgs e)
        {
            //Alternating X and O
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled == false)
                btnMidRight.Text = "X";
            else if (timer1.Enabled == true)
                btnMidRight.Text = "O";

            //Checking for winner
            if ((btnTopLeft.Text == "X" && btnTopMid.Text == "X" && btnTopRight.Text == "X") || (btnMidLeft.Text == "X" && btnMidMid.Text == "X" && btnMidRight.Text == "X") || (btnBottomLeft.Text == "X" && btnBottomMid.Text == "X" && btnBottomRight.Text == "X") || (btnTopLeft.Text == "X" && btnMidMid.Text == "X" && btnBottomRight.Text == "X") || (btnTopRight.Text == "X" && btnMidMid.Text == "X" && btnBottomLeft.Text == "X") || (btnTopLeft.Text == "X" && btnMidLeft.Text == "X" && btnBottomLeft.Text == "X") || (btnTopMid.Text == "X" && btnMidMid.Text == "X" && btnBottomMid.Text == "X") || (btnTopRight.Text == "X" && btnMidRight.Text == "X" && btnBottomRight.Text == "X"))
            {
                txtResult.Text = "Player 1 wins!";
                //Shows the result textbox
                txtResult.Visible = true;
            }
            else if ((btnTopLeft.Text == "O" && btnTopMid.Text == "O" && btnTopRight.Text == "O") || (btnMidLeft.Text == "O" && btnMidMid.Text == "O" && btnMidRight.Text == "O") || (btnBottomLeft.Text == "O" && btnBottomMid.Text == "O" && btnBottomRight.Text == "O") || (btnTopLeft.Text == "O" && btnMidMid.Text == "O" && btnBottomRight.Text == "O") || (btnTopRight.Text == "O" && btnMidMid.Text == "O" && btnBottomLeft.Text == "O") || (btnTopLeft.Text == "O" && btnMidLeft.Text == "O" && btnBottomLeft.Text == "O") || (btnTopMid.Text == "O" && btnMidMid.Text == "O" && btnBottomMid.Text == "O") || (btnTopRight.Text == "O" && btnMidRight.Text == "O" && btnBottomRight.Text == "O"))
            {
                txtResult.Text = "Player 2 wins!";
                //Shows the result textbox
                txtResult.Visible = true;
            }

            //Disabling button
            btnMidRight.Enabled = false;
        }

        private void btnBottomLeft_Click(object sender, EventArgs e)
        {
            //Alternating X and O
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled == false)
                btnBottomLeft.Text = "X";
            else if (timer1.Enabled == true)
                btnBottomLeft.Text = "O";

            //Checking for winner
            if ((btnTopLeft.Text == "X" && btnTopMid.Text == "X" && btnTopRight.Text == "X") || (btnMidLeft.Text == "X" && btnMidMid.Text == "X" && btnMidRight.Text == "X") || (btnBottomLeft.Text == "X" && btnBottomMid.Text == "X" && btnBottomRight.Text == "X") || (btnTopLeft.Text == "X" && btnMidMid.Text == "X" && btnBottomRight.Text == "X") || (btnTopRight.Text == "X" && btnMidMid.Text == "X" && btnBottomLeft.Text == "X") || (btnTopLeft.Text == "X" && btnMidLeft.Text == "X" && btnBottomLeft.Text == "X") || (btnTopMid.Text == "X" && btnMidMid.Text == "X" && btnBottomMid.Text == "X") || (btnTopRight.Text == "X" && btnMidRight.Text == "X" && btnBottomRight.Text == "X"))
            {
                txtResult.Text = "Player 1 wins!";
                //Shows the result textbox
                txtResult.Visible = true;
            }
            else if ((btnTopLeft.Text == "O" && btnTopMid.Text == "O" && btnTopRight.Text == "O") || (btnMidLeft.Text == "O" && btnMidMid.Text == "O" && btnMidRight.Text == "O") || (btnBottomLeft.Text == "O" && btnBottomMid.Text == "O" && btnBottomRight.Text == "O") || (btnTopLeft.Text == "O" && btnMidMid.Text == "O" && btnBottomRight.Text == "O") || (btnTopRight.Text == "O" && btnMidMid.Text == "O" && btnBottomLeft.Text == "O") || (btnTopLeft.Text == "O" && btnMidLeft.Text == "O" && btnBottomLeft.Text == "O") || (btnTopMid.Text == "O" && btnMidMid.Text == "O" && btnBottomMid.Text == "O") || (btnTopRight.Text == "O" && btnMidRight.Text == "O" && btnBottomRight.Text == "O"))
            {
                txtResult.Text = "Player 2 wins!";
                //Shows the result textbox
                txtResult.Visible = true;
            }

            //Disabling button
            btnBottomLeft.Enabled = false;
        }

        private void btnBottomMid_Click(object sender, EventArgs e)
        {
            //Alternating X and O
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled == false)
                btnBottomMid.Text = "X";
            else if (timer1.Enabled == true)
                btnBottomMid.Text = "O";

            //Checking for winner
            if ((btnTopLeft.Text == "X" && btnTopMid.Text == "X" && btnTopRight.Text == "X") || (btnMidLeft.Text == "X" && btnMidMid.Text == "X" && btnMidRight.Text == "X") || (btnBottomLeft.Text == "X" && btnBottomMid.Text == "X" && btnBottomRight.Text == "X") || (btnTopLeft.Text == "X" && btnMidMid.Text == "X" && btnBottomRight.Text == "X") || (btnTopRight.Text == "X" && btnMidMid.Text == "X" && btnBottomLeft.Text == "X") || (btnTopLeft.Text == "X" && btnMidLeft.Text == "X" && btnBottomLeft.Text == "X") || (btnTopMid.Text == "X" && btnMidMid.Text == "X" && btnBottomMid.Text == "X") || (btnTopRight.Text == "X" && btnMidRight.Text == "X" && btnBottomRight.Text == "X"))
            {
                txtResult.Text = "Player 1 wins!";
                //Shows the result textbox
                txtResult.Visible = true;
            }
            else if ((btnTopLeft.Text == "O" && btnTopMid.Text == "O" && btnTopRight.Text == "O") || (btnMidLeft.Text == "O" && btnMidMid.Text == "O" && btnMidRight.Text == "O") || (btnBottomLeft.Text == "O" && btnBottomMid.Text == "O" && btnBottomRight.Text == "O") || (btnTopLeft.Text == "O" && btnMidMid.Text == "O" && btnBottomRight.Text == "O") || (btnTopRight.Text == "O" && btnMidMid.Text == "O" && btnBottomLeft.Text == "O") || (btnTopLeft.Text == "O" && btnMidLeft.Text == "O" && btnBottomLeft.Text == "O") || (btnTopMid.Text == "O" && btnMidMid.Text == "O" && btnBottomMid.Text == "O") || (btnTopRight.Text == "O" && btnMidRight.Text == "O" && btnBottomRight.Text == "O"))
            {
                txtResult.Text = "Player 2 wins!";
                //Shows the result textbox
                txtResult.Visible = true;
            }

            //Disabling button
            btnBottomMid.Enabled = false;
        }

        private void btnBottomRight_Click(object sender, EventArgs e)
        {
            //Alternating X and O
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled == false)
                btnBottomRight.Text = "X";
            else if (timer1.Enabled == true)
                btnBottomRight.Text = "O";

            //Checking for winner
            if ((btnTopLeft.Text == "X" && btnTopMid.Text == "X" && btnTopRight.Text == "X") || (btnMidLeft.Text == "X" && btnMidMid.Text == "X" && btnMidRight.Text == "X") || (btnBottomLeft.Text == "X" && btnBottomMid.Text == "X" && btnBottomRight.Text == "X") || (btnTopLeft.Text == "X" && btnMidMid.Text == "X" && btnBottomRight.Text == "X") || (btnTopRight.Text == "X" && btnMidMid.Text == "X" && btnBottomLeft.Text == "X") || (btnTopLeft.Text == "X" && btnMidLeft.Text == "X" && btnBottomLeft.Text == "X") || (btnTopMid.Text == "X" && btnMidMid.Text == "X" && btnBottomMid.Text == "X") || (btnTopRight.Text == "X" && btnMidRight.Text == "X" && btnBottomRight.Text == "X"))
            {
                txtResult.Text = "Player 1 wins!";
                //Shows the result textbox
                txtResult.Visible = true;
            }
            else if ((btnTopLeft.Text == "O" && btnTopMid.Text == "O" && btnTopRight.Text == "O") || (btnMidLeft.Text == "O" && btnMidMid.Text == "O" && btnMidRight.Text == "O") || (btnBottomLeft.Text == "O" && btnBottomMid.Text == "O" && btnBottomRight.Text == "O") || (btnTopLeft.Text == "O" && btnMidMid.Text == "O" && btnBottomRight.Text == "O") || (btnTopRight.Text == "O" && btnMidMid.Text == "O" && btnBottomLeft.Text == "O") || (btnTopLeft.Text == "O" && btnMidLeft.Text == "O" && btnBottomLeft.Text == "O") || (btnTopMid.Text == "O" && btnMidMid.Text == "O" && btnBottomMid.Text == "O") || (btnTopRight.Text == "O" && btnMidRight.Text == "O" && btnBottomRight.Text == "O"))
            {
                txtResult.Text = "Player 2 wins!";
                //Shows the result textbox
                txtResult.Visible = true;
            }

            //Disabling button
            btnBottomRight.Enabled = false;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            //Hides the result textbox
            txtResult.Visible = false;

            //Setting the symbol of player 1 to "X" and player 2 to "O"
            if (txtResult.Text == "Player 1 wins!")
            {
                timer1.Enabled = !timer1.Enabled;
            }
               
            else if (txtResult.Text == "Player 2 wins!")
            {
                timer1.Enabled = true;
            }

            //Clearing the boxes
            btnTopLeft.Text = "";
            btnTopMid.Text = "";
            btnTopRight.Text = "";
            btnMidLeft.Text = "";
            btnMidMid.Text = "";
            btnMidRight.Text = "";
            btnBottomLeft.Text = "";
            btnBottomMid.Text = "";
            btnBottomRight.Text = "";

            //Clearing the result
            txtResult.Text = "";

            //Enabling the boxes again
            btnTopLeft.Enabled = true;
            btnTopMid.Enabled = true;
            btnTopRight.Enabled = true;
            btnMidLeft.Enabled = true;
            btnMidMid.Enabled = true;
            btnMidRight.Enabled = true;
            btnBottomLeft.Enabled = true;
            btnBottomMid.Enabled = true;
            btnBottomRight.Enabled = true;

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            //Disabling the playing board
            if (txtResult.Text != "")
            {
                btnTopLeft.Enabled = false;
                btnTopMid.Enabled = false;
                btnTopRight.Enabled = false;
                btnMidLeft.Enabled = false;
                btnMidMid.Enabled = false;
                btnMidRight.Enabled = false;
                btnBottomLeft.Enabled = false;
                btnBottomMid.Enabled = false;
                btnBottomRight.Enabled = false;
            }

            //Score counter
            if (txtResult.Text == "Player 1 wins!")
            {
                p1score = p1score + 1;
                lblp1score1.Text = Convert.ToString(p1score);
            }

            else if (txtResult.Text == "Player 2 wins!")
            {
                p2score = p2score + 1;
                lblp2score1.Text = Convert.ToString(p2score);
            }

        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            //Hides the result textbox
            txtResult.Visible = false;

            //Resets the score of the game
            lblp1score1.Text = "0";
            lblp2score1.Text = "0";
            p1score = 0;
            p2score = 0;

            //Setting the symbol of player 1 to "X" and player 2 to "O"
            if (txtResult.Text == "Player 1 wins!")
            {
                timer1.Enabled = !timer1.Enabled;
            }

            else if (txtResult.Text == "Player 2 wins!")
            {
                timer1.Enabled = true;
            }

            //Clearing the boxes
            btnTopLeft.Text = "";
            btnTopMid.Text = "";
            btnTopRight.Text = "";
            btnMidLeft.Text = "";
            btnMidMid.Text = "";
            btnMidRight.Text = "";
            btnBottomLeft.Text = "";
            btnBottomMid.Text = "";
            btnBottomRight.Text = "";

            //Clearing the result
            txtResult.Text = "";

            //Enabling the boxes again
            btnTopLeft.Enabled = true;
            btnTopMid.Enabled = true;
            btnTopRight.Enabled = true;
            btnMidLeft.Enabled = true;
            btnMidMid.Enabled = true;
            btnMidRight.Enabled = true;
            btnBottomLeft.Enabled = true;
            btnBottomMid.Enabled = true;
            btnBottomRight.Enabled = true;
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            var MainMenu = new Main_menu();

            MainMenu.Show();
            this.Close();
        }
    }
}