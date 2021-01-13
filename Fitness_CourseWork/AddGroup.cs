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
    public partial class AddGroup : Form
    {
        public string sqlConnectionString = @"Data Source=DESKTOP-NG053GB;Initial Catalog=Fitness_Db;Integrated Security=True";
        private int groupId;
        private bool editParameter;
        public AddGroup()
        {
            InitializeComponent();
        }
        public AddGroup(int groupId, string name, string type, int teacherId, int countPlaces)
        {
            InitializeComponent();
            тренерTableAdapter.Fill(this.fitness_DbDataSet1.Тренер);
            textBox3.Text = name;
            comboBox1.SelectedValue = type;
            comboBox2.SelectedValue = teacherId;
            textBox5.Text = countPlaces.ToString();
            this.groupId = groupId;
            editParameter = true;
        }

        private void AddGroup_Load(object sender, EventArgs e)
        {
            this.тренерTableAdapter.Fill(this.fitness_DbDataSet1.Тренер);

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!editParameter)
            {
                SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
                sqlConnection.Open();
                SqlCommand queryInsert = new SqlCommand("INSERT INTO Групи (Назва, [Вид занять], [ID_тренера], [Кількість вільних місць]) " + "Values(@data_0, @data_1, @data_2, @data_3)", sqlConnection);
                queryInsert.Parameters.Add("@data_0", SqlDbType.NVarChar).Value = textBox3.Text;
                queryInsert.Parameters.Add("@data_1", SqlDbType.NVarChar).Value = comboBox1.Text;
                queryInsert.Parameters.Add("@data_2", SqlDbType.NVarChar).Value = comboBox2.Text;
                queryInsert.Parameters.Add("@data_3", SqlDbType.NVarChar).Value = textBox5.Text;
                queryInsert.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Додано групу.");
                this.Close();

            }
            else if (editParameter)
            {
                SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
                sqlConnection.Open();
                string queryUpdate = String.Format("UPDATE Групи Set [Назва] = N'{1}', [Вид занять] = N'{2}', [ID_тренера] = N'{3}', [Кількість вільних місць] = N'{4}' WHERE Id = '{0}' ",
                    groupId.ToString(),  textBox3.Text, comboBox1.Text, comboBox2.Text, textBox5.Text);
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
