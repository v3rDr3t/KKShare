using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKShare.Data
{
    public static class Constants
    {
        // default network settings
        public const int DEFAULT_PORT = 51010;

        // discovery
        public const string MULTICAST_ADDRESS = "239.255.10.10";
        public const int ANNOUNCE_SEND_INTERVAL = 5000; // ms

        // settings file
        public const string SETTINGS_FILE_NAME = "kkshare_settings.xml";
        public const string SETTINGS_FILE_ROOT_NAME = "Settings";
        public const string SETTINGS_FILE_NETWORK_NAME = "Network";
        public const string SETTINGS_FILE_NAME_NAME = "Name";

        // logging
        public const string LOG_DATETIME_FORMAT = "HH:mm:ss (dd-MM-yyyy)";

        // property names
        public const string PROP_NAME_SETTINGS_NAME = "SettingsName";
        public const string PROP_NAME_LOG = "Log";


    }
}
