using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KKShare.Data;

namespace KKShare.Announcement
{
    internal enum UDPHeader
    {
        Null,
        Announce
    }

    internal class UDPMessage
    {
        private UDPHeader type;
        private string text;

        /// <summary>
        /// Constructs an instance of <see cref="UDPMessage"/> of given byte array.
        /// </summary>
        /// <param name="data">The given UDP message as byte array.</param>
        internal UDPMessage(byte[] data)
        {
            try
            {
                // convert message type from first 2 bytes
                UDPHeader parsedType = (UDPHeader)BitConverter.ToInt32(data, 0);
                this.type = (UDPHeader.IsDefined(typeof(UDPHeader), parsedType))
                    ? parsedType
                    : UDPHeader.Null;

                // convert message length from next 4 byte
                int textLength = BitConverter.ToInt32(data, 4);

                // convert message text from remaining bytes
                this.text = (textLength > 0)
                    ? Encoding.Default.GetString(data, 8, textLength)
                    : string.Empty;
            }
            catch (Exception)
            {
                this.type = UDPHeader.Null;
                this.text = string.Empty;
            }
        }

        /// <summary>
        /// Constructs an instance of <see cref="UDPMessage"/>.
        /// </summary>
        /// <param name="type">The UDP message type.</param>
        /// <param name="text">The text content.</param>
        internal UDPMessage(UDPHeader type, string text)
        {
            this.type = type;
            this.text = text;
        }

        /// <summary>
        /// Converts the UDP message to a byte array.
        /// </summary>
        /// <returns>
        /// The UDP message as byte array.
        /// </returns>
        internal byte[] ToByte()
        {
            List<byte> bytes = new List<byte>();

            // convert message type
            bytes.AddRange(BitConverter.GetBytes((int)type));

            // convert message length and text
            if (!text.Equals(string.Empty))
            {
                bytes.AddRange(BitConverter.GetBytes(text.Length));
                bytes.AddRange(Encoding.Default.GetBytes(text));
            }
            else
            {
                bytes.AddRange(BitConverter.GetBytes(0));
            }
            
            return bytes.ToArray();
        }

        #region Field Getter
        internal UDPHeader Type
        {
            get { return type; }
        }

        internal string Text
        {
            get { return text; }
        }
        #endregion
    }
}
