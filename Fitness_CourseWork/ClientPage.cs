using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_CourseWork
{
    public partial class ClientPage : Form
    {
        private ClientLogin clientLogin;
        private FindGroup findGroup;
        private BuySeasonTicket seasonTicket;
        private ReportsClient reports;
        public string ConnectionString = @"Data Source=DESKTOP-NG053GB;Initial Catalog=Fitness_Db;Integrated Security=True";
        string loglog = "";
        private bool IsShownButton;
        public ClientPage()
        {
            InitializeComponent();
        }
        public ClientPage(string log)
        {
            InitializeComponent();
            loglog = log;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClienPage_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitness_DbDataSet1.Тренер". При необходимости она может быть перемещена или удалена.
            this.тренерTableAdapter.Fill(this.fitness_DbDataSet1.Тренер);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitness_DbDataSet1.Розклад_тренера". При необходимости она может быть перемещена или удалена.
            this.розклад_тренераTableAdapter.Fill(this.fitness_DbDataSet1.Розклад_тренера);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitness_DbDataSet1.Розклад_групи". При необходимости она может быть перемещена или удалена.
            this.розклад_групиTableAdapter.Fill(this.fitness_DbDataSet1.Розклад_групи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitness_DbDataSet1.Купівля". При необходимости она может быть перемещена или удалена.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitness_DbDataSet1.Групи". При необходимости она может быть перемещена или удалена.
            this.групиTableAdapter.Fill(this.fitness_DbDataSet1.Групи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitness_DbDataSet1.Адміністратор". При необходимости она может быть перемещена или удалена.
            this.адміністраторTableAdapter.Fill(this.fitness_DbDataSet1.Адміністратор);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitness_DbDataSet1.Абонемент". При необходимости она может быть перемещена или удалена.
            this.абонементTableAdapter.Fill(this.fitness_DbDataSet1.Абонемент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitness_DbDataSet1.Клієнт". При необходимости она может быть перемещена или удалена.
            this.клієнтTableAdapter.Fill(this.fitness_DbDataSet1.Клієнт);
            OwnInformation();
            dataGridView1.AutoGenerateColumns = true;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            clientLogin = new ClientLogin();
            clientLogin.Show();
            this.Close();
        }


        #region
        //LoadDataEvents
        public void OwnInformation()
        {
            string query = "SELECT Клієнт.*, [Акаунт клієнта].Логін, [Акаунт клієнта].Пароль, [Акаунт клієнта].[Перевірочне слово] FROM Клієнт, [Акаунт клієнта] WHERE Клієнт.Id = [Акаунт клієнта].ID_клієнта AND [Акаунт клієнта].[Логін] = '" + loglog + "'";
            SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
            SqlDataAdapter sqlDataAdapt = new SqlDataAdapter(query, sqlConnectionString);
            DataTable dataTable = new DataTable();
            sqlDataAdapt.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            label1.Text = "Власна інформація";
            label2.Text = "У пошуку не існує сенсу";
            iconButton1.Enabled = false;
            textBox1.Enabled = false;
            toolStripMenuItem2.Enabled = false;
            toolStripMenuItem5.Enabled = false;
            toolStripMenuItem1.Enabled = true;
            //MessageBox.Show("На жаль, сортувати та фільтрувати інформацію не має сенсу.");
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
            SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM Групи", sqlConnectionString);
            DataTable dataTable = new DataTable();
            sqlDataAdapt.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            label1.Text = "Групи";
            label2.Text = "Пошук по виду занять";
            textBox1.Clear();
            toolStripMenuItem10.Text = "Сортувати згідно назви групи";
            toolStripMenuItem11.Text = "Сортувати згідно ID групи";
            iconButton1.Enabled = true;
            textBox1.Enabled = true;
            toolStripMenuItem2.Enabled = true;
            toolStripMenuItem5.Enabled = true;
            toolStripMenuItem1.Enabled = false;
            //MessageBox.Show("На жаль, слід зайти в систему як адміністратор для того, щоб змінювати дані про групи.");
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
            SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM [Розклад групи]", sqlConnectionString);
            DataTable dataTable = new DataTable();
            sqlDataAdapt.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            label1.Text = "Розклад груп";
            label2.Text = "Пошук по дню тижня";
            textBox1.Clear();
            toolStripMenuItem10.Text = "Сортувати згідно дня тижня";
            toolStripMenuItem11.Text = "Сортувати згідно вида занять";
            iconButton1.Enabled = true;
            textBox1.Enabled = true;
            toolStripMenuItem2.Enabled = true;
            toolStripMenuItem5.Enabled = true;
            toolStripMenuItem1.Enabled = false;
            //MessageBox.Show("На жаль, слід зайти в систему як адміністратор для того, щоб змінювати дані про розклад груп.");
        }
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
            SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM Тренер", sqlConnectionString);
            DataTable dataTable = new DataTable();
            sqlDataAdapt.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            label1.Text = "Тренер";
            label2.Text = "Пошук по прізвищу";
            textBox1.Clear();
            toolStripMenuItem10.Text = "Сортувати згідно прізвища тренера";
            toolStripMenuItem11.Text = "Сортувати згідно ID тренера";
            iconButton1.Enabled = true;
            textBox1.Enabled = true;
            toolStripMenuItem2.Enabled = true;
            toolStripMenuItem5.Enabled = true;
            toolStripMenuItem1.Enabled = false;
            //MessageBox.Show("На жаль, слід зайти в систему як адміністратор для того, щоб змінювати дані.");
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
            SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM [Розклад тренера]", sqlConnectionString);
            DataTable dataTable = new DataTable();
            sqlDataAdapt.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            label1.Text = "Розклад тренера";
            label2.Text = "Пошук по дню тижня";
            textBox1.Clear();
            toolStripMenuItem10.Text = "Сортувати згідно дня тижня у розкладі тренера";
            toolStripMenuItem11.Text = "Сортувати згідно ID тренера";
            iconButton1.Enabled = true;
            textBox1.Enabled = true;
            toolStripMenuItem2.Enabled = true;
            toolStripMenuItem5.Enabled = true;
            toolStripMenuItem1.Enabled = false;
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
            SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM Абонемент", sqlConnectionString);
            DataTable dataTable = new DataTable();
            sqlDataAdapt.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            label1.Text = "Абонемент";
            label2.Text = "Пошук по назві абонементу";
            textBox1.Clear();
            toolStripMenuItem10.Text = "Сортувати згідно назви";
            toolStripMenuItem11.Text = "Сортувати згідно ID абонемента";
            iconButton1.Enabled = true;
            textBox1.Enabled = true;
            toolStripMenuItem2.Enabled = true;
            toolStripMenuItem5.Enabled = true;
            toolStripMenuItem1.Enabled = false;
        }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            OwnInformation();
        }
        private void ShowButton(object sender, EventArgs e)
        {
            IsShownButton = !IsShownButton;
            iconButton2.Visible = IsShownButton;
        }

        #endregion


        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClientPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectData = dataGridView1.SelectedRows[0];
            ClientRegistration clR = new ClientRegistration(Convert.ToInt32(selectData.Cells[0].Value), Convert.ToString(selectData.Cells[1].Value),
                Convert.ToString(selectData.Cells[2].Value), Convert.ToString(selectData.Cells[3].Value), Convert.ToDateTime(selectData.Cells[4].Value),
                Convert.ToString(selectData.Cells[5].Value), Convert.ToString(selectData.Cells[6].Value), Convert.ToString(selectData.Cells[7].Value));
            clR.ShowDialog();
            ClientLoginRegistration clientLoginRegistration = new ClientLoginRegistration(Convert.ToInt32(selectData.Cells[0].Value), Convert.ToString(selectData.Cells[8].Value), Convert.ToString(selectData.Cells[9].Value), Convert.ToString(selectData.Cells[10].Value));
            clientLoginRegistration.ShowDialog();
            OwnInformation();
            fitness_DbDataSet1.AcceptChanges();
        }

        private void iconButtonF_Click(object sender, EventArgs e)
        {
            seasonTicket = new BuySeasonTicket();
            seasonTicket.Show();
        }

        private void iconButtonT_Click(object sender, EventArgs e)
        {
            findGroup = new FindGroup();
            findGroup.Show();
        }

        private void iconButtonS_Click(object sender, EventArgs e)
        {
            reports = new ReportsClient();
            reports.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem10.Text == "Сортувати згідно назви групи" && label1.Text == "Групи")
            {
                SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM Групи ORDER BY Назва", sqlConnectionString);
                DataTable dataTable = new DataTable();
                sqlDataAdapt.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            } else if (toolStripMenuItem10.Text == "Сортувати згідно дня тижня" && label1.Text == "Розклад груп")
            {
                SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM [Розклад групи] ORDER BY [День тижня]", sqlConnectionString);
                DataTable dataTable = new DataTable();
                sqlDataAdapt.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            } else if (toolStripMenuItem10.Text == "Сортувати згідно прізвища тренера" && label1.Text == "Тренер")
            {
                SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM [Тренер] ORDER BY [Прізвище]", sqlConnectionString);
                DataTable dataTable = new DataTable();
                sqlDataAdapt.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            else if (toolStripMenuItem10.Text == "Сортувати згідно дня тижня у розкладі тренера" && label1.Text == "Розклад тренера")
            {
                SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM [Розклад тренера] ORDER BY [День тижня]", sqlConnectionString);
                DataTable dataTable = new DataTable();
                sqlDataAdapt.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            else if (toolStripMenuItem10.Text == "Сортувати згідно назві" && label1.Text == "Абонемент")
            {
                SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM Абонемент ORDER BY Назва", sqlConnectionString);
                DataTable dataTable = new DataTable();
                sqlDataAdapt.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem11.Text == "Сортувати згідно ID групи" && label1.Text == "Групи")
            {
                SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM Групи ORDER BY [Id]", sqlConnectionString);
                DataTable dataTable = new DataTable();
                sqlDataAdapt.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            else if (toolStripMenuItem11.Text == "Сортувати згідно вида занять" && label1.Text == "Розклад груп")
            {
                SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM [Розклад групи] ORDER BY [Вид занять]", sqlConnectionString);
                DataTable dataTable = new DataTable();
                sqlDataAdapt.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            else if (toolStripMenuItem11.Text == "Сортувати згідно ID тренера" && label1.Text == "Тренер")
            {
                SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM [Тренер] ORDER BY [Id]", sqlConnectionString);
                DataTable dataTable = new DataTable();
                sqlDataAdapt.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            else if (toolStripMenuItem11.Text == "Сортувати згідно ID тренера" && label1.Text == "Розклад тренера")
            {
                SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM [Розклад тренера] ORDER BY [ID_тренера]", sqlConnectionString);
                DataTable dataTable = new DataTable();
                sqlDataAdapt.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            else if (toolStripMenuItem11.Text == "Сортувати згідно ID абонемента" && label1.Text == "Абонемент")
            {
                SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM Абонемент ORDER BY Id", sqlConnectionString);
                DataTable dataTable = new DataTable();
                sqlDataAdapt.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            switch (label1.Text)
            {
                case "Групи":
                    GroupFilter groupFilter = new GroupFilter(this);
                    groupFilter.IsButton += ShowButton;
                    groupFilter.Show();
                    break;
                case "Розклад груп":
                    GroupScheduleFilter groupScheduleFilter = new GroupScheduleFilter(this);
                    groupScheduleFilter.IsButton += ShowButton;
                    groupScheduleFilter.Show();
                    break;
                case "Тренер":
                    CoachFilter coachFilter = new CoachFilter(this);
                    coachFilter.IsButton += ShowButton;
                    coachFilter.Show();
                    break;
                case "Розклад тренера":
                    CoachScheduleFilter coachScheduleFilter = new CoachScheduleFilter(this);
                    coachScheduleFilter.IsButton += ShowButton;
                    coachScheduleFilter.Show();
                    break;
                case "Абонемент":
                    SeasonTicketFilter seasonTicketFilter = new SeasonTicketFilter(this);
                    seasonTicketFilter.IsButton += ShowButton;
                    seasonTicketFilter.Show();
                    break;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            switch (label1.Text)
            {
                case ("Групи"):
                    {
                        string selectString =
                            "[Вид занять] LIKE '" + textBox1.Text.Trim() + "%'";

                        DataRowCollection allRows =
                            ((DataTable)dataGridView1.DataSource).Rows;

                        DataRow[] searchedRows =
                            ((DataTable)dataGridView1.DataSource).
                            Select(selectString);

                        int rowIndex = allRows.IndexOf(searchedRows[0]);

                        dataGridView1.CurrentCell =
                            dataGridView1[0, rowIndex];
                        break;
                    }
                case ("Розклад груп"):
                    {
                        string selectString =
                            "[День тижня] LIKE '" + textBox1.Text.Trim() + "%'";

                        DataRowCollection allRows =
                            ((DataTable)dataGridView1.DataSource).Rows;

                        DataRow[] searchedRows =
                            ((DataTable)dataGridView1.DataSource).
                            Select(selectString);

                        int rowIndex = allRows.IndexOf(searchedRows[0]);

                        dataGridView1.CurrentCell =
                            dataGridView1[0, rowIndex];
                        break;
                    }
                case ("Тренер"):
                    {
                        string selectString =
                            "Прізвище LIKE '" + textBox1.Text.Trim() + "%'";

                        DataRowCollection allRows =
                            ((DataTable)dataGridView1.DataSource).Rows;

                        DataRow[] searchedRows =
                            ((DataTable)dataGridView1.DataSource).
                            Select(selectString);

                        int rowIndex = allRows.IndexOf(searchedRows[0]);

                        dataGridView1.CurrentCell =
                            dataGridView1[0, rowIndex];
                        break;
                    }
                case ("Розклад тренера"):
                    {
                        string selectString =
                            "[День тижня] LIKE '" + textBox1.Text.Trim() + "%'";

                        DataRowCollection allRows =
                            ((DataTable)dataGridView1.DataSource).Rows;

                        DataRow[] searchedRows =
                            ((DataTable)dataGridView1.DataSource).
                            Select(selectString);

                        int rowIndex = allRows.IndexOf(searchedRows[0]);

                        dataGridView1.CurrentCell =
                            dataGridView1[0, rowIndex];
                        break;
                    }
                case ("Абонемент"):
                    {
                        string selectString =
                            "[Назва] LIKE '" + textBox1.Text.Trim() + "%'";

                        DataRowCollection allRows =
                            ((DataTable)dataGridView1.DataSource).Rows;

                        DataRow[] searchedRows =
                            ((DataTable)dataGridView1.DataSource).
                            Select(selectString);

                        int rowIndex = allRows.IndexOf(searchedRows[0]);

                        dataGridView1.CurrentCell =
                            dataGridView1[0, rowIndex];
                        break;
                    }
            }
        }

        private void iconButtonMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconButtonMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;

            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            switch(label1.Text)
            {
                case "Групи":
                    SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Групи", sqlConnectionString);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    IsShownButton = !IsShownButton;
                    iconButton2.Visible = IsShownButton;
                    break;
                case "Розклад груп":
                    SqlConnection sqlConnectionString2 = new SqlConnection(ConnectionString);
                    SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter("SELECT * FROM [Розклад групи]", sqlConnectionString2);
                    DataTable dataTable2 = new DataTable();
                    sqlDataAdapter2.Fill(dataTable2);
                    dataGridView1.DataSource = dataTable2;
                    IsShownButton = !IsShownButton;
                    iconButton2.Visible = IsShownButton;
                    break;
                case "Тренер":
                    SqlConnection sqlConnectionString3 = new SqlConnection(ConnectionString);
                    SqlDataAdapter sqlDataAdapter3 = new SqlDataAdapter("SELECT * FROM Тренер", sqlConnectionString3);
                    DataTable dataTable3 = new DataTable();
                    sqlDataAdapter3.Fill(dataTable3);
                    dataGridView1.DataSource = dataTable3;
                    IsShownButton = !IsShownButton;
                    iconButton2.Visible = IsShownButton;
                    break;
                case "Розклад тренера":
                    SqlConnection sqlConnectionString4 = new SqlConnection(ConnectionString);
                    SqlDataAdapter sqlDataAdapter4 = new SqlDataAdapter("SELECT * FROM [Розклад тренера]", sqlConnectionString4);
                    DataTable dataTable4 = new DataTable();
                    sqlDataAdapter4.Fill(dataTable4);
                    dataGridView1.DataSource = dataTable4;
                    IsShownButton = !IsShownButton;
                    iconButton2.Visible = IsShownButton;
                    break;
                case "Абонемент":
                    SqlConnection sqlConnectionString5 = new SqlConnection(ConnectionString);
                    SqlDataAdapter sqlDataAdapter5 = new SqlDataAdapter("SELECT * FROM [Розклад тренера]", sqlConnectionString5);
                    DataTable dataTable5 = new DataTable();
                    sqlDataAdapter5.Fill(dataTable5);
                    dataGridView1.DataSource = dataTable5;
                    IsShownButton = !IsShownButton;
                    iconButton2.Visible = IsShownButton;
                    break;
            }
        }
    }
}
