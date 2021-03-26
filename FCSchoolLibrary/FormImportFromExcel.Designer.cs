namespace FCSchoolLibrary
{
    partial class FormImportFromExcel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_bookFromExcel = new System.Windows.Forms.DataGridView();
            this.btn_uploadToDB = new System.Windows.Forms.Button();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_booksLoad = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_bookLoad = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.InventaryNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Series = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cipher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PagesCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bookFromExcel)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_bookFromExcel
            // 
            this.dgv_bookFromExcel.AllowUserToResizeColumns = false;
            this.dgv_bookFromExcel.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv_bookFromExcel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_bookFromExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_bookFromExcel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_bookFromExcel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_bookFromExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bookFromExcel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InventaryNumber,
            this.Author,
            this.NameBook,
            this.Year,
            this.PublishPlace,
            this.PublishName,
            this.Series,
            this.Count,
            this.Price,
            this.Department,
            this.Cipher,
            this.PagesCount,
            this.Subject,
            this.Genre,
            this.ISBN,
            this.Age,
            this.Date});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_bookFromExcel.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_bookFromExcel.Location = new System.Drawing.Point(12, 12);
            this.dgv_bookFromExcel.Name = "dgv_bookFromExcel";
            this.dgv_bookFromExcel.Size = new System.Drawing.Size(1170, 494);
            this.dgv_bookFromExcel.TabIndex = 4;
            this.dgv_bookFromExcel.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_bookFromExcel_RowsAdded);
            // 
            // btn_uploadToDB
            // 
            this.btn_uploadToDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_uploadToDB.Enabled = false;
            this.btn_uploadToDB.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_uploadToDB.ForeColor = System.Drawing.Color.Black;
            this.btn_uploadToDB.Image = global::FCSchoolLibrary.Properties.Resources.Add_Database_32px;
            this.btn_uploadToDB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_uploadToDB.Location = new System.Drawing.Point(224, 512);
            this.btn_uploadToDB.Name = "btn_uploadToDB";
            this.btn_uploadToDB.Size = new System.Drawing.Size(246, 39);
            this.btn_uploadToDB.TabIndex = 2;
            this.btn_uploadToDB.Text = "Загрузить в базу данных";
            this.btn_uploadToDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_uploadToDB.UseVisualStyleBackColor = true;
            this.btn_uploadToDB.Click += new System.EventHandler(this.btn_uploadToDB_Click);
            // 
            // btn_openFile
            // 
            this.btn_openFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_openFile.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_openFile.ForeColor = System.Drawing.Color.Black;
            this.btn_openFile.Image = global::FCSchoolLibrary.Properties.Resources.Open_32px;
            this.btn_openFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_openFile.Location = new System.Drawing.Point(12, 512);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(206, 39);
            this.btn_openFile.TabIndex = 1;
            this.btn_openFile.Text = "Открыть файл Excel";
            this.btn_openFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_openFile.UseVisualStyleBackColor = true;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Image = global::FCSchoolLibrary.Properties.Resources.Close_Window_32px;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_close.Location = new System.Drawing.Point(1067, 512);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(115, 39);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Закрыть";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.lbl_booksLoad});
            this.statusStrip1.Location = new System.Drawing.Point(0, 552);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1194, 24);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(142, 19);
            this.toolStripStatusLabel2.Text = "Книг загружено:";
            // 
            // lbl_booksLoad
            // 
            this.lbl_booksLoad.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_booksLoad.Name = "lbl_booksLoad";
            this.lbl_booksLoad.Size = new System.Drawing.Size(18, 19);
            this.lbl_booksLoad.Text = "0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(129, 18);
            this.toolStripStatusLabel1.Text = "Загружено книг:";
            // 
            // status_bookLoad
            // 
            this.status_bookLoad.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status_bookLoad.ForeColor = System.Drawing.Color.Black;
            this.status_bookLoad.Name = "status_bookLoad";
            this.status_bookLoad.Size = new System.Drawing.Size(16, 18);
            this.status_bookLoad.Text = "0";
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear.Enabled = false;
            this.btn_clear.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Image = global::FCSchoolLibrary.Properties.Resources.Broom_32px;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.Location = new System.Drawing.Point(889, 512);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(172, 39);
            this.btn_clear.TabIndex = 24;
            this.btn_clear.Text = "Очистить список";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // InventaryNumber
            // 
            this.InventaryNumber.HeaderText = "Инвентарный номер";
            this.InventaryNumber.Name = "InventaryNumber";
            this.InventaryNumber.Width = 166;
            // 
            // Author
            // 
            this.Author.HeaderText = "Автор";
            this.Author.Name = "Author";
            this.Author.Width = 76;
            // 
            // NameBook
            // 
            this.NameBook.HeaderText = "Название";
            this.NameBook.Name = "NameBook";
            this.NameBook.Width = 103;
            // 
            // Year
            // 
            this.Year.HeaderText = "Год издания";
            this.Year.Name = "Year";
            this.Year.Width = 113;
            // 
            // PublishPlace
            // 
            this.PublishPlace.HeaderText = "Место издания";
            this.PublishPlace.Name = "PublishPlace";
            this.PublishPlace.Width = 129;
            // 
            // PublishName
            // 
            this.PublishName.HeaderText = "Издательство";
            this.PublishName.Name = "PublishName";
            this.PublishName.Width = 132;
            // 
            // Series
            // 
            this.Series.HeaderText = "Серия";
            this.Series.Name = "Series";
            this.Series.Width = 79;
            // 
            // Count
            // 
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            this.Count.Width = 117;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.Width = 70;
            // 
            // Department
            // 
            this.Department.HeaderText = "Отдел";
            this.Department.Name = "Department";
            this.Department.Width = 78;
            // 
            // Cipher
            // 
            this.Cipher.HeaderText = "Шифр";
            this.Cipher.Name = "Cipher";
            this.Cipher.Width = 78;
            // 
            // PagesCount
            // 
            this.PagesCount.HeaderText = "Страниц";
            this.PagesCount.Name = "PagesCount";
            this.PagesCount.Width = 95;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Тема";
            this.Subject.Name = "Subject";
            this.Subject.Width = 70;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Жанр";
            this.Genre.Name = "Genre";
            this.Genre.Width = 74;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.Width = 71;
            // 
            // Age
            // 
            this.Age.HeaderText = "Возраст";
            this.Age.Name = "Age";
            this.Age.Width = 90;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.Width = 68;
            // 
            // FormImportFromExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1194, 576);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_uploadToDB);
            this.Controls.Add(this.btn_openFile);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.dgv_bookFromExcel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormImportFromExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Импортировать данные из Excel";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bookFromExcel)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_bookFromExcel;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.Button btn_uploadToDB;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel status_bookLoad;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lbl_booksLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventaryNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Series;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cipher;
        private System.Windows.Forms.DataGridViewTextBoxColumn PagesCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}