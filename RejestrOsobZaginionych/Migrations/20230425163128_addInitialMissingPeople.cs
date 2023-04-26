using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RejestrOsobZaginionych.Migrations
{
    /// <inheritdoc />
    public partial class addInitialMissingPeople : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MissingPeople",
                columns: new[] { "Id", "Age", "FirstName", "ImagePath", "LastName", "Location", "MissingSince" },
                values: new object[,]
                {
                    { 1, 28, "firstName 0", null, "lastName 0", "Warszawa", new DateOnly(2006, 9, 27) },
                    { 2, 77, "firstName 1", null, "lastName 1", "Warszawa", new DateOnly(2011, 5, 20) },
                    { 3, 50, "firstName 2", null, "lastName 2", "Warszawa", new DateOnly(2008, 2, 8) },
                    { 4, 68, "firstName 3", null, "lastName 3", "Warszawa", new DateOnly(2007, 4, 9) },
                    { 5, 47, "firstName 4", null, "lastName 4", "Warszawa", new DateOnly(2015, 5, 1) },
                    { 6, 23, "firstName 5", null, "lastName 5", "Warszawa", new DateOnly(2019, 8, 25) },
                    { 7, 64, "firstName 6", null, "lastName 6", "Warszawa", new DateOnly(2007, 11, 6) },
                    { 8, 50, "firstName 7", null, "lastName 7", "Warszawa", new DateOnly(2017, 3, 15) },
                    { 9, 26, "firstName 8", null, "lastName 8", "Warszawa", new DateOnly(2017, 9, 13) },
                    { 10, 72, "firstName 9", null, "lastName 9", "Warszawa", new DateOnly(2009, 10, 12) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
