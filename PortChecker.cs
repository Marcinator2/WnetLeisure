using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WnetLeisure
{
    public partial class PortChecker : Form
    {
        
        private CancellationTokenSource _cancellationTokenSource;

        public PortChecker()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(PortChecker_FormClosing);
        }

        private async void btnStart_Click(object sender, EventArgs e)//async damit mehrere Tasks gleichzeitig ausgeführt werden können
        {
            btnStart.Enabled = false; // Deaktiviert die Schaltfläche
            _cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = _cancellationTokenSource.Token;

            try
            {
                await PortTestRun(token);//führt PortChecker aus
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Der Vorgang wurde abgebrochen.");
            }
            finally
            {
                if (_cancellationTokenSource != null)
                {
                    _cancellationTokenSource.Dispose();
                    _cancellationTokenSource = null;
                }
                btnStart.Enabled = true; // Aktiviert die Schaltfläche wieder
            }
        }
        //PortChecker ausführen
        private async Task PortTestRun(CancellationToken token)
        {
            OpenFile OpenFile = new OpenFile();

            string selectedFilePath = OpenFile.ShowOpenCsvFileDialog();
            lblRead.Text = "IP-Liste wird gelesen von: " + selectedFilePath;
            string saveFileName = Path.GetFileNameWithoutExtension(selectedFilePath) + "_result.csv";

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = saveFileName;

            string resultFile = null;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                resultFile = saveFileDialog.FileName;
                lblWrite.Text = "Ergebnis wird geschrieben in: " + resultFile;
            }

            if (resultFile == null) return;

            await Task.Run(() => //Startet eine neue Task
            {
                if (selectedFilePath != null)
                {
                    try
                    {
                        using (var reader = new StreamReader(selectedFilePath))
                        using (var writer = new StreamWriter(resultFile))
                        {
                            PortsInputDialog portsDialog = new PortsInputDialog();
                            if (portsDialog.ShowDialog() == DialogResult.OK)
                            {
                                UpdateStatusLabel("Und los gehts!");
                                string portNumbers = portsDialog.GetPortNumbers();
                                int[] portsToCheck = portNumbers.Split(',').Select(Int32.Parse).ToArray();

                                writer.Write("IP;Ping;");
                                for (int i = 0; i < portsToCheck.Length; i++)
                                {
                                    writer.Write("Port {0};", portsToCheck[i]);
                                }
                                writer.WriteLine();

                                while (!reader.EndOfStream)
                                {
                                    token.ThrowIfCancellationRequested(); // Überprüfe den Abbruch

                                    string[] line = reader.ReadLine().Split(';');
                                    string host = line[0];
                                    string portStatus = host;

                                    try
                                    {
                                        Ping ping = new Ping();
                                        PingReply reply = ping.Send(host);
                                        if (reply.Status == IPStatus.Success)
                                        {
                                            Console.WriteLine("Host {0} is reachable.", host);
                                            UpdateStatusLabel("IP: " + host + " Ping erfolgreich");
                                            portStatus += ";Reachable";
                                            foreach (int port in portsToCheck)
                                            {
                                                token.ThrowIfCancellationRequested(); // Überprüfe den Abbruch

                                                try
                                                {
                                                    using (var client = new TcpClient(host, port))
                                                    {
                                                        Console.WriteLine("Port {0} on IP {1} is open.", port, host);
                                                        UpdateStatusLabel("IP: " + host + " Port: " + port + " offen");
                                                        portStatus += ";Open";
                                                    }
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine("Port {0} on IP {1} is closed.", port, host + ex.Message);
                                                    portStatus += ";Closed";
                                                    UpdateStatusLabel("IP: " + host + " Port: " + port + " geschlossen");
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Host {0} is not reachable.", host);
                                            portStatus += ";Unreachable;;;";
                                            UpdateStatusLabel("IP: " + host + " nicht pingbar");
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Error pinging host: " + ex.Message);
                                        portStatus += ";Error;;;";
                                    }

                                    writer.WriteLine(portStatus);
                                }
                            }
                        }
                    }
                    catch (OperationCanceledException)
                    {
                        MessageBox.Show("Der Vorgang wurde abgebrochen.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message);
                    }
                UpdateStatusLabel("Fäddisch!");
                }
            }, token);
        }

        private void PortChecker_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Möchten Sie den Port Checker wirklich beenden?", "Port Checker beenden", MessageBoxButtons.OKCancel);

            if (result == DialogResult.Cancel)
            {
                e.Cancel = true; // Programm wird nicht geschlossen
            }
            else
            {
                _cancellationTokenSource?.Cancel(); // Abbruch des asynchronen Vorgangs
            }
        }
        //Statuslabel aktualisieren
        private void UpdateStatusLabel(string text)
        {
            if (lblStatus.InvokeRequired)
            {
                lblStatus.Invoke(new Action(() => lblStatus.Text = text));
            }
            else
            {
                lblStatus.Text = text;
            }
        }
    }
}
