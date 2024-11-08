namespace WnetLeisure
{
    partial class FormServerZugaenge
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            textBoxDBServer = new System.Windows.Forms.TextBox();
            textBoxReportServer = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            buttonDBSettingsLaden = new System.Windows.Forms.Button();
            buttonDBSettingsSpeichern = new System.Windows.Forms.Button();
            checkBoxServerCert = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(41, 56);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Datenbank Server:";
            // 
            // textBoxDBServer
            // 
            textBoxDBServer.Location = new System.Drawing.Point(154, 48);
            textBoxDBServer.Name = "textBoxDBServer";
            textBoxDBServer.Size = new System.Drawing.Size(226, 23);
            textBoxDBServer.TabIndex = 1;
            // 
            // textBoxReportServer
            // 
            textBoxReportServer.Location = new System.Drawing.Point(154, 83);
            textBoxReportServer.Name = "textBoxReportServer";
            textBoxReportServer.Size = new System.Drawing.Size(226, 23);
            textBoxReportServer.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(41, 91);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 15);
            label2.TabIndex = 2;
            label2.Text = "Report Server:";
            // 
            // buttonDBSettingsLaden
            // 
            buttonDBSettingsLaden.Location = new System.Drawing.Point(386, 51);
            buttonDBSettingsLaden.Name = "buttonDBSettingsLaden";
            buttonDBSettingsLaden.Size = new System.Drawing.Size(154, 23);
            buttonDBSettingsLaden.TabIndex = 4;
            buttonDBSettingsLaden.Text = "DB Settings Laden";
            buttonDBSettingsLaden.UseVisualStyleBackColor = true;
            buttonDBSettingsLaden.Click += buttonDBSettingsLaden_Click;
            // 
            // buttonDBSettingsSpeichern
            // 
            buttonDBSettingsSpeichern.Location = new System.Drawing.Point(386, 83);
            buttonDBSettingsSpeichern.Name = "buttonDBSettingsSpeichern";
            buttonDBSettingsSpeichern.Size = new System.Drawing.Size(154, 23);
            buttonDBSettingsSpeichern.TabIndex = 5;
            buttonDBSettingsSpeichern.Text = "DB Settings Speichern";
            buttonDBSettingsSpeichern.UseVisualStyleBackColor = true;
            buttonDBSettingsSpeichern.Click += buttonDBSettingsSpeichern_Click;
            // 
            // checkBoxServerCert
            // 
            checkBoxServerCert.AutoSize = true;
            checkBoxServerCert.Location = new System.Drawing.Point(80, 14);
            checkBoxServerCert.Name = "checkBoxServerCert";
            checkBoxServerCert.Size = new System.Drawing.Size(111, 19);
            checkBoxServerCert.TabIndex = 6;
            checkBoxServerCert.Text = "Trust Server Cert";
            checkBoxServerCert.UseVisualStyleBackColor = true;
            // 
            // FormServerZugaenge
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(583, 199);
            Controls.Add(checkBoxServerCert);
            Controls.Add(buttonDBSettingsSpeichern);
            Controls.Add(buttonDBSettingsLaden);
            Controls.Add(textBoxReportServer);
            Controls.Add(label2);
            Controls.Add(textBoxDBServer);
            Controls.Add(label1);
            Name = "FormServerZugaenge";
            Text = "FormServerZugaenge";
            this.Load += FormServerZugaenge_Load;  // Sicherstellen, dass das Load-Ereignis richtig verbunden ist.
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDBServer;
        private System.Windows.Forms.TextBox textBoxReportServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDBSettingsLaden;
        private System.Windows.Forms.Button buttonDBSettingsSpeichern;
        private System.Windows.Forms.CheckBox checkBoxServerCert;
    }
}