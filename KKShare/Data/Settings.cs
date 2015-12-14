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
        
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Settings()
        {
            port = Constants.DEFAULT_PORT;
            name = System.Environment.MachineName;
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

        #region Field Getters
        public int Port
        {
            get { return port; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                Set(Constants.PROP_NAME_SETTINGS_NAME, ref this.name, value);
            }
        }
        #endregion
    }
}
