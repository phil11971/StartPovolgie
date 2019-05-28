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

        public RegistryAcceptForRepairForm()
        {
            InitializeComponent();
            btnAccept.Visible = false;
            btnDetail.Visible = false;
            btnDel.Visible = false;
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
            new AcceptForRepairController().DeleteById((int)dgvAccept.CurrentRow.Cells[0].Value);
            registryAcceptTableAdapter.Fill(spDataSet.RegistryAccept);
        }

        private void rbLastName_CheckedChanged(object sender, EventArgs e)
        {
            mtbFind.Mask = "";
            mtbFind.Text = "";
        }

        private void rbPhone_CheckedChanged(object sender, EventArgs e)
        {
            mtbFind.Mask = "8(000)000-00-00";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (rbLastName.Checked)
            {
                registryAcceptBindingSource.Filter = String.Format("clientFullName LIKE \'{0}%\'", mtbFind.Text.Trim());
            }
            else
            {
                registryAcceptBindingSource.Filter = String.Format("phone=\'{0}\'", mtbFind.Text.Trim());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            registryAcceptBindingSource.Filter = "";
        }

        private void rbReceiptDate_CheckedChanged(object sender, EventArgs e)
        {
            /*if (rbReceiptDate.Checked)
            {
                string[] date = dtpS.Text.Split('-');
                string dateS = date[1] + "-" + date[0] + "-" + date[2];
                date = dtpPo.Text.Split('-');
                string datePo = date[1] + "-" + date[0] + "-" + date[2];
                string filter = String.Format("receipt_date >= '{0}' AND receipt_date<='{1}'", dateS, datePo);
                var table = registryAcceptTableAdapter.GetData();
                DataRow[] dataRows = table.Select(filter);
                dgvAccept.DataSource = dataRows;
            }*/
        }

        private void rbStatus_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
