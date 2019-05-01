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
            masterSpecializationTableAdapter.FillBy(spDataSet.MasterSpecialization);
            this.masterSpecializationBindingSource.Filter = String.Format("id_master=\'{0}\'", dgvEmployees.Rows[0].Cells[0].Value);

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

        }

        private void masterSpecializationBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dgvEmployees_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 1)
            {
                masterSpecializationBindingSource.Filter = String.Format("id_master=\'{0}\'", dgvEmployees.SelectedRows[0].Cells[0].Value);
            }
        }
    }
}
