using System;
using System.Windows.Forms;

namespace WebCam
{
    public partial class AccountSettings : Form
    {
        public AccountSettings()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Account.FromEmail = txtFromEmail.Text;
            Account.FromPassword = txtPasswrod.Text;
            Account.ToEmail = txtToEmail.Text;

            MessageBox.Show("Сохранено");
            this.Close();
        }

        private void AccountSettings_Load(object sender, EventArgs e)
        {
            txtFromEmail.Text = Account.FromEmail;
            txtPasswrod.Text = Account.FromPassword;
            txtToEmail.Text = Account.ToEmail;
        }
    }
}
