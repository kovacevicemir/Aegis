using Microsoft.EntityFrameworkCore.Migrations;

namespace Aegis.Data.Migrations
{
    public partial class notificationvol3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IntValue",
                table: "Notification",
                newName: "InvValue2");

            migrationBuilder.AddColumn<int>(
                name: "IntValue1",
                table: "Notification",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IntValue1",
                table: "Notification");

            migrationBuilder.RenameColumn(
                name: "InvValue2",
                table: "Notification",
                newName: "IntValue");
        }
    }
}
