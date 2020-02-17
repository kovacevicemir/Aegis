using Microsoft.EntityFrameworkCore.Migrations;

namespace Aegis.Data.Migrations
{
    public partial class guildIdaddedtoplayermodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GuildId",
                table: "PlayerModel",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GuildId",
                table: "PlayerModel");
        }
    }
}
