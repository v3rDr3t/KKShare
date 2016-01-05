using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKShare.Data
{
    public class Settings : INotifyPropertyChanged

    {
        private int port;
        private string name;
        private string downloadsPath;

        private List<Share> shares;
        
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Settings()
        {
            this.port = Constants.DEFAULT_PORT;
            this.name = System.Environment.MachineName;
            this.downloadsPath = System.Windows.Forms.Application.StartupPath;

            shares = new List<Share>();
        }

        internal bool AddShare(Share share)
        {
            if (shares == null || shares.FindIndex(item => item.DirPath.Equals(share.DirPath)) >= 0)
            {
                return false;
            }
            shares.Add(share);
            PropertyChanged(this, new PropertyChangedEventArgs(Constants.PROP_NAME_SHARES));
            return true;
        }

        private void shareChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(Constants.PROP_NAME_SHARES));
        }

        internal bool RemoveShares(List<Share> shares)
        {
            if (shares == null)
            {
                return false;
            }
            var sharesToRemove = new HashSet<Share>(shares);
            this.shares.RemoveAll(share => sharesToRemove.Contains(share));
            PropertyChanged(this, new PropertyChangedEventArgs(Constants.PROP_NAME_SHARES));
            return true;
        }

        internal bool ClearShares()
        {
            if (shares == null)
            {
                return false;
            }
            shares.Clear();
            PropertyChanged(this, new PropertyChangedEventArgs(Constants.PROP_NAME_SHARES));
            return true;
        }

        internal bool Set<T>(string propertyName, ref T field, T value)
        {
            if (field == null || EqualityComparer<T>.Default.Equals(field, value))
            {
                return false;
            }
            field = value;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            return true;
        }

        #region Field Accessors
        public int Port
        {
            get { return this.port; }
        }

        public string Name
        {
            get { return this.name; }
            set { Set(Constants.PROP_NAME_SETTINGS_NAME, ref this.name, value); }
        }

        internal string DownloadsPath
        {
            get { return this.downloadsPath; }
            set { Set(Constants.PROP_DOWNLAODS_SETTINGS_NAME, ref this.downloadsPath, value); }
        }

        internal List<Share> Shares
        {
            get { return this.shares; }
        }
        #endregion
    }
}
