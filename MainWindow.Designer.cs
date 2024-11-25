namespace WnetLeisure
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            btnStartIS600EKonfiMngr = new System.Windows.Forms.Button();
            btnPort = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            zugängeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exclusiveIS600EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            wtouchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            serverZugängeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            entwickleroptionenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            anleitungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            überWNETLeisuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btnLIN = new System.Windows.Forms.Button();
            btnReportCreator = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnStartIS600EKonfiMngr
            // 
            btnStartIS600EKonfiMngr.Location = new System.Drawing.Point(168, 45);
            btnStartIS600EKonfiMngr.Margin = new System.Windows.Forms.Padding(2);
            btnStartIS600EKonfiMngr.Name = "btnStartIS600EKonfiMngr";
            btnStartIS600EKonfiMngr.Size = new System.Drawing.Size(147, 67);
            btnStartIS600EKonfiMngr.TabIndex = 0;
            btnStartIS600EKonfiMngr.Text = "IS600E / Exclusive Konfigurations Manager";
            btnStartIS600EKonfiMngr.UseVisualStyleBackColor = true;
            btnStartIS600EKonfiMngr.Click += btnStartIS600EKonfiMngr_Click;
            // 
            // btnPort
            // 
            btnPort.Location = new System.Drawing.Point(14, 45);
            btnPort.Margin = new System.Windows.Forms.Padding(2);
            btnPort.Name = "btnPort";
            btnPort.Size = new System.Drawing.Size(147, 67);
            btnPort.TabIndex = 1;
            btnPort.Text = "Port Checker";
            btnPort.UseVisualStyleBackColor = true;
            btnPort.Click += btnPing_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { einstellungenToolStripMenuItem, entwickleroptionenToolStripMenuItem, hilfeToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(687, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // einstellungenToolStripMenuItem
            // 
            einstellungenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { zugängeToolStripMenuItem, serverZugängeToolStripMenuItem });
            einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            einstellungenToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // zugängeToolStripMenuItem
            // 
            zugängeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { exclusiveIS600EToolStripMenuItem, wtouchToolStripMenuItem });
            zugängeToolStripMenuItem.Name = "zugängeToolStripMenuItem";
            zugängeToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            zugängeToolStripMenuItem.Text = "Steuerungs Zugänge";
            zugängeToolStripMenuItem.Click += zugaengeToolStripMenuItem_Click;
            // 
            // exclusiveIS600EToolStripMenuItem
            // 
            exclusiveIS600EToolStripMenuItem.Name = "exclusiveIS600EToolStripMenuItem";
            exclusiveIS600EToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            exclusiveIS600EToolStripMenuItem.Text = "Exclusive/IS600E";
            exclusiveIS600EToolStripMenuItem.Click += exclusiveIS600EToolStripMenuItem_Click;
            // 
            // wtouchToolStripMenuItem
            // 
            wtouchToolStripMenuItem.Name = "wtouchToolStripMenuItem";
            wtouchToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            wtouchToolStripMenuItem.Text = "Wtouch";
            wtouchToolStripMenuItem.Click += wtouchToolStripMenuItem_Click;
            // 
            // serverZugängeToolStripMenuItem
            // 
            serverZugängeToolStripMenuItem.Name = "serverZugängeToolStripMenuItem";
            serverZugängeToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            serverZugängeToolStripMenuItem.Text = "Server Zugänge";
            serverZugängeToolStripMenuItem.Click += serverZugaengeToolStripMenuItem_Click;
            // 
            // entwickleroptionenToolStripMenuItem
            // 
            entwickleroptionenToolStripMenuItem.Name = "entwickleroptionenToolStripMenuItem";
            entwickleroptionenToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            entwickleroptionenToolStripMenuItem.Text = "Entwickleroptionen";
            entwickleroptionenToolStripMenuItem.Click += entwickleroptionenToolStripMenuItem_Click;
            // 
            // hilfeToolStripMenuItem
            // 
            hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { anleitungToolStripMenuItem, überWNETLeisuToolStripMenuItem });
            hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // anleitungToolStripMenuItem
            // 
            anleitungToolStripMenuItem.Name = "anleitungToolStripMenuItem";
            anleitungToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            anleitungToolStripMenuItem.Text = "Anleitung";
            // 
            // überWNETLeisuToolStripMenuItem
            // 
            überWNETLeisuToolStripMenuItem.Name = "überWNETLeisuToolStripMenuItem";
            überWNETLeisuToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            überWNETLeisuToolStripMenuItem.Text = "Über W-NET Leisure";
            überWNETLeisuToolStripMenuItem.Click += überWNETLeisuToolStripMenuItem_Click;
            // 
            // btnLIN
            // 
            btnLIN.Location = new System.Drawing.Point(321, 45);
            btnLIN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLIN.Name = "btnLIN";
            btnLIN.Size = new System.Drawing.Size(144, 67);
            btnLIN.TabIndex = 3;
            btnLIN.Text = "LINs hochladen";
            btnLIN.UseVisualStyleBackColor = true;
            btnLIN.Click += btnLIN_Click;
            // 
            // btnReportCreator
            // 
            btnReportCreator.Location = new System.Drawing.Point(473, 45);
            btnReportCreator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnReportCreator.Name = "btnReportCreator";
            btnReportCreator.Size = new System.Drawing.Size(144, 67);
            btnReportCreator.TabIndex = 4;
            btnReportCreator.Text = "Wnet Report Creator";
            btnReportCreator.UseVisualStyleBackColor = true;
            btnReportCreator.Click += btnReportCreator_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(14, 117);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(147, 67);
            button1.TabIndex = 5;
            button1.Text = "Wtouch Konfi Manager";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            BackgroundImage = Properties.Resources.W_NETLeisureohneBG;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            CausesValidation = false;
            ClientSize = new System.Drawing.Size(687, 378);
            Controls.Add(button1);
            Controls.Add(btnReportCreator);
            Controls.Add(btnLIN);
            Controls.Add(btnPort);
            Controls.Add(btnStartIS600EKonfiMngr);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(2);
            Name = "MainWindow";
            Text = "W-NET Leisure";
            Load += MainWindow_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnStartIS600EKonfiMngr;
        private System.Windows.Forms.Button btnPort;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zugängeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exclusiveIS600EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wtouchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entwickleroptionenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anleitungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überWNETLeisuToolStripMenuItem;
        private System.Windows.Forms.Button btnLIN;
        private System.Windows.Forms.Button btnReportCreator;
        private System.Windows.Forms.ToolStripMenuItem serverZugängeToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

