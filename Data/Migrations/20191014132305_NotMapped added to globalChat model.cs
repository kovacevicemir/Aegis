using Microsoft.EntityFrameworkCore.Migrations;

namespace Aegis.Data.Migrations
{
    public partial class NotMappedaddedtoglobalChatmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GlobalChat_PlayerModel_PlayerId",
                table: "GlobalChat");

            migrationBuilder.DropIndex(
                name: "IX_GlobalChat_PlayerId",
                table: "GlobalChat");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_GlobalChat_PlayerId",
                table: "GlobalChat",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalChat_PlayerModel_PlayerId",
                table: "GlobalChat",
                column: "PlayerId",
                principalTable: "PlayerModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
