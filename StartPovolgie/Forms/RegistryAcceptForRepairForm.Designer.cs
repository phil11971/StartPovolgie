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
            this.rbStatus = new System.Windows.Forms.RadioButton();
            this.rbReceiptDate = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPo = new System.Windows.Forms.DateTimePicker();
            this.dtpS = new System.Windows.Forms.DateTimePicker();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.gbFind = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.mtbFind = new System.Windows.Forms.MaskedTextBox();
            this.rbLastName = new System.Windows.Forms.RadioButton();
            this.rbPhone = new System.Windows.Forms.RadioButton();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.dgvAccept = new System.Windows.Forms.DataGridView();
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
            this.registryAcceptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spDataSet = new StartPovolgie.SPDataSet();
            this.registryAcceptTableAdapter = new StartPovolgie.SPDataSetTableAdapters.RegistryAcceptTableAdapter();
            this.btnApply = new System.Windows.Forms.Button();
            this.gbFilter.SuspendLayout();
            this.gbFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registryAcceptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnApply);
            this.gbFilter.Controls.Add(this.rbStatus);
            this.gbFilter.Controls.Add(this.rbReceiptDate);
            this.gbFilter.Controls.Add(this.label2);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Controls.Add(this.dtpPo);
            this.gbFilter.Controls.Add(this.dtpS);
            this.gbFilter.Controls.Add(this.cbStatus);
            this.gbFilter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbFilter.Location = new System.Drawing.Point(12, 12);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(396, 149);
            this.gbFilter.TabIndex = 12;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Фильтрация списка";
            // 
            // rbStatus
            // 
            this.rbStatus.AutoSize = true;
            this.rbStatus.Location = new System.Drawing.Point(217, 19);
            this.rbStatus.Name = "rbStatus";
            this.rbStatus.Size = new System.Drawing.Size(78, 17);
            this.rbStatus.TabIndex = 26;
            this.rbStatus.TabStop = true;
            this.rbStatus.Text = "по статусу";
            this.rbStatus.UseVisualStyleBackColor = true;
            this.rbStatus.CheckedChanged += new System.EventHandler(this.rbStatus_CheckedChanged);
            // 
            // rbReceiptDate
            // 
            this.rbReceiptDate.AutoSize = true;
            this.rbReceiptDate.Checked = true;
            this.rbReceiptDate.Location = new System.Drawing.Point(13, 19);
            this.rbReceiptDate.Name = "rbReceiptDate";
            this.rbReceiptDate.Size = new System.Drawing.Size(104, 17);
            this.rbReceiptDate.TabIndex = 25;
            this.rbReceiptDate.TabStop = true;
            this.rbReceiptDate.Text = "по дате приема";
            this.rbReceiptDate.UseVisualStyleBackColor = true;
            this.rbReceiptDate.CheckedChanged += new System.EventHandler(this.rbReceiptDate_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "по";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "с";
            // 
            // dtpPo
            // 
            this.dtpPo.Checked = false;
            this.dtpPo.CustomFormat = "dd-MM-yyyy";
            this.dtpPo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPo.Location = new System.Drawing.Point(29, 92);
            this.dtpPo.MinDate = new System.DateTime(2015, 12, 24, 0, 0, 0, 0);
            this.dtpPo.Name = "dtpPo";
            this.dtpPo.Size = new System.Drawing.Size(158, 20);
            this.dtpPo.TabIndex = 22;
            // 
            // dtpS
            // 
            this.dtpS.Checked = false;
            this.dtpS.CustomFormat = "dd-MM-yyyy";
            this.dtpS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpS.Location = new System.Drawing.Point(29, 46);
            this.dtpS.MinDate = new System.DateTime(2015, 12, 24, 0, 0, 0, 0);
            this.dtpS.Name = "dtpS";
            this.dtpS.Size = new System.Drawing.Size(158, 20);
            this.dtpS.TabIndex = 21;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(217, 44);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(158, 21);
            this.cbStatus.TabIndex = 20;
            this.cbStatus.Tag = "";
            // 
            // gbFind
            // 
            this.gbFind.Controls.Add(this.btnCancel);
            this.gbFind.Controls.Add(this.mtbFind);
            this.gbFind.Controls.Add(this.rbLastName);
            this.gbFind.Controls.Add(this.rbPhone);
            this.gbFind.Controls.Add(this.btnFind);
            this.gbFind.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbFind.Location = new System.Drawing.Point(414, 12);
            this.gbFind.Name = "gbFind";
            this.gbFind.Size = new System.Drawing.Size(374, 149);
            this.gbFind.TabIndex = 17;
            this.gbFind.TabStop = false;
            this.gbFind.Text = "Поиск";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(238, 106);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 23);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Снять фильтр";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // mtbFind
            // 
            this.mtbFind.Location = new System.Drawing.Point(13, 106);
            this.mtbFind.Mask = "8(000)000-00-00";
            this.mtbFind.Name = "mtbFind";
            this.mtbFind.Size = new System.Drawing.Size(100, 20);
            this.mtbFind.TabIndex = 28;
            // 
            // rbLastName
            // 
            this.rbLastName.AutoSize = true;
            this.rbLastName.Location = new System.Drawing.Point(13, 63);
            this.rbLastName.Name = "rbLastName";
            this.rbLastName.Size = new System.Drawing.Size(86, 17);
            this.rbLastName.TabIndex = 27;
            this.rbLastName.TabStop = true;
            this.rbLastName.Text = "по фамилии";
            this.rbLastName.UseVisualStyleBackColor = true;
            this.rbLastName.CheckedChanged += new System.EventHandler(this.rbLastName_CheckedChanged);
            // 
            // rbPhone
            // 
            this.rbPhone.AutoSize = true;
            this.rbPhone.Checked = true;
            this.rbPhone.Location = new System.Drawing.Point(13, 28);
            this.rbPhone.Name = "rbPhone";
            this.rbPhone.Size = new System.Drawing.Size(88, 17);
            this.rbPhone.TabIndex = 26;
            this.rbPhone.TabStop = true;
            this.rbPhone.Text = "по телефону";
            this.rbPhone.UseVisualStyleBackColor = true;
            this.rbPhone.CheckedChanged += new System.EventHandler(this.rbPhone_CheckedChanged);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(119, 106);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(113, 23);
            this.btnFind.TabIndex = 20;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
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
            // idacceptDataGridViewTextBoxColumn
            // 
            this.idacceptDataGridViewTextBoxColumn.DataPropertyName = "id_accept";
            this.idacceptDataGridViewTextBoxColumn.HeaderText = "Номер приёма";
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
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(262, 104);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(113, 23);
            this.btnApply.TabIndex = 29;
            this.btnApply.Text = "Применить";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
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
        private System.Windows.Forms.GroupBox gbFind;
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
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.DateTimePicker dtpS;
        private System.Windows.Forms.DateTimePicker dtpPo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbStatus;
        private System.Windows.Forms.RadioButton rbReceiptDate;
        private System.Windows.Forms.RadioButton rbLastName;
        private System.Windows.Forms.RadioButton rbPhone;
        private System.Windows.Forms.MaskedTextBox mtbFind;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
    }
}