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
    public partial class OfficePhoneForm : Form
    {
        public OfficePhoneForm()
        {
            InitializeComponent();
        }

        private void OfficePhoneForm_Load(object sender, EventArgs e)
        {
            this.officePhoneTableAdapter.Fill(this.spDataSet.OfficePhone);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addOfficePhoneForm = new AddOfficePhoneForm();
            addOfficePhoneForm.Closing += AddTypeOfDevicesForm_Closing;
            addOfficePhoneForm.ShowDialog();
        }

        private void AddTypeOfDevicesForm_Closing(object sender, CancelEventArgs e)
        {
            officePhoneTableAdapter.Fill(spDataSet.OfficePhone);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранный вид устройств?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvOfficePhone.CurrentRow.Cells[0].Value);
                //string name = dgvTypeGood.CurrentRow.Cells[1].Value.ToString();
                try
                {
                    //typeGoodTableAdapter.Delete(id, name);
                    new OfficePhoneController().DeleteById(id);
                    officePhoneTableAdapter.Fill(spDataSet.OfficePhone);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvOfficePhone.CurrentRow.Cells[0].Value);
            string s = (string)dgvOfficePhone.CurrentRow.Cells[1].Value;
            var editOfficePhoneForm = new AddOfficePhoneForm(id, s);
            editOfficePhoneForm.Closing += AddTypeOfDevicesForm_Closing;
            editOfficePhoneForm.ShowDialog();
        }
    }
}
