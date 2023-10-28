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
using System.Runtime.Intrinsics.X86;
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

        private static decimal allRating = 0;
        private static decimal allWords = 0;
        private static string connectionString = DbConfig.ConnectionString;
        private static Dictionary<string, int> dictWordsWithHints = new Dictionary<string, int>();
        private static Dictionary<string, int> dictWords = new Dictionary<string, int>();
        private static Dictionary<string, int> dictWordsAnswers = new Dictionary<string, int>();

        EnglishDictTesterContext context = new EnglishDictTesterContext();

        private void chartHint_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoadTestNumber_Click(object sender, EventArgs e)
        {
            HashSet<int> testNumbers = new HashSet<int>();

            comboBoxTestNumber.Items.Clear();
            chartHint.Series.Clear();
            chartTimes.Series.Clear();
            chartAnswers.Series.Clear();
            dictWords.Clear();
            dictWordsWithHints.Clear();
            dictWordsAnswers.Clear();
            allRating = 0;
            allWords = 0;
            labelAllTestRate.Text = $"All Tests Rate: ";

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
                FillWordsWithTimesInDict(testNumber);
                FillWordsWithAnswersInDict(testNumber);
            }
        }
        private void FillWordsWithHintsInDict(int testNumber)
        {
            var words = context.Tests!.Select(w => new { w.lngName, w.bgW, w.enW, w.test, w.Hint }).Where(w => w.test == testNumber && w.Hint == true).ToList();

            foreach (var word in words)
            {
                if (word.lngName == "En")
                {
                    if (!dictWordsWithHints.ContainsKey(word.enW!))
                    {
                        dictWordsWithHints.Add(word.enW!, 0);
                    }
                    dictWordsWithHints[word.enW!] += 1;
                }
                else if (word.lngName == "Bg")
                {
                    if (!dictWordsWithHints.ContainsKey(word.bgW!))
                    {
                        dictWordsWithHints.Add(word.bgW!, 0);
                    }
                    dictWordsWithHints[word.bgW!] += 1;
                }
            }
            CreateChartSeriesHints();
        }
        private void FillWordsWithTimesInDict(int testNumber)
        {
            var words = context.Tests!.Select(w => new { w.lngName, w.bgW, w.enW, w.test }).Where(w => w.test == testNumber).ToList();

            foreach (var word in words)
            {
                if (word.lngName == "En")
                {
                    if (!dictWords.ContainsKey(word.enW!))
                    {
                        dictWords.Add(word.enW!, 0);
                    }
                    dictWords[word.enW!] += 1;
                }
                else if (word.lngName == "Bg")
                {
                    if (!dictWords.ContainsKey(word.bgW!))
                    {
                        dictWords.Add(word.bgW!, 0);
                    }
                    dictWords[word.bgW!] += 1;
                }
            }
            CreateChartSeriesTimes();
        }
        private void FillWordsWithAnswersInDict(int testNumber)
        {
            var words = context.Tests!.Select(w => new { w.lngName, w.bgW, w.enW, w.test, w.answer }).Where(w => w.test == testNumber).ToList();

            foreach (var word in words)
            {
                if (word.lngName == "En")
                {
                    if (word.answer == "correct")
                    {
                        if (!dictWordsAnswers.ContainsKey(word.enW!))
                        {
                            dictWordsAnswers.Add(word.enW!, 6);
                        }
                        //dictWordsAnswers[word.enW!] = 6;
                    }
                    else if (word.answer == "Incorrect")
                    {
                        if (!dictWordsAnswers.ContainsKey(word.enW!))
                        {
                            dictWordsAnswers.Add(word.enW!, 2);
                        }
                        //dictWordsAnswers[word.enW!] = 2;
                    }
                }
                else if (word.lngName == "Bg")
                {
                    if (word.answer == "correct")
                    {
                        if (!dictWordsAnswers.ContainsKey(word.bgW!))
                        {
                            dictWordsAnswers.Add(word.bgW!, 6);
                        }
                        //dictWordsAnswers[word.bgW!] = 6;
                    }
                    if (word.answer == "Incorrect")
                    {
                        if (!dictWordsAnswers.ContainsKey(word.bgW!))
                        {
                            dictWordsAnswers.Add(word.bgW!, 2);
                        }
                        //dictWordsAnswers[word.bgW!] = 2;
                    }
                }
            }
            CreateChartSeriesAnswers();
        }
        private void CreateChartSeriesHints()//Chart Hint
        {
            foreach (var word in dictWordsWithHints.OrderBy(w => w.Key))
            {
                if (chartHint.Series.IsUniqueName(word!.ToString()))
                {
                    chartHint.Series.Add($"{word.Key}").Points.AddXY($"Hint", word.Value);
                }
            }
        }
        private void CreateChartSeriesTimes()//Chart Times
        {
            int allValue = 0;
            foreach (var word in dictWords.OrderBy(w => w.Key))
            {
                allValue += word.Value;
                if (chartTimes.Series.IsUniqueName(word!.ToString()))
                {
                    chartTimes.Series.Add($"{word.Key}").Points.AddXY($"Times", word.Value);
                }
            }
            chartTimes.Series.Add($"All words: {allValue}");
        }
        private void CreateChartSeriesAnswers()//Chart Times
        {

            foreach (var word in dictWordsAnswers.OrderBy(w => w.Key))
            {
                allWords++;
                allRating += word.Value;
                if (chartAnswers.Series.IsUniqueName(word!.ToString()))
                {
                    chartAnswers.Series.Add($"{word.Key}").Points.AddXY($"Rating", word.Value);
                }
                else
                {
                    chartAnswers.Series.Add($"{word.Key}").Points.AddXY($"Rating", word.Value);
                }
            }
            chartAnswers.Series.Add($"Rate: {allRating / allWords:f2}");
        }
        private void chartTimes_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)// Button Calc WhitOut Hints
        {
            int testNumber = int.Parse(comboBoxTestNumber.Text);

            decimal evaluation = 0;
            allWords = 0;
            allRating = 0;

            chartAnswers.Series.Clear();

            CreateChartSeriesAnswers();

            var allHints = context.Tests!.Select(t => new { t.enW, t.test, t.Hint }).Where(t => t.Hint == true && t.test == testNumber).Count();

            evaluation = allHints * 4; //Еvaluation difference between 6 - 2

            decimal calcWithoutHints = (allRating - evaluation) / allWords;

            if (calcWithoutHints < 2)
            {
                chartAnswers.Series.Add($"Rate(whitout hints): 2");
            }
            else
            {
                chartAnswers.Series.Add($"Rate(whitout hints): {calcWithoutHints:f2}");
            }
        }

        private void buttonAllTestsRate_Click(object sender, EventArgs e)
        {
            //AllTestsRate();
        }

        private void AllTestsRate()
        {
            Dictionary<string, int> dictEvaluation = new Dictionary<string, int>();
            //chartAnswers.Series.Clear();

            //CreateChartSeriesAnswers();

            var allAnswers = context.Tests!.Select(t => new { t.enW, t.answer }).ToList();

            foreach (var a in allAnswers)
            {
                if (a.answer == "correct")
                {
                    if (!dictEvaluation.ContainsKey(a.enW!))
                    {
                        dictEvaluation.Add(a.enW!, 0);
                    }
                    dictEvaluation[a.enW!] = 6;
                }
                else if (a.answer == "Incorrect")
                {
                    if (!dictEvaluation.ContainsKey(a.enW!))
                    {
                        dictEvaluation.Add(a.enW!, 0);
                    }
                    dictEvaluation[a.enW!] = 2;
                }
            }
            double avg = dictEvaluation.Values.Average();

            //chartAnswers.Series.Add($"All Tests Rate: {dictEvaluation.Values.Average():F2}");
            labelAllTestRate.Text = $"All Tests Rate: {avg:F2}";
        }

        private void labelAllTestRate_Click(object sender, EventArgs e)
        {
            AllTestsRate();
        }
    }
}
