using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KKShare.Data;

namespace KKShare.ConnectionAndTransfers
{
    public class TCPInterpreter
    {

        public TCPMessage Parse(byte[] data)
        {
            TCPHeader parsedHeader = TCPHeader.Null;
            try
            {
                parsedHeader = (TCPHeader)BitConverter.ToInt32(data, 0);
            }
            catch (Exception)
            {
                Log.Instance.AddMessage(Severity.Error, "Could not parse TCP header!");
            }
            return interpreter(parsedHeader, data);
        }

        private TCPMessage interpreter(TCPHeader parsedHeader, byte[] data)
        {
            TCPMessage message = null;
            switch (parsedHeader)
            {
                case TCPHeader.SharesRequest:
                    message = new SharesRequestMsg(data);
                    break;

                case TCPHeader.Shares:
                    message = new SharesMsg(data);
                    break;

                default:
                    Log.Instance.AddMessage(Severity.Error, "Could not interpret TCP header!");
                    break;
            }

            return message;
        }
    }
}
