using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKShare.ConnectionAndTransfers
{
    internal enum TCPHeader
    {
        Null,
        SharesRequest,
        Shares
    }

    internal abstract class TCPMessage
    {
        private TCPHeader type;

        internal TCPMessage()
        {
            this.type = TCPHeader.Null;
        }

        internal TCPMessage(TCPHeader type)
        {
            this.type = type;
        }

        internal abstract byte[] ToBytes();

        internal abstract void ParseData(byte[] data);

        public override string ToString()
        {
            return type.ToString();
        }

        internal TCPHeader Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
    }
}
