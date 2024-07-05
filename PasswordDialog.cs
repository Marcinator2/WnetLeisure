using System;
using System.Windows.Forms;

namespace WnetLeisure
{
    public partial class PasswordDialog : Form
    {
        public string Password { get; private set; }

        public PasswordDialog()
        {
            InitializeComponent();
            txtbxDevPW.KeyDown += new KeyEventHandler(txtbxDevPW_KeyDown);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Setzen Sie das DialogResult auf OK und schließen Sie den Dialog
            Password = txtbxDevPW.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
        private void txtbxDevPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }




    }
}
