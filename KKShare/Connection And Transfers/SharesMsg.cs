using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKShare.ConnectionAndTransfers
{
    internal class SharesMsg : TCPMessage
    {
        private List<string> shares;

        internal SharesMsg(TCPHeader type)
            : base(type)
        {
            this.shares = new List<string>();
        }

        internal SharesMsg(TCPHeader type, List<string> shares)
            : base(type)
        {
            this.shares = shares;
        }

        internal override void ParseData(byte[] data)
        {
            // TODO: Parse filePaths from data (seperate by some non-WS-char).
            throw new NotImplementedException();
        }

        internal override byte[] ToBytes()
        {
            // TODO: Convert filePaths from list (seperate by some non-WS-char)
            throw new NotImplementedException();
        }
    }
}
