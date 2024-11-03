using System;
using System.Drawing;
using System.Windows.Forms;

namespace LearnMorse
{
    public partial class LearnMorse : Form
    {
        public LearnMorse()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 204, 204);
            this.Font = new Font("Arial", 14);
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.Show();
        }

        private void buttonPractice_Click(object sender, EventArgs e)
        {
            TranslateForm practiceForm = new TranslateForm();
            practiceForm.Show();
        }
    }
}
