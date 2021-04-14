using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApiGus.ApiRegon.DataBase.Migrations
{
    public partial class _16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11OsPrawnaPkd",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11OsPrawnaPkd",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "(newsequentialid())",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "BIR11OsPrawnaPkdMessageInspector",
                schema: "pagard",
                columns: table => new
                {
                    BIR11OsPrawnaPkdId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MessageInspectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11OsPrawnaPkdMessageInspector", x => new { x.BIR11OsPrawnaPkdId, x.MessageInspectorId });
                    table.ForeignKey(
                        name: "FK_BIR11OsPrawnaPkdMessageInspector_BIR11OsPrawnaPkd_BIR11OsPrawnaPkdId",
                        column: x => x.BIR11OsPrawnaPkdId,
                        principalSchema: "pagard",
                        principalTable: "BIR11OsPrawnaPkd",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BIR11OsPrawnaPkdMessageInspector_MessageInspector_MessageInspectorId",
                        column: x => x.MessageInspectorId,
                        principalSchema: "pagard",
                        principalTable: "MessageInspector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaPkdMessageInspector_BIR11OsPrawnaPkdId",
                schema: "pagard",
                table: "BIR11OsPrawnaPkdMessageInspector",
                column: "BIR11OsPrawnaPkdId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaPkdMessageInspector_MessageInspectorId",
                schema: "pagard",
                table: "BIR11OsPrawnaPkdMessageInspector",
                column: "MessageInspectorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BIR11OsPrawnaPkdMessageInspector",
                schema: "pagard");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11OsPrawnaPkd",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11OsPrawnaPkd",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "(newsequentialid())");
        }
    }
}
