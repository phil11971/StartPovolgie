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
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.rbStatus = new System.Windows.Forms.RadioButton();
            this.rbDateOfAcceptance = new System.Windows.Forms.RadioButton();
            this.dtPickerPo = new System.Windows.Forms.DateTimePicker();
            this.lblPo = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.dtPickerS = new System.Windows.Forms.DateTimePicker();
            this.gbFind = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.rbtnName = new System.Windows.Forms.RadioButton();
            this.rbtnPhone = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvtbcNumberAccept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcGood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcAcceptDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFilter.SuspendLayout();
            this.gbFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.button1);
            this.gbFilter.Controls.Add(this.cmbStatus);
            this.gbFilter.Controls.Add(this.rbStatus);
            this.gbFilter.Controls.Add(this.rbDateOfAcceptance);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Снять фильтр";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            // rbDateOfAcceptance
            // 
            this.rbDateOfAcceptance.AutoSize = true;
            this.rbDateOfAcceptance.Checked = true;
            this.rbDateOfAcceptance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbDateOfAcceptance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbDateOfAcceptance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbDateOfAcceptance.Location = new System.Drawing.Point(11, 19);
            this.rbDateOfAcceptance.Name = "rbDateOfAcceptance";
            this.rbDateOfAcceptance.Size = new System.Drawing.Size(119, 21);
            this.rbDateOfAcceptance.TabIndex = 16;
            this.rbDateOfAcceptance.TabStop = true;
            this.rbDateOfAcceptance.Text = "по дате приема";
            this.rbDateOfAcceptance.UseVisualStyleBackColor = true;
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
            this.gbFind.Controls.Add(this.button2);
            this.gbFind.Controls.Add(this.mtbPhone);
            this.gbFind.Controls.Add(this.rbtnName);
            this.gbFind.Controls.Add(this.rbtnPhone);
            this.gbFind.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbFind.Location = new System.Drawing.Point(414, 12);
            this.gbFind.Name = "gbFind";
            this.gbFind.Size = new System.Drawing.Size(374, 149);
            this.gbFind.TabIndex = 17;
            this.gbFind.TabStop = false;
            this.gbFind.Text = "Поиск";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Найти";
            this.button2.UseVisualStyleBackColor = true;
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
            // rbtnName
            // 
            this.rbtnName.AutoSize = true;
            this.rbtnName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbtnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.rbtnName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnName.Location = new System.Drawing.Point(9, 59);
            this.rbtnName.Name = "rbtnName";
            this.rbtnName.Size = new System.Drawing.Size(104, 20);
            this.rbtnName.TabIndex = 21;
            this.rbtnName.TabStop = true;
            this.rbtnName.Text = "по фамилии";
            this.rbtnName.UseVisualStyleBackColor = true;
            // 
            // rbtnPhone
            // 
            this.rbtnPhone.AutoSize = true;
            this.rbtnPhone.Checked = true;
            this.rbtnPhone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbtnPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rbtnPhone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnPhone.Location = new System.Drawing.Point(9, 33);
            this.rbtnPhone.Name = "rbtnPhone";
            this.rbtnPhone.Size = new System.Drawing.Size(162, 20);
            this.rbtnPhone.TabIndex = 20;
            this.rbtnPhone.TabStop = true;
            this.rbtnPhone.Text = "по номеру телефона";
            this.rbtnPhone.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 34);
            this.button3.TabIndex = 18;
            this.button3.Text = "Прием в ремонт";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(131, 167);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 34);
            this.button4.TabIndex = 19;
            this.button4.Text = "Просмотр приема в ремонт";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(250, 167);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 34);
            this.button5.TabIndex = 20;
            this.button5.Text = "Удалить прием в ремонт";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcNumberAccept,
            this.dgvtbcGood,
            this.dgvtbcClient,
            this.dgvtbcPhone,
            this.dgvtbcAddress,
            this.dgvtbcAcceptDate,
            this.dgvtbcDeliveryDate,
            this.dgvtbcStatus,
            this.dgvtbcAdmin});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(803, 231);
            this.dataGridView1.TabIndex = 21;
            // 
            // dgvtbcNumberAccept
            // 
            this.dgvtbcNumberAccept.HeaderText = "Номер заявки";
            this.dgvtbcNumberAccept.Name = "dgvtbcNumberAccept";
            this.dgvtbcNumberAccept.ReadOnly = true;
            // 
            // dgvtbcGood
            // 
            this.dgvtbcGood.HeaderText = "Товар";
            this.dgvtbcGood.Name = "dgvtbcGood";
            this.dgvtbcGood.ReadOnly = true;
            // 
            // dgvtbcClient
            // 
            this.dgvtbcClient.HeaderText = "Физическое лицо";
            this.dgvtbcClient.Name = "dgvtbcClient";
            this.dgvtbcClient.ReadOnly = true;
            // 
            // dgvtbcPhone
            // 
            this.dgvtbcPhone.HeaderText = "Телефон";
            this.dgvtbcPhone.Name = "dgvtbcPhone";
            this.dgvtbcPhone.ReadOnly = true;
            // 
            // dgvtbcAddress
            // 
            this.dgvtbcAddress.HeaderText = "Адрес";
            this.dgvtbcAddress.Name = "dgvtbcAddress";
            this.dgvtbcAddress.ReadOnly = true;
            // 
            // dgvtbcAcceptDate
            // 
            this.dgvtbcAcceptDate.HeaderText = "Дата приема";
            this.dgvtbcAcceptDate.Name = "dgvtbcAcceptDate";
            this.dgvtbcAcceptDate.ReadOnly = true;
            // 
            // dgvtbcDeliveryDate
            // 
            this.dgvtbcDeliveryDate.HeaderText = "Дата выдачи";
            this.dgvtbcDeliveryDate.Name = "dgvtbcDeliveryDate";
            this.dgvtbcDeliveryDate.ReadOnly = true;
            // 
            // dgvtbcStatus
            // 
            this.dgvtbcStatus.HeaderText = "Статус";
            this.dgvtbcStatus.Name = "dgvtbcStatus";
            this.dgvtbcStatus.ReadOnly = true;
            // 
            // dgvtbcAdmin
            // 
            this.dgvtbcAdmin.HeaderText = "Администратор";
            this.dgvtbcAdmin.Name = "dgvtbcAdmin";
            this.dgvtbcAdmin.ReadOnly = true;
            // 
            // RegistryAcceptForRepairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.gbFind);
            this.Controls.Add(this.gbFilter);
            this.Name = "RegistryAcceptForRepairForm";
            this.Text = "Реестр приемов в ремонт";
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.gbFind.ResumeLayout(false);
            this.gbFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.RadioButton rbStatus;
        private System.Windows.Forms.RadioButton rbDateOfAcceptance;
        private System.Windows.Forms.DateTimePicker dtPickerPo;
        private System.Windows.Forms.Label lblPo;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.DateTimePicker dtPickerS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbFind;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.RadioButton rbtnName;
        private System.Windows.Forms.RadioButton rbtnPhone;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNumberAccept;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcGood;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcAcceptDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcAdmin;
    }
}