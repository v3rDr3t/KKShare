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

        // shares
        public const int MAXIMUM_FILE_PATH_LENGTH = 260;

        // messaging
        public const char LIST_DELIMITER = '|';

        // settings file
        public const string SETTINGS_FILE_NAME = "kkshare_settings.xml";
        public const string SETTINGS_FILE_ROOT_NAME = "Settings";
        public const string SETTINGS_FILE_NETWORK_NAME = "Network";
        public const string SETTINGS_FILE_NAME_NAME = "Name";
        public const string SETTINGS_FILE_DOWNLOADS_NAME = "DownloadsPath";
        public const string SETTINGS_FILE_SHARES_NAME = "Shares";
        public const string SETTINGS_FILE_SHARE_PATH_NAME = "SharePath";

        // logging
        public const string LOG_DATETIME_FORMAT = "HH:mm:ss (dd-MM-yyyy)";

        // directory check
        public const string DIR_CHECK_INFO_TEXT_CHECK = "Checking directory...";
        public const string DIR_CHECK_INFO_TEXT_PASSED = "Passed all checks.\nAdd to shared folders?";
        public const string DIR_CHECK_INFO_TEXT_SOME = "Some problems were identified.\nAdd to shared folders?";
        public const string DIR_CHECK_INFO_TEXT_FAILED = "Problems have been identified.\nFolder cannot be shared!";
        public const string DIR_CHECK_ERROR_TEXT_UNAUTH = "Insufficient access rights";
        public const string DIR_CHECK_ERROR_TEXT_DEL = "Does not exist anymore";
        public const string DIR_CHECK_ERROR_TEXT_UNKNOWN = "Unknown problem";


        // property names
        public const string PROP_NAME_SETTINGS_NAME = "SettingsName";
        public const string PROP_DOWNLAODS_SETTINGS_NAME = "SettingsDownloadsPath";
        public const string PROP_NAME_LOG = "Log";
        public const string PROP_NAME_SHARES = "Shares";


    }
}
