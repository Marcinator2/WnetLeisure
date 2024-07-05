using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WnetLeisure
{
    public partial class Developeroptions : Form
    {
        public Developeroptions()
        {
            InitializeComponent();
        }
        private void Developeroptions_Load(object sender, EventArgs e)
        {
            txtbxFTPaddIS600E.Text = WnetLeisure.Properties.Settings.Default.ftpaddIS600E;
            txtbxDevPW.Text = WnetLeisure.Properties.Settings.Default.devPW;
        }
        private void btnSaveFTPaddIS600E_Click(object sender, EventArgs e)
        {
            // Speichern Sie die Textbox-Werte bevor das Formular geschlossen wird
            WnetLeisure.Properties.Settings.Default.ftpaddIS600E = txtbxFTPaddIS600E.Text;
            
            WnetLeisure.Properties.Settings.Default.Save();
        }

        private void btnSaveDevPW_Click(object sender, EventArgs e)
        {
            // Bestätigungsmeldung anzeigen
            DialogResult result = MessageBox.Show("Möchten Sie die Änderungen wirklich speichern? \nBitte informieren Sie auch Ihre Kollegen über die Änderung!", "Sind Sie sicher???", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Speichern Sie die Textbox-Werte bevor das Formular geschlossen wird
                WnetLeisure.Properties.Settings.Default.devPW = txtbxDevPW.Text;
                WnetLeisure.Properties.Settings.Default.Save();
                MessageBox.Show("Das Entwicklerpasswort wurde geändert!", "Bestätigung", MessageBoxButtons.OK);

            }
            else
            {
                // Abbruch der Ausführung
                return;
            }
        }
    }
}
