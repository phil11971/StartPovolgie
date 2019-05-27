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
    public partial class AddServiceForm : Form
    {
        private int id;
        ServiceController serviceController;

        public AddServiceForm()
        {
            InitializeComponent();
            this.ActiveControl = tbName;
            serviceController = new ServiceController();
            typeGoodTableAdapter.Fill(spDataSet.TypeGood);
        }

        public AddServiceForm(int id, string name, string price, string type)
        {
            InitializeComponent();
            lblAdd.Text = "Изменение информации об услуге";
            tbName.Text = name;
            nudPrice.Text = price;
            cbType.Text = type;
            btnAdd.Text = "Изменить";
            this.id = id;
            this.ActiveControl = tbName;
            serviceController = new ServiceController();
            typeGoodTableAdapter.Fill(spDataSet.TypeGood);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim().Equals("") || nudPrice.Text.Trim().Equals("") || cbType.Text.Trim().Equals(""))
            {
                MessageBox.Show("Заполните пустые поля!", "Ошибка добваления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (id == 0)
                    {
                        TypeGood typeGood = new TypeGood(Convert.ToInt32(cbType.SelectedValue.ToString()), cbType.Text.Trim());
                        Service service = new Service(tbName.Text.Trim(), Convert.ToSingle(nudPrice.Text.Trim()), typeGood);
                        if (!serviceController.Insert(service))
                        {
                            MessageBox.Show("Невозможно добавить новую услугу!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            this.Close();
                    }
                    else
                    {
                        try
                        {
                            Service service = new Service(id, tbName.Text.Trim(), Convert.ToSingle(nudPrice.Text.Trim()), new TypeGood(Convert.ToInt32(cbType.SelectedValue.ToString()), cbType.Text.Trim()));
                            if (!serviceController.Update(service))
                            {
                                MessageBox.Show("Невозможно изменить услугу!", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                this.Close();

                        }
                        catch (System.Data.SqlClient.SqlException)
                        {
                            MessageBox.Show("Невозможно изменить услугу", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ошибка работы с базой данных!", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Невозможно добавить новую услугу", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
