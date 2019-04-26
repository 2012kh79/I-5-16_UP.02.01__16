namespace UP_02._01
{
    partial class RegistrationForm
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
            this.btReg = new System.Windows.Forms.Button();
            this.btBackAuthoriz = new System.Windows.Forms.Button();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbAuth = new System.Windows.Forms.Label();
            this.tbRepeatPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btReg
            // 
            this.btReg.Location = new System.Drawing.Point(233, 275);
            this.btReg.Name = "btReg";
            this.btReg.Size = new System.Drawing.Size(85, 23);
            this.btReg.TabIndex = 13;
            this.btReg.Text = "Регистрация";
            this.btReg.UseVisualStyleBackColor = true;
            this.btReg.Click += new System.EventHandler(this.btReg_Click);
            // 
            // btBackAuthoriz
            // 
            this.btBackAuthoriz.Location = new System.Drawing.Point(324, 275);
            this.btBackAuthoriz.Name = "btBackAuthoriz";
            this.btBackAuthoriz.Size = new System.Drawing.Size(135, 23);
            this.btBackAuthoriz.TabIndex = 12;
            this.btBackAuthoriz.Text = "Переход к авторизации";
            this.btBackAuthoriz.UseVisualStyleBackColor = true;
            this.btBackAuthoriz.Click += new System.EventHandler(this.btBackAuthoriz_Click);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(179, 190);
            this.tbPass.MaxLength = 16;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(280, 20);
            this.tbPass.TabIndex = 11;
            this.tbPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLogin_KeyPress);
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(179, 150);
            this.tbLogin.MaxLength = 16;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(280, 20);
            this.tbLogin.TabIndex = 10;
            this.tbLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLogin_KeyPress);
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.BackColor = System.Drawing.Color.Transparent;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPass.Location = new System.Drawing.Point(95, 190);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(67, 20);
            this.lbPass.TabIndex = 9;
            this.lbPass.Text = "Пароль";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLogin.Location = new System.Drawing.Point(95, 150);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(55, 20);
            this.lbLogin.TabIndex = 8;
            this.lbLogin.Text = "Логин";
            // 
            // lbAuth
            // 
            this.lbAuth.AutoSize = true;
            this.lbAuth.BackColor = System.Drawing.Color.Transparent;
            this.lbAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAuth.Location = new System.Drawing.Point(90, 68);
            this.lbAuth.Name = "lbAuth";
            this.lbAuth.Size = new System.Drawing.Size(277, 51);
            this.lbAuth.TabIndex = 7;
            this.lbAuth.Text = "Регистрация";
            // 
            // tbRepeatPass
            // 
            this.tbRepeatPass.Location = new System.Drawing.Point(179, 228);
            this.tbRepeatPass.MaxLength = 16;
            this.tbRepeatPass.Name = "tbRepeatPass";
            this.tbRepeatPass.PasswordChar = '*';
            this.tbRepeatPass.Size = new System.Drawing.Size(280, 20);
            this.tbRepeatPass.TabIndex = 15;
            this.tbRepeatPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLogin_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Повтор пароля";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 339);
            this.Controls.Add(this.tbRepeatPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btReg);
            this.Controls.Add(this.btBackAuthoriz);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbAuth);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btReg;
        private System.Windows.Forms.Button btBackAuthoriz;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbAuth;
        private System.Windows.Forms.TextBox tbRepeatPass;
        private System.Windows.Forms.Label label1;
    }
}