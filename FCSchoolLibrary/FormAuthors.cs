using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Windows.Forms;
using System.Linq;

namespace FCSchoolLibrary
{
    public partial class FormAuthors : Form
    {
        FCSchoolLibrary fcSchoolLibrary = new FCSchoolLibrary();

        public FormAuthors()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAuthors_Load(object sender, EventArgs e)
        {
            try
            {
                lb_authors.DataSource = new BLL().GetBookAuthor();
            }
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            }
            
        }

        private void lb_authors_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbx_newAuthorName.Text = lb_authors.SelectedItem.ToString();
        }

        private void btn_saveNewAuthorsName_Click(object sender, EventArgs e)
        {
                try
                {
                    IEnumerable<Book> authors =
                        fcSchoolLibrary.Books.Where(b => b.Author == lb_authors.SelectedItem.ToString())
                            .AsEnumerable()
                            .Select(b =>
                            {
                                b.Author = txbx_newAuthorName.Text.Trim();
                                return b;
                            });

                    foreach (Book author in authors)
                    {
                        fcSchoolLibrary.Entry(author).State = EntityState.Modified;
                    }
                    fcSchoolLibrary.SaveChanges();
                    txbx_newAuthorName.Text = String.Empty;
                    MessageBox.Show(@"Автор успешно отредактирован!");

                lb_authors.DataSource = new BLL().GetBookAuthor();
            }
                catch (Exception ex)
                {
                    new FormException(ex.Message).ShowDialog();
                }
        }
    }
}
