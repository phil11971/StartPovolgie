using StartPovolgie.Controller;
using StartPovolgie.Model;
using StartPovolgie.DAO;
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
    public partial class ViewAcceptForRepairForm : Form
    {
        AcceptForRepair acceptForRepair;

        public ViewAcceptForRepairForm(AcceptForRepair accept)
        {
            InitializeComponent();
            acceptForRepair = accept;
        }

        private void ViewAcceptForRepairForm_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
