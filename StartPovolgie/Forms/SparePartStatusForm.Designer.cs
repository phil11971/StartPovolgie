namespace StartPovolgie.Forms
{
    partial class SparePartStatusForm
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
            this.dgvTypeGood = new System.Windows.Forms.DataGridView();
            this.idspsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namespsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparePartStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spDataSet = new StartPovolgie.SPDataSet();
            this.btnEdit = new System.Windows.Forms.Button();
            this.sparePartStatusTableAdapter = new StartPovolgie.SPDataSetTableAdapters.SparePartStatusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(225, 12);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dgvTypeGood
            // 
            this.dgvTypeGood.AllowUserToAddRows = false;
            this.dgvTypeGood.AllowUserToDeleteRows = false;
            this.dgvTypeGood.AllowUserToResizeRows = false;
            this.dgvTypeGood.AutoGenerateColumns = false;
            this.dgvTypeGood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTypeGood.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTypeGood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypeGood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idspsDataGridViewTextBoxColumn,
            this.namespsDataGridViewTextBoxColumn});
            this.dgvTypeGood.DataSource = this.sparePartStatusBindingSource;
            this.dgvTypeGood.EnableHeadersVisualStyles = false;
            this.dgvTypeGood.Location = new System.Drawing.Point(15, 41);
            this.dgvTypeGood.MultiSelect = false;
            this.dgvTypeGood.Name = "dgvTypeGood";
            this.dgvTypeGood.ReadOnly = true;
            this.dgvTypeGood.RowHeadersVisible = false;
            this.dgvTypeGood.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTypeGood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTypeGood.Size = new System.Drawing.Size(285, 229);
            this.dgvTypeGood.TabIndex = 2;
            // 
            // idspsDataGridViewTextBoxColumn
            // 
            this.idspsDataGridViewTextBoxColumn.DataPropertyName = "id_sps";
            this.idspsDataGridViewTextBoxColumn.HeaderText = "id_sps";
            this.idspsDataGridViewTextBoxColumn.Name = "idspsDataGridViewTextBoxColumn";
            this.idspsDataGridViewTextBoxColumn.ReadOnly = true;
            this.idspsDataGridViewTextBoxColumn.Visible = false;
            // 
            // namespsDataGridViewTextBoxColumn
            // 
            this.namespsDataGridViewTextBoxColumn.DataPropertyName = "name_sps";
            this.namespsDataGridViewTextBoxColumn.HeaderText = "Название";
            this.namespsDataGridViewTextBoxColumn.Name = "namespsDataGridViewTextBoxColumn";
            this.namespsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sparePartStatusBindingSource
            // 
            this.sparePartStatusBindingSource.DataMember = "SparePartStatus";
            this.sparePartStatusBindingSource.DataSource = this.spDataSet;
            // 
            // spDataSet
            // 
            this.spDataSet.DataSetName = "SPDataSet";
            this.spDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(121, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // sparePartStatusTableAdapter
            // 
            this.sparePartStatusTableAdapter.ClearBeforeFill = true;
            // 
            // SparePartStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 282);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvTypeGood);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Name = "SparePartStatusForm";
            this.Text = "Статус запчасти";
            this.Load += new System.EventHandler(this.SparePartStatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dgvTypeGood;
        private SPDataSet spDataSet;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.BindingSource sparePartStatusBindingSource;
        private SPDataSetTableAdapters.SparePartStatusTableAdapter sparePartStatusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idspsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namespsDataGridViewTextBoxColumn;
    }
}