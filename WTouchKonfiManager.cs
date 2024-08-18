using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using Renci.SshNet; // Import SSH.NET namespace
using Newtonsoft.Json;



namespace WnetLeisure
{
    public partial class WTouchKonfiManager : Form
    {
        string host;
        string targetHost;
        string username = WnetLeisure.Properties.Settings.Default.WtouchNutzer;// "wiesheu";
        //string pemFilePath = @"C:\Wnet\wnet_2304\wnet_lizenz\WTouchKey.pem"; // Path to your PEM file
        string pemFilePath = WnetLeisure.Properties.Settings.Default.WTouchCert;
        string jsonFilePath = "/usr/var/config/oven_config.json"; // Path to JSON file on the remote server
        string jsonServiceConfig = "/usr/var/config/service_config.json"; // Path to service config JSON file
        string sudoPassword = WnetLeisure.Properties.Settings.Default.WtouchPW;//"wiesheu";
        
        private SshClient client; // Keep a reference to the SSH client

        public WTouchKonfiManager()
        {
            InitializeComponent();
            comboBoxOvenNo.Items.Add("Oven 1");
            comboBoxOvenNo.Items.Add("Oven 2");
            comboBoxOvenNo.Items.Add("Oven 3");
            comboBoxOvenNo.Items.Add("Oven 4");
            comboBoxOvenNo.SelectedIndex = 0;
            txtBxIPConnect.Text = "10.10.10.150";
            host = txtBxIPConnect.Text;
        }

        private void WTouchKonfiManager_Load(object sender, EventArgs e)
        {
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                client = ConnectToHost(host, targetHost, username, pemFilePath);

                if (client == null)
                {
                    return; // Connection failed, abort method
                }

                // Read the JSON file content via SSH
                string jsonString = ReadFileFromServer(client, jsonFilePath);
                string jsonStringService = ReadFileFromServer(client, jsonServiceConfig);

                // Execute command to get the current system time
                string commandGetTime = "date '+%Y-%m-%d %H:%M:%S'";
                using (var command = client.CreateCommand(commandGetTime))
                {
                    string serverTime = command.Execute().Trim(); // Execute and trim result
                    lblDateTime.Text = serverTime;
                }

                // Deserialize JSON data using Newtonsoft.Json
                Root config = JsonConvert.DeserializeObject<Root>(jsonString);
                RootService configService = JsonConvert.DeserializeObject<RootService>(jsonStringService);

                // Ensure the deserialized object is not null
                if (config?.Oven == null)
                {
                    MessageBox.Show("Fehler beim Laden der Ofenkonfiguration.");
                    return;
                }


                MessageBox.Show(config.Oven.TimeZone);
                
                // Populate UI with deserialized data
                //lblMAC.Text = configService?.MAC;
                lblMAC.Text = configService.MAC;
                lblType.Text = configService.OvenType;
                lblSerialNumber.Text = configService.SerialNumber;

                // General
                txtBxTimeZone.Text = config.Oven.TimeZone;
                txtBxTimeServer.Text = config.Oven.TimeServer;
                txtBxUpdateServer.Text = config.Network.General.UpdateServer;
                txtBxNetworRole.Text = config.Network.General.NetworkRole;
                txtBxAvahiHostname.Text = config.Network.General.AvahiHostname;
                txtBxDHCP.Text = config.Network.Eth0.DHCP.ToString();
                txtBxDHCPHostname.Text = config.Network.Eth0.DhcpHostname;
                txtBxAutonegotiation.Text = config.Network.Eth0.Autonegotiation.ToString();
                txtBxGateway.Text = config.Network.Eth0.Gateway;
                txtBxIP.Text = config.Network.Eth0.Ip;
                txtBxNameserver.Text = config.Network.Eth0.Nameserver;
                txtBxNetworkmask.Text = config.Network.Eth0.Netmask;

                // Energy
                txtBxlights_off_standby.Text = config.Energy.LightsOffStandby.ToString();
                txtBXlights_off_baking.Text = config.Energy.LightsOffBaking.ToString();
                txtbxlights_off_cleaning.Text = config.Energy.LightsOffCleaning.ToString();
                txtBxpreheating_timeout_minutes.Text = config.Energy.PreheatingTimeoutMinutes.ToString();

                // Disconnect the SSH client
                DisconnectFromHost();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (client == null)
                {
                    client = ConnectToHost(host, targetHost, username, pemFilePath);
                    if (client == null)
                    {
                        return; // Connection failed, abort method
                    }
                }

                // Read the JSON file content via SSH
                string jsonString = ReadFileFromServer(client, jsonFilePath);

                // Deserialize JSON data using Newtonsoft.Json
                Root config = JsonConvert.DeserializeObject<Root>(jsonString);

                // Ensure the deserialized object is not null
                if (config?.Oven == null)
                {
                    MessageBox.Show("Fehler beim Laden der Ofenkonfiguration.");
                    return;
                }

                // Update configuration based on text box values
                config.Oven.TimeZone = txtBxTimeZone.Text;
                config.Oven.TimeServer = txtBxTimeServer.Text;
                config.Network.General.UpdateServer = txtBxUpdateServer.Text;
                config.Network.General.NetworkRole = txtBxNetworRole.Text;
                config.Network.General.AvahiHostname = txtBxAvahiHostname.Text;

                // Network Eth0
                config.Network.Eth0.DHCP = bool.Parse(txtBxDHCP.Text);
                config.Network.Eth0.DhcpHostname = txtBxDHCPHostname.Text;
                config.Network.Eth0.Autonegotiation = bool.Parse(txtBxAutonegotiation.Text);
                config.Network.Eth0.Gateway = txtBxGateway.Text;
                config.Network.Eth0.Ip = txtBxIP.Text;
                config.Network.Eth0.Nameserver = txtBxNameserver.Text;
                config.Network.Eth0.Netmask = txtBxNetworkmask.Text;

                // Energy
                config.Energy.LightsOffStandby = bool.Parse(txtBxlights_off_standby.Text);
                config.Energy.LightsOffBaking = bool.Parse(txtBXlights_off_baking.Text);
                config.Energy.LightsOffCleaning = bool.Parse(txtbxlights_off_cleaning.Text);
                config.Energy.PreheatingTimeoutMinutes = int.Parse(txtBxpreheating_timeout_minutes.Text);

                // Serialize the updated configuration back to a JSON string
                jsonString = JsonConvert.SerializeObject(config, Formatting.Indented);

                // Write the updated JSON content back to the server
                WriteFileToServer(client, jsonFilePath, jsonString);

                // Disconnect the SSH client
                DisconnectFromHost();

                MessageBox.Show("Daten erfolgreich gespeichert.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message);
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            // Get the time from the DateTimePicker in HH:mm format
            string restartTime = dateTimePicker1.Value.ToString("HH:mm");

            try
            {
                if (client == null)
                {
                    client = CreateSshClient(host, username, pemFilePath);
                    if (client == null)
                    {
                        return; // Connection failed, abort method
                    }
                }

                // Standard sudo command for immediate restart
                string commandText = $"echo {sudoPassword} | sudo -S shutdown -r now";

                // Check if the checkbox in the DateTimePicker is checked
                if (dateTimePicker1.ShowCheckBox && dateTimePicker1.Checked)
                {
                    // Append the time to the command to delay the restart
                    commandText = $"echo {sudoPassword} | sudo -S shutdown -r {restartTime}";
                }

                using (var command = client.CreateCommand(commandText))
                {
                    command.Execute();
                    if (!string.IsNullOrEmpty(command.Error))
                    {
                        throw new Exception($"Fehler beim Ausführen des Befehls: {command.Error}");
                    }
                }

                // Disconnect the SSH client
                DisconnectFromHost();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message);
            }
        }

        private SshClient ConnectToHost(string host, string targetHost, string username, string pemFilePath)
        {
            return comboBoxOvenNo.SelectedIndex == 0
                ? CreateSshClient(host, username, pemFilePath)
                : ConnectViaJumphost(host, targetHost, username, pemFilePath);
        }

        private void DisconnectFromHost()
        {
            if (client != null && client.IsConnected)
            {
                client.Disconnect();
                client.Dispose();
                client = null;
            }
        }

        private SshClient CreateSshClient(string host, string username, string pemFilePath)
        {
            try
            {
                // Create a private key file object using the PEM file
                using (var privateKeyFile = new PrivateKeyFile(pemFilePath))
                {
                    // Create a list of private key files
                    var keyFiles = new[] { privateKeyFile };

                    // Create a connection info object with a timeout
                    var connectionInfo = new ConnectionInfo(host, username, new PrivateKeyAuthenticationMethod(username, keyFiles))
                    {
                        Timeout = TimeSpan.FromSeconds(2) // Set the timeout duration here
                    };

                    // Create and return the SSH client
                    var client = new SshClient(connectionInfo);
                    client.Connect();

                    return client;
                }
            }
            catch (Exception ex)
            {
                // Use MessageBox to show the error message in a Windows Forms application
                MessageBox.Show("Ein Fehler ist bei der SSH-Verbindung aufgetreten: " + ex.Message);
                return null;
            }
        }

        private SshClient ConnectViaJumphost(string jumphost, string targetHost, string username, string privateKeyPath)
        {
            var keyFile = new PrivateKeyFile(privateKeyPath);
            var keyFiles = new[] { keyFile };

            // Create the SSH connection details for the jump host with timeout
            var jumpConnectionInfo = new ConnectionInfo(jumphost, username, new PrivateKeyAuthenticationMethod(username, keyFiles))
            {
                Timeout = TimeSpan.FromSeconds(5) // Set the timeout duration here
            };

            try
            {
                using (var jumpClient = new SshClient(jumpConnectionInfo))
                {
                    jumpClient.Connect();

                    using (var portForwarded = new ForwardedPortLocal("localhost", 22, targetHost, 22))
                    {
                        jumpClient.AddForwardedPort(portForwarded);
                        portForwarded.Start();

                        var targetConnectionInfo = new ConnectionInfo("localhost", 22, username, new PrivateKeyAuthenticationMethod(username, keyFiles))
                        {
                            Timeout = TimeSpan.FromSeconds(10) // Set the timeout duration here
                        };

                        var targetClient = new SshClient(targetConnectionInfo);
                        targetClient.Connect();

                        return targetClient;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Verbinden über den Jumphost: " + ex.Message);
                return null;
            }
        }

        private string ReadFileFromServer(SshClient client, string filePath)
        {
            // Ensure that the SSH client is connected before running commands
            if (client == null || !client.IsConnected)
            {
                throw new InvalidOperationException("SSH client is not connected.");
            }

            try
            {
                // Create and execute the command to read the file content
                using (var command = client.CreateCommand($"cat {filePath}"))
                {
                    // Execute the command
                    var result = command.Execute();

                    // Check for errors
                    if (command.ExitStatus != 0)
                    {
                        throw new InvalidOperationException($"Command execution failed with exit code {command.ExitStatus}. Error: {command.Error}");
                    }

                    return result;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                throw new InvalidOperationException("An error occurred while reading the file from the server.", ex);
            }
        }

        private void WriteFileToServer(SshClient client, string filePath, string content)
        {
            string tempFilePath = "/home/wiesheu/temp_oven_config.json";

            using (var scp = new ScpClient(client.ConnectionInfo))
            {
                scp.Connect();
                using (var ms = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(content)))
                {
                    scp.Upload(ms, tempFilePath);
                }
                scp.Disconnect();
            }

            string commandText = $"echo {sudoPassword} | sudo -S mv {tempFilePath} {filePath}";

            using (var command = client.CreateCommand(commandText))
            {
                command.Execute();
                if (!string.IsNullOrEmpty(command.Error))
                {
                    throw new Exception($"Fehler beim Schreiben: {command.Error}");
                }
            }
        }

        private void txtBxIPConnect_TextChanged(object sender, EventArgs e)
        {
            host = txtBxIPConnect.Text;
        }

        private void comboBoxOvenNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOvenNo.SelectedIndex == 0)
            {
                targetHost = "";
            }
            if (comboBoxOvenNo.SelectedIndex == 1)
            {
                targetHost = "169.254.0.101";
            }
            if (comboBoxOvenNo.SelectedIndex == 2)
            {
                targetHost = "169.254.0.102";
            }

            if (comboBoxOvenNo.SelectedIndex == 3)
            {
                targetHost = "169.254.0.103";
            }
        }


    }

    // Your existing classes here
    public class RootService
        {
            [JsonProperty("serial")]
            public string SerialNumber { get; set; }

            [JsonProperty("oven_type")]
            public string OvenType { get; set; }

            [JsonProperty("mac_eth0")]
            public string MAC { get; set; }
        }
        public class Root
        {

            [JsonProperty("protected")]
            public List<string> ProtectedList { get; set; }

            [JsonProperty("oven")]
            public Oven Oven { get; set; }

            [JsonProperty("network")]
            public Network Network { get; set; }

            [JsonProperty("energy")]
            public Energy Energy { get; set; }

            [Newtonsoft.Json.JsonExtensionData]
            public IDictionary<string, object> ExtensionData { get; set; }


        }

        public class Oven
        {
            [JsonProperty("time_zone")]
            public string TimeZone { get; set; }

            [JsonProperty("time_server")]
            public string TimeServer { get; set; }
        }

        public class General
        {
            [JsonProperty("update_server")]
            public string UpdateServer { get; set; }

            [JsonProperty("network_role")]
            public string NetworkRole { get; set; }

            [JsonProperty("avahi_hostname")]
            public string AvahiHostname { get; set; }
        }

        public class Eth0
        {
            [JsonProperty("DHCP")]
            public bool DHCP { get; set; }

            [JsonProperty("dhcp_hostname")]
            public string DhcpHostname { get; set; }

            [JsonProperty("autonegotiation")]
            public bool Autonegotiation { get; set; }

            [JsonProperty("ip")]
            public string Ip { get; set; }

            [JsonProperty("gateway")]
            public string Gateway { get; set; }

            [JsonProperty("netmask")]
            public string Netmask { get; set; }

            [JsonProperty("nameserver")]
            public string Nameserver { get; set; }
        }

        public class Network
        {
            [JsonProperty("general")]
            public General General { get; set; }

            [JsonProperty("eth0")]
            public Eth0 Eth0 { get; set; }
        }



        public class Energy
        {
            [JsonProperty("lights_off_standby")]
            public bool LightsOffStandby { get; set; }

            [JsonProperty("lights_off_baking")]
            public bool LightsOffBaking { get; set; }

            [JsonProperty("lights_off_cleaning")]
            public bool LightsOffCleaning { get; set; }

            [JsonProperty("preheating_timeout_minutes")]
            public int PreheatingTimeoutMinutes { get; set; }
        }


    
}
