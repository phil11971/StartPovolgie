namespace StartPovolgie.Forms
{
    partial class MainForm
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прайслистыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работыУслугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запчастиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мастерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администраторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.специализацииМастеровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.офисныеТелефоныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.состояниеНеисправностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяЗаявкаНаРемонтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реестрЗаявокНаРемонтToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRegistry = new System.Windows.Forms.Button();
            this.lblEmp = new System.Windows.Forms.LinkLabel();
            this.pbEmployee = new System.Windows.Forms.PictureBox();
            this.pbStartPovolgie = new System.Windows.Forms.PictureBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStartPovolgie)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.сервисToolStripMenuItem,
            this.запросыToolStripMenuItem,
            this.отчётыToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.сменитьПользователяToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(763, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прайслистыToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.товарыToolStripMenuItem,
            this.типыТоваровToolStripMenuItem,
            this.специализацииМастеровToolStripMenuItem,
            this.офисныеТелефоныToolStripMenuItem,
            this.состояниеНеисправностиToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // прайслистыToolStripMenuItem
            // 
            this.прайслистыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работыУслугиToolStripMenuItem,
            this.запчастиToolStripMenuItem});
            this.прайслистыToolStripMenuItem.Name = "прайслистыToolStripMenuItem";
            this.прайслистыToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.прайслистыToolStripMenuItem.Text = "Прайс-листы";
            // 
            // работыУслугиToolStripMenuItem
            // 
            this.работыУслугиToolStripMenuItem.Name = "работыУслугиToolStripMenuItem";
            this.работыУслугиToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.работыУслугиToolStripMenuItem.Text = "Работы/Услуги";
            this.работыУслугиToolStripMenuItem.Click += new System.EventHandler(this.работыУслугиToolStripMenuItem_Click);
            // 
            // запчастиToolStripMenuItem
            // 
            this.запчастиToolStripMenuItem.Name = "запчастиToolStripMenuItem";
            this.запчастиToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.запчастиToolStripMenuItem.Text = "Запчасти";
            this.запчастиToolStripMenuItem.Click += new System.EventHandler(this.запчастиToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.мастерыToolStripMenuItem,
            this.администраторыToolStripMenuItem});
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // мастерыToolStripMenuItem
            // 
            this.мастерыToolStripMenuItem.Name = "мастерыToolStripMenuItem";
            this.мастерыToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.мастерыToolStripMenuItem.Text = "Мастер";
            this.мастерыToolStripMenuItem.Click += new System.EventHandler(this.мастерыToolStripMenuItem_Click);
            // 
            // администраторыToolStripMenuItem
            // 
            this.администраторыToolStripMenuItem.Name = "администраторыToolStripMenuItem";
            this.администраторыToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.администраторыToolStripMenuItem.Text = "Администратор";
            this.администраторыToolStripMenuItem.Click += new System.EventHandler(this.администраторыToolStripMenuItem_Click);
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.товарыToolStripMenuItem.Text = "Товары";
            this.товарыToolStripMenuItem.Click += new System.EventHandler(this.товарыToolStripMenuItem_Click);
            // 
            // типыТоваровToolStripMenuItem
            // 
            this.типыТоваровToolStripMenuItem.Name = "типыТоваровToolStripMenuItem";
            this.типыТоваровToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.типыТоваровToolStripMenuItem.Text = "Типы товаров";
            this.типыТоваровToolStripMenuItem.Click += new System.EventHandler(this.типыТоваровToolStripMenuItem_Click);
            // 
            // специализацииМастеровToolStripMenuItem
            // 
            this.специализацииМастеровToolStripMenuItem.Name = "специализацииМастеровToolStripMenuItem";
            this.специализацииМастеровToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.специализацииМастеровToolStripMenuItem.Text = "Специализации мастеров";
            this.специализацииМастеровToolStripMenuItem.Click += new System.EventHandler(this.специализацииМастеровToolStripMenuItem_Click);
            // 
            // офисныеТелефоныToolStripMenuItem
            // 
            this.офисныеТелефоныToolStripMenuItem.Name = "офисныеТелефоныToolStripMenuItem";
            this.офисныеТелефоныToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.офисныеТелефоныToolStripMenuItem.Text = "Офисные телефоны";
            this.офисныеТелефоныToolStripMenuItem.Click += new System.EventHandler(this.офисныеТелефоныToolStripMenuItem_Click);
            // 
            // состояниеНеисправностиToolStripMenuItem
            // 
            this.состояниеНеисправностиToolStripMenuItem.Name = "состояниеНеисправностиToolStripMenuItem";
            this.состояниеНеисправностиToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.состояниеНеисправностиToolStripMenuItem.Text = "Состояние неисправности";
            this.состояниеНеисправностиToolStripMenuItem.Click += new System.EventHandler(this.состояниеНеисправностиToolStripMenuItem_Click);
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяЗаявкаНаРемонтToolStripMenuItem});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // новаяЗаявкаНаРемонтToolStripMenuItem
            // 
            this.новаяЗаявкаНаРемонтToolStripMenuItem.Name = "новаяЗаявкаНаРемонтToolStripMenuItem";
            this.новаяЗаявкаНаРемонтToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.новаяЗаявкаНаРемонтToolStripMenuItem.Text = "Прием в ремонт";
            this.новаяЗаявкаНаРемонтToolStripMenuItem.Click += new System.EventHandler(this.новаяЗаявкаНаРемонтToolStripMenuItem_Click);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.реестрЗаявокНаРемонтToolStripMenuItem1});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // реестрЗаявокНаРемонтToolStripMenuItem1
            // 
            this.реестрЗаявокНаРемонтToolStripMenuItem1.Name = "реестрЗаявокНаРемонтToolStripMenuItem1";
            this.реестрЗаявокНаРемонтToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
            this.реестрЗаявокНаРемонтToolStripMenuItem1.Text = "Реестр приемов в ремонт";
            this.реестрЗаявокНаРемонтToolStripMenuItem1.Click += new System.EventHandler(this.реестрЗаявокНаРемонтToolStripMenuItem1_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчётыToolStripMenuItem.Text = "Отчеты";
            this.отчётыToolStripMenuItem.Click += new System.EventHandler(this.отчётыToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            // 
            // btnRegistry
            // 
            this.btnRegistry.Location = new System.Drawing.Point(499, 134);
            this.btnRegistry.Name = "btnRegistry";
            this.btnRegistry.Size = new System.Drawing.Size(200, 23);
            this.btnRegistry.TabIndex = 2;
            this.btnRegistry.Text = "Реестр приемов в ремонт";
            this.btnRegistry.UseVisualStyleBackColor = true;
            this.btnRegistry.Click += new System.EventHandler(this.btnRegistry_Click);
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Location = new System.Drawing.Point(527, 9);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(54, 13);
            this.lblEmp.TabIndex = 10;
            this.lblEmp.TabStop = true;
            this.lblEmp.Text = "nameEmp";
            // 
            // pbEmployee
            // 
            this.pbEmployee.Location = new System.Drawing.Point(499, 2);
            this.pbEmployee.Name = "pbEmployee";
            this.pbEmployee.Size = new System.Drawing.Size(22, 22);
            this.pbEmployee.TabIndex = 9;
            this.pbEmployee.TabStop = false;
            // 
            // pbStartPovolgie
            // 
            this.pbStartPovolgie.Image = global::StartPovolgie.Properties.Resources.СП;
            this.pbStartPovolgie.Location = new System.Drawing.Point(29, 72);
            this.pbStartPovolgie.Name = "pbStartPovolgie";
            this.pbStartPovolgie.Size = new System.Drawing.Size(438, 114);
            this.pbStartPovolgie.TabIndex = 11;
            this.pbStartPovolgie.TabStop = false;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(499, 89);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(200, 23);
            this.btnAccept.TabIndex = 12;
            this.btnAccept.Text = "Прием в ремонт";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 272);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblEmp);
            this.Controls.Add(this.pbEmployee);
            this.Controls.Add(this.pbStartPovolgie);
            this.Controls.Add(this.btnRegistry);
            this.Controls.Add(this.menuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuMain;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Серивисный центр \"Старт Поволжье\"";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStartPovolgie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прайслистыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работыУслугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запчастиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыТоваровToolStripMenuItem;
        private System.Windows.Forms.Button btnRegistry;
        private System.Windows.Forms.PictureBox pbStartPovolgie;
        private System.Windows.Forms.PictureBox pbEmployee;
        private System.Windows.Forms.ToolStripMenuItem новаяЗаявкаНаРемонтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem специализацииМастеровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem офисныеТелефоныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem реестрЗаявокНаРемонтToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem мастерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администраторыToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lblEmp;
        private System.Windows.Forms.ToolStripMenuItem состояниеНеисправностиToolStripMenuItem;
        private System.Windows.Forms.Button btnAccept;
    }
}