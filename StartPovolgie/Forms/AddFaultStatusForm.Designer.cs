namespace StartPovolgie.Forms
{
    partial class AddFaultStatusForm
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
            this.gbFaultStatus = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbFaultStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbFaultStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFaultStatus
            // 
            this.gbFaultStatus.Controls.Add(this.btnAdd);
            this.gbFaultStatus.Controls.Add(this.tbFaultStatus);
            this.gbFaultStatus.Controls.Add(this.label2);
            this.gbFaultStatus.Location = new System.Drawing.Point(12, 12);
            this.gbFaultStatus.Name = "gbFaultStatus";
            this.gbFaultStatus.Size = new System.Drawing.Size(200, 100);
            this.gbFaultStatus.TabIndex = 1;
            this.gbFaultStatus.TabStop = false;
            this.gbFaultStatus.Text = "Добавление нового состояния неисправности";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(119, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbFaultStatus
            // 
            this.tbFaultStatus.Location = new System.Drawing.Point(94, 26);
            this.tbFaultStatus.Name = "tbFaultStatus";
            this.tbFaultStatus.Size = new System.Drawing.Size(100, 20);
            this.tbFaultStatus.TabIndex = 1;
            this.tbFaultStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFaultStatus_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Название";
            // 
            // AddFaultStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 121);
            this.Controls.Add(this.gbFaultStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddFaultStatusForm";
            this.Text = "Добавление состояния неисправности";
            this.gbFaultStatus.ResumeLayout(false);
            this.gbFaultStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFaultStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbFaultStatus;
        private System.Windows.Forms.Label label2;
    }


}