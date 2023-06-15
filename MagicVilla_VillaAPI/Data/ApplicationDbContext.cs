using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id=1,
                    Name="Royal Villa",
                    Details= "A serene place",
                    ImageUrl= "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRtDjXn-TtvGB3NfsqMcyyh7aPamXfhgtBxWc4NeyO_&s", 
                    Occupancy=5,
                    Rate=200,
                    Sqft=500,
                    Amenity="",
                    CreatedDate= DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Diamond Villa",
                    Details = "A serene place",
                    ImageUrl = "https://www.engelvoelkers.com/images/07e43544-9e5f-4571-ae73-7170dc2d6809/modern-villa-project-with-innovative-concept",
                    Occupancy = 7,
                    Rate = 250,
                    Sqft = 1500,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 3,
                    Name = "Silver Villa",
                    Details = "A serene place",
                    ImageUrl = "https://media.gettyimages.com/id/1283532082/photo/luxurious-beautiful-modern-villa-with-front-yard-garden-at-sunset.jpg?s=612x612&w=gi&k=20&c=8D3LTUjwmcCxXLDdFkZeCo-VOh9nVy4j1qBB1hdEihU=",
                    Occupancy = 3,
                    Rate = 700,
                    Sqft = 800,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 4,
                    Name = "Gold Villa",
                    Details = "A serene place",
                    ImageUrl = "https://assets-news.housing.com/news/wp-content/uploads/2022/02/27121904/featured-compressed-67.jpg",
                    Occupancy = 4,
                    Rate = 1200,
                    Sqft = 5100,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 5,
                    Name = "Diamond Pool Villa",
                    Details = "A serene place",
                    ImageUrl = "https://do84cgvgcm805.cloudfront.net/article/883/1200/12628bf5cf237d65658468c91ada6d7c397e4500483787773bce05857c4bd60e.jpg",
                    Occupancy = 9,
                    Rate = 230,
                    Sqft = 1500,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                });
        }
    }
}
