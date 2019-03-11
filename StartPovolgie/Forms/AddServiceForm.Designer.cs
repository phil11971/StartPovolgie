namespace StartPovolgie.Forms
{
    partial class AddServiceForm
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
            this.lblAdd = new System.Windows.Forms.Label();
            this.gbInfoService = new System.Windows.Forms.GroupBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbInfoService.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(28, 13);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(139, 13);
            this.lblAdd.TabIndex = 0;
            this.lblAdd.Text = "Добавление новой услуги";
            // 
            // gbInfoService
            // 
            this.gbInfoService.Controls.Add(this.cbType);
            this.gbInfoService.Controls.Add(this.tbPrice);
            this.gbInfoService.Controls.Add(this.tbName);
            this.gbInfoService.Controls.Add(this.lblType);
            this.gbInfoService.Controls.Add(this.lblPrice);
            this.gbInfoService.Controls.Add(this.lblName);
            this.gbInfoService.Location = new System.Drawing.Point(31, 45);
            this.gbInfoService.Name = "gbInfoService";
            this.gbInfoService.Size = new System.Drawing.Size(254, 141);
            this.gbInfoService.TabIndex = 1;
            this.gbInfoService.TabStop = false;
            this.gbInfoService.Text = "Информация об услуге";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(95, 100);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 12;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(95, 61);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(121, 20);
            this.tbPrice.TabIndex = 7;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(95, 32);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 6;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(20, 103);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(62, 13);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Тип услуги";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(20, 68);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 13);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Цена";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Название";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(210, 192);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // AddServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 223);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbInfoService);
            this.Controls.Add(this.lblAdd);
            this.Name = "AddServiceForm";
            this.Text = "Добавление новой услуги";
            this.gbInfoService.ResumeLayout(false);
            this.gbInfoService.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.GroupBox gbInfoService;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnAdd;
    }
}