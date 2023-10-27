using EnglishDictTester.Data;
using EnglishDictTester.Data.Common;
using FastReport.DataVisualization.Charting;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EnglishDictTester
{
    public partial class frmChart : Form
    {
        public frmChart()
        {
            InitializeComponent();
        }
        EnglishDictTesterContext context = new EnglishDictTesterContext();
        private static string connectionString = DbConfig.ConnectionString;
        private static Dictionary<string, int> dictWordsWithHints = new Dictionary<string, int>();
        private static Dictionary<string, int> dictWords = new Dictionary<string, int>();

        private void chartHint_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoadTestNumber_Click(object sender, EventArgs e)
        {
            HashSet<int> testNumbers = new HashSet<int>();

            comboBoxTestNumber.Items.Clear();
            chartHint.Series.Clear();
            chartTimes.Series.Clear();
            dictWords.Clear();
            dictWordsWithHints.Clear();


            var tests = context.Tests!.Select(t => t.test).ToList();

            testNumbers = tests.ToHashSet();

            //Fill comboBox
            foreach (var testN in testNumbers)
            {
                comboBoxTestNumber.Items.Add(testN);
            }

            if (comboBoxTestNumber.Text != "")
            {
                int testNumber = int.Parse(comboBoxTestNumber.Text);
                int numberOfTest = context.Tests!.Where(t => t.test == testNumber).Count();

                FillWordsWithHintsInDict(testNumber);
                FillWordsInDict(testNumber);
                //labelNumberOfWords.Text = $"Number of Words: {numberOfTest.ToString()}";
            }
        }
        private void FillWordsWithHintsInDict(int testNumber)
        {
            var words = context.Tests!.Select(w => new { w.enW, w.test, w.Hint }).Where(w => w.test == testNumber && w.Hint == true).ToList();

            foreach (var word in words)
            {
                if (!dictWordsWithHints.ContainsKey(word.enW!))
                {
                    dictWordsWithHints.Add(word.enW!, 0);
                }
                dictWordsWithHints[word.enW!] += 1;
            }
            CreateChartSeriesHints();
        }
        private void FillWordsInDict(int testNumber)
        {
            var words = context.Tests!.Select(w => new { w.enW, w.test }).Where(w => w.test == testNumber).ToList();

            foreach (var word in words)
            {
                if (!dictWords.ContainsKey(word.enW!))
                {
                    dictWords.Add(word.enW!, 0);
                }
                dictWords[word.enW!] += 1;
            }
            CreateChartSeries();
        }
        private void CreateChartSeriesHints()
        {
            foreach (var word in dictWordsWithHints)
            {
                if (chartHint.Series.IsUniqueName(word!.ToString()))
                {
                    chartHint.Series.Add($"{word.Key}").Points.AddXY($"Hint", word.Value);
                }
            }
        }
        private void CreateChartSeries()
        {
            foreach (var word in dictWords)
            {
                if (chartTimes.Series.IsUniqueName(word!.ToString()))
                {
                    chartTimes.Series.Add($"{word.Key}").Points.AddXY($"Times", word.Value);
                }
            }
        }
        private void chartTimes_Click(object sender, EventArgs e)
        {

        }
    }
}
