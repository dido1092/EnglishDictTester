namespace EnglishDictTester
{
    partial class frmChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            FastReport.DataVisualization.Charting.ChartArea chartArea2 = new FastReport.DataVisualization.Charting.ChartArea();
            FastReport.DataVisualization.Charting.Legend legend2 = new FastReport.DataVisualization.Charting.Legend();
            FastReport.DataVisualization.Charting.Title title2 = new FastReport.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChart));
            chartHint = new System.Windows.Forms.DataVisualization.Charting.Chart();
            comboBoxTestNumber = new ComboBox();
            buttonLoadTestNumber = new Button();
            chartTimes = new FastReport.DataVisualization.Charting.Chart();
            label1 = new Label();
            chartAnswers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonCalcWHints = new Button();
            labelAllTestRate = new Label();
            labelWords = new Label();
            ((System.ComponentModel.ISupportInitialize)chartHint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartTimes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartAnswers).BeginInit();
            SuspendLayout();
            // 
            // chartHint
            // 
            chartArea1.Name = "ChartArea1";
            chartHint.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartHint.Legends.Add(legend1);
            chartHint.Location = new Point(204, 60);
            chartHint.Name = "chartHint";
            chartHint.Size = new Size(494, 306);
            chartHint.TabIndex = 0;
            chartHint.Text = "chart1";
            title1.Name = "Hint";
            title1.Text = "Hint";
            chartHint.Titles.Add(title1);
            chartHint.Click += chartHint_Click;
            // 
            // comboBoxTestNumber
            // 
            comboBoxTestNumber.FormattingEnabled = true;
            comboBoxTestNumber.Location = new Point(12, 60);
            comboBoxTestNumber.Name = "comboBoxTestNumber";
            comboBoxTestNumber.Size = new Size(78, 23);
            comboBoxTestNumber.TabIndex = 1;
            // 
            // buttonLoadTestNumber
            // 
            buttonLoadTestNumber.Location = new Point(96, 60);
            buttonLoadTestNumber.Name = "buttonLoadTestNumber";
            buttonLoadTestNumber.Size = new Size(75, 23);
            buttonLoadTestNumber.TabIndex = 2;
            buttonLoadTestNumber.Text = "Load Test";
            buttonLoadTestNumber.UseVisualStyleBackColor = true;
            buttonLoadTestNumber.Click += buttonLoadTestNumber_Click;
            // 
            // chartTimes
            // 
            chartArea2.Name = "ChartArea1";
            chartTimes.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartTimes.Legends.Add(legend2);
            chartTimes.Location = new Point(204, 388);
            chartTimes.Name = "chartTimes";
            chartTimes.Size = new Size(494, 306);
            chartTimes.TabIndex = 3;
            chartTimes.Text = "chart1";
            title2.Name = "Times";
            title2.Text = "Times";
            chartTimes.Titles.Add(title2);
            chartTimes.Click += chartTimes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 4;
            label1.Text = "Test#";
            // 
            // chartAnswers
            // 
            chartArea3.Name = "ChartArea1";
            chartAnswers.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartAnswers.Legends.Add(legend3);
            chartAnswers.Location = new Point(715, 60);
            chartAnswers.Name = "chartAnswers";
            chartAnswers.Size = new Size(494, 306);
            chartAnswers.TabIndex = 5;
            chartAnswers.Text = "chart1";
            title3.Name = "Answers";
            title3.Text = "Answers";
            chartAnswers.Titles.Add(title3);
            // 
            // buttonCalcWHints
            // 
            buttonCalcWHints.Location = new Point(1088, 388);
            buttonCalcWHints.Name = "buttonCalcWHints";
            buttonCalcWHints.Size = new Size(121, 32);
            buttonCalcWHints.TabIndex = 6;
            buttonCalcWHints.Text = "Calc Without Hints";
            buttonCalcWHints.UseVisualStyleBackColor = true;
            buttonCalcWHints.Click += button1_Click;
            // 
            // labelAllTestRate
            // 
            labelAllTestRate.AutoSize = true;
            labelAllTestRate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelAllTestRate.Location = new Point(715, 399);
            labelAllTestRate.Name = "labelAllTestRate";
            labelAllTestRate.Size = new Size(107, 21);
            labelAllTestRate.TabIndex = 8;
            labelAllTestRate.Text = "All Test Rate: ";
            labelAllTestRate.Click += labelAllTestRate_Click;
            // 
            // labelWords
            // 
            labelWords.AutoSize = true;
            labelWords.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelWords.Location = new Point(715, 435);
            labelWords.Name = "labelWords";
            labelWords.Size = new Size(58, 21);
            labelWords.TabIndex = 9;
            labelWords.Text = "Words:";
            // 
            // frmChart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 734);
            Controls.Add(labelWords);
            Controls.Add(labelAllTestRate);
            Controls.Add(buttonCalcWHints);
            Controls.Add(chartAnswers);
            Controls.Add(label1);
            Controls.Add(chartTimes);
            Controls.Add(buttonLoadTestNumber);
            Controls.Add(comboBoxTestNumber);
            Controls.Add(chartHint);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmChart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Charts";
            ((System.ComponentModel.ISupportInitialize)chartHint).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartTimes).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartAnswers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartHint;
        private ComboBox comboBoxTestNumber;
        private Button buttonLoadTestNumber;
        private FastReport.DataVisualization.Charting.Chart chartTimes;
        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAnswers;
        private Button buttonCalcWHints;
        private Label labelAllTestRate;
        private Label labelWords;
    }
}