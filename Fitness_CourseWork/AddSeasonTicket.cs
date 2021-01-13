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
    public partial class AddSeasonTicket : Form
    {
        public string sqlConnectionString = @"Data Source=DESKTOP-NG053GB;Initial Catalog=Fitness_Db;Integrated Security=True";
        private int seasonTicketId;
        private bool editParameter;
        public AddSeasonTicket()
        {
            InitializeComponent();
            абонементTableAdapter.Fill(this.fitness_DbDataSet1.Абонемент);
            editParameter = false;
        }
        public AddSeasonTicket(int seasonTicketId, string name, string ticketPeriod, string type)
        {
            InitializeComponent();
            абонементTableAdapter.Fill(this.fitness_DbDataSet1.Абонемент);
            textBox2.Text = name;
            switch (ticketPeriod.ToUpper())
            {
                case "3":
                    comboBox1.SelectedIndex = 0;
                    break;
                case "6":
                    comboBox1.SelectedIndex = 1;
                    break;
                case "10":
                    comboBox1.SelectedIndex = 2;
                    break;
                case "12":
                    comboBox1.SelectedIndex = 3;
                    break;
                default:
                    comboBox1.SelectedIndex = 0;
                    break;
            }
            //comboBox1.SelectedValue = ticketPeriod;
            switch (type.ToUpper())
            {
                case "Груповий":
                    comboBox2.SelectedIndex = 0;
                    break;
                case "Тренажерний":
                    comboBox2.SelectedIndex = 1;
                    break;
                case "Басейн":
                    comboBox2.SelectedIndex = 2;
                    break;
                default:
                    comboBox2.SelectedIndex = 0;
                    break;
            }
            this.seasonTicketId = seasonTicketId;
            editParameter = true;

        }

        private void AddSeasonTicket_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitness_DbDataSet1.Абонемент". При необходимости она может быть перемещена или удалена.
            //this.абонементTableAdapter.Fill(this.fitness_DbDataSet1.Абонемент);

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string ticketPeriod = "";
            if (comboBox1.SelectedIndex == 0)
            {
                ticketPeriod = "3";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                ticketPeriod = "6";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                ticketPeriod = "10";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                ticketPeriod = "12";
            }
            string type = "";
            if (comboBox2.SelectedIndex == 0)
            {
                ticketPeriod = "Груповий";
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                ticketPeriod = "Тренажерний";
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                ticketPeriod = "Басейн";
            }
            if (!editParameter)
            {
                SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
                sqlConnection.Open();
                SqlCommand queryInsert = new SqlCommand("INSERT INTO Абонемент (Назва, [Срок абонементу], [Вид занять]) " + "Values(@data_0, @data_1, @data_2)", sqlConnection);
                queryInsert.Parameters.Add("@data_0", SqlDbType.NVarChar).Value = textBox2.Text;
                queryInsert.Parameters.Add("@data_1", SqlDbType.NVarChar).Value = ticketPeriod;
                queryInsert.Parameters.Add("@data_2", SqlDbType.NVarChar).Value = type;
                queryInsert.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Додано абонемент.");
                this.Close();
            }
            else if (editParameter)
            {
                SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
                sqlConnection.Open();
                string queryUpdate = String.Format("UPDATE Абонемент Set [Назва] = N'{1}', [Срок абонементу] = N'{2}', [Вид занять] = N'{3}' WHERE Id = '{0}' ",
                    seasonTicketId.ToString(), textBox2.Text, ticketPeriod, type);
                SqlCommand query = new SqlCommand(queryUpdate, sqlConnection);
                query.ExecuteNonQuery();
                sqlConnection.Close();
                this.Close();

            }
            else MessageBox.Show("Перевірте дані", "", MessageBoxButtons.OK);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Ви справді хочете вийти?", "Вийти", MessageBoxButtons.OKCancel))
            {
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
