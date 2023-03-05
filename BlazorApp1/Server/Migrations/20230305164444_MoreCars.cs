using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    /// <inheritdoc />
    public partial class MoreCars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "Spooky", "https://s1.cdn.autoevolution.com/images/news/gallery/1966-dodge-a100-mystery-machine-has-proper-v8-power-cartoonish-as-they-get_1.jpg", "The Mystery Machine" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "Helped Woody get onto the moving van", "https://cdn.shopify.com/s/files/1/2278/2841/products/HOW-DIES-RETO-ASST-fyp68-2_1024x1024@2x.jpg?v=1592146087", "RC Car" });
        }
    }
}
