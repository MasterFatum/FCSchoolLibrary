using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace FCSchoolLibrary
{
    public partial class FormSeries : Form
    {
        public FormSeries()
        {
            InitializeComponent();
        }

        FCSchoolLibrary fcSchoolLibrary = new FCSchoolLibrary();

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormSeries_Load(object sender, EventArgs e)
        {
            try
            {
                lb_series.DataSource = new Bll().GetBookSeries();
            }
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            }
        }

        private void lb_series_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbx_newSeriesName.Text = lb_series.SelectedItem.ToString();
        }

        private void btn_saveNewSeriesName_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<Book> series =
                    fcSchoolLibrary.Books.Where(b => b.Serial == lb_series.SelectedItem.ToString())
                        .AsEnumerable()
                        .Select(b =>
                        {
                            b.Serial = txbx_newSeriesName.Text.Trim();
                            return b;
                        });

                foreach (Book s in series)
                {
                    fcSchoolLibrary.Entry(s).State = EntityState.Modified;
                }
                fcSchoolLibrary.SaveChanges();
                txbx_newSeriesName.Text = String.Empty;
                MessageBox.Show(@"Серия успешно отредактирована!");

                lb_series.DataSource = new Bll().GetBookSeries();
            }
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            }
        }
    }
}
