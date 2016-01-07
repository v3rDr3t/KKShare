using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KKShare.Data;

namespace KKShare.ConnectionAndTransfers
{
    public class SharesMsg : TCPMessage
    {
        private List<string> shares;

        /// <summary>SharesMsg
        /// Creates an object of type <see cref="SharesMsg"/> with the given shares.
        /// Is used when sending a message of this kind.
        /// </summary>
        /// <param name="shares">The given shares.</param>
        public SharesMsg(List<string> shares) : base(TCPHeader.Shares)
        {
            this.shares = shares;
        }

        public SharesMsg(byte[] data) : base(TCPHeader.Shares)
        {
            try
            {
                // convert shares (as string) length from 4. byte
                int sharesLength = BitConverter.ToInt32(data, 4);

                // convert shares (as string) from remaining bytes
                string sharesAsString = (sharesLength > 0)
                    ? Encoding.Default.GetString(data, 8, sharesLength)
                    : string.Empty;

                // parse shares (as string) to list
                this.shares = sharesAsString.Split(new[] { Constants.MSG_SHARES_LIST_DELIMITER },
                    StringSplitOptions.None).ToList();

            }
            catch (Exception)
            {
                Log.Instance.AddMessage(Severity.Error, "Could not parse SharesMsg data!");
            }
        }

        public override byte[] ToBytes()
        {
            List<byte> bytes = new List<byte>();

            // convert type
            bytes.AddRange(BitConverter.GetBytes((int)base.Type));

            if (this.shares.Any())
            {
                string sharesToString = String.Join(Constants.MSG_SHARES_LIST_DELIMITER, this.shares.ToArray());
                // convert shares (as string) length
                int byteCount = Encoding.Default.GetByteCount(sharesToString);
                bytes.AddRange(BitConverter.GetBytes(byteCount));
                // convert shares (as string)
                bytes.AddRange(Encoding.Default.GetBytes(sharesToString));
            }
            else
            {
                // set shares (as string) length to "0"
                bytes.AddRange(BitConverter.GetBytes(0));
            }

            return bytes.ToArray();
        }

        #region Field Accessors
        public List<string> Shares
        {
            get { return this.shares; }
        }
        #endregion
    }
}
