namespace WnetLeisure
{
    partial class FormAuthentication
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
            this.rbWindowsAuth = new System.Windows.Forms.RadioButton();
            this.rbSqlServerAuth = new System.Windows.Forms.RadioButton();
            this.txtBxUsername = new System.Windows.Forms.TextBox();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbWindowsAuth
            // 
            this.rbWindowsAuth.AutoSize = true;
            this.rbWindowsAuth.Location = new System.Drawing.Point(92, 60);
            this.rbWindowsAuth.Name = "rbWindowsAuth";
            this.rbWindowsAuth.Size = new System.Drawing.Size(125, 17);
            this.rbWindowsAuth.TabIndex = 0;
            this.rbWindowsAuth.TabStop = true;
            this.rbWindowsAuth.Text = "Windows Anmeldung";
            this.rbWindowsAuth.UseVisualStyleBackColor = true;
            // 
            // rbSqlServerAuth
            // 
            this.rbSqlServerAuth.AutoSize = true;
            this.rbSqlServerAuth.Location = new System.Drawing.Point(92, 95);
            this.rbSqlServerAuth.Name = "rbSqlServerAuth";
            this.rbSqlServerAuth.Size = new System.Drawing.Size(135, 17);
            this.rbSqlServerAuth.TabIndex = 1;
            this.rbSqlServerAuth.TabStop = true;
            this.rbSqlServerAuth.Text = "SQL Server anmeldung";
            this.rbSqlServerAuth.UseVisualStyleBackColor = true;
            // 
            // txtBxUsername
            // 
            this.txtBxUsername.Location = new System.Drawing.Point(152, 167);
            this.txtBxUsername.Name = "txtBxUsername";
            this.txtBxUsername.Size = new System.Drawing.Size(245, 20);
            this.txtBxUsername.TabIndex = 2;
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Location = new System.Drawing.Point(150, 202);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(246, 20);
            this.txtBxPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nutzername";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Passwort";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(78, 240);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(237, 31);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Verbinden";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // FormAuthentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.txtBxUsername);
            this.Controls.Add(this.rbSqlServerAuth);
            this.Controls.Add(this.rbWindowsAuth);
            this.Name = "FormAuthentication";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbWindowsAuth;
        private System.Windows.Forms.RadioButton rbSqlServerAuth;
        private System.Windows.Forms.TextBox txtBxUsername;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
    }
}