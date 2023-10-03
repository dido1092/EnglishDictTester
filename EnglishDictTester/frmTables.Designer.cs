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
            dataGridViewMap = new DataGridView();
            wordBgIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            wordEnIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            wordsEnBgBindingSource = new BindingSource(components);
            buttonRefresh = new Button();
            labelWordsBg = new Label();
            labelWordsEn = new Label();
            labelMappingTable = new Label();
            buttonDeleteWordsBG = new Button();
            buttonDeleteWordsEn = new Button();
            buttonDeleteMappingTable = new Button();
            textBoxBgId = new TextBox();
            textBoxEnId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonUpdateTableEn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wordBgBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wordEnBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMap).BeginInit();
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
            dataGridViewBg.Size = new Size(244, 309);
            dataGridViewBg.TabIndex = 0;
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
            dataGridViewEn.Location = new Point(281, 88);
            dataGridViewEn.Name = "dataGridViewEn";
            dataGridViewEn.RowTemplate.Height = 25;
            dataGridViewEn.Size = new Size(344, 309);
            dataGridViewEn.TabIndex = 1;
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
            // wordEnBindingSource
            // 
            wordEnBindingSource.DataSource = typeof(Data.Models.WordEn);
            // 
            // dataGridViewMap
            // 
            dataGridViewMap.AutoGenerateColumns = false;
            dataGridViewMap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMap.Columns.AddRange(new DataGridViewColumn[] { wordBgIdDataGridViewTextBoxColumn1, wordEnIdDataGridViewTextBoxColumn1 });
            dataGridViewMap.DataSource = wordsEnBgBindingSource;
            dataGridViewMap.Location = new Point(660, 88);
            dataGridViewMap.Name = "dataGridViewMap";
            dataGridViewMap.RowTemplate.Height = 25;
            dataGridViewMap.Size = new Size(244, 309);
            dataGridViewMap.TabIndex = 2;
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
            // wordsEnBgBindingSource
            // 
            wordsEnBgBindingSource.DataSource = typeof(Data.Models.WordsEnBg);
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(1024, 12);
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
            labelWordsEn.Location = new Point(281, 70);
            labelWordsEn.Name = "labelWordsEn";
            labelWordsEn.Size = new Size(59, 15);
            labelWordsEn.TabIndex = 5;
            labelWordsEn.Text = "Words EN";
            // 
            // labelMappingTable
            // 
            labelMappingTable.AutoSize = true;
            labelMappingTable.Location = new Point(660, 70);
            labelMappingTable.Name = "labelMappingTable";
            labelMappingTable.Size = new Size(78, 15);
            labelMappingTable.TabIndex = 6;
            labelMappingTable.Text = "Maping Table";
            // 
            // buttonDeleteWordsBG
            // 
            buttonDeleteWordsBG.Location = new Point(21, 403);
            buttonDeleteWordsBG.Name = "buttonDeleteWordsBG";
            buttonDeleteWordsBG.Size = new Size(84, 29);
            buttonDeleteWordsBG.TabIndex = 7;
            buttonDeleteWordsBG.Text = "Delete";
            buttonDeleteWordsBG.UseVisualStyleBackColor = true;
            buttonDeleteWordsBG.Click += buttonDeleteWordsBG_Click;
            // 
            // buttonDeleteWordsEn
            // 
            buttonDeleteWordsEn.Location = new Point(281, 403);
            buttonDeleteWordsEn.Name = "buttonDeleteWordsEn";
            buttonDeleteWordsEn.Size = new Size(84, 29);
            buttonDeleteWordsEn.TabIndex = 8;
            buttonDeleteWordsEn.Text = "Delete";
            buttonDeleteWordsEn.UseVisualStyleBackColor = true;
            buttonDeleteWordsEn.Click += buttonDeleteWordsEn_Click;
            // 
            // buttonDeleteMappingTable
            // 
            buttonDeleteMappingTable.Location = new Point(917, 148);
            buttonDeleteMappingTable.Name = "buttonDeleteMappingTable";
            buttonDeleteMappingTable.Size = new Size(147, 29);
            buttonDeleteMappingTable.TabIndex = 9;
            buttonDeleteMappingTable.Text = "Delete";
            buttonDeleteMappingTable.UseVisualStyleBackColor = true;
            buttonDeleteMappingTable.Click += buttonDeleteMappingTable_Click;
            // 
            // textBoxBgId
            // 
            textBoxBgId.Location = new Point(917, 107);
            textBoxBgId.Name = "textBoxBgId";
            textBoxBgId.Size = new Size(65, 23);
            textBoxBgId.TabIndex = 10;
            // 
            // textBoxEnId
            // 
            textBoxEnId.Location = new Point(999, 107);
            textBoxEnId.Name = "textBoxEnId";
            textBoxEnId.Size = new Size(65, 23);
            textBoxEnId.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(917, 89);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 12;
            label1.Text = "BgID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(999, 89);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 13;
            label2.Text = "EnID";
            // 
            // buttonUpdateTableEn
            // 
            buttonUpdateTableEn.Location = new Point(541, 403);
            buttonUpdateTableEn.Name = "buttonUpdateTableEn";
            buttonUpdateTableEn.Size = new Size(84, 29);
            buttonUpdateTableEn.TabIndex = 14;
            buttonUpdateTableEn.Text = "Update";
            buttonUpdateTableEn.UseVisualStyleBackColor = true;
            buttonUpdateTableEn.Click += buttonUpdateTableEn_Click;
            // 
            // frmTables
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 460);
            Controls.Add(buttonUpdateTableEn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxEnId);
            Controls.Add(textBoxBgId);
            Controls.Add(buttonDeleteMappingTable);
            Controls.Add(buttonDeleteWordsEn);
            Controls.Add(buttonDeleteWordsBG);
            Controls.Add(labelMappingTable);
            Controls.Add(labelWordsEn);
            Controls.Add(labelWordsBg);
            Controls.Add(buttonRefresh);
            Controls.Add(dataGridViewMap);
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewMap).EndInit();
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
        private BindingSource wordBgBindingSource;
        private BindingSource wordEnBindingSource;
        private BindingSource wordsEnBgBindingSource;
        private DataGridViewTextBoxColumn wordBgIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bgWordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn wordEnIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enWordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transcriptionsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn wordBgIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn wordEnIdDataGridViewTextBoxColumn1;
        private Button buttonDeleteWordsBG;
        private Button buttonDeleteWordsEn;
        private Button buttonDeleteMappingTable;
        private TextBox textBoxBgId;
        private TextBox textBoxEnId;
        private Label label1;
        private Label label2;
        private Button buttonUpdateTableEn;
    }
}