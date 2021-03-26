namespace FCSchoolLibrary
{
    partial class FormConnectionString
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
            this.btn_close = new System.Windows.Forms.Button();
            this.txbx_connectionString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Image = global::FCSchoolLibrary.Properties.Resources.Close_Window_32px;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_close.Location = new System.Drawing.Point(465, 63);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(115, 38);
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "Закрыть";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txbx_connectionString
            // 
            this.txbx_connectionString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbx_connectionString.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_connectionString.Location = new System.Drawing.Point(12, 35);
            this.txbx_connectionString.Name = "txbx_connectionString";
            this.txbx_connectionString.Size = new System.Drawing.Size(568, 22);
            this.txbx_connectionString.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Строка подключения:";
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_edit.ForeColor = System.Drawing.Color.Black;
            this.btn_edit.Image = global::FCSchoolLibrary.Properties.Resources.Save_32px;
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_edit.Location = new System.Drawing.Point(12, 63);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(131, 38);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.Text = "Сохранить";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // FormConnectionString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(592, 111);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_connectionString);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormConnectionString";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Строка подключение к базе данных";
            this.Load += new System.EventHandler(this.FormConnectionString_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txbx_connectionString;
        private System.Windows.Forms.Label label1;
    }
}