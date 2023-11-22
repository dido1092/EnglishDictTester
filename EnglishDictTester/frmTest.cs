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
        int indexEn = 0;
        int indexBg = 0;
        int correctAnswer = 0;
        int numberOfWords = 0;
        int countWords = 0;
        int counterWords = 0;
        int counterAddToSelectedWords = 0;
        int getTestNumber = 0;
        string translateWord = string.Empty;
        string[]? arrAllWords;
        string[]? arrSelectedWords;
        string[]? arrAllCorrectedBgWords;
        string[]? arrAllCorrectedEnWords;
        string[]? arrWords;
        List<string> allWords = new List<string>();
        List<object>? lsEnIds = new List<object>();
        List<string> selectedWords = new List<string>();
        bool isFinish = false;
        bool isButtonLoadAllIncorrectAnswersIsClicked = false;
        bool isButtonLoadSelectedIncorrectWordsClicked = false;
        bool isbuttonIncludeWordsClicked = false;
        bool isButtonLoadClicked = false;
        bool isButtonHintClicked = false;
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
                //if (comboBoxNumberOfWords.Text != "" && comboBoxTestNumber.Text != "")
                if (comboBoxNumberOfWords.Text != "")
                {
                    if (int.Parse(comboBoxNumberOfWords.Text) != 0)
                    {
                        i = 0;
                        indexEn = 0;
                        indexBg = 1;
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
                        isButtonHintClicked = false;
                        //checkBoxSoundOnly.Checked = true;
                        isButtonLoadAllIncorrectAnswersIsClicked = false;
                        isButtonLoadSelectedIncorrectWordsClicked = false;

                        //getTestNumber = context.Tests!.Select(t => t.test).OrderByDescending(t => t).FirstOrDefaultAsync().Result;


                        //var enWordsId = context.WordEns?.Select(i => new { i.WordEnId }).ToList();
                        //var bgWordsId = context.WordBgs?.Select(i => new { i.WordBgId }).ToList();

                        //var enWords = context.WordEns?.Select(e => new { e.EnWord }).ToList();
                        //var bgWords = context.WordBgs?.Select(b => new { b.BgWord }).ToList();

                        var mapTableIDs = context.WordsEnBgs?.Select(enBg => new { enBg.WordBgId, enBg.WordEnId }).ToList();

                        if (isbuttonIncludeWordsClicked)
                        {
                            arrAllWords = new string[mapTableIDs!.Count * 2];
                        }
                        else
                        {
                            int arrayLength = int.Parse(comboBoxNumberOfWords.Text) * 2;
                            arrAllWords = new string[arrayLength];
                        }

                        foreach (var mapTableID in mapTableIDs!)
                        {
                            string wordEn = string.Empty;
                            string wordBg = string.Empty;

                            int mapEnId = int.Parse(mapTableID.WordEnId.ToString()!);
                            var enIDs = context.WordEns?.Select(i => new { i.WordEnId, i.EnWord }).Where(w => w.WordEnId == mapEnId);

                            int mapBgId = int.Parse(mapTableID.WordBgId.ToString()!);
                            var bgIDs = context.WordBgs?.Select(i => new { i.WordBgId, i.BgWord }).Where(w => w.WordBgId == mapBgId);

                            foreach (var enID in enIDs!)
                            {
                                var currentWord = context.WordEns?.Select(i => new { i.WordEnId, i.EnWord }).SingleOrDefault(w => w.WordEnId == mapEnId);
                                wordEn = currentWord!.EnWord!;
                            }
                            foreach (var bgID in bgIDs!)
                            {
                                var currentWord = context.WordBgs?.Select(i => new { i.WordBgId, i.BgWord }).SingleOrDefault(w => w.WordBgId == mapBgId);
                                wordBg = currentWord!.BgWord!;
                            }
                            numberOfWords++;

                            if (comboBoxLanguage.SelectedIndex == 0)//En
                            {
                                arrAllWords[indexEn] = wordEn;
                                arrAllWords[indexBg] = wordBg;
                            }
                            else if (comboBoxLanguage.SelectedIndex == 1)//Bg
                            {
                                arrAllWords[indexEn] = wordBg;
                                arrAllWords[indexBg] = wordEn;
                            }

                            indexEn += 2;
                            indexBg += 2;
                            if (numberOfWords.ToString() == comboBoxNumberOfWords.Text && !isbuttonIncludeWordsClicked)
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
                        GetTestNumber();

                        SelectedWords(numberOfWords);

                        labelExamWord.Text = arrSelectedWords![0];

                        AddTestWordsToDictResult();

                        Pronounce();
                    }
                }
            }
        }

        private void SelectedWords(int numberOfWords)
        {

            string[] arrSelectedWordsFromRichTextBox = new string[selectedWords.Count() * 2];

            if (isbuttonIncludeWordsClicked)
            {
                arrSelectedWords = new string[selectedWords.Count() * 2];

                for (int k = 0, j = 0; k < selectedWords.Count(); j += 2, k++)
                {
                    if (arrAllWords!.Contains(selectedWords.ElementAt(k)))
                    {
                        int indexWord = Array.IndexOf(arrAllWords!, selectedWords.ElementAt(k));

                        arrSelectedWords[j] = selectedWords![k];
                        arrSelectedWords[j + 1] = arrAllWords![indexWord + 1];

                    }
                }
            }
            else
            {
                arrSelectedWords = new string[numberOfWords * 2];

                for (int k = 0, j = 1; k < numberOfWords * 2; k += 2, j += 2)
                {
                    if (j < numberOfWords * 2)
                    {
                        int index = rnd.Next(arrAllWords!.Length - 2);

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
        }
        private void Pronounce()
        {
            if (comboBoxLanguage.Text == "En")
            {
                GetWordEnId getWordEnId1 = new GetWordEnId();
                string getExamWord = labelExamWord.Text;

                int? getEnId = getWordEnId1.GetWordEnID(getExamWord);

                var getPronounce = context.WordEns?.Select(x => new { x.EnWord, x.WordEnId, x.Transcriptions }).SingleOrDefault(p => p.WordEnId == getEnId);
                string? pronounce = getPronounce!.Transcriptions;

                labelPronounce.Text = $"{pronounce}";
            }
            else if (comboBoxLanguage.Text == "Bg")
            {
                labelPronounce.Text = "";
            }
        }
        private void buttonNextWord_Click(object sender, EventArgs e)
        {
            //int numberOfIncorrectWords = 0;

            countWords++;
            //if (textBoxTranslateWord.Text != "" && countWords <= numberOfWords && comboBoxTestNumber.Text != "")
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
                            translateWord = arrAllCorrectedEnWords![i];
                        }
                    }
                    else if (isButtonLoadClicked)
                    {
                        arrWords = arrSelectedWords;
                        translateWord = arrWords![i + 1];//Because the words in array are evens or odds in different language
                    }

                    writtenWord = textBoxTranslateWord.Text.ToUpper();

                    if (translateWord != "")
                    {
                        if (writtenWord.Replace(" ", "") == translateWord.Replace(" ", ""))
                        {
                            correctAnswer++;
                            InsertIntoTest("correct");
                        }
                        else
                        {
                            InsertIntoTest("Incorrect");

                        }
                        isButtonHintClicked = false;
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
                        getTestNumber = 0;
                        TestResults();
                        MessageBox.Show("Finish");
                        return;
                    }

                    if (!isButtonLoadAllIncorrectAnswersIsClicked)
                    {

                        if (i == arrWords!.Length - 2)
                        {
                            getTestNumber = 0;
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
                                getTestNumber = 0;
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
                    //if ((!(i == int.Parse(comboBoxNumberOfIncorrectWords.Text))) && arrWords != null)//While i reach number of incorrect words
                    if ((i != int.Parse(comboBoxNumberOfIncorrectWords.Text)) && arrWords != null)//While i reach number of incorrect words
                    {
                        labelExamWord.Text = arrWords[i];

                    }

                    textBoxTranslateWord.Text = "";

                    Pronounce();

                    AddTestWordsToDictResult();

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
            int testNumber = 0;


            if (isFinish)
            {
                getTestNumber = context.Tests!.Select(t => t.test).OrderByDescending(t => t).FirstOrDefaultAsync().Result;
            }
            if (getTestNumber != null)
            {
                testNumber = getTestNumber + 1;
            }
            else
            {
                testNumber = 1;
            }
            try
            {
                if (comboBoxLanguage.Text == "En")
                {
                    Tests t = new Tests
                    {
                        lngName = comboBoxLanguage.Text,
                        //test = int.Parse(comboBoxTestNumber.Text),
                        test = testNumber,
                        enW = labelExamWord.Text.ToUpper(),
                        bgW = textBoxTranslateWord.Text.ToUpper(),
                        answer = getAnswer,
                        enId = getEnId.GetWordEnID(labelExamWord.Text),
                        bgId = getBgId.GetWordBgID(textBoxTranslateWord.Text),
                        Hint = isButtonHintClicked,
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
                        //test = int.Parse(comboBoxTestNumber.Text),
                        test = testNumber,
                        enW = textBoxTranslateWord.Text.ToUpper(),
                        bgW = labelExamWord.Text.ToUpper(),
                        answer = getAnswer,
                        enId = getEnId.GetWordEnID(textBoxTranslateWord.Text),
                        bgId = getBgId.GetWordBgID(labelExamWord.Text),
                        Hint = isButtonHintClicked,
                        dateTime = DateTime.Now
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
            richTextBoxWords.Clear();
            int numberOfRows = 0;
            isButtonLoadSelectedIncorrectWordsClicked = false;
            allWords.Clear();

            if (comboBoxLanguage.Text == "En")
            {
                numberOfRows = await context.WordEns!.CountAsync();
                allWords = await context.WordEns!.Select(enW => enW.EnWord!).ToListAsync();
            }
            else if (comboBoxLanguage.Text == "Bg")
            {
                numberOfRows = await context.WordBgs!.CountAsync();
                allWords = await context.WordBgs!.Select(enW => enW.BgWord!).ToListAsync();
            }

            foreach (var word in allWords)
            {
                richTextBoxWords.Text += word + "\n";
            }
            counterWords = numberOfRows;

            labelAllWords.Text = numberOfRows.ToString();

            labelRichTextBoxAllWords.Text = numberOfRows.ToString();

            comboBoxNumberOfWords.Items.Clear();

            comboBoxNumberOfWords.Text = numberOfRows.ToString();
        }

        public async void buttonHint_ClickAsync(object sender, EventArgs e)
        {
            if (isButtonLoadClicked)
            {
                MessageBox.Show(arrSelectedWords![i + 1]);
            }
            if (isButtonLoadAllIncorrectAnswersIsClicked && comboBoxNumberOfIncorrectWords.Text != "")
            {
                if (int.Parse(comboBoxNumberOfIncorrectWords.Text) != 0)
                {
                    if (comboBoxLanguage.Text == "En")
                    {
                        MessageBox.Show(arrAllCorrectedBgWords![i]);
                    }
                    else if (comboBoxLanguage.Text == "Bg")
                    {
                        MessageBox.Show(arrAllCorrectedEnWords![i]);
                    }
                }
            }
            isButtonHintClicked = true;
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

                        if (mapTableIDs != null)
                        {
                            correctIdBgAnalog = mapTableIDs?.WordBgId!.Value;
                            correctIdEnAnalog = mapTableIDs?.WordEnId!.Value;

                            var correctWordBg = context.WordBgs?.Select(x => new { x.WordBgId, x.BgWord }).SingleOrDefault(x => x.WordBgId.ToString() == correctIdBgAnalog.ToString());
                            var correctWordEn = context.WordEns?.Select(x => new { x.WordEnId, x.EnWord }).SingleOrDefault(x => x.WordEnId.ToString() == correctIdEnAnalog.ToString());

                            arrAllCorrectedBgWords[count] = correctWordBg!.BgWord!.ToString();
                            arrAllCorrectedEnWords[count] = correctWordEn!.EnWord!.ToString();

                            count++;
                        }
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

                arrAllCorrectedEnWords = new string[bgIds!.Count()];
                arrAllCorrectedBgWords = new string[bgIds!.Count()];

                labelIncorrectWords.Text = "Incorrect words: " + bgIds?.Count().ToString();

                foreach (var getIdBg in bgIds!)
                {
                    if (getIdBg != null)
                    {

                        var mapTableIDs = context.WordsEnBgs?.Select(enBg => new { enBg.WordEnId, enBg.WordBgId }).SingleOrDefault(x => x.WordBgId == getIdBg.bgId.Value);

                        correctIdBgAnalog = mapTableIDs!.WordBgId!.Value;
                        correctIdEnAnalog = mapTableIDs.WordEnId!.Value;

                        var correctWordBg = context.WordBgs?.Select(x => new { x.WordBgId, x.BgWord }).SingleOrDefault(i => i.WordBgId.ToString() == correctIdBgAnalog.ToString());
                        var correctWordEn = context.WordEns?.Select(x => new { x.WordEnId, x.EnWord }).SingleOrDefault(i => i.WordEnId.ToString() == correctIdEnAnalog.ToString());

                        arrAllCorrectedBgWords[count] = correctWordBg!.BgWord!.ToString();
                        arrAllCorrectedEnWords[count] = correctWordEn!.EnWord!.ToString();

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
            isButtonHintClicked = false;
            isButtonLoadSelectedIncorrectWordsClicked = true;
            numberOfWords = int.Parse(comboBoxNumberOfIncorrectWords.Text);

            if (comboBoxNumberOfIncorrectWords.Text != "")
            {
                if (int.Parse(comboBoxNumberOfIncorrectWords.Text) != 0)
                {
                    if (comboBoxLanguage.Text == "En")
                    {
                        labelExamWord.Text = arrAllCorrectedEnWords![0];
                    }
                    else if (comboBoxLanguage.Text == "Bg")
                    {
                        labelExamWord.Text = arrAllCorrectedBgWords![0];
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

                    GetTestNumber();

                    AddTestWordsToDictResult();
                    Pronounce();
                }
            }
        }

        private void GetTestNumber()
        {
            getTestNumber = context.Tests!.Select(t => t.test).OrderByDescending(t => t).FirstOrDefaultAsync().Result;
        }

        private void AddTestWordsToDictResult()
        {
            if (!dictResultWords.ContainsKey(labelExamWord.Text))
            {
                dictResultWords.Add(labelExamWord.Text, 0);
            }
            dictResultWords[labelExamWord.Text] += 1;
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

        private void checkBoxSoundOnly_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBoxSoundOnly.Checked)
            //{
            //    checkBoxSoundOnly.Checked = false;
            //}
            //else
            //{
            //    checkBoxSoundOnly.Checked = true;
            //}
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            counterWords--;
            counterAddToSelectedWords++;
            string getWord = richTextBoxWords.SelectedText.Replace("\n", "");

            richTextBoxWords.Text = "";

            allWords.Remove(getWord);

            foreach (var word in allWords)
            {
                richTextBoxWords.Text += word + "\n";
            }

            selectedWords.Add(getWord);

            richTextBoxSelectedWords.Text += getWord + "\n";

            //comboBoxNumberOfWords.Text = $"{counterAddToSelectedWords}";

            labelRichTextBoxAllWords.Text = $"All words: {counterWords}";
            labelRichTextBoxSelectedWords.Text = $"Selected words: {counterAddToSelectedWords}";
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string selectedWord = richTextBoxSelectedWords.SelectedText;
            richTextBoxSelectedWords.Clear();
            selectedWords.Remove(selectedWord);
            counterAddToSelectedWords--;

            foreach (var word in selectedWords)
            {
                richTextBoxSelectedWords.Text += word + "\n";
            }

            comboBoxNumberOfWords.Text = $"{counterAddToSelectedWords}";

            labelRichTextBoxSelectedWords.Text = $"Selected words: {counterAddToSelectedWords}";
        }

        private void buttonExcludeWords_Click(object sender, EventArgs e)
        {
            isbuttonIncludeWordsClicked = false;
            selectedWords.Clear();
            richTextBoxSelectedWords.Text = "";
            labelRichTextBoxSelectedWords.Text = $"Selected words: 0";
            //buttonIncludeWords.BackColor = Color.Red;
        }

        private void buttonIncludeWords_Click(object sender, EventArgs e)
        {
            //if (isbuttonIncludeWordsClicked)
            //{
            //    isbuttonIncludeWordsClicked = false;
            //    buttonIncludeWords.BackColor = Color.Red;
            //}
            //else
            //{
            //    buttonIncludeWords.BackColor = Color.LightGreen;
            //    isbuttonIncludeWordsClicked = true;
            //}

            isbuttonIncludeWordsClicked = true;
            comboBoxNumberOfWords.Text = selectedWords.Count.ToString();
        }
    }
}
