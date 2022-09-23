using Manage_WZ.View;
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
            //if (Setting.Default.FirstTime)
            //{
            //    ApplicationConfiguration.Initialize();
            //    Application.Run(new FirstWindow());
            //}
            //else
            //{
                ApplicationConfiguration.Initialize();
                Application.Run(new MenuWindow());
            //}           
        }
    }
}