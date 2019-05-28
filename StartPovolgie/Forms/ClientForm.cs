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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            clientTableAdapter.Fill(spDataSet.Client);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addClientForm = new AddClientForm();
            addClientForm.Closing += AddTypeOfDevicesForm_Closing;
            addClientForm.ShowDialog();
        }

        private void AddTypeOfDevicesForm_Closing(object sender, CancelEventArgs e)
        {
            clientTableAdapter.Fill(spDataSet.Client);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvClient.CurrentRow.Cells[0].Value);
            string lname = (string)dgvClient.CurrentRow.Cells[1].Value;
            string fname = (string)dgvClient.CurrentRow.Cells[2].Value;
            string patr = (string)dgvClient.CurrentRow.Cells[3].Value;
            string phone = (string)dgvClient.CurrentRow.Cells[4].Value;
            string mail = (string)dgvClient.CurrentRow.Cells[5].Value;
            string adr = (string)dgvClient.CurrentRow.Cells[6].Value;

            var addClientForm = new AddClientForm(id, lname, fname, patr, phone, mail, adr);
            addClientForm.Closing += AddTypeOfDevicesForm_Closing;
            addClientForm.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранного клиента?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvClient.CurrentRow.Cells[0].Value);
                //string name = dgvTypeGood.CurrentRow.Cells[1].Value.ToString();
                try
                {
                    new ClientController().DeleteById(id);
                    clientTableAdapter.Fill(spDataSet.Client);
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Невозможно удалить выбранного клиента!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (rbLastName.Checked)
            {
                clientBindingSource.Filter = String.Format("lname=\'{0}\'", mtbFind.Text.Trim());
            }
            else
            {
                clientBindingSource.Filter = String.Format("phone=\'{0}\'", mtbFind.Text.Trim());
            }
        }

        private void btnPullOut_Click(object sender, EventArgs e)
        {
            clientBindingSource.Filter = "";
        }

        private void rbPhone_CheckedChanged(object sender, EventArgs e)
        {
            mtbFind.Mask = "8(000)000-00-00";
            mtbFind.Text = "";
        }

        private void rbLastName_CheckedChanged(object sender, EventArgs e)
        {
            mtbFind.Mask = "";
            mtbFind.Text = "";
        }
    }
}
