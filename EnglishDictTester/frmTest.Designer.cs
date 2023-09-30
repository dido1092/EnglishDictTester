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
            button1 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            buttonNextWord = new Button();
            buttonHint = new Button();
            comboBox2 = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(91, 40);
            button1.Name = "button1";
            button1.Size = new Size(83, 25);
            button1.TabIndex = 0;
            button1.Text = "Load words";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "5", "10", "15", "20", "25", "30", "50", "100" });
            comboBox1.Location = new Point(16, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(69, 23);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 24);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "# of words";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(246, 116);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 3;
            label2.Text = "WORD";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(218, 184);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 23);
            textBox1.TabIndex = 4;
            // 
            // buttonNextWord
            // 
            buttonNextWord.Location = new Point(381, 184);
            buttonNextWord.Name = "buttonNextWord";
            buttonNextWord.Size = new Size(75, 23);
            buttonNextWord.TabIndex = 5;
            buttonNextWord.Text = "Next word";
            buttonNextWord.UseVisualStyleBackColor = true;
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
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "En", "Bg" });
            comboBox2.Location = new Point(16, 90);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(69, 23);
            comboBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 72);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 8;
            label3.Text = "Language";
            // 
            // Test
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 407);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(buttonHint);
            Controls.Add(buttonNextWord);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Name = "Test";
            Text = "Test";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button buttonNextWord;
        private Button buttonHint;
        private ComboBox comboBox2;
        private Label label3;
    }
}