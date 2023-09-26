using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySqlTraning
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void mainChangeButton_Click(object sender, EventArgs e)
        {

            MainChange_Switch();

            //замінив для ЯП
            /*
            switch (choiceChangeTable.Text)
            {
                case "Співробітник":
                    Employees employees = new Employees();
                    employees.Show();
                    break;
                case "Гості програми":
                    Guests_program guests_Program = new Guests_program();
                    guests_Program.Show();
                    break;
                case "Посада":
                    Work_position work_Position = new Work_position();
                    work_Position.Show();
                    break;
                case "Сюжет":
                    Plot plot = new Plot();
                    plot.Show();
                    break;
                case "Облік програм":
                    Program_accounting program_Accounting = new Program_accounting();
                    program_Accounting.Show();
                    break;
                case "Програма в ефірі":
                    Program_ether program_Ether = new Program_ether();
                    program_Ether.Show();
                    break;
                case "Довідник учасників":
                    Directory_participants directory_Participants = new Directory_participants();
                    directory_Participants.Show();
                    break;
                case "Довідник змагань":
                    Directory_competitions directory_Competitions = new Directory_competitions();
                    directory_Competitions.Show();
                    break;
            }*/
        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            switch (requestComboBox.Text)
            {
                case "Список сюжетів, які веде заданий робітникa":
                    Request_1 request_1 = new Request_1();
                    request_1.Show();
                    break;
                case "Вивести список програм, який веде заданий робітник":
                    Request_2 request_2 = new Request_2();
                    request_2.Show();
                    break;
                case "Знайти ведучого, прізвище якого починається на літеру А":
                    Request_3 request_3 = new Request_3();
                    request_3.Show();
                    break;
                case "Знайти гостей, прізвище якого починається на літеру У":
                    Request_4 request_4 = new Request_4();
                    request_4.Show();
                    break;
                case "Cписок програм, які були проведені с 2022-05-01 до 2022-05-02":
                    Request_5 request_5 = new Request_5();
                    request_5.Show();
                    break;
                case "Cписок робітників, які були в ефірі с 2022-05-01 до 2022-05-02":
                    Request_6 request_6 = new Request_6();
                    request_6.Show();
                    break;
                case "Скільки ефіров вийшло за останній тиждень?":
                    Request_7 request_7 = new Request_7();
                    request_7.Show();
                    break;
                case "Скільки гостей було за останній тиждень?":
                    Request_8 request_8 = new Request_8();
                    request_8.Show();
                    break;
                case "Скільки ефірів провів кожен робітник?":
                    Request_9 request_9 = new Request_9();
                    request_9.Show();
                    break;
                case "Скільки сюжетів зробив кожен робітник?":
                    Request_10 request_10 = new Request_10();
                    request_10.Show();
                    break;
                case "Хто з співробітників провів більш за всіх ефірів?":
                    Request_11 request_11 = new Request_11();
                    request_11.Show();
                    break;
                case "Хто з співробітників провів менш за всіх ефірів?":
                    Request_12 request_12 = new Request_12();
                    request_12.Show();
                    break;
                case "Список співробітників та програм, співробітники яких вели програми в ефірі":
                    Request_13 request_13 = new Request_13();
                    request_13.Show();
                    break;
                case "Прізвища працівників та кількість проведених ефірів":
                    Request_14 request_14 = new Request_14();
                    request_14.Show();
                    break;
                case "Хто не проводив ефір на цьому тиждні?":
                    Request_15 request_15 = new Request_15();
                    request_15.Show();
                    break;
                case "У кого з співробітників немає сюжету?":
                    Request_16 request_16 = new Request_16();
                    request_16.Show();
                    break;
                case "Кого з гостей немає в списку учасників?":
                    Request_17 request_17 = new Request_17();
                    request_17.Show();
                    break;
                case "Cписок співробітників з коментарем: \"Має найбільше проведених ефірів\"":
                    Request_18 request_18 = new Request_18();
                    request_18.Show();
                    break;
                case "Список співробітників з коментарем: \"Немає ефірів сьогодні\"":
                    Request_19 request_19 = new Request_19();
                    request_19.Show();
                    break;
                case "Запис \"Провів найбільшу кількість ефірів\" у таблицю співробітників":
                    Request_20 request_20 = new Request_20();
                    request_20.Show();
                    break;
                case "Запис \"Ця програма найчастіше виходить в ефір\"":
                    Request_21 request_21 = new Request_21();
                    request_21.Show();
                    break;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form2 = new Form1();
            form2.Show();
        }

        private void MainChange_Switch()
        {
            switch (choiceChangeTable.Text)
            {
                case "Співробітник":
                    Employees employees = new Employees();
                    employees.Show();
                    break;
                case "Гості програми":
                    Guests_program guests_Program = new Guests_program();
                    guests_Program.Show();
                    break;
                case "Посада":
                    Work_position work_Position = new Work_position();
                    work_Position.Show();
                    break;
                case "Сюжет":
                    Plot plot = new Plot();
                    plot.Show();
                    break;
                case "Облік програм":
                    Program_accounting program_Accounting = new Program_accounting();
                    program_Accounting.Show();
                    break;
                case "Програма в ефірі":
                    Program_ether program_Ether = new Program_ether();
                    program_Ether.Show();
                    break;
                case "Довідник учасників":
                    Directory_participants directory_Participants = new Directory_participants();
                    directory_Participants.Show();
                    break;
                case "Довідник змагань":
                    Directory_competitions directory_Competitions = new Directory_competitions();
                    directory_Competitions.Show();
                    break;
            }
        }
    }
}
