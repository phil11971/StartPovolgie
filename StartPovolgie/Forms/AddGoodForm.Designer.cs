namespace StartPovolgie.Forms
{
    partial class AddGoodForm
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
            this.gbGood = new System.Windows.Forms.GroupBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.typeGoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spDataSet = new StartPovolgie.SPDataSet();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.typeGoodTableAdapter = new StartPovolgie.SPDataSetTableAdapters.TypeGoodTableAdapter();
            this.gbGood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeGoodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(28, 13);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(146, 13);
            this.lblAdd.TabIndex = 0;
            this.lblAdd.Text = "Добавление нового товара";
            // 
            // gbGood
            // 
            this.gbGood.Controls.Add(this.cbType);
            this.gbGood.Controls.Add(this.tbName);
            this.gbGood.Controls.Add(this.lblType);
            this.gbGood.Controls.Add(this.lblName);
            this.gbGood.Location = new System.Drawing.Point(31, 45);
            this.gbGood.Name = "gbGood";
            this.gbGood.Size = new System.Drawing.Size(254, 108);
            this.gbGood.TabIndex = 1;
            this.gbGood.TabStop = false;
            this.gbGood.Text = "Информация о товаре";
            // 
            // cbType
            // 
            this.cbType.DataSource = this.typeGoodBindingSource;
            this.cbType.DisplayMember = "name_tg";
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(95, 69);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 12;
            this.cbType.ValueMember = "id_tg";
            // 
            // typeGoodBindingSource
            // 
            this.typeGoodBindingSource.DataMember = "TypeGood";
            this.typeGoodBindingSource.DataSource = this.spDataSet;
            // 
            // spDataSet
            // 
            this.spDataSet.DataSetName = "SPDataSet";
            this.spDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(95, 32);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 6;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 69);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(64, 13);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Тип товара";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Наименование";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(210, 159);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // typeGoodTableAdapter
            // 
            this.typeGoodTableAdapter.ClearBeforeFill = true;
            // 
            // AddGoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 192);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbGood);
            this.Controls.Add(this.lblAdd);
            this.Name = "AddGoodForm";
            this.Text = "Добавление нового товара";
            this.gbGood.ResumeLayout(false);
            this.gbGood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeGoodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.GroupBox gbGood;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnAdd;
        private SPDataSet spDataSet;
        private SPDataSetTableAdapters.TypeGoodTableAdapter typeGoodTableAdapter;
        private System.Windows.Forms.BindingSource typeGoodBindingSource;
    }
}