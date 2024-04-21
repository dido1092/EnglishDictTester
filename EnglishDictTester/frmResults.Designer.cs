using System.Drawing;
using System.Windows.Forms;

namespace EnglishDictTester
{
    partial class frmResults
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResults));
            dataGridViewResults = new DataGridView();
            testsBindingSource = new BindingSource(components);
            buttonResultRefresh = new Button();
            buttonUpdateResult = new Button();
            buttonDelete = new Button();
            buttonRemoveAllIncorrectTests = new Button();
            buttonRemoveAllCorrectTests = new Button();
            labelNumberOfWords = new Label();
            comboBoxResultTest = new ComboBox();
            buttonLoadTest = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            chartsToolStripMenuItem = new ToolStripMenuItem();
            testId = new DataGridViewTextBoxColumn();
            test = new DataGridViewTextBoxColumn();
            lng = new DataGridViewTextBoxColumn();
            bgWDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            enWDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            answerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hint = new DataGridViewCheckBoxColumn();
            dateTime = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).BeginInit();
            ((System.ComponentModel.ISupportInitialize)testsBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewResults
            // 
            dataGridViewResults.AllowUserToOrderColumns = true;
            dataGridViewResults.AutoGenerateColumns = false;
            dataGridViewResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewResults.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResults.Columns.AddRange(new DataGridViewColumn[] { testId, test, lng, bgWDataGridViewTextBoxColumn, enWDataGridViewTextBoxColumn, answerDataGridViewTextBoxColumn, hint, dateTime });
            dataGridViewResults.DataSource = testsBindingSource;
            dataGridViewResults.Location = new Point(12, 116);
            dataGridViewResults.Name = "dataGridViewResults";
            dataGridViewResults.RowTemplate.Height = 25;
            dataGridViewResults.Size = new Size(996, 557);
            dataGridViewResults.TabIndex = 0;
            // 
            // testsBindingSource
            // 
            testsBindingSource.DataSource = typeof(Data.Models.Tests);
            // 
            // buttonResultRefresh
            // 
            buttonResultRefresh.Location = new Point(1026, 116);
            buttonResultRefresh.Name = "buttonResultRefresh";
            buttonResultRefresh.Size = new Size(93, 34);
            buttonResultRefresh.TabIndex = 1;
            buttonResultRefresh.Text = "Refresh";
            buttonResultRefresh.UseVisualStyleBackColor = true;
            buttonResultRefresh.Click += buttonResultRefresh_Click;
            // 
            // buttonUpdateResult
            // 
            buttonUpdateResult.Location = new Point(1026, 187);
            buttonUpdateResult.Name = "buttonUpdateResult";
            buttonUpdateResult.Size = new Size(93, 32);
            buttonUpdateResult.TabIndex = 2;
            buttonUpdateResult.Text = "Update";
            buttonUpdateResult.UseVisualStyleBackColor = true;
            buttonUpdateResult.Click += buttonUpdateResult_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(1026, 249);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(93, 32);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonRemoveAllIncorrectTests
            // 
            buttonRemoveAllIncorrectTests.Location = new Point(1026, 308);
            buttonRemoveAllIncorrectTests.Name = "buttonRemoveAllIncorrectTests";
            buttonRemoveAllIncorrectTests.Size = new Size(93, 45);
            buttonRemoveAllIncorrectTests.TabIndex = 4;
            buttonRemoveAllIncorrectTests.Text = "Remove All Incorrect Tests";
            buttonRemoveAllIncorrectTests.UseVisualStyleBackColor = true;
            buttonRemoveAllIncorrectTests.Click += buttonRemoveAllIncorrectTests_Click;
            // 
            // buttonRemoveAllCorrectTests
            // 
            buttonRemoveAllCorrectTests.Location = new Point(1026, 614);
            buttonRemoveAllCorrectTests.Name = "buttonRemoveAllCorrectTests";
            buttonRemoveAllCorrectTests.Size = new Size(93, 45);
            buttonRemoveAllCorrectTests.TabIndex = 5;
            buttonRemoveAllCorrectTests.Text = "Remove All Correct Tests";
            buttonRemoveAllCorrectTests.UseVisualStyleBackColor = true;
            buttonRemoveAllCorrectTests.Click += buttonRemoveAllCorrectTests_Click;
            // 
            // labelNumberOfWords
            // 
            labelNumberOfWords.AutoSize = true;
            labelNumberOfWords.Location = new Point(867, 676);
            labelNumberOfWords.Name = "labelNumberOfWords";
            labelNumberOfWords.Size = new Size(102, 15);
            labelNumberOfWords.TabIndex = 6;
            labelNumberOfWords.Text = "Number of Words";
            // 
            // comboBoxResultTest
            // 
            comboBoxResultTest.FormattingEnabled = true;
            comboBoxResultTest.Location = new Point(172, 71);
            comboBoxResultTest.Name = "comboBoxResultTest";
            comboBoxResultTest.Size = new Size(65, 23);
            comboBoxResultTest.TabIndex = 7;
            // 
            // buttonLoadTest
            // 
            buttonLoadTest.Location = new Point(254, 71);
            buttonLoadTest.Name = "buttonLoadTest";
            buttonLoadTest.Size = new Size(75, 23);
            buttonLoadTest.TabIndex = 8;
            buttonLoadTest.Text = "Load Test";
            buttonLoadTest.UseVisualStyleBackColor = true;
            buttonLoadTest.Click += buttonLoadTest_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 53);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 9;
            label1.Text = "Test#";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1186, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { chartsToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(50, 20);
            toolStripMenuItem1.Text = "Menu";
            // 
            // chartsToolStripMenuItem
            // 
            chartsToolStripMenuItem.Name = "chartsToolStripMenuItem";
            chartsToolStripMenuItem.Size = new Size(108, 22);
            chartsToolStripMenuItem.Text = "Charts";
            chartsToolStripMenuItem.Click += chartsToolStripMenuItem_Click;
            // 
            // testId
            // 
            testId.DataPropertyName = "testId";
            testId.HeaderText = "testId";
            testId.Name = "testId";
            // 
            // test
            // 
            test.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            test.DataPropertyName = "test";
            test.HeaderText = "test";
            test.Name = "test";
            // 
            // lng
            // 
            lng.DataPropertyName = "lngName";
            lng.HeaderText = "lng";
            lng.Name = "lng";
            // 
            // bgWDataGridViewTextBoxColumn
            // 
            bgWDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bgWDataGridViewTextBoxColumn.DataPropertyName = "bgW";
            bgWDataGridViewTextBoxColumn.HeaderText = "bgW";
            bgWDataGridViewTextBoxColumn.Name = "bgWDataGridViewTextBoxColumn";
            // 
            // enWDataGridViewTextBoxColumn
            // 
            enWDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            enWDataGridViewTextBoxColumn.DataPropertyName = "enW";
            enWDataGridViewTextBoxColumn.HeaderText = "enW";
            enWDataGridViewTextBoxColumn.Name = "enWDataGridViewTextBoxColumn";
            // 
            // answerDataGridViewTextBoxColumn
            // 
            answerDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            answerDataGridViewTextBoxColumn.DataPropertyName = "answer";
            answerDataGridViewTextBoxColumn.HeaderText = "answer";
            answerDataGridViewTextBoxColumn.Name = "answerDataGridViewTextBoxColumn";
            // 
            // hint
            // 
            hint.DataPropertyName = "Hint";
            hint.HeaderText = "hint";
            hint.Name = "hint";
            // 
            // dateTime
            // 
            dateTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateTime.DataPropertyName = "dateTime";
            dateTime.HeaderText = "dateTime";
            dateTime.Name = "dateTime";
            // 
            // frmResults
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 708);
            Controls.Add(label1);
            Controls.Add(buttonLoadTest);
            Controls.Add(comboBoxResultTest);
            Controls.Add(labelNumberOfWords);
            Controls.Add(buttonRemoveAllCorrectTests);
            Controls.Add(buttonRemoveAllIncorrectTests);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdateResult);
            Controls.Add(buttonResultRefresh);
            Controls.Add(dataGridViewResults);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "frmResults";
            Text = "Results";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).EndInit();
            ((System.ComponentModel.ISupportInitialize)testsBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewResults;
        private BindingSource testsBindingSource;
        private Button buttonResultRefresh;
        private Button buttonUpdateResult;
        private Button buttonDelete;
        private Button buttonRemoveAllIncorrectTests;
        private Button buttonRemoveAllCorrectTests;
        private Label labelNumberOfWords;
        private ComboBox comboBoxResultTest;
        private Button buttonLoadTest;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem chartsToolStripMenuItem;
        private DataGridViewTextBoxColumn testId;
        private DataGridViewTextBoxColumn test;
        private DataGridViewTextBoxColumn lng;
        private DataGridViewTextBoxColumn bgWDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enWDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn hint;
        private DataGridViewTextBoxColumn dateTime;
    }
}