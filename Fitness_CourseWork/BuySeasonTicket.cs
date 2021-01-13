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
    public partial class BuySeasonTicket : Form
    {
        public string sqlConnectionString = @"Data Source=DESKTOP-NG053GB;Initial Catalog=Fitness_Db;Integrated Security=True";
        public string loglog = "";
        private bool editParameter;
        public int clientID;
        public BuySeasonTicket()
        {
            InitializeComponent();
            editParameter = false;
        }
        public BuySeasonTicket(string log)
        {
            InitializeComponent();
            loglog = log;
            editParameter = true;
        }
        public BuySeasonTicket(int clientID)
        {
            InitializeComponent();
            this.clientID = clientID;
            editParameter = true;
        }

        private void BuySeasonTicket_Load(object sender, EventArgs e)
        {
            string query = "SELECT Id FROM Абонемент";
            SqlConnection sqlconn = new SqlConnection(sqlConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter(query.Substring(0), sqlconn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            this.comboBox1.DataSource = dt;
            this.comboBox1.DisplayMember = "Id";
            this.comboBox1.ValueMember = "Id";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!editParameter)
            {
                //string clientId = "SELECT ID_клієнта FROM [Акаунт клієнта] WHERE [Акаунт клієнта].Логін = '" + loglog + "'";
                //int idClient = Int32.Parse(clientId);
                SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
                sqlConnection.Open();
                SqlCommand queryInsert = new SqlCommand("INSERT INTO Купівля (ID_абонемента, [Початок дії]) " + "Values(@data_0, @data_2)", sqlConnection);
                queryInsert.Parameters.Add("@data_0", SqlDbType.Int).Value = comboBox1.SelectedValue;
                queryInsert.Parameters.Add("@data_2", SqlDbType.DateTime).Value = DateTime.Now;
                queryInsert.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Абонемент успішно придбано");
                this.Close();


            }
            else if (editParameter)
            {
                //string clientId = "SELECT Id FROM Клієнт, [Акаунт клієнта] WHERE [Клієнт].Id = [Акаунт клієнта].ID_клієнта AND [Акаунт клієнта].Логін = '" + loglog + "'";
                //int idClient = Int32.Parse(clientId);
                SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
                sqlConnection.Open();
                string queryUpdate = String.Format("UPDATE Купівля Set [ID_клієнта] = N'{1}', [Початок дії] = N'{2}' WHERE ID_абонемента = '{0}' ",
                    comboBox1.SelectedValue, clientID.ToString(), DateTime.Now);
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
