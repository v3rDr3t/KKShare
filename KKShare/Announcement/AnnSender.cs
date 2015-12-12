using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using KKShare.Data;

namespace KKShare.Announcement
{
    internal class AnnSender
    {
        private string name;
        private Thread annSndThread;
        private AnnSendWorker worker;

        public AnnSender(string name)
        {
            this.name = name;
        }

        internal void StartSending()
        {
            worker = new AnnSendWorker();
            annSndThread = new Thread(() => worker.Start(this.name));
            annSndThread.Name = "AnnSender";
            annSndThread.IsBackground = true;
            annSndThread.Start();
        }

        internal void StopSending()
        {
            worker.Stop();
        }
    }

    internal class AnnSendWorker
    {
        private UdpClient udpClient;
        private IPEndPoint localEP;
        private int running;

        internal  AnnSendWorker()
        {
            udpClient = new UdpClient();
            IPAddress multicastAddress = IPAddress.Parse(Constants.MULTICAST_ADDRESS);
            udpClient.JoinMulticastGroup(multicastAddress);
            localEP = new IPEndPoint(multicastAddress, Constants.DEFAULT_PORT);
            running = 1;
        }

        internal void Start(string name)
        {
            while (running == 1)
            {
                UDPMessage msg = new UDPMessage(UDPMsgType.Announce, name);
                byte[] data = msg.ToByte();
                udpClient.Send(data, data.Length, localEP);
                Log.Instance.AddMessage(Severity.Debug, "Sent announcement.");
                Thread.Sleep(Constants.ANNOUNCE_SEND_INTERVAL);
            }
        }

        internal void Stop()
        {
            Interlocked.CompareExchange(ref running, 0, 1);
        }
    }
}
