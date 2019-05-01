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
    public partial class AddEmployeeForm : Form
    {
        EmployeeController employeeController;

        public AddEmployeeForm()
        {
            InitializeComponent();
            employeeController = new EmployeeController();
            cbStatus.SelectedItem = "Работает";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbLastName.Text.Trim().Equals("") || tbFirstName.Text.Trim().Equals("") || tbPhone.Text.Trim().Equals("") || tbAddress.Text.Trim().Equals("") ||
                tbLogin.Text.Trim().Equals("") || tbPass.Text.Trim().Equals(""))
            {
                MessageBox.Show("Заполните пустые поля!", "Ошибка добваления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Administrator admin = new Administrator(tbLogin.Text.Trim(), tbPass.Text.Trim(),
                        tbLastName.Text.Trim(), tbFirstName.Text.Trim(), tbPatronymic.Text.Trim(), tbPhone.Text.Trim(), tbAddress.Text.Trim());
                        if (!employeeController.Insert(admin))
                        {
                            MessageBox.Show("Невозможно добавить новый вид устройства!\nВид с таким названием уже существует.", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            this.Close();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Невозможно добавить новый вид устройства!\nВид с таким названием уже существует.", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
