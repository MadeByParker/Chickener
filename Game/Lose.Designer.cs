namespace Game
{
    partial class Lose
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
            this.txtLose = new System.Windows.Forms.TextBox();
            this.timerRes2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtLose
            // 
            this.txtLose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtLose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLose.Enabled = false;
            this.txtLose.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLose.Location = new System.Drawing.Point(716, 358);
            this.txtLose.Multiline = true;
            this.txtLose.Name = "txtLose";
            this.txtLose.ReadOnly = true;
            this.txtLose.Size = new System.Drawing.Size(785, 312);
            this.txtLose.TabIndex = 4;
            this.txtLose.TabStop = false;
            // 
            // timerRes2
            // 
            this.timerRes2.Enabled = true;
            this.timerRes2.Interval = 1000;
            this.timerRes2.Tick += new System.EventHandler(this.Lose_Load);
            // 
            // Lose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources.bg_start;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.txtLose);
            this.Name = "Lose";
            this.Text = "Lose, Game Over!";
            this.Load += new System.EventHandler(this.Lose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLose;
        private System.Windows.Forms.Timer timerRes2;
    }
}