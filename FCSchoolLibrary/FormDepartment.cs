using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace FCSchoolLibrary
{
    public partial class FormDepartment : Form
    {
        public FormDepartment()
        {
            InitializeComponent();
        }

        FCSchoolLibrary fcSchoolLibrary = new FCSchoolLibrary();

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDepartment_Load(object sender, EventArgs e)
        {
            try
            {
                lb_department.DataSource = new BLL().GetBookDepartment();
            }
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            }
        }

        private void lb_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbx_newDepartmentName.Text = lb_department.SelectedItem.ToString();
        }

        private void btn_saveNewDepartmentName_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<Book> departments =
                    fcSchoolLibrary.Books.Where(b => b.Department == lb_department.SelectedItem.ToString())
                        .AsEnumerable()
                        .Select(b =>
                        {
                            b.Department = txbx_newDepartmentName.Text.Trim();
                            return b;
                        });

                foreach (Book department in departments)
                {
                    fcSchoolLibrary.Entry(department).State = EntityState.Modified;
                }
                fcSchoolLibrary.SaveChanges();
                txbx_newDepartmentName.Text = String.Empty;
                MessageBox.Show(@"Отдел успешно отредактирован!");

                lb_department.DataSource = new BLL().GetBookDepartment();
            }
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            }
        }
    }
}
