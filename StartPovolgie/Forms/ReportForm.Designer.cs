namespace StartPovolgie.Forms
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.spDataSet = new StartPovolgie.SPDataSet();
            this.serviceCostTableAdapter = new StartPovolgie.SPDataSetTableAdapters.ServiceCostTableAdapter();
            this.serviceCostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.countGoodTableAdapter = new StartPovolgie.SPDataSetTableAdapters.CountGoodTableAdapter();
            this.countGoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceCostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countGoodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spDataSet
            // 
            this.spDataSet.DataSetName = "SPDataSet";
            this.spDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceCostTableAdapter
            // 
            this.serviceCostTableAdapter.ClearBeforeFill = true;
            // 
            // serviceCostBindingSource
            // 
            this.serviceCostBindingSource.DataMember = "ServiceCost";
            this.serviceCostBindingSource.DataSource = this.spDataSet;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = "D:\\8 семак\\диплом\\ВКРБ Филатова\\Программа\\StartPovolgie\\StartPovolgie\\Forms\\servc" +
    ".rpt";
            this.crystalReportViewer1.Size = new System.Drawing.Size(849, 534);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // countGoodTableAdapter
            // 
            this.countGoodTableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 534);
            this.Controls.Add(this.crystalReportViewer1);
            this.MaximizeBox = false;
            this.Name = "ReportForm";
            this.Text = "Отчет Типы товаров";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceCostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countGoodBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SPDataSet spDataSet;
        private SPDataSetTableAdapters.ServiceCostTableAdapter serviceCostTableAdapter;
        private System.Windows.Forms.BindingSource serviceCostBindingSource;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private SPDataSetTableAdapters.CountGoodTableAdapter countGoodTableAdapter;
        private System.Windows.Forms.BindingSource countGoodBindingSource;
    }
}