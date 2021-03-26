namespace FCSchoolLibrary
{
    partial class FormAuthors
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
            this.lb_authors = new System.Windows.Forms.ListBox();
            this.txbx_newAuthorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_saveNewAuthorsName = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.btn_close.TabIndex = 20;
            this.btn_close.Text = "Закрыть";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lb_authors
            // 
            this.lb_authors.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_authors.FormattingEnabled = true;
            this.lb_authors.ItemHeight = 18;
            this.lb_authors.Location = new System.Drawing.Point(12, 12);
            this.lb_authors.Name = "lb_authors";
            this.lb_authors.Size = new System.Drawing.Size(422, 490);
            this.lb_authors.TabIndex = 22;
            this.lb_authors.SelectedIndexChanged += new System.EventHandler(this.lb_authors_SelectedIndexChanged);
            // 
            // txbx_newAuthorName
            // 
            this.txbx_newAuthorName.BackColor = System.Drawing.Color.LightCyan;
            this.txbx_newAuthorName.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_newAuthorName.Location = new System.Drawing.Point(122, 519);
            this.txbx_newAuthorName.Name = "txbx_newAuthorName";
            this.txbx_newAuthorName.Size = new System.Drawing.Size(312, 27);
            this.txbx_newAuthorName.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 522);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Новое имя:";
            // 
            // btn_saveNewAuthorsName
            // 
            this.btn_saveNewAuthorsName.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_saveNewAuthorsName.ForeColor = System.Drawing.Color.Black;
            this.btn_saveNewAuthorsName.Image = global::FCSchoolLibrary.Properties.Resources.Save_32px;
            this.btn_saveNewAuthorsName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_saveNewAuthorsName.Location = new System.Drawing.Point(12, 562);
            this.btn_saveNewAuthorsName.Name = "btn_saveNewAuthorsName";
            this.btn_saveNewAuthorsName.Size = new System.Drawing.Size(131, 38);
            this.btn_saveNewAuthorsName.TabIndex = 25;
            this.btn_saveNewAuthorsName.Text = "Сохранить";
            this.btn_saveNewAuthorsName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_saveNewAuthorsName.UseVisualStyleBackColor = true;
            this.btn_saveNewAuthorsName.Click += new System.EventHandler(this.btn_saveNewAuthorsName_Click);
            // 
            // FormAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 608);
            this.Controls.Add(this.btn_saveNewAuthorsName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_newAuthorName);
            this.Controls.Add(this.lb_authors);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAuthors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справочник авторов";
            this.Load += new System.EventHandler(this.FormAuthors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ListBox lb_authors;
        private System.Windows.Forms.TextBox txbx_newAuthorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_saveNewAuthorsName;
    }
}