﻿using System;
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
    public partial class AdminLogin : Form
    {
        public string sqlConnectionString = @"Data Source=DESKTOP-NG053GB;Initial Catalog=Fitness_Db;Integrated Security=True";
        public AdminPage adminPage;
        public AdminLogin()
        {
            InitializeComponent();
        }
        public AdminLogin(string login, string password)
        {
            InitializeComponent();
            textBox7.Text = login;
            textBox1.Text = password;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
                SqlCommand query = new SqlCommand("SELECT Логін, Пароль FROM [Акаунт адміністратора] WHERE Логін = @data_0 AND Пароль = @data_1", sqlConnection);
                SqlParameter uName = new SqlParameter("@data_0", SqlDbType.NVarChar);
                SqlParameter uPassword = new SqlParameter("@data_1", SqlDbType.VarChar);

                uName.Value = textBox7.Text;
                uPassword.Value = textBox1.Text;

                query.Parameters.Add(uName);
                query.Parameters.Add(uPassword);
                query.Connection.Open();

                SqlDataReader myReader = query.ExecuteReader(CommandBehavior.CloseConnection);

                if (myReader.Read() == true)
                {
                    MessageBox.Show("Ви успішно увійшли до акаунту " + textBox7.Text);
                    this.Hide();
                    adminPage = new AdminPage(textBox7.Text);
                    adminPage.Show();
                }
                else
                {
                    MessageBox.Show("Щось трапилось, перевірте дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBox7.Clear();
                    textBox1.Clear();
                    textBox7.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
