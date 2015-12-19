using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KKShare.Data;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections;
using System.IO;

using KKShare.View;
using KKShare.Utility;

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
                // load <Name>
                string name = settingsFileHandler.ReadName();
                settings.Name = name;
                
                // load <...>
                // ...

                // load <SharePath>s
                List<string> shares = settingsFileHandler.ReadShares();
                if (shares.Any())
                {
                    DirectoryCheckView checkView = new DirectoryCheckView(settingsFileHandler.ReadShares());
                    if (checkView.ShowDialog() == DialogResult.OK)
                    {
                        foreach (Share share in checkView.GetCheckedShares())
                        {
                            settings.AddShare(share);
                        }
                    }
                }
            }
            else
            {
                Log.Instance.AddMessage(Severity.Info, "No settings file found. Loading default settings.");
            }
        }

        internal void WriteSettings()
        {
            string name = settings.Name;
            List<Share> shares = settings.Shares;
            // ...

            settingsFileHandler.CreateSettingsFile(name, shares);
        }

        internal string GetName()
        {
            return settings.Name;
        }

        internal void SetName(string name)
        {
            settings.Name = name;
        }

        internal List<Share> GetShares()
        {
            return settings.Shares;
        }

        internal void TryAddShare(string selectedPath)
        {
            DirectoryCheckView checkView = new DirectoryCheckView(new List<string>() { selectedPath });
            if (checkView.ShowDialog() == DialogResult.OK)
            {
                foreach (Share share in checkView.GetCheckedShares())
                {
                    settings.AddShare(share);
                }
            }
        }

        internal void RemoveShares(List<Share> shares)
        {
            settings.RemoveShares(shares);
        }

        internal void ClearShares()
        {
            settings.ClearShares();
        }
    }
}
