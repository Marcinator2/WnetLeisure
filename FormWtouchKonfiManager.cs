using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;

namespace WnetLeisure
{
    public partial class FormWtouchKonfiManager : Form
    {
        public FormWtouchKonfiManager()
        {
            InitializeComponent();
        }

        private void FormWtouchKonfiManager_Load(object sender, EventArgs e)
        {
            comboBoxHostname_fuellen();
            textBoxIPWtouch.Text = "10.10.10.150";
        }

        private async void buttonVerbinden_Click(object sender, EventArgs e)
        {
            // Alte Tabelle entfernen, falls vorhanden
            tabPageAutostarts.Controls.Clear();
            LeereTextBoxen();
            string Port;
            string ipWtouch = textBoxIPWtouch.Text;
            string Hostname;
            if (comboBoxHostname.SelectedIndex == 0)
            {
                Port = "8083";
            }
            else
            {
                Hostname = comboBoxHostname.Text;
                Port = "8323/https://" + Hostname + ".local:8083";
            }
            string urlSettingsService = $"https://{ipWtouch}:{Port}/api/v1/settings/service";
            string urlSettingsOven = $"https://{ipWtouch}:{Port}/api/v1/settings/oven";
            string urlAutostarts = $"https://{ipWtouch}:{Port}/api/v1/calendar/default";
            string urlBackprogramme = $"https://{ipWtouch}:{Port}/api/v1/recipes";


            try
            {
                // HttpClient konfigurieren mit Zertifikatsoptionen
                using (HttpClientHandler handler = new HttpClientHandler())
                {
                    handler.ClientCertificateOptions = ClientCertificateOption.Automatic;
                    handler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;

                    using (HttpClient client = new HttpClient(handler))
                    {
                        client.Timeout = TimeSpan.FromSeconds(3); // Timeout auf 3 Sekunden setzen

                        // Anfrage an die URL senden und JSON-Daten abrufen
                        HttpResponseMessage responseService = await client.GetAsync(urlSettingsService);
                        responseService.EnsureSuccessStatusCode(); // Fehler werfen, wenn die Anfrage fehlschlägt
                        HttpResponseMessage responseOven = await client.GetAsync(urlSettingsOven);
                        HttpResponseMessage responseAutostarts = await client.GetAsync(urlAutostarts);
                        HttpResponseMessage responseBackprogramme = await client.GetAsync(urlBackprogramme);



                        // JSON-Daten lesen und parsen
                        string jsonResponseService = await responseService.Content.ReadAsStringAsync();
                        JsonNode jsonNodeService = JsonNode.Parse(jsonResponseService);
                        string jsonResponseOven = await responseOven.Content.ReadAsStringAsync();
                        JsonNode jsonNodeOven = JsonNode.Parse(jsonResponseOven);
                        string jsonResponseAutostarts = await responseAutostarts.Content.ReadAsStringAsync();
                        JsonNode jsonNodeAutoStarts = JsonNode.Parse(jsonResponseAutostarts);
                        string jsonResponseBackprogramme = await responseBackprogramme.Content.ReadAsStringAsync();
                        JsonNode jsonNodeBackprogramme = JsonNode.Parse(jsonResponseBackprogramme);


                        // Tabelle erstellen und füllen
                        FuelleAutostartTabelle(jsonNodeAutoStarts);

                        // Werte von "Service" extrahieren
                        string serial = jsonNodeService?["serial"]?.ToString();
                        textBoxSeriennummer.Text = serial;
                        string Typ = jsonNodeService?["oven_type"]?.ToString();
                        textBoxTyp.Text = Typ;
                        string MAC = jsonNodeService?["mac_eth0"]?.ToString();
                        textBoxMAC.Text = MAC;
                        string Reinigung = jsonNodeService?["cleaning_type"]?.ToString();
                        textBoxReinigung.Text = Reinigung;
                        string Tuer = jsonNodeService?["door_type"]?.ToString();
                        textBoxTuer.Text = Tuer;
                        string Beschwadung = jsonNodeService?["steaming_type"]?.ToString();
                        textBoxBeschwadung.Text = Beschwadung;

                        // Werte von "Oven" extrahieren (Achtung auf verschachtelte Objekte)
                        string timeZone = jsonNodeOven?["oven"]?["time_zone"]?.ToString();
                        textBoxZeitzone.Text = timeZone;
                        string timeServer = jsonNodeOven?["oven"]?["time_server"]?.ToString();
                        textBoxZeitServer.Text = timeServer;
                        string DateTime = jsonNodeOven?["oven"]?["date_time_auto"]?.ToString();
                        textBoxDateTime.Text = DateTime;
                        string UpdateServer = jsonNodeOven?["network"]?["general"]?["update_server"]?.ToString();
                        textBoxUpdateServer.Text = UpdateServer;
                        string Rolle = jsonNodeOven?["network"]?["general"]?["network_role"]?.ToString();
                        textBoxRolle.Text = Rolle;
                        string HostnameWtouch = jsonNodeOven?["network"]?["general"]?["avahi_hostname"]?.ToString();
                        textBoxHostnameWtouch.Text = HostnameWtouch;

                        //Hintergrundbild
                        string HintergrundbildString = jsonNodeOven?["visual"]?["wallpaper"]?.ToString();
                        // Nur den Dateinamen extrahieren
                        string HintergrundbildName = Path.GetFileName(HintergrundbildString);
                    
                        string urlHintergrund = $"https://{ipWtouch}:{Port}/api/v1/storage/internal/{HintergrundbildName}?path=%2F";
                        // Sende die HTTP-Anfrage
                        HttpResponseMessage responseHintergrund = await client.GetAsync(urlHintergrund);
                        responseHintergrund.EnsureSuccessStatusCode(); // Fehler werfen, wenn der HTTP-Status nicht erfolgreich ist

                        // Lade das Bild direkt aus dem Stream
                        using (Stream bildStream = await responseHintergrund.Content.ReadAsStreamAsync())
                        {
                            Image bild = Image.FromStream(bildStream);
                            pictureBoxHintergrund.BackgroundImage = bild; // Setze das Bild als Hintergrund
                            pictureBoxHintergrund.BackgroundImageLayout = ImageLayout.Zoom; // Optional: Passe die Darstellung an
                        }


                        FuelleBackprogrammeTabelle(jsonNodeBackprogramme, ipWtouch, Port);
                        FuelleAutostartTabelle(jsonNodeAutoStarts);
                    }
                }
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("Die Anfrage hat zu lange gedauert und wurde abgebrochen.", "Timeout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ein Fehler ist aufgetreten: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LeereTextBoxen()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox && control != textBoxIPWtouch)
                {
                    control.Text = string.Empty;
                }
            }

            // Durchlaufe alle TabPages im TabControl
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                // Suche das TableLayoutPanel in der aktuellen TabPage
                foreach (Control control in tabPage.Controls)
                {
                    if (control is TableLayoutPanel tableLayoutPanel)
                    {
                        // Durchlaufe alle Controls im TableLayoutPanel
                        foreach (Control tableControl in tableLayoutPanel.Controls)
                        {

                            if (tableControl is TextBox)
                            {
                                tableControl.Text = string.Empty; // Leere die TextBox
                            }

                        }
                    }
                }
            }

            // ComboBox zurücksetzen (falls gewünscht)
            //comboBoxHostname.SelectedIndex = 0;
        }

        private void comboBoxHostname_fuellen()
        {
            comboBoxHostname.Items.Clear();
            comboBoxHostname.Items.Add("direkt");
            comboBoxHostname.Items.Add("wiesheu-top");
            comboBoxHostname.Items.Add("wiesheu-bottom");
            comboBoxHostname.Items.Add("wiesheu-1");
            comboBoxHostname.Items.Add("wiesheu-2");
            comboBoxHostname.Items.Add("wiesheu-3");
            comboBoxHostname.SelectedIndex = 0;
        }

        private void FuelleAutostartTabelle(JsonNode jsonNodeAutoStarts)
        {


            // DataGridView erstellen
            DataGridView dataGridView = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AllowUserToAddRows = false,
                ReadOnly = true,
                AllowUserToResizeColumns = false, // Spalten nicht mehr größenveränderbar
                AllowUserToResizeRows = false,    // Zeilen nicht mehr größenveränderbar
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing // Kopfzeilenhöhe nicht veränderbar
            };
            // Styling für die Kopfzeile
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue; // Hellblau
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;    // Schriftfarbe Schwarz
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold); // Schrift fett
            dataGridView.EnableHeadersVisualStyles = false; // Nutzt das benutzerdefinierte Styling

            // Spalten hinzufügen
            dataGridView.Columns.Add("Day", "Tag");
            dataGridView.Columns.Add("StartTime", "Startzeit");
            dataGridView.Columns.Add("Recipe", "Rezept");

            // Daten aus JSON extrahieren
            foreach (var day in new[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" })
            {
                JsonNode? dayData = jsonNodeAutoStarts?[day];
                if (dayData != null)
                {
                    string startTime = dayData["start"]?["localtime"]?.ToString() ?? "Keine";
                    string recipe = dayData["start"]?["recipe"]?.ToString() ?? "Keine";
                    dataGridView.Rows.Add(day, startTime, recipe);
                }
            }

            // DataGridView zur TabPage hinzufügen
            tabPageAutostarts.Controls.Add(dataGridView);
        }
        private async void FuelleBackprogrammeTabelle(JsonNode jsonNodeBackprogramme, string ipWtouch, string Port)
        {
            // DataGridView erstellen
            DataGridView dataGridView = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AllowUserToAddRows = false,
                ReadOnly = true,
                AllowUserToResizeColumns = false, // Spalten nicht mehr größenveränderbar
                AllowUserToResizeRows = false,    // Zeilen nicht mehr größenveränderbar
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing // Kopfzeilenhöhe nicht veränderbar
            };

            // Styling für die Kopfzeile
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue; // Hellblau
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;    // Schriftfarbe Schwarz
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold); // Schrift fett
            dataGridView.EnableHeadersVisualStyles = false; // Nutzt das benutzerdefinierte Styling

            // Spalten hinzufügen
            dataGridView.Columns.Add("ProgramName", "Programmname");
            dataGridView.Columns.Add("ProgramType", "Programmart");
            dataGridView.Columns.Add("IconFileName", "Icon-Dateiname");
            dataGridView.Columns.Add("UUID", "UUID");

            // Spalte für Bilder hinzufügen
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
            {
                Name = "IconFile",
                HeaderText = "Icon",
                ImageLayout = DataGridViewImageCellLayout.Zoom // Bild skalieren
            };
            dataGridView.Columns.Add(imageColumn);

            // Daten aus JSON extrahieren
            foreach (JsonNode program in jsonNodeBackprogramme.AsArray())
            {
                string? programName = program["beschreibung"]?["name"]?.ToString() ?? "N/A";
                string? programType = program["beschreibung"]?["type"]?.ToString() ?? "N/A";
                string? iconFileName = program["beschreibung"]?["icon_filename"]?.ToString() ?? "N/A";
                string? UUID = program["uuid"]?.ToString() ?? "N/A";

                // Platzhalter-Zeile hinzufügen (das Bild wird später asynchron geladen)
                int rowIndex = dataGridView.Rows.Add(programName, programType, iconFileName, UUID);

      
            }

            // DataGridView zur TabPage hinzufügen
            tabPageBackprogramme.Controls.Add(dataGridView);
        }

    }
}
