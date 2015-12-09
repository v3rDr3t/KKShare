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
