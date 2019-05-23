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
            employeeTableAdapter.Fill(spDataSet.Employee);
            clientTableAdapter.Fill(spDataSet.Client);
            typeGoodTableAdapter.Fill(spDataSet.TypeGood);
            goodTableAdapter.Fill(spDataSet.Good);
            faultTableAdapter.Fill(spDataSet.Fault);
            faultSparePartTableAdapter.Fill(spDataSet.FaultSparePart);

            acceptForRepairBindingSource.Filter = String.Format("id_accept=\'{0}\'", acceptForRepair.Id);
            employeeBindingSource.Filter = String.Format("id_emp=\'{0}\'", acceptForRepair.IdAdmin);
            clientBindingSource.Filter = String.Format("id_client=\'{0}\'", acceptForRepair.IdClient);

            DataRowView dataRowView = (DataRowView)goodBindingSource.Current;
            typeGoodBindingSource.Filter = String.Format("id_tg=\'{0}\'", (int)dataRowView.Row.ItemArray[0]);

            goodBindingSource.Filter = String.Format("id_g=\'{0}\'", acceptForRepair.IdGood);

            faultBindingSource.Filter = String.Format("id_accept=\'{0}\'", acceptForRepair.Id);
            faultSparePartBindingSource.Filter = String.Format("id_fault=\'{0}\'", Int32.Parse(dgvFault.Rows[0].Cells[0].Value.ToString()));

            idfaultDataGridViewTextBoxColumn.Visible = false;
            idfaultDataGridViewTextBoxColumn1.Visible = false;

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

        private void dgvFault_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFault.SelectedRows.Count == 1)
            {
                faultSparePartBindingSource.Filter = String.Format("id_fault=\'{0}\'", dgvFault.CurrentRow.Cells[0].Value);
            }
        }

        private void btnAddSparePartForCurrFault_Click(object sender, EventArgs e)
        {
            var sparePartsForFaultForm = new SparePartsForFaultForm((int)dgvFault.CurrentRow.Cells[0].Value);
            sparePartsForFaultForm.Closed += Apda_RecFormed;
            sparePartsForFaultForm.ShowDialog();
        }

        private void Apda_RecFormed(object sender, EventArgs e)
        {
            faultSparePartTableAdapter.Fill(spDataSet.FaultSparePart);
            faultSparePartBindingSource.Filter = String.Format("id_fault=\'{0}\'", dgvFault.CurrentRow.Cells[0].Value); ;
        }

        private void btnDelSparePartForCurrFault_Click(object sender, EventArgs e)
        {
            new FaultSparePartController().DeleteById( Int32.Parse(dgvFault.CurrentRow.Cells[0].Value.ToString()), Int32.Parse(dgvSparePart.CurrentRow.Cells[1].Value.ToString()));
            faultSparePartTableAdapter.Fill(spDataSet.FaultSparePart);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvFault.Rows.Count-1; i++)
            {
                if (dgvFault.Rows[i].Cells[3].Value.ToString().Equals(""))
                {
                    MessageBox.Show("Введите ст-ть устранения неисправности");
                    return;
                }
            }
            float priceFaults = 0;//ст-ть ремонта
            List<Fault> faults = new List<Fault>();
            for (int i = 0; i < dgvFault.Rows.Count-1; i++)
            {
                priceFaults += Convert.ToSingle(dgvFault.Rows[i].Cells[3].Value.ToString());
                faults.Add(new Fault(Int32.Parse(dgvFault.Rows[i].Cells[0].Value.ToString()), Convert.ToSingle(dgvFault.Rows[i].Cells[3].Value.ToString())));
            }
            tbAmountRepair.Text = priceFaults.ToString();

            string filter = "";
            filter += String.Format("id_fault={0}", Int32.Parse(dgvFault.Rows[0].Cells[0].Value.ToString()));
            for (int i = 1; i < dgvFault.Rows.Count - 1; i++)
            {
                filter += String.Format(" OR id_fault={0}", Int32.Parse(dgvFault.Rows[i].Cells[0].Value.ToString()));
            }
            var table = faultSparePartTableAdapter.GetData();
            DataRow[] dataRows = table.Select(filter);
            float priceSpareParts = 0;//ст-ть ЗП
            for (int i = 0; i < dataRows.Length; i++)
            {
                priceSpareParts += Convert.ToSingle(dataRows[i].ItemArray[3].ToString());
            }
            tbAmountSpareParts.Text = priceSpareParts.ToString();

            float total = priceFaults + priceSpareParts;
            tbTotal.Text = total.ToString();

            new FaultController().Update(faults);
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            ReturnFromRepair returnFromRepair = new ReturnFromRepair(Int32.Parse(tbIdAccept.Text), rtbDescJob.Text.Trim(), dtpIssueDate.Value.Date, float.Parse(tbAmountRepair.Text), float.Parse(tbTotal.Text));
            new ReturnFromRepairController().Insert(returnFromRepair);
        }
    }
}
