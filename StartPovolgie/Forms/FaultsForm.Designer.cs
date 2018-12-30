namespace StartPovolgie.Forms
{
    partial class FaultsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvtbcNameFault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDescFault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcbc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcNameFault,
            this.dgvtbcDescFault,
            this.dgvcbc});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(339, 171);
            this.dataGridView1.TabIndex = 5;
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
            // dgvcbc
            // 
            this.dgvcbc.HeaderText = "Состояние";
            this.dgvcbc.Name = "dgvcbc";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FaultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 224);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FaultsForm";
            this.Text = "Неисправности";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNameFault;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDescFault;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcbc;
        private System.Windows.Forms.Button button1;
    }
}