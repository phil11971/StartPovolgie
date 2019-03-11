﻿namespace StartPovolgie.Forms
{
    partial class ServiceForm
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
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnPullOut = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.spDataSet = new StartPovolgie.SPDataSet();
            this.serviceTableAdapter = new StartPovolgie.SPDataSetTableAdapters.ServiceTableAdapter();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvTypeGood = new System.Windows.Forms.DataGridView();
            this.typeServiceTableAdapter = new StartPovolgie.SPDataSetTableAdapters.TypeServiceTableAdapter();
            this.typeServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idserviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameserviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeServiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.lblType);
            this.gbSearch.Controls.Add(this.cbType);
            this.gbSearch.Controls.Add(this.btnPullOut);
            this.gbSearch.Controls.Add(this.btnFind);
            this.gbSearch.Controls.Add(this.tbName);
            this.gbSearch.Controls.Add(this.lblName);
            this.gbSearch.Location = new System.Drawing.Point(12, 12);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(475, 100);
            this.gbSearch.TabIndex = 0;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Поиск";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(11, 63);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(26, 13);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Тип";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(100, 55);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 4;
            // 
            // btnPullOut
            // 
            this.btnPullOut.Location = new System.Drawing.Point(316, 28);
            this.btnPullOut.Name = "btnPullOut";
            this.btnPullOut.Size = new System.Drawing.Size(143, 23);
            this.btnPullOut.TabIndex = 3;
            this.btnPullOut.Text = "Вывести полный список";
            this.btnPullOut.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(235, 28);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(100, 28);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Наименование";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 127);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(93, 127);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(174, 127);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // spDataSet
            // 
            this.spDataSet.DataSetName = "SPDataSet";
            this.spDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.spDataSet;
            // 
            // dgvTypeGood
            // 
            this.dgvTypeGood.AllowUserToAddRows = false;
            this.dgvTypeGood.AllowUserToDeleteRows = false;
            this.dgvTypeGood.AllowUserToResizeRows = false;
            this.dgvTypeGood.AutoGenerateColumns = false;
            this.dgvTypeGood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTypeGood.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTypeGood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypeGood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idserviceDataGridViewTextBoxColumn,
            this.nameserviceDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.idtsDataGridViewTextBoxColumn});
            this.dgvTypeGood.DataSource = this.serviceBindingSource;
            this.dgvTypeGood.EnableHeadersVisualStyles = false;
            this.dgvTypeGood.Location = new System.Drawing.Point(12, 156);
            this.dgvTypeGood.MultiSelect = false;
            this.dgvTypeGood.Name = "dgvTypeGood";
            this.dgvTypeGood.ReadOnly = true;
            this.dgvTypeGood.RowHeadersVisible = false;
            this.dgvTypeGood.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTypeGood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTypeGood.Size = new System.Drawing.Size(545, 148);
            this.dgvTypeGood.TabIndex = 9;
            // 
            // typeServiceTableAdapter
            // 
            this.typeServiceTableAdapter.ClearBeforeFill = true;
            // 
            // typeServiceBindingSource
            // 
            this.typeServiceBindingSource.DataMember = "TypeService";
            this.typeServiceBindingSource.DataSource = this.spDataSet;
            // 
            // idserviceDataGridViewTextBoxColumn
            // 
            this.idserviceDataGridViewTextBoxColumn.DataPropertyName = "id_service";
            this.idserviceDataGridViewTextBoxColumn.HeaderText = "id_service";
            this.idserviceDataGridViewTextBoxColumn.Name = "idserviceDataGridViewTextBoxColumn";
            this.idserviceDataGridViewTextBoxColumn.ReadOnly = true;
            this.idserviceDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameserviceDataGridViewTextBoxColumn
            // 
            this.nameserviceDataGridViewTextBoxColumn.DataPropertyName = "name_service";
            this.nameserviceDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameserviceDataGridViewTextBoxColumn.Name = "nameserviceDataGridViewTextBoxColumn";
            this.nameserviceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idtsDataGridViewTextBoxColumn
            // 
            this.idtsDataGridViewTextBoxColumn.DataPropertyName = "id_ts";
            this.idtsDataGridViewTextBoxColumn.DataSource = this.typeServiceBindingSource;
            this.idtsDataGridViewTextBoxColumn.DisplayMember = "name_ts";
            this.idtsDataGridViewTextBoxColumn.HeaderText = "Тип услуги";
            this.idtsDataGridViewTextBoxColumn.Name = "idtsDataGridViewTextBoxColumn";
            this.idtsDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtsDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idtsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idtsDataGridViewTextBoxColumn.ValueMember = "id_ts";
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 316);
            this.Controls.Add(this.dgvTypeGood);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbSearch);
            this.Name = "ServiceForm";
            this.Text = "Услуги";
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeServiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnPullOut;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private SPDataSet spDataSet;
        private SPDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.DataGridView dgvTypeGood;
        private SPDataSetTableAdapters.TypeServiceTableAdapter typeServiceTableAdapter;
        private System.Windows.Forms.BindingSource typeServiceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idserviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameserviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idtsDataGridViewTextBoxColumn;
    }
}