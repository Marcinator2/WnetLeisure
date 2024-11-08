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
            textBox1 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
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
            textBoxReportServer.Location = new System.Drawing.Point(154, 83);
            textBoxReportServer.Name = "textBoxReportServer";
            textBoxReportServer.Size = new System.Drawing.Size(226, 23);
            textBoxReportServer.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(10, 86);
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
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(154, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(226, 23);
            textBox1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(10, 119);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(135, 15);
            label3.TabIndex = 7;
            label3.Text = "Reports speichern unter:";
            // 
            // FormServerZugaenge
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(583, 203);
            Controls.Add(textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}