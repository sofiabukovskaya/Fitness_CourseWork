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
    public partial class AdminEditing : Form
    {
        public string sqlConnectionString = @"Data Source=DESKTOP-NG053GB;Initial Catalog=Fitness_Db;Integrated Security=True";
        private int adminId;
        private bool editParameter;
        public AdminEditing()
        {
            InitializeComponent();
            адміністраторTableAdapter.Fill(fitness_DbDataSet1.Адміністратор);
            editParameter = false;
        }
        public AdminEditing(int adminId, string surname, string name, string fathname, DateTime birthdate, string gender, string phone, string email)
        {
            InitializeComponent();
            адміністраторTableAdapter.Fill(fitness_DbDataSet1.Адміністратор);
            textBox7.Text = surname;
            textBox1.Text = name;
            textBox2.Text = fathname;
            textBox3.Text = birthdate.ToString();
            switch(gender.ToUpper())
            {
                case "Чоловіча":
                    comboBox1.SelectedIndex = 0;
                    break;
                case "Жіноча":
                    comboBox1.SelectedIndex = 1;
                    break;
                default:
                    comboBox1.SelectedIndex = 1;
                    break;
            }
            //comboBox1.SelectedValue = gender;
            textBox4.Text = phone;
            textBox5.Text = email;
            this.adminId = adminId;
            editParameter = true;

        }

        private void AdminEditing_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitness_DbDataSet1.Адміністратор". При необходимости она может быть перемещена или удалена.
            //this.адміністраторTableAdapter.Fill(this.fitness_DbDataSet1.Адміністратор);
            /*string query = "SELECT DISTINCT Стать FROM Адміністратор ORDER BY Стать DESC";
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

            if (editParameter)
            {
                SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
                sqlConnection.Open();
                string queryUpdate = String.Format("UPDATE Адміністратор Set [Прізвище] = N'{1}', [Ім'я] = N'{2}', [По-батькові] = N'{3}', [Дата народження] = N'{4}', [Стать] = N'{5}', [Телефон] = N'{6}', [Пошта] = N'{7}' WHERE Id = '{0}' ",
                    adminId.ToString(), textBox7.Text, textBox1.Text, textBox2.Text, textBox3.Text, gender, textBox4.Text, textBox5.Text);
                SqlCommand query = new SqlCommand(queryUpdate, sqlConnection);
                query.ExecuteNonQuery();
                sqlConnection.Close();
                this.Close();

            }
            else MessageBox.Show("Перевірте дані", "", MessageBoxButtons.OK);
        }
    }
}
