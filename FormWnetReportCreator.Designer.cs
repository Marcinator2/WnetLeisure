using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;

namespace WnetLeisure
{
    partial class FormWnetReportCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWnetReportCreator));
            comboBoxDatenbanken = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBoxGruppe = new ComboBox();
            comboBoxReport = new ComboBox();
            label3 = new Label();
            buttonReportAusfuehren = new Button();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            label4 = new Label();
            textBoxDBName = new TextBox();
            checkBoxLetzterMonat = new CheckBox();
            checkBoxLetzteWoche = new CheckBox();
            pictureBoxLaden = new PictureBox();
            buttonBakingCleaningAll = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLaden).BeginInit();
            SuspendLayout();
            // 
            // comboBoxDatenbanken
            // 
            comboBoxDatenbanken.FormattingEnabled = true;
            comboBoxDatenbanken.Location = new Point(144, 93);
            comboBoxDatenbanken.Name = "comboBoxDatenbanken";
            comboBoxDatenbanken.Size = new Size(580, 23);
            comboBoxDatenbanken.TabIndex = 0;
            comboBoxDatenbanken.SelectedIndexChanged += comboBoxDatenbanken_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 96);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 1;
            label1.Text = "Datenbank wählen:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 168);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 2;
            label2.Text = "Gruppe wählen:";
            // 
            // comboBoxGruppe
            // 
            comboBoxGruppe.FormattingEnabled = true;
            comboBoxGruppe.Location = new Point(144, 160);
            comboBoxGruppe.Name = "comboBoxGruppe";
            comboBoxGruppe.Size = new Size(580, 23);
            comboBoxGruppe.TabIndex = 3;
            comboBoxGruppe.SelectedIndexChanged += comboBoxGruppe_SelectedIndexChanged;
            // 
            // comboBoxReport
            // 
            comboBoxReport.FormattingEnabled = true;
            comboBoxReport.Location = new Point(144, 212);
            comboBoxReport.Name = "comboBoxReport";
            comboBoxReport.Size = new Size(580, 23);
            comboBoxReport.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 215);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 4;
            label3.Text = "Report wählen:";
            // 
            // buttonReportAusfuehren
            // 
            buttonReportAusfuehren.Location = new Point(242, 317);
            buttonReportAusfuehren.Name = "buttonReportAusfuehren";
            buttonReportAusfuehren.Size = new Size(120, 33);
            buttonReportAusfuehren.TabIndex = 6;
            buttonReportAusfuehren.Text = "Report ausführen";
            buttonReportAusfuehren.UseVisualStyleBackColor = true;
            buttonReportAusfuehren.Click += buttonReportAusfuehren_Click;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(289, 261);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 23);
            dateTimePickerStart.TabIndex = 7;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(524, 261);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 23);
            dateTimePickerEnd.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 123);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 9;
            label4.Text = "Datenbank Name:";
            // 
            // textBoxDBName
            // 
            textBoxDBName.Enabled = false;
            textBoxDBName.Location = new Point(144, 123);
            textBoxDBName.Name = "textBoxDBName";
            textBoxDBName.Size = new Size(140, 23);
            textBoxDBName.TabIndex = 10;
            // 
            // checkBoxLetzterMonat
            // 
            checkBoxLetzterMonat.AutoSize = true;
            checkBoxLetzterMonat.Location = new Point(33, 266);
            checkBoxLetzterMonat.Name = "checkBoxLetzterMonat";
            checkBoxLetzterMonat.Size = new Size(99, 19);
            checkBoxLetzterMonat.TabIndex = 12;
            checkBoxLetzterMonat.Text = "Letzter Monat";
            checkBoxLetzterMonat.UseVisualStyleBackColor = true;
            checkBoxLetzterMonat.CheckedChanged += checkBoxLetzterMonat_CheckedChanged;
            // 
            // checkBoxLetzteWoche
            // 
            checkBoxLetzteWoche.AutoSize = true;
            checkBoxLetzteWoche.Location = new Point(33, 291);
            checkBoxLetzteWoche.Name = "checkBoxLetzteWoche";
            checkBoxLetzteWoche.Size = new Size(97, 19);
            checkBoxLetzteWoche.TabIndex = 13;
            checkBoxLetzteWoche.Text = "Letzte Woche";
            checkBoxLetzteWoche.UseVisualStyleBackColor = true;
            checkBoxLetzteWoche.CheckedChanged += checkBoxLetzteWoche_CheckedChanged;
            // 
            // pictureBoxLaden
            // 
            pictureBoxLaden.Cursor = Cursors.Cross;
            pictureBoxLaden.Image = Properties.Resources.W;
            pictureBoxLaden.InitialImage = Properties.Resources.W;
            pictureBoxLaden.Location = new Point(404, 309);
            pictureBoxLaden.Name = "pictureBoxLaden";
            pictureBoxLaden.Size = new Size(42, 41);
            pictureBoxLaden.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLaden.TabIndex = 14;
            pictureBoxLaden.TabStop = false;
            // 
            // buttonBakingCleaningAll
            // 
            buttonBakingCleaningAll.Location = new Point(524, 294);
            buttonBakingCleaningAll.Name = "buttonBakingCleaningAll";
            buttonBakingCleaningAll.Size = new Size(200, 78);
            buttonBakingCleaningAll.TabIndex = 15;
            buttonBakingCleaningAll.Text = "Back- und Reinigungsreports von allen Datenbanken holen.\r\nAlle Öfen.";
            buttonBakingCleaningAll.UseVisualStyleBackColor = true;
            buttonBakingCleaningAll.Click += buttonBakingCleaningAll_Click;
            // 
            // FormWnetReportCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBakingCleaningAll);
            Controls.Add(pictureBoxLaden);
            Controls.Add(checkBoxLetzteWoche);
            Controls.Add(checkBoxLetzterMonat);
            Controls.Add(textBoxDBName);
            Controls.Add(label4);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(buttonReportAusfuehren);
            Controls.Add(comboBoxReport);
            Controls.Add(label3);
            Controls.Add(comboBoxGruppe);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxDatenbanken);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormWnetReportCreator";
            Text = "Wnet Report Creator";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLaden).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxDatenbanken;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxGruppe;
        private ComboBox comboBoxReport;
        private Label label3;
        private Button buttonReportAusfuehren;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Label label4;
        private TextBox textBoxDBName;
        private CheckBox checkBoxLetzterMonat;
        private CheckBox checkBoxLetzteWoche;
        private PictureBox pictureBoxLaden;
        private Button buttonBakingCleaningAll;
    }
}
