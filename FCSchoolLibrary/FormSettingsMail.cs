using System;
using System.Windows.Forms;

namespace FCSchoolLibrary
{
    public partial class FormSettingsMail : Form
    {
        public FormSettingsMail()
        {
            InitializeComponent();
        }

        private void FormSettingsMail_Load(object sender, EventArgs e)
        {
            txbx_mailUsername.Text = Properties.Settings.Default.MailUsername;
            txbx_mailPassword.Text = Properties.Settings.Default.MailPassword;
            txbx_mailServer.Text = Properties.Settings.Default.MailServer;
            txbx_mailPort.Text = Properties.Settings.Default.MailPort.ToString();
            chbx_useSsl.Checked = Properties.Settings.Default.MailUseSSL;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(@"Использовать эти данные учетной записи?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    Properties.Settings.Default.MailUsername = txbx_mailUsername.Text.Trim();
                    Properties.Settings.Default.MailPassword = txbx_mailPassword.Text.Trim();
                    Properties.Settings.Default.MailServer = txbx_mailServer.Text.Trim();
                    Properties.Settings.Default.MailPort = Convert.ToInt32(txbx_mailPort.Text.Trim());
                    Properties.Settings.Default.MailUseSSL = chbx_useSsl.Checked;
                    Properties.Settings.Default.Save();

                    MessageBox.Show(@"Данные учетной записи сохранены!");

                }
                catch (Exception ex)
                {
                    new FormException(ex.Message + " " + "ФОРМА УЧЁТНЫХ ЗАПИСЕЙ ЭЛЕКТРОННОЙ ПОЧТЫ.").ShowDialog();

                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
