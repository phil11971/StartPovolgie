using StartPovolgie.Controller;
using StartPovolgie.Model;
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
    public partial class AcceptForRepairForm : Form
    {
        Employee employee;
        AcceptForRepairController acceptForRepairController;

        public AcceptForRepairForm(Employee employee)
        {
            InitializeComponent();
            acceptForRepairController = new AcceptForRepairController();
            this.employee = employee;
        }

        private void AcceptForRepairForm_Load(object sender, EventArgs e)
        {
            typeGoodTableAdapter.Fill(spDataSet.TypeGood);
            clientTableAdapter.Fill(spDataSet.Client);
            goodTableAdapter.Fill(spDataSet.Good);
            faultStatusTableAdapter.Fill(spDataSet.FaultStatus);
            idclientDataGridViewTextBoxColumn.Visible = false;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            new AddClientForm().ShowDialog();
        }

        private void btnAddGood_Click(object sender, EventArgs e)
        {
            new AddGoodForm().ShowDialog();
        }

        private void btnFindGood_Click(object sender, EventArgs e)
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

                dgvGood.DataSource = spDataSet.Good;
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

                dgvGood.DataSource = spDataSet.Good;
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

                dgvGood.DataSource = spDataSet.Good;
            }
        }

        private void btnCancelGood_Click(object sender, EventArgs e)
        {
            spDataSet.Service.Clear();
            goodTableAdapter.Fill(spDataSet.Good);
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            //todo maskedtb
            if (rbLastName.Checked)
                clientBindingSource.Filter = String.Format("lname=\'{0}\'", mtbFind.Text.Trim());
            else
                clientBindingSource.Filter = String.Format("phone=\'{0}\'", mtbFind.Text.Trim());
        }

        private void btnCancelClient_Click(object sender, EventArgs e)
        {
            clientBindingSource.Filter = "";
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (dgvFault.Rows.Count == 0 && (dgvFault.Rows[0].Cells[0].Value.Equals("") || dgvFault.Rows[0].Cells[1].Value.Equals("")) )
            {
                MessageBox.Show("Заполните неисправности!", "Ошибка добваления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    LinkedList<Fault> faults = new LinkedList<Fault>();
                    for (int i = 0; i < dgvFault.RowCount - 1; i++)
                    {
                        faults.AddLast( new Fault(dgvFault.Rows[i].Cells[0].Value.ToString(), dgvFault.Rows[i].Cells[1].Value.ToString(), (int)dgvFault.Rows[i].Cells[2].Value) );
                    }
                    AcceptForRepair acceptForRepair = new AcceptForRepair(
                        rtbEquipment.Text.Trim(), rtbMechanicalDamage.Text.Trim(), 
                        dtpReceiptDate.Value.Date, rtbComment.Text.Trim(), 
                        (int)dgvGood.CurrentRow.Cells[0].Value, employee.Id, (int)dgvClient.CurrentRow.Cells[0].Value,
                        faults);
                    if (!acceptForRepairController.Insert(acceptForRepair))
                    {
                        MessageBox.Show("Невозможно добавить новый вид устройства!\nВид с таким названием уже существует.", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        this.Close();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Невозможно добавить новый вид устройства!\nВид с таким названием уже существует.", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //todo print
        private void btnPrint_Click(object sender, EventArgs e)
        {
            
        }
    }
}
