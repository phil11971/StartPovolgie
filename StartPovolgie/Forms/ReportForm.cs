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
                        
                        break;
                    }
                case "\'Количество оставленных товаров\'":
                    {
                        countGoodTableAdapter.Fill(spDataSet.CountGood, dateS.ToShortDateString(), datePo.ToShortDateString());
                        ReportDocument doc = new ReportDocument();
                        doc.Load(@"D:\8 семак\диплом\ВКРБ Филатова\Программа\StartPovolgie\StartPovolgie\Forms\cntg.rpt");
                        doc.SetDataSource(spDataSet);
                        crystalReportViewer1.ReportSource = doc;
                        crystalReportViewer1.Refresh();
                        this.Controls.Add(crystalReportViewer1);
                        crystalReportViewer1.Dock = DockStyle.Fill;
                        
                        break;
                    }

            }

        }

    }
}
