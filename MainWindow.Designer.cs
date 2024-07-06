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
            this.btnStartIS600EKonfiMngr = new System.Windows.Forms.Button();
            this.btnPort = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zugängeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exclusiveIS600EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wtouchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entwickleroptionenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anleitungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überWNETLeisuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartIS600EKonfiMngr
            // 
            this.btnStartIS600EKonfiMngr.Location = new System.Drawing.Point(192, 48);
            this.btnStartIS600EKonfiMngr.Name = "btnStartIS600EKonfiMngr";
            this.btnStartIS600EKonfiMngr.Size = new System.Drawing.Size(168, 72);
            this.btnStartIS600EKonfiMngr.TabIndex = 0;
            this.btnStartIS600EKonfiMngr.Text = "IS600E / Exclusive Konfigurations Manager";
            this.btnStartIS600EKonfiMngr.UseVisualStyleBackColor = true;
            this.btnStartIS600EKonfiMngr.Click += new System.EventHandler(this.btnStartIS600EKonfiMngr_Click);
            // 
            // btnPort
            // 
            this.btnPort.Location = new System.Drawing.Point(16, 48);
            this.btnPort.Name = "btnPort";
            this.btnPort.Size = new System.Drawing.Size(168, 72);
            this.btnPort.TabIndex = 1;
            this.btnPort.Text = "Port Checker";
            this.btnPort.UseVisualStyleBackColor = true;
            this.btnPort.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.einstellungenToolStripMenuItem,
            this.entwickleroptionenToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zugängeToolStripMenuItem});
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // zugängeToolStripMenuItem
            // 
            this.zugängeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exclusiveIS600EToolStripMenuItem,
            this.wtouchToolStripMenuItem});
            this.zugängeToolStripMenuItem.Name = "zugängeToolStripMenuItem";
            this.zugängeToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.zugängeToolStripMenuItem.Text = "Zugänge";
            // 
            // exclusiveIS600EToolStripMenuItem
            // 
            this.exclusiveIS600EToolStripMenuItem.Name = "exclusiveIS600EToolStripMenuItem";
            this.exclusiveIS600EToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.exclusiveIS600EToolStripMenuItem.Text = "Exclusive/IS600E";
            this.exclusiveIS600EToolStripMenuItem.Click += new System.EventHandler(this.exclusiveIS600EToolStripMenuItem_Click);
            // 
            // wtouchToolStripMenuItem
            // 
            this.wtouchToolStripMenuItem.Name = "wtouchToolStripMenuItem";
            this.wtouchToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.wtouchToolStripMenuItem.Text = "Wtouch";
            this.wtouchToolStripMenuItem.Click += new System.EventHandler(this.wtouchToolStripMenuItem_Click);
            // 
            // entwickleroptionenToolStripMenuItem
            // 
            this.entwickleroptionenToolStripMenuItem.Name = "entwickleroptionenToolStripMenuItem";
            this.entwickleroptionenToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.entwickleroptionenToolStripMenuItem.Text = "Entwickleroptionen";
            this.entwickleroptionenToolStripMenuItem.Click += new System.EventHandler(this.entwickleroptionenToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anleitungToolStripMenuItem,
            this.überWNETLeisuToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // anleitungToolStripMenuItem
            // 
            this.anleitungToolStripMenuItem.Name = "anleitungToolStripMenuItem";
            this.anleitungToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.anleitungToolStripMenuItem.Text = "Anleitung";
            // 
            // überWNETLeisuToolStripMenuItem
            // 
            this.überWNETLeisuToolStripMenuItem.Name = "überWNETLeisuToolStripMenuItem";
            this.überWNETLeisuToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.überWNETLeisuToolStripMenuItem.Text = "Über W-NET Leisure";
            this.überWNETLeisuToolStripMenuItem.Click += new System.EventHandler(this.überWNETLeisuToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WnetLeisure.Properties.Resources.W_NETLeisureohneBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(785, 404);
            this.Controls.Add(this.btnPort);
            this.Controls.Add(this.btnStartIS600EKonfiMngr);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "W-NET Leisure";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

