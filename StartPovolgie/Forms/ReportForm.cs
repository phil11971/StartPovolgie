using CrystalDecisions.CrystalReports.Engine;
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

        private string type;
        private DateTime dateS;
        private DateTime datePo;

        public ReportForm(string type, DateTime dateS, DateTime datePo)
        {
            InitializeComponent();
            this.type = type;
            this.dateS = dateS;
            this.datePo = datePo;
            this.Text = "Отчет " + type;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

            switch (type)
            {
                case "\'Объем выполненных работ\'":
                    {

                        serviceCostTableAdapter.Fill(spDataSet.ServiceCost, dateS.ToShortDateString(), datePo.ToShortDateString());
                        ReportDocument doc = new ReportDocument();
                        doc.Load(@"D:\8 семак\диплом\ВКРБ Филатова\Программа\StartPovolgie\StartPovolgie\Forms\servc.rpt");
                        doc.SetDataSource(spDataSet);
                        crystalReportViewer1.ReportSource = doc;
                        crystalReportViewer1.Refresh();
                        this.Controls.Add(crystalReportViewer1);
                        crystalReportViewer1.Dock = DockStyle.Fill;
                        /*ReportDataSource reportDataSource = new ReportDataSource();
                        reportDataSource.Name = "DataSetServiceCost";
                        reportDataSource.Value = serviceCostBindingSource;//serviceCenterDBDataSet.ServiceCosts;
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                        reportViewer1.LocalReport.ReportEmbeddedResource = "StartPovolgie.Reports.ServiceCost.rdlc";

                        ReportParameterInfoCollection parms = reportViewer1.LocalReport.GetParameters();
                        foreach (ReportParameterInfo parm in parms)
                        {
                            SetReportParameters(parm.Name);
                        }

                        reportViewer1.LocalReport.Refresh();
                        this.reportViewer1.RefreshReport();
                        this.serviceCostTableAdapter.Fill(this.spDataSet.ServiceCost, dateS.ToShortDateString(), datePo.ToShortDateString());
                        */
                        break;
                    }


            }

            /*ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet1";
            reportDataSource.Value = bindingSource1;
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportEmbeddedResource = "StartPovolgie.Reports.Report1.rdlc";

            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
            typeGoodTableAdapter1.Fill(spDataSet.TypeGood);*/
        }

        private void SetReportParameters(String parameterName)
        {
            //string dateS=dtpDateS.Value.Date+"."+dtpDateS.Value.Month + "."+dtpDateS.Value.Year;
            //string datePo = dtpDatePo.Value.Date + "." + dtpDatePo.Value.Month + "." + dtpDatePo.Value.Year;
            try
            {
                if (parameterName.ToLower().Equals("dates"))
                {
                    ReportParameter startTimeParameter = new ReportParameter(parameterName, dateS.ToShortDateString());
                    //this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { startTimeParameter });
                }
                else if (parameterName.ToLower().Equals("datepo"))
                {
                    ReportParameter endTimeParameter = new ReportParameter(parameterName, datePo.ToShortDateString());
                    //this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { endTimeParameter });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
