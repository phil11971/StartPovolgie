namespace StartPovolgie.Forms
{
    partial class AddOfficePhoneForm
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
            this.gbPhone = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.gbPhone.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.gbPhone.Controls.Add(this.mtbPhone);
            this.gbPhone.Controls.Add(this.btnAdd);
            this.gbPhone.Controls.Add(this.label2);
            this.gbPhone.Location = new System.Drawing.Point(12, 12);
            this.gbPhone.Name = "groupBox1";
            this.gbPhone.Size = new System.Drawing.Size(200, 100);
            this.gbPhone.TabIndex = 2;
            this.gbPhone.TabStop = false;
            this.gbPhone.Text = "Добавление нового телефона";
            // 
            // button1
            // 
            this.btnAdd.Location = new System.Drawing.Point(119, 62);
            this.btnAdd.Name = "button1";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Номер";
            // 
            // maskedTextBox1
            // 
            this.mtbPhone.Location = new System.Drawing.Point(53, 23);
            this.mtbPhone.Mask = "8(000)000-00-00";
            this.mtbPhone.Name = "maskedTextBox1";
            this.mtbPhone.Size = new System.Drawing.Size(100, 20);
            this.mtbPhone.TabIndex = 3;
            // 
            // AddOfficePhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 120);
            this.Controls.Add(this.gbPhone);
            this.Name = "AddOfficePhoneForm";
            this.Text = "Добавление телефона";
            this.gbPhone.ResumeLayout(false);
            this.gbPhone.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPhone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
    }
}