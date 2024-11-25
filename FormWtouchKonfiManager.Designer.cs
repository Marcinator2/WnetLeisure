using System.Windows.Forms;
using System.Drawing;



namespace WnetLeisure

    {
    partial class FormWtouchKonfiManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonVerbinden = new Button();
            textBoxIPWtouch = new TextBox();
            comboBoxHostname = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPageEinstellungen = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            label9 = new Label();
            textBoxHostnameWtouch = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label10 = new Label();
            textBoxUpdateServer = new TextBox();
            textBoxRolle = new TextBox();
            textBoxZeitzone = new TextBox();
            textBoxZeitServer = new TextBox();
            label13 = new Label();
            textBoxDateTime = new TextBox();
            label14 = new Label();
            tabPageAutostarts = new TabPage();
            textBoxSeriennummer = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxTyp = new TextBox();
            label5 = new Label();
            textBoxMAC = new TextBox();
            label6 = new Label();
            textBoxReinigung = new TextBox();
            label7 = new Label();
            textBoxTuer = new TextBox();
            label8 = new Label();
            textBoxBeschwadung = new TextBox();
            pictureBoxHintergrund = new PictureBox();
            label15 = new Label();
            tabPageBackprogramme = new TabPage();
            tabControl1.SuspendLayout();
            tabPageEinstellungen.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHintergrund).BeginInit();
            SuspendLayout();
            // 
            // buttonVerbinden
            // 
            buttonVerbinden.Location = new Point(377, 10);
            buttonVerbinden.Name = "buttonVerbinden";
            buttonVerbinden.Size = new Size(75, 23);
            buttonVerbinden.TabIndex = 0;
            buttonVerbinden.Text = "Verbinden";
            buttonVerbinden.UseVisualStyleBackColor = true;
            buttonVerbinden.Click += buttonVerbinden_Click;
            // 
            // textBoxIPWtouch
            // 
            textBoxIPWtouch.Location = new Point(73, 12);
            textBoxIPWtouch.Name = "textBoxIPWtouch";
            textBoxIPWtouch.Size = new Size(100, 23);
            textBoxIPWtouch.TabIndex = 1;
            // 
            // comboBoxHostname
            // 
            comboBoxHostname.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHostname.FormattingEnabled = true;
            comboBoxHostname.Location = new Point(250, 11);
            comboBoxHostname.Name = "comboBoxHostname";
            comboBoxHostname.Size = new Size(121, 23);
            comboBoxHostname.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 14);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 3;
            label1.Text = "IP Adresse:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 15);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 4;
            label2.Text = "Hostname:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageEinstellungen);
            tabControl1.Controls.Add(tabPageAutostarts);
            tabControl1.Controls.Add(tabPageBackprogramme);
            tabControl1.Location = new Point(12, 141);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(782, 297);
            tabControl1.TabIndex = 5;
            // 
            // tabPageEinstellungen
            // 
            tabPageEinstellungen.Controls.Add(tableLayoutPanel1);
            tabPageEinstellungen.Location = new Point(4, 24);
            tabPageEinstellungen.Name = "tabPageEinstellungen";
            tabPageEinstellungen.Padding = new Padding(3);
            tabPageEinstellungen.Size = new Size(774, 269);
            tabPageEinstellungen.TabIndex = 0;
            tabPageEinstellungen.Text = "Einstellungen";
            tabPageEinstellungen.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label9, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxHostnameWtouch, 1, 5);
            tableLayoutPanel1.Controls.Add(label11, 0, 5);
            tableLayoutPanel1.Controls.Add(label12, 0, 3);
            tableLayoutPanel1.Controls.Add(label10, 0, 4);
            tableLayoutPanel1.Controls.Add(textBoxUpdateServer, 1, 3);
            tableLayoutPanel1.Controls.Add(textBoxRolle, 1, 4);
            tableLayoutPanel1.Controls.Add(textBoxZeitzone, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxZeitServer, 1, 1);
            tableLayoutPanel1.Controls.Add(label13, 0, 2);
            tableLayoutPanel1.Controls.Add(textBoxDateTime, 1, 2);
            tableLayoutPanel1.Controls.Add(label14, 0, 1);
            tableLayoutPanel1.Location = new Point(20, 18);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(1);
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Size = new Size(718, 233);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(22, 12);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 9;
            label9.Text = "Zeitzone:";
            // 
            // textBoxHostnameWtouch
            // 
            textBoxHostnameWtouch.Anchor = AnchorStyles.None;
            textBoxHostnameWtouch.Location = new Point(102, 200);
            textBoxHostnameWtouch.Name = "textBoxHostnameWtouch";
            textBoxHostnameWtouch.ReadOnly = true;
            textBoxHostnameWtouch.Size = new Size(123, 23);
            textBoxHostnameWtouch.TabIndex = 12;
            textBoxHostnameWtouch.Tag = "";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Location = new Point(17, 204);
            label11.Name = "label11";
            label11.Size = new Size(65, 15);
            label11.TabIndex = 13;
            label11.Text = "Hostname:";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Location = new Point(8, 126);
            label12.Name = "label12";
            label12.Size = new Size(83, 15);
            label12.TabIndex = 15;
            label12.Text = "Update Server:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(32, 164);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 11;
            label10.Text = "Rolle:";
            // 
            // textBoxUpdateServer
            // 
            textBoxUpdateServer.Anchor = AnchorStyles.None;
            textBoxUpdateServer.Location = new Point(102, 122);
            textBoxUpdateServer.Name = "textBoxUpdateServer";
            textBoxUpdateServer.ReadOnly = true;
            textBoxUpdateServer.Size = new Size(123, 23);
            textBoxUpdateServer.TabIndex = 16;
            textBoxUpdateServer.Tag = "";
            // 
            // textBoxRolle
            // 
            textBoxRolle.Anchor = AnchorStyles.None;
            textBoxRolle.Location = new Point(102, 160);
            textBoxRolle.Name = "textBoxRolle";
            textBoxRolle.ReadOnly = true;
            textBoxRolle.Size = new Size(123, 23);
            textBoxRolle.TabIndex = 10;
            textBoxRolle.Tag = "";
            // 
            // textBoxZeitzone
            // 
            textBoxZeitzone.Anchor = AnchorStyles.None;
            textBoxZeitzone.Location = new Point(102, 8);
            textBoxZeitzone.Name = "textBoxZeitzone";
            textBoxZeitzone.ReadOnly = true;
            textBoxZeitzone.Size = new Size(123, 23);
            textBoxZeitzone.TabIndex = 8;
            textBoxZeitzone.Tag = "";
            // 
            // textBoxZeitServer
            // 
            textBoxZeitServer.Anchor = AnchorStyles.None;
            textBoxZeitServer.Location = new Point(102, 46);
            textBoxZeitServer.Name = "textBoxZeitServer";
            textBoxZeitServer.ReadOnly = true;
            textBoxZeitServer.Size = new Size(123, 23);
            textBoxZeitServer.TabIndex = 14;
            textBoxZeitServer.Tag = "";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Location = new Point(4, 88);
            label13.Name = "label13";
            label13.Size = new Size(92, 15);
            label13.TabIndex = 17;
            label13.Text = "Date/Time auto:";
            // 
            // textBoxDateTime
            // 
            textBoxDateTime.Anchor = AnchorStyles.None;
            textBoxDateTime.Location = new Point(102, 84);
            textBoxDateTime.Name = "textBoxDateTime";
            textBoxDateTime.ReadOnly = true;
            textBoxDateTime.Size = new Size(123, 23);
            textBoxDateTime.TabIndex = 18;
            textBoxDateTime.Tag = "";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Location = new Point(19, 50);
            label14.Name = "label14";
            label14.Size = new Size(61, 15);
            label14.TabIndex = 19;
            label14.Text = "Zeitserver:";
            // 
            // tabPageAutostarts
            // 
            tabPageAutostarts.Location = new Point(4, 24);
            tabPageAutostarts.Name = "tabPageAutostarts";
            tabPageAutostarts.Padding = new Padding(3);
            tabPageAutostarts.Size = new Size(774, 269);
            tabPageAutostarts.TabIndex = 1;
            tabPageAutostarts.Text = "Autostarts";
            tabPageAutostarts.UseVisualStyleBackColor = true;
            // 
            // textBoxSeriennummer
            // 
            textBoxSeriennummer.Location = new Point(100, 68);
            textBoxSeriennummer.Name = "textBoxSeriennummer";
            textBoxSeriennummer.ReadOnly = true;
            textBoxSeriennummer.Size = new Size(100, 23);
            textBoxSeriennummer.TabIndex = 6;
            textBoxSeriennummer.Tag = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 71);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 7;
            label3.Text = "Seriennummer:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 71);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 9;
            label4.Text = "Typ:";
            // 
            // textBoxTyp
            // 
            textBoxTyp.Location = new Point(301, 68);
            textBoxTyp.Name = "textBoxTyp";
            textBoxTyp.ReadOnly = true;
            textBoxTyp.Size = new Size(100, 23);
            textBoxTyp.TabIndex = 8;
            textBoxTyp.Tag = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(619, 18);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 11;
            label5.Text = "Hintergrund:";
            // 
            // textBoxMAC
            // 
            textBoxMAC.Location = new Point(498, 68);
            textBoxMAC.Name = "textBoxMAC";
            textBoxMAC.ReadOnly = true;
            textBoxMAC.Size = new Size(100, 23);
            textBoxMAC.TabIndex = 10;
            textBoxMAC.Tag = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(428, 103);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 13;
            label6.Text = "Reinigung:";
            // 
            // textBoxReinigung
            // 
            textBoxReinigung.Location = new Point(498, 100);
            textBoxReinigung.Name = "textBoxReinigung";
            textBoxReinigung.ReadOnly = true;
            textBoxReinigung.Size = new Size(100, 23);
            textBoxReinigung.TabIndex = 12;
            textBoxReinigung.Tag = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(67, 103);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 15;
            label7.Text = "Tür:";
            // 
            // textBoxTuer
            // 
            textBoxTuer.Location = new Point(100, 100);
            textBoxTuer.Name = "textBoxTuer";
            textBoxTuer.ReadOnly = true;
            textBoxTuer.Size = new Size(100, 23);
            textBoxTuer.TabIndex = 14;
            textBoxTuer.Tag = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(211, 103);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 17;
            label8.Text = "Beschwadung:";
            // 
            // textBoxBeschwadung
            // 
            textBoxBeschwadung.Location = new Point(301, 100);
            textBoxBeschwadung.Name = "textBoxBeschwadung";
            textBoxBeschwadung.ReadOnly = true;
            textBoxBeschwadung.Size = new Size(100, 23);
            textBoxBeschwadung.TabIndex = 16;
            textBoxBeschwadung.Tag = "";
            // 
            // pictureBoxHintergrund
            // 
            pictureBoxHintergrund.Location = new Point(633, 35);
            pictureBoxHintergrund.Name = "pictureBoxHintergrund";
            pictureBoxHintergrund.Size = new Size(61, 88);
            pictureBoxHintergrund.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxHintergrund.TabIndex = 18;
            pictureBoxHintergrund.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(455, 71);
            label15.Name = "label15";
            label15.Size = new Size(37, 15);
            label15.TabIndex = 19;
            label15.Text = "MAC:";
            // 
            // tabPageBackprogramme
            // 
            tabPageBackprogramme.Location = new Point(4, 24);
            tabPageBackprogramme.Name = "tabPageBackprogramme";
            tabPageBackprogramme.Size = new Size(774, 269);
            tabPageBackprogramme.TabIndex = 2;
            tabPageBackprogramme.Text = "Backprogramme";
            tabPageBackprogramme.UseVisualStyleBackColor = true;
            // 
            // FormWtouchKonfiManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label15);
            Controls.Add(pictureBoxHintergrund);
            Controls.Add(label8);
            Controls.Add(textBoxBeschwadung);
            Controls.Add(label7);
            Controls.Add(textBoxTuer);
            Controls.Add(label6);
            Controls.Add(textBoxReinigung);
            Controls.Add(label5);
            Controls.Add(textBoxMAC);
            Controls.Add(label4);
            Controls.Add(textBoxTyp);
            Controls.Add(label3);
            Controls.Add(textBoxSeriennummer);
            Controls.Add(tabControl1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxHostname);
            Controls.Add(textBoxIPWtouch);
            Controls.Add(buttonVerbinden);
            Name = "FormWtouchKonfiManager";
            Text = "Wtouch Konfigurations Manager";
            Load += FormWtouchKonfiManager_Load;
            tabControl1.ResumeLayout(false);
            tabPageEinstellungen.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHintergrund).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonVerbinden;
        private TextBox textBoxIPWtouch;
        private ComboBox comboBoxHostname;
        private Label label1;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPageEinstellungen;
        private TabPage tabPageAutostarts;
        private TextBox textBoxSeriennummer;
        private Label label3;
        private Label label4;
        private TextBox textBoxTyp;
        private Label label5;
        private TextBox textBoxMAC;
        private Label label6;
        private TextBox textBoxReinigung;
        private Label label7;
        private TextBox textBoxTuer;
        private Label label8;
        private TextBox textBoxBeschwadung;
        private Label label14;
        private TextBox textBoxDateTime;
        private Label label13;
        private TextBox textBoxUpdateServer;
        private Label label12;
        private TextBox textBoxZeitServer;
        private Label label11;
        private TextBox textBoxHostnameWtouch;
        private Label label10;
        private TextBox textBoxRolle;
        private Label label9;
        private TextBox textBoxZeitzone;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBoxHintergrund;
        private Label label15;
        private TabPage tabPageBackprogramme;
    }
}
