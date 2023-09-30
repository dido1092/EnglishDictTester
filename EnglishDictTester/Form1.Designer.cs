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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonRecord = new Button();
            buttonMakeTest = new Button();
            dataGridView1 = new DataGridView();
            wordBgIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            wordEnIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            wordBgDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            wordEnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            wordsEnBgBindingSource = new BindingSource(components);
            wordBgBindingSource = new BindingSource(components);
            wordEnBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wordsEnBgBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wordBgBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wordEnBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(249, 35);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(249, 91);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(131, 23);
            textBox3.TabIndex = 2;
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
            label3.Size = new Size(75, 15);
            label3.TabIndex = 5;
            label3.Text = "Transcription";
            // 
            // buttonRecord
            // 
            buttonRecord.Location = new Point(504, 35);
            buttonRecord.Name = "buttonRecord";
            buttonRecord.Size = new Size(120, 39);
            buttonRecord.TabIndex = 6;
            buttonRecord.Text = "Record";
            buttonRecord.UseVisualStyleBackColor = true;
            // 
            // buttonMakeTest
            // 
            buttonMakeTest.Location = new Point(504, 203);
            buttonMakeTest.Name = "buttonMakeTest";
            buttonMakeTest.Size = new Size(92, 33);
            buttonMakeTest.TabIndex = 7;
            buttonMakeTest.Text = "Make Test";
            buttonMakeTest.UseVisualStyleBackColor = true;
            buttonMakeTest.Click += buttonMakeTest_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { wordBgIdDataGridViewTextBoxColumn, wordEnIdDataGridViewTextBoxColumn, wordBgDataGridViewTextBoxColumn, wordEnDataGridViewTextBoxColumn });
            dataGridView1.DataSource = wordsEnBgBindingSource;
            dataGridView1.Location = new Point(27, 203);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(443, 225);
            dataGridView1.TabIndex = 8;
            // 
            // wordBgIdDataGridViewTextBoxColumn
            // 
            wordBgIdDataGridViewTextBoxColumn.DataPropertyName = "WordBgId";
            wordBgIdDataGridViewTextBoxColumn.HeaderText = "WordBgId";
            wordBgIdDataGridViewTextBoxColumn.Name = "wordBgIdDataGridViewTextBoxColumn";
            // 
            // wordEnIdDataGridViewTextBoxColumn
            // 
            wordEnIdDataGridViewTextBoxColumn.DataPropertyName = "WordEnId";
            wordEnIdDataGridViewTextBoxColumn.HeaderText = "WordEnId";
            wordEnIdDataGridViewTextBoxColumn.Name = "wordEnIdDataGridViewTextBoxColumn";
            // 
            // wordBgDataGridViewTextBoxColumn
            // 
            wordBgDataGridViewTextBoxColumn.DataPropertyName = "WordBg";
            wordBgDataGridViewTextBoxColumn.HeaderText = "WordBg";
            wordBgDataGridViewTextBoxColumn.Name = "wordBgDataGridViewTextBoxColumn";
            // 
            // wordEnDataGridViewTextBoxColumn
            // 
            wordEnDataGridViewTextBoxColumn.DataPropertyName = "WordEn";
            wordEnDataGridViewTextBoxColumn.HeaderText = "WordEn";
            wordEnDataGridViewTextBoxColumn.Name = "wordEnDataGridViewTextBoxColumn";
            // 
            // wordsEnBgBindingSource
            // 
            wordsEnBgBindingSource.DataSource = typeof(Data.Models.WordsEnBg);
            // 
            // wordBgBindingSource
            // 
            wordBgBindingSource.DataSource = typeof(Data.Models.WordBg);
            // 
            // wordEnBindingSource
            // 
            wordEnBindingSource.DataSource = typeof(Data.Models.WordEn);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 484);
            Controls.Add(dataGridView1);
            Controls.Add(buttonMakeTest);
            Controls.Add(buttonRecord);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EnBgDictTester";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)wordsEnBgBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)wordBgBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)wordEnBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonRecord;
        private Button buttonMakeTest;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn wordBgIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn wordEnIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn wordBgDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn wordEnDataGridViewTextBoxColumn;
        private BindingSource wordsEnBgBindingSource;
        private BindingSource wordBgBindingSource;
        private BindingSource wordEnBindingSource;
    }
}