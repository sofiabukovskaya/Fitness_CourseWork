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
    public partial class GroupFilter : Form
    {
        public string sqlConnectionString = @"Data Source=DESKTOP-NG053GB;Initial Catalog=Fitness_Db;Integrated Security=True";
        private ClientPage clientPage;
        private AdminPage adminPage;
        public event Action<object, EventArgs> IsButton;
        public GroupFilter()
        {
            InitializeComponent();
        }
        public GroupFilter(ClientPage clientPage)
        {
            InitializeComponent();
            this.clientPage = clientPage;
        }

        private void GroupFilter_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitness_DbDataSet1.Групи". При необходимости она может быть перемещена или удалена.
            this.групиTableAdapter.Fill(this.fitness_DbDataSet1.Групи);
            string query = "SELECT DISTINCT [Вид занять] FROM Групи";
            SqlConnection sqlconn = new SqlConnection(sqlConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter(query.Substring(0), sqlconn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            this.comboBox1.DataSource = dt;
            this.comboBox1.DisplayMember = "Вид занять";
            this.comboBox1.ValueMember = "Вид занять";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT *  FROM Групи WHERE ";
                if (comboBox1.Text != "")
                {
                    query += " [Вид занять] LIKE N'" + comboBox1.Text + "' AND ";
                }
                SqlConnection sqlconn = new SqlConnection(sqlConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter(query.Substring(0, query.Length - 4), sqlconn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                clientPage.dataGridView1.DataSource = dt;
                IsButton.Invoke(this, EventArgs.Empty);
                Close();

            }
            catch (ArgumentOutOfRangeException t)
            {
                Console.WriteLine(t);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
