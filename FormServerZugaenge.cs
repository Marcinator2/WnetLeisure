using Microsoft.Extensions.Configuration;
using System;
using System.Windows.Forms;

namespace WnetLeisure
{
    public partial class FormServerZugaenge : Form
    {
        public FormServerZugaenge()
        {
            InitializeComponent();
        }

        private void FormServerZugaenge_Load(object sender, EventArgs e)
        {

            // Sicherstellen, dass die letzten Einstellungen geladen werden
            WnetLeisure.Properties.Settings.Default.Reload();

            // Laden der Werte aus den gespeicherten Einstellungen in die Steuerelemente

            textBoxDBServer.Text = WnetLeisure.Properties.Settings.Default.SQLServer;
            textBoxReportServer.Text = WnetLeisure.Properties.Settings.Default.ReportServer;
            checkBoxServerCert.Checked = WnetLeisure.Properties.Settings.Default.trustServerCert;
            textBoxReportServerDBName.Text = WnetLeisure.Properties.Settings.Default.ReportServerDBName;
            textBoxReportPfad.Text = WnetLeisure.Properties.Settings.Default.ReportPfad;
            checkBoxReportsIgnore_Suffix.Checked = WnetLeisure.Properties.Settings.Default.ignoreSuffix;
            textBoxTimeOutReportServer.Text = WnetLeisure.Properties.Settings.Default.TimeOutReportServer.ToString();

        }

        private void buttonDBSettingsLaden_Click(object sender, EventArgs e)
        {
            // Lade die Konfiguration
            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Parameter aus der Konfiguration
            string server = config["DatabaseSettings:Server"];
            string reportServerUrl = config["ReportServerSettings:BaseUrl"];

            // Lesen des booleschen Werts für trustServerCert
            bool trustServerCert = bool.TryParse(config["DatabaseSettings:trustServerCert"], out bool parsedValue) && parsedValue;

            // Setze die Textfelder und die Checkbox
            textBoxDBServer.Text = server;
            textBoxReportServer.Text = reportServerUrl;
            checkBoxServerCert.Checked = trustServerCert;
        }

        private void buttonDBSettingsSpeichern_Click(object sender, EventArgs e)
        {

            // Speichere die Werte in den Einstellungen

            WnetLeisure.Properties.Settings.Default.SQLServer = textBoxDBServer.Text;
            WnetLeisure.Properties.Settings.Default.ReportServer = textBoxReportServer.Text;
            WnetLeisure.Properties.Settings.Default.trustServerCert = checkBoxServerCert.Checked;
            WnetLeisure.Properties.Settings.Default.ReportServerDBName = textBoxReportServerDBName.Text;
            WnetLeisure.Properties.Settings.Default.ReportPfad = textBoxReportPfad.Text;
            WnetLeisure.Properties.Settings.Default.ignoreSuffix = checkBoxReportsIgnore_Suffix.Checked;
            WnetLeisure.Properties.Settings.Default.TimeOutReportServer = int.Parse(textBoxTimeOutReportServer.Text);
            WnetLeisure.Properties.Settings.Default.Save();
            MessageBox.Show("Einstellungen wurden gespeichert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }


    }
}
