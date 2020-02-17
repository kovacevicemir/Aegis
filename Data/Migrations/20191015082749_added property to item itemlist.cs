using Microsoft.EntityFrameworkCore.Migrations;

namespace Aegis.Data.Migrations
{
    public partial class addedpropertytoitemitemlist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "ItemList",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "Item",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "ItemList");

            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Item");
        }
    }
}
