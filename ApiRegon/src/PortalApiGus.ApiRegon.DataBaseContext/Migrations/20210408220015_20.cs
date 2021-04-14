using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApiGus.ApiRegon.DataBase.Migrations
{
    public partial class _20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Typ",
                schema: "pagard",
                table: "BIR11TypPodmiotu",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11TypPodmiotu",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11TypPodmiotu",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "WspolscRegonWspolnikSpolki",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "WspolscNazwisko",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "WspolscImiePierwsze",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "WspolscImieDrugie",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "WspolscFirmaNazwa",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PrawPkdPrzewazajace",
                schema: "pagard",
                table: "BIR11OsPrawnaPkd",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "PrawPkdNazwa",
                schema: "pagard",
                table: "BIR11OsPrawnaPkd",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "PrawPkdKod",
                schema: "pagard",
                table: "BIR11OsPrawnaPkd",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11OsPrawnaPkd",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11OsPrawnaPkd",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LokprawRegon14",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawNazwa",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(254)",
                maxLength: 254,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(254)",
                oldMaxLength: 254);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataZawieszeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataWznowieniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataWpisuDoRegon",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataSkresleniaZRegon",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataRozpoczeciaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataPowstania",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzWojewodztwoSymbol",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzWojewodztwoNazwa",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzUlicaSymbol",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzUlicaNazwa",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(351)",
                maxLength: 351,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(351)",
                oldMaxLength: 351);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzPowiatSymbol",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzPowiatNazwa",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzNumerNieruchomosci",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzNumerLokalu",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzNietypoweMiejsceLokalizacji",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(160)",
                maxLength: 160,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(160)",
                oldMaxLength: 160);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzMiejscowoscSymbol",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzMiejscowoscPocztySymbol",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzMiejscowoscPocztyNazwa",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzMiejscowoscNazwa",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzKrajSymbol",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzKodPocztowy",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzGminaSymbol",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzGminaNazwa",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PrawSzczegolnaFormaPrawnaSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "PrawSzczegolnaFormaPrawnaNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "PrawStatusNip",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "PrawRodzajRejestruEwidencjiSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "PrawRodzajRejestruEwidencjiNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240);

            migrationBuilder.AlterColumn<string>(
                name: "PrawRegon9",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "PrawPodstawowaFormaPrawnaSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "PrawPodstawowaFormaPrawnaNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "PrawOrganZalozycielskiSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "PrawOrganZalozycielskiNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "PrawOrganRejestrowySymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "PrawOrganRejestrowyNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240);

            migrationBuilder.AlterColumn<string>(
                name: "PrawNumerWewnetrznyTelefonu",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6);

            migrationBuilder.AlterColumn<string>(
                name: "PrawNumerWRejestrzeEwidencji",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PrawNumerTelefonu",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18);

            migrationBuilder.AlterColumn<string>(
                name: "PrawNumerFaksu",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18);

            migrationBuilder.AlterColumn<string>(
                name: "PrawNip",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "PrawNazwaSkrocona",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "PrawNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<int>(
                name: "PrawLiczbaJednLokalnych",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PrawFormaWlasnosciSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PrawFormaWlasnosciNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240);

            migrationBuilder.AlterColumn<string>(
                name: "PrawFormaFinansowaniaSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "PrawFormaFinansowaniaNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240);

            migrationBuilder.AlterColumn<string>(
                name: "PrawDataZawieszeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "PrawDataZakonczeniaPostepowaniaUpadlosciowego",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "PrawDataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "PrawDataZaistnieniaZmiany",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "PrawDataWznowieniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "PrawDataWpisuDoRejestruEwidencji",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "PrawDataWpisuDoRegon",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "PrawDataSkresleniaZRegon",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "PrawDataRozpoczeciaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "PrawDataPowstania",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "PrawDataOrzeczeniaOUpadlosci",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdresStronyinternetowej",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdresEmail",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzWojewodztwoSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzWojewodztwoNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzUlicaSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzUlicaNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(351)",
                maxLength: 351,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(351)",
                oldMaxLength: 351);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzPowiatSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzPowiatNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzNumerNieruchomosci",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzNumerLokalu",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzNietypoweMiejsceLokalizacji",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(160)",
                maxLength: 160,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(160)",
                oldMaxLength: 160);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzMiejscowoscSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzMiejscowoscPocztySymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzMiejscowoscPocztyNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzMiejscowoscNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzKrajSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzKrajNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzKodPocztowy",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzGminaSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzGminaNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FizSilosSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<int>(
                name: "FizSilosID",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FizPkdPrzewazajace",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "FizPkdNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "FizPkdKod",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataSkresleniaDzialalnosciZRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LokfizSilosSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<int>(
                name: "LokfizSilosID",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "LokfizRegon14",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataZawieszeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataWznowieniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataWpisuDoRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataSkresleniaZRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataRozpoczeciaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataPowstania",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzWojewodztwoSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzWojewodztwoNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzUlicaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzUlicaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(350)",
                maxLength: 350,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(350)",
                oldMaxLength: 350);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzPowiatSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzPowiatNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzNumerNieruchomosci",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzNumerLokalu",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzNietypoweMiejsceLokalizacji",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzMiejscowoscSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzMiejscowoscPocztySymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzMiejscowoscPocztyNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzMiejscowoscNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzKrajSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzKodPocztowy",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzGminaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzGminaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FizRegon9",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "FizNumerWewnetrznyTelefonu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "FizNumerTelefonu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "FizNumerFaksu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "FizNazwaSkrocona",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "FizNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZawieszeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZaistnieniaZmianyDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataWznowieniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataWpisuDzialalnosciDoRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataSkresleniaDzialalnosciZRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataRozpoczeciaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataPowstania",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdresStronyinternetowej",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdresEmail2",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdresEmail",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzWojewodztwoSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzWojewodztwoNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzUlicaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzUlicaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(351)",
                maxLength: 351,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(351)",
                oldMaxLength: 351);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzPowiatSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzPowiatNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzNumerNieruchomosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzNumerLokalu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzNietypoweMiejsceLokalizacji",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(160)",
                maxLength: 160,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(160)",
                oldMaxLength: 160);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscPocztySymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscPocztyNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzKrajSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzKrajNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzKodPocztowy",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzGminaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzGminaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FizRegon9",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "FizNumerWewnetrznyTelefonu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6);

            migrationBuilder.AlterColumn<string>(
                name: "FizNumerTelefonu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18);

            migrationBuilder.AlterColumn<string>(
                name: "FizNumerFaksu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18);

            migrationBuilder.AlterColumn<string>(
                name: "FizNazwaSkrocona",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "FizNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZawieszeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZakonczeniaPostepowaniaUpadlosciowego",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZaistnieniaZmianyDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataWznowieniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataWpisuDzialalnosciDoRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataSkresleniaDzialalanosciZRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataRozpoczeciaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataPowstania",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataOrzeczeniaOUpadlosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdresStronyinternetowej",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdresEmail",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzWojewodztwoSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzWojewodztwoNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzUlicaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzUlicaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(351)",
                maxLength: 351,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(351)",
                oldMaxLength: 351);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzPowiatSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzPowiatNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzNumerNieruchomosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzNumerLokalu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzNietypoweMiejsceLokalizacji",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(160)",
                maxLength: 160,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(160)",
                oldMaxLength: 160);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscPocztySymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscPocztyNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzKrajSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzKrajNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzKodPocztowy",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzGminaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzGminaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FizRegon9",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "FizPRodzajRejestruSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "FizPRodzajRejestruNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240);

            migrationBuilder.AlterColumn<string>(
                name: "FizPOrganRejestrowySymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "FizPOrganRejestrowyNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240);

            migrationBuilder.AlterColumn<string>(
                name: "FizPNumerWRejestrzeEwidencji",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FizPDataWpisuDoRejestruEwidencji",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizNumerWewnetrznyTelefonu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6);

            migrationBuilder.AlterColumn<string>(
                name: "FizNumerTelefonu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18);

            migrationBuilder.AlterColumn<string>(
                name: "FizNumerFaksu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18);

            migrationBuilder.AlterColumn<string>(
                name: "FizNazwaSkrocona",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "FizNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZawieszeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZakonczeniaPostepowaniaUpadlosciowego",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZaistnieniaZmianyDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataWznowieniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataWpisuDzialalnosciDoRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataSkresleniaDzialalnosciZRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataRozpoczeciaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataPowstania",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataOrzeczeniaOUpadlosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdresStronyinternetowej",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdresEmail",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzWojewodztwoSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzWojewodztwoNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzUlicaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzUlicaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(351)",
                maxLength: 351,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(351)",
                oldMaxLength: 351);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzPowiatSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzPowiatNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzNumerNieruchomosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzNumerLokalu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzNietypoweMiejsceLokalizacji",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(160)",
                maxLength: 160,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(160)",
                oldMaxLength: 160);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscPocztySymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscPocztyNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzKrajSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzKrajNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzKodPocztowy",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzGminaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzGminaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FizRegon9",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "FizNumerWewnetrznyTelefonu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "FizNumerTelefonu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "FizNumerFaksu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "FizNazwaSkrocona",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "FizNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZawieszeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZakonczeniaPostepowaniaUpadlosciowego",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZaistnieniaZmianyDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataWznowieniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataWpisuDzialalnosciDoRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataSkresleniaDzialalnosciZRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataRozpoczeciaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataPowstania",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataOrzeczeniaOUpadlosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizCRodzajRejestruSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "FizCRodzajRejestruNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240);

            migrationBuilder.AlterColumn<string>(
                name: "FizCOrganRejestrowySymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "FizCOrganRejestrowyNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240);

            migrationBuilder.AlterColumn<string>(
                name: "FizCNumerWRejestrzeEwidencji",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<bool>(
                name: "FizCNiePodjetoDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "FizCDataWpisuDoRejestruEwidencji",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizCDataSkresleniaZRejestruEwidencji",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdresStronyinternetowej",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdresEmail",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzWojewodztwoSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzWojewodztwoNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzUlicaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzUlicaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(351)",
                maxLength: 351,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(351)",
                oldMaxLength: 351);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzPowiatSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzPowiatNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzNumerNieruchomosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzNumerLokalu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzNietypoweMiejsceLokalizacji",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(160)",
                maxLength: 160,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(160)",
                oldMaxLength: 160);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscPocztySymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscPocztyNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzKrajSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzKrajNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzKodPocztowy",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzGminaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzGminaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FizSzczegolnaFormaPrawnaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "FizSzczegolnaFormaPrawnaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "FizStatusNip",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "FizRegon9",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "FizPodstawowaFormaPrawnaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "FizPodstawowaFormaPrawnaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "FizNip",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizNazwisko",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "FizLiczbaJednLokalnych",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FizImie2",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FizImie1",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FizFormaWlasnosciSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FizFormaWlasnosciNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240);

            migrationBuilder.AlterColumn<string>(
                name: "FizFormaFinansowaniaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "FizFormaFinansowaniaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240);

            migrationBuilder.AlterColumn<int>(
                name: "FizDzialalnoscSkreslonaDo20141108",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FizDzialalnoscRolnicza",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FizDzialalnoscPozostala",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FizDzialalnoscCeidg",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZaistnieniaZmiany",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataWpisuPodmiotuDoRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataSkresleniaPodmiotuZRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejPkd",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejPkd",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LokprawPkdPrzewazajace",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejPkd",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawPkdNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejPkd",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawPkdKod",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejPkd",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LokprawRodzajRejestruEwidencjiSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawRodzajRejestruEwidencjiNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawRegon14",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawOrganRejestrowySymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawOrganRejestrowyNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawNumerWrejestrzeEwidencji",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(254)",
                maxLength: 254,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(254)",
                oldMaxLength: 254);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawFormaFinansowaniaSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawFormaFinansowaniaNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataZawieszeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataZaistnieniaZmiany",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataWznowieniaDzialalnosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataWpisuDoRejestruEwidencji",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataWpisuDoRegon",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataSkresleniaZRegon",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataRozpoczeciaDzialalnosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataPowstania",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzWojewodztwoSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzWojewodztwoNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzUlicaSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzUlicaNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(351)",
                maxLength: 351,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(351)",
                oldMaxLength: 351);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzPowiatSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzPowiatNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzNumerNieruchomosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzNumerLokalu",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzNietypoweMiejsceLokalizacji",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(160)",
                maxLength: 160,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(160)",
                oldMaxLength: 160);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzMiejscowoscSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzMiejscowoscPocztySymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzMiejscowoscPocztyNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzMiejscowoscNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzKrajSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzKrajNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzKodPocztowy",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzGminaSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzGminaNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkd",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkd",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LokfizSilosSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkd",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizPkdPrzewazajace",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkd",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizPkdNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkd",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizPkdKod",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkd",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LokfizSilosNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<int>(
                name: "LokfizSilosID",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "LokfizRodzajRejestruSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizRodzajRejestruNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizRegon14",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizOrganRejestrowySymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizOrganRejestrowyNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizNumerwRejestrzeEwidencji",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizFormaFinansowaniaSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizFormaFinansowaniaNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataZawieszeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataZaistnieniaZmiany",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataWznowieniaDzialalnosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataWpisuDoRejestruEwidencji",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataWpisuDoRegon",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataSkresleniaZRegon",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataRozpoczeciaDzialalnosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataPowstania",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<bool>(
                name: "LokfizCNiePodjetoDzialalnosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzWojewodztwoSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzWojewodztwoNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzUlicaSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzUlicaNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(350)",
                maxLength: 350,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(350)",
                oldMaxLength: 350);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzPowiatSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzPowiatNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzNumerNieruchomosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzNumerLokalu",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzNietypoweMiejsceLokalizacji",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzMiejscowoscSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzMiejscowoscPocztySymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzMiejscowoscPocztyNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzMiejscowoscNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzKrajSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzKrajNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzKodPocztowy",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzGminaSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzGminaNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Typ",
                schema: "pagard",
                table: "BIR11TypPodmiotu",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11TypPodmiotu",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11TypPodmiotu",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WspolscRegonWspolnikSpolki",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WspolscNazwisko",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WspolscImiePierwsze",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WspolscImieDrugie",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WspolscFirmaNazwa",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11OsPrawnaSpCywilnaWspolnicy",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawPkdPrzewazajace",
                schema: "pagard",
                table: "BIR11OsPrawnaPkd",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawPkdNazwa",
                schema: "pagard",
                table: "BIR11OsPrawnaPkd",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawPkdKod",
                schema: "pagard",
                table: "BIR11OsPrawnaPkd",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11OsPrawnaPkd",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11OsPrawnaPkd",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawRegon14",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawNazwa",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(254)",
                maxLength: 254,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(254)",
                oldMaxLength: 254,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataZawieszeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataWznowieniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataWpisuDoRegon",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataSkresleniaZRegon",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataRozpoczeciaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataPowstania",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzWojewodztwoSymbol",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzWojewodztwoNazwa",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzUlicaSymbol",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzUlicaNazwa",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(351)",
                maxLength: 351,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(351)",
                oldMaxLength: 351,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzPowiatSymbol",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzPowiatNazwa",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzNumerNieruchomosci",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzNumerLokalu",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzNietypoweMiejsceLokalizacji",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(160)",
                maxLength: 160,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(160)",
                oldMaxLength: 160,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzMiejscowoscSymbol",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzMiejscowoscPocztySymbol",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzMiejscowoscPocztyNazwa",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzMiejscowoscNazwa",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzKrajSymbol",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzKodPocztowy",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzGminaSymbol",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzGminaNazwa",
                schema: "pagard",
                table: "BIR11OsPrawnaListaJednLokalnych",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawSzczegolnaFormaPrawnaSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawSzczegolnaFormaPrawnaNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawStatusNip",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawRodzajRejestruEwidencjiSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawRodzajRejestruEwidencjiNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawRegon9",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawPodstawowaFormaPrawnaSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawPodstawowaFormaPrawnaNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawOrganZalozycielskiSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawOrganZalozycielskiNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawOrganRejestrowySymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawOrganRejestrowyNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawNumerWewnetrznyTelefonu",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawNumerWRejestrzeEwidencji",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawNumerTelefonu",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawNumerFaksu",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawNip",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawNazwaSkrocona",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PrawLiczbaJednLokalnych",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawFormaWlasnosciSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawFormaWlasnosciNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawFormaFinansowaniaSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawFormaFinansowaniaNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawDataZawieszeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawDataZakonczeniaPostepowaniaUpadlosciowego",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawDataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawDataZaistnieniaZmiany",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawDataWznowieniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawDataWpisuDoRejestruEwidencji",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawDataWpisuDoRegon",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawDataSkresleniaZRegon",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawDataRozpoczeciaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawDataPowstania",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawDataOrzeczeniaOUpadlosci",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdresStronyinternetowej",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdresEmail",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzWojewodztwoSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzWojewodztwoNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzUlicaSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzUlicaNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(351)",
                maxLength: 351,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(351)",
                oldMaxLength: 351,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzPowiatSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzPowiatNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzNumerNieruchomosci",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzNumerLokalu",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzNietypoweMiejsceLokalizacji",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(160)",
                maxLength: 160,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(160)",
                oldMaxLength: 160,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzMiejscowoscSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzMiejscowoscPocztySymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzMiejscowoscPocztyNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzMiejscowoscNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzKrajSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzKrajNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzKodPocztowy",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzGminaSymbol",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrawAdSiedzGminaNazwa",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11OsPrawna",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizSilosSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FizSilosID",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizPkdPrzewazajace",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizPkdNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizPkdKod",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataSkresleniaDzialalnosciZRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaPkd",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizSilosSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LokfizSilosID",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizRegon14",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataZawieszeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataWznowieniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataWpisuDoRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataSkresleniaZRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataRozpoczeciaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataPowstania",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzWojewodztwoSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzWojewodztwoNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzUlicaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzUlicaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(350)",
                maxLength: 350,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(350)",
                oldMaxLength: 350,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzPowiatSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzPowiatNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzNumerNieruchomosci",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzNumerLokalu",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzNietypoweMiejsceLokalizacji",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzMiejscowoscSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzMiejscowoscPocztySymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzMiejscowoscPocztyNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzMiejscowoscNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzKrajSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzKodPocztowy",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzGminaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzGminaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaListaJednLokalnych",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizRegon9",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizNumerWewnetrznyTelefonu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizNumerTelefonu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizNumerFaksu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizNazwaSkrocona",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZawieszeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZaistnieniaZmianyDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataWznowieniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataWpisuDzialalnosciDoRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataSkresleniaDzialalnosciZRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataRozpoczeciaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataPowstania",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdresStronyinternetowej",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdresEmail2",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdresEmail",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzWojewodztwoSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzWojewodztwoNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzUlicaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzUlicaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(351)",
                maxLength: 351,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(351)",
                oldMaxLength: 351,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzPowiatSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzPowiatNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzNumerNieruchomosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzNumerLokalu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzNietypoweMiejsceLokalizacji",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(160)",
                maxLength: 160,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(160)",
                oldMaxLength: 160,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscPocztySymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscPocztyNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzKrajSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzKrajNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzKodPocztowy",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzGminaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzGminaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizRegon9",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizNumerWewnetrznyTelefonu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizNumerTelefonu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizNumerFaksu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizNazwaSkrocona",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZawieszeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZakonczeniaPostepowaniaUpadlosciowego",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZaistnieniaZmianyDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataWznowieniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataWpisuDzialalnosciDoRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataSkresleniaDzialalanosciZRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataRozpoczeciaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataPowstania",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataOrzeczeniaOUpadlosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdresStronyinternetowej",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdresEmail",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzWojewodztwoSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzWojewodztwoNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzUlicaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzUlicaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(351)",
                maxLength: 351,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(351)",
                oldMaxLength: 351,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzPowiatSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzPowiatNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzNumerNieruchomosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzNumerLokalu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzNietypoweMiejsceLokalizacji",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(160)",
                maxLength: 160,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(160)",
                oldMaxLength: 160,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscPocztySymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscPocztyNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzKrajSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzKrajNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzKodPocztowy",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzGminaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzGminaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscRolnicza",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizRegon9",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizPRodzajRejestruSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizPRodzajRejestruNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizPOrganRejestrowySymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizPOrganRejestrowyNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizPNumerWRejestrzeEwidencji",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizPDataWpisuDoRejestruEwidencji",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizNumerWewnetrznyTelefonu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizNumerTelefonu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizNumerFaksu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizNazwaSkrocona",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZawieszeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZakonczeniaPostepowaniaUpadlosciowego",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZaistnieniaZmianyDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataWznowieniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataWpisuDzialalnosciDoRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataSkresleniaDzialalnosciZRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataRozpoczeciaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataPowstania",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataOrzeczeniaOUpadlosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdresStronyinternetowej",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdresEmail",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzWojewodztwoSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzWojewodztwoNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzUlicaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzUlicaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(351)",
                maxLength: 351,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(351)",
                oldMaxLength: 351,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzPowiatSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzPowiatNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzNumerNieruchomosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzNumerLokalu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzNietypoweMiejsceLokalizacji",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(160)",
                maxLength: 160,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(160)",
                oldMaxLength: 160,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscPocztySymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscPocztyNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzKrajSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzKrajNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzKodPocztowy",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzGminaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzGminaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscPozostala",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizRegon9",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizNumerWewnetrznyTelefonu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizNumerTelefonu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizNumerFaksu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizNazwaSkrocona",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZawieszeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZakonczeniaPostepowaniaUpadlosciowego",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZaistnieniaZmianyDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataWznowieniaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataWpisuDzialalnosciDoRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataSkresleniaDzialalnosciZRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataRozpoczeciaDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataPowstania",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataOrzeczeniaOUpadlosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizCRodzajRejestruSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizCRodzajRejestruNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizCOrganRejestrowySymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizCOrganRejestrowyNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizCNumerWRejestrzeEwidencji",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FizCNiePodjetoDzialalnosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizCDataWpisuDoRejestruEwidencji",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizCDataSkresleniaZRejestruEwidencji",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdresStronyinternetowej",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdresEmail",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzWojewodztwoSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzWojewodztwoNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzUlicaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzUlicaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(351)",
                maxLength: 351,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(351)",
                oldMaxLength: 351,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzPowiatSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzPowiatNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzNumerNieruchomosci",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzNumerLokalu",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzNietypoweMiejsceLokalizacji",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(160)",
                maxLength: 160,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(160)",
                oldMaxLength: 160,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscPocztySymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscPocztyNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzMiejscowoscNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzKrajSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzKrajNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzKodPocztowy",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzGminaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizAdSiedzGminaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDzialalnoscCeidg",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizSzczegolnaFormaPrawnaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizSzczegolnaFormaPrawnaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizStatusNip",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizRegon9",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizPodstawowaFormaPrawnaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizPodstawowaFormaPrawnaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizNip",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizNazwisko",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FizLiczbaJednLokalnych",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizImie2",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizImie1",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizFormaWlasnosciSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizFormaWlasnosciNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizFormaFinansowaniaSymbol",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizFormaFinansowaniaNazwa",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FizDzialalnoscSkreslonaDo20141108",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FizDzialalnoscRolnicza",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FizDzialalnoscPozostala",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FizDzialalnoscCeidg",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataZaistnieniaZmiany",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataWpisuPodmiotuDoRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FizDataSkresleniaPodmiotuZRegon",
                schema: "pagard",
                table: "BIR11OsFizycznaDaneOgolne",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejPkd",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejPkd",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawPkdPrzewazajace",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejPkd",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawPkdNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejPkd",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawPkdKod",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnejPkd",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawRodzajRejestruEwidencjiSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawRodzajRejestruEwidencjiNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawRegon14",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawOrganRejestrowySymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawOrganRejestrowyNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawNumerWrejestrzeEwidencji",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(254)",
                maxLength: 254,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(254)",
                oldMaxLength: 254,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawFormaFinansowaniaSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawFormaFinansowaniaNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataZawieszeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataZaistnieniaZmiany",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataWznowieniaDzialalnosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataWpisuDoRejestruEwidencji",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataWpisuDoRegon",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataSkresleniaZRegon",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataRozpoczeciaDzialalnosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawDataPowstania",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzWojewodztwoSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzWojewodztwoNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzUlicaSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzUlicaNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(351)",
                maxLength: 351,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(351)",
                oldMaxLength: 351,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzPowiatSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzPowiatNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzNumerNieruchomosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzNumerLokalu",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzNietypoweMiejsceLokalizacji",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(160)",
                maxLength: 160,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(160)",
                oldMaxLength: 160,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzMiejscowoscSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzMiejscowoscPocztySymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzMiejscowoscPocztyNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzMiejscowoscNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzKrajSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzKrajNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzKodPocztowy",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzGminaSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokprawAdSiedzGminaNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsPrawnej",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkd",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkd",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizSilosSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkd",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizPkdPrzewazajace",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkd",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizPkdNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkd",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizPkdKod",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznejPkd",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PRegon",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PNazwaRaportu",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizSilosNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LokfizSilosID",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizRodzajRejestruSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizRodzajRejestruNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizRegon14",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizOrganRejestrowySymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizOrganRejestrowyNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizNumerwRejestrzeEwidencji",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizFormaFinansowaniaSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizFormaFinansowaniaNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(240)",
                maxLength: 240,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(240)",
                oldMaxLength: 240,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataZawieszeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataZakonczeniaDzialalnosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataZaistnieniaZmiany",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataWznowieniaDzialalnosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataWpisuDoRejestruEwidencji",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataWpisuDoRegon",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataSkresleniaZRegon",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataRozpoczeciaDzialalnosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizDataPowstania",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "LokfizCNiePodjetoDzialalnosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzWojewodztwoSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzWojewodztwoNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzUlicaSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzUlicaNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(350)",
                maxLength: 350,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(350)",
                oldMaxLength: 350,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzPowiatSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzPowiatNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzNumerNieruchomosci",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzNumerLokalu",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzNietypoweMiejsceLokalizacji",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzMiejscowoscSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzMiejscowoscPocztySymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzMiejscowoscPocztyNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzMiejscowoscNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzKrajSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzKrajNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzKodPocztowy",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzGminaSymbol",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokfizAdSiedzGminaNazwa",
                schema: "pagard",
                table: "BIR11JednLokalnaOsFizycznej",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}
