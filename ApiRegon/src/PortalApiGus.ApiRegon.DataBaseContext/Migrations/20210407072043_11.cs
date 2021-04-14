using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApiGus.ApiRegon.DataBase.Migrations
{
    public partial class _11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "(newsequentialid())",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector",
                schema: "pagard",
                columns: table => new
                {
                    BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MessageInspectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector", x => new { x.BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id, x.MessageInspectorId });
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_BIR11OsFizycznaD~",
                        column: x => x.BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id,
                        principalSchema: "pagard",
                        principalTable: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector_MessageInspector_MessageInspectorId",
                        column: x => x.MessageInspectorId,
                        principalSchema: "pagard",
                        principalTable: "MessageInspector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector",
                column: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector_MessageInspectorId",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector",
                column: "MessageInspectorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector",
                schema: "pagard");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "(newsequentialid())");
        }
    }
}
