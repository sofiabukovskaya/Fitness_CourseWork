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
    public partial class AdminLoginEditing : Form
    {
        public string sqlConnectionString = @"Data Source=DESKTOP-NG053GB;Initial Catalog=Fitness_Db;Integrated Security=True";
        private int adminId;
        private bool editParameter;
        public AdminLoginEditing()
        {
            InitializeComponent();
            editParameter = false;
        }
        public AdminLoginEditing(int adminId, string login, string password, string word)
        {
            InitializeComponent();
            textBox7.Text = login;
            textBox1.Text = password;
            textBox2.Text = word;
            this.adminId = adminId;
            editParameter = true;
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
            if (editParameter)
            {
                SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
                sqlConnection.Open();
                string queryUpdate = String.Format("UPDATE [Акаунт адміністратора] Set [Логін] = N'{1}', [Пароль] = N'{2}', [Перевірочне слово] = N'{3}' WHERE Id_адміна = '{0}' ",
                    adminId.ToString(), textBox7.Text, textBox1.Text, textBox2.Text);
                SqlCommand query = new SqlCommand(queryUpdate, sqlConnection);
                query.ExecuteNonQuery();
                sqlConnection.Close();
                this.Close();
            }
            else MessageBox.Show("Перевірте дані", "", MessageBoxButtons.OK);
        }
    }
}
