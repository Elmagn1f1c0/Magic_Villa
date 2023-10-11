﻿using MagicVilla_VillaAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<LocalUser> LocalUsers { get; set; }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                    ImageUrl = "data:image/jpeg;base64,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",
                    Occupancy = 4,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = new DateTime(2000, 01, 01) 
                },
              new Villa
              {
                  Id = 2,
                  Name = "Premium Pool Villa",
                  Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                  ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTH6299-_Nhfev1MVpqmm4AZIHx5l3uaGGaJv6BJFf_Kg&s",
                  Occupancy = 4,
                  Rate = 300,
                  Sqft = 550,
                  Amenity = "",
                  CreatedDate = new DateTime(2000, 01, 01)
              },
              new Villa
              {
                  Id = 3,
                  Name = "Luxury Pool Villa",
                  Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                  ImageUrl = "data:image/jpeg;base64,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",
                  Occupancy = 4,
                  Rate = 400,
                  Sqft = 750,
                  Amenity = "",
                  CreatedDate = new DateTime(2000, 01, 01)
              },
              new Villa
              {
                  Id = 4,
                  Name = "Diamond Villa",
                  Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                  ImageUrl = "https://th.bing.com/th?id=OIP.JtrnGkUaV8mnoKmUlLU4bQHaEh&w=320&h=195&c=8&rs=1&qlt=90&o=6&pid=3.1&rm=2",
                  Occupancy = 4,
                  Rate = 550,
                  Sqft = 900,
                  Amenity = "",
                  CreatedDate = new DateTime(2000, 01, 01)
              },
              new Villa
              {
                  Id = 5,
                  Name = "Diamond Pool Villa",
                  Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                  ImageUrl = "https://th.bing.com/th?id=OIP.5cPRakAop6ITYq784MvCtQHaE7&w=306&h=204&c=8&rs=1&qlt=90&o=6&pid=3.1&rm=2",
                  Occupancy = 4,
                  Rate = 600,
                  Sqft = 1100,
                  Amenity = "",
                  CreatedDate = new DateTime(2000, 01, 01)
              });
        }
    }
}
