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
            testIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lngNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bgId = new DataGridViewTextBoxColumn();
            enId = new DataGridViewTextBoxColumn();
            bgWDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            enWDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            answerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            testsBindingSource = new BindingSource(components);
            buttonResultRefresh = new Button();
            buttonUpdateResult = new Button();
            buttonDelete = new Button();
            buttonRemoveAllIncorrectTests = new Button();
            buttonRemoveAllCorrectTests = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).BeginInit();
            ((System.ComponentModel.ISupportInitialize)testsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewResults
            // 
            dataGridViewResults.AutoGenerateColumns = false;
            dataGridViewResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResults.Columns.AddRange(new DataGridViewColumn[] { testIdDataGridViewTextBoxColumn, lngNameDataGridViewTextBoxColumn, bgId, enId, bgWDataGridViewTextBoxColumn, enWDataGridViewTextBoxColumn, answerDataGridViewTextBoxColumn });
            dataGridViewResults.DataSource = testsBindingSource;
            dataGridViewResults.Location = new Point(21, 22);
            dataGridViewResults.Name = "dataGridViewResults";
            dataGridViewResults.RowTemplate.Height = 25;
            dataGridViewResults.Size = new Size(743, 591);
            dataGridViewResults.TabIndex = 0;
            // 
            // testIdDataGridViewTextBoxColumn
            // 
            testIdDataGridViewTextBoxColumn.DataPropertyName = "testId";
            testIdDataGridViewTextBoxColumn.HeaderText = "testId";
            testIdDataGridViewTextBoxColumn.Name = "testIdDataGridViewTextBoxColumn";
            // 
            // lngNameDataGridViewTextBoxColumn
            // 
            lngNameDataGridViewTextBoxColumn.DataPropertyName = "lngName";
            lngNameDataGridViewTextBoxColumn.HeaderText = "lngName";
            lngNameDataGridViewTextBoxColumn.Name = "lngNameDataGridViewTextBoxColumn";
            // 
            // bgId
            // 
            bgId.DataPropertyName = "bgId";
            bgId.HeaderText = "bgId";
            bgId.Name = "bgId";
            // 
            // enId
            // 
            enId.DataPropertyName = "enId";
            enId.HeaderText = "enId";
            enId.Name = "enId";
            // 
            // bgWDataGridViewTextBoxColumn
            // 
            bgWDataGridViewTextBoxColumn.DataPropertyName = "bgW";
            bgWDataGridViewTextBoxColumn.HeaderText = "bgW";
            bgWDataGridViewTextBoxColumn.Name = "bgWDataGridViewTextBoxColumn";
            // 
            // enWDataGridViewTextBoxColumn
            // 
            enWDataGridViewTextBoxColumn.DataPropertyName = "enW";
            enWDataGridViewTextBoxColumn.HeaderText = "enW";
            enWDataGridViewTextBoxColumn.Name = "enWDataGridViewTextBoxColumn";
            // 
            // answerDataGridViewTextBoxColumn
            // 
            answerDataGridViewTextBoxColumn.DataPropertyName = "answer";
            answerDataGridViewTextBoxColumn.HeaderText = "answer";
            answerDataGridViewTextBoxColumn.Name = "answerDataGridViewTextBoxColumn";
            // 
            // testsBindingSource
            // 
            testsBindingSource.DataSource = typeof(Data.Models.Tests);
            // 
            // buttonResultRefresh
            // 
            buttonResultRefresh.Location = new Point(781, 22);
            buttonResultRefresh.Name = "buttonResultRefresh";
            buttonResultRefresh.Size = new Size(93, 34);
            buttonResultRefresh.TabIndex = 1;
            buttonResultRefresh.Text = "Refresh";
            buttonResultRefresh.UseVisualStyleBackColor = true;
            buttonResultRefresh.Click += buttonResultRefresh_Click;
            // 
            // buttonUpdateResult
            // 
            buttonUpdateResult.Location = new Point(781, 92);
            buttonUpdateResult.Name = "buttonUpdateResult";
            buttonUpdateResult.Size = new Size(93, 32);
            buttonUpdateResult.TabIndex = 2;
            buttonUpdateResult.Text = "Update";
            buttonUpdateResult.UseVisualStyleBackColor = true;
            buttonUpdateResult.Click += buttonUpdateResult_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(781, 160);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(93, 32);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonRemoveAllIncorrectTests
            // 
            buttonRemoveAllIncorrectTests.Location = new Point(781, 226);
            buttonRemoveAllIncorrectTests.Name = "buttonRemoveAllIncorrectTests";
            buttonRemoveAllIncorrectTests.Size = new Size(93, 45);
            buttonRemoveAllIncorrectTests.TabIndex = 4;
            buttonRemoveAllIncorrectTests.Text = "Remove All Incorrect Tests";
            buttonRemoveAllIncorrectTests.UseVisualStyleBackColor = true;
            buttonRemoveAllIncorrectTests.Click += buttonRemoveAllIncorrectTests_Click;
            // 
            // buttonRemoveAllCorrectTests
            // 
            buttonRemoveAllCorrectTests.Location = new Point(781, 568);
            buttonRemoveAllCorrectTests.Name = "buttonRemoveAllCorrectTests";
            buttonRemoveAllCorrectTests.Size = new Size(93, 45);
            buttonRemoveAllCorrectTests.TabIndex = 5;
            buttonRemoveAllCorrectTests.Text = "Remove All Correct Tests";
            buttonRemoveAllCorrectTests.UseVisualStyleBackColor = true;
            buttonRemoveAllCorrectTests.Click += buttonRemoveAllCorrectTests_Click;
            // 
            // frmResults
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 655);
            Controls.Add(buttonRemoveAllCorrectTests);
            Controls.Add(buttonRemoveAllIncorrectTests);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdateResult);
            Controls.Add(buttonResultRefresh);
            Controls.Add(dataGridViewResults);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmResults";
            Text = "frmResults";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).EndInit();
            ((System.ComponentModel.ISupportInitialize)testsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewResults;
        private BindingSource testsBindingSource;
        private Button buttonResultRefresh;
        private DataGridViewTextBoxColumn testIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lngNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bgId;
        private DataGridViewTextBoxColumn enId;
        private DataGridViewTextBoxColumn bgWDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enWDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn;
        private Button buttonUpdateResult;
        private Button buttonDelete;
        private Button buttonRemoveAllIncorrectTests;
        private Button buttonRemoveAllCorrectTests;
    }
}