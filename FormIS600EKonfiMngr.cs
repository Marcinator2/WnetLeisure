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
using System.Net;
using System.Threading;

namespace WnetLeisure
{
    public partial class FormIS600EKonfiMngr : Form
    {

        private CancellationTokenSource cancellationTokenSource;

        private List<string> ipList = new List<string>(); // Liste der IP-Adressen
        private string ipListFilePath; // Pfad zur IP-Liste
        private string logFilePath; // Pfad zur Log-Datei

        public class TransferResult
        {
            public string FtpServer { get; set; }
            public string FilePath { get; set; }
            public bool Success { get; set; }
        }

        public FormIS600EKonfiMngr()
        {
            InitializeComponent();
            this.FormClosing += FormIS600EKonfiMngr_FormClosing;// Event-Handler für das Schließen des Fensters
        }

        private void btnLoadIPList_Click(object sender, EventArgs e)
        {
            OpenFile OpenFile = new OpenFile();

            ipListFilePath = OpenFile.ShowOpenCsvFileDialog();

            // Überprüfen, ob eine Datei ausgewählt wurde
            if (string.IsNullOrWhiteSpace(ipListFilePath))
            {
                return; // Verlassen der Methode, da keine Datei ausgewählt wurde
            }

            lblIPList.Text = "IP-Liste wird gelesen von: " + ipListFilePath;

            using (var reader = new StreamReader(ipListFilePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        ipList.Add(line.Trim()); // IP-Adresse zur Liste hinzufügen
                    }
                }
            }

            string logFileName = Path.GetFileNameWithoutExtension(ipListFilePath) + "_LOG.csv";
            string logDirectory = Path.GetDirectoryName(ipListFilePath);
            logFilePath = Path.Combine(logDirectory, logFileName);
        }


        private async void btnTransfer_Click(object sender, EventArgs e)
        {
            // Deaktivieren der Schaltflächen
            btnTransfer.Enabled = false;
            btnLoadIPList.Enabled = false;

            // Erstellen des CancellationTokenSources
            cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            try
            {
                // Ausführen des Transfers in einem neuen Task
                await Task.Run(() =>
                {
                    List<TransferResult> results = new List<TransferResult>();
                    foreach (string singleIP in ipList)
                    {
                        if (token.IsCancellationRequested)
                            break;

                        TransferResult result = Transfer(singleIP, token);
                        results.Add(result);
                    }

                    LogResultsToCsv(results);
                }, token);
            }
            catch (OperationCanceledException)
            {
                // Task wurde abgebrochen
                Console.WriteLine("Task wurde abgebrochen.");
            }
            finally
            {
                // Aktivieren der Schaltflächen nach Abschluss oder Abbruch des Tasks
                btnTransfer.Enabled = true;
                btnLoadIPList.Enabled = true;
            }

            // Aktivieren der Schaltflächen nach Abschluss des Tasks
            btnTransfer.Enabled = true;
            btnLoadIPList.Enabled = true;
        }

        private TransferResult Transfer(string singleIP, CancellationToken token) // gibt TransferResult zurück
        {
            TransferResult result = new TransferResult();
            result.FtpServer = "ftp://" + singleIP;

            string filePath = WnetLeisure.Properties.Settings.Default.ftpaddIS600E + txtbxPath.Text;
            string ftpUsername = WnetLeisure.Properties.Settings.Default.IS600ENutzer;
            string ftpPassword = WnetLeisure.Properties.Settings.Default.IS600EPW;
            string appDirectory = Path.GetDirectoryName(Application.ExecutablePath); // Verzeichnis der Anwendung
            string localFilePath = appDirectory + filePath.Replace("/", "\\");

            string directoryPath = Path.GetDirectoryName(localFilePath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
                Console.WriteLine("Verzeichnis erstellt: " + directoryPath);
            }

            bool downloadSuccess = DownloadFile(result.FtpServer, filePath, ftpUsername, ftpPassword, localFilePath);

            if (downloadSuccess)
            {
                Console.WriteLine("Datei erfolgreich heruntergeladen.");
                ModifyFile(localFilePath);
                bool uploadSuccess = UploadFile(result.FtpServer, filePath, ftpUsername, ftpPassword, localFilePath);
                result.Success = uploadSuccess;
            }
            else
            {
                Console.WriteLine("Fehler beim Herunterladen der Datei.");
                result.Success = false;
            }

            result.FilePath = filePath;

            try
            {
                // Prüfen, ob Abbruch angefordert wurde
                token.ThrowIfCancellationRequested();
            }
            catch (OperationCanceledException)
            {
                // Wenn Abbruch angefordert wurde, wird eine Ausnahme geworfen
                Console.WriteLine("Transfer wurde abgebrochen.");
            
            }

            return result;
        }


        static bool DownloadFile(string ftpServer, string filePath, string username, string password, string localFilePath)
        {
            try
            {
                string ftpFullPath = $"{ftpServer}/{filePath}";
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpFullPath);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(username, password);

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                using (Stream responseStream = response.GetResponseStream())
                using (FileStream fileStream = new FileStream(localFilePath, FileMode.Create))
                {
                    responseStream.CopyTo(fileStream);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Herunterladen: {ex.Message}");
                return false;
            }
        }

        private void ModifyFile(string localFilePath)
        {
            string Header = string.Empty;
            bool HeaderFound = false;
            bool insideHeaderSection = false;

            // auf txtbxHeader in GUI zugreifen
            this.Invoke((MethodInvoker)(() =>
            {
                Header = txtbxHeader.Text;
            }));

            // Lesen von Herfuntergeladenen Datei
            string[] lines = File.ReadAllLines(localFilePath);
            List<string> newLines = new List<string>();

            Dictionary<string, string> entriesToUpdate = new Dictionary<string, string>();// erstellt ein Dictionary zum Speichern der zu aktualisierenden Einträge

            // Access txtbxEntries on the UI thread
            this.Invoke((MethodInvoker)(() =>
            {
                foreach (string entry in txtbxEntries.Lines)
                {
                    if (entry.Contains("="))
                    {
                        string[] parts = entry.Split('=');
                        if (parts.Length == 2)
                        {
                            string keyToUpdate = parts[0].Trim();
                            string updatedValue = parts[1].Trim();
                            entriesToUpdate[keyToUpdate] = updatedValue; // Speichern des zu aktualisierenden Eintrags
                        }
                    }
                }
            }));

            foreach (string line in lines)
            {
                if (line.Trim().Equals(Header, StringComparison.OrdinalIgnoreCase)) // If header is found
                {
                    HeaderFound = true;
                    insideHeaderSection = true;

                    // Add the header line itself
                    newLines.Add(line);
                    continue; // Move to the next line
                }

                if (insideHeaderSection)
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        insideHeaderSection = false; // End of header section
                        newLines.Add(line);
                        continue;
                    }

                    if (line.Contains("="))
                    {
                        string[] parts = line.Split('=');
                        if (parts.Length == 2)
                        {
                            string key = parts[0].Trim();
                            if (entriesToUpdate.ContainsKey(key))
                            {
                                // Update the line with the new value
                                newLines.Add($"{key}={entriesToUpdate[key]}");
                                entriesToUpdate.Remove(key); // Remove the updated entry
                                continue;
                            }
                        }
                    }
                }

                newLines.Add(line); // Add the original line if no special processing is needed
            }

            // If the Header was not found, add it at the end of newLines and place all entries below it
            if (!HeaderFound)
            {
                newLines.Add("");
                newLines.Add(Header);
                foreach (var entry in entriesToUpdate)
                {
                    newLines.Add($"{entry.Key}={entry.Value}");
                }
            }
            else
            {
                // Add remaining entries to the header section if not updated above
                List<string> tempLines = new List<string>();
                foreach (string line in newLines)
                {
                    tempLines.Add(line);
                    if (line.Trim().Equals(Header, StringComparison.OrdinalIgnoreCase))
                    {
                        foreach (var entry in entriesToUpdate)
                        {
                            if (!tempLines.Any(l => l.StartsWith(entry.Key + "=", StringComparison.OrdinalIgnoreCase)))
                            {
                                tempLines.Add($"{entry.Key}={entry.Value}");
                            }
                        }
                    }
                }
                newLines = tempLines;
            }

            // Write the updated content back to the file
            File.WriteAllLines(localFilePath, newLines.ToArray());
        }


        static bool UploadFile(string ftpServer, string filePath, string username, string password, string localFilePath)
        {
            try
            {
                string ftpFullPath = $"{ftpServer}/{filePath}";
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpFullPath);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(username, password);

                using (Stream requestStream = request.GetRequestStream())
                using (FileStream fileStream = new FileStream(localFilePath, FileMode.Open))
                {
                    fileStream.CopyTo(requestStream);
                }

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    Console.WriteLine($"Upload Status: {response.StatusDescription}");
                    response.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Hochladen: {ex.Message}");
                return false;
            }
        }

        private void LogResultsToCsv(List<TransferResult> results)
        {
            var csvLines = new List<string> { "IP-Adresse;Status" };
            foreach (var result in results)
            {
                string ipAddress = result.FtpServer.Replace("ftp://", ""); // Entferne "ftp://"
                string status = result.Success ? "erfolgreich" : "nicht erfolgreich";
                csvLines.Add($"{ipAddress};{status}");
            }

            File.WriteAllLines(logFilePath, csvLines);
        }

        private void FormIS600EKonfiMngr_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Warnmeldung anzeigen und Schließen bestätigen
            DialogResult result = MessageBox.Show("Wollen Sie das Programm wirklich beenden?", "Programm beenden", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Abbrechen des Schließvorgangs
            }
            else
            {
                // Task abbrechen, wenn das Formular geschlossen wird
                cancellationTokenSource?.Cancel();
            }
        }
    }
}
