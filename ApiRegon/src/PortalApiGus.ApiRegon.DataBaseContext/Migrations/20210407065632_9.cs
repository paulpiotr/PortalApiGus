using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApiGus.ApiRegon.DataBase.Migrations
{
    public partial class _9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "(newsequentialid())",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "BIR11OsFizycznaDzialalnoscPozostalaMessageInspector",
                schema: "pagard",
                columns: table => new
                {
                    BIR11OsFizycznaDzialalnoscPozostalaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MessageInspectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11OsFizycznaDzialalnoscPozostalaMessageInspector", x => new { x.BIR11OsFizycznaDzialalnoscPozostalaId, x.MessageInspectorId });
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaDzialalnoscPozostalaMessageInspector_BIR11OsFizycznaDzialalnoscPozostala_BIR11OsFizycznaDzialalnoscPozostalaId",
                        column: x => x.BIR11OsFizycznaDzialalnoscPozostalaId,
                        principalSchema: "pagard",
                        principalTable: "BIR11OsFizycznaDzialalnoscPozostala",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaDzialalnoscPozostalaMessageInspector_MessageInspector_MessageInspectorId",
                        column: x => x.MessageInspectorId,
                        principalSchema: "pagard",
                        principalTable: "MessageInspector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostalaMessageInspector_BIR11OsFizycznaDzialalnoscPozostalaId",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostalaMessageInspector",
                column: "BIR11OsFizycznaDzialalnoscPozostalaId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostalaMessageInspector_MessageInspectorId",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostalaMessageInspector",
                column: "MessageInspectorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BIR11OsFizycznaDzialalnoscPozostalaMessageInspector",
                schema: "pagard");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "(newsequentialid())");
        }
    }
}
