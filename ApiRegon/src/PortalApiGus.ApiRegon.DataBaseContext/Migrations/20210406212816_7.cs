using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApiGus.ApiRegon.DataBase.Migrations
{
    public partial class _7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "(newsequentialid())",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejPkd",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejPkd",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "(newsequentialid())",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "BIR11JednLokalnaOsPrawnejPkdMessageInspector",
                schema: "pagard",
                columns: table => new
                {
                    BIR11JednLokalnaOsPrawnejPkdId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MessageInspectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11JednLokalnaOsPrawnejPkdMessageInspector", x => new { x.BIR11JednLokalnaOsPrawnejPkdId, x.MessageInspectorId });
                    table.ForeignKey(
                        name: "FK_BIR11JednLokalnaOsPrawnejPkdMessageInspector_BIR11JednLokalnaOsPrawnejPkd_BIR11JednLokalnaOsPrawnejPkdId",
                        column: x => x.BIR11JednLokalnaOsPrawnejPkdId,
                        principalSchema: "pagard",
                        principalTable: "BIR11JednLokalnaOsPrawnejPkd",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BIR11JednLokalnaOsPrawnejPkdMessageInspector_MessageInspector_MessageInspectorId",
                        column: x => x.MessageInspectorId,
                        principalSchema: "pagard",
                        principalTable: "MessageInspector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BIR11OsFizycznaDaneOgolneMessageInspector",
                schema: "pagard",
                columns: table => new
                {
                    BIR11OsFizycznaDaneOgolneId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MessageInspectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11OsFizycznaDaneOgolneMessageInspector", x => new { x.BIR11OsFizycznaDaneOgolneId, x.MessageInspectorId });
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaDaneOgolneMessageInspector_BIR11OsFizycznaDaneOgolne_BIR11OsFizycznaDaneOgolneId",
                        column: x => x.BIR11OsFizycznaDaneOgolneId,
                        principalSchema: "pagard",
                        principalTable: "BIR11OsFizycznaDaneOgolne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaDaneOgolneMessageInspector_MessageInspector_MessageInspectorId",
                        column: x => x.MessageInspectorId,
                        principalSchema: "pagard",
                        principalTable: "MessageInspector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnejPkdMessageInspector_BIR11JednLokalnaOsPrawnejPkdId",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejPkdMessageInspector",
                column: "BIR11JednLokalnaOsPrawnejPkdId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnejPkdMessageInspector_MessageInspectorId",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejPkdMessageInspector",
                column: "MessageInspectorId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolneMessageInspector_BIR11OsFizycznaDaneOgolneId",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolneMessageInspector",
                column: "BIR11OsFizycznaDaneOgolneId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolneMessageInspector_MessageInspectorId",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolneMessageInspector",
                column: "MessageInspectorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BIR11JednLokalnaOsPrawnejPkdMessageInspector",
                schema: "pagard");

            migrationBuilder.DropTable(
                name: "BIR11OsFizycznaDaneOgolneMessageInspector",
                schema: "pagard");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "(newsequentialid())");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejPkd",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejPkd",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "(newsequentialid())");
        }
    }
}
