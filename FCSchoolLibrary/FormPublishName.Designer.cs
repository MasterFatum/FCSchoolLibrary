namespace FCSchoolLibrary
{
    partial class FormPublishHouse
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
            this.btn_saveNewPublishName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_newPublishName = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.lb_publishName = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_saveNewPublishName
            // 
            this.btn_saveNewPublishName.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_saveNewPublishName.ForeColor = System.Drawing.Color.Black;
            this.btn_saveNewPublishName.Image = global::FCSchoolLibrary.Properties.Resources.Save_32px;
            this.btn_saveNewPublishName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_saveNewPublishName.Location = new System.Drawing.Point(12, 562);
            this.btn_saveNewPublishName.Name = "btn_saveNewPublishName";
            this.btn_saveNewPublishName.Size = new System.Drawing.Size(131, 38);
            this.btn_saveNewPublishName.TabIndex = 36;
            this.btn_saveNewPublishName.Text = "Сохранить";
            this.btn_saveNewPublishName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_saveNewPublishName.UseVisualStyleBackColor = true;
            this.btn_saveNewPublishName.Click += new System.EventHandler(this.btn_saveNewPublishName_Click);
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
            // txbx_newPublishName
            // 
            this.txbx_newPublishName.BackColor = System.Drawing.Color.LightCyan;
            this.txbx_newPublishName.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_newPublishName.Location = new System.Drawing.Point(122, 519);
            this.txbx_newPublishName.Name = "txbx_newPublishName";
            this.txbx_newPublishName.Size = new System.Drawing.Size(312, 27);
            this.txbx_newPublishName.TabIndex = 34;
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
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click_1);
            // 
            // lb_publishName
            // 
            this.lb_publishName.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_publishName.FormattingEnabled = true;
            this.lb_publishName.ItemHeight = 18;
            this.lb_publishName.Location = new System.Drawing.Point(12, 12);
            this.lb_publishName.Name = "lb_publishName";
            this.lb_publishName.Size = new System.Drawing.Size(422, 490);
            this.lb_publishName.TabIndex = 32;
            this.lb_publishName.SelectedIndexChanged += new System.EventHandler(this.lb_publishName_SelectedIndexChanged);
            // 
            // FormPublishHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 608);
            this.Controls.Add(this.btn_saveNewPublishName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_newPublishName);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lb_publishName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormPublishHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справочник издательств";
            this.Load += new System.EventHandler(this.FormPublishHouse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_saveNewPublishName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_newPublishName;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ListBox lb_publishName;
    }
}