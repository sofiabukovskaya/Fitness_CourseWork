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
    public partial class Statistics : Form
    {
        public string ConnectionString = @"Data Source=DESKTOP-NG053GB;Initial Catalog=Fitness_Db;Integrated Security=True";
        public Statistics()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string query = "SELECT [Розклад тренера].ID_тренера, Тренер.Прізвище, Тренер.[Ім'я], COUNT([Розклад тренера].[Початок занять]) AS Кількість FROM Тренер, [Розклад тренера] WHERE Тренер.Id = [Розклад тренера].ID_тренера GROUP BY [Розклад тренера].ID_тренера, Тренер.Id, Тренер.Прізвище, Тренер.[Ім'я]";
            SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnectionString);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            label8.Text = "Кількість годин за тиждень";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            string query = "SELECT Групи.Назва, Групи.[Вид занять], COUNT(Групи.[Вид занять]) AS Кількість FROM Групи GROUP BY Групи.Назва, Групи.[Вид занять]";
            SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnectionString);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            label8.Text = "Кількість груп за видом занять";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string query = "SELECT Абонемент.Назва, Абонемент.[Срок абонементу], COUNT(Купівля.[ID_абонемента]) AS Кількість FROM Абонемент, Купівля WHERE Абонемент.Id = Купівля.ID_абонемента GROUP BY Абонемент.Назва, Абонемент.[Срок абонементу]";
            SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnectionString);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            label8.Text = "Кількість груп за видом занять";
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            string query = "SELECT [Розклад групи].[День тижня], COUNT([Розклад групи].[День тижня]) AS [Кількість годин] FROM [Розклад групи] GROUP BY [Розклад групи].[День тижня]";
            SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnectionString);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            label8.Text = "Кількість годин згідно дня тижня";
        }
    }
}
