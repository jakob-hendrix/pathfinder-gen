using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PathfinderIM.Data.Migrations
{
    public partial class SourceBookChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "License",
                table: "SourceBooks");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "SourceBooks");

            migrationBuilder.AddColumn<int>(
                name: "BookType",
                table: "SourceBooks",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookType",
                table: "SourceBooks");

            migrationBuilder.AddColumn<string>(
                name: "License",
                table: "SourceBooks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "SourceBooks",
                nullable: true);
        }
    }
}
