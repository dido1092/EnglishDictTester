﻿namespace EnglishDictTester
{
    partial class frmTables
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
            dataGridViewBg = new DataGridView();
            dataGridViewEn = new DataGridView();
            dataGridViewMap = new DataGridView();
            buttonRefresh = new Button();
            labelWordsBg = new Label();
            labelWordsEn = new Label();
            labelMappingTable = new Label();
            wordBgBindingSource = new BindingSource(components);
            wordBgIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bgWordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            wordsEnBgsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            wordEnBindingSource = new BindingSource(components);
            wordEnIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            enWordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transcriptionsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            wordsEnBgsDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            wordsEnBgBindingSource = new BindingSource(components);
            wordBgIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            wordEnIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            wordBgDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            wordEnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wordBgBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wordEnBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wordsEnBgBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBg
            // 
            dataGridViewBg.AutoGenerateColumns = false;
            dataGridViewBg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBg.Columns.AddRange(new DataGridViewColumn[] { wordBgIdDataGridViewTextBoxColumn, bgWordDataGridViewTextBoxColumn, wordsEnBgsDataGridViewTextBoxColumn });
            dataGridViewBg.DataSource = wordBgBindingSource;
            dataGridViewBg.Location = new Point(21, 88);
            dataGridViewBg.Name = "dataGridViewBg";
            dataGridViewBg.RowTemplate.Height = 25;
            dataGridViewBg.Size = new Size(343, 309);
            dataGridViewBg.TabIndex = 0;
            // 
            // dataGridViewEn
            // 
            dataGridViewEn.AutoGenerateColumns = false;
            dataGridViewEn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEn.Columns.AddRange(new DataGridViewColumn[] { wordEnIdDataGridViewTextBoxColumn, enWordDataGridViewTextBoxColumn, transcriptionsDataGridViewTextBoxColumn, wordsEnBgsDataGridViewTextBoxColumn1 });
            dataGridViewEn.DataSource = wordEnBindingSource;
            dataGridViewEn.Location = new Point(370, 88);
            dataGridViewEn.Name = "dataGridViewEn";
            dataGridViewEn.RowTemplate.Height = 25;
            dataGridViewEn.Size = new Size(443, 309);
            dataGridViewEn.TabIndex = 1;
            // 
            // dataGridViewMap
            // 
            dataGridViewMap.AutoGenerateColumns = false;
            dataGridViewMap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMap.Columns.AddRange(new DataGridViewColumn[] { wordBgIdDataGridViewTextBoxColumn1, wordEnIdDataGridViewTextBoxColumn1, wordBgDataGridViewTextBoxColumn, wordEnDataGridViewTextBoxColumn });
            dataGridViewMap.DataSource = wordsEnBgBindingSource;
            dataGridViewMap.Location = new Point(833, 88);
            dataGridViewMap.Name = "dataGridViewMap";
            dataGridViewMap.RowTemplate.Height = 25;
            dataGridViewMap.Size = new Size(445, 309);
            dataGridViewMap.TabIndex = 2;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(21, 12);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(109, 42);
            buttonRefresh.TabIndex = 3;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // labelWordsBg
            // 
            labelWordsBg.AutoSize = true;
            labelWordsBg.Location = new Point(21, 70);
            labelWordsBg.Name = "labelWordsBg";
            labelWordsBg.Size = new Size(59, 15);
            labelWordsBg.TabIndex = 4;
            labelWordsBg.Text = "Words BG";
            // 
            // labelWordsEn
            // 
            labelWordsEn.AutoSize = true;
            labelWordsEn.Location = new Point(370, 70);
            labelWordsEn.Name = "labelWordsEn";
            labelWordsEn.Size = new Size(59, 15);
            labelWordsEn.TabIndex = 5;
            labelWordsEn.Text = "Words EN";
            // 
            // labelMappingTable
            // 
            labelMappingTable.AutoSize = true;
            labelMappingTable.Location = new Point(833, 70);
            labelMappingTable.Name = "labelMappingTable";
            labelMappingTable.Size = new Size(78, 15);
            labelMappingTable.TabIndex = 6;
            labelMappingTable.Text = "Maping Table";
            // 
            // wordBgBindingSource
            // 
            wordBgBindingSource.DataSource = typeof(Data.Models.WordBg);
            // 
            // wordBgIdDataGridViewTextBoxColumn
            // 
            wordBgIdDataGridViewTextBoxColumn.DataPropertyName = "WordBgId";
            wordBgIdDataGridViewTextBoxColumn.HeaderText = "WordBgId";
            wordBgIdDataGridViewTextBoxColumn.Name = "wordBgIdDataGridViewTextBoxColumn";
            // 
            // bgWordDataGridViewTextBoxColumn
            // 
            bgWordDataGridViewTextBoxColumn.DataPropertyName = "BgWord";
            bgWordDataGridViewTextBoxColumn.HeaderText = "BgWord";
            bgWordDataGridViewTextBoxColumn.Name = "bgWordDataGridViewTextBoxColumn";
            // 
            // wordsEnBgsDataGridViewTextBoxColumn
            // 
            wordsEnBgsDataGridViewTextBoxColumn.DataPropertyName = "WordsEnBgs";
            wordsEnBgsDataGridViewTextBoxColumn.HeaderText = "WordsEnBgs";
            wordsEnBgsDataGridViewTextBoxColumn.Name = "wordsEnBgsDataGridViewTextBoxColumn";
            // 
            // wordEnBindingSource
            // 
            wordEnBindingSource.DataSource = typeof(Data.Models.WordEn);
            // 
            // wordEnIdDataGridViewTextBoxColumn
            // 
            wordEnIdDataGridViewTextBoxColumn.DataPropertyName = "WordEnId";
            wordEnIdDataGridViewTextBoxColumn.HeaderText = "WordEnId";
            wordEnIdDataGridViewTextBoxColumn.Name = "wordEnIdDataGridViewTextBoxColumn";
            // 
            // enWordDataGridViewTextBoxColumn
            // 
            enWordDataGridViewTextBoxColumn.DataPropertyName = "EnWord";
            enWordDataGridViewTextBoxColumn.HeaderText = "EnWord";
            enWordDataGridViewTextBoxColumn.Name = "enWordDataGridViewTextBoxColumn";
            // 
            // transcriptionsDataGridViewTextBoxColumn
            // 
            transcriptionsDataGridViewTextBoxColumn.DataPropertyName = "Transcriptions";
            transcriptionsDataGridViewTextBoxColumn.HeaderText = "Transcriptions";
            transcriptionsDataGridViewTextBoxColumn.Name = "transcriptionsDataGridViewTextBoxColumn";
            // 
            // wordsEnBgsDataGridViewTextBoxColumn1
            // 
            wordsEnBgsDataGridViewTextBoxColumn1.DataPropertyName = "WordsEnBgs";
            wordsEnBgsDataGridViewTextBoxColumn1.HeaderText = "WordsEnBgs";
            wordsEnBgsDataGridViewTextBoxColumn1.Name = "wordsEnBgsDataGridViewTextBoxColumn1";
            // 
            // wordsEnBgBindingSource
            // 
            wordsEnBgBindingSource.DataSource = typeof(Data.Models.WordsEnBg);
            // 
            // wordBgIdDataGridViewTextBoxColumn1
            // 
            wordBgIdDataGridViewTextBoxColumn1.DataPropertyName = "WordBgId";
            wordBgIdDataGridViewTextBoxColumn1.HeaderText = "WordBgId";
            wordBgIdDataGridViewTextBoxColumn1.Name = "wordBgIdDataGridViewTextBoxColumn1";
            // 
            // wordEnIdDataGridViewTextBoxColumn1
            // 
            wordEnIdDataGridViewTextBoxColumn1.DataPropertyName = "WordEnId";
            wordEnIdDataGridViewTextBoxColumn1.HeaderText = "WordEnId";
            wordEnIdDataGridViewTextBoxColumn1.Name = "wordEnIdDataGridViewTextBoxColumn1";
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
            // frmTables
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 460);
            Controls.Add(labelMappingTable);
            Controls.Add(labelWordsEn);
            Controls.Add(labelWordsBg);
            Controls.Add(buttonRefresh);
            Controls.Add(dataGridViewMap);
            Controls.Add(dataGridViewEn);
            Controls.Add(dataGridViewBg);
            Name = "frmTables";
            Text = "Tables";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBg).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMap).EndInit();
            ((System.ComponentModel.ISupportInitialize)wordBgBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)wordEnBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)wordsEnBgBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewBg;
        private DataGridView dataGridViewEn;
        private DataGridView dataGridViewMap;
        private Button buttonRefresh;
        private Label labelWordsBg;
        private Label labelWordsEn;
        private Label labelMappingTable;
        private DataGridViewTextBoxColumn wordBgIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bgWordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn wordsEnBgsDataGridViewTextBoxColumn;
        private BindingSource wordBgBindingSource;
        private DataGridViewTextBoxColumn wordEnIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enWordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transcriptionsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn wordsEnBgsDataGridViewTextBoxColumn1;
        private BindingSource wordEnBindingSource;
        private DataGridViewTextBoxColumn wordBgIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn wordEnIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn wordBgDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn wordEnDataGridViewTextBoxColumn;
        private BindingSource wordsEnBgBindingSource;
    }
}