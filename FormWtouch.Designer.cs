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
            btnWTSave = new System.Windows.Forms.Button();
            btnWTCancel = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtbxWTUser = new System.Windows.Forms.TextBox();
            txtbxWTPW = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnWTSave
            // 
            btnWTSave.Location = new System.Drawing.Point(16, 120);
            btnWTSave.Name = "btnWTSave";
            btnWTSave.Size = new System.Drawing.Size(120, 32);
            btnWTSave.TabIndex = 0;
            btnWTSave.Text = "Speichern";
            btnWTSave.UseVisualStyleBackColor = true;
            btnWTSave.Click += btnWTSave_Click;
            // 
            // btnWTCancel
            // 
            btnWTCancel.Location = new System.Drawing.Point(152, 120);
            btnWTCancel.Name = "btnWTCancel";
            btnWTCancel.Size = new System.Drawing.Size(120, 32);
            btnWTCancel.TabIndex = 1;
            btnWTCancel.Text = "Abbrechen";
            btnWTCancel.UseVisualStyleBackColor = true;
            btnWTCancel.Click += btnWTCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(32, 40);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(75, 15);
            label3.TabIndex = 2;
            label3.Text = "Nutzername:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(32, 80);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Passwort:";
            // 
            // txtbxWTUser
            // 
            txtbxWTUser.Location = new System.Drawing.Point(128, 40);
            txtbxWTUser.Name = "txtbxWTUser";
            txtbxWTUser.Size = new System.Drawing.Size(136, 23);
            txtbxWTUser.TabIndex = 4;
            // 
            // txtbxWTPW
            // 
            txtbxWTPW.Location = new System.Drawing.Point(128, 80);
            txtbxWTPW.Name = "txtbxWTPW";
            txtbxWTPW.Size = new System.Drawing.Size(136, 23);
            txtbxWTPW.TabIndex = 5;
            txtbxWTPW.UseSystemPasswordChar = true;
            // 
            // FormWtouch
            // 
            ClientSize = new System.Drawing.Size(331, 172);
            Controls.Add(txtbxWTPW);
            Controls.Add(txtbxWTUser);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnWTCancel);
            Controls.Add(btnWTSave);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FormWtouch";
            Text = "Wtouch Zugang";
            Load += FormWtouch_Load;
            ResumeLayout(false);
            PerformLayout();
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