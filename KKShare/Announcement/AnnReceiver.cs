using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KKShare.Controllers;
using KKShare.Data;

namespace KKShare.Announcement
{
    internal class AnnReceiver
    {
        private CommController commController;

        private UdpClient udpClient;
        private IPEndPoint remoteEP;
        private CancellationTokenSource cancelTSource;

        internal AnnReceiver(CommController commController)
        {
            this.commController = commController;

            udpClient = new UdpClient();
            remoteEP = new IPEndPoint(IPAddress.Any, Constants.DEFAULT_PORT);

            udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            udpClient.ExclusiveAddressUse = false;
            udpClient.Client.Bind(remoteEP);

            IPAddress multicastAddress = IPAddress.Parse(Constants.MULTICAST_ADDRESS);
            udpClient.JoinMulticastGroup(multicastAddress);
            cancelTSource = new CancellationTokenSource();
        }

        /// <summary>
        /// Starts receiving announcements from other PCs on LAN.
        /// </summary>
        internal void StartReceiving()
        {
            CancellationToken cancelToken = cancelTSource.Token;
            Task.Factory.StartNew(async () =>
            {
                while (true)
                {
                    try
                    {
                        byte[] buffer = udpClient.Receive(ref remoteEP);
                        if (!isLocalIpAddress(remoteEP.Address.ToString()))
                        {
                            UDPMessage msg = new UDPMessage(buffer);
                            switch (msg.Type)
                            {
                                case UDPHeader.Announce:
                                    commController.AddPeer(remoteEP.Address.ToString(), msg.Text);
                                    break;

                                default:
                                    Log.Instance.AddMessage(Severity.Warning,
                                        "An invalid UDP message was received and therefor ignored!");
                                    break;
                            }
                        }
                    }
                    catch (SocketException ex)
                    {
                        Log.Instance.AddMessage(Severity.Error,
                            "Socket exception: " + ex.ErrorCode);
                    }

                    await Task.Delay(Constants.ANNOUNCE_SEND_INTERVAL, cancelToken);
                }
            }, cancelToken);
        }

        /// <summary>
        /// Stops receiving announcements from other PCs on LAN.
        /// </summary>
        internal void StopReceiving()
        {
            cancelTSource.Cancel();
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
    }
}
