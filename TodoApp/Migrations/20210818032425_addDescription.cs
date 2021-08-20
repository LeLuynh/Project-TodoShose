using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoApp.Migrations
{
    public partial class addDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Detail",
                table: "TodoModel",
                newName: "Description");

            migrationBuilder.AddColumn<bool>(
                name: "IsComplete",
                table: "TodoModel",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsComplete",
                table: "TodoModel");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "TodoModel",
                newName: "Detail");
        }
    }
}
