using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApiGus.ApiRegon.DataBase.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SHA512",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania");

            migrationBuilder.DropColumn(
                name: "ParametryWyszukiwaniaJson",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropColumn(
                name: "ParametryWyszukiwaniaSHA512",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwaniaUniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                newName: "IX_DaneSzukajPodmiotyParametryWyszukiwania_UniqueIdentifierOfTheLoggedInUser");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwaniaRegony9zn",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                newName: "IX_DaneSzukajPodmiotyParametryWyszukiwania_Regony9zn");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwaniaRegony14zn",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                newName: "IX_DaneSzukajPodmiotyParametryWyszukiwania_Regony14zn");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwaniaRegon",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                newName: "IX_DaneSzukajPodmiotyParametryWyszukiwania_Regon");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwaniaNipy",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                newName: "IX_DaneSzukajPodmiotyParametryWyszukiwania_Nipy");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwaniaNip",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                newName: "IX_DaneSzukajPodmiotyParametryWyszukiwania_Nip");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwaniaKrsy",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                newName: "IX_DaneSzukajPodmiotyParametryWyszukiwania_Krsy");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwaniaKrs",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                newName: "IX_DaneSzukajPodmiotyParametryWyszukiwania_Krs");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                newName: "IX_DaneSzukajPodmiotyParametryWyszukiwania_Id");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyWojewodztwo",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmioty_Wojewodztwo");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyUniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmioty_UniqueIdentifierOfTheLoggedInUser");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyUlica",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmioty_Ulica");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyTyp",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmioty_Typ");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotySilosMiejscowoscPoczty",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmioty_MiejscowoscPoczty");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotySilosID",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmioty_SilosID");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyRegon",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmioty_Regon");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyPowiat",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmioty_Powiat");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyNip",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmioty_Nip");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyNazwa",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmioty_Nazwa");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyMiejscowosc",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmioty_Miejscowosc");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyKodPocztowy",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmioty_KodPocztowy");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmioty_Id");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyGmina",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmioty_Gmina");

            migrationBuilder.AlterColumn<string>(
                name: "UniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataUtworzenia",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataModyfikacji",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Wojewodztwo",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ulica",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Typ",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StatusNip",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Regon",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Powiat",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NrNieruchomosci",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NrLokalu",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nip",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nazwa",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MiejscowoscPoczty",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Miejscowosc",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KodPocztowy",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gmina",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataUtworzenia",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataModyfikacji",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BIR11JednLokalnaOsFizycznejId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BIR11JednLokalnaOsPrawnejId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BIR11OsFizycznaDaneOgolneId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BIR11OsFizycznaDzialalnoscCeidgId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BIR11OsFizycznaDzialalnoscPozostalaId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BIR11OsFizycznaDzialalnoscRolniczaId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BIR11OsPrawnaId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BIR11TypPodmiotuId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DaneSzukajPodmiotyKomunikatyOBledachId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DaneSzukajPodmiotyParametryWyszukiwaniaId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DaneSzukajPodmiotyKomunikatyOBledach",
                schema: "pagard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newsequentialid())"),
                    UniqueIdentifierOfTheLoggedInUser = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DataUtworzenia = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    DataModyfikacji = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ErrorCode = table.Column<int>(type: "int", nullable: true),
                    ErrorMessagePl = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    ErrorMessageEn = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    Regon = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    Nip = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Krs = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Nipy = table.Column<string>(type: "nvarchar(220)", maxLength: 220, nullable: true),
                    Regony14zn = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Regony9zn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Krsy = table.Column<string>(type: "nvarchar(220)", maxLength: 220, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaneSzukajPodmiotyKomunikatyOBledach", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MessageInspector",
                schema: "pagard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newsequentialid())"),
                    DataUtworzenia = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    DataModyfikacji = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UniqueIdentifierOfTheLoggedInUser = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    AfterReceiveReplyMessage = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    AfterReceiveReplyMessageAsStringXml = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    AfterReceiveReplyCorrelationState = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    BeforeSendRequestMessage = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    BeforeSendRequestMessageAsStringXml = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    BeforeSendRequestClientChannel = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageInspector", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BIR11JednLokalnaOsFizycznej",
                schema: "pagard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LokfizRegon14 = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    LokfizNazwa = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    LokfizSilosID = table.Column<int>(type: "int", nullable: false),
                    LokfizSilosNazwa = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokfizDataPowstania = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokfizDataRozpoczeciaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokfizDataWpisuDoRegon = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokfizDataZawieszeniaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokfizDataWznowieniaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokfizDataZaistnieniaZmiany = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokfizDataZakonczeniaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokfizDataSkresleniaZRegon = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokfizAdSiedzKrajSymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    LokfizAdSiedzWojewodztwoSymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    LokfizAdSiedzPowiatSymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    LokfizAdSiedzGminaSymbol = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    LokfizAdSiedzKodPocztowy = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    LokfizAdSiedzMiejscowoscPocztySymbol = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    LokfizAdSiedzMiejscowoscSymbol = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    LokfizAdSiedzUlicaSymbol = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    LokfizAdSiedzNumerNieruchomosci = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LokfizAdSiedzNumerLokalu = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokfizAdSiedzNietypoweMiejsceLokalizacji = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    LokfizAdSiedzKrajNazwa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LokfizAdSiedzWojewodztwoNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LokfizAdSiedzPowiatNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LokfizAdSiedzGminaNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LokfizAdSiedzMiejscowoscNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LokfizAdSiedzMiejscowoscPocztyNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LokfizAdSiedzUlicaNazwa = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    LokfizFormaFinansowaniaNazwa = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: false),
                    LokfizFormaFinansowaniaSymbol = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    LokfizDataWpisuDoRejestruEwidencji = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LokfizNumerwRejestrzeEwidencji = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LokfizOrganRejestrowySymbol = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    LokfizRodzajRejestruSymbol = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    LokfizOrganRejestrowyNazwa = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: false),
                    LokfizRodzajRejestruNazwa = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: false),
                    LokfizCNiePodjetoDzialalnosci = table.Column<bool>(type: "bit", nullable: false),
                    UniqueIdentifierOfTheLoggedInUser = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DateOfCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfModification = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PRegon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PNazwaRaportu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaneSzukajPodmiotyParametryWyszukiwaniaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DaneSzukajPodmiotyKomunikatyOBledachId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11JednLokalnaOsFizycznej", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BIR11JednLokalnaOsFizycznej_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId",
                        column: x => x.DaneSzukajPodmiotyKomunikatyOBledachId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyKomunikatyOBledach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIR11JednLokalnaOsFizycznej_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                        column: x => x.DaneSzukajPodmiotyParametryWyszukiwaniaId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyParametryWyszukiwania",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BIR11JednLokalnaOsFizycznejPkd",
                schema: "pagard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaneSzukajPodmiotyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LokfizPkdKod = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    LokfizPkdNazwa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LokfizPkdPrzewazajace = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    LokfizSilosSymbol = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UniqueIdentifierOfTheLoggedInUser = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DateOfCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfModification = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PRegon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PNazwaRaportu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaneSzukajPodmiotyParametryWyszukiwaniaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DaneSzukajPodmiotyKomunikatyOBledachId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11JednLokalnaOsFizycznejPkd", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BIR11JednLokalnaOsFizycznejPkd_DaneSzukajPodmioty_DaneSzukajPodmiotyId",
                        column: x => x.DaneSzukajPodmiotyId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmioty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIR11JednLokalnaOsFizycznejPkd_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId",
                        column: x => x.DaneSzukajPodmiotyKomunikatyOBledachId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyKomunikatyOBledach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIR11JednLokalnaOsFizycznejPkd_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                        column: x => x.DaneSzukajPodmiotyParametryWyszukiwaniaId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyParametryWyszukiwania",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BIR11JednLokalnaOsPrawnej",
                schema: "pagard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LokprawRegon14 = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    LokprawNazwa = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: false),
                    LokprawNumerWrejestrzeEwidencji = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LokprawDataWpisuDoRejestruEwidencji = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokprawDataPowstania = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokprawDataRozpoczeciaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokprawDataWpisuDoRegon = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokprawDataZawieszeniaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokprawDataWznowieniaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokprawDataZaistnieniaZmiany = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokprawDataZakonczeniaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokprawDataSkresleniaZRegon = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokprawAdSiedzKrajSymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    LokprawAdSiedzWojewodztwoSymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    LokprawAdSiedzPowiatSymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    LokprawAdSiedzGminaSymbol = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    LokprawAdSiedzKodPocztowy = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    LokprawAdSiedzMiejscowoscPocztySymbol = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    LokprawAdSiedzMiejscowoscSymbol = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    LokprawAdSiedzUlicaSymbol = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    LokprawAdSiedzNumerNieruchomosci = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LokprawAdSiedzNumerLokalu = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokprawAdSiedzNietypoweMiejsceLokalizacji = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: false),
                    LokprawAdSiedzKrajNazwa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LokprawAdSiedzWojewodztwoNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LokprawAdSiedzPowiatNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LokprawAdSiedzGminaNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LokprawAdSiedzMiejscowoscNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LokprawAdSiedzMiejscowoscPocztyNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LokprawAdSiedzUlicaNazwa = table.Column<string>(type: "nvarchar(351)", maxLength: 351, nullable: false),
                    LokprawFormaFinansowaniaSymbol = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    LokprawOrganRejestrowySymbol = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    LokprawRodzajRejestruEwidencjiSymbol = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    LokprawFormaFinansowaniaNazwa = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: false),
                    LokprawOrganRejestrowyNazwa = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: false),
                    LokprawRodzajRejestruEwidencjiNazwa = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: false),
                    UniqueIdentifierOfTheLoggedInUser = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DateOfCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfModification = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PRegon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PNazwaRaportu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaneSzukajPodmiotyParametryWyszukiwaniaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DaneSzukajPodmiotyKomunikatyOBledachId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11JednLokalnaOsPrawnej", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BIR11JednLokalnaOsPrawnej_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId",
                        column: x => x.DaneSzukajPodmiotyKomunikatyOBledachId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyKomunikatyOBledach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIR11JednLokalnaOsPrawnej_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                        column: x => x.DaneSzukajPodmiotyParametryWyszukiwaniaId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyParametryWyszukiwania",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BIR11JednLokalnaOsPrawnejPkd",
                schema: "pagard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaneSzukajPodmiotyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LokprawPkdKod = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    LokprawPkdNazwa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LokprawPkdPrzewazajace = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    UniqueIdentifierOfTheLoggedInUser = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DateOfCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfModification = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PRegon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PNazwaRaportu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaneSzukajPodmiotyParametryWyszukiwaniaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DaneSzukajPodmiotyKomunikatyOBledachId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11JednLokalnaOsPrawnejPkd", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BIR11JednLokalnaOsPrawnejPkd_DaneSzukajPodmioty_DaneSzukajPodmiotyId",
                        column: x => x.DaneSzukajPodmiotyId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmioty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIR11JednLokalnaOsPrawnejPkd_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId",
                        column: x => x.DaneSzukajPodmiotyKomunikatyOBledachId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyKomunikatyOBledach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIR11JednLokalnaOsPrawnejPkd_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                        column: x => x.DaneSzukajPodmiotyParametryWyszukiwaniaId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyParametryWyszukiwania",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BIR11OsFizycznaDaneOgolne",
                schema: "pagard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FizRegon9 = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    FizNip = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizStatusNip = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    FizNazwisko = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FizImie1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FizImie2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FizDataWpisuPodmiotuDoRegon = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataZaistnieniaZmiany = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataSkresleniaPodmiotuZRegon = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizPodstawowaFormaPrawnaSymbol = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    FizSzczegolnaFormaPrawnaSymbol = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    FizFormaFinansowaniaSymbol = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FizFormaWlasnosciSymbol = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FizPodstawowaFormaPrawnaNazwa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FizSzczegolnaFormaPrawnaNazwa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FizFormaFinansowaniaNazwa = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: false),
                    FizFormaWlasnosciNazwa = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: false),
                    FizDzialalnoscCeidg = table.Column<int>(type: "int", nullable: false),
                    FizDzialalnoscRolnicza = table.Column<int>(type: "int", nullable: false),
                    FizDzialalnoscPozostala = table.Column<int>(type: "int", nullable: false),
                    FizDzialalnoscSkreslonaDo20141108 = table.Column<int>(type: "int", nullable: false),
                    FizLiczbaJednLokalnych = table.Column<int>(type: "int", nullable: false),
                    UniqueIdentifierOfTheLoggedInUser = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DateOfCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfModification = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PRegon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PNazwaRaportu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaneSzukajPodmiotyParametryWyszukiwaniaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DaneSzukajPodmiotyKomunikatyOBledachId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11OsFizycznaDaneOgolne", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaDaneOgolne_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId",
                        column: x => x.DaneSzukajPodmiotyKomunikatyOBledachId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyKomunikatyOBledach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaDaneOgolne_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                        column: x => x.DaneSzukajPodmiotyParametryWyszukiwaniaId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyParametryWyszukiwania",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BIR11OsFizycznaDzialalnoscCeidg",
                schema: "pagard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FizRegon9 = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    FizNazwa = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    FizNazwaSkrocona = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    FizDataPowstania = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataRozpoczeciaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataWpisuDzialalnosciDoRegon = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataZawieszeniaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataWznowieniaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataZaistnieniaZmianyDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataZakonczeniaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataSkresleniaDzialalnosciZRegon = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataOrzeczeniaOUpadlosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataZakonczeniaPostepowaniaUpadlosciowego = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizAdSiedzKrajSymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    FizAdSiedzWojewodztwoSymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    FizAdSiedzPowiatSymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    FizAdSiedzGminaSymbol = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    FizAdSiedzKodPocztowy = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    FizAdSiedzMiejscowoscPocztySymbol = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    FizAdSiedzMiejscowoscSymbol = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    FizAdSiedzUlicaSymbol = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    FizAdSiedzNumerNieruchomosci = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FizAdSiedzNumerLokalu = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizAdSiedzNietypoweMiejsceLokalizacji = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: false),
                    FizNumerTelefonu = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FizNumerWewnetrznyTelefonu = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FizNumerFaksu = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FizAdresEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FizAdresStronyinternetowej = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FizAdSiedzKrajNazwa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FizAdSiedzWojewodztwoNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FizAdSiedzPowiatNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FizAdSiedzGminaNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FizAdSiedzMiejscowoscNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FizAdSiedzMiejscowoscPocztyNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FizAdSiedzUlicaNazwa = table.Column<string>(type: "nvarchar(351)", maxLength: 351, nullable: false),
                    FizCDataWpisuDoRejestruEwidencji = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizCDataSkresleniaZRejestruEwidencji = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizCNumerWRejestrzeEwidencji = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FizCOrganRejestrowySymbol = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    FizCOrganRejestrowyNazwa = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: false),
                    FizCRodzajRejestruSymbol = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    FizCRodzajRejestruNazwa = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: false),
                    FizCNiePodjetoDzialalnosci = table.Column<bool>(type: "bit", nullable: false),
                    UniqueIdentifierOfTheLoggedInUser = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DateOfCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfModification = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PRegon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PNazwaRaportu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaneSzukajPodmiotyParametryWyszukiwaniaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DaneSzukajPodmiotyKomunikatyOBledachId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11OsFizycznaDzialalnoscCeidg", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaDzialalnoscCeidg_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId",
                        column: x => x.DaneSzukajPodmiotyKomunikatyOBledachId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyKomunikatyOBledach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaDzialalnoscCeidg_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                        column: x => x.DaneSzukajPodmiotyParametryWyszukiwaniaId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyParametryWyszukiwania",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BIR11OsFizycznaDzialalnoscPozostala",
                schema: "pagard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FizRegon9 = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    FizNazwa = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    FizNazwaSkrocona = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    FizDataPowstania = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataRozpoczeciaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataWpisuDzialalnosciDoRegon = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataZawieszeniaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataWznowieniaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataZaistnieniaZmianyDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataZakonczeniaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataSkresleniaDzialalnosciZRegon = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataOrzeczeniaOUpadlosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataZakonczeniaPostepowaniaUpadlosciowego = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizAdSiedzKrajSymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    FizAdSiedzWojewodztwoSymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    FizAdSiedzPowiatSymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    FizAdSiedzGminaSymbol = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    FizAdSiedzKodPocztowy = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    FizAdSiedzMiejscowoscPocztySymbol = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    FizAdSiedzMiejscowoscSymbol = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    FizAdSiedzUlicaSymbol = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    FizAdSiedzNumerNieruchomosci = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FizAdSiedzNumerLokalu = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizAdSiedzNietypoweMiejsceLokalizacji = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: false),
                    FizNumerTelefonu = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    FizNumerWewnetrznyTelefonu = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    FizNumerFaksu = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    FizAdresEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FizAdresStronyinternetowej = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FizAdSiedzKrajNazwa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FizAdSiedzWojewodztwoNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FizAdSiedzPowiatNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FizAdSiedzGminaNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FizAdSiedzMiejscowoscNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FizAdSiedzMiejscowoscPocztyNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FizAdSiedzUlicaNazwa = table.Column<string>(type: "nvarchar(351)", maxLength: 351, nullable: false),
                    FizPDataWpisuDoRejestruEwidencji = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizPNumerWRejestrzeEwidencji = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FizPOrganRejestrowySymbol = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    FizPOrganRejestrowyNazwa = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: false),
                    FizPRodzajRejestruSymbol = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    FizPRodzajRejestruNazwa = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: false),
                    UniqueIdentifierOfTheLoggedInUser = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DateOfCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfModification = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PRegon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PNazwaRaportu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaneSzukajPodmiotyParametryWyszukiwaniaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DaneSzukajPodmiotyKomunikatyOBledachId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11OsFizycznaDzialalnoscPozostala", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaDzialalnoscPozostala_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId",
                        column: x => x.DaneSzukajPodmiotyKomunikatyOBledachId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyKomunikatyOBledach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaDzialalnoscPozostala_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                        column: x => x.DaneSzukajPodmiotyParametryWyszukiwaniaId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyParametryWyszukiwania",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BIR11OsFizycznaDzialalnoscRolnicza",
                schema: "pagard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FizRegon9 = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    FizNazwa = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    FizNazwaSkrocona = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    FizDataPowstania = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataRozpoczeciaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataWpisuDzialalnosciDoRegon = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataZawieszeniaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataWznowieniaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataZaistnieniaZmianyDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataZakonczeniaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataSkresleniaDzialalanosciZRegon = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataOrzeczeniaOUpadlosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataZakonczeniaPostepowaniaUpadlosciowego = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizAdSiedzKrajSymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    FizAdSiedzWojewodztwoSymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    FizAdSiedzPowiatSymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    FizAdSiedzGminaSymbol = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    FizAdSiedzKodPocztowy = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    FizAdSiedzMiejscowoscPocztySymbol = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    FizAdSiedzMiejscowoscSymbol = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    FizAdSiedzUlicaSymbol = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    FizAdSiedzNumerNieruchomosci = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FizAdSiedzNumerLokalu = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizAdSiedzNietypoweMiejsceLokalizacji = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: false),
                    FizNumerTelefonu = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    FizNumerWewnetrznyTelefonu = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    FizNumerFaksu = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    FizAdresEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FizAdresStronyinternetowej = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FizAdSiedzKrajNazwa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FizAdSiedzWojewodztwoNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FizAdSiedzPowiatNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FizAdSiedzGminaNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FizAdSiedzMiejscowoscNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FizAdSiedzMiejscowoscPocztyNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FizAdSiedzUlicaNazwa = table.Column<string>(type: "nvarchar(351)", maxLength: 351, nullable: false),
                    UniqueIdentifierOfTheLoggedInUser = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DateOfCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfModification = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PRegon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PNazwaRaportu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaneSzukajPodmiotyParametryWyszukiwaniaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DaneSzukajPodmiotyKomunikatyOBledachId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11OsFizycznaDzialalnoscRolnicza", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaDzialalnoscRolnicza_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId",
                        column: x => x.DaneSzukajPodmiotyKomunikatyOBledachId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyKomunikatyOBledach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaDzialalnoscRolnicza_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                        column: x => x.DaneSzukajPodmiotyParametryWyszukiwaniaId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyParametryWyszukiwania",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                schema: "pagard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FizRegon9 = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    FizNazwa = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    FizNazwaSkrocona = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FizDataPowstania = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FizDataRozpoczeciaDzialalnosci = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FizDataWpisuDzialalnosciDoRegon = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FizDataZawieszeniaDzialalnosci = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FizDataWznowieniaDzialalnosci = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FizDataZaistnieniaZmianyDzialalnosci = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FizDataZakonczeniaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataSkresleniaDzialalnosciZRegon = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FizAdSiedzKrajSymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    FizAdSiedzWojewodztwoSymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    FizAdSiedzPowiatSymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    FizAdSiedzGminaSymbol = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    FizAdSiedzKodPocztowy = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    FizAdSiedzMiejscowoscPocztySymbol = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    FizAdSiedzMiejscowoscSymbol = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    FizAdSiedzUlicaSymbol = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    FizAdSiedzNumerNieruchomosci = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FizAdSiedzNumerLokalu = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizAdSiedzNietypoweMiejsceLokalizacji = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: false),
                    FizNumerTelefonu = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FizNumerWewnetrznyTelefonu = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FizNumerFaksu = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FizAdresEmail = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FizAdresStronyinternetowej = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FizAdresEmail2 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FizAdSiedzKrajNazwa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FizAdSiedzWojewodztwoNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FizAdSiedzPowiatNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FizAdSiedzGminaNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FizAdSiedzMiejscowoscNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FizAdSiedzMiejscowoscPocztyNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FizAdSiedzUlicaNazwa = table.Column<string>(type: "nvarchar(351)", maxLength: 351, nullable: false),
                    UniqueIdentifierOfTheLoggedInUser = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DateOfCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfModification = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PRegon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PNazwaRaportu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaneSzukajPodmiotyParametryWyszukiwaniaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DaneSzukajPodmiotyKomunikatyOBledachId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId",
                        column: x => x.DaneSzukajPodmiotyKomunikatyOBledachId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyKomunikatyOBledach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwani~",
                        column: x => x.DaneSzukajPodmiotyParametryWyszukiwaniaId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyParametryWyszukiwania",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BIR11OsFizycznaListaJednLokalnych",
                schema: "pagard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaneSzukajPodmiotyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LokfizRegon14 = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    LokfizNazwa = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    LokfizSilosID = table.Column<int>(type: "int", nullable: false),
                    LokfizSilosSymbol = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokfizAdSiedzKrajSymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    LokfizAdSiedzWojewodztwoSymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    LokfizAdSiedzPowiatSymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    LokfizAdSiedzGminaSymbol = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    LokfizAdSiedzKodPocztowy = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    LokfizAdSiedzMiejscowoscPocztySymbol = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    LokfizAdSiedzMiejscowoscSymbol = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    LokfizAdSiedzUlicaSymbol = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    LokfizAdSiedzNumerNieruchomosci = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LokfizAdSiedzNumerLokalu = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokfizAdSiedzNietypoweMiejsceLokalizacji = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    LokfizAdSiedzWojewodztwoNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LokfizAdSiedzPowiatNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LokfizAdSiedzGminaNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LokfizAdSiedzMiejscowoscNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LokfizAdSiedzMiejscowoscPocztyNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LokfizAdSiedzUlicaNazwa = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    LokfizDataPowstania = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokfizDataRozpoczeciaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokfizDataWpisuDoRegon = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokfizDataZawieszeniaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokfizDataWznowieniaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokfizDataZakonczeniaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokfizDataSkresleniaZRegon = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UniqueIdentifierOfTheLoggedInUser = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DateOfCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfModification = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PRegon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PNazwaRaportu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaneSzukajPodmiotyParametryWyszukiwaniaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DaneSzukajPodmiotyKomunikatyOBledachId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11OsFizycznaListaJednLokalnych", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaListaJednLokalnych_DaneSzukajPodmioty_DaneSzukajPodmiotyId",
                        column: x => x.DaneSzukajPodmiotyId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmioty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaListaJednLokalnych_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId",
                        column: x => x.DaneSzukajPodmiotyKomunikatyOBledachId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyKomunikatyOBledach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaListaJednLokalnych_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                        column: x => x.DaneSzukajPodmiotyParametryWyszukiwaniaId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyParametryWyszukiwania",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BIR11OsFizycznaPkd",
                schema: "pagard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaneSzukajPodmiotyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FizPkdKod = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    FizPkdNazwa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FizPkdPrzewazajace = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FizSilosID = table.Column<int>(type: "int", nullable: false),
                    FizSilosSymbol = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FizDataSkresleniaDzialalnosciZRegon = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UniqueIdentifierOfTheLoggedInUser = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DateOfCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfModification = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PRegon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PNazwaRaportu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaneSzukajPodmiotyParametryWyszukiwaniaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DaneSzukajPodmiotyKomunikatyOBledachId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11OsFizycznaPkd", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaPkd_DaneSzukajPodmioty_DaneSzukajPodmiotyId",
                        column: x => x.DaneSzukajPodmiotyId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmioty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaPkd_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId",
                        column: x => x.DaneSzukajPodmiotyKomunikatyOBledachId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyKomunikatyOBledach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIR11OsFizycznaPkd_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                        column: x => x.DaneSzukajPodmiotyParametryWyszukiwaniaId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyParametryWyszukiwania",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BIR11OsPrawna",
                schema: "pagard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrawRegon9 = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    PrawNip = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PrawStatusNip = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    PrawNazwa = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    PrawNazwaSkrocona = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    PrawNumerWRejestrzeEwidencji = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrawDataWpisuDoRejestruEwidencji = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PrawDataPowstania = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PrawDataRozpoczeciaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PrawDataWpisuDoRegon = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PrawDataZawieszeniaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PrawDataWznowieniaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PrawDataZaistnieniaZmiany = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PrawDataZakonczeniaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PrawDataSkresleniaZRegon = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PrawDataOrzeczeniaOUpadlosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PrawDataZakonczeniaPostepowaniaUpadlosciowego = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PrawAdSiedzKrajSymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    PrawAdSiedzWojewodztwoSymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    PrawAdSiedzPowiatSymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    PrawAdSiedzGminaSymbol = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    PrawAdSiedzKodPocztowy = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    PrawAdSiedzMiejscowoscPocztySymbol = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    PrawAdSiedzMiejscowoscSymbol = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    PrawAdSiedzUlicaSymbol = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    PrawAdSiedzNumerNieruchomosci = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PrawAdSiedzNumerLokalu = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PrawAdSiedzNietypoweMiejsceLokalizacji = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: false),
                    PrawNumerTelefonu = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    PrawNumerWewnetrznyTelefonu = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    PrawNumerFaksu = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    PrawAdresEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PrawAdresStronyinternetowej = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PrawAdSiedzKrajNazwa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PrawAdSiedzWojewodztwoNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PrawAdSiedzPowiatNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PrawAdSiedzGminaNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PrawAdSiedzMiejscowoscNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PrawAdSiedzMiejscowoscPocztyNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PrawAdSiedzUlicaNazwa = table.Column<string>(type: "nvarchar(351)", maxLength: 351, nullable: false),
                    PrawPodstawowaFormaPrawnaSymbol = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    PrawSzczegolnaFormaPrawnaSymbol = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    PrawFormaFinansowaniaSymbol = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    PrawFormaWlasnosciSymbol = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrawOrganZalozycielskiSymbol = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    PrawOrganRejestrowySymbol = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    PrawRodzajRejestruEwidencjiSymbol = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    PrawPodstawowaFormaPrawnaNazwa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PrawSzczegolnaFormaPrawnaNazwa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PrawFormaFinansowaniaNazwa = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: false),
                    PrawFormaWlasnosciNazwa = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: false),
                    PrawOrganZalozycielskiNazwa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PrawOrganRejestrowyNazwa = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: false),
                    PrawRodzajRejestruEwidencjiNazwa = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: false),
                    PrawLiczbaJednLokalnych = table.Column<int>(type: "int", nullable: false),
                    UniqueIdentifierOfTheLoggedInUser = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DateOfCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfModification = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PRegon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PNazwaRaportu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaneSzukajPodmiotyParametryWyszukiwaniaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DaneSzukajPodmiotyKomunikatyOBledachId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11OsPrawna", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BIR11OsPrawna_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId",
                        column: x => x.DaneSzukajPodmiotyKomunikatyOBledachId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyKomunikatyOBledach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIR11OsPrawna_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                        column: x => x.DaneSzukajPodmiotyParametryWyszukiwaniaId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyParametryWyszukiwania",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BIR11OsPrawnaListaJednLokalnych",
                schema: "pagard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaneSzukajPodmiotyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LokprawRegon14 = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    LokprawNazwa = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: false),
                    LokprawAdSiedzKrajSymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    LokprawAdSiedzWojewodztwoSymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    LokprawAdSiedzPowiatSymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    LokprawAdSiedzGminaSymbol = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    LokprawAdSiedzKodPocztowy = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    LokprawAdSiedzMiejscowoscPocztySymbol = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    LokprawAdSiedzMiejscowoscSymbol = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    LokprawAdSiedzUlicaSymbol = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    LokprawAdSiedzNumerNieruchomosci = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LokprawAdSiedzNumerLokalu = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokprawAdSiedzNietypoweMiejsceLokalizacji = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: false),
                    LokprawAdSiedzWojewodztwoNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LokprawAdSiedzPowiatNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LokprawAdSiedzGminaNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LokprawAdSiedzMiejscowoscNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LokprawAdSiedzMiejscowoscPocztyNazwa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LokprawAdSiedzUlicaNazwa = table.Column<string>(type: "nvarchar(351)", maxLength: 351, nullable: false),
                    LokprawDataPowstania = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokprawDataRozpoczeciaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokprawDataWpisuDoRegon = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokprawDataZawieszeniaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokprawDataWznowieniaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokprawDataZakonczeniaDzialalnosci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LokprawDataSkresleniaZRegon = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UniqueIdentifierOfTheLoggedInUser = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DateOfCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfModification = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PRegon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PNazwaRaportu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaneSzukajPodmiotyParametryWyszukiwaniaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DaneSzukajPodmiotyKomunikatyOBledachId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11OsPrawnaListaJednLokalnych", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BIR11OsPrawnaListaJednLokalnych_DaneSzukajPodmioty_DaneSzukajPodmiotyId",
                        column: x => x.DaneSzukajPodmiotyId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmioty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIR11OsPrawnaListaJednLokalnych_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId",
                        column: x => x.DaneSzukajPodmiotyKomunikatyOBledachId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyKomunikatyOBledach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIR11OsPrawnaListaJednLokalnych_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                        column: x => x.DaneSzukajPodmiotyParametryWyszukiwaniaId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyParametryWyszukiwania",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BIR11OsPrawnaPkd",
                schema: "pagard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaneSzukajPodmiotyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PrawPkdKod = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    PrawPkdNazwa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PrawPkdPrzewazajace = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    UniqueIdentifierOfTheLoggedInUser = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DateOfCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfModification = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PRegon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PNazwaRaportu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaneSzukajPodmiotyParametryWyszukiwaniaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DaneSzukajPodmiotyKomunikatyOBledachId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11OsPrawnaPkd", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BIR11OsPrawnaPkd_DaneSzukajPodmioty_DaneSzukajPodmiotyId",
                        column: x => x.DaneSzukajPodmiotyId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmioty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIR11OsPrawnaPkd_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId",
                        column: x => x.DaneSzukajPodmiotyKomunikatyOBledachId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyKomunikatyOBledach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIR11OsPrawnaPkd_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                        column: x => x.DaneSzukajPodmiotyParametryWyszukiwaniaId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyParametryWyszukiwania",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BIR11OsPrawnaSpCywilnaWspolnicy",
                schema: "pagard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaneSzukajPodmiotyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WspolscRegonWspolnikSpolki = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    WspolscImiePierwsze = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    WspolscImieDrugie = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    WspolscNazwisko = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    WspolscFirmaNazwa = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    UniqueIdentifierOfTheLoggedInUser = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DateOfCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfModification = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PRegon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PNazwaRaportu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaneSzukajPodmiotyParametryWyszukiwaniaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DaneSzukajPodmiotyKomunikatyOBledachId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11OsPrawnaSpCywilnaWspolnicy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BIR11OsPrawnaSpCywilnaWspolnicy_DaneSzukajPodmioty_DaneSzukajPodmiotyId",
                        column: x => x.DaneSzukajPodmiotyId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmioty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIR11OsPrawnaSpCywilnaWspolnicy_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId",
                        column: x => x.DaneSzukajPodmiotyKomunikatyOBledachId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyKomunikatyOBledach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIR11OsPrawnaSpCywilnaWspolnicy_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                        column: x => x.DaneSzukajPodmiotyParametryWyszukiwaniaId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyParametryWyszukiwania",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BIR11TypPodmiotu",
                schema: "pagard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Typ = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    UniqueIdentifierOfTheLoggedInUser = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DateOfCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfModification = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PRegon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PNazwaRaportu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaneSzukajPodmiotyParametryWyszukiwaniaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DaneSzukajPodmiotyKomunikatyOBledachId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIR11TypPodmiotu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BIR11TypPodmiotu_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId",
                        column: x => x.DaneSzukajPodmiotyKomunikatyOBledachId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyKomunikatyOBledach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIR11TypPodmiotu_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                        column: x => x.DaneSzukajPodmiotyParametryWyszukiwaniaId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmiotyParametryWyszukiwania",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DaneSzukajPodmiotyMessageInspector",
                schema: "pagard",
                columns: table => new
                {
                    DaneSzukajPodmiotyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MessageInspectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaneSzukajPodmiotyMessageInspector", x => new { x.DaneSzukajPodmiotyId, x.MessageInspectorId });
                    table.ForeignKey(
                        name: "FK_DaneSzukajPodmiotyMessageInspector_DaneSzukajPodmioty_DaneSzukajPodmiotyId",
                        column: x => x.DaneSzukajPodmiotyId,
                        principalSchema: "pagard",
                        principalTable: "DaneSzukajPodmioty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DaneSzukajPodmiotyMessageInspector_MessageInspector_MessageInspectorId",
                        column: x => x.MessageInspectorId,
                        principalSchema: "pagard",
                        principalTable: "MessageInspector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwania_DataModyfikacji",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                column: "DataModyfikacji");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwania_DataUtworzenia",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                column: "DataUtworzenia");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmioty_BIR11JednLokalnaOsFizycznejId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "BIR11JednLokalnaOsFizycznejId");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmioty_BIR11JednLokalnaOsPrawnejId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "BIR11JednLokalnaOsPrawnejId");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmioty_BIR11OsFizycznaDaneOgolneId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "BIR11OsFizycznaDaneOgolneId");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmioty_BIR11OsFizycznaDzialalnoscCeidgId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "BIR11OsFizycznaDzialalnoscCeidgId");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmioty_BIR11OsFizycznaDzialalnoscPozostalaId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "BIR11OsFizycznaDzialalnoscPozostalaId");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmioty_BIR11OsFizycznaDzialalnoscRolniczaId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "BIR11OsFizycznaDzialalnoscRolniczaId");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmioty_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmioty_BIR11OsPrawnaId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "BIR11OsPrawnaId");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmioty_BIR11TypPodmiotuId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "BIR11TypPodmiotuId");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmioty_DaneSzukajPodmiotyKomunikatyOBledachId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "DaneSzukajPodmiotyKomunikatyOBledachId");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmioty_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "DaneSzukajPodmiotyParametryWyszukiwaniaId");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmioty_DataModyfikacji",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "DataModyfikacji");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmioty_DataUtworzenia",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "DataUtworzenia");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmioty_DataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "DataZakonczeniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmioty_NrLokalu",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "NrLokalu");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmioty_NrNieruchomosci",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "NrNieruchomosci");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmioty_StatusNip",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "StatusNip");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_DaneSzukajPodmiotyKomunikatyOBledachId",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "DaneSzukajPodmiotyKomunikatyOBledachId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "DaneSzukajPodmiotyParametryWyszukiwaniaId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_DateOfCreate",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "DateOfCreate");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_DateOfModification",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "DateOfModification");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_Id",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzGminaNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizAdSiedzGminaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzGminaSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizAdSiedzGminaSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzKodPocztowy",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizAdSiedzKodPocztowy");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzKrajNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizAdSiedzKrajNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzKrajSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizAdSiedzKrajSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzMiejscowoscNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizAdSiedzMiejscowoscNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzMiejscowoscPocztyNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizAdSiedzMiejscowoscPocztyNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzMiejscowoscPocztySymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizAdSiedzMiejscowoscPocztySymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzMiejscowoscSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizAdSiedzMiejscowoscSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzNietypoweMiejsceLokalizacji",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizAdSiedzNietypoweMiejsceLokalizacji");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzNumerLokalu",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizAdSiedzNumerLokalu");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzNumerNieruchomosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizAdSiedzNumerNieruchomosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzPowiatNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizAdSiedzPowiatNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzPowiatSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizAdSiedzPowiatSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzUlicaNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizAdSiedzUlicaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzUlicaSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizAdSiedzUlicaSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzWojewodztwoNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizAdSiedzWojewodztwoNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzWojewodztwoSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizAdSiedzWojewodztwoSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizCNiePodjetoDzialalnosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizCNiePodjetoDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizDataPowstania",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizDataPowstania");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizDataRozpoczeciaDzialalnosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizDataRozpoczeciaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizDataSkresleniaZRegon",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizDataSkresleniaZRegon");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizDataWpisuDoRegon",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizDataWpisuDoRegon");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizDataWpisuDoRejestruEwidencji",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizDataWpisuDoRejestruEwidencji");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizDataWznowieniaDzialalnosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizDataWznowieniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizDataZaistnieniaZmiany",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizDataZaistnieniaZmiany");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizDataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizDataZakonczeniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizDataZawieszeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizDataZawieszeniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizFormaFinansowaniaNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizFormaFinansowaniaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizFormaFinansowaniaSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizFormaFinansowaniaSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizNumerwRejestrzeEwidencji",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizNumerwRejestrzeEwidencji");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizOrganRejestrowyNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizOrganRejestrowyNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizOrganRejestrowySymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizOrganRejestrowySymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizRegon14",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizRegon14");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizRodzajRejestruNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizRodzajRejestruNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizRodzajRejestruSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizRodzajRejestruSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizSilosID",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizSilosID");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_LokfizSilosNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "LokfizSilosNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznej_UniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                column: "UniqueIdentifierOfTheLoggedInUser");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznejPkd_DaneSzukajPodmiotyId",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkd",
                column: "DaneSzukajPodmiotyId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznejPkd_DaneSzukajPodmiotyKomunikatyOBledachId",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkd",
                column: "DaneSzukajPodmiotyKomunikatyOBledachId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznejPkd_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkd",
                column: "DaneSzukajPodmiotyParametryWyszukiwaniaId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznejPkd_DateOfCreate",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkd",
                column: "DateOfCreate");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznejPkd_DateOfModification",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkd",
                column: "DateOfModification");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznejPkd_Id",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkd",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznejPkd_LokfizPkdKod",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkd",
                column: "LokfizPkdKod");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznejPkd_LokfizPkdNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkd",
                column: "LokfizPkdNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznejPkd_LokfizPkdPrzewazajace",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkd",
                column: "LokfizPkdPrzewazajace");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznejPkd_LokfizSilosSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkd",
                column: "LokfizSilosSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsFizycznejPkd_UniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkd",
                column: "UniqueIdentifierOfTheLoggedInUser");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_DaneSzukajPodmiotyKomunikatyOBledachId",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "DaneSzukajPodmiotyKomunikatyOBledachId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "DaneSzukajPodmiotyParametryWyszukiwaniaId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_DateOfCreate",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "DateOfCreate");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_DateOfModification",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "DateOfModification");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_Id",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzGminaNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawAdSiedzGminaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzGminaSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawAdSiedzGminaSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzKodPocztowy",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawAdSiedzKodPocztowy");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzKrajNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawAdSiedzKrajNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzKrajSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawAdSiedzKrajSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzMiejscowoscNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawAdSiedzMiejscowoscNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzMiejscowoscPocztyNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawAdSiedzMiejscowoscPocztyNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzMiejscowoscPocztySymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawAdSiedzMiejscowoscPocztySymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzMiejscowoscSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawAdSiedzMiejscowoscSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzNietypoweMiejsceLokalizacji",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawAdSiedzNietypoweMiejsceLokalizacji");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzNumerLokalu",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawAdSiedzNumerLokalu");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzNumerNieruchomosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawAdSiedzNumerNieruchomosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzPowiatNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawAdSiedzPowiatNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzPowiatSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawAdSiedzPowiatSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzUlicaNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawAdSiedzUlicaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzUlicaSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawAdSiedzUlicaSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzWojewodztwoNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawAdSiedzWojewodztwoNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzWojewodztwoSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawAdSiedzWojewodztwoSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawDataPowstania",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawDataPowstania");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawDataRozpoczeciaDzialalnosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawDataRozpoczeciaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawDataSkresleniaZRegon",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawDataSkresleniaZRegon");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawDataWpisuDoRegon",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawDataWpisuDoRegon");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawDataWpisuDoRejestruEwidencji",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawDataWpisuDoRejestruEwidencji");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawDataWznowieniaDzialalnosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawDataWznowieniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawDataZaistnieniaZmiany",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawDataZaistnieniaZmiany");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawDataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawDataZakonczeniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawDataZawieszeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawDataZawieszeniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawFormaFinansowaniaNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawFormaFinansowaniaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawFormaFinansowaniaSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawFormaFinansowaniaSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawNumerWrejestrzeEwidencji",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawNumerWrejestrzeEwidencji");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawOrganRejestrowyNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawOrganRejestrowyNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawOrganRejestrowySymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawOrganRejestrowySymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawRegon14",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawRegon14");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawRodzajRejestruEwidencjiNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawRodzajRejestruEwidencjiNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_LokprawRodzajRejestruEwidencjiSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "LokprawRodzajRejestruEwidencjiSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnej_UniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                column: "UniqueIdentifierOfTheLoggedInUser");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnejPkd_DaneSzukajPodmiotyId",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejPkd",
                column: "DaneSzukajPodmiotyId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnejPkd_DaneSzukajPodmiotyKomunikatyOBledachId",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejPkd",
                column: "DaneSzukajPodmiotyKomunikatyOBledachId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnejPkd_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejPkd",
                column: "DaneSzukajPodmiotyParametryWyszukiwaniaId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnejPkd_DateOfCreate",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejPkd",
                column: "DateOfCreate");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnejPkd_DateOfModification",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejPkd",
                column: "DateOfModification");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnejPkd_Id",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejPkd",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnejPkd_LokprawPkdKod",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejPkd",
                column: "LokprawPkdKod");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnejPkd_LokprawPkdNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejPkd",
                column: "LokprawPkdNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnejPkd_LokprawPkdPrzewazajace",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejPkd",
                column: "LokprawPkdPrzewazajace");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11JednLokalnaOsPrawnejPkd_UniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejPkd",
                column: "UniqueIdentifierOfTheLoggedInUser");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_DaneSzukajPodmiotyKomunikatyOBledachId",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "DaneSzukajPodmiotyKomunikatyOBledachId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "DaneSzukajPodmiotyParametryWyszukiwaniaId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_DateOfCreate",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "DateOfCreate");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_DateOfModification",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "DateOfModification");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_FizDataSkresleniaPodmiotuZRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "FizDataSkresleniaPodmiotuZRegon");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_FizDataWpisuPodmiotuDoRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "FizDataWpisuPodmiotuDoRegon");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_FizDataZaistnieniaZmiany",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "FizDataZaistnieniaZmiany");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_FizDzialalnoscCeidg",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "FizDzialalnoscCeidg");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_FizDzialalnoscPozostala",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "FizDzialalnoscPozostala");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_FizDzialalnoscRolnicza",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "FizDzialalnoscRolnicza");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_FizDzialalnoscSkreslonaDo20141108",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "FizDzialalnoscSkreslonaDo20141108");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_FizFormaFinansowaniaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "FizFormaFinansowaniaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_FizFormaFinansowaniaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "FizFormaFinansowaniaSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_FizFormaWlasnosciNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "FizFormaWlasnosciNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_FizFormaWlasnosciSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "FizFormaWlasnosciSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_FizImie1",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "FizImie1");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_FizImie2",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "FizImie2");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_FizLiczbaJednLokalnych",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "FizLiczbaJednLokalnych");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_FizNazwisko",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "FizNazwisko");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_FizNip",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "FizNip");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_FizPodstawowaFormaPrawnaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "FizPodstawowaFormaPrawnaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_FizPodstawowaFormaPrawnaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "FizPodstawowaFormaPrawnaSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_FizRegon9",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "FizRegon9");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_FizStatusNip",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "FizStatusNip");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_FizSzczegolnaFormaPrawnaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "FizSzczegolnaFormaPrawnaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_FizSzczegolnaFormaPrawnaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "FizSzczegolnaFormaPrawnaSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_Id",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDaneOgolne_UniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                column: "UniqueIdentifierOfTheLoggedInUser");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_DaneSzukajPodmiotyKomunikatyOBledachId",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "DaneSzukajPodmiotyKomunikatyOBledachId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "DaneSzukajPodmiotyParametryWyszukiwaniaId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_DateOfCreate",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "DateOfCreate");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_DateOfModification",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "DateOfModification");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdresEmail",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizAdresEmail");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdresStronyinternetowej",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizAdresStronyinternetowej");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzGminaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizAdSiedzGminaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzGminaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizAdSiedzGminaSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzKodPocztowy",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizAdSiedzKodPocztowy");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzKrajNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizAdSiedzKrajNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzKrajSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizAdSiedzKrajSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzMiejscowoscNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizAdSiedzMiejscowoscNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzMiejscowoscPocztyNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizAdSiedzMiejscowoscPocztyNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzMiejscowoscPocztySymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizAdSiedzMiejscowoscPocztySymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzMiejscowoscSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizAdSiedzMiejscowoscSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzNietypoweMiejsceLokalizacji",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizAdSiedzNietypoweMiejsceLokalizacji");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzNumerLokalu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizAdSiedzNumerLokalu");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzNumerNieruchomosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizAdSiedzNumerNieruchomosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzPowiatNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizAdSiedzPowiatNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzPowiatSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizAdSiedzPowiatSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzUlicaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizAdSiedzUlicaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzUlicaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizAdSiedzUlicaSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzWojewodztwoNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizAdSiedzWojewodztwoNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzWojewodztwoSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizAdSiedzWojewodztwoSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizCDataSkresleniaZRejestruEwidencji",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizCDataSkresleniaZRejestruEwidencji");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizCDataWpisuDoRejestruEwidencji",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizCDataWpisuDoRejestruEwidencji");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizCNiePodjetoDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizCNiePodjetoDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizCNumerWRejestrzeEwidencji",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizCNumerWRejestrzeEwidencji");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizCOrganRejestrowyNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizCOrganRejestrowyNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizCOrganRejestrowySymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizCOrganRejestrowySymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizCRodzajRejestruNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizCRodzajRejestruNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizCRodzajRejestruSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizCRodzajRejestruSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizDataOrzeczeniaOUpadlosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizDataOrzeczeniaOUpadlosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizDataPowstania",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizDataPowstania");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizDataRozpoczeciaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizDataRozpoczeciaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizDataSkresleniaDzialalnosciZRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizDataSkresleniaDzialalnosciZRegon");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizDataWpisuDzialalnosciDoRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizDataWpisuDzialalnosciDoRegon");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizDataWznowieniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizDataWznowieniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizDataZaistnieniaZmianyDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizDataZaistnieniaZmianyDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizDataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizDataZakonczeniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizDataZakonczeniaPostepowaniaUpadlosciowego",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizDataZakonczeniaPostepowaniaUpadlosciowego");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizDataZawieszeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizDataZawieszeniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizNazwaSkrocona",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizNazwaSkrocona");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizNumerFaksu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizNumerFaksu");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizNumerTelefonu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizNumerTelefonu");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizNumerWewnetrznyTelefonu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizNumerWewnetrznyTelefonu");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_FizRegon9",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "FizRegon9");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_Id",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscCeidg_UniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                column: "UniqueIdentifierOfTheLoggedInUser");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_DaneSzukajPodmiotyKomunikatyOBledachId",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "DaneSzukajPodmiotyKomunikatyOBledachId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "DaneSzukajPodmiotyParametryWyszukiwaniaId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_DateOfCreate",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "DateOfCreate");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_DateOfModification",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "DateOfModification");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdresEmail",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizAdresEmail");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdresStronyinternetowej",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizAdresStronyinternetowej");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzGminaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizAdSiedzGminaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzGminaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizAdSiedzGminaSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzKodPocztowy",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizAdSiedzKodPocztowy");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzKrajNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizAdSiedzKrajNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzKrajSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizAdSiedzKrajSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzMiejscowoscNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizAdSiedzMiejscowoscNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzMiejscowoscPocztyNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizAdSiedzMiejscowoscPocztyNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzMiejscowoscPocztySymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizAdSiedzMiejscowoscPocztySymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzMiejscowoscSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizAdSiedzMiejscowoscSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzNietypoweMiejsceLokalizacji",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizAdSiedzNietypoweMiejsceLokalizacji");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzNumerLokalu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizAdSiedzNumerLokalu");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzNumerNieruchomosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizAdSiedzNumerNieruchomosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzPowiatNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizAdSiedzPowiatNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzPowiatSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizAdSiedzPowiatSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzUlicaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizAdSiedzUlicaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzUlicaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizAdSiedzUlicaSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzWojewodztwoNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizAdSiedzWojewodztwoNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzWojewodztwoSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizAdSiedzWojewodztwoSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizDataOrzeczeniaOUpadlosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizDataOrzeczeniaOUpadlosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizDataPowstania",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizDataPowstania");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizDataRozpoczeciaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizDataRozpoczeciaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizDataSkresleniaDzialalnosciZRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizDataSkresleniaDzialalnosciZRegon");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizDataWpisuDzialalnosciDoRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizDataWpisuDzialalnosciDoRegon");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizDataWznowieniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizDataWznowieniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizDataZaistnieniaZmianyDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizDataZaistnieniaZmianyDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizDataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizDataZakonczeniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizDataZakonczeniaPostepowaniaUpadlosciowego",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizDataZakonczeniaPostepowaniaUpadlosciowego");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizDataZawieszeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizDataZawieszeniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizNazwaSkrocona",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizNazwaSkrocona");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizNumerFaksu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizNumerFaksu");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizNumerTelefonu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizNumerTelefonu");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizNumerWewnetrznyTelefonu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizNumerWewnetrznyTelefonu");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizPDataWpisuDoRejestruEwidencji",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizPDataWpisuDoRejestruEwidencji");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizPNumerWRejestrzeEwidencji",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizPNumerWRejestrzeEwidencji");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizPOrganRejestrowyNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizPOrganRejestrowyNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizPOrganRejestrowySymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizPOrganRejestrowySymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizPRodzajRejestruNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizPRodzajRejestruNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizPRodzajRejestruSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizPRodzajRejestruSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_FizRegon9",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "FizRegon9");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_Id",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscPozostala_UniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                column: "UniqueIdentifierOfTheLoggedInUser");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_DaneSzukajPodmiotyKomunikatyOBledachId",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "DaneSzukajPodmiotyKomunikatyOBledachId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "DaneSzukajPodmiotyParametryWyszukiwaniaId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_DateOfCreate",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "DateOfCreate");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_DateOfModification",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "DateOfModification");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdresEmail",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizAdresEmail");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdresStronyinternetowej",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizAdresStronyinternetowej");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzGminaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizAdSiedzGminaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzGminaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizAdSiedzGminaSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzKodPocztowy",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizAdSiedzKodPocztowy");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzKrajNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizAdSiedzKrajNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzKrajSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizAdSiedzKrajSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzMiejscowoscNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizAdSiedzMiejscowoscNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzMiejscowoscPocztyNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizAdSiedzMiejscowoscPocztyNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzMiejscowoscPocztySymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizAdSiedzMiejscowoscPocztySymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzMiejscowoscSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizAdSiedzMiejscowoscSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzNietypoweMiejsceLokalizacji",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizAdSiedzNietypoweMiejsceLokalizacji");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzNumerLokalu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizAdSiedzNumerLokalu");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzNumerNieruchomosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizAdSiedzNumerNieruchomosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzPowiatNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizAdSiedzPowiatNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzPowiatSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizAdSiedzPowiatSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzUlicaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizAdSiedzUlicaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzUlicaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizAdSiedzUlicaSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzWojewodztwoNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizAdSiedzWojewodztwoNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzWojewodztwoSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizAdSiedzWojewodztwoSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizDataOrzeczeniaOUpadlosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizDataOrzeczeniaOUpadlosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizDataPowstania",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizDataPowstania");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizDataRozpoczeciaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizDataRozpoczeciaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizDataSkresleniaDzialalanosciZRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizDataSkresleniaDzialalanosciZRegon");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizDataWpisuDzialalnosciDoRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizDataWpisuDzialalnosciDoRegon");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizDataWznowieniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizDataWznowieniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizDataZaistnieniaZmianyDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizDataZaistnieniaZmianyDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizDataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizDataZakonczeniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizDataZakonczeniaPostepowaniaUpadlosciowego",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizDataZakonczeniaPostepowaniaUpadlosciowego");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizDataZawieszeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizDataZawieszeniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizNazwaSkrocona",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizNazwaSkrocona");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizNumerFaksu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizNumerFaksu");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizNumerTelefonu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizNumerTelefonu");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizNumerWewnetrznyTelefonu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizNumerWewnetrznyTelefonu");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_FizRegon9",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "FizRegon9");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_Id",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscRolnicza_UniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                column: "UniqueIdentifierOfTheLoggedInUser");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_DaneSzukajPodmiotyKomunikatyOBledachId",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "DaneSzukajPodmiotyKomunikatyOBledachId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "DaneSzukajPodmiotyParametryWyszukiwaniaId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_DateOfCreate",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "DateOfCreate");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_DateOfModification",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "DateOfModification");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdresEmail",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizAdresEmail");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdresEmail2",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizAdresEmail2");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdresStronyinternetowej",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizAdresStronyinternetowej");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzGminaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizAdSiedzGminaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzGminaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizAdSiedzGminaSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzKodPocztowy",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizAdSiedzKodPocztowy");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzKrajNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizAdSiedzKrajNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzKrajSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizAdSiedzKrajSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzMiejscowoscNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizAdSiedzMiejscowoscNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzMiejscowoscPocztyNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizAdSiedzMiejscowoscPocztyNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzMiejscowoscPocztySymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizAdSiedzMiejscowoscPocztySymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzMiejscowoscSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizAdSiedzMiejscowoscSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzNietypoweMiejsceLokalizacji",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizAdSiedzNietypoweMiejsceLokalizacji");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzNumerLokalu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizAdSiedzNumerLokalu");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzNumerNieruchomosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizAdSiedzNumerNieruchomosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzPowiatNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizAdSiedzPowiatNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzPowiatSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizAdSiedzPowiatSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzUlicaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizAdSiedzUlicaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzUlicaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizAdSiedzUlicaSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzWojewodztwoNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizAdSiedzWojewodztwoNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzWojewodztwoSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizAdSiedzWojewodztwoSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizDataPowstania",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizDataPowstania");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizDataRozpoczeciaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizDataRozpoczeciaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizDataSkresleniaDzialalnosciZRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizDataSkresleniaDzialalnosciZRegon");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizDataWpisuDzialalnosciDoRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizDataWpisuDzialalnosciDoRegon");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizDataWznowieniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizDataWznowieniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizDataZaistnieniaZmianyDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizDataZaistnieniaZmianyDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizDataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizDataZakonczeniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizDataZawieszeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizDataZawieszeniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizNazwaSkrocona",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizNazwaSkrocona");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizNumerFaksu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizNumerFaksu");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizNumerTelefonu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizNumerTelefonu");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizNumerWewnetrznyTelefonu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizNumerWewnetrznyTelefonu");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizRegon9",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "FizRegon9");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_Id",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_UniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                column: "UniqueIdentifierOfTheLoggedInUser");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_DaneSzukajPodmiotyId",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "DaneSzukajPodmiotyId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_DaneSzukajPodmiotyKomunikatyOBledachId",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "DaneSzukajPodmiotyKomunikatyOBledachId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "DaneSzukajPodmiotyParametryWyszukiwaniaId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_DateOfCreate",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "DateOfCreate");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_DateOfModification",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "DateOfModification");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_Id",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzGminaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizAdSiedzGminaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzGminaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizAdSiedzGminaSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzKodPocztowy",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizAdSiedzKodPocztowy");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzKrajSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizAdSiedzKrajSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzMiejscowoscNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizAdSiedzMiejscowoscNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzMiejscowoscPocztyNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizAdSiedzMiejscowoscPocztyNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzMiejscowoscPocztySymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizAdSiedzMiejscowoscPocztySymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzMiejscowoscSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizAdSiedzMiejscowoscSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzNietypoweMiejsceLokalizacji",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizAdSiedzNietypoweMiejsceLokalizacji");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzNumerLokalu",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizAdSiedzNumerLokalu");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzNumerNieruchomosci",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizAdSiedzNumerNieruchomosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzPowiatNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizAdSiedzPowiatNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzPowiatSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizAdSiedzPowiatSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzUlicaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizAdSiedzUlicaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzUlicaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizAdSiedzUlicaSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzWojewodztwoNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizAdSiedzWojewodztwoNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzWojewodztwoSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizAdSiedzWojewodztwoSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizDataPowstania",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizDataPowstania");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizDataRozpoczeciaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizDataRozpoczeciaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizDataSkresleniaZRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizDataSkresleniaZRegon");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizDataWpisuDoRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizDataWpisuDoRegon");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizDataWznowieniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizDataWznowieniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizDataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizDataZakonczeniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizDataZawieszeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizDataZawieszeniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizRegon14",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizRegon14");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizSilosID",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizSilosID");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_LokfizSilosSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "LokfizSilosSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaListaJednLokalnych_UniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                column: "UniqueIdentifierOfTheLoggedInUser");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaPkd_DaneSzukajPodmiotyId",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                column: "DaneSzukajPodmiotyId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaPkd_DaneSzukajPodmiotyKomunikatyOBledachId",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                column: "DaneSzukajPodmiotyKomunikatyOBledachId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaPkd_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                column: "DaneSzukajPodmiotyParametryWyszukiwaniaId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaPkd_DateOfCreate",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                column: "DateOfCreate");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaPkd_DateOfModification",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                column: "DateOfModification");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaPkd_FizDataSkresleniaDzialalnosciZRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                column: "FizDataSkresleniaDzialalnosciZRegon");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaPkd_FizPkdKod",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                column: "FizPkdKod");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaPkd_FizPkdNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                column: "FizPkdNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaPkd_FizPkdPrzewazajace",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                column: "FizPkdPrzewazajace");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaPkd_FizSilosID",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                column: "FizSilosID");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaPkd_FizSilosSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                column: "FizSilosSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaPkd_Id",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsFizycznaPkd_UniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                column: "UniqueIdentifierOfTheLoggedInUser");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_DaneSzukajPodmiotyKomunikatyOBledachId",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "DaneSzukajPodmiotyKomunikatyOBledachId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "DaneSzukajPodmiotyParametryWyszukiwaniaId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_DateOfCreate",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "DateOfCreate");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_DateOfModification",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "DateOfModification");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_Id",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawAdresEmail",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawAdresEmail");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawAdresStronyinternetowej",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawAdresStronyinternetowej");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawAdSiedzGminaNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawAdSiedzGminaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawAdSiedzGminaSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawAdSiedzGminaSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawAdSiedzKodPocztowy",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawAdSiedzKodPocztowy");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawAdSiedzKrajNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawAdSiedzKrajNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawAdSiedzKrajSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawAdSiedzKrajSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawAdSiedzMiejscowoscNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawAdSiedzMiejscowoscNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawAdSiedzMiejscowoscPocztyNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawAdSiedzMiejscowoscPocztyNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawAdSiedzMiejscowoscPocztySymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawAdSiedzMiejscowoscPocztySymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawAdSiedzMiejscowoscSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawAdSiedzMiejscowoscSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawAdSiedzNietypoweMiejsceLokalizacji",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawAdSiedzNietypoweMiejsceLokalizacji");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawAdSiedzNumerLokalu",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawAdSiedzNumerLokalu");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawAdSiedzNumerNieruchomosci",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawAdSiedzNumerNieruchomosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawAdSiedzPowiatNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawAdSiedzPowiatNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawAdSiedzPowiatSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawAdSiedzPowiatSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawAdSiedzUlicaNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawAdSiedzUlicaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawAdSiedzUlicaSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawAdSiedzUlicaSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawAdSiedzWojewodztwoNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawAdSiedzWojewodztwoNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawAdSiedzWojewodztwoSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawAdSiedzWojewodztwoSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawDataOrzeczeniaOUpadlosci",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawDataOrzeczeniaOUpadlosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawDataPowstania",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawDataPowstania");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawDataRozpoczeciaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawDataRozpoczeciaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawDataSkresleniaZRegon",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawDataSkresleniaZRegon");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawDataWpisuDoRegon",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawDataWpisuDoRegon");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawDataWpisuDoRejestruEwidencji",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawDataWpisuDoRejestruEwidencji");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawDataWznowieniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawDataWznowieniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawDataZaistnieniaZmiany",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawDataZaistnieniaZmiany");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawDataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawDataZakonczeniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawDataZakonczeniaPostepowaniaUpadlosciowego",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawDataZakonczeniaPostepowaniaUpadlosciowego");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawDataZawieszeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawDataZawieszeniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawFormaFinansowaniaNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawFormaFinansowaniaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawFormaFinansowaniaSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawFormaFinansowaniaSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawFormaWlasnosciNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawFormaWlasnosciNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawFormaWlasnosciSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawFormaWlasnosciSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawLiczbaJednLokalnych",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawLiczbaJednLokalnych");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawNazwaSkrocona",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawNazwaSkrocona");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawNip",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawNip");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawNumerFaksu",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawNumerFaksu");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawNumerTelefonu",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawNumerTelefonu");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawNumerWewnetrznyTelefonu",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawNumerWewnetrznyTelefonu");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawNumerWRejestrzeEwidencji",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawNumerWRejestrzeEwidencji");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawOrganRejestrowyNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawOrganRejestrowyNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawOrganRejestrowySymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawOrganRejestrowySymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawOrganZalozycielskiNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawOrganZalozycielskiNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawOrganZalozycielskiSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawOrganZalozycielskiSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawPodstawowaFormaPrawnaNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawPodstawowaFormaPrawnaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawPodstawowaFormaPrawnaSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawPodstawowaFormaPrawnaSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawRegon9",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawRegon9");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawRodzajRejestruEwidencjiNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawRodzajRejestruEwidencjiNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawRodzajRejestruEwidencjiSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawRodzajRejestruEwidencjiSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawStatusNip",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawStatusNip");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawSzczegolnaFormaPrawnaNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawSzczegolnaFormaPrawnaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_PrawSzczegolnaFormaPrawnaSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "PrawSzczegolnaFormaPrawnaSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawna_UniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "BIR11OsPrawna",
                column: "UniqueIdentifierOfTheLoggedInUser");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_DaneSzukajPodmiotyId",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "DaneSzukajPodmiotyId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_DaneSzukajPodmiotyKomunikatyOBledachId",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "DaneSzukajPodmiotyKomunikatyOBledachId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "DaneSzukajPodmiotyParametryWyszukiwaniaId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_DateOfCreate",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "DateOfCreate");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_DateOfModification",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "DateOfModification");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_Id",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzGminaNazwa",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "LokprawAdSiedzGminaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzGminaSymbol",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "LokprawAdSiedzGminaSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzKodPocztowy",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "LokprawAdSiedzKodPocztowy");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzKrajSymbol",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "LokprawAdSiedzKrajSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzMiejscowoscNazwa",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "LokprawAdSiedzMiejscowoscNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzMiejscowoscPocztyNazwa",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "LokprawAdSiedzMiejscowoscPocztyNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzMiejscowoscPocztySymbol",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "LokprawAdSiedzMiejscowoscPocztySymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzMiejscowoscSymbol",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "LokprawAdSiedzMiejscowoscSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzNietypoweMiejsceLokalizacji",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "LokprawAdSiedzNietypoweMiejsceLokalizacji");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzNumerLokalu",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "LokprawAdSiedzNumerLokalu");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzNumerNieruchomosci",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "LokprawAdSiedzNumerNieruchomosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzPowiatNazwa",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "LokprawAdSiedzPowiatNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzPowiatSymbol",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "LokprawAdSiedzPowiatSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzUlicaNazwa",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "LokprawAdSiedzUlicaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzUlicaSymbol",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "LokprawAdSiedzUlicaSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzWojewodztwoNazwa",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "LokprawAdSiedzWojewodztwoNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzWojewodztwoSymbol",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "LokprawAdSiedzWojewodztwoSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_LokprawDataPowstania",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "LokprawDataPowstania");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_LokprawDataRozpoczeciaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "LokprawDataRozpoczeciaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_LokprawDataSkresleniaZRegon",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "LokprawDataSkresleniaZRegon");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_LokprawDataWpisuDoRegon",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "LokprawDataWpisuDoRegon");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_LokprawDataWznowieniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "LokprawDataWznowieniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_LokprawDataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "LokprawDataZakonczeniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_LokprawDataZawieszeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "LokprawDataZawieszeniaDzialalnosci");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_LokprawNazwa",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "LokprawNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_LokprawRegon14",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "LokprawRegon14");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaListaJednLokalnych_UniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                column: "UniqueIdentifierOfTheLoggedInUser");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaPkd_DaneSzukajPodmiotyId",
                schema: "pagard",
                table: "BIR11OsPrawnaPkd",
                column: "DaneSzukajPodmiotyId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaPkd_DaneSzukajPodmiotyKomunikatyOBledachId",
                schema: "pagard",
                table: "BIR11OsPrawnaPkd",
                column: "DaneSzukajPodmiotyKomunikatyOBledachId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaPkd_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                schema: "pagard",
                table: "BIR11OsPrawnaPkd",
                column: "DaneSzukajPodmiotyParametryWyszukiwaniaId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaPkd_DateOfCreate",
                schema: "pagard",
                table: "BIR11OsPrawnaPkd",
                column: "DateOfCreate");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaPkd_DateOfModification",
                schema: "pagard",
                table: "BIR11OsPrawnaPkd",
                column: "DateOfModification");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaPkd_Id",
                schema: "pagard",
                table: "BIR11OsPrawnaPkd",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaPkd_PrawPkdKod",
                schema: "pagard",
                table: "BIR11OsPrawnaPkd",
                column: "PrawPkdKod");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaPkd_PrawPkdNazwa",
                schema: "pagard",
                table: "BIR11OsPrawnaPkd",
                column: "PrawPkdNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaPkd_PrawPkdPrzewazajace",
                schema: "pagard",
                table: "BIR11OsPrawnaPkd",
                column: "PrawPkdPrzewazajace");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaPkd_UniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "BIR11OsPrawnaPkd",
                column: "UniqueIdentifierOfTheLoggedInUser");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaSpCywilnaWspolnicy_DaneSzukajPodmiotyId",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                column: "DaneSzukajPodmiotyId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaSpCywilnaWspolnicy_DaneSzukajPodmiotyKomunikatyOBledachId",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                column: "DaneSzukajPodmiotyKomunikatyOBledachId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaSpCywilnaWspolnicy_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                column: "DaneSzukajPodmiotyParametryWyszukiwaniaId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaSpCywilnaWspolnicy_DateOfCreate",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                column: "DateOfCreate");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaSpCywilnaWspolnicy_DateOfModification",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                column: "DateOfModification");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaSpCywilnaWspolnicy_Id",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaSpCywilnaWspolnicy_UniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                column: "UniqueIdentifierOfTheLoggedInUser");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaSpCywilnaWspolnicy_WspolscFirmaNazwa",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                column: "WspolscFirmaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaSpCywilnaWspolnicy_WspolscImieDrugie",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                column: "WspolscImieDrugie");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaSpCywilnaWspolnicy_WspolscImiePierwsze",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                column: "WspolscImiePierwsze");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaSpCywilnaWspolnicy_WspolscNazwisko",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                column: "WspolscNazwisko");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11OsPrawnaSpCywilnaWspolnicy_WspolscRegonWspolnikSpolki",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                column: "WspolscRegonWspolnikSpolki");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11TypPodmiotu_DaneSzukajPodmiotyKomunikatyOBledachId",
                schema: "pagard",
                table: "BIR11TypPodmiotu",
                column: "DaneSzukajPodmiotyKomunikatyOBledachId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11TypPodmiotu_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                schema: "pagard",
                table: "BIR11TypPodmiotu",
                column: "DaneSzukajPodmiotyParametryWyszukiwaniaId");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11TypPodmiotu_DateOfCreate",
                schema: "pagard",
                table: "BIR11TypPodmiotu",
                column: "DateOfCreate");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11TypPodmiotu_DateOfModification",
                schema: "pagard",
                table: "BIR11TypPodmiotu",
                column: "DateOfModification");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11TypPodmiotu_Id",
                schema: "pagard",
                table: "BIR11TypPodmiotu",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BIR11TypPodmiotu_Typ",
                schema: "pagard",
                table: "BIR11TypPodmiotu",
                column: "Typ");

            migrationBuilder.CreateIndex(
                name: "IX_BIR11TypPodmiotu_UniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "BIR11TypPodmiotu",
                column: "UniqueIdentifierOfTheLoggedInUser");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyKomunikatyOBledach_DataModyfikacji",
                schema: "pagard",
                table: "DaneSzukajPodmiotyKomunikatyOBledach",
                column: "DataModyfikacji");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyKomunikatyOBledach_DataUtworzenia",
                schema: "pagard",
                table: "DaneSzukajPodmiotyKomunikatyOBledach",
                column: "DataUtworzenia");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyKomunikatyOBledach_Id",
                schema: "pagard",
                table: "DaneSzukajPodmiotyKomunikatyOBledach",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyKomunikatyOBledach_Krs",
                schema: "pagard",
                table: "DaneSzukajPodmiotyKomunikatyOBledach",
                column: "Krs");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyKomunikatyOBledach_Krsy",
                schema: "pagard",
                table: "DaneSzukajPodmiotyKomunikatyOBledach",
                column: "Krsy");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyKomunikatyOBledach_Nip",
                schema: "pagard",
                table: "DaneSzukajPodmiotyKomunikatyOBledach",
                column: "Nip");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyKomunikatyOBledach_Nipy",
                schema: "pagard",
                table: "DaneSzukajPodmiotyKomunikatyOBledach",
                column: "Nipy");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyKomunikatyOBledach_Regon",
                schema: "pagard",
                table: "DaneSzukajPodmiotyKomunikatyOBledach",
                column: "Regon");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyKomunikatyOBledach_Regony14zn",
                schema: "pagard",
                table: "DaneSzukajPodmiotyKomunikatyOBledach",
                column: "Regony14zn");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyKomunikatyOBledach_Regony9zn",
                schema: "pagard",
                table: "DaneSzukajPodmiotyKomunikatyOBledach",
                column: "Regony9zn");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyKomunikatyOBledach_UniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "DaneSzukajPodmiotyKomunikatyOBledach",
                column: "UniqueIdentifierOfTheLoggedInUser");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyMessageInspector_DaneSzukajPodmiotyId",
                schema: "pagard",
                table: "DaneSzukajPodmiotyMessageInspector",
                column: "DaneSzukajPodmiotyId");

            migrationBuilder.CreateIndex(
                name: "IX_DaneSzukajPodmiotyMessageInspector_MessageInspectorId",
                schema: "pagard",
                table: "DaneSzukajPodmiotyMessageInspector",
                column: "MessageInspectorId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageInspector_DataModyfikacji",
                schema: "pagard",
                table: "MessageInspector",
                column: "DataModyfikacji");

            migrationBuilder.CreateIndex(
                name: "IX_MessageInspector_DataUtworzenia",
                schema: "pagard",
                table: "MessageInspector",
                column: "DataUtworzenia");

            migrationBuilder.CreateIndex(
                name: "IX_MessageInspector_Id",
                schema: "pagard",
                table: "MessageInspector",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MessageInspector_UniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "MessageInspector",
                column: "UniqueIdentifierOfTheLoggedInUser");

            migrationBuilder.AddForeignKey(
                name: "FK_DaneSzukajPodmioty_BIR11JednLokalnaOsFizycznej_BIR11JednLokalnaOsFizycznejId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "BIR11JednLokalnaOsFizycznejId",
                principalSchema: "pagard",
                principalTable: "BIR11JednLokalnaOsFizycznej",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DaneSzukajPodmioty_BIR11JednLokalnaOsPrawnej_BIR11JednLokalnaOsPrawnejId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "BIR11JednLokalnaOsPrawnejId",
                principalSchema: "pagard",
                principalTable: "BIR11JednLokalnaOsPrawnej",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DaneSzukajPodmioty_BIR11OsFizycznaDaneOgolne_BIR11OsFizycznaDaneOgolneId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "BIR11OsFizycznaDaneOgolneId",
                principalSchema: "pagard",
                principalTable: "BIR11OsFizycznaDaneOgolne",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DaneSzukajPodmioty_BIR11OsFizycznaDzialalnoscCeidg_BIR11OsFizycznaDzialalnoscCeidgId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "BIR11OsFizycznaDzialalnoscCeidgId",
                principalSchema: "pagard",
                principalTable: "BIR11OsFizycznaDzialalnoscCeidg",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DaneSzukajPodmioty_BIR11OsFizycznaDzialalnoscPozostala_BIR11OsFizycznaDzialalnoscPozostalaId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "BIR11OsFizycznaDzialalnoscPozostalaId",
                principalSchema: "pagard",
                principalTable: "BIR11OsFizycznaDzialalnoscPozostala",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DaneSzukajPodmioty_BIR11OsFizycznaDzialalnoscRolnicza_BIR11OsFizycznaDzialalnoscRolniczaId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "BIR11OsFizycznaDzialalnoscRolniczaId",
                principalSchema: "pagard",
                principalTable: "BIR11OsFizycznaDzialalnoscRolnicza",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DaneSzukajPodmioty_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id",
                principalSchema: "pagard",
                principalTable: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DaneSzukajPodmioty_BIR11OsPrawna_BIR11OsPrawnaId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "BIR11OsPrawnaId",
                principalSchema: "pagard",
                principalTable: "BIR11OsPrawna",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DaneSzukajPodmioty_BIR11TypPodmiotu_BIR11TypPodmiotuId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "BIR11TypPodmiotuId",
                principalSchema: "pagard",
                principalTable: "BIR11TypPodmiotu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DaneSzukajPodmioty_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "DaneSzukajPodmiotyKomunikatyOBledachId",
                principalSchema: "pagard",
                principalTable: "DaneSzukajPodmiotyKomunikatyOBledach",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DaneSzukajPodmioty_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                column: "DaneSzukajPodmiotyParametryWyszukiwaniaId",
                principalSchema: "pagard",
                principalTable: "DaneSzukajPodmiotyParametryWyszukiwania",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DaneSzukajPodmioty_BIR11JednLokalnaOsFizycznej_BIR11JednLokalnaOsFizycznejId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropForeignKey(
                name: "FK_DaneSzukajPodmioty_BIR11JednLokalnaOsPrawnej_BIR11JednLokalnaOsPrawnejId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropForeignKey(
                name: "FK_DaneSzukajPodmioty_BIR11OsFizycznaDaneOgolne_BIR11OsFizycznaDaneOgolneId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropForeignKey(
                name: "FK_DaneSzukajPodmioty_BIR11OsFizycznaDzialalnoscCeidg_BIR11OsFizycznaDzialalnoscCeidgId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropForeignKey(
                name: "FK_DaneSzukajPodmioty_BIR11OsFizycznaDzialalnoscPozostala_BIR11OsFizycznaDzialalnoscPozostalaId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropForeignKey(
                name: "FK_DaneSzukajPodmioty_BIR11OsFizycznaDzialalnoscRolnicza_BIR11OsFizycznaDzialalnoscRolniczaId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropForeignKey(
                name: "FK_DaneSzukajPodmioty_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropForeignKey(
                name: "FK_DaneSzukajPodmioty_BIR11OsPrawna_BIR11OsPrawnaId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropForeignKey(
                name: "FK_DaneSzukajPodmioty_BIR11TypPodmiotu_BIR11TypPodmiotuId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropForeignKey(
                name: "FK_DaneSzukajPodmioty_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropForeignKey(
                name: "FK_DaneSzukajPodmioty_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropTable(
                name: "BIR11JednLokalnaOsFizycznej",
                schema: "pagard");

            migrationBuilder.DropTable(
                name: "BIR11JednLokalnaOsFizycznejPkd",
                schema: "pagard");

            migrationBuilder.DropTable(
                name: "BIR11JednLokalnaOsPrawnej",
                schema: "pagard");

            migrationBuilder.DropTable(
                name: "BIR11JednLokalnaOsPrawnejPkd",
                schema: "pagard");

            migrationBuilder.DropTable(
                name: "BIR11OsFizycznaDaneOgolne",
                schema: "pagard");

            migrationBuilder.DropTable(
                name: "BIR11OsFizycznaDzialalnoscCeidg",
                schema: "pagard");

            migrationBuilder.DropTable(
                name: "BIR11OsFizycznaDzialalnoscPozostala",
                schema: "pagard");

            migrationBuilder.DropTable(
                name: "BIR11OsFizycznaDzialalnoscRolnicza",
                schema: "pagard");

            migrationBuilder.DropTable(
                name: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                schema: "pagard");

            migrationBuilder.DropTable(
                name: "BIR11OsFizycznaListaJednLokalnych",
                schema: "pagard");

            migrationBuilder.DropTable(
                name: "BIR11OsFizycznaPkd",
                schema: "pagard");

            migrationBuilder.DropTable(
                name: "BIR11OsPrawna",
                schema: "pagard");

            migrationBuilder.DropTable(
                name: "BIR11OsPrawnaListaJednLokalnych",
                schema: "pagard");

            migrationBuilder.DropTable(
                name: "BIR11OsPrawnaPkd",
                schema: "pagard");

            migrationBuilder.DropTable(
                name: "BIR11OsPrawnaSpCywilnaWspolnicy",
                schema: "pagard");

            migrationBuilder.DropTable(
                name: "BIR11TypPodmiotu",
                schema: "pagard");

            migrationBuilder.DropTable(
                name: "DaneSzukajPodmiotyMessageInspector",
                schema: "pagard");

            migrationBuilder.DropTable(
                name: "DaneSzukajPodmiotyKomunikatyOBledach",
                schema: "pagard");

            migrationBuilder.DropTable(
                name: "MessageInspector",
                schema: "pagard");

            migrationBuilder.DropIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwania_DataModyfikacji",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania");

            migrationBuilder.DropIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwania_DataUtworzenia",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania");

            migrationBuilder.DropIndex(
                name: "IX_DaneSzukajPodmioty_BIR11JednLokalnaOsFizycznejId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropIndex(
                name: "IX_DaneSzukajPodmioty_BIR11JednLokalnaOsPrawnejId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropIndex(
                name: "IX_DaneSzukajPodmioty_BIR11OsFizycznaDaneOgolneId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropIndex(
                name: "IX_DaneSzukajPodmioty_BIR11OsFizycznaDzialalnoscCeidgId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropIndex(
                name: "IX_DaneSzukajPodmioty_BIR11OsFizycznaDzialalnoscPozostalaId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropIndex(
                name: "IX_DaneSzukajPodmioty_BIR11OsFizycznaDzialalnoscRolniczaId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropIndex(
                name: "IX_DaneSzukajPodmioty_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropIndex(
                name: "IX_DaneSzukajPodmioty_BIR11OsPrawnaId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropIndex(
                name: "IX_DaneSzukajPodmioty_BIR11TypPodmiotuId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropIndex(
                name: "IX_DaneSzukajPodmioty_DaneSzukajPodmiotyKomunikatyOBledachId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropIndex(
                name: "IX_DaneSzukajPodmioty_DaneSzukajPodmiotyParametryWyszukiwaniaId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropIndex(
                name: "IX_DaneSzukajPodmioty_DataModyfikacji",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropIndex(
                name: "IX_DaneSzukajPodmioty_DataUtworzenia",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropIndex(
                name: "IX_DaneSzukajPodmioty_DataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropIndex(
                name: "IX_DaneSzukajPodmioty_NrLokalu",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropIndex(
                name: "IX_DaneSzukajPodmioty_NrNieruchomosci",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropIndex(
                name: "IX_DaneSzukajPodmioty_StatusNip",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropColumn(
                name: "BIR11JednLokalnaOsFizycznejId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropColumn(
                name: "BIR11JednLokalnaOsPrawnejId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropColumn(
                name: "BIR11OsFizycznaDaneOgolneId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropColumn(
                name: "BIR11OsFizycznaDzialalnoscCeidgId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropColumn(
                name: "BIR11OsFizycznaDzialalnoscPozostalaId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropColumn(
                name: "BIR11OsFizycznaDzialalnoscRolniczaId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropColumn(
                name: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropColumn(
                name: "BIR11OsPrawnaId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropColumn(
                name: "BIR11TypPodmiotuId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropColumn(
                name: "DaneSzukajPodmiotyKomunikatyOBledachId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropColumn(
                name: "DaneSzukajPodmiotyParametryWyszukiwaniaId",
                schema: "pagard",
                table: "DaneSzukajPodmioty");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwania_UniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                newName: "IX_DaneSzukajPodmiotyParametryWyszukiwaniaUniqueIdentifierOfTheLoggedInUser");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwania_Regony9zn",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                newName: "IX_DaneSzukajPodmiotyParametryWyszukiwaniaRegony9zn");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwania_Regony14zn",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                newName: "IX_DaneSzukajPodmiotyParametryWyszukiwaniaRegony14zn");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwania_Regon",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                newName: "IX_DaneSzukajPodmiotyParametryWyszukiwaniaRegon");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwania_Nipy",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                newName: "IX_DaneSzukajPodmiotyParametryWyszukiwaniaNipy");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwania_Nip",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                newName: "IX_DaneSzukajPodmiotyParametryWyszukiwaniaNip");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwania_Krsy",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                newName: "IX_DaneSzukajPodmiotyParametryWyszukiwaniaKrsy");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwania_Krs",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                newName: "IX_DaneSzukajPodmiotyParametryWyszukiwaniaKrs");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmiotyParametryWyszukiwania_Id",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                newName: "IX_DaneSzukajPodmiotyParametryWyszukiwaniaId");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmioty_Wojewodztwo",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmiotyWojewodztwo");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmioty_UniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmiotyUniqueIdentifierOfTheLoggedInUser");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmioty_Ulica",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmiotyUlica");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmioty_Typ",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmiotyTyp");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmioty_SilosID",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmiotySilosID");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmioty_Regon",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmiotyRegon");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmioty_Powiat",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmiotyPowiat");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmioty_Nip",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmiotyNip");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmioty_Nazwa",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmiotyNazwa");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmioty_MiejscowoscPoczty",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmiotySilosMiejscowoscPoczty");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmioty_Miejscowosc",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmiotyMiejscowosc");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmioty_KodPocztowy",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmiotyKodPocztowy");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmioty_Id",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmiotyId");

            migrationBuilder.RenameIndex(
                name: "IX_DaneSzukajPodmioty_Gmina",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                newName: "IX_DaneSzukajPodmiotyGmina");

            migrationBuilder.AlterColumn<string>(
                name: "UniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                type: "varchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataUtworzenia",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                type: "datetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataModyfikacji",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SHA512",
                schema: "pagard",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                type: "nvarchar(max)",
                maxLength: 2147483647,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Wojewodztwo",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "UniqueIdentifierOfTheLoggedInUser",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "varchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ulica",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Typ",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "StatusNip",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "Regon",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "Powiat",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "NrNieruchomosci",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "NrLokalu",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Nip",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Nazwa",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "MiejscowoscPoczty",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Miejscowosc",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "KodPocztowy",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "Gmina",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "DataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataUtworzenia",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "datetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataModyfikacji",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParametryWyszukiwaniaJson",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(max)",
                maxLength: 2147483647,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParametryWyszukiwaniaSHA512",
                schema: "pagard",
                table: "DaneSzukajPodmioty",
                type: "nvarchar(max)",
                maxLength: 2147483647,
                nullable: true);
        }
    }
}
