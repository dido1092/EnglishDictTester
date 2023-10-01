using EnglishDictTester.Data;
using EnglishDictTester.Data.Models;
using EnglishDictTester.Enumerators;
using EnglishDictTester.Get_Id_s;
using Google.Cloud.Translation.V2;
using Azure;
using Azure.AI.Translation.Text;
using Microsoft.EntityFrameworkCore;
using System.Data;
using FluentAssertions.Common;
using System.Net;

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
        //string? correctWordBg = string.Empty;
        string translateWord = string.Empty;
        string[]? arrAllWords;
        string[]? arrSelectedWords;
        string[]? arrAllCorrectedBgWords;
        string[]? arrAllCorrectedEnWords;
        string[]? arrWords;
        List<object>? lsEnIds = new List<object>();
        bool isFinish = false;
        bool isButtonLoadAllIncorrectAnswersIsClicked = false;
        bool isButtonLoad = false;
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
                numberOfWords = 0;
                wordA = 0;
                wordB = 1;
                isButtonLoad = true;
                isButtonLoadAllIncorrectAnswersIsClicked = false;

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
            if (textBoxTranslateWord.Text != "")
            {
                string writtenWord = string.Empty;

                if (isFinish)
                {
                    return;
                }
                if (isButtonLoadAllIncorrectAnswersIsClicked)
                {
                    if (comboBoxLanguage.Text == "En")
                    {
                        arrWords = arrAllCorrectedEnWords;
                        translateWord = arrAllCorrectedBgWords[i];
                    }
                    if (comboBoxLanguage.Text == "Bg")
                    {
                        arrWords = arrAllCorrectedBgWords;
                        translateWord = arrAllCorrectedEnWords[i];
                    }

                }
                else
                {
                    arrWords = arrSelectedWords;
                    translateWord = arrWords[i + 1];
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
                //i++;

                if (!isButtonLoadAllIncorrectAnswersIsClicked)
                {
                    if (i == arrWords.Length - 2)
                    {
                        MessageBox.Show("Finish!");
                        isFinish = true;
                        //return;
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
                    if (i == arrWords.Length)
                    {
                        MessageBox.Show("Finish!");
                        isFinish = true;
                        return;
                    }
                }

                labelExamWord.Text = arrWords[i];
                textBoxTranslateWord.Text = "";
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
                        enW = labelExamWord.Text.ToUpper(),
                        bgW = textBoxTranslateWord.Text.ToUpper(),
                        answer = getAnswer,
                        enId = getEnId.GetWordEnID(labelExamWord.Text),
                        bgId = getBgId.GetWordBgID(textBoxTranslateWord.Text)
                    };
                    context.Add(t);
                    context.SaveChanges();
                }
                else if (comboBoxLanguage.Text == "Bg")
                {
                    Tests t = new Tests
                    {
                        lngName = comboBoxLanguage.Text,
                        //enW = labelExamWord.Text.ToUpper(),
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
            if (isButtonLoad)
            {
                MessageBox.Show(arrSelectedWords[i + 1]);
            }
            //await TranslateWord().ConfigureAwait(true);

            //var client = TranslationClient.Create();
            //var text = labelExamWord.Text;
            ////var response = client.TranslateText(text, LanguageCodes.Bulgarian, LanguageCodes.English);


            //if (comboBoxLanguage.Text == "En" && isButtonLoadAllIncorrectAnswersIsClicked == true)
            //{
            //    var response = client.TranslateText(text, LanguageCodes.Bulgarian, LanguageCodes.English);
            //    MessageBox.Show(text);
            //    textBoxHint.Text = response.TranslatedText;
            //}
            //if (comboBoxLanguage.Text == "Bg" && isButtonLoadAllIncorrectAnswersIsClicked == true)
            //{
            //    var response = client.TranslateText(text, LanguageCodes.English, LanguageCodes.Bulgarian);
            //    MessageBox.Show(text);
            //    textBoxHint.Text = response.TranslatedText;
            //}
        }

        private async Task TranslateWord()
        {
            string key = "4ac12a19038d4adf905b85187491c727";

            AzureKeyCredential credential = new(key);
            TextTranslationClient client = new(credential);
            try
            {
                string targetLanguage = "bg";
                string inputText = labelExamWord.Text;

                Response<IReadOnlyList<TranslatedTextItem>> response = await client.TranslateAsync(targetLanguage, inputText).ConfigureAwait(false);
                IReadOnlyList<TranslatedTextItem> translations = response.Value;
                TranslatedTextItem translation = translations.FirstOrDefault();

                textBoxHint.Text = ($"Detected languages of the input text: {translation?.DetectedLanguage?.Language} with score: {translation?.DetectedLanguage?.Score}.");
                textBoxHint.Text = ($"Text was translated to: '{translation?.Translations?.FirstOrDefault().To}' and the result is: '{translation?.Translations?.FirstOrDefault()?.Text}'.");
            }
            catch (RequestFailedException exception)
            {
                MessageBox.Show($"Error Code: {exception.ErrorCode}");
                MessageBox.Show($"Message: {exception.Message}");
            }
        }

        private void buttonLoadAllIncorrectAnswers_Click(object sender, EventArgs e)
        {
            isButtonLoad = false;

            int count = 0;
            int? correctIdBgAnalog = 0;
            int? correctIdEnAnalog = 0;

            ClearVariablesAndControls();

            if (comboBoxLanguage.Text == "En")
            {
                var enCorrectWordsId = context.Tests?.Select(t => new { t.enId, t.bgId, t.lngName, t.enW, t.answer }).Where(a => a.answer == "Incorrect" && a.lngName == "En");
                var enIds = enCorrectWordsId?.Select(w => new { w.enId });

                arrAllCorrectedEnWords = new string[enIds.Count()];
                arrAllCorrectedBgWords = new string[enIds.Count()];

                labelIncorrectWords.Text = "Incorrect words: " + enIds?.Count().ToString();

                foreach (var getIdEn in enIds)
                {
                    if (getIdEn != null)
                    {
                        var mapTableIDs = context.WordsEnBgs?.Select(enBg => new { enBg.WordEnId, enBg.WordBgId }).SingleOrDefault(x => x.WordEnId == getIdEn.enId.Value);

                        correctIdBgAnalog = mapTableIDs.WordBgId.Value;
                        correctIdEnAnalog = mapTableIDs.WordEnId.Value;

                        var correctWordBg = context.WordBgs?.Select(x => new { x.WordBgId, x.BgWord }).SingleOrDefault(x => x.WordBgId.ToString() == correctIdBgAnalog.ToString());
                        var correctWordEn = context.WordEns?.Select(x => new { x.WordEnId, x.EnWord }).SingleOrDefault(x => x.WordEnId.ToString() == correctIdEnAnalog.ToString());

                        arrAllCorrectedBgWords[count] = correctWordBg.BgWord.ToString();
                        arrAllCorrectedEnWords[count] = correctWordEn.EnWord.ToString();

                        count++;
                    }
                }
                //numberOfWords = arrAllCorrectedEnWords.Count();
                //SelectedWords(numberOfWords);

                labelExamWord.Text = arrAllCorrectedEnWords[0];
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
                //numberOfWords = arrAllCorrectedBgWords.Count();
                //SelectedWords(numberOfWords);

                labelExamWord.Text = arrAllCorrectedBgWords[0];
            }

            isButtonLoadAllIncorrectAnswersIsClicked = true;
        }

        private void ClearVariablesAndControls()
        {
            i = 0;
            correctAnswer = 0;
            isFinish = false;
            textBoxTranslateWord.Text = "";
            labelScore.Text = "Score: 0";
        }
    }
}
