using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnglishDictTester.Data.Migrations
{
    public partial class InTestNewColumnTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "test",
                table: "Tests",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "test",
                table: "Tests");
        }
    }
}
