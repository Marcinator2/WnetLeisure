namespace WnetLeisure
{
    partial class PortChecker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortChecker));
            this.btnStart = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRead = new System.Windows.Forms.Label();
            this.lblWrite = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(48, 40);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(128, 32);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Starten";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(40, 104);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(153, 16);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Es gibt gerade nix zu tun.";
            // 
            // lblRead
            // 
            this.lblRead.AutoSize = true;
            this.lblRead.Location = new System.Drawing.Point(256, 40);
            this.lblRead.Name = "lblRead";
            this.lblRead.Size = new System.Drawing.Size(158, 16);
            this.lblRead.TabIndex = 2;
            this.lblRead.Text = "IP-Liste wird gelesen von:";
            // 
            // lblWrite
            // 
            this.lblWrite.AutoSize = true;
            this.lblWrite.Location = new System.Drawing.Point(256, 64);
            this.lblWrite.Name = "lblWrite";
            this.lblWrite.Size = new System.Drawing.Size(182, 16);
            this.lblWrite.TabIndex = 3;
            this.lblWrite.Text = "Ergebnis wird geschrieben in:";
            // 
            // PortChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(501, 138);
            this.Controls.Add(this.lblWrite);
            this.Controls.Add(this.lblRead);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PortChecker";
            this.Text = "Port Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRead;
        private System.Windows.Forms.Label lblWrite;
    }
}