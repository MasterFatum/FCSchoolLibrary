using System;
using System.Windows.Forms;

namespace FCSchoolLibrary
{
    public partial class FormException : Form
    {

        public FormException(string textError)
        {
            InitializeComponent();

            const string mainText = "Программная ошибка! ";

           txbx_errorText.Text = mainText + textError;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btn_sendReport_Click(object sender, EventArgs e)
        {
            Bll bll = new Bll();

            string username = Properties.Settings.Default.MailUsername;
            string password = Properties.Settings.Default.MailPassword;
            string smtpServer = Properties.Settings.Default.MailServer;
            bool useSsl = Properties.Settings.Default.MailUseSSL;
            int smtpPort = Properties.Settings.Default.MailPort;
            string body = txbx_errorText.Text.Trim();


            await bll.SendReportEmail(username, password, smtpServer, smtpPort, username, body, useSsl);

            Close();
        }
    }
}
