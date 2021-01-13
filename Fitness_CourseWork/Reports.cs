using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_CourseWork
{
    public partial class Reports : Form
    {
        public string ConnectionString = @"Data Source=DESKTOP-NG053GB;Initial Catalog=Fitness_Db;Integrated Security=True";
        public Reports()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string query = "SELECT Клієнт.Id, Клієнт.Прізвище, Клієнт.[Ім'я], Клієнт.[По-батькові], Купівля.[Початок дії] FROM Клієнт, Купівля WHERE Клієнт.Id = Купівля.ID_клієнта ORDER BY Клієнт.Id";
            SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnectionString);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            label8.Text = "Клубна карта";
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            switch (label8.Text)
            {
                case "Клубна карта":
                {

                    DataTable dataTable = (DataTable)dataGridView1.DataSource;
                    DateTime dateNow = DateTime.Now;
                    DataGridViewRow selectData = dataGridView1.SelectedRows[0];

                    using (StreamWriter x = new StreamWriter(Directory.GetCurrentDirectory() + @"\club_cart.txt", false))
                    {
                        
                        x.WriteLine("			                    Фітнес-клуб 'GymFit' ");
                        x.WriteLine("Клубна карта клієнта: " + selectData.Cells[0].Value.ToString());
                        x.WriteLine("Прізвище: " + selectData.Cells[1].Value.ToString());
                        x.WriteLine("Ім'я: " + selectData.Cells[2].Value.ToString());
                        x.WriteLine("По-батькові: " + selectData.Cells[3].Value.ToString());
                        x.WriteLine("Зареєстрована: " + selectData.Cells[4].Value.ToString());
                        x.WriteLine();
                       
                        x.WriteLine("Дата формування карти: " + dateNow);
                    }

                    System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\club_cart.txt");
                    break;

                }
                case "Розклад змагань":
                {

                    DataTable dataTable = (DataTable)dataGridView1.DataSource;
                    DateTime dateNow = DateTime.Now;

                    using (StreamWriter x = new StreamWriter(Directory.GetCurrentDirectory() + @"\sched_comp.txt", false))
                    {
                        x.WriteLine("                               Розклад змагань ");
                        x.WriteLine("			                    Фітнес-клуб 'GymFit' ");

                        foreach (DataRow y in dataTable.Rows)
                        {
                            x.WriteLine("Назва змагання: " + y[0].ToString());
                            x.WriteLine("Вид спорту: " + y[1].ToString());
                            x.WriteLine("День тижня: " + y[2].ToString());
                            x.WriteLine("Час початку змагань: " + y[3].ToString());
                            x.WriteLine("Час кінця змагань: " + y[4].ToString());
                            x.WriteLine();
                        }
                        x.WriteLine("Дата формування розкладу змагань: " + dateNow);
                    }

                    System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\sched_comp.txt");
                    break;

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string query = "SELECT Групи.Назва AS [Назва змагання], Групи.[Вид занять] AS [Вид спорту], [Розклад групи].[День тижня], [Розклад групи].[Початок занять] AS [Час початку змагань], [Розклад групи].[Кінець занять] AS [Час кінця змагань] FROM Групи, [Розклад групи] WHERE Групи.Id = [Розклад групи].ID_групи";
            SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnectionString);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            label8.Text = "Розклад змагань";
        }
    }
}
