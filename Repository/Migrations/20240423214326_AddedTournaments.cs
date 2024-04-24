using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class AddedTournaments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Club_Tournament_TournamentId",
                table: "Club");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Tournament_TournamentId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Standings_Tournament_TournamentId",
                table: "Standings");

            migrationBuilder.DropForeignKey(
                name: "FK_Tournament_Club_WinnerId",
                table: "Tournament");

            migrationBuilder.DropIndex(
                name: "IX_Standings_TournamentId",
                table: "Standings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tournament",
                table: "Tournament");

            migrationBuilder.RenameTable(
                name: "Tournament",
                newName: "Tournaments");

            migrationBuilder.RenameIndex(
                name: "IX_Tournament_WinnerId",
                table: "Tournaments",
                newName: "IX_Tournaments_WinnerId");

            migrationBuilder.AlterColumn<int>(
                name: "WinnerId",
                table: "Tournaments",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tournaments",
                table: "Tournaments",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Standings_TournamentId",
                table: "Standings",
                column: "TournamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Club_Tournaments_TournamentId",
                table: "Club",
                column: "TournamentId",
                principalTable: "Tournaments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Tournaments_TournamentId",
                table: "Matches",
                column: "TournamentId",
                principalTable: "Tournaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Standings_Tournaments_TournamentId",
                table: "Standings",
                column: "TournamentId",
                principalTable: "Tournaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tournaments_Club_WinnerId",
                table: "Tournaments",
                column: "WinnerId",
                principalTable: "Club",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Club_Tournaments_TournamentId",
                table: "Club");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Tournaments_TournamentId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Standings_Tournaments_TournamentId",
                table: "Standings");

            migrationBuilder.DropForeignKey(
                name: "FK_Tournaments_Club_WinnerId",
                table: "Tournaments");

            migrationBuilder.DropIndex(
                name: "IX_Standings_TournamentId",
                table: "Standings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tournaments",
                table: "Tournaments");

            migrationBuilder.RenameTable(
                name: "Tournaments",
                newName: "Tournament");

            migrationBuilder.RenameIndex(
                name: "IX_Tournaments_WinnerId",
                table: "Tournament",
                newName: "IX_Tournament_WinnerId");

            migrationBuilder.AlterColumn<int>(
                name: "WinnerId",
                table: "Tournament",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tournament",
                table: "Tournament",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Standings_TournamentId",
                table: "Standings",
                column: "TournamentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Club_Tournament_TournamentId",
                table: "Club",
                column: "TournamentId",
                principalTable: "Tournament",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Tournament_TournamentId",
                table: "Matches",
                column: "TournamentId",
                principalTable: "Tournament",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Standings_Tournament_TournamentId",
                table: "Standings",
                column: "TournamentId",
                principalTable: "Tournament",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tournament_Club_WinnerId",
                table: "Tournament",
                column: "WinnerId",
                principalTable: "Club",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
