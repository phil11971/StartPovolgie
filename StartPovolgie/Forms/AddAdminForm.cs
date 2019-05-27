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
    public partial class AddAdminForm : Form
    {

        private int id;
        EmployeeController employeeController;

        public AddAdminForm()
        {
            InitializeComponent();
            employeeController = new EmployeeController();
            cbStatus.SelectedItem = "Работает";
        }

        public AddAdminForm(int id, string lname, string fname, string patr, string phone, string status, string adr, string log, string pass)
        {
            InitializeComponent();
            this.Text = "Изменение информации об администраторе";
            lblAdd.Text = "Изменение информации об администраторе";
            tbLastName.Text = lname;
            tbFirstName.Text = fname;
            tbPatronymic.Text = patr;
            mtbPhone.Text = phone;
            cbStatus.Text = status;
            tbAddress.Text = adr;
            tbLogin.Text = log;
            tbPass.Text = pass;
            btnAdd.Text = "Изменить";
            this.id = id;
            this.ActiveControl = tbLastName;
            employeeController = new EmployeeController();
            cbStatus.SelectedItem = "Работает";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbLastName.Text.Trim().Equals("") || tbFirstName.Text.Trim().Equals("") || mtbPhone.Text.Trim().Equals("") || tbAddress.Text.Trim().Equals("") ||
                tbLogin.Text.Trim().Equals("") || tbPass.Text.Trim().Equals(""))
            {
                MessageBox.Show("Заполните пустые поля!", "Ошибка добваления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (id == 0)
                    {
                        Administrator admin = new Administrator(tbLogin.Text.Trim(), tbPass.Text.Trim(),
                            tbLastName.Text.Trim(), tbFirstName.Text.Trim(), tbPatronymic.Text.Trim(), mtbPhone.Text.Trim(), tbAddress.Text.Trim());
                        if (!employeeController.Insert(admin))
                        {
                            MessageBox.Show("Невозможно добавить нового администратора!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            this.Close();
                    }
                    else
                    {
                        try
                        {
                            Administrator admin = new Administrator(id, tbLogin.Text.Trim(), tbPass.Text.Trim(),
                            tbLastName.Text.Trim(), tbFirstName.Text.Trim(), tbPatronymic.Text.Trim(), mtbPhone.Text.Trim(), tbAddress.Text.Trim());

                            if (!employeeController.Update(admin))
                            {
                                MessageBox.Show("Невозможно изменить данные администратора!", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                this.Close();

                        }
                        catch (System.Data.SqlClient.SqlException)
                        {
                            MessageBox.Show("Невозможно изменить данные администратора!", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ошибка работы с базой данных!", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Невозможно добавить нового администратора!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
