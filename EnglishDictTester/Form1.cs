using EnglishDictTester.Data;
using EnglishDictTester.Data.Common;
using EnglishDictTester.Data.Models;
using EnglishDictTester.Enumerators;
using EnglishDictTester.Get_Id_s;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

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
            string wordBg = textBoxWordBg.Text;
            string wordEn = textBoxWordEn.Text;
            string transcriptions = textBoxTranscriptions.Text;


            if (wordBg != "" && wordEn != "")
            {
                InsertBgWord(wordBg);
                InsertEnWord(wordEn, transcriptions);
                InsertInMappingTable(wordBg, wordEn);

                MessageBox.Show("Success!");

                textBoxWordBg.Text = "";
                textBoxWordEn.Text = "";
                textBoxTranscriptions.Text = "";

                //con.Open();
                //string select = "SELECT * from table_name";
                //SqlDataAdapter da = new SqlDataAdapter(select, con);
                //DataSet ds = new DataSet();
                //da.Fill(ds, "table_name");
                //dataGridView1.DataSource = ds;

                //WordsEnBg dbe = new WordsEnBg();
                //BindingSource bs = new BindingSource();
                //dataProducts.DataSource = null;
                //List<Book> books = dbe.Book.ToList();
                //bs.DataSource = books;
                //dataProducts.DataSource = bs;


                //dataGridView1.DataSource = 
                //dataGridView1.Update();
                //dataGridView1.Refresh();
            }
        }

        public void InsertInMappingTable(string wordBg, string wordEn)
        {
            WordsEnBg wEnBg = new WordsEnBg();
            GetWordBgId getBgId = new GetWordBgId();
            GetWordEnId getEnId = new GetWordEnId();

            int? wordBgId = getBgId.GetWordBgID(wordBg);
            int? wordEnId = getEnId.GetWordEnID(wordEn);

            try
            {
                wEnBg = new WordsEnBg { WordBgId = wordBgId, WordEnId = wordEnId };
                context.Add(wEnBg);
                context.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show(Enums.WordBgEn_Duplicated.ToString());
                throw;
            }
        }

        private static void InsertBgWord(string wordBg)
        {
            var checkWordBg = context.WordBgs?.Select(bg => new { bg.BgWord }).SingleOrDefault(wBg => wBg.BgWord == wordBg);
            try
            {
                if (checkWordBg == null)
                {
                    WordBg wBg = new WordBg { BgWord = wordBg };
                    context.Add(wBg);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Enums.WordBg_Duplicated.ToString());
                throw;
            }
        }
        private static void InsertEnWord(string wordEn, string transcriptions)
        {
            var checkWordEn = context.WordEns?.Select(bg => new { bg.EnWord }).SingleOrDefault(wBg => wBg.EnWord == wordEn);
            try
            {
                if (checkWordEn == null)
                {
                    WordEn wEn = new WordEn { EnWord = wordEn, Transcriptions = transcriptions };
                    context.Add(wEn);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Enums.WordEn_Duplicated.ToString());
                throw;
            }
        }
    }
}