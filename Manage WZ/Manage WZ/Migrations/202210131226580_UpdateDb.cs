namespace Manage_WZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WzModels", "NumberFv", c => c.String());
            AddColumn("dbo.WzModels", "dateWZ", c => c.DateTime(nullable: false));
            AddColumn("dbo.WzModels", "dateFZ", c => c.DateTime(nullable: false));
            AddColumn("dbo.WzModels", "dateDelivery", c => c.DateTime(nullable: false));
            AddColumn("dbo.WzModels", "type", c => c.Int(nullable: false));
            DropColumn("dbo.WzModels", "date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WzModels", "date", c => c.DateTime(nullable: false));
            DropColumn("dbo.WzModels", "type");
            DropColumn("dbo.WzModels", "dateDelivery");
            DropColumn("dbo.WzModels", "dateFZ");
            DropColumn("dbo.WzModels", "dateWZ");
            DropColumn("dbo.WzModels", "NumberFv");
        }
    }
}
