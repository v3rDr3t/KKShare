using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KKShare.Data;
using KKShare.Announcement;
using System.ComponentModel;

namespace KKShare.Controllers
{
    internal class CommController
    {
        private Settings settings;
        private MainView mainView;

        private AnnReceiver discoveryRcv;
        private AnnSender discoverySnd;

        private bool annServiceStarted;

        internal CommController(Settings settings, MainView mainView)
        {
            this.settings = settings;
            this.mainView = mainView;

            discoveryRcv = new AnnReceiver();
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

        internal void StopSending()
        {
            discoverySnd.StopSending();
        }
    }
}
