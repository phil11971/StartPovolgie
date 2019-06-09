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
using System.Data.SqlClient;

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
            cbStatus.Items.Add("Принято в ремонт");
            cbStatus.Items.Add("Завершена");
            cbStatus.Text = "Принято в ремонт";
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
            var viewAcceptForRepairForm = new ViewAcceptForRepairForm(acceptForRepair, employee);
            viewAcceptForRepairForm.Closing += AddTypeOfDevicesForm_Closing;
            viewAcceptForRepairForm.ShowDialog();
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
                string sql = string.Format("SELECT * FROM RegistryAccept WHERE clientFullName LIKE \'{0}%\'", mtbFind.Text.Trim());

                using (SqlCommand cmd = new SqlCommand(sql, ConnectionDB.Connect()))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                    spDataSet.RegistryAccept.Clear();
                    dataAdapter.Fill(spDataSet.RegistryAccept);
                }

                dgvAccept.DataSource = spDataSet.RegistryAccept;
            }
            else
            {
                string sql = string.Format("SELECT * FROM RegistryAccept WHERE phone=\'{0}\'", mtbFind.Text.Trim());

                using (SqlCommand cmd = new SqlCommand(sql, ConnectionDB.Connect()))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                    spDataSet.RegistryAccept.Clear();
                    dataAdapter.Fill(spDataSet.RegistryAccept);
                }

                dgvAccept.DataSource = spDataSet.RegistryAccept;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            registryAcceptTableAdapter.Fill(spDataSet.RegistryAccept);
        }

        private void rbReceiptDate_CheckedChanged(object sender, EventArgs e)
        {
            /*if (rbReceiptDate.Checked)
            {
                string[] date = dtpS.Text.Split('-');
                string dateS = date[1] + "-" + date[0] + "-" + date[2];
                date = dtpPo.Text.Split('-');
                string datePo = date[1] + "-" + date[0] + "-" + date[2];
                string filter = String.Format("receipt_date >= '{0}' AND receipt_date <= '{1}'", dateS, datePo);
                var table = registryAcceptTableAdapter.GetData();
                DataRow[] dataRows = table.Select(filter);
                dgvAccept.DataSource = dataRows;
            }*/

            

        }

        private void rbStatus_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (rbReceiptDate.Checked)
            {
                if (dtpPo.Value.Date >= dtpS.Value.Date)
                {
                    DateTime dateS = dtpS.Value.Date;
                    DateTime datePo = dtpPo.Value.Date;
                    string strDateS = dateS.Year + "-" + dateS.Month + "-" + dateS.Day;
                    string strDatePo = datePo.Year + "-" + datePo.Month + "-" + datePo.Day;
                    string sql = string.Format("SELECT * FROM RegistryAccept WHERE receipt_date BETWEEN '{0}' AND '{1}'", strDateS, strDatePo);

                    using (SqlCommand cmd = new SqlCommand(sql, ConnectionDB.Connect()))
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                        spDataSet.RegistryAccept.Clear();
                        dataAdapter.Fill(spDataSet.RegistryAccept);
                    }

                    dgvAccept.DataSource = spDataSet.RegistryAccept;
                }
                else
                {
                    MessageBox.Show("Даты введены неверно");
                }
            }
            else if (rbStatus.Checked)
            {
                if (cbStatus.Text.Equals("Принято в ремонт"))
                {
                    registryAcceptTableAdapter.Fill(spDataSet.RegistryAccept);
                    dgvAccept.DataSource = spDataSet.RegistryAccept;
                }
                else
                {
                    string sql = "SELECT * FROM RegistryAccept WHERE issue_date IS NOT NULL";

                    using (SqlCommand cmd = new SqlCommand(sql, ConnectionDB.Connect()))
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                        spDataSet.RegistryAccept.Clear();
                        dataAdapter.Fill(spDataSet.RegistryAccept);
                    }

                    dgvAccept.DataSource = spDataSet.RegistryAccept;
                }
            }
        }
    }
}
