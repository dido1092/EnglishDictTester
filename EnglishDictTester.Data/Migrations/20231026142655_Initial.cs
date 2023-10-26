using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnglishDictTester.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    testId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lngName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    bgId = table.Column<int>(type: "int", nullable: true),
                    bgW = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    enId = table.Column<int>(type: "int", nullable: true),
                    enW = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    answer = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.testId);
                });

            migrationBuilder.CreateTable(
                name: "WordBgs",
                columns: table => new
                {
                    WordBgId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BgWord = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordBgs", x => x.WordBgId);
                });

            migrationBuilder.CreateTable(
                name: "WordEns",
                columns: table => new
                {
                    WordEnId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnWord = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Transcriptions = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordEns", x => x.WordEnId);
                });

            migrationBuilder.CreateTable(
                name: "WordsEnBgs",
                columns: table => new
                {
                    WordBgId = table.Column<int>(type: "int", nullable: false),
                    WordEnId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordsEnBgs", x => new { x.WordEnId, x.WordBgId });
                    table.ForeignKey(
                        name: "FK_WordsEnBgs_WordBgs_WordBgId",
                        column: x => x.WordBgId,
                        principalTable: "WordBgs",
                        principalColumn: "WordBgId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WordsEnBgs_WordEns_WordEnId",
                        column: x => x.WordEnId,
                        principalTable: "WordEns",
                        principalColumn: "WordEnId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WordsEnBgs_WordBgId",
                table: "WordsEnBgs",
                column: "WordBgId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "WordsEnBgs");

            migrationBuilder.DropTable(
                name: "WordBgs");

            migrationBuilder.DropTable(
                name: "WordEns");
        }
    }
}
