using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using WnetLeisure.Properties;


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
            OpenFile OpenFile = new OpenFile();

            string selectedFilePath = OpenFile.ShowOpenCsvFileDialog();

            if (selectedFilePath != null)
            {
                try
                {
                    using (var reader = new StreamReader(selectedFilePath))
                    {

                        string filePath = selectedFilePath; 
                        string resultFile = "ipportresult.csv";

                        PortsInputDialog portsDialog = new PortsInputDialog(); 
                        if (portsDialog.ShowDialog() == DialogResult.OK)

                        {
                            string portNumbers = portsDialog.GetPortNumbers(); 
                            int[] portsToCheck = portNumbers.Split(',').Select(Int32.Parse).ToArray();
                            {
                                using (var writer = new StreamWriter(resultFile))
                                {                   
                                    // Write header with dynamic number of ports
                                    writer.Write("IP;Ping;");
                                    for (int i = 0; i < portsToCheck.Length; i++)                   
                                    {                     
                                        writer.Write("Port {0};", portsToCheck[i]);                   }                   
                                        writer.WriteLine(); // Start a new line;

                                    while (!reader.EndOfStream)
                                    {
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
                                                portStatus += ";Reachable"; 
                                                foreach (int port in portsToCheck) 
                                                { 
                                                    try 
                                                    { 
                                                        using (var client = new TcpClient(host, port)) 
                                                        { 
                                                            Console.WriteLine("Port {0} on IP {1} is open.", port, host); 
                                                            portStatus += ";Open"; 
                                                        } 
                                                    } 
                                                    catch (Exception ex) 
                                                    { 
                                                        Console.WriteLine("Port {0} on IP {1} is closed.", port, host + ex.Message); 
                                                        portStatus += ";Closed"; 
                                                    } 
                                                } 
                                            } 
                                            else 
                                            { 
                                                Console.WriteLine("Host {0} is not reachable.", host); portStatus += ";Unreachable;;;"; 
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
                    }
                }

                catch (Exception ex) 
                { 
                    Console.WriteLine("Error reading file: " + ex.Message);
                }

                Console.WriteLine("\n Fäddisch!"); 
                Console.ReadLine();
            }

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
    }

}
