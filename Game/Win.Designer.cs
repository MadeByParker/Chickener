namespace Game
{
    partial class Win
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
            this.txtWin = new System.Windows.Forms.TextBox();
            this.timerRes = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtWin
            // 
            this.txtWin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtWin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWin.Enabled = false;
            this.txtWin.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWin.Location = new System.Drawing.Point(716, 358);
            this.txtWin.Multiline = true;
            this.txtWin.Name = "txtWin";
            this.txtWin.ReadOnly = true;
            this.txtWin.Size = new System.Drawing.Size(785, 312);
            this.txtWin.TabIndex = 3;
            this.txtWin.TabStop = false;
            // 
            // timerRes
            // 
            this.timerRes.Enabled = true;
            this.timerRes.Interval = 1000;
            this.timerRes.Tick += new System.EventHandler(this.Win_Load);
            // 
            // Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources.bg_start;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.txtWin);
            this.Name = "Win";
            this.Text = "Win";
            this.Load += new System.EventHandler(this.Win_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWin;
        private System.Windows.Forms.Timer timerRes;
    }
}