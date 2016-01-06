using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using KKShare.Controllers;
using KKShare.Data;
using KKShare.Announcement;
using KKShare.Utility;

namespace KKShare.View
{
    public partial class MainView : Form
    {
        private SettingsController settingsController;
        private CommController commController;
        private InputValidator inputValidator;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public MainView()
        {
            InitializeComponent();
            Log.Instance.PropertyChanged += new PropertyChangedEventHandler(onLogProperty_Changed);

            inputValidator = new InputValidator();
            
            // format size column
            this.shareSizeOLVCol.AspectToStringConverter = delegate (object cellValue) {
                long bytesToFormat = (long)cellValue;
                return formatSize(bytesToFormat);
            };
        }

        /// <summary>
        /// Creates a formated (readable) string from the given bytes.
        /// </summary>
        /// <param name="bytesToFormat">The given bytes.</param>
        /// <returns>The formated folder size string.</returns>
        private string formatSize(long bytesToFormat)
        {
            string[] suffixes = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
            if (bytesToFormat == 0)
            {
                return "0 " + suffixes[0];
            }
            long bytes = Math.Abs(bytesToFormat);
            int dimension = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double fileSize = Math.Round(bytes / Math.Pow(1024, dimension), 2);
            return (Math.Sign(bytesToFormat) * fileSize).ToString() + " " + suffixes[dimension];
        }

        /// <summary>
        /// Initiates an update of a specific property. Triggered through a (property) change event.
        /// </summary>
        private void onLogProperty_Changed(object sender, PropertyChangedEventArgs e)
        {
            UpdateProperty(e.PropertyName);
        }
        
        /// <summary>
        /// ... . Triggered through an event.
        /// </summary>
        private void onMainView_Show(object sender, EventArgs e)
        {
            settingsController.LoadSettings();
            commController.StartAnnouncementService();
        }

        private void onMainView_Close(object sender, FormClosingEventArgs e)
        {
            settingsController.WriteSettings();
            // TODO: Close open connections etc...
        }

        /// <summary>
        /// Validates the user input for the <code>Name</code>. Triggered through an event.
        /// </summary>
        private void onNameTB_Validating(object sender, CancelEventArgs e)
        {
            string name = this.nameTB.Text;
            switch (inputValidator.ValidateName(name))
            {
                case NameResults.Error:
                    name = System.Environment.MachineName;
                    Log.Instance.AddMessage(Severity.Warning,
                        "The entered PC name \"" + this.nameTB.Text + "\" is invalid! Defaulting...");
                    break;

                default:
                    break;
            }
            this.settingsController.SetName(name);
        }

        /// <summary>
        /// Forces a focus change (to initiate validation). Triggered through an event.
        /// </summary>
        private void onNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                (sender as TextBox).Parent.Focus();
            }
        }

        /// <summary>
        /// Validates the user input for the <code>Downloads</code> folder. Triggered through an event.
        /// </summary>
        private void onDownloadsTB_Validating(object sender, CancelEventArgs e)
        {
            string downloadsPath = this.downloadsTB.Text;
            switch (inputValidator.ValidateDownloads(this.downloadsTB.Text))
            {
                case NameResults.Error:
                    downloadsPath = System.Windows.Forms.Application.StartupPath;
                    Log.Instance.AddMessage(Severity.Warning,
                        "The selected folder \"" + this.downloadsTB.Text + "\" does not exist! Defaulting...");
                    break;

                default:
                    break;
            }
            this.settingsController.SetDownloadsPath(downloadsPath);
        }

        /// <summary>
        /// Forces a focus change (to initiate validation). Triggered through an event.
        /// </summary>
        private void onDownloadsTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                (sender as TextBox).Parent.Focus();
            }
        }

        /// <summary>
        /// Initiates a browser dialog for the <code>Downloads</code> folder. Triggered through an event.
        /// </summary>
        private void onDownloadsBrowseBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDiag = new FolderBrowserDialog();
            if (folderBrowserDiag.ShowDialog() == DialogResult.OK)
            {
                this.downloadsTB.Text = folderBrowserDiag.SelectedPath;
                settingsController.SetDownloadsPath(folderBrowserDiag.SelectedPath);
            }
        }

        /// <summary>
        /// Adds the given <see cref="SettingsController"/> to the main view.
        /// </summary>
        /// <param name="controller">The given controller.</param>
        internal void AddSettingsController(SettingsController controller)
        {
            this.settingsController = controller;
        }

        /// <summary>
        /// Adds the given <see cref="CommController"/> to the main view.
        /// </summary>
        /// <param name="controller">The given controller.</param>
        internal void AddCommController(CommController controller)
        {
            this.commController = controller;
        }

        /// <summary>
        /// Autoscrolls to the bottom item when items change. Triggered through an event.
        /// </summary>
        private void onLogView_ItemsChanged(object sender, BrightIdeasSoftware.ItemsChangedEventArgs e)
        {
            if (logFOLV.GetItemCount() > 0)
            {
                logFOLV.EnsureVisible(logFOLV.GetItemCount() - 1);
            }
        }

        /// <summary>
        /// Updates the peers (lan) view according to given property./>
        /// </summary>
        internal void UpdatePeers(List<Peer> peers)
        {
            this.lanOLV.SetObjects(peers);
        }

        /// <summary>
        /// Updates the main view according to given property./>
        /// </summary>
        internal void UpdateProperty(string propertyName)
        {
            switch (propertyName)
            {
                case Constants.PROP_NAME_SETTINGS_NAME:
                    this.nameTB.Text = settingsController.GetName();
                    break;

                case Constants.PROP_DOWNLOADS_SETTINGS_NAME:
                    this.downloadsTB.Text = settingsController.GetDownloadsPath();
                    break;

                case Constants.PROP_NAME_LOG:
                    this.logFOLV.SetObjects(Log.Instance.List);
                    break;

                case Constants.PROP_NAME_SHARES:
                    this.sharesOLV.SetObjects(settingsController.GetShares());
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Initiates a TCP connection to the respective peer. Triggered through an event.
        /// </summary>
        private void onPeer_DoubleClick(object sender, EventArgs e)
        {
            Peer selectedPeer = (Peer)this.lanOLV.GetItem(this.lanOLV.SelectedIndex).RowObject;
            Log.Instance.AddMessage(Severity.Debug, "Connecting to " + selectedPeer.Name);
        }

        /// <summary>
        /// Shows the context menu for the shares view. Triggered through an event.
        /// </summary>
        private void onShares_OpenContext(object sender, BrightIdeasSoftware.CellRightClickEventArgs e)
        {
            this.sharesCMSAdd.Visible = true;
            this.sharesCMSRemove.Visible = true;
            this.sharesCMSClear.Visible = true;
            if (sharesOLV.SelectedItems.Count < 1)
            {
                this.sharesCMSRemove.Visible = false;
            }
            e.MenuStrip = this.sharesCMS;
        }

        /// <summary>
        /// Initiates the addition of a new share. Triggered through an event.
        /// </summary>
        private void onSharesCMSAdd_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDiag = new FolderBrowserDialog();
            if (folderBrowserDiag.ShowDialog() == DialogResult.OK)
            {
                settingsController.TryAddShare(folderBrowserDiag.SelectedPath);
            }
        }
        
        /// <summary>
        /// Removes a selected share. Triggered through an event.
        /// </summary>
        private void onSharesCMSRemove_Click(object sender, EventArgs e)
        {
            List<Share> selectedShares = sharesOLV.SelectedObjects.Cast<Share>().ToList();
            settingsController.RemoveShares(selectedShares);
        }

        /// <summary>
        /// Clears all shares. Triggered through an event.
        /// </summary>
        private void onSharesCMSClear_Click(object sender, EventArgs e)
        {
            settingsController.ClearShares();
        }
    }
}
