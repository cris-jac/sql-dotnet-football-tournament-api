using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    Position = table.Column<string>(type: "TEXT", nullable: false),
                    Starter = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Surname = table.Column<string>(type: "TEXT", nullable: false),
                    DocumentType = table.Column<string>(type: "TEXT", nullable: false),
                    DocumentNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 1, new DateTime(1987, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 12345678, "DNI", "Lionel", 10, "Delantero", true, "Messi" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 2, new DateTime(1992, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 98765432, "DNI", "Emiliano", 23, "Arquero", false, "Martinez" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 3, new DateTime(2001, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 13572468, "DNI", "Enzo", 24, "Mediocampista", true, "Fernandez" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 4, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 97532468, "DNI", "Gonzalo", 4, "Defensor", true, "Montiel" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
