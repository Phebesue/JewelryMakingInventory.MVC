namespace JewelryMaking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AttemptToAddLocationIdToBead : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Beads", "LocationId", c => c.Int(nullable: true));
            CreateIndex("dbo.Beads", "LocationId");
            AddForeignKey("dbo.Beads", "LocationId", "dbo.Locations", "LocationId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Beads", "LocationId", "dbo.Locations");
            DropIndex("dbo.Beads", new[] { "LocationId" });
            DropColumn("dbo.Beads", "LocationId");
        }
    }
}
