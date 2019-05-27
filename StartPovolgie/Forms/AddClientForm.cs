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
    public partial class AddClientForm : Form
    {
        private int id;
        ClientController clientController;

        public AddClientForm()
        {
            InitializeComponent();
            clientController = new ClientController();
            this.ActiveControl = tbLastName;
        }

        public AddClientForm(int id, string lname, string fname, string patr, string phone, string mail, string adr)
        {
            InitializeComponent(); this.Text = "Изменение информации об администраторе";
            lblAdd.Text = "Изменение информации об администраторе";
            tbLastName.Text = lname;
            tbFirstName.Text = fname;
            tbPatronymic.Text = patr;
            mtbPhone.Text = phone;
            tbMail.Text = mail;
            tbAddress.Text = adr;
            btnAdd.Text = "Изменить";
            this.id = id;
            this.ActiveControl = tbLastName;
            clientController = new ClientController();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbLastName.Text.Trim().Equals("") || tbFirstName.Text.Trim().Equals("") || mtbPhone.Text.Trim().Equals("") || tbAddress.Text.Trim().Equals(""))
            {
                MessageBox.Show("Заполните пустые поля!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (id == 0)
                    {
                        Client client = new Client(tbLastName.Text.Trim(), tbFirstName.Text.Trim(), tbPatronymic.Text.Trim(), mtbPhone.Text.Trim(), tbMail.Text.Trim(), tbAddress.Text.Trim());
                        if (!clientController.Insert(client))
                        {
                            MessageBox.Show("Невозможно добавить нового клиента!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            this.Close();
                    }
                    else
                    {
                        Client client = new Client(id, tbLastName.Text.Trim(), tbFirstName.Text.Trim(), tbPatronymic.Text.Trim(), mtbPhone.Text.Trim(), tbMail.Text.Trim(), tbAddress.Text.Trim());
                        if (!clientController.Update(client))
                        {
                            MessageBox.Show("Невозможно изменить информацию о клиенте", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            this.Close();
                    }
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Невозможно добавить нового клиента!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
