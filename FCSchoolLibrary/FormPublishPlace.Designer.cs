namespace FCSchoolLibrary
{
    partial class FormPublishPlace
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
            this.btn_savePublishPlaceName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_newPublishPlaceName = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.lb_publishPlace = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_savePublishPlaceName
            // 
            this.btn_savePublishPlaceName.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_savePublishPlaceName.ForeColor = System.Drawing.Color.Black;
            this.btn_savePublishPlaceName.Image = global::FCSchoolLibrary.Properties.Resources.Save_32px;
            this.btn_savePublishPlaceName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_savePublishPlaceName.Location = new System.Drawing.Point(12, 562);
            this.btn_savePublishPlaceName.Name = "btn_savePublishPlaceName";
            this.btn_savePublishPlaceName.Size = new System.Drawing.Size(131, 38);
            this.btn_savePublishPlaceName.TabIndex = 36;
            this.btn_savePublishPlaceName.Text = "Сохранить";
            this.btn_savePublishPlaceName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_savePublishPlaceName.UseVisualStyleBackColor = true;
            this.btn_savePublishPlaceName.Click += new System.EventHandler(this.btn_savePublishPlaceName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Новое имя:";
            // 
            // txbx_newPublishPlaceName
            // 
            this.txbx_newPublishPlaceName.BackColor = System.Drawing.Color.LightCyan;
            this.txbx_newPublishPlaceName.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_newPublishPlaceName.Location = new System.Drawing.Point(122, 519);
            this.txbx_newPublishPlaceName.Name = "txbx_newPublishPlaceName";
            this.txbx_newPublishPlaceName.Size = new System.Drawing.Size(312, 27);
            this.txbx_newPublishPlaceName.TabIndex = 34;
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Image = global::FCSchoolLibrary.Properties.Resources.Close_Window_32px;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_close.Location = new System.Drawing.Point(319, 561);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(115, 39);
            this.btn_close.TabIndex = 33;
            this.btn_close.Text = "Закрыть";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lb_publishPlace
            // 
            this.lb_publishPlace.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_publishPlace.FormattingEnabled = true;
            this.lb_publishPlace.ItemHeight = 18;
            this.lb_publishPlace.Location = new System.Drawing.Point(12, 12);
            this.lb_publishPlace.Name = "lb_publishPlace";
            this.lb_publishPlace.Size = new System.Drawing.Size(422, 490);
            this.lb_publishPlace.TabIndex = 32;
            this.lb_publishPlace.SelectedIndexChanged += new System.EventHandler(this.lb_publishPlace_SelectedIndexChanged);
            // 
            // FormPublishPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 608);
            this.Controls.Add(this.btn_savePublishPlaceName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_newPublishPlaceName);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lb_publishPlace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormPublishPlace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник места издания";
            this.Load += new System.EventHandler(this.FormPublishPlace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_savePublishPlaceName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_newPublishPlaceName;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ListBox lb_publishPlace;
    }
}