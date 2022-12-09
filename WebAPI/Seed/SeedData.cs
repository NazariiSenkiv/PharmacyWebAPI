using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Seed
{
    public static class SeedData
    {
        public static void SeedMedicine(this ModelBuilder builder)
        {
            builder.Entity<Medicine>().HasData(
                new Medicine()
                {
                    Id = 1,
                    Name = "SeededMed1",
                    Brand = "SBranD",
                    Category = "Universal",
                    Price = 1000,
                    ProductionYear = 2021
                },
                new Medicine()
                {
                    Id = 2,
                    Name = "ThroatMed",
                    Brand = "THm",
                    Category = "Throat",
                    Price = 30,
                    ProductionYear = 2022
                },
                new Medicine()
                {
                    Id = 3,
                    Name = "Paracetamol",
                    Brand = "P",
                    Category = "P",
                    Price = 100,
                    ProductionYear = 2020
                }
            );
        }
    }
}
