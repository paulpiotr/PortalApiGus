using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalApiGusApiRegonData.Migrations
{
    public partial class M2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SHA512",
                table: "DaneSzukajPodmiotyParametryWyszukiwania",
                maxLength: 2147483647,
                nullable: true);
            migrationBuilder.Sql("ALTER TABLE [dbo].[DaneSzukajPodmioty] DROP CONSTRAINT IF EXISTS [DF_DaneSzukajPodmioty_DataUtworzenia]");
            migrationBuilder.Sql("ALTER TABLE [dbo].[DaneSzukajPodmioty] ADD CONSTRAINT [DF_DaneSzukajPodmioty_DataUtworzenia] DEFAULT (getdate()) FOR [DataUtworzenia]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("ALTER TABLE [dbo].[DaneSzukajPodmioty] DROP CONSTRAINT IF EXISTS [DF_DaneSzukajPodmioty_DataUtworzenia] GO");
            migrationBuilder.DropColumn(
                name: "SHA512",
                table: "DaneSzukajPodmiotyParametryWyszukiwania");
        }
    }
}
