using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_CourseWork
{
    public partial class GroupSchedule : Form
    {
        public GroupSchedule()
        {
            InitializeComponent();
        }

        private void групиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.групиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fitness_DbDataSet1);

        }

        private void GroupSchedule_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitness_DbDataSet1.Розклад_групи". При необходимости она может быть перемещена или удалена.
            this.розклад_групиTableAdapter.Fill(this.fitness_DbDataSet1.Розклад_групи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitness_DbDataSet1.Групи". При необходимости она может быть перемещена или удалена.
            this.групиTableAdapter.Fill(this.fitness_DbDataSet1.Групи);

        }

        private void acceptChangeButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете внести зміни?", "Зміна даних", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                розклад_групиTableAdapter.Update(fitness_DbDataSet1);
            }
        }
    }
}
