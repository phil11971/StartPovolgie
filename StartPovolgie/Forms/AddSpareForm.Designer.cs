namespace StartPovolgie.Forms
{
    partial class AddSpareForm
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
            this.gbInfoSpare = new System.Windows.Forms.GroupBox();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.gbInfoSpare.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(28, 13);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(152, 13);
            this.lblAdd.TabIndex = 0;
            this.lblAdd.Text = "Добавление новой запчасти";
            // 
            // gbInfoSpare
            // 
            this.gbInfoSpare.Controls.Add(this.tbDesc);
            this.gbInfoSpare.Controls.Add(this.tbStatus);
            this.gbInfoSpare.Controls.Add(this.lblStatus);
            this.gbInfoSpare.Controls.Add(this.tbCount);
            this.gbInfoSpare.Controls.Add(this.tbPrice);
            this.gbInfoSpare.Controls.Add(this.tbName);
            this.gbInfoSpare.Controls.Add(this.lblCount);
            this.gbInfoSpare.Controls.Add(this.lblDesc);
            this.gbInfoSpare.Controls.Add(this.lblPrice);
            this.gbInfoSpare.Controls.Add(this.lblName);
            this.gbInfoSpare.Location = new System.Drawing.Point(31, 45);
            this.gbInfoSpare.Name = "gbInfoSpare";
            this.gbInfoSpare.Size = new System.Drawing.Size(254, 195);
            this.gbInfoSpare.TabIndex = 1;
            this.gbInfoSpare.TabStop = false;
            this.gbInfoSpare.Text = "Информация о запчасти";
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(95, 141);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(121, 20);
            this.tbCount.TabIndex = 9;
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
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(20, 141);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(66, 13);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "Количество";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(20, 103);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(57, 13);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Описание";
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
            this.btnAdd.Location = new System.Drawing.Point(209, 246);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 168);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 13);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Статус";
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(95, 165);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(121, 20);
            this.tbStatus.TabIndex = 14;
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(95, 100);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(121, 20);
            this.tbDesc.TabIndex = 15;
            // 
            // AddSpareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 280);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbInfoSpare);
            this.Controls.Add(this.lblAdd);
            this.Name = "AddSpareForm";
            this.Text = "Добавление новой запчасти";
            this.gbInfoSpare.ResumeLayout(false);
            this.gbInfoSpare.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.GroupBox gbInfoSpare;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label lblStatus;
    }
}