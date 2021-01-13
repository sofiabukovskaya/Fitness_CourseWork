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
    public partial class AddCoach : Form
    {
        public string sqlConnectionString = @"Data Source=DESKTOP-NG053GB;Initial Catalog=Fitness_Db;Integrated Security=True";
        private int coachId;
        private bool editParameter;
        public AddCoach()
        {
            InitializeComponent();
            тренерTableAdapter.Fill(this.fitness_DbDataSet1.Тренер);
            editParameter = false;
        }
        public AddCoach(int coachId, string surname, string name, string fathname, DateTime birthdate, string gender, string phone, string email, string achievements)
        {
            InitializeComponent();
            тренерTableAdapter.Fill(this.fitness_DbDataSet1.Тренер);
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
            this.coachId = coachId;
            textBox8.Text = achievements;
            editParameter = true;

        }

        private void AddCoach_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitness_DbDataSet1.Тренер". При необходимости она может быть перемещена или удалена.
            //this.тренерTableAdapter.Fill(this.fitness_DbDataSet1.Тренер);

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
                SqlCommand queryInsert = new SqlCommand("INSERT INTO Тренер (Прізвище, [Ім'я], [По-батькові], [Дата народження], Стать, Телефон, Пошта, Досягнення) " + "Values(@data_0, @data_1, @data_2, @data_3, @data_4, @data_5, @data_6, @data_7)", sqlConnection);
                queryInsert.Parameters.Add("@data_0", SqlDbType.NVarChar).Value = textBox7.Text;
                queryInsert.Parameters.Add("@data_1", SqlDbType.NVarChar).Value = textBox1.Text;
                queryInsert.Parameters.Add("@data_2", SqlDbType.NVarChar).Value = textBox2.Text;
                queryInsert.Parameters.Add("@data_3", SqlDbType.NVarChar).Value = textBox3.Text;
                queryInsert.Parameters.Add("@data_4", SqlDbType.NVarChar).Value = gender;
                queryInsert.Parameters.Add("@data_5", SqlDbType.NVarChar).Value = textBox4.Text;
                queryInsert.Parameters.Add("@data_6", SqlDbType.NVarChar).Value = textBox5.Text;
                queryInsert.Parameters.Add("@data_7", SqlDbType.NVarChar).Value = textBox8.Text;
                queryInsert.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Додано тренера.");
                this.Close();


            }
            else if (editParameter)
            {
                SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
                sqlConnection.Open();
                string queryUpdate = String.Format("UPDATE Тренер Set [Прізвище] = N'{1}', [Ім'я] = N'{2}', [По-батькові] = N'{3}', [Дата народження] = N'{4}', [Стать] = N'{5}', [Телефон] = N'{6}', [Пошта] = N'{7}', [Досягнення] = N'{8}' WHERE Id = '{0}' ",
                    coachId.ToString(), textBox7.Text, textBox1.Text, textBox2.Text, textBox3.Text, gender, textBox4.Text, textBox5.Text, textBox8.Text);
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
