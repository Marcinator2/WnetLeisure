using System;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace WnetLeisure
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
         
        }
  

        private void btnStartIS600EKonfiMngr_Click(object sender, EventArgs e)
        {
            FormIS600EKonfiMngr formIS600EKonfiMngr = new FormIS600EKonfiMngr();
            formIS600EKonfiMngr.Show();

        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            PortChecker portChecker = new PortChecker();
            portChecker.Show();

        }

        private void exclusiveIS600EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExclIS600E FormExclIS600E = new FormExclIS600E();
            FormExclIS600E.Show();
        }

        private void wtouchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWtouch FormWtouch = new FormWtouch();
            FormWtouch.Show();
        }

        private void entwickleroptionenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Passwortabfrage Dialogfeld erstellen
            PasswordDialog passwordDialog = new PasswordDialog();

            // Überprüfen, ob das eingegebene Passwort korrekt ist
            if (passwordDialog.ShowDialog() == DialogResult.OK)
            {
                string enteredPassword = passwordDialog.Password;
                if (VerifyPassword(enteredPassword))
                {
                    // Passwort ist korrekt, Formular öffnen
                    Developeroptions developeroptions = new Developeroptions();
                    developeroptions.Show();
                }
                else
                {
                    // Passwort ist inkorrekt, entsprechende Aktion durchführen
                    MessageBox.Show("Falsches Passwort eingegeben. Zugriff verweigert.");
                }
            }
        }

        private bool VerifyPassword(string enteredPassword)
        {
            // Hier können Sie Ihre eigene Logik zur Passwortüberprüfung implementieren
            // Zum Beispiel können Sie das eingegebene Passwort mit einem gespeicherten Passwort vergleichen
            string storedPassword = WnetLeisure.Properties.Settings.Default.devPW;

            return enteredPassword == storedPassword;
        }

        private void überWNETLeisuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 AboutBox1 = new AboutBox1();
            AboutBox1.Show();
        }
    }

}
