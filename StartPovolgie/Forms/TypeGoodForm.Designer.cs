namespace StartPovolgie.Forms
{
    partial class TypeGoodForm
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
            this.idtgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeGoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spDataSet = new StartPovolgie.SPDataSet();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.typeGoodTableAdapter = new StartPovolgie.SPDataSetTableAdapters.TypeGoodTableAdapter();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeGoodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(305, 41);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(305, 99);
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
            this.idtgDataGridViewTextBoxColumn,
            this.nametgDataGridViewTextBoxColumn});
            this.dgvTypeGood.DataSource = this.typeGoodBindingSource;
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
            // idtgDataGridViewTextBoxColumn
            // 
            this.idtgDataGridViewTextBoxColumn.DataPropertyName = "id_tg";
            this.idtgDataGridViewTextBoxColumn.HeaderText = "id_tg";
            this.idtgDataGridViewTextBoxColumn.Name = "idtgDataGridViewTextBoxColumn";
            this.idtgDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtgDataGridViewTextBoxColumn.Visible = false;
            // 
            // nametgDataGridViewTextBoxColumn
            // 
            this.nametgDataGridViewTextBoxColumn.DataPropertyName = "name_tg";
            this.nametgDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nametgDataGridViewTextBoxColumn.Name = "nametgDataGridViewTextBoxColumn";
            this.nametgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeGoodBindingSource
            // 
            this.typeGoodBindingSource.DataMember = "TypeGood";
            this.typeGoodBindingSource.DataSource = this.spDataSet;
            // 
            // spDataSet
            // 
            this.spDataSet.DataSetName = "SPDataSet";
            this.spDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(305, 70);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(306, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // typeGoodTableAdapter
            // 
            this.typeGoodTableAdapter.ClearBeforeFill = true;
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(119, 14);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(100, 20);
            this.tbFilter.TabIndex = 6;
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(12, 17);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(100, 13);
            this.lblFilter.TabIndex = 7;
            this.lblFilter.Text = "Введите название";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(225, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "Запрос";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // TypeGoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 282);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvTypeGood);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Name = "TypeGoodForm";
            this.Text = "Типы товаров";
            this.Load += new System.EventHandler(this.TypeGoodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeGoodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dgvTypeGood;
        private SPDataSet spDataSet;
        private System.Windows.Forms.BindingSource typeGoodBindingSource;
        private SPDataSetTableAdapters.TypeGoodTableAdapter typeGoodTableAdapter;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametgDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnSelect;
    }
}