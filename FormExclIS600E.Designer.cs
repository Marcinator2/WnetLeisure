namespace WnetLeisure
{
    partial class FormExclIS600E
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExclIS600E));
            btnOK = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtbxUser = new System.Windows.Forms.TextBox();
            txtbxPW = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new System.Drawing.Point(70, 98);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(98, 30);
            btnOK.TabIndex = 0;
            btnOK.Text = "Speichern";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(175, 98);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(91, 30);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Abbrechen";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(63, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 15);
            label1.TabIndex = 2;
            label1.Text = "Nutzername:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(84, 52);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Passwort:";
            // 
            // txtbxUser
            // 
            txtbxUser.Location = new System.Drawing.Point(147, 22);
            txtbxUser.Name = "txtbxUser";
            txtbxUser.Size = new System.Drawing.Size(120, 23);
            txtbxUser.TabIndex = 4;
            // 
            // txtbxPW
            // 
            txtbxPW.Location = new System.Drawing.Point(147, 52);
            txtbxPW.Name = "txtbxPW";
            txtbxPW.Size = new System.Drawing.Size(120, 23);
            txtbxPW.TabIndex = 5;
            txtbxPW.UseSystemPasswordChar = true;
            // 
            // FormExclIS600E
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(346, 155);
            Controls.Add(txtbxPW);
            Controls.Add(txtbxUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FormExclIS600E";
            Text = "Exclusive / IS600E Zugang";
            Load += FormExclIS600E_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxUser;
        private System.Windows.Forms.TextBox txtbxPW;
    }
}