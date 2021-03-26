namespace FCSchoolLibrary
{
    partial class FormSeries
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
            this.txbx_newSeriesName = new System.Windows.Forms.TextBox();
            this.lb_series = new System.Windows.Forms.ListBox();
            this.btn_saveNewSeriesName = new System.Windows.Forms.Button();
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
            // txbx_newSeriesName
            // 
            this.txbx_newSeriesName.BackColor = System.Drawing.Color.LightCyan;
            this.txbx_newSeriesName.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_newSeriesName.Location = new System.Drawing.Point(122, 519);
            this.txbx_newSeriesName.Name = "txbx_newSeriesName";
            this.txbx_newSeriesName.Size = new System.Drawing.Size(312, 27);
            this.txbx_newSeriesName.TabIndex = 28;
            // 
            // lb_series
            // 
            this.lb_series.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_series.FormattingEnabled = true;
            this.lb_series.ItemHeight = 18;
            this.lb_series.Location = new System.Drawing.Point(12, 12);
            this.lb_series.Name = "lb_series";
            this.lb_series.Size = new System.Drawing.Size(422, 490);
            this.lb_series.TabIndex = 27;
            this.lb_series.SelectedIndexChanged += new System.EventHandler(this.lb_series_SelectedIndexChanged);
            // 
            // btn_saveNewSeriesName
            // 
            this.btn_saveNewSeriesName.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_saveNewSeriesName.ForeColor = System.Drawing.Color.Black;
            this.btn_saveNewSeriesName.Image = global::FCSchoolLibrary.Properties.Resources.Save_32px;
            this.btn_saveNewSeriesName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_saveNewSeriesName.Location = new System.Drawing.Point(12, 562);
            this.btn_saveNewSeriesName.Name = "btn_saveNewSeriesName";
            this.btn_saveNewSeriesName.Size = new System.Drawing.Size(131, 38);
            this.btn_saveNewSeriesName.TabIndex = 30;
            this.btn_saveNewSeriesName.Text = "Сохранить";
            this.btn_saveNewSeriesName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_saveNewSeriesName.UseVisualStyleBackColor = true;
            this.btn_saveNewSeriesName.Click += new System.EventHandler(this.btn_saveNewSeriesName_Click);
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
            // FormSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 608);
            this.Controls.Add(this.btn_saveNewSeriesName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_newSeriesName);
            this.Controls.Add(this.lb_series);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSeries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник серий";
            this.Load += new System.EventHandler(this.FormSeries_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_saveNewSeriesName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_newSeriesName;
        private System.Windows.Forms.ListBox lb_series;
        private System.Windows.Forms.Button btn_close;
    }
}