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
    public partial class ServiceForm : Form
    {
        public ServiceForm()
        {
            InitializeComponent();
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            typeGoodTableAdapter.Fill(spDataSet.TypeGood);
            serviceTableAdapter.Fill(spDataSet.Service);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addServiceForm = new AddServiceForm();
            addServiceForm.Closing += AddTypeOfDevicesForm_Closing;
            addServiceForm.ShowDialog();
        }

        private void AddTypeOfDevicesForm_Closing(object sender, CancelEventArgs e)
        {
            serviceTableAdapter.Fill(spDataSet.Service);
            typeGoodTableAdapter.Fill(spDataSet.TypeGood);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvService.CurrentRow.Cells[0].Value);
            string name = (string)dgvService.CurrentRow.Cells[1].Value;
            string price = dgvService.CurrentRow.Cells[2].Value.ToString();
            string type = dgvService.CurrentRow.Cells[3].Value.ToString();

            var editTypeGoodForm = new AddServiceForm(id, name, price, type);
            editTypeGoodForm.Closing += AddTypeOfDevicesForm_Closing;
            editTypeGoodForm.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранный вид устройств?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvService.CurrentRow.Cells[0].Value);
                //string name = dgvTypeGood.CurrentRow.Cells[1].Value.ToString();
                try
                {
                    //typeGoodTableAdapter.Delete(id, name);
                    new ServiceController().DeleteById(id);
                    serviceTableAdapter.Fill(spDataSet.Service);
                    typeGoodTableAdapter.Fill(spDataSet.TypeGood);
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Невозможно удалить выбранную услугу!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string sql = "Select s.id_service, s.name_service, s.price, s.id_tg From Service s Join TypeGood t On s.id_tg = t.id_tg Where t.name_tg = @cbType and s.name_service = @tbName";

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
                    spDataSet.Service.Clear();
                    dataAdapter.Fill(spDataSet.Service);

                }

                dgvService.DataSource = spDataSet.Service;
            }
            else if (!tbName.Text.Equals("")) {
                string sql = "Select * From Service Where name_service=@tbName";

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
                    spDataSet.Service.Clear();
                    dataAdapter.Fill(spDataSet.Service);

                }
                
                dgvService.DataSource = spDataSet.Service;
            }
            else if (!cbType.Text.Equals("")) {
                string sql = "Select s.id_service, s.name_service, s.price, s.id_tg From Service s Join TypeGood t On s.id_tg = t.id_tg Where t.name_tg = @cbType";

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
                    spDataSet.Service.Clear();
                    dataAdapter.Fill(spDataSet.Service);

                }

                dgvService.DataSource = spDataSet.Service;
            }
        }

        private void btnPullOut_Click(object sender, EventArgs e)
        {
            spDataSet.Service.Clear();
            serviceTableAdapter.Fill(spDataSet.Service);
        }
    }
}
