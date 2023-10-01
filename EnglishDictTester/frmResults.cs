using EnglishDictTester.Data;
using EnglishDictTester.Data.Common;
using EnglishDictTester.Data.Migrations;
using EnglishDictTester.Data.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace EnglishDictTester
{
    public partial class frmResults : Form
    {
        EnglishDictTesterContext context = new EnglishDictTesterContext();

        public frmResults()
        {
            InitializeComponent();
        }

        private void buttonResultRefresh_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            connectionString = DbConfig.ConnectionString; //ConnectionString();

            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            try
            {
                TableTests(connectionString);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void TableTests(string connectionString)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tests", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Tests");
            dataGridViewResults.DataSource = ds.Tables["Tests"]?.DefaultView;
        }

        private void buttonUpdateResult_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            connectionString = DbConfig.ConnectionString; //ConnectionString();

            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            int rowindex = dataGridViewResults.CurrentRow.Index;
            int colindex = dataGridViewResults.CurrentCell.ColumnIndex;

            string? columnName = dataGridViewResults.Columns[colindex].HeaderText;

            string? getValue = dataGridViewResults.CurrentCell.Value.ToString();
            string? id = dataGridViewResults.Rows[rowindex].Cells[0].Value.ToString();

            //MessageBox.Show(columnName.ToString());

            try
            {
                using (cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    string sqlCommand = $"Update Tests set {columnName}=@{columnName} Where testId={id}";
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
