﻿namespace StartPovolgie.Forms
{
    partial class AddSparePartForm
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
            this.components = new System.ComponentModel.Container();
            this.lblAdd = new System.Windows.Forms.Label();
            this.gbInfoSpare = new System.Windows.Forms.GroupBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.spDataSet = new StartPovolgie.SPDataSet();
            this.sparePartStatusTableAdapter = new StartPovolgie.SPDataSetTableAdapters.SparePartStatusTableAdapter();
            this.sparePartStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbInfoSpare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartStatusBindingSource)).BeginInit();
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
            this.gbInfoSpare.Controls.Add(this.cbStatus);
            this.gbInfoSpare.Controls.Add(this.tbDesc);
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
            this.gbInfoSpare.Size = new System.Drawing.Size(254, 172);
            this.gbInfoSpare.TabIndex = 1;
            this.gbInfoSpare.TabStop = false;
            this.gbInfoSpare.Text = "Информация о запчасти";
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(95, 58);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(121, 20);
            this.tbDesc.TabIndex = 15;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 136);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 13);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Статус";
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(95, 84);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(121, 20);
            this.tbCount.TabIndex = 9;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(95, 110);
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
            this.lblCount.Location = new System.Drawing.Point(20, 84);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(66, 13);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "Количество";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(20, 61);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(57, 13);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Описание";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(20, 110);
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
            this.btnAdd.Location = new System.Drawing.Point(210, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.DataSource = this.sparePartStatusBindingSource;
            this.cbStatus.DisplayMember = "name_sps";
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(95, 137);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 16;
            this.cbStatus.ValueMember = "id_sps";
            // 
            // spDataSet
            // 
            this.spDataSet.DataSetName = "SPDataSet";
            this.spDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sparePartStatusTableAdapter
            // 
            this.sparePartStatusTableAdapter.ClearBeforeFill = true;
            // 
            // sparePartStatusBindingSource
            // 
            this.sparePartStatusBindingSource.DataMember = "SparePartStatus";
            this.sparePartStatusBindingSource.DataSource = this.spDataSet;
            // 
            // AddSparePartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 256);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbInfoSpare);
            this.Controls.Add(this.lblAdd);
            this.Name = "AddSparePartForm";
            this.Text = "Добавление новой запчасти";
            this.gbInfoSpare.ResumeLayout(false);
            this.gbInfoSpare.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartStatusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(string name, string desc, int cnt, int price, string status)
        {
            this.components = new System.ComponentModel.Container();
            this.lblAdd = new System.Windows.Forms.Label();
            this.gbInfoSpare = new System.Windows.Forms.GroupBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.spDataSet = new StartPovolgie.SPDataSet();
            this.sparePartStatusTableAdapter = new StartPovolgie.SPDataSetTableAdapters.SparePartStatusTableAdapter();
            this.sparePartStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbInfoSpare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartStatusBindingSource)).BeginInit();
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
            this.gbInfoSpare.Controls.Add(this.cbStatus);
            this.gbInfoSpare.Controls.Add(this.tbDesc);
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
            this.gbInfoSpare.Size = new System.Drawing.Size(254, 172);
            this.gbInfoSpare.TabIndex = 1;
            this.gbInfoSpare.TabStop = false;
            this.gbInfoSpare.Text = "Информация о запчасти";
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(95, 58);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(121, 20);
            this.tbDesc.TabIndex = 15;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 136);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 13);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Статус";
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(95, 84);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(121, 20);
            this.tbCount.TabIndex = 9;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(95, 110);
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
            this.lblCount.Location = new System.Drawing.Point(20, 84);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(66, 13);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "Количество";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(20, 61);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(57, 13);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Описание";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(20, 110);
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
            this.btnAdd.Location = new System.Drawing.Point(210, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.DataSource = this.sparePartStatusBindingSource;
            this.cbStatus.DisplayMember = "name_sps";
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(95, 137);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 16;
            this.cbStatus.ValueMember = "id_sps";
            // 
            // spDataSet
            // 
            this.spDataSet.DataSetName = "SPDataSet";
            this.spDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sparePartStatusTableAdapter
            // 
            this.sparePartStatusTableAdapter.ClearBeforeFill = true;
            // 
            // sparePartStatusBindingSource
            // 
            this.sparePartStatusBindingSource.DataMember = "SparePartStatus";
            this.sparePartStatusBindingSource.DataSource = this.spDataSet;
            // 
            // AddSparePartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 256);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbInfoSpare);
            this.Controls.Add(this.lblAdd);
            this.Name = "AddSparePartForm";
            this.Text = "Добавление новой запчасти";
            this.gbInfoSpare.ResumeLayout(false);
            this.gbInfoSpare.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartStatusBindingSource)).EndInit();
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
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private SPDataSet spDataSet;
        private SPDataSetTableAdapters.SparePartStatusTableAdapter sparePartStatusTableAdapter;
        private System.Windows.Forms.BindingSource sparePartStatusBindingSource;
    }
}