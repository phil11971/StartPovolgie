using StartPovolgie.Controller;
using StartPovolgie.DAO;
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
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            employeeTableAdapter.Fill(spDataSet.Employee);
            masterSpecializationTableAdapter.Fill(spDataSet.MasterSpecialization);
            //todo
            masterSpecializationBindingSource.Filter = String.Format("id_master=\'{0}\'", dgvMaster.Rows[0].Cells[0].Value);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addMasterForm = new AddMasterForm();
            addMasterForm.Closing += addMasterForm_Closing;
            addMasterForm.ShowDialog();
        }

        private void addMasterForm_Closing(object sender, CancelEventArgs e)
        {
            employeeTableAdapter.Fill(spDataSet.Employee);
            masterSpecializationTableAdapter.Fill(spDataSet.MasterSpecialization);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранный вид устройств?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvMaster.CurrentRow.Cells[0].Value);
                //string name = dgvTypeGood.CurrentRow.Cells[1].Value.ToString();
                try
                {
                    //typeGoodTableAdapter.Delete(id, name);
                    new MasterController().DeleteById(id);
                    employeeTableAdapter.Fill(spDataSet.Employee);
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

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {//todo check
            if (dgvMaster.SelectedRows.Count == 1)
            {
                masterSpecializationBindingSource.Filter = String.Format("id_master=\'{0}\'", dgvMaster.CurrentRow.Cells[0].Value);
            }
        }
    }
}
