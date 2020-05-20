using System;
using System.Text;

namespace CmdInterface
{
    /// <summary>
    /// Based on MVPVM Design Pattern
    /// This Entity class contains only native .NET data types.
    /// 
    /// Reference URL: https://msdn.microsoft.com/en-us/magazine/hh580734.aspx
    /// </summary>
    public class PortSettingsEntity
    {
        private string _portName;
        public string PortName
        {
            get { return _portName; }
            set { _portName = value; }
        }

        private UInt32 _baudRate;
        public UInt32 BaudRate
        {
            get { return _baudRate; }
            set { _baudRate = value; }
        }

        private System.IO.Ports.Parity _parity = System.IO.Ports.Parity.None;
        public System.IO.Ports.Parity Parity
        {
            get { return _parity; }
            set { _parity = value; }
        }

        private byte _dataBits = 8;
        public byte DataBits
        {
            get { return _dataBits; }
            set { _dataBits = value; }
        }

        private System.IO.Ports.StopBits _stopBits = System.IO.Ports.StopBits.One;
        public System.IO.Ports.StopBits StopBits
        {
            get { return _stopBits; }
            set { _stopBits = value; }
        }

        private System.IO.Ports.Handshake _handshake = System.IO.Ports.Handshake.None;
        public System.IO.Ports.Handshake Handshake
        {
            get { return _handshake; }
            set { _handshake = value; }
        }

        private UInt16 _readTimeout = 500;
        public UInt16 ReadTimeout
        {
            get { return _readTimeout; }
            set { _readTimeout = value; }
        }

        private UInt16 _writeTimeout = 500;
        public UInt16 WriteTimeout
        {
            get { return _writeTimeout; }
            set { _writeTimeout = value; }
        }

        private Encoding _encoding = Encoding.ASCII;
        public Encoding Encoding
        {
            get { return _encoding; }
            set { _encoding = value; }
        }

        private bool _dtrEnable = false;
        public bool DtrEnable
        {
            get { return _dtrEnable; }
            set { _dtrEnable = value; }
        }

        private bool _rtsEnable = false;
        public bool RtsEnable
        {
            get { return _rtsEnable; }
            set { _rtsEnable = value; }
        }

        private bool _discardNull = true;
        public bool DiscardNull
        {
            get { return _discardNull; }
            set { _discardNull = value; }
        }

        private string _newline = Environment.NewLine;
        public string Newline
        {
            get { return _newline; }
            set { _newline = value; }
        }
    }
}
