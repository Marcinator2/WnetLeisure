using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using Microsoft.Data.SqlClient;



namespace WnetLeisure
{
    public class ButtonDatenbankenLaden
    {
        // SQL-Verbindungszeichenfolge aus den Einstellungen
        private string connectionString = $"Server={WnetLeisure.Properties.Settings.Default.SQLServer};Integrated Security=True;TrustServerCertificate={WnetLeisure.Properties.Settings.Default.trustServerCert};";

        public void FillFlowLayoutPanel(FlowLayoutPanel flowLayoutPanel)
        {
            // Sicherstellen, dass das FlowLayoutPanel leer ist
            flowLayoutPanel.Controls.Clear();

            // Verbindung zur Datenbank herstellen
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Verbindung öffnen

                    // SQL-Abfrage: Namen aller Datenbanken, die mit "wnet_Daten" beginnen
                    string query = "SELECT name FROM sys.databases WHERE name LIKE 'wnet_Daten%'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Datenbanknamen lesen und in das FlowLayoutPanel einfügen
                            while (reader.Read())
                            {
                                string dbName = reader.GetString(0);

                                // Panel für jede Datenbank
                                Panel panel = new Panel
                                {
                                    Width = 200,
                                    Height = 300,
                                    Margin = new Padding(10),
                                    BorderStyle = BorderStyle.FixedSingle
                                };

                                // Überschrift hinzufügen
                                Label titleLabel = new Label
                                {
                                    Text = dbName,
                                    Dock = DockStyle.Top,
                                    TextAlign = ContentAlignment.MiddleCenter
                                };
                                panel.Controls.Add(titleLabel);

                                // Kuchendiagramm erstellen (mit echten Daten aus der Datenbank)
                                Chart pieChart = new Chart
                                {
                                    Dock = DockStyle.Fill
                                };
                                pieChart.ChartAreas.Add(new ChartArea("ChartArea"));

                                // Eine neue Verbindung für das Zählen der Kategorien erstellen
                                using (SqlConnection countConnection = new SqlConnection(connectionString))
                                {
                                    countConnection.Open();

                                    // Dynamische SQL-Abfrage mit Datenbanknamen
                                    string countQuery = $@"
                                SELECT 
                                    COUNT(CASE WHEN VerbindungsStatus = 0 THEN 1 END) AS 'Verbindung ok',
                                    COUNT(CASE WHEN VerbindungsStatus = 10006 THEN 1 END) AS 'Seriennummer falsch',
                                    COUNT(CASE WHEN VerbindungsStatus <> 0 AND VerbindungsStatus <> 10006 THEN 1 END) AS 'Keine Verbindung'
                                FROM [{dbName}].[dbo].[Geraet]";

                                    using (SqlCommand countCommand = new SqlCommand(countQuery, countConnection))
                                    {
                                        using (SqlDataReader countReader = countCommand.ExecuteReader())
                                        {
                                            if (countReader.Read())
                                            {
                                                // Zählen der jeweiligen Kategorien
                                                int verbindungOkCount = countReader.GetInt32(0); // "Verbindung ok"
                                                int seriennummerFalschCount = countReader.GetInt32(1); // "Seriennummer falsch"
                                                int keineVerbindungCount = countReader.GetInt32(2); // "Keine Verbindung"

                                                // Kuchendiagramm erstellen
                                                Series series = new Series
                                                {
                                                    ChartType = SeriesChartType.Pie
                                                };

                                                // Die gezählten Werte als Punkte hinzufügen und Farben festlegen
                                                DataPoint verbindungOkPoint = new DataPoint(0, verbindungOkCount)
                                                {
                                                    Label = "Verbindung ok",
                                                    Color = Color.Green // Setzt die Farbe auf Grün
                                                };
                                                series.Points.Add(verbindungOkPoint);

                                                DataPoint seriennummerFalschPoint = new DataPoint(0, seriennummerFalschCount)
                                                {
                                                    Label = "Seriennummer falsch",
                                                    Color = Color.Orange // Setzt die Farbe auf Rot
                                                };
                                                series.Points.Add(seriennummerFalschPoint);

                                                DataPoint keineVerbindungPoint = new DataPoint(0, keineVerbindungCount)
                                                {
                                                    Label = "Keine Verbindung",
                                                    Color = Color.Red // Setzt die Farbe auf Orange
                                                };
                                                series.Points.Add(keineVerbindungPoint);

                                                // Serie zum Diagramm hinzufügen
                                                pieChart.Series.Add(series);
                                            }
                                        }
                                    }
                                }

                                panel.Controls.Add(pieChart);

                                // Panel ins FlowLayoutPanel hinzufügen
                                flowLayoutPanel.Controls.Add(panel);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler beim Abrufen der Datenbanken: {ex.Message}");
                }
            }
        }

    }
}
