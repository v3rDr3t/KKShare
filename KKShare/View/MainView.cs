using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KKShare
{
    public partial class MainView : Form, Observer
    {
        //private Controller controller;

        public MainView()
        {
            InitializeComponent();
        }

        //public void AddSettingsController(SettingsController controller)
        //{
        //    this.settingsController = controller;
        //}

        //void Observer.Update()
        //{
        //    // TODO: ...
        //}
    }

    /// <summary>
    /// An abstract observer.
    /// </summary>
    public interface Observer
    {
        /// <summary>
        /// Updates the respective view elements.
        /// </summary>
        void Update();
    }
}
