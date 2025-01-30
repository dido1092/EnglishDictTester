using EnglishDictTester.Data;
using EnglishDictTester.Data.Common;
using EnglishDictTester.Data.Models;
using EnglishDictTester.Enumerators;
using EnglishDictTester.Get_Id_s;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EnglishDictTester
{
    public partial class Form1 : Form
    {
        public static EnglishDictTesterContext context = new EnglishDictTesterContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMakeTest_Click(object sender, EventArgs e)
        {
            frmTest frmTest = new frmTest();
            frmTest.ShowDialog();
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            string wordBg = textBoxWordBg.Text.ToUpper();
            string wordEn = textBoxWordEn.Text.ToUpper();
            string transcription = textBoxTranscriptions.Text;

            if (wordBg != "" && wordEn != "")
            {
                InsertWords(wordBg, wordEn, transcription);
                //InsertEnWord(wordEn, transcription, wordBg);
                InsertInMappingTable(wordBg, wordEn);
            }
            else
            {
                MessageBox.Show("Enter BgWord AND EnWord!");
            }
        }

        private void ClearTextBoxes()
        {
            textBoxWordBg.Text = "";
            textBoxWordEn.Text = "";
            textBoxTranscriptions.Text = "";
        }

        public void InsertInMappingTable(string wordBg, string wordEn)
        {
            WordsEnBg wEnBg = new WordsEnBg();
            GetWordBgId getBgId = new GetWordBgId();
            GetWordEnId getEnId = new GetWordEnId();

            int? wordBgId = getBgId.GetWordBgID(wordBg);
            int? wordEnId = getEnId.GetWordEnID(wordEn);

            if (wordBgId != null & wordEnId != null)
            {
                wEnBg = new WordsEnBg { WordBgId = wordBgId, WordEnId = wordEnId };
                context.Add(wEnBg);
                context.SaveChanges();

                ClearTextBoxes();
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Unsuccess!");
            }
        }

        private void InsertWords(string wordBg, string wordEn, string transaction)
        {
            var checkWordBg = context.WordBgs?.Select(bg => new { bg.BgWord }).SingleOrDefault(wBg => wBg.BgWord == wordBg);
            var checkWordEn = context.WordEns?.Select(en => new { en.EnWord }).SingleOrDefault(wEn => wEn.EnWord == wordEn);

            if (checkWordBg != null)
            {
                MessageBox.Show(Enums.WordBg_Duplicated.ToString());
            }
            if (checkWordEn != null)
            {
                MessageBox.Show(Enums.WordEn_Duplicated.ToString());
            }
            if (checkWordBg == null && checkWordEn == null)
            {
                WordBg wBg = new WordBg { BgWord = wordBg };
                WordEn wEn = new WordEn { EnWord = wordEn, Transcriptions = transaction };
                context.Add(wBg);
                context.Add(wEn);
                context.SaveChanges();
                //MessageBox.Show("Record in each tables!");
            }
        }
        //private void InsertEnWord(string wordEn, string transcriptions, string wordBg)
        //{
        //    var checkWordEn = context.WordEns?.Select(bg => new { bg.EnWord }).SingleOrDefault(wBg => wBg.EnWord == wordEn);
        //    var checkWordBg = context.WordBgs?.Select(bg => new { bg.BgWord }).SingleOrDefault(wBg => wBg.BgWord == wordBg);
        //    try
        //    {
        //        if (checkWordBg == null)
        //        {
        //            try
        //            {
        //                if (checkWordEn == null)
        //                {
        //                    WordEn wEn = new WordEn { EnWord = wordEn, Transcriptions = transcriptions };
        //                    context.Add(wEn);
        //                    context.SaveChanges();
        //                    //MessageBox.Show("Success!");
        //                }
        //            }
        //            catch (Exception)
        //            {
        //                MessageBox.Show(Enums.WordEn_Duplicated.ToString());
        //                //throw;
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show(Enums.WordBg_Duplicated.ToString());
        //        throw;
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)//Button Tables
        {
            frmTables frmTables = new frmTables();
            frmTables.Show();

        }

        private void buttonResults_Click(object sender, EventArgs e)
        {
            frmResults frmResults = new frmResults();
            frmResults.Show();
        }

        private void buttonWordGame_Click(object sender, EventArgs e)
        {
            frmWordGame frmWordGame = new frmWordGame();
            frmWordGame.Show();
        }
    }
}