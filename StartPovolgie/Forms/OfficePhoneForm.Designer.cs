namespace StartPovolgie.Forms
{
    partial class OfficePhoneForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.dgvOfficePhone = new System.Windows.Forms.DataGridView();
            this.dgvtbNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfficePhone)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(27, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(118, 12);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // dgvOfficePhone
            // 
            this.dgvOfficePhone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOfficePhone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbNumber});
            this.dgvOfficePhone.EnableHeadersVisualStyles = false;
            this.dgvOfficePhone.Location = new System.Drawing.Point(27, 41);
            this.dgvOfficePhone.Name = "dgvOfficePhone";
            this.dgvOfficePhone.RowHeadersVisible = false;
            this.dgvOfficePhone.Size = new System.Drawing.Size(240, 229);
            this.dgvOfficePhone.TabIndex = 2;
            // 
            // dgvtbNumber
            // 
            this.dgvtbNumber.HeaderText = "Номер";
            this.dgvtbNumber.Name = "dgvtbNumber";
            this.dgvtbNumber.ReadOnly = true;
            // 
            // OfficePhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 282);
            this.Controls.Add(this.dgvOfficePhone);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Name = "OfficePhone";
            this.Text = "Офисные номера телефонов";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfficePhone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dgvOfficePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbNumber;
    }
}