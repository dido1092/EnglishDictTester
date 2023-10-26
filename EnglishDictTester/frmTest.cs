using EnglishDictTester.Data;
using EnglishDictTester.Data.Models;
using EnglishDictTester.Enumerators;
using EnglishDictTester.Get_Id_s;
using Microsoft.EntityFrameworkCore;
using System.Speech.Recognition;
using System.Data;
using System.Speech.Synthesis;
using System;
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
        int numberOfWords = 0;
        int countWords = 0;
        string translateWord = string.Empty;
        string[]? arrAllWords;
        string[]? arrSelectedWords;
        string[]? arrAllCorrectedBgWords;
        string[]? arrAllCorrectedEnWords;
        string[]? arrWords;
        List<object>? lsEnIds = new List<object>();
        bool isFinish = false;
        bool isButtonLoadAllIncorrectAnswersIsClicked = false;
        bool isButtonLoadSelectedIncorrectWordsClicked = false;
        bool isButtonLoadClicked = false;
        Random rnd = new Random();
        Dictionary<string, string> dictWords = new Dictionary<string, string>();
        Dictionary<string, int> dictResultWords = new Dictionary<string, int>();
        public frmTest()
        {
            InitializeComponent();
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (comboBoxLanguage.SelectedIndex == 0 || comboBoxLanguage.SelectedIndex == 1)
            {
                if (comboBoxNumberOfWords.Text != "")
                {
                    if (int.Parse(comboBoxNumberOfWords.Text) != 0)
                    {
                        i = 0;
                        wordA = 0;
                        wordB = 1;
                        countWords = 0;
                        isFinish = false;
                        correctAnswer = 0;
                        numberOfWords = 0;
                        dictResultWords.Clear();
                        richTextBoxTestResult.Clear();
                        isButtonLoadClicked = true;
                        ProgressBarTest.Maximum = 0;
                        labelScore.Text = "Score: 0";
                        textBoxTranslateWord.Text = "";
                        isButtonLoadAllIncorrectAnswersIsClicked = false;
                        isButtonLoadSelectedIncorrectWordsClicked = false;

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
                        if (comboBoxNumberOfWords.Text != "")
                        {
                            int cbNumberOfWords = int.Parse(comboBoxNumberOfWords.Text);

                            if (cbNumberOfWords != 0)
                            {
                                ProgressBarTest.Minimum = 0;
                                //ProgressBarTest.Value++;
                                ProgressBarTest.Maximum = cbNumberOfWords;

                            }
                        }
                        SelectedWords(numberOfWords);

                        labelExamWord.Text = arrSelectedWords[0];

                        AddFirstWord();

                        Pronounce();
                    }
                }
            }
        }

        private void SelectedWords(int numberOfWords)
        {
            arrSelectedWords = new string[numberOfWords * 2];

            for (int k = 0, j = 1; k < numberOfWords * 2; k += 2, j += 2)
            {
                if (j < numberOfWords * 2)
                {
                    int index = rnd.Next(arrAllWords.Length - 2);

                    if (index % 2 == 0)//En or Bg
                    {
                        arrSelectedWords[k] = arrAllWords[index];
                        arrSelectedWords[j] = arrAllWords[index + 1];
                    }
                    else
                    {
                        arrSelectedWords[k] = arrAllWords[index + 1];
                        arrSelectedWords[j] = arrAllWords[index + 2];
                    }
                }
                else
                {
                    break;
                }
            }
        }
        private void Pronounce()
        {
            if (comboBoxLanguage.Text == "En")
            {
                GetWordEnId getWordEnId1 = new GetWordEnId();
                string getExamWord = labelExamWord.Text;

                int? getEnId = getWordEnId1.GetWordEnID(getExamWord);

                var getPronounce = context.WordEns?.Select(x => new { x.EnWord, x.WordEnId, x.Transcriptions }).SingleOrDefault(p => p.WordEnId == getEnId);
                string? pronounce = getPronounce.Transcriptions;

                labelPronounce.Text = $"{pronounce}";
            }
            else if (comboBoxLanguage.Text == "Bg")
            {
                labelPronounce.Text = "";
            }
        }
        private void buttonNextWord_Click(object sender, EventArgs e)
        {
            int numberOfIncorrectWords = 0;

            countWords++;
            if (textBoxTranslateWord.Text != "" && countWords <= numberOfWords)
            {
                if (isButtonLoadClicked || isButtonLoadSelectedIncorrectWordsClicked)
                {
                    string writtenWord = string.Empty;
                    ProgressBarTest.Value++;

                    if (isFinish)
                    {
                        return;
                    }
                    if (isButtonLoadAllIncorrectAnswersIsClicked)
                    {
                        if (comboBoxLanguage.Text == "En" && arrAllCorrectedEnWords != null && arrAllCorrectedBgWords != null)
                        {
                            arrWords = arrAllCorrectedEnWords;
                            translateWord = arrAllCorrectedBgWords[i];


                        }
                        if (comboBoxLanguage.Text == "Bg" && arrAllCorrectedEnWords?.Length != 0 && arrAllCorrectedBgWords?.Length != 0)
                        {
                            arrWords = arrAllCorrectedBgWords;
                            translateWord = arrAllCorrectedEnWords[i];
                        }
                    }
                    else if (isButtonLoadClicked)
                    {
                        arrWords = arrSelectedWords;
                        translateWord = arrWords[i + 1];
                    }

                    writtenWord = textBoxTranslateWord.Text.ToUpper();

                    if (translateWord != "")
                    {
                        if (writtenWord == translateWord)
                        {
                            correctAnswer++;
                            InsertIntoTest("correct");
                        }
                        else
                        {
                            InsertIntoTest("Incorrect");
                        }
                    }
                    else
                    {
                        return;
                    }
                    labelScore.Text = "Score: " + correctAnswer;

                    if (isButtonLoadSelectedIncorrectWordsClicked && i == int.Parse(comboBoxNumberOfIncorrectWords.Text) - 1)
                    {
                        isFinish = true;
                        textBoxTranslateWord.Text = "";
                        correctAnswer = 0;
                        TestResults();
                        MessageBox.Show("Finish");

                    }
                    if (!isButtonLoadAllIncorrectAnswersIsClicked)
                    {

                        if (i == arrWords.Length - 2)
                        {
                            TestResults();
                            MessageBox.Show("Finish!");
                            isFinish = true;
                        }
                        if (i < arrWords.Length)
                        {
                            if (isFinish == false)
                            {
                                i += 2;
                            }
                        }
                    }
                    else
                    {
                        i++;
                        if (arrWords != null)
                        {
                            if (i == arrWords.Length)
                            {
                                TestResults();
                                MessageBox.Show("Finish!");
                                isFinish = true;
                                return;
                            }
                        }

                    }
                    if (comboBoxNumberOfIncorrectWords.Text == "")
                    {
                        comboBoxNumberOfIncorrectWords.Text = "0";
                    }
                    if ((!(i == int.Parse(comboBoxNumberOfIncorrectWords.Text))) && arrWords != null)//While i reach number of incorrect words
                    {
                        labelExamWord.Text = arrWords[i];

                    }

                    textBoxTranslateWord.Text = "";

                    Pronounce();

                    string currentWord = labelExamWord.Text;

                    if (!dictResultWords.ContainsKey(currentWord))
                    {
                        dictResultWords.Add(currentWord, 1);

                    }
                    else
                    {
                        dictResultWords[currentWord] += 1;
                    }


                    textBoxTranslateWord.Focus();
                }
            }
        }

        private void TestResults()
        {
            foreach (var word in dictResultWords.OrderByDescending(w => w.Value))
            {
                richTextBoxTestResult.Text += $"{word.Key} - {word.Value}\n";
            }
            labelTestResult.Text = $"Selected words: {dictResultWords.Count.ToString()}";
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
                        enW = labelExamWord.Text.ToUpper(),
                        bgW = textBoxTranslateWord.Text.ToUpper(),
                        answer = getAnswer,
                        enId = getEnId.GetWordEnID(labelExamWord.Text),
                        bgId = getBgId.GetWordBgID(textBoxTranslateWord.Text),
                        dateTime = DateTime.Now
                    };
                    context.Add(t);
                    context.SaveChanges();
                }
                else if (comboBoxLanguage.Text == "Bg")
                {
                    Tests t = new Tests
                    {
                        lngName = comboBoxLanguage.Text,
                        enW = textBoxTranslateWord.Text.ToUpper(),
                        bgW = labelExamWord.Text.ToUpper(),
                        answer = getAnswer,
                        enId = getEnId.GetWordEnID(textBoxTranslateWord.Text),
                        bgId = getBgId.GetWordBgID(labelExamWord.Text)
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
            isButtonLoadSelectedIncorrectWordsClicked = false;

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

        public async void buttonHint_ClickAsync(object sender, EventArgs e)
        {
            if (isButtonLoadClicked)
            {
                MessageBox.Show(arrSelectedWords[i + 1]);//i+1
            }
            if (isButtonLoadAllIncorrectAnswersIsClicked && comboBoxNumberOfIncorrectWords.Text != "")
            {
                if (int.Parse(comboBoxNumberOfIncorrectWords.Text) != 0)
                {
                    if (comboBoxLanguage.Text == "En")
                    {
                        MessageBox.Show(arrAllCorrectedBgWords[i]);
                    }
                    else if (comboBoxLanguage.Text == "Bg")
                    {
                        MessageBox.Show(arrAllCorrectedEnWords[i]);
                    }
                }
            }
        }
        private void buttonLoadAllIncorrectAnswers_Click(object sender, EventArgs e)
        {
            isButtonLoadClicked = false;
            isButtonLoadSelectedIncorrectWordsClicked = false;

            int count = 0;
            int? correctIdBgAnalog = 0;
            int? correctIdEnAnalog = 0;

            ClearVariablesAndControls();

            if (comboBoxLanguage.Text == "En")
            {
                var enCorrectWordsId = context.Tests?.Select(t => new { t.enId, t.bgId, t.lngName, t.enW, t.answer }).Where(a => a.answer == "Incorrect" && a.lngName == "En");
                var enIds = enCorrectWordsId?.Select(w => new { w.enId });

                arrAllCorrectedEnWords = new string[enIds!.Count()];
                arrAllCorrectedBgWords = new string[enIds!.Count()];

                labelIncorrectWords.Text = "Incorrect words: " + enIds?.Count().ToString();

                foreach (var getIdEn in enIds!)
                {
                    if (getIdEn != null)
                    {
                        var mapTableIDs = context.WordsEnBgs?.Select(enBg => new { enBg.WordEnId, enBg.WordBgId }).SingleOrDefault(x => x.WordEnId == getIdEn.enId!.Value);

                        correctIdBgAnalog = mapTableIDs?.WordBgId!.Value;
                        correctIdEnAnalog = mapTableIDs?.WordEnId!.Value;

                        var correctWordBg = context.WordBgs?.Select(x => new { x.WordBgId, x.BgWord }).SingleOrDefault(x => x.WordBgId.ToString() == correctIdBgAnalog.ToString());
                        var correctWordEn = context.WordEns?.Select(x => new { x.WordEnId, x.EnWord }).SingleOrDefault(x => x.WordEnId.ToString() == correctIdEnAnalog.ToString());

                        arrAllCorrectedBgWords[count] = correctWordBg!.BgWord!.ToString();
                        arrAllCorrectedEnWords[count] = correctWordEn!.EnWord!.ToString();



                        count++;
                    }
                }
                if (arrAllCorrectedEnWords.Length != 0)
                {
                    labelExamWord.Text = arrAllCorrectedEnWords[0];
                }

                comboBoxNumberOfIncorrectWords.Text = enIds?.Count().ToString();
            }

            if (comboBoxLanguage.Text == "Bg")
            {
                var bgCorrectWordsId = context.Tests?.Select(t => new { t.enId, t.bgId, t.lngName, t.enW, t.answer }).Where(a => a.answer == "Incorrect" && a.lngName == "Bg");
                var bgIds = bgCorrectWordsId?.Select(w => new { w.bgId });

                arrAllCorrectedEnWords = new string[bgIds.Count()];
                arrAllCorrectedBgWords = new string[bgIds.Count()];

                labelIncorrectWords.Text = "Incorrect words: " + bgIds?.Count().ToString();

                foreach (var getIdBg in bgIds)
                {
                    if (getIdBg != null)
                    {

                        var mapTableIDs = context.WordsEnBgs?.Select(enBg => new { enBg.WordEnId, enBg.WordBgId }).SingleOrDefault(x => x.WordBgId == getIdBg.bgId.Value);

                        correctIdBgAnalog = mapTableIDs.WordBgId.Value;
                        correctIdEnAnalog = mapTableIDs.WordEnId.Value;

                        var correctWordBg = context.WordBgs?.Select(x => new { x.WordBgId, x.BgWord }).SingleOrDefault(i => i.WordBgId.ToString() == correctIdBgAnalog.ToString());
                        var correctWordEn = context.WordEns?.Select(x => new { x.WordEnId, x.EnWord }).SingleOrDefault(i => i.WordEnId.ToString() == correctIdEnAnalog.ToString());

                        arrAllCorrectedBgWords[count] = correctWordBg.BgWord.ToString();
                        arrAllCorrectedEnWords[count] = correctWordEn.EnWord.ToString();

                        count++;
                    }
                }
                if (arrAllCorrectedBgWords.Length != 0)
                {
                    labelExamWord.Text = arrAllCorrectedBgWords[0];
                }

                comboBoxNumberOfIncorrectWords.Text = bgIds?.Count().ToString();
            }

            isButtonLoadAllIncorrectAnswersIsClicked = true;
        }

        private void ClearVariablesAndControls()
        {
            isFinish = false;
            textBoxTranslateWord.Text = "";
            labelScore.Text = "Score: 0";
            countWords = 0;
        }
        private void buttonLoadSelectedWords_Click(object sender, EventArgs e)
        {
            i = 0;
            countWords = 0;
            isFinish = false;
            correctAnswer = 0;
            ProgressBarTest.Maximum = 0;
            dictResultWords.Clear();
            richTextBoxTestResult.Clear();
            labelScore.Text = "Score: 0";
            textBoxTranslateWord.Text = "";
            isButtonLoadSelectedIncorrectWordsClicked = true;
            numberOfWords = int.Parse(comboBoxNumberOfIncorrectWords.Text);

            if (comboBoxNumberOfIncorrectWords.Text != "")
            {
                if (int.Parse(comboBoxNumberOfIncorrectWords.Text) != 0)
                {
                    if (comboBoxLanguage.Text == "En")
                    {
                        labelExamWord.Text = arrAllCorrectedEnWords[0];
                    }
                    else if (comboBoxLanguage.Text == "Bg")
                    {
                        labelExamWord.Text = arrAllCorrectedBgWords[0];
                    }
                    if (comboBoxNumberOfIncorrectWords.Text != "")
                    {
                        int cbNumberOfWords = int.Parse(comboBoxNumberOfIncorrectWords.Text);

                        if (cbNumberOfWords != 0)
                        {
                            ProgressBarTest.Minimum = 0;
                            ProgressBarTest.Maximum = cbNumberOfWords;
                        }
                    }
                    AddFirstWord();
                    Pronounce();
                }
            }
        }

        private void AddFirstWord()
        {
            if (!dictResultWords.ContainsKey(labelExamWord.Text))
            {
                dictResultWords.Add(labelExamWord.Text, 1);

            }
        }

        private void ReadText(string word)
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();
            speech.SpeakAsync(word);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (comboBoxLanguage.Text == "En")
            {
                string word = labelExamWord.Text;
                ReadText(word);
            }
        }
    }
}
