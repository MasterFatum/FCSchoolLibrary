using System;
using System.Windows.Forms;

namespace FCSchoolLibrary
{
    public partial class FormEditBook : Form
    {
        FCSchoolLibrary fcSchoolLibrary = new FCSchoolLibrary();

        Bll bll = new Bll();

        public int Id { get; }

        public FormEditBook(int id)
        {
            InitializeComponent();

            Id = id;

            var book = fcSchoolLibrary.Books.Find(Id);

            if (book != null)
            {
                num__inventoryNumber.Value = book.InventoryNumber;
                cbx_author.Text = book.Author;
                cbx_name.Text = book.Name;
                cbx_year.Text = book.Year.ToString();
                cbx_publishPlace.Text = book.PublishPlace;
                cbx_publishName.Text = book.PublishName;
                cbx_series.Text = book.Serial;
                num_count.Value = book.Count;
                num_price.Value = book.Price;
                cbx_department.Text = book.Department;
                cbx_cipher.Text = book.Cipher;
                num_pages.Value = book.Pages;
                cbx_subject.Text = book.Subject;
                cbx_genre.Text = book.Genre;
                txbx_ISBN.Text = book.ISBN;
                num_age.Value = (int)book.Age;
            }
            else
            {
                MessageBox.Show(@"Выберите книгу");
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(Id);

            var year = Convert.ToInt32(cbx_year.Text.Trim());

            try
            {
                bll.EditBook(id, (int)num__inventoryNumber.Value, cbx_author.Text.Trim(), cbx_name.Text.Trim(), year, cbx_publishPlace.Text.Trim(), cbx_publishName.Text.Trim(), cbx_series.Text.Trim(), 
                    (int)num_count.Value, num_price.Value, cbx_department.Text.Trim(), cbx_cipher.Text.Trim(), (int)num_pages.Value, cbx_subject.Text.Trim(), cbx_genre.Text.Trim(), txbx_ISBN.Text.Trim(), (int)num_age.Value);
                Close();
            }
            catch (Exception ex)
            {

                new FormException(ex.Message + " " + "ФОРМА РЕДАКТИРОВАНИЯ КНИГ.").ShowDialog();

            }
        }

        public void ClearTextBoxes()
        {
            DialogResult result = MessageBox.Show(@"Очистить форму?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                num__inventoryNumber.Value = 0;
                cbx_author.Text = string.Empty;
                cbx_name.Text = string.Empty;
                cbx_year.Text = @"0000";
                cbx_publishPlace.Text = string.Empty;
                cbx_publishName.Text = string.Empty;
                cbx_series.Text = string.Empty;
                num_count.Value = 1;
                num_price.Value = 1;
                cbx_department.Text = string.Empty;
                cbx_cipher.Text = string.Empty;
                num_pages.Value = 1;
                cbx_subject.Text = string.Empty;
                cbx_genre.Text = string.Empty;
                txbx_ISBN.Text = string.Empty;
                num_age.Value = 0;
            }
        }
    }
}
