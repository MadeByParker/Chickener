using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Game : Form
    {

        int xspeed = 10;
        int yspeed = 10;
        int enemyYpos = -10;
        int counter = 0;
        int xpos;
        int xpos2;
        int xpos3;
        int xpos4;
        int xpos5;
        int[] xposition = { 255, 370, 555, 680, 865, 990, 1185, 1305, 1495, 1615 }; //array for car positions
        int restartcounter = 20;
        int eggcheck;
        public Game()
        {

            InitializeComponent();
            WindowState = FormWindowState.Maximized; //to make the client maximised on launch
            ClientSize = new Size(1920, 1080);
            int i = ClientRectangle.Height;
            character.Left = 10; //to determine the character's x position
            int r = ClientRectangle.Right;
            character.Top = ((i / 2) - 34); //this is the value to check if its > than the Client Height so it doesn't go off screen
            Random rnd = new Random(); //variable to randomise the car's lanes
            messagebox.Text = "Pick up the basket!";
            void objectxpos() //function for generating the 5 cars x positions
            {
                xpos = xposition[rnd.Next(0, 2)]; //each car has 2 lanes to be decided from
                xpos2 = xposition[rnd.Next(2, 4)];
                xpos3 = xposition[(rnd.Next(4, 6))];
                xpos4 = xposition[rnd.Next(6, 8)];
                xpos5 = xposition[rnd.Next(8, 10)];
                fastcar.Left = xpos5;
                fastcar.Top = enemyYpos;
                redcar.Left = xpos2;
                redcar.Top = enemyYpos;
                greencar.Left = xpos3;
                greencar.Top = enemyYpos;
                purplecar.Left = xpos4;
                purplecar.Top = enemyYpos;
                yellowcar.Left = xpos;
                yellowcar.Top = enemyYpos;
            }
            objectxpos();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) //this is for the controls 
        {
            void moveup()
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W) //if the W or up arrow key is pressed down then the character will move up
                {
                    character.Top = character.Top - yspeed;
                }
            }
            void movedown()
            {
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S) //if the S or down arrow key is pressed down then the character will move down
                {
                    character.Top = character.Top + yspeed;
                }
            }
            void barriers()
            {
                if (character.Left <= 0) //if character hits the left border then it doesn't go off the screen, it'll just bounce off it
                {
                    character.Left = character.Left + 10;
                    counter = counter - 1;
                }
                if (character.Top <= 0)
                {
                    character.Top = character.Top + yspeed;
                }
                if (character.Top > ClientRectangle.Height - character.Height)
                {
                    character.Top = character.Top - yspeed;
                }
                if (character.Left >= ClientRectangle.Width - 75)
                {
                    character.Left = character.Left - xspeed;
                    counter = counter - 1;
                }
            }
            void movehorizontal()
            {
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) //if the D or right arrow key is pressed down then the character will move right and gain points
                {
                    character.Left = character.Left + xspeed;
                    counter = counter + 1;
                    score.Text = counter.ToString();
                }
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) //if the A or left arrow key is pressed down then the character will move left
                {
                    character.Left = character.Left - xspeed;
                }
            }
            void moveopphorizontal()
            {
                
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) // and vice-versa, this time if the character moves left then it gains points rather than right (this is for returning to the house)
                {
                    character.Left = character.Left + xspeed;
                }
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                {
                    character.Left = character.Left - xspeed;
                    counter = counter + 1;
                    score.Text = counter.ToString();
                }
            }


            moveup();
            movedown();
            movehorizontal();
            barriers();

            
            if (character.Bounds.IntersectsWith(egg1.Bounds)) //when the character collects the egg then this will happen
            {
                eggcheck = 1; //this is the variable which stops the game from winning without the egg
                messagebox.Text = ("Go back to drop the egg in the safehouse!"); //updates the text box in the bottom-left corner
                character.Image = Image.FromFile(Application.StartupPath + "\\chickwithegg.png"); //updates the picture
                character.Image.RotateFlip(RotateFlipType.RotateNoneFlipX); // flips it horizontally so it's facig left 
                egg1.Visible = false; //makes the egg invisible
                
                if (messagebox.Text == ("Go back to drop the egg in the safehouse!")) //this will update the scoring depending on if the chicken has the egg or not
                {
                    moveopphorizontal();

                }
                else
                {
                    movehorizontal();
                }
            }
            
            void eggdrop() //when the chicken reaches the house
            {
                if (eggcheck == 1) //saying if the character has the egg then it detects that they have won or else just carry on
                {
                    if (character.Bounds.IntersectsWith(home.Bounds))
                    {
                        egg1.Size = new Size(50, 50); //changes size and location of the egg
                        egg1.Location = new Point(139, 203);
                        messagebox.Text = "You Won!";
                        character.Image = Image.FromFile(Application.StartupPath + "\\chickwithbasket.png");
                        var formWin = new Win(); //starts the relaunch process
                        formWin.Show();
                        this.Hide();
                    }
                }
                else
                {

                }
            }
            eggdrop();

        }   

        private void Form1_Load(object sender, EventArgs e)
        {
            
            void basketpickup() //when the character collects the basket
            {
                if(character.Bounds.IntersectsWith(basket.Bounds))
                {
                    character.Image = Image.FromFile(Application.StartupPath + "\\chickwithbasket.png"); //updates to a chicken with a basket on its back
                    character.Size = new Size(125, 100);//updates the hitbox of the character
                    basket.Hide();//hides the basket so this function doesn't happen again
                    messagebox.Text = "Grab the egg!"; //updates the hint
                }
            }
            basketpickup();
            
            
            void collison()//if character hits a car then it launches the maths client page
            {
                if (character.Bounds.IntersectsWith(fastcar.Bounds))
                {
                    character.Left = 10;
                    var formM = new Maths();
                    formM.Show();
                    this.Hide();
                }
                if (character.Bounds.IntersectsWith(redcar.Bounds))
                {
                    character.Left = 10;
                    var formM = new Maths();
                    formM.Show();
                    this.Hide();
                }
                if (character.Bounds.IntersectsWith(greencar.Bounds))
                {
                    character.Left = 10;
                    var formM = new Maths();
                    formM.Show();
                    this.Hide();
                }
                if (character.Bounds.IntersectsWith(purplecar.Bounds))
                {
                    character.Left = 10;
                    var formM = new Maths();
                    formM.Show();
                    this.Hide();
                }
                if (character.Bounds.IntersectsWith(yellowcar.Bounds))
                {
                    character.Left = 10;
                    var formM = new Maths();
                    formM.Show();
                    this.Hide();

                }
            }
            void resetpos() //when the car goes of the page, it resets itself at the top and in a new lane based on RNG
                {
                    if (fastcar.Top >= ClientRectangle.Height)
                    {
                        fastcar.Top = enemyYpos;
                        Random x2 = new Random();
                        xpos5 = xposition[x2.Next(8, 10)];
                        fastcar.Left = xpos5;
                    }
                    else
                    {
                        fastcar.Top = fastcar.Top + 50;
                    }
                    if (redcar.Top >= ClientRectangle.Height)
                    {
                        redcar.Top = enemyYpos;
                        Random x2 = new Random();
                        xpos2 = xposition[x2.Next(2, 4)];
                        redcar.Left = xpos2;
                    }
                    else
                    {
                        redcar.Top = redcar.Top + 15;
                    }
                        if (greencar.Top >= ClientRectangle.Height)
                    {
                        greencar.Top = enemyYpos;
                        Random x2 = new Random();
                        xpos3 = xposition[x2.Next(4, 6)];
                        greencar.Left = xpos3;
                    }
                    else
                    {
                        greencar.Top = greencar.Top + 25;
                    }
                    if (purplecar.Top >= ClientRectangle.Height)
                    {
                        purplecar.Top = enemyYpos;
                        Random x2 = new Random();
                        xpos4 = xposition[x2.Next(6, 8)];
                        purplecar.Left = xpos4;
                    }
                    else
                    {
                        purplecar.Top = purplecar.Top + 35;
                    }
                    if (yellowcar.Top >= ClientRectangle.Height)
                    {
                        yellowcar.Top = enemyYpos;
                        Random x2 = new Random();
                        xpos = xposition[x2.Next(0, 2)];
                        yellowcar.Left = xpos;
                    }
                    else
                    {
                        yellowcar.Top = yellowcar.Top + 10;
                    }
                }
            resetpos();
            collison();
            }

        private void timeRestart_Tick(object sender, EventArgs e)//relaunch process
        {
            timeRestart.Enabled = true;
            timeRestart.Start();
            if (restartcounter > 0)
            {
                restartcounter--;
                messagebox.Text = ("Restarting..." + restartcounter); 
            }
            if (restartcounter == 0)
            {
                var Start = new Start();
                Start.Show();
                this.Close();
            }
        }
    }
    }
