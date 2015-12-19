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

        private List<Share> shares;
        
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Settings()
        {
            port = Constants.DEFAULT_PORT;
            name = System.Environment.MachineName;

            shares = new List<Share>();
        }

        internal bool AddShare(Share share)
        {
            if (shares == null || shares.FindIndex(item => item.FolderPath.Equals(share.FolderPath)) >= 0)
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
            get { return port; }
        }

        public string Name
        {
            get { return name; }
            set { Set(Constants.PROP_NAME_SETTINGS_NAME, ref this.name, value); }
        }

        public List<Share> Shares
        {
            get { return this.shares; }
        }
        #endregion
    }
}
