using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CIDM3312_finalProject_ThomasCrouch.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prisons",
                columns: table => new
                {
                    PrisonID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PrisonName = table.Column<string>(type: "TEXT", maxLength: 75, nullable: false),
                    PrisonAddress = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    WardenName = table.Column<string>(type: "TEXT", maxLength: 75, nullable: false),
                    GuardsEmployed = table.Column<int>(type: "INTEGER", nullable: false),
                    SecurityLevel = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    DateOpened = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prisons", x => x.PrisonID);
                });

            migrationBuilder.CreateTable(
                name: "Prisoners",
                columns: table => new
                {
                    PrisonerID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PrisonerName = table.Column<string>(type: "TEXT", maxLength: 75, nullable: false),
                    ConvictedCrimes = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    DateOfRelease = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PrisonID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prisoners", x => x.PrisonerID);
                    table.ForeignKey(
                        name: "FK_Prisoners_Prisons_PrisonID",
                        column: x => x.PrisonID,
                        principalTable: "Prisons",
                        principalColumn: "PrisonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prisoners_PrisonID",
                table: "Prisoners",
                column: "PrisonID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prisoners");

            migrationBuilder.DropTable(
                name: "Prisons");
        }
    }
}
