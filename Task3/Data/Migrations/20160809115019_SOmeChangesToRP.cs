using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PagesCRUD.Data.Migrations
{
    public partial class SOmeChangesToRP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RelatedPages_Page_Page1PageID",
                table: "RelatedPages");

            migrationBuilder.DropForeignKey(
                name: "FK_RelatedPages_Page_Page2PageID",
                table: "RelatedPages");

            migrationBuilder.DropIndex(
                name: "IX_RelatedPages_Page1PageID",
                table: "RelatedPages");

            migrationBuilder.DropIndex(
                name: "IX_RelatedPages_Page2PageID",
                table: "RelatedPages");

            migrationBuilder.DropColumn(
                name: "Page1PageID",
                table: "RelatedPages");

            migrationBuilder.DropColumn(
                name: "Page2PageID",
                table: "RelatedPages");

            migrationBuilder.DropColumn(
                name: "PageId1",
                table: "RelatedPages");

            migrationBuilder.DropColumn(
                name: "PageId2",
                table: "RelatedPages");

            migrationBuilder.AddColumn<int>(
                name: "FirstPageId",
                table: "RelatedPages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SecondPageId",
                table: "RelatedPages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RelatedPages_FirstPageId",
                table: "RelatedPages",
                column: "FirstPageId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedPages_SecondPageId",
                table: "RelatedPages",
                column: "SecondPageId");

            migrationBuilder.AddForeignKey(
                name: "FK_RelatedPages_Page_FirstPageId",
                table: "RelatedPages",
                column: "FirstPageId",
                principalTable: "Page",
                principalColumn: "PageID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_RelatedPages_Page_SecondPageId",
                table: "RelatedPages",
                column: "SecondPageId",
                principalTable: "Page",
                principalColumn: "PageID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RelatedPages_Page_FirstPageId",
                table: "RelatedPages");

            migrationBuilder.DropForeignKey(
                name: "FK_RelatedPages_Page_SecondPageId",
                table: "RelatedPages");

            migrationBuilder.DropIndex(
                name: "IX_RelatedPages_FirstPageId",
                table: "RelatedPages");

            migrationBuilder.DropIndex(
                name: "IX_RelatedPages_SecondPageId",
                table: "RelatedPages");

            migrationBuilder.DropColumn(
                name: "FirstPageId",
                table: "RelatedPages");

            migrationBuilder.DropColumn(
                name: "SecondPageId",
                table: "RelatedPages");

            migrationBuilder.AddColumn<int>(
                name: "Page1PageID",
                table: "RelatedPages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Page2PageID",
                table: "RelatedPages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PageId1",
                table: "RelatedPages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PageId2",
                table: "RelatedPages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RelatedPages_Page1PageID",
                table: "RelatedPages",
                column: "Page1PageID");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedPages_Page2PageID",
                table: "RelatedPages",
                column: "Page2PageID");

            migrationBuilder.AddForeignKey(
                name: "FK_RelatedPages_Page_Page1PageID",
                table: "RelatedPages",
                column: "Page1PageID",
                principalTable: "Page",
                principalColumn: "PageID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RelatedPages_Page_Page2PageID",
                table: "RelatedPages",
                column: "Page2PageID",
                principalTable: "Page",
                principalColumn: "PageID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
