using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Windows.Forms;
using System.Linq;

namespace FCSchoolLibrary
{
    public partial class FormGenres : Form
    {
        public FormGenres()
        {
            InitializeComponent();
        }

        FCSchoolLibrary fcSchoolLibrary = new FCSchoolLibrary();

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormGenres_Load(object sender, EventArgs e)
        {
            try
            {
                lb_genres.DataSource = new BLL().GetBookGenre();
            }
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            }
        }

        private void lb_genres_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbx_newGenresName.Text = lb_genres.SelectedItem.ToString();
        }

        private void btn_saveNewGenresName_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<Book> genres =
                    fcSchoolLibrary.Books.Where(b => b.Genre == lb_genres.SelectedItem.ToString())
                        .AsEnumerable()
                        .Select(b =>
                        {
                            b.Genre = txbx_newGenresName.Text.Trim();
                            return b;
                        });

                foreach (Book genre in genres)
                {
                    fcSchoolLibrary.Entry(genre).State = EntityState.Modified;
                }
                fcSchoolLibrary.SaveChanges();
                txbx_newGenresName.Text = String.Empty;
                MessageBox.Show(@"Жанр успешно отредактирован!");

                lb_genres.DataSource = new BLL().GetBookGenre();
            }
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            }
        }
    }
}
