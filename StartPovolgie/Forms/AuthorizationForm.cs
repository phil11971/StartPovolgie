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
            if (tbLogin.Text.Trim().Equals("") || tbPass.Text.Trim().Equals(""))
                MessageBox.Show("Заполните пустые поля!", "Ошибка входа в систему", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

                try
                {
                    Emp = empController.GetEmployeeByAuthorization(tbLogin.Text.Trim(), tbPass.Text.Trim());
                    if (Emp == null)
                    {
                        MessageBox.Show("Неверный логин или пароль!", "Ошибка входа в систему", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbPass.Text = "Пароль";
                    }
                    else
                    {
                        DialogResult = DialogResult.OK;
                        this.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
