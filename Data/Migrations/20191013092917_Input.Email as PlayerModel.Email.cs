using Microsoft.EntityFrameworkCore.Migrations;

namespace Aegis.Data.Migrations
{
    public partial class InputEmailasPlayerModelEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "PlayerModel",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "PlayerModel");
        }
    }
}
