using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Server.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "book", "Standard cars", "standard" },
                    { 2, "camera-slr", "Cars film", "cars" },
                    { 3, "aperture", "Cars from movies", "movies" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 2, 26, 20, 1, 12, 689, DateTimeKind.Local).AddTicks(2399), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lotus Elise is available with a 1.8-litre, four-cylinder engine in two states of tune. The Sport 220 offers 217bhp, while the Cup 250 makes a stronger case for itself with 243bhp. Both have identical torque figures at 184lb ft, but the Cup 250 develops its pulling power lower down the rev range. Acceleration from 0-62mph takes 4.6 seconds and 4.3 seconds respectively, with the pair moving on to ample top speeds of 145mph and 150mph via the six-speed manual transmission. The Elise is also one of the few cars on the road with no power steering, which results in a fantastic accuracy and amount of feel through the wheel.", "https://www.topgear.com/sites/default/files/cars-car/carousel/2019/07/751a3478_0.jpg?w=892&h=502", false, false, 19.99m, 9.99m, "Lotus Elise" },
                    { 2, 2, new DateTime(2023, 2, 26, 20, 1, 12, 689, DateTimeKind.Local).AddTicks(2430), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lightning McQueen is a 2006 Custom-Built Piston Cup Racing stock car, with a top speed of 198mph, and accelerattion of 0-60 in 4 seconds. Lightning's body is built from 24-gauge Cold-rolled Sheet Steel, and chassis has a high strength tubular frame.", "https://images.squarespace-cdn.com/content/v1/5ae237043917eef6a6aeebce/1524780584779-3K5X1Q384A7QF4PA2UU4/IMG_0959.JPG?format=1000w", false, false, 195.95m, 95.95m, "Lightning McQueen" },
                    { 3, 2, new DateTime(2023, 2, 26, 20, 1, 12, 689, DateTimeKind.Local).AddTicks(2432), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Porche did good", "https://media.autoexpress.co.uk/image/private/s--8Hv5ZbZt--/v1661262351/evo/2022/08/Porsche%20911%20Sally%20Carrera%20Special%20Edition%20high%20res-2.jpg", false, false, 150m, 24.25m, "Sally Car" },
                    { 4, 3, new DateTime(2023, 2, 26, 20, 1, 12, 689, DateTimeKind.Local).AddTicks(2435), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Helped Woody get onto the moving van", "https://cdn.shopify.com/s/files/1/2278/2841/products/HOW-DIES-RETO-ASST-fyp68-2_1024x1024@2x.jpg?v=1592146087", false, false, 0.99m, 0.99m, "RC Car" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
