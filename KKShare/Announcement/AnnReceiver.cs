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
    public class AnnReceiver
    {
        private Thread annRcvThread;
        private AnnReceiveWorker worker;

        internal void StartReceiving()
        {
            worker = new AnnReceiveWorker();
            annRcvThread = new Thread(worker.Start);
            annRcvThread.Name = "AnnReceiver";
            annRcvThread.IsBackground = true;
            annRcvThread.Start();
        }

        internal void StopReceiving()
        {
            worker.Stop();
        }
    }

    public class AnnReceiveWorker
    {
        private UdpClient udpClient;
        private IPEndPoint remoteEP;
        private int running;

        public AnnReceiveWorker()
        {
            udpClient = new UdpClient();
            remoteEP = new IPEndPoint(IPAddress.Any, Constants.DEFAULT_PORT);

            udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            udpClient.ExclusiveAddressUse = false;
            udpClient.Client.Bind(remoteEP);

            IPAddress multicastAddress = IPAddress.Parse(Constants.MULTICAST_ADDRESS);
            udpClient.JoinMulticastGroup(multicastAddress);
            running = 1;
        }

        internal void Start()
        {
            while (running == 1)
            {
                byte[] buffer = udpClient.Receive(ref remoteEP);
                UDPMessage msg = new UDPMessage(buffer);
                if (!isLocalIpAddress(remoteEP.Address.ToString()))
                {
                    switch (msg.Type)
                    {
                        case UDPMsgType.Announce:
                            Log.Instance.AddMessage(Severity.Debug,
                                msg.Text + " (" + remoteEP.Address.ToString() + ") announced itself.");
                            break;

                        default:
                            Log.Instance.AddMessage(Severity.Warning,
                                "An invalid UDP message was received and therefor ignored!");
                            break;
                    }
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
