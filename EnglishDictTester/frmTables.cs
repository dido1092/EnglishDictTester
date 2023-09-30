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

            TableWordBg(connectionString);
            TableWordEn(connectionString);
            TableMap(connectionString);
        }

        private void TableWordBg(string connectionString)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM WordBg", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "WordBg");
            dataGridViewBg.DataSource = ds.Tables["WordBg"]?.DefaultView;
        }
        private void TableWordEn(string connectionString)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM WordEn", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "WordEn");
            dataGridViewEn.DataSource = ds.Tables["WordEn"]?.DefaultView;
        }
        private void TableMap(string connectionString)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM WordsEnBg", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "WordsEnBg");
            dataGridViewMap.DataSource = ds.Tables["WorWordsEnBgdEn"]?.DefaultView;
        }
    }
}
