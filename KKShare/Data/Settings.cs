using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKShare.Data
{
    public class Settings : Observable
    {
        private int port;
        private string name;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Settings()
        {
            port = Constants.DEFAULT_PORT;
            name = System.Environment.MachineName;
        }

        internal void SetName(string name, bool updateView)
        {
            this.name = name;
            if (updateView) Notify();
        }

        #region Field Getters
        public int Port
        {
            get { return port; }
        }

        public string Name
        {
            get { return name; }
        }
        #endregion
    }
}
