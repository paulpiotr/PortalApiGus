using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApiGus.ApiRegon.DataBase.Migrations
{
    public partial class _8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "(newsequentialid())",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "BIR11OsFizycznaDzialalnoscCeidgMessageInspector",
                schema: "pagard",
                columns: table => new
                {
                    BIR11OsFizycznaDzialalnoscCeidgId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MessageInspectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11OsFizycznaDzialalnoscCeidgMessageInspector", x => new { x.BIR11OsFizycznaDzialalnoscCeidgId, x.MessageInspectorId });
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaDzialalnoscCeidgMessageInspector_BIR11OsFizycznaDzialalnoscCeidg_BIR11OsFizycznaDzialalnoscCeidgId",
                        column: x => x.BIR11OsFizycznaDzialalnoscCeidgId,
                        principalSchema: "pagard",
                        principalTable: "BIR11OsFizycznaDzialalnoscCeidg",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaDzialalnoscCeidgMessageInspector_MessageInspector_MessageInspectorId",
                        column: x => x.MessageInspectorId,
                        principalSchema: "pagard",
                        principalTable: "MessageInspector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidgMessageInspector_BIR11OsFizycznaDzialalnoscCeidgId",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidgMessageInspector",
                column: "BIR11OsFizycznaDzialalnoscCeidgId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidgMessageInspector_MessageInspectorId",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidgMessageInspector",
                column: "MessageInspectorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BIR11OsFizycznaDzialalnoscCeidgMessageInspector",
                schema: "pagard");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "(newsequentialid())");
        }
    }
}
