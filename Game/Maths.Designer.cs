namespace Game
{
    partial class Maths
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
            this.bgStart = new System.Windows.Forms.PictureBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.CPUans = new System.Windows.Forms.TextBox();
            this.Reload = new System.Windows.Forms.Timer(this.components);
            this.tmAns = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bgStart)).BeginInit();
            this.SuspendLayout();
            // 
            // bgStart
            // 
            this.bgStart.Image = global::Game.Properties.Resources.bg_start;
            this.bgStart.Location = new System.Drawing.Point(0, 0);
            this.bgStart.Name = "bgStart";
            this.bgStart.Size = new System.Drawing.Size(1920, 1080);
            this.bgStart.TabIndex = 0;
            this.bgStart.TabStop = false;
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuestion.Enabled = false;
            this.txtQuestion.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(676, 123);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(563, 312);
            this.txtQuestion.TabIndex = 2;
            this.txtQuestion.TabStop = false;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(744, 473);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(416, 97);
            this.txtAnswer.TabIndex = 3;
            this.txtAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAnswer_KeyDown);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(883, 739);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(128, 61);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check!";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // CPUans
            // 
            this.CPUans.Enabled = false;
            this.CPUans.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUans.Location = new System.Drawing.Point(28, 609);
            this.CPUans.Name = "CPUans";
            this.CPUans.Size = new System.Drawing.Size(271, 45);
            this.CPUans.TabIndex = 5;
            this.CPUans.TabStop = false;
            this.CPUans.Visible = false;
            // 
            // Reload
            // 
            this.Reload.Interval = 1000;
            this.Reload.Tick += new System.EventHandler(this.Reload_Tick);
            // 
            // tmAns
            // 
            this.tmAns.Enabled = true;
            this.tmAns.Interval = 1000;
            this.tmAns.Tick += new System.EventHandler(this.tmAns_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.Enabled = false;
            this.lblTimer.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(832, 614);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(256, 46);
            this.lblTimer.TabIndex = 6;
            this.lblTimer.Text = "Time Left: ";
            // 
            // Maths
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.CPUans);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.bgStart);
            this.Name = "Maths";
            this.Text = "Maths";
            this.Load += new System.EventHandler(this.Maths_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bgStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bgStart;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox CPUans;
        private System.Windows.Forms.Timer Reload;
        private System.Windows.Forms.Timer tmAns;
        private System.Windows.Forms.Label lblTimer;
    }
}