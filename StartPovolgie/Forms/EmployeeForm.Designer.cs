namespace StartPovolgie.Forms
{
    partial class EmployeeForm
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.dgvtbcLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcPatronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInfoEmp = new System.Windows.Forms.GroupBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.gbInfoEmpEntry = new System.Windows.Forms.GroupBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.gbInfoEmp.SuspendLayout();
            this.gbInfoEmpEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить ";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(94, 40);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(177, 40);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Location = new System.Drawing.Point(12, 82);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(66, 13);
            this.lblEmployees.TabIndex = 3;
            this.lblEmployees.Text = "Сотрудники";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcLastName,
            this.dgvtbcFirstName,
            this.dgvtbcPatronymic});
            this.dgvEmployees.EnableHeadersVisualStyles = false;
            this.dgvEmployees.Location = new System.Drawing.Point(12, 113);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.Size = new System.Drawing.Size(303, 150);
            this.dgvEmployees.TabIndex = 4;
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
            // gbInfoEmp
            // 
            this.gbInfoEmp.Controls.Add(this.tbStatus);
            this.gbInfoEmp.Controls.Add(this.tbPhone);
            this.gbInfoEmp.Controls.Add(this.lblStatus);
            this.gbInfoEmp.Controls.Add(this.lblPhone);
            this.gbInfoEmp.Location = new System.Drawing.Point(321, 40);
            this.gbInfoEmp.Name = "gbInfoEmp";
            this.gbInfoEmp.Size = new System.Drawing.Size(182, 223);
            this.gbInfoEmp.TabIndex = 5;
            this.gbInfoEmp.TabStop = false;
            this.gbInfoEmp.Text = "Общая информация о сотруднике";
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(78, 117);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(100, 20);
            this.tbStatus.TabIndex = 5;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(78, 42);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(100, 20);
            this.tbPhone.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(7, 124);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Статус";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(7, 42);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 13);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Телефон";
            // 
            // gbInfoEmpEntry
            // 
            this.gbInfoEmpEntry.Controls.Add(this.tbPass);
            this.gbInfoEmpEntry.Controls.Add(this.tbLogin);
            this.gbInfoEmpEntry.Controls.Add(this.lblPass);
            this.gbInfoEmpEntry.Controls.Add(this.lblLogin);
            this.gbInfoEmpEntry.Location = new System.Drawing.Point(509, 40);
            this.gbInfoEmpEntry.Name = "gbInfoEmpEntry";
            this.gbInfoEmpEntry.Size = new System.Drawing.Size(200, 223);
            this.gbInfoEmpEntry.TabIndex = 6;
            this.gbInfoEmpEntry.TabStop = false;
            this.gbInfoEmpEntry.Text = "Информация для входа в систему";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(80, 70);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(100, 20);
            this.tbPass.TabIndex = 7;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(80, 39);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(100, 20);
            this.tbLogin.TabIndex = 6;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(25, 73);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(45, 13);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Пароль";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(25, 42);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(38, 13);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Логин";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 286);
            this.Controls.Add(this.gbInfoEmpEntry);
            this.Controls.Add(this.gbInfoEmp);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.lblEmployees);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "EmployeeForm";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.gbInfoEmp.ResumeLayout(false);
            this.gbInfoEmp.PerformLayout();
            this.gbInfoEmpEntry.ResumeLayout(false);
            this.gbInfoEmpEntry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.GroupBox gbInfoEmp;
        private System.Windows.Forms.GroupBox gbInfoEmpEntry;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcPatronymic;
    }
}