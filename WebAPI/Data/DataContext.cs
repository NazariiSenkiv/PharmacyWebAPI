using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using WebAPI.Seed;

namespace WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.SeedMedicine();
        }

        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<AvailableMedicine> AvailableMedicines { get; set; }
    }
}
