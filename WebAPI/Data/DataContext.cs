using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<AvailableMedicine> AvailableMedicines { get; set; }
    }
}
