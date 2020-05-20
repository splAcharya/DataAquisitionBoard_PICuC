using System;
using System.Windows.Forms;

namespace CmdInterface
{
    public partial class FormPortSettings : Form
    {
        public PortSettingsEntity NewSettings { get { return _currentSettings; } }
        private PortSettingsEntity _defaultSettings, _currentSettings;
        private PortSettingsViewModel _viewModel;

        public FormPortSettings()
        {
            InitializeComponent();
        }

        private void FormPortSettings_Load(object sender, EventArgs e)
        {
            buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            SelectSettings(_defaultSettings);
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            UpdateSettings(_currentSettings);
            this.Close();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Initialize(PortSettingsEntity defaultSettings, PortSettingsEntity currentSettings)
        {
            if(defaultSettings != null && currentSettings != null)
            {
                FillComboboxPortName();
                FillComboboxBaudRate();
                FillComboboxDataBit();
                FillComboboxParity();
                FillComboboxStopBit();
                FillComboboxHandshake();

                SelectSettings(currentSettings);
                _defaultSettings = defaultSettings;
                _currentSettings = currentSettings;
            }
        }

        #region Private methods - UI

        private void FillComboboxPortName()
        {
            string[] options = System.IO.Ports.SerialPort.GetPortNames();

            comboBoxPortName.Items.Clear();  //empty combo box
            foreach (string s in options)
            {
                comboBoxPortName.Items.Add(s);
            }
        }

        private void FillComboboxBaudRate()
        {
            int[] options = { 9600, 19200, 38400, 57600, 115200 };

            comboBoxBaud.Items.Clear();  //empty combo box
            foreach (int i in options)
            {
                comboBoxBaud.Items.Add(i.ToString());
            }
        }
        private void FillComboboxDataBit()
        {
            int[] options = { 5, 6, 7, 8 };

            comboBoxDataBit.Items.Clear();  //empty combo box
            foreach (int i in options)
            {
                comboBoxDataBit.Items.Add(i.ToString());
            }
        }
        private void FillComboboxParity()
        {
            string[] options = Enum.GetNames(typeof(System.IO.Ports.Parity));

            comboBoxParity.Items.Clear();  //empty combo box
            foreach (string p in options)
            {
                comboBoxParity.Items.Add(p.ToString());
            }
        }
        private void FillComboboxStopBit()
        {
            string[] options = Enum.GetNames(typeof(System.IO.Ports.StopBits));

            comboBoxStopBit.Items.Clear();  //empty combo box
            foreach (string s in options)
            {
                comboBoxStopBit.Items.Add(s.ToString());
            }
        }
        private void FillComboboxHandshake()
        {
            string[] options = Enum.GetNames(typeof(System.IO.Ports.Handshake));

            comboBoxFlowControl.Items.Clear();  //empty combo box
            foreach (string s in options)
            {
                comboBoxFlowControl.Items.Add(s);
            }
        }
        
        #endregion

        private void SelectSettings(PortSettingsEntity settings)
        {
            int index = comboBoxPortName.Items.IndexOf(settings.PortName);
            if (index >= 0)
            {
                comboBoxPortName.SelectedIndex = index;
            }
            else
            {
                //comboBoxPortName.SelectedIndex = 0;
            }

            comboBoxBaud.SelectedIndex = comboBoxBaud.Items.IndexOf(settings.BaudRate.ToString());
            comboBoxDataBit.SelectedIndex = comboBoxDataBit.Items.IndexOf(settings.DataBits.ToString());
            comboBoxParity.SelectedIndex = comboBoxParity.Items.IndexOf(settings.Parity.ToString());
            comboBoxStopBit.SelectedIndex = comboBoxStopBit.Items.IndexOf(settings.StopBits.ToString());
            comboBoxFlowControl.SelectedIndex = comboBoxFlowControl.Items.IndexOf(settings.Handshake.ToString());
        }

        private void UpdateSettings(PortSettingsEntity entity)
        {
            if(_viewModel == null)
            {
                _viewModel = new PortSettingsViewModel();
            }
            _viewModel.Entity = entity;  //Pass reference to view model

            _viewModel.PortName = comboBoxPortName.SelectedItem.ToString();
            _viewModel.BaudRate = comboBoxBaud.SelectedItem.ToString();
            _viewModel.DataBits = comboBoxDataBit.SelectedItem.ToString();
            _viewModel.Parity = comboBoxParity.SelectedItem.ToString();
            _viewModel.StopBits = comboBoxStopBit.SelectedItem.ToString();
            _viewModel.Handshake = comboBoxFlowControl.SelectedItem.ToString();
        }
    }
}
