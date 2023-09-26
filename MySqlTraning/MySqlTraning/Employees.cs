using System;
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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
            Load_Date();
        }

        public void Load_Date()
        {
            DB db = new DB();
            string showDate = "select * from employees";
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

        private void inputEmployee_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand insertCommand = new MySqlCommand("INSERT INTO `employees` (`full_name`, `id_work_position`, `more_information`) VALUES (@fullName, @id_work_position, @more_information);", db.getConnection());
            insertCommand.Parameters.Add("@fullName", MySqlDbType.VarChar).Value = fullNameBox.Text;
            insertCommand.Parameters.Add("@id_work_position", MySqlDbType.Int32).Value = workPositionBox.Text;            
            insertCommand.Parameters.Add("@more_information", MySqlDbType.VarChar).Value = moreInformationBox.Text;
                              
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
                int idToDelete = (int)selectedRow.Cells["id_employees"].Value;

                // Удаляем строку из DataGridView
                dataGridView1.Rows.Remove(selectedRow);

                // Удаление записи из базы данных MySQL
                using (MySqlConnection connection = new MySqlConnection("server=localhost;uid=Biba;pwd=aboba123;database=coolcompany"))
                {
                    connection.Open();

                    // Создаем команду SQL для удаления записи
                    string query = "DELETE FROM employees WHERE id_employees = @id";
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
