namespace FCSchoolLibrary
{
    partial class FormSubjects
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
            this.btn_saveSubjectName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_newSubjectName = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.lb_subject = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_saveSubjectName
            // 
            this.btn_saveSubjectName.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_saveSubjectName.ForeColor = System.Drawing.Color.Black;
            this.btn_saveSubjectName.Image = global::FCSchoolLibrary.Properties.Resources.Save_32px;
            this.btn_saveSubjectName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_saveSubjectName.Location = new System.Drawing.Point(12, 562);
            this.btn_saveSubjectName.Name = "btn_saveSubjectName";
            this.btn_saveSubjectName.Size = new System.Drawing.Size(131, 38);
            this.btn_saveSubjectName.TabIndex = 41;
            this.btn_saveSubjectName.Text = "Сохранить";
            this.btn_saveSubjectName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_saveSubjectName.UseVisualStyleBackColor = true;
            this.btn_saveSubjectName.Click += new System.EventHandler(this.btn_saveSubjectName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "Новое имя:";
            // 
            // txbx_newSubjectName
            // 
            this.txbx_newSubjectName.BackColor = System.Drawing.Color.LightCyan;
            this.txbx_newSubjectName.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_newSubjectName.Location = new System.Drawing.Point(122, 519);
            this.txbx_newSubjectName.Name = "txbx_newSubjectName";
            this.txbx_newSubjectName.Size = new System.Drawing.Size(312, 27);
            this.txbx_newSubjectName.TabIndex = 39;
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
            this.btn_close.TabIndex = 38;
            this.btn_close.Text = "Закрыть";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lb_subject
            // 
            this.lb_subject.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_subject.FormattingEnabled = true;
            this.lb_subject.ItemHeight = 18;
            this.lb_subject.Location = new System.Drawing.Point(12, 12);
            this.lb_subject.Name = "lb_subject";
            this.lb_subject.Size = new System.Drawing.Size(422, 490);
            this.lb_subject.TabIndex = 37;
            this.lb_subject.SelectedIndexChanged += new System.EventHandler(this.lb_subject_SelectedIndexChanged);
            // 
            // FormSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 608);
            this.Controls.Add(this.btn_saveSubjectName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_newSubjectName);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lb_subject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSubjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справочник тем";
            this.Load += new System.EventHandler(this.FormSubjects_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_saveSubjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_newSubjectName;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ListBox lb_subject;
    }
}