namespace Manage_WZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FirmModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WzModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumberWZ = c.String(),
                        FirmId = c.Int(nullable: false),
                        date = c.DateTime(nullable: false),
                        PdfFile = c.Binary(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FirmModels", t => t.FirmId, cascadeDelete: true)
                .Index(t => t.FirmId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WzModels", "FirmId", "dbo.FirmModels");
            DropIndex("dbo.WzModels", new[] { "FirmId" });
            DropTable("dbo.WzModels");
            DropTable("dbo.FirmModels");
        }
    }
}
