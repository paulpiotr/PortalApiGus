using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApiGus.ApiRegon.DataBase.Migrations
{
    public partial class _15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "(newsequentialid())",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "BIR11OsPrawnaListaJednLokalnychMessageInspector",
                schema: "pagard",
                columns: table => new
                {
                    BIR11OsPrawnaListaJednLokalnychId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MessageInspectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11OsPrawnaListaJednLokalnychMessageInspector", x => new { x.BIR11OsPrawnaListaJednLokalnychId, x.MessageInspectorId });
                    table.ForeignKey(
                        name: "FK_BIR11OsPrawnaListaJednLokalnychMessageInspector_BIR11OsPrawnaListaJednLokalnych_BIR11OsPrawnaListaJednLokalnychId",
                        column: x => x.BIR11OsPrawnaListaJednLokalnychId,
                        principalSchema: "pagard",
                        principalTable: "BIR11OsPrawnaListaJednLokalnych",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BIR11OsPrawnaListaJednLokalnychMessageInspector_MessageInspector_MessageInspectorId",
                        column: x => x.MessageInspectorId,
                        principalSchema: "pagard",
                        principalTable: "MessageInspector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnychMessageInspector_BIR11OsPrawnaListaJednLokalnychId",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnychMessageInspector",
                column: "BIR11OsPrawnaListaJednLokalnychId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnychMessageInspector_MessageInspectorId",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnychMessageInspector",
                column: "MessageInspectorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BIR11OsPrawnaListaJednLokalnychMessageInspector",
                schema: "pagard");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "(newsequentialid())");
        }
    }
}
