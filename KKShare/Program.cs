using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using KKShare.Data;
using KKShare.Controllers;

namespace KKShare
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // setup core components
            MainView mainView = new MainView();
            Settings settings = new Settings();
            new SettingsController(settings, mainView);
            new CommController(settings, mainView);

            // run
            Application.Run(mainView);
        }
    }
}
