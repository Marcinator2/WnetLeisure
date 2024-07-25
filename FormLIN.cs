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

        private void btnLINladen_Click(object sender, EventArgs e)
        {
            // Öffnen des Datei-Dialogs
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            openFileDialog.Title = "Select a CSV file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string serverAddress = txtBxServer.Text;

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
                string connectionString = $"Server={serverAddress};User ID=wnet_svc;Password=wnet_svc;";
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

                    // Einfügen der Daten in die Tabelle
                    foreach (var row in csvData.Skip(1)) // Skip header row
                    {
                        string insertQuery = "INSERT INTO SNLINBJ (Seriennummer, LIN, BJ) VALUES (@Seriennummer, @LIN, @BJ)";
                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Seriennummer", row[0]);
                            command.Parameters.AddWithValue("@LIN", row[1]);
                            command.Parameters.AddWithValue("@BJ", row[2]);
                            command.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("CSV data imported successfully.");
            }
        }
    }
}
