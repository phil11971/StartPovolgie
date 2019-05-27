namespace StartPovolgie.Forms
{
    partial class AddSpecializationForm
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
            this.gbSpec = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbSpec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbSpec.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSpec
            // 
            this.gbSpec.Controls.Add(this.btnAdd);
            this.gbSpec.Controls.Add(this.tbSpec);
            this.gbSpec.Controls.Add(this.label2);
            this.gbSpec.Location = new System.Drawing.Point(12, 12);
            this.gbSpec.Name = "gbSpec";
            this.gbSpec.Size = new System.Drawing.Size(234, 100);
            this.gbSpec.TabIndex = 1;
            this.gbSpec.TabStop = false;
            this.gbSpec.Text = "Добавление новой специализации мастера";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(144, 61);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbSpec
            // 
            this.tbSpec.Location = new System.Drawing.Point(119, 26);
            this.tbSpec.Name = "tbSpec";
            this.tbSpec.Size = new System.Drawing.Size(100, 20);
            this.tbSpec.TabIndex = 1;
            this.tbSpec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSpec_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Название";
            // 
            // AddSpecializationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 121);
            this.Controls.Add(this.gbSpec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddSpecializationForm";
            this.Text = "Добавление специализации мастера";
            this.gbSpec.ResumeLayout(false);
            this.gbSpec.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSpec;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbSpec;
        private System.Windows.Forms.Label label2;
    }


}