#region using

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#endregion

namespace PortalApiGusApiRegonData.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                "pagard");

            migrationBuilder.CreateTable(
                "DaneSzukajPodmioty",
                schema: "pagard",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),
                    UniqueIdentifierOfTheLoggedInUser =
                        table.Column<string>("varchar(512)", maxLength: 512, nullable: true),
                    ParametryWyszukiwaniaSHA512 = table.Column<string>(maxLength: 2147483647, nullable: true),
                    ParametryWyszukiwaniaJson = table.Column<string>(maxLength: 2147483647, nullable: true),
                    Regon = table.Column<string>(maxLength: 14, nullable: true),
                    Nip = table.Column<string>(maxLength: 10, nullable: true),
                    StatusNip = table.Column<string>(maxLength: 12, nullable: true),
                    Nazwa = table.Column<string>(maxLength: 2000, nullable: true),
                    Wojewodztwo = table.Column<string>(maxLength: 200, nullable: true),
                    Powiat = table.Column<string>(maxLength: 200, nullable: true),
                    Gmina = table.Column<string>(maxLength: 200, nullable: true),
                    Miejscowosc = table.Column<string>(maxLength: 200, nullable: true),
                    KodPocztowy = table.Column<string>(maxLength: 12, nullable: true),
                    Ulica = table.Column<string>(maxLength: 200, nullable: true),
                    NrNieruchomosci = table.Column<string>(maxLength: 20, nullable: true),
                    NrLokalu = table.Column<string>(maxLength: 10, nullable: true),
                    Typ = table.Column<string>(maxLength: 2, nullable: true),
                    SilosID = table.Column<int>(nullable: true),
                    DataZakonczeniaDzialalnosci = table.Column<string>(maxLength: 10, nullable: true),
                    MiejscowoscPoczty = table.Column<string>(maxLength: 200, nullable: true),
                    DataUtworzenia =
                        table.Column<DateTime>("datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DataModyfikacji = table.Column<DateTime>("datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaneSzukajPodmioty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                "DaneSzukajPodmiotyParametryWyszukiwania",
                schema: "pagard",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),
                    UniqueIdentifierOfTheLoggedInUser =
                        table.Column<string>("varchar(512)", maxLength: 512, nullable: true),
                    SHA512 = table.Column<string>(maxLength: 2147483647, nullable: true),
                    Regon = table.Column<string>(maxLength: 14, nullable: true),
                    Nip = table.Column<string>(maxLength: 10, nullable: true),
                    Krs = table.Column<string>(maxLength: 10, nullable: true),
                    Nipy = table.Column<string>(maxLength: 220, nullable: true),
                    Regony14zn = table.Column<string>(maxLength: 300, nullable: true),
                    Regony9zn = table.Column<string>(maxLength: 200, nullable: true),
                    Krsy = table.Column<string>(maxLength: 220, nullable: true),
                    DataUtworzenia =
                        table.Column<DateTime>("datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DataModyfikacji = table.Column<DateTime>("datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaneSzukajPodmiotyParametryWyszukiwania", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                "IX_DaneSzukajPodmiotyGmina",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "Gmina");

            migrationBuilder.CreateIndex(
                "IX_DaneSzukajPodmiotyId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                "IX_DaneSzukajPodmiotyKodPocztowy",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "KodPocztowy");

            migrationBuilder.CreateIndex(
                "IX_DaneSzukajPodmiotyMiejscowosc",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "Miejscowosc");

            migrationBuilder.CreateIndex(
                "IX_DaneSzukajPodmiotySilosMiejscowoscPoczty",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "MiejscowoscPoczty");

            migrationBuilder.CreateIndex(
                "IX_DaneSzukajPodmiotyNazwa",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "Nazwa");

            migrationBuilder.CreateIndex(
                "IX_DaneSzukajPodmiotyNip",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "Nip");

            migrationBuilder.CreateIndex(
                "IX_DaneSzukajPodmiotyPowiat",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "Powiat");

            migrationBuilder.CreateIndex(
                "IX_DaneSzukajPodmiotyRegon",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "Regon");

            migrationBuilder.CreateIndex(
                "IX_DaneSzukajPodmiotySilosID",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "SilosID");

            migrationBuilder.CreateIndex(
                "IX_DaneSzukajPodmiotyTyp",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "Typ");

            migrationBuilder.CreateIndex(
                "IX_DaneSzukajPodmiotyUlica",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "Ulica");

            migrationBuilder.CreateIndex(
                "IX_DaneSzukajPodmiotyUniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "UniqueIdentifierOfTheLoggedInUser");

            migrationBuilder.CreateIndex(
                "IX_DaneSzukajPodmiotyWojewodztwo",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "Wojewodztwo");

            migrationBuilder.CreateIndex(
                "IX_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                "IX_DaneSzukajPodmiotyParametryWyszukiwaniaKrs",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                column: "Krs");

            migrationBuilder.CreateIndex(
                "IX_DaneSzukajPodmiotyParametryWyszukiwaniaKrsy",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                column: "Krsy");

            migrationBuilder.CreateIndex(
                "IX_DaneSzukajPodmiotyParametryWyszukiwaniaNip",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                column: "Nip");

            migrationBuilder.CreateIndex(
                "IX_DaneSzukajPodmiotyParametryWyszukiwaniaNipy",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                column: "Nipy");

            migrationBuilder.CreateIndex(
                "IX_DaneSzukajPodmiotyParametryWyszukiwaniaRegon",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                column: "Regon");

            migrationBuilder.CreateIndex(
                "IX_DaneSzukajPodmiotyParametryWyszukiwaniaRegony14zn",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                column: "Regony14zn");

            migrationBuilder.CreateIndex(
                "IX_DaneSzukajPodmiotyParametryWyszukiwaniaRegony9zn",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                column: "Regony9zn");

            migrationBuilder.CreateIndex(
                "IX_DaneSzukajPodmiotyParametryWyszukiwaniaUniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                column: "UniqueIdentifierOfTheLoggedInUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "DaneSzukajPodmioty",
                "pagard");

            migrationBuilder.DropTable(
                "DaneSzukajPodmiotyParametryWyszukiwania",
                "pagard");
        }
    }
}
