using System;

namespace CmdInterface
{
    /// <summary>
    /// This View Model translates Entity class proprties into data types that can be used by the View (User Interface)
    /// </summary>
    public class PortSettingsViewModel
    {
        private PortSettingsEntity _entity;
        public PortSettingsEntity Entity
        {
            get { return _entity; }
            set { _entity = value; }
        }

        public string PortName
        {
            get { return _entity.PortName; }
            set { _entity.PortName = value; }
        }
        public string BaudRate
        {
            get { return _entity.BaudRate.ToString(); }
            set { _entity.BaudRate = UInt32.Parse(value); }
        }
        public string Parity
        {
            get { return _entity.Parity.ToString(); }
            set { _entity.Parity = (System.IO.Ports.Parity)Enum.Parse(typeof(System.IO.Ports.Parity), value); }
        }
        public string DataBits
        {
            get { return _entity.DataBits.ToString(); }
            set { _entity.DataBits = (byte)int.Parse(value); }
        }
        public string StopBits
        {
            set { _entity.StopBits = (System.IO.Ports.StopBits)Enum.Parse(typeof(System.IO.Ports.StopBits), value); }
            get { return _entity.StopBits.ToString(); }
        }
        public string Handshake
        {
            get { return _entity.Handshake.ToString(); }
            set { _entity.Handshake = (System.IO.Ports.Handshake)Enum.Parse(typeof(System.IO.Ports.Handshake), value); }
        }
        public int ReadTimeout
        {
            get { return (int)_entity.ReadTimeout; }
            set { _entity.ReadTimeout = (UInt16)ReadTimeout; }
        }
        public int WriteTimeout
        {
            get { return (int)_entity.WriteTimeout; }
            set { _entity.WriteTimeout = (UInt16)WriteTimeout; }
        }
        public System.Text.Encoding Encoding
        {
            set { _entity.Encoding = value; }
            get { return _entity.Encoding; }
        }
        public bool DtrEnable
        {
            get { return _entity.DtrEnable; }
            set { _entity.DtrEnable = value; }
        }
        public bool RtsEnable
        {
            get { return _entity.RtsEnable; }
            set { _entity.RtsEnable = value; }
        }
        public bool DiscardNull
        {
            get { return _entity.DiscardNull; }
            set { _entity.DiscardNull = value; }
        }
    }
}
