namespace JewelryMaking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImageToBead : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Beads", "File", c => c.Binary());
            DropColumn("dbo.Beads", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Beads", "Image", c => c.Binary());
            DropColumn("dbo.Beads", "File");
        }
    }
}