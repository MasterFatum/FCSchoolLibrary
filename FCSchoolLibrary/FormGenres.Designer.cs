namespace FCSchoolLibrary
{
    partial class FormGenres
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
            this.lb_genres = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_newGenresName = new System.Windows.Forms.TextBox();
            this.btn_saveNewGenresName = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_genres
            // 
            this.lb_genres.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_genres.FormattingEnabled = true;
            this.lb_genres.ItemHeight = 18;
            this.lb_genres.Location = new System.Drawing.Point(12, 12);
            this.lb_genres.Name = "lb_genres";
            this.lb_genres.Size = new System.Drawing.Size(422, 490);
            this.lb_genres.TabIndex = 27;
            this.lb_genres.SelectedIndexChanged += new System.EventHandler(this.lb_genres_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Новое имя:";
            // 
            // txbx_newGenresName
            // 
            this.txbx_newGenresName.BackColor = System.Drawing.Color.LightCyan;
            this.txbx_newGenresName.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_newGenresName.Location = new System.Drawing.Point(122, 519);
            this.txbx_newGenresName.Name = "txbx_newGenresName";
            this.txbx_newGenresName.Size = new System.Drawing.Size(312, 27);
            this.txbx_newGenresName.TabIndex = 29;
            // 
            // btn_saveNewGenresName
            // 
            this.btn_saveNewGenresName.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_saveNewGenresName.ForeColor = System.Drawing.Color.Black;
            this.btn_saveNewGenresName.Image = global::FCSchoolLibrary.Properties.Resources.Save_32px;
            this.btn_saveNewGenresName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_saveNewGenresName.Location = new System.Drawing.Point(12, 562);
            this.btn_saveNewGenresName.Name = "btn_saveNewGenresName";
            this.btn_saveNewGenresName.Size = new System.Drawing.Size(131, 38);
            this.btn_saveNewGenresName.TabIndex = 31;
            this.btn_saveNewGenresName.Text = "Сохранить";
            this.btn_saveNewGenresName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_saveNewGenresName.UseVisualStyleBackColor = true;
            this.btn_saveNewGenresName.Click += new System.EventHandler(this.btn_saveNewGenresName_Click);
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
            this.btn_close.TabIndex = 28;
            this.btn_close.Text = "Закрыть";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // FormGenres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 608);
            this.Controls.Add(this.btn_saveNewGenresName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_newGenresName);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lb_genres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormGenres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справочник жанров";
            this.Load += new System.EventHandler(this.FormGenres_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ListBox lb_genres;
        private System.Windows.Forms.Button btn_saveNewGenresName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_newGenresName;
    }
}