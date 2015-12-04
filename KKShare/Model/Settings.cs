using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKShare
{
    public class Settings : Observable
    {
        private ServerSettings serverSettings;
        private ClientSettings clientSettings;

        public Settings(ushort port)
        {
            serverSettings = new ServerSettings();
            clientSettings = new ClientSettings();
        }

        public bool ReadyToReceive()
        {
            bool validPort = serverSettings.Port > 0; // TODO: Regex!
            return validPort;
        }

        public bool ReadyToSend()
        {
            // validity is checked on input! Only check if value is set right.
            bool IsIpSet = !clientSettings.Ip.Equals("");
            bool IsPortSet = clientSettings.Port > 0;
            bool fileStillExists = true; // TODO: Check File.Exists() or something because validity is checked on input!
            return IsIpSet && IsPortSet && fileStillExists;
        }

        public void SetServerPort(ushort port)
        {
            serverSettings.Port = port;
            Notify();
        }
    }

    public class ServerSettings
    {
        private ushort port;

        #region Field Accessors
        public ushort Port
        {
            get { return port; }
            set { port = value; }
        }
        #endregion
    }

    public class ClientSettings
    {
        private string ip;
        private ushort port;
        private string filePath;

        public ClientSettings()
        {
            this.ip = "";
            this.filePath = "";
        }

        #region Field Accessors
        public string Ip
        {
            get { return ip; }
            set { ip = value; }
        }

        public ushort Port
        {
            get { return port; }
            set { port = value; }
        }

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        #endregion
    }

    /// <summary>
    /// An abstract observable model.
    /// </summary>
    public abstract class Observable
    {
        // List of observers attached to an observable model
        private List<Observer> observers = new List<Observer>();

        /// <summary>
        /// Attaches an observer to the observable model.
        /// </summary>
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// Detaches an observer from the observable model.
        /// </summary>
        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        /// Notifies all observers about a change in the model.
        /// </summary>
        public void Notify()
        {
            foreach (Observer observer in observers)
            {
                observer.Update();
            }
        }
    }
}
