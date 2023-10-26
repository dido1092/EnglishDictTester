﻿using System.Drawing;
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
            testIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lngNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bgId = new DataGridViewTextBoxColumn();
            enId = new DataGridViewTextBoxColumn();
            bgWDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            enWDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            answerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateTime = new DataGridViewTextBoxColumn();
            testsBindingSource = new BindingSource(components);
            buttonResultRefresh = new Button();
            buttonUpdateResult = new Button();
            buttonDelete = new Button();
            buttonRemoveAllIncorrectTests = new Button();
            buttonRemoveAllCorrectTests = new Button();
            labelNumberOfTests = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).BeginInit();
            ((System.ComponentModel.ISupportInitialize)testsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewResults
            // 
            dataGridViewResults.AllowUserToOrderColumns = true;
            dataGridViewResults.AutoGenerateColumns = false;
            dataGridViewResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewResults.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResults.Columns.AddRange(new DataGridViewColumn[] { testIdDataGridViewTextBoxColumn, lngNameDataGridViewTextBoxColumn, bgId, enId, bgWDataGridViewTextBoxColumn, enWDataGridViewTextBoxColumn, answerDataGridViewTextBoxColumn, dateTime });
            dataGridViewResults.DataSource = testsBindingSource;
            dataGridViewResults.Location = new Point(12, 22);
            dataGridViewResults.Name = "dataGridViewResults";
            dataGridViewResults.RowTemplate.Height = 25;
            dataGridViewResults.Size = new Size(894, 591);
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
            bgId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            // dateTime
            // 
            dateTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateTime.DataPropertyName = "dateTime";
            dateTime.HeaderText = "dateTime";
            dateTime.Name = "dateTime";
            // 
            // testsBindingSource
            // 
            testsBindingSource.DataSource = typeof(Data.Models.Tests);
            // 
            // buttonResultRefresh
            // 
            buttonResultRefresh.Location = new Point(931, 22);
            buttonResultRefresh.Name = "buttonResultRefresh";
            buttonResultRefresh.Size = new Size(93, 34);
            buttonResultRefresh.TabIndex = 1;
            buttonResultRefresh.Text = "Refresh";
            buttonResultRefresh.UseVisualStyleBackColor = true;
            buttonResultRefresh.Click += buttonResultRefresh_Click;
            // 
            // buttonUpdateResult
            // 
            buttonUpdateResult.Location = new Point(931, 81);
            buttonUpdateResult.Name = "buttonUpdateResult";
            buttonUpdateResult.Size = new Size(93, 32);
            buttonUpdateResult.TabIndex = 2;
            buttonUpdateResult.Text = "Update";
            buttonUpdateResult.UseVisualStyleBackColor = true;
            buttonUpdateResult.Click += buttonUpdateResult_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(931, 142);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(93, 32);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonRemoveAllIncorrectTests
            // 
            buttonRemoveAllIncorrectTests.Location = new Point(931, 204);
            buttonRemoveAllIncorrectTests.Name = "buttonRemoveAllIncorrectTests";
            buttonRemoveAllIncorrectTests.Size = new Size(93, 45);
            buttonRemoveAllIncorrectTests.TabIndex = 4;
            buttonRemoveAllIncorrectTests.Text = "Remove All Incorrect Tests";
            buttonRemoveAllIncorrectTests.UseVisualStyleBackColor = true;
            buttonRemoveAllIncorrectTests.Click += buttonRemoveAllIncorrectTests_Click;
            // 
            // buttonRemoveAllCorrectTests
            // 
            buttonRemoveAllCorrectTests.Location = new Point(931, 568);
            buttonRemoveAllCorrectTests.Name = "buttonRemoveAllCorrectTests";
            buttonRemoveAllCorrectTests.Size = new Size(93, 45);
            buttonRemoveAllCorrectTests.TabIndex = 5;
            buttonRemoveAllCorrectTests.Text = "Remove All Correct Tests";
            buttonRemoveAllCorrectTests.UseVisualStyleBackColor = true;
            buttonRemoveAllCorrectTests.Click += buttonRemoveAllCorrectTests_Click;
            // 
            // labelNumberOfTests
            // 
            labelNumberOfTests.AutoSize = true;
            labelNumberOfTests.Location = new Point(775, 616);
            labelNumberOfTests.Name = "labelNumberOfTests";
            labelNumberOfTests.Size = new Size(96, 15);
            labelNumberOfTests.TabIndex = 6;
            labelNumberOfTests.Text = "Number of Tests:";
            // 
            // frmResults
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 655);
            Controls.Add(labelNumberOfTests);
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
        private Label labelNumberOfTests;
        private DataGridViewTextBoxColumn testIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lngNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bgId;
        private DataGridViewTextBoxColumn enId;
        private DataGridViewTextBoxColumn bgWDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enWDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateTime;
    }
}