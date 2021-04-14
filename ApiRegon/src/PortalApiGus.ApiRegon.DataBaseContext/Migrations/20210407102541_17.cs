using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApiGus.ApiRegon.DataBase.Migrations
{
    public partial class _17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "(newsequentialid())",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector",
                schema: "pagard",
                columns: table => new
                {
                    BIR11OsPrawnaSpCywilnaWspolnicyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MessageInspectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector", x => new { x.BIR11OsPrawnaSpCywilnaWspolnicyId, x.MessageInspectorId });
                    table.ForeignKey(
                        name: "FK_BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector_BIR11OsPrawnaSpCywilnaWspolnicy_BIR11OsPrawnaSpCywilnaWspolnicyId",
                        column: x => x.BIR11OsPrawnaSpCywilnaWspolnicyId,
                        principalSchema: "pagard",
                        principalTable: "BIR11OsPrawnaSpCywilnaWspolnicy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector_MessageInspector_MessageInspectorId",
                        column: x => x.MessageInspectorId,
                        principalSchema: "pagard",
                        principalTable: "MessageInspector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector_BIR11OsPrawnaSpCywilnaWspolnicyId",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector",
                column: "BIR11OsPrawnaSpCywilnaWspolnicyId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector_MessageInspectorId",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector",
                column: "MessageInspectorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector",
                schema: "pagard");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "(newsequentialid())");
        }
    }
}
