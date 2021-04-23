using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FCSchoolLibrary
{
    public class Bll
    {
        FCSchoolLibrary fcSchoolLibrary = new FCSchoolLibrary();

        SaveFileDialog saveFile;

        public void UpdateDataGridView(DataGridView dgv, ToolStripStatusLabel countBooksInDb)
        {
            try
            {
                fcSchoolLibrary.Dispose();

                fcSchoolLibrary = new FCSchoolLibrary();

                dgv.DataSource = fcSchoolLibrary.Books.OrderBy(i => i.InventoryNumber).Select(b => new { Id = b.Id, InventoryNumber = b.InventoryNumber, 
                    Author = b.Author, Name = b.Name, Department = b.Department, Chipher = b.Cipher }).ToList();

                countBooksInDb.Text = dgv.RowCount.ToString();

            }
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            }
        }

        public List<String> GetBookName()
        {
            List<String> books = new List<String>();
            
            try
            {
                var allBooks = fcSchoolLibrary.Books.Select(b => b.Name).Distinct();

                foreach (var book in allBooks)
                {
                    books.Add(book);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return books;
        }

        public List<String> GetBookAuthor()
        {
            List<String> author = new List<String>();

            try
            {
                var allAuthors = fcSchoolLibrary.Books.Select(p => p.Author).Distinct();

                foreach (var allAuthor in allAuthors)
                {
                    author.Add(allAuthor);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return author;
        }

        public List<String> GetBookYear()
        {
            List<String> year = new List<String>();

            try
            {
                var allYears = fcSchoolLibrary.Books.Select(p => p.Year).Distinct();

                foreach (var allYear in allYears)
                {
                    year.Add(allYear.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return year;
        }
        public List<String> GetBookInventoryNumber()
        {
            List<String> allBooksInventoryNumbers = new List<String>();

            try
            {
                var inventoryNumbers = fcSchoolLibrary.Books.Select(c => c.InventoryNumber).Distinct();

                foreach (var number in inventoryNumbers)
                {
                    allBooksInventoryNumbers.Add(number.ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return allBooksInventoryNumbers;
        }
        public List<String> GetBookSubject()
        {
            List<String> allBookSubject = new List<String>();

            try
            {
                var allSubject = fcSchoolLibrary.Books.Select(c => c.Subject).Distinct();

                foreach (var subject in allSubject)
                {
                    allBookSubject.Add(subject);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return allBookSubject;
        }

        public List<String> GetBookGenre()
        {
            List<String> allBookGenre = new List<String>();

            try
            {
                var allGenre = fcSchoolLibrary.Books.Select(c => c.Genre).Distinct();

                foreach (var genre in allGenre)
                {
                    if (genre != null)
                    {
                        allBookGenre.Add(genre);
                    }                                      
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return allBookGenre;
        }

        public List<String> GetBookPublishPlace()
        {
            List<String> allBookPublishPlace = new List<String>();

            try
            {
                var allPublishPlace= fcSchoolLibrary.Books.Select(c => c.PublishPlace).Distinct();

                foreach (var publishPlace in allPublishPlace)
                {
                    if (publishPlace != null)
                    {
                        allBookPublishPlace.Add(publishPlace);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return allBookPublishPlace;
        }

        public List<String> GetBookPublishName()
        {
            List<String> allBookPublishName = new List<String>();

            try
            {
                var allPublishName = fcSchoolLibrary.Books.Select(c => c.PublishName).Distinct();

                foreach (var publishName in allPublishName)
                {
                    if (publishName != null)
                    {
                        allBookPublishName.Add(publishName);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return allBookPublishName;
        }

        public List<String> GetBookSeries()
        {
            List<String> allBookSeries = new List<String>();

            try
            {
                var allSeries = fcSchoolLibrary.Books.Select(c => c.Serial).Distinct();

                foreach (var series in allSeries)
                {
                    if (series != null)
                    {
                        allBookSeries.Add(series);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return allBookSeries;
        }

        public List<String> GetBookDepartment()
        {
            List<String> allBookDepartment = new List<String>();

            try
            {
                var allDepartment = fcSchoolLibrary.Books.Select(c => c.Department).Distinct();

                foreach (var department in allDepartment)
                {
                    if (department != null)
                    {
                        allBookDepartment.Add(department);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return allBookDepartment;
        }

        public List<String> GetBookCipher()
        {
            List<String> allBookCipher = new List<String>();

            try
            {
                var allCipher = fcSchoolLibrary.Books.Select(c => c.Cipher).Distinct();

                foreach (var cipher in allCipher)
                {
                    if (cipher != null)
                    {
                        allBookCipher.Add(cipher);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return allBookCipher;
        }
        public bool AddNewBook(int inventoryNumber,  string author, string name, int year, string publishPlace, string publishName, string serial, 
            int count, decimal price, string department, string cipher, int pages, string subject, string genre, string isbn, int age)
        {
            try
            {
                if (inventoryNumber != 0 && author != string.Empty && name != string.Empty && year != 0 && publishPlace != string.Empty &&
                publishName != string.Empty && count != 0 && price != 0 && department != string.Empty && cipher != string.Empty && pages != 0)
                {
                    fcSchoolLibrary.Books.Add(new Book
                    {
                        InventoryNumber = inventoryNumber,
                        Author = author,
                        Name = name,
                        Year = year,
                        PublishPlace = publishPlace,
                        PublishName = publishName,
                        Serial = serial,
                        Count = count,
                        Price = price,
                        Department = department,
                        Cipher = cipher,
                        Pages = pages,
                        Subject = subject,
                        Genre = genre,
                        ISBN = isbn,
                        Age = age
                    });

                    if (fcSchoolLibrary.SaveChanges() == 1)
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return false;
        }
        public void EditBook(int id, int inventoryNumber, string author, string name, int year, string publishPlace, string publishName, string serial,
            int count, decimal price, string department, string cipher, int pages, string subject, string genre, string isbn, int age)
        {

            try
            {
                
                var book = fcSchoolLibrary.Books.Find(id);

                if (book != null)
                {
                    book.InventoryNumber = inventoryNumber;
                    book.Author = author;
                    book.Name = name;
                    book.Year = year;
                    book.PublishPlace = publishPlace;
                    book.PublishName = publishName;
                    book.Serial = serial;
                    book.Count = count;
                    book.Price = price;
                    book.Department = department;
                    book.Cipher = cipher;
                    book.Pages = pages;
                    book.Subject = subject;
                    book.Genre = genre;
                    book.ISBN = isbn;
                    book.Age = age;

                    fcSchoolLibrary.Books.AddOrUpdate(book);

                    fcSchoolLibrary.SaveChanges();

                    MessageBox.Show(@"Книга успешно отредактирована!", @"Редактирование книги", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        //Удаление книги

        public void DeleteBook(int id, DataGridView dgv)
        {
            try
            {
                var book = fcSchoolLibrary.Books.Find(id);

                if (book != null)
                {
                    if (book.Count > 1)
                    {
                        book.Count--;
                    }
                    else
                    {
                        fcSchoolLibrary.Books.Remove(book);
                    }
                    
                }
                
                fcSchoolLibrary.SaveChanges();

                dgv.DataSource = fcSchoolLibrary.Books.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        } 

        //Удаление нескольких книг

        public void DeleteReservalBook(List<Int32> id)
        {
            try
            {
                foreach (Int32 b in id)
                {
                    var book = fcSchoolLibrary.Books.Find(b);

                    if (book != null)
                    {
                        fcSchoolLibrary.Books.Remove(book);
                    }
                    
                }
                
                fcSchoolLibrary.SaveChanges();

                MessageBox.Show(@"Книги успешно удалены!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                new FormException(ex.Message + " " + ex.StackTrace).ShowDialog();
            }
        }

        //Просмотреть список книг на удаление

        public List<String> ViewBooksOnDelete(List<Int32> id)
        {
            List<String> books = new List<String>();

            try
            {
                foreach (Int32 book in id)
                {
                    var bookForDelete = fcSchoolLibrary.Books.Find(book);
                    if (bookForDelete != null)
                    {
                        books.Add(bookForDelete.Name);
                    }
                }
            }
            
            catch (Exception ex)
            {
                new FormException(ex.Message + " " + ex.StackTrace).ShowDialog();
            }

            return books;
        }

        //Экспорт в Excel

        public void ExportToExcel(DataGridView dgv)
        {
            saveFile = new SaveFileDialog();

            saveFile.Filter = @"Excel файлы (*.xlsx)|*.xlsx";

            saveFile.FileName = "Экспорт библиотека " + DateTime.Now.Day + "." + DateTime.Now.Month + "." +
                                DateTime.Now.Year + ".xlsx";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string pathToFile = saveFile.FileName;

                Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();

                exApp.Workbooks.Add();

                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet) exApp.ActiveSheet;

                exApp.Columns.ColumnWidth = 30;
                exApp.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;


                for (int i = 0; i < dgv.RowCount; i++)
                {
                    for (int j = 1; j < dgv.ColumnCount; j++)
                    {
                        exApp.Cells[i + 1, j] = dgv.Rows[i].Cells[j].Value;
                    }
                }

                worksheet.SaveAs(pathToFile);
                exApp.Quit();
                MessageBox.Show(@"Экспорт успешно выполнен!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public async Task SendReportEmail(string username, string password, string smtpServer, int smtpPort, string mailFrom,  string body, bool useSsl)
        {
            try
            {
                MailAddress from = new MailAddress(mailFrom);

                MailAddress to = new MailAddress("i.panfilov@fckrasnodar.ru");

                MailMessage message = new MailMessage(from, to);

                message.Subject = "Отчет об ошибке в приложении Библиотека НЧОУ СОШ ФК Краснодар";

                message.Body = body;

                SmtpClient smtp = new SmtpClient(smtpServer, smtpPort);

                smtp.Credentials = new NetworkCredential(username, password);

                if (useSsl)
                {
                    smtp.EnableSsl = true;
                }
                else
                {
                    smtp.EnableSsl = false;
                }
                
                await smtp.SendMailAsync(message);

                MessageBox.Show(@"Письмо об ошибке отправлено!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                smtp.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void RenameDataGridView(DataGridView dgv)
        {
            try
            {
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].HeaderCell.Value = "Инвентарный номер";
                dgv.Columns[2].HeaderCell.Value = "Автор";
                dgv.Columns[3].HeaderCell.Value = "Название";
                dgv.Columns[4].HeaderCell.Value = "Издательство";
                dgv.Columns[5].HeaderCell.Value = "Серия";
            }
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            }
        }

        public void SearchBooksInDataGridView(TextBox textBoxSearch, DataGridView dgv)
        {
            try
            {
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    dgv.Rows[i].Selected = false;

                    for (int j = 0; j < dgv.ColumnCount; j++)
                    {
                        if (dgv.Rows[i].Cells[j].Value != null)
                        {
                            if (dgv.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch.Text))
                            {
                                dgv.Rows[i].Selected = true;
                                break;
                            }
                        }
                    }
                }
                MessageBox.Show(String.Format($"Найдено записей: {dgv.SelectedRows.Count}"));
            }
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            }
        }

        public void LoadBooksToDb(DataGridView dgv)
        {
            
            DialogResult result = MessageBox.Show(@"Добавить данные книги в базу данных?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

             if (result == DialogResult.Yes)
             {
                try
                {
                    var booksList = new ArrayList();

                    for (int i = 0; i < dgv.RowCount - 1; i++)
                    {
                        for (int j = 0; j < dgv.ColumnCount; j++)
                        {
                            booksList.Add(dgv[j, i].Value);
                        }

                        if (booksList.Count != 0)
                        {
                            fcSchoolLibrary.Books.Add(new Book
                            {
                                InventoryNumber = Convert.ToInt32(booksList[0]),
                                Author = booksList[1].ToString(),
                                Name = booksList[2].ToString(),
                                Year = Convert.ToInt32(booksList[3]),
                                PublishPlace = booksList[4].ToString(),
                                PublishName = booksList[5].ToString(),
                                Serial = booksList[6].ToString(),
                                Count = Convert.ToInt32(booksList[7]),
                                Price = Convert.ToDecimal(booksList[8]),
                                Department = booksList[9].ToString(),
                                Cipher = booksList[10].ToString(),
                                Pages = Convert.ToInt32(booksList[11]),
                                Subject = booksList[12].ToString(),
                                Genre = booksList[13].ToString(),
                                ISBN = booksList[14].ToString(),
                                Age = Convert.ToInt32(booksList[15])
                            });

                            booksList.Clear();
                        }
                    }

                    fcSchoolLibrary.SaveChanges();
                
                    MessageBox.Show(@"Книги успешно добавлены в базу данных!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    new FormException(ex.Message + Environment.NewLine + ex.StackTrace + Environment.NewLine + ex.InnerException + Environment.NewLine + ex.Source).ShowDialog();
                }
             }
        }

        public void SaveConnectionString(string connectionString)
        {
            Properties.Settings.Default.ConnectionStringMy = connectionString;
            Properties.Settings.Default.Save();
            MessageBox.Show(@"Строка подключения успешно сохранена!");
        }

        public void DeleteAllBooksInDataBase(DataGridView dgv)
        {
            try
            {
                DialogResult resultDelete = MessageBox.Show(@"Вы действительно хотите удалить все записи из базы данных? После удаления вы не сможете восстановить данные!", @"Очистка базы данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultDelete == DialogResult.Yes)
                {
                    DialogResult resultBackup = MessageBox.Show(@"Сделать резервную копию базы данных в формате Excel?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultBackup == DialogResult.Yes)
                    {
                        new Bll().ExportToExcel(dgv);
                    }

                    if (fcSchoolLibrary.Books.Count() != 0)
                    {
                        fcSchoolLibrary.Books.RemoveRange(fcSchoolLibrary.Books);
                        fcSchoolLibrary.SaveChanges();
                        MessageBox.Show(@"Все книги из базы данных успешно удалены!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void AddBookToDataGridViewFromLoadDb(DataGridView dgv, String filename)
        {
            try
            {
                if (filename != String.Empty)
                {
                    Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel._Workbook excelWorkBook;
                    Microsoft.Office.Interop.Excel.Worksheet excelWorkSheet;
                    Microsoft.Office.Interop.Excel.Range excelRange;

                    excelWorkBook = excelApp.Workbooks.Open(filename, 0, true, 5, "", "", true,
                        Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false,
                        false, 0, true, 1, 0);
                    excelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelWorkBook.Worksheets.get_Item(1);

                    excelRange = excelWorkSheet.UsedRange;
                    for (int rCnt = 1; rCnt <= excelRange.Rows.Count; rCnt++)
                    {
                        dgv.Rows.Add(1);

                        for (int cCnt = 1; cCnt <= excelRange.Columns.Count; cCnt++)
                        {
                            var range = excelRange.Cells[rCnt, cCnt] as Microsoft.Office.Interop.Excel.Range;

                            if (range != null)
                            {
                                var str = (string)range.Text;
                                dgv.Rows[rCnt - 1].Cells[cCnt - 1].Value = str;
                            }
                        }
                    }
                    excelWorkBook.Close(true);
                    excelApp.Quit();

                    releaseObject(excelWorkSheet);
                    releaseObject(excelWorkBook);
                    releaseObject(excelApp);
                }
            }
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            }
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
            }
            catch (Exception ex)
            {
                new FormException(ex.Message).ShowDialog();
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}

