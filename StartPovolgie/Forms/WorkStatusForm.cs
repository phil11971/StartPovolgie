using StartPovolgie.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartPovolgie.Forms
{
    public partial class WorkStatusForm : Form
    {
        public WorkStatusForm()
        {
            InitializeComponent();
        }

        private void WorkStatusForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spDataSet.WorkStatus". При необходимости она может быть перемещена или удалена.
            this.workStatusTableAdapter.Fill(this.spDataSet.WorkStatus);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addWorkStatusForm = new AddWorkStatusForm();
            addWorkStatusForm.Closing += AddTypeOfDevicesForm_Closing;
            addWorkStatusForm.ShowDialog();
        }

        private void AddTypeOfDevicesForm_Closing(object sender, CancelEventArgs e)
        {
            workStatusTableAdapter.Fill(spDataSet.WorkStatus);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvTypeGood.CurrentRow.Cells[0].Value);
            string s = (string)dgvTypeGood.CurrentRow.Cells[1].Value;
            var editWorkStatusForm = new AddWorkStatusForm(id, s);
            editWorkStatusForm.Closing += AddTypeOfDevicesForm_Closing;
            editWorkStatusForm.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранный вид устройств?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvTypeGood.CurrentRow.Cells[0].Value);
                //string name = dgvTypeGood.CurrentRow.Cells[1].Value.ToString();
                try
                {
                    //typeGoodTableAdapter.Delete(id, name);
                    new WorkStatusController.DeleteById(id);
                    workStatusTableAdapter.Fill(spDataSet.WorkStatus);
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Невозможно удалить выбранный вид устройств! Имеются устройства данного вида.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
