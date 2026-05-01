using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp5
{
    public partial class Main_menu : Form
    {
        private SoundPlayer bgMusic;
        private SoundPlayer click;

        public Main_menu()
        {
            InitializeComponent();
            click = new SoundPlayer("mixkit-game-click-1114.wav");
            bgMusic = new SoundPlayer("Twin Musicom - NES Overworld.wav");
        }

        private void Main_menu_Load(object sender, EventArgs e)
        {
            bgMusic.PlayLooping();
            pbDTT.Visible = false;
            pbRPS.Visible = false;
            pbTTT.Visible = false;
        }

        private void btnTicTac_Click(object sender, EventArgs e)
        {
            click.Play();

            var TTT = new TicTacToe();
            TTT.Show();

            this.Hide();
        }

        private void btnMainGame_Click(object sender, EventArgs e)
        {
            click.Play();
            var Introduction = new Introduction();
            Introduction.Show();
            this.Hide();
        }

        private void btnTicTac_MouseHover(object sender, EventArgs e)
        {
            pbTTT.Visible = true;

        }

        private void Main_menu_MouseHover(object sender, EventArgs e)
        {
            pbTTT.Visible = false;
            pbDTT.Visible = false;
            pbRPS.Visible = false;
        }

        private void btnMainGame_MouseHover(object sender, EventArgs e)
        {
            pbMainGame.Visible = true;
            
        }

        private void btnMiniGame3_MouseHover(object sender, EventArgs e)
        {
            pbDTT.Visible = true;

        }

        private void btnRPS_Click(object sender, EventArgs e)
        {
            click.Play();

            var RPS = new RPS();
            RPS.Show();

            this.Hide();
        }

        private void pbTTT_Click(object sender, EventArgs e)
        {

        }

        private void pbRPS_Click(object sender, EventArgs e)
        {

        }

        private void btnMiniGame3_Click(object sender, EventArgs e)
        {
            click.Play();

            var DTT = new DTT();

            DTT.Show();
            this.Hide();
        }

        private void btnMainGame_MouseLeave(object sender, EventArgs e)
        {
            pbMainGame.Visible = false;
        }

        private void btnRPS_MouseHover_1(object sender, EventArgs e)
        {
            pbRPS.Visible = true;
        }

        private void btnTicTac_MouseLeave(object sender, EventArgs e)
        {
            pbTTT.Visible = false;
        }

        private void btnRPS_MouseLeave(object sender, EventArgs e)
        {
            pbRPS.Visible = false;
        }

        private void btnMiniGame3_MouseLeave(object sender, EventArgs e)
        {
            pbDTT.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            click.Play();
            var Introduction = new Introduction();
            Introduction.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            click.Play();
            var Introduction = new Introduction();
            Introduction.Show();
            this.Hide();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            pbMainGame.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            pbMainGame.Visible = false;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            pbMainGame.Visible = false;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            pbMainGame.Visible = true;
        }
    }
}
