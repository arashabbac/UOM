using Microsoft.EntityFrameworkCore;
using UOM.Domain.Models.Dimensions;

namespace UOM.Persistence.EF
{
    public class UomContext : DbContext
    {
        public DbSet<Dimension> Dimensions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=.;initial catalog=UOM-DB;Integrated security=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UomContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
