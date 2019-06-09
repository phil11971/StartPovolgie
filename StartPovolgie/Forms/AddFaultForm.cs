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
    public partial class AddFaultForm : Form
    {
        private int idAccept;
        FaultController faultController;

        public AddFaultForm(int idAccept)
        {
            InitializeComponent();
            this.idAccept = idAccept;
            faultController = new FaultController();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvFault.Rows[0].Cells[0].Value == null || dgvFault.Rows[0].Cells[1].Value == null)
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
                        faults.AddLast(new Fault(dgvFault.Rows[i].Cells[0].Value.ToString(), (int)dgvFault.Rows[i].Cells[1].Value));
                    }

                    if (!faultController.Insert(faults, idAccept))
                    {
                        MessageBox.Show("Невозможно добавить неисправности", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Невозможно добавить неисправности", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
