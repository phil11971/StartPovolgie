﻿namespace StartPovolgie.Forms
{
    partial class AddMasterForm
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
            this.lblAdd = new System.Windows.Forms.Label();
            this.gbInfoEmp = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPatronymic = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.gbInfoEmpEntry = new System.Windows.Forms.GroupBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvMasterSpecialization = new System.Windows.Forms.DataGridView();
            this.dgvcbcNameSpec = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.specializationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spDataSet = new StartPovolgie.SPDataSet();
            this.dgvtbcDescSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationTableAdapter = new StartPovolgie.SPDataSetTableAdapters.SpecializationTableAdapter();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.gbInfoEmp.SuspendLayout();
            this.gbInfoEmpEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterSpecialization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(28, 13);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(154, 13);
            this.lblAdd.TabIndex = 0;
            this.lblAdd.Text = "Добавление нового мастера";
            // 
            // gbInfoEmp
            // 
            this.gbInfoEmp.Controls.Add(this.mtbPhone);
            this.gbInfoEmp.Controls.Add(this.label1);
            this.gbInfoEmp.Controls.Add(this.tbAddress);
            this.gbInfoEmp.Controls.Add(this.cbStatus);
            this.gbInfoEmp.Controls.Add(this.tbPatronymic);
            this.gbInfoEmp.Controls.Add(this.tbFirstName);
            this.gbInfoEmp.Controls.Add(this.tbLastName);
            this.gbInfoEmp.Controls.Add(this.lblStatus);
            this.gbInfoEmp.Controls.Add(this.lblPhone);
            this.gbInfoEmp.Controls.Add(this.lblPatronymic);
            this.gbInfoEmp.Controls.Add(this.lblFirstName);
            this.gbInfoEmp.Controls.Add(this.lblLastName);
            this.gbInfoEmp.Location = new System.Drawing.Point(31, 45);
            this.gbInfoEmp.Name = "gbInfoEmp";
            this.gbInfoEmp.Size = new System.Drawing.Size(254, 215);
            this.gbInfoEmp.TabIndex = 1;
            this.gbInfoEmp.TabStop = false;
            this.gbInfoEmp.Text = "Общая информация о мастере";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Адрес";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(95, 185);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(121, 20);
            this.tbAddress.TabIndex = 16;
            // 
            // cbStatus
            // 
            this.cbStatus.DisplayMember = "Работает";
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Работает",
            "Не работает",
            "В отпуске"});
            this.cbStatus.Location = new System.Drawing.Point(95, 158);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 13;
            this.cbStatus.Tag = "Работает";
            this.cbStatus.ValueMember = "Работает";
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Location = new System.Drawing.Point(95, 96);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(121, 20);
            this.tbPatronymic.TabIndex = 8;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(95, 61);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(121, 20);
            this.tbFirstName.TabIndex = 7;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(95, 32);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(121, 20);
            this.tbLastName.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 161);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Статус";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(20, 135);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 13);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Телефон";
            // 
            // lblPatronymic
            // 
            this.lblPatronymic.AutoSize = true;
            this.lblPatronymic.Location = new System.Drawing.Point(20, 103);
            this.lblPatronymic.Name = "lblPatronymic";
            this.lblPatronymic.Size = new System.Drawing.Size(54, 13);
            this.lblPatronymic.TabIndex = 2;
            this.lblPatronymic.Text = "Отчество";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(20, 68);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(29, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Имя";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(20, 32);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 13);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Фамилия";
            // 
            // gbInfoEmpEntry
            // 
            this.gbInfoEmpEntry.Controls.Add(this.tbPass);
            this.gbInfoEmpEntry.Controls.Add(this.tbLogin);
            this.gbInfoEmpEntry.Controls.Add(this.lblPass);
            this.gbInfoEmpEntry.Controls.Add(this.lblLogin);
            this.gbInfoEmpEntry.Location = new System.Drawing.Point(31, 266);
            this.gbInfoEmpEntry.Name = "gbInfoEmpEntry";
            this.gbInfoEmpEntry.Size = new System.Drawing.Size(254, 99);
            this.gbInfoEmpEntry.TabIndex = 2;
            this.gbInfoEmpEntry.TabStop = false;
            this.gbInfoEmpEntry.Text = "Информация для входа в систему";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(95, 61);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(121, 20);
            this.tbPass.TabIndex = 14;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(95, 25);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(121, 20);
            this.tbLogin.TabIndex = 12;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(16, 61);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(45, 13);
            this.lblPass.TabIndex = 13;
            this.lblPass.Text = "Пароль";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(16, 32);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(38, 13);
            this.lblLogin.TabIndex = 12;
            this.lblLogin.Text = "Логин";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(209, 372);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvMasterSpecialization
            // 
            this.dgvMasterSpecialization.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMasterSpecialization.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMasterSpecialization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasterSpecialization.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcbcNameSpec,
            this.dgvtbcDescSpec});
            this.dgvMasterSpecialization.EnableHeadersVisualStyles = false;
            this.dgvMasterSpecialization.Location = new System.Drawing.Point(301, 49);
            this.dgvMasterSpecialization.Name = "dgvMasterSpecialization";
            this.dgvMasterSpecialization.RowHeadersVisible = false;
            this.dgvMasterSpecialization.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMasterSpecialization.Size = new System.Drawing.Size(320, 316);
            this.dgvMasterSpecialization.TabIndex = 4;
            // 
            // dgvcbcNameSpec
            // 
            this.dgvcbcNameSpec.DataSource = this.specializationBindingSource;
            this.dgvcbcNameSpec.DisplayMember = "name_spec";
            this.dgvcbcNameSpec.HeaderText = "Название специализации";
            this.dgvcbcNameSpec.Name = "dgvcbcNameSpec";
            this.dgvcbcNameSpec.ValueMember = "id_spec";
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
            // dgvtbcDescSpec
            // 
            this.dgvtbcDescSpec.HeaderText = "Характеристика";
            this.dgvtbcDescSpec.Name = "dgvtbcDescSpec";
            // 
            // specializationTableAdapter
            // 
            this.specializationTableAdapter.ClearBeforeFill = true;
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(95, 128);
            this.mtbPhone.Mask = "8(000)000-00-00";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(121, 20);
            this.mtbPhone.TabIndex = 18;
            // 
            // AddMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 401);
            this.Controls.Add(this.dgvMasterSpecialization);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbInfoEmpEntry);
            this.Controls.Add(this.gbInfoEmp);
            this.Controls.Add(this.lblAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddMasterForm";
            this.Text = "Добавление нового мастера";
            this.gbInfoEmp.ResumeLayout(false);
            this.gbInfoEmp.PerformLayout();
            this.gbInfoEmpEntry.ResumeLayout(false);
            this.gbInfoEmpEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterSpecialization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.GroupBox gbInfoEmp;
        private System.Windows.Forms.GroupBox gbInfoEmpEntry;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPatronymic;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.DataGridView dgvMasterSpecialization;
        private System.Windows.Forms.BindingSource specializationBindingSource;
        private SPDataSet spDataSet;
        private SPDataSetTableAdapters.SpecializationTableAdapter specializationTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcbcNameSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDescSpec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
    }
}