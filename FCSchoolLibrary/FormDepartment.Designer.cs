namespace FCSchoolLibrary
{
    partial class FormDepartment
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_newDepartmentName = new System.Windows.Forms.TextBox();
            this.lb_department = new System.Windows.Forms.ListBox();
            this.btn_saveNewDepartmentName = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // txbx_newDepartmentName
            // 
            this.txbx_newDepartmentName.BackColor = System.Drawing.Color.LightCyan;
            this.txbx_newDepartmentName.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_newDepartmentName.Location = new System.Drawing.Point(122, 519);
            this.txbx_newDepartmentName.Name = "txbx_newDepartmentName";
            this.txbx_newDepartmentName.Size = new System.Drawing.Size(312, 27);
            this.txbx_newDepartmentName.TabIndex = 28;
            // 
            // lb_department
            // 
            this.lb_department.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_department.FormattingEnabled = true;
            this.lb_department.ItemHeight = 18;
            this.lb_department.Location = new System.Drawing.Point(12, 12);
            this.lb_department.Name = "lb_department";
            this.lb_department.Size = new System.Drawing.Size(422, 490);
            this.lb_department.TabIndex = 27;
            this.lb_department.SelectedIndexChanged += new System.EventHandler(this.lb_department_SelectedIndexChanged);
            // 
            // btn_saveNewDepartmentName
            // 
            this.btn_saveNewDepartmentName.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_saveNewDepartmentName.ForeColor = System.Drawing.Color.Black;
            this.btn_saveNewDepartmentName.Image = global::FCSchoolLibrary.Properties.Resources.Save_32px;
            this.btn_saveNewDepartmentName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_saveNewDepartmentName.Location = new System.Drawing.Point(12, 562);
            this.btn_saveNewDepartmentName.Name = "btn_saveNewDepartmentName";
            this.btn_saveNewDepartmentName.Size = new System.Drawing.Size(131, 38);
            this.btn_saveNewDepartmentName.TabIndex = 30;
            this.btn_saveNewDepartmentName.Text = "Сохранить";
            this.btn_saveNewDepartmentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_saveNewDepartmentName.UseVisualStyleBackColor = true;
            this.btn_saveNewDepartmentName.Click += new System.EventHandler(this.btn_saveNewDepartmentName_Click);
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
            // FormDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 608);
            this.Controls.Add(this.btn_saveNewDepartmentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_newDepartmentName);
            this.Controls.Add(this.lb_department);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник отделов";
            this.Load += new System.EventHandler(this.FormDepartment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_saveNewDepartmentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_newDepartmentName;
        private System.Windows.Forms.ListBox lb_department;
        private System.Windows.Forms.Button btn_close;
    }
}