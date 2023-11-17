using System.Drawing;
using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTest));
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
            label2 = new Label();
            comboBoxNumberOfIncorrectWords = new ComboBox();
            buttonLoadSelectedWords = new Button();
            labelPronounce = new Label();
            ProgressBarTest = new ProgressBar();
            pictureBox1 = new PictureBox();
            richTextBoxTestResult = new RichTextBox();
            labelTestResult = new Label();
            checkBoxSoundOnly = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxNumberOfWords
            // 
            comboBoxNumberOfWords.FormattingEnabled = true;
            comboBoxNumberOfWords.Location = new Point(15, 148);
            comboBoxNumberOfWords.Name = "comboBoxNumberOfWords";
            comboBoxNumberOfWords.Size = new Size(63, 23);
            comboBoxNumberOfWords.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 130);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "# of words";
            // 
            // labelExamWord
            // 
            labelExamWord.AutoSize = true;
            labelExamWord.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelExamWord.Location = new Point(276, 199);
            labelExamWord.Name = "labelExamWord";
            labelExamWord.Size = new Size(70, 25);
            labelExamWord.TabIndex = 3;
            labelExamWord.Text = "WORD";
            // 
            // textBoxTranslateWord
            // 
            textBoxTranslateWord.Location = new Point(276, 276);
            textBoxTranslateWord.Name = "textBoxTranslateWord";
            textBoxTranslateWord.Size = new Size(191, 23);
            textBoxTranslateWord.TabIndex = 4;
            // 
            // buttonNextWord
            // 
            buttonNextWord.Location = new Point(480, 276);
            buttonNextWord.Name = "buttonNextWord";
            buttonNextWord.Size = new Size(75, 23);
            buttonNextWord.TabIndex = 5;
            buttonNextWord.Text = "Next";
            buttonNextWord.UseVisualStyleBackColor = true;
            buttonNextWord.Click += buttonNextWord_Click;
            // 
            // buttonHint
            // 
            buttonHint.Location = new Point(480, 34);
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
            buttonLoad.Location = new Point(81, 148);
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
            labelAllWords.Location = new Point(15, 100);
            labelAllWords.Name = "labelAllWords";
            labelAllWords.Size = new Size(60, 15);
            labelAllWords.TabIndex = 10;
            labelAllWords.Text = "all words: ";
            // 
            // buttonLoadAllWords
            // 
            buttonLoadAllWords.Location = new Point(11, 74);
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
            labelScore.Location = new Point(480, 357);
            labelScore.Name = "labelScore";
            labelScore.RightToLeft = RightToLeft.No;
            labelScore.Size = new Size(56, 21);
            labelScore.TabIndex = 12;
            labelScore.Text = "Score:";
            // 
            // buttonLoadAllIncorrectAnswers
            // 
            buttonLoadAllIncorrectAnswers.Location = new Point(12, 199);
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
            labelIncorrectWords.Location = new Point(12, 225);
            labelIncorrectWords.Name = "labelIncorrectWords";
            labelIncorrectWords.Size = new Size(95, 15);
            labelIncorrectWords.TabIndex = 14;
            labelIncorrectWords.Text = "Incorrect words: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 257);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 16;
            label2.Text = "# of incorrect words";
            // 
            // comboBoxNumberOfIncorrectWords
            // 
            comboBoxNumberOfIncorrectWords.FormattingEnabled = true;
            comboBoxNumberOfIncorrectWords.Location = new Point(12, 275);
            comboBoxNumberOfIncorrectWords.Name = "comboBoxNumberOfIncorrectWords";
            comboBoxNumberOfIncorrectWords.Size = new Size(66, 23);
            comboBoxNumberOfIncorrectWords.TabIndex = 18;
            // 
            // buttonLoadSelectedWords
            // 
            buttonLoadSelectedWords.Location = new Point(81, 275);
            buttonLoadSelectedWords.Name = "buttonLoadSelectedWords";
            buttonLoadSelectedWords.Size = new Size(84, 23);
            buttonLoadSelectedWords.TabIndex = 19;
            buttonLoadSelectedWords.Text = "Load words";
            buttonLoadSelectedWords.UseVisualStyleBackColor = true;
            buttonLoadSelectedWords.Click += buttonLoadSelectedWords_Click;
            // 
            // labelPronounce
            // 
            labelPronounce.AutoSize = true;
            labelPronounce.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPronounce.Location = new Point(276, 245);
            labelPronounce.Name = "labelPronounce";
            labelPronounce.Size = new Size(74, 17);
            labelPronounce.TabIndex = 20;
            labelPronounce.Text = "Pronounce";
            // 
            // ProgressBarTest
            // 
            ProgressBarTest.Location = new Point(276, 305);
            ProgressBarTest.Name = "ProgressBarTest";
            ProgressBarTest.Size = new Size(191, 10);
            ProgressBarTest.TabIndex = 21;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Audio_24;
            pictureBox1.Location = new Point(530, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 30);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // richTextBoxTestResult
            // 
            richTextBoxTestResult.Location = new Point(582, 35);
            richTextBoxTestResult.Name = "richTextBoxTestResult";
            richTextBoxTestResult.Size = new Size(204, 343);
            richTextBoxTestResult.TabIndex = 24;
            richTextBoxTestResult.Text = "";
            // 
            // labelTestResult
            // 
            labelTestResult.AutoSize = true;
            labelTestResult.Location = new Point(582, 381);
            labelTestResult.Name = "labelTestResult";
            labelTestResult.Size = new Size(89, 15);
            labelTestResult.TabIndex = 25;
            labelTestResult.Text = "Selected words:";
            // 
            // checkBoxSoundOnly
            // 
            checkBoxSoundOnly.AutoSize = true;
            checkBoxSoundOnly.Location = new Point(101, 34);
            checkBoxSoundOnly.Name = "checkBoxSoundOnly";
            checkBoxSoundOnly.Size = new Size(86, 19);
            checkBoxSoundOnly.TabIndex = 26;
            checkBoxSoundOnly.Text = "Sound only";
            checkBoxSoundOnly.UseVisualStyleBackColor = true;
            checkBoxSoundOnly.CheckedChanged += checkBoxSoundOnly_CheckedChanged;
            // 
            // frmTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 419);
            Controls.Add(checkBoxSoundOnly);
            Controls.Add(labelTestResult);
            Controls.Add(richTextBoxTestResult);
            Controls.Add(pictureBox1);
            Controls.Add(ProgressBarTest);
            Controls.Add(labelPronounce);
            Controls.Add(buttonLoadSelectedWords);
            Controls.Add(comboBoxNumberOfIncorrectWords);
            Controls.Add(label2);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmTest";
            Text = "Test";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label label2;
        private ComboBox comboBoxNumberOfIncorrectWords;
        private Button buttonLoadSelectedWords;
        private Label labelPronounce;
        private ProgressBar ProgressBarTest;
        private PictureBox pictureBox1;
        private RichTextBox richTextBoxTestResult;
        private Label labelTestResult;
        private CheckBox checkBoxSoundOnly;
    }
}