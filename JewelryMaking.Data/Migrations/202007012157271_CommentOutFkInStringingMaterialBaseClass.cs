namespace JewelryMaking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CommentOutFkInStringingMaterialBaseClass : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StringingMaterials", "Location_LocationId", "dbo.Locations");
            DropForeignKey("dbo.StringingMaterials", "Source_SourceId", "dbo.Sources");
            DropIndex("dbo.StringingMaterials", new[] { "Location_LocationId" });
            DropIndex("dbo.StringingMaterials", new[] { "Source_SourceId" });
            DropColumn("dbo.StringingMaterials", "Location_LocationId");
            DropColumn("dbo.StringingMaterials", "Source_SourceId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StringingMaterials", "Source_SourceId", c => c.Int());
            AddColumn("dbo.StringingMaterials", "Location_LocationId", c => c.Int(nullable: false));
            CreateIndex("dbo.StringingMaterials", "Source_SourceId");
            CreateIndex("dbo.StringingMaterials", "Location_LocationId");
            AddForeignKey("dbo.StringingMaterials", "Source_SourceId", "dbo.Sources", "SourceId");
            AddForeignKey("dbo.StringingMaterials", "Location_LocationId", "dbo.Locations", "LocationId", cascadeDelete: true);
        }
    }
}
