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
    
    public partial class Win : Form
    {
        int restartcounter = 10;
        public Win()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void Win_Load(object sender, EventArgs e)
        {
            if (restartcounter > 0)
            {
                txtWin.Text = "You Won! " + restartcounter;
                restartcounter--;
                if (restartcounter <= 5)
                {
                    txtWin.Text = ("Restarting... in " + restartcounter);
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
