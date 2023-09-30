using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnglishDictTester.Data.Migrations
{
    public partial class EditTestsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "bgId",
                table: "Tests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "enId",
                table: "Tests",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bgId",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "enId",
                table: "Tests");
        }
    }
}
