namespace JewelryMaking.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AbandonImageForNowWorkOnSubtotal : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Beads", "FileId");
        }

        public override void Down()
        {
            AddColumn("dbo.Beads", "FileId", c => c.Int());
        }
    }
}
