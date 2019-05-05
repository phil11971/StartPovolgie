namespace StartPovolgie.Forms
{
    partial class RegistryAcceptForRepairForm
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
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.rbStatus = new System.Windows.Forms.RadioButton();
            this.rbReceiptDate = new System.Windows.Forms.RadioButton();
            this.dtPickerPo = new System.Windows.Forms.DateTimePicker();
            this.lblPo = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.dtPickerS = new System.Windows.Forms.DateTimePicker();
            this.gbFind = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.rbLastName = new System.Windows.Forms.RadioButton();
            this.rbPhone = new System.Windows.Forms.RadioButton();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.dgvAccept = new System.Windows.Forms.DataGridView();
            this.registryAcceptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spDataSet = new StartPovolgie.SPDataSet();
            this.registryAcceptTableAdapter = new StartPovolgie.SPDataSetTableAdapters.RegistryAcceptTableAdapter();
            this.idacceptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFilter.SuspendLayout();
            this.gbFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registryAcceptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnCancel);
            this.gbFilter.Controls.Add(this.cmbStatus);
            this.gbFilter.Controls.Add(this.rbStatus);
            this.gbFilter.Controls.Add(this.rbReceiptDate);
            this.gbFilter.Controls.Add(this.dtPickerPo);
            this.gbFilter.Controls.Add(this.lblPo);
            this.gbFilter.Controls.Add(this.lblS);
            this.gbFilter.Controls.Add(this.dtPickerS);
            this.gbFilter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbFilter.Location = new System.Drawing.Point(12, 12);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(396, 149);
            this.gbFilter.TabIndex = 12;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Фильтрация списка";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(226, 106);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Снять фильтр";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Принято на ремонт",
            "Отремонтировано",
            "Завершена"});
            this.cmbStatus.Location = new System.Drawing.Point(27, 103);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(191, 26);
            this.cmbStatus.TabIndex = 18;
            // 
            // rbStatus
            // 
            this.rbStatus.AutoSize = true;
            this.rbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rbStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbStatus.Location = new System.Drawing.Point(11, 74);
            this.rbStatus.Name = "rbStatus";
            this.rbStatus.Size = new System.Drawing.Size(85, 21);
            this.rbStatus.TabIndex = 17;
            this.rbStatus.Text = "по статусу";
            this.rbStatus.UseVisualStyleBackColor = true;
            // 
            // rbReceiptDate
            // 
            this.rbReceiptDate.AutoSize = true;
            this.rbReceiptDate.Checked = true;
            this.rbReceiptDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbReceiptDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbReceiptDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbReceiptDate.Location = new System.Drawing.Point(11, 19);
            this.rbReceiptDate.Name = "rbReceiptDate";
            this.rbReceiptDate.Size = new System.Drawing.Size(119, 21);
            this.rbReceiptDate.TabIndex = 16;
            this.rbReceiptDate.TabStop = true;
            this.rbReceiptDate.Text = "по дате приема";
            this.rbReceiptDate.UseVisualStyleBackColor = true;
            // 
            // dtPickerPo
            // 
            this.dtPickerPo.CalendarFont = new System.Drawing.Font("Segoe UI", 11F);
            this.dtPickerPo.Checked = false;
            this.dtPickerPo.CustomFormat = "dd-MM-yyyy";
            this.dtPickerPo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtPickerPo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerPo.Location = new System.Drawing.Point(226, 42);
            this.dtPickerPo.MinDate = new System.DateTime(2007, 1, 1, 0, 0, 0, 0);
            this.dtPickerPo.Name = "dtPickerPo";
            this.dtPickerPo.Size = new System.Drawing.Size(156, 27);
            this.dtPickerPo.TabIndex = 9;
            this.dtPickerPo.Value = new System.DateTime(2017, 5, 16, 22, 30, 59, 0);
            // 
            // lblPo
            // 
            this.lblPo.AutoSize = true;
            this.lblPo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPo.Location = new System.Drawing.Point(193, 46);
            this.lblPo.Name = "lblPo";
            this.lblPo.Size = new System.Drawing.Size(27, 20);
            this.lblPo.TabIndex = 11;
            this.lblPo.Text = "по";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblS.Location = new System.Drawing.Point(7, 46);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(16, 20);
            this.lblS.TabIndex = 10;
            this.lblS.Text = "с";
            // 
            // dtPickerS
            // 
            this.dtPickerS.CalendarFont = new System.Drawing.Font("Segoe UI", 11F);
            this.dtPickerS.Checked = false;
            this.dtPickerS.CustomFormat = "dd-MM-yyyy";
            this.dtPickerS.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtPickerS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerS.Location = new System.Drawing.Point(29, 42);
            this.dtPickerS.MinDate = new System.DateTime(2007, 1, 1, 0, 0, 0, 0);
            this.dtPickerS.Name = "dtPickerS";
            this.dtPickerS.Size = new System.Drawing.Size(158, 27);
            this.dtPickerS.TabIndex = 8;
            this.dtPickerS.Value = new System.DateTime(2017, 5, 16, 22, 30, 59, 0);
            // 
            // gbFind
            // 
            this.gbFind.Controls.Add(this.btnFind);
            this.gbFind.Controls.Add(this.mtbPhone);
            this.gbFind.Controls.Add(this.rbLastName);
            this.gbFind.Controls.Add(this.rbPhone);
            this.gbFind.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbFind.Location = new System.Drawing.Point(414, 12);
            this.gbFind.Name = "gbFind";
            this.gbFind.Size = new System.Drawing.Size(374, 149);
            this.gbFind.TabIndex = 17;
            this.gbFind.TabStop = false;
            this.gbFind.Text = "Поиск";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(255, 107);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(113, 23);
            this.btnFind.TabIndex = 20;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // mtbPhone
            // 
            this.mtbPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbPhone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.mtbPhone.Location = new System.Drawing.Point(13, 103);
            this.mtbPhone.Mask = "8(999)000-00-00";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(226, 27);
            this.mtbPhone.TabIndex = 25;
            // 
            // rbLastName
            // 
            this.rbLastName.AutoSize = true;
            this.rbLastName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.rbLastName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbLastName.Location = new System.Drawing.Point(9, 59);
            this.rbLastName.Name = "rbLastName";
            this.rbLastName.Size = new System.Drawing.Size(104, 20);
            this.rbLastName.TabIndex = 21;
            this.rbLastName.TabStop = true;
            this.rbLastName.Text = "по фамилии";
            this.rbLastName.UseVisualStyleBackColor = true;
            // 
            // rbPhone
            // 
            this.rbPhone.AutoSize = true;
            this.rbPhone.Checked = true;
            this.rbPhone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rbPhone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbPhone.Location = new System.Drawing.Point(9, 33);
            this.rbPhone.Name = "rbPhone";
            this.rbPhone.Size = new System.Drawing.Size(162, 20);
            this.rbPhone.TabIndex = 20;
            this.rbPhone.TabStop = true;
            this.rbPhone.Text = "по номеру телефона";
            this.rbPhone.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(12, 167);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(113, 34);
            this.btnAccept.TabIndex = 18;
            this.btnAccept.Text = "Прием в ремонт";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(131, 167);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(113, 34);
            this.btnDetail.TabIndex = 19;
            this.btnDetail.Text = "Просмотр приема в ремонт";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(250, 167);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(113, 34);
            this.btnDel.TabIndex = 20;
            this.btnDel.Text = "Удалить прием в ремонт";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dgvAccept
            // 
            this.dgvAccept.AutoGenerateColumns = false;
            this.dgvAccept.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccept.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAccept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccept.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idacceptDataGridViewTextBoxColumn,
            this.receiptdateDataGridViewTextBoxColumn,
            this.issuedateDataGridViewTextBoxColumn,
            this.idadminDataGridViewTextBoxColumn,
            this.adminFullNameDataGridViewTextBoxColumn,
            this.idgDataGridViewTextBoxColumn,
            this.namegDataGridViewTextBoxColumn,
            this.idclientDataGridViewTextBoxColumn,
            this.clientFullNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dgvAccept.DataSource = this.registryAcceptBindingSource;
            this.dgvAccept.EnableHeadersVisualStyles = false;
            this.dgvAccept.Location = new System.Drawing.Point(12, 207);
            this.dgvAccept.Name = "dgvAccept";
            this.dgvAccept.RowHeadersVisible = false;
            this.dgvAccept.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccept.Size = new System.Drawing.Size(803, 231);
            this.dgvAccept.TabIndex = 21;
            // 
            // registryAcceptBindingSource
            // 
            this.registryAcceptBindingSource.DataMember = "RegistryAccept";
            this.registryAcceptBindingSource.DataSource = this.spDataSet;
            // 
            // spDataSet
            // 
            this.spDataSet.DataSetName = "SPDataSet";
            this.spDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registryAcceptTableAdapter
            // 
            this.registryAcceptTableAdapter.ClearBeforeFill = true;
            // 
            // idacceptDataGridViewTextBoxColumn
            // 
            this.idacceptDataGridViewTextBoxColumn.DataPropertyName = "id_accept";
            this.idacceptDataGridViewTextBoxColumn.HeaderText = "Номер заявки";
            this.idacceptDataGridViewTextBoxColumn.Name = "idacceptDataGridViewTextBoxColumn";
            // 
            // receiptdateDataGridViewTextBoxColumn
            // 
            this.receiptdateDataGridViewTextBoxColumn.DataPropertyName = "receipt_date";
            this.receiptdateDataGridViewTextBoxColumn.HeaderText = "Дата приёма";
            this.receiptdateDataGridViewTextBoxColumn.Name = "receiptdateDataGridViewTextBoxColumn";
            // 
            // issuedateDataGridViewTextBoxColumn
            // 
            this.issuedateDataGridViewTextBoxColumn.DataPropertyName = "issue_date";
            this.issuedateDataGridViewTextBoxColumn.HeaderText = "Дата выдачи";
            this.issuedateDataGridViewTextBoxColumn.Name = "issuedateDataGridViewTextBoxColumn";
            this.issuedateDataGridViewTextBoxColumn.Visible = false;
            // 
            // idadminDataGridViewTextBoxColumn
            // 
            this.idadminDataGridViewTextBoxColumn.DataPropertyName = "id_admin";
            this.idadminDataGridViewTextBoxColumn.HeaderText = "id_admin";
            this.idadminDataGridViewTextBoxColumn.Name = "idadminDataGridViewTextBoxColumn";
            this.idadminDataGridViewTextBoxColumn.Visible = false;
            // 
            // adminFullNameDataGridViewTextBoxColumn
            // 
            this.adminFullNameDataGridViewTextBoxColumn.DataPropertyName = "adminFullName";
            this.adminFullNameDataGridViewTextBoxColumn.HeaderText = "Администратор";
            this.adminFullNameDataGridViewTextBoxColumn.Name = "adminFullNameDataGridViewTextBoxColumn";
            this.adminFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idgDataGridViewTextBoxColumn
            // 
            this.idgDataGridViewTextBoxColumn.DataPropertyName = "id_g";
            this.idgDataGridViewTextBoxColumn.HeaderText = "id_g";
            this.idgDataGridViewTextBoxColumn.Name = "idgDataGridViewTextBoxColumn";
            this.idgDataGridViewTextBoxColumn.Visible = false;
            // 
            // namegDataGridViewTextBoxColumn
            // 
            this.namegDataGridViewTextBoxColumn.DataPropertyName = "name_g";
            this.namegDataGridViewTextBoxColumn.HeaderText = "Товар";
            this.namegDataGridViewTextBoxColumn.Name = "namegDataGridViewTextBoxColumn";
            // 
            // idclientDataGridViewTextBoxColumn
            // 
            this.idclientDataGridViewTextBoxColumn.DataPropertyName = "id_client";
            this.idclientDataGridViewTextBoxColumn.HeaderText = "id_client";
            this.idclientDataGridViewTextBoxColumn.Name = "idclientDataGridViewTextBoxColumn";
            this.idclientDataGridViewTextBoxColumn.Visible = false;
            // 
            // clientFullNameDataGridViewTextBoxColumn
            // 
            this.clientFullNameDataGridViewTextBoxColumn.DataPropertyName = "clientFullName";
            this.clientFullNameDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.clientFullNameDataGridViewTextBoxColumn.Name = "clientFullNameDataGridViewTextBoxColumn";
            this.clientFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // RegistryAcceptForRepairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.dgvAccept);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.gbFind);
            this.Controls.Add(this.gbFilter);
            this.Name = "RegistryAcceptForRepairForm";
            this.Text = "Реестр приемов в ремонт";
            this.Load += new System.EventHandler(this.RegistryAcceptForRepairForm_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.gbFind.ResumeLayout(false);
            this.gbFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registryAcceptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.RadioButton rbStatus;
        private System.Windows.Forms.RadioButton rbReceiptDate;
        private System.Windows.Forms.DateTimePicker dtPickerPo;
        private System.Windows.Forms.Label lblPo;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.DateTimePicker dtPickerS;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbFind;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.RadioButton rbLastName;
        private System.Windows.Forms.RadioButton rbPhone;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dgvAccept;
        private SPDataSet spDataSet;
        private SPDataSetTableAdapters.RegistryAcceptTableAdapter registryAcceptTableAdapter;
        private System.Windows.Forms.BindingSource registryAcceptBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idacceptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}