namespace JewelryMaking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Findings", "Location_LocationId", "dbo.Locations");
            DropIndex("dbo.Findings", new[] { "Location_LocationId" });
            AlterColumn("dbo.Findings", "Location_LocationId", c => c.Int());
            CreateIndex("dbo.Findings", "Location_LocationId");
            AddForeignKey("dbo.Findings", "Location_LocationId", "dbo.Locations", "LocationId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Findings", "Location_LocationId", "dbo.Locations");
            DropIndex("dbo.Findings", new[] { "Location_LocationId" });
            AlterColumn("dbo.Findings", "Location_LocationId", c => c.Int(nullable: false));
            CreateIndex("dbo.Findings", "Location_LocationId");
            AddForeignKey("dbo.Findings", "Location_LocationId", "dbo.Locations", "LocationId", cascadeDelete: true);
        }
    }
}
