﻿namespace StartPovolgie.Forms
{
    partial class AddTypeGoodForm
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
            this.gbTypeGood = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbTypeGood = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbTypeGood.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTypeGood
            // 
            this.gbTypeGood.Controls.Add(this.btnAdd);
            this.gbTypeGood.Controls.Add(this.tbTypeGood);
            this.gbTypeGood.Controls.Add(this.label2);
            this.gbTypeGood.Location = new System.Drawing.Point(12, 12);
            this.gbTypeGood.Name = "gbTypeGood";
            this.gbTypeGood.Size = new System.Drawing.Size(221, 100);
            this.gbTypeGood.TabIndex = 1;
            this.gbTypeGood.TabStop = false;
            this.gbTypeGood.Text = "Добавление нового типа товара";
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
            // tbTypeGood
            // 
            this.tbTypeGood.Location = new System.Drawing.Point(94, 26);
            this.tbTypeGood.Name = "tbTypeGood";
            this.tbTypeGood.Size = new System.Drawing.Size(100, 20);
            this.tbTypeGood.TabIndex = 1;
            this.tbTypeGood.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTypeGood_KeyPress);
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
            // AddTypeGoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 121);
            this.Controls.Add(this.gbTypeGood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddTypeGoodForm";
            this.Text = "Добавление типа товара";
            this.gbTypeGood.ResumeLayout(false);
            this.gbTypeGood.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTypeGood;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbTypeGood;
        private System.Windows.Forms.Label label2;
    }


}