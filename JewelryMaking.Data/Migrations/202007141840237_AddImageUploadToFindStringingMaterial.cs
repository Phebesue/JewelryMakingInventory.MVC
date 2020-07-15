namespace JewelryMaking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImageUploadToFindStringingMaterial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Findings", "File", c => c.Binary());
            AddColumn("dbo.StringingMaterials", "File", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.StringingMaterials", "File");
            DropColumn("dbo.Findings", "File");
        }
    }
}
