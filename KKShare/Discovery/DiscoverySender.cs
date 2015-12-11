using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using KKShare.Data;

namespace KKShare.Discovery
{
    public class DiscoverySender
    {
        private Thread discoverySndThread;
        private DiscoverySenderWorker worker;

        public DiscoverySender()
        {
        }

        internal void StartSending()
        {
            worker = new DiscoverySenderWorker();
            discoverySndThread = new Thread(worker.Start);
            discoverySndThread.IsBackground = true;
            discoverySndThread.Start();
        }

        internal void StopSending()
        {
            worker.Stop();
        }
    }

    public class DiscoverySenderWorker
    {
        private UdpClient udpClient;
        private IPEndPoint outgoingIP;
        private int running;

        public DiscoverySenderWorker()
        {
            udpClient = new UdpClient();
            IPAddress multicastAddress = IPAddress.Parse(Constants.MULTICAST_ADDRESS);
            udpClient.JoinMulticastGroup(multicastAddress);
            outgoingIP = new IPEndPoint(multicastAddress, Constants.DEFAULT_PORT);
            running = 1;
        }

        internal void Start()
        {
            while (running == 1)
            {
                byte[] buffer = Encoding.Unicode.GetBytes("HELLO"); ;
                udpClient.Send(buffer, buffer.Length, outgoingIP);
                Log.Instance.AddMessage(Severity.Info, "Sent HELLO.");
                Thread.Sleep(Constants.DISCOVERY_SEND_INTERVAL);
            }
        }

        internal void Stop()
        {
            Interlocked.CompareExchange(ref running, 0, 1);
        }
    }
}
