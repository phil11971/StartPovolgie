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
            if (MessageBox.Show("Вы действительно хотите удалить выбранный тип товара?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                    MessageBox.Show("Невозможно удалить выбранный тип товара! Имеются товары данного типа.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
