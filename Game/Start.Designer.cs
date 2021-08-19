namespace Game
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.btnStart = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtRules = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.character = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.character)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(944, 845);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(238, 134);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.Black;
            this.txtInfo.Enabled = false;
            this.txtInfo.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtInfo.Location = new System.Drawing.Point(895, 295);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(323, 121);
            this.txtInfo.TabIndex = 1;
            this.txtInfo.Text = "Why did the chicken cross the road?                      Click the Start button t" +
    "o start playing!";
            // 
            // txtRules
            // 
            this.txtRules.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtRules.Enabled = false;
            this.txtRules.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRules.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtRules.Location = new System.Drawing.Point(895, 466);
            this.txtRules.Multiline = true;
            this.txtRules.Name = "txtRules";
            this.txtRules.Size = new System.Drawing.Size(323, 149);
            this.txtRules.TabIndex = 2;
            this.txtRules.Text = "Controls:                         Use W, A, S, D or the Arrow Keys for Movement. " +
    "                       ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(895, 650);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 169);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // character
            // 
            this.character.BackColor = System.Drawing.Color.Transparent;
            this.character.Image = global::Game.Properties.Resources.chicken1;
            this.character.Location = new System.Drawing.Point(946, 140);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(236, 149);
            this.character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.character.TabIndex = 4;
            this.character.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(864, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 109);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to Chicken! ";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources.bg_start;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.character);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtRules);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnStart);
            this.Name = "Start";
            this.Text = "Start";
            ((System.ComponentModel.ISupportInitialize)(this.character)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtRules;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox character;
        private System.Windows.Forms.Label label1;
    }
}