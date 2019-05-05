using StartPovolgie.Controller;
using StartPovolgie.Model;
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
    public partial class RegistryAcceptForRepairForm : Form
    {

        Employee employee;

        public RegistryAcceptForRepairForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void RegistryAcceptForRepairForm_Load(object sender, EventArgs e)
        {
            registryAcceptTableAdapter.Fill(spDataSet.RegistryAccept);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var acceptForRepairForm = new AcceptForRepairForm(employee);
            acceptForRepairForm.Closing += AddTypeOfDevicesForm_Closing;
            acceptForRepairForm.ShowDialog();
        }

        private void AddTypeOfDevicesForm_Closing(object sender, CancelEventArgs e)
        {
            registryAcceptTableAdapter.Fill(spDataSet.RegistryAccept);
        }

        //todo
        private void btnDetail_Click(object sender, EventArgs e)
        {
            AcceptForRepair acceptForRepair = new AcceptForRepair((int)dgvAccept.CurrentRow.Cells[0].Value,
                (int)dgvAccept.CurrentRow.Cells[5].Value, (int)dgvAccept.CurrentRow.Cells[3].Value, (int)dgvAccept.CurrentRow.Cells[7].Value);
            new ViewAcceptForRepairForm(acceptForRepair).ShowDialog();
        }

        //todo
        private void btnDel_Click(object sender, EventArgs e)
        {

        }
    }
}
