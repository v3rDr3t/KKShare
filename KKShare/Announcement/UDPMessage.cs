using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KKShare.Data;

namespace KKShare.Announcement
{
    public enum UDPHeader
    {
        Null,
        Announce
    }

    public class UDPMessage
    {
        private UDPHeader type;
        private string text;

        /// <summary>
        /// Constructs an instance of <see cref="UDPMessage"/>.
        /// </summary>
        /// <param name="type">The UDP message type.</param>
        /// <param name="text">The text content.</param>
        public UDPMessage(UDPHeader type, string text)
        {
            this.type = type;
            this.text = text;
        }

        /// <summary>
        /// Constructs an instance of <see cref="UDPMessage"/> of given byte array.
        /// </summary>
        /// <param name="data">The given UDP message as byte array.</param>
        public UDPMessage(byte[] data)
        {
            try
            {
                // convert type from first 2 bytes
                UDPHeader parsedType = (UDPHeader)BitConverter.ToInt32(data, 0);
                this.type = (UDPHeader.IsDefined(typeof(UDPHeader), parsedType))
                    ? parsedType
                    : UDPHeader.Null;

                // convert text length from next 4 byte
                int textLength = BitConverter.ToInt32(data, 4);

                // convert text from remaining bytes
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
        /// Converts the UDP message to a byte array.
        /// </summary>
        /// <returns>
        /// The UDP message as byte array.
        /// </returns>
        public byte[] ToByte()
        {
            List<byte> bytes = new List<byte>();

            // convert type
            bytes.AddRange(BitConverter.GetBytes((int)type));

            if (!text.Equals(string.Empty))
            {
                // convert text length
                int byteCount = Encoding.Default.GetByteCount(text);
                bytes.AddRange(BitConverter.GetBytes(byteCount));
                // convert text
                bytes.AddRange(Encoding.Default.GetBytes(text));
            }
            else
            {
                // text length 0
                bytes.AddRange(BitConverter.GetBytes(0));
            }
            
            return bytes.ToArray();
        }

        #region Field Getter
        public UDPHeader Type
        {
            get { return type; }
        }

        public string Text
        {
            get { return text; }
        }
        #endregion
    }
}
