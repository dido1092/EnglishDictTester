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
        //int bufferId = 1;
        string translateWord = string.Empty;
        double score = 0;
        double correctAnswer = 0;
        //List<string> lsEnWords = new List<string>();
        //List<string> lsBgWords = new List<string>();
        Dictionary<string, string> dictWords = new Dictionary<string, string>();
        //Dictionary<int, int> dictIds = new Dictionary<int, int>();
        public frmTest()
        {
            InitializeComponent();
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (comboBoxLanguage.SelectedIndex == 0 && comboBoxNumberOfWords.SelectedValue != null)//En
            {
                int numberOfWords = 0;
                
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
                    dictWords.Add(wordEn, wordBg);

                    if (numberOfWords == (int)comboBoxNumberOfWords.SelectedValue)
                    {
                        break;
                    }
                }

                foreach (var word in dictWords)
                {
                    labelExamWord.Text = word.Key.ElementAt(i).ToString();
                    translateWord = word.Value.ElementAt(i).ToString();
                }

                //labelExamWord.Text = enWords?.ElementAt(i).ToString();
            }
        }

        private void buttonNextWord_Click(object sender, EventArgs e)
        {
            i++;

            string exampWord = textBoxTranslateWord.Text;

            if (exampWord == translateWord)
            {
                correctAnswer++;
            }
            if (i == (int)comboBoxNumberOfWords.SelectedValue)
            {
                MessageBox.Show("Finish!");
                labelExamWord.Text = "Score: " + correctAnswer / (int)comboBoxNumberOfWords.SelectedValue;
            }
        }
    }
}
