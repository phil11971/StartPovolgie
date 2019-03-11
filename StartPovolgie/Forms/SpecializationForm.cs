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
    public partial class SpecializationForm : Form
    {
        public SpecializationForm()
        {
            InitializeComponent();
        }

        private void SpecializationForm_Load(object sender, EventArgs e)
        {
            specializationTableAdapter.Fill(spDataSet.Specialization);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addSpecializationForm = new AddSpecializationForm();
            addSpecializationForm.Closing += AddTypeOfDevicesForm_Closing;
            addSpecializationForm.ShowDialog();
        }

        private void AddTypeOfDevicesForm_Closing(object sender, CancelEventArgs e)
        {
            specializationTableAdapter.Fill(spDataSet.Specialization);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvSpecialization.CurrentRow.Cells[0].Value);
            string s = (string)dgvSpecialization.CurrentRow.Cells[1].Value;
            var editSpecializationForm = new AddSpecializationForm(id, s);
            editSpecializationForm.Closing += AddTypeOfDevicesForm_Closing;
            editSpecializationForm.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранный вид устройств?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvSpecialization.CurrentRow.Cells[0].Value);
                //string name = dgvTypeGood.CurrentRow.Cells[1].Value.ToString();
                try
                {
                    //typeGoodTableAdapter.Delete(id, name);
                    new SpecializationController().DeleteById(id);
                    specializationTableAdapter.Fill(spDataSet.Specialization);
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
