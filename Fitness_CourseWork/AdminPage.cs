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
    public partial class AdminPage : Form
    {
        public string ConnectionString = @"Data Source=DESKTOP-NG053GB;Initial Catalog=Fitness_Db;Integrated Security=True";
        string loglog = "";
        private AdminLogin admingLogin;
        private Reports reports;
        private Statistics statistics;
        public AdminPage()
        {
            InitializeComponent();
        }
        public AdminPage(string log)
        {
            InitializeComponent();
            loglog = log;
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitness_DbDataSet1.Тренер". При необходимости она может быть перемещена или удалена.
            this.тренерTableAdapter.Fill(this.fitness_DbDataSet1.Тренер);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitness_DbDataSet1.Розклад_тренера". При необходимости она может быть перемещена или удалена.
            this.розклад_тренераTableAdapter.Fill(this.fitness_DbDataSet1.Розклад_тренера);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitness_DbDataSet1.Розклад_групи". При необходимости она может быть перемещена или удалена.
            this.розклад_групиTableAdapter.Fill(this.fitness_DbDataSet1.Розклад_групи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitness_DbDataSet1.Клієнт". При необходимости она может быть перемещена или удалена.
            this.клієнтTableAdapter.Fill(this.fitness_DbDataSet1.Клієнт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitness_DbDataSet1.Групи". При необходимости она может быть перемещена или удалена.
            this.групиTableAdapter.Fill(this.fitness_DbDataSet1.Групи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitness_DbDataSet1.Адміністратор". При необходимости она может быть перемещена или удалена.
            this.адміністраторTableAdapter.Fill(this.fitness_DbDataSet1.Адміністратор);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitness_DbDataSet1.Абонемент". При необходимости она может быть перемещена или удалена.
            this.абонементTableAdapter.Fill(this.fitness_DbDataSet1.Абонемент);
            OwnInformation();
            dataGridView1.AutoGenerateColumns = true;
        }

        public void OwnInformation()
        {
            string query = "SELECT Адміністратор.*, [Акаунт адміністратора].Логін, [Акаунт адміністратора].Пароль, [Акаунт адміністратора].[Перевірочне слово] FROM Адміністратор, [Акаунт адміністратора] WHERE Адміністратор.Id = [Акаунт адміністратора].Id_адміна AND [Акаунт адміністратора].[Логін] = '" + loglog + "'";
            SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
            SqlDataAdapter sqlDataAdapt = new SqlDataAdapter(query, sqlConnectionString);
            DataTable dataTable = new DataTable();
            sqlDataAdapt.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            label4.Text = "Власна інформація";
            label2.Text = "У пошуку не існує сенсу";
            iconButton1.Enabled = false;
            textBox1.Enabled = false;
            toolStripMenuItem2.Enabled = false;
            toolStripMenuItem8.Enabled = false;
            toolStripMenuItem15.Enabled = false;
        }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            OwnInformation();
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AdminPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            admingLogin = new AdminLogin();
            admingLogin.Show();
            this.Close();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
            SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM Групи", sqlConnectionString);
            DataTable dataTable = new DataTable();
            sqlDataAdapt.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            label4.Text = "Групи";
            label2.Text = "Пошук по виду занять";
            textBox1.Clear();
            toolStripMenuItem10.Text = "Сортувати згідно назви групи";
            toolStripMenuItem11.Text = "Сортувати згідно ID групи";
            iconButton1.Enabled = true;
            textBox1.Enabled = true;
            toolStripMenuItem2.Enabled = true;
            toolStripMenuItem1.Enabled = true;
            toolStripMenuItem8.Enabled = true;
            toolStripMenuItem15.Enabled = true;
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            GroupSchedule groupSchedule = new GroupSchedule();
            groupSchedule.ShowDialog();
            /*SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
            SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM [Розклад групи]", sqlConnectionString);
            DataTable dataTable = new DataTable();
            sqlDataAdapt.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            label4.Text = "Розклад груп";
            label2.Text = "Пошук по дню тижня";
            textBox1.Clear();
            toolStripMenuItem10.Text = "Сортувати згідно дня тижня";
            toolStripMenuItem11.Text = "Сортувати згідно вида занять";
            iconButton1.Enabled = true;
            textBox1.Enabled = true;
            toolStripMenuItem2.Enabled = true;
            toolStripMenuItem1.Enabled = true;
            toolStripMenuItem8.Enabled = true;
            toolStripMenuItem15.Enabled = true;*/
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
            SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM Тренер", sqlConnectionString);
            DataTable dataTable = new DataTable();
            sqlDataAdapt.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            label4.Text = "Тренер";
            label2.Text = "Пошук по прізвищу";
            textBox1.Clear();
            toolStripMenuItem10.Text = "Сортувати згідно прізвища тренера";
            toolStripMenuItem11.Text = "Сортувати згідно ID тренера";
            iconButton1.Enabled = true;
            textBox1.Enabled = true;
            toolStripMenuItem2.Enabled = true;
            toolStripMenuItem1.Enabled = true;
            toolStripMenuItem8.Enabled = true;
            toolStripMenuItem15.Enabled = true;
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
            SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM [Розклад тренера]", sqlConnectionString);
            DataTable dataTable = new DataTable();
            sqlDataAdapt.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            label4.Text = "Розклад тренера";
            label2.Text = "Пошук по дню тижня";
            textBox1.Clear();
            toolStripMenuItem10.Text = "Сортувати згідно дня тижня у розкладі тренера";
            toolStripMenuItem11.Text = "Сортувати згідно ID тренера";
            iconButton1.Enabled = true;
            textBox1.Enabled = true;
            toolStripMenuItem2.Enabled = true;
            toolStripMenuItem1.Enabled = true;
            toolStripMenuItem8.Enabled = true;
            toolStripMenuItem15.Enabled = true;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
            SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM Абонемент", sqlConnectionString);
            DataTable dataTable = new DataTable();
            sqlDataAdapt.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            label4.Text = "Абонемент";
            label2.Text = "Пошук по назві абонементу";
            textBox1.Clear();
            toolStripMenuItem10.Text = "Сортувати згідно назви";
            toolStripMenuItem11.Text = "Сортувати згідно ID абонемента";
            iconButton1.Enabled = true;
            textBox1.Enabled = true;
            toolStripMenuItem2.Enabled = true;
            toolStripMenuItem1.Enabled = true;
            toolStripMenuItem8.Enabled = true;
            toolStripMenuItem15.Enabled = true;
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            string query = "SELECT Клієнт.*, [Акаунт клієнта].Логін, [Акаунт клієнта].Пароль, [Акаунт клієнта].[Перевірочне слово] FROM Клієнт, [Акаунт клієнта] WHERE Клієнт.Id = [Акаунт клієнта].ID_клієнта";
            SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
            SqlDataAdapter sqlDataAdapt = new SqlDataAdapter(query, sqlConnectionString);
            DataTable dataTable = new DataTable();
            sqlDataAdapt.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            label4.Text = "Клієнт";
            label2.Text = "Пошук за статтю";
            textBox1.Clear();
            toolStripMenuItem10.Text = "Сортувати згідно прізвища";
            toolStripMenuItem11.Text = "Сортувати згідно ID клієнта";
            iconButton1.Enabled = true;
            textBox1.Enabled = true;
            toolStripMenuItem2.Enabled = true;
            toolStripMenuItem1.Enabled = true;
            toolStripMenuItem8.Enabled = true;
            toolStripMenuItem15.Enabled = true;
        }

        private void iconButtonS_Click(object sender, EventArgs e)
        {
            reports = new Reports();
            reports.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            switch (label4.Text)
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
                case ("Клієнт"):
                    {
                        string selectString =
                            "[Стать] LIKE '" + textBox1.Text.Trim() + "%'";

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

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem10.Text == "Сортувати згідно назви групи" && label4.Text == "Групи")
            {
                SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM Групи ORDER BY Назва", sqlConnectionString);
                DataTable dataTable = new DataTable();
                sqlDataAdapt.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            else if (toolStripMenuItem10.Text == "Сортувати згідно дня тижня" && label4.Text == "Розклад груп")
            {
                SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM [Розклад групи] ORDER BY [День тижня]", sqlConnectionString);
                DataTable dataTable = new DataTable();
                sqlDataAdapt.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            else if (toolStripMenuItem10.Text == "Сортувати згідно прізвища тренера" && label4.Text == "Тренер")
            {
                SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM [Тренер] ORDER BY [Прізвище]", sqlConnectionString);
                DataTable dataTable = new DataTable();
                sqlDataAdapt.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            else if (toolStripMenuItem10.Text == "Сортувати згідно дня тижня у розкладі тренера" && label4.Text == "Розклад тренера")
            {
                SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM [Розклад тренера] ORDER BY [День тижня]", sqlConnectionString);
                DataTable dataTable = new DataTable();
                sqlDataAdapt.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            else if (toolStripMenuItem10.Text == "Сортувати згідно назви" && label4.Text == "Абонемент")
            {
                SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM Абонемент ORDER BY Назва", sqlConnectionString);
                DataTable dataTable = new DataTable();
                sqlDataAdapt.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            } else if(toolStripMenuItem10.Text == "Сортувати згідно прізвища" && label4.Text == "Клієнт")
            {
                SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM Клієнт ORDER BY Прізвище", sqlConnectionString);
                DataTable dataTable = new DataTable();
                sqlDataAdapt.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem11.Text == "Сортувати згідно ID групи" && label4.Text == "Групи")
            {
                SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM Групи ORDER BY [Id]", sqlConnectionString);
                DataTable dataTable = new DataTable();
                sqlDataAdapt.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            else if (toolStripMenuItem11.Text == "Сортувати згідно вида занять" && label4.Text == "Розклад груп")
            {
                SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM [Розклад групи] ORDER BY [Вид занять]", sqlConnectionString);
                DataTable dataTable = new DataTable();
                sqlDataAdapt.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            else if (toolStripMenuItem11.Text == "Сортувати згідно ID тренера" && label4.Text == "Тренер")
            {
                SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM [Тренер] ORDER BY [Id]", sqlConnectionString);
                DataTable dataTable = new DataTable();
                sqlDataAdapt.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            else if (toolStripMenuItem11.Text == "Сортувати згідно ID тренера" && label4.Text == "Розклад тренера")
            {
                SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM [Розклад тренера] ORDER BY [ID_тренера]", sqlConnectionString);
                DataTable dataTable = new DataTable();
                sqlDataAdapt.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            else if (toolStripMenuItem11.Text == "Сортувати згідно ID абонемента" && label4.Text == "Абонемент")
            {
                SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM Абонемент ORDER BY Id", sqlConnectionString);
                DataTable dataTable = new DataTable();
                sqlDataAdapt.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            else if (toolStripMenuItem11.Text == "Сортувати згідно ID клієнта" && label4.Text == "Клієнт")
            {
                SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM Абонемент ORDER BY Id", sqlConnectionString);
                DataTable dataTable = new DataTable();
                sqlDataAdapt.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            switch(label4.Text)
            {
                case "Групи":
                    AddGroup addGroup = new AddGroup();
                    addGroup.Show();
                    SqlConnection sqlConnectionString1 = new SqlConnection(ConnectionString);
                    SqlDataAdapter sqlDataAdapt1 = new SqlDataAdapter("SELECT * FROM Групи", sqlConnectionString1);
                    DataTable dataTable1 = new DataTable();
                    sqlDataAdapt1.Fill(dataTable1);
                    dataGridView1.DataSource = dataTable1;
                    fitness_DbDataSet1.AcceptChanges();
                    break;
                case "Тренер":
                    AddCoach addCoach = new AddCoach();
                    addCoach.Show();
                    SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                    SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM Тренер", sqlConnectionString);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapt.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    fitness_DbDataSet1.AcceptChanges();
                    break;
                case "Абонемент":
                    AddSeasonTicket addSeasonTicket = new AddSeasonTicket();
                    addSeasonTicket.Show();
                    SqlConnection sqlConnectionString3 = new SqlConnection(ConnectionString);
                    SqlDataAdapter sqlDataAdapt3 = new SqlDataAdapter("SELECT * FROM Абонемент", sqlConnectionString3);
                    DataTable dataTable3 = new DataTable();
                    sqlDataAdapt3.Fill(dataTable3);
                    dataGridView1.DataSource = dataTable3;
                    fitness_DbDataSet1.AcceptChanges();
                    break;
                case "Клієнт":
                    ClientRegistration clientRegistration = new ClientRegistration();
                    clientRegistration.Show();
                    string query = "SELECT Клієнт.*, [Акаунт клієнта].Логін, [Акаунт клієнта].Пароль, [Акаунт клієнта].[Перевірочне слово] FROM Клієнт, [Акаунт клієнта] WHERE Клієнт.Id = [Акаунт клієнта].ID_клієнта";
                    SqlConnection sqlConnectionString4 = new SqlConnection(ConnectionString);
                    SqlDataAdapter sqlDataAdapt4 = new SqlDataAdapter(query, sqlConnectionString4);
                    DataTable dataTable4 = new DataTable();
                    sqlDataAdapt4.Fill(dataTable4);
                    dataGridView1.DataSource = dataTable4;
                    fitness_DbDataSet1.AcceptChanges();
                    break;
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            switch (label4.Text)
            {
                case "Власна інформація":
                    DataGridViewRow selectData = dataGridView1.SelectedRows[0];
                    AdminEditing adminEditing = new AdminEditing(Convert.ToInt32(selectData.Cells[0].Value), Convert.ToString(selectData.Cells[1].Value),
                        Convert.ToString(selectData.Cells[2].Value), Convert.ToString(selectData.Cells[3].Value), Convert.ToDateTime(selectData.Cells[4].Value),
                        Convert.ToString(selectData.Cells[5].Value), Convert.ToString(selectData.Cells[6].Value), Convert.ToString(selectData.Cells[7].Value));
                    adminEditing.ShowDialog();
                    AdminLoginEditing adminLoginEditing = new AdminLoginEditing(Convert.ToInt32(selectData.Cells[0].Value), Convert.ToString(selectData.Cells[8].Value), Convert.ToString(selectData.Cells[9].Value), Convert.ToString(selectData.Cells[10].Value));
                    adminLoginEditing.ShowDialog();
                    OwnInformation();
                    fitness_DbDataSet1.AcceptChanges();
                    break;
                case "Групи":
                    DataGridViewRow selectData1 = dataGridView1.SelectedRows[0];
                    AddGroup addGroup = new AddGroup(Convert.ToInt32(selectData1.Cells[0].Value), Convert.ToString(selectData1.Cells[1].Value),
                         Convert.ToString(selectData1.Cells[2].Value), Convert.ToInt32(selectData1.Cells[3].Value), Convert.ToInt32(selectData1.Cells[4].Value));
                    addGroup.ShowDialog();
                    SqlConnection sqlConnectionString1 = new SqlConnection(ConnectionString);
                    SqlDataAdapter sqlDataAdapt1 = new SqlDataAdapter("SELECT * FROM Групи", sqlConnectionString1);
                    DataTable dataTable1 = new DataTable();
                    sqlDataAdapt1.Fill(dataTable1);
                    dataGridView1.DataSource = dataTable1;
                    fitness_DbDataSet1.AcceptChanges();
                    break;
                case "Тренер":
                    DataGridViewRow selectData2 = dataGridView1.SelectedRows[0];
                    AddCoach addCoach = new AddCoach(Convert.ToInt32(selectData2.Cells[0].Value), Convert.ToString(selectData2.Cells[1].Value),
                        Convert.ToString(selectData2.Cells[2].Value), Convert.ToString(selectData2.Cells[3].Value), Convert.ToDateTime(selectData2.Cells[4].Value),
                        Convert.ToString(selectData2.Cells[5].Value), Convert.ToString(selectData2.Cells[6].Value), Convert.ToString(selectData2.Cells[7].Value), Convert.ToString(selectData2.Cells[8].Value));
                    addCoach.ShowDialog();
                    SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                    SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM Тренер", sqlConnectionString);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapt.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    fitness_DbDataSet1.AcceptChanges();
                    break;
                case "Абонемент":
                    DataGridViewRow selectData3 = dataGridView1.SelectedRows[0];
                    AddSeasonTicket addSeasonTicket = new AddSeasonTicket(Convert.ToInt32(selectData3.Cells[0].Value), Convert.ToString(selectData3.Cells[1].Value),
                        Convert.ToString(selectData3.Cells[2].Value), Convert.ToString(selectData3.Cells[3].Value));
                    addSeasonTicket.ShowDialog();
                    SqlConnection sqlConnectionString3 = new SqlConnection(ConnectionString);
                    SqlDataAdapter sqlDataAdapt3 = new SqlDataAdapter("SELECT * FROM Абонемент", sqlConnectionString3);
                    DataTable dataTable3 = new DataTable();
                    sqlDataAdapt3.Fill(dataTable3);
                    dataGridView1.DataSource = dataTable3;
                    fitness_DbDataSet1.AcceptChanges();
                    break;
                case "Клієнт":
                    DataGridViewRow selectData4 = dataGridView1.SelectedRows[0];
                    ClientRegistration clientRegistration = new ClientRegistration(Convert.ToInt32(selectData4.Cells[0].Value), Convert.ToString(selectData4.Cells[1].Value),
                        Convert.ToString(selectData4.Cells[2].Value), Convert.ToString(selectData4.Cells[3].Value), Convert.ToDateTime(selectData4.Cells[4].Value),
                        Convert.ToString(selectData4.Cells[5].Value), Convert.ToString(selectData4.Cells[6].Value), Convert.ToString(selectData4.Cells[7].Value));
                    clientRegistration.ShowDialog();
                    ClientLoginRegistration clientLoginRegistration = new ClientLoginRegistration(Convert.ToInt32(selectData4.Cells[0].Value), Convert.ToString(selectData4.Cells[8].Value), Convert.ToString(selectData4.Cells[9].Value), Convert.ToString(selectData4.Cells[10].Value));
                    clientLoginRegistration.ShowDialog();
                    SqlConnection sqlConnectionString4 = new SqlConnection(ConnectionString);
                    SqlDataAdapter sqlDataAdapt4 = new SqlDataAdapter("SELECT * FROM Клієнт", sqlConnectionString4);
                    DataTable dataTable4 = new DataTable();
                    sqlDataAdapt4.Fill(dataTable4);
                    dataGridView1.DataSource = dataTable4;
                    fitness_DbDataSet1.AcceptChanges();
                    break;
            }

        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            switch(label4.Text)
            {
                case "Групи":
                    if (DialogResult.OK == MessageBox.Show("Ви хочете видалити дані?", "Видалити дані",
                            MessageBoxButtons.OKCancel))
                    {
                        SqlConnection sqlconn = new SqlConnection(ConnectionString);
                        sqlconn.Open();
                        SqlCommand query =
                            new SqlCommand(
                                "DELETE FROM Групи WHERE Id =" +
                                dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), sqlconn);
                        query.ExecuteNonQuery();
                        sqlconn.Close();
                        SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                        SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM Групи", sqlConnectionString);
                        DataTable dataTable = new DataTable();
                        sqlDataAdapt.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                        fitness_DbDataSet1.AcceptChanges();
                    }
                    break;
                case "Тренер":
                    if (DialogResult.OK == MessageBox.Show("Ви хочете видалити дані?", "Видалити дані",
                            MessageBoxButtons.OKCancel))
                    {
                        SqlConnection sqlconn = new SqlConnection(ConnectionString);
                        sqlconn.Open();
                        SqlCommand query =
                            new SqlCommand(
                                "DELETE FROM Тренер WHERE Id =" +
                                dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), sqlconn);
                        query.ExecuteNonQuery();
                        sqlconn.Close();
                        SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                        SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM Тренер", sqlConnectionString);
                        DataTable dataTable = new DataTable();
                        sqlDataAdapt.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                        fitness_DbDataSet1.AcceptChanges();
                    }
                    break;
                case "Абонемент":
                    if (DialogResult.OK == MessageBox.Show("Ви хочете видалити дані?", "Видалити дані",
                            MessageBoxButtons.OKCancel))
                    {
                        SqlConnection sqlconn = new SqlConnection(ConnectionString);
                        sqlconn.Open();
                        SqlCommand query =
                            new SqlCommand(
                                "DELETE FROM Абонемент WHERE Id =" +
                                dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), sqlconn);
                        query.ExecuteNonQuery();
                        sqlconn.Close();
                        SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                        SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM Абонемент", sqlConnectionString);
                        DataTable dataTable = new DataTable();
                        sqlDataAdapt.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                        fitness_DbDataSet1.AcceptChanges();
                    }
                    break; ;
                case "Клієнт":
                    if (DialogResult.OK == MessageBox.Show("Ви хочете видалити дані?", "Видалити дані",
                            MessageBoxButtons.OKCancel))
                    {
                        SqlConnection sqlconn = new SqlConnection(ConnectionString);
                        sqlconn.Open();
                        SqlCommand query =
                            new SqlCommand(
                                "DELETE FROM Клієнт WHERE Id =" +
                                dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), sqlconn);
                        query.ExecuteNonQuery();
                        sqlconn.Close();
                        SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                        SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT * FROM Клієнт", sqlConnectionString);
                        DataTable dataTable = new DataTable();
                        sqlDataAdapt.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                        fitness_DbDataSet1.AcceptChanges();
                    }
                    break;
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            SqlQuery sqlQuery = new SqlQuery();
            sqlQuery.Show();
        }

        private void iconButtonF_Click(object sender, EventArgs e)
        {
            statistics = new Statistics();
            statistics.Show();
        }

        private void iconButtonMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
            SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("SELECT Купівля.ID_абонемента, Абонемент.Назва, Абонемент.[Вид занять], Купівля.ID_клієнта, Купівля.[Початок дії] FROM Купівля, Абонемент WHERE Купівля.ID_абонемента = Абонемент.Id", sqlConnectionString);
            DataTable dataTable = new DataTable();
            sqlDataAdapt.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            label4.Text = "Придбаний абонемент";
            label2.Text = "Пошук по назві абонементу";
            textBox1.Clear();
            toolStripMenuItem10.Text = "Сортувати згідно назви";
            toolStripMenuItem11.Text = "Сортувати згідно ID абонемента";
            iconButton1.Enabled = true;
            textBox1.Enabled = true;
            toolStripMenuItem2.Enabled = true;
            toolStripMenuItem1.Enabled = true;
            toolStripMenuItem8.Enabled = true;
            toolStripMenuItem15.Enabled = true;
        }
    }
}
