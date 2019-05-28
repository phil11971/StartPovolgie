namespace StartPovolgie.Forms
{
    partial class SparePartsForFaultForm
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
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnPullOut = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.spDataSet = new StartPovolgie.SPDataSet();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvSparePart = new System.Windows.Forms.DataGridView();
            this.idspDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namespDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descspDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qonf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceforsponf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparePartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sparePartTableAdapter = new StartPovolgie.SPDataSetTableAdapters.SparePartTableAdapter();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSparePart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnPullOut);
            this.gbSearch.Controls.Add(this.btnFind);
            this.gbSearch.Controls.Add(this.tbName);
            this.gbSearch.Controls.Add(this.lblName);
            this.gbSearch.Location = new System.Drawing.Point(12, 12);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(475, 61);
            this.gbSearch.TabIndex = 0;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Поиск";
            // 
            // btnPullOut
            // 
            this.btnPullOut.Location = new System.Drawing.Point(316, 18);
            this.btnPullOut.Name = "btnPullOut";
            this.btnPullOut.Size = new System.Drawing.Size(143, 23);
            this.btnPullOut.TabIndex = 3;
            this.btnPullOut.Text = "Вывести полный список";
            this.btnPullOut.UseVisualStyleBackColor = true;
            this.btnPullOut.Click += new System.EventHandler(this.btnPullOut_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(235, 19);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(100, 21);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Наименование";
            // 
            // spDataSet
            // 
            this.spDataSet.DataSetName = "SPDataSet";
            this.spDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(501, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvSparePart
            // 
            this.dgvSparePart.AllowUserToAddRows = false;
            this.dgvSparePart.AllowUserToDeleteRows = false;
            this.dgvSparePart.AllowUserToResizeRows = false;
            this.dgvSparePart.AutoGenerateColumns = false;
            this.dgvSparePart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSparePart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSparePart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSparePart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idspDataGridViewTextBoxColumn,
            this.namespDataGridViewTextBoxColumn,
            this.descspDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.qonf,
            this.priceforsponf});
            this.dgvSparePart.DataSource = this.sparePartBindingSource;
            this.dgvSparePart.EnableHeadersVisualStyles = false;
            this.dgvSparePart.Location = new System.Drawing.Point(12, 97);
            this.dgvSparePart.Name = "dgvSparePart";
            this.dgvSparePart.RowHeadersVisible = false;
            this.dgvSparePart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSparePart.Size = new System.Drawing.Size(564, 150);
            this.dgvSparePart.TabIndex = 9;
            this.dgvSparePart.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSparePart_CellEndEdit);
            // 
            // idspDataGridViewTextBoxColumn
            // 
            this.idspDataGridViewTextBoxColumn.DataPropertyName = "id_sp";
            this.idspDataGridViewTextBoxColumn.HeaderText = "id_sp";
            this.idspDataGridViewTextBoxColumn.Name = "idspDataGridViewTextBoxColumn";
            this.idspDataGridViewTextBoxColumn.ReadOnly = true;
            this.idspDataGridViewTextBoxColumn.Visible = false;
            // 
            // namespDataGridViewTextBoxColumn
            // 
            this.namespDataGridViewTextBoxColumn.DataPropertyName = "name_sp";
            this.namespDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.namespDataGridViewTextBoxColumn.Name = "namespDataGridViewTextBoxColumn";
            // 
            // descspDataGridViewTextBoxColumn
            // 
            this.descspDataGridViewTextBoxColumn.DataPropertyName = "desc_sp";
            this.descspDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descspDataGridViewTextBoxColumn.Name = "descspDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена ЗП за ед.";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // qonf
            // 
            this.qonf.HeaderText = "Количество на неиспр";
            this.qonf.Name = "qonf";
            // 
            // priceforsponf
            // 
            this.priceforsponf.HeaderText = "Цена с учетом кол-ва ЗП на неиспр";
            this.priceforsponf.Name = "priceforsponf";
            this.priceforsponf.ReadOnly = true;
            // 
            // sparePartBindingSource
            // 
            this.sparePartBindingSource.DataMember = "SparePart";
            this.sparePartBindingSource.DataSource = this.spDataSet;
            this.sparePartBindingSource.Filter = "quantity>0";
            // 
            // sparePartTableAdapter
            // 
            this.sparePartTableAdapter.ClearBeforeFill = true;
            // 
            // SparePartsForFaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 281);
            this.Controls.Add(this.dgvSparePart);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SparePartsForFaultForm";
            this.Text = "Запчасти";
            this.Load += new System.EventHandler(this.SparePartsForFaultForm_Load);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSparePart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btnPullOut;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvSparePart;
        private SPDataSet spDataSet;
        private System.Windows.Forms.BindingSource sparePartBindingSource;
        private SPDataSetTableAdapters.SparePartTableAdapter sparePartTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idspDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namespDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descspDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qonf;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceforsponf;
    }
}