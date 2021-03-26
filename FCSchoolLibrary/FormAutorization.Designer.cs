namespace FCSchoolLibrary
{
    partial class FormAutorization
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
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.txbx_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chbx_savePassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_login.ForeColor = System.Drawing.Color.Black;
            this.btn_login.Image = global::FCSchoolLibrary.Properties.Resources.Login_32px;
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_login.Location = new System.Drawing.Point(12, 121);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(160, 37);
            this.btn_login.TabIndex = 22;
            this.btn_login.Text = "Войти";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Image = global::FCSchoolLibrary.Properties.Resources.Close_Window_32px;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_close.Location = new System.Drawing.Point(178, 121);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(114, 38);
            this.btn_close.TabIndex = 21;
            this.btn_close.Text = "Закрыть";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txbx_password
            // 
            this.txbx_password.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_password.Location = new System.Drawing.Point(142, 25);
            this.txbx_password.Name = "txbx_password";
            this.txbx_password.PasswordChar = '*';
            this.txbx_password.Size = new System.Drawing.Size(150, 27);
            this.txbx_password.TabIndex = 24;
            this.txbx_password.UseSystemPasswordChar = true;
            this.txbx_password.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbx_password_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Введите пароль:";
            // 
            // chbx_savePassword
            // 
            this.chbx_savePassword.AutoSize = true;
            this.chbx_savePassword.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbx_savePassword.Location = new System.Drawing.Point(74, 75);
            this.chbx_savePassword.Name = "chbx_savePassword";
            this.chbx_savePassword.Size = new System.Drawing.Size(159, 22);
            this.chbx_savePassword.TabIndex = 26;
            this.chbx_savePassword.Text = "Сохранить пароль";
            this.chbx_savePassword.UseVisualStyleBackColor = true;
            // 
            // FormAutorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 171);
            this.Controls.Add(this.chbx_savePassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_password);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAutorization";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация пользователя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAutorization_FormClosing);
            this.Load += new System.EventHandler(this.FormAutorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txbx_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbx_savePassword;
    }
}