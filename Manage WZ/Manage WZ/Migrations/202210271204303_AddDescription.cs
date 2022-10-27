namespace Manage_WZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WzModels", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WzModels", "Description");
        }
    }
}
