namespace StartPovolgie.Forms
{
    partial class GoodForm
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
            this.lblType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnPullOut = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.dgvGoods = new System.Windows.Forms.DataGridView();
            this.dgvtbcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).BeginInit();
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
            this.gbSearch.Size = new System.Drawing.Size(458, 82);
            this.gbSearch.TabIndex = 0;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Поиск";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(8, 52);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(64, 13);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Тип товара";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(97, 49);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 4;
            // 
            // btnPullOut
            // 
            this.btnPullOut.Location = new System.Drawing.Point(305, 49);
            this.btnPullOut.Name = "btnPullOut";
            this.btnPullOut.Size = new System.Drawing.Size(142, 23);
            this.btnPullOut.TabIndex = 3;
            this.btnPullOut.Text = "Вывести полный список";
            this.btnPullOut.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(224, 49);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(97, 20);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Наименование";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(9, 110);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(93, 110);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // dgvGoods
            // 
            this.dgvGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcName,
            this.dgvtbcType,
            this.dgvtbcStatus,
            this.dgvtbcClient});
            this.dgvGoods.EnableHeadersVisualStyles = false;
            this.dgvGoods.Location = new System.Drawing.Point(12, 139);
            this.dgvGoods.Name = "dgvGoods";
            this.dgvGoods.RowHeadersVisible = false;
            this.dgvGoods.Size = new System.Drawing.Size(457, 150);
            this.dgvGoods.TabIndex = 6;
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
            // dgvtbcClient
            // 
            this.dgvtbcClient.HeaderText = "Клиент";
            this.dgvtbcClient.Name = "dgvtbcClient";
            this.dgvtbcClient.ReadOnly = true;
            // 
            // GoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 301);
            this.Controls.Add(this.dgvGoods);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.gbSearch);
            this.Name = "GoodForm";
            this.Text = "Товары";
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btnPullOut;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dgvGoods;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcClient;
    }
}