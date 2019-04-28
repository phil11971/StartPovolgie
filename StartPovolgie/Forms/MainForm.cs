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
        public Employee Emp { get; private set; }
        public MainForm(Employee emp)
        {
            InitializeComponent();
            this.ActiveControl = lblEmp;
            Emp = emp;
            lblEmp.Text = Emp.LastName + " " + Emp.FirstName;
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
            new EmployeeForm(Emp.Id).ShowDialog();
            //new AddEmployeeForm("Администратор").ShowDialog();
        }

        private void мастерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MasterForm().ShowDialog();
        }
    }
}
