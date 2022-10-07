using Manage_WZ.Model;
using Manage_WZ.View;
using Manage_WZ.View.SmallView;
using Setting = Manage_WZ.Properties.Settings;
namespace Manage_WZ
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MenuWindow());
        }
    }
}