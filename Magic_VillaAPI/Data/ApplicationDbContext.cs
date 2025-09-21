using MagicVilla_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Magic_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    ID = 1,
                    Name = "Royals",
                    Details = "TEST kjhrjhh",
                    ImageUrl = "",
                    Occupancy = 5,
                    Rate = 200,
                    Amenity = "Pool",
                    CreatedDate = DateTime.Now

                },
                 new Villa()
                 {
                     ID = 2,
                     Name = "Royals 2",
                     Details = "TEST kjhrjhh",
                     ImageUrl = "",
                     Occupancy = 3,
                     Rate = 2000,
                     Amenity = "Pool",
                     CreatedDate = DateTime.Now

                 },
                  new Villa()
                  {
                      ID = 3,
                      Name = "Royals 3",
                      Details = "TEST kjhrjhh",
                      ImageUrl = "",
                      Occupancy = 50,
                      Rate = 20000,
                      Amenity = "Pool",
                      CreatedDate = DateTime.Now

                  },
                new Villa()
                {
                    ID = 4,
                    Name = "Royals 4",
                    Details = "TEST kjhrjhh",
                    ImageUrl = "",
                    Occupancy = 500,
                    Rate = 200000,
                    Amenity = "Pool",
                    CreatedDate = DateTime.Now

                },
                new Villa()
                {
                    ID = 5,
                    Name = "Royals 5",
                    Details = "TEST kjhrjhh",
                    ImageUrl = "",
                    Occupancy = 78,
                    Rate = 20099,
                    Amenity = "Pool",
                    CreatedDate = DateTime.Now

                });
        }
       
    }
}
