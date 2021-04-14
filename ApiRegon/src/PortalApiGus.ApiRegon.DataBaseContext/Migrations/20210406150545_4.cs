using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApiGus.ApiRegon.DataBase.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "(newsequentialid())",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "BIR11JednLokalnaOsFizycznejMessageInspector",
                schema: "pagard",
                columns: table => new
                {
                    BIR11JednLokalnaOsFizycznejId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MessageInspectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11JednLokalnaOsFizycznejMessageInspector", x => new { x.BIR11JednLokalnaOsFizycznejId, x.MessageInspectorId });
                    table.ForeignKey(
                        name: "FK_BIR11JednLokalnaOsFizycznejMessageInspector_BIR11JednLokalnaOsFizycznej_BIR11JednLokalnaOsFizycznejId",
                        column: x => x.BIR11JednLokalnaOsFizycznejId,
                        principalSchema: "pagard",
                        principalTable: "BIR11JednLokalnaOsFizycznej",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BIR11JednLokalnaOsFizycznejMessageInspector_MessageInspector_MessageInspectorId",
                        column: x => x.MessageInspectorId,
                        principalSchema: "pagard",
                        principalTable: "MessageInspector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznejMessageInspector_BIR11JednLokalnaOsFizycznejId",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejMessageInspector",
                column: "BIR11JednLokalnaOsFizycznejId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznejMessageInspector_MessageInspectorId",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejMessageInspector",
                column: "MessageInspectorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BIR11JednLokalnaOsFizycznejMessageInspector",
                schema: "pagard");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "(newsequentialid())");
        }
    }
}
