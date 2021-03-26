using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace FCSchoolLibrary
{
    public partial class FormPublishPlace : Form
    {
        public FormPublishPlace()
        {
            InitializeComponent();
        }

        FCSchoolLibrary fcSchoolLibrary = new FCSchoolLibrary();

        private void lb_publishPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbx_newPublishPlaceName.Text = lb_publishPlace.SelectedItem.ToString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormPublishPlace_Load(object sender, EventArgs e)
        {
            try
            {
                lb_publishPlace.DataSource = new BLL().GetBookPublishPlace();
            }
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            }
        }

        private void btn_savePublishPlaceName_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<Book> publishPlaces =
                    fcSchoolLibrary.Books.Where(b => b.PublishPlace == lb_publishPlace.SelectedItem.ToString())
                        .AsEnumerable()
                        .Select(b =>
                        {
                            b.PublishPlace = txbx_newPublishPlaceName.Text.Trim();
                            return b;
                        });

                foreach (Book publishPlace in publishPlaces)
                {
                    fcSchoolLibrary.Entry(publishPlace).State = EntityState.Modified;
                }
                fcSchoolLibrary.SaveChanges();
                txbx_newPublishPlaceName.Text = String.Empty;
                MessageBox.Show(@"Место издания успешно отредактировано!");

                lb_publishPlace.DataSource = new BLL().GetBookPublishPlace();
            }
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            }
        }
    }
}
