using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PagesCRUD.Data.Migrations
{
    public partial class ModelsAndClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NavLink",
                columns: table => new
                {
                    NLId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NavLinkTitle = table.Column<string>(nullable: true),
                    PageId = table.Column<int>(nullable: false),
                    ParentLinkId = table.Column<int>(nullable: true), 
                    Position = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NavLink", x => x.NLId);
                    table.ForeignKey(
                        name: "FK_NavLink_Page_PageId",
                        column: x => x.PageId,
                        principalTable: "Page",
                        principalColumn: "PageID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NavLink_NavLink_ParentLinkId",
                        column: x => x.ParentLinkId,
                        principalTable: "NavLink",
                        principalColumn: "NLId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "RelatedPages",
                columns: table => new
                {
                    RowId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Page1PageID = table.Column<int>(nullable: true),
                    Page2PageID = table.Column<int>(nullable: true),
                    PageId1 = table.Column<int>(nullable: false),
                    PageId2 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedPages", x => x.RowId);
                    table.ForeignKey(
                        name: "FK_RelatedPages_Page_Page1PageID",
                        column: x => x.Page1PageID,
                        principalTable: "Page",
                        principalColumn: "PageID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RelatedPages_Page_Page2PageID",
                        column: x => x.Page2PageID,
                        principalTable: "Page",
                        principalColumn: "PageID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.AlterColumn<string>(
                name: "UrlName",
                table: "Page",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Page",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Page",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Page",
                nullable: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Page",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.CreateIndex(
                name: "IX_NavLink_PageId",
                table: "NavLink",
                column: "PageId");

            migrationBuilder.CreateIndex(
                name: "IX_NavLink_ParentLinkId",
                table: "NavLink",
                column: "ParentLinkId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedPages_Page1PageID",
                table: "RelatedPages",
                column: "Page1PageID");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedPages_Page2PageID",
                table: "RelatedPages",
                column: "Page2PageID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NavLink");

            migrationBuilder.DropTable(
                name: "RelatedPages");

            migrationBuilder.AlterColumn<string>(
                name: "UrlName",
                table: "Page",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Page",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Page",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Page",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddedDate",
                table: "Page",
                type: "datetime",
                nullable: true,
                defaultValueSql: "CURRENT_TIMESTAMP");
        }
    }
}
