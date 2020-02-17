using Microsoft.EntityFrameworkCore.Migrations;

namespace Aegis.Data.Migrations
{
    public partial class PlayerModelfixremovingforeignkeyforguild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerModel_Guild_GuildId",
                table: "PlayerModel");

            migrationBuilder.DropIndex(
                name: "IX_PlayerModel_GuildId",
                table: "PlayerModel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_PlayerModel_GuildId",
                table: "PlayerModel",
                column: "GuildId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerModel_Guild_GuildId",
                table: "PlayerModel",
                column: "GuildId",
                principalTable: "Guild",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
