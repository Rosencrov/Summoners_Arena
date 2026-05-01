using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp5
{
    internal class Skills
    {
        public int Hearts1 = 0;
        public int Hearts2 = 0;
        public int Accuracy;
        public int Damage;
        public int Hit = 1;

        public int Stomp() //Character jumps and slams the ground
        {
            Random rnd = new Random();

            Damage = rnd.Next(2, 4);

            Accuracy = rnd.Next(1,101);

            if (Accuracy <= 90)
            {
                Damage = Damage * Hit;
                Hit = 1;
                return Damage;
            }

            else
            {
                Damage = 0 * Hit;
                Hit = 1;
                return Damage;
            }

        }

        public int Meditate() //Yellow auro comes out of the character
        {
            Random rnd = new Random();

            Accuracy = rnd.Next(1, 101);

            if(Accuracy <= 80)
            {
                Hit = 0;
                return Hit;
            }

            else
            {
                Hit = 1;
                return Hit;
            }

        }

        public int QuickAttack() //Don't know tha animation yet
        {
            Random rnd = new Random();

            Damage = rnd.Next(1, 5);

            if(Damage <= 3)
            {
                Accuracy = rnd.Next(1, 101);

                if(Accuracy <= 80)
                {
                    Damage = Damage * Hit;
                    Hit = 1;
                    return Damage;
                }

                else
                {
                    Damage = 0 * Hit;
                    Hit = 1;
                    return Damage;
                }
            }

            if(Damage == 4)
            {
                Accuracy = rnd.Next(1, 101);

                if (Accuracy <= 70)
                {
                    Damage = Damage * Hit;
                    Hit = 1;
                    return Damage;
                }

                else
                {
                    Damage = 0 * Hit;
                    Hit = 1;
                    return Damage;
                }
            }

            else
            {
                return 0;
            }
        }

        public int Heal() //Green light descends upon the character
        {
            Random rnd = new Random(); //Disable this button after using

            Damage = rnd.Next(2, 6);
            Damage = Damage * Hit;
            Damage = Damage * -1;
            Hit = 1;

            return Damage;
        }

        public int PanThrow() //Throws a frying pan
        {
            Random rnd = new Random();

            int Dmg = rnd.Next(1, 3);

            if(Dmg == 1)
            {
                Damage = rnd.Next(2, 4);
                Accuracy = rnd.Next(1, 101);

                if(Accuracy <= 80)
                {
                    Damage = Damage * Hit;
                    Hit = 1;

                    return Damage;
                }

                else
                {
                    Damage = 0 * Hit;
                    Hit = 1;
                    return Damage;
                }
            }

            else
            {
                Damage = 10;
                Accuracy = rnd.Next(1, 101);

                if(Accuracy <= 30)
                {
                    Damage = Damage * Hit;
                    Hit = 1;

                    return Damage;
                }

                else
                {
                    Damage = 0 * Hit;
                    Hit = 1;

                    return Damage;
                }
            }
        }

        //Bard
        public int Rhapsody()
        {
            Random rnd = new Random();

            Damage = 2;
            Accuracy = rnd.Next(1, 101);

            if(Accuracy <= 50)
            {
                Damage = Damage * Hit;
                Hit = 1;

                return Damage;
            }

            else
            {
                Damage = 0 * Hit;
                Hit = 1;

                return Damage;
            }
        }

        public int Rhapsody1() //Put this in the same button as Rhapsody but after it
        {
            Hit = 0;
            return Hit; //This will only guarantee one miss, it need to be two
        }

        public int Rondo()
        {
            Random rnd = new Random();
            Damage = 1;
            int mult = 0;
            Accuracy = rnd.Next(1, 101);

            if (Accuracy <= 80)
            {
                //first phase
                mult = rnd.Next(1, 3);
                Damage = Damage * mult;
                MessageBox.Show("Phase 1: The damage is multiplied by " + mult);
                //second phase
                mult = rnd.Next(2, 4);
                Damage = Damage * mult;
                MessageBox.Show("Phase 2: The damage is multiplied by " + mult);
                //third phase
                Damage = Damage * Hit;
                Hit = 1;
                MessageBox.Show("Phase 3: Rondo will deal " + Damage + " damage");

                return Damage;
            }

            else
            {
                Damage = 0 * Hit;
                Hit = 1;

                return Damage;
            }
        }


        //Berserker
        //Passive: Chance of multi-casting skill (put skills twice in the button with randomizer)
        public int Ragnarok() //sways weapon that deal 3, 6 or 9 herts of damage and reflects 1/3 of the damage dealt
        {
            Random rnd = new Random();
            int select;
            Accuracy = rnd.Next(1, 101);

            if (Accuracy <= 80)
            {
                select = rnd.Next(1, 7);

                if(select == 1 || select == 3)
                {
                    Damage = 3 * Hit;
                    Hit = 1;

                    return Damage;
                }

                else if(select == 2 || select == 4)
                {
                    Damage = 6 * Hit;
                    Hit = 1;

                    return Damage;
                }

                else
                {
                    Damage = 9 * Hit;
                    Hit = 1;

                    return Damage;
                }
            }

            else
            {
                Damage = 0 * Hit;
                Hit = 1;

                return Damage;
            }
        }

        public int Ragnarok1()//This is the reflected damage, cast this to the player
        {
            Damage = Damage / 3;
            Damage = Damage * Hit;
            Hit = 1;

            return Damage;
        }

        public int SliceAndDice()//Slashes the two weapons dealing 1-4 hearts each with 80% accuracy
        {
            Random rnd = new Random();
            Damage = rnd.Next(1, 5);
            Accuracy = rnd.Next(1, 101);

            if (Accuracy <= 80) //use this skill twice in the same button
            {
                Damage = Damage * Hit;
                Hit = 1;

                return Damage;
            }

            else
            {
                Damage = 0 * Hit;
                Hit = 1;

                return Damage;
            }
        }

        //Sorcerer
        //Has a 25% chance of healing yourself 2 hearts and the enemy 1 heart
        public int Enchant() //Has a 40% chance of doubling the damage of your next skill and another 50% to deal 2 hearts of damage
        {
            //Put this code in the botton
            Random rnd = new Random();
            Damage = 2;
            Hit = 1;
            Accuracy = rnd.Next(1, 101);

            if (Accuracy <= 50) //This is the damage
            {
                Damage = Damage * Hit;
                Hit = 1;

                return Damage;
            }
            else
            {
                Damage = 0 * Hit;
                Hit = 1;

                return Damage;
            }

        }

        public int Enchant1()//Multiplier
        {
            Random rnd = new Random();
            int Accuracy1 = rnd.Next(1, 101);

            if (Accuracy1 <= 40) //This is the damage multiplier
            {
                MessageBox.Show("Next ability's damage will be doubled");
                Hit = 2;

                return Hit;
            }
            else
            {
                MessageBox.Show("Enchantment failed");
                Hit = 1;

                return Hit;
            }
        }

        public int Conjure() //Summons a golem that slams the ground that has a 70% chance of dealing 8 hearts of damage to enemy and 20% of hitting you too
        {
            Random rnd = new Random(); //Put this in the button too

            Damage = 8;
            Accuracy = rnd.Next(1, 101);

            if (Accuracy <= 70)
            {
                Damage = Damage * Hit;
                Hit = 1;

                return Damage;
            }
            else
            {
                Damage = 0 * Hit;
                Hit = 1;

                return Damage;
            }
        }

        public int Conjure1()//return damage to player
        {
            if(Accuracy <= 20)
            {
                MessageBox.Show("Ooops! the impact damaged you too");
                Damage = Damage * Hit;
                Hit = 1;
                
                return Damage;
            }

            else
            {
                Damage = 0 * Hit;
                Hit = 1;

                return Damage;
            }
        }


        //Ranger
        public int HawkShot()//Can only be used twice
        {
            Random rnd = new Random();//Put this in the button

            Damage = 15;

            Accuracy = rnd.Next(1, 101);

            if(Accuracy <= 40)
            {
                Damage = Damage * Hit;
                Hit = 1;

                return Damage;
            }

            else
            {
                Damage = 0 * Hit;
                Hit = 1;

                return Damage;
            }
        }

        public int Strafe()
        {
            Random rnd = new Random();

            Damage = 1;
            Accuracy = rnd.Next(1, 7);
            Damage = Damage * Hit;
            Damage = Damage * Accuracy;
            Hit = 1;

            return Damage;
        }

        //Assassin
        //only has 75% hearts but has a 50% chance of applying 1-3 hearts
        public int UmbralStrike()
        {
            Random rnd = new Random();

            Accuracy = rnd.Next(1, 101);
            int Accuracy1 = rnd.Next(1, 101);

            if(Accuracy1 <= 40)//Front
            {
                Damage = 3 * Hit;
                Hit = 1;
            }

            else//Back
            {
                Damage = 5 * Hit;
                Hit = 1;
            }

            if (Accuracy <= 80)
            {
                return Damage;
            }

            else
            {
                Damage = 0 * Hit;
                Hit = 1;

                return Damage;
            }
        }

        public int QuickSlash()
        {
            Random rnd = new Random();

            int select = rnd.Next(1, 3);

            if(select == 1)
            {
                Damage = 6;
                Accuracy = rnd.Next(1, 101);

                if(Accuracy <= 75)
                {
                    Damage = Damage * Hit;
                    Hit = 1;

                    return Damage;
                }

                else
                {
                    Damage = 0 * Hit;
                    Hit = 1;

                    return Damage;
                }
            }

            else
            {
                Damage = 2 * Hit;
                Hit = 1;

                return Damage;
            }
        }

        //Vanguard
        //Has 160% hearts
        public int Bash()//Club
        {
            Random rnd = new Random();
            Accuracy = rnd.Next(1, 101);
            
            if(Accuracy <= 60)
            {
                Damage = 3;

                Damage = Damage * Hit;
                Hit = 1;

                return Damage;
            }

            else
            {
                Damage = 2;

                Damage = Damage * Hit;
                Hit = 1;

                return Damage;
            }
        }

        public int Brauming()//sways shield
        {
            Random rnd = new Random();
            int select = rnd.Next(1, 101);

            if(select <= 60)
            {
                Damage = 4;

                Damage = Damage * Hit;
                Hit = 1;

                return Damage;
            }

            else
            {
                Damage = 1;

                Damage = Damage * Hit;
                Hit = 1;

                return Damage;
            }
        }








    }
}
