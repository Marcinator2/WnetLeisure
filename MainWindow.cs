using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WnetLeisure;
using System.Drawing;


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

        private void btnLIN_Click(object sender, EventArgs e)
        {
            FormLIN formLIN = new FormLIN();
            formLIN.Show();
        }

        private void btnReportCreator_Click(object sender, EventArgs e)
        {
            FormWnetReportCreator FormWnetReportCreator = new FormWnetReportCreator();
            FormWnetReportCreator.Show();
        }

        private void serverZugaengeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormServerZugaenge FormServerZugaenge = new FormServerZugaenge();
            FormServerZugaenge.Show();

        }


        private void zugaengeToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormWtouchKonfiManager formWtouchKonfiManager = new FormWtouchKonfiManager();
            formWtouchKonfiManager.Show();
        }

        private void buttonDatenbankenLaden_Click(object sender, EventArgs e)
        {
            // Instanz der Klasse erstellen
            ButtonDatenbankenLaden ButtonDatenbankenLaden = new ButtonDatenbankenLaden();

            // Methode aufrufen und das FlowLayoutPanel übergeben
            ButtonDatenbankenLaden.FillFlowLayoutPanel(flowLayoutPanelServerUebersicht);
        }
    }

}
