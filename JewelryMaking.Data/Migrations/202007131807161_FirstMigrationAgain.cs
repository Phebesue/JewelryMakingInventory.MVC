namespace JewelryMaking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigrationAgain : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Beads",
                c => new
                    {
                        BeadId = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        Type = c.String(),
                        SubType = c.String(),
                        Shape = c.String(nullable: false),
                        Size = c.String(),
                        Color = c.String(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Cost = c.Double(nullable: false),
                        LocationId = c.Int(nullable: false),
                        SourceId = c.Int(),
                        Description = c.String(),
                        Image = c.Binary(),
                    })
                .PrimaryKey(t => t.BeadId)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .ForeignKey("dbo.Sources", t => t.SourceId)
                .Index(t => t.LocationId)
                .Index(t => t.SourceId);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        LocationId = c.Int(nullable: false, identity: true),
                        Kind = c.String(nullable: false),
                        Size = c.String(),
                        Color = c.String(),
                        Place = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.LocationId);
            
            CreateTable(
                "dbo.Sources",
                c => new
                    {
                        SourceId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        WebSite = c.String(),
                        ShowOrLocation = c.String(nullable: false, maxLength: 200),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(maxLength: 10),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.SourceId);
            
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
            
            CreateTable(
                "dbo.Findings",
                c => new
                    {
                        FindingId = c.Int(nullable: false, identity: true),
                        Category = c.String(nullable: false),
                        SubType = c.String(),
                        Size = c.String(),
                        Color = c.String(),
                        Association = c.String(),
                        Quantity = c.Int(nullable: false),
                        Cost = c.Double(nullable: false),
                        LocationId = c.Int(nullable: false),
                        SourceId = c.Int(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.FindingId)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .ForeignKey("dbo.Sources", t => t.SourceId)
                .Index(t => t.LocationId)
                .Index(t => t.SourceId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.StringingMaterials",
                c => new
                    {
                        StringingMaterialId = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false),
                        Material = c.String(nullable: false),
                        Size = c.Double(nullable: false),
                        Color = c.String(),
                        Length = c.Double(nullable: false),
                        Cost = c.Double(nullable: false),
                        LocationId = c.Int(nullable: false),
                        SourceId = c.Int(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.StringingMaterialId)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .ForeignKey("dbo.Sources", t => t.SourceId)
                .Index(t => t.LocationId)
                .Index(t => t.SourceId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.StringingMaterials", "SourceId", "dbo.Sources");
            DropForeignKey("dbo.StringingMaterials", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Findings", "SourceId", "dbo.Sources");
            DropForeignKey("dbo.Findings", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.Files", "FileId", "dbo.Beads");
            DropForeignKey("dbo.Beads", "SourceId", "dbo.Sources");
            DropForeignKey("dbo.Beads", "LocationId", "dbo.Locations");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.StringingMaterials", new[] { "SourceId" });
            DropIndex("dbo.StringingMaterials", new[] { "LocationId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Findings", new[] { "SourceId" });
            DropIndex("dbo.Findings", new[] { "LocationId" });
            DropIndex("dbo.Files", new[] { "FileId" });
            DropIndex("dbo.Beads", new[] { "SourceId" });
            DropIndex("dbo.Beads", new[] { "LocationId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.StringingMaterials");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Findings");
            DropTable("dbo.Files");
            DropTable("dbo.Sources");
            DropTable("dbo.Locations");
            DropTable("dbo.Beads");
        }
    }
}
