using Microsoft.EntityFrameworkCore;

namespace HikeBookAPI.Models
{
    public class MyDbContext : DbContext
    {
            public DbSet<Hike> Hike { get; set; }

            public DbSet<Feature> Features { get; set; }
            public DbSet<Geometry> Geometries { get; set; }

            public DbSet<Properties> Properties { get; set; }

            public DbSet<Cordinates> Cordinates { get; set; }

            public DbSet<Tag> Tags { get; set; }

            //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            //{
            //    optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=DwarfWorkShop;Trusted_Connection=True;TrustServerCertificate=true");
            //}
        
    }
}
