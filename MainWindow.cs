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
  

        private void btnBackende_Click(object sender, EventArgs e)
        {
            string filePath = "600e.ini";
            string section = "[OPTIONS]";
            bool sectionFound = false;

            // Überprüfe, ob die Datei existiert
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Die Datei existiert nicht.");
                return;
            }

            // Lade den Inhalt der Datei
            string[] lines = File.ReadAllLines(filePath);
            StringBuilder sb = new StringBuilder();

            // Suche nach der Sektion [OPTIONS]
            foreach (string line in lines)
            {
                if (line.Trim().Equals(section, StringComparison.OrdinalIgnoreCase))
                {
                    sectionFound = true;
                }
                sb.AppendLine(line);
            }

            // Falls die Sektion [OPTIONS] nicht gefunden wurde, füge sie hinzu
            if (!sectionFound)
            {
                sb.AppendLine(section);
            }

            // Speichere den aktualisierten Inhalt in die Datei
            File.WriteAllText(filePath, sb.ToString());

            if (sectionFound)
            {
                Console.WriteLine("Die Sektion [OPTIONS] wurde gefunden.");
            }
            else
            {
                Console.WriteLine("Die Sektion [OPTIONS] wurde hinzugefügt.");
            }
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
    }

}
