using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    /// <inheritdoc />
    public partial class CarDetailsUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Based on a 2002 Porsche 911 Carrera GTS, the most distinctive feature of the car is its “Sally Blue Metallic” exterior paint color, made exclusively for the one-of-one vehicle. Additional exclusive features of the Sally Special include a “Carrera” designation on the vehicle’s rear and a set of custom five-spoke 911 Turbo wheels inspired by those of the vehicle’s namesake.", "911 Sally Special" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "The Chevrolet Van was a series of vans introduced for the 1964 model year. The Chevrolet Van succeeded the Chevrolet Greenbrier, and was launched with the G-10 half-ton variant. A 'Sportvan' was later added to the range that included integrated windows. The first two generations of van were built with a front mid engine layout, but from 1971 onwards, the engine was a front mounted unit. A wide range of engines have been fitted to the Chevrolet Van, including inline four, V6, and V8 units. The Van was configurable for a variety of uses, including passenger, cargo, and bus versions. Production of the Chevrolet Van ended in 1995, and the model was replaced by the Chevrolet Express.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Porche did good", "Sally Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Spooky");
        }
    }
}
