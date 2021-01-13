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
    public partial class ClientRegistration : Form
    {
        public string sqlConnectionString = @"Data Source=DESKTOP-NG053GB;Initial Catalog=Fitness_Db;Integrated Security=True";
        private int clientID;
        private bool editParameter;
        private ClientLoginRegistration clientLoginRegistration;
        public ClientRegistration()
        {
            InitializeComponent();
            клієнтTableAdapter.Fill(this.fitness_DbDataSet1.Клієнт);
            editParameter = false;
        }
        public ClientRegistration(int clientID, string surname, string name, string fathname, DateTime birthdate, string gender, string phone, string email)
        {
            InitializeComponent();
            клієнтTableAdapter.Fill(this.fitness_DbDataSet1.Клієнт);
            textBox7.Text = surname;
            textBox1.Text = name;
            textBox2.Text = fathname;
            textBox3.Text = birthdate.ToString();
            switch (gender.ToUpper())
            {
                case "Чоловіча":
                    comboBox1.SelectedIndex = 0;
                    break;
                case "Жіноча":
                    comboBox1.SelectedIndex = 1;
                    break;
                default:
                    comboBox1.SelectedIndex = 0;
                    break;
            }
            //comboBox1.SelectedValue = gender;
            textBox4.Text = phone;
            textBox5.Text = email;
            this.clientID = clientID;
            editParameter = true;

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (comboBox1.SelectedIndex == 0)
            {
                gender = "Чоловіча";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                gender = "Жіноча";
            }
            if (!editParameter)
            {
                SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
                sqlConnection.Open();
                SqlCommand queryInsert = new SqlCommand("INSERT INTO Клієнт (Прізвище, [Ім'я], [По-батькові], [Дата народження], Стать, Телефон, Пошта) " + "Values(@data_0, @data_1, @data_2, @data_3, @data_4, @data_5, @data_6)", sqlConnection);
                queryInsert.Parameters.Add("@data_0", SqlDbType.NVarChar).Value = textBox7.Text;
                queryInsert.Parameters.Add("@data_1", SqlDbType.NVarChar).Value = textBox1.Text;
                queryInsert.Parameters.Add("@data_2", SqlDbType.NVarChar).Value = textBox2.Text;
                queryInsert.Parameters.Add("@data_3", SqlDbType.NVarChar).Value = textBox3.Text;
                queryInsert.Parameters.Add("@data_4", SqlDbType.NVarChar).Value = gender;
                queryInsert.Parameters.Add("@data_5", SqlDbType.NVarChar).Value = textBox4.Text;
                queryInsert.Parameters.Add("@data_6", SqlDbType.NVarChar).Value = textBox5.Text;
                queryInsert.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Реєстрація даних успішна. Надалі слід зареєструвати дані персонального акаунту.");
                clientLoginRegistration = new ClientLoginRegistration();
                clientLoginRegistration.Show();
                this.Close();


            }
            else if (editParameter)
            {
                SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
                sqlConnection.Open();
                string queryUpdate = String.Format("UPDATE Клієнт Set [Прізвище] = N'{1}', [Ім'я] = N'{2}', [По-батькові] = N'{3}', [Дата народження] = N'{4}', [Стать] = N'{5}', [Телефон] = N'{6}', [Пошта] = N'{7}' WHERE Id = '{0}' ", 
                    clientID.ToString(), textBox7.Text, textBox1.Text, textBox2.Text, textBox3.Text, gender, textBox4.Text, textBox5.Text);
                SqlCommand query = new SqlCommand(queryUpdate, sqlConnection);
                query.ExecuteNonQuery();
                sqlConnection.Close();
                this.Close();

            }
            else MessageBox.Show("Перевірте дані", "", MessageBoxButtons.OK);
        }

        private void ClientRegistration_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitness_DbDataSet1.Клієнт". При необходимости она может быть перемещена или удалена.
            //this.клієнтTableAdapter.Fill(this.fitness_DbDataSet1.Клієнт);
            /*string query = "SELECT DISTINCT Стать FROM Клієнт ORDER BY Стать DESC";
            SqlConnection sqlconn = new SqlConnection(sqlConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter(query.Substring(0), sqlconn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            this.comboBox1.DataSource = dt;
            this.comboBox1.DisplayMember = "Стать";
            this.comboBox1.ValueMember = "Стать";*/

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
            Close();
        }
    }
}
