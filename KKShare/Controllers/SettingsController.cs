using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KKShare.Data;

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
            this.settings.Attach(mainView);
            Log.Instance.Attach(mainView);
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
                settings.SetName(name, true);

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
            settings.SetName(name, false);
        }
    }
}
