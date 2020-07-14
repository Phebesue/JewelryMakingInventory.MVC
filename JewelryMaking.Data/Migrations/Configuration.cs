namespace JewelryMaking.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<JewelryMaking.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(JewelryMaking.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Sources.AddOrUpdate(x => x.SourceId,
             new Source() { SourceId = 1, Name = "Joann Fabrics", WebSite = "www.joann.com", ShowOrLocation = "Greenwood", Address = " 1260 U.S. 31 N ", City = "Greenwood", State = "IN", ZipCode = "46142", Note = "" },
             new Source() { SourceId = 2, Name = "Joann Fabrics", WebSite = "www.joann.com", ShowOrLocation = "Mason", Address = "8125 Arbor Square Dr ", City = "Mason", State = "OH", ZipCode = "45040", Note = "" },
             new Source() { SourceId = 3, Name = "Michael's", WebSite = "www.michaels.com", ShowOrLocation = "Mason", Address = "9851 Waterstone Blvd", City = "Cincinnati", State = "OH", ZipCode = "45040", Note = "" },
             new Source() { SourceId = 4, Name = "Michael's", WebSite = "www.michaels.com", ShowOrLocation = "Greenwood", Address = "8030 US-31", City = "Indianapolis", State = "IN", ZipCode = "46227", Note = "" },
             new Source() { SourceId = 5, Name = "Small and Beautiful Beads", WebSite = "https://www.kazuriwest.com", ShowOrLocation = "Gem Street USA", Address = "13714 Barfield Drive", City = "Warren", State = "MI", ZipCode = "48088", Note = "Tamie Simpson, Email: tamiesimpson111@gmail.com, Phone: 810.919.4386, Now runs Kazuri West" },
             new Source() { SourceId = 6, Name = "Elka Designs", WebSite = "https://www.elka-designs.shoppingcartsplus.com/index.html", ShowOrLocation = "Gem Street USA", Address = "suite 101, 1098 S.Milwaukee Ave", City = "Wheeling", State = "IL", ZipCode = "60090", Note = "Jolanta, Phone Number: 847-387-2973, Email Address:  pljola7@comcast.net" },
             new Source() { SourceId = 7, Name = "Newtique Beads", WebSite = "", ShowOrLocation = "Gem Street USA", Address = "", City = "Kingsport", State = "TN", ZipCode = "", Note = "Zenda Conerly, Email: newtique@chartertn.net" },
             new Source() { SourceId = 8, Name = "Queen’s Beads", WebSite = "https://www.queensbeads.net/", ShowOrLocation = "Gem Street USA", Address = "1985 Lincoln Way", City = "White Oak", State = "PA", ZipCode = "15131", Note = "David and Karen Thomas, Phone number: 412-896-6966" },
             new Source() { SourceId = 9, Name = "The Silverlady II", WebSite = "http://www.silverlady2.com/", ShowOrLocation = "Gem Street USA", Address = "", City = "Cincinnati", State = "OH", ZipCode = "45242", Note = " Barbara Schulman, Phone number: 513.543.1241" },
             new Source() { SourceId = 10, Name = "Quest Crystals", WebSite = "", ShowOrLocation = "Gem Street USA", Address = "", City = "Warren", State = "OH", ZipCode = "", Note = "Ken Poore, Phone number = 330.360.6858" },
             new Source() { SourceId = 11, Name = "T & T Trading", WebSite = "http://tttbeads.com", ShowOrLocation = "Grand Ledge", Address = "1063 E Grand Ledge Hwy", City = "Grand Ledge", State = "MI", ZipCode = "48837", Note = " Tom and Theada Howard, Son = Dan, Email: Tom@tttbeads.com, Phone number: 517-627-2333" }
             );

            context.Locations.AddOrUpdate(x => x.LocationId,
                new Location() { LocationId = 1, Kind = "RolyKit", Size = "Large", Color = "Blue", Place = "Stack" },
                new Location() { LocationId = 2, Kind = "Rolykit", Size = "Large", Color = "Lt. Blue", Place = "Stack" },
                new Location() { LocationId = 3, Kind = "RolyKit", Size = "Large", Color = "Green", Place = "Stack" },
                new Location() { LocationId = 4, Kind = "Rolykit", Size = "Large", Color = "Gray", Place = "Stack" },
                new Location() { LocationId = 5, Kind = "RolyKit", Size = "Medium", Color = "Red", Place = "Stack" },
                new Location() { LocationId = 6, Kind = "Rolykit", Size = "Small", Color = "Green", Place = "Stack" },
                new Location() { LocationId = 7, Kind = "Cubbie", Size = "", Color = "Tan", Place = "Cubbie Middle Left(11)" },
                new Location() { LocationId = 8, Kind = "Purse", Size = "Large", Color = "Orange", Place = "Under Bed" },
                new Location() { LocationId = 9, Kind = "Trunk", Size = "Large", Color = "Tan", Place = "East Wall" },
                new Location() { LocationId = 10, Kind = "Utility Tote", Size = "Large", Color = " Purple Flowers", Place = "Under Bed" },
                new Location() { LocationId = 11, Kind = "Utility Tote", Size = "Large", Color = "Teal & Navy Flowers", Place = "Under Bed" },
                new Location() { LocationId = 12, Kind = "Case", Size = "", Color = "White", Place = "Cubbie Bottom Left(21)" },
                new Location() { LocationId = 13, Kind = "Purse", Size = "Large", Color = "Turquoise", Place = "Under Bed" },
                new Location() { LocationId = 14, Kind = "Purse", Size = "Large", Color = "Lime", Place = "Under Bed" }
                );

            context.Beads.AddOrUpdate(x => x.BeadId,
                new Bead() { BeadId = 1, Brand = "Kazuri", Type = "Clay", Shape = "Pita Pat", Size = "22 - 23mm", Color = "Black & White", Quantity = 3, Description = "Jambo S", Cost = 3.5, LocationId = 1, SourceId = 5 },
                new Bead() { BeadId = 2, Brand = "Kazuri", Type = "Clay", Shape = "Pita Pat", Size = "22 - 23mm", Color = "Blue & White", Quantity = 3, Description = "Jambo S", Cost = 3.5, LocationId = 1, SourceId = 5 },
                new Bead() { BeadId = 3, Brand = "Kazuri", Type = "Clay", Shape = "Pita Pat", Size = "22 - 23mm", Color = "Red & Yellow", Quantity = 5, Description = "Jambo S", Cost = 3.5, LocationId = 1, SourceId = 5 },
                new Bead() { BeadId = 4, Brand = "Kazuri", Type = "Clay", Shape = "Pita Pat", Size = "22 - 23mm", Color = "Black, Gray & White", Quantity = 3, Description = "Monet", Cost = 2.75, LocationId = 1, SourceId = 5 },
                new Bead() { BeadId = 5, Brand = "Kazuri", Type = "Clay", Shape = "Pita Pat", Size = "22 - 23mm", Color = "Black & White", Quantity = 3, Description = "Wavy", Cost = 3.5, LocationId = 1, SourceId = 5 },
                new Bead() { BeadId = 6, Brand = "Kazuri", Type = "Clay", Shape = "Pita Pat", Size = "22 - 23mm", Color = "Black & White", Quantity = 3, Description = "Dots", Cost = 3.5, LocationId = 1, SourceId = 5 },
                new Bead() { BeadId = 7, Brand = "", Type = "", Shape = "Round", Size = "12mm", Color = "White ", Quantity = 3, Description = "Opalescent", Cost = 0.0, LocationId = 7 },
                new Bead() { BeadId = 8, Brand = "Swarovski", Type = "Crystal", Shape = "Bicone", Size = "4mm", Color = "Blue", Quantity = 33, Description = "", Cost = 1, LocationId = 8, SourceId = 11 },
                new Bead() { BeadId = 9, Brand = "Swarovski", Type = "Crystal", Shape = "Bicone", Size = "4mm", Color = "Aqua", Quantity = 100, Description = "", Cost = 1, LocationId = 8, SourceId = 11 }
                );

            context.StringingMaterials.AddOrUpdate(x => x.StringingMaterialId,
                new StringingMaterial() { StringingMaterialId = 1, Type = "Cord", Material = "Leather", Size = 2, Color = "Black", Length = 1800, Cost = 0.13, Description = "", LocationId = 14, SourceId = 1 },
                new StringingMaterial() { StringingMaterialId = 2, Type = "Cord", Material = "Leather", Size = 2, Color = "Brown", Length = 1800, Cost = 0.13, Description = "", LocationId = 14, SourceId = 1 },
                new StringingMaterial() { StringingMaterialId = 3, Type = "Cord", Material = "Leather", Size = 2, Color = "Navy", Length = 180, Cost = 0.25, Description = "Weathered", LocationId = 14, SourceId = 8 },
                new StringingMaterial() { StringingMaterialId = 4, Type = "Cord", Material = "Leather", Size = 5, Color = "Black", Length = 120, Cost = 0.35, Description = "polished", LocationId = 14, SourceId = 8 },
                new StringingMaterial() { StringingMaterialId = 5, Type = "Cord", Material = "Leather", Size = 5, Color = "Aqua", Length = 24, Cost = 0.35, Description = "metallic", LocationId = 14, SourceId = 8 }
                );

            context.Findings.AddOrUpdate(x => x.FindingId,
                new Finding() { FindingId = 1, Category = "Clasp", SubType = "Magnetic", Size = "10mm", Color = "Silver Tone", Association = "Leather", Quantity = 10, Cost = 6, LocationId = 2, SourceId = 8 },
                new Finding() { FindingId = 2, Category = "Clasp", SubType = "Magnetic", Size = "10mm", Color = "Brass Tone", Association = "Leather", Quantity = 6, Cost = 6, LocationId = 2, SourceId = 8 },
                new Finding() { FindingId = 3, Category = "Clasp", SubType = "Magnetic", Size = "10mm", Color = "Copper Tone", Association = "Leather", Quantity = 5, Cost = 6, LocationId = 2, SourceId = 8 },
                new Finding() { FindingId = 4, Category = "Clasp", SubType = "Toggle", Size = "10mm", Color = "Silver Tone", Association = "Kumihimo", Quantity = 5, Cost = 6, LocationId = 2, SourceId = 2 },
                new Finding() { FindingId = 5, Category = "Clasp", SubType = "Lobster", Size = "6mm", Color = "Silver Tone", Association = "", Quantity = 10, Cost = 1.5, LocationId = 2, SourceId = 8 }
                );
        }
    }
}