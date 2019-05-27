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
    public partial class AddFaultStatusForm : Form
    {
        private int id;
        FaultStatusController faultStatusController;

        public AddFaultStatusForm()
        {
            InitializeComponent();
            this.ActiveControl = tbFaultStatus;
            faultStatusController = new FaultStatusController();
        }

        public AddFaultStatusForm(int id, string faultStatusName)
        {
            InitializeComponent();
            this.Text = "Изменение состояния неисправности";
            gbFaultStatus.Text = "Изменение состояния неисправности";
            tbFaultStatus.Text = faultStatusName;
            btnAdd.Text = "Изменить";
            this.ActiveControl = tbFaultStatus;
            faultStatusController = new FaultStatusController();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbFaultStatus.Text.Trim().Equals(""))
            {
                MessageBox.Show("Заполните пустые поля!", "Ошибка добваления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (id == 0)
                    {
                        FaultStatus faultStatus = new FaultStatus(tbFaultStatus.Text.Trim());
                        if (!faultStatusController.Insert(faultStatus))
                        {
                            MessageBox.Show("Невозможно добавить новый статус неисправности!\nСтатус неисправности с таким названием уже существует.", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            this.Close();
                    }
                    else
                    {
                        try
                        {
                            FaultStatus faultStatus = new FaultStatus(id, tbFaultStatus.Text.Trim());
                            if (!faultStatusController.Update(faultStatus))
                            {
                                MessageBox.Show("Невозможно изменить статус неисправности!\nСтатус неисправности с таким именем уже существует.", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                this.Close();
                            
                        }
                        catch (System.Data.SqlClient.SqlException)
                        {
                            MessageBox.Show("Невозможно изменить статус неисправности!\nТип товара с таким именем уже существует.", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ошибка работы с базой данных!", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Невозможно добавить статус неисправности!\nСтатус неисправности с таким названием уже существует.", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbFaultStatus_KeyPress(object sender, KeyPressEventArgs e)
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
