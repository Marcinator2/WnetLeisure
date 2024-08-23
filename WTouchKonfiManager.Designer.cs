using System.Windows.Forms;

namespace WnetLeisure
{ 
    partial class WTouchKonfiManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WTouchKonfiManager));
            this.btnLoad = new System.Windows.Forms.Button();
            this.comboBoxOvenNo = new System.Windows.Forms.ComboBox();
            this.txtBxIPConnect = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.lblMAC = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtBxNetworkmask = new System.Windows.Forms.TextBox();
            this.txtBxNameserver = new System.Windows.Forms.TextBox();
            this.txtBxUpdateServer = new System.Windows.Forms.TextBox();
            this.txtBxIP = new System.Windows.Forms.TextBox();
            this.txtBxpreheating_timeout_minutes = new System.Windows.Forms.TextBox();
            this.txtbxlights_off_cleaning = new System.Windows.Forms.TextBox();
            this.txtBxNetworRole = new System.Windows.Forms.TextBox();
            this.txtBxAvahiHostname = new System.Windows.Forms.TextBox();
            this.txtBxlights_off_standby = new System.Windows.Forms.TextBox();
            this.txtBXlights_off_baking = new System.Windows.Forms.TextBox();
            this.txtBxTimeServer = new System.Windows.Forms.TextBox();
            this.txtBxTimeZone = new System.Windows.Forms.TextBox();
            this.txtBxAutonegotiation = new System.Windows.Forms.TextBox();
            this.txtBxDHCP = new System.Windows.Forms.TextBox();
            this.txtBxDHCPHostname = new System.Windows.Forms.TextBox();
            this.txtBxGateway = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(146, 513);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(85, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // comboBoxOvenNo
            // 
            this.comboBoxOvenNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOvenNo.FormattingEnabled = true;
            this.comboBoxOvenNo.Location = new System.Drawing.Point(247, 17);
            this.comboBoxOvenNo.Name = "comboBoxOvenNo";
            this.comboBoxOvenNo.Size = new System.Drawing.Size(93, 21);
            this.comboBoxOvenNo.TabIndex = 1;
            this.comboBoxOvenNo.SelectedIndexChanged += new System.EventHandler(this.comboBoxOvenNo_SelectedIndexChanged);
            // 
            // txtBxIPConnect
            // 
            this.txtBxIPConnect.Location = new System.Drawing.Point(130, 18);
            this.txtBxIPConnect.Name = "txtBxIPConnect";
            this.txtBxIPConnect.Size = new System.Drawing.Size(111, 20);
            this.txtBxIPConnect.TabIndex = 2;
            this.txtBxIPConnect.TextChanged += new System.EventHandler(this.txtBxIPConnect_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Connect to Oven IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "General:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Network Settings:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Time-Server:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Network Role:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Update Server:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Hostname:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(346, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Lights Off Standby:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Network:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Oven Settings:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Timezone:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(428, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Oven Type:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 476);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Network-Mask:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 450);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Name-Server:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(33, 424);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "IP:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(346, 262);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(142, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Preheating Timeout Minutes:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(346, 236);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Lights Off Cleaning:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(346, 210);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "Lights Off Baking:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(325, 146);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(126, 20);
            this.label19.TabIndex = 21;
            this.label19.Text = "Energy Settings:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(428, 89);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(98, 13);
            this.label20.TabIndex = 22;
            this.label20.Text = "System Date/Time:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(428, 67);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 13);
            this.label21.TabIndex = 23;
            this.label21.Text = "MAC ID:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(428, 44);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 13);
            this.label22.TabIndex = 24;
            this.label22.Text = "Serial Number:";
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Location = new System.Drawing.Point(565, 44);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(76, 13);
            this.lblSerialNumber.TabIndex = 28;
            this.lblSerialNumber.Text = "Serial Number:";
            // 
            // lblMAC
            // 
            this.lblMAC.AutoSize = true;
            this.lblMAC.Location = new System.Drawing.Point(565, 67);
            this.lblMAC.Name = "lblMAC";
            this.lblMAC.Size = new System.Drawing.Size(47, 13);
            this.lblMAC.TabIndex = 27;
            this.lblMAC.Text = "MAC ID:";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(565, 89);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(98, 13);
            this.lblDateTime.TabIndex = 26;
            this.lblDateTime.Text = "System Date/Time:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(565, 21);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(63, 13);
            this.lblType.TabIndex = 25;
            this.lblType.Text = "Oven Type:";
            // 
            // txtBxNetworkmask
            // 
            this.txtBxNetworkmask.Location = new System.Drawing.Point(130, 473);
            this.txtBxNetworkmask.Name = "txtBxNetworkmask";
            this.txtBxNetworkmask.Size = new System.Drawing.Size(111, 20);
            this.txtBxNetworkmask.TabIndex = 29;
            // 
            // txtBxNameserver
            // 
            this.txtBxNameserver.Location = new System.Drawing.Point(130, 447);
            this.txtBxNameserver.Name = "txtBxNameserver";
            this.txtBxNameserver.Size = new System.Drawing.Size(111, 20);
            this.txtBxNameserver.TabIndex = 30;
            // 
            // txtBxUpdateServer
            // 
            this.txtBxUpdateServer.Location = new System.Drawing.Point(130, 204);
            this.txtBxUpdateServer.Name = "txtBxUpdateServer";
            this.txtBxUpdateServer.Size = new System.Drawing.Size(111, 20);
            this.txtBxUpdateServer.TabIndex = 31;
            // 
            // txtBxIP
            // 
            this.txtBxIP.Location = new System.Drawing.Point(130, 421);
            this.txtBxIP.Name = "txtBxIP";
            this.txtBxIP.Size = new System.Drawing.Size(111, 20);
            this.txtBxIP.TabIndex = 32;
            // 
            // txtBxpreheating_timeout_minutes
            // 
            this.txtBxpreheating_timeout_minutes.Location = new System.Drawing.Point(494, 259);
            this.txtBxpreheating_timeout_minutes.Name = "txtBxpreheating_timeout_minutes";
            this.txtBxpreheating_timeout_minutes.Size = new System.Drawing.Size(111, 20);
            this.txtBxpreheating_timeout_minutes.TabIndex = 33;
            // 
            // txtbxlights_off_cleaning
            // 
            this.txtbxlights_off_cleaning.Location = new System.Drawing.Point(494, 233);
            this.txtbxlights_off_cleaning.Name = "txtbxlights_off_cleaning";
            this.txtbxlights_off_cleaning.Size = new System.Drawing.Size(111, 20);
            this.txtbxlights_off_cleaning.TabIndex = 34;
            // 
            // txtBxNetworRole
            // 
            this.txtBxNetworRole.Location = new System.Drawing.Point(130, 230);
            this.txtBxNetworRole.Name = "txtBxNetworRole";
            this.txtBxNetworRole.Size = new System.Drawing.Size(111, 20);
            this.txtBxNetworRole.TabIndex = 35;
            // 
            // txtBxAvahiHostname
            // 
            this.txtBxAvahiHostname.Location = new System.Drawing.Point(130, 256);
            this.txtBxAvahiHostname.Name = "txtBxAvahiHostname";
            this.txtBxAvahiHostname.Size = new System.Drawing.Size(111, 20);
            this.txtBxAvahiHostname.TabIndex = 36;
            // 
            // txtBxlights_off_standby
            // 
            this.txtBxlights_off_standby.Location = new System.Drawing.Point(494, 181);
            this.txtBxlights_off_standby.Name = "txtBxlights_off_standby";
            this.txtBxlights_off_standby.Size = new System.Drawing.Size(111, 20);
            this.txtBxlights_off_standby.TabIndex = 37;
            // 
            // txtBXlights_off_baking
            // 
            this.txtBXlights_off_baking.Location = new System.Drawing.Point(494, 207);
            this.txtBXlights_off_baking.Name = "txtBXlights_off_baking";
            this.txtBXlights_off_baking.Size = new System.Drawing.Size(111, 20);
            this.txtBXlights_off_baking.TabIndex = 38;
            // 
            // txtBxTimeServer
            // 
            this.txtBxTimeServer.Location = new System.Drawing.Point(130, 111);
            this.txtBxTimeServer.Name = "txtBxTimeServer";
            this.txtBxTimeServer.Size = new System.Drawing.Size(111, 20);
            this.txtBxTimeServer.TabIndex = 39;
            // 
            // txtBxTimeZone
            // 
            this.txtBxTimeZone.Location = new System.Drawing.Point(130, 85);
            this.txtBxTimeZone.Name = "txtBxTimeZone";
            this.txtBxTimeZone.Size = new System.Drawing.Size(111, 20);
            this.txtBxTimeZone.TabIndex = 40;
            // 
            // txtBxAutonegotiation
            // 
            this.txtBxAutonegotiation.Location = new System.Drawing.Point(130, 342);
            this.txtBxAutonegotiation.Name = "txtBxAutonegotiation";
            this.txtBxAutonegotiation.Size = new System.Drawing.Size(111, 20);
            this.txtBxAutonegotiation.TabIndex = 48;
            // 
            // txtBxDHCP
            // 
            this.txtBxDHCP.Location = new System.Drawing.Point(130, 316);
            this.txtBxDHCP.Name = "txtBxDHCP";
            this.txtBxDHCP.Size = new System.Drawing.Size(111, 20);
            this.txtBxDHCP.TabIndex = 47;
            // 
            // txtBxDHCPHostname
            // 
            this.txtBxDHCPHostname.Location = new System.Drawing.Point(130, 368);
            this.txtBxDHCPHostname.Name = "txtBxDHCPHostname";
            this.txtBxDHCPHostname.Size = new System.Drawing.Size(111, 20);
            this.txtBxDHCPHostname.TabIndex = 46;
            // 
            // txtBxGateway
            // 
            this.txtBxGateway.Location = new System.Drawing.Point(130, 394);
            this.txtBxGateway.Name = "txtBxGateway";
            this.txtBxGateway.Size = new System.Drawing.Size(111, 20);
            this.txtBxGateway.TabIndex = 45;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(33, 345);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(84, 13);
            this.label27.TabIndex = 44;
            this.label27.Text = "Autonegotiation:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(33, 371);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(88, 13);
            this.label28.TabIndex = 43;
            this.label28.Text = "DHCP-Hostname";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(33, 397);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(52, 13);
            this.label29.TabIndex = 42;
            this.label29.Text = "Gateway:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(33, 319);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(40, 13);
            this.label30.TabIndex = 41;
            this.label30.Text = "DHCP:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(279, 513);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 23);
            this.btnSave.TabIndex = 49;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(390, 513);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(85, 23);
            this.btnRestart.TabIndex = 50;
            this.btnRestart.Text = "Restart WTouch";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(481, 516);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker1.TabIndex = 51;
            // 
            // WTouchKonfiManager
            // 
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBxAutonegotiation);
            this.Controls.Add(this.txtBxDHCP);
            this.Controls.Add(this.txtBxDHCPHostname);
            this.Controls.Add(this.txtBxGateway);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.txtBxTimeZone);
            this.Controls.Add(this.txtBxTimeServer);
            this.Controls.Add(this.txtBXlights_off_baking);
            this.Controls.Add(this.txtBxlights_off_standby);
            this.Controls.Add(this.txtBxAvahiHostname);
            this.Controls.Add(this.txtBxNetworRole);
            this.Controls.Add(this.txtbxlights_off_cleaning);
            this.Controls.Add(this.txtBxpreheating_timeout_minutes);
            this.Controls.Add(this.txtBxIP);
            this.Controls.Add(this.txtBxUpdateServer);
            this.Controls.Add(this.txtBxNameserver);
            this.Controls.Add(this.txtBxNetworkmask);
            this.Controls.Add(this.lblSerialNumber);
            this.Controls.Add(this.lblMAC);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxIPConnect);
            this.Controls.Add(this.comboBoxOvenNo);
            this.Controls.Add(this.btnLoad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WTouchKonfiManager";
            this.Text = "WTouch Konfigurations Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button btnLoad;
    private System.Windows.Forms.ComboBox comboBoxOvenNo;
    private System.Windows.Forms.TextBox txtBxIPConnect;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.Label label19;
    private System.Windows.Forms.Label label20;
    private System.Windows.Forms.Label label21;
    private System.Windows.Forms.Label label22;
    private System.Windows.Forms.Label lblSerialNumber;
    private System.Windows.Forms.Label lblMAC;
    private System.Windows.Forms.Label lblDateTime;
    private System.Windows.Forms.Label lblType;
    private System.Windows.Forms.TextBox txtBxNetworkmask;
    private System.Windows.Forms.TextBox txtBxNameserver;
    private System.Windows.Forms.TextBox txtBxUpdateServer;
    private System.Windows.Forms.TextBox txtBxIP;
    private System.Windows.Forms.TextBox txtBxpreheating_timeout_minutes;
    private System.Windows.Forms.TextBox txtbxlights_off_cleaning;
    private System.Windows.Forms.TextBox txtBxNetworRole;
    private System.Windows.Forms.TextBox txtBxAvahiHostname;
    private System.Windows.Forms.TextBox txtBxlights_off_standby;
    private System.Windows.Forms.TextBox txtBXlights_off_baking;
    private System.Windows.Forms.TextBox txtBxTimeServer;
    private System.Windows.Forms.TextBox txtBxTimeZone;
    private System.Windows.Forms.TextBox txtBxAutonegotiation;
    private System.Windows.Forms.TextBox txtBxDHCP;
    private System.Windows.Forms.TextBox txtBxDHCPHostname;
    private System.Windows.Forms.TextBox txtBxGateway;
    private System.Windows.Forms.Label label27;
    private System.Windows.Forms.Label label28;
    private System.Windows.Forms.Label label29;
    private System.Windows.Forms.Label label30;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnRestart;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
}
}
