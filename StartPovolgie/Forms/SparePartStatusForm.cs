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
    public partial class SparePartStatusForm : Form
    {
        public SparePartStatusForm()
        {
            InitializeComponent();
        }

        private void SparePartStatusForm_Load(object sender, EventArgs e)
        {
            sparePartStatusTableAdapter.Fill(spDataSet.SparePartStatus);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addSparePartStatusForm = new AddSparePartStatusForm();
            addSparePartStatusForm.Closing += AddTypeOfDevicesForm_Closing;
            addSparePartStatusForm.ShowDialog();
        }

        private void AddTypeOfDevicesForm_Closing(object sender, CancelEventArgs e)
        {
            sparePartStatusTableAdapter.Fill(spDataSet.SparePartStatus);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvTypeGood.CurrentRow.Cells[0].Value);
            string s = (string)dgvTypeGood.CurrentRow.Cells[1].Value;
            var editSparePartStatusForm = new AddSparePartStatusForm(id, s);
            editSparePartStatusForm.Closing += AddTypeOfDevicesForm_Closing;
            editSparePartStatusForm.ShowDialog();
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
                    new SparePartStatusController().DeleteById(id);
                    sparePartStatusTableAdapter.Fill(spDataSet.SparePartStatus);
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
