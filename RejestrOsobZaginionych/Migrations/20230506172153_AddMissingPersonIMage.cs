using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RejestrOsobZaginionych.Migrations
{
    /// <inheritdoc />
    public partial class AddMissingPersonIMage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "MissingPeople");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "MissingPeople",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PersonImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    File = table.Column<byte[]>(type: "bytea", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonImages", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9852271c-4681-4816-885d-69e36175b5d8",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "896f04fd-768e-4a52-9bcf-c8c720bbe17a", "admin@abc.com", "ADMIN@ABC.COM", "AQAAAAIAAYagAAAAEJ59fiPtsa+jyQKsoeHHBJaGjebnLr3zU3KCH2DQOm7ZAbOggHJm+7ZnsHuZ+rMiWA==", "7e52a72a-c934-432c-9b40-f18d4ab8e88c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonImages");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "MissingPeople");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "MissingPeople",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9852271c-4681-4816-885d-69e36175b5d8",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "799bb33d-56ca-40f5-8937-988c3b231c80", null, null, "AQAAAAIAAYagAAAAEIsDu1ppobx8R+6H3+nSXJl68eTBlf0r16Wq9ym418qnFvtfyAf35ubtSQQBt6Plsw==", "131fbefb-1bfb-4cdf-bfcb-1500916dc5be" });
        }
    }
}
