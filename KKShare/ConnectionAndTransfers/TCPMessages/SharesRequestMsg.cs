using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KKShare.Data;

namespace KKShare.ConnectionAndTransfers
{
    public class SharesRequestMsg : TCPMessage
    {
        /// <summary>
        /// Default constructor.
        /// Is used when sending a message of this kind.
        /// </summary>
        public SharesRequestMsg() : base(TCPHeader.SharesRequest)
        {
        }

        /// <summary>
        /// Creates an object of type <see cref="SharesRequestMsg"/> from the given byte stream.
        /// Is used when receiving a message of this kind.
        /// </summary>
        /// <param name="data">The given byte stream.</param>
        public SharesRequestMsg(byte[] data) : base(TCPHeader.SharesRequest)
        {
            // nothing needs to be parsed
        }

        public override byte[] ToBytes()
        {
            return BitConverter.GetBytes((int)base.Type);
        }
    }
}
