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
    public partial class DTT : Form
    {
        public int val = 10;
        public int valleft = 10;
        public int score = 0;
        public int miss = 0;
        Random rnd = new Random();

        double Tick = 0;

        public DTT()
        {
            InitializeComponent();
        }

        private void DTT_Load(object sender, EventArgs e)
        {
            x.Top = rnd.Next(100, 450);
            x.Left = rnd.Next(100, 450);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Hello world!";
            // x.Top = x.Top + val;

            // if (x.Top >= 150)
            // {
            //     val = -10;
            // }
            // else if (x.Top <= 50)
            // {
            //     val = 10;
            // } 
            timer1.Enabled = !timer1.Enabled;
            button1.Text = "Playing";
            textBox1.Text = "";
            textBox2.Text = "";
            miss = 0;
            score = 0;
            x.Text = "   ";
            x.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            x.Visible = true;
            lblResult1.Enabled = false;
            lblResult1.Visible = false;
            pbLost.Enabled = false;
            pbLost.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x.Top = rnd.Next(100, 600);
            x.Left = rnd.Next(100, 1000);

            if (textBox2.Text != "10")
            {
                miss++; textBox2.Text = miss.ToString();
            }


            if (miss >= 10)
            {
                textBox1.Text = "Game over!";
                button1.Text = "Try again?";
                timer1.Enabled = !timer1.Enabled;
                lblResult1.Text = "You Lost :'(";
                lblResult1.Enabled = true;
                lblResult1.Visible = true;
                pbLost.Enabled = true;
                pbLost.Visible = true;
                x.Enabled = false;
                x.Visible = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
        }

        private void x_Click(object sender, EventArgs e)
        {
            score++;
            x.Top = rnd.Next(100, 600); x.Left = rnd.Next(100, 1000);
            textBox1.Text = score.ToString();
            timer1.Stop();
            timer1.Start();

            if (score == 10)
            {
                textBox1.Text = "You won!";
                button1.Text = "Try again?";
                timer1.Enabled = !timer1.Enabled;
                x.Visible = false;
                lblResult1.Text = "Victory!";
                lblResult1.Enabled = true;
                lblResult1.Visible = true;
                x.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
        }


        private void DTT_Click(object sender, EventArgs e)
        {
            if ((miss < 10) && (textBox1.Text != "You won!") && (textBox1.Text != "Game over!"))

            {
                x.Top = rnd.Next(100, 600);
                x.Left = rnd.Next(100, 1000);
                miss++; textBox2.Text = miss.ToString(); textBox1.Text = score.ToString();
                timer1.Stop(); timer1.Start();
            }


            else if (miss == 10)
            {
                textBox1.Text = "Game over!";
                button1.Text = "Try again?";
                timer1.Stop();
                x.Visible = false;
                lblResult1.Text = "You Lost :'(";
                lblResult1.Enabled = true;
                lblResult1.Visible = true;
                pbLost.Enabled = true;
                pbLost.Visible = true;
                x.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                DTT Form_1 = new DTT();
                Form_1.Enabled = !true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var MainMenu = new Main_menu();
            MainMenu.Show();
            this.Close();
        }

        private void btnTick_Click(object sender, EventArgs e)
        {
            Tick = Convert.ToDouble(txtTick.Text);
            Tick = Tick * 1000;
            int tick = Convert.ToInt32(Tick);

            timer1.Interval = tick;

            txtTick.Text = tick + " milliseconds";
        }

        private void txtTick_Click(object sender, EventArgs e)
        {
            txtTick.Text = "";
        }
    }
}
