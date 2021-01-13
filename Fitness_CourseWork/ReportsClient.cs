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
    public partial class ReportsClient : Form
    {
        public string ConnectionString = @"Data Source=DESKTOP-NG053GB;Initial Catalog=Fitness_Db;Integrated Security=True";
        public ReportsClient()
        {
            InitializeComponent();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            switch (label8.Text)
            {
                case "Клубна карта":
                    {

                        DataTable dataTable = (DataTable)dataGridView1.DataSource;
                        DateTime dateNow = DateTime.Now;

                        using (StreamWriter x = new StreamWriter(Directory.GetCurrentDirectory() + @"\club_cart.txt", false))
                        {
                            foreach (DataRow y in dataTable.Rows)
                            {
                                x.WriteLine("			                    Фітнес-клуб 'GymFit' ");
                                x.WriteLine("Клубна карта клієнта: " + y[0].ToString());
                                x.WriteLine("Прізвище: " + y[1].ToString());
                                x.WriteLine("Ім'я: " + y[2].ToString());
                                x.WriteLine("По-батькові: " + y[3].ToString());
                                x.WriteLine("Зареєстрована: " + y[4].ToString());
                                x.WriteLine();
                            }
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
