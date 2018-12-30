namespace StartPovolgie.Forms
{
    partial class SpecializationForm
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
            this.dgvSpecialization = new System.Windows.Forms.DataGridView();
            this.dgvtbcTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecialization)).BeginInit();
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
            // dgvSpecialization
            // 
            this.dgvSpecialization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecialization.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcTitle});
            this.dgvSpecialization.EnableHeadersVisualStyles = false;
            this.dgvSpecialization.Location = new System.Drawing.Point(27, 41);
            this.dgvSpecialization.Name = "dgvSpecialization";
            this.dgvSpecialization.RowHeadersVisible = false;
            this.dgvSpecialization.Size = new System.Drawing.Size(240, 229);
            this.dgvSpecialization.TabIndex = 2;
            // 
            // dgvtbcTitle
            // 
            this.dgvtbcTitle.HeaderText = "Название";
            this.dgvtbcTitle.Name = "dgvtbcTitle";
            this.dgvtbcTitle.ReadOnly = true;
            // 
            // Specialization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 282);
            this.Controls.Add(this.dgvSpecialization);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Name = "Specialization";
            this.Text = "Специализации мастеров";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecialization)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dgvSpecialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcTitle;
    }
}