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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            ClientSize = new Size(1920, 1080);
        }
        //on click of the start button then its launches the game client and closes the start page
        private void button1_Click(object sender, EventArgs e)
        {
            var form1 = new Game();
            form1.Show();
            this.Hide();
        }
    }
}
