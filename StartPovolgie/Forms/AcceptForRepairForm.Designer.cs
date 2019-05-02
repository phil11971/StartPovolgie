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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dgvGoods = new System.Windows.Forms.DataGridView();
            this.dgvtbcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvtbcNameFault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDescFault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcbcStateFault = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvIndividual = new System.Windows.Forms.DataGridView();
            this.dgvtbcLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcPatronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcAdr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.mtbSearch = new System.Windows.Forms.MaskedTextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndividual)).BeginInit();
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(99, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 20);
            this.dateTimePicker1.TabIndex = 1;
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
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(99, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(185, 60);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Оформить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Печать";
            this.button2.UseVisualStyleBackColor = true;
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
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.dgvGoods);
            this.tabPage1.Controls.Add(this.richTextBox3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.richTextBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(673, 344);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Информация об устройстве";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(475, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(185, 21);
            this.comboBox2.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Тип товара";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(475, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Наименование";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(9, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "Добавить товар";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(591, 316);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dgvGoods
            // 
            this.dgvGoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGoods.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcName,
            this.dgvtbcType,
            this.dgvtbcStatus});
            this.dgvGoods.EnableHeadersVisualStyles = false;
            this.dgvGoods.Location = new System.Drawing.Point(6, 181);
            this.dgvGoods.Name = "dgvGoods";
            this.dgvGoods.RowHeadersVisible = false;
            this.dgvGoods.Size = new System.Drawing.Size(309, 129);
            this.dgvGoods.TabIndex = 10;
            // 
            // dgvtbcName
            // 
            this.dgvtbcName.HeaderText = "Наименование";
            this.dgvtbcName.Name = "dgvtbcName";
            this.dgvtbcName.ReadOnly = true;
            // 
            // dgvtbcType
            // 
            this.dgvtbcType.HeaderText = "Тип товара";
            this.dgvtbcType.Name = "dgvtbcType";
            this.dgvtbcType.ReadOnly = true;
            // 
            // dgvtbcStatus
            // 
            this.dgvtbcStatus.HeaderText = "Статус";
            this.dgvtbcStatus.Name = "dgvtbcStatus";
            this.dgvtbcStatus.ReadOnly = true;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(475, 133);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(185, 38);
            this.richTextBox3.TabIndex = 10;
            this.richTextBox3.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Механические повреждения";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(475, 89);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(185, 38);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(6, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 140);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 92);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(64, 13);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Тип товара";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(96, 89);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 4;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(223, 30);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = true;
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
            this.label5.Location = new System.Drawing.Point(322, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Комплектация";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcNameFault,
            this.dgvtbcDescFault,
            this.dgvcbcStateFault});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(327, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(339, 129);
            this.dataGridView1.TabIndex = 4;
            // 
            // dgvtbcNameFault
            // 
            this.dgvtbcNameFault.HeaderText = "Название неисправности";
            this.dgvtbcNameFault.Name = "dgvtbcNameFault";
            // 
            // dgvtbcDescFault
            // 
            this.dgvtbcDescFault.HeaderText = "Описание неисправности";
            this.dgvtbcDescFault.Name = "dgvtbcDescFault";
            // 
            // dgvcbcStateFault
            // 
            this.dgvcbcStateFault.HeaderText = "Состояние";
            this.dgvcbcStateFault.Name = "dgvcbcStateFault";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.dgvIndividual);
            this.tabPage2.Controls.Add(this.gbSearch);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(673, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Информация о клиенте";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(592, 315);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dgvIndividual
            // 
            this.dgvIndividual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIndividual.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvIndividual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIndividual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcLastName,
            this.dgvtbcFirstName,
            this.dgvtbcPatronymic,
            this.dgvtbcPhone,
            this.dgvtbcAdr});
            this.dgvIndividual.EnableHeadersVisualStyles = false;
            this.dgvIndividual.Location = new System.Drawing.Point(7, 141);
            this.dgvIndividual.Name = "dgvIndividual";
            this.dgvIndividual.RowHeadersVisible = false;
            this.dgvIndividual.Size = new System.Drawing.Size(660, 168);
            this.dgvIndividual.TabIndex = 7;
            // 
            // dgvtbcLastName
            // 
            this.dgvtbcLastName.HeaderText = "Фамилия";
            this.dgvtbcLastName.Name = "dgvtbcLastName";
            this.dgvtbcLastName.ReadOnly = true;
            // 
            // dgvtbcFirstName
            // 
            this.dgvtbcFirstName.HeaderText = "Имя";
            this.dgvtbcFirstName.Name = "dgvtbcFirstName";
            this.dgvtbcFirstName.ReadOnly = true;
            // 
            // dgvtbcPatronymic
            // 
            this.dgvtbcPatronymic.HeaderText = "Отчество";
            this.dgvtbcPatronymic.Name = "dgvtbcPatronymic";
            this.dgvtbcPatronymic.ReadOnly = true;
            // 
            // dgvtbcPhone
            // 
            this.dgvtbcPhone.HeaderText = "Телефон";
            this.dgvtbcPhone.Name = "dgvtbcPhone";
            this.dgvtbcPhone.ReadOnly = true;
            // 
            // dgvtbcAdr
            // 
            this.dgvtbcAdr.HeaderText = "Адрес";
            this.dgvtbcAdr.Name = "dgvtbcAdr";
            this.dgvtbcAdr.ReadOnly = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(204, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.mtbSearch);
            this.gbSearch.Controls.Add(this.radioButton2);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.radioButton1);
            this.gbSearch.Location = new System.Drawing.Point(7, 35);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(285, 87);
            this.gbSearch.TabIndex = 5;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Поиск";
            // 
            // mtbSearch
            // 
            this.mtbSearch.Location = new System.Drawing.Point(7, 56);
            this.mtbSearch.Name = "mtbSearch";
            this.mtbSearch.Size = new System.Drawing.Size(181, 20);
            this.mtbSearch.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(98, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(90, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "По телефону";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "По фамилии";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 22);
            this.button3.TabIndex = 0;
            this.button3.Text = "Добавить клиента";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AcceptForRepairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 484);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "AcceptForRepairForm";
            this.Text = "Прием в ремонт";
            this.Load += new System.EventHandler(this.AcceptForRepairForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndividual)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.MaskedTextBox mtbSearch;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView dgvIndividual;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcPatronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcAdr;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNameFault;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDescFault;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcbcStateFault;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
    }
}