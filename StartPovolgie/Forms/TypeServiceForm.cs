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
    public partial class TypeServiceForm : Form
    {
        public TypeServiceForm()
        {
            InitializeComponent();
        }

        private void TypeServiceForm_Load(object sender, EventArgs e)
        {
            typeServiceTableAdapter.Fill(spDataSet.TypeService);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addTypeServiceForm = new AddTypeServiceForm();
            addTypeServiceForm.Closing += AddTypeOfDevicesForm_Closing;
            addTypeServiceForm.ShowDialog();
        }

        private void AddTypeOfDevicesForm_Closing(object sender, CancelEventArgs e)
        {
            typeServiceTableAdapter.Fill(spDataSet.TypeService);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvTypeGood.CurrentRow.Cells[0].Value);
            string s = (string)dgvTypeGood.CurrentRow.Cells[1].Value;
            var editTypeServiceForm = new AddTypeServiceForm(id, s);
            editTypeServiceForm.Closing += AddTypeOfDevicesForm_Closing;
            editTypeServiceForm.ShowDialog();
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
                    new TypeServiceController().DeleteById(id);
                    typeServiceTableAdapter.Fill(spDataSet.TypeService);
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
            typeServiceBindingSource.Filter = null;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            typeServiceBindingSource.Filter = String.Format("name_ts = '{0}'", tbFilter.Text.ToString());
            //typeGoodBindingSource.MoveFirst();
            //for (int i = 0; i < typeGoodBindingSource.Count; i++)
            //{
            //    //Это то что Вам нужно, Виктория
            //    Console.WriteLine((typeGoodBindingSource.Current as DataRowView).Row[1]);
            //    typeGoodBindingSource.MoveNext();
            //}
        }
    }
}
