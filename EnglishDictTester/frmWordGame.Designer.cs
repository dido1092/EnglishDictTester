using System.Drawing;
using System.Windows.Forms;

namespace EnglishDictTester
{
    partial class frmWordGame
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
            buttonLoad = new Button();
            textBoxWord = new TextBox();
            buttonNext = new Button();
            labelShuffleWord = new Label();
            labelScore = new Label();
            textBoxNumberOfWords = new TextBox();
            label1 = new Label();
            progressBarWordGame = new ProgressBar();
            SuspendLayout();
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(85, 29);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(75, 23);
            buttonLoad.TabIndex = 0;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // textBoxWord
            // 
            textBoxWord.Location = new Point(108, 168);
            textBoxWord.Name = "textBoxWord";
            textBoxWord.Size = new Size(206, 23);
            textBoxWord.TabIndex = 1;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(320, 168);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(75, 23);
            buttonNext.TabIndex = 2;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // labelShuffleWord
            // 
            labelShuffleWord.AutoSize = true;
            labelShuffleWord.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelShuffleWord.Location = new Point(108, 119);
            labelShuffleWord.Name = "labelShuffleWord";
            labelShuffleWord.Size = new Size(70, 25);
            labelShuffleWord.TabIndex = 3;
            labelShuffleWord.Text = "WORD";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelScore.Location = new Point(324, 302);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(71, 30);
            labelScore.TabIndex = 4;
            labelScore.Text = "Score:";
            // 
            // textBoxNumberOfWords
            // 
            textBoxNumberOfWords.Location = new Point(12, 29);
            textBoxNumberOfWords.Name = "textBoxNumberOfWords";
            textBoxNumberOfWords.Size = new Size(67, 23);
            textBoxNumberOfWords.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 6;
            label1.Text = "# of words";
            // 
            // progressBarWordGame
            // 
            progressBarWordGame.Location = new Point(108, 197);
            progressBarWordGame.Name = "progressBarWordGame";
            progressBarWordGame.Size = new Size(206, 10);
            progressBarWordGame.TabIndex = 7;
            // 
            // frmWordGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 394);
            Controls.Add(progressBarWordGame);
            Controls.Add(label1);
            Controls.Add(textBoxNumberOfWords);
            Controls.Add(labelScore);
            Controls.Add(labelShuffleWord);
            Controls.Add(buttonNext);
            Controls.Add(textBoxWord);
            Controls.Add(buttonLoad);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmWordGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WordGame";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLoad;
        private TextBox textBoxWord;
        private Button buttonNext;
        private Label labelShuffleWord;
        private Label labelScore;
        private TextBox textBoxNumberOfWords;
        private Label label1;
        private ProgressBar progressBarWordGame;
    }
}