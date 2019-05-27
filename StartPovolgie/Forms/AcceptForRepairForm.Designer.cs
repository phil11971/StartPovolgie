namespace StartPovolgie.Forms
{
    partial class AcceptForRepairForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpReceiptDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbComment = new System.Windows.Forms.RichTextBox();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddGood = new System.Windows.Forms.Button();
            this.dgvGood = new System.Windows.Forms.DataGridView();
            this.idgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.typeGoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spDataSet = new StartPovolgie.SPDataSet();
            this.goodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rtbMechanicalDamage = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbEquipment = new System.Windows.Forms.RichTextBox();
            this.gbFind = new System.Windows.Forms.GroupBox();
            this.btnCancelGood = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnFindGood = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvFault = new System.Windows.Forms.DataGridView();
            this.dgvtbcNameFault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDescFault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faultStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.faultStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.idclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnCancelClient = new System.Windows.Forms.Button();
            this.mtbFind = new System.Windows.Forms.MaskedTextBox();
            this.rbPhone = new System.Windows.Forms.RadioButton();
            this.btnFindClient = new System.Windows.Forms.Button();
            this.rbLastName = new System.Windows.Forms.RadioButton();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.goodTableAdapter = new StartPovolgie.SPDataSetTableAdapters.GoodTableAdapter();
            this.typeGoodTableAdapter = new StartPovolgie.SPDataSetTableAdapters.TypeGoodTableAdapter();
            this.clientTableAdapter = new StartPovolgie.SPDataSetTableAdapters.ClientTableAdapter();
            this.faultStatusTableAdapter = new StartPovolgie.SPDataSetTableAdapters.FaultStatusTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeGoodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).BeginInit();
            this.gbFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultStatusBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата приема";
            // 
            // dtpReceiptDate
            // 
            this.dtpReceiptDate.Location = new System.Drawing.Point(99, 12);
            this.dtpReceiptDate.Name = "dtpReceiptDate";
            this.dtpReceiptDate.Size = new System.Drawing.Size(185, 20);
            this.dtpReceiptDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Комментарий";
            // 
            // rtbComment
            // 
            this.rtbComment.Location = new System.Drawing.Point(99, 43);
            this.rtbComment.Name = "rtbComment";
            this.rtbComment.Size = new System.Drawing.Size(185, 60);
            this.rtbComment.TabIndex = 3;
            this.rtbComment.Text = "";
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(290, 43);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(113, 23);
            this.btnIssue.TabIndex = 4;
            this.btnIssue.Text = "Оформить";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(290, 80);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(113, 23);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Печать";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 109);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 370);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAddGood);
            this.tabPage1.Controls.Add(this.dgvGood);
            this.tabPage1.Controls.Add(this.rtbMechanicalDamage);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.rtbEquipment);
            this.tabPage1.Controls.Add(this.gbFind);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dgvFault);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(673, 344);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Информация об устройстве";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddGood
            // 
            this.btnAddGood.Location = new System.Drawing.Point(9, 6);
            this.btnAddGood.Name = "btnAddGood";
            this.btnAddGood.Size = new System.Drawing.Size(100, 23);
            this.btnAddGood.TabIndex = 12;
            this.btnAddGood.Text = "Добавить товар";
            this.btnAddGood.UseVisualStyleBackColor = true;
            this.btnAddGood.Click += new System.EventHandler(this.btnAddGood_Click);
            // 
            // dgvGood
            // 
            this.dgvGood.AllowUserToAddRows = false;
            this.dgvGood.AllowUserToDeleteRows = false;
            this.dgvGood.AllowUserToResizeRows = false;
            this.dgvGood.AutoGenerateColumns = false;
            this.dgvGood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGood.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idgDataGridViewTextBoxColumn,
            this.namegDataGridViewTextBoxColumn,
            this.idtgDataGridViewTextBoxColumn});
            this.dgvGood.DataSource = this.goodBindingSource;
            this.dgvGood.EnableHeadersVisualStyles = false;
            this.dgvGood.Location = new System.Drawing.Point(6, 181);
            this.dgvGood.MultiSelect = false;
            this.dgvGood.Name = "dgvGood";
            this.dgvGood.ReadOnly = true;
            this.dgvGood.RowHeadersVisible = false;
            this.dgvGood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGood.Size = new System.Drawing.Size(309, 129);
            this.dgvGood.TabIndex = 10;
            // 
            // idgDataGridViewTextBoxColumn
            // 
            this.idgDataGridViewTextBoxColumn.DataPropertyName = "id_g";
            this.idgDataGridViewTextBoxColumn.HeaderText = "id_g";
            this.idgDataGridViewTextBoxColumn.Name = "idgDataGridViewTextBoxColumn";
            this.idgDataGridViewTextBoxColumn.ReadOnly = true;
            this.idgDataGridViewTextBoxColumn.Visible = false;
            // 
            // namegDataGridViewTextBoxColumn
            // 
            this.namegDataGridViewTextBoxColumn.DataPropertyName = "name_g";
            this.namegDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.namegDataGridViewTextBoxColumn.Name = "namegDataGridViewTextBoxColumn";
            this.namegDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idtgDataGridViewTextBoxColumn
            // 
            this.idtgDataGridViewTextBoxColumn.DataPropertyName = "id_tg";
            this.idtgDataGridViewTextBoxColumn.DataSource = this.typeGoodBindingSource;
            this.idtgDataGridViewTextBoxColumn.DisplayMember = "name_tg";
            this.idtgDataGridViewTextBoxColumn.HeaderText = "Тип товара";
            this.idtgDataGridViewTextBoxColumn.Name = "idtgDataGridViewTextBoxColumn";
            this.idtgDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtgDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idtgDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idtgDataGridViewTextBoxColumn.ValueMember = "id_tg";
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
            // goodBindingSource
            // 
            this.goodBindingSource.DataMember = "Good";
            this.goodBindingSource.DataSource = this.spDataSet;
            // 
            // rtbMechanicalDamage
            // 
            this.rtbMechanicalDamage.Location = new System.Drawing.Point(475, 114);
            this.rtbMechanicalDamage.Name = "rtbMechanicalDamage";
            this.rtbMechanicalDamage.Size = new System.Drawing.Size(185, 38);
            this.rtbMechanicalDamage.TabIndex = 10;
            this.rtbMechanicalDamage.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Механические повреждения";
            // 
            // rtbEquipment
            // 
            this.rtbEquipment.Location = new System.Drawing.Point(475, 70);
            this.rtbEquipment.Name = "rtbEquipment";
            this.rtbEquipment.Size = new System.Drawing.Size(185, 38);
            this.rtbEquipment.TabIndex = 8;
            this.rtbEquipment.Text = "";
            // 
            // gbFind
            // 
            this.gbFind.Controls.Add(this.btnCancelGood);
            this.gbFind.Controls.Add(this.lblType);
            this.gbFind.Controls.Add(this.cbType);
            this.gbFind.Controls.Add(this.btnFindGood);
            this.gbFind.Controls.Add(this.tbName);
            this.gbFind.Controls.Add(this.lblName);
            this.gbFind.Location = new System.Drawing.Point(6, 35);
            this.gbFind.Name = "gbFind";
            this.gbFind.Size = new System.Drawing.Size(309, 110);
            this.gbFind.TabIndex = 7;
            this.gbFind.TabStop = false;
            this.gbFind.Text = "Поиск";
            // 
            // btnCancelGood
            // 
            this.btnCancelGood.Location = new System.Drawing.Point(223, 72);
            this.btnCancelGood.Name = "btnCancelGood";
            this.btnCancelGood.Size = new System.Drawing.Size(75, 23);
            this.btnCancelGood.TabIndex = 6;
            this.btnCancelGood.Text = "Отмена";
            this.btnCancelGood.UseVisualStyleBackColor = true;
            this.btnCancelGood.Click += new System.EventHandler(this.btnCancelGood_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 71);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(64, 13);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Тип товара";
            // 
            // cbType
            // 
            this.cbType.DataSource = this.typeGoodBindingSource;
            this.cbType.DisplayMember = "name_tg";
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(96, 71);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 4;
            this.cbType.ValueMember = "id_tg";
            // 
            // btnFindGood
            // 
            this.btnFindGood.Location = new System.Drawing.Point(223, 30);
            this.btnFindGood.Name = "btnFindGood";
            this.btnFindGood.Size = new System.Drawing.Size(75, 23);
            this.btnFindGood.TabIndex = 2;
            this.btnFindGood.Text = "Найти";
            this.btnFindGood.UseVisualStyleBackColor = true;
            this.btnFindGood.Click += new System.EventHandler(this.btnFindGood_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(96, 30);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Наименование";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Комплектация";
            // 
            // dgvFault
            // 
            this.dgvFault.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFault.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFault.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFault.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcNameFault,
            this.dgvtbcDescFault,
            this.faultStatus});
            this.dgvFault.EnableHeadersVisualStyles = false;
            this.dgvFault.Location = new System.Drawing.Point(327, 181);
            this.dgvFault.Name = "dgvFault";
            this.dgvFault.RowHeadersVisible = false;
            this.dgvFault.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFault.Size = new System.Drawing.Size(339, 129);
            this.dgvFault.TabIndex = 4;
            // 
            // dgvtbcNameFault
            // 
            this.dgvtbcNameFault.HeaderText = "Название";
            this.dgvtbcNameFault.Name = "dgvtbcNameFault";
            // 
            // dgvtbcDescFault
            // 
            this.dgvtbcDescFault.HeaderText = "Описание неисправности";
            this.dgvtbcDescFault.Name = "dgvtbcDescFault";
            // 
            // faultStatus
            // 
            this.faultStatus.DataSource = this.faultStatusBindingSource;
            this.faultStatus.DisplayMember = "name_fs";
            this.faultStatus.HeaderText = "Состояние";
            this.faultStatus.Name = "faultStatus";
            this.faultStatus.ValueMember = "id_fs";
            // 
            // faultStatusBindingSource
            // 
            this.faultStatusBindingSource.DataMember = "FaultStatus";
            this.faultStatusBindingSource.DataSource = this.spDataSet;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvClient);
            this.tabPage2.Controls.Add(this.gbSearch);
            this.tabPage2.Controls.Add(this.btnAddClient);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(673, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Информация о клиенте";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvClient
            // 
            this.dgvClient.AutoGenerateColumns = false;
            this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclientDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dgvClient.DataSource = this.clientBindingSource;
            this.dgvClient.EnableHeadersVisualStyles = false;
            this.dgvClient.Location = new System.Drawing.Point(7, 141);
            this.dgvClient.MultiSelect = false;
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.RowHeadersVisible = false;
            this.dgvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClient.Size = new System.Drawing.Size(660, 168);
            this.dgvClient.TabIndex = 7;
            // 
            // idclientDataGridViewTextBoxColumn
            // 
            this.idclientDataGridViewTextBoxColumn.DataPropertyName = "id_client";
            this.idclientDataGridViewTextBoxColumn.HeaderText = "id_client";
            this.idclientDataGridViewTextBoxColumn.Name = "idclientDataGridViewTextBoxColumn";
            this.idclientDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclientDataGridViewTextBoxColumn.Visible = false;
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
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.spDataSet;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnCancelClient);
            this.gbSearch.Controls.Add(this.mtbFind);
            this.gbSearch.Controls.Add(this.rbPhone);
            this.gbSearch.Controls.Add(this.btnFindClient);
            this.gbSearch.Controls.Add(this.rbLastName);
            this.gbSearch.Location = new System.Drawing.Point(7, 35);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(285, 87);
            this.gbSearch.TabIndex = 5;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Поиск";
            // 
            // btnCancelClient
            // 
            this.btnCancelClient.Location = new System.Drawing.Point(204, 53);
            this.btnCancelClient.Name = "btnCancelClient";
            this.btnCancelClient.Size = new System.Drawing.Size(75, 23);
            this.btnCancelClient.TabIndex = 8;
            this.btnCancelClient.Text = "Отмена";
            this.btnCancelClient.UseVisualStyleBackColor = true;
            this.btnCancelClient.Click += new System.EventHandler(this.btnCancelClient_Click);
            // 
            // mtbFind
            // 
            this.mtbFind.Location = new System.Drawing.Point(7, 56);
            this.mtbFind.Name = "mtbFind";
            this.mtbFind.Size = new System.Drawing.Size(181, 20);
            this.mtbFind.TabIndex = 2;
            // 
            // rbPhone
            // 
            this.rbPhone.AutoSize = true;
            this.rbPhone.Location = new System.Drawing.Point(98, 20);
            this.rbPhone.Name = "rbPhone";
            this.rbPhone.Size = new System.Drawing.Size(90, 17);
            this.rbPhone.TabIndex = 1;
            this.rbPhone.Text = "По телефону";
            this.rbPhone.UseVisualStyleBackColor = true;
            // 
            // btnFindClient
            // 
            this.btnFindClient.Location = new System.Drawing.Point(204, 17);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(75, 23);
            this.btnFindClient.TabIndex = 6;
            this.btnFindClient.Text = "Найти";
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // rbLastName
            // 
            this.rbLastName.AutoSize = true;
            this.rbLastName.Checked = true;
            this.rbLastName.Location = new System.Drawing.Point(7, 20);
            this.rbLastName.Name = "rbLastName";
            this.rbLastName.Size = new System.Drawing.Size(88, 17);
            this.rbLastName.TabIndex = 0;
            this.rbLastName.TabStop = true;
            this.rbLastName.Text = "По фамилии";
            this.rbLastName.UseVisualStyleBackColor = true;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(7, 7);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(112, 22);
            this.btnAddClient.TabIndex = 0;
            this.btnAddClient.Text = "Добавить клиента";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // goodTableAdapter
            // 
            this.goodTableAdapter.ClearBeforeFill = true;
            // 
            // typeGoodTableAdapter
            // 
            this.typeGoodTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // faultStatusTableAdapter
            // 
            this.faultStatusTableAdapter.ClearBeforeFill = true;
            // 
            // AcceptForRepairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 484);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.rtbComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpReceiptDate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AcceptForRepairForm";
            this.Text = "Прием в ремонт";
            this.Load += new System.EventHandler(this.AcceptForRepairForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeGoodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).EndInit();
            this.gbFind.ResumeLayout(false);
            this.gbFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultStatusBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpReceiptDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbComment;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvFault;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.MaskedTextBox mtbFind;
        private System.Windows.Forms.RadioButton rbPhone;
        private System.Windows.Forms.RadioButton rbLastName;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.DataGridView dgvGood;
        private System.Windows.Forms.GroupBox gbFind;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnFindGood;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAddGood;
        private System.Windows.Forms.RichTextBox rtbMechanicalDamage;
        private System.Windows.Forms.RichTextBox rtbEquipment;
        private SPDataSet spDataSet;
        private SPDataSetTableAdapters.GoodTableAdapter goodTableAdapter;
        private SPDataSetTableAdapters.TypeGoodTableAdapter typeGoodTableAdapter;
        private System.Windows.Forms.BindingSource goodBindingSource;
        private System.Windows.Forms.BindingSource typeGoodBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idtgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private SPDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.Button btnCancelGood;
        private System.Windows.Forms.Button btnCancelClient;
        private SPDataSetTableAdapters.FaultStatusTableAdapter faultStatusTableAdapter;
        private System.Windows.Forms.BindingSource faultStatusBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNameFault;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDescFault;
        private System.Windows.Forms.DataGridViewComboBoxColumn faultStatus;
    }
}