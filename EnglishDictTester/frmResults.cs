﻿using EnglishDictTester.Data;
using EnglishDictTester.Data.Common;
//using EnglishDictTester.Data.Migrations;
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
        private static string connectionString = DbConfig.ConnectionString;
        public frmResults()
        {
            InitializeComponent();
        }

        private void buttonResultRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            try
            {
                Tests(connectionString);
            }
            catch (Exception)
            {

                throw;
            }
            CountRows();
        }
        private void CountRows()
        {
            // Create the connection.
            SqlConnection conn = new SqlConnection(DbConfig.ConnectionString);

            // Build the query to count, including CustomerID criteria if specified.
            String selectText = "SELECT COUNT(*) FROM Tests";

            // Create the command to count the records.
            SqlCommand cmd = new SqlCommand(selectText, conn);

            // Execute the command, storing the results.
            conn.Open();
            int recordCount = (int)cmd.ExecuteScalar();
            conn.Close();
            labelNumberOfWords.Text = $"Number of Words: {recordCount}";
        }
        private void Tests(string connectionString)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tests", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Tests");
            dataGridViewResults.DataSource = ds.Tables["Tests"]?.DefaultView;
        }
        private void TestsSelected(string connectionString, int testNumber)
        {
            SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM Tests WHERE test={testNumber}", connectionString);
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = dataGridViewResults.SelectedCells[0] as DataGridViewCell;

            string value = cell.Value.ToString()!;
            int getTestId = int.Parse(value!);

            var testId = context.Tests!.Where(v => v.testId == getTestId).FirstOrDefault();

            try
            {
                if (testId != null)
                {
                    context.Remove(testId);
                    context.SaveChanges();
                }
                MessageBox.Show($"The TestId '{getTestId}' has been deleted! ");

                buttonResultRefresh.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot delete Test! ");
            }
        }

        private void buttonRemoveAllIncorrectTests_Click(object sender, EventArgs e)
        {
            RemoveTest("Incorrect");
        }

        private void buttonRemoveAllCorrectTests_Click(object sender, EventArgs e)
        {
            RemoveTest("Correct");
        }
        private void RemoveTest(string answerStatus)
        {
            //String Connection
            string connetionString = null;
            connetionString = DbConfig.ConnectionString;
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            //Delete from DB
            cmd.CommandText = ("Delete From Tests Where answer='" + answerStatus + "'");

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


        }

        private void buttonLoadTest_Click(object sender, EventArgs e)
        {
            comboBoxResultTest.Items.Clear();
            HashSet<int> testNumbers = new HashSet<int>();

            var tests = context.Tests!.Select(t => t.test).ToList();

            testNumbers = tests.ToHashSet();

            foreach (var testN in testNumbers)
            {
                comboBoxResultTest.Items.Add(testN);
            }
            if (comboBoxResultTest.Text != "")
            {
                int testNumber = int.Parse(comboBoxResultTest.Text);
                int numberOfTest = context.Tests!.Where(t => t.test == testNumber).Count();

                TestsSelected(connectionString, testNumber);
                labelNumberOfWords.Text = $"Number of Words: {numberOfTest.ToString()}";
            }
        }

        private void buttonChart_Click(object sender, EventArgs e)
        {
            frmChart chart = new frmChart();
            chart.Show();
        }

        private void chartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChart chart = new frmChart();
            chart.Show();
        }
    }
}
