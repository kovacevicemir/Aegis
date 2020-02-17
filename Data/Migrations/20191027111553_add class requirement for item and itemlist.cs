using Microsoft.EntityFrameworkCore.Migrations;

namespace Aegis.Data.Migrations
{
    public partial class addclassrequirementforitemanditemlist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClassRequirement",
                table: "ItemList",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClassRequirement",
                table: "Item",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassRequirement",
                table: "ItemList");

            migrationBuilder.DropColumn(
                name: "ClassRequirement",
                table: "Item");
        }
    }
}
