namespace Game
{
    partial class Game
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.score = new System.Windows.Forms.TextBox();
            this.timerMovement = new System.Windows.Forms.Timer(this.components);
            this.messagebox = new System.Windows.Forms.TextBox();
            this.basket = new System.Windows.Forms.PictureBox();
            this.egg1 = new System.Windows.Forms.PictureBox();
            this.greencar = new System.Windows.Forms.PictureBox();
            this.yellowcar = new System.Windows.Forms.PictureBox();
            this.purplecar = new System.Windows.Forms.PictureBox();
            this.fastcar = new System.Windows.Forms.PictureBox();
            this.redcar = new System.Windows.Forms.PictureBox();
            this.character = new System.Windows.Forms.PictureBox();
            this.bg = new System.Windows.Forms.PictureBox();
            this.home = new System.Windows.Forms.PictureBox();
            this.timeRestart = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.basket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greencar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowcar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purplecar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastcar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redcar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.home)).BeginInit();
            this.SuspendLayout();
            // 
            // score
            // 
            this.score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(159)))), ((int)(((byte)(31)))));
            this.score.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.score.Enabled = false;
            this.score.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.White;
            this.score.Location = new System.Drawing.Point(26, 11);
            this.score.Margin = new System.Windows.Forms.Padding(2);
            this.score.Multiline = true;
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(165, 75);
            this.score.TabIndex = 6;
            // 
            // timerMovement
            // 
            this.timerMovement.Enabled = true;
            this.timerMovement.Tick += new System.EventHandler(this.Form1_Load);
            // 
            // messagebox
            // 
            this.messagebox.BackColor = System.Drawing.Color.White;
            this.messagebox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messagebox.Enabled = false;
            this.messagebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.messagebox.ForeColor = System.Drawing.Color.Black;
            this.messagebox.Location = new System.Drawing.Point(26, 902);
            this.messagebox.Multiline = true;
            this.messagebox.Name = "messagebox";
            this.messagebox.ReadOnly = true;
            this.messagebox.Size = new System.Drawing.Size(189, 97);
            this.messagebox.TabIndex = 8;
            // 
            // basket
            // 
            this.basket.BackColor = System.Drawing.Color.Transparent;
            this.basket.Image = global::Game.Properties.Resources.basket;
            this.basket.Location = new System.Drawing.Point(66, 585);
            this.basket.Name = "basket";
            this.basket.Size = new System.Drawing.Size(53, 62);
            this.basket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.basket.TabIndex = 12;
            this.basket.TabStop = false;
            // 
            // egg1
            // 
            this.egg1.BackColor = System.Drawing.Color.Transparent;
            this.egg1.Image = global::Game.Properties.Resources.egg1;
            this.egg1.Location = new System.Drawing.Point(1801, 404);
            this.egg1.Name = "egg1";
            this.egg1.Size = new System.Drawing.Size(80, 80);
            this.egg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.egg1.TabIndex = 11;
            this.egg1.TabStop = false;
            // 
            // greencar
            // 
            this.greencar.BackColor = System.Drawing.Color.Black;
            this.greencar.Image = global::Game.Properties.Resources.greencar;
            this.greencar.Location = new System.Drawing.Point(558, 154);
            this.greencar.Name = "greencar";
            this.greencar.Size = new System.Drawing.Size(50, 100);
            this.greencar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.greencar.TabIndex = 5;
            this.greencar.TabStop = false;
            // 
            // yellowcar
            // 
            this.yellowcar.BackColor = System.Drawing.Color.Black;
            this.yellowcar.Image = global::Game.Properties.Resources.yellowcar;
            this.yellowcar.Location = new System.Drawing.Point(363, 154);
            this.yellowcar.Name = "yellowcar";
            this.yellowcar.Size = new System.Drawing.Size(50, 100);
            this.yellowcar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yellowcar.TabIndex = 4;
            this.yellowcar.TabStop = false;
            // 
            // purplecar
            // 
            this.purplecar.BackColor = System.Drawing.Color.Black;
            this.purplecar.Image = global::Game.Properties.Resources.purplecar;
            this.purplecar.Location = new System.Drawing.Point(614, 154);
            this.purplecar.Name = "purplecar";
            this.purplecar.Size = new System.Drawing.Size(50, 100);
            this.purplecar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.purplecar.TabIndex = 3;
            this.purplecar.TabStop = false;
            // 
            // fastcar
            // 
            this.fastcar.BackColor = System.Drawing.Color.Black;
            this.fastcar.Image = global::Game.Properties.Resources.fastcar1;
            this.fastcar.Location = new System.Drawing.Point(437, 154);
            this.fastcar.Name = "fastcar";
            this.fastcar.Size = new System.Drawing.Size(50, 100);
            this.fastcar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fastcar.TabIndex = 2;
            this.fastcar.TabStop = false;
            // 
            // redcar
            // 
            this.redcar.BackColor = System.Drawing.Color.Black;
            this.redcar.Image = global::Game.Properties.Resources.redcar;
            this.redcar.Location = new System.Drawing.Point(493, 154);
            this.redcar.Name = "redcar";
            this.redcar.Size = new System.Drawing.Size(50, 100);
            this.redcar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redcar.TabIndex = 1;
            this.redcar.TabStop = false;
            // 
            // character
            // 
            this.character.BackColor = System.Drawing.Color.Transparent;
            this.character.Image = global::Game.Properties.Resources.chicken1;
            this.character.Location = new System.Drawing.Point(26, 441);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(80, 80);
            this.character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.character.TabIndex = 0;
            this.character.TabStop = false;
            // 
            // bg
            // 
            this.bg.BackColor = System.Drawing.Color.Transparent;
            this.bg.Enabled = false;
            this.bg.Image = global::Game.Properties.Resources.bg;
            this.bg.Location = new System.Drawing.Point(0, 0);
            this.bg.Name = "bg";
            this.bg.Size = new System.Drawing.Size(1920, 1080);
            this.bg.TabIndex = 7;
            this.bg.TabStop = false;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.Transparent;
            this.home.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.home.Image = global::Game.Properties.Resources.pen;
            this.home.Location = new System.Drawing.Point(26, 112);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(179, 153);
            this.home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.home.TabIndex = 13;
            this.home.TabStop = false;
            // 
            // timeRestart
            // 
            this.timeRestart.Interval = 1000;
            this.timeRestart.Tick += new System.EventHandler(this.timeRestart_Tick);
            // 
            // Game
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Game.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.egg1);
            this.Controls.Add(this.character);
            this.Controls.Add(this.basket);
            this.Controls.Add(this.home);
            this.Controls.Add(this.messagebox);
            this.Controls.Add(this.score);
            this.Controls.Add(this.greencar);
            this.Controls.Add(this.yellowcar);
            this.Controls.Add(this.purplecar);
            this.Controls.Add(this.fastcar);
            this.Controls.Add(this.redcar);
            this.Controls.Add(this.bg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ParentChanged += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.basket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greencar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowcar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purplecar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastcar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redcar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox redcar;
        private System.Windows.Forms.TextBox score;
        private System.Windows.Forms.Timer timerMovement;
        private System.Windows.Forms.PictureBox character;
        private System.Windows.Forms.PictureBox fastcar;
        private System.Windows.Forms.PictureBox purplecar;
        private System.Windows.Forms.PictureBox yellowcar;
        private System.Windows.Forms.PictureBox greencar;
        private System.Windows.Forms.TextBox messagebox;
        private System.Windows.Forms.PictureBox bg;
        private System.Windows.Forms.PictureBox egg1;
        private System.Windows.Forms.PictureBox basket;
        private System.Windows.Forms.PictureBox home;
        private System.Windows.Forms.Timer timeRestart;
    }
}

