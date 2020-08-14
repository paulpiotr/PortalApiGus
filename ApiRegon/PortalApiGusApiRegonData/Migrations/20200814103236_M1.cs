using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace PortalApiGusApiRegonData.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataUtworzenia",
                table: "DaneSzukajPodmioty",
                nullable: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataModyfikacji",
                table: "DaneSzukajPodmioty",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "ParametryWyszukiwaniaJson",
                table: "DaneSzukajPodmioty",
                maxLength: 2147483647,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParametryWyszukiwaniaSHA512",
                table: "DaneSzukajPodmioty",
                maxLength: 2147483647,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataUtworzenia",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropColumn(
                name: "DataModyfikacji",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropColumn(
                name: "ParametryWyszukiwaniaJson",
                table: "DaneSzukajPodmioty");

            migrationBuilder.DropColumn(
                name: "ParametryWyszukiwaniaSHA512",
                table: "DaneSzukajPodmioty");
        }
    }
}
