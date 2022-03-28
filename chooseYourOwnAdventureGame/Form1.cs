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
                    outputLabel.Text = "You are about to reach your street.";
                    option1Label.Text = "Turn onto your street";
                    option2Label.Text = "Keep going";
                    break;
                case 3:
                    outputLabel.Text = "You almost make it home but the sketchy guy catches up. You never end up making it home safely.";
                    option1Label.Text = "Next";
                    option2Label.Text = "";
                    option2Label.Visible = false;
                    option2Label.Enabled = false;
                    break;
                case 4:
                    outputLabel.Text = "On your way down the street, you pass a house with a baseball bat sitting on the front porch. Do you take it?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 5:
                    outputLabel.Text = "You now have a baseball bat. You continue on down the road. You have now reached the end of the road.";
                    option1Label.Text = "Next";
                    option2Label.Text = "";
                    option2Label.Visible = false;
                    option2Label.Enabled = false;
                    break;
                case 6:
                    outputLabel.Text = "You decide to carry on without the baseball bat. You reach the end of the road.";
                    option1Label.Text = "Next";
                    option2Label.Text = "";
                    option2Label.Visible = false;
                    option2Label.Enabled = false;
                    break;
                case 7:
                    outputLabel.Text = "The road on the right has a lot of houses. The road on the left looks empty while beginning to lead out of town.";
                    option1Label.Text = "Left";
                    option2Label.Text = "Right";
                    break;
                case 8:
                    outputLabel.Text = "You take the empty road beginning to lead out of town. The guy gives up following you and turns around.";
                    option1Label.Text = "Continue down that road";
                    option2Label.Text = "Turn to go back home";
                    break;
                case 9:
                    outputLabel.Text = "You turn right. You walk down the road until you realize the end of this street is a dead end.";
                    option3Button.Visible = true;
                    option3Button.Enabled = true;
                    option1Label.Text = "Try to run past";
                    option2Label.Text = "Attack!!";
                    option3Label.Text = "Knock on a stranger's door";
                    break;
                case 10:
                    outputLabel.Text = "You continue down the road a little longer. You eventually turn down a road to go back home once you feel it's safe.";
                    option1Label.Text = "Next";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option2Button.Visible = false;
                    option2Button.Enabled = false;
                    option3Button.Visible = false;
                    option3Button.Enabled = false;
                    break;
                case 11:
                    outputLabel.Text = "You decide to turn back to try and make it home faster. You end up running into the sketchy guy again.";
                    option1Label.Text = "Try to run past";
                    option2Label.Text = "Run back the other way";
                    break;
                case 12:
                    outputLabel.Text = "Your follower tries to take the chance to grab a hold of you. You use the bat to get away. You make it home safely.";
                    option1Label.Text = "Next";
                    option2Label.Text = "";
                    option2Button.Visible = false;
                    option2Button.Enabled = false;
                    break;
                case 13:
                    outputLabel.Text = "As you try and run past, your follower takes the chance to grab a hold of you. You try to fight him off but fail. You don't make it home.";
                    option1Label.Text = "Next";
                    option2Label.Text = "";
                    option2Button.Visible = false;
                    option2Button.Enabled = false;
                    break;
                case 14:
                    outputLabel.Text = "You tell them that someone is following you and you need help. They decide to help you out. You pretend like you are good friends and they invite you inside until it's safe to go home or a ride shows up. You end up making it home safely";
                    option1Label.Text = "Next";
                    option2Label.Text = "";
                    option2Button.Visible = false;
                    option2Button.Enabled = false;
                    break;
                case 15:
                    outputLabel.Text = "You knock on the door and wait a couple seconds. You don't hear any movement. If you wait any longer, you could be in trouble.";
                    option1Label.Text = "Knock again";
                    option2Label.Text = "Leave";
                    break;
                case 16:
                    outputLabel.Text = "You lunge forward to attack your follower. You land a couple punches but not enough to win the fight. You don't make it home.";
                    option1Label.Text = "Next";
                    option2Label.Text = "";
                    option2Button.Visible = false;
                    option2Button.Enabled = false;
                    break;
                case 17:
                    outputLabel.Text = "You use the bat to attack your follower. You knock him down long enough to get away. You make it home safely.";
                    option1Label.Text = "Next";
                    option2Label.Text = "";
                    option2Button.Visible = false;
                    option2Button.Enabled = false;
                    break;
                case 18:
                    outputLabel.Text = "There is still no answer at the door. Your follower caught up to you. You didn't make it home.";
                    option1Label.Text = "Next";
                    option2Label.Text = "";
                    option2Button.Visible = false;
                    option2Button.Enabled = false;
                    break;
                case 19:
                    outputLabel.Text = "You decide to leave.";
                    option3Button.Visible = true;
                    option3Button.Enabled = true;
                    option1Label.Text = "Run past";
                    option2Label.Text = "Attack!!";
                    option3Label.Text = "Knock on a stranger's door";
                    break;
                case 20:
                    outputLabel.Text = "You run in the direction of the strange guy. Because you have the bat, you use it to defend yourself. You run the rest of the way home and you make it home safely.";
                    option1Label.Text = "Next";
                    option2Label.Text = "";
                    option2Button.Visible = false;
                    option2Button.Enabled = false;
                    break;
                case 21:
                    outputLabel.Text = "You try to run past him but you don't have the bat. He grabs a hold of you and you don't make it home.";
                    option1Label.Text = "Next";
                    option2Label.Text = "";
                    option2Button.Visible = false;
                    option2Button.Enabled = false;
                    break;
                case 22:
                    outputLabel.Text = "You make a run for it in the opposite direction. Lucky, he didn't notice you and you make it away. You make it home safely.";
                    option1Label.Text = "Next";
                    option2Label.Text = "";
                    option2Button.Visible = false;
                    option2Button.Enabled = false;
                    break;
                case 23:
                    outputLabel.Text = "They pick up. You tell them what's going on.";
                    option1Label.Text = "Ask them to pick you up";
                    option2Label.Text = "Ask them to stay on the phone until you get to safety";
                    break;
                case 24:
                    outputLabel.Text = "They don't pick up.";
                    option1Label.Text = "Call again";
                    option2Label.Text = "Try someone else";
                    break;
                case 25:
                    outputLabel.Text = "You ask your friend if they can pick you up. They go to ask their parents if they can pick you up. They say they can't";
                    option1Label.Text = "Confront";
                    option2Label.Text = "Find help";
                    break;
                case 26:
                    outputLabel.Text = "You ask your friend to stay on the phone. They say they can stay on the phone for as long as you need. You thank them and carry on your way. They begin to ask where you are but then your phone dies! You are now on your own. You continue on your way home. Without help from your friend, you start panicking, not knowing what to do and he ends up catching up to you. You don't make it home.";
                    option1Label.Text = "Next";
                    option2Label.Text = "";
                    option2Button.Visible = false;
                    option2Button.Enabled = false;
                    break;
                case 27:
                    outputLabel.Text = "You try to call again but no one answers. Without help, you start to panic, trying to think of what to do. You just try to get home but the guy catches up to you and you don't make it home.";
                    option1Label.Text = "Next";
                    option2Label.Text = "";
                    option2Button.Visible = false;
                    option2Button.Enabled = false;
                    break;
                case 28:
                    outputLabel.Text = "You try to call someone else. They pick up and you tell them what's going on and ask if they can pick you up a couple streets down from where you are. They say they can meet you there in a couple minutes. Thanks to your friend, you make it home safely";
                    option1Label.Text = "Next";
                    option2Label.Text = "";
                    option2Button.Visible = false;
                    option2Button.Enabled = false;
                    break;
                case 29:
                    outputLabel.Text = "You decide to confront them. You walk closer to him, making a fist with your hands, getting ready for a fight.";
                    option1Label.Text = "Next";
                    option2Label.Text = "";
                    option2Button.Visible = false;
                    option2Button.Enabled = false;
                    break;
                case 30:
                    outputLabel.Text = "You decide to go find help. You go up to a random house and knock on the door. They answer and ask what you want. You tell them that you need help because a strange guy is following you. They are generous enough to let you come inside until safety arrives. You make it home safely thanks to the generous person.";
                    option1Label.Text = "Next";
                    option2Label.Text = "";
                    option2Button.Visible = false;
                    option2Button.Enabled = false;
                    break;
                case 31:
                    outputLabel.Text = "You win the fight and knock him out. You make it home safely.";
                    option1Label.Text = "Next";
                    option2Label.Text = "";
                    option2Button.Visible = false;
                    option2Button.Enabled = false;
                    break;
                case 32:
                    outputLabel.Text = "You don't win the fight and don't make it home safely.";
                    option1Label.Text = "Next";
                    option2Label.Text = "";
                    option2Button.Visible = false;
                    option2Button.Enabled = false;
                    break;
                case 97:
                    outputLabel.Text = "You got a good ending. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 98:
                    outputLabel.Text = "You got a bad ending. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 99:
                    outputLabel.Text = "Thanks for playing!";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option1Button.Visible = false;
                    option1Button.Enabled = false;
                    option2Button.Visible = false;
                    option2Button.Enabled = false;
                    option3Button.Visible = false;
                    option3Button.Enabled = false;
                    break;
            }
        }
    }
}
