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
    public partial class ClientLoginRegistration : Form
    {
        public string sqlConnectionString = @"Data Source=DESKTOP-NG053GB;Initial Catalog=Fitness_Db;Integrated Security=True";
        private int clientID;
        private bool editParameter;
        public ClientLoginRegistration()
        {
            InitializeComponent();
            editParameter = false;
        }
        public ClientLoginRegistration(int clientID, string login, string password, string word)
        {
            InitializeComponent();
            textBox7.Text = login;
            textBox1.Text = password;
            textBox2.Text = word;
            this.clientID = clientID;
            editParameter = true;
        }
      
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if(!editParameter)
            {
                SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
                sqlConnection.Open();
                SqlCommand queryId = new SqlCommand("SELECT Id FROM Клієнт WHERE Id=(SELECT MAX(Id) FROM Клієнт)", sqlConnection);
                int userId = (Int32)queryId.ExecuteScalar();
                SqlCommand queryInsert = new SqlCommand("INSERT INTO [Акаунт клієнта] (ID_клієнта, Логін, Пароль, [Перевірочне слово]) " + "Values(@data_0, @data_1, @data_2, @data_3)", sqlConnection);
                queryInsert.Parameters.Add("@data_0", SqlDbType.Int).Value = userId;
                queryInsert.Parameters.Add("@data_1", SqlDbType.NVarChar).Value = textBox7.Text;
                queryInsert.Parameters.Add("@data_2", SqlDbType.NVarChar).Value = textBox1.Text;
                queryInsert.Parameters.Add("@data_3", SqlDbType.NVarChar).Value = textBox2.Text;
                queryInsert.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Реєстрація успішна.");
                this.Close();
            } else if(editParameter)
            {
                SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
                sqlConnection.Open();
                string queryUpdate = String.Format("UPDATE [Акаунт клієнта] Set [Логін] = N'{1}', [Пароль] = N'{2}', [Перевірочне слово] = N'{3}' WHERE ID_клієнта = '{0}' ",
                    clientID.ToString(), textBox7.Text, textBox1.Text, textBox2.Text);
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
            Close();
        }
    }
}
