using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApiGusApiRegonData.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "pagard");

            migrationBuilder.CreateTable(
                name: "DaneSzukajPodmioty",
                schema: "pagard",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),
                    UniqueIdentifierOfTheLoggedInUser = table.Column<string>(type: "varchar(512)", maxLength: 512, nullable: true),
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
                    DataUtworzenia = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DataModyfikacji = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaneSzukajPodmioty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DaneSzukajPodmiotyParametryWyszukiwania",
                schema: "pagard",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),
                    UniqueIdentifierOfTheLoggedInUser = table.Column<string>(type: "varchar(512)", maxLength: 512, nullable: true),
                    SHA512 = table.Column<string>(maxLength: 2147483647, nullable: true),
                    Regon = table.Column<string>(maxLength: 14, nullable: true),
                    Nip = table.Column<string>(maxLength: 10, nullable: true),
                    Krs = table.Column<string>(maxLength: 10, nullable: true),
                    Nipy = table.Column<string>(maxLength: 220, nullable: true),
                    Regony14zn = table.Column<string>(maxLength: 300, nullable: true),
                    Regony9zn = table.Column<string>(maxLength: 200, nullable: true),
                    Krsy = table.Column<string>(maxLength: 220, nullable: true),
                    DataUtworzenia = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DataModyfikacji = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaneSzukajPodmiotyParametryWyszukiwania", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyGmina",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "Gmina");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyKodPocztowy",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "KodPocztowy");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyMiejscowosc",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "Miejscowosc");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotySilosMiejscowoscPoczty",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "MiejscowoscPoczty");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyNazwa",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "Nazwa");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyNip",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "Nip");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyPowiat",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "Powiat");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyRegon",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "Regon");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotySilosID",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "SilosID");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyTyp",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "Typ");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyUlica",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "Ulica");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyUniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "UniqueIdentifierOfTheLoggedInUser");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyWojewodztwo",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "Wojewodztwo");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwaniaKrs",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                column: "Krs");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwaniaKrsy",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                column: "Krsy");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwaniaNip",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                column: "Nip");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwaniaNipy",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                column: "Nipy");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwaniaRegon",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                column: "Regon");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwaniaRegony14zn",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                column: "Regony14zn");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwaniaRegony9zn",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                column: "Regony9zn");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwaniaUniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                column: "UniqueIdentifierOfTheLoggedInUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DaneSzukajPodmioty",
                schema: "pagard");

            migrationBuilder.DropTable(
                name: "DaneSzukajPodmiotyParametryWyszukiwania",
                schema: "pagard");
        }
    }
}
