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
    public partial class AddGoodForm : Form
    {

        private int id;
        GoodController goodController;

        public AddGoodForm()
        {
            InitializeComponent();
            this.ActiveControl = tbName;
            goodController = new GoodController();
            typeGoodTableAdapter.Fill(spDataSet.TypeGood);
        }

        public AddGoodForm(int id, string name, string type)
        {
            InitializeComponent();
            this.Text = "Изменение товара";
            lblAdd.Text = "Изменение товара";
            gbGood.Text = "Информация о товаре";
            tbName.Text = name;
            cbType.Text = type;
            btnAdd.Text = "Изменить";
            this.id = id;
            this.ActiveControl = tbName;
            goodController = new GoodController();
            typeGoodTableAdapter.Fill(spDataSet.TypeGood);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim().Equals("") || cbType.Text.Trim().Equals(""))
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
                        Good good = new Good(tbName.Text.Trim(), typeGood);
                        if (!goodController.Insert(good))
                        {
                            MessageBox.Show("Невозможно добавить новый товар!\nТовар с таким названием уже существует.", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            this.Close();
                    }
                    else
                    {
                        try
                        {
                            Good good = new Good(id, tbName.Text.Trim(), new TypeGood(Convert.ToInt32(cbType.SelectedValue.ToString()), cbType.Text.Trim()));
                            if (!goodController.Update(good))
                            {
                                MessageBox.Show("Невозможно изменить товар!\nТовара с таким именем уже существует.", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                this.Close();

                        }
                        catch (System.Data.SqlClient.SqlException)
                        {
                            MessageBox.Show("Невозможно изменить товар!\nТовар с таким именем уже существует.", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ошибка работы с базой данных!", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Невозможно добавить новый товар!\nТовар с таким названием уже существует.", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || Char.IsSeparator(e.KeyChar)))
            {
                e.Handled = true;
            }
            else if (!(e.KeyChar >= 1040 && e.KeyChar <= 1103 || e.KeyChar == (char)Keys.Back || Char.IsSeparator(e.KeyChar))) // 1040...1071 А ~ Я 1072...1103 а ~ я
            {
                String myCurrentLanguage = InputLanguage.CurrentInputLanguage.LayoutName;
                ChangeKeyboardLayout(System.Globalization.CultureInfo.GetCultureInfo("ru-RU"));
                e.Handled = true;
            }
        }

        private void ChangeKeyboardLayout(System.Globalization.CultureInfo CultureInfo)
        {
            InputLanguage c = InputLanguage.FromCulture(CultureInfo);
            InputLanguage.CurrentInputLanguage = c;
        }
    }
}
