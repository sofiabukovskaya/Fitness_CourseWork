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
    public partial class FindGroup : Form
    {
        public string sqlConnectionString = @"Data Source=DESKTOP-NG053GB;Initial Catalog=Fitness_Db;Integrated Security=True";
        public FindGroup()
        {
            InitializeComponent();
        }
  
       

        #region Automatization
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Ранок" && comboBox2.Text == "М'язи кора(прес та сідниці), спини та рук - TRX")
            {
                SqlConnection sqlconn = new SqlConnection(sqlConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Групи.[ID] AS [Номер групи], Групи.[Назва], [Розклад групи].[Вид занять], [Розклад групи].[День тижня], [Розклад групи].[Початок занять], [Розклад групи].[Кінець занять] FROM Групи, [Розклад групи] WHERE Групи.ID = [Розклад групи].ID_групи AND [Розклад групи].[Початок занять] BETWEEN '09:00' AND '11:30' AND Групи.[Кількість вільних місць] > 0 AND Групи.[Вид занять] = 'TRX';  ", sqlconn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            } 
            if (comboBox1.Text == "День" && comboBox2.Text == "М'язи кора(прес та сідниці), спини та рук - TRX")
            {
                SqlConnection sqlconn = new SqlConnection(sqlConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Групи.[ID] AS [Номер групи], Групи.[Назва], [Розклад групи].[Вид занять], [Розклад групи].[День тижня], [Розклад групи].[Початок занять], [Розклад групи].[Кінець занять] FROM Групи, [Розклад групи] WHERE Групи.ID = [Розклад групи].ID_групи AND [Розклад групи].[Початок занять] BETWEEN '12:00' AND '17:00' AND Групи.[Кількість вільних місць] > 0 AND Групи.[Вид занять] = 'TRX';  ", sqlconn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.Text == "Вечір" && comboBox2.Text == "М'язи кора(прес та сідниці), спини та рук - TRX")
            {
                SqlConnection sqlconn = new SqlConnection(sqlConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Групи.[ID] AS [Номер групи], Групи.[Назва], [Розклад групи].[Вид занять], [Розклад групи].[День тижня], [Розклад групи].[Початок занять], [Розклад групи].[Кінець занять] FROM Групи, [Розклад групи] WHERE Групи.ID = [Розклад групи].ID_групи AND [Розклад групи].[Початок занять] BETWEEN '17:05' AND '21:00' AND Групи.[Кількість вільних місць] > 0 AND Групи.[Вид занять] = 'TRX';  ", sqlconn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.Text == "Ранок" && comboBox2.Text == "Ноги - Степ-аеробіка")
            {
                SqlConnection sqlconn = new SqlConnection(sqlConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Групи.[ID] AS [Номер групи], Групи.[Назва], [Розклад групи].[Вид занять], [Розклад групи].[День тижня], [Розклад групи].[Початок занять], [Розклад групи].[Кінець занять] FROM Групи, [Розклад групи] WHERE Групи.ID = [Розклад групи].ID_групи AND [Розклад групи].[Початок занять] BETWEEN '09:00' AND '11:30' AND Групи.[Кількість вільних місць] > 0 AND (Групи.[Вид занять] = 'Стретчінг' OR Групи.[Вид занять] = 'Степ-аеробіка'); ", sqlconn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.Text == "День" && comboBox2.Text == "Ноги - Степ-аеробіка")
            {
                SqlConnection sqlconn = new SqlConnection(sqlConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Групи.[ID] AS [Номер групи], Групи.[Назва], [Розклад групи].[Вид занять], [Розклад групи].[День тижня], [Розклад групи].[Початок занять], [Розклад групи].[Кінець занять] FROM Групи, [Розклад групи] WHERE Групи.ID = [Розклад групи].ID_групи AND [Розклад групи].[Початок занять] BETWEEN '12:00' AND '17:00' AND Групи.[Кількість вільних місць] > 0 AND (Групи.[Вид занять] = 'Стретчінг' OR Групи.[Вид занять] = 'Степ-аеробіка');  ", sqlconn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.Text == "Вечір" && comboBox2.Text == "Ноги - Степ-аеробіка")
            {
                SqlConnection sqlconn = new SqlConnection(sqlConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Групи.[ID] AS [Номер групи], Групи.[Назва], [Розклад групи].[Вид занять], [Розклад групи].[День тижня], [Розклад групи].[Початок занять], [Розклад групи].[Кінець занять] FROM Групи, [Розклад групи] WHERE Групи.ID = [Розклад групи].ID_групи AND [Розклад групи].[Початок занять] BETWEEN '17:05' AND '21:00' AND Групи.[Кількість вільних місць] > 0 AND (Групи.[Вид занять] = 'Стретчінг' OR Групи.[Вид занять] = 'Степ-аеробіка');  ", sqlconn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.Text == "Ранок" && comboBox2.Text == "М'язи кора та руки - Бокс")
            {
                SqlConnection sqlconn = new SqlConnection(sqlConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Групи.[ID] AS [Номер групи], Групи.[Назва], [Розклад групи].[Вид занять], [Розклад групи].[День тижня], [Розклад групи].[Початок занять], [Розклад групи].[Кінець занять] FROM Групи, [Розклад групи] WHERE Групи.ID = [Розклад групи].ID_групи AND [Розклад групи].[Початок занять] BETWEEN '09:00' AND '11:30' AND Групи.[Кількість вільних місць] > 0 AND Групи.[Вид занять] = 'Бокс';  ", sqlconn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.Text == "День" && comboBox2.Text == "М'язи кора та руки - Бокс")
            {
                SqlConnection sqlconn = new SqlConnection(sqlConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Групи.[ID] AS [Номер групи], Групи.[Назва], [Розклад групи].[Вид занять], [Розклад групи].[День тижня], [Розклад групи].[Початок занять], [Розклад групи].[Кінець занять] FROM Групи, [Розклад групи] WHERE Групи.ID = [Розклад групи].ID_групи AND [Розклад групи].[Початок занять] BETWEEN '12:00' AND '17:00' AND Групи.[Кількість вільних місць] > 0 AND Групи.[Вид занять] = 'Бокс';  ", sqlconn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.Text == "Вечір" && comboBox2.Text == "М'язи кора та руки - Бокс")
            {
                SqlConnection sqlconn = new SqlConnection(sqlConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Групи.[ID] AS [Номер групи], Групи.[Назва], [Розклад групи].[Вид занять], [Розклад групи].[День тижня], [Розклад групи].[Початок занять], [Розклад групи].[Кінець занять] FROM Групи, [Розклад групи] WHERE Групи.ID = [Розклад групи].ID_групи AND [Розклад групи].[Початок занять] BETWEEN '17:05' AND '21:00' AND Групи.[Кількість вільних місць] > 0 AND Групи.[Вид занять] = 'Бокс';  ", sqlconn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.Text == "Ранок" && comboBox2.Text == "М'язи усього тіла - Кросфіт/Аеробіка")
            {
                SqlConnection sqlconn = new SqlConnection(sqlConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Групи.[ID] AS [Номер групи], Групи.[Назва], [Розклад групи].[Вид занять], [Розклад групи].[День тижня], [Розклад групи].[Початок занять], [Розклад групи].[Кінець занять] FROM Групи, [Розклад групи] WHERE Групи.ID = [Розклад групи].ID_групи AND [Розклад групи].[Початок занять] BETWEEN '09:00' AND '11:30' AND Групи.[Кількість вільних місць] > 0 AND (Групи.[Вид занять] = 'Аеробіка' OR Групи.[Вид занять] = 'Крос-фіт');  ", sqlconn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.Text == "День" && comboBox2.Text == "М'язи усього тіла - Кросфіт/Аеробіка")
            {
                SqlConnection sqlconn = new SqlConnection(sqlConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Групи.[ID] AS [Номер групи], Групи.[Назва], [Розклад групи].[Вид занять], [Розклад групи].[День тижня], [Розклад групи].[Початок занять], [Розклад групи].[Кінець занять] FROM Групи, [Розклад групи] WHERE Групи.ID = [Розклад групи].ID_групи AND [Розклад групи].[Початок занять] BETWEEN '12:00' AND '17:00' AND Групи.[Кількість вільних місць] > 0 AND (Групи.[Вид занять] = 'Аеробіка' OR Групи.[Вид занять] = 'Крос-фіт');  ", sqlconn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.Text == "Вечір" && comboBox2.Text == "М'язи усього тіла - Кросфіт/Аеробіка")
            {
                SqlConnection sqlconn = new SqlConnection(sqlConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Групи.[ID] AS [Номер групи], Групи.[Назва], [Розклад групи].[Вид занять], [Розклад групи].[День тижня], [Розклад групи].[Початок занять], [Розклад групи].[Кінець занять] FROM Групи, [Розклад групи] WHERE Групи.ID = [Розклад групи].ID_групи AND [Розклад групи].[Початок занять] BETWEEN '17:05' AND '21:00' AND Групи.[Кількість вільних місць] > 0 AND (Групи.[Вид занять] = 'Аеробіка' OR Групи.[Вид занять] = 'Крос-фіт');  ", sqlconn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.Text == "Ранок" && comboBox2.Text == "Прес та сідниці - Пілатес")
            {
                SqlConnection sqlconn = new SqlConnection(sqlConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Групи.[ID] AS [Номер групи], Групи.[Назва], [Розклад групи].[Вид занять], [Розклад групи].[День тижня], [Розклад групи].[Початок занять], [Розклад групи].[Кінець занять] FROM Групи, [Розклад групи] WHERE Групи.ID = [Розклад групи].ID_групи AND [Розклад групи].[Початок занять] BETWEEN '09:00' AND '11:30' AND Групи.[Кількість вільних місць] > 0 AND Групи.[Вид занять] = 'Пілатес';  ", sqlconn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.Text == "День" && comboBox2.Text == "Прес та сідниці - Пілатес")
            {
                SqlConnection sqlconn = new SqlConnection(sqlConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Групи.[ID] AS [Номер групи], Групи.[Назва], [Розклад групи].[Вид занять], [Розклад групи].[День тижня], [Розклад групи].[Початок занять], [Розклад групи].[Кінець занять] FROM Групи, [Розклад групи] WHERE Групи.ID = [Розклад групи].ID_групи AND [Розклад групи].[Початок занять] BETWEEN '12:00' AND '17:00' AND Групи.[Кількість вільних місць] > 0 AND Групи.[Вид занять] = 'Пілатес';  ", sqlconn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.Text == "Вечір" && comboBox2.Text == "Прес та сідниці - Пілатес")
            {
                SqlConnection sqlconn = new SqlConnection(sqlConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Групи.[ID] AS [Номер групи], Групи.[Назва], [Розклад групи].[Вид занять], [Розклад групи].[День тижня], [Розклад групи].[Початок занять], [Розклад групи].[Кінець занять] FROM Групи, [Розклад групи] WHERE Групи.ID = [Розклад групи].ID_групи AND [Розклад групи].[Початок занять] BETWEEN '17:05' AND '21:00' AND Групи.[Кількість вільних місць] > 0 AND Групи.[Вид занять] = 'Пілатес';  ", sqlconn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }
        #endregion


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FindGroup_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string Group = dataGridView1.SelectedCells[2].Value.ToString();
            textBox1.Text = Group;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(sqlConnectionString);
            sqlconn.Open();
            SqlCommand query = new SqlCommand(" INSERT INTO [Групові заняття]([ID_групи])" + "VALUES(@data_0)", sqlconn);
            query.Parameters.Add("@data_0", SqlDbType.NVarChar).Value = dataGridView1.SelectedCells[0].Value.ToString();
            query.ExecuteNonQuery();
            sqlconn.Close();
            MessageBox.Show("Ви вибрали вид занять: " + textBox1.Text);
            textBox1.Clear();
        }
    }
}
