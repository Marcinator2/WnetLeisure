using System;
using System.Windows.Forms;

namespace WnetLeisure
{
    public partial class PortsInputDialog : Form
    {
        public PortsInputDialog()
        {
            InitializeComponent();
            txtPorts.Text = "21, 22, 8083, 8323, 10001";
        }
        public string GetPortNumbers()
        {
            return txtPorts.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
