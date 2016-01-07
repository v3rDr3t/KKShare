using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KKShare.Data;
using KKShare.View;
using KKShare.Announcement;
using System.ComponentModel;

namespace KKShare.Controllers
{
    internal class CommController
    {
        private Settings settings;
        private CommData commData;
        private MainView mainView;

        private AnnReceiver discoveryRcv;
        private AnnSender discoverySnd;

        private bool annServiceStarted;

        internal CommController(Settings settings, MainView mainView)
        {
            commData = new CommData();
            this.settings = settings;
            this.mainView = mainView;

            discoveryRcv = new AnnReceiver(this);
            discoverySnd = new AnnSender();

            annServiceStarted = false;

            mainView.AddCommController(this);
            settings.PropertyChanged += new PropertyChangedEventHandler(settingsPropertyChanged);
        }

        internal void StartAnnouncementService()
        {
            discoveryRcv.StartReceiving();
            discoverySnd.StartSending(settings.Name);
            annServiceStarted = true;
        }

        internal void AddPeer(string ip, string name)
        {
            commData.AddPeer(ip, name);
            mainView.UpdatePeers(commData.Peers);
        }

        private void settingsPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case Constants.PROP_NAME_SETTINGS_NAME:
                    if (annServiceStarted)
                    {
                        discoverySnd.RestartSending(settings.Name);
                    }
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Initiates the transmission of a 'SharesRequest' to the given peer.
        /// </summary>
        /// <param name="peer">The given peer.</param>
        internal void sendSharesRequest(Peer peer)
        {
            throw new NotImplementedException();
        }
    }
}
