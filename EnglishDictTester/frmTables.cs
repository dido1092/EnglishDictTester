using EnglishDictTester.Data.Common;
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
    }
}
