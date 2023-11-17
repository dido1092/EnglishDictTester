using EnglishDictTester.Data;
using EnglishDictTester.Data.Common;
using EnglishDictTester.Data.Models;
using EnglishDictTester.Get_Id_s;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EnglishDictTester
{
    public partial class frmTables : Form
    {
        public frmTables()
        {
            InitializeComponent();
        }
        private static string connectionString = DbConfig.ConnectionString;
        EnglishDictTesterContext context = new EnglishDictTesterContext();
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            //ConnectionString();

            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            try
            {
                TableWordBg(connectionString);
                TableWordEn(connectionString);
                CountRows(connectionString);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void TableWordBg(string connectionString)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM WordBgs", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "WordBgs");
            dataGridViewBg.DataSource = ds.Tables["WordBgs"]?.DefaultView;
        }
        private void TableWordEn(string connectionString)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM WordEns", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "WordEns");
            dataGridViewEn.DataSource = ds.Tables["WordEns"]?.DefaultView;
        }
        private void CountRows(string connectionString)
        {
            // Create the connection.
            SqlConnection conn = new SqlConnection(DbConfig.ConnectionString);

            // Build the query to count, including CustomerID criteria if specified.
            String selectText = "SELECT COUNT(*) FROM WordEns";

            // Create the command to count the records.
            SqlCommand cmd = new SqlCommand(selectText, conn);

            // Execute the command, storing the results.
            conn.Open();
            int recordCount = (int)cmd.ExecuteScalar();
            conn.Close();
            labelTablesNumberOfWords.Text = $"words: {recordCount}";
        }

        private void buttonDeleteWordsEn_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = dataGridViewEn.SelectedCells[0] as DataGridViewCell;
            string value = cell.Value.ToString();
            int getID = int.Parse(value);

            //Remove row from DataGridView
            int rowIndex = dataGridViewEn.CurrentCell.RowIndex;
            this.dataGridViewEn.Rows.RemoveAt(rowIndex);

            //String Connection
            string connetionString = null;
            connetionString = DbConfig.ConnectionString;
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            //Delete from DB
            cmd.CommandText = ($"Delete From WordEns Where WordEnId=" + getID + "");

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("The row has been deleted ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection ! ");
            }

            cmd.CommandText = ($"Delete From WordBgs Where WordBgId=" + getID + "");

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("The row has been deleted ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection ! ");
            }

            Refresh();
        }

        private void buttonUpdateTableEn_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            connectionString = DbConfig.ConnectionString;

            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            int rowindex = dataGridViewEn.CurrentRow.Index;
            int colindex = dataGridViewEn.CurrentCell.ColumnIndex;

            string? columnName = dataGridViewEn.Columns[colindex].HeaderText;

            string? getValue = dataGridViewEn.CurrentCell.Value.ToString();
            string? id = dataGridViewEn.Rows[rowindex].Cells[0].Value.ToString();

            //MessageBox.Show(columnName.ToString());

            try
            {
                using (cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    string sqlCommand = $"Update WordEns set {columnName}=@{columnName} Where WordEnId={id}";
                    cmd = new SqlCommand(sqlCommand, cnn);
                    cmd.Parameters.AddWithValue($"@{columnName}", getValue);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Information Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdateTableBg_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            connectionString = DbConfig.ConnectionString;

            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            int rowindex = dataGridViewBg.CurrentRow.Index;
            int colindex = dataGridViewBg.CurrentCell.ColumnIndex;

            string? columnName = dataGridViewBg.Columns[colindex].HeaderText;

            string? getValue = dataGridViewBg.CurrentCell.Value.ToString();
            string? id = dataGridViewBg.Rows[rowindex].Cells[0].Value.ToString();

            //MessageBox.Show(columnName.ToString());

            try
            {
                using (cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    string sqlCommand = $"Update WordBgs set {columnName}=@{columnName} Where WordBgId={id}";
                    cmd = new SqlCommand(sqlCommand, cnn);
                    cmd.Parameters.AddWithValue($"@{columnName}", getValue);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Information Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            OpenFile();
            InsertInTables();

        }
        private void InsertInTables()
        {
            //OpenFile();

            string patternBg = @"[А-Я]";
            string patternEn = @"[A-Z]";

            string[] lines = System.IO.File.ReadAllLines(textBoxInsert.Text);

            foreach (var line in lines)
            {
                string[] words = line.Split('-', '[', ']');

                string bgWords = words[0].Replace(" ", "").ToUpper();
                string enWords = words[1].Replace(" ", "").ToUpper();
                string transcriptions = words[2].Replace(" ", "");

                GetWordBgId getBgId = new GetWordBgId();
                GetWordEnId getEnId = new GetWordEnId();

                if (Regex.Matches(bgWords, patternBg).Count > 0 && Regex.Matches(enWords, patternEn).Count > 0)
                {
                    //WordBg Table
                    WordBg wBg = new WordBg()
                    {
                        BgWord = bgWords
                    };
                    context.WordBgs!.Add(wBg);

                    //WordEn Table
                    WordEn wEn = new WordEn()
                    {
                        EnWord = enWords,
                        Transcriptions = transcriptions
                    };
                    context.WordEns!.Add(wEn);

                    //Save
                    context.SaveChanges();

                    //Mapping Table
                    int? wordBgId = getBgId.GetWordBgID(wBg.BgWord);
                    int? wordEnId = getEnId.GetWordEnID(wEn.EnWord);

                    WordsEnBg wEnBg = new WordsEnBg ()
                    { 
                        WordBgId = wordBgId, 
                        WordEnId = wordEnId 
                    };
                    context.WordsEnBgs!.Add(wEnBg);

                    //Save
                    context.SaveChanges();
                }
            }
            MessageBox.Show("Import Done!");
        }
        private void OpenFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxInsert.Text = openFileDialog1.FileName;
            }
        }


        private void buttonExport_Click(object sender, EventArgs e)
        {
            Save();

            HashSet<string> hsWords = Export();

            File.WriteAllText(textBoxInsert.Text, string.Join("\n", hsWords));
            MessageBox.Show("Done!");
        }

        private HashSet<string> Export()
        {
            List<string> lsBgWords = new List<string>();
            List<string> lsEnWords = new List<string>();
            List<string> lsEnTranscriptions = new List<string>();
            HashSet<string> hsWords = new HashSet<string>();

            var bgWords = context.WordBgs!.OrderBy(w => w.WordBgId).Select(w => w.BgWord).ToList();
            var enWords = context.WordEns!.OrderBy(w => w.WordEnId).Select(w => w.EnWord).ToList();
            var enTranscriptions = context.WordEns!.OrderBy(w => w.WordEnId).Select(w => w.Transcriptions).ToList();

            lsBgWords = bgWords.ToList()!;
            lsEnWords = enWords.ToList()!;
            lsEnTranscriptions = enTranscriptions.ToList()!;

            for (int i = 0; i < lsBgWords.Count(); i++)
            {
                hsWords.Add($"{lsBgWords[i]} - {lsEnWords[i]} [{lsEnTranscriptions[i]}]");
            }

            return hsWords;
        }

        private void Save()
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.RestoreDirectory = true;
            //savefile.InitialDirectory = "e:\\faktur";
            savefile.FileName = String.Format("{0}.txt", Text);
            savefile.DefaultExt = "*.txt*";
            savefile.Filter = "TEXT Files|*.txt";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(savefile.FileName)) { }
                textBoxInsert.Text = savefile.FileName;
            }
        }
    }
}
