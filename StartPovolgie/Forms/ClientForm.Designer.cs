namespace StartPovolgie.Forms
{
    partial class ClientForm
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
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnPullOut = new System.Windows.Forms.Button();
            this.mtbSearch = new System.Windows.Forms.MaskedTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.tcClients = new System.Windows.Forms.TabControl();
            this.tpIndividual = new System.Windows.Forms.TabPage();
            this.dgvIndividual = new System.Windows.Forms.DataGridView();
            this.dgvtbcLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcPatronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcAdr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpEntity = new System.Windows.Forms.TabPage();
            this.dgvEntity = new System.Windows.Forms.DataGridView();
            this.dgvtbcTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSearch.SuspendLayout();
            this.tcClients.SuspendLayout();
            this.tpIndividual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndividual)).BeginInit();
            this.tpEntity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.radioButton3);
            this.gbSearch.Controls.Add(this.btnPullOut);
            this.gbSearch.Controls.Add(this.mtbSearch);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.radioButton2);
            this.gbSearch.Controls.Add(this.radioButton1);
            this.gbSearch.Location = new System.Drawing.Point(13, 13);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(439, 100);
            this.gbSearch.TabIndex = 0;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Поиск";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(101, 20);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(92, 17);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "По названию";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnPullOut
            // 
            this.btnPullOut.Location = new System.Drawing.Point(287, 56);
            this.btnPullOut.Name = "btnPullOut";
            this.btnPullOut.Size = new System.Drawing.Size(137, 23);
            this.btnPullOut.TabIndex = 5;
            this.btnPullOut.Text = "Вывести всех клиентов";
            this.btnPullOut.UseVisualStyleBackColor = true;
            // 
            // mtbSearch
            // 
            this.mtbSearch.Location = new System.Drawing.Point(7, 56);
            this.mtbSearch.Name = "mtbSearch";
            this.mtbSearch.Size = new System.Drawing.Size(181, 20);
            this.mtbSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(206, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(206, 20);
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 133);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(94, 133);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(175, 133);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // tcClients
            // 
            this.tcClients.Controls.Add(this.tpIndividual);
            this.tcClients.Controls.Add(this.tpEntity);
            this.tcClients.Location = new System.Drawing.Point(13, 172);
            this.tcClients.Name = "tcClients";
            this.tcClients.SelectedIndex = 0;
            this.tcClients.Size = new System.Drawing.Size(549, 177);
            this.tcClients.TabIndex = 6;
            // 
            // tpIndividual
            // 
            this.tpIndividual.Controls.Add(this.dgvIndividual);
            this.tpIndividual.Location = new System.Drawing.Point(4, 22);
            this.tpIndividual.Name = "tpIndividual";
            this.tpIndividual.Padding = new System.Windows.Forms.Padding(3);
            this.tpIndividual.Size = new System.Drawing.Size(541, 151);
            this.tpIndividual.TabIndex = 0;
            this.tpIndividual.Text = "Физические лица";
            this.tpIndividual.UseVisualStyleBackColor = true;
            // 
            // dgvIndividual
            // 
            this.dgvIndividual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIndividual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcLastName,
            this.dgvtbcFirstName,
            this.dgvtbcPatronymic,
            this.dgvtbcPhone,
            this.dgvtbcAdr});
            this.dgvIndividual.EnableHeadersVisualStyles = false;
            this.dgvIndividual.Location = new System.Drawing.Point(0, 0);
            this.dgvIndividual.Name = "dgvIndividual";
            this.dgvIndividual.RowHeadersVisible = false;
            this.dgvIndividual.Size = new System.Drawing.Size(541, 150);
            this.dgvIndividual.TabIndex = 0;
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
            // tpEntity
            // 
            this.tpEntity.Controls.Add(this.dgvEntity);
            this.tpEntity.Location = new System.Drawing.Point(4, 22);
            this.tpEntity.Name = "tpEntity";
            this.tpEntity.Padding = new System.Windows.Forms.Padding(3);
            this.tpEntity.Size = new System.Drawing.Size(541, 151);
            this.tpEntity.TabIndex = 1;
            this.tpEntity.Text = "Юридические лица";
            this.tpEntity.UseVisualStyleBackColor = true;
            // 
            // dgvEntity
            // 
            this.dgvEntity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcTitle,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvEntity.EnableHeadersVisualStyles = false;
            this.dgvEntity.Location = new System.Drawing.Point(-4, -2);
            this.dgvEntity.Name = "dgvEntity";
            this.dgvEntity.RowHeadersVisible = false;
            this.dgvEntity.Size = new System.Drawing.Size(545, 157);
            this.dgvEntity.TabIndex = 0;
            // 
            // dgvtbcTitle
            // 
            this.dgvtbcTitle.HeaderText = "Название";
            this.dgvtbcTitle.Name = "dgvtbcTitle";
            this.dgvtbcTitle.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 367);
            this.Controls.Add(this.tcClients);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbSearch);
            this.Name = "ClientForm";
            this.Text = " Клиенты";
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.tcClients.ResumeLayout(false);
            this.tpIndividual.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndividual)).EndInit();
            this.tpEntity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.MaskedTextBox mtbSearch;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPullOut;
        private System.Windows.Forms.TabControl tcClients;
        private System.Windows.Forms.TabPage tpIndividual;
        private System.Windows.Forms.DataGridView dgvIndividual;
        private System.Windows.Forms.TabPage tpEntity;
        private System.Windows.Forms.DataGridView dgvEntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcPatronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcAdr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}