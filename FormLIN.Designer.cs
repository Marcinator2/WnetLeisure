namespace WnetLeisure
{
    partial class FormLIN
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtBxServer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLINladen;
        private System.Windows.Forms.ProgressBar prgrsBrFortschritt;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLIN));
            this.txtBxServer = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLINladen = new System.Windows.Forms.Button();
            this.prgrsBrFortschritt = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBxServer
            // 
            this.txtBxServer.Location = new System.Drawing.Point(92, 15);
            this.txtBxServer.Name = "txtBxServer";
            this.txtBxServer.Size = new System.Drawing.Size(260, 20);
            this.txtBxServer.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(358, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLINladen
            // 
            this.btnLINladen.Location = new System.Drawing.Point(144, 41);
            this.btnLINladen.Name = "btnLINladen";
            this.btnLINladen.Size = new System.Drawing.Size(145, 23);
            this.btnLINladen.TabIndex = 2;
            this.btnLINladen.Text = "LINs hochladen";
            this.btnLINladen.UseVisualStyleBackColor = true;
            this.btnLINladen.Click += new System.EventHandler(this.btnLINladen_Click);
            // 
            // prgrsBrFortschritt
            // 
            this.prgrsBrFortschritt.Location = new System.Drawing.Point(24, 70);
            this.prgrsBrFortschritt.Name = "prgrsBrFortschritt";
            this.prgrsBrFortschritt.Size = new System.Drawing.Size(409, 23);
            this.prgrsBrFortschritt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SQL Server:";
            // 
            // FormLIN
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(474, 118);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prgrsBrFortschritt);
            this.Controls.Add(this.btnLINladen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBxServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLIN";
            this.Text = "LINs hochladen";
            this.Load += new System.EventHandler(this.FormLIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
    }
}
