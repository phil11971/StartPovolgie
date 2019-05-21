using StartPovolgie.DAO;
using StartPovolgie.Controller;
using StartPovolgie.Model;
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

    public partial class SparePartsForFaultForm : Form
    {
        private int idFault;
        FaultSparePartController faultSparePartController;

        public SparePartsForFaultForm(int idFault)
        {
            InitializeComponent();
            faultSparePartController = new FaultSparePartController();
            this.idFault = idFault;
        }

        private void SparePartsForFaultForm_Load(object sender, EventArgs e)
        {
            sparePartTableAdapter.Fill(spDataSet.SparePart);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //todo
            List<SparePart> spareParts = new List<SparePart>();
            for (int i = 0; i < dgvSparePart.SelectedRows.Count; i++)
            {
                spareParts.Add( new SparePart((int)dgvSparePart.SelectedRows[i].Cells[0].Value, Int32.Parse(dgvSparePart.SelectedRows[i].Cells[5].Value.ToString()), float.Parse(dgvSparePart.SelectedRows[i].Cells[6].Value.ToString())) );
            }
            FaultSparePart faultSparePart = new FaultSparePart(idFault, spareParts);
            if (!faultSparePartController.Insert(faultSparePart))
            {
                MessageBox.Show("Невозможно добавить новый вид устройства!\nВид с таким названием уже существует.", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                this.Close();
        }

        private void AddTypeOfDevicesForm_Closing(object sender, CancelEventArgs e)
        {
            sparePartTableAdapter.Fill(spDataSet.SparePart);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!tbName.Text.Equals(""))
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
        }

        private void btnPullOut_Click(object sender, EventArgs e)
        {
            spDataSet.SparePart.Clear();
            sparePartTableAdapter.Fill(spDataSet.SparePart);
        }

        private void dgvSparePart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && !dgvSparePart.Rows[e.RowIndex].Cells[5].Value.Equals(""))
            {
                if (Int32.Parse(dgvSparePart.Rows[e.RowIndex].Cells[5].Value.ToString()) <= (int)dgvSparePart.Rows[e.RowIndex].Cells[3].Value)
                {
                    float priceunit = Convert.ToSingle(dgvSparePart.Rows[e.RowIndex].Cells[4].Value);
                    int cntreal = Int32.Parse(dgvSparePart.Rows[e.RowIndex].Cells[5].Value.ToString());
                    dgvSparePart.Rows[e.RowIndex].Cells[6].Value = priceunit * cntreal;
                }
                else
                {
                    dgvSparePart.Rows[e.RowIndex].Cells[5].Value = "";
                    MessageBox.Show("Нет такого кол-ва ЗП на складе");
                }
            }
        }
    }

}
