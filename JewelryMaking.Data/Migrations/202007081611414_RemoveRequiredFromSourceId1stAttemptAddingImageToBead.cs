namespace JewelryMaking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveRequiredFromSourceId1stAttemptAddingImageToBead : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        FileId = c.Int(nullable: false),
                        FileName = c.String(),
                        ContentType = c.String(),
                        Image = c.Binary(),
                    })
                .PrimaryKey(t => t.FileId)
                .ForeignKey("dbo.Beads", t => t.FileId)
                .Index(t => t.FileId);
            
            AddColumn("dbo.Beads", "FileId", c => c.Int());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Files", "FileId", "dbo.Beads");
            DropIndex("dbo.Files", new[] { "FileId" });
            DropColumn("dbo.Beads", "FileId");
            DropTable("dbo.Files");
        }
    }
}
