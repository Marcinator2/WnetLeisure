using System;
using System.Windows.Forms;

namespace WnetLeisure
{
    public partial class FormAuthentication : Form
    {
        public bool IsWindowsAuth { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }

        public FormAuthentication()
        {
            InitializeComponent();
        }

        private void FormAuthentication_Load(object sender, EventArgs e)
        {
            rbWindowsAuth.Checked = true; // Default to Windows Authentication
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            IsWindowsAuth = rbWindowsAuth.Checked;
            Username = txtBxUsername.Text;
            Password = txtBxPassword.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void rbSqlServerAuth_CheckedChanged(object sender, EventArgs e)
        {
            txtBxUsername.Enabled = rbSqlServerAuth.Checked;
            txtBxPassword.Enabled = rbSqlServerAuth.Checked;
        }

    }
}
