using Microsoft.Reporting.WinForms;
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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet1";
            reportDataSource.Value = bindingSource1;
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportEmbeddedResource = "StartPovolgie.Reports.Report1.rdlc";

            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
            typeGoodTableAdapter1.Fill(spDataSet1.TypeGood);
        }
    }
}
