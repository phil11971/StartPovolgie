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
    public partial class AddSparePartForm : Form
    {

        private int id;
        SparePartController sparePartController;

        public AddSparePartForm()
        {
            InitializeComponent();
            this.ActiveControl = tbName;
            sparePartController = new SparePartController();
            sparePartStatusTableAdapter.Fill(spDataSet.SparePartStatus);
        }

        public AddSparePartForm(int id, string name, string desc, int cnt, int price, string status)
        {
            InitializeComponent(name, desc, cnt, price, status);
            this.id = id;
            this.ActiveControl = tbName;
            sparePartController = new SparePartController();
            sparePartStatusTableAdapter.Fill(spDataSet.SparePartStatus);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim().Equals("") || tbPrice.Text.Trim().Equals("") || cbStatus.Text.Trim().Equals(""))
            {
                MessageBox.Show("Заполните пустые поля!", "Ошибка добваления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (id == 0)
                    {
                        SparePartStatus sparePartStatus = new SparePartStatus(Convert.ToInt32(cbStatus.SelectedValue.ToString()), cbStatus.Text.Trim());
                        SparePart sparePart = new SparePart(tbName.Text.Trim(), tbDesc.Text.Trim(), Convert.ToInt32(tbCount.Text.Trim()), Convert.ToInt32(tbPrice.Text.Trim()), sparePartStatus);
                        if (!sparePartController.Insert(sparePart))
                        {
                            MessageBox.Show("Невозможно добавить новый вид устройства!\nВид с таким названием уже существует.", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            this.Close();
                    }
                    else
                    {
                        try
                        {
                            SparePart sparePart = new SparePart(id, tbName.Text.Trim(), tbDesc.Text.Trim(), Convert.ToInt32(tbCount.Text.Trim()), Convert.ToInt32(tbPrice.Text.Trim()), new SparePartStatus(Convert.ToInt32(cbStatus.SelectedValue.ToString()), cbStatus.Text.Trim()));
                            if (!sparePartController.Update(sparePart))
                            {
                                MessageBox.Show("Невозможно изменить тип товара!\nТип товара с таким именем уже существует.", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                this.Close();

                        }
                        catch (System.Data.SqlClient.SqlException)
                        {
                            MessageBox.Show("Невозможно изменить тип товара!\nТип товара с таким именем уже существует.", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ошибка работы с базой данных!", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

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

        private void tbCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
