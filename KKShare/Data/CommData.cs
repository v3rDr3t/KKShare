using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKShare.Data
{
    internal class CommData
    {
        private ConcurrentQueue<Peer> peers;

        internal CommData()
        {
            peers = new ConcurrentQueue<Peer>();
        }

        internal void AddPeer(string ip, string name)
        {
            Peer toAdd = peers.FirstOrDefault(peer => peer.IP == ip);
            if (toAdd != null)
            {
                if (!toAdd.Name.Equals(name))
                {
                    toAdd.Name = name;
                    Log.Instance.AddMessage(Severity.Debug, "Modified " + toAdd.Name + " (" + toAdd.IP + ").");
                }
            }
            else
            {
                peers.Enqueue(new Peer(ip, name));
                Log.Instance.AddMessage(Severity.Info, name + " (" + ip + ") announced itself.");
            }
        }

        #region Field Getters
        internal List<Peer> Peers
        {
            get
            {
                return this.peers.ToList();
            }
        }
        #endregion
    }

    internal class Peer
    {
        private string ip;
        private string name;

        internal Peer(string ip, string name)
        {
            this.ip = ip;
            this.name = name;
        }

        #region Field Getters
        public string IP
        {
            get { return this.ip; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        #endregion
    }
}
