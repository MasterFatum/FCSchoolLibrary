namespace FCSchoolLibrary
{
    partial class FormSettingsMail
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbx_useSsl = new System.Windows.Forms.CheckBox();
            this.txbx_mailPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbx_mailServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbx_mailPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbx_mailUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ok.ForeColor = System.Drawing.Color.Black;
            this.btn_ok.Image = global::FCSchoolLibrary.Properties.Resources.Save_32px;
            this.btn_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ok.Location = new System.Drawing.Point(12, 267);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(135, 39);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "Сохранить";
            this.btn_ok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Image = global::FCSchoolLibrary.Properties.Resources.Close_Window_32px;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_close.Location = new System.Drawing.Point(335, 267);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(115, 39);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "Закрыть";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Данные учетной записи вашей электронной почты необходимы для \r\nотправки отчета об" +
    " ошибках разработчку программного обеспечения\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbx_useSsl);
            this.groupBox1.Controls.Add(this.txbx_mailPort);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbx_mailServer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbx_mailPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbx_mailUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 200);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Учетная запись";
            // 
            // chbx_useSsl
            // 
            this.chbx_useSsl.AutoSize = true;
            this.chbx_useSsl.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbx_useSsl.Location = new System.Drawing.Point(276, 169);
            this.chbx_useSsl.Name = "chbx_useSsl";
            this.chbx_useSsl.Size = new System.Drawing.Size(159, 22);
            this.chbx_useSsl.TabIndex = 5;
            this.chbx_useSsl.Text = "Использовать SSL";
            this.chbx_useSsl.UseVisualStyleBackColor = true;
            // 
            // txbx_mailPort
            // 
            this.txbx_mailPort.BackColor = System.Drawing.Color.LightCyan;
            this.txbx_mailPort.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_mailPort.Location = new System.Drawing.Point(327, 131);
            this.txbx_mailPort.Name = "txbx_mailPort";
            this.txbx_mailPort.Size = new System.Drawing.Size(105, 26);
            this.txbx_mailPort.TabIndex = 4;
            this.txbx_mailPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(229, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "SMTP порт:";
            // 
            // txbx_mailServer
            // 
            this.txbx_mailServer.BackColor = System.Drawing.Color.LightCyan;
            this.txbx_mailServer.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_mailServer.Location = new System.Drawing.Point(139, 100);
            this.txbx_mailServer.Name = "txbx_mailServer";
            this.txbx_mailServer.Size = new System.Drawing.Size(293, 26);
            this.txbx_mailServer.TabIndex = 3;
            this.txbx_mailServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "SMTP сервер:";
            // 
            // txbx_mailPassword
            // 
            this.txbx_mailPassword.BackColor = System.Drawing.Color.LightCyan;
            this.txbx_mailPassword.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_mailPassword.Location = new System.Drawing.Point(139, 69);
            this.txbx_mailPassword.Name = "txbx_mailPassword";
            this.txbx_mailPassword.PasswordChar = '*';
            this.txbx_mailPassword.Size = new System.Drawing.Size(293, 26);
            this.txbx_mailPassword.TabIndex = 2;
            this.txbx_mailPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль:";
            // 
            // txbx_mailUsername
            // 
            this.txbx_mailUsername.BackColor = System.Drawing.Color.LightCyan;
            this.txbx_mailUsername.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_mailUsername.Location = new System.Drawing.Point(139, 38);
            this.txbx_mailUsername.Name = "txbx_mailUsername";
            this.txbx_mailUsername.Size = new System.Drawing.Size(293, 26);
            this.txbx_mailUsername.TabIndex = 1;
            this.txbx_mailUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Логин:";
            // 
            // FormSettingsMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(462, 316);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSettingsMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Учетная запись электронной почты";
            this.Load += new System.EventHandler(this.FormSettingsMail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbx_mailPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbx_mailServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbx_mailPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbx_mailUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbx_useSsl;
    }
}