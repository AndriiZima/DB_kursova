﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySqlTraning
{
    public partial class Program_accounting : Form
    {
        public Program_accounting()
        {
            InitializeComponent();
            Load_Date();
        }

        public void Load_Date()
        {
            DB db = new DB();
            string showDate = "select * from program_accounting";
            MySqlCommand showDateComm = new MySqlCommand(showDate);
            showDateComm.Connection = db.getConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = showDateComm;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;

            dataGridView1.DataSource = bindingSource;
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand insertCommand = new MySqlCommand("INSERT INTO `program_accounting` (`name_program`, `сonducting_time`, `id_employees`, `id_guests`, `more_information`) VALUES (@name_program, @сonducting_time, @id_employees, @id_guests, @more_information);", db.getConnection());
            insertCommand.Parameters.Add("@name_program", MySqlDbType.VarChar).Value = textBox1.Text;
            insertCommand.Parameters.Add("@сonducting_time", MySqlDbType.VarChar).Value = textBox2.Text;
            insertCommand.Parameters.Add("@id_employees", MySqlDbType.Int32).Value = textBox3.Text;
            insertCommand.Parameters.Add("@id_guests", MySqlDbType.Int32).Value = textBox4.Text;
            insertCommand.Parameters.Add("@more_information", MySqlDbType.VarChar).Value = textBox5.Text;

            db.openConnection();
            if (insertCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Занесено до бази даних.");
            }
            else
            {
                MessageBox.Show("Помилка");
            }

            db.closeConnection();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Load_Date();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Получаем выбранную строку
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Получаем значение первичного ключа для удаления
                int idToDelete = (int)selectedRow.Cells["id_program_accounting"].Value;

                // Удаляем строку из DataGridView
                dataGridView1.Rows.Remove(selectedRow);

                // Удаление записи из базы данных MySQL
                using (MySqlConnection connection = new MySqlConnection("server=localhost;uid=Biba;pwd=aboba123;database=coolcompany"))
                {
                    connection.Open();

                    // Создаем команду SQL для удаления записи
                    string query = "DELETE FROM program_accounting WHERE id_program_accounting = @id";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", idToDelete);

                    // Выполняем команду удаления
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Запись успешно удалена из базы данных.");
                    }
                    else
                    {
                        MessageBox.Show("Ошибка удаления записи из базы данных.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления.");
            }
        }
    }
}
