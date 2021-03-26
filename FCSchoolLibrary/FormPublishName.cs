using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Windows.Forms;
using System.Linq;

namespace FCSchoolLibrary
{
    public partial class FormPublishHouse : Form
    {
        public FormPublishHouse()
        {
            InitializeComponent();
        }

        FCSchoolLibrary fcSchoolLibrary = new FCSchoolLibrary();

        private void FormPublishHouse_Load(object sender, EventArgs e)
        {
            try
            {
                lb_publishName.DataSource = new BLL().GetBookPublishName();
            }
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            }
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void lb_publishName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbx_newPublishName.Text = lb_publishName.SelectedItem.ToString();
        }

        private void btn_saveNewPublishName_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<Book> publishNames =
                    fcSchoolLibrary.Books.Where(b => b.PublishName == lb_publishName.SelectedItem.ToString())
                        .AsEnumerable()
                        .Select(b =>
                        {
                            b.PublishName = txbx_newPublishName.Text.Trim();
                            return b;
                        });

                foreach (Book publishName in publishNames)
                {
                    fcSchoolLibrary.Entry(publishName).State = EntityState.Modified;
                }
                fcSchoolLibrary.SaveChanges();
                txbx_newPublishName.Text = String.Empty;
                MessageBox.Show(@"Издательство успешно отредактировано!");

                lb_publishName.DataSource = new BLL().GetBookPublishName();
            }
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            }
        }
    }
}
