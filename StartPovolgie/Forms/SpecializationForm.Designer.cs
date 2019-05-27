namespace StartPovolgie.Forms
{
    partial class SpecializationForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.dgvSpecialization = new System.Windows.Forms.DataGridView();
            this.idspecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namespecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spDataSet = new StartPovolgie.SPDataSet();
            this.btnEdit = new System.Windows.Forms.Button();
            this.specializationTableAdapter = new StartPovolgie.SPDataSetTableAdapters.SpecializationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecialization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(214, 12);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dgvSpecialization
            // 
            this.dgvSpecialization.AllowUserToAddRows = false;
            this.dgvSpecialization.AllowUserToDeleteRows = false;
            this.dgvSpecialization.AllowUserToResizeRows = false;
            this.dgvSpecialization.AutoGenerateColumns = false;
            this.dgvSpecialization.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSpecialization.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSpecialization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecialization.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idspecDataGridViewTextBoxColumn,
            this.namespecDataGridViewTextBoxColumn});
            this.dgvSpecialization.DataSource = this.specializationBindingSource;
            this.dgvSpecialization.EnableHeadersVisualStyles = false;
            this.dgvSpecialization.Location = new System.Drawing.Point(12, 41);
            this.dgvSpecialization.MultiSelect = false;
            this.dgvSpecialization.Name = "dgvSpecialization";
            this.dgvSpecialization.ReadOnly = true;
            this.dgvSpecialization.RowHeadersVisible = false;
            this.dgvSpecialization.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSpecialization.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSpecialization.Size = new System.Drawing.Size(277, 229);
            this.dgvSpecialization.TabIndex = 3;
            // 
            // idspecDataGridViewTextBoxColumn
            // 
            this.idspecDataGridViewTextBoxColumn.DataPropertyName = "id_spec";
            this.idspecDataGridViewTextBoxColumn.HeaderText = "id_spec";
            this.idspecDataGridViewTextBoxColumn.Name = "idspecDataGridViewTextBoxColumn";
            this.idspecDataGridViewTextBoxColumn.ReadOnly = true;
            this.idspecDataGridViewTextBoxColumn.Visible = false;
            // 
            // namespecDataGridViewTextBoxColumn
            // 
            this.namespecDataGridViewTextBoxColumn.DataPropertyName = "name_spec";
            this.namespecDataGridViewTextBoxColumn.HeaderText = "Название";
            this.namespecDataGridViewTextBoxColumn.Name = "namespecDataGridViewTextBoxColumn";
            this.namespecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specializationBindingSource
            // 
            this.specializationBindingSource.DataMember = "Specialization";
            this.specializationBindingSource.DataSource = this.spDataSet;
            // 
            // spDataSet
            // 
            this.spDataSet.DataSetName = "SPDataSet";
            this.spDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(113, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // specializationTableAdapter
            // 
            this.specializationTableAdapter.ClearBeforeFill = true;
            // 
            // SpecializationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 282);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvSpecialization);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Name = "SpecializationForm";
            this.Text = "Специализации мастеров";
            this.Load += new System.EventHandler(this.SpecializationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecialization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dgvSpecialization;
        private System.Windows.Forms.BindingSource specializationBindingSource;
        private SPDataSet spDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idspecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namespecDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEdit;
        private SPDataSetTableAdapters.SpecializationTableAdapter specializationTableAdapter;
    }
}