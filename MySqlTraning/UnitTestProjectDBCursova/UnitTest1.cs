using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySqlTraning;
using System.Data;
using MySql.Data.MySqlClient;



namespace UnitTestProjectDBCursova
{

    [TestClass]
    public class UnitTest1
    {/*
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
        }*/

        /*
        string queryName = "Тест";
        string errorTest2;

        [TestMethod]
        public void TestMethod1()
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
                Console.WriteLine("Немає підключення до БД.");
            }
            Assert.AreEqual(a, true);
        }

        [TestMethod]
        public void TestMethod2()
        {
            PrintClass printObj = new PrintClass();
            Assert.AreEqual(queryName, "Тест");
            if(queryName != "Тест")
            {
                Console.WriteLine("Помилка друку.");
                errorTest2 = "Помилка друку.";
                Assert.AreEqual(errorTest2, "Помилка друку.");
            }
        }

        [TestMethod]
        public void TestMethod3()
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
        }*/

/*
        CountTable countTable = new CountTable();

        [TestMethod]
        public void ElemNone()
        {
            string answer = countTable.SizeTable(0);
            Assert.AreEqual("Елементів у таблиці немає", answer);
        }

        [TestMethod]
        public void SmallTable()
        {
            string answer = countTable.SizeTable(100);
            Assert.AreEqual("Маленька таблиця", answer);
        }

        [TestMethod]
        public void MediumTable()
        {
            string answer = countTable.SizeTable(1000);
            Assert.AreEqual("Середня таблиця", answer);
        }

        [TestMethod]
        public void BigTable()
        {
            string answer = countTable.SizeTable(10000);
            Assert.AreEqual("Велика таблиця", answer);
        }*/


        CountTable countTable = new CountTable();

        [TestMethod]
        public void Test1()
        {
            string answer = countTable.SizeTable(-1);
            Assert.AreEqual("Елементів у таблиці немає", answer);
        }

        [TestMethod]
        public void Test2()
        {
            string answer = countTable.SizeTable(0);
            Assert.AreEqual("Елементів у таблиці немає", answer);
        }

        [TestMethod]
        public void Test3()
        {
            string answer = countTable.SizeTable(1);
            Assert.AreEqual("Маленька таблиця", answer);
        }

        [TestMethod]
        public void Test4()
        {
            string answer = countTable.SizeTable(99);
            Assert.AreEqual("Маленька таблиця", answer);
        }

        [TestMethod]
        public void Test5()
        {
            string answer = countTable.SizeTable(100);
            Assert.AreEqual("Маленька таблиця", answer);
        }

        [TestMethod]
        public void Test6()
        {
            string answer = countTable.SizeTable(101);
            Assert.AreEqual("Середня таблиця", answer);
        }

        [TestMethod]
        public void Test7()
        {
            string answer = countTable.SizeTable(999);
            Assert.AreEqual("Середня таблиця", answer);
        }

        [TestMethod]
        public void Test8()
        {
            string answer = countTable.SizeTable(1000);
            Assert.AreEqual("Середня таблиця", answer);
        }

        [TestMethod]
        public void Test9()
        {
            string answer = countTable.SizeTable(1001);
            Assert.AreEqual("Велика таблиця", answer);
        }
    }
}
