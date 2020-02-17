﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Aegis.Data.Migrations
{
    public partial class addingguildleaderproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Leader",
                table: "Guild",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Leader",
                table: "Guild");
        }
    }
}
