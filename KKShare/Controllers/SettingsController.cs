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
        private List<DirectoryWatcher> dirWatchers;

        delegate void DirWorkerEventHandler(object sender, FileSystemEventArgs e);
        delegate void DirWorkerErrorHandler(object sender, ErrorEventArgs e);

        public SettingsController(Settings settings, MainView mainView)
        {
            this.settings = settings;
            this.mainView = mainView;

            this.settingsFileHandler = new SettingsFileHandler();
            this.dirWatchers = new List<DirectoryWatcher>();

            mainView.AddSettingsController(this);
            settings.PropertyChanged += new PropertyChangedEventHandler(settingsPropertyChanged);
        }

        /// <summary>
        /// Informs the GUI a change in the settings model. Triggered through an event.
        /// </summary>
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

        /// <summary>
        /// Writes all user defined settings to persistent data structure.
        /// </summary>
        internal void WriteSettings()
        {
            string name = settings.Name;
            List<Share> shares = settings.Shares;
            // ...

            settingsFileHandler.CreateSettingsFile(name, shares);
        }

        /// <summary>
        /// Returns the PC name from the model.
        /// </summary>
        /// <returns>The PC name.</returns>
        internal string GetName()
        {
            return settings.Name;
        }

        /// <summary>
        /// Sets the PC name defined in the model to the given name.
        /// </summary>
        /// <param name="name">The given name.</param>
        internal void SetName(string name)
        {
            settings.Name = name;
        }

        /// <summary>
        /// Returns the shares from the model.
        /// </summary>
        /// <returns>The shares.</returns>
        internal List<Share> GetShares()
        {
            return settings.Shares;
        }

        /// <summary>
        /// Tries to add the given directory path as share by conducting a directory check.
        /// The result depends on the outcome of the check.
        /// </summary>
        /// <param name="selectedPath">The given directory path.</param>
        internal void TryAddShare(string selectedPath)
        {
            DirectoryCheckView checkView = new DirectoryCheckView(new List<string>() { selectedPath });
            if (checkView.ShowDialog() == DialogResult.OK)
            {
                foreach (Share share in checkView.GetCheckedShares())
                {
                    settings.AddShare(share);
                    startDirWatcher(share.FolderPath, "*.*");
                }
            }
        }

        /// <summary>
        /// Removes the given shares.
        /// </summary>
        /// <param name="shares">The given shares.</param>
        internal void RemoveShares(List<Share> shares)
        {
            // stop watchers
            stopDirWatchers(shares);
            // remove shares
            settings.RemoveShares(shares);
        }

        /// <summary>
        /// Clears all shares.
        /// </summary>
        internal void ClearShares()
        {
            // stop directory watchers
            foreach (DirectoryWatcher dirWatcher in this.dirWatchers)
            {
                dirWatcher.StopWatching();
            }
            this.dirWatchers.Clear();
            // clear shares
            settings.ClearShares();
        }

        /// <summary>
        /// Creates and starts a directory watcher for the given directory path.
        /// </summary>
        /// <param name="dirPath">The given directory path</param>
        /// <param name="filter">The given filter settings.</param>
        private void startDirWatcher(string dirPath, string filter)
        {
            DirectoryWatcher dirWatcher = new DirectoryWatcher(dirPath, filter);
            // set event handlers
            dirWatcher.ChangedMethod = new DirWorkerEventHandler(dirWatcherChanged);
            dirWatcher.CreatedMethod = new DirWorkerEventHandler(dirWatcherCreated);
            dirWatcher.DeletedMethod = new DirWorkerEventHandler(dirWatcherDeleted);
            dirWatcher.RenamedMethod = new DirWorkerEventHandler(dirWatcherRenamed);
            dirWatcher.ErrorMethod = new DirWorkerErrorHandler(dirWatcherError);
            // start and add
            dirWatcher.StartWatching();
            this.dirWatchers.Add(dirWatcher);
        }

        /// <summary>
        /// Stops the directory watchers responsible for the given shares.
        /// </summary>
        /// <param name="shares">The given shares.</param>
        private void stopDirWatchers(List<Share> shares)
        {
            foreach (Share share in shares)
            {
                int idx = this.dirWatchers.FindIndex(item => item.DirPath.Equals(share.FolderPath));
                if (idx >= 0)
                {
                    this.dirWatchers.ElementAt(idx).StopWatching();
                    this.dirWatchers.RemoveAt(idx);
                }
            }
        }

        #region Directory Watcher Event Handlers
        // TODO: Implement...
        private void dirWatcherChanged(object sender, FileSystemEventArgs e)
        {
            Log.Instance.AddMessage(Severity.Debug, "Change in file \"" + e.FullPath + "\".");
        }

        private void dirWatcherCreated(object sender, FileSystemEventArgs e)
        {
            Log.Instance.AddMessage(Severity.Debug, "Change in file \"" + e.FullPath + "\".");
        }

        private void dirWatcherDeleted(object sender, FileSystemEventArgs e)
        {
            Log.Instance.AddMessage(Severity.Debug, "Change in file \"" + e.FullPath + "\".");
        }

        private void dirWatcherRenamed(object sender, FileSystemEventArgs e)
        {
            Log.Instance.AddMessage(Severity.Debug, "Change in file \"" + e.FullPath + "\".");
        }

        private void dirWatcherError(object sender, ErrorEventArgs e)
        {
            Log.Instance.AddMessage(Severity.Debug, "Error: \"" + e.GetException().Message + "\".");
        }
        #endregion
    }
}
