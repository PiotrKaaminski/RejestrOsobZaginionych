using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RejestrOsobZaginionych.Migrations
{
    /// <inheritdoc />
    public partial class LinkMissingPersonToCreator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "CreatorId",
                table: "MissingPeople",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c51cb7b-0460-4663-98b5-4f4a7e225cf5",
                column: "NormalizedName",
                value: "ADMIN");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf1e50c9-74fb-4614-b547-ccbde7bd79ba",
                column: "NormalizedName",
                value: "USER");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9852271c-4681-4816-885d-69e36175b5d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de937289-5d7e-473e-af74-e28e46a9b9a9", "AQAAAAIAAYagAAAAED6E8MelhOo0sriViTdh4cHovDGvgW6/P/mJ2VKQGQfAqtkRrr+MkEkMnGLS0yHlag==", "a762a0ce-2819-4525-8fa9-c343a8737c87" });

            migrationBuilder.CreateIndex(
                name: "IX_MissingPeople_CreatorId",
                table: "MissingPeople",
                column: "CreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_MissingPeople_AspNetUsers_CreatorId",
                table: "MissingPeople",
                column: "CreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MissingPeople_AspNetUsers_CreatorId",
                table: "MissingPeople");

            migrationBuilder.DropIndex(
                name: "IX_MissingPeople_CreatorId",
                table: "MissingPeople");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "MissingPeople");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c51cb7b-0460-4663-98b5-4f4a7e225cf5",
                column: "NormalizedName",
                value: "Admin");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf1e50c9-74fb-4614-b547-ccbde7bd79ba",
                column: "NormalizedName",
                value: "User");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9852271c-4681-4816-885d-69e36175b5d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "658fe12b-2f05-4f3a-a328-158d398a9903", "AQAAAAIAAYagAAAAEOCMC+nhxHjaexJ9WOoND9Eiy5jR2CdAH3NU/oK/MMCjf7ENtKESvbKjqwMfBu2pmA==", "98d83a0a-b106-435c-b5c7-5f6879eb4aeb" });

            migrationBuilder.InsertData(
                table: "MissingPeople",
                columns: new[] { "Id", "Age", "FirstName", "ImagePath", "LastName", "Location", "MissingSince" },
                values: new object[,]
                {
                    { 1, 70, "firstName 0", null, "lastName 0", "Warszawa", new DateOnly(2006, 8, 17) },
                    { 2, 47, "firstName 1", null, "lastName 1", "Warszawa", new DateOnly(2005, 8, 23) },
                    { 3, 15, "firstName 2", null, "lastName 2", "Warszawa", new DateOnly(2013, 8, 2) },
                    { 4, 63, "firstName 3", null, "lastName 3", "Warszawa", new DateOnly(2017, 2, 4) },
                    { 5, 57, "firstName 4", null, "lastName 4", "Warszawa", new DateOnly(2017, 5, 6) },
                    { 6, 75, "firstName 5", null, "lastName 5", "Warszawa", new DateOnly(2013, 7, 21) },
                    { 7, 64, "firstName 6", null, "lastName 6", "Warszawa", new DateOnly(2010, 8, 7) },
                    { 8, 46, "firstName 7", null, "lastName 7", "Warszawa", new DateOnly(2005, 11, 1) },
                    { 9, 39, "firstName 8", null, "lastName 8", "Warszawa", new DateOnly(2012, 7, 4) },
                    { 10, 44, "firstName 9", null, "lastName 9", "Warszawa", new DateOnly(2014, 6, 16) }
                });
        }
    }
}
