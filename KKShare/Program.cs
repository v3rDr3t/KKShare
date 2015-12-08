using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            // setup MVC
            MainView view = new MainView();
            //Model model = new Model();
            //Controller controller = new Controller(model, view);

            // run
            Application.Run(view);
        }
    }
}
