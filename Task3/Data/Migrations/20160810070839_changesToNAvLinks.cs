using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PagesCRUD.Data.Migrations
{
    public partial class changesToNAvLinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NavLink_NavLink_ParentLinkId",
                table: "NavLink");

            migrationBuilder.DropIndex(
                name: "IX_NavLink_ParentLinkId",
                table: "NavLink");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_NavLink_ParentLinkId",
                table: "NavLink",
                column: "ParentLinkId");

            migrationBuilder.AddForeignKey(
                name: "FK_NavLink_NavLink_ParentLinkId",
                table: "NavLink",
                column: "ParentLinkId",
                principalTable: "NavLink",
                principalColumn: "NLId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
