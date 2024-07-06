namespace WnetLeisure
{
    partial class FormIS600EKonfiMngr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIS600EKonfiMngr));
            this.btnLoadIPList = new System.Windows.Forms.Button();
            this.lblIPList = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtbxPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxHeader = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxEntries = new System.Windows.Forms.RichTextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadIPList
            // 
            this.btnLoadIPList.AutoSize = true;
            this.btnLoadIPList.Location = new System.Drawing.Point(12, 20);
            this.btnLoadIPList.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadIPList.Name = "btnLoadIPList";
            this.btnLoadIPList.Size = new System.Drawing.Size(102, 32);
            this.btnLoadIPList.TabIndex = 0;
            this.btnLoadIPList.Text = "IP-Liste laden";
            this.btnLoadIPList.UseVisualStyleBackColor = true;
            this.btnLoadIPList.Click += new System.EventHandler(this.btnLoadIPList_Click);
            // 
            // lblIPList
            // 
            this.lblIPList.AutoSize = true;
            this.lblIPList.Location = new System.Drawing.Point(126, 32);
            this.lblIPList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIPList.Name = "lblIPList";
            this.lblIPList.Size = new System.Drawing.Size(99, 13);
            this.lblIPList.TabIndex = 1;
            this.lblIPList.Text = "Keine Liste gewählt";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(2, 0);
            this.lblPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(144, 13);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "Pfad und Dateiname wählen:";
            // 
            // txtbxPath
            // 
            this.txtbxPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxPath.Location = new System.Drawing.Point(215, 2);
            this.txtbxPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxPath.Name = "txtbxPath";
            this.txtbxPath.Size = new System.Drawing.Size(209, 20);
            this.txtbxPath.TabIndex = 3;
            this.txtbxPath.Text = "/SETTINGS/SETTING.INI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(428, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Beispiel: /SETTINGS/SETTING.INI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Header zum Ändern oder Erstellen wählen:";
            // 
            // txtbxHeader
            // 
            this.txtbxHeader.Location = new System.Drawing.Point(215, 57);
            this.txtbxHeader.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxHeader.Name = "txtbxHeader";
            this.txtbxHeader.Size = new System.Drawing.Size(97, 20);
            this.txtbxHeader.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPath, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtbxHeader, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtbxPath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtbxEntries, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 72);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.125F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.875F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(588, 188);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 52);
            this.label5.TabIndex = 10;
            this.label5.Text = "Beispiel: \r\nautoswitchoff=1\r\nautoOffHour=20\r\nautoOnHour=1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Welche Einträge sollen erstellt oder geändert werden?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Beispiel: [AutoOff]";
            // 
            // txtbxEntries
            // 
            this.txtbxEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxEntries.Location = new System.Drawing.Point(215, 105);
            this.txtbxEntries.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxEntries.Name = "txtbxEntries";
            this.txtbxEntries.Size = new System.Drawing.Size(209, 81);
            this.txtbxEntries.TabIndex = 8;
            this.txtbxEntries.Text = "";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(12, 280);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(108, 19);
            this.btnTransfer.TabIndex = 8;
            this.btnTransfer.Text = "Übertragung starten";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // FormIS600EKonfiMngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblIPList);
            this.Controls.Add(this.btnLoadIPList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormIS600EKonfiMngr";
            this.Text = "IS600E / Exclusive Konfigurations Manager";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadIPList;
        private System.Windows.Forms.Label lblIPList;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtbxPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtbxEntries;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTransfer;
    }
}