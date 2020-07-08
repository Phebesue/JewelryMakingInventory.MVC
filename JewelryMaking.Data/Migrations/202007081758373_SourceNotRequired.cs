namespace JewelryMaking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SourceNotRequired : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Findings", "SourceId", "dbo.Sources");
            DropForeignKey("dbo.StringingMaterials", "SourceId", "dbo.Sources");
            DropIndex("dbo.Findings", new[] { "SourceId" });
            DropIndex("dbo.StringingMaterials", new[] { "SourceId" });
            AlterColumn("dbo.Findings", "SourceId", c => c.Int());
            AlterColumn("dbo.StringingMaterials", "SourceId", c => c.Int());
            CreateIndex("dbo.Findings", "SourceId");
            CreateIndex("dbo.StringingMaterials", "SourceId");
            AddForeignKey("dbo.Findings", "SourceId", "dbo.Sources", "SourceId");
            AddForeignKey("dbo.StringingMaterials", "SourceId", "dbo.Sources", "SourceId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StringingMaterials", "SourceId", "dbo.Sources");
            DropForeignKey("dbo.Findings", "SourceId", "dbo.Sources");
            DropIndex("dbo.StringingMaterials", new[] { "SourceId" });
            DropIndex("dbo.Findings", new[] { "SourceId" });
            AlterColumn("dbo.StringingMaterials", "SourceId", c => c.Int(nullable: false));
            AlterColumn("dbo.Findings", "SourceId", c => c.Int(nullable: false));
            CreateIndex("dbo.StringingMaterials", "SourceId");
            CreateIndex("dbo.Findings", "SourceId");
            AddForeignKey("dbo.StringingMaterials", "SourceId", "dbo.Sources", "SourceId", cascadeDelete: true);
            AddForeignKey("dbo.Findings", "SourceId", "dbo.Sources", "SourceId", cascadeDelete: true);
        }
    }
}
