namespace CmdInterface.common
{
    public class CmdComposer : AComposer
    {
        public CmdComposer(IView_FormMain i_view) : base(i_view) { }

        private string delimiter1 = "^";
        private string delimiter2 = "&";
        private string delimiter3 = "*";
        private string endFlag = "@";

        public void GenericCmd(string cmd)
        {
            CmdString(cmd);
        }
        public string LedOff()
        {
            string temp = encodeRequest("L", "0");
            CmdString(temp);
            return temp;
        }

        public string LedOn()
        {
            string temp = encodeRequest("L", "1");
            CmdString(temp);
            return temp;
        }


        public string TimedOutputEnable(string duration)
        {
            string temp = encodeRequest("N", duration);
            CmdString(temp);
            return temp;
        }

        public string TimedOutputDisable()
        {
            string temp = encodeRequest("F", "X");
            CmdString(temp);
            return temp;
        }

        public string TimedOutputStatus()
        {
            string temp = encodeRequest("S", "X");
            CmdString(temp);
            return temp;
        }

        public string TimedOutputPeriod()
        {
            string temp = encodeRequest("R", "X");
            CmdString(temp);
            return temp;
        }

        public string DigitalInputRead()
        {
            string temp = encodeRequest("D", "X");
            CmdString(temp);
            return temp;
        }
        

        public string PeriodicEnable(string pulsePerSecond)
        {
            string temp = encodeRequest("I", pulsePerSecond);
            CmdString(temp);
            return temp;
        }


        public string PeriodicDisable()
        {
            string temp = encodeRequest("J", "X");
            CmdString(temp);
            return temp;
        }


        public string AdcRead(string channel)
        {
            string temp = encodeRequest("A", channel);
            CmdString(temp);
            return temp;
        }
        

        public string encodeRequest(string operationFlag, string operationPayload1)
        {
            string encodedString = string.Empty;
            encodedString = operationFlag + delimiter1 + operationPayload1 + delimiter2 + endFlag;
            return encodedString;
        }

        public string parseResponse(string dataPacket,string token1, string token2)
        {
            int token1Index = dataPacket.IndexOf(token1);
            int token2Index = dataPacket.IndexOf(token2);
            string result = dataPacket.Substring(token1Index+1,token2Index - token1Index -1 );
            return result;
        }
    }
}
