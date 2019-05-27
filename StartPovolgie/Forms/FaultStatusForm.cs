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
    public partial class FaultStatusForm : Form
    {
        public FaultStatusForm()
        {
            InitializeComponent();
        }

        private void FaultStatusForm_Load(object sender, EventArgs e)
        {
            faultStatusTableAdapter.Fill(spDataSet.FaultStatus);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addFaultStatusForm = new AddFaultStatusForm();
            addFaultStatusForm.Closing += AddTypeOfDevicesForm_Closing;
            addFaultStatusForm.ShowDialog();
        }

        private void AddTypeOfDevicesForm_Closing(object sender, CancelEventArgs e)
        {
            faultStatusTableAdapter.Fill(spDataSet.FaultStatus);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvTypeGood.CurrentRow.Cells[0].Value);
            string s = (string)dgvTypeGood.CurrentRow.Cells[1].Value;
            var editFaultStatusForm = new AddFaultStatusForm(id, s);
            editFaultStatusForm.Closing += AddTypeOfDevicesForm_Closing;
            editFaultStatusForm.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранный вид устройств?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvTypeGood.CurrentRow.Cells[0].Value);
                try
                {
                    new FaultStatusController().DeleteById(id);
                    faultStatusTableAdapter.Fill(spDataSet.FaultStatus);
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Невозможно удалить выбранный статус неисправности! Имеются неисправности с выбранным статусом.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
