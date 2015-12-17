using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KKShare.Data;

namespace KKShare.ConnectionAndTransfers
{
    internal class SharesRequestMsg : TCPMessage
    {

        internal SharesRequestMsg(TCPHeader type)
            : base(type)
        {
        }

        internal override void ParseData(byte[] data)
        {
            try
            {
                // convert message type from first 2 bytes
                TCPHeader parsedType = (TCPHeader)BitConverter.ToInt32(data, 0);
                if (TCPHeader.IsDefined(typeof(TCPHeader), parsedType))
                {
                    base.Type = parsedType;
                }
            }
            catch (Exception)
            {
                Log.Instance.AddMessage(Severity.Error, "Could not parse SharesRequestMsg!");
            }
        }

        internal override byte[] ToBytes()
        {
            List<byte> bytes = new List<byte>();

            // convert message type
            bytes.AddRange(BitConverter.GetBytes((int)base.Type));

            return bytes.ToArray();
        }
    }
}
