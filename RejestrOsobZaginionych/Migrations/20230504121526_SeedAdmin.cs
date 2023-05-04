using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RejestrOsobZaginionych.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05023c9f-cd49-4677-ab26-9f08fc707170");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2c088ff-55bf-4618-b463-3ece8da9e5b7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c51cb7b-0460-4663-98b5-4f4a7e225cf5", "1", "Admin", "ADMIN" },
                    { "cf1e50c9-74fb-4614-b547-ccbde7bd79ba", "1", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9852271c-4681-4816-885d-69e36175b5d8", 0, "658fe12b-2f05-4f3a-a328-158d398a9903", null, false, false, null, null, "ADMIN@ABC.COM", "AQAAAAIAAYagAAAAEOCMC+nhxHjaexJ9WOoND9Eiy5jR2CdAH3NU/oK/MMCjf7ENtKESvbKjqwMfBu2pmA==", null, false, "98d83a0a-b106-435c-b5c7-5f6879eb4aeb", false, "admin@abc.com" });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 70, new DateOnly(2006, 8, 17) });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 47, new DateOnly(2005, 8, 23) });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 15, new DateOnly(2013, 8, 2) });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 63, new DateOnly(2017, 2, 4) });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 57, new DateOnly(2017, 5, 6) });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 6,
                column: "MissingSince",
                value: new DateOnly(2013, 7, 21));

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 64, new DateOnly(2010, 8, 7) });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 46, new DateOnly(2005, 11, 1) });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 39, new DateOnly(2012, 7, 4) });

            migrationBuilder.UpdateData(
                table: "MissingPeople",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "MissingSince" },
                values: new object[] { 44, new DateOnly(2014, 6, 16) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0c51cb7b-0460-4663-98b5-4f4a7e225cf5", "9852271c-4681-4816-885d-69e36175b5d8" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf1e50c9-74fb-4614-b547-ccbde7bd79ba");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0c51cb7b-0460-4663-98b5-4f4a7e225cf5", "9852271c-4681-4816-885d-69e36175b5d8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c51cb7b-0460-4663-98b5-4f4a7e225cf5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9852271c-4681-4816-885d-69e36175b5d8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05023c9f-cd49-4677-ab26-9f08fc707170", "1", "Admin", "Admin" },
                    { "d2c088ff-55bf-4618-b463-3ece8da9e5b7", "1", "User", "User" }
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
                column: "MissingSince",
                value: new DateOnly(2012, 3, 2));

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
    }
}
