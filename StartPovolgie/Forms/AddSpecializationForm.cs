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
    public partial class AddSpecializationForm : Form
    {
        private int id;
        SpecializationController specializationController;

        public AddSpecializationForm()
        {
            InitializeComponent();
            this.ActiveControl = tbSpec;
            specializationController = new SpecializationController();
        }

        public AddSpecializationForm(int id, string spec)
        {
            InitializeComponent();
            this.Text = "Изменение специализации";
            gbSpec.Text = "Изменение специализации";
            tbSpec.Text = spec;
            btnAdd.Text = "Изменить";
            this.id = id;
            this.ActiveControl = tbSpec;
            specializationController = new SpecializationController();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbSpec.Text.Trim().Equals(""))
            {
                MessageBox.Show("Заполните пустые поля!", "Ошибка добваления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (id == 0)
                    {
                        Specialization specialization = new Specialization(tbSpec.Text.Trim());
                        if (!specializationController.Insert(specialization))
                        {
                            MessageBox.Show("Невозможно добавить новую специализацию!\nСпециализация с таким названием уже существует.", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            this.Close();
                    }
                    else
                    {
                        try
                        {
                            Specialization specialization = new Specialization(id, tbSpec.Text.Trim());
                            if (!specializationController.Update(specialization))
                            {
                                MessageBox.Show("Невозможно изменить специализацию!\nСпециализация с таким именем уже существует.", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                this.Close();
                            
                        }
                        catch (System.Data.SqlClient.SqlException)
                        {
                            MessageBox.Show("Невозможно изменить специализацию!\nСпециализация с таким именем уже существует.", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ошибка работы с базой данных!", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Невозможно добавить новую специализацию!\nСпециализация с таким названием уже существует.", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbSpec_KeyPress(object sender, KeyPressEventArgs e)
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
