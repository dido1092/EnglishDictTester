namespace EnglishDictTester
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBoxWordBg = new TextBox();
            textBoxWordEn = new TextBox();
            textBoxTranscriptions = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonRecord = new Button();
            buttonMakeTest = new Button();
            wordsEnBgBindingSource = new BindingSource(components);
            buttonTables = new Button();
            buttonResults = new Button();
            buttonWordGame = new Button();
            ((System.ComponentModel.ISupportInitialize)wordsEnBgBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBoxWordBg
            // 
            textBoxWordBg.Location = new Point(27, 35);
            textBoxWordBg.Name = "textBoxWordBg";
            textBoxWordBg.Size = new Size(192, 23);
            textBoxWordBg.TabIndex = 0;
            // 
            // textBoxWordEn
            // 
            textBoxWordEn.Location = new Point(249, 35);
            textBoxWordEn.Name = "textBoxWordEn";
            textBoxWordEn.Size = new Size(192, 23);
            textBoxWordEn.TabIndex = 1;
            // 
            // textBoxTranscriptions
            // 
            textBoxTranscriptions.Location = new Point(249, 91);
            textBoxTranscriptions.Name = "textBoxTranscriptions";
            textBoxTranscriptions.Size = new Size(131, 23);
            textBoxTranscriptions.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 17);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 3;
            label1.Text = "Word Bg";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 17);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 4;
            label2.Text = "Word En";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 73);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 5;
            label3.Text = "Pronounce";
            // 
            // buttonRecord
            // 
            buttonRecord.Location = new Point(504, 35);
            buttonRecord.Name = "buttonRecord";
            buttonRecord.Size = new Size(120, 39);
            buttonRecord.TabIndex = 6;
            buttonRecord.Text = "Record";
            buttonRecord.UseVisualStyleBackColor = true;
            buttonRecord.Click += buttonRecord_Click;
            // 
            // buttonMakeTest
            // 
            buttonMakeTest.Location = new Point(541, 141);
            buttonMakeTest.Name = "buttonMakeTest";
            buttonMakeTest.Size = new Size(83, 33);
            buttonMakeTest.TabIndex = 7;
            buttonMakeTest.Text = "Make Test";
            buttonMakeTest.UseVisualStyleBackColor = true;
            buttonMakeTest.Click += buttonMakeTest_Click;
            // 
            // wordsEnBgBindingSource
            // 
            wordsEnBgBindingSource.DataSource = typeof(Data.Models.WordsEnBg);
            // 
            // buttonTables
            // 
            buttonTables.Location = new Point(541, 259);
            buttonTables.Name = "buttonTables";
            buttonTables.Size = new Size(83, 31);
            buttonTables.TabIndex = 9;
            buttonTables.Text = "Tables";
            buttonTables.UseVisualStyleBackColor = true;
            buttonTables.Click += button1_Click;
            // 
            // buttonResults
            // 
            buttonResults.Location = new Point(541, 316);
            buttonResults.Name = "buttonResults";
            buttonResults.Size = new Size(83, 31);
            buttonResults.TabIndex = 10;
            buttonResults.Text = "Results";
            buttonResults.UseVisualStyleBackColor = true;
            buttonResults.Click += buttonResults_Click;
            // 
            // buttonWordGame
            // 
            buttonWordGame.Location = new Point(541, 199);
            buttonWordGame.Name = "buttonWordGame";
            buttonWordGame.Size = new Size(83, 33);
            buttonWordGame.TabIndex = 11;
            buttonWordGame.Text = "Word Game";
            buttonWordGame.UseVisualStyleBackColor = true;
            buttonWordGame.Click += buttonWordGame_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 445);
            Controls.Add(buttonWordGame);
            Controls.Add(buttonResults);
            Controls.Add(buttonTables);
            Controls.Add(buttonMakeTest);
            Controls.Add(buttonRecord);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxTranscriptions);
            Controls.Add(textBoxWordEn);
            Controls.Add(textBoxWordBg);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EnBgDictTester";
            ((System.ComponentModel.ISupportInitialize)wordsEnBgBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxWordBg;
        private TextBox textBoxWordEn;
        private TextBox textBoxTranscriptions;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonRecord;
        private Button buttonMakeTest;
        private BindingSource wordsEnBgBindingSource;
        private Button buttonTables;
        private Button buttonResults;
        private Button buttonWordGame;
    }
}