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
    public partial class ServiceForm : Form
    {
        public ServiceForm()
        {
            InitializeComponent();
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            typeGoodTableAdapter.Fill(spDataSet.TypeGood);
            serviceTableAdapter.Fill(spDataSet.Service);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addServiceForm = new AddServiceForm();
            addServiceForm.Closing += AddTypeOfDevicesForm_Closing;
            addServiceForm.ShowDialog();
        }

        private void AddTypeOfDevicesForm_Closing(object sender, CancelEventArgs e)
        {
            serviceTableAdapter.Fill(spDataSet.Service);
            typeGoodTableAdapter.Fill(spDataSet.TypeGood);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvService.CurrentRow.Cells[0].Value);
            string name = (string)dgvService.CurrentRow.Cells[1].Value;
            int price = Convert.ToInt32(dgvService.CurrentRow.Cells[2].Value);
            string type = (string)dgvService.CurrentRow.Cells[3].Value;
            var editTypeGoodForm = new AddServiceForm(id, name, price, type);
            editTypeGoodForm.Closing += AddTypeOfDevicesForm_Closing;
            editTypeGoodForm.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранный вид устройств?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvService.CurrentRow.Cells[0].Value);
                //string name = dgvTypeGood.CurrentRow.Cells[1].Value.ToString();
                try
                {
                    //typeGoodTableAdapter.Delete(id, name);
                    new ServiceController().DeleteById(id);
                    serviceTableAdapter.Fill(spDataSet.Service);
                    typeGoodTableAdapter.Fill(spDataSet.TypeGood);
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

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!tbName.Text.Equals(""))
                serviceBindingSource.Filter = String.Format("name_service = '{0}'", tbName.Text.ToString());
            else if(!cbType.Text.Equals(""))
                typeGoodBindingSource.Filter = String.Format("name_tg = '{0}'", cbType.Text.ToString());
            else if(!(tbName.Text.Equals("") && cbType.Text.Equals("")))
            {
                serviceBindingSource.Filter = String.Format("name_service = '{0}'", tbName.Text.ToString());
                typeGoodBindingSource.Filter = String.Format("name_tg = '{0}'", cbType.Text.ToString());
            }

        }

        private void btnPullOut_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            cbType.Text = "";
            serviceBindingSource.Filter = null;
            typeGoodBindingSource.Filter = null;
        }
    }
}
