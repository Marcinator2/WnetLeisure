using Microsoft.VisualBasic.Logging;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
//using OfficeOpenXml; // EPPlus für Excel-Verarbeitung
using CsvHelper; // Zum Verarbeiten von CSV-Dateien
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;
//using Microsoft.Extensions.Configuration.FileExtensions;
//using NLog;


namespace WnetLeisure
{
    public partial class FormWnetReportCreator : Form
    {
        private string? selectedGroupId; // Variable zum Speichern der ausgewählten Id
        private SqlConnection connection; // Globale Verbindung für die Klasse
        private string reportServerUrl; // Instanzvariable für ReportServer-URL
        private string reportPath;      // Instanzvariable für den Berichtspfad
        private bool rotationAktiv; // Kontrolliert die Rotation

        public FormWnetReportCreator()
        {
            InitializeComponent();

            // Lade die Konfiguration
            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Parameter aus der Konfiguration
            string server = WnetLeisure.Properties.Settings.Default.SQLServer;
            string trustServerCert = WnetLeisure.Properties.Settings.Default.trustServerCert.ToString();
            //string trustServerCert = config["DatabaseSettings:trustServerCert"];
            // Weisen Sie die Konfigurationswerte den Instanzvariablen zu
            reportServerUrl = WnetLeisure.Properties.Settings.Default.ReportServer;
            // reportPath = config["ReportServerSettings:ReportPath"];

            // Verbindungszeichenfolge für SQL-Authentifizierung erstellen
            string connectionString = $"Server={server};Integrated Security=True;TrustServerCertificate={trustServerCert};";


            // Globale Verbindung initialisieren
            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                // MessageBox.Show("Datenbankverbindung erfolgreich!");

                // Fülle die ComboBox mit den Datenbanken
                FuelleComboBoxDatenbanken();


                // Fülle die Gruppe-ComboBox mit Einträgen
                //   FuelleComboBoxGruppe();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler bei der Verbindung zur Datenbank: {ex.Message}");
            }
        }

        private void FuelleComboBoxDatenbanken()
        {
            // SQL-Abfrage zum Abrufen aller Datenbanken, die mit "wnet_Inhalte" beginnen
            string query = "SELECT name FROM sys.databases WHERE name LIKE 'wnet_Daten%'";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string dbName = reader.GetString(0);
                        comboBoxDatenbanken.Items.Add(dbName);
                    }
                }
            }
        }
        private void FuelleComboBoxReport()
        {
            // Sicherstellen, dass reportPath gesetzt ist
            if (string.IsNullOrEmpty(reportPath))
            {
                MessageBox.Show("Kein gültiger Report-Pfad gefunden.");
                return;
            }

            // SQL-Abfrage zum Abrufen aller Einträge aus der Tabelle ReportServer.dbo.Catalog,
            // aber nur aus dem dynamischen Ordner basierend auf reportPath und mit "Gruppe" oder "Group" im Namen
            string query = @"
                            SELECT Path 
                            FROM [ReportServer].[dbo].[Catalog] 
                            WHERE Path LIKE @ReportPath
                            AND (
                                (Path LIKE '%Gruppe%' OR Path LIKE '%Group%')
                                                                AND (
                                    Path LIKE '%_ger%' 
                                )
                                AND (
                                    Path LIKE '%Back%' OR Path LIKE '%Baking%' OR 
                                    Path LIKE '%Cleaning%'
                                )
                            )";


            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Setze den Parameter für die Report-Pfad-Abfrage
                command.Parameters.AddWithValue("@ReportPath", "%" + reportPath + "%");

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Leere die ComboBox, bevor neue Berichte hinzugefügt werden
                    comboBoxReport.Items.Clear();

                    while (reader.Read())
                    {
                        string reportName = reader.GetString(0);
                        comboBoxReport.Items.Add(reportName); // Füge den Bericht zur ComboBox hinzu
                    }
                }
            }
        }

        private async void buttonReportAusfuehren_Click(object sender, EventArgs e)
        {
            // Überprüfen, ob alle erforderlichen Felder ausgefüllt sind
            if (comboBoxReport.SelectedItem == null || comboBoxGruppe.SelectedItem == null)
            {
                MessageBox.Show("Bitte wählen Sie sowohl einen Bericht als auch eine Gruppe aus.");
                return;
            }

            // Überprüfen, ob der Report-Pfad korrekt gesetzt wurde
            if (string.IsNullOrEmpty(reportPath))
            {
                MessageBox.Show("Kein gültiger Report-Pfad gefunden.");
                return;
            }

            // Den richtigen Bericht aus der ComboBox auswählen
            string selectedReport = comboBoxReport.SelectedItem.ToString();

            // Führe den Bericht aus und speichere ihn als Excel
            await ExportiereBerichtNachExcel(reportServerUrl, selectedReport);

            // MessageBox.Show(selectedReport);
        }

        private void FuelleComboBoxGruppe()
        {
            // Leere die ComboBox, um doppelte Einträge zu vermeiden
            comboBoxGruppe.Items.Clear();

            // SQL-Abfrage zum Abrufen aller Gruppen in der Tabelle `Gruppe`
            string query = $"SELECT Id, Name FROM [{comboBoxDatenbanken.Text}].[dbo].[Gruppe]";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Die Id und den Namen des Eintrags lesen und prüfen, ob sie null sind
                        string id = reader["Id"]?.ToString() ?? ""; // Fallback auf leeren String bei null
                        string name = reader["Name"]?.ToString() ?? ""; // Fallback auf leeren String bei null

                        // Füge den Eintrag zur ComboBoxGruppe hinzu
                        comboBoxGruppe.Items.Add(new ComboBoxItem(name, id));
                    }
                }
            }
        }

        //  private bool rotationAktiv; // Kontrolliert die Rotation
        private async Task ExportiereBerichtNachExcel(string reportServerUrl, string selectedReport)
        {
            // Rotation starten
            rotationAktiv = true;
            Task rotationTask = Task.Run(() => RotatePictureBoxAsync());

            // Definiere die URL zum Abrufen des Berichts im Excel-Format
            string startDate = dateTimePickerStart.Value.ToString("yyyy/MM/dd");
            string endDate = dateTimePickerEnd.Value.ToString("yyyy/MM/dd");
            ComboBoxItem selectedGroup = (ComboBoxItem)comboBoxGruppe.SelectedItem;
            string groupId = selectedGroup?.Value;

            if (groupId == null)
            {
                MessageBox.Show("Bitte wählen Sie eine Gruppe aus.");
                rotationAktiv = false; // Rotation stoppen
                return;
            }

            string reportUrl = $"{reportServerUrl}?{selectedReport}&KId={groupId}&Start={startDate}&End={endDate}&rs:Format=EXCELOPENXML";

            try
            {
                using (HttpClientHandler handler = new HttpClientHandler { UseDefaultCredentials = true })
                using (HttpClient client = new HttpClient(handler))
                {
                    HttpResponseMessage response = await client.GetAsync(reportUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        // Hole den Datenbanknamen aus der ComboBox (z.B. "wnet_DatenDB_19")
                        string datenbankName = comboBoxDatenbanken.SelectedItem.ToString();

                        // Hole den vollständigen Pfad des ausgewählten Reports aus der ComboBox
                        string fullReportPath = comboBoxReport.SelectedItem.ToString();

                        // Extrahiere nur den Namen des Berichts (nach dem letzten '\')
                        string reportName = Path.GetFileName(fullReportPath);

                        // Definiere den Ordnerpfad relativ zur .exe-Datei und stelle sicher, dass der Ordner existiert
                        string exePath = AppContext.BaseDirectory;
                        string reportsFolderPath = Path.Combine(exePath, "WnetReports");

                        // Überprüfen, ob der Ordner "WnetReports" existiert; wenn nicht, erstelle ihn
                        if (!Directory.Exists(reportsFolderPath))
                        {
                            Directory.CreateDirectory(reportsFolderPath);
                        }

                        // Erstelle den Dateipfad mit dem Datenbanknamen und Reportnamen
                        string filePath = Path.Combine(reportsFolderPath,
                                                       $"{datenbankName}_{DateTime.Now:yyyy-MM-dd}_{reportName}.xlsx");



                        using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                        {
                            await response.Content.CopyToAsync(fileStream);
                        }

                        MessageBox.Show("Der Bericht wurde erfolgreich nach Excel exportiert und auf dem Desktop gespeichert.");
                    }
                    else
                    {
                        MessageBox.Show($"Fehler beim Abrufen des Berichts: {response.ReasonPhrase}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Exportieren des Berichts: " + ex.Message);
            }
            finally
            {
                // Stoppe die Rotation nach Abschluss des Exports
                rotationAktiv = false;
                await rotationTask; // Warte darauf, dass die Rotation vollständig beendet ist
            }
        }

        // Methode zur Rotation des Bildes in der PictureBox
        private async Task RotatePictureBoxAsync()
        {
            int angle = 0;

            while (rotationAktiv)
            {
                Invoke((MethodInvoker)(() =>
                {
                    pictureBoxLaden.Image?.Dispose();
                    pictureBoxLaden.Image = RotateImage(Properties.Resources.W, angle);
                    angle = (angle + 10) % 360; // Drehe das Bild um 10 Grad
                }));

                await Task.Delay(100); // Kurze Pause zwischen den Rotationen
            }
        }

        // Hilfsmethode zum Drehen des Bildes
        private Image RotateImage(Image image, float angle)
        {
            Bitmap rotatedImage = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(image.Width / 2, image.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-image.Width / 2, -image.Height / 2);
                g.DrawImage(image, new Point(0, 0));
            }
            return rotatedImage;
        }

        private void comboBoxDatenbanken_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Stelle sicher, dass eine Datenbank ausgewählt ist und die Gruppe-ComboBox neu gefüllt wird
            FuelleComboBoxGruppe();

            // Passe den ReportPath an und fülle die Report-ComboBox basierend auf der Auswahl in comboBoxDatenbanken
            string datenbankName = comboBoxDatenbanken.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(datenbankName))
            {
                // Extrahiere das Suffix nach "wnet_DatenDB" (z.B. "_19" aus "wnet_DatenDB_19")
                string suffix = datenbankName.Replace("wnet_DatenDB", ""); // z.B. "_19"

                // Setze den ReportPath dynamisch basierend auf dem ausgewählten Datenbanknamen
                reportPath = $"/WnetReports{suffix}/"; // z.B. "/WnetReports_19/"

                // Fülle die ComboBoxReport basierend auf dem angepassten ReportPath
                FuelleComboBoxReport();

                // Setze textBoxDBName.Text auf den Wert aus der dynamisch erzeugten Datenbank
                SetzeDatenbankKennung(suffix);
            }
        }

        private void SetzeDatenbankKennung(string suffix)
        {
            // Erstelle den Datenbanknamen basierend auf dem Suffix
            string dynamicDbName = $"wnet_WebDB{suffix}"; // z.B. "wnet_WebDB_19"

            // SQL-Abfrage, um die DatenbankKennung aus der Tabelle wnet_WebDB_<suffix>.dbo.Einstellungen zu holen
            string query = $"SELECT DatenbankKennung FROM [{dynamicDbName}].[dbo].[Einstellungen]";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    // Führe die Abfrage aus und lese das Ergebnis
                    var result = command.ExecuteScalar();

                    if (result != null)
                    {
                        // Setze den Text der TextBox auf die erhaltene DatenbankKennung
                        textBoxDBName.Text = result.ToString();
                    }
                    else
                    {
                        // Falls keine Daten gefunden wurden, einen Hinweis anzeigen
                        MessageBox.Show("Keine passende DatenbankKennung gefunden.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Abrufen der DatenbankKennung: " + ex.Message);
                }
            }
        }


        private void comboBoxGruppe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGruppe.SelectedItem is ComboBoxItem selectedItem)
            {
                // Speichere die Id des ausgewählten Elements in der Variable
                selectedGroupId = selectedItem.Value;
                //  MessageBox.Show($"Ausgewählte Gruppen-Id: {selectedGroupId}");
            }


        }

        private void checkBoxLetzterMonat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLetzterMonat.Checked)
            {

                // Deaktiviere die andere CheckBox, falls aktiviert
                checkBoxLetzteWoche.Checked = false;
                // Erster Tag des letzten Monats
                DateTime ersterTagLetzterMonat = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, 1);
                // Erster Tag des aktuellen Monats
                DateTime ersterTagAktuellerMonat = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

                dateTimePickerStart.Value = ersterTagLetzterMonat;
                dateTimePickerEnd.Value = ersterTagAktuellerMonat;
            }
            else
            {
                // Optional: Setze die DateTimePicker-Werte zurück oder lass sie unverändert
                dateTimePickerStart.Value = DateTime.Now;
                dateTimePickerEnd.Value = DateTime.Now;
            }
        }


        private void checkBoxLetzteWoche_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLetzteWoche.Checked)
            {
                // Deaktiviere die andere CheckBox, falls aktiviert
                checkBoxLetzterMonat.Checked = false;
                // Berechne den ersten Tag der letzten Woche (Montag der Vorwoche)
                DateTime heute = DateTime.Now;
                int aktuellerWochentag = (int)heute.DayOfWeek;
                DateTime ersterTagAktuelleWoche = heute.AddDays(-aktuellerWochentag + (aktuellerWochentag == 0 ? -6 : 1));
                DateTime ersterTagLetzteWoche = ersterTagAktuelleWoche.AddDays(-7);

                dateTimePickerStart.Value = ersterTagLetzteWoche;
                dateTimePickerEnd.Value = ersterTagAktuelleWoche;
            }
            else
            {
                // Optional: Setze die DateTimePicker-Werte zurück oder lass sie unverändert
                dateTimePickerStart.Value = DateTime.Now;
                dateTimePickerEnd.Value = DateTime.Now;
            }
        }



    }

    // Hilfsklasse für Einträge in der ComboBox, um Namen und Id zu speichern
    public class ComboBoxItem
    {
        public string Text { get; }
        public string Value { get; }

        public ComboBoxItem(string text, string value)
        {
            Text = text;
            Value = value;
        }

        // Damit der Name in der ComboBox angezeigt wird
        public override string ToString()
        {
            return Text;
        }
    }

    // Hilfsklasse zum Speichern von Berichtspfad und Berichtname
    public class ReportItem
    {
        public string FullPath { get; set; }
        public string Name { get; set; }

        public ReportItem(string fullPath)
        {
            FullPath = fullPath;
            Name = Path.GetFileName(fullPath); // Nur der Name des Berichts, ohne Pfad
        }

        public override string ToString()
        {
            return Name; // Hier wird nur der Name des Berichts angezeigt
        }
    }

}
