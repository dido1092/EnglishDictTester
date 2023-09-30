using EnglishDictTester.Data;
using EnglishDictTester.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishDictTester
{
    public partial class frmTest : Form
    {
        EnglishDictTesterContext context = new EnglishDictTesterContext();
        int i = 0;
        int wordA = 0;
        int wordB = 0;
        //double score = 0;
        int correctAnswer = 0;
        string examWord = string.Empty;
        string translateWord = string.Empty;
        string[] arrWords;
        bool isFinish = false;
        Random rnd = new Random();
        Dictionary<string, string> dictWords = new Dictionary<string, string>();
        public frmTest()
        {
            InitializeComponent();
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if ((comboBoxLanguage.SelectedIndex == 0 || comboBoxLanguage.SelectedIndex == 1) && comboBoxNumberOfWords.Text != null)
            {
                correctAnswer = 0;
                int numberOfWords = 0;
                wordA = 0;
                wordB = 1;

                int arrayLength = int.Parse(comboBoxNumberOfWords.Text) * 2;
                arrWords = new string[arrayLength];

                var enWordsId = context.WordEns?.Select(i => new { i.WordEnId }).ToList();
                var bgWordsId = context.WordBgs?.Select(i => new { i.WordBgId }).ToList();

                var enWords = context.WordEns?.Select(e => new { e.EnWord }).ToList();
                var bgWords = context.WordBgs?.Select(b => new { b.BgWord }).ToList();

                var mapTableIDs = context.WordsEnBgs?.Select(enBg => new { enBg.WordBgId, enBg.WordEnId }).ToList();


                foreach (var mapTableID in mapTableIDs)
                {
                    string wordEn = string.Empty;
                    string wordBg = string.Empty;

                    int mapEnId = int.Parse(mapTableID.WordEnId.ToString());
                    var enIDs = context.WordEns?.Select(i => new { i.WordEnId, i.EnWord }).Where(w => w.WordEnId == mapEnId);

                    int mapBgId = int.Parse(mapTableID.WordBgId.ToString());
                    var bgIDs = context.WordBgs?.Select(i => new { i.WordBgId, i.BgWord }).Where(w => w.WordBgId == mapBgId);

                    foreach (var enID in enIDs)
                    {
                        var currentWord = context.WordEns?.Select(i => new { i.WordEnId, i.EnWord }).SingleOrDefault(w => w.WordEnId == mapEnId);
                        wordEn = currentWord.EnWord;
                    }
                    foreach (var bgID in bgIDs)
                    {
                        var currentWord = context.WordBgs?.Select(i => new { i.WordBgId, i.BgWord }).SingleOrDefault(w => w.WordBgId == mapBgId);
                        wordBg = currentWord.BgWord;
                    }
                    numberOfWords++;

                    //dictWords.Add(wordEn, wordBg);
                    if (comboBoxLanguage.SelectedIndex == 0)//En
                    {
                        arrWords[wordA] = wordEn;
                        arrWords[wordB] = wordBg;
                    }
                    else if (comboBoxLanguage.SelectedIndex == 1)//Bg
                    {
                        arrWords[wordA] = wordBg;
                        arrWords[wordB] = wordEn;
                    }
                    //arrWords[wordA] = wordEn;
                    //arrWords[wordB] = wordBg;
                    wordA += 2;
                    wordB += 2;
                    if (numberOfWords.ToString() == comboBoxNumberOfWords.Text)
                    {
                        break;
                    }
                }

                labelExamWord.Text = arrWords[i];
            }
        }

        private void buttonNextWord_Click(object sender, EventArgs e)
        {
            string writtenWord = string.Empty;
            if (isFinish)
            {
                return;
            }

            //rnd.Next(arrWords.Length);

            translateWord = arrWords[i + 1];

            writtenWord = textBoxTranslateWord.Text.ToUpper();

            if (writtenWord == translateWord)
            {
                correctAnswer++;
            }

            labelScore.Text = "Score: " + correctAnswer;

            if (i == arrWords.Length - 2)
            {
                MessageBox.Show("Finish!");
                isFinish = true;
            }
            if (i < arrWords.Length)
            {
                if (isFinish == false)
                {
                    i += 2;
                }

                if (i > 0)
                {
                    labelExamWord.Text = arrWords[i];
                    textBoxTranslateWord.Text = "";
                }
            }

        }

        private async void buttonLoadAllWords_Click(object sender, EventArgs e)
        {
            int numberOfRows = 0;

            if (comboBoxLanguage.Text == "En")
            {
                numberOfRows = await context.WordEns.CountAsync();
            }
            else if (comboBoxLanguage.Text == "Bg")
            {
                numberOfRows = await context.WordBgs.CountAsync();
            }

            labelAllWords.Text = numberOfRows.ToString();
            comboBoxNumberOfWords.Items.Clear();
            comboBoxNumberOfWords.Text = numberOfRows.ToString();
        }

        private void buttonHint_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrWords[i + 1]);
        }
    }
}
