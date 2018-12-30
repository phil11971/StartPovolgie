using StartPovolgie.Controller;
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
    public partial class AuthorizationForm : Form
    {
        private EmployeeController empController;
        public Employee Emp { get; private set; }
        public AuthorizationForm()
        {
            InitializeComponent();
            this.ActiveControl = tbLogin;
            empController = new EmployeeController();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            bool isEmpty = false;
            if (tbLogin.Text.Equals("Логин") || tbLogin.Text.Trim().Equals(""))
            {
                isEmpty = true;
                tbPass.Text = "Пароль";
            }
            if (tbPass.Text.Equals("Пароль") || tbPass.Text.Trim().Equals(""))
            {
                isEmpty = true;
            }
            if (isEmpty)
            {
                MessageBox.Show("Заполните пустые поля!", "Ошибка входа в систему", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isEmpty = false;
                tbPass.Text = "Пароль";
                tbPass.ForeColor = Color.Gray;
                tbPass.UseSystemPasswordChar = false;
            }
            else
            {
                if (tbLogin.Text.Trim().Equals("_"))
                {
                    MessageBox.Show("Неверный логин!", "Ошибка входа в систему", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbPass.Text = "Пароль";
                    tbPass.ForeColor = Color.Gray;
                    tbPass.UseSystemPasswordChar = false;
                }
                else
                {
                    try
                    {
                        Emp = empController.GetEmployeeByAuthorization(tbLogin.Text.Trim(), tbPass.Text.Trim());
                        if (Emp == null)
                        {
                            MessageBox.Show("Неверный логин или пароль!", "Ошибка входа в систему", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbPass.Text = "Пароль";
                            tbPass.ForeColor = Color.Gray;
                            tbPass.UseSystemPasswordChar = false;
                        }
                        else
                        {
                            DialogResult = DialogResult.OK;
                            this.Dispose();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка работы с базой данных!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
