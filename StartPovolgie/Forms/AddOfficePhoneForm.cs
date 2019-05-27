using StartPovolgie.Model;
using StartPovolgie.Controller;
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
    public partial class AddOfficePhoneForm : Form
    {

        private int id;
        OfficePhoneController officePhoneController;

        public AddOfficePhoneForm()
        {
            InitializeComponent();
            this.ActiveControl = mtbPhone;
            officePhoneController = new OfficePhoneController();
        }

        public AddOfficePhoneForm(int id, string numberOfficePhone)
        {
            InitializeComponent();
            this.Text = "Изменение номера телефона";
            gbPhone.Text = "Изменение номера телефона";
            mtbPhone.Text = numberOfficePhone;
            btnAdd.Text = "Изменить";
            this.id = id;
            this.ActiveControl = mtbPhone;
            officePhoneController = new OfficePhoneController();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (mtbPhone.Text.Trim().Equals(""))
            {
                MessageBox.Show("Заполните пустые поля!", "Ошибка добваления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (id == 0)
                    {
                        OfficePhone officePhone = new OfficePhone(mtbPhone.Text.Trim());
                        if (!officePhoneController.Insert(officePhone))
                        {
                            MessageBox.Show("Невозможно добавить новый номер телефона!\nТакой номер телефона уже существует.", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            this.Close();
                    }
                    else
                    {
                        try
                        {
                            OfficePhone officePhone = new OfficePhone(id, mtbPhone.Text.Trim());
                            if (!officePhoneController.Update(officePhone))
                            {
                                MessageBox.Show("Невозможно изменить номер телефона!\nТакой номер телефона уже существует.", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                this.Close();

                        }
                        catch (System.Data.SqlClient.SqlException)
                        {
                            MessageBox.Show("Невозможно изменить номер телефона!\nТакой номер телефона уже существует.", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ошибка работы с базой данных!", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Невозможно добавить новый номер телефона!\nТакой номер телефона уже существует.", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
