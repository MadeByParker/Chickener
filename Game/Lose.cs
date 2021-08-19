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
    public partial class Lose : Form
    {
        int restartcounter = 10;
        public Lose()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void Lose_Load(object sender, EventArgs e)
        {
            if (restartcounter > 0)
            {
                txtLose.Text = "Game Over, You Lose! " + restartcounter;
                restartcounter--;
                if (restartcounter <= 5)
                {
                    txtLose.Text = ("Restarting... in " + restartcounter);
                }
                if (restartcounter == 0)
                {
                    var restartform = new Start();
                    restartform.Show();
                    this.Hide();
                }
            }
        }
    }
}
