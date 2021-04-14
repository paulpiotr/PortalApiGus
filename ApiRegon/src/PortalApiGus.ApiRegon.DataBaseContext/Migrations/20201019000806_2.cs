#region using

using Microsoft.EntityFrameworkCore.Migrations;
using NetAppCommon.Helpers.Db.Mssql;

#endregion

namespace PortalApiGus.ApiRegon.DataBase.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            AuditMigration.Create(migrationBuilder, "pagard", "DaneSzukajPodmiotyParametryWyszukiwania");
            AuditMigration.Create(migrationBuilder, "pagard", "DaneSzukajPodmioty");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            AuditMigration.Drop(migrationBuilder, "pagard", "DaneSzukajPodmiotyParametryWyszukiwania");
            AuditMigration.Drop(migrationBuilder, "pagard", "DaneSzukajPodmioty");
        }
    }
}
