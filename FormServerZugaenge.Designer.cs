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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServerZugaenge));
            label1 = new System.Windows.Forms.Label();
            textBoxDBServer = new System.Windows.Forms.TextBox();
            textBoxReportServer = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            buttonDBSettingsLaden = new System.Windows.Forms.Button();
            buttonDBSettingsSpeichern = new System.Windows.Forms.Button();
            checkBoxServerCert = new System.Windows.Forms.CheckBox();
            textBoxReportsSpeichern = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            textBoxReportServerDBName = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            textBoxReportPfad = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            checkBoxReportsIgnore_Suffix = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 51);
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
            textBoxReportServer.Location = new System.Drawing.Point(154, 77);
            textBoxReportServer.Name = "textBoxReportServer";
            textBoxReportServer.Size = new System.Drawing.Size(226, 23);
            textBoxReportServer.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(10, 80);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 15);
            label2.TabIndex = 2;
            label2.Text = "Report Server:";
            // 
            // buttonDBSettingsLaden
            // 
            buttonDBSettingsLaden.Location = new System.Drawing.Point(386, 47);
            buttonDBSettingsLaden.Name = "buttonDBSettingsLaden";
            buttonDBSettingsLaden.Size = new System.Drawing.Size(154, 23);
            buttonDBSettingsLaden.TabIndex = 4;
            buttonDBSettingsLaden.Text = "DB Settings Laden";
            buttonDBSettingsLaden.UseVisualStyleBackColor = true;
            buttonDBSettingsLaden.Click += buttonDBSettingsLaden_Click;
            // 
            // buttonDBSettingsSpeichern
            // 
            buttonDBSettingsSpeichern.Location = new System.Drawing.Point(386, 79);
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
            // textBoxReportsSpeichern
            // 
            textBoxReportsSpeichern.Enabled = false;
            textBoxReportsSpeichern.Location = new System.Drawing.Point(154, 168);
            textBoxReportsSpeichern.Name = "textBoxReportsSpeichern";
            textBoxReportsSpeichern.Size = new System.Drawing.Size(226, 23);
            textBoxReportsSpeichern.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(10, 171);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(135, 15);
            label3.TabIndex = 7;
            label3.Text = "Reports speichern unter:";
            // 
            // textBoxReportServerDBName
            // 
            textBoxReportServerDBName.Location = new System.Drawing.Point(154, 106);
            textBoxReportServerDBName.Name = "textBoxReportServerDBName";
            textBoxReportServerDBName.Size = new System.Drawing.Size(226, 23);
            textBoxReportServerDBName.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(10, 109);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(133, 15);
            label4.TabIndex = 9;
            label4.Text = "Report Server DB Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(386, 109);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(110, 15);
            label5.TabIndex = 11;
            label5.Text = "z.B.: ReportServer24";
            // 
            // textBoxReportPfad
            // 
            textBoxReportPfad.Enabled = false;
            textBoxReportPfad.Location = new System.Drawing.Point(154, 135);
            textBoxReportPfad.Name = "textBoxReportPfad";
            textBoxReportPfad.Size = new System.Drawing.Size(226, 23);
            textBoxReportPfad.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(10, 138);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(72, 15);
            label6.TabIndex = 12;
            label6.Text = "Report Pfad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(386, 138);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(111, 15);
            label7.TabIndex = 14;
            label7.Text = "z.B.: WnetReports24";
            // 
            // checkBoxReportsIgnore_Suffix
            // 
            checkBoxReportsIgnore_Suffix.AutoSize = true;
            checkBoxReportsIgnore_Suffix.Location = new System.Drawing.Point(521, 134);
            checkBoxReportsIgnore_Suffix.Name = "checkBoxReportsIgnore_Suffix";
            checkBoxReportsIgnore_Suffix.Size = new System.Drawing.Size(150, 19);
            checkBoxReportsIgnore_Suffix.TabIndex = 15;
            checkBoxReportsIgnore_Suffix.Text = "\"_\" Bei Suffix ignorieren";
            checkBoxReportsIgnore_Suffix.UseVisualStyleBackColor = true;
            // 
            // FormServerZugaenge
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(774, 203);
            Controls.Add(checkBoxReportsIgnore_Suffix);
            Controls.Add(label7);
            Controls.Add(textBoxReportPfad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxReportServerDBName);
            Controls.Add(label4);
            Controls.Add(textBoxReportsSpeichern);
            Controls.Add(label3);
            Controls.Add(checkBoxServerCert);
            Controls.Add(buttonDBSettingsSpeichern);
            Controls.Add(buttonDBSettingsLaden);
            Controls.Add(textBoxReportServer);
            Controls.Add(label2);
            Controls.Add(textBoxDBServer);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FormServerZugaenge";
            Text = "FormServerZugaenge";
            Load += FormServerZugaenge_Load;
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
        private System.Windows.Forms.TextBox textBoxReportsSpeichern;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxReportServerDBName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxReportPfad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxReportsIgnore_Suffix;
    }
}