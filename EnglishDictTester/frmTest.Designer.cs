namespace EnglishDictTester
{
    partial class frmTest
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
            comboBoxNumberOfWords = new ComboBox();
            label1 = new Label();
            labelExamWord = new Label();
            textBoxTranslateWord = new TextBox();
            buttonNextWord = new Button();
            buttonHint = new Button();
            comboBoxLanguage = new ComboBox();
            label3 = new Label();
            buttonLoad = new Button();
            SuspendLayout();
            // 
            // comboBoxNumberOfWords
            // 
            comboBoxNumberOfWords.FormattingEnabled = true;
            comboBoxNumberOfWords.Items.AddRange(new object[] { "5", "10", "15", "20", "25", "30", "50", "100" });
            comboBoxNumberOfWords.Location = new Point(16, 90);
            comboBoxNumberOfWords.Name = "comboBoxNumberOfWords";
            comboBoxNumberOfWords.Size = new Size(69, 23);
            comboBoxNumberOfWords.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 72);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "# of words";
            // 
            // labelExamWord
            // 
            labelExamWord.AutoSize = true;
            labelExamWord.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelExamWord.Location = new Point(248, 171);
            labelExamWord.Name = "labelExamWord";
            labelExamWord.Size = new Size(70, 25);
            labelExamWord.TabIndex = 3;
            labelExamWord.Text = "WORD";
            // 
            // textBoxTranslateWord
            // 
            textBoxTranslateWord.Location = new Point(196, 240);
            textBoxTranslateWord.Name = "textBoxTranslateWord";
            textBoxTranslateWord.Size = new Size(173, 23);
            textBoxTranslateWord.TabIndex = 4;
            // 
            // buttonNextWord
            // 
            buttonNextWord.Location = new Point(375, 239);
            buttonNextWord.Name = "buttonNextWord";
            buttonNextWord.Size = new Size(75, 23);
            buttonNextWord.TabIndex = 5;
            buttonNextWord.Text = "Next word";
            buttonNextWord.UseVisualStyleBackColor = true;
            buttonNextWord.Click += buttonNextWord_Click;
            // 
            // buttonHint
            // 
            buttonHint.Location = new Point(554, 31);
            buttonHint.Name = "buttonHint";
            buttonHint.Size = new Size(75, 23);
            buttonHint.TabIndex = 6;
            buttonHint.Text = "Hint";
            buttonHint.UseVisualStyleBackColor = true;
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Items.AddRange(new object[] { "En", "Bg" });
            comboBoxLanguage.Location = new Point(16, 39);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new Size(69, 23);
            comboBoxLanguage.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 21);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 8;
            label3.Text = "Language";
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(91, 90);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(75, 23);
            buttonLoad.TabIndex = 9;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // frmTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 407);
            Controls.Add(buttonLoad);
            Controls.Add(label3);
            Controls.Add(comboBoxLanguage);
            Controls.Add(buttonHint);
            Controls.Add(buttonNextWord);
            Controls.Add(textBoxTranslateWord);
            Controls.Add(labelExamWord);
            Controls.Add(label1);
            Controls.Add(comboBoxNumberOfWords);
            Name = "frmTest";
            Text = "Test";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxNumberOfWords;
        private Label label1;
        private Label labelExamWord;
        private TextBox textBoxTranslateWord;
        private Button buttonNextWord;
        private Button buttonHint;
        private ComboBox comboBoxLanguage;
        private Label label3;
        private Button buttonLoad;
    }
}