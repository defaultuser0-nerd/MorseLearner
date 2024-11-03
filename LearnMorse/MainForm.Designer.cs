using System.Drawing;
using System.Windows.Forms;

namespace LearnMorse
{
    partial class LearnMorse
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LearnMorse));
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonPractice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Font = new System.Drawing.Font("Arial", 20F);
            this.buttonPlay.ForeColor = System.Drawing.Color.White;
            this.buttonPlay.Location = new System.Drawing.Point(80, 39);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(300, 120);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.TabStop = false;
            this.buttonPlay.Text = "Play Morse Code Game";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonPractice
            // 
            this.buttonPractice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.buttonPractice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPractice.Font = new System.Drawing.Font("Arial", 20F);
            this.buttonPractice.ForeColor = System.Drawing.Color.White;
            this.buttonPractice.Location = new System.Drawing.Point(80, 250);
            this.buttonPractice.Name = "buttonPractice";
            this.buttonPractice.Size = new System.Drawing.Size(300, 120);
            this.buttonPractice.TabIndex = 1;
            this.buttonPractice.Text = "Translate Morse Code";
            this.buttonPractice.UseVisualStyleBackColor = false;
            this.buttonPractice.Click += new System.EventHandler(this.buttonPractice_Click);
            // 
            // LearnMorse
            // 
            this.ClientSize = new System.Drawing.Size(475, 400);
            this.Controls.Add(this.buttonPractice);
            this.Controls.Add(this.buttonPlay);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LearnMorse";
            this.Text = "Learn Morse Code";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonPractice;
    }
}
