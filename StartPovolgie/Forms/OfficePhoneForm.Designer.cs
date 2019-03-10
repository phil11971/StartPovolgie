namespace StartPovolgie.Forms
{
    partial class OfficePhoneForm
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
            this.dgvOfficePhone = new System.Windows.Forms.DataGridView();
            this.officePhoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spDataSet = new StartPovolgie.SPDataSet();
            this.officePhoneTableAdapter = new StartPovolgie.SPDataSetTableAdapters.OfficePhoneTableAdapter();
            this.idopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfficePhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officePhoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(27, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(192, 12);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dgvOfficePhone
            // 
            this.dgvOfficePhone.AllowUserToAddRows = false;
            this.dgvOfficePhone.AllowUserToDeleteRows = false;
            this.dgvOfficePhone.AllowUserToResizeRows = false;
            this.dgvOfficePhone.AutoGenerateColumns = false;
            this.dgvOfficePhone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOfficePhone.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOfficePhone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOfficePhone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idopDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dgvOfficePhone.DataSource = this.officePhoneBindingSource;
            this.dgvOfficePhone.EnableHeadersVisualStyles = false;
            this.dgvOfficePhone.Location = new System.Drawing.Point(27, 41);
            this.dgvOfficePhone.Name = "dgvOfficePhone";
            this.dgvOfficePhone.RowHeadersVisible = false;
            this.dgvOfficePhone.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvOfficePhone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOfficePhone.Size = new System.Drawing.Size(240, 229);
            this.dgvOfficePhone.TabIndex = 2;
            // 
            // officePhoneBindingSource
            // 
            this.officePhoneBindingSource.DataMember = "OfficePhone";
            this.officePhoneBindingSource.DataSource = this.spDataSet;
            // 
            // spDataSet
            // 
            this.spDataSet.DataSetName = "SPDataSet";
            this.spDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // officePhoneTableAdapter
            // 
            this.officePhoneTableAdapter.ClearBeforeFill = true;
            // 
            // idopDataGridViewTextBoxColumn
            // 
            this.idopDataGridViewTextBoxColumn.DataPropertyName = "id_op";
            this.idopDataGridViewTextBoxColumn.HeaderText = "id_op";
            this.idopDataGridViewTextBoxColumn.Name = "idopDataGridViewTextBoxColumn";
            this.idopDataGridViewTextBoxColumn.ReadOnly = true;
            this.idopDataGridViewTextBoxColumn.Visible = false;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OfficePhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 282);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvOfficePhone);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Name = "OfficePhoneForm";
            this.Text = "Офисные номера телефонов";
            this.Load += new System.EventHandler(this.OfficePhoneForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfficePhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officePhoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dgvOfficePhone;
        private System.Windows.Forms.BindingSource officePhoneBindingSource;
        private SPDataSet spDataSet;
        private SPDataSetTableAdapters.OfficePhoneTableAdapter officePhoneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}