using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JewelryMaking.Data
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public DbSet<File> Files { get; set; }
        //public DbSet<ImageFile> ImageFiles { get; set; }
        public DbSet<Source> Sources { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Bead> Beads { get; set; }
        public DbSet<StringingMaterial> StringingMaterials { get; set; }
        public DbSet<Finding> Findings { get; set; }

        //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //    {
        //        modelBuilder
        //            .Conventions
        //            .Remove<PluralizingTableNameConvention>();

        //        modelBuilder
        //            .Configurations
        //            .Add(new IdentityUserLoginConfiguration())
        //            .Add(new IdentityUserRoleConfiguration());
        //    }
        //}
        //public class IdentityUserLoginConfiguration : EntityTypeConfiguration<IdentityUserLogin>
        //{
        //    public IdentityUserLoginConfiguration()
        //    {
        //        HasKey(iul => iul.UserId);
        //    }
        //}
        //public class IdentityUserRoleConfiguration : EntityTypeConfiguration<IdentityUserRole>
        //{
        //    public IdentityUserRoleConfiguration()
        //    {
        //        HasKey(iur => iur.UserId);
        //    }
    }
}