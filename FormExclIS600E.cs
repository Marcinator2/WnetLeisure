using System;
using System.Windows.Forms;


namespace WnetLeisure
{
    public partial class FormExclIS600E : Form
    {
        public FormExclIS600E()
        {
            InitializeComponent(); 
        }

        private void FormExclIS600E_Load(object sender, EventArgs e)
        {

            // Laden des Werts aus den Einstellungen
           
            txtbxUser.Text = WnetLeisure.Properties.Settings.Default.IS600ENutzer;
            txtbxPW.Text = WnetLeisure.Properties.Settings.Default.IS600EPW;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Speichern Sie die Textbox-Werte bevor das Formular geschlossen wird
            WnetLeisure.Properties.Settings.Default.IS600ENutzer = txtbxUser.Text;
            WnetLeisure.Properties.Settings.Default.IS600EPW = txtbxPW.Text;
            WnetLeisure.Properties.Settings.Default.Save();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}