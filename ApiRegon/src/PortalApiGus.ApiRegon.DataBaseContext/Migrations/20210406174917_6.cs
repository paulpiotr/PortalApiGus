using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApiGus.ApiRegon.DataBase.Migrations
{
    public partial class _6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "(newsequentialid())",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "BIR11JednLokalnaOsPrawnejMessageInspector",
                schema: "pagard",
                columns: table => new
                {
                    BIR11JednLokalnaOsPrawnejId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MessageInspectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11JednLokalnaOsPrawnejMessageInspector", x => new { x.BIR11JednLokalnaOsPrawnejId, x.MessageInspectorId });
                    table.ForeignKey(
                        name: "FK_BIR11JednLokalnaOsPrawnejMessageInspector_BIR11JednLokalnaOsPrawnej_BIR11JednLokalnaOsPrawnejId",
                        column: x => x.BIR11JednLokalnaOsPrawnejId,
                        principalSchema: "pagard",
                        principalTable: "BIR11JednLokalnaOsPrawnej",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BIR11JednLokalnaOsPrawnejMessageInspector_MessageInspector_MessageInspectorId",
                        column: x => x.MessageInspectorId,
                        principalSchema: "pagard",
                        principalTable: "MessageInspector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnejMessageInspector_BIR11JednLokalnaOsPrawnejId",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejMessageInspector",
                column: "BIR11JednLokalnaOsPrawnejId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnejMessageInspector_MessageInspectorId",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejMessageInspector",
                column: "MessageInspectorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BIR11JednLokalnaOsPrawnejMessageInspector",
                schema: "pagard");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "(newsequentialid())");
        }
    }
}
