using StartPovolgie.Controller;
using StartPovolgie.DAO;
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
    public partial class GoodForm : Form
    {
        public GoodForm()
        {
            InitializeComponent();
        }

        private void GoodForm_Load(object sender, EventArgs e)
        {
            typeGoodTableAdapter.Fill(spDataSet.TypeGood);
            goodTableAdapter.Fill(spDataSet.Good);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addGoodForm = new AddGoodForm();
            addGoodForm.Closing += AddTypeOfDevicesForm_Closing;
            addGoodForm.ShowDialog();
        }

        private void AddTypeOfDevicesForm_Closing(object sender, CancelEventArgs e)
        {
            goodTableAdapter.Fill(spDataSet.Good);
            typeGoodTableAdapter.Fill(spDataSet.TypeGood);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvGoods.CurrentRow.Cells[0].Value);
            string name = (string)dgvGoods.CurrentRow.Cells[1].Value;
            string type = dgvGoods.CurrentRow.Cells[2].Value.ToString();
            var editGoodForm = new AddGoodForm(id, name, type);
            editGoodForm.Closing += AddTypeOfDevicesForm_Closing;
            editGoodForm.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранный вид устройств?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvGoods.CurrentRow.Cells[0].Value);
                //string name = dgvTypeGood.CurrentRow.Cells[1].Value.ToString();
                try
                {
                    //typeGoodTableAdapter.Delete(id, name);
                    new GoodController().DeleteById(id);
                    goodTableAdapter.Fill(spDataSet.Good);
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

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!tbName.Text.Equals("") && !cbType.Text.Equals(""))
            {
                string sql = "Select g.id_g, g.name_g, g.id_tg From Good g Join TypeGood t On g.id_tg = t.id_tg Where t.name_tg = @cbType and g.name_g = @tbName";

                using (SqlCommand cmd = new SqlCommand(sql, ConnectionDB.Connect()))
                {
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@cbType";
                    param.Value = cbType.Text;
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 100;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@tbName";
                    param.Value = tbName.Text;
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 100;
                    cmd.Parameters.Add(param);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                    spDataSet.Good.Clear();
                    dataAdapter.Fill(spDataSet.Good);

                }

                dgvGoods.DataSource = spDataSet.Good;
            }
            else if (!tbName.Text.Equals(""))
            {
                string sql = "Select * From Good Where name_g=@tbName";

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
                    spDataSet.Good.Clear();
                    dataAdapter.Fill(spDataSet.Good);

                }

                dgvGoods.DataSource = spDataSet.Good;
            }
            else if (!cbType.Text.Equals(""))
            {
                string sql = "Select g.id_g, g.name_g, g.id_tg From Good g Join TypeGood t On g.id_tg = t.id_tg Where t.name_tg = @cbType";

                using (SqlCommand cmd = new SqlCommand(sql, ConnectionDB.Connect()))
                {
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@cbType";
                    param.Value = cbType.Text;
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 100;
                    cmd.Parameters.Add(param);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                    spDataSet.Good.Clear();
                    dataAdapter.Fill(spDataSet.Good);

                }

                dgvGoods.DataSource = spDataSet.Good;
            }
        }

        private void btnPullOut_Click(object sender, EventArgs e)
        {
            spDataSet.Service.Clear();
            goodTableAdapter.Fill(spDataSet.Good);
        }
    }
}
