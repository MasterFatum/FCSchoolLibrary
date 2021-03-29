using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCSchoolLibrary
{
    public partial class FormImportFromExcel : Form
    {

        public FormImportFromExcel()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
            
        }


        private void btn_openFile_Click(object sender, EventArgs e)
        {
            try
            {
                    OpenFileDialog openFile = new OpenFileDialog();
                    openFile.Filter = @"Excel (*.xlsx)|*.xlsx";
                    openFile.ShowDialog();
                    string filename = openFile.FileName;

                new Bll().AddBookToDataGridViewFromLoadDb(dgv_bookFromExcel, filename);
            }   
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            }
        }


        //КОЛИЧЕСТВО ДОБАВЛЕННЫХ КНИГ

        private void dgv_bookFromExcel_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgv_bookFromExcel.RowCount > 0)
            {
                btn_uploadToDB.Enabled = true;
                btn_clear.Enabled = true;
                lbl_booksLoad.Text = dgv_bookFromExcel.RowCount.ToString();
            }
        }

        //ДОБАВЛЕНИЕ КНИГ ИЗ DATAGRIDVIEW В БАЗУ ДАННЫХ

        private void btn_uploadToDB_Click(object sender, EventArgs e)
        {
            Task addBookInDatabase = new Task(()=> new Bll().LoadBooksToDb(dgv_bookFromExcel));

            try
            {
                addBookInDatabase.Start();
            }
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            }
        }
        
        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (dgv_bookFromExcel.RowCount > 0)
            {
                dgv_bookFromExcel.Rows.Clear();
                lbl_booksLoad.Text = 0.ToString();
                btn_uploadToDB.Enabled = false;
            }

        }
    }
}