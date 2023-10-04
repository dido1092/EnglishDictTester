using EnglishDictTester.Data.Common;
using Google.Cloud.Translation.V2;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishDictTester
{
    public partial class frmTables : Form
    {
        public frmTables()
        {
            InitializeComponent();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            string connectionString = null;
            connectionString = DbConfig.ConnectionString; //ConnectionString();

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
    }
}
