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
    public partial class InfoUserForm : Form
    {

        Employee employee;
        private EmployeeController employeeController;

        public InfoUserForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            this.ActiveControl = label1;
            tbLogin.Text = employee.Login;
            tbPass.Text = employee.Password;
            tbLName.Text = employee.LastName;
            tbFName.Text = employee.FirstName;
            tbPatr.Text = employee.Patronymic;
            employeeController = new EmployeeController();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text.Equals("Логин") || tbLogin.Text.Trim().Equals("") || tbPass.Text.Equals("Пароль") || tbPass.Text.Trim().Equals(""))
            {
                MessageBox.Show("Заполните пустые поля!", "Ошибка изменения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                    if (!tbLogin.Text.Equals(employee.Login) || !tbPass.Text.Equals(employee.Password))
                    {
                        bool isOk = employeeController.SetLoginAndPasswordById(employee.Id, tbLogin.Text.Trim(), tbPass.Text.Trim());
                        if (isOk)
                        {
                            MessageBox.Show("Изменения успешно сохранены!", "Изменение данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            employee.Login = tbLogin.Text.Trim().ToLower();
                            employee.Password = tbPass.Text.Trim();
                            this.Close();
                        }
                        else
                        {
                            tbLogin.Text = employee.Login;
                            tbPass.Text = employee.Password;
                            MessageBox.Show("Не удалось изменить данные!", "Изменение данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
            }
        }
    }
}
