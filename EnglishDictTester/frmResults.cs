using EnglishDictTester.Data.Common;
using EnglishDictTester.Data.Migrations;
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
    public partial class frmResults : Form
    {
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
    }
}
