namespace LearnMorse
{
    partial class TranslateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranslateForm));
            this.labelInput = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonTranslate = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelInput.Location = new System.Drawing.Point(15, 16);
            this.labelInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(112, 22);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Enter Text:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Arial", 24F);
            this.textBoxInput.Location = new System.Drawing.Point(15, 41);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(301, 82);
            this.textBoxInput.TabIndex = 1;
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonTranslate.Location = new System.Drawing.Point(15, 130);
            this.buttonTranslate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(88, 32);
            this.buttonTranslate.TabIndex = 2;
            this.buttonTranslate.Text = "Translate";
            this.buttonTranslate.UseVisualStyleBackColor = true;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.BackColor = System.Drawing.Color.White;
            this.labelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOutput.Font = new System.Drawing.Font("Arial", 100F);
            this.labelOutput.Location = new System.Drawing.Point(15, 171);
            this.labelOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(300, 82);
            this.labelOutput.TabIndex = 3;
            // 
            // TranslateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 284);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.buttonTranslate);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TranslateForm";
            this.Text = "Morse Code Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonTranslate;
        private System.Windows.Forms.Label labelOutput;
    }
}
