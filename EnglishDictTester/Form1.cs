namespace EnglishDictTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMakeTest_Click(object sender, EventArgs e)
        {
            frmTest frmTest = new frmTest();
            frmTest.ShowDialog();
        }
    }
}