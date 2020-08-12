using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApiGusApiRegonData.Migrations
{
    public partial class M0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DaneSzukajPodmioty",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    MiejscowoscPoczty = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaneSzukajPodmioty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DaneSzukajPodmiotyParametryWyszukiwania",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Regon = table.Column<string>(maxLength: 14, nullable: true),
                    Nip = table.Column<string>(maxLength: 10, nullable: true),
                    Krs = table.Column<string>(maxLength: 10, nullable: true),
                    Nipy = table.Column<string>(maxLength: 220, nullable: true),
                    Regony14zn = table.Column<string>(maxLength: 300, nullable: true),
                    Regony9zn = table.Column<string>(maxLength: 200, nullable: true),
                    Krsy = table.Column<string>(maxLength: 220, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaneSzukajPodmiotyParametryWyszukiwania", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DaneSzukajPodmioty");

            migrationBuilder.DropTable(
                name: "DaneSzukajPodmiotyParametryWyszukiwania");
        }
    }
}
