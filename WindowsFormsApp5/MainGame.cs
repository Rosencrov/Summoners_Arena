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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp5
{
    public partial class MainGame : Form
    {
        //Calling characters
        Name Bard = new Name();
        Name Berserker = new Name();
        Name Sorcerer = new Name();
        Name Ranger = new Name();
        Name Assassin = new Name();
        Name Vanguard = new Name();
        Skills Skill = new Skills();


        private SoundPlayer bgMusic;
        private SoundPlayer healSound;


        int p1Heart, p2Heart, charge1 = 0, charge2 = 0, charges1 = 0, charges2 = 0, charge3 = 0, charge4 = 0, charges3 = 0, charges4 = 0;
        int frame1 = 0, frame2 = 0;
        //int music = 0;
        public MainGame()
        {
            InitializeComponent();
            bgMusic = new SoundPlayer("TwinMusicomNESBoss.wav");
            healSound = new SoundPlayer("mixkit-collect-material-3209.wav");
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            //Setting the HP of characters
            Bard.Hearts1 = 50;
            Berserker.Hearts1 = 50;
            Sorcerer.Hearts1 = 50;
            Ranger.Hearts1 = 50;
            Assassin.Hearts1 = 40;
            Vanguard.Hearts1 = 80;

            //Starting the ghost animation
            timer3.Start();
            timer4.Start();

            //Background music
            bgMusic.PlayLooping();
            //timer7.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bgMusic.Stop();
            var MainMenu = new Main_menu();
            MainMenu.Show();
            this.Close();
        }
        private void btnIntroduction_Click(object sender, EventArgs e)
        {
            var Introduction = new Introduction();
            Introduction.Show();
        }

        //Player 1
        private void rbtnBard1_CheckedChanged(object sender, EventArgs e)
        {
            lblP1Character.Text = "Bard";

            //Showing the Avatar
            pbGhost1.Visible = false;
            pbGhost1_1.Visible = false;
            pbBard1.Visible = true;
            pbBard1_1.Visible = false;
            timer3.Stop();
            timer1.Start();

            //Setting player 1 HP
            p1HPbar.Maximum = 50;
            p1HPbar.Minimum = 0;
            p1HPbar.Value = 50;
            p1Heart = 50;
            lblP1Heart.Text = lblP1Heart.Text + p1Heart.ToString();
            gbP1.Visible = false;

            //Deactivating other skills
            btnRagnarok1.Visible = false;
            btnSliceAndDice1.Visible = false;
            btnEnchant1.Visible = false;
            btnConjure1.Visible = false;
            btnHawkshot1.Visible = false;
            btnStrafe1.Visible = false;
            btnUmbralStrike1.Visible = false;
            btnQuickSlash1.Visible = false;
            btnBash1.Visible = false;
            btnBrauming1.Visible = false;
        }

        private void rbtnBerserker1_CheckedChanged(object sender, EventArgs e)
        {
            lblP1Character.Text = "Berserker";

            //Showing the Avatar
            pbGhost1.Visible = false;
            pbBerserker1.Visible = true;
            timer1.Start();
            pbGhost1_1.Visible = false;
            timer3.Stop();

            //Setting player 1 HP
            p1HPbar.Maximum = 50;
            p1HPbar.Minimum = 0;
            p1HPbar.Value = 50;
            p1Heart = 50;
            lblP1Heart.Text = lblP1Heart.Text + p1Heart.ToString();
            gbP1.Visible = false;

            //Deactivating other skills
            btnRhapsody1.Visible = false;
            btnRondo1.Visible = false;
            btnEnchant1.Visible = false;
            btnConjure1.Visible = false;
            btnHawkshot1.Visible = false;
            btnStrafe1.Visible = false;
            btnUmbralStrike1.Visible = false;
            btnQuickSlash1.Visible = false;
            btnBash1.Visible = false;
            btnBrauming1.Visible = false;
        }

        private void rbtnSorcerer1_CheckedChanged(object sender, EventArgs e)
        {
            lblP1Character.Text = "Sorcerer";

            //Showing the Avatar
            pbGhost1.Visible = false;
            pbSorcerer1.Visible = true;
            timer1.Start();
            pbGhost1_1.Visible = false;
            timer3.Stop();

            //Setting player 1 HP
            p1HPbar.Maximum = 50;
            p1HPbar.Minimum = 0;
            p1HPbar.Value = 50;
            p1Heart = 50;
            lblP1Heart.Text = lblP1Heart.Text + p1Heart.ToString();
            gbP1.Visible = false;

            //Deactivating other skills
            btnRhapsody1.Visible = false;
            btnRondo1.Visible = false;
            btnRagnarok1.Visible = false;
            btnSliceAndDice1.Visible = false;
            btnHawkshot1.Visible = false;
            btnStrafe1.Visible = false;
            btnUmbralStrike1.Visible = false;
            btnQuickSlash1.Visible = false;
            btnBash1.Visible = false;
            btnBrauming1.Visible = false;
        }

        private void rbtnRanger1_CheckedChanged(object sender, EventArgs e)
        {
            lblP1Character.Text = "Ranger";

            //Showing the Avatar
            pbGhost1.Visible = false;
            pbRanger1.Visible = true;
            timer1.Start();
            pbGhost1_1.Visible = false;
            timer3.Stop();

            //Setting player 1 HP
            p1HPbar.Maximum = 50;
            p1HPbar.Minimum = 0;
            p1HPbar.Value = 50;
            p1Heart = 50;
            lblP1Heart.Text = lblP1Heart.Text + p1Heart.ToString();
            gbP1.Visible = false;

            //Deactivating other skills
            btnRhapsody1.Visible = false;
            btnRondo1.Visible = false;
            btnRagnarok1.Visible = false;
            btnSliceAndDice1.Visible = false;
            btnEnchant1.Visible = false;
            btnConjure1.Visible = false;
            btnUmbralStrike1.Visible = false;
            btnQuickSlash1.Visible = false;
            btnBash1.Visible = false;
            btnBrauming1.Visible = false;
        }

        private void rbtnAssassin1_CheckedChanged(object sender, EventArgs e)
        {
            lblP1Character.Text = "Assassin";

            //Showing the Avatar
            pbGhost1.Visible = false;
            pbAssassin1.Visible = true;
            timer1.Start();
            pbGhost1_1.Visible = false;
            timer3.Stop();

            //Setting player 1 HP
            p1HPbar.Maximum = 40;
            p1HPbar.Minimum = 0;
            p1HPbar.Value = 40;
            p1Heart = 40;
            lblP1Heart.Text = lblP1Heart.Text + p1Heart.ToString();
            gbP1.Visible = false;

            //Deactivating other skills
            btnRhapsody1.Visible = false;
            btnRondo1.Visible = false;
            btnRagnarok1.Visible = false;
            btnSliceAndDice1.Visible = false;
            btnEnchant1.Visible = false;
            btnConjure1.Visible = false;
            btnHawkshot1.Visible = false;
            btnStrafe1.Visible = false;
            btnBash1.Visible = false;
            btnBrauming1.Visible = false;
        }

        private void rbtnVanguard1_CheckedChanged(object sender, EventArgs e)
        {
            lblP1Character.Text = "Vanguard";

            //Showing the Avatar
            pbGhost1.Visible = false;
            pbVanguard1.Visible = true;
            timer1.Start();
            pbGhost1_1.Visible = false;
            timer3.Stop();

            //Setting player 1 HP
            p1HPbar.Maximum = 80;
            p1HPbar.Minimum = 0;
            p1HPbar.Value = 80;
            p1Heart = 80;
            lblP1Heart.Text = lblP1Heart.Text + p1Heart.ToString();
            gbP1.Visible = false;

            //Deactivating other skills
            btnRhapsody1.Visible = false;
            btnRondo1.Visible = false;
            btnRagnarok1.Visible = false;
            btnSliceAndDice1.Visible = false;
            btnEnchant1.Visible = false;
            btnConjure1.Visible = false;
            btnHawkshot1.Visible = false;
            btnStrafe1.Visible = false;
            btnUmbralStrike1.Visible = false;
            btnQuickSlash1.Visible = false;
        }



        //Player 2
        private void rbtnBard2_CheckedChanged(object sender, EventArgs e)
        {
            lblP2Character.Text = "Bard";

            //Showing the Avatar
            pbGhost2.Visible = false;
            pbBard2.Visible = true;
            pbBard2_1.Visible = false;
            timer2.Start();
            pbGhost2_1.Visible = false;
            timer4.Stop();

            //Setting player 2 HP
            p2HPbar.Maximum = 50;
            p2HPbar.Minimum = 0;
            p2HPbar.Value = 50;
            p2Heart = 50;
            lblP2Heart.Text = lblP2Heart.Text + p2Heart.ToString();
            gbP2.Visible = false;

            //Deactivating other skills
            btnRagnarok2.Visible = false;
            btnSliceAndDice2.Visible = false;
            btnEnchant2.Visible = false;
            btnConjure2.Visible = false;
            btnHawkshot2.Visible = false;
            btnStrafe2.Visible = false;
            btnUmbralStrike2.Visible = false;
            btnQuickSlash2.Visible = false;
            btnBash2.Visible = false;
            btnBrauming2.Visible = false;
        }
        private void rbtnBerserker2_CheckedChanged(object sender, EventArgs e)
        {
            lblP2Character.Text = "Berserker";

            //Showing the Avatar
            pbGhost2.Visible = false;
            pbBerserker2.Visible = true;
            timer2.Start();
            pbGhost2_1.Visible = false;
            timer4.Stop();

            //Setting player 2 HP
            p2HPbar.Maximum = 50;
            p2HPbar.Minimum = 0;
            p2HPbar.Value = 50;
            p2Heart = 50;
            lblP2Heart.Text = lblP2Heart.Text + p2Heart.ToString();
            gbP2.Visible = false;

            //Deactivating other skills
            btnRhapsody2.Visible = false;
            btnRondo2.Visible = false;
            btnEnchant2.Visible = false;
            btnConjure2.Visible = false;
            btnHawkshot2.Visible = false;
            btnStrafe2.Visible = false;
            btnUmbralStrike2.Visible = false;
            btnQuickSlash2.Visible = false;
            btnBash2.Visible = false;
            btnBrauming2.Visible = false;
        }

        private void rbtnSorcerer2_CheckedChanged(object sender, EventArgs e)
        {
            lblP2Character.Text = "Sorcerer";

            //Showing the Avatar
            pbGhost2.Visible = false;
            pbSorcerer2.Visible = true;
            timer2.Start();
            pbGhost2_1.Visible = false;
            timer4.Stop();

            //Setting player 2 HP
            p2HPbar.Maximum = 50;
            p2HPbar.Minimum = 0;
            p2HPbar.Value = 50;
            p2Heart = 50;
            lblP2Heart.Text = lblP2Heart.Text + p2Heart.ToString();
            gbP2.Visible = false;

            //Deactivating other skills
            btnRhapsody2.Visible = false;
            btnRondo2.Visible = false;
            btnRagnarok2.Visible = false;
            btnSliceAndDice2.Visible = false;
            btnHawkshot2.Visible = false;
            btnStrafe2.Visible = false;
            btnUmbralStrike2.Visible = false;
            btnQuickSlash2.Visible = false;
            btnBash2.Visible = false;
            btnBrauming2.Visible = false;
        }

        private void rbtnRanger2_CheckedChanged(object sender, EventArgs e)
        {
            lblP2Character.Text = "Ranger";

            //Showing the Avatar
            pbGhost2.Visible = false;
            pbRanger2.Visible = true;
            timer2.Start();
            pbGhost2_1.Visible = false;
            timer4.Stop();

            //Setting player 2 HP
            p2HPbar.Maximum = 50;
            p2HPbar.Minimum = 0;
            p2HPbar.Value = 50;
            p2Heart = 50;
            lblP2Heart.Text = lblP2Heart.Text + p2Heart.ToString();
            gbP2.Visible = false;

            //Deactivating other skills
            btnRhapsody2.Visible = false;
            btnRondo2.Visible = false;
            btnRagnarok2.Visible = false;
            btnSliceAndDice2.Visible = false;
            btnEnchant2.Visible = false;
            btnConjure2.Visible = false;
            btnUmbralStrike2.Visible = false;
            btnQuickSlash2.Visible = false;
            btnBash2.Visible = false;
            btnBrauming2.Visible = false;
        }

        private void rbtnAssassin2_CheckedChanged(object sender, EventArgs e)
        {
            lblP2Character.Text = "Assassin";

            //Showing the Avatar
            pbGhost2.Visible = false;
            pbAssassin2.Visible = true;
            timer2.Start();
            pbGhost2_1.Visible = false;
            timer4.Stop();

            //Setting player 2 HP
            p2HPbar.Maximum = 40;
            p2HPbar.Minimum = 0;
            p2HPbar.Value = 40;
            p2Heart = 40;
            lblP2Heart.Text = lblP2Heart.Text + p2Heart.ToString();
            gbP2.Visible = false;

            //Deactivating other skills
            btnRhapsody2.Visible = false;
            btnRondo2.Visible = false;
            btnRagnarok2.Visible = false;
            btnSliceAndDice2.Visible = false;
            btnEnchant2.Visible = false;
            btnConjure2.Visible = false;
            btnHawkshot2.Visible = false;
            btnStrafe2.Visible = false;
            btnBash2.Visible = false;
            btnBrauming2.Visible = false;
        }

        private void rbtnVanguard2_CheckedChanged(object sender, EventArgs e)
        {
            lblP2Character.Text = "Vanguard";

            //Showing the Avatar
            pbGhost2.Visible = false;
            pbVanguard2.Visible = true;
            timer2.Start();
            pbGhost2_1.Visible = false;
            timer4.Stop();

            //Setting player 2 HP
            p2HPbar.Maximum = 80;
            p2HPbar.Minimum = 0;
            p2HPbar.Value = 80;
            p2Heart = 80;
            lblP2Heart.Text = lblP2Heart.Text + p2Heart.ToString();
            gbP2.Visible = false;

            //Deactivating other skills
            btnRhapsody2.Visible = false;
            btnRondo2.Visible = false;
            btnRagnarok2.Visible = false;
            btnSliceAndDice2.Visible = false;
            btnEnchant2.Visible = false;
            btnConjure2.Visible = false;
            btnHawkshot2.Visible = false;
            btnStrafe2.Visible = false;
            btnUmbralStrike2.Visible = false;
            btnQuickSlash2.Visible = false;
        }



        //Player 1 skills

        private void btnHeal1_Click(object sender, EventArgs e)
        {
            if(p1Heart <= 45 || p1Heart > 50 && p1Heart <= 75)
            {
                charge1++;

                healSound.Play();

                if (charge1 <= 2)
                {
                    p1Heart = p1Heart - (Skill.Heal());
                    p1HPbar.Value = p1Heart;
                    lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();

                    MessageBox.Show("Restored " + (Skill.Heal() * -1) + " HP");
                }

                if (charge1 == 2)
                {
                    btnHeal1.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Cannot heal right now, HP is too high");
            }
            

            timer7.Stop();
            timer7.Start();
            bgMusic.PlayLooping();
        }

        private void btnStomp1_Click(object sender, EventArgs e)
        {
            //Deactivates Player 1's skills
            gbP1skills.Enabled = false;
            gbP2skills.Enabled = true;

            p2Heart = p2Heart - (Skill.Stomp());

            if (Skill.Stomp() == 0)
            {
                MessageBox.Show("Stomp missed");
            }

            if (p2Heart > 0)
            {
                p2HPbar.Value = p2Heart;
                lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
            }

            else
            {
                p2HPbar.Value = 0;
                lblP2Heart.Text = "Player 2 HP: 0";
                btnStomp1.Enabled = false;
                MessageBox.Show("Player 1 Won!");
            }
        }

        private void btnMeditate1_Click(object sender, EventArgs e)
        {
            //Deactivates Player 1's skills
            gbP1skills.Enabled = false;
            gbP2skills.Enabled = true;

            Skill.Meditate();

            if (Skill.Meditate() == 0)
            {
                MessageBox.Show("Player 1 will deflect the next attack");
            }

            else
            {
                MessageBox.Show("Player 1 has failed to meditate");
            }
        }

        private void btnQuickAttack1_Click(object sender, EventArgs e)
        {
            //Deactivates Player 1's skills
            gbP1skills.Enabled = false;
            gbP2skills.Enabled = true;

            p2Heart = p2Heart - (Skill.QuickAttack());

            if (Skill.QuickAttack() == 0)
            {
                MessageBox.Show("Quick Attack missed");
            }

            if (p2Heart > 0)
            {
                p2HPbar.Value = p2Heart;
                lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
            }

            else
            {
                p2HPbar.Value = 0;
                lblP2Heart.Text = "Player 2 HP: 0";
                btnQuickAttack1.Enabled = false;
                MessageBox.Show("Player 1 Won!");
            }
        }

        private void btnPanThrow1_Click(object sender, EventArgs e)
        {
            //Deactivates Player 1's skills
            gbP1skills.Enabled = false;
            gbP2skills.Enabled = true;

            p2Heart = p2Heart - (Skill.PanThrow());

            if (Skill.PanThrow() == 0)
            {
                MessageBox.Show("The frying pan flew past Player 2 and missed");
            }

            if (p2Heart > 0)
            {
                p2HPbar.Value = p2Heart;
                lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
            }

            else
            {
                p2HPbar.Value = 0;
                lblP2Heart.Text = "Player 2 HP: 0";
                btnPanThrow1.Enabled = false;
                MessageBox.Show("Player 1 Won!");
            }
        }

        private void btnRhapsody1_Click(object sender, EventArgs e)
        {
            //Deactivates Player 1's skills
            gbP1skills.Enabled = false;
            gbP2skills.Enabled = true;

            charge3++;

            if(charge3 <= 10)
            {
                p2Heart = p2Heart - (Skill.Rhapsody());

                if (Skill.Rhapsody() == 0)
                {
                    MessageBox.Show("Rhapsody was too harmonious to deal damage");
                }

                if (p2Heart > 0)
                {
                    p2HPbar.Value = p2Heart;
                    lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
                }

                else
                {
                    p2HPbar.Value = 0;
                    lblP2Heart.Text = "Player 2 HP: 0";
                    btnRhapsody1.Enabled = false;
                    MessageBox.Show("Player 1 Won!");
                }

                Skill.Rhapsody1();
                MessageBox.Show("Player 2 is under hallucination and their next attack will deal 0 damage");
            }

            if(charge3 == 10)
            {
                btnRhapsody1.Enabled = false;
            }

        }

        private void btnRondo1_Click(object sender, EventArgs e)
        {
            //Deactivates Player 1's skills
            gbP1skills.Enabled = false;
            gbP2skills.Enabled = true;

            int RondoDamage = Skill.Rondo();

            p2Heart = p2Heart - (RondoDamage);

            if (RondoDamage == 0)
            {
                MessageBox.Show("Rondo was out of tune");
            }

            if (p2Heart > 0)
            {
                p2HPbar.Value = p2Heart;
                lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
            }

            else
            {
                p2HPbar.Value = 0;
                lblP2Heart.Text = "Player 2 HP: 0";
                btnRondo1.Enabled = false;
                MessageBox.Show("Player 1 Won!");
            }
        }

        private void btnRagnarok1_Click(object sender, EventArgs e)
        {
            //Deactivates Player 1's skills
            gbP1skills.Enabled = false;
            gbP2skills.Enabled = true;

            Random rnd = new Random();
            int multicast = rnd.Next(1, 101);

            if(multicast % 2 == 0)
            {
                MessageBox.Show("Ragnarok multicasted");

                p2Heart = p2Heart - (Skill.Ragnarok());

                if (Skill.Ragnarok() == 0)
                {
                    MessageBox.Show("Attack missed");
                }

                if (p2Heart > 0)
                {
                    p2HPbar.Value = p2Heart;
                    lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
                }

                else
                {
                    p2HPbar.Value = 0;
                    lblP2Heart.Text = "Player 2 HP: 0";
                    btnRagnarok1.Enabled = false;
                    MessageBox.Show("Player 1 Won!");
                }

                //Reflect damage
                p1Heart = p1Heart - (Skill.Ragnarok1());

                if (Skill.Ragnarok() == 0)
                {
                    MessageBox.Show("Attack missed");
                }

                if (p1Heart > 0)
                {
                    p1HPbar.Value = p1Heart;
                    lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
                }

                else
                {
                    pbGhost1.Visible = true;
                    p1HPbar.Value = 0;
                    lblP1Heart.Text = "Player 1 HP: 0";
                    btnRagnarok1.Enabled = false;
                    MessageBox.Show("Player 2 Won!");
                }





                //Second cast
                MessageBox.Show("Second cast");

                p2Heart = p2Heart - (Skill.Ragnarok());

                if (Skill.Ragnarok() == 0)
                {
                    MessageBox.Show("Attack missed");
                }

                if (p2Heart > 0)
                {
                    p2HPbar.Value = p2Heart;
                    lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
                }

                else
                {
                    pbGhost2.Visible = true;
                    p2HPbar.Value = 0;
                    lblP2Heart.Text = "Player 2 HP: 0";
                    btnRagnarok1.Enabled = false;
                    MessageBox.Show("Player 1 Won!");
                }

                //Reflect damage
                p1Heart = p1Heart - (Skill.Ragnarok1());

                if (Skill.Ragnarok() == 0)
                {
                    MessageBox.Show("Attack missed");
                }

                if (p1Heart > 0)
                {
                    p1HPbar.Value = p1Heart;
                    lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
                }

                else
                {
                    pbGhost1.Visible = true;
                    p1HPbar.Value = 0;
                    lblP1Heart.Text = "Player 1 HP: 0";
                    btnRagnarok1.Enabled = false;
                    MessageBox.Show("Player 2 Won!");
                }
            }

            else
            {
                MessageBox.Show("Ragnarok didn't multicast");
                p2Heart = p2Heart - (Skill.Ragnarok());

                if (Skill.Ragnarok() == 0)
                {
                    MessageBox.Show("Attack missed");
                }

                if (p2Heart > 0)
                {
                    p2HPbar.Value = p2Heart;
                    lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
                }

                else
                {
                    pbGhost2.Visible = true;
                    p2HPbar.Value = 0;
                    lblP2Heart.Text = "Player 2 HP: 0";
                    btnRagnarok1.Enabled = false;
                    MessageBox.Show("Player 1 Won!");
                }

                //Reflect damage
                p1Heart = p1Heart - (Skill.Ragnarok1());

                if (Skill.Ragnarok() == 0)
                {
                    MessageBox.Show("Attack missed");
                }

                if (p1Heart > 0)
                {
                    p1HPbar.Value = p1Heart;
                    lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
                }

                else
                {
                    pbGhost1.Visible = true;
                    p1HPbar.Value = 0;
                    lblP1Heart.Text = "Player 1 HP: 0";
                    btnRagnarok1.Enabled = false;
                    MessageBox.Show("Player 2 Won!");
                }
            }
        }

        private void btnSliceAndDice1_Click(object sender, EventArgs e)
        {
            //Deactivates Player 1's skills
            gbP1skills.Enabled = false;
            gbP2skills.Enabled = true;

            Random rnd = new Random();
            int multicast = rnd.Next(1, 101);

            if (multicast % 2 == 0)
            {
                MessageBox.Show("Slice and Dice multicasted");

                //1st phase

                //1st cast
                MessageBox.Show("Casting slice");
                p2Heart = p2Heart - (Skill.SliceAndDice());

                if (Skill.SliceAndDice() == 0)
                {
                    MessageBox.Show("Slice missed");
                }

                if (p2Heart > 0)
                {
                    p2HPbar.Value = p2Heart;
                    lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
                }

                else
                {
                    p2HPbar.Value = 0;
                    lblP2Heart.Text = "Player 2 HP: 0";
                    btnSliceAndDice1.Enabled = false;
                    MessageBox.Show("Player 1 Won!");
                }

                //2nd cast
                MessageBox.Show("Casting dice");
                p2Heart = p2Heart - (Skill.SliceAndDice());

                if (Skill.SliceAndDice() == 0)
                {
                    MessageBox.Show("Dice missed");
                }

                if (p2Heart > 0)
                {
                    p2HPbar.Value = p2Heart;
                    lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
                }

                else
                {
                    p2HPbar.Value = 0;
                    lblP2Heart.Text = "Player 2 HP: 0";
                    btnSliceAndDice1.Enabled = false;
                    MessageBox.Show("Player 1 Won!");
                }

                //2nd phase

                //1st cast
                MessageBox.Show("Casting slice");
                p2Heart = p2Heart - (Skill.SliceAndDice());

                if (Skill.SliceAndDice() == 0)
                {
                    MessageBox.Show("Slice missed");
                }

                if (p2Heart > 0)
                {
                    p2HPbar.Value = p2Heart;
                    lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
                }

                else
                {
                    p2HPbar.Value = 0;
                    lblP2Heart.Text = "Player 2 HP: 0";
                    btnSliceAndDice1.Enabled = false;
                    MessageBox.Show("Player 1 Won!");
                }

                //2nd cast
                MessageBox.Show("Casting dice");
                p2Heart = p2Heart - (Skill.SliceAndDice());

                if (Skill.SliceAndDice() == 0)
                {
                    MessageBox.Show("Dice missed");
                }

                if (p2Heart > 0)
                {
                    p2HPbar.Value = p2Heart;
                    lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
                }

                else
                {
                    p2HPbar.Value = 0;
                    lblP2Heart.Text = "Player 2 HP: 0";
                    btnSliceAndDice1.Enabled = false;
                    MessageBox.Show("Player 1 Won!");
                }
            }

            else
            {
                MessageBox.Show("Slice and Dice didn't multicast");

                //1st cast
                MessageBox.Show("Casting slice");
                p2Heart = p2Heart - (Skill.SliceAndDice());

                if (Skill.SliceAndDice() == 0)
                {
                    MessageBox.Show("Slice missed");
                }

                if (p2Heart > 0)
                {
                    p2HPbar.Value = p2Heart;
                    lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
                }

                else
                {
                    p2HPbar.Value = 0;
                    lblP2Heart.Text = "Player 2 HP: 0";
                    btnSliceAndDice1.Enabled = false;
                    MessageBox.Show("Player 1 Won!");
                }

                //2nd cast
                MessageBox.Show("Casting dice");
                p2Heart = p2Heart - (Skill.SliceAndDice());

                if (Skill.SliceAndDice() == 0)
                {
                    MessageBox.Show("Dice missed");
                }

                if (p2Heart > 0)
                {
                    p2HPbar.Value = p2Heart;
                    lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
                }

                else
                {
                    p2HPbar.Value = 0;
                    lblP2Heart.Text = "Player 2 HP: 0";
                    btnSliceAndDice1.Enabled = false;
                    MessageBox.Show("Player 1 Won!");
                }
            }
        }

        private void btnEnchant1_Click(object sender, EventArgs e)
        {
            charges3++;

            if(charges3 <= 3)
            {
                //Recoil
                p1Heart = p1Heart - 3;
                
                //Actual skill
                MessageBox.Show("Players may cast 2 consecutive skills");
                p2Heart = p2Heart - (Skill.Enchant());

                if (Skill.Enchant() == 0)
                {
                    MessageBox.Show("Enchant didn't deal damage");
                }

                if (p2Heart > 0)
                {
                    p2HPbar.Value = p2Heart;
                    lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
                }

                else
                {
                    p2HPbar.Value = 0;
                    lblP2Heart.Text = "Player 2 HP: 0";
                    btnEnchant1.Enabled = false;
                    MessageBox.Show("Player 1 Won!");
                }

                //Passive
                Random rnd = new Random();

                int select = rnd.Next(1, 101);

                if (select <= 25)//Passive
                {
                    MessageBox.Show("Player 1 heals 2 hit points and player 2 heals 1 hit point");

                    if(p1Heart <= 48)
                    {
                        p1Heart = p1Heart + 2;

                        p1HPbar.Value = p1Heart;
                        lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
                    }
                    if(p2Heart != 50 && p2Heart != 80)
                    {
                        p2Heart = p2Heart + 1;

                        p2HPbar.Value = p2Heart;
                        lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
                    }
                }

                else
                {
                    p1Heart = p1Heart + 0;

                    p1HPbar.Value = p1Heart;
                    lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();


                    p2Heart = p2Heart + 0;

                    p2HPbar.Value = p2Heart;
                    lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
                }

                Skill.Enchant1();
            }

            if(charges3 == 3)
            {
                btnEnchant1.Enabled = false;
            }
        }

        private void btnConjure1_Click(object sender, EventArgs e)
        {
            timer5.Start();
            //Deactivates Player 1's skills
            gbP1skills.Enabled = false;

        }

        private void btnHawkshot1_Click(object sender, EventArgs e)
        {
            //Deactivates Player 1's skills
            gbP1skills.Enabled = false;
            gbP2skills.Enabled = true;

            charges1++;

            if (charges1 <= 3)
            {
                p2Heart = p2Heart - (Skill.HawkShot());

                if (Skill.HawkShot() == 0)
                {
                    MessageBox.Show("Hawkshot missed");
                }

                if (p2Heart > 0)
                {
                    p2HPbar.Value = p2Heart;
                    lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
                }

                else
                {
                    p2HPbar.Value = 0;
                    lblP2Heart.Text = "Player 2 HP: 0";
                    btnHawkshot1.Enabled = false;
                    MessageBox.Show("Player 1 Won!");
                }

            }

            if (charges1 == 3)
            {
                btnHawkshot1.Enabled = false;
            }
        }

        private void btnStrafe1_Click(object sender, EventArgs e)
        {
            //Deactivates Player 1's skills
            gbP1skills.Enabled = false;
            gbP2skills.Enabled = true;

            p2Heart = p2Heart - (Skill.Strafe());
            MessageBox.Show("Ranger fired " + Skill.Strafe() + " arrows");

            if (Skill.Strafe() == 0)
            {
                MessageBox.Show("Arrows missed");
            }

            if (p2Heart > 0)
            {
                p2HPbar.Value = p2Heart;
                lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
            }

            else
            {
                p2HPbar.Value = 0;
                lblP2Heart.Text = "Player 2 HP: 0";
                btnStrafe1.Enabled = false;
                MessageBox.Show("Player 1 Won!");
            }

        }

        private void btnUmbralStrike1_Click(object sender, EventArgs e)
        {
            //Deactivates Player 1's skills
            gbP1skills.Enabled = false;
            gbP2skills.Enabled = true;

            p2Heart = p2Heart - (Skill.UmbralStrike());

            if (Skill.UmbralStrike() == 0)
            {
                MessageBox.Show("Attack was too obvious so it missed");
            }

            else
            {
                Random rnd = new Random();

                int select = rnd.Next(1, 101);

                if (select <= 50)//Passive
                {
                    int crit = rnd.Next(1, 6);

                    MessageBox.Show("Attack triggered crtitical strike and dealt " + crit + " extra damage");

                    p2Heart = p2Heart - crit;

                    if (p2Heart > 0)
                    {
                        p2HPbar.Value = p2Heart;
                        lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
                    }

                    else
                    {
                        p2HPbar.Value = 0;
                        lblP2Heart.Text = "Player 2 HP: 0";
                        btnUmbralStrike1.Enabled = false;
                        MessageBox.Show("Player 1 Won!");
                    }
                }

                else
                {
                    p2Heart = p2Heart - 0;

                    p2HPbar.Value = p2Heart;
                    lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
                }
            }

            if (p2Heart > 0)
            {
                p2HPbar.Value = p2Heart;
                lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
            }

            else
            {
                p2HPbar.Value = 0;
                lblP2Heart.Text = "Player 2 HP: 0";
                btnUmbralStrike1.Enabled = false;
                MessageBox.Show("Player 1 Won!");
            }

        }

        private void btnQuickSlash1_Click(object sender, EventArgs e)
        {
            //Deactivates Player 1's skills
            gbP1skills.Enabled = false;
            gbP2skills.Enabled = true;

            p2Heart = p2Heart - (Skill.QuickSlash());

            if (Skill.QuickSlash() == 0)
            {
                MessageBox.Show("Attack was too obvious so it missed");
            }

            else//Passive
            {
                Random rnd = new Random();

                int select = rnd.Next(1, 101);

                if (select <= 50)
                {
                    int crit = rnd.Next(1, 6);

                    MessageBox.Show("Attack triggered crtitical strike and dealt " + crit + " extra damage");

                    p2Heart = p2Heart - crit;

                    if (p2Heart > 0)
                    {
                        p2HPbar.Value = p2Heart;
                        lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
                    }

                    else
                    {
                        p2HPbar.Value = 0;
                        lblP2Heart.Text = "Player 2 HP: 0";
                        btnUmbralStrike1.Enabled = false;
                        MessageBox.Show("Player 1 Won!");
                    }
                }

                else
                {
                    p2Heart = p2Heart - 0;

                    p2HPbar.Value = p2Heart;
                    lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
                }
            }

            if (p2Heart > 0)
            {
                p2HPbar.Value = p2Heart;
                lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
            }

            else
            {
                p2HPbar.Value = 0;
                lblP2Heart.Text = "Player 2 HP: 0";
                btnQuickSlash1.Enabled = false;
                MessageBox.Show("Player 1 Won!");
            }

        }

        private void btnBash1_Click(object sender, EventArgs e)
        {
            //Deactivates Player 1's skills
            gbP1skills.Enabled = false;
            gbP2skills.Enabled = true;

            p2Heart = p2Heart - (Skill.Bash());

            if (Skill.Bash() == 0)
            {
                MessageBox.Show("Player 1 swinged the club too slow");
            }

            if (p2Heart > 0)
            {
                p2HPbar.Value = p2Heart;
                lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
            }

            else
            {
                p2HPbar.Value = 0;
                lblP2Heart.Text = "Player 2 HP: 0";
                btnBash1.Enabled = false;
                MessageBox.Show("Player 1 Won!");
            }

        }

        private void btnBrauming1_Click(object sender, EventArgs e)
        {
            //Deactivates Player 1's skills
            gbP1skills.Enabled = false;
            gbP2skills.Enabled = true;

            p2Heart = p2Heart - (Skill.Brauming());

            if (Skill.Brauming() == 0)
            {
                MessageBox.Show("Attack missed");
            }

            if (p2Heart > 0)
            {
                p2HPbar.Value = p2Heart;
                lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
            }

            else
            {
                p2HPbar.Value = 0;
                lblP2Heart.Text = "Player 2 HP: 0";
                btnBrauming1.Enabled = false;
                MessageBox.Show("Player 1 Won!");
            }

        }




        //Player 2 skills
        private void btnHeal2_Click(object sender, EventArgs e)
        {
            if (p2Heart <= 45 || p2Heart > 50 && p2Heart <= 75)
            {
                charge2++;

                healSound.Play();

                if (charge2 <= 2)
                {
                    p2Heart = p2Heart - (Skill.Heal());
                    p2HPbar.Value = p2Heart;
                    lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();

                    MessageBox.Show("Restored " + (Skill.Heal() * -1) + " HP");
                }

                if (charge2 == 2)
                {
                    btnHeal2.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Cannot heal right now, HP is too high");
            }
            

            timer7.Stop();
            timer7.Start();
            bgMusic.PlayLooping();
        }

        private void btnStomp2_Click(object sender, EventArgs e)
        {
            //Deactivates Player 2's skills
            gbP2skills.Enabled = false;
            gbP1skills.Enabled = true;

            p1Heart = p1Heart - (Skill.Stomp());

            if (Skill.Stomp() == 0)
            {
                MessageBox.Show("Stomp missed");
            }

            if (p1Heart > 0)
            {
                p1HPbar.Value = p1Heart;
                lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
            }

            else
            {
                p1HPbar.Value = 0;
                lblP1Heart.Text = "Player 1 HP: 0";
                btnStomp2.Enabled = false;
                MessageBox.Show("Player 2 Won!");
            }
        }

        private void btnMeditate2_Click(object sender, EventArgs e)
        {
            //Deactivates Player 2's skills
            gbP2skills.Enabled = false;
            gbP1skills.Enabled = true;

            Skill.Meditate();

            if (Skill.Meditate() == 0)
            {
                MessageBox.Show("Player 2 will deflect the next attack");
            }

            else
            {
                MessageBox.Show("Player 2 has failed to meditate");
            }
        }

        private void btnQuickAttack2_Click(object sender, EventArgs e)
        {
            //Deactivates Player 2's skills
            gbP2skills.Enabled = false;
            gbP1skills.Enabled = true;

            p1Heart = p1Heart - (Skill.QuickAttack());

            if (Skill.QuickAttack() == 0)
            {
                MessageBox.Show("Quick Attack missed");
            }

            if (p1Heart > 0)
            {
                p1HPbar.Value = p1Heart;
                lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
            }

            else
            {
                p1HPbar.Value = 0;
                lblP1Heart.Text = "Player 1 HP: 0";
                btnQuickAttack2.Enabled = false;
                MessageBox.Show("Player 2 Won!");
            }
        }

        private void btnPanThrow_Click(object sender, EventArgs e)
        {
            //Deactivates Player 2's skills
            gbP2skills.Enabled = false;
            gbP1skills.Enabled = true;

            p1Heart = p1Heart - (Skill.PanThrow());

            if (Skill.PanThrow() == 0)
            {
                MessageBox.Show("The frying pan flew past Player 1 and missed");
            }

            if (p1Heart > 0)
            {
                p1HPbar.Value = p1Heart;
                lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
            }

            else
            {
                p1HPbar.Value = 0;
                lblP1Heart.Text = "Player 1 HP: 0";
                btnPanThrow2.Enabled = false;
                MessageBox.Show("Player 2 Won!");
            }
        }

        private void btnRhapsody2_Click(object sender, EventArgs e)
        {
            //Deactivates Player 2's skills
            gbP2skills.Enabled = false;
            gbP1skills.Enabled = true;

            charge4++;

            if (charge4 <= 10)
            {
                p1Heart = p1Heart - (Skill.Rhapsody());

                if (Skill.Rhapsody() == 0)
                {
                    MessageBox.Show("Rhapsody was too harmonious to deal damage");
                }

                if (p1Heart > 0)
                {
                    p1HPbar.Value = p1Heart;
                    lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
                }

                else
                {
                    p1HPbar.Value = 0;
                    lblP1Heart.Text = "Player 1 HP: 0";
                    btnRhapsody2.Enabled = false;
                    MessageBox.Show("Player 2 Won!");
                }

                Skill.Rhapsody1();
                MessageBox.Show("Player 1 is under hallucination and their next attack will deal 0 damage");
            }

            if (charge4 == 10)
            {
                btnRhapsody2.Enabled = false;
            }
        }

        private void btnRondo2_Click(object sender, EventArgs e)
        {
            //Deactivates Player 2's skills
            gbP2skills.Enabled = false;
            gbP1skills.Enabled = true;

            int RondoDamage = Skill.Rondo();

            p1Heart = p1Heart - (RondoDamage);

            if (RondoDamage == 0)
            {
                MessageBox.Show("Rondo was out of tune");
            }

            if (p1Heart > 0)
            {
                p1HPbar.Value = p1Heart;
                lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
            }

            else
            {
                p1HPbar.Value = 0;
                lblP1Heart.Text = "Player 1 HP: 0";
                btnRondo2.Enabled = false;
                MessageBox.Show("Player 2 Won!");
            }
        }

        private void btnRagnarok2_Click(object sender, EventArgs e)
        {
            //Deactivates Player 2's skills
            gbP2skills.Enabled = false;
            gbP1skills.Enabled = true;

            Random rnd = new Random();
            int multicast = rnd.Next(1, 101);

            if (multicast % 2 == 0)
            {
                MessageBox.Show("Ragnarok multicasted");

                p1Heart = p1Heart - (Skill.Ragnarok());

                if (Skill.Ragnarok() == 0)
                {
                    MessageBox.Show("Attack missed");
                }

                if (p1Heart > 0)
                {
                    p1HPbar.Value = p1Heart;
                    lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
                }

                else
                {
                    p1HPbar.Value = 0;
                    lblP1Heart.Text = "Player 1 HP: 0";
                    btnRagnarok2.Enabled = false;
                    MessageBox.Show("Player 2 Won!");
                }

                //Reflect damage
                p2Heart = p2Heart - (Skill.Ragnarok1());

                if (Skill.Ragnarok() == 0)
                {
                    MessageBox.Show("Attack missed");
                }

                if (p2Heart > 0)
                {
                    p2HPbar.Value = p2Heart;
                    lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
                }

                else
                {
                    p2HPbar.Value = 0;
                    lblP2Heart.Text = "Player 2 HP: 0";
                    btnRagnarok2.Enabled = false;
                    MessageBox.Show("Player 1 Won!");
                }





                //Second cast
                MessageBox.Show("Second cast");

                p1Heart = p1Heart - (Skill.Ragnarok());

                if (Skill.Ragnarok() == 0)
                {
                    MessageBox.Show("Attack missed");
                }

                if (p1Heart > 0)
                {
                    p1HPbar.Value = p1Heart;
                    lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
                }

                else
                {
                    p1HPbar.Value = 0;
                    lblP1Heart.Text = "Player 1 HP: 0";
                    btnRagnarok2.Enabled = false;
                    MessageBox.Show("Player 2 Won!");
                }

                //Reflect damage
                p2Heart = p2Heart - (Skill.Ragnarok1());

                if (Skill.Ragnarok() == 0)
                {
                    MessageBox.Show("Attack missed");
                }

                if (p2Heart > 0)
                {
                    p2HPbar.Value = p2Heart;
                    lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
                }

                else
                {
                    p2HPbar.Value = 0;
                    lblP2Heart.Text = "Player 2 HP: 0";
                    btnRagnarok2.Enabled = false;
                    MessageBox.Show("Player 1 Won!");
                }
            }

            else
            {
                MessageBox.Show("Ragnarok didn't multicast");
                p1Heart = p1Heart - (Skill.Ragnarok());

                if (Skill.Ragnarok() == 0)
                {
                    MessageBox.Show("Attack missed");
                }

                if (p1Heart > 0)
                {
                    p1HPbar.Value = p1Heart;
                    lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
                }

                else
                {
                    p1HPbar.Value = 0;
                    lblP1Heart.Text = "Player 1 HP: 0";
                    btnRagnarok2.Enabled = false;
                    MessageBox.Show("Player 2 Won!");
                }

                //Reflect damage
                p2Heart = p2Heart - (Skill.Ragnarok1());

                if (Skill.Ragnarok() == 0)
                {
                    MessageBox.Show("Attack missed");
                }

                if (p2Heart > 0)
                {
                    p2HPbar.Value = p2Heart;
                    lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
                }

                else
                {
                    p2HPbar.Value = 0;
                    lblP2Heart.Text = "Player 2 HP: 0";
                    btnRagnarok2.Enabled = false;
                    MessageBox.Show("Player 1 Won!");
                }
            }
        }

        private void btnSliceAndDice2_Click(object sender, EventArgs e)
        {
            //Deactivates Player 2's skills
            gbP2skills.Enabled = false;
            gbP1skills.Enabled = true;

            Random rnd = new Random();
            int multicast = rnd.Next(1, 101);

            if (multicast % 2 == 0)
            {
                MessageBox.Show("Slice and Dice multicasted");

                //1st phase

                //1st cast
                MessageBox.Show("Casting slice");
                p1Heart = p1Heart - (Skill.SliceAndDice());

                if (Skill.SliceAndDice() == 0)
                {
                    MessageBox.Show("Slice missed");
                }

                if (p1Heart > 0)
                {
                    p1HPbar.Value = p1Heart;
                    lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
                }

                else
                {
                    p1HPbar.Value = 0;
                    lblP1Heart.Text = "Player 1 HP: 0";
                    btnSliceAndDice2.Enabled = false;
                    MessageBox.Show("Player 2 Won!");
                }

                //2nd cast
                MessageBox.Show("Casting dice");
                p1Heart = p1Heart - (Skill.SliceAndDice());

                if (Skill.SliceAndDice() == 0)
                {
                    MessageBox.Show("Dice missed");
                }

                if (p1Heart > 0)
                {
                    p1HPbar.Value = p1Heart;
                    lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
                }

                else
                {
                    p1HPbar.Value = 0;
                    lblP1Heart.Text = "Player 1 HP: 0";
                    btnSliceAndDice2.Enabled = false;
                    MessageBox.Show("Player 2 Won!");
                }

                //2nd phase
                //1st cast
                MessageBox.Show("Casting slice");
                p1Heart = p1Heart - (Skill.SliceAndDice());

                if (Skill.SliceAndDice() == 0)
                {
                    MessageBox.Show("Slice missed");
                }

                if (p1Heart > 0)
                {
                    p1HPbar.Value = p1Heart;
                    lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
                }

                else
                {
                    p1HPbar.Value = 0;
                    lblP1Heart.Text = "Player 1 HP: 0";
                    btnSliceAndDice2.Enabled = false;
                    MessageBox.Show("Player 2 Won!");
                }

                //2nd cast
                MessageBox.Show("Casting dice");
                p1Heart = p1Heart - (Skill.SliceAndDice());

                if (Skill.SliceAndDice() == 0)
                {
                    MessageBox.Show("Dice missed");
                }

                if (p1Heart > 0)
                {
                    p1HPbar.Value = p1Heart;
                    lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
                }

                else
                {
                    p1HPbar.Value = 0;
                    lblP1Heart.Text = "Player 1 HP: 0";
                    btnSliceAndDice2.Enabled = false;
                    MessageBox.Show("Player 2 Won!");
                }
            }

            else
            {
                MessageBox.Show("Slice and Dice didn't multicast");

                //1st cast
                MessageBox.Show("Casting slice");
                p1Heart = p1Heart - (Skill.SliceAndDice());

                if (Skill.SliceAndDice() == 0)
                {
                    MessageBox.Show("Slice missed");
                }

                if (p1Heart > 0)
                {
                    p1HPbar.Value = p1Heart;
                    lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
                }

                else
                {
                    p1HPbar.Value = 0;
                    lblP1Heart.Text = "Player 1 HP: 0";
                    btnSliceAndDice2.Enabled = false;
                    MessageBox.Show("Player 2 Won!");
                }

                //2nd cast
                MessageBox.Show("Casting dice");
                p1Heart = p1Heart - (Skill.SliceAndDice());

                if (Skill.SliceAndDice() == 0)
                {
                    MessageBox.Show("Dice missed");
                }

                if (p1Heart > 0)
                {
                    p1HPbar.Value = p1Heart;
                    lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
                }

                else
                {
                    p1HPbar.Value = 0;
                    lblP1Heart.Text = "Player 1 HP: 0";
                    btnSliceAndDice2.Enabled = false;
                    MessageBox.Show("Player 2 Won!");
                }
            }
        }

        private void btnEnchant2_Click(object sender, EventArgs e)
        {
            charges4++;

            if(charges4 <= 3)
            {
                //recoil
                p2Heart = p2Heart - 3;               

                //Actual skill
                MessageBox.Show("Players may cast 2 consecutive skills");
                p1Heart = p1Heart - (Skill.Enchant());

                if (Skill.Enchant() == 0)
                {
                    MessageBox.Show("Enchant didn't deal damage");
                }

                if (p1Heart > 0)
                {
                    p1HPbar.Value = p1Heart;
                    lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
                }

                else
                {
                    p1HPbar.Value = 0;
                    lblP1Heart.Text = "Player 1 HP: 0";
                    btnEnchant2.Enabled = false;
                    MessageBox.Show("Player 2 Won!");
                }

                //Passive
                Random rnd = new Random();

                int select = rnd.Next(1, 101);

                if (select <= 25)//Passive
                {
                    MessageBox.Show("Player 2 heals 2 hit points and player 1 heals 1 hit point");

                    if (p2Heart <= 48)
                    {
                        p2Heart = p2Heart + 2;

                        p2HPbar.Value = p2Heart;
                        lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
                    }
                    if (p1Heart != 50 && p1Heart != 80)
                    {
                        p1Heart = p1Heart + 1;

                        p1HPbar.Value = p1Heart;
                        lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
                    }
                }

                else
                {
                    p2Heart = p2Heart + 0;

                    p2HPbar.Value = p2Heart;
                    lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();


                    p1Heart = p1Heart + 0;

                    p1HPbar.Value = p1Heart;
                    lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
                }

                Skill.Enchant1();
            }

            if(charges4 == 3)
            {
                btnEnchant2.Enabled = false;
            }
        }

        private void btnConjure2_Click(object sender, EventArgs e)
        {
            timer6.Start();
            //Deactivates Player 2's skills
            gbP2skills.Enabled = false;
            
        }

        private void btnHawkshot2_Click(object sender, EventArgs e)
        {
            //Deactivates Player 2's skills
            gbP2skills.Enabled = false;
            gbP1skills.Enabled = true;

            charges2++;

            if (charges2 <= 3)
            {
                p1Heart = p1Heart - (Skill.HawkShot());

                if (Skill.HawkShot() == 0)
                {
                    MessageBox.Show("Hawkshot missed");
                }

                if (p1Heart > 0)
                {
                    p1HPbar.Value = p1Heart;
                    lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
                }

                else
                {
                    p1HPbar.Value = 0;
                    lblP1Heart.Text = "Player 1 HP: 0";
                    btnHawkshot2.Enabled = false;
                    MessageBox.Show("Player 2 Won!");
                }

            }

            if (charges2 == 3)
            {
                btnHawkshot2.Enabled = false;
            }
        }

        private void btnStrafe2_Click(object sender, EventArgs e)
        {
            //Deactivates Player 2's skills
            gbP2skills.Enabled = false;
            gbP1skills.Enabled = true;

            p1Heart = p1Heart - (Skill.Strafe());
            MessageBox.Show("Ranger fired " + Skill.Strafe() + " arrows");

            if (Skill.Strafe() == 0)
            {
                MessageBox.Show("Arrows missed");
            }

            if (p1Heart > 0)
            {
                p1HPbar.Value = p1Heart;
                lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
            }

            else
            {
                p1HPbar.Value = 0;
                lblP1Heart.Text = "Player 1 HP: 0";
                btnStrafe2.Enabled = false;
                MessageBox.Show("Player 2 Won!");
            }
        }

        private void btnUmbralStrike2_Click(object sender, EventArgs e)
        {
            //Deactivates Player 2's skills
            gbP2skills.Enabled = false;
            gbP1skills.Enabled = true;

            p1Heart = p1Heart - (Skill.UmbralStrike());

            if (Skill.UmbralStrike() == 0)
            {
                MessageBox.Show("Attack was too obvious so it missed");
            }

            else
            {
                Random rnd = new Random();

                int select = rnd.Next(1, 101);

                if (select <= 50)//Passive
                {
                    int crit = rnd.Next(1, 6);

                    MessageBox.Show("Attack triggered crtitical strike and dealt " + crit + " extra damage");

                    p1Heart = p1Heart - crit;

                    if(p1Heart > 0)
                    {
                        p1HPbar.Value = p1Heart;
                        lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
                    }
                    
                    else
                    {
                        p1HPbar.Value = 0;
                        lblP1Heart.Text = "Player 1 HP: 0";
                        btnUmbralStrike2.Enabled = false;
                        MessageBox.Show("Player 2 Won!");
                    }
                }

                else
                {
                    p1Heart = p1Heart - 0;

                    p1HPbar.Value = p1Heart;
                    lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
                }
            }

            if (p1Heart > 0)
            {
                p1HPbar.Value = p1Heart;
                lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
            }

            else
            {
                p1HPbar.Value = 0;
                lblP1Heart.Text = "Player 1 HP: 0";
                btnUmbralStrike2.Enabled = false;
                MessageBox.Show("Player 2 Won!");
            }
        }

        private void btnQuickSlash2_Click(object sender, EventArgs e)
        {
            //Deactivates Player 2's skills
            gbP2skills.Enabled = false;
            gbP1skills.Enabled = true;

            p1Heart = p1Heart - (Skill.QuickSlash());

            if (Skill.QuickSlash() == 0)
            {
                MessageBox.Show("Attack was too obvious so it missed");
            }

            else//Passive
            {
                Random rnd = new Random();

                int select = rnd.Next(1, 101);

                if (select <= 50)
                {
                    int crit = rnd.Next(1, 6);

                    MessageBox.Show("Attack triggered crtitical strike and dealt " + crit + " extra damage");

                    p1Heart = p1Heart - crit;

                    if (p1Heart > 0)
                    {
                        p1HPbar.Value = p1Heart;
                        lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
                    }

                    else
                    {
                        p1HPbar.Value = 0;
                        lblP1Heart.Text = "Player 1 HP: 0";
                        btnUmbralStrike2.Enabled = false;
                        MessageBox.Show("Player 2 Won!");
                    }
                }

                else
                {
                    p1Heart = p1Heart - 0;

                    p1HPbar.Value = p1Heart;
                    lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
                }
            }

            if (p1Heart > 0)
            {
                p1HPbar.Value = p1Heart;
                lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
            }

            else
            {
                p1HPbar.Value = 0;
                lblP1Heart.Text = "Player 1 HP: 0";
                btnQuickSlash2.Enabled = false;
                MessageBox.Show("Player 2 Won!");
            }
        }

        private void btnBash2_Click(object sender, EventArgs e)
        {
            //Deactivates Player 2's skills
            gbP2skills.Enabled = false;
            gbP1skills.Enabled = true;

            p1Heart = p1Heart - (Skill.Bash());

            if (Skill.Bash() == 0)
            {
                MessageBox.Show("Player 1 swinged the club too slow");
            }

            if (p1Heart > 0)
            {
                p1HPbar.Value = p1Heart;
                lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
            }

            else
            {
                p1HPbar.Value = 0;
                lblP1Heart.Text = "Player 1 HP: 0";
                btnBash2.Enabled = false;
                MessageBox.Show("Player 2 Won!");
            }
        }

        private void btnBrauming2_Click(object sender, EventArgs e)
        {
            //Deactivates Player 2's skills
            gbP2skills.Enabled = false;
            gbP1skills.Enabled = true;

            p1Heart = p1Heart - (Skill.Brauming());

            if (Skill.Brauming() == 0)
            {
                MessageBox.Show("Attack missed");
            }

            if (p1Heart > 0)
            {
                p1HPbar.Value = p1Heart;
                lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
            }

            else
            {
                p1HPbar.Value = 0;
                lblP1Heart.Text = "Player 1 HP: 0";
                btnBrauming2.Enabled = false;
                MessageBox.Show("Player 2 Won!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Player 1 Avatar animation
            if (rbtnBard1.Checked)
            {
                pbBard1.Visible = !pbBard1.Visible;
                pbBard1_1.Visible = !pbBard1_1.Visible;
            }

            else if (rbtnBerserker1.Checked)
            {
                pbBerserker1.Visible = !pbBerserker1.Visible;
                pbBerserker1_1.Visible = !pbBerserker1_1.Visible;
            }

            else if (rbtnSorcerer1.Checked)
            {
                pbSorcerer1.Visible = !pbSorcerer1.Visible;
                pbSorcerer1_1.Visible = !pbSorcerer1_1.Visible;
            }

            else if (rbtnRanger1.Checked)
            {
                pbRanger1.Visible = !pbRanger1.Visible;
                pbRanger1_1.Visible = !pbRanger1_1.Visible;
            }

            else if (rbtnAssassin1.Checked)
            {
                pbAssassin1.Visible = !pbAssassin1.Visible;
                pbAssassin1_1.Visible = !pbAssassin1_1.Visible;
            }

            else if (rbtnVanguard1.Checked)
            {
                pbVanguard1.Visible = !pbVanguard1.Visible;
                pbVanguard1_1.Visible = !pbVanguard1_1.Visible;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Player 2 Avatar animation
            if (rbtnBard2.Checked)
            {
                pbBard2.Visible = !pbBard2.Visible;
                pbBard2_1.Visible = !pbBard2_1.Visible;
            }

            else if (rbtnBerserker2.Checked)
            {
                pbBerserker2.Visible = !pbBerserker2.Visible;
                pbBerserker2_1.Visible = !pbBerserker2_1.Visible;
            }

            else if (rbtnSorcerer2.Checked)
            {
                pbSorcerer2.Visible = !pbSorcerer2.Visible;
                pbSorcerer2_1.Visible = !pbSorcerer2_1.Visible;
            }

            else if (rbtnRanger2.Checked)
            {
                pbRanger2.Visible = !pbRanger2.Visible;
                pbRanger2_1.Visible = !pbRanger2_1.Visible;
            }

            else if (rbtnAssassin2.Checked)
            {
                pbAssassin2.Visible = !pbAssassin2.Visible;
                pbAssassin2_1.Visible = !pbAssassin2_1.Visible;
            }

            else if (rbtnVanguard2.Checked)
            {
                pbVanguard2.Visible = !pbVanguard2.Visible;
                pbVanguard2_1.Visible = !pbVanguard2_1.Visible;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //Player 1 ghost animation
            pbGhost1.Visible = !pbGhost1.Visible;
            pbGhost1_1.Visible = !pbGhost1_1.Visible;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            //Player 2 ghost animation
            pbGhost2.Visible = !pbGhost2.Visible;
            pbGhost2_1.Visible = !pbGhost2_1.Visible;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            //Player 1 conjure animation
            frame1++;

            if (frame1 == 1)
            {
                pbGolem1.Visible = true;
            }
            if (frame1 == 2)
            {
                pbGolem1.Visible = false;
                pbGolem2.Visible = true;
            }
            if (frame1 == 3)
            {
                pbGolem2.Visible = false;
                pbGolem3.Visible = true;
            }
            if (frame1 == 4)
            {
                pbGolem3.Visible = false;
                pbGolem4.Visible = true;
            }
            if (frame1 == 5)
            {
                pbGolem4.Visible = false;
                pbGolem5.Visible = true;
            }
            if (frame1 == 6)
            {
                pbGolem5.Visible = false;
                pbGolem6.Visible = true;
            }
            if (frame1 == 7)
            {
                pbGolem6.Visible = false;
                pbGolem7.Visible = true;
            }
            if (frame1 == 8)
            {
                pbGolem7.Visible = false;
                pbGolem8.Visible = true;
            }
            if (frame1 == 9)
            {
                pbGolem8.Visible = false;
                timer5.Stop();
                frame1 = 0;

                //Actual skill
                p2Heart = p2Heart - (Skill.Conjure());

                if (Skill.Conjure() == 0)
                {
                    MessageBox.Show("The impact missed Player 2");
                }

                if (p2Heart > 0)
                {
                    p2HPbar.Value = p2Heart;
                    lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
                }

                else
                {
                    p2HPbar.Value = 0;
                    lblP2Heart.Text = "Player 2 HP: 0";
                    btnConjure1.Enabled = false;
                    MessageBox.Show("Player 1 Won!");
                }

                //feedback
                p1Heart = p1Heart - (Skill.Conjure1());

                if (Skill.Conjure1() == 0)
                {
                    MessageBox.Show("You escaped unscathed");
                }

                if (p1Heart > 0)
                {
                    p1HPbar.Value = p1Heart;
                    lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
                }

                else
                {
                    p1HPbar.Value = 0;
                    lblP1Heart.Text = "Player 1 HP: 0";
                    btnConjure1.Enabled = false;
                    MessageBox.Show("Player 2 Won!");
                }

                //Passive
                Random rnd = new Random();

                int select = rnd.Next(1, 101);

                if (select <= 25)//Passive
                {
                    MessageBox.Show("Player 1 heals 2 hit points and player 2 heals 1 hit point");

                    if (p1Heart <= 48)
                    {
                        p1Heart = p1Heart + 2;

                        p1HPbar.Value = p1Heart;
                        lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
                    }
                    if (p2Heart != 50 && p2Heart != 80)
                    {
                        p2Heart = p2Heart + 1;

                        p2HPbar.Value = p2Heart;
                        lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
                    }
                }

                else
                {
                    p1Heart = p1Heart + 0;

                    p1HPbar.Value = p1Heart;
                    lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();


                    p2Heart = p2Heart + 0;

                    p2HPbar.Value = p2Heart;
                    lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
                }

                //skill
                gbP2skills.Enabled = true;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            //Player 2 conjure animation
            frame2++;

            if (frame2 == 1)
            {
                pbGolem1.Visible = true;
            }
            if (frame2 == 2)
            {
                pbGolem1.Visible = false;
                pbGolem2.Visible = true;
            }
            if (frame2 == 3)
            {
                pbGolem2.Visible = false;
                pbGolem3.Visible = true;
            }
            if (frame2 == 4)
            {
                pbGolem3.Visible = false;
                pbGolem4.Visible = true;
            }
            if (frame2 == 5)
            {
                pbGolem4.Visible = false;
                pbGolem5.Visible = true;
            }
            if (frame2 == 6)
            {
                pbGolem5.Visible = false;
                pbGolem6.Visible = true;
            }
            if (frame2 == 7)
            {
                pbGolem6.Visible = false;
                pbGolem7.Visible = true;
            }
            if (frame2 == 8)
            {
                pbGolem7.Visible = false;
                pbGolem8.Visible = true;
            }
            if (frame2 == 9)
            {
                pbGolem8.Visible = false;
                timer6.Stop();
                frame2 = 0;

                //Actual skill
                p1Heart = p1Heart - (Skill.Conjure());

                if (Skill.Conjure() == 0)
                {
                    MessageBox.Show("The impact missed Player 1");
                }

                if (p1Heart > 0)
                {
                    p1HPbar.Value = p1Heart;
                    lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
                }

                else
                {
                    p1HPbar.Value = 0;
                    lblP1Heart.Text = "Player 1 HP: 0";
                    btnConjure2.Enabled = false;
                    MessageBox.Show("Player 2 Won!");
                }

                //feedback
                p2Heart = p2Heart - (Skill.Conjure1());

                if (Skill.Conjure1() == 0)
                {
                    MessageBox.Show("You escaped unscathed");
                }

                if (p2Heart > 0)
                {
                    p2HPbar.Value = p2Heart;
                    lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
                }

                else
                {
                    p2HPbar.Value = 0;
                    lblP2Heart.Text = "Player 2 HP: 0";
                    btnConjure2.Enabled = false;
                    MessageBox.Show("Player 1 Won!");
                }

                //Passive
                Random rnd = new Random();

                int select = rnd.Next(1, 101);

                if (select <= 25)//Passive
                {
                    MessageBox.Show("Player 2 heals 2 hit points and player 1 heals 1 hit point");

                    if (p2Heart <= 48)
                    {
                        p2Heart = p2Heart + 2;

                        p2HPbar.Value = p2Heart;
                        lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();
                    }
                    if (p1Heart != 50 && p1Heart != 80)
                    {
                        p1Heart = p1Heart + 1;

                        p1HPbar.Value = p1Heart;
                        lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
                    }
                }

                else
                {
                    p2Heart = p2Heart + 0;

                    p2HPbar.Value = p2Heart;
                    lblP2Heart.Text = "Player 2 HP: " + p2Heart.ToString();


                    p1Heart = p1Heart + 0;

                    p1HPbar.Value = p1Heart;
                    lblP1Heart.Text = "Player 1 HP: " + p1Heart.ToString();
                }

                //skill
                gbP1skills.Enabled = true;
            }
        }       

        //Player1 skill description
        private void btnHeal1_MouseHover(object sender, EventArgs e)
        {
            lblHeal1.Visible = true;
        }

        private void btnHeal1_MouseLeave(object sender, EventArgs e)
        {
            lblHeal1.Visible = false;
        }

        private void btnStomp1_MouseHover(object sender, EventArgs e)
        {
            lblStomp1.Visible = true;
        }

        private void btnStomp1_MouseLeave(object sender, EventArgs e)
        {
            lblStomp1.Visible = false;
        }

        private void btnMeditate1_MouseHover(object sender, EventArgs e)
        {
            lblMeditate1.Visible = true;
        }

        private void btnMeditate1_MouseLeave(object sender, EventArgs e)
        {
            lblMeditate1.Visible = false;
        }

        private void btnQuickAttack1_MouseHover(object sender, EventArgs e)
        {
            lblQuickAttack1.Visible = true;
        }

        private void btnQuickAttack1_MouseLeave(object sender, EventArgs e)
        {
            lblQuickAttack1.Visible = false;
        }

        private void btnPanThrow1_MouseHover(object sender, EventArgs e)
        {
            lblPanThrow1.Visible = true;
        }

        private void btnPanThrow1_MouseLeave(object sender, EventArgs e)
        {
            lblPanThrow1.Visible = false;
        }

        private void btnRhapsody1_MouseHover(object sender, EventArgs e)
        {
            lblRhapsody1.Visible = true;
        }

        private void btnRhapsody1_MouseLeave(object sender, EventArgs e)
        {
            lblRhapsody1.Visible = false;
        }

        private void btnRondo1_MouseHover(object sender, EventArgs e)
        {
            lblRondo1.Visible = true;
        }

        private void btnRondo1_MouseLeave(object sender, EventArgs e)
        {
            lblRondo1.Visible = false;
        }

        private void btnRagnarok1_MouseHover(object sender, EventArgs e)
        {
            lblRagnarok1.Visible = true;
        }

        private void btnRagnarok1_MouseLeave(object sender, EventArgs e)
        {
            lblRagnarok1.Visible = false;
        }

        private void btnSliceAndDice1_MouseHover(object sender, EventArgs e)
        {
            lblSliceAndDice1.Visible = true;
        }

        private void btnSliceAndDice1_MouseLeave(object sender, EventArgs e)
        {
            lblSliceAndDice1.Visible = false;
        }

        private void btnEnchant1_MouseHover(object sender, EventArgs e)
        {
            lblEnchant1.Visible = true;
        }

        private void btnEnchant1_MouseLeave(object sender, EventArgs e)
        {
            lblEnchant1.Visible = false;
        }

        private void btnConjure1_MouseHover(object sender, EventArgs e)
        {
            lblConjure1.Visible = true;
        }

        private void btnConjure1_MouseLeave(object sender, EventArgs e)
        {
            lblConjure1.Visible = false;
        }

        private void btnHawkshot1_MouseHover(object sender, EventArgs e)
        {
            lblHawkshot1.Visible = true;
        }

        private void btnHawkshot1_MouseLeave(object sender, EventArgs e)
        {
            lblHawkshot1.Visible = false;
        }

        private void btnStrafe1_MouseHover(object sender, EventArgs e)
        {
            lblStrafe1.Visible = true;
        }

        private void btnStrafe1_MouseLeave(object sender, EventArgs e)
        {
            lblStrafe1.Visible = false;
        }

        private void btnUmbralStrike1_MouseHover(object sender, EventArgs e)
        {
            lblUmbralStrike1.Visible = true;
        }

        private void btnUmbralStrike1_MouseLeave(object sender, EventArgs e)
        {
            lblUmbralStrike1.Visible = false;
        }

        private void btnQuickSlash1_MouseHover(object sender, EventArgs e)
        {
            lblQuickSlash1.Visible = true;
        }

        private void btnQuickSlash1_MouseLeave(object sender, EventArgs e)
        {
            lblQuickSlash1.Visible = false;
        }

        private void btnBash1_MouseHover(object sender, EventArgs e)
        {
            lblBash1.Visible = true;
        }

        private void btnBash1_MouseLeave(object sender, EventArgs e)
        {
            lblBash1.Visible = false;
        }

        private void btnBrauming1_MouseHover(object sender, EventArgs e)
        {
            lblBrauming1.Visible = true;
        }

        private void btnBrauming1_MouseLeave(object sender, EventArgs e)
        {
            lblBrauming1.Visible = false;
        }

        //Player2 skill description
        private void btnHeal2_MouseHover(object sender, EventArgs e)
        {
            lblHeal1.Visible = true;
        }

        private void btnHeal2_MouseLeave(object sender, EventArgs e)
        {
            lblHeal1.Visible = false;
        }

        private void btnStomp2_MouseHover(object sender, EventArgs e)
        {
            lblStomp1.Visible = true;
        }

        private void btnStomp2_MouseLeave(object sender, EventArgs e)
        {
            lblStomp1.Visible = false;
        }

        private void btnMeditate2_MouseHover(object sender, EventArgs e)
        {
            lblMeditate1.Visible = true;
        }

        private void btnMeditate2_MouseLeave(object sender, EventArgs e)
        {
            lblMeditate1.Visible = false;
        }

        private void btnQuickAttack2_MouseHover(object sender, EventArgs e)
        {
            lblQuickAttack1.Visible = true;
        }

        private void btnQuickAttack2_MouseLeave(object sender, EventArgs e)
        {
            lblQuickAttack1.Visible = false;
        }

        private void btnPanThrow2_MouseHover(object sender, EventArgs e)
        {
            lblPanThrow1.Visible = true;
        }

        private void btnPanThrow2_MouseLeave(object sender, EventArgs e)
        {
            lblPanThrow1.Visible = false;
        }

        private void btnRhapsody2_MouseHover(object sender, EventArgs e)
        {
            lblRhapsody1.Visible = true;
        }

        private void btnRhapsody2_MouseLeave(object sender, EventArgs e)
        {
            lblRhapsody1.Visible = false;
        }

        private void btnRondo2_MouseHover(object sender, EventArgs e)
        {
            lblRondo1.Visible = true;
        }

        private void btnRondo2_MouseLeave(object sender, EventArgs e)
        {
            lblRondo1.Visible = false;
        }

        private void btnRagnarok2_MouseHover(object sender, EventArgs e)
        {
            lblRagnarok1.Visible = true;
        }

        private void btnRagnarok2_MouseLeave(object sender, EventArgs e)
        {
            lblRagnarok1.Visible = false;
        }

        private void btnSliceAndDice2_MouseHover(object sender, EventArgs e)
        {
            lblSliceAndDice1.Visible = true;
        }

        private void btnSliceAndDice2_MouseLeave(object sender, EventArgs e)
        {
            lblSliceAndDice1.Visible = false;
        }

        private void btnEnchant2_MouseHover(object sender, EventArgs e)
        {
            lblEnchant1.Visible = true;
        }

        private void btnEnchant2_MouseLeave(object sender, EventArgs e)
        {
            lblEnchant1.Visible = false;
        }

        private void btnConjure2_MouseHover(object sender, EventArgs e)
        {
            lblConjure1.Visible = true;
        }

        private void btnConjure2_MouseLeave(object sender, EventArgs e)
        {
            lblConjure1.Visible = false;
        }

        private void btnHawkshot2_MouseHover(object sender, EventArgs e)
        {
            lblHawkshot1.Visible = true;
        }

        private void btnHawkshot2_MouseLeave(object sender, EventArgs e)
        {
            lblHawkshot1.Visible = false;
        }

        private void btnStrafe2_MouseHover(object sender, EventArgs e)
        {
            lblStrafe1.Visible = true;
        }

        private void btnStrafe2_MouseLeave(object sender, EventArgs e)
        {
            lblStrafe1.Visible = false;
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            //music++;

            //if(music == 56)
            //{
            //    music = 0;
            //    bgMusic.Stop();
            //    bgMusic.Play();
            //    timer7.Stop();
            //    timer7.Start();
            //}
        }

        private void btnUmbralStrike2_MouseHover(object sender, EventArgs e)
        {
            lblUmbralStrike1.Visible = true;
        }
        
        private void btnUmbralStrike2_MouseLeave(object sender, EventArgs e)
        {
            lblUmbralStrike1.Visible = false;
        }

        private void btnQuickSlash2_MouseHover(object sender, EventArgs e)
        {
            lblQuickSlash1.Visible = true;
        }

        private void btnQuickSlash2_MouseLeave(object sender, EventArgs e)
        {
            lblQuickSlash1.Visible = false;
        }

        private void btnBash2_MouseHover(object sender, EventArgs e)
        {
            lblBash1.Visible = true;
        }

        private void btnBash2_MouseLeave(object sender, EventArgs e)
        {
            lblBash1.Visible = false;
        }

        private void btnBrauming2_MouseHover(object sender, EventArgs e)
        {
            lblBrauming1.Visible = true;
        }

        private void btnBrauming2_MouseLeave(object sender, EventArgs e)
        {
            lblBrauming1.Visible = false;
        }

        private void lblP2Heart_TextChanged(object sender, EventArgs e)
        {
            if (lblP2Heart.Text == "Player 2 HP: 0")
            {
                //Hiding the character avatars and stopping the animation
                pbBard2.Visible = false;
                pbBard2_1.Visible = false;
                pbBerserker2.Visible = false;
                pbBerserker2_1.Visible = false;
                pbSorcerer2.Visible = false;
                pbSorcerer2_1.Visible = false;
                pbRanger2.Visible = false;
                pbRanger2_1.Visible = false;
                pbAssassin2.Visible = false;
                pbAssassin2_1.Visible = false;
                pbVanguard2.Visible = false;
                pbVanguard2_1.Visible = false;
                timer2.Stop();

                //Starting the ghost animation
                pbGhost2.Visible = true;
                timer4.Stop();
                timer4.Start();

                //Deactivating skills
                gbP1skills.Enabled = false;
                gbP2skills.Enabled = false;
                btnHeal2.Enabled = false;
                btnHeal1.Enabled = false;
            }
        }

        private void lblP1Heart_TextChanged(object sender, EventArgs e)
        {
            if (lblP1Heart.Text == "Player 1 HP: 0")
            {
                //Hiding the character avatars and stopping the animation
                pbBard1.Visible = false;
                pbBard1_1.Visible = false;
                pbBerserker1.Visible = false;
                pbBerserker1_1.Visible = false;
                pbSorcerer1.Visible = false;
                pbSorcerer1_1.Visible = false;
                pbRanger1.Visible = false;
                pbRanger1_1.Visible = false;
                pbAssassin1.Visible = false;
                pbAssassin1_1.Visible = false;
                pbVanguard1.Visible = false;
                pbVanguard1_1.Visible = false;
                timer1.Stop();

                //Starting the ghost animation
                pbGhost1.Visible = true;
                timer3.Stop();
                timer3.Start();

                //Deactivating skills
                gbP1skills.Enabled = false;
                gbP2skills.Enabled = false;
                btnHeal1.Enabled = false;
                btnHeal2.Enabled = false;
            }
        }
    }
}