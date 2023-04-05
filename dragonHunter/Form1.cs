//Gabe Emms
//ICS3U
//Mr.T

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dragonHunter
{
    public partial class Form1 : Form
    {
        // Tracks what page of the story the user is at
        int page = 1;
        Random randGen = new Random();
        int randomVal;

    
        public Form1()
        {
            InitializeComponent();
            // Display initial message and options
            outputLabel.Text = "Welcome to Dragon Hunter";
            option1Button.Text = "";
            option3Button.Text = "";
            option2Button.Text = "Start";
        }

        private void option1Button_Click(object sender, EventArgs e)
        // Depending on the current page, update the page number to a new value
        {
            if (page == 1)
            {
                page = 99;
            }
            else if (page == 2)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 99;
            }
            else if (page == 5)
            {
                page = 11;
            }
            else if (page == 11)
            {
                page = 99;
            }
            else if (page == 7)
            {
                page = 5;
            }
            else if (page == 6)
            {
                page = 5;
            }
            else if (page == 10)
            {
                page = 99;
            }
            else if (page == 9)
            {
                page = 99;
            }

            else if (page == 8)
            {
                page = 99;
            }
            else if (page == 13)
            {
                page = 8;
            }
            else if (page == 99 || page == 98)
            {
                page = 1;
            }

            switchStatement(); // Call the switchStatement() method to update the display based on the new page number
        }

        private void option2Button_Click(object sender, EventArgs e)
        // Depending on the current page, update the page number to a new value
        {

            if (page == 1)
            {
                page = 2;
            }


            else if (page == 2)
            {
                page = 6;

            }
            else if (page == 3)
            {
                page = 2;
            }
            else if (page == 11)
            {
                page = 9;

            }
            else if (page == 6)
            { 
                page = 2;
            }
            else if (page == 9)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 13;
            }

            else if (page == 13)
            {
                page = 10;
            }
            else if (page == 5)
            {
                page = 10;
            }



            else if (page == 99 || page == 98)
            {
                page = 1;
            }


            
            switchStatement(); // Call the switchStatement() method to update the display based
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            if (page == 5)
            {
                page = 6;
            }
            else if (page == 7)
            {
                page = 99;
            }
            else if (page == 99 || page == 98)
            {
                page = 1;
            }
            else if (page == 11)
            {
                page = 99;
            }

                switchStatement(); // Call the switchStatement() method to update the display based
        }

        void switchStatement()
            {
                switch (page)
                {
                // If page == 1, display a welcome message and two options
                case 1:
                        outputLabel.Text = "Welcome to Dragon Hunter! Would you like to wear diamond armor or chain mail armor?";
                        option1Button.Text = "Diamond Armor";
                        option2Button.Text = "Chain Mail Armor";
                        option3Button.Text = "";
                    this.BackgroundImage = Properties.Resources.knight;
                        break;
                    case 2:
                    // If page == 2, display a message and two options
                    outputLabel.Text = "Great choice! Go to the cave or the valley?";
                        option1Button.Text = "Cave";
                        option2Button.Text = "Valley";
                        option3Button.Text = "";
                    this.BackgroundImage = Properties.Resources.cave_valley;
                        break;
                    case 3:
                    // If page == 3, display a message and two options
                    outputLabel.Text = "Welcome to the cave. You encounter a dragon! Would you like to fight or retreat?";
                        option1Button.Text = "Fight";
                        option2Button.Text = "Retreat";
                        option3Button.Text = "";
                    this.BackgroundImage = Properties.Resources.cave;
                    break;
                    case 4:
                    // If page == 4, display a message and two options
                    outputLabel.Text = "You ecnounter a dragon!";
                        option1Button.Text = "Attack the dragon";
                        option2Button.Text = "Retreat";
                        option3Button.Text = "";
                    this.BackgroundImage = Properties.Resources.encounter_dragon;
                    break;
                    case 5:
                    // If page == 5, display a message and two options
                    outputLabel.Text = "You killed the dragon! You’re hungry after the fight. Would you like to eat part of the dragon or the wild berries?”";
                        option1Button.Text = "Dragon";
                        option2Button.Text = "Berries";
                        option3Button.Text = "";
                    this.BackgroundImage = Properties.Resources.berries_or_dragon;
                        break;
                    case 6:
                    // If page == 6, display a message and two options
                    outputLabel.Text = "Welcome to the valley";
                        outputLabel.Text = "You encounter a dragon. Fight or retreat?";
                        option1Button.Text = "Fight";
                        option2Button.Text = "Retreat";
                        option3Button.Text = "";
                    this.BackgroundImage = Properties.Resources.encounter_dragon;
                        break;
                    case 7:
                    // If page == 7, display a message and one option
                    outputLabel.Text = "You killed the dragon";
                        option1Button.Text = "Continue";
                        option2Button.Text = "";
                        option3Button.Text = "";
                    this.BackgroundImage = Properties.Resources.killed_dragon;
                        break;
                    case 8:
                    // If page == 8, randomly determine whether the player has defeated the final dragon, and display a message and two options accordingly
                    randomVal = randGen.Next(1, 101);
                    
                    if (randomVal >= 50)
                        {
                            outputLabel.Text = "Congratulations, you have defeated the final dragon! Would you like to play again?";
                            option1Button.Text = "Yes";
                            option2Button.Text = "No";
                            option3Button.Text = "";
                        this.BackgroundImage = Properties.Resources.You_Win;
                        page = 98;
                        }
                        else
                        {
                            outputLabel.Text = "The dragon is too powerful and you die. Would you like to play again?";
                            option1Button.Text = "Yes";
                            option2Button.Text = "No";
                            option3Button.Text = "";
                        this.BackgroundImage = Properties.Resources.download__1_;
                        page = 99;
                        }
                        break;

                    case 9:
                    // If page == 9, display a message and one option
                    outputLabel.Text = "You have entered the prison. Free the prisoners?";
                        option1Button.Text = "Free them";
                        option2Button.Text = "Leave them";
                        option3Button.Text = "";
                    this.BackgroundImage = Properties.Resources.prison;
                        break;
                    case 10:
                    // If page == 10, display a message and one option
                    outputLabel.Text = "That was a close one! Go through the prison tunnel or window";
                        option1Button.Text = "Tunnel";
                        option2Button.Text = "Window";
                        option3Button.Text = "";
                    this.BackgroundImage = Properties.Resources.Tunnel_Window;
                        break;
                    case 11:
                    // If page == 11, display a message and one option
                    outputLabel.Text = "Great option! Dragons are good for you. You encounter 3 doors, which one do you pick?";
                        option1Button.Text = "Door 1";
                        option2Button.Text = "Door 2";
                        option3Button.Text = "Door 3";
                    this.BackgroundImage = Properties.Resources._3_Doors;
                        break;
                  
                case 13:
                    // If page == 13 display a message and one option
                    outputLabel.Text = "You ecnounter the final dragon!";
                    option1Button.Text = "Attack";
                    option2Button.Text = "Retreat";
                    option3Button.Text = "";
                    this.BackgroundImage = Properties.Resources.Final_Dragon;
                    break;


                case 98:
                    //If page == 98 display the message and display the user has one
                        outputLabel.Text = "Congratulations you have won! Would you like to play again?";
                        option1Button.Text = "Yes";
                        option2Button.Text = "No";
                        option3Button.Text = "";
                    this.BackgroundImage = Properties.Resources.You_Win;
                        break;
                    case 99:

                    //If page == 98 display the message and display the user has lost
                    outputLabel.Text = "You died! Would you like to play again?";
                        option1Button.Text = "Yes";
                        option2Button.Text = "No";
                        option3Button.Text = "";
                    this.BackgroundImage = Properties.Resources.download__1_;
                    break;






                }


            }
        }
    }


