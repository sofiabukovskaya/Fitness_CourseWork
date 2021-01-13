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
    public partial class CoachScheduleFilter : Form
    {
        public string sqlConnectionString = @"Data Source=DESKTOP-NG053GB;Initial Catalog=Fitness_Db;Integrated Security=True";
        private ClientPage clientPage;
        public event Action<object, EventArgs> IsButton;
        public CoachScheduleFilter()
        {
            InitializeComponent();
        }
        public CoachScheduleFilter(ClientPage clientPage)
        {
            InitializeComponent();
            this.clientPage = clientPage;
        }

        private void CoachScheduleFilter_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitness_DbDataSet1.Розклад_тренера". При необходимости она может быть перемещена или удалена.
            this.розклад_тренераTableAdapter.Fill(this.fitness_DbDataSet1.Розклад_тренера);
            string query = "SELECT DISTINCT [День тижня] FROM [Розклад тренера]";
            SqlConnection sqlconn = new SqlConnection(sqlConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter(query.Substring(0), sqlconn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            this.comboBox1.DataSource = dt;
            this.comboBox1.DisplayMember = "День тижня";
            this.comboBox1.ValueMember = "День тижня";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT *  FROM [Розклад тренера] WHERE ";
                int v = 0;
                if (comboBox1.Text != "")
                {
                    query += " [День тижня] LIKE N'" + comboBox1.Text + "' AND ";
                }

                if (Int32.TryParse(textBox1.Text, out v))
                {
                    query += " [ID_тренера] >=" + textBox1.Text + " AND ";
                }

                if (Int32.TryParse(textBox2.Text, out v))
                    query += " [ID_тренера] <=" + textBox2.Text + " AND ";
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
    }
}
