using EnglishDictTester.Data.Common;
using Google.Cloud.Translation.V2;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class frmTables : Form
    {
        public frmTables()
        {
            InitializeComponent();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
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
                TableMap(connectionString);
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
        private void TableMap(string connectionString)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM WordsEnBgs", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "WordsEnBgs");
            dataGridViewMap.DataSource = ds.Tables["WordsEnBgs"]?.DefaultView;
        }
        //private void Delete(DataGridViewCell cell, DataGridView language,string table, string id)
        //{
        //    string value = cell.Value.ToString();
        //    int getID = int.Parse(value);

        //    //Remove row from DataGridView
        //    int rowIndex = language.CurrentCell.RowIndex;
        //    this.dataGridViewBg.Rows.RemoveAt(rowIndex);

        //    //String Connection
        //    string connetionString = null;
        //    connetionString = DbConfig.ConnectionString;
        //    SqlConnection cnn = new SqlConnection(connetionString);
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = cnn;

        //    //Delete from DB
        //    cmd.CommandText = ($"Delete From {table} Where {id}=" + getID + "");

        //    try
        //    {
        //        cnn.Open();
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("The row has been deleted ! ");
        //        cnn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Cannot open connection ! ");
        //    }

        //}
        private void buttonDeleteWordsBG_Click(object sender, EventArgs e)
        {
            //Delete(cell, "WordBgs", "WordBgId");

            DataGridViewCell cell = dataGridViewBg.SelectedCells[0] as DataGridViewCell;
            string value = cell.Value.ToString();
            int getID = int.Parse(value);

            //Remove row from DataGridView
            int rowIndex = dataGridViewBg.CurrentCell.RowIndex;
            this.dataGridViewBg.Rows.RemoveAt(rowIndex);

            //String Connection
            string connetionString = null;
            connetionString = DbConfig.ConnectionString;
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            //Delete from DB
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
        }

        private void buttonDeleteWordsEn_Click(object sender, EventArgs e)
        {
            //DataGridViewCell cell = dataGridViewEn.SelectedCells[0] as DataGridViewCell;
            //Delete(cell, "WordEns", "WordEnId");

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
        }

        private void buttonDeleteMappingTable_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = dataGridViewMap.SelectedCells[0] as DataGridViewCell;
            string value = cell.Value.ToString();
            int getID = int.Parse(value);

            //Remove row from DataGridView
            int rowIndex = dataGridViewMap.CurrentCell.RowIndex;
            this.dataGridViewBg.Rows.RemoveAt(rowIndex);

            //String Connection
            string connetionString = null;
            connetionString = DbConfig.ConnectionString;
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            //Delete from DB
            cmd.CommandText = ($"DELETE FROM [WordsEnBgs] WHERE WordBgId = '{int.Parse(textBoxBgId.Text)}' AND WordEnId = '{int.Parse(textBoxEnId.Text)}'");

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
    }
}
