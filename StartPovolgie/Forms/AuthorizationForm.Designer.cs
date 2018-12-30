namespace StartPovolgie.Forms
{
    partial class AuthorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAuth = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnEntry = new System.Windows.Forms.Button();
            this.panelAuth = new System.Windows.Forms.Panel();
            this.panelAuth.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAuth
            // 
            this.lblAuth.AutoSize = true;
            this.lblAuth.Location = new System.Drawing.Point(96, 21);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(73, 13);
            this.lblAuth.TabIndex = 0;
            this.lblAuth.Text = "Авторизация\r\n";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(41, 17);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(129, 20);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.Text = "Логин";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(41, 52);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(129, 20);
            this.tbPass.TabIndex = 2;
            this.tbPass.Text = "Пароль";
            // 
            // btnEntry
            // 
            this.btnEntry.Location = new System.Drawing.Point(94, 160);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(75, 23);
            this.btnEntry.TabIndex = 3;
            this.btnEntry.Text = "Войти";
            this.btnEntry.UseVisualStyleBackColor = true;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // panelAuth
            // 
            this.panelAuth.Controls.Add(this.tbLogin);
            this.panelAuth.Controls.Add(this.tbPass);
            this.panelAuth.Location = new System.Drawing.Point(35, 54);
            this.panelAuth.Name = "panelAuth";
            this.panelAuth.Size = new System.Drawing.Size(200, 100);
            this.panelAuth.TabIndex = 6;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 201);
            this.Controls.Add(this.panelAuth);
            this.Controls.Add(this.btnEntry);
            this.Controls.Add(this.lblAuth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AuthorizationForm";
            this.Text = "Старт Поволжье";
            this.panelAuth.ResumeLayout(false);
            this.panelAuth.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAuth;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Panel panelAuth;
    }
}

