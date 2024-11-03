using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LearnMorse
{
    public partial class TranslateForm : Form
    {
        private Dictionary<char, string> morseCodeDict;

        public TranslateForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 204, 204);
            InitializeMorseCode();
            SetupUI();
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
                { 'Z', "--.." },
                { '0', "-----" },
                { '1', ".----" },
                { '2', "..---" },
                { '3', "...--" },
                { '4', "....-" },
                { '5', "....." },
                { '6', "-...." },
                { '7', "--..." },
                { '8', "---.." },
                { '9', "----." },
                { ' ', "/" } 
            };
        }

        private void SetupUI()
        {
            Label labelInput = new Label
            {
                Text = "Enter Text:",
                Location = new Point(20, 20),
                AutoSize = true,
                Font = new Font("Arial", 14, FontStyle.Bold)
            };
            Controls.Add(labelInput);

            textBoxInput.Location = new Point(20, 50);
            textBoxInput.Size = new Size(400, 100);
            textBoxInput.Font = new Font("Arial", 12);
            Controls.Add(textBoxInput);

            buttonTranslate.Text = "Translate";
            buttonTranslate.Location = new Point(20, 160);
            buttonTranslate.Size = new Size(100, 40);
            buttonTranslate.Font = new Font("Arial", 12);
            buttonTranslate.Click += buttonTranslate_Click;
            Controls.Add(buttonTranslate);

            labelOutput.Location = new Point(20, 210);
            labelOutput.Size = new Size(400, 100);
            labelOutput.Font = new Font("Arial", 12);
            labelOutput.BackColor = Color.FromArgb(255, 255, 255);
            labelOutput.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(labelOutput);
        }

        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text.ToUpper();
            string morseCode = TranslateToMorse(input);
            labelOutput.Text = morseCode;
        }

        private string TranslateToMorse(string input)
        {
            string result = "";
            foreach (char c in input)
            {
                if (morseCodeDict.ContainsKey(c))
                {
                    result += morseCodeDict[c] + " ";
                }
                else
                {
                    result += "? ";
                }
            }
            return result.Trim();
        }
    }
}
