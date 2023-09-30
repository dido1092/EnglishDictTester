using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnglishDictTester.Data.Migrations
{
    public partial class NewTableTests_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "languageName",
                table: "Tests",
                newName: "lngName");

            migrationBuilder.RenameColumn(
                name: "enword",
                table: "Tests",
                newName: "enW");

            migrationBuilder.RenameColumn(
                name: "bgword",
                table: "Tests",
                newName: "bgW");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lngName",
                table: "Tests",
                newName: "languageName");

            migrationBuilder.RenameColumn(
                name: "enW",
                table: "Tests",
                newName: "enword");

            migrationBuilder.RenameColumn(
                name: "bgW",
                table: "Tests",
                newName: "bgword");
        }
    }
}
