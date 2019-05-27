using StartPovolgie.Model;
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
    public partial class MainForm : Form
    {
        public Employee employee { get; private set; }
        public MainForm(Employee employee)
        {
            InitializeComponent();
            this.ActiveControl = lblEmp;
            this.employee = employee;
            lblEmp.Text = employee.LastName + " " + employee.FirstName;
        }

        private void типыТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TypeGoodForm().ShowDialog();
        }

        private void отчётыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportsForm rf = new ReportsForm();
            rf.Show();
        }

        private void офисныеТелефоныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OfficePhoneForm().ShowDialog();
        }

        private void работыУслугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ServiceForm().ShowDialog();
        }

        private void специализацииМастеровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SpecializationForm().ShowDialog();
        }

        private void состояниеНеисправностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FaultStatusForm().ShowDialog();
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GoodForm().ShowDialog();
        }

        private void запчастиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SparePartForm().ShowDialog();
        }

        private void справочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void администраторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AdminForm(employee.Id).ShowDialog();
        }

        private void мастерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MasterForm().ShowDialog();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ClientForm().ShowDialog();
        }

        private void новаяЗаявкаНаРемонтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AcceptForRepairForm(employee).ShowDialog();
        }

        private void реестрЗаявокНаРемонтToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new RegistryAcceptForRepairForm(employee).ShowDialog();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            new AcceptForRepairForm(employee).ShowDialog();
        }

        private void btnRegistry_Click(object sender, EventArgs e)
        {
            new RegistryAcceptForRepairForm(employee).ShowDialog();
        }
    }
}
