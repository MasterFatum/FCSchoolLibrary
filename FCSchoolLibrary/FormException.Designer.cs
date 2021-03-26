namespace FCSchoolLibrary
{
    partial class FormException
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
            this.txbx_errorText = new System.Windows.Forms.TextBox();
            this.btn_sendReport = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbx_errorText
            // 
            this.txbx_errorText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbx_errorText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_errorText.Location = new System.Drawing.Point(12, 12);
            this.txbx_errorText.Multiline = true;
            this.txbx_errorText.Name = "txbx_errorText";
            this.txbx_errorText.ReadOnly = true;
            this.txbx_errorText.Size = new System.Drawing.Size(471, 212);
            this.txbx_errorText.TabIndex = 0;
            // 
            // btn_sendReport
            // 
            this.btn_sendReport.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_sendReport.ForeColor = System.Drawing.Color.Black;
            this.btn_sendReport.Image = global::FCSchoolLibrary.Properties.Resources.Envelope_32px;
            this.btn_sendReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sendReport.Location = new System.Drawing.Point(12, 230);
            this.btn_sendReport.Name = "btn_sendReport";
            this.btn_sendReport.Size = new System.Drawing.Size(273, 39);
            this.btn_sendReport.TabIndex = 1;
            this.btn_sendReport.Text = "Отправить отчет об ошибке";
            this.btn_sendReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sendReport.UseVisualStyleBackColor = true;
            this.btn_sendReport.Click += new System.EventHandler(this.btn_sendReport_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Image = global::FCSchoolLibrary.Properties.Resources.Close_Window_32px;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_close.Location = new System.Drawing.Point(368, 230);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(115, 39);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Закрыть";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // FormException
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(495, 278);
            this.Controls.Add(this.btn_sendReport);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.txbx_errorText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormException";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Форма ошибок";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_sendReport;
        public System.Windows.Forms.TextBox txbx_errorText;
    }
}