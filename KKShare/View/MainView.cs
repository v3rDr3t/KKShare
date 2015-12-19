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
            Log.Instance.PropertyChanged += new PropertyChangedEventHandler(logPropertyChanged);

            inputValidator = new InputValidator();
        }

        /// <summary>
        /// Initiates an update of a specific property. Triggered through a (property) change event.
        /// </summary>
        private void logPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            UpdateProperty(e.PropertyName);
        }
        
        /// <summary>
        /// ... . Triggered through an event.
        /// </summary>
        private void onMainViewShow(object sender, EventArgs e)
        {
            settingsController.LoadSettings();
            commController.StartAnnouncementService();
        }

        private void MainView_Closing(object sender, FormClosingEventArgs e)
        {
            settingsController.WriteSettings();
            // TODO: Close open connections etc...
        }

        /// <summary>
        /// Validates the user input for the <code>Name</code>. Triggered through an event.
        /// </summary>
        private void TextBoxName_Validating(object sender, CancelEventArgs e)
        {
            switch (inputValidator.ValidateName(nameTextBox.Text))
            {
                case NameResults.Error:
                    inputErrorProvider.SetError(nameTextBox, "Invalid name!");
                    e.Cancel = true;
                    break;

                default:
                    inputErrorProvider.Clear();
                    settingsController.SetName(nameTextBox.Text);
                    Log.Instance.AddMessage(Severity.Debug, "Changed PC name to " + nameTextBox.Text + ".");
                    break;
            }
        }

        /// <summary>
        /// Forces a focus change (to initiate validation).
        /// </summary>
        private void TextBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                (sender as TextBox).Parent.Focus();
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
        private void Log_ItemsChanged(object sender, BrightIdeasSoftware.ItemsChangedEventArgs e)
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
                    nameTextBox.Text = settingsController.GetName();
                    break;

                case Constants.PROP_NAME_LOG:
                    logFOLV.SetObjects(Log.Instance.List);
                    break;

                case Constants.PROP_NAME_SHARES:
                    sharesOLV.SetObjects(settingsController.GetShares());
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Initiates a TCP connection to the respective peer. Triggered through an event.
        /// </summary>
        private void Peer_DoubleClick(object sender, EventArgs e)
        {
            Peer selectedPeer = (Peer)this.lanOLV.GetItem(this.lanOLV.SelectedIndex).RowObject;
            Log.Instance.AddMessage(Severity.Debug, "Connecting to " + selectedPeer.Name);
        }

        private void Shares_OpenContext(object sender, BrightIdeasSoftware.CellRightClickEventArgs e)
        {
            e.MenuStrip = (sharesOLV.SelectedItems.Count > 0)
                ? this.sharedItemCMS
                : this.sharesCMS;
        }

        private void sharesCMSAdd_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDiag = new FolderBrowserDialog();
            if (folderBrowserDiag.ShowDialog() == DialogResult.OK)
            {
                settingsController.TryAddShare(folderBrowserDiag.SelectedPath);
            }
        }

        private void sharesCMSClear_Click(object sender, EventArgs e)
        {
            settingsController.ClearShares();
        }

        private void sharedItemCMSAdd_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDiag = new FolderBrowserDialog();
            if (folderBrowserDiag.ShowDialog() == DialogResult.OK)
            {
                settingsController.TryAddShare(folderBrowserDiag.SelectedPath);
            }
        }

        private void sharedItemCMSRemove_Click(object sender, EventArgs e)
        {
            List<Share> selectedShares = sharesOLV.SelectedObjects.Cast<Share>().ToList();
            settingsController.RemoveShares(selectedShares);
        }

        private void sharedItemCMSClear_Click(object sender, EventArgs e)
        {
            settingsController.ClearShares();
        }
    }
}
