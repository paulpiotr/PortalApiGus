using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApiGus.ApiRegon.DataBase.Migrations
{
    public partial class _13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "(newsequentialid())",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "BIR11OsFizycznaPkdMessageInspector",
                schema: "pagard",
                columns: table => new
                {
                    BIR11OsFizycznaPkdId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MessageInspectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11OsFizycznaPkdMessageInspector", x => new { x.BIR11OsFizycznaPkdId, x.MessageInspectorId });
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaPkdMessageInspector_BIR11OsFizycznaPkd_BIR11OsFizycznaPkdId",
                        column: x => x.BIR11OsFizycznaPkdId,
                        principalSchema: "pagard",
                        principalTable: "BIR11OsFizycznaPkd",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaPkdMessageInspector_MessageInspector_MessageInspectorId",
                        column: x => x.MessageInspectorId,
                        principalSchema: "pagard",
                        principalTable: "MessageInspector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaPkdMessageInspector_BIR11OsFizycznaPkdId",
                schema: "pagard",
                table: "BIR11OsFizycznaPkdMessageInspector",
                column: "BIR11OsFizycznaPkdId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaPkdMessageInspector_MessageInspectorId",
                schema: "pagard",
                table: "BIR11OsFizycznaPkdMessageInspector",
                column: "MessageInspectorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BIR11OsFizycznaPkdMessageInspector",
                schema: "pagard");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "(newsequentialid())");
        }
    }
}
