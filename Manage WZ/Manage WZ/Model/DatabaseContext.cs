using System.Data.Entity;
using Settings = Manage_WZ.Properties.Settings;

namespace Manage_WZ.Model
{
    internal class DatabaseContext :DbContext
    {
        public DatabaseContext() : base()
        {
            Database.Connection.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + Settings.Default.DbPath + Settings.Default.DbName + ";Integrated Security = True";
        }
        public DbSet<FirmModel> firms { get; set; }
        public DbSet<WzModel> Wzs { get; set; }
    }
}
