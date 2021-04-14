using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApiGus.ApiRegon.DataBase.Migrations
{
    public partial class _12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "(newsequentialid())",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "BIR11OsFizycznaListaJednLokalnychMessageInspector",
                schema: "pagard",
                columns: table => new
                {
                    BIR11OsFizycznaListaJednLokalnychId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MessageInspectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11OsFizycznaListaJednLokalnychMessageInspector", x => new { x.BIR11OsFizycznaListaJednLokalnychId, x.MessageInspectorId });
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaListaJednLokalnychMessageInspector_BIR11OsFizycznaListaJednLokalnych_BIR11OsFizycznaListaJednLokalnychId",
                        column: x => x.BIR11OsFizycznaListaJednLokalnychId,
                        principalSchema: "pagard",
                        principalTable: "BIR11OsFizycznaListaJednLokalnych",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaListaJednLokalnychMessageInspector_MessageInspector_MessageInspectorId",
                        column: x => x.MessageInspectorId,
                        principalSchema: "pagard",
                        principalTable: "MessageInspector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnychMessageInspector_BIR11OsFizycznaListaJednLokalnychId",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnychMessageInspector",
                column: "BIR11OsFizycznaListaJednLokalnychId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnychMessageInspector_MessageInspectorId",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnychMessageInspector",
                column: "MessageInspectorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BIR11OsFizycznaListaJednLokalnychMessageInspector",
                schema: "pagard");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "(newsequentialid())");
        }
    }
}
