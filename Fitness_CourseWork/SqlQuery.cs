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
    public partial class SqlQuery : Form
    {
        public string ConnectionString = @"Data Source=DESKTOP-NG053GB;Initial Catalog=Fitness_Db;Integrated Security=True";
        public SqlQuery()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "SELECT";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection sqlConnectionString = new SqlConnection(ConnectionString);
                sqlConnectionString.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(richTextBox1.Text, sqlConnectionString);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                sqlConnectionString.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Сталася помилка: " + exception.Message);
            }
        }
    }
}
