using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class datamigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClubId",
                table: "Players",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Club",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    FoundationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Manager = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Club", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stadium",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    Capacity = table.Column<int>(type: "INTEGER", nullable: false),
                    ClubId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stadium", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stadium_Club_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Club",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Club",
                columns: new[] { "Id", "FoundationDate", "Manager", "Name" },
                values: new object[] { 1, new DateTime(1901, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marcelo Gallardo", "River Plate" });

            migrationBuilder.InsertData(
                table: "Club",
                columns: new[] { "Id", "FoundationDate", "Manager", "Name" },
                values: new object[] { 2, new DateTime(1905, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miguel Ángel Russo", "Boca Juniors" });

            migrationBuilder.InsertData(
                table: "Club",
                columns: new[] { "Id", "FoundationDate", "Manager", "Name" },
                values: new object[] { 3, new DateTime(1905, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Julio Falcioni", "Independiente" });

            migrationBuilder.InsertData(
                table: "Club",
                columns: new[] { "Id", "FoundationDate", "Manager", "Name" },
                values: new object[] { 4, new DateTime(1905, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eduardo Coudet", "Racing" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClubId", "DateOfBirth", "Name", "Number", "Position", "Surname" },
                values: new object[] { 1, new DateTime(1986, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Franco", 1, "Arquero", "Armani" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClubId", "DateOfBirth", "DocumentNumber", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 1, new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23456789, "Gonzalo", 4, "Defensor", true, "Montiel" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClubId", "DateOfBirth", "DocumentNumber", "Name", "Number", "Position", "Surname" },
                values: new object[] { 1, new DateTime(1983, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 34567890, "Javier", 22, "Defensor", "Pinola" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ClubId", "DateOfBirth", "DocumentNumber", "Name", "Number", "Surname" },
                values: new object[] { 1, new DateTime(1996, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 45678901, "Lucas", 29, "Martínez Quarta" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 5, 1, new DateTime(1988, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 56789012, "DNI", "Milton", 20, "Defensor", true, "Casco" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 6, 1, new DateTime(1998, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 67890123, "DNI", "Exequiel", 15, "Centrocampista", true, "Palacios" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 7, 1, new DateTime(1982, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 78901234, "DNI", "Leonardo", 23, "Centrocampista", true, "Ponzio" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 8, 1, new DateTime(1990, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 89012345, "DNI", "Ignacio", 26, "Centrocampista", true, "Fernández" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 9, 1, new DateTime(1995, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 90123456, "DNI", "Rafael", 19, "Delantero", true, "Santos Borré" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 10, 1, new DateTime(1988, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1234567, "DNI", "Lucas", 27, "Delantero", true, "Pratto" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 11, 1, new DateTime(1993, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 12345678, "DNI", "Juan Fernando", 8, "Centrocampista", true, "Quintero" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 12, 2, new DateTime(1995, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 12345678, "DNI", "Agustín", 1, "Arquero", true, "Rossi" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 13, 2, new DateTime(1991, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 23456789, "DNI", "Leonardo", 29, "Defensor", true, "Jara" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 14, 2, new DateTime(1989, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 34567890, "DNI", "Carlos", 24, "Defensor", true, "Izquierdoz" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 15, 2, new DateTime(1993, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 45678901, "DNI", "Lisandro", 6, "Defensor", true, "Magallán" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 16, 2, new DateTime(1989, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 56789012, "DNI", "Emmanuel", 3, "Defensor", true, "Mas" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 17, 2, new DateTime(1995, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 67890123, "DNI", "Nahitan", 15, "Centrocampista", true, "Nández" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 18, 2, new DateTime(1993, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 78901234, "DNI", "Wilmar", 16, "Centrocampista", true, "Barrios" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 19, 2, new DateTime(1985, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 89012345, "DNI", "Pablo", 8, "Centrocampista", true, "Pérez" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 20, 2, new DateTime(1996, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 90123456, "DNI", "Cristian", 7, "Delantero", true, "Pavón" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 21, 2, new DateTime(1989, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1234567, "DNI", "Ramón", 9, "Delantero", true, "Ábila" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 22, 2, new DateTime(1990, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 12345678, "DNI", "Darío", 9, "Delantero", true, "Benedetto" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 23, 3, new DateTime(1989, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 12345678, "DNI", "Martín", 1, "Arquero", true, "Campaña" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 24, 3, new DateTime(1996, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 23456789, "DNI", "Alan", 2, "Defensor", true, "Franco" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 25, 3, new DateTime(1992, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 34567890, "DNI", "Nicolás", 3, "Defensor", true, "Tagliafico" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 26, 3, new DateTime(1994, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 45678901, "DNI", "Gastón", 4, "Defensor", true, "Silva" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 27, 3, new DateTime(1996, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 56789012, "DNI", "Fabricio", 16, "Defensor", true, "Bustos" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 28, 3, new DateTime(1986, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 67890123, "DNI", "Pablo", 10, "Centrocampista", true, "Hernández" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 29, 3, new DateTime(1992, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 78901234, "DNI", "Maximiliano", 11, "Centrocampista", true, "Meza" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 30, 3, new DateTime(1999, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 89012345, "DNI", "Ezequiel", 20, "Centrocampista", true, "Barco" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 31, 3, new DateTime(1987, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 90123456, "DNI", "Emmanuel", 9, "Delantero", true, "Gigliotti" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 32, 3, new DateTime(1991, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1234567, "DNI", "Fernando", 15, "Centrocampista", true, "Gaibor" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 33, 3, new DateTime(1994, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 12345678, "DNI", "Martín", 8, "Centrocampista", true, "Benítez" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 34, 3, new DateTime(1989, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 12345678, "DNI", "Martín", 1, "Arquero", true, "Campaña" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 35, 3, new DateTime(1996, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 23456789, "DNI", "Alan", 2, "Defensor", true, "Franco" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 36, 3, new DateTime(1992, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 34567890, "DNI", "Nicolás", 3, "Defensor", true, "Tagliafico" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 37, 3, new DateTime(1994, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 45678901, "DNI", "Gastón", 4, "Defensor", true, "Silva" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 38, 3, new DateTime(1996, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 56789012, "DNI", "Fabricio", 16, "Defensor", true, "Bustos" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 39, 3, new DateTime(1986, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 67890123, "DNI", "Pablo", 10, "Centrocampista", true, "Hernández" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 40, 3, new DateTime(1992, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 78901234, "DNI", "Maximiliano", 11, "Centrocampista", true, "Meza" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 41, 3, new DateTime(1999, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 89012345, "DNI", "Ezequiel", 20, "Centrocampista", true, "Barco" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 42, 3, new DateTime(1987, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 90123456, "DNI", "Emmanuel", 9, "Delantero", true, "Gigliotti" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 43, 3, new DateTime(1991, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1234567, "DNI", "Fernando", 15, "Centrocampista", true, "Gaibor" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ClubId", "DateOfBirth", "DocumentNumber", "DocumentType", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { 44, 3, new DateTime(1994, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 12345678, "DNI", "Martín", 8, "Centrocampista", true, "Benítez" });

            migrationBuilder.InsertData(
                table: "Stadium",
                columns: new[] { "Id", "Capacity", "ClubId", "Location", "Name" },
                values: new object[] { 1, 86000, 1, "Buenos Aires", "Monumental" });

            migrationBuilder.InsertData(
                table: "Stadium",
                columns: new[] { "Id", "Capacity", "ClubId", "Location", "Name" },
                values: new object[] { 2, 57000, 2, "Buenos Aires", "La Bombonera" });

            migrationBuilder.InsertData(
                table: "Stadium",
                columns: new[] { "Id", "Capacity", "ClubId", "Location", "Name" },
                values: new object[] { 3, 48000, 3, "Avellaneda", "Libertadores de América" });

            migrationBuilder.InsertData(
                table: "Stadium",
                columns: new[] { "Id", "Capacity", "ClubId", "Location", "Name" },
                values: new object[] { 4, 53000, 4, "Avellaneda", "Presidente Perón" });

            migrationBuilder.CreateIndex(
                name: "IX_Players_ClubId",
                table: "Players",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Stadium_ClubId",
                table: "Stadium",
                column: "ClubId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Club_ClubId",
                table: "Players",
                column: "ClubId",
                principalTable: "Club",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Club_ClubId",
                table: "Players");

            migrationBuilder.DropTable(
                name: "Stadium");

            migrationBuilder.DropTable(
                name: "Club");

            migrationBuilder.DropIndex(
                name: "IX_Players_ClubId",
                table: "Players");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DropColumn(
                name: "ClubId",
                table: "Players");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "Name", "Number", "Position", "Surname" },
                values: new object[] { new DateTime(1987, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lionel", 10, "Delantero", "Messi" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "DocumentNumber", "Name", "Number", "Position", "Starter", "Surname" },
                values: new object[] { new DateTime(1992, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 98765432, "Emiliano", 23, "Arquero", false, "Martinez" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "DocumentNumber", "Name", "Number", "Position", "Surname" },
                values: new object[] { new DateTime(2001, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 13572468, "Enzo", 24, "Mediocampista", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "DocumentNumber", "Name", "Number", "Surname" },
                values: new object[] { new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 97532468, "Gonzalo", 4, "Montiel" });
        }
    }
}
