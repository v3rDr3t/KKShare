using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKShare.Data
{
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
