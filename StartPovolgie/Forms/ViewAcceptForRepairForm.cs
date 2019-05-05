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
    public partial class ViewAcceptForRepairForm : Form
    {
        AcceptForRepair acceptForRepair;

        public ViewAcceptForRepairForm(AcceptForRepair acceptForRepair)
        {
            InitializeComponent();
            this.acceptForRepair = acceptForRepair;
        }

        private void ViewAcceptForRepairForm_Load(object sender, EventArgs e)
        {
            acceptForRepairTableAdapter.Fill(spDataSet.AcceptForRepair);
            clientTableAdapter.Fill(spDataSet.Client);
            typeGoodTableAdapter.Fill(spDataSet.TypeGood);
            goodTableAdapter.Fill(spDataSet.Good);
            faultTableAdapter.Fill(spDataSet.Fault);
            faultSparePartTableAdapter.Fill(spDataSet.FaultSparePart);
            employeeTableAdapter.Fill(spDataSet.Employee);

            acceptForRepairBindingSource.Filter = String.Format("id_accept=\'{0}\'", acceptForRepair.Id);
            employeeBindingSource.Filter = String.Format("id_emp=\'{0}\'", acceptForRepair.IdAdmin);
            clientBindingSource.Filter = String.Format("id_client=\'{0}\'", acceptForRepair.IdClient);
            goodBindingSource.Filter = String.Format("id_g=\'{0}\'", acceptForRepair.IdGood);

            DataRowView dataRowView = (DataRowView)goodBindingSource.Current;

            typeGoodBindingSource.Filter = String.Format("id_tg=\'{0}\'", (int)dataRowView.Row.ItemArray[0]);

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rtbComment_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
