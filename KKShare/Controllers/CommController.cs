using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KKShare.Data;
using KKShare.Announcement;

namespace KKShare.Controllers
{
    internal class CommController
    {
        private Settings settings;
        private MainView mainView;

        private AnnReceiver discoveryRcv;
        private AnnSender discoverySnd;

        internal CommController(Settings settings, MainView mainView)
        {
            this.settings = settings;
            this.mainView = mainView;

            discoveryRcv = new AnnReceiver();
            discoverySnd = new AnnSender(settings.Name);

            mainView.AddCommController(this);
        }

        internal void StartAnnouncementService()
        {
            Log.Instance.AddMessage(Severity.Info, "Searching for other PCs on LAN...");
            discoveryRcv.StartReceiving();
            discoverySnd.StartSending();
        }
    }
}
