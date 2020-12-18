using System;
using System.IO.Ports;
using System.Windows.Forms;

using CmdInterface.common;

namespace CmdInterface
{
    public partial class FormMain : Form, IView_FormMain
    {
        private FormPortSettings _formPortSettings;
        private PortSettingsEntity _defaultSettings, _currentSettings;
        private CmdComposer _composer;

        //recieve data
        string rxData;

        //delegate mothods
        public delegate void UpdateUIDelegate(string indata);
        public UpdateUIDelegate textUpdaterDelegate; //General Acknowledge
        public UpdateUIDelegate timedOutputStatusUpdaterDelegate; //update timed output status
        public UpdateUIDelegate timedInputPeriodUpdaterDelegate; // update timed output reming time
        public UpdateUIDelegate digitalInputUpdaterDelegate; //update digital input status
        public UpdateUIDelegate adcChannel1UpdaterDelegate; //update adc channel 1;
        public UpdateUIDelegate adcChannel2UpdaterDelegate; //update adc channel 2;
        public UpdateUIDelegate adcChannel3UpdaterDelegate; //update adc channel 3;

        public FormMain()
        {
            InitializeComponent();

            //Initialize UI visual elements
            connectToolStripMenuItem.Enabled = true;
            disconnectToolStripMenuItem.Enabled = false;
            //tbAscii.ReadOnly = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _defaultSettings = new PortSettingsEntity();  //Object instance containing default settings
            _currentSettings = new PortSettingsEntity();  //Object instance storing current settings from user

            InitializeComPort(_defaultSettings);
            InitializeComPort(_currentSettings);

            _composer = new CmdComposer(this);
   
            //Delegate
            this.textUpdaterDelegate = new UpdateUIDelegate(generalAcknowledge);
            this.timedOutputStatusUpdaterDelegate = new UpdateUIDelegate(updateTimedOutputStatus);
            this.timedInputPeriodUpdaterDelegate = new UpdateUIDelegate(updateTimedOutputPeriod);
            this.digitalInputUpdaterDelegate = new UpdateUIDelegate(updateDigitalInputStatus);
            this.adcChannel1UpdaterDelegate = new UpdateUIDelegate(updateAdcChannel1Value);
            this.adcChannel2UpdaterDelegate = new UpdateUIDelegate(updateAdcChannel2Value);
            this.adcChannel3UpdaterDelegate = new UpdateUIDelegate(updateAdcChannel3Value);
        }

        //general acknowledgement bit for LED, Timed output, Periodic, Analog Input
        private void generalAcknowledge(string indata)
        {
            indata = _composer.parseResponse(indata,"^","&");
            richTextBox_ack.Clear();
            richTextBox_ack.Text = indata;
            rxData = string.Empty;   
        }

        //update Timed outptu status
        private void updateTimedOutputStatus(string indata)
        {
            indata = _composer.parseResponse(indata, "^", "&");
            tbStatus.Clear();
            tbStatus.Text = indata;
            rxData = string.Empty;
        }

        //update Timed output Period
        private void updateTimedOutputPeriod(string indata)
        {
            indata = _composer.parseResponse(indata, "^", "&");
            tB_rT.Clear();
            tB_rT.Text = indata;
            rxData = string.Empty;
        }

        //update digital input status
        private void updateDigitalInputStatus(string indata)
        {
            indata = _composer.parseResponse(indata, "^", "&");
            tbInputStatus.Clear();
            tbInputStatus.Text = indata;
            rxData = string.Empty;
        }


        //update Adc channel1 Value
        private void updateAdcChannel1Value(string indata)
        {
            indata = _composer.parseResponse(indata, "&", "*");
            tbStatusAN1.Clear();
            tbStatusAN1.Text = indata;
            rxData = string.Empty;
        }

        //update Adc channel1 Value
        private void updateAdcChannel2Value(string indata)
        {
            indata = _composer.parseResponse(indata, "&", "*");
            tbStatusAN2.Clear();
            tbStatusAN2.Text = indata;
            rxData = string.Empty;
        }

        //update Adc channel1 Value
        private void updateAdcChannel3Value(string indata)
        {
            indata = _composer.parseResponse(indata, "&", "*");
            tbStatusAN3.Clear();
            tbStatusAN3.Text = indata;
            rxData = string.Empty;
        }


        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitializeComPort(PortSettingsEntity handle)
        {
            string[] port_list = System.IO.Ports.SerialPort.GetPortNames();

            if (port_list.Length > 0)
            {
                handle.PortName = port_list[0];  //Default com port is the first one on the list
                handle.BaudRate = 9600;
                handle.DataBits = 8;
                handle.StopBits = System.IO.Ports.StopBits.One;
                handle.Parity = System.IO.Ports.Parity.None;
            }
        }

        private void Connect(PortSettingsEntity handle)
        {
            if (handle != null)
            {
                //Configure serial port
                serialPort1.PortName = handle.PortName;
                serialPort1.BaudRate = (int)handle.BaudRate;
                serialPort1.DataBits = handle.DataBits;
                serialPort1.Parity = handle.Parity;
                serialPort1.Handshake = handle.Handshake;

                serialPort1.ReadTimeout = handle.ReadTimeout;
                serialPort1.WriteTimeout = handle.WriteTimeout;
                serialPort1.DiscardNull = handle.DiscardNull;
                serialPort1.RtsEnable = handle.RtsEnable;
                serialPort1.NewLine = handle.Newline;
                serialPort1.Encoding = handle.Encoding;

                try
                {
                    if (serialPort1.IsOpen == false)
                    {
                        serialPort1.Open();  //attempt to open the configured serial port

                        if (serialPort1.IsOpen)
                        {
                            //Com Port connected
                            connectToolStripMenuItem.Enabled = false;
                            disconnectToolStripMenuItem.Enabled = true;
                            tbAscii.ReadOnly = false;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to open serial port");
                }
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Note: SerialPort object operates on a seperate thread.
            //      Therefore, DataReceived event can not interact directly with other WinForm controls.
            //      Doing so will cause cross-thread action exception.
            //      In order to display received data to UI, delegate method must be used.

            //Read data from serial port object
            SerialPort sp = (SerialPort)sender;
            rxData += sp.ReadExisting(); //kkep appending recived packets

            //TODO: display received string to Textbox
            //decide packet roles
            if (rxData[rxData.Length - 1] == '#'){

                if ((rxData[0] == 'L') || (rxData[0] == 'T') || (rxData[0] == 'P')) //for led, timed output enable/disable, pwm enable/disable
                {
                    richTextBox_ack.Invoke(this.textUpdaterDelegate, new object[] { rxData });
                }
                else if (rxData[0] == 'S') //for timed output status
                {
                    tbStatus.Invoke(this.timedOutputStatusUpdaterDelegate, new object[] { rxData });
                }
                else if (rxData[0] == 'R') //for timed output remaing time
                {
                    tB_rT.Invoke(this.timedInputPeriodUpdaterDelegate, new object[] { rxData });
                }
                else if (rxData[0] == 'D') // for digital input status
                {
                    tbInputStatus.Invoke(this.digitalInputUpdaterDelegate, new object[] { rxData });
                }
                else if (rxData[0] == 'A')
                {
                    if (rxData[2] == '6') //for adc channel 1
                    {
                        tbStatusAN1.Invoke(this.adcChannel1UpdaterDelegate, new object[] { rxData });
                    }
                    else if (rxData[2] == '7') //for adc channel 2
                    {
                        tbStatusAN2.Invoke(this.adcChannel2UpdaterDelegate, new object[] { rxData });
                    }
                    else if (rxData[2] == '8') //for adc channel 3
                    {
                        tbStatusAN3.Invoke(this.adcChannel3UpdaterDelegate, new object[] { rxData });
                    }
                }
            }
            //else {
                // richTextBox_ack.Text = "Serial recieved";
                //richTextBox_ack.Invoke(this.textUpdaterDelegate, new object[] { "Data Recieved" });
            //}
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //handle serial port connect
            Connect(_currentSettings);
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                //Disconnect serial port
                serialPort1.Close();

                connectToolStripMenuItem.Enabled = true;
                disconnectToolStripMenuItem.Enabled = false;
                tbAscii.ReadOnly = true;
            }
        }

        private void tbAscii_TextChanged(object sender, EventArgs e)
        {
            byte[] buffer = common.Utility.StringToByteArray(tbAscii.Text);
            UpdateHexTextbox(buffer);
        }

        public void ShowCommand(string command_string)
        {
            tbAscii.Text = command_string;
        }

        private void UpdateHexTextbox(byte[] buffer)
        {
            tbHex.Text = common.Utility.ByteArrayToString(buffer);
            tbHex.SelectionStart = tbHex.Text.Length;
            tbHex.ScrollToCaret();
            tbHex.Refresh();
        }

        private void clearTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbAscii.Clear();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (string.IsNullOrEmpty(tbAscii.Text) == false)
                {
                    //Write string directly to serial port object
                    serialPort1.Write(tbAscii.Text);
                }
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_formPortSettings == null)
            {
                _formPortSettings = new FormPortSettings();
            }

            _formPortSettings.Initialize(_defaultSettings, _currentSettings);
            //if (_formPortSettings.ShowDialog() == DialogResult.OK)
            {
                //apply settings
                _currentSettings = _formPortSettings.NewSettings;
            }
        }

        //led off
        private void btnLedOff_Click(object sender, EventArgs e)
        {
            string temp = _composer.LedOff();
            serialPort1.Write(temp);
        }

        //led on
        private void btnLedOn_Click(object sender, EventArgs e)
        {
            string temp = _composer.LedOn();
            serialPort1.Write(temp);
        }

        //timed output enable
        private void btnEnableTimed_Click(object sender, EventArgs e)
        {
            string temp = _composer.TimedOutputEnable(textBoxTime1.Text.ToString());
            serialPort1.Write(temp);
        }


        //timed output disable
        private void btnDisableTimed_Click(object sender, EventArgs e)
        {
            string temp = _composer.TimedOutputDisable();
            serialPort1.Write(temp);
        }

        //status 
        private void btnStatus_Click(object sender, EventArgs e)
        {
            string temp = _composer.TimedOutputStatus();
            serialPort1.Write(temp);
        }

        //period
        private void btn_rT_Click(object sender, EventArgs e)
        {
            string temp = _composer.TimedOutputPeriod();
            serialPort1.Write(temp);
        }


        //digital input
        private void btnReadInput_Click(object sender, EventArgs e)
        {
            string temp = _composer.DigitalInputRead();
            serialPort1.Write(temp);
        }

        //periodic pwm disable
        private void btnEnablePeriodic_Click(object sender, EventArgs e)
        {
           string temp =  _composer.PeriodicEnable(tbPeriodic.Text.ToString());
            serialPort1.Write(temp);
        }

        //periodic pwm enable
        private void btnDisabledPeriodic_Click(object sender, EventArgs e)
        {
            string temp = _composer.PeriodicDisable();
            serialPort1.Write(temp);
        }

        //adc channel 1
        private void btnCh1_Click(object sender, EventArgs e)
        {
           string temp =  _composer.AdcRead("6");
            serialPort1.Write(temp);
        }


        //adc channel 2
        private void btnCh2_Click(object sender, EventArgs e)
        {
            string temp = _composer.AdcRead("7");
            serialPort1.Write(temp);
        }


        //adc channel 3
        private void btnCh3_Click(object sender, EventArgs e)
        {
            string temp = _composer.AdcRead("8");
            serialPort1.Write(temp);
        }

    }
}
