using System;
using System.Windows.Forms;

namespace FCSchoolLibrary
{
    public partial class FormAutorization : Form
    {
        private const String Password = "Admin";
        private const String Password2 = "admin";

        public FormAutorization()
        {
            InitializeComponent();
        }

        
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (Password == txbx_password.Text.Trim() || Password2 == txbx_password.Text.Trim())
            {
                if (chbx_savePassword.Checked)
                {
                    Properties.Settings.Default.Password = txbx_password.Text.Trim();
                    Properties.Settings.Default.SavePassword = true;
                    Properties.Settings.Default.Save();
                    Close();
                }
                else if (!chbx_savePassword.Checked)
                {
                    Properties.Settings.Default.Password = String.Empty;
                    Properties.Settings.Default.SavePassword = false;
                    Properties.Settings.Default.Save();
                    Close();
                }
            }
            else
            {
                MessageBox.Show(@"Неправильный пароль!");
                txbx_password.Text = String.Empty;
                chbx_savePassword.Checked = false;
            }
        }

        private void FormAutorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.FormOwnerClosing)
            {
                e.Cancel = true;
            }
        }

        private void FormAutorization_Load(object sender, EventArgs e)
        {
            ControlBox = false;

            if (Properties.Settings.Default.SavePassword)
            {
                txbx_password.Text = Properties.Settings.Default.Password;
                chbx_savePassword.Checked = Properties.Settings.Default.SavePassword;
            }
        }

        private void txbx_password_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Password == txbx_password.Text.Trim() || Password2 == txbx_password.Text.Trim())
                {
                    Close();
                }
                else
                {
                    MessageBox.Show(@"Неправильный пароль!");
                    txbx_password.Text = String.Empty;
                }
            }
        }
    }
}
