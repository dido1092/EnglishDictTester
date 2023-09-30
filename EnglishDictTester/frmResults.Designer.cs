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
            dataGridViewResults = new DataGridView();
            testIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lngNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bgWDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            enWDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            answerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            testsBindingSource = new BindingSource(components);
            buttonResultRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).BeginInit();
            ((System.ComponentModel.ISupportInitialize)testsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewResults
            // 
            dataGridViewResults.AutoGenerateColumns = false;
            dataGridViewResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResults.Columns.AddRange(new DataGridViewColumn[] { testIdDataGridViewTextBoxColumn, lngNameDataGridViewTextBoxColumn, bgWDataGridViewTextBoxColumn, enWDataGridViewTextBoxColumn, answerDataGridViewTextBoxColumn });
            dataGridViewResults.DataSource = testsBindingSource;
            dataGridViewResults.Location = new Point(22, 22);
            dataGridViewResults.Name = "dataGridViewResults";
            dataGridViewResults.RowTemplate.Height = 25;
            dataGridViewResults.Size = new Size(545, 356);
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
            buttonResultRefresh.Location = new Point(589, 22);
            buttonResultRefresh.Name = "buttonResultRefresh";
            buttonResultRefresh.Size = new Size(96, 34);
            buttonResultRefresh.TabIndex = 1;
            buttonResultRefresh.Text = "Refresh";
            buttonResultRefresh.UseVisualStyleBackColor = true;
            buttonResultRefresh.Click += buttonResultRefresh_Click;
            // 
            // frmResults
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 418);
            Controls.Add(buttonResultRefresh);
            Controls.Add(dataGridViewResults);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmResults";
            Text = "frmResults";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).EndInit();
            ((System.ComponentModel.ISupportInitialize)testsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewResults;
        private DataGridViewTextBoxColumn testIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lngNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bgWDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enWDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn;
        private BindingSource testsBindingSource;
        private Button buttonResultRefresh;
    }
}