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
    public partial class TypeGoodForm : Form
    {
        public TypeGoodForm()
        {
            InitializeComponent();
        }

        private void TypeGoodForm_Load(object sender, EventArgs e)
        {
            this.typeGoodTableAdapter.Fill(this.spDataSet.TypeGood);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addTypeGoodForm = new AddTypeGoodForm();
            addTypeGoodForm.Closing += AddTypeOfDevicesForm_Closing;
            addTypeGoodForm.Closing += btnCancel_Click;
            addTypeGoodForm.ShowDialog();
        }

        private void AddTypeOfDevicesForm_Closing(object sender, CancelEventArgs e)
        {
            typeGoodTableAdapter.Fill(spDataSet.TypeGood);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvTypeGood.CurrentRow.Cells[0].Value);
            string s = (string)dgvTypeGood.CurrentRow.Cells[1].Value;
            var editTypeGoodForm = new AddTypeGoodForm(id, s);
            editTypeGoodForm.Closing += AddTypeOfDevicesForm_Closing;
            editTypeGoodForm.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранный вид устройств?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvTypeGood.CurrentRow.Cells[0].Value);
                //string name = dgvTypeGood.CurrentRow.Cells[1].Value.ToString();
                try
                {
                    //typeGoodTableAdapter.Delete(id, name);
                    new TypeGoodController().DeleteById(id);
                    typeGoodTableAdapter.Fill(spDataSet.TypeGood);
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Невозможно удалить выбранный вид устройств! Имеются устройства данного вида.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbFilter.Text = "";
            typeGoodBindingSource.Filter = null;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            typeGoodBindingSource.Filter = String.Format("name_tg = '{0}'", tbFilter.Text.ToString());
            //typeGoodBindingSource.MoveFirst();
            //for (int i = 0; i < typeGoodBindingSource.Count; i++)
            //{
            //    //Это то что Вам нужно, Виктория
            //    Console.WriteLine((typeGoodBindingSource.Current as DataRowView).Row[1]);
            //    typeGoodBindingSource.MoveNext();
            //}
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
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
