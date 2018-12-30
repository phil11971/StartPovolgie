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
    public partial class EmployeeForm : Form
    {
        private int IdEmp { get; set; }
        public EmployeeForm(int idEmp)
        {
            InitializeComponent();
            this.ActiveControl = lblEmployees;
            IdEmp = idEmp;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
