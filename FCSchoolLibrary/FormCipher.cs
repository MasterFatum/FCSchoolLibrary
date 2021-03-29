using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace FCSchoolLibrary
{
    public partial class FormCipher : Form
    {
        public FormCipher()
        {
            InitializeComponent();
        }

        FCSchoolLibrary fcSchoolLibrary = new FCSchoolLibrary();

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCipher_Load(object sender, EventArgs e)
        {
            try
            {
                lb_cipher.DataSource = new Bll().GetBookCipher();
            }
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            }
        }

        private void lb_cipher_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbx_newCipherName.Text = lb_cipher.SelectedItem.ToString();
        }

        private void btn_saveNewCipherName_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<Book> ciphers =
                    fcSchoolLibrary.Books.Where(b => b.Cipher == lb_cipher.SelectedItem.ToString())
                        .AsEnumerable()
                        .Select(b =>
                        {
                            b.Cipher = txbx_newCipherName.Text.Trim();
                            return b;
                        });

                foreach (Book cipher in ciphers)
                {
                    fcSchoolLibrary.Entry(cipher).State = EntityState.Modified;
                }
                fcSchoolLibrary.SaveChanges();
                txbx_newCipherName.Text = String.Empty;
                MessageBox.Show(@"Шифр успешно отредактирован!");

                lb_cipher.DataSource = new Bll().GetBookCipher();
            }
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            }
        }
    }
}
