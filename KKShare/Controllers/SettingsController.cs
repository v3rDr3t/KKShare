using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KKShare.Data;
using System.ComponentModel;
using System.Windows.Forms;

namespace KKShare.Controllers
{
    public class SettingsController
    {
        private Settings settings;
        private MainView mainView;

        private SettingsFileHandler settingsFileHandler;

        public SettingsController(Settings settings, MainView mainView)
        {
            this.settings = settings;
            this.mainView = mainView;

            this.settingsFileHandler = new SettingsFileHandler();

            mainView.AddSettingsController(this);
            settings.PropertyChanged += new PropertyChangedEventHandler(settingsPropertyChanged);
        }
        
        private void settingsPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            mainView.UpdateProperty(e.PropertyName);
        }

        /// <summary>
        /// Loads settings from persistent data.
        /// </summary>
        internal void LoadSettings()
        {
            if (settingsFileHandler.LoadSettingsFile())
            {
                // load <name>
                string name = settingsFileHandler.ReadName();
                settings.Name = name;

                // load <...>
                // ...
            }
            else
            {
                Log.Instance.AddMessage(Severity.Info, "No settings file found. Loading default settings.");
            }
        }

        internal void WriteSettings()
        {
            string name = settings.Name;
            // ...
            settingsFileHandler.CreateSettingsFile(name);
        }

        internal string GetName()
        {
            return settings.Name;
        }

        internal void SetName(string name)
        {
            settings.Name = name;
        }
    }
}
