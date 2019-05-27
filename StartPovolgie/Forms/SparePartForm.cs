using StartPovolgie.DAO;
using StartPovolgie.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartPovolgie.Forms
{
    public partial class SparePartForm : Form
    {
        public SparePartForm()
        {
            InitializeComponent();
        }

        private void SparePartForm_Load(object sender, EventArgs e)
        {
            cbStatus.SelectedItem = "В наличии";
            sparePartTableAdapter.Fill(spDataSet.SparePart);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addSparePartForm = new AddSparePartForm();
            addSparePartForm.Closing += AddTypeOfDevicesForm_Closing;
            addSparePartForm.ShowDialog();
        }

        private void AddTypeOfDevicesForm_Closing(object sender, CancelEventArgs e)
        {
            sparePartTableAdapter.Fill(spDataSet.SparePart);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvSparePart.CurrentRow.Cells[0].Value);
            string name = (string)dgvSparePart.CurrentRow.Cells[1].Value;
            string desc = (string)dgvSparePart.CurrentRow.Cells[2].Value;
            string cnt = dgvSparePart.CurrentRow.Cells[3].Value.ToString();
            string price = dgvSparePart.CurrentRow.Cells[4].Value.ToString();

            var editSparePartForm = new AddSparePartForm(id, name, desc, cnt, price);
            editSparePartForm.Closing += AddTypeOfDevicesForm_Closing;
            editSparePartForm.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранную запчасть?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvSparePart.CurrentRow.Cells[0].Value);
                //string name = dgvTypeGood.CurrentRow.Cells[1].Value.ToString();
                try
                {
                    //typeGoodTableAdapter.Delete(id, name);
                    new SparePartController().DeleteById(id);
                    sparePartTableAdapter.Fill(spDataSet.SparePart);
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Невозможно удалить выбранную запчасть!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!tbName.Text.Equals(""))
            {
                string sql;
                if (cbStatus.Text.Equals("В наличии"))
                    sql = "Select sp.id_sp, sp.name_sp, sp.desc_sp, sp.quantity, sp.price From SparePart sp Where sp.quantity > 0 and sp.name_sp = @tbName";
                else
                    sql = "Select sp.id_sp, sp.name_sp, sp.desc_sp, sp.quantity, sp.price From SparePart sp Where sp.quantity = 0 and sp.name_sp = @tbName";

                using (SqlCommand cmd = new SqlCommand(sql, ConnectionDB.Connect()))
                {
                    SqlParameter param = new SqlParameter();
                    param = new SqlParameter();
                    param.ParameterName = "@tbName";
                    param.Value = tbName.Text;
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 100;
                    cmd.Parameters.Add(param);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                    spDataSet.SparePart.Clear();
                    dataAdapter.Fill(spDataSet.SparePart);

                }

                dgvSparePart.DataSource = spDataSet.SparePart;
            }
            else if (!tbName.Text.Equals(""))
            {
                string sql = "Select * From SparePart Where name_sp=@tbName";

                using (SqlCommand cmd = new SqlCommand(sql, ConnectionDB.Connect()))
                {
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@tbName";
                    param.Value = tbName.Text;
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 100;
                    cmd.Parameters.Add(param);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                    spDataSet.SparePart.Clear();
                    dataAdapter.Fill(spDataSet.SparePart);

                }

                dgvSparePart.DataSource = spDataSet.SparePart;
            }
            else if (!cbStatus.Text.Equals(""))
            {
                string sql;
                if (cbStatus.Text.Equals("В наличии"))
                    sql = "Select sp.id_sp, sp.name_sp, sp.desc_sp, sp.quantity, sp.price From SparePart sp Where sp.quantity > 0";
                else
                    sql = "Select sp.id_sp, sp.name_sp, sp.desc_sp, sp.quantity, sp.price From SparePart sp Where sp.quantity = 0";

                using (SqlCommand cmd = new SqlCommand(sql, ConnectionDB.Connect()))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                    spDataSet.SparePart.Clear();
                    dataAdapter.Fill(spDataSet.SparePart);
                }

                dgvSparePart.DataSource = spDataSet.SparePart;
            }
        }

        private void btnPullOut_Click(object sender, EventArgs e)
        {
            spDataSet.SparePart.Clear();
            sparePartTableAdapter.Fill(spDataSet.SparePart);
        }
    }
}
