namespace CmdInterface
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.tbAscii = new System.Windows.Forms.TextBox();
            this.lblAsciiString = new System.Windows.Forms.Label();
            this.tbHex = new System.Windows.Forms.TextBox();
            this.lblHex = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnLedOn = new System.Windows.Forms.Button();
            this.btnLedOff = new System.Windows.Forms.Button();
            this.groupBoxLED = new System.Windows.Forms.GroupBox();
            this.groupBoxTimed = new System.Windows.Forms.GroupBox();
            this.btn_rT = new System.Windows.Forms.Button();
            this.tB_rT = new System.Windows.Forms.TextBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnDisableTimed = new System.Windows.Forms.Button();
            this.lblSecond = new System.Windows.Forms.Label();
            this.textBoxTime1 = new System.Windows.Forms.TextBox();
            this.btnEnableTimed = new System.Windows.Forms.Button();
            this.groupBoxPeriodic = new System.Windows.Forms.GroupBox();
            this.btnDisabledPeriodic = new System.Windows.Forms.Button();
            this.lblPulsePerSecond = new System.Windows.Forms.Label();
            this.tbPeriodic = new System.Windows.Forms.TextBox();
            this.btnEnablePeriodic = new System.Windows.Forms.Button();
            this.groupBoxDigital = new System.Windows.Forms.GroupBox();
            this.btnReadInput = new System.Windows.Forms.Button();
            this.tbInputStatus = new System.Windows.Forms.TextBox();
            this.groupBoxAnalog = new System.Windows.Forms.GroupBox();
            this.lblUnit3 = new System.Windows.Forms.Label();
            this.lblUnit2 = new System.Windows.Forms.Label();
            this.lblUnit1 = new System.Windows.Forms.Label();
            this.tbStatusAN3 = new System.Windows.Forms.TextBox();
            this.tbStatusAN2 = new System.Windows.Forms.TextBox();
            this.tbStatusAN1 = new System.Windows.Forms.TextBox();
            this.btnCh3 = new System.Windows.Forms.Button();
            this.btnCh2 = new System.Windows.Forms.Button();
            this.btnCh1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_ack = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBoxLED.SuspendLayout();
            this.groupBoxTimed.SuspendLayout();
            this.groupBoxPeriodic.SuspendLayout();
            this.groupBoxDigital.SuspendLayout();
            this.groupBoxAnalog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAscii
            // 
            this.tbAscii.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbAscii.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAscii.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAscii.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbAscii.Location = new System.Drawing.Point(66, 388);
            this.tbAscii.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAscii.Name = "tbAscii";
            this.tbAscii.Size = new System.Drawing.Size(282, 29);
            this.tbAscii.TabIndex = 0;
            this.tbAscii.TextChanged += new System.EventHandler(this.tbAscii_TextChanged);
            // 
            // lblAsciiString
            // 
            this.lblAsciiString.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAsciiString.AutoSize = true;
            this.lblAsciiString.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsciiString.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAsciiString.Location = new System.Drawing.Point(7, 396);
            this.lblAsciiString.Name = "lblAsciiString";
            this.lblAsciiString.Size = new System.Drawing.Size(47, 21);
            this.lblAsciiString.TabIndex = 1;
            this.lblAsciiString.Text = "ASCII";
            // 
            // tbHex
            // 
            this.tbHex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHex.BackColor = System.Drawing.SystemColors.Info;
            this.tbHex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHex.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbHex.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHex.Location = new System.Drawing.Point(66, 430);
            this.tbHex.Name = "tbHex";
            this.tbHex.ReadOnly = true;
            this.tbHex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbHex.Size = new System.Drawing.Size(531, 22);
            this.tbHex.TabIndex = 2;
            this.tbHex.TabStop = false;
            // 
            // lblHex
            // 
            this.lblHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHex.AutoSize = true;
            this.lblHex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHex.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHex.Location = new System.Drawing.Point(13, 431);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(36, 21);
            this.lblHex.TabIndex = 3;
            this.lblHex.Text = "Hex";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSend.Location = new System.Drawing.Point(477, 381);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(119, 40);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comPortToolStripMenuItem,
            this.clearTextToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comPortToolStripMenuItem
            // 
            this.comPortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.comPortToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.comPortToolStripMenuItem.Name = "comPortToolStripMenuItem";
            this.comPortToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.comPortToolStripMenuItem.Text = "&Com Port";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.connectToolStripMenuItem.Text = "&Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.disconnectToolStripMenuItem.Text = "&Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // clearTextToolStripMenuItem
            // 
            this.clearTextToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.clearTextToolStripMenuItem.Name = "clearTextToolStripMenuItem";
            this.clearTextToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.clearTextToolStripMenuItem.Text = "Clear Te&xt";
            this.clearTextToolStripMenuItem.Click += new System.EventHandler(this.clearTextToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(40, 21);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btnLedOn
            // 
            this.btnLedOn.Location = new System.Drawing.Point(11, 24);
            this.btnLedOn.Name = "btnLedOn";
            this.btnLedOn.Size = new System.Drawing.Size(81, 34);
            this.btnLedOn.TabIndex = 6;
            this.btnLedOn.Text = "LED on";
            this.btnLedOn.UseVisualStyleBackColor = true;
            this.btnLedOn.Click += new System.EventHandler(this.btnLedOn_Click);
            // 
            // btnLedOff
            // 
            this.btnLedOff.Location = new System.Drawing.Point(11, 64);
            this.btnLedOff.Name = "btnLedOff";
            this.btnLedOff.Size = new System.Drawing.Size(81, 34);
            this.btnLedOff.TabIndex = 7;
            this.btnLedOff.Text = "LED off";
            this.btnLedOff.UseVisualStyleBackColor = true;
            this.btnLedOff.Click += new System.EventHandler(this.btnLedOff_Click);
            // 
            // groupBoxLED
            // 
            this.groupBoxLED.Controls.Add(this.btnLedOn);
            this.groupBoxLED.Controls.Add(this.btnLedOff);
            this.groupBoxLED.Location = new System.Drawing.Point(6, 28);
            this.groupBoxLED.Name = "groupBoxLED";
            this.groupBoxLED.Size = new System.Drawing.Size(115, 163);
            this.groupBoxLED.TabIndex = 8;
            this.groupBoxLED.TabStop = false;
            this.groupBoxLED.Text = "LED";
            // 
            // groupBoxTimed
            // 
            this.groupBoxTimed.Controls.Add(this.btn_rT);
            this.groupBoxTimed.Controls.Add(this.tB_rT);
            this.groupBoxTimed.Controls.Add(this.tbStatus);
            this.groupBoxTimed.Controls.Add(this.btnStatus);
            this.groupBoxTimed.Controls.Add(this.btnDisableTimed);
            this.groupBoxTimed.Controls.Add(this.lblSecond);
            this.groupBoxTimed.Controls.Add(this.textBoxTime1);
            this.groupBoxTimed.Controls.Add(this.btnEnableTimed);
            this.groupBoxTimed.Location = new System.Drawing.Point(127, 28);
            this.groupBoxTimed.Name = "groupBoxTimed";
            this.groupBoxTimed.Size = new System.Drawing.Size(205, 163);
            this.groupBoxTimed.TabIndex = 9;
            this.groupBoxTimed.TabStop = false;
            this.groupBoxTimed.Text = "Timed Output";
            // 
            // btn_rT
            // 
            this.btn_rT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_rT.Location = new System.Drawing.Point(6, 125);
            this.btn_rT.Name = "btn_rT";
            this.btn_rT.Size = new System.Drawing.Size(86, 25);
            this.btn_rT.TabIndex = 16;
            this.btn_rT.Text = "R Time";
            this.btn_rT.UseVisualStyleBackColor = false;
            this.btn_rT.Click += new System.EventHandler(this.btn_rT_Click);
            // 
            // tB_rT
            // 
            this.tB_rT.Location = new System.Drawing.Point(98, 126);
            this.tB_rT.Name = "tB_rT";
            this.tB_rT.Size = new System.Drawing.Size(99, 25);
            this.tB_rT.TabIndex = 15;
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(98, 96);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(99, 25);
            this.tbStatus.TabIndex = 13;
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnStatus.Location = new System.Drawing.Point(6, 95);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(86, 25);
            this.btnStatus.TabIndex = 12;
            this.btnStatus.Text = "Pin Status";
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnDisableTimed
            // 
            this.btnDisableTimed.Location = new System.Drawing.Point(6, 56);
            this.btnDisableTimed.Name = "btnDisableTimed";
            this.btnDisableTimed.Size = new System.Drawing.Size(63, 32);
            this.btnDisableTimed.TabIndex = 11;
            this.btnDisableTimed.Text = "Disable";
            this.btnDisableTimed.UseVisualStyleBackColor = true;
            this.btnDisableTimed.Click += new System.EventHandler(this.btnDisableTimed_Click);
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(133, 33);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(64, 17);
            this.lblSecond.TabIndex = 10;
            this.lblSecond.Text = "second(s)";
            // 
            // textBoxTime1
            // 
            this.textBoxTime1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTime1.Location = new System.Drawing.Point(75, 27);
            this.textBoxTime1.Name = "textBoxTime1";
            this.textBoxTime1.Size = new System.Drawing.Size(52, 29);
            this.textBoxTime1.TabIndex = 9;
            this.textBoxTime1.Text = "5";
            this.textBoxTime1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEnableTimed
            // 
            this.btnEnableTimed.Location = new System.Drawing.Point(6, 24);
            this.btnEnableTimed.Name = "btnEnableTimed";
            this.btnEnableTimed.Size = new System.Drawing.Size(63, 26);
            this.btnEnableTimed.TabIndex = 8;
            this.btnEnableTimed.Text = "Enable";
            this.btnEnableTimed.UseVisualStyleBackColor = true;
            this.btnEnableTimed.Click += new System.EventHandler(this.btnEnableTimed_Click);
            // 
            // groupBoxPeriodic
            // 
            this.groupBoxPeriodic.Controls.Add(this.btnDisabledPeriodic);
            this.groupBoxPeriodic.Controls.Add(this.lblPulsePerSecond);
            this.groupBoxPeriodic.Controls.Add(this.tbPeriodic);
            this.groupBoxPeriodic.Controls.Add(this.btnEnablePeriodic);
            this.groupBoxPeriodic.Location = new System.Drawing.Point(338, 28);
            this.groupBoxPeriodic.Name = "groupBoxPeriodic";
            this.groupBoxPeriodic.Size = new System.Drawing.Size(259, 163);
            this.groupBoxPeriodic.TabIndex = 10;
            this.groupBoxPeriodic.TabStop = false;
            this.groupBoxPeriodic.Text = "Periodic";
            // 
            // btnDisabledPeriodic
            // 
            this.btnDisabledPeriodic.Location = new System.Drawing.Point(180, 64);
            this.btnDisabledPeriodic.Name = "btnDisabledPeriodic";
            this.btnDisabledPeriodic.Size = new System.Drawing.Size(63, 34);
            this.btnDisabledPeriodic.TabIndex = 15;
            this.btnDisabledPeriodic.Text = "Disable";
            this.btnDisabledPeriodic.UseVisualStyleBackColor = true;
            this.btnDisabledPeriodic.Click += new System.EventHandler(this.btnDisabledPeriodic_Click);
            // 
            // lblPulsePerSecond
            // 
            this.lblPulsePerSecond.AutoSize = true;
            this.lblPulsePerSecond.Location = new System.Drawing.Point(6, 59);
            this.lblPulsePerSecond.Name = "lblPulsePerSecond";
            this.lblPulsePerSecond.Size = new System.Drawing.Size(108, 17);
            this.lblPulsePerSecond.TabIndex = 14;
            this.lblPulsePerSecond.Text = "pulse(s) / second";
            // 
            // tbPeriodic
            // 
            this.tbPeriodic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPeriodic.Location = new System.Drawing.Point(9, 27);
            this.tbPeriodic.Name = "tbPeriodic";
            this.tbPeriodic.Size = new System.Drawing.Size(52, 29);
            this.tbPeriodic.TabIndex = 13;
            this.tbPeriodic.Text = "4";
            this.tbPeriodic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEnablePeriodic
            // 
            this.btnEnablePeriodic.Location = new System.Drawing.Point(180, 24);
            this.btnEnablePeriodic.Name = "btnEnablePeriodic";
            this.btnEnablePeriodic.Size = new System.Drawing.Size(63, 34);
            this.btnEnablePeriodic.TabIndex = 12;
            this.btnEnablePeriodic.Text = "Enable";
            this.btnEnablePeriodic.UseVisualStyleBackColor = true;
            this.btnEnablePeriodic.Click += new System.EventHandler(this.btnEnablePeriodic_Click);
            // 
            // groupBoxDigital
            // 
            this.groupBoxDigital.Controls.Add(this.btnReadInput);
            this.groupBoxDigital.Controls.Add(this.tbInputStatus);
            this.groupBoxDigital.Location = new System.Drawing.Point(127, 197);
            this.groupBoxDigital.Name = "groupBoxDigital";
            this.groupBoxDigital.Size = new System.Drawing.Size(205, 170);
            this.groupBoxDigital.TabIndex = 11;
            this.groupBoxDigital.TabStop = false;
            this.groupBoxDigital.Text = "Digital Input";
            // 
            // btnReadInput
            // 
            this.btnReadInput.Location = new System.Drawing.Point(11, 24);
            this.btnReadInput.Name = "btnReadInput";
            this.btnReadInput.Size = new System.Drawing.Size(63, 34);
            this.btnReadInput.TabIndex = 15;
            this.btnReadInput.Text = "Read";
            this.btnReadInput.UseVisualStyleBackColor = true;
            this.btnReadInput.Click += new System.EventHandler(this.btnReadInput_Click);
            // 
            // tbInputStatus
            // 
            this.tbInputStatus.Location = new System.Drawing.Point(80, 30);
            this.tbInputStatus.Name = "tbInputStatus";
            this.tbInputStatus.Size = new System.Drawing.Size(85, 25);
            this.tbInputStatus.TabIndex = 14;
            // 
            // groupBoxAnalog
            // 
            this.groupBoxAnalog.Controls.Add(this.lblUnit3);
            this.groupBoxAnalog.Controls.Add(this.lblUnit2);
            this.groupBoxAnalog.Controls.Add(this.lblUnit1);
            this.groupBoxAnalog.Controls.Add(this.tbStatusAN3);
            this.groupBoxAnalog.Controls.Add(this.tbStatusAN2);
            this.groupBoxAnalog.Controls.Add(this.tbStatusAN1);
            this.groupBoxAnalog.Controls.Add(this.btnCh3);
            this.groupBoxAnalog.Controls.Add(this.btnCh2);
            this.groupBoxAnalog.Controls.Add(this.btnCh1);
            this.groupBoxAnalog.Location = new System.Drawing.Point(338, 197);
            this.groupBoxAnalog.Name = "groupBoxAnalog";
            this.groupBoxAnalog.Size = new System.Drawing.Size(259, 170);
            this.groupBoxAnalog.TabIndex = 12;
            this.groupBoxAnalog.TabStop = false;
            this.groupBoxAnalog.Text = "Analog Input";
            // 
            // lblUnit3
            // 
            this.lblUnit3.AutoSize = true;
            this.lblUnit3.Location = new System.Drawing.Point(169, 124);
            this.lblUnit3.Name = "lblUnit3";
            this.lblUnit3.Size = new System.Drawing.Size(77, 17);
            this.lblUnit3.TabIndex = 24;
            this.lblUnit3.Text = "(ADC Steps)";
            // 
            // lblUnit2
            // 
            this.lblUnit2.AutoSize = true;
            this.lblUnit2.Location = new System.Drawing.Point(169, 84);
            this.lblUnit2.Name = "lblUnit2";
            this.lblUnit2.Size = new System.Drawing.Size(77, 17);
            this.lblUnit2.TabIndex = 23;
            this.lblUnit2.Text = "(ADC Steps)";
            // 
            // lblUnit1
            // 
            this.lblUnit1.AutoSize = true;
            this.lblUnit1.Location = new System.Drawing.Point(169, 39);
            this.lblUnit1.Name = "lblUnit1";
            this.lblUnit1.Size = new System.Drawing.Size(77, 17);
            this.lblUnit1.TabIndex = 22;
            this.lblUnit1.Text = "(ADC Steps)";
            // 
            // tbStatusAN3
            // 
            this.tbStatusAN3.Location = new System.Drawing.Point(78, 116);
            this.tbStatusAN3.Name = "tbStatusAN3";
            this.tbStatusAN3.Size = new System.Drawing.Size(85, 25);
            this.tbStatusAN3.TabIndex = 21;
            // 
            // tbStatusAN2
            // 
            this.tbStatusAN2.Location = new System.Drawing.Point(78, 76);
            this.tbStatusAN2.Name = "tbStatusAN2";
            this.tbStatusAN2.Size = new System.Drawing.Size(85, 25);
            this.tbStatusAN2.TabIndex = 20;
            // 
            // tbStatusAN1
            // 
            this.tbStatusAN1.Location = new System.Drawing.Point(78, 33);
            this.tbStatusAN1.Name = "tbStatusAN1";
            this.tbStatusAN1.Size = new System.Drawing.Size(85, 25);
            this.tbStatusAN1.TabIndex = 19;
            // 
            // btnCh3
            // 
            this.btnCh3.Location = new System.Drawing.Point(9, 110);
            this.btnCh3.Name = "btnCh3";
            this.btnCh3.Size = new System.Drawing.Size(63, 34);
            this.btnCh3.TabIndex = 18;
            this.btnCh3.Text = "Ch 3";
            this.btnCh3.UseVisualStyleBackColor = true;
            this.btnCh3.Click += new System.EventHandler(this.btnCh3_Click);
            // 
            // btnCh2
            // 
            this.btnCh2.Location = new System.Drawing.Point(9, 70);
            this.btnCh2.Name = "btnCh2";
            this.btnCh2.Size = new System.Drawing.Size(63, 34);
            this.btnCh2.TabIndex = 17;
            this.btnCh2.Text = "Ch 2";
            this.btnCh2.UseVisualStyleBackColor = true;
            this.btnCh2.Click += new System.EventHandler(this.btnCh2_Click);
            // 
            // btnCh1
            // 
            this.btnCh1.Location = new System.Drawing.Point(9, 30);
            this.btnCh1.Name = "btnCh1";
            this.btnCh1.Size = new System.Drawing.Size(63, 34);
            this.btnCh1.TabIndex = 16;
            this.btnCh1.Text = "Ch 1";
            this.btnCh1.UseVisualStyleBackColor = true;
            this.btnCh1.Click += new System.EventHandler(this.btnCh1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Acknowledge";
            // 
            // richTextBox_ack
            // 
            this.richTextBox_ack.Location = new System.Drawing.Point(12, 221);
            this.richTextBox_ack.Name = "richTextBox_ack";
            this.richTextBox_ack.Size = new System.Drawing.Size(100, 96);
            this.richTextBox_ack.TabIndex = 14;
            this.richTextBox_ack.Text = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(608, 464);
            this.Controls.Add(this.richTextBox_ack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxAnalog);
            this.Controls.Add(this.groupBoxDigital);
            this.Controls.Add(this.groupBoxPeriodic);
            this.Controls.Add(this.groupBoxTimed);
            this.Controls.Add(this.groupBoxLED);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblHex);
            this.Controls.Add(this.tbHex);
            this.Controls.Add(this.lblAsciiString);
            this.Controls.Add(this.tbAscii);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "Command Interface Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxLED.ResumeLayout(false);
            this.groupBoxTimed.ResumeLayout(false);
            this.groupBoxTimed.PerformLayout();
            this.groupBoxPeriodic.ResumeLayout(false);
            this.groupBoxPeriodic.PerformLayout();
            this.groupBoxDigital.ResumeLayout(false);
            this.groupBoxDigital.PerformLayout();
            this.groupBoxAnalog.ResumeLayout(false);
            this.groupBoxAnalog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAscii;
        private System.Windows.Forms.Label lblAsciiString;
        private System.Windows.Forms.TextBox tbHex;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearTextToolStripMenuItem;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnLedOn;
        private System.Windows.Forms.Button btnLedOff;
        private System.Windows.Forms.GroupBox groupBoxLED;
        private System.Windows.Forms.GroupBox groupBoxTimed;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnDisableTimed;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.TextBox textBoxTime1;
        private System.Windows.Forms.Button btnEnableTimed;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.GroupBox groupBoxPeriodic;
        private System.Windows.Forms.Button btnDisabledPeriodic;
        private System.Windows.Forms.Label lblPulsePerSecond;
        private System.Windows.Forms.TextBox tbPeriodic;
        private System.Windows.Forms.Button btnEnablePeriodic;
        private System.Windows.Forms.GroupBox groupBoxDigital;
        private System.Windows.Forms.Button btnReadInput;
        private System.Windows.Forms.TextBox tbInputStatus;
        private System.Windows.Forms.GroupBox groupBoxAnalog;
        private System.Windows.Forms.Label lblUnit3;
        private System.Windows.Forms.Label lblUnit2;
        private System.Windows.Forms.Label lblUnit1;
        private System.Windows.Forms.TextBox tbStatusAN3;
        private System.Windows.Forms.TextBox tbStatusAN2;
        private System.Windows.Forms.TextBox tbStatusAN1;
        private System.Windows.Forms.Button btnCh3;
        private System.Windows.Forms.Button btnCh2;
        private System.Windows.Forms.Button btnCh1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox_ack;
        private System.Windows.Forms.TextBox tB_rT;
        private System.Windows.Forms.Button btn_rT;
    }
}

