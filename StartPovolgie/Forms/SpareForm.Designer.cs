namespace StartPovolgie.Forms
{
    partial class SpareForm
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
            this.btnPullOut = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.dgvtbcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnPullOut);
            this.gbSearch.Controls.Add(this.btnFind);
            this.gbSearch.Controls.Add(this.tbName);
            this.gbSearch.Controls.Add(this.lblName);
            this.gbSearch.Location = new System.Drawing.Point(12, 12);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(475, 65);
            this.gbSearch.TabIndex = 0;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Поиск";
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
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(235, 28);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(100, 28);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 1;
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 97);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(93, 97);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(174, 97);
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
            this.dgvtbcCount,
            this.dgvtbcStatus});
            this.dgvServices.EnableHeadersVisualStyles = false;
            this.dgvServices.Location = new System.Drawing.Point(12, 142);
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
            // dgvtbcCount
            // 
            this.dgvtbcCount.HeaderText = "Количество";
            this.dgvtbcCount.Name = "dgvtbcCount";
            this.dgvtbcCount.ReadOnly = true;
            // 
            // dgvtbcStatus
            // 
            this.dgvtbcStatus.HeaderText = "Статус";
            this.dgvtbcStatus.Name = "dgvtbcStatus";
            this.dgvtbcStatus.ReadOnly = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, 299);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(240, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Только запчасти, которые есть в наличии";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SpareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 330);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dgvServices);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbSearch);
            this.Name = "SpareForm";
            this.Text = "Запчасти";
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearch;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcStatus;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}