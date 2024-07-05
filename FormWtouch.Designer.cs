namespace WnetLeisure
{
    partial class FormWtouch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWtouch));
            this.btnWTSave = new System.Windows.Forms.Button();
            this.btnWTCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxWTUser = new System.Windows.Forms.TextBox();
            this.txtbxWTPW = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnWTSave
            // 
            this.btnWTSave.Location = new System.Drawing.Point(16, 120);
            this.btnWTSave.Name = "btnWTSave";
            this.btnWTSave.Size = new System.Drawing.Size(120, 32);
            this.btnWTSave.TabIndex = 0;
            this.btnWTSave.Text = "Speichern";
            this.btnWTSave.UseVisualStyleBackColor = true;
            this.btnWTSave.Click += new System.EventHandler(this.btnWTSave_Click);
            // 
            // btnWTCancel
            // 
            this.btnWTCancel.Location = new System.Drawing.Point(152, 120);
            this.btnWTCancel.Name = "btnWTCancel";
            this.btnWTCancel.Size = new System.Drawing.Size(120, 32);
            this.btnWTCancel.TabIndex = 1;
            this.btnWTCancel.Text = "Abbrechen";
            this.btnWTCancel.UseVisualStyleBackColor = true;
            this.btnWTCancel.Click += new System.EventHandler(this.btnWTCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nutzername:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Passwort:";
            // 
            // txtbxWTUser
            // 
            this.txtbxWTUser.Location = new System.Drawing.Point(128, 40);
            this.txtbxWTUser.Name = "txtbxWTUser";
            this.txtbxWTUser.Size = new System.Drawing.Size(136, 22);
            this.txtbxWTUser.TabIndex = 4;
            // 
            // txtbxWTPW
            // 
            this.txtbxWTPW.Location = new System.Drawing.Point(128, 80);
            this.txtbxWTPW.Name = "txtbxWTPW";
            this.txtbxWTPW.Size = new System.Drawing.Size(136, 22);
            this.txtbxWTPW.TabIndex = 5;
            // 
            // FormWtouch
            // 
            this.ClientSize = new System.Drawing.Size(466, 198);
            this.Controls.Add(this.txtbxWTPW);
            this.Controls.Add(this.txtbxWTUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnWTCancel);
            this.Controls.Add(this.btnWTSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWtouch";
            this.Text = "Wtouch Zugang";
            this.Load += new System.EventHandler(this.FormWtouch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWTSave;
        private System.Windows.Forms.Button btnWTCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxWTUser;
        private System.Windows.Forms.TextBox txtbxWTPW;
    }
}