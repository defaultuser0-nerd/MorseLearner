using System.Drawing;
using System.Windows.Forms;

namespace LearnMorse
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.labelCurrentLetter = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelCurrentLetter
            // 
            this.labelCurrentLetter.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold);
            this.labelCurrentLetter.Location = new System.Drawing.Point(50, 50);
            this.labelCurrentLetter.Name = "labelCurrentLetter";
            this.labelCurrentLetter.Size = new System.Drawing.Size(700, 100);
            this.labelCurrentLetter.TabIndex = 4;
            this.labelCurrentLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Arial", 24F);
            this.textBoxInput.Location = new System.Drawing.Point(50, 200);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(700, 44);
            this.textBoxInput.TabIndex = 3;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Arial", 20F);
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(300, 300);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(200, 60);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelScore
            // 
            this.labelScore.Font = new System.Drawing.Font("Arial", 24F);
            this.labelScore.Location = new System.Drawing.Point(50, 370);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(350, 40);
            this.labelScore.TabIndex = 1;
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Arial", 24F);
            this.labelTime.Location = new System.Drawing.Point(400, 370);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(350, 40);
            this.labelTime.TabIndex = 0;
            // 
            // timerGame
            // 
            this.timerGame.Interval = 1000;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // GameForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelCurrentLetter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.Text = "Morse Code Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelCurrentLetter;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timerGame;
    }
}
