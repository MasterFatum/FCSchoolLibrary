namespace FCSchoolLibrary
{
    partial class FormCipher
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
            this.btn_saveNewCipherName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_newCipherName = new System.Windows.Forms.TextBox();
            this.lb_cipher = new System.Windows.Forms.ListBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_saveNewCipherName
            // 
            this.btn_saveNewCipherName.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_saveNewCipherName.ForeColor = System.Drawing.Color.Black;
            this.btn_saveNewCipherName.Image = global::FCSchoolLibrary.Properties.Resources.Save_32px;
            this.btn_saveNewCipherName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_saveNewCipherName.Location = new System.Drawing.Point(12, 562);
            this.btn_saveNewCipherName.Name = "btn_saveNewCipherName";
            this.btn_saveNewCipherName.Size = new System.Drawing.Size(131, 38);
            this.btn_saveNewCipherName.TabIndex = 30;
            this.btn_saveNewCipherName.Text = "Сохранить";
            this.btn_saveNewCipherName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_saveNewCipherName.UseVisualStyleBackColor = true;
            this.btn_saveNewCipherName.Click += new System.EventHandler(this.btn_saveNewCipherName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 522);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Новое имя:";
            // 
            // txbx_newCipherName
            // 
            this.txbx_newCipherName.BackColor = System.Drawing.Color.LightCyan;
            this.txbx_newCipherName.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_newCipherName.Location = new System.Drawing.Point(122, 519);
            this.txbx_newCipherName.Name = "txbx_newCipherName";
            this.txbx_newCipherName.Size = new System.Drawing.Size(312, 27);
            this.txbx_newCipherName.TabIndex = 28;
            // 
            // lb_cipher
            // 
            this.lb_cipher.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_cipher.FormattingEnabled = true;
            this.lb_cipher.ItemHeight = 18;
            this.lb_cipher.Location = new System.Drawing.Point(12, 12);
            this.lb_cipher.Name = "lb_cipher";
            this.lb_cipher.Size = new System.Drawing.Size(422, 490);
            this.lb_cipher.TabIndex = 27;
            this.lb_cipher.SelectedIndexChanged += new System.EventHandler(this.lb_cipher_SelectedIndexChanged);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Image = global::FCSchoolLibrary.Properties.Resources.Close_Window_32px;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_close.Location = new System.Drawing.Point(319, 562);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(115, 38);
            this.btn_close.TabIndex = 26;
            this.btn_close.Text = "Закрыть";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // FormCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 608);
            this.Controls.Add(this.btn_saveNewCipherName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_newCipherName);
            this.Controls.Add(this.lb_cipher);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCipher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник шифров";
            this.Load += new System.EventHandler(this.FormCipher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_saveNewCipherName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_newCipherName;
        private System.Windows.Forms.ListBox lb_cipher;
        private System.Windows.Forms.Button btn_close;
    }
}