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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();

            dtpS.MaxDate = DateTime.Now.Date;
            dtpPo.MaxDate = DateTime.Now.Date;
            dtpPo.Value = DateTime.Now.Date;
            dtpS.Value = DateTime.Now.Date;

            if (dtpPo.Value < dtpS.Value)
            {
                btnForm.Enabled = false;
            }
            else
            {
                btnForm.Enabled = true;
            }
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            if (rbServiceCost.Checked)
            {
                if (new ReturnFromRepairController().HasServiceInPeriod(dtpS.Value, dtpPo.Value))
                {
                    new ReportForm("\'Объем выполненных работ\'", dtpS.Value, dtpPo.Value).ShowDialog();
                }
                else
                {
                    MessageBox.Show("За выбранный период услуги не оказывались!", "Формирование отчета", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (new ReturnFromRepairController().HasServiceInPeriod(dtpS.Value, dtpPo.Value))
                {
                    new ReportForm("\'Количество оставленных товаров\'", dtpS.Value, dtpPo.Value).ShowDialog();
                }
                else
                {
                    MessageBox.Show("За выбранный период товары не принимались!", "Формирование отчета", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
