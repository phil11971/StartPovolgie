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
    public partial class AcceptForRepairForm : Form
    {
        public AcceptForRepairForm()
        {
            InitializeComponent();
        }

        private void AcceptForRepairForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            new AddClientForm().ShowDialog();
        }

        private void btnAddGood_Click(object sender, EventArgs e)
        {
            new AddGoodForm().ShowDialog();
        }
    }
}
