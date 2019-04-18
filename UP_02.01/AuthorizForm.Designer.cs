namespace UP_02._01
{
    partial class AuthorizForm
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
            this.lbAuth = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btVhod = new System.Windows.Forms.Button();
            this.btReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAuth
            // 
            this.lbAuth.AutoSize = true;
            this.lbAuth.BackColor = System.Drawing.Color.Transparent;
            this.lbAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAuth.Location = new System.Drawing.Point(51, 81);
            this.lbAuth.Name = "lbAuth";
            this.lbAuth.Size = new System.Drawing.Size(284, 51);
            this.lbAuth.TabIndex = 0;
            this.lbAuth.Text = "Авторизация";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLogin.Location = new System.Drawing.Point(37, 168);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(55, 20);
            this.lbLogin.TabIndex = 1;
            this.lbLogin.Text = "Логин";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.BackColor = System.Drawing.Color.Transparent;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPass.Location = new System.Drawing.Point(37, 208);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(67, 20);
            this.lbPass.TabIndex = 2;
            this.lbPass.Text = "Пароль";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(121, 168);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(214, 20);
            this.tbLogin.TabIndex = 3;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(121, 208);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(214, 20);
            this.tbPass.TabIndex = 4;
            // 
            // btVhod
            // 
            this.btVhod.Location = new System.Drawing.Point(169, 263);
            this.btVhod.Name = "btVhod";
            this.btVhod.Size = new System.Drawing.Size(75, 23);
            this.btVhod.TabIndex = 5;
            this.btVhod.Text = "Вход";
            this.btVhod.UseVisualStyleBackColor = true;
            this.btVhod.Click += new System.EventHandler(this.btVhod_Click);
            // 
            // btReg
            // 
            this.btReg.Location = new System.Drawing.Point(250, 263);
            this.btReg.Name = "btReg";
            this.btReg.Size = new System.Drawing.Size(85, 23);
            this.btReg.TabIndex = 6;
            this.btReg.Text = "Регистрация";
            this.btReg.UseVisualStyleBackColor = true;
            this.btReg.Click += new System.EventHandler(this.btReg_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UP_02._01.Properties.Resources.Form1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(368, 346);
            this.Controls.Add(this.btReg);
            this.Controls.Add(this.btVhod);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbAuth);
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAuth;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btVhod;
        private System.Windows.Forms.Button btReg;
    }
}

