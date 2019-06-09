namespace StartPovolgie.Forms
{
    partial class ViewAcceptForRepairForm
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
            this.tbIdAccept = new System.Windows.Forms.TextBox();
            this.acceptForRepairBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spDataSet = new StartPovolgie.SPDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbEquipment = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbMechanicalDamage = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpReceiptDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbComment = new System.Windows.Forms.RichTextBox();
            this.gbPrint = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.rbReturn = new System.Windows.Forms.RadioButton();
            this.rbAccept = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTypeGood = new System.Windows.Forms.TextBox();
            this.typeGoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbGood = new System.Windows.Forms.TextBox();
            this.goodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.gbInfoClient = new System.Windows.Forms.GroupBox();
            this.tbClientPatr = new System.Windows.Forms.TextBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbClientFirstName = new System.Windows.Forms.TextBox();
            this.tbClientLastName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvSparePart = new System.Windows.Forms.DataGridView();
            this.idfaultDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idspDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faultSparePartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvFault = new System.Windows.Forms.DataGridView();
            this.idfaultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descfaultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costeliminationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idacceptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmasterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idfsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelSparePartForCurrFault = new System.Windows.Forms.Button();
            this.btnAddSparePartForCurrFault = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.returnFromRepairBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbAmountRepair = new System.Windows.Forms.TextBox();
            this.tbAmountSpareParts = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbAdminFirstName = new System.Windows.Forms.TextBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbAdminLastName = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.acceptForRepairTableAdapter = new StartPovolgie.SPDataSetTableAdapters.AcceptForRepairTableAdapter();
            this.clientTableAdapter = new StartPovolgie.SPDataSetTableAdapters.ClientTableAdapter();
            this.goodTableAdapter = new StartPovolgie.SPDataSetTableAdapters.GoodTableAdapter();
            this.faultSparePartTableAdapter = new StartPovolgie.SPDataSetTableAdapters.FaultSparePartTableAdapter();
            this.faultTableAdapter = new StartPovolgie.SPDataSetTableAdapters.FaultTableAdapter();
            this.employeeTableAdapter = new StartPovolgie.SPDataSetTableAdapters.EmployeeTableAdapter();
            this.typeGoodTableAdapter = new StartPovolgie.SPDataSetTableAdapters.TypeGoodTableAdapter();
            this.rtbDescJob = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExec = new System.Windows.Forms.Button();
            this.returnFromRepairTableAdapter = new StartPovolgie.SPDataSetTableAdapters.ReturnFromRepairTableAdapter();
            this.btnAddFault = new System.Windows.Forms.Button();
            this.btnDelFault = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.acceptForRepairBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).BeginInit();
            this.gbPrint.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeGoodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).BeginInit();
            this.gbInfoClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSparePart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultSparePartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnFromRepairBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер приема";
            // 
            // tbIdAccept
            // 
            this.tbIdAccept.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.acceptForRepairBindingSource, "id_accept", true));
            this.tbIdAccept.Location = new System.Drawing.Point(169, 9);
            this.tbIdAccept.Name = "tbIdAccept";
            this.tbIdAccept.ReadOnly = true;
            this.tbIdAccept.Size = new System.Drawing.Size(135, 20);
            this.tbIdAccept.TabIndex = 1;
            // 
            // acceptForRepairBindingSource
            // 
            this.acceptForRepairBindingSource.DataMember = "AcceptForRepair";
            this.acceptForRepairBindingSource.DataSource = this.spDataSet;
            // 
            // spDataSet
            // 
            this.spDataSet.DataSetName = "SPDataSet";
            this.spDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Комплектация";
            // 
            // rtbEquipment
            // 
            this.rtbEquipment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.acceptForRepairBindingSource, "equipment", true));
            this.rtbEquipment.Location = new System.Drawing.Point(169, 43);
            this.rtbEquipment.Name = "rtbEquipment";
            this.rtbEquipment.ReadOnly = true;
            this.rtbEquipment.Size = new System.Drawing.Size(135, 41);
            this.rtbEquipment.TabIndex = 3;
            this.rtbEquipment.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Механические повреждения";
            // 
            // rtbMechanicalDamage
            // 
            this.rtbMechanicalDamage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.acceptForRepairBindingSource, "mechanical_damage", true));
            this.rtbMechanicalDamage.Location = new System.Drawing.Point(169, 98);
            this.rtbMechanicalDamage.Name = "rtbMechanicalDamage";
            this.rtbMechanicalDamage.ReadOnly = true;
            this.rtbMechanicalDamage.Size = new System.Drawing.Size(135, 41);
            this.rtbMechanicalDamage.TabIndex = 5;
            this.rtbMechanicalDamage.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата приема";
            // 
            // dtpReceiptDate
            // 
            this.dtpReceiptDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.acceptForRepairBindingSource, "receipt_date", true));
            this.dtpReceiptDate.Enabled = false;
            this.dtpReceiptDate.Location = new System.Drawing.Point(169, 145);
            this.dtpReceiptDate.Name = "dtpReceiptDate";
            this.dtpReceiptDate.Size = new System.Drawing.Size(135, 20);
            this.dtpReceiptDate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Комментарий";
            // 
            // rtbComment
            // 
            this.rtbComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.acceptForRepairBindingSource, "additionally", true));
            this.rtbComment.Location = new System.Drawing.Point(169, 218);
            this.rtbComment.Name = "rtbComment";
            this.rtbComment.ReadOnly = true;
            this.rtbComment.Size = new System.Drawing.Size(135, 41);
            this.rtbComment.TabIndex = 9;
            this.rtbComment.Text = "";
            // 
            // gbPrint
            // 
            this.gbPrint.Controls.Add(this.btnPrint);
            this.gbPrint.Controls.Add(this.rbReturn);
            this.gbPrint.Controls.Add(this.rbAccept);
            this.gbPrint.Location = new System.Drawing.Point(356, 82);
            this.gbPrint.Name = "gbPrint";
            this.gbPrint.Size = new System.Drawing.Size(145, 100);
            this.gbPrint.TabIndex = 14;
            this.gbPrint.TabStop = false;
            this.gbPrint.Text = "Печать";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(40, 66);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Печать";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // rbReturn
            // 
            this.rbReturn.AutoSize = true;
            this.rbReturn.Location = new System.Drawing.Point(6, 43);
            this.rbReturn.Name = "rbReturn";
            this.rbReturn.Size = new System.Drawing.Size(128, 17);
            this.rbReturn.TabIndex = 1;
            this.rbReturn.TabStop = true;
            this.rbReturn.Text = "Возврат из ремонта";
            this.rbReturn.UseVisualStyleBackColor = true;
            // 
            // rbAccept
            // 
            this.rbAccept.AutoSize = true;
            this.rbAccept.Checked = true;
            this.rbAccept.Location = new System.Drawing.Point(7, 20);
            this.rbAccept.Name = "rbAccept";
            this.rbAccept.Size = new System.Drawing.Size(108, 17);
            this.rbAccept.TabIndex = 0;
            this.rbAccept.TabStop = true;
            this.rbAccept.Text = "Прием в ремонт";
            this.rbAccept.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Дата выдачи";
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Location = new System.Drawing.Point(169, 181);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(135, 20);
            this.dtpIssueDate.TabIndex = 16;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(16, 268);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(883, 236);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.gbInfoClient);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(875, 210);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Основная информация";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTypeGood);
            this.groupBox1.Controls.Add(this.tbGood);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(496, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 197);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о товаре";
            // 
            // tbTypeGood
            // 
            this.tbTypeGood.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeGoodBindingSource, "name_tg", true));
            this.tbTypeGood.Location = new System.Drawing.Point(98, 113);
            this.tbTypeGood.Name = "tbTypeGood";
            this.tbTypeGood.ReadOnly = true;
            this.tbTypeGood.Size = new System.Drawing.Size(251, 20);
            this.tbTypeGood.TabIndex = 3;
            // 
            // typeGoodBindingSource
            // 
            this.typeGoodBindingSource.DataMember = "TypeGood";
            this.typeGoodBindingSource.DataSource = this.spDataSet;
            // 
            // tbGood
            // 
            this.tbGood.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodBindingSource, "name_g", true));
            this.tbGood.Location = new System.Drawing.Point(98, 66);
            this.tbGood.Name = "tbGood";
            this.tbGood.ReadOnly = true;
            this.tbGood.Size = new System.Drawing.Size(251, 20);
            this.tbGood.TabIndex = 2;
            // 
            // goodBindingSource
            // 
            this.goodBindingSource.DataMember = "Good";
            this.goodBindingSource.DataSource = this.spDataSet;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 113);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Тип товара";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Товар ";
            // 
            // gbInfoClient
            // 
            this.gbInfoClient.Controls.Add(this.tbClientPatr);
            this.gbInfoClient.Controls.Add(this.tbClientFirstName);
            this.gbInfoClient.Controls.Add(this.tbClientLastName);
            this.gbInfoClient.Controls.Add(this.label14);
            this.gbInfoClient.Controls.Add(this.label10);
            this.gbInfoClient.Controls.Add(this.label9);
            this.gbInfoClient.Controls.Add(this.tbAddress);
            this.gbInfoClient.Controls.Add(this.tbMail);
            this.gbInfoClient.Controls.Add(this.mtbPhone);
            this.gbInfoClient.Location = new System.Drawing.Point(10, 7);
            this.gbInfoClient.Name = "gbInfoClient";
            this.gbInfoClient.Size = new System.Drawing.Size(480, 197);
            this.gbInfoClient.TabIndex = 22;
            this.gbInfoClient.TabStop = false;
            this.gbInfoClient.Text = "Информация о клиенте";
            // 
            // tbClientPatr
            // 
            this.tbClientPatr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "patronymic", true));
            this.tbClientPatr.Location = new System.Drawing.Point(360, 29);
            this.tbClientPatr.Name = "tbClientPatr";
            this.tbClientPatr.ReadOnly = true;
            this.tbClientPatr.Size = new System.Drawing.Size(100, 20);
            this.tbClientPatr.TabIndex = 10;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.spDataSet;
            // 
            // tbClientFirstName
            // 
            this.tbClientFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "fname", true));
            this.tbClientFirstName.Location = new System.Drawing.Point(222, 29);
            this.tbClientFirstName.Name = "tbClientFirstName";
            this.tbClientFirstName.ReadOnly = true;
            this.tbClientFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbClientFirstName.TabIndex = 9;
            // 
            // tbClientLastName
            // 
            this.tbClientLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "lname", true));
            this.tbClientLastName.Location = new System.Drawing.Point(82, 29);
            this.tbClientLastName.Name = "tbClientLastName";
            this.tbClientLastName.ReadOnly = true;
            this.tbClientLastName.Size = new System.Drawing.Size(100, 20);
            this.tbClientLastName.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Адрес";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Mail";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Телефон";
            // 
            // tbAddress
            // 
            this.tbAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "address", true));
            this.tbAddress.Location = new System.Drawing.Point(82, 145);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.ReadOnly = true;
            this.tbAddress.Size = new System.Drawing.Size(378, 20);
            this.tbAddress.TabIndex = 3;
            // 
            // tbMail
            // 
            this.tbMail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "mail", true));
            this.tbMail.Location = new System.Drawing.Point(82, 108);
            this.tbMail.Name = "tbMail";
            this.tbMail.ReadOnly = true;
            this.tbMail.Size = new System.Drawing.Size(378, 20);
            this.tbMail.TabIndex = 2;
            // 
            // mtbPhone
            // 
            this.mtbPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "phone", true));
            this.mtbPhone.Location = new System.Drawing.Point(82, 72);
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.ReadOnly = true;
            this.mtbPhone.Size = new System.Drawing.Size(378, 20);
            this.mtbPhone.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDelFault);
            this.tabPage3.Controls.Add(this.btnAddFault);
            this.tabPage3.Controls.Add(this.dgvSparePart);
            this.tabPage3.Controls.Add(this.dgvFault);
            this.tabPage3.Controls.Add(this.btnDelSparePartForCurrFault);
            this.tabPage3.Controls.Add(this.btnAddSparePartForCurrFault);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(875, 210);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Используемые запчасти";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvSparePart
            // 
            this.dgvSparePart.AutoGenerateColumns = false;
            this.dgvSparePart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSparePart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSparePart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSparePart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfaultDataGridViewTextBoxColumn1,
            this.idspDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvSparePart.DataSource = this.faultSparePartBindingSource;
            this.dgvSparePart.EnableHeadersVisualStyles = false;
            this.dgvSparePart.Location = new System.Drawing.Point(351, 33);
            this.dgvSparePart.MultiSelect = false;
            this.dgvSparePart.Name = "dgvSparePart";
            this.dgvSparePart.RowHeadersVisible = false;
            this.dgvSparePart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSparePart.Size = new System.Drawing.Size(503, 171);
            this.dgvSparePart.TabIndex = 15;
            // 
            // idfaultDataGridViewTextBoxColumn1
            // 
            this.idfaultDataGridViewTextBoxColumn1.DataPropertyName = "id_fault";
            this.idfaultDataGridViewTextBoxColumn1.HeaderText = "id_fault";
            this.idfaultDataGridViewTextBoxColumn1.Name = "idfaultDataGridViewTextBoxColumn1";
            this.idfaultDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idspDataGridViewTextBoxColumn
            // 
            this.idspDataGridViewTextBoxColumn.DataPropertyName = "id_sp";
            this.idspDataGridViewTextBoxColumn.HeaderText = "id_sp";
            this.idspDataGridViewTextBoxColumn.Name = "idspDataGridViewTextBoxColumn";
            this.idspDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "name_sp";
            this.dataGridViewTextBoxColumn3.HeaderText = "Название ЗП";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "qonf";
            this.dataGridViewTextBoxColumn1.HeaderText = "Кол-во на неиспр.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "pwithqsp";
            this.dataGridViewTextBoxColumn2.HeaderText = "Цена ЗП с учетом кол-ва";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "qonstore";
            this.dataGridViewTextBoxColumn4.HeaderText = "Кол-во на складе";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "punit";
            this.dataGridViewTextBoxColumn5.HeaderText = "Цена ЗП за ед.";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // faultSparePartBindingSource
            // 
            this.faultSparePartBindingSource.DataMember = "FaultSparePart";
            this.faultSparePartBindingSource.DataSource = this.spDataSet;
            // 
            // dgvFault
            // 
            this.dgvFault.AutoGenerateColumns = false;
            this.dgvFault.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFault.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFault.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFault.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfaultDataGridViewTextBoxColumn,
            this.descfaultDataGridViewTextBoxColumn,
            this.costeliminationDataGridViewTextBoxColumn,
            this.idacceptDataGridViewTextBoxColumn,
            this.idmasterDataGridViewTextBoxColumn,
            this.idfsDataGridViewTextBoxColumn});
            this.dgvFault.DataSource = this.faultBindingSource;
            this.dgvFault.EnableHeadersVisualStyles = false;
            this.dgvFault.Location = new System.Drawing.Point(6, 33);
            this.dgvFault.MultiSelect = false;
            this.dgvFault.Name = "dgvFault";
            this.dgvFault.RowHeadersVisible = false;
            this.dgvFault.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFault.Size = new System.Drawing.Size(339, 171);
            this.dgvFault.TabIndex = 14;
            this.dgvFault.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFault_CellClick);
            // 
            // idfaultDataGridViewTextBoxColumn
            // 
            this.idfaultDataGridViewTextBoxColumn.DataPropertyName = "id_fault";
            this.idfaultDataGridViewTextBoxColumn.HeaderText = "id_fault";
            this.idfaultDataGridViewTextBoxColumn.Name = "idfaultDataGridViewTextBoxColumn";
            this.idfaultDataGridViewTextBoxColumn.ReadOnly = true;
            this.idfaultDataGridViewTextBoxColumn.Visible = false;
            // 
            // descfaultDataGridViewTextBoxColumn
            // 
            this.descfaultDataGridViewTextBoxColumn.DataPropertyName = "desc_fault";
            this.descfaultDataGridViewTextBoxColumn.HeaderText = "Описание неисправности";
            this.descfaultDataGridViewTextBoxColumn.Name = "descfaultDataGridViewTextBoxColumn";
            // 
            // costeliminationDataGridViewTextBoxColumn
            // 
            this.costeliminationDataGridViewTextBoxColumn.DataPropertyName = "cost_elimination";
            this.costeliminationDataGridViewTextBoxColumn.HeaderText = "Стоимость устранения";
            this.costeliminationDataGridViewTextBoxColumn.Name = "costeliminationDataGridViewTextBoxColumn";
            // 
            // idacceptDataGridViewTextBoxColumn
            // 
            this.idacceptDataGridViewTextBoxColumn.DataPropertyName = "id_accept";
            this.idacceptDataGridViewTextBoxColumn.HeaderText = "id_accept";
            this.idacceptDataGridViewTextBoxColumn.Name = "idacceptDataGridViewTextBoxColumn";
            this.idacceptDataGridViewTextBoxColumn.Visible = false;
            // 
            // idmasterDataGridViewTextBoxColumn
            // 
            this.idmasterDataGridViewTextBoxColumn.DataPropertyName = "id_master";
            this.idmasterDataGridViewTextBoxColumn.HeaderText = "id_master";
            this.idmasterDataGridViewTextBoxColumn.Name = "idmasterDataGridViewTextBoxColumn";
            this.idmasterDataGridViewTextBoxColumn.Visible = false;
            // 
            // idfsDataGridViewTextBoxColumn
            // 
            this.idfsDataGridViewTextBoxColumn.DataPropertyName = "id_fs";
            this.idfsDataGridViewTextBoxColumn.HeaderText = "id_fs";
            this.idfsDataGridViewTextBoxColumn.Name = "idfsDataGridViewTextBoxColumn";
            this.idfsDataGridViewTextBoxColumn.Visible = false;
            // 
            // faultBindingSource
            // 
            this.faultBindingSource.DataMember = "Fault";
            this.faultBindingSource.DataSource = this.spDataSet;
            // 
            // btnDelSparePartForCurrFault
            // 
            this.btnDelSparePartForCurrFault.Location = new System.Drawing.Point(588, 6);
            this.btnDelSparePartForCurrFault.Name = "btnDelSparePartForCurrFault";
            this.btnDelSparePartForCurrFault.Size = new System.Drawing.Size(266, 23);
            this.btnDelSparePartForCurrFault.TabIndex = 13;
            this.btnDelSparePartForCurrFault.Text = "Удалить запчасть для текущей неисправности";
            this.btnDelSparePartForCurrFault.UseVisualStyleBackColor = true;
            this.btnDelSparePartForCurrFault.Click += new System.EventHandler(this.btnDelSparePartForCurrFault_Click);
            // 
            // btnAddSparePartForCurrFault
            // 
            this.btnAddSparePartForCurrFault.Location = new System.Drawing.Point(304, 6);
            this.btnAddSparePartForCurrFault.Name = "btnAddSparePartForCurrFault";
            this.btnAddSparePartForCurrFault.Size = new System.Drawing.Size(278, 23);
            this.btnAddSparePartForCurrFault.TabIndex = 12;
            this.btnAddSparePartForCurrFault.Text = "Добавить запчасть для текущей неисправности";
            this.btnAddSparePartForCurrFault.UseVisualStyleBackColor = true;
            this.btnAddSparePartForCurrFault.Click += new System.EventHandler(this.btnAddSparePartForCurrFault_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(353, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Итого";
            // 
            // tbTotal
            // 
            this.tbTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returnFromRepairBindingSource, "total", true));
            this.tbTotal.Location = new System.Drawing.Point(476, 239);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(135, 20);
            this.tbTotal.TabIndex = 19;
            // 
            // returnFromRepairBindingSource
            // 
            this.returnFromRepairBindingSource.DataMember = "ReturnFromRepair";
            this.returnFromRepairBindingSource.DataSource = this.spDataSet;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(354, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Стоимость ремонта";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(353, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Стоимость запчастей";
            // 
            // tbAmountRepair
            // 
            this.tbAmountRepair.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returnFromRepairBindingSource, "amount_repair", true));
            this.tbAmountRepair.Location = new System.Drawing.Point(476, 184);
            this.tbAmountRepair.Name = "tbAmountRepair";
            this.tbAmountRepair.ReadOnly = true;
            this.tbAmountRepair.Size = new System.Drawing.Size(135, 20);
            this.tbAmountRepair.TabIndex = 22;
            // 
            // tbAmountSpareParts
            // 
            this.tbAmountSpareParts.Location = new System.Drawing.Point(476, 211);
            this.tbAmountSpareParts.Name = "tbAmountSpareParts";
            this.tbAmountSpareParts.ReadOnly = true;
            this.tbAmountSpareParts.Size = new System.Drawing.Size(135, 20);
            this.tbAmountSpareParts.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbAdminFirstName);
            this.groupBox2.Controls.Add(this.tbAdminLastName);
            this.groupBox2.Location = new System.Drawing.Point(356, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 75);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Администратор";
            // 
            // tbAdminFirstName
            // 
            this.tbAdminFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "fname", true));
            this.tbAdminFirstName.Location = new System.Drawing.Point(6, 47);
            this.tbAdminFirstName.Name = "tbAdminFirstName";
            this.tbAdminFirstName.ReadOnly = true;
            this.tbAdminFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbAdminFirstName.TabIndex = 1;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.spDataSet;
            // 
            // tbAdminLastName
            // 
            this.tbAdminLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "lname", true));
            this.tbAdminLastName.Location = new System.Drawing.Point(6, 20);
            this.tbAdminLastName.Name = "tbAdminLastName";
            this.tbAdminLastName.ReadOnly = true;
            this.tbAdminLastName.Size = new System.Drawing.Size(100, 20);
            this.tbAdminLastName.TabIndex = 0;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(639, 235);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 25;
            this.btnCalc.Text = "Рассчитать";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // acceptForRepairTableAdapter
            // 
            this.acceptForRepairTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // goodTableAdapter
            // 
            this.goodTableAdapter.ClearBeforeFill = true;
            // 
            // faultSparePartTableAdapter
            // 
            this.faultSparePartTableAdapter.ClearBeforeFill = true;
            // 
            // faultTableAdapter
            // 
            this.faultTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // typeGoodTableAdapter
            // 
            this.typeGoodTableAdapter.ClearBeforeFill = true;
            // 
            // rtbDescJob
            // 
            this.rtbDescJob.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.acceptForRepairBindingSource, "additionally", true));
            this.rtbDescJob.Location = new System.Drawing.Point(639, 6);
            this.rtbDescJob.Name = "rtbDescJob";
            this.rtbDescJob.Size = new System.Drawing.Size(276, 223);
            this.rtbDescJob.TabIndex = 26;
            this.rtbDescJob.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Описание работ";
            // 
            // btnExec
            // 
            this.btnExec.Enabled = false;
            this.btnExec.Location = new System.Drawing.Point(720, 235);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(75, 23);
            this.btnExec.TabIndex = 28;
            this.btnExec.Text = "Провести";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // returnFromRepairTableAdapter
            // 
            this.returnFromRepairTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddFault
            // 
            this.btnAddFault.Location = new System.Drawing.Point(6, 4);
            this.btnAddFault.Name = "btnAddFault";
            this.btnAddFault.Size = new System.Drawing.Size(145, 23);
            this.btnAddFault.TabIndex = 16;
            this.btnAddFault.Text = "Добавить неисправность";
            this.btnAddFault.UseVisualStyleBackColor = true;
            this.btnAddFault.Click += new System.EventHandler(this.btnAddFault_Click);
            // 
            // btnDelFault
            // 
            this.btnDelFault.Location = new System.Drawing.Point(153, 4);
            this.btnDelFault.Name = "btnDelFault";
            this.btnDelFault.Size = new System.Drawing.Size(145, 23);
            this.btnDelFault.TabIndex = 17;
            this.btnDelFault.Text = "Удалить неисправность";
            this.btnDelFault.UseVisualStyleBackColor = true;
            // 
            // ViewAcceptForRepairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 516);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbDescJob);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbAmountSpareParts);
            this.Controls.Add(this.tbAmountRepair);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbPrint);
            this.Controls.Add(this.rtbComment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpReceiptDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbMechanicalDamage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbEquipment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIdAccept);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ViewAcceptForRepairForm";
            this.Text = "Просмотр приема в ремонт";
            this.Load += new System.EventHandler(this.ViewAcceptForRepairForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.acceptForRepairBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).EndInit();
            this.gbPrint.ResumeLayout(false);
            this.gbPrint.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeGoodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).EndInit();
            this.gbInfoClient.ResumeLayout(false);
            this.gbInfoClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSparePart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultSparePartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnFromRepairBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIdAccept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbEquipment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbMechanicalDamage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpReceiptDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbComment;
        private System.Windows.Forms.GroupBox gbPrint;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.RadioButton rbReturn;
        private System.Windows.Forms.RadioButton rbAccept;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnDelSparePartForCurrFault;
        private System.Windows.Forms.DataGridView dgvFault;
        private System.Windows.Forms.DataGridView dgvSparePart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbAmountRepair;
        private System.Windows.Forms.TextBox tbAmountSpareParts;
        private SPDataSet spDataSet;
        private SPDataSetTableAdapters.AcceptForRepairTableAdapter acceptForRepairTableAdapter;
        private System.Windows.Forms.BindingSource acceptForRepairBindingSource;
        private SPDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private SPDataSetTableAdapters.GoodTableAdapter goodTableAdapter;
        private System.Windows.Forms.BindingSource goodBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbInfoClient;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbGood;
        private SPDataSetTableAdapters.FaultSparePartTableAdapter faultSparePartTableAdapter;
        private System.Windows.Forms.BindingSource faultSparePartBindingSource;
        private SPDataSetTableAdapters.FaultTableAdapter faultTableAdapter;
        private System.Windows.Forms.BindingSource faultBindingSource;
        private SPDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbAdminFirstName;
        private System.Windows.Forms.TextBox tbAdminLastName;
        private System.Windows.Forms.TextBox tbClientPatr;
        private System.Windows.Forms.TextBox tbClientFirstName;
        private System.Windows.Forms.TextBox tbClientLastName;
        private SPDataSetTableAdapters.TypeGoodTableAdapter typeGoodTableAdapter;
        private System.Windows.Forms.BindingSource typeGoodBindingSource;
        private System.Windows.Forms.TextBox tbTypeGood;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnAddSparePartForCurrFault;
        private System.Windows.Forms.DataGridViewTextBoxColumn namespDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qonfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pwithqspDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qonstoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn punitDataGridViewTextBoxColumn;
        private System.Windows.Forms.RichTextBox rtbDescJob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfaultDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idspDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private SPDataSetTableAdapters.ReturnFromRepairTableAdapter returnFromRepairTableAdapter;
        private System.Windows.Forms.BindingSource returnFromRepairBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfaultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descfaultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costeliminationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idacceptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmasterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDelFault;
        private System.Windows.Forms.Button btnAddFault;
    }
}