using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RejestrOsobZaginionych.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05023c9f-cd49-4677-ab26-9f08fc707170", "1", "Admin", "ADMIN" },
                    { "d2c088ff-55bf-4618-b463-3ece8da9e5b7", "1", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 76, new DateOnly(2000, 5, 19) });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 59, new DateOnly(2007, 2, 13) });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 27, new DateOnly(2008, 5, 18) });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 41, new DateOnly(2019, 5, 22) });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 16, new DateOnly(2012, 2, 12) });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 75, new DateOnly(2012, 3, 2) });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 63, new DateOnly(2008, 1, 22) });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 77, new DateOnly(2012, 2, 23) });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 40, new DateOnly(2000, 8, 23) });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 37, new DateOnly(2000, 1, 7) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05023c9f-cd49-4677-ab26-9f08fc707170");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2c088ff-55bf-4618-b463-3ece8da9e5b7");

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 28, new DateOnly(2006, 9, 27) });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 77, new DateOnly(2011, 5, 20) });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 50, new DateOnly(2008, 2, 8) });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 68, new DateOnly(2007, 4, 9) });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 47, new DateOnly(2015, 5, 1) });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 23, new DateOnly(2019, 8, 25) });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 64, new DateOnly(2007, 11, 6) });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 50, new DateOnly(2017, 3, 15) });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 26, new DateOnly(2017, 9, 13) });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 72, new DateOnly(2009, 10, 12) });
        }
    }
}
