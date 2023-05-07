using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RejestrOsobZaginionych.Migrations
{
    /// <inheritdoc />
    public partial class AddSexToMissingPerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Male",
                table: "MissingPeople",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9852271c-4681-4816-885d-69e36175b5d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "799bb33d-56ca-40f5-8937-988c3b231c80", "AQAAAAIAAYagAAAAEIsDu1ppobx8R+6H3+nSXJl68eTBlf0r16Wq9ym418qnFvtfyAf35ubtSQQBt6Plsw==", "131fbefb-1bfb-4cdf-bfcb-1500916dc5be" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Male",
                table: "MissingPeople");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9852271c-4681-4816-885d-69e36175b5d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de937289-5d7e-473e-af74-e28e46a9b9a9", "AQAAAAIAAYagAAAAED6E8MelhOo0sriViTdh4cHovDGvgW6/P/mJ2VKQGQfAqtkRrr+MkEkMnGLS0yHlag==", "a762a0ce-2819-4525-8fa9-c343a8737c87" });
        }
    }
}
