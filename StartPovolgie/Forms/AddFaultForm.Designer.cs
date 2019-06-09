namespace StartPovolgie.Forms
{
    partial class AddFaultForm
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
            this.dgvFault = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.faultStatusTableAdapter = new StartPovolgie.SPDataSetTableAdapters.FaultStatusTableAdapter();
            this.faultStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spDataSet = new StartPovolgie.SPDataSet();
            this.dgvtbcDescFault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faultStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idfsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namefsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFault
            // 
            this.dgvFault.AutoGenerateColumns = false;
            this.dgvFault.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFault.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFault.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFault.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcDescFault,
            this.faultStatus,
            this.idfsDataGridViewTextBoxColumn,
            this.namefsDataGridViewTextBoxColumn});
            this.dgvFault.DataSource = this.faultStatusBindingSource;
            this.dgvFault.EnableHeadersVisualStyles = false;
            this.dgvFault.Location = new System.Drawing.Point(12, 12);
            this.dgvFault.Name = "dgvFault";
            this.dgvFault.RowHeadersVisible = false;
            this.dgvFault.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFault.Size = new System.Drawing.Size(339, 129);
            this.dgvFault.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(276, 147);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // faultStatusTableAdapter
            // 
            this.faultStatusTableAdapter.ClearBeforeFill = true;
            // 
            // faultStatusBindingSource
            // 
            this.faultStatusBindingSource.DataMember = "FaultStatus";
            this.faultStatusBindingSource.DataSource = this.spDataSet;
            // 
            // spDataSet
            // 
            this.spDataSet.DataSetName = "SPDataSet";
            this.spDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvtbcDescFault
            // 
            this.dgvtbcDescFault.HeaderText = "Описание неисправности";
            this.dgvtbcDescFault.Name = "dgvtbcDescFault";
            // 
            // faultStatus
            // 
            this.faultStatus.HeaderText = "Состояние";
            this.faultStatus.Name = "faultStatus";
            // 
            // idfsDataGridViewTextBoxColumn
            // 
            this.idfsDataGridViewTextBoxColumn.DataPropertyName = "id_fs";
            this.idfsDataGridViewTextBoxColumn.HeaderText = "id_fs";
            this.idfsDataGridViewTextBoxColumn.Name = "idfsDataGridViewTextBoxColumn";
            this.idfsDataGridViewTextBoxColumn.ReadOnly = true;
            this.idfsDataGridViewTextBoxColumn.Visible = false;
            // 
            // namefsDataGridViewTextBoxColumn
            // 
            this.namefsDataGridViewTextBoxColumn.DataPropertyName = "name_fs";
            this.namefsDataGridViewTextBoxColumn.HeaderText = "name_fs";
            this.namefsDataGridViewTextBoxColumn.Name = "namefsDataGridViewTextBoxColumn";
            this.namefsDataGridViewTextBoxColumn.Visible = false;
            // 
            // AddFaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 177);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvFault);
            this.Name = "AddFaultForm";
            this.Text = "Добавление неисправностей";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFault;
        private System.Windows.Forms.Button btnAdd;
        private SPDataSetTableAdapters.FaultStatusTableAdapter faultStatusTableAdapter;
        private System.Windows.Forms.BindingSource faultStatusBindingSource;
        private SPDataSet spDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDescFault;
        private System.Windows.Forms.DataGridViewComboBoxColumn faultStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namefsDataGridViewTextBoxColumn;
    }
}