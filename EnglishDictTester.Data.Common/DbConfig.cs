namespace EnglishDictTester.Data.Common
{
    public class DbConfig
    {
        private static string name = Environment.MachineName.ToUpper().ToString();
        public static string ConnectionString =
         //@"Server=KASIS\SQLEXPRESS;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\EnglishDictTester.mdf;Database=EnglishDictTester;Integrated Security=True;Encrypt=False;MultipleActiveResultSets=true;";
         @"Server=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\EnglishDictTester.mdf;Database=EnglishDictTester;Integrated Security=True;Encrypt=False;MultipleActiveResultSets=true;";
         //@"Server=" + name + @"\SQLEXPRESS;AttachDbFilename=C:\Program Files\BulgarianEnglishDictTester\BulgarianEnglishDictTester.mdfDatabase=BulgarianEnglishDictTester;Integrated Security=True;Encrypt=False;MultipleActiveResultSets=true;";
         //@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\BulgarianEnglishDictTester\BulgarianEnglishDictTester.mdf;Database=BulgarianEnglishDictTester;Integrated Security=True;Encrypt=False;MultipleActiveResultSets=true;";
         //@"Data Source=C:\Program Files\BulgarianEnglishDictTester\EnglishDictTester.mdf;Database=EnglishDictTester;Integrated Security=True;Encrypt=False;MultipleActiveResultSets=true;";
    }
}