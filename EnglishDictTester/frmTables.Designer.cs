namespace EnglishDictTester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTables));
            dataGridViewBg = new DataGridView();
            wordBgIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bgWordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            wordBgBindingSource = new BindingSource(components);
            dataGridViewEn = new DataGridView();
            wordEnIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            enWordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transcriptionsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            wordEnBindingSource = new BindingSource(components);
            wordsEnBgBindingSource = new BindingSource(components);
            buttonRefresh = new Button();
            labelWordsBg = new Label();
            labelWordsEn = new Label();
            buttonDeleteWordsEn = new Button();
            buttonUpdateTableEn = new Button();
            labelTablesNumberOfWords = new Label();
            buttonUpdateTableBg = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wordBgBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wordEnBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wordsEnBgBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBg
            // 
            dataGridViewBg.AutoGenerateColumns = false;
            dataGridViewBg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBg.Columns.AddRange(new DataGridViewColumn[] { wordBgIdDataGridViewTextBoxColumn, bgWordDataGridViewTextBoxColumn });
            dataGridViewBg.DataSource = wordBgBindingSource;
            dataGridViewBg.Location = new Point(21, 88);
            dataGridViewBg.Name = "dataGridViewBg";
            dataGridViewBg.RowTemplate.Height = 25;
            dataGridViewBg.Size = new Size(312, 309);
            dataGridViewBg.TabIndex = 0;
            // 
            // wordBgIdDataGridViewTextBoxColumn
            // 
            wordBgIdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            wordBgIdDataGridViewTextBoxColumn.DataPropertyName = "WordBgId";
            wordBgIdDataGridViewTextBoxColumn.HeaderText = "WordBgId";
            wordBgIdDataGridViewTextBoxColumn.Name = "wordBgIdDataGridViewTextBoxColumn";
            wordBgIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            // 
            // bgWordDataGridViewTextBoxColumn
            // 
            bgWordDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bgWordDataGridViewTextBoxColumn.DataPropertyName = "BgWord";
            bgWordDataGridViewTextBoxColumn.HeaderText = "BgWord";
            bgWordDataGridViewTextBoxColumn.Name = "bgWordDataGridViewTextBoxColumn";
            // 
            // wordBgBindingSource
            // 
            wordBgBindingSource.DataSource = typeof(Data.Models.WordBg);
            // 
            // dataGridViewEn
            // 
            dataGridViewEn.AutoGenerateColumns = false;
            dataGridViewEn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEn.Columns.AddRange(new DataGridViewColumn[] { wordEnIdDataGridViewTextBoxColumn, enWordDataGridViewTextBoxColumn, transcriptionsDataGridViewTextBoxColumn });
            dataGridViewEn.DataSource = wordEnBindingSource;
            dataGridViewEn.Location = new Point(339, 88);
            dataGridViewEn.Name = "dataGridViewEn";
            dataGridViewEn.RowTemplate.Height = 25;
            dataGridViewEn.Size = new Size(366, 309);
            dataGridViewEn.TabIndex = 1;
            // 
            // wordEnIdDataGridViewTextBoxColumn
            // 
            wordEnIdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            wordEnIdDataGridViewTextBoxColumn.DataPropertyName = "WordEnId";
            wordEnIdDataGridViewTextBoxColumn.HeaderText = "WordEnId";
            wordEnIdDataGridViewTextBoxColumn.Name = "wordEnIdDataGridViewTextBoxColumn";
            // 
            // enWordDataGridViewTextBoxColumn
            // 
            enWordDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            // wordEnBindingSource
            // 
            wordEnBindingSource.DataSource = typeof(Data.Models.WordEn);
            // 
            // wordsEnBgBindingSource
            // 
            wordsEnBgBindingSource.DataSource = typeof(Data.Models.WordsEnBg);
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(716, 12);
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
            labelWordsEn.Location = new Point(339, 70);
            labelWordsEn.Name = "labelWordsEn";
            labelWordsEn.Size = new Size(59, 15);
            labelWordsEn.TabIndex = 5;
            labelWordsEn.Text = "Words EN";
            // 
            // buttonDeleteWordsEn
            // 
            buttonDeleteWordsEn.Location = new Point(621, 403);
            buttonDeleteWordsEn.Name = "buttonDeleteWordsEn";
            buttonDeleteWordsEn.Size = new Size(84, 29);
            buttonDeleteWordsEn.TabIndex = 8;
            buttonDeleteWordsEn.Text = "Delete";
            buttonDeleteWordsEn.UseVisualStyleBackColor = true;
            buttonDeleteWordsEn.Click += buttonDeleteWordsEn_Click;
            // 
            // buttonUpdateTableEn
            // 
            buttonUpdateTableEn.Location = new Point(339, 403);
            buttonUpdateTableEn.Name = "buttonUpdateTableEn";
            buttonUpdateTableEn.Size = new Size(84, 29);
            buttonUpdateTableEn.TabIndex = 14;
            buttonUpdateTableEn.Text = "Update";
            buttonUpdateTableEn.UseVisualStyleBackColor = true;
            buttonUpdateTableEn.Click += buttonUpdateTableEn_Click;
            // 
            // labelTablesNumberOfWords
            // 
            labelTablesNumberOfWords.AutoSize = true;
            labelTablesNumberOfWords.Location = new Point(21, 465);
            labelTablesNumberOfWords.Name = "labelTablesNumberOfWords";
            labelTablesNumberOfWords.Size = new Size(42, 15);
            labelTablesNumberOfWords.TabIndex = 15;
            labelTablesNumberOfWords.Text = "words:";
            // 
            // buttonUpdateTableBg
            // 
            buttonUpdateTableBg.Location = new Point(21, 403);
            buttonUpdateTableBg.Name = "buttonUpdateTableBg";
            buttonUpdateTableBg.Size = new Size(84, 29);
            buttonUpdateTableBg.TabIndex = 16;
            buttonUpdateTableBg.Text = "Update";
            buttonUpdateTableBg.UseVisualStyleBackColor = true;
            buttonUpdateTableBg.Click += buttonUpdateTableBg_Click;
            // 
            // frmTables
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 501);
            Controls.Add(buttonUpdateTableBg);
            Controls.Add(labelTablesNumberOfWords);
            Controls.Add(buttonUpdateTableEn);
            Controls.Add(buttonDeleteWordsEn);
            Controls.Add(labelWordsEn);
            Controls.Add(labelWordsBg);
            Controls.Add(buttonRefresh);
            Controls.Add(dataGridViewEn);
            Controls.Add(dataGridViewBg);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmTables";
            Text = "Tables";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBg).EndInit();
            ((System.ComponentModel.ISupportInitialize)wordBgBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEn).EndInit();
            ((System.ComponentModel.ISupportInitialize)wordEnBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)wordsEnBgBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewBg;
        private DataGridView dataGridViewEn;
        private Button buttonRefresh;
        private Label labelWordsBg;
        private Label labelWordsEn;
        private BindingSource wordBgBindingSource;
        private BindingSource wordEnBindingSource;
        private BindingSource wordsEnBgBindingSource;
        private Button buttonDeleteWordsEn;
        private Button buttonUpdateTableEn;
        private DataGridViewTextBoxColumn wordBgIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bgWordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn wordEnIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enWordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transcriptionsDataGridViewTextBoxColumn;
        private Label labelTablesNumberOfWords;
        private Button buttonUpdateTableBg;
    }
}