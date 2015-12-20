using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKShare.Utility
{
    internal class DirectoryWatcher
    {
        private string dirPath;
        private string filter;

        private Delegate changedMethod;
        private Delegate createdMethod;
        private Delegate deletedMethod;
        private Delegate renamedMethod;
        private Delegate errorMethod;

        private FileSystemWatcher watcher;

        /// <summary>
        /// Creates an instance of type <see cref="DirectoryWatcher"/> with the given directory path and filter settung.
        /// </summary>
        /// <param name="dirPath">The given path to the directory to be monitored.</param>
        /// <param name="filter">The given filer settings.</param>
        internal DirectoryWatcher(string dirPath, string filter)
        {
            this.dirPath = dirPath;
            this.filter = filter;
            this.watcher = new FileSystemWatcher();
        }

        /// <summary>
        /// Starts monitoring the set directory.
        /// </summary>
        internal void StartWatching()
        {
            // setup watcher
            this.watcher.Filter = this.filter;
            this.watcher.Path = this.dirPath;
            this.watcher.IncludeSubdirectories = true;
            this.watcher.NotifyFilter = NotifyFilters.DirectoryName
                | NotifyFilters.FileName
                | NotifyFilters.LastWrite
                | NotifyFilters.Size;
            this.watcher.EnableRaisingEvents = true;

            // add event handlers
            this.watcher.Changed += new FileSystemEventHandler(OnChanged);
            this.watcher.Created += new FileSystemEventHandler(OnCreated);
            this.watcher.Deleted += new FileSystemEventHandler(OnDeleted);
            this.watcher.Renamed += new RenamedEventHandler(OnRenamed);
            this.watcher.Error += new ErrorEventHandler(OnError);
        }

        /// <summary>
        /// Stops monitoring the set directory.
        /// </summary>
        internal void StopWatching()
        {
            this.watcher.EnableRaisingEvents = true;
            // remove event handler delegates
            this.watcher.Changed -= new FileSystemEventHandler(OnChanged);
            this.watcher.Created -= new FileSystemEventHandler(OnCreated);
            this.watcher.Deleted -= new FileSystemEventHandler(OnDeleted);
            this.watcher.Renamed -= new RenamedEventHandler(OnRenamed);
            this.watcher.Error -= new ErrorEventHandler(OnError);
        }

        #region Event Handlers
        /// <summary>
        /// Dynamically invokes the respecive delegate event handler. Triggered through an event.
        /// </summary>
        internal void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (this.changedMethod != null)
            {
                this.changedMethod.DynamicInvoke(sender, e);
            }
        }

        /// <summary>
        /// Dynamically invokes the respecive delegate event handler. Triggered through an event.
        /// </summary>
        internal void OnCreated(object sender, FileSystemEventArgs e)
        {
            if (this.createdMethod != null)
            {
                this.createdMethod.DynamicInvoke(sender, e);
            }
        }

        /// <summary>
        /// Dynamically invokes the respecive delegate event handler. Triggered through an event.
        /// </summary>
        internal void OnDeleted(object sender, FileSystemEventArgs e)
        {
            if (this.deletedMethod != null)
            {
                this.deletedMethod.DynamicInvoke(sender, e);
            }
        }

        /// <summary>
        /// Dynamically invokes the respecive delegate event handler. Triggered through an event.
        /// </summary>
        internal void OnRenamed(object sender, FileSystemEventArgs e)
        {
            if (this.renamedMethod != null)
            {
                this.renamedMethod.DynamicInvoke(sender, e);
            }
        }

        /// <summary>
        /// Dynamically invokes the respecive delegate event handler. Triggered through an event.
        /// </summary>
        public void OnError(object sender, ErrorEventArgs e)
        {
            if (this.errorMethod != null)
            {
                this.errorMethod.DynamicInvoke(sender, e);
            }
        }
        #endregion

        #region Field Accessors
        internal string DirPath
        {
            get { return this.dirPath; }
        }

        internal Delegate ChangedMethod
        {
            set { this.changedMethod = value; }
        }

        internal Delegate CreatedMethod
        {
            set { this.createdMethod = value; }
        }

        internal Delegate DeletedMethod
        {
            set { this.deletedMethod = value; }
        }

        internal Delegate RenamedMethod
        {
            set { this.renamedMethod = value; }
        }

        internal Delegate ErrorMethod
        {
            set { this.errorMethod = value; }
        }
        #endregion
    }
}
