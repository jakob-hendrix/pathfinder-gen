﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PathfinderIM.DataAccess.Migrations
{
    public partial class initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SourceBooks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookName = table.Column<string>(nullable: true),
                    License = table.Column<string>(nullable: true),
                    PageNumber = table.Column<int>(nullable: false),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SourceBooks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WondrousItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(nullable: true),
                    GoldPrice = table.Column<decimal>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Slot = table.Column<int>(nullable: false),
                    SourceId = table.Column<int>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WondrousItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WondrousItems_SourceBooks_SourceId",
                        column: x => x.SourceId,
                        principalTable: "SourceBooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WondrousItems_SourceId",
                table: "WondrousItems",
                column: "SourceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WondrousItems");

            migrationBuilder.DropTable(
                name: "SourceBooks");
        }
    }
}
