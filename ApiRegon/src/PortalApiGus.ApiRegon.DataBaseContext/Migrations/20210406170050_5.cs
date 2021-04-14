using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApiGus.ApiRegon.DataBase.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkd",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkd",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "(newsequentialid())",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "BIR11JednLokalnaOsFizycznejPkdMessageInspector",
                schema: "pagard",
                columns: table => new
                {
                    BIR11JednLokalnaOsFizycznejPkdId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MessageInspectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11JednLokalnaOsFizycznejPkdMessageInspector", x => new { x.BIR11JednLokalnaOsFizycznejPkdId, x.MessageInspectorId });
                    table.ForeignKey(
                        name: "FK_BIR11JednLokalnaOsFizycznejPkdMessageInspector_BIR11JednLokalnaOsFizycznejPkd_BIR11JednLokalnaOsFizycznejPkdId",
                        column: x => x.BIR11JednLokalnaOsFizycznejPkdId,
                        principalSchema: "pagard",
                        principalTable: "BIR11JednLokalnaOsFizycznejPkd",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BIR11JednLokalnaOsFizycznejPkdMessageInspector_MessageInspector_MessageInspectorId",
                        column: x => x.MessageInspectorId,
                        principalSchema: "pagard",
                        principalTable: "MessageInspector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznejPkdMessageInspector_BIR11JednLokalnaOsFizycznejPkdId",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkdMessageInspector",
                column: "BIR11JednLokalnaOsFizycznejPkdId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznejPkdMessageInspector_MessageInspectorId",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkdMessageInspector",
                column: "MessageInspectorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BIR11JednLokalnaOsFizycznejPkdMessageInspector",
                schema: "pagard");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkd",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkd",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "(newsequentialid())");
        }
    }
}
