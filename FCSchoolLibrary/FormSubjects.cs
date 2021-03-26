using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Windows.Forms;
using System.Linq;

namespace FCSchoolLibrary
{
    public partial class FormSubjects : Form
    {
        public FormSubjects()
        {
            InitializeComponent();
        }

        FCSchoolLibrary fcSchoolLibrary = new FCSchoolLibrary();

        private void FormSubjects_Load(object sender, EventArgs e)
        {
            try
            {
                lb_subject.DataSource = new BLL().GetBookSubject();
            }
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lb_subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbx_newSubjectName.Text = lb_subject.SelectedItem.ToString();
        }

        private void btn_saveSubjectName_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<Book> subjects =
                    fcSchoolLibrary.Books.Where(b => b.Subject == lb_subject.SelectedItem.ToString())
                        .AsEnumerable()
                        .Select(b =>
                        {
                            b.Subject = txbx_newSubjectName.Text.Trim();
                            return b;
                        });

                foreach (Book subject in subjects)
                {
                    fcSchoolLibrary.Entry(subject).State = EntityState.Modified;
                }
                fcSchoolLibrary.SaveChanges();
                txbx_newSubjectName.Text = String.Empty;
                MessageBox.Show(@"Тема успешно отредактирована!");

                lb_subject.DataSource = new BLL().GetBookSubject();
            }
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            }
        }
    }
}
