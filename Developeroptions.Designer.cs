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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Developeroptions));
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxFTPaddIS600E = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveFTPaddIS600E = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbxDevPW = new System.Windows.Forms.TextBox();
            this.btnSaveDevPW = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pfadanpassung nach ftp://IP";
            // 
            // txtbxFTPaddIS600E
            // 
            this.txtbxFTPaddIS600E.Location = new System.Drawing.Point(150, 46);
            this.txtbxFTPaddIS600E.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxFTPaddIS600E.Name = "txtbxFTPaddIS600E";
            this.txtbxFTPaddIS600E.Size = new System.Drawing.Size(115, 20);
            this.txtbxFTPaddIS600E.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "IS600E / Exclusive";
            // 
            // btnSaveFTPaddIS600E
            // 
            this.btnSaveFTPaddIS600E.Location = new System.Drawing.Point(270, 46);
            this.btnSaveFTPaddIS600E.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveFTPaddIS600E.Name = "btnSaveFTPaddIS600E";
            this.btnSaveFTPaddIS600E.Size = new System.Drawing.Size(72, 19);
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
            this.groupBox1.Location = new System.Drawing.Point(456, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(198, 104);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entwicklerpasswort ändern:";
            // 
            // txtbxDevPW
            // 
            this.txtbxDevPW.Location = new System.Drawing.Point(48, 39);
            this.txtbxDevPW.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxDevPW.Name = "txtbxDevPW";
            this.txtbxDevPW.Size = new System.Drawing.Size(97, 19);
            this.txtbxDevPW.TabIndex = 7;
            this.txtbxDevPW.UseSystemPasswordChar = true;
            // 
            // btnSaveDevPW
            // 
            this.btnSaveDevPW.Location = new System.Drawing.Point(60, 65);
            this.btnSaveDevPW.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveDevPW.Name = "btnSaveDevPW";
            this.btnSaveDevPW.Size = new System.Drawing.Size(72, 20);
            this.btnSaveDevPW.TabIndex = 6;
            this.btnSaveDevPW.Text = "Speichern";
            this.btnSaveDevPW.UseVisualStyleBackColor = true;
            this.btnSaveDevPW.Click += new System.EventHandler(this.btnSaveDevPW_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Beispiel: /IS600E";
            // 
            // Developeroptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 366);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveFTPaddIS600E);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbxFTPaddIS600E);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label label4;
    }
}