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
    public class DiscoveryReceiver
    {
        private Thread discoveryRcvThread;
        private DiscoveryReceiverWorker worker;

        public DiscoveryReceiver()
        {
        }

        internal void StartReceiving()
        {
            worker = new DiscoveryReceiverWorker();
            discoveryRcvThread = new Thread(worker.Start);
            discoveryRcvThread.IsBackground = true;
            discoveryRcvThread.Start();
        }

        internal void StopReceiving()
        {
            worker.Stop();
        }
    }

    public class DiscoveryReceiverWorker
    {
        private UdpClient udpClient;
        private IPEndPoint incomingIP;
        private int running;

        public DiscoveryReceiverWorker()
        {
            udpClient = new UdpClient();
            incomingIP = new IPEndPoint(IPAddress.Any, Constants.DEFAULT_PORT);

            udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            udpClient.ExclusiveAddressUse = false;
            udpClient.Client.Bind(incomingIP);

            IPAddress multicastAddress = IPAddress.Parse(Constants.MULTICAST_ADDRESS);
            udpClient.JoinMulticastGroup(multicastAddress);
            running = 1;
        }

        internal void Start()
        {
            while (running == 1)
            {
                byte[] buffer = udpClient.Receive(ref incomingIP);
                string helloString = Encoding.Unicode.GetString(buffer);
                if (!isLocalIpAddress(incomingIP.Address.ToString()))
                {
                    Log.Instance.AddMessage(Severity.Info, "Received: " + helloString + " from " + incomingIP.Address.ToString());
                }
            }
        }

        /// <summary>
        /// Checks if the given ip address is a local ip address.
        /// </summary>
        /// <param name="address">The given ip address.</param>
        /// <returns>
        /// <code>True</code> in case it is a local ip address, <code>false</code> otherwise.
        /// </returns>
        private bool isLocalIpAddress(string address)
        {
            IPAddress[] hostIPs = Dns.GetHostAddresses(address);
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress hostIP in hostIPs)
            {
                // is localhost
                if (IPAddress.IsLoopback(hostIP)) return true;
                // is local address
                foreach (IPAddress localIP in localIPs)
                {
                    if (hostIP.Equals(localIP)) return true;
                }
            }

            return false;
        }

        internal void Stop()
        {
            Interlocked.CompareExchange(ref running, 0, 1);
        }
    }
}
