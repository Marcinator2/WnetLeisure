using System;
using System.Windows.Forms;

namespace WnetLeisure
{
    public partial class FormWtouch : Form
    {
        public FormWtouch()
        {
            InitializeComponent();
        }

        private void FormWtouch_Load(object sender, EventArgs e)
        {

            // Laden des Werts aus den Einstellungen

            txtbxWTUser.Text = WnetLeisure.Properties.Settings.Default.WtouchNutzer;
            txtbxWTPW.Text = WnetLeisure.Properties.Settings.Default.WtouchPW;
        }

        private void btnWTSave_Click(object sender, EventArgs e)
        {
            // Speichern Sie die Textbox-Werte bevor das Formular geschlossen wird
            WnetLeisure.Properties.Settings.Default.WtouchNutzer = txtbxWTUser.Text;
            WnetLeisure.Properties.Settings.Default.WtouchPW = txtbxWTPW.Text;
            WnetLeisure.Properties.Settings.Default.Save();
            this.Close();
        }

        private void btnWTCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}