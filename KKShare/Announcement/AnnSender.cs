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
        private UdpClient udpClient;
        private IPEndPoint localEP;
        CancellationTokenSource cancelTSource;

        internal AnnSender()
        {
            udpClient = new UdpClient();
            IPAddress multicastAddress = IPAddress.Parse(Constants.MULTICAST_ADDRESS);
            udpClient.JoinMulticastGroup(multicastAddress);
            localEP = new IPEndPoint(multicastAddress, Constants.DEFAULT_PORT);
            cancelTSource = new CancellationTokenSource();
        }

        internal void StartSending(string name)
        {
            cancelTSource.Dispose();
            cancelTSource = new CancellationTokenSource();
            CancellationToken cancelToken = cancelTSource.Token;
            Task.Factory.StartNew(async () =>
            {
                while (true)
                {
                    try
                    {
                        // announce name
                        UDPMessage msg = new UDPMessage(UDPHeader.Announce, name);
                        byte[] data = msg.ToByte();
                        udpClient.Send(data, data.Length, localEP);
                    }
                    catch (SocketException ex)
                    {
                        Log.Instance.AddMessage(Severity.Error, "Socket exception: " + ex.ErrorCode);
                    }
                    await Task.Delay(Constants.ANNOUNCE_SEND_INTERVAL, cancelToken);
                }
            }, cancelToken);
            //Log.Instance.AddMessage(Severity.Debug, "Started announcing...");
        }

        internal void RestartSending(string name)
        {
            cancelTSource.Cancel();
            StartSending(name);
        }

        internal void StopSending()
        {
            cancelTSource.Cancel();
            //Log.Instance.AddMessage(Severity.Debug, "Stopped announcing...");
        }
    }
}
