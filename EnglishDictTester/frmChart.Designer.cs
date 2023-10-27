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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            FastReport.DataVisualization.Charting.ChartArea chartArea5 = new FastReport.DataVisualization.Charting.ChartArea();
            FastReport.DataVisualization.Charting.Legend legend5 = new FastReport.DataVisualization.Charting.Legend();
            FastReport.DataVisualization.Charting.Title title5 = new FastReport.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChart));
            chartHint = new System.Windows.Forms.DataVisualization.Charting.Chart();
            comboBoxTestNumber = new ComboBox();
            buttonLoadTestNumber = new Button();
            chartTimes = new FastReport.DataVisualization.Charting.Chart();
            label1 = new Label();
            chartAnswers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonCalcWHints = new Button();
            buttonAllTestsRate = new Button();
            ((System.ComponentModel.ISupportInitialize)chartHint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartTimes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartAnswers).BeginInit();
            SuspendLayout();
            // 
            // chartHint
            // 
            chartArea4.Name = "ChartArea1";
            chartHint.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chartHint.Legends.Add(legend4);
            chartHint.Location = new Point(204, 60);
            chartHint.Name = "chartHint";
            chartHint.Size = new Size(494, 306);
            chartHint.TabIndex = 0;
            chartHint.Text = "chart1";
            title4.Name = "Hint";
            title4.Text = "Hint";
            chartHint.Titles.Add(title4);
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
            chartArea5.Name = "ChartArea1";
            chartTimes.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            chartTimes.Legends.Add(legend5);
            chartTimes.Location = new Point(204, 388);
            chartTimes.Name = "chartTimes";
            chartTimes.Size = new Size(494, 306);
            chartTimes.TabIndex = 3;
            chartTimes.Text = "chart1";
            title5.Name = "Times";
            title5.Text = "Times";
            chartTimes.Titles.Add(title5);
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
            chartArea6.Name = "ChartArea1";
            chartAnswers.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            chartAnswers.Legends.Add(legend6);
            chartAnswers.Location = new Point(715, 60);
            chartAnswers.Name = "chartAnswers";
            chartAnswers.Size = new Size(494, 306);
            chartAnswers.TabIndex = 5;
            chartAnswers.Text = "chart1";
            title6.Name = "Answers";
            title6.Text = "Answers";
            chartAnswers.Titles.Add(title6);
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
            // buttonAllTestsRate
            // 
            buttonAllTestsRate.Location = new Point(1088, 447);
            buttonAllTestsRate.Name = "buttonAllTestsRate";
            buttonAllTestsRate.Size = new Size(121, 32);
            buttonAllTestsRate.TabIndex = 7;
            buttonAllTestsRate.Text = "All Tests Rate";
            buttonAllTestsRate.UseVisualStyleBackColor = true;
            buttonAllTestsRate.Click += buttonAllTestsRate_Click;
            // 
            // frmChart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 734);
            Controls.Add(buttonAllTestsRate);
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
        private Button buttonAllTestsRate;
    }
}