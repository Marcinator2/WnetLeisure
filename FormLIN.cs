using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WnetLeisure
{
    public partial class FormLIN : Form
    {
        public FormLIN()
        {
            InitializeComponent();
        }

        private void FormLIN_Load(object sender, EventArgs e)
        {
            // Laden des Werts aus den Einstellungen
            txtBxServer.Text = WnetLeisure.Properties.Settings.Default.SQLServer;
        }

        private async void btnLINladen_Click(object sender, EventArgs e)
        {
            // Öffnen des Datei-Dialogs
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            openFileDialog.Title = "Select a CSV file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string serverAddress = txtBxServer.Text;

                // Authentifizierungsformular anzeigen
                using (FormAuthentication formAuth = new FormAuthentication())
                {
                    if (formAuth.ShowDialog() == DialogResult.OK)
                    {
                        string connectionString;
                        if (formAuth.IsWindowsAuth)
                        {
                            connectionString = $"Server={serverAddress};Integrated Security=True;";
                        }
                        else
                        {
                            connectionString = $"Server={serverAddress};User ID={formAuth.Username};Password={formAuth.Password};";
                        }

                        // Führen Sie die lange laufende Operation asynchron aus
                        var progress = new Progress<int>(value => prgrsBrFortschritt.Value = value);
                        await Task.Run(() => ProcessCsvFile(filePath, connectionString, progress));

                        MessageBox.Show("CSV data imported successfully.");
                    }
                }
            }
        }

        private void ProcessCsvFile(string filePath, string connectionString, IProgress<int> progress)
        {
            // Lesen der CSV-Datei
            List<string[]> csvData = new List<string[]>();
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    csvData.Add(line.Split(';'));
                }
            }

            // Verbindung zum SQL Server
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Überprüfen, ob die Datenbank existiert
                string checkDatabaseQuery = "IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'wnet_LIN') CREATE DATABASE wnet_LIN";
                using (SqlCommand command = new SqlCommand(checkDatabaseQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Verbindung zur wnet_LIN Datenbank
                connection.ChangeDatabase("wnet_LIN");

                // Überprüfen, ob die Tabelle existiert und erstellen falls nicht
                string createTableQuery = @"
                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'SNLINBJ')
                    CREATE TABLE SNLINBJ (
                        Seriennummer NVARCHAR(50),
                        LIN NVARCHAR(50),
                        BJ NVARCHAR(50)
                    )";
                using (SqlCommand command = new SqlCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Löschen der bestehenden Daten in der Tabelle
                string deleteDataQuery = "DELETE FROM SNLINBJ";
                using (SqlCommand command = new SqlCommand(deleteDataQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Einfügen der Daten in die Tabelle
                int rowCount = csvData.Count - 1; // Minus 1 for header
                for (int i = 1; i < csvData.Count; i++) // Skip header row
                {
                    var row = csvData[i];
                    string insertQuery = "INSERT INTO SNLINBJ (Seriennummer, LIN, BJ) VALUES (@Seriennummer, @LIN, @BJ)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Seriennummer", row[0]);
                        command.Parameters.AddWithValue("@LIN", row[1]);
                        command.Parameters.AddWithValue("@BJ", row[2]);
                        command.ExecuteNonQuery();
                    }
                    progress.Report((i * 100) / rowCount);
                }
                MessageBox.Show("LINs hochgeladen.", "Supi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            WnetLeisure.Properties.Settings.Default.SQLServer = txtBxServer.Text;
            WnetLeisure.Properties.Settings.Default.Save();
            MessageBox.Show("Einstellungen wurden gespeichert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
