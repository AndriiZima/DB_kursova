using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySqlTraning;
using System.Data;
using MySql.Data.MySqlClient;



namespace UnitTestProjectDBCursova
{
    [TestClass]
    public class UnitTest1
    {
        string queryName = "Тест";
        


        [TestMethod]
        public void TestMethod1()
        {
            PrintClass printObj = new PrintClass();
            Assert.AreEqual(queryName, "Тест"); 
        }

        [TestMethod]
        public void TestMethod2()
        {
            bool a = false;
            DB db = new DB();
            try
            {
                db.getConnection();
                a = true;
            }
            catch
            {
                Console.WriteLine("error");
            }
            Assert.AreEqual(a, true);
        }

        [TestMethod]
        public void TestMethod3()
        {
            bool a = false;
            DB db = new DB();
            try
            {
                db.closeConnection();
                a = true;
            }
            catch
            {
                Console.WriteLine("error");
            }
            Assert.AreEqual(a, true);
        }

        [TestMethod]
        public void TestMethod4()
        {
            bool a = false;
            DB db = new DB();
            try
            {
                db.openConnection();
                a = true;
            }
            catch
            {
                Console.WriteLine("error");
            }
            Assert.AreEqual(a, true);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string loginUser = "Admin";
            string passUser = "admin123";

            DB db = new DB();
            DataTable tabel = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM login_users where `login` = @uL and `password` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(tabel);
        }
    }
}
