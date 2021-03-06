﻿using StartPovolgie.Controller;
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
    public partial class AdminForm : Form
    {
        private int IdEmp { get; set; }
        public AdminForm(int idEmp)
        {
            InitializeComponent();
            this.ActiveControl = lblEmployees;
            IdEmp = idEmp;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            employeeTableAdapter.Fill(spDataSet.Employee);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addEmployeeForm = new AddAdminForm();
            addEmployeeForm.Closing += AddEmployeeForm_Closing;
            addEmployeeForm.ShowDialog();
        }

        private void AddEmployeeForm_Closing(object sender, CancelEventArgs e)
        {
            employeeTableAdapter.Fill(spDataSet.Employee);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvAdmin.CurrentRow.Cells[0].Value);
            string lname = (string)dgvAdmin.CurrentRow.Cells[1].Value;
            string fname = (string)dgvAdmin.CurrentRow.Cells[2].Value;
            string patr = (string)dgvAdmin.CurrentRow.Cells[3].Value;
            string phone = tbPhone.Text;
            string adr = tbAddress.Text;
            string status = tbStatus.Text;
            string log = tbLogin.Text;
            string pass = tbPass.Text;

            var editEmployeeForm = new AddAdminForm(id, lname, fname, patr, phone, adr, status, log, pass);
            editEmployeeForm.Closing += AddEmployeeForm_Closing;
            editEmployeeForm.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранного администратора?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvAdmin.CurrentRow.Cells[0].Value);
                //string name = dgvTypeGood.CurrentRow.Cells[1].Value.ToString();
                try
                {
                    //typeGoodTableAdapter.Delete(id, name);
                    new EmployeeController().DeleteById(id);
                    employeeTableAdapter.Fill(spDataSet.Employee);
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Невозможно удалить выбранного администратора!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
