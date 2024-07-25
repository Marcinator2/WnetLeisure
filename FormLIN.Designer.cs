namespace WnetLeisure
{
    partial class FormLIN
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
            this.txtBxServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLINladen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxServer
            // 
            this.txtBxServer.Location = new System.Drawing.Point(128, 47);
            this.txtBxServer.Name = "txtBxServer";
            this.txtBxServer.Size = new System.Drawing.Size(169, 20);
            this.txtBxServer.TabIndex = 0;
            this.txtBxServer.Text = "WIN-8TFJMHGHGFC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Adresse:";
            // 
            // btnLINladen
            // 
            this.btnLINladen.Location = new System.Drawing.Point(370, 46);
            this.btnLINladen.Name = "btnLINladen";
            this.btnLINladen.Size = new System.Drawing.Size(186, 20);
            this.btnLINladen.TabIndex = 2;
            this.btnLINladen.Text = "LIN Laden";
            this.btnLINladen.UseVisualStyleBackColor = true;
            this.btnLINladen.Click += new System.EventHandler(this.btnLINladen_Click);
            // 
            // FormLIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLINladen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxServer);
            this.Name = "FormLIN";
            this.Text = "FormLIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLINladen;
    }
}