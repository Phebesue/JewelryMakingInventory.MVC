namespace JewelryMaking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AttemptToAddLocationIdToFindingSM : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Findings", "Location_LocationId", "dbo.Locations");
            DropForeignKey("dbo.Findings", "Source_SourceId", "dbo.Sources");
            DropIndex("dbo.Findings", new[] { "Location_LocationId" });
            DropIndex("dbo.Findings", new[] { "Source_SourceId" });
            RenameColumn(table: "dbo.Findings", name: "Location_LocationId", newName: "LocationId");
            RenameColumn(table: "dbo.Findings", name: "Source_SourceId", newName: "SourceId");
            AddColumn("dbo.Beads", "SourceId", c => c.Int(nullable: true));
            AddColumn("dbo.StringingMaterials", "LocationId", c => c.Int(nullable: false));
            AddColumn("dbo.StringingMaterials", "SourceId", c => c.Int(nullable: true));
            AlterColumn("dbo.Findings", "LocationId", c => c.Int(nullable: false));
            AlterColumn("dbo.Findings", "SourceId", c => c.Int(nullable: true));
            CreateIndex("dbo.Beads", "SourceId");
            CreateIndex("dbo.Findings", "LocationId");
            CreateIndex("dbo.Findings", "SourceId");
            CreateIndex("dbo.StringingMaterials", "LocationId");
            CreateIndex("dbo.StringingMaterials", "SourceId");
            AddForeignKey("dbo.Beads", "SourceId", "dbo.Sources", "SourceId", cascadeDelete: true);
            AddForeignKey("dbo.StringingMaterials", "LocationId", "dbo.Locations", "LocationId", cascadeDelete: true);
            AddForeignKey("dbo.StringingMaterials", "SourceId", "dbo.Sources", "SourceId", cascadeDelete: true);
            AddForeignKey("dbo.Findings", "LocationId", "dbo.Locations", "LocationId", cascadeDelete: true);
            AddForeignKey("dbo.Findings", "SourceId", "dbo.Sources", "SourceId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Findings", "SourceId", "dbo.Sources");
            DropForeignKey("dbo.Findings", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.StringingMaterials", "SourceId", "dbo.Sources");
            DropForeignKey("dbo.StringingMaterials", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.Beads", "SourceId", "dbo.Sources");
            DropIndex("dbo.StringingMaterials", new[] { "SourceId" });
            DropIndex("dbo.StringingMaterials", new[] { "LocationId" });
            DropIndex("dbo.Findings", new[] { "SourceId" });
            DropIndex("dbo.Findings", new[] { "LocationId" });
            DropIndex("dbo.Beads", new[] { "SourceId" });
            AlterColumn("dbo.Findings", "SourceId", c => c.Int());
            AlterColumn("dbo.Findings", "LocationId", c => c.Int());
            DropColumn("dbo.StringingMaterials", "SourceId");
            DropColumn("dbo.StringingMaterials", "LocationId");
            DropColumn("dbo.Beads", "SourceId");
            RenameColumn(table: "dbo.Findings", name: "SourceId", newName: "Source_SourceId");
            RenameColumn(table: "dbo.Findings", name: "LocationId", newName: "Location_LocationId");
            CreateIndex("dbo.Findings", "Source_SourceId");
            CreateIndex("dbo.Findings", "Location_LocationId");
            AddForeignKey("dbo.Findings", "Source_SourceId", "dbo.Sources", "SourceId");
            AddForeignKey("dbo.Findings", "Location_LocationId", "dbo.Locations", "LocationId");
        }
    }
}
