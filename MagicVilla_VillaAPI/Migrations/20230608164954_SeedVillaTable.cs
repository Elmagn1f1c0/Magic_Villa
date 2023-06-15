using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVillaVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A serene place", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRtDjXn-TtvGB3NfsqMcyyh7aPamXfhgtBxWc4NeyO_&s", "Royal Villa", 5, 200.0, 500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A serene place", "https://www.engelvoelkers.com/images/07e43544-9e5f-4571-ae73-7170dc2d6809/modern-villa-project-with-innovative-concept", "Diamond Villa", 7, 250.0, 1500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A serene place", "https://media.gettyimages.com/id/1283532082/photo/luxurious-beautiful-modern-villa-with-front-yard-garden-at-sunset.jpg?s=612x612&w=gi&k=20&c=8D3LTUjwmcCxXLDdFkZeCo-VOh9nVy4j1qBB1hdEihU=", "Silver Villa", 3, 700.0, 800, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A serene place", "https://assets-news.housing.com/news/wp-content/uploads/2022/02/27121904/featured-compressed-67.jpg", "Gold Villa", 4, 1200.0, 5100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A serene place", "https://do84cgvgcm805.cloudfront.net/article/883/1200/12628bf5cf237d65658468c91ada6d7c397e4500483787773bce05857c4bd60e.jpg", "Diamond Pool Villa", 9, 230.0, 1500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
