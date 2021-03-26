using System;
using System.Linq;
using System.Windows.Forms;

namespace FCSchoolLibrary
{
    public partial class FormAddBook : Form
    {
        BLL bll = new BLL();

        public FormAddBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (num__inventoryNumber.Value != 0 || cbx_author.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show(@"Вы уверены что хотите закрыть форму добавления книг? На форме остались введенные данные!", @"Закрытие",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Close();                    
                }
            }
            else
            {
                Close();
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                int year = Convert.ToInt32(cbx_year.Text.Trim());

                if (bll.AddNewBook((int)num__inventoryNumber.Value, cbx_author.Text, cbx_name.Text.Trim(), year, cbx_publishPlace.Text.Trim(), cbx_publishName.Text.Trim(), cbx_series.Text.Trim(),
                (int)num_count.Value, num_price.Value, cbx_department.Text.Trim(), cbx_cipher.Text.Trim(), (int)num_pages.Value, cbx_subject.Text.Trim(), cbx_genre.Text.Trim(), txbx_ISBN.Text.Trim(), (int)num_age.Value))
                {
                    MessageBox.Show(@"Новая книга успешно добавлена!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show(@"Не все обязательные поля заполнены!");
                }
                
            }
            catch (Exception ex)
            {
                new FormException(ex.Message + " " + "ФОРМА ДОБАВЛЕНИЯ КНИГ.").ShowDialog();
            }                                           
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void cbx_author_DropDown(object sender, EventArgs e)
        {
            cbx_author.DataSource = bll.GetBookAuthor();
        }

        private void cbx_name_DropDown(object sender, EventArgs e)
        {
            cbx_name.DataSource = bll.GetBookName();
        }

        private void cbx_year_DropDown(object sender, EventArgs e)
        {
            cbx_year.DataSource = bll.GetBookYear();
        }

        private void cbx_publishPlace_DropDown(object sender, EventArgs e)
        {
            cbx_publishPlace.DataSource = bll.GetBookPublishPlace();
        }

        private void cbx_publishName_DropDown(object sender, EventArgs e)
        {
            cbx_publishName.DataSource = bll.GetBookPublishName();
        }

        private void cbx_series_DropDown(object sender, EventArgs e)
        {
            cbx_series.DataSource = bll.GetBookSeries();
        }

        private void cbx__department_DropDown(object sender, EventArgs e)
        {
            cbx_department.DataSource = bll.GetBookDepartment();
        }

        private void cbx_cipher_DropDown(object sender, EventArgs e)
        {
            cbx_cipher.DataSource = bll.GetBookCipher();
        }

        private void cbx_subject_DropDown(object sender, EventArgs e)
        {
            cbx_subject.DataSource = bll.GetBookSubject();
        }

        private void cbx_genre_DropDown(object sender, EventArgs e)
        {
            cbx_genre.DataSource = bll.GetBookGenre();
        }
    }
}
