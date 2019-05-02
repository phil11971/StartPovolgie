using System;

namespace StartPovolgie.Forms
{
    partial class MasterForm
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.dgvMaster = new System.Windows.Forms.DataGridView();
            this.idempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spDataSet = new StartPovolgie.SPDataSet();
            this.gbInfoEmp = new System.Windows.Forms.GroupBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.gbInfoEmpEntry = new System.Windows.Forms.GroupBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.dgvMasterSpec = new System.Windows.Forms.DataGridView();
            this.idmasterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idspecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namespecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charspecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterSpecializationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new StartPovolgie.SPDataSetTableAdapters.EmployeeTableAdapter();
            this.masterSpecializationTableAdapter = new StartPovolgie.SPDataSetTableAdapters.MasterSpecializationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).BeginInit();
            this.gbInfoEmp.SuspendLayout();
            this.gbInfoEmpEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterSpec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterSpecializationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(94, 40);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(177, 40);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Location = new System.Drawing.Point(12, 92);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(53, 13);
            this.lblEmployees.TabIndex = 3;
            this.lblEmployees.Text = "Мастеры";
            // 
            // dgvMaster
            // 
            this.dgvMaster.AutoGenerateColumns = false;
            this.dgvMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idempDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn});
            this.dgvMaster.DataSource = this.masterBindingSource;
            this.dgvMaster.EnableHeadersVisualStyles = false;
            this.dgvMaster.Location = new System.Drawing.Point(12, 142);
            this.dgvMaster.Name = "dgvMaster";
            this.dgvMaster.RowHeadersVisible = false;
            this.dgvMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaster.Size = new System.Drawing.Size(303, 132);
            this.dgvMaster.TabIndex = 4;
            this.dgvMaster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellClick);
            // 
            // idempDataGridViewTextBoxColumn
            // 
            this.idempDataGridViewTextBoxColumn.DataPropertyName = "id_emp";
            this.idempDataGridViewTextBoxColumn.HeaderText = "id_emp";
            this.idempDataGridViewTextBoxColumn.Name = "idempDataGridViewTextBoxColumn";
            this.idempDataGridViewTextBoxColumn.ReadOnly = true;
            this.idempDataGridViewTextBoxColumn.Visible = false;
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            // 
            // masterBindingSource
            // 
            this.masterBindingSource.DataMember = "Employee";
            this.masterBindingSource.DataSource = this.spDataSet;
            this.masterBindingSource.Filter = "job=\'Мастер\'";
            // 
            // spDataSet
            // 
            this.spDataSet.DataSetName = "SPDataSet";
            this.spDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbInfoEmp
            // 
            this.gbInfoEmp.Controls.Add(this.lblAddress);
            this.gbInfoEmp.Controls.Add(this.tbAddress);
            this.gbInfoEmp.Controls.Add(this.tbStatus);
            this.gbInfoEmp.Controls.Add(this.tbPhone);
            this.gbInfoEmp.Controls.Add(this.lblStatus);
            this.gbInfoEmp.Controls.Add(this.lblPhone);
            this.gbInfoEmp.Location = new System.Drawing.Point(321, 12);
            this.gbInfoEmp.Name = "gbInfoEmp";
            this.gbInfoEmp.Size = new System.Drawing.Size(182, 124);
            this.gbInfoEmp.TabIndex = 5;
            this.gbInfoEmp.TabStop = false;
            this.gbInfoEmp.Text = "Общая информация о мастере";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 64);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(38, 13);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Адрес";
            // 
            // tbAddress
            // 
            this.tbAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.masterBindingSource, "address", true));
            this.tbAddress.Location = new System.Drawing.Point(76, 68);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 20);
            this.tbAddress.TabIndex = 8;
            // 
            // tbStatus
            // 
            this.tbStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.masterBindingSource, "status", true));
            this.tbStatus.Location = new System.Drawing.Point(76, 94);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(100, 20);
            this.tbStatus.TabIndex = 5;
            // 
            // tbPhone
            // 
            this.tbPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.masterBindingSource, "phone", true));
            this.tbPhone.Location = new System.Drawing.Point(76, 42);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(100, 20);
            this.tbPhone.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(7, 90);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Статус";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(7, 42);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 13);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Телефон";
            // 
            // gbInfoEmpEntry
            // 
            this.gbInfoEmpEntry.Controls.Add(this.tbPass);
            this.gbInfoEmpEntry.Controls.Add(this.tbLogin);
            this.gbInfoEmpEntry.Controls.Add(this.lblPass);
            this.gbInfoEmpEntry.Controls.Add(this.lblLogin);
            this.gbInfoEmpEntry.Location = new System.Drawing.Point(509, 12);
            this.gbInfoEmpEntry.Name = "gbInfoEmpEntry";
            this.gbInfoEmpEntry.Size = new System.Drawing.Size(200, 110);
            this.gbInfoEmpEntry.TabIndex = 6;
            this.gbInfoEmpEntry.TabStop = false;
            this.gbInfoEmpEntry.Text = "Информация для входа в систему";
            // 
            // tbPass
            // 
            this.tbPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.masterBindingSource, "pass", true));
            this.tbPass.Location = new System.Drawing.Point(80, 70);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(100, 20);
            this.tbPass.TabIndex = 7;
            // 
            // tbLogin
            // 
            this.tbLogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.masterBindingSource, "login", true));
            this.tbLogin.Location = new System.Drawing.Point(80, 39);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(100, 20);
            this.tbLogin.TabIndex = 6;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(25, 73);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(45, 13);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Пароль";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(25, 42);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(38, 13);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Логин";
            // 
            // dgvMasterSpec
            // 
            this.dgvMasterSpec.AutoGenerateColumns = false;
            this.dgvMasterSpec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMasterSpec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasterSpec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmasterDataGridViewTextBoxColumn,
            this.idspecDataGridViewTextBoxColumn,
            this.namespecDataGridViewTextBoxColumn,
            this.charspecDataGridViewTextBoxColumn});
            this.dgvMasterSpec.DataSource = this.masterSpecializationBindingSource;
            this.dgvMasterSpec.EnableHeadersVisualStyles = false;
            this.dgvMasterSpec.Location = new System.Drawing.Point(321, 142);
            this.dgvMasterSpec.Name = "dgvMasterSpec";
            this.dgvMasterSpec.RowHeadersVisible = false;
            this.dgvMasterSpec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMasterSpec.Size = new System.Drawing.Size(388, 132);
            this.dgvMasterSpec.TabIndex = 7;
            this.dgvMasterSpec.Tag = "";
            // 
            // idmasterDataGridViewTextBoxColumn
            // 
            this.idmasterDataGridViewTextBoxColumn.DataPropertyName = "id_master";
            this.idmasterDataGridViewTextBoxColumn.HeaderText = "id_master";
            this.idmasterDataGridViewTextBoxColumn.Name = "idmasterDataGridViewTextBoxColumn";
            this.idmasterDataGridViewTextBoxColumn.Visible = false;
            // 
            // idspecDataGridViewTextBoxColumn
            // 
            this.idspecDataGridViewTextBoxColumn.DataPropertyName = "id_spec";
            this.idspecDataGridViewTextBoxColumn.HeaderText = "id_spec";
            this.idspecDataGridViewTextBoxColumn.Name = "idspecDataGridViewTextBoxColumn";
            this.idspecDataGridViewTextBoxColumn.Visible = false;
            // 
            // namespecDataGridViewTextBoxColumn
            // 
            this.namespecDataGridViewTextBoxColumn.DataPropertyName = "name_spec";
            this.namespecDataGridViewTextBoxColumn.HeaderText = "Название специальности";
            this.namespecDataGridViewTextBoxColumn.Name = "namespecDataGridViewTextBoxColumn";
            // 
            // charspecDataGridViewTextBoxColumn
            // 
            this.charspecDataGridViewTextBoxColumn.DataPropertyName = "char_spec";
            this.charspecDataGridViewTextBoxColumn.HeaderText = "Характеристика";
            this.charspecDataGridViewTextBoxColumn.Name = "charspecDataGridViewTextBoxColumn";
            // 
            // masterSpecializationBindingSource
            // 
            this.masterSpecializationBindingSource.DataMember = "MasterSpecialization";
            this.masterSpecializationBindingSource.DataSource = this.spDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // masterSpecializationTableAdapter
            // 
            this.masterSpecializationTableAdapter.ClearBeforeFill = true;
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 294);
            this.Controls.Add(this.dgvMasterSpec);
            this.Controls.Add(this.gbInfoEmpEntry);
            this.Controls.Add(this.gbInfoEmp);
            this.Controls.Add(this.dgvMaster);
            this.Controls.Add(this.lblEmployees);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "MasterForm";
            this.Text = "Мастеры";
            this.Load += new System.EventHandler(this.MasterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).EndInit();
            this.gbInfoEmp.ResumeLayout(false);
            this.gbInfoEmp.PerformLayout();
            this.gbInfoEmpEntry.ResumeLayout(false);
            this.gbInfoEmpEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterSpec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterSpecializationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.DataGridView dgvMaster;
        private System.Windows.Forms.GroupBox gbInfoEmp;
        private System.Windows.Forms.GroupBox gbInfoEmpEntry;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.DataGridView dgvMasterSpec;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbAddress;
        private SPDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private SPDataSet spDataSet;
        private System.Windows.Forms.BindingSource masterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private SPDataSetTableAdapters.MasterSpecializationTableAdapter masterSpecializationTableAdapter;
        private System.Windows.Forms.BindingSource masterSpecializationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmasterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idspecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namespecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn charspecDataGridViewTextBoxColumn;
    }
}