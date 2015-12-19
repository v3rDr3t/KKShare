using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKShare.ConnectionAndTransfers
{
    public enum TCPHeader
    {
        Null,
        SharesRequest,
        Shares
    }

    public abstract class TCPMessage
    {
        private TCPHeader type;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public TCPMessage()
        {
            this.type = TCPHeader.Null;
        }

        /// <summary>
        /// Creates an object of type <see cref="TCPMessage"/> with the given message type.
        /// </summary>
        /// <param name="type">The given message type.</param>
        public TCPMessage(TCPHeader type)
        {
            this.type = type;
        }

        /// <summary>
        /// Converts this message to a byte stream.
        /// </summary>
        /// <returns>A byte stream.</returns>
        public abstract byte[] ToBytes();

        public override string ToString()
        {
            return type.ToString();
        }

        #region Field Accessors
        public TCPHeader Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        #endregion
    }
}
