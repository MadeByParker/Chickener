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

namespace Game
{
    public partial class Maths : Form
    {
        int CPUanswer; //cpu answer to check with the user's answer
        int TimeLeft = 25;//Time left to answer the question
        int reloadcounter = 6;
        public Maths()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            ClientSize = new Size(1920, 1080);
        }

        private void Maths_Load(object sender, EventArgs e)
        {
            //array to store all operators
            string[] operators = { "+", "-", "x", "/" };
            Random op = new Random();
            int n = op.Next(0, 4);//randomly picks an operator
            string sign = operators[n];
            int value1;
            int value2;
            Random num = new Random();
            value1 = num.Next(1, 100);//randomly picks 2 values between 1 and 100
            value2 = num.Next(1, 100);


            

            if (n == 0)//for each operator it prints the question and works out the answer
            {
                CPUanswer = value1 + value2;
                CPUans.Text = CPUanswer.ToString();
                txtQuestion.Text = ("What is " + value1 + sign + value2 + "?");
            }
            if (n == 1)
            {
                CPUanswer = value1 - value2;
                CPUans.Text = CPUanswer.ToString();
                txtQuestion.Text = ("What is " + value1 + sign + value2 + "?");
            }
            if (n == 2)
            {
                if (value1 > 12 || value2 > 12)//most people can't do times tables past 12x12 so if either value is higher than that then it regenerates for a easier multiplication
                {
                    Random random = new Random();
                    value1 = num.Next(1, 13);
                    value2 = num.Next(1, 13);
                    CPUanswer = value1 * value2;
                    txtQuestion.Text = ("What is " + value1 + sign + value2 + "?");
                    CPUans.Text = CPUanswer.ToString();
                }
                else
                {
                    CPUanswer = value1 * value2;
                    CPUans.Text = CPUanswer.ToString();
                }
            }
            if (n == 3)
            {
                CPUanswer = value1 / value2;
                CPUans.Text = CPUanswer.ToString();
                txtQuestion.Text = ("What is " + value1 + sign + value2 + "? to the nearest whole number");
            }

            
        }
        //when the user clicks the check button then the system  checks if the user if correct or wrong 
        private void btnCheck_Click(object sender, EventArgs e)
        {
            txtAnswer.Enabled = false;
            btnCheck.Enabled = false;
            tmAns.Stop();
            if (CPUanswer.ToString() == txtAnswer.Text)
            {
                txtAnswer.Text = ("Correct!");
                Reload_Tick(sender, e);
            }
            else
            {
                txtAnswer.Text = ("Wrong!");
                Reload_Tick(sender, e);
            }

        }
        //performs same function if the NETER key is pressed
        private void txtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCheck_Click(sender, e);
            }
        }
        //countdown timer
        private void tmAns_Tick(object sender, EventArgs e)
        {
            if (TimeLeft > 0)
            {
                TimeLeft = TimeLeft - 1;
                lblTimer.Text = "Time Left: " + TimeLeft;
            }
            if (TimeLeft == 0)
            {
                txtAnswer.Text = ("Time's Out!");
                txtAnswer.Enabled = false;
                tmAns.Stop();
                Reload_Tick(sender, e);
            }
        }
        //it reloads the corresponding page depending on if the user got the question correct or wrong
        private void Reload_Tick(object sender, EventArgs e)
        {

            Reload.Enabled = true;
            Reload.Start();
            if (txtAnswer.Text == "Correct!")
            {
                if (reloadcounter > 0)
                {
                    reloadcounter--;
                    if (reloadcounter == 3)
                    {
                        txtAnswer.Text = ("Reloading...");
                        var form2 = new Game();
                        form2.Show();
                        this.Hide();
                    }
                }
            }
            if (txtAnswer.Text == "Wrong!")
            {
                if (reloadcounter > 0)
                {
                    reloadcounter--;
                    if (reloadcounter == 3)
                    {
                        var form1 = new Lose();
                        form1.Show();
                        this.Hide();
                    }
                   
                }
            }
            if (txtAnswer.Text == "Time's Out!")
            {
                if (reloadcounter > 0)
                {
                    reloadcounter--;
                    if (reloadcounter == 3)
                    {
                        
                        var form1 = new Lose();
                        form1.Show();
                        this.Hide();
                    }
                }
            }
        }
    }
}
