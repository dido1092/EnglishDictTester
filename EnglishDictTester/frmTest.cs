using EnglishDictTester.Data;
using EnglishDictTester.Data.Models;
using EnglishDictTester.Enumerators;
using EnglishDictTester.Get_Id_s;
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
        int correctAnswer = 0;
        string? correctWordBg = string.Empty;
        string translateWord = string.Empty;
        string[]? arrAllWords;
        string[]? arrSelectedWords;
        string[]? arrAllCorrectedWords;
        List<object>? lsEnIds = new List<object>();
        bool isFinish = false;
        bool isButtonLoadAllIncorrectAnswersIsClicked = false;
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
                arrAllWords = new string[arrayLength];

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
                    //string mapEnId = mapTableID.WordEnId.ToString();
                    var enIDs = context.WordEns?.Select(i => new { i.WordEnId, i.EnWord }).Where(w => w.WordEnId == mapEnId);

                    int mapBgId = int.Parse(mapTableID.WordBgId.ToString());
                    //string mapBgId = mapTableID.WordBgId.ToString();
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

                    if (comboBoxLanguage.SelectedIndex == 0)//En
                    {
                        arrAllWords[wordA] = wordEn;
                        arrAllWords[wordB] = wordBg;
                    }
                    else if (comboBoxLanguage.SelectedIndex == 1)//Bg
                    {
                        arrAllWords[wordA] = wordBg;
                        arrAllWords[wordB] = wordEn;
                    }

                    wordA += 2;
                    wordB += 2;
                    if (numberOfWords.ToString() == comboBoxNumberOfWords.Text)
                    {
                        break;
                    }
                }
                SelectedWords(numberOfWords);

                labelExamWord.Text = arrSelectedWords[i];
                isButtonLoadAllIncorrectAnswersIsClicked = false;
            }
        }

        private void SelectedWords(int numberOfWords)
        {
            arrSelectedWords = new string[numberOfWords * 2];

            for (int i = 0, j = 1; i < numberOfWords * 2; i += 2, j += 2)
            {
                if (j < numberOfWords * 2)
                {
                    int index = rnd.Next(arrAllWords.Length - 2);

                    if (index % 2 == 0)
                    {
                        arrSelectedWords[i] = arrAllWords[index];
                        arrSelectedWords[j] = arrAllWords[index + 1];
                    }
                    else
                    {
                        arrSelectedWords[i] = arrAllWords[index + 1];
                        arrSelectedWords[j] = arrAllWords[index + 2];
                    }
                }
                else
                {
                    break;
                }
            }
        }

        private void buttonNextWord_Click(object sender, EventArgs e)
        {
            string writtenWord = string.Empty;
            if (isFinish)
            {
                return;
            }


            if (isButtonLoadAllIncorrectAnswersIsClicked)
            {
                translateWord = arrAllCorrectedWords[i + 1];
            }
            else
            {
                translateWord = arrSelectedWords[i + 1];
            }
            writtenWord = textBoxTranslateWord.Text.ToUpper();

            if (writtenWord == translateWord)
            {
                correctAnswer++;
                InsertIntoTest("correct");
            }
            else
            {
                InsertIntoTest("Incorrect");
            }

            labelScore.Text = "Score: " + correctAnswer;

            if (i == arrSelectedWords.Length - 2)
            {
                MessageBox.Show("Finish!");
                isFinish = true;
            }
            if (i < arrSelectedWords.Length)
            {
                if (isFinish == false)
                {
                    i += 2;
                }

                if (i > 0)
                {
                    labelExamWord.Text = arrSelectedWords[i];
                    textBoxTranslateWord.Text = "";
                }
            }
        }
        private void InsertIntoTest(string getAnswer)
        {
            GetWordEnId getEnId = new GetWordEnId();
            GetWordBgId getBgId = new GetWordBgId();
            try
            {
                if (comboBoxLanguage.Text == "En")
                {
                    Tests t = new Tests
                    {
                        lngName = comboBoxLanguage.Text,
                        enW = labelExamWord.Text,
                        bgW = textBoxTranslateWord.Text,
                        answer = getAnswer,
                        enId = getEnId.GetWordEnID(labelExamWord.Text),
                        bgId = getBgId.GetWordBgID(textBoxTranslateWord.Text)
                    };
                    context.Add(t);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Enums.WordBg_Duplicated.ToString());
                throw;
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
            MessageBox.Show(arrSelectedWords[i + 1]);
        }

        private void buttonLoadAllIncorrectAnswers_Click(object sender, EventArgs e)
        {
            var enCorrectWordsId = context.Tests?.Select(t => new { t.enId, t.enW, t.answer }).Where(a => a.answer == "Incorrect").ToList();
            var enIds = enCorrectWordsId?.Select(w => new { w.enId }).ToList();


            labelIncorrectWords.Text = "Incorrect words: " + enIds?.Count().ToString();

            if (enIds != null)
            {
                //Fill Incorrect words into List

                foreach (var enId in enIds)
                {
                    lsEnIds?.Add(enId);
                }

                //List<int> lsEn = new List<int>();

                //foreach (var item in lsEnIds.ToString())
                //{
                //    lsEn = (int)item;

                //}
                CorrectBgWord();
            }
            isButtonLoadAllIncorrectAnswersIsClicked = true;
        }

        private void CorrectBgWord()
        {
            int count = 0;

            arrAllCorrectedWords = new string[lsEnIds.Count];

            foreach (var getIdEn in lsEnIds)
            {
                //string word = currentCorrectWord.Replace(" ", string.Empty);

                //var getCorrectNameEn = context.WordEns?.Select(i => new { i.WordEnId, i.EnWord }).SingleOrDefault(a => a.EnWord == currentCorrectWord);
                //int? getIdEn = getCorrectNameEn.WordEnId;
               // Int32? convertToInt = (Int32?)getIdEn;


                var mapTableIDs = context.WordsEnBgs?.Select(enBg => new { enBg.WordBgId, enBg.WordEnId }).SingleOrDefault(i => i.WordEnId.ToString() == getIdEn.ToString());

                int? correctIdBgAnalog = mapTableIDs.WordBgId;

                correctWordBg = context.WordBgs?.Select(x => new { x.WordBgId, x.BgWord }).SingleOrDefault(i => i.WordBgId == correctIdBgAnalog).ToString();

                arrAllCorrectedWords[count] = correctWordBg;
                count++;
            }
        }
    }
}
