namespace StartPovolgie.Forms
{
    partial class ServiceForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnPullOut = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.dgvtbcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDateEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.lblType);
            this.gbSearch.Controls.Add(this.cbType);
            this.gbSearch.Controls.Add(this.btnPullOut);
            this.gbSearch.Controls.Add(this.btnFind);
            this.gbSearch.Controls.Add(this.tbName);
            this.gbSearch.Controls.Add(this.lblName);
            this.gbSearch.Location = new System.Drawing.Point(12, 12);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(475, 100);
            this.gbSearch.TabIndex = 0;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Поиск";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Наименование";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(100, 28);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(235, 28);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnPullOut
            // 
            this.btnPullOut.Location = new System.Drawing.Point(316, 28);
            this.btnPullOut.Name = "btnPullOut";
            this.btnPullOut.Size = new System.Drawing.Size(143, 23);
            this.btnPullOut.TabIndex = 3;
            this.btnPullOut.Text = "Вывести полный список";
            this.btnPullOut.UseVisualStyleBackColor = true;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(100, 55);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 4;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(11, 63);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(26, 13);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Тип";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 127);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(93, 127);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(174, 127);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // dgvServices
            // 
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcName,
            this.dgvtbcPrice,
            this.dgvtbcDesc,
            this.dgvtbcType,
            this.dgvtbcDateEdit});
            this.dgvServices.EnableHeadersVisualStyles = false;
            this.dgvServices.Location = new System.Drawing.Point(13, 157);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.RowHeadersVisible = false;
            this.dgvServices.Size = new System.Drawing.Size(564, 150);
            this.dgvServices.TabIndex = 9;
            // 
            // dgvtbcName
            // 
            this.dgvtbcName.HeaderText = "Наименование";
            this.dgvtbcName.Name = "dgvtbcName";
            this.dgvtbcName.ReadOnly = true;
            // 
            // dgvtbcPrice
            // 
            this.dgvtbcPrice.HeaderText = "Цена";
            this.dgvtbcPrice.Name = "dgvtbcPrice";
            this.dgvtbcPrice.ReadOnly = true;
            // 
            // dgvtbcDesc
            // 
            this.dgvtbcDesc.HeaderText = "Описание";
            this.dgvtbcDesc.Name = "dgvtbcDesc";
            this.dgvtbcDesc.ReadOnly = true;
            // 
            // dgvtbcType
            // 
            this.dgvtbcType.HeaderText = "Тип услуги";
            this.dgvtbcType.Name = "dgvtbcType";
            this.dgvtbcType.ReadOnly = true;
            // 
            // dgvtbcDateEdit
            // 
            this.dgvtbcDateEdit.HeaderText = "Дата изменения";
            this.dgvtbcDateEdit.Name = "dgvtbcDateEdit";
            this.dgvtbcDateEdit.ReadOnly = true;
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvServices);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbSearch);
            this.Name = "ServiceForm";
            this.Text = "Услуги";
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnPullOut;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDateEdit;
    }
}