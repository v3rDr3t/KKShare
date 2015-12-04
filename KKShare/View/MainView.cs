using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KKShare.Controller;

namespace KKShare
{
    public partial class MainView : Form, Observer
    {
        private SettingsController settingsController;
        private InputValidator inputValidator;

        public MainView()
        {
            InitializeComponent();

            // initialize input validator
            inputValidator = new InputValidator();
        }

        #region Input Validation
        private void txtBoxPortServer_Validating(object sender, CancelEventArgs e)
        {
            switch (inputValidator.validatePort(txtBoxPortServer.Text))
            {
                case ValidatePortResult.Error:
                    inputErrorProvider.SetError(txtBoxPortServer, "Something is not right with the server port input!");
                    break;

                case ValidatePortResult.Error1:
                    inputErrorProvider.SetError(txtBoxPortServer, "Something else is not right with the server port input!");
                    break;

                default:
                    // Parse validated input and set
                    ushort port = Convert.ToUInt16(txtBoxPortServer.Text);
                    settingsController.SetServerPort(port);
                    break;
            }
        }
        #endregion

        private void btnRcv_Click(object sender, EventArgs e)
        {
            // TODO: ...
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // TODO: ...
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            // TODO: ...
        }

        // Is called through Observable.Notify()
        void Observer.Update()
        {
            // server panel: activate "Start Receiving"
            btnRcv.Enabled = settingsController.ReadyToReceive();

            // client panel: activate "Send File"
            btnSend.Enabled = settingsController.ReadyToSend();

            // log panel: update log messages
            // TODO: ...
        }

        public void AddSettingsController(SettingsController controller)
        {
            this.settingsController = controller;
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
