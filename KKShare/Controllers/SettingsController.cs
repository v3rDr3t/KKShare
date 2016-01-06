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

        private delegate void DirWorkerEventHandler(object sender, FileSystemEventArgs e);
        private delegate void DirWorkerRenameHandler(object sender, RenamedEventArgs e);
        private delegate void DirWorkerErrorHandler(object sender, ErrorEventArgs e);

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
                InputValidator inputValidator = new InputValidator();

                // load and validate <Name>
                string name = settingsFileHandler.ReadName();
                switch (inputValidator.ValidateName(name))
                {
                    case NameResults.Error:
                        this.settings.Name = System.Environment.MachineName;
                        Log.Instance.AddMessage(Severity.Info,
                            "The loaded PC name \"" + name + "\" is invalid! Defaulting...");
                        break;

                    default:
                        this.settings.Name = name;
                        break;
                }

                // load and validate <DownloadsPath>
                string downloadsPath = settingsFileHandler.ReadDownloadsPath();
                switch (inputValidator.ValidateName(name))
                {
                    case NameResults.Error:
                        this.settings.DownloadsPath = System.Windows.Forms.Application.StartupPath;
                        Log.Instance.AddMessage(Severity.Info,
                            "The loaded downloads folder \"" + downloadsPath + "\" does not exist! Defaulting...");
                        break;

                    default:
                        this.settings.DownloadsPath = downloadsPath;
                        break;
                }

                // load and validate <...>
                // ...

                // load and check <SharePath>s
                List<string> shares = settingsFileHandler.ReadShares();
                if (shares.Any())
                {
                    DirectoryCheckView checkView = new DirectoryCheckView(settingsFileHandler.ReadShares());
                    if (checkView.ShowDialog() == DialogResult.OK)
                    {
                        foreach (Share share in checkView.Shares)
                        {
                            this.settings.AddShare(share);
                        }
                    }
                }
            }
            else
            {
                this.settings.Name = System.Environment.MachineName;
                this.settings.DownloadsPath = System.Windows.Forms.Application.StartupPath;
                Log.Instance.AddMessage(Severity.Info, "No settings file found. Using default settings.");
            }
        }

        /// <summary>
        /// Writes all user defined settings to persistent data structure.
        /// </summary>
        internal void WriteSettings()
        {
            string name = settings.Name;
            string downloadsPath = settings.DownloadsPath;
            List<Share> shares = settings.Shares;
            // ...

            settingsFileHandler.CreateSettingsFile(name, downloadsPath, shares);
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
        /// Returns the downloads folder path from the model.
        /// </summary>
        /// <returns>The downloads folder path.</returns>
        internal string GetDownloadsPath()
        {
            return settings.DownloadsPath;
        }

        /// <summary>
        /// Sets the downloads folder path defined in the model to the given path.
        /// </summary>
        /// <param name="path">The given name.</param>
        internal void SetDownloadsPath(string path)
        {
            settings.DownloadsPath = path;
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
                foreach (Share share in checkView.Shares)
                {
                    settings.AddShare(share);
                    startDirWatcher(share.DirPath, "*.*");
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
            dirWatcher.RenamedMethod = new DirWorkerRenameHandler(dirWatcherRenamed);
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
                int idx = this.dirWatchers.FindIndex(item => item.DirPath.Equals(share.DirPath));
                if (idx >= 0)
                {
                    this.dirWatchers.ElementAt(idx).StopWatching();
                    this.dirWatchers.RemoveAt(idx);
                }
            }
        }

        #region Directory Watcher Event Handlers
        private void dirWatcherChanged(object sender, FileSystemEventArgs e)
        {
            // TODO: Implement...
            Log.Instance.AddMessage(Severity.Debug, "Changed file \"" + e.FullPath + "\".");
        }

        private void dirWatcherCreated(object sender, FileSystemEventArgs e)
        {
            // TODO: Implement...
            Log.Instance.AddMessage(Severity.Debug, "Created file \"" + e.FullPath + "\".");
        }

        private void dirWatcherDeleted(object sender, FileSystemEventArgs e)
        {
            // TODO: Implement...
            Log.Instance.AddMessage(Severity.Debug, "Deleted file \"" + e.FullPath + "\".");
        }

        private void dirWatcherRenamed(object sender, RenamedEventArgs e)
        {
            // TODO: Implement...
            Log.Instance.AddMessage(Severity.Debug, "Renamed file from \"" + e.OldFullPath + "\" to \""
                + e.FullPath + "\".");
        }

        private void dirWatcherError(object sender, ErrorEventArgs e)
        {
            // TODO: Implement...
            Log.Instance.AddMessage(Severity.Debug, "Error: \"" + e.GetException().Message + "\".");
        }
        #endregion
    }
}
