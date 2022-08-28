using DentalNation.source;
using DentalNation.source.libs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalNation
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Logger.Init("DentalNation.log");
            Config.Init("Materials.txt");
            Storage.Init("localhost", "admin", "4444");

            //string pth = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            //Logger.Write(Level.DEBUG, "Path: " + pth);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new form_main());
        }
    }
}
