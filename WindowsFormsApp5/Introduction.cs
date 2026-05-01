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
    public partial class Introduction : Form
    {
        private SoundPlayer bgMusic;
        private SoundPlayer bgMusic1;
        public Introduction()
        {
            InitializeComponent();
            // Check if MainGame form is active
            bgMusic = new SoundPlayer("Twin Musicom-NESTheme.wav");
            bgMusic1 = new SoundPlayer("TwinMusicomNESBoss.wav");
        }

        private void Introduction_Load(object sender, EventArgs e)
        {
            timer1.Start();
            bgMusic.PlayLooping();
        }

        private void btnBackToMainGame_Click(object sender, EventArgs e)
        {
            var MainGame = new MainGame();
            MainGame.Show();
            this.Close();
        }
        private void Introduction_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Stop all playing music when the Introduction form is closed
            bgMusic1.PlayLooping();
        }

        private void btnReturnToMainGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblHeal_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Effect: Player restores 2 to 5 points of HP\n\nCharge: 2\n\nAccuracy: 100%");
        }

        private void lblStomp_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Effect: Player jumps and slams the ground dealing 2 to 3 points of damage\n\nCharge: infinite\n\nAccuracy: 90%");
        }

        private void lblMeditate_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Effect: Player will block the incoming damage.\n\nCharge: infinite\n\nAccuracy: 80%");
        }

        private void lblQuickAttack_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Effect: Deals 1 to 4 points of damage\n\nCharge: infinite\n\nAccuracy: if damage is 1 to 3 the accuracy is 80% but it drops to 70% if the damage is 4");
        }

        private void lblPanThrow_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Effect: Throws a frying pan that deals 2 or 3 points of damage with the chance of it dealing a rare 10 points of damage\n\nCharge: infinite\n\nAccuracy: if the damage is 2 or 3, accuracy is at 80% but if it hits the jackpot 10 points it only has a 30% chance of hitting");
        }

        private void lblRhapsody_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Effect: Traps the enemy in a hallucination with music and they skip a turn. This skill has a 50% chance of applying 2 points of damage.\n\nCharge: 10\n\nAccuracy: 100% on making the enemy skip a turn and 50% on applying 2 points of damage");
        }

        private void lblRondo_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Effect: This is a three phased skill. The initial damage is 1 and in the first phase, it can be multiplied by 1 or 2. The second phase either doubles or triples the damage and the third phase applies the damage.\n\nCharge: infinite\n\nAccuracy: 80%");
        }

        private void label23_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Passive: N/A");
        }

        private void lblBerserker_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Passive: Skills can multi-cast");
        }

        private void lblRagnarok_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Effect: Player sways one of his weapons and deals 3, 6 or 9 points of damage. The player then recieves 1/3 of the damage dealt as reflected damage.\n\nCharge: infinite\n\nAccuracy: 80%");
        }

        private void lblSliceAndDice_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Effect: Player slashes his two weapons dealing 1 to 4 points of damage each\n\nCharge: infinite\n\nAccuracy: 80%");
        }

        private void lblSorcerer_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Passive: Special skills have a 25% chance of healing you 2 points of HP and the enemy 1 point of HP.");
        }

        private void lblEnchant_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Effect: Deals 3 damage to one's self then Enchants the player's attacks. It has a chance of doubling the damage of your next attack and has a half chance of dealing 2 points of damage. This skill allows the players to take two turns.\n\nCharge: 3\n\nAccuracy: 40% chance to double the next damage and 50% chance to deal 2 points of danage");
        }

        private void lblConjure_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Effect: Summons a golem that smashes the ground dealing 8 points of damage and could potentially hit you too.\n\nCharge: inifinite\n\nAccuracy: 70% chance of hitting the enemy and 30% chance of hitting you too.");
        }

        private void lblRanger_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Passive: N/A");
        }

        private void lblHawkshot_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Effect: The ranger fires an arrow of light that deals 15 points of damage.\n\nCharge: 3\n\nAccuracy: 40%");
        }

        private void lblStrafe_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Effect: Fires and arrow that deals 1 point damage but can split up to 6 times upon launching.\n\nCharge: infinite\n\nAccuracy: 100%");
        }

        private void lblAssassin_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Passive: Assassins only have 40 Hit Points but has a 50% chance to trigger a critical strike on his special skill dealing 1 to 5 points of damage.");
        }

        private void lblUmbralStrike_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Effect: Using his dagger, the assassin strikes the enemy to their opening. The opening is on their front 4 out of 10 times and on their back 6 out of 10 times. The damage is 3 points if it strikes the enemy up front and 5 points if the assassin is able to sneak behind them.\n\nCharge: infinite\n\nAccuracy: 80%");
        }

        private void lblQuickSlash_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Effect: The assassin slashes the enemy upfront or from behind with a 50/50 chance. If the Assassin slashes from the front, it will hit a vital spot and will deal 6 points of damage. If it's from the back, the damage is only 2 points.\n\nCharge: infinite\n\nAccuracy: Front: 75% Back: 100%");
        }

        private void lblVanguard_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Passive: The Vanguard is a tank character and has 80 Hit Points but has a relatively small damage on his special skills but they are guaranteed to hit.");
        }

        private void lblBash_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Effect: Vanguard strikes with his club dealing 2 or 3 points of damage.\n\nCharge: infinite\n\nAccuracy: 100%");
        }

        private void lblBrauming_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Effect: Trained by Braum himself, Vanguard sways his Vibranium shield against the enemy dealing 1 or 4 points of damage.\n\nCharge: infinite\n\nAccuracy: 100%");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Bard animation
            pbBard1.Visible = !pbBard1.Visible;
            pbBard2.Visible = !pbBard2.Visible;

            //Berserker animation
            pbBerserker2.Visible = !pbBerserker2.Visible;
            pbBerserker1.Visible = !pbBerserker1.Visible;

            //Sorcerer animation
            pbSorcerer1.Visible = !pbSorcerer1.Visible;
            pbSorcerer2.Visible = !pbSorcerer2.Visible;

            //Ranger animation
            pbRanger1.Visible = !pbRanger1.Visible;
            pbRanger2.Visible = !pbRanger2.Visible;

            //Assassin animation
            pbAssassin1.Visible = !pbAssassin1.Visible;
            pbAssassin2.Visible = !pbAssassin2.Visible;

            //Vanguard animation
            pbVanguard1.Visible = !pbVanguard1.Visible;
            pbVanguard2.Visible = !pbVanguard2.Visible;
        }

    }
}
