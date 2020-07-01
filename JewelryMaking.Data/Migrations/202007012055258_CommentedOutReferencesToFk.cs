namespace JewelryMaking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CommentedOutReferencesToFk : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Beads", "Location_LocationId", "dbo.Locations");
            DropForeignKey("dbo.Beads", "Source_SourceId", "dbo.Sources");
            DropIndex("dbo.Beads", new[] { "Location_LocationId" });
            DropIndex("dbo.Beads", new[] { "Source_SourceId" });
            DropColumn("dbo.Beads", "Location_LocationId");
            DropColumn("dbo.Beads", "Source_SourceId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Beads", "Source_SourceId", c => c.Int());
            AddColumn("dbo.Beads", "Location_LocationId", c => c.Int(nullable: false));
            CreateIndex("dbo.Beads", "Source_SourceId");
            CreateIndex("dbo.Beads", "Location_LocationId");
            AddForeignKey("dbo.Beads", "Source_SourceId", "dbo.Sources", "SourceId");
            AddForeignKey("dbo.Beads", "Location_LocationId", "dbo.Locations", "LocationId", cascadeDelete: true);
        }
    }
}
