using Manage_WZ.Model;
using Manage_WZ.Properties;
using Manage_WZ.View;
using Manage_WZ.View.SmallView;
using System.IO;
using System.Security.AccessControl;
using System.Security;
using Setting = Manage_WZ.Properties.Settings;
using System.Security.Principal;

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
            Setting.Default.DbPath = Application.StartupPath+ "DataBase\\";
            Setting.Default.Save();
            var sec = new DirectorySecurity();
            sec.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, AccessControlType.Allow));
            sec.CreateDirectory(Setting.Default.DbPath);
            ApplicationConfiguration.Initialize();
            Application.Run(new MenuWindow());
        }
    }
}