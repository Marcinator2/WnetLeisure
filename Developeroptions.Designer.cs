namespace WnetLeisure
{
    partial class Developeroptions
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxFTPaddIS600E = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveFTPaddIS600E = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveDevPW = new System.Windows.Forms.Button();
            this.txtbxDevPW = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pfadanpassung nach ftp://IP";
            // 
            // txtbxFTPaddIS600E
            // 
            this.txtbxFTPaddIS600E.Location = new System.Drawing.Point(200, 56);
            this.txtbxFTPaddIS600E.Name = "txtbxFTPaddIS600E";
            this.txtbxFTPaddIS600E.Size = new System.Drawing.Size(152, 22);
            this.txtbxFTPaddIS600E.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "IS600E / Exclusive";
            // 
            // btnSaveFTPaddIS600E
            // 
            this.btnSaveFTPaddIS600E.Location = new System.Drawing.Point(360, 56);
            this.btnSaveFTPaddIS600E.Name = "btnSaveFTPaddIS600E";
            this.btnSaveFTPaddIS600E.Size = new System.Drawing.Size(96, 23);
            this.btnSaveFTPaddIS600E.TabIndex = 3;
            this.btnSaveFTPaddIS600E.Text = "Speichern";
            this.btnSaveFTPaddIS600E.UseVisualStyleBackColor = true;
            this.btnSaveFTPaddIS600E.Click += new System.EventHandler(this.btnSaveFTPaddIS600E_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Controls.Add(this.txtbxDevPW);
            this.groupBox1.Controls.Add(this.btnSaveDevPW);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(608, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 128);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entwicklerpasswort ändern:";
            // 
            // btnSaveDevPW
            // 
            this.btnSaveDevPW.Location = new System.Drawing.Point(80, 80);
            this.btnSaveDevPW.Name = "btnSaveDevPW";
            this.btnSaveDevPW.Size = new System.Drawing.Size(96, 24);
            this.btnSaveDevPW.TabIndex = 6;
            this.btnSaveDevPW.Text = "Speichern";
            this.btnSaveDevPW.UseVisualStyleBackColor = true;
            this.btnSaveDevPW.Click += new System.EventHandler(this.btnSaveDevPW_Click);
            // 
            // txtbxDevPW
            // 
            this.txtbxDevPW.Location = new System.Drawing.Point(64, 48);
            this.txtbxDevPW.Name = "txtbxDevPW";
            this.txtbxDevPW.Size = new System.Drawing.Size(128, 22);
            this.txtbxDevPW.TabIndex = 7;
            this.txtbxDevPW.UseSystemPasswordChar = true;
            // 
            // Developeroptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveFTPaddIS600E);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbxFTPaddIS600E);
            this.Controls.Add(this.label1);
            this.Name = "Developeroptions";
            this.Text = "Entwickleroptionen";
            this.Load += new System.EventHandler(this.Developeroptions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxFTPaddIS600E;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveFTPaddIS600E;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveDevPW;
        private System.Windows.Forms.TextBox txtbxDevPW;
    }
}