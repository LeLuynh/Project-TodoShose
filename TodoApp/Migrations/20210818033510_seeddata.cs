using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoApp.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TodoModel",
                columns: new[] { "Id", "Description", "IsComplete", "Name" },
                values: new object[,]
                {
                    { 1, "suitable for men and women", true, "Vanz" },
                    { 2, "suitable for men and women", false, "Convert" },
                    { 3, "suitable for men and women", false, "Nike" },
                    { 4, "suitable for men and women", true, "Biti" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TodoModel",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TodoModel",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TodoModel",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TodoModel",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
