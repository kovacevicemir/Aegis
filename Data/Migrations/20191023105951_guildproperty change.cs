using Microsoft.EntityFrameworkCore.Migrations;

namespace Aegis.Data.Migrations
{
    public partial class guildpropertychange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GuildId",
                table: "PlayerModel");

            migrationBuilder.AddColumn<string>(
                name: "GuildName",
                table: "PlayerModel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GuildName",
                table: "PlayerModel");

            migrationBuilder.AddColumn<int>(
                name: "GuildId",
                table: "PlayerModel",
                nullable: false,
                defaultValue: 0);
        }
    }
}
