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
using KKShare.Discovery;

namespace KKShare
{
    public partial class MainView : Form, Observer
    {
        private SettingsController settingsController;
        private InputValidator inputValidator;
        
        private DiscoveryReceiver discoveryRcv;
        private DiscoverySender discoverySnd;

        public MainView()
        {
            InitializeComponent();

            inputValidator = new InputValidator();
            discoveryRcv = new DiscoveryReceiver();
            discoverySnd = new DiscoverySender();
        }


        private void MainView_Load(object sender, EventArgs e)
        {
            settingsController.LoadSettings();

            Log.Instance.AddMessage(Severity.Info, "Searching for other PCs on LAN...");
            discoveryRcv.StartReceiving();
            discoverySnd.StartSending();
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
        public void AddSettingsController(SettingsController controller)
        {
            this.settingsController = controller;
        }

        /// <summary>
        /// Autoscrolls to the bottom item when items change. Triggered through an event.
        /// </summary>
        private void Log_ItemsChanged(object sender, BrightIdeasSoftware.ItemsChangedEventArgs e)
        {
            if (logFastObjectListView.GetItemCount() > 0)
            {
                logFastObjectListView.EnsureVisible(logFastObjectListView.GetItemCount() - 1);
            }
        }

        /// <summary>
        /// Updates the main view according to data settings./>
        /// </summary>
        void Observer.Update()
        {
            nameTextBox.Text = settingsController.GetName();
            logFastObjectListView.SetObjects(Log.Instance.List);
        }
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
