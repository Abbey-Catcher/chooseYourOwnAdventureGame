using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace chooseYourOwnAdventureGame
{
    public partial class chooseYourOwnAdventureGame : Form
    {
        int page = 1;
        Random randGen = new Random();
        int bat = 0;

        public chooseYourOwnAdventureGame()
        {
            InitializeComponent();

            // Display initial message and options
            DisplayPage();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            //End otions: Button says next, then goes to page 97 or 98
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 98;
            }
            else if (page == 4)
            {
                int bat = 1;
                page = 5;
            }
            else if (page == 5 || page == 6)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 10;
            }
            else if (page == 9)
            {
                //checks for bat
                //has bat = page 12
                if (bat == 1)
                {
                    page = 12;
                }
                //doesn't have bat = page 13
                else
                {
                    page = 13;
                }
            }
            else if (page == 10)
            {
                page = 97;
            }
            else if (page == 11)
            {
                //checks for bat
                //has bat = page 20
                if (bat == 1)
                {
                    page = 20;
                }
                //doesn't have bat = page 21
                else
                {
                    page = 21;
                }
            }
            else if (page == 12)
            {
                page = 97;
            }
            else if (page == 13)
            {
                page = 98;
            }
            else if (page == 14)
            {
                page = 97;
            }
            else if (page == 15)
            {
                page = 18;
            }
            else if (page == 16)
            {
                page = 98;
            }
            else if (page == 17)
            {
                page = 97;
            }
            else if (page == 18)
            {
                page = 98;
            }
            else if (page == 19)
            {
                //brings back to options from page 9

                //checks for bat
                //has bat = page 12
                if (bat == 1)
                {
                    page = 12;
                }
                //doesn't have bat = page 13
                else
                {
                    page = 13;
                }
            }
            else if (page == 20)
            {
                page = 97;
            }
            else if (page == 21)
            {
                page = 98;
            }
            else if (page == 22)
            {
                page = 97;
            }
            else if (page == 23)
            {
                page = 25;
            }
            else if (page == 24)
            {
                page = 27;
            }
            else if (page == 25)
            {
                page = 29;
            }
            else if (page == 26)
            {
                page = 98;
            }
            else if (page == 27)
            {
                page = 98;
            }
            else if (page == 28)
            {
                page = 97;
            }
            else if (page == 29)
            {
                int chance = randGen.Next(1, 21);
                //65% chance they win
                //win = page 31
                if (chance <= 13)
                {
                    page = 31;
                }
                //lose = 32
                else
                {
                    page = 32;
                }
            }
            else if (page == 30)
            {
                page = 97;
            }
            else if (page == 31)
            {
                page = 97;
            }
            else if (page == 32)
            {
                page = 98;
            }
            else if (page == 97 || page == 98)
            {
                page = 1;
            }
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                int chance = randGen.Next(1, 3);
                //50% chance they pick up
                //picks up = page 23
                if (chance == 1)
                {
                    page = 23;
                }
                //doesn't pick up = page 24
                else
                {
                    page = 24;
                }
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 6;
            }
            else if (page == 7)
            {
                page = 9;
            }
            else if (page == 8)
            {
                page = 11;
            }
            else if (page == 9)
            {
                //checks for bat
                //has bat = page 17
                if (bat == 1)
                {
                    page = 17;
                }
                //doesn't have bat = page 16
                else
                {
                    page = 16;
                }
            }
            else if (page == 11)
            {
                page = 22;
            }
            else if (page == 15)
            {
                page = 19;
            }
            else if (page == 23)
            {
                page = 26;
            }
            else if (page == 24)
            {
                page = 28;
            }
            else if (page == 25)
            {
                page = 30;
            }
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            if (page == 9 || page == 19)
            {
                int chance = randGen.Next(1, 5);
                //75% chance someone answers
                //they don't = page 15
                if (chance == 4)
                {
                    page = 15;
                }
                //they do = page 14
                else
                {
                    page = 14;
                }
            }
        }

        public void DisplayPage()
        {
            outputLabel.Text = "You are walking through a park at dawn. You see a sketchy guy and notice he begins to follow you.";
            option1Label.Text = "Speed up";
            option2Label.Text = "Call a friend";

            switch (page)
            {
                case 1:
                    outputLabel.Text = "You are walking through a park at dawn. You see a sketchy guy and notice he begins to follow you.";
                    option1Label.Text = "Speed up";
                    option2Label.Text = "Call a friend";
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                case 21:
                    break;
                case 22:
                    break;
                case 23:
                    break;
                case 24:
                    break;
                case 25:
                    break;
                case 26:
                    break;
                case 27:
                    break;
                case 28:
                    break;
                case 29:
                    break;
                case 30:
                    break;
                case 31:
                    break;
                case 32:
                    break;
                case 97:
                    break;
                case 98:
                    break;
                case 99:
                    break;
            }
        }
    }
}
