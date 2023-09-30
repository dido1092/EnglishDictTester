using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnglishDictTester.Data.Migrations
{
    public partial class NewTableTests_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    testId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    languageName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    bgword = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    enword = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    answer = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.testId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tests");
        }
    }
}
