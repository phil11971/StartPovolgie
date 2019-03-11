﻿using StartPovolgie.Model;
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

        private void состояниеРаботыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new WorkStatusForm().ShowDialog();
        }

        private void состояниеНеисправностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FaultStatusForm().ShowDialog();
        }

        private void статусЗапчастиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SparePartStatusForm().ShowDialog();
        }
    }
}
