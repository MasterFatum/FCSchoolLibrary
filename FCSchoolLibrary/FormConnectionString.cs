using System;
using System.Windows.Forms;

namespace FCSchoolLibrary
{
    public partial class FormConnectionString : Form
    {
        public FormConnectionString()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            new BLL().SaveConnectionString(txbx_connectionString.Text.Trim());
        }

        private void FormConnectionString_Load(object sender, EventArgs e)
        {
            txbx_connectionString.Text = Properties.Settings.Default.ConnectionStringMy;
        }
    }
}
