using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LearnMorse
{
    public partial class GameForm : Form
    {
        private Random random;
        private string currentLetter;
        private int score;
        private int timeLeft;
        private Dictionary<char, string> morseCodeDict;

        public GameForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 204, 204);
            random = new Random();
            score = 0;
            timeLeft = 30;
            InitializeMorseCode();
            StartGame();
            textBoxInput.KeyDown += textBoxInput_KeyDown;
        }

        private void InitializeMorseCode()
        {
            morseCodeDict = new Dictionary<char, string>
            {
                { 'A', ".-" },
                { 'B', "-..." },
                { 'C', "-.-." },
                { 'D', "-.." },
                { 'E', "." },
                { 'F', "..-." },
                { 'G', "--." },
                { 'H', "...." },
                { 'I', ".." },
                { 'J', ".---" },
                { 'K', "-.-" },
                { 'L', ".-.." },
                { 'M', "--" },
                { 'N', "-." },
                { 'O', "---" },
                { 'P', ".--." },
                { 'Q', "--.-" },
                { 'R', ".-." },
                { 'S', "..." },
                { 'T', "-" },
                { 'U', "..-" },
                { 'V', "...-" },
                { 'W', ".--" },
                { 'X', "-..-" },
                { 'Y', "-.--" },
                { 'Z', "--.." }
            };
        }

        private void StartGame()
        {
            UpdateCurrentLetter();
            timerGame.Start();
            labelScore.Text = "Score: 0";
            labelTime.Text = "Time Left: 30";
            timeLeft = 30;
        }

        private void UpdateCurrentLetter()
        {
            currentLetter = ((char)random.Next('A', 'Z' + 1)).ToString();
            labelCurrentLetter.Text = currentLetter;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            ProcessInput();
        }

        private void textBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(textBoxInput.Text))
            {
                ProcessInput();
                e.SuppressKeyPress = true; 
            }
        }

        private void ProcessInput()
        {
            string morseCode = morseCodeDict[currentLetter[0]];
            string input = textBoxInput.Text.Trim();

            if (input == morseCode)
            {
                score++;
                labelScore.Text = "Score: " + score;
                UpdateCurrentLetter();
                textBoxInput.Clear();
            }
            else
            {
                MessageBox.Show("Incorrect! Try again.");
                textBoxInput.Clear();
            }
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            labelTime.Text = "Time Left: " + timeLeft;

            if (timeLeft <= 0)
            {
                timerGame.Stop();
                MessageBox.Show($"Time's up! Your score is {score}.");
                this.Close(); 
            }
        }
    }
}
