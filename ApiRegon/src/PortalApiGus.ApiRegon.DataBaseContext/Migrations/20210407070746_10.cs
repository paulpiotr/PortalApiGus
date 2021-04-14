using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApiGus.ApiRegon.DataBase.Migrations
{
    public partial class _10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "(newsequentialid())",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "BIR11OsFizycznaDzialalnoscRolniczaMessageInspector",
                schema: "pagard",
                columns: table => new
                {
                    BIR11OsFizycznaDzialalnoscRolniczaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MessageInspectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11OsFizycznaDzialalnoscRolniczaMessageInspector", x => new { x.BIR11OsFizycznaDzialalnoscRolniczaId, x.MessageInspectorId });
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaDzialalnoscRolniczaMessageInspector_BIR11OsFizycznaDzialalnoscRolnicza_BIR11OsFizycznaDzialalnoscRolniczaId",
                        column: x => x.BIR11OsFizycznaDzialalnoscRolniczaId,
                        principalSchema: "pagard",
                        principalTable: "BIR11OsFizycznaDzialalnoscRolnicza",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaDzialalnoscRolniczaMessageInspector_MessageInspector_MessageInspectorId",
                        column: x => x.MessageInspectorId,
                        principalSchema: "pagard",
                        principalTable: "MessageInspector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolniczaMessageInspector_BIR11OsFizycznaDzialalnoscRolniczaId",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolniczaMessageInspector",
                column: "BIR11OsFizycznaDzialalnoscRolniczaId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolniczaMessageInspector_MessageInspectorId",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolniczaMessageInspector",
                column: "MessageInspectorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BIR11OsFizycznaDzialalnoscRolniczaMessageInspector",
                schema: "pagard");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "(newsequentialid())");
        }
    }
}
