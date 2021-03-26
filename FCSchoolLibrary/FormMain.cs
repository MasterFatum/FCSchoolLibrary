using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace FCSchoolLibrary
{
    public partial class FormMain : Form
    {
        FCSchoolLibrary fcSchoolLibrary = new FCSchoolLibrary();

        BLL bll = new BLL();

        private Timer time;

        public void Time(Object sender, EventArgs e)
        {
            toolStrip_time.Text = DateTime.Now.ToLongTimeString();
        }

        public void ApplicationExit()
        {
            DialogResult result = MessageBox.Show(@"Выйти из программы?", @"Выход", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
                fcSchoolLibrary.Dispose();
            }
        }
        
        public FormMain()
        {
            InitializeComponent();
            time = new Timer();
            time.Interval = 1000;
            time.Tick += Time;
            time.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            time.Start();
            new FormAutorization().ShowDialog();
            //GetStartApp();
            //bll.RenameDataGridView(dgv_books);
            

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }

        }

        
        public void GetStartApp()
        {
            
            try
            {
                var allBooks = fcSchoolLibrary.Books.ToList();

                if (allBooks.Count == 0)
                {
                    MessageBox.Show(@"Отсутствуют книги в базе данных!", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    NoComboBoxEvents();

                    dgv_books.DataSource = allBooks;

                    ResetAllComboBox();

                    statusCountBooksInDb.Text = dgv_books.RowCount.ToString();
                }
            }
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            } 
        }

        public void UpdateDataGridView()
        {
            try
            {
                fcSchoolLibrary.Dispose();

                fcSchoolLibrary = new FCSchoolLibrary();

                dgv_books.DataSource = fcSchoolLibrary.Books.ToList();

                statusCountBooksInDb.Text = dgv_books.RowCount.ToString();

            }
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            }
        }


        public void ResetAllComboBox()
        {
            try
            {
                cbx_author.DataSource = bll.GetBookAuthor();
                cbx_name.DataSource = bll.GetBookName();
                cbx_year.DataSource = bll.GetBookYear();
                cbx_inventoryNumber.DataSource = bll.GetBookInventoryNumber();
                cbx_subject.DataSource = bll.GetBookSubject();
                cbx_genre.DataSource = bll.GetBookGenre();

                cbx_author.SelectedIndex = -1;
                cbx_name.SelectedIndex = -1;
                cbx_year.SelectedIndex = -1;
                cbx_inventoryNumber.SelectedIndex = -1;
                cbx_subject.SelectedIndex = -1;
                cbx_genre.SelectedIndex = -1;

                dgv_books.DataSource = fcSchoolLibrary.Books.ToList();
                
            }
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormAddBook().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ApplicationExit();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationExit();
        }

        public void NoComboBoxEvents()
        {
            cbx_author.SelectedIndexChanged -= cbx_author_SelectedIndexChanged;
            cbx_name.SelectedIndexChanged -= cbx_name_SelectedIndexChanged;
            cbx_year.SelectedIndexChanged -= cbx_year_SelectedIndexChanged;
            cbx_inventoryNumber.SelectedIndexChanged -= cbx_count_SelectedIndexChanged;
            cbx_subject.SelectedIndexChanged -= cbx_subject_SelectedIndexChanged;
            cbx_genre.SelectedIndexChanged -= cbx_genre_SelectedIndexChanged;
        }

        public void YesComboBoxEvents()
        {
            cbx_author.SelectedIndexChanged += cbx_author_SelectedIndexChanged;
            cbx_name.SelectedIndexChanged += cbx_name_SelectedIndexChanged;
            cbx_year.SelectedIndexChanged += cbx_year_SelectedIndexChanged;
            cbx_inventoryNumber.SelectedIndexChanged += cbx_count_SelectedIndexChanged;
            cbx_subject.SelectedIndexChanged += cbx_subject_SelectedIndexChanged;
            cbx_genre.SelectedIndexChanged += cbx_genre_SelectedIndexChanged;
        }

        private void btnResetAllComboBox_Click(object sender, EventArgs e)
        {
            if (chbx_search.Checked)
            {
                GetStartApp();
                chbx_search.Checked = false;
                chbx_search.Checked = true;
            }
        }

        private void btn_updateDb_Click(object sender, EventArgs e)
        {
            UpdateDataGridView();
            bll.RenameDataGridView(dgv_books);
        }

        private void dgv_books_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( dgv_books.CurrentRow == null)
            {
                return;
            }

            var books = dgv_books.CurrentRow.DataBoundItem as Book;

            if (books == null)
            {
                return;
            }

            statusIdBook.Text = books.Id.ToString();
        }

        //РЕДАКТИРОВАТЬ КНИГУ


        private void btn_editBook_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 idBook = Convert.ToInt32(statusIdBook.Text);

                if (idBook != 0)
                {
                    FormEditBook formEditBook = new FormEditBook(idBook);
                    formEditBook.ShowDialog();
                }
                else
                {
                    MessageBox.Show(@"Выберите книгу!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            }
            
        }

        //УДАЛИТЬ КНИГУ

        private void btn_deleteBook_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(@"Вы действительно хотите удалить данную книгу?", @"Удаление книги",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var id = Convert.ToInt32(statusIdBook.Text);

                bll.DeleteBook(id, dgv_books);

                statusCountBooksInDb.Text = dgv_books.RowCount.ToString();
            }

        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            new FormAbout().ShowDialog();
        }

        private void btn_excelExport_Click(object sender, EventArgs e)
        {
            bll.ExportToExcel(dgv_books);
        }

        private void btn_excelImport_Click(object sender, EventArgs e)
        {
            new FormImportFromExcel().ShowDialog();
        }

        //ПОИСК И ФИЛЬТРАЦИЯ КНИГ
        

        IQueryable<Book> bookes;

        private void cbx_author_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            bookes = fcSchoolLibrary.Books.Where(b => b.Author == cbx_author.SelectedItem.ToString()).Distinct();

            if (cbx_name.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.Author == cbx_author.SelectedItem.ToString())
                        .Where(b => b.Name == cbx_name.SelectedItem.ToString())
                        .Distinct();
            }

            if (cbx_year.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.Author == cbx_author.SelectedItem.ToString())
                        .Where(b => b.Year.ToString() == cbx_year.SelectedItem.ToString())
                        .Distinct();
            }

            if (cbx_inventoryNumber.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.Author == cbx_author.SelectedItem.ToString())
                        .Where(b => b.Count.ToString() == cbx_inventoryNumber.SelectedItem.ToString())
                        .Distinct();
            }

            if (cbx_subject.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.Author == cbx_author.SelectedItem.ToString())
                        .Where(b => b.Subject == cbx_subject.SelectedItem.ToString())
                        .Distinct();
            }

            if (cbx_genre.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.Author == cbx_author.SelectedItem.ToString())
                       .Where(b => b.Genre == cbx_genre.SelectedItem.ToString())
                        .Distinct();
            }


            dgv_books.DataSource = bookes.ToList();
        }

        private void cbx_name_SelectedIndexChanged(object sender, EventArgs e)
        {

            bookes = fcSchoolLibrary.Books.Where(b => b.Name == cbx_name.SelectedItem.ToString()).Distinct();

            if (cbx_author.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.Name == cbx_name.SelectedItem.ToString())
                        .Where(b => b.Author == cbx_author.SelectedItem.ToString())
                        .Distinct();
            }

            if (cbx_year.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.Name == cbx_name.SelectedItem.ToString())
                        .Where(b => b.Year.ToString() == cbx_year.SelectedItem.ToString())
                        .Distinct();
            }

            if (cbx_inventoryNumber.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.Name == cbx_name.SelectedItem.ToString())
                        .Where(b => b.Count.ToString() == cbx_inventoryNumber.SelectedItem.ToString())
                        .Distinct();
            }

            if (cbx_subject.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.Name == cbx_name.SelectedItem.ToString())
                        .Where(b => b.Subject == cbx_subject.SelectedItem.ToString())
                        .Distinct();
            }

            if (cbx_genre.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.Name == cbx_name.SelectedItem.ToString())
                       .Where(b => b.Genre == cbx_genre.SelectedItem.ToString())
                        .Distinct();
            }


            dgv_books.DataSource = bookes.ToList();


        }

        private void cbx_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookes = fcSchoolLibrary.Books.Where(b => b.Year.ToString() == cbx_year.SelectedItem.ToString()).Distinct();

            if (cbx_author.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.Year.ToString() == cbx_year.SelectedItem.ToString())
                        .Where(b => b.Author == cbx_author.SelectedItem.ToString())
                        .Distinct();
            }

            if (cbx_name.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.Year.ToString() == cbx_year.SelectedItem.ToString())
                        .Where(b => b.Name == cbx_name.SelectedItem.ToString())
                        .Distinct();
            }

            if (cbx_inventoryNumber.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.Year.ToString() == cbx_year.SelectedItem.ToString())
                        .Where(b => b.Count.ToString() == cbx_inventoryNumber.SelectedItem.ToString())
                        .Distinct();
            }

            if (cbx_subject.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.Year.ToString() == cbx_year.SelectedItem.ToString())
                        .Where(b => b.Subject == cbx_subject.SelectedItem.ToString())
                        .Distinct();
            }

            if (cbx_genre.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.Year.ToString() == cbx_year.SelectedItem.ToString())
                       .Where(b => b.Genre == cbx_genre.SelectedItem.ToString())
                        .Distinct();
            }


            dgv_books.DataSource = bookes.ToList();

        }

        private void cbx_count_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookes = fcSchoolLibrary.Books.Where(b => b.InventoryNumber.ToString() == cbx_inventoryNumber.SelectedItem.ToString()).Distinct();

            if (cbx_author.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.InventoryNumber.ToString() == cbx_inventoryNumber.SelectedItem.ToString())
                        .Where(b => b.Author == cbx_author.SelectedItem.ToString())
                        .Distinct();
            }

            if (cbx_name.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.InventoryNumber.ToString() == cbx_inventoryNumber.SelectedItem.ToString())
                        .Where(b => b.Name == cbx_name.SelectedItem.ToString())
                        .Distinct();
            }

            if (cbx_year.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.InventoryNumber.ToString() == cbx_inventoryNumber.SelectedItem.ToString())
                        .Where(b => b.Count.ToString() == cbx_inventoryNumber.SelectedItem.ToString())
                        .Distinct();
            }

            if (cbx_subject.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.InventoryNumber.ToString() == cbx_inventoryNumber.SelectedItem.ToString())
                        .Where(b => b.Subject == cbx_subject.SelectedItem.ToString())
                        .Distinct();
            }

            if (cbx_genre.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.InventoryNumber.ToString() == cbx_inventoryNumber.SelectedItem.ToString())
                       .Where(b => b.Genre == cbx_genre.SelectedItem.ToString())
                        .Distinct();
            }


            dgv_books.DataSource = bookes.ToList();
        }

        private void cbx_subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookes = fcSchoolLibrary.Books.Where(b => b.Subject == cbx_subject.SelectedItem.ToString()).Distinct();

            if (cbx_author.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.Subject == cbx_subject.SelectedItem.ToString())
                        .Where(b => b.Author == cbx_author.SelectedItem.ToString())
                        .Distinct();
            }

            if (cbx_name.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.Subject == cbx_subject.SelectedItem.ToString())
                        .Where(b => b.Name == cbx_name.SelectedItem.ToString())
                        .Distinct();
            }

            if (cbx_year.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.Subject == cbx_subject.SelectedItem.ToString())
                        .Where(b => b.Year.ToString() == cbx_year.SelectedItem.ToString())
                        .Distinct();
            }

            if (cbx_inventoryNumber.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.Subject == cbx_subject.SelectedItem.ToString())
                        .Where(b => b.Count.ToString() == cbx_inventoryNumber.SelectedItem.ToString())
                        .Distinct();
            }

            if (cbx_genre.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.Subject == cbx_genre.SelectedItem.ToString())
                       .Where(b => b.Genre == cbx_genre.SelectedItem.ToString())
                        .Distinct();
            }


            dgv_books.DataSource = bookes.ToList();
        }

        private void cbx_genre_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookes = fcSchoolLibrary.Books.Where(b => b.Genre == cbx_genre.SelectedItem.ToString()).Distinct();

            if (cbx_author.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.Genre == cbx_genre.SelectedItem.ToString())
                        .Where(b => b.Author == cbx_author.SelectedItem.ToString())
                        .Distinct();
            }

            if (cbx_name.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.Genre == cbx_genre.SelectedItem.ToString())
                        .Where(b => b.Name == cbx_name.SelectedItem.ToString())
                        .Distinct();
            }

            if (cbx_year.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.Genre == cbx_genre.SelectedItem.ToString())
                        .Where(b => b.Year.ToString() == cbx_year.SelectedItem.ToString())
                        .Distinct();
            }

            if (cbx_inventoryNumber.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.Genre == cbx_genre.SelectedItem.ToString())
                        .Where(b => b.Count.ToString() == cbx_inventoryNumber.SelectedItem.ToString())
                        .Distinct();
            }

            if (cbx_subject.SelectedIndex != -1)
            {
                bookes =
                    fcSchoolLibrary.Books.Where(b => b.Genre.ToString() == cbx_genre.SelectedItem.ToString())
                       .Where(b => b.Subject == cbx_subject.SelectedItem.ToString())
                        .Distinct();
            }


            dgv_books.DataSource = bookes.ToList();
        }

        private void chbx_search_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_search.Checked)
            {
                gb_search.Enabled = true;

                YesComboBoxEvents();

                btn_clearComboBox.Enabled = true;
            }
            else if (!chbx_search.Checked)
            {
                gb_search.Enabled = false;

                NoComboBoxEvents();

                btn_clearComboBox.Enabled = false;
            }
            
        }

        private void учетныеЗаписиПочтыToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new FormSettingsMail().ShowDialog();

        }

        private void информацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAbout().ShowDialog();
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAddBook().ShowDialog();
        }

        private void редактироватьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(statusIdBook.Text);
            new FormEditBook(id).ShowDialog();
        }

        private void удалитьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(statusIdBook.Text);
            new BLL().DeleteBook(id, dgv_books);
        }

        private void экспортВExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BLL().ExportToExcel(dgv_books);
        }

        private void импортВExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormImportFromExcel().ShowDialog();
        }

        //ИНФОРМАЦИЯ О КНИГАХ 

        private void cbx_countBookAuthor_DropDown(object sender, EventArgs e)
        {
            cbx_countBookAuthor.DataSource = fcSchoolLibrary.Books.Select(b => b.Author).Distinct().ToList();
        }

        private void cbx_countBookGenre_DropDown(object sender, EventArgs e)
        {
            cbx_countBookGenre.DataSource = fcSchoolLibrary.Books.Select(b => b.Genre).Distinct().ToList();
        }

        private void cbx_countBookName_DropDown(object sender, EventArgs e)
        {
            cbx_countBookName.DataSource = fcSchoolLibrary.Books.Select(b => b.Name).Distinct().ToList();
        }

        private void cbx_countBookYear_DropDown(object sender, EventArgs e)
        {
            cbx_countBookYear.DataSource = fcSchoolLibrary.Books.Select(b => b.Year).Distinct().ToList();
        }

        private void cbx_countBookDepartment_DropDown(object sender, EventArgs e)
        {
            cbx_countBookPublishName.DataSource = fcSchoolLibrary.Books.Select(b => b.PublishName).Distinct().ToList();
        }

        private void cbx_countPlaceName_DropDown(object sender, EventArgs e)
        {
            cbx_countPublishPlace.DataSource = fcSchoolLibrary.Books.Select(b => b.PublishPlace).Distinct().ToList();
        }
        
        private void cbx_countBookGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = fcSchoolLibrary.Books.Count(p => p.Genre == cbx_countBookGenre.SelectedItem.ToString());

            txbx_countBookGenre.Text = count.ToString();
        }

        private void cbx_countBookName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = fcSchoolLibrary.Books.Count(p => p.Name == cbx_countBookName.SelectedItem.ToString());

            txbx_countBookName.Text = count.ToString();
        }

        private void cbx_countBookYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = fcSchoolLibrary.Books.Count(p => p.Year.ToString() == cbx_countBookYear.SelectedItem.ToString());

            txbx_countBookYear.Text = count.ToString();
        }

        private void cbx_countBookPublishName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = fcSchoolLibrary.Books.Count(p => p.PublishName == cbx_countBookPublishName.SelectedItem.ToString());

            txbx_countBookPublishName.Text = count.ToString();
        }

        private void cbx_countPublishPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = fcSchoolLibrary.Books.Count(p => p.PublishPlace == cbx_countPublishPlace.SelectedItem.ToString());

            txbx_countBookPublishPlace.Text = count.ToString();
        }

        private void cbx_countBookAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {

            int count = fcSchoolLibrary.Books.Where(a => a.Author == cbx_countBookAuthor.SelectedItem.ToString()).Sum(c => c.Count);

            txbx_countBookAuthor.Text = count.ToString();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                if (tabControl1.SelectedTab == tabPage1)
                {
                    btn_addBook.Enabled = true;
                    btn_editBook.Enabled = true;
                    btn_deleteBook.Enabled = true;
                    chbx_search.Enabled = true;
                    btn_clearComboBox.Enabled = chbx_search.Checked;
                    btn_updateDb.Enabled = true;
                    txbx_searchBooks.Enabled = true;
                    btn_excelExport.Enabled = true;
                    btn_excelImport.Enabled = true;
                    

                    if (chbx_search.Checked)
                    {
                        gb_search.Enabled = true;
                    }  
                }

                if (tabControl1.SelectedTab == tabPage2)
                {
                    try
                    {
                        btn_addBook.Enabled = false;
                        btn_editBook.Enabled = false;
                        btn_deleteBook.Enabled = false;
                        chbx_search.Enabled = false;
                        btn_clearComboBox.Enabled = false;
                        btn_updateDb.Enabled = false;
                        gb_search.Enabled = false;
                        txbx_searchBooks.Enabled = false;
                        btn_excelExport.Enabled = false;
                        btn_excelImport.Enabled = false;

                        int fullCountBooks = fcSchoolLibrary.Books.Count();
                        txbx_fullCountBooks.Text = fullCountBooks.ToString();

                        int fullCountAuthors = fcSchoolLibrary.Books.Select(b => b.Author).Distinct().Count();
                        txbx_fullCountAuthors.Text = fullCountAuthors.ToString();

                        int fullCountGenres = fcSchoolLibrary.Books.Select(b => b.Genre).Distinct().Count();
                        txbx_fullBookGenres.Text = fullCountGenres.ToString();

                        decimal fullPrice = fcSchoolLibrary.Books.Sum(b => b.Price);
                        txbx_fullBookPrice.Text = fullPrice.ToString("F");

                        int fullPages = fcSchoolLibrary.Books.Sum(b => b.Pages);
                        txbx_fullCountAllPages.Text = fullPages.ToString();

                        int fullCountPublishName = fcSchoolLibrary.Books.Select(b => b.PublishName).Distinct().Count();
                        txbx_fullCountPublishName.Text = fullCountPublishName.ToString();
                    }
                    catch (Exception ex)
                    {
                        new FormException(ex.Message).ShowDialog();
                    }
                    
                }

                if (tabControl1.SelectedTab == tabPage3)
                {
                    btn_addBook.Enabled = false;
                    btn_editBook.Enabled = false;
                    btn_deleteBook.Enabled = false;
                    chbx_search.Enabled = false;
                    btn_clearComboBox.Enabled = false;
                    btn_updateDb.Enabled = true;
                    txbx_searchBooks.Enabled = false;
                    btn_excelExport.Enabled = false;
                    btn_excelImport.Enabled = false;

                    if (dgv_allBooks.RowCount == 0)
                    {
                        dgv_allBooks.DataSource = fcSchoolLibrary.Books.ToList();
                    }
                    

                    bll.RenameDataGridView(dgv_allBooks);
                }              

            }
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            }
        }

        private void dgv_books_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            statusCountBooksInDataGridView.Text = dgv_books.RowCount.ToString();
        }

        private void btn_searchBooks_Click(object sender, EventArgs e)
        {
            bll.SearchBooksInDataGridView(txbx_searchBooks, dgv_books);
        }

        private void txbx_searchBooks_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bll.SearchBooksInDataGridView(txbx_searchBooks, dgv_books);
            }
        }

        private void txbx_searchBooks_TextChanged(object sender, EventArgs e)
        {
            if (txbx_searchBooks.Text != String.Empty)
            {
                btn_searchBooks.Enabled = true;
            }
            else
            {
                btn_searchBooks.Enabled = false;
            }
        }

        //Удаление нескольких книг

        private  List<Int32> booksIdOnDelete = new List<int>();


        private void btn_deleteBooks_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(@"Удалить выбранные книги из базы данных?", @"Удаление нескольких книг", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bll.DeleteReservalBook(booksIdOnDelete);
                booksIdOnDelete.Clear();
                dgv_allBooks.DataSource = fcSchoolLibrary.Books.ToList();
                lb_viewBooksOnDelete.DataSource = booksIdOnDelete;
                btn_deleteBooks.Enabled = false;
                lbl_bookCount.Text = @"0";
            }
        }


        private void dgv_allBooks_Click(object sender, EventArgs e)
        {

            if (dgv_allBooks.CurrentRow == null)
            {
                return;
            }

            var books = dgv_allBooks.CurrentRow.DataBoundItem as Book;

            if (books == null)
            {
                return;
            }

            booksIdOnDelete.Add(books.Id);
            btn_deleteBooks.Enabled = true;            
            lb_viewBooksOnDelete.DataSource = bll.ViewBooksOnDelete(booksIdOnDelete);
            lbl_bookCount.Text = lb_viewBooksOnDelete.Items.Count.ToString();
        }


        private void строкаПодключенияКБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormConnectionString().ShowDialog();
        }

        private void очиститьБазуДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bll.DeleteAllBooksInDataBase(dgv_allBooks);
        }

        private void btn_clearBooksListOnDelete_Click(object sender, EventArgs e)
        {
            if (lb_viewBooksOnDelete.Items.Count == 0)
            {
                MessageBox.Show(@"Список выбранных книг пуст!");
            }
            else
            {
                DialogResult result = MessageBox.Show(@"Очистить список удаляемых книг?", @"Удаление книг", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    booksIdOnDelete.Clear();
                    lbl_bookCount.Text = @"0";
                    lb_viewBooksOnDelete.DataSource = bll.ViewBooksOnDelete(booksIdOnDelete);
                    btn_deleteBooks.Enabled = false;
                }
            }
        }

        private void btn_formAuthors_Click(object sender, EventArgs e)
        {
            new FormAuthors().ShowDialog();
        }

        private void btn_editPublishPlace_Click(object sender, EventArgs e)
        {
            new FormPublishPlace().ShowDialog();
        }

        private void btn_formCipher_Click(object sender, EventArgs e)
        {
            new FormCipher().ShowDialog();
        }

        private void btn_formPublishPlaces_Click(object sender, EventArgs e)
        {
            new FormPublishHouse().ShowDialog();
        }

        private void btn_formSubjects_Click(object sender, EventArgs e)
        {
            new FormSubjects().ShowDialog();
        }

        private void btn_formGenres_Click(object sender, EventArgs e)
        {
            new FormGenres().ShowDialog();
        }

        private void btn_formSeries_Click(object sender, EventArgs e)
        {
            new FormSeries().ShowDialog();
        }

        private void btn_formDepartment_Click(object sender, EventArgs e)
        {
            new FormDepartment().ShowDialog();
        }

        private void строкаПодключенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormConnectionString().ShowDialog();
        }

        private void настройкиЭлектроннойПочтыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormSettingsMail().ShowDialog();
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormAbout().ShowDialog();
        }

        private void блокировкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAutorization().ShowDialog();
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ApplicationExit();
        }

        private void удалитьБазуДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bll.DeleteAllBooksInDataBase(dgv_books);
        }

        private void ts_copy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.Clear();
                DataObject dgv = dgv_books.GetClipboardContent();

                if (dgv != null)
                {
                    Clipboard.SetDataObject(dgv);
                }
            }
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            }
        }

        private void panel_ColorRed_Click(object sender, EventArgs e)
        {
            dgv_books.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
        }

        private void panel_ColorWhite_Click_1(object sender, EventArgs e)
        {
            dgv_books.CurrentRow.DefaultCellStyle.BackColor = Color.White;
        }

        private void panel_ColorBlue_Click(object sender, EventArgs e)
        {
            dgv_books.CurrentRow.DefaultCellStyle.BackColor = Color.Blue;
        }

        private void dgv_books_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_editBook_Click(null, null);
        }
    }
}

