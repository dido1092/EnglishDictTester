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
            labelAllWords = new Label();
            buttonLoadAllWords = new Button();
            labelScore = new Label();
            buttonLoadAllIncorrectAnswers = new Button();
            labelIncorrectWords = new Label();
            textBoxHint = new TextBox();
            SuspendLayout();
            // 
            // comboBoxNumberOfWords
            // 
            comboBoxNumberOfWords.FormattingEnabled = true;
            comboBoxNumberOfWords.Items.AddRange(new object[] { "5", "10", "15", "20", "25", "30", "50", "100" });
            comboBoxNumberOfWords.Location = new Point(12, 97);
            comboBoxNumberOfWords.Name = "comboBoxNumberOfWords";
            comboBoxNumberOfWords.Size = new Size(63, 23);
            comboBoxNumberOfWords.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 79);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "# of words";
            // 
            // labelExamWord
            // 
            labelExamWord.AutoSize = true;
            labelExamWord.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelExamWord.Location = new Point(288, 172);
            labelExamWord.Name = "labelExamWord";
            labelExamWord.Size = new Size(70, 25);
            labelExamWord.TabIndex = 3;
            labelExamWord.Text = "WORD";
            // 
            // textBoxTranslateWord
            // 
            textBoxTranslateWord.Location = new Point(236, 239);
            textBoxTranslateWord.Name = "textBoxTranslateWord";
            textBoxTranslateWord.Size = new Size(172, 23);
            textBoxTranslateWord.TabIndex = 4;
            // 
            // buttonNextWord
            // 
            buttonNextWord.Location = new Point(414, 239);
            buttonNextWord.Name = "buttonNextWord";
            buttonNextWord.Size = new Size(75, 23);
            buttonNextWord.TabIndex = 5;
            buttonNextWord.Text = "Next word";
            buttonNextWord.UseVisualStyleBackColor = true;
            buttonNextWord.Click += buttonNextWord_Click;
            // 
            // buttonHint
            // 
            buttonHint.Location = new Point(544, 33);
            buttonHint.Name = "buttonHint";
            buttonHint.Size = new Size(75, 23);
            buttonHint.TabIndex = 6;
            buttonHint.Text = "Hint";
            buttonHint.UseVisualStyleBackColor = true;
            buttonHint.Click += buttonHint_ClickAsync;
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Items.AddRange(new object[] { "En", "Bg" });
            comboBoxLanguage.Location = new Point(12, 34);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new Size(63, 23);
            comboBoxLanguage.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 16);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 8;
            label3.Text = "Language";
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(81, 97);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(84, 23);
            buttonLoad.TabIndex = 9;
            buttonLoad.Text = "Load  words";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // labelAllWords
            // 
            labelAllWords.AutoSize = true;
            labelAllWords.Location = new Point(183, 38);
            labelAllWords.Name = "labelAllWords";
            labelAllWords.Size = new Size(60, 15);
            labelAllWords.TabIndex = 10;
            labelAllWords.Text = "all words: ";
            // 
            // buttonLoadAllWords
            // 
            buttonLoadAllWords.Location = new Point(81, 34);
            buttonLoadAllWords.Name = "buttonLoadAllWords";
            buttonLoadAllWords.Size = new Size(96, 23);
            buttonLoadAllWords.TabIndex = 11;
            buttonLoadAllWords.Text = "All words in DB";
            buttonLoadAllWords.UseVisualStyleBackColor = true;
            buttonLoadAllWords.Click += buttonLoadAllWords_Click;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelScore.Location = new Point(544, 355);
            labelScore.Name = "labelScore";
            labelScore.RightToLeft = RightToLeft.No;
            labelScore.Size = new Size(56, 21);
            labelScore.TabIndex = 12;
            labelScore.Text = "Score:";
            // 
            // buttonLoadAllIncorrectAnswers
            // 
            buttonLoadAllIncorrectAnswers.Location = new Point(12, 148);
            buttonLoadAllIncorrectAnswers.Name = "buttonLoadAllIncorrectAnswers";
            buttonLoadAllIncorrectAnswers.Size = new Size(153, 23);
            buttonLoadAllIncorrectAnswers.TabIndex = 13;
            buttonLoadAllIncorrectAnswers.Text = "Load All Incorrect answers";
            buttonLoadAllIncorrectAnswers.UseVisualStyleBackColor = true;
            buttonLoadAllIncorrectAnswers.Click += buttonLoadAllIncorrectAnswers_Click;
            // 
            // labelIncorrectWords
            // 
            labelIncorrectWords.AutoSize = true;
            labelIncorrectWords.Location = new Point(12, 174);
            labelIncorrectWords.Name = "labelIncorrectWords";
            labelIncorrectWords.Size = new Size(95, 15);
            labelIncorrectWords.TabIndex = 14;
            labelIncorrectWords.Text = "Incorrect words: ";
            // 
            // textBoxHint
            // 
            textBoxHint.Location = new Point(544, 71);
            textBoxHint.Name = "textBoxHint";
            textBoxHint.Size = new Size(100, 23);
            textBoxHint.TabIndex = 15;
            // 
            // frmTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 404);
            Controls.Add(textBoxHint);
            Controls.Add(labelIncorrectWords);
            Controls.Add(buttonLoadAllIncorrectAnswers);
            Controls.Add(labelScore);
            Controls.Add(buttonLoadAllWords);
            Controls.Add(labelAllWords);
            Controls.Add(buttonLoad);
            Controls.Add(label3);
            Controls.Add(comboBoxLanguage);
            Controls.Add(buttonHint);
            Controls.Add(buttonNextWord);
            Controls.Add(textBoxTranslateWord);
            Controls.Add(labelExamWord);
            Controls.Add(label1);
            Controls.Add(comboBoxNumberOfWords);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmTest";
            Text = "Test";
            ResumeLayout(false);
            PerformLayout();
        }

        private void ButtonLoadAllIncorrectAnswers_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
        public Label labelAllWords;
        private Button buttonLoadAllWords;
        private Label labelScore;
        private Button buttonLoadAllIncorrectAnswers;
        private Label labelIncorrectWords;
        private TextBox textBoxHint;
    }
}