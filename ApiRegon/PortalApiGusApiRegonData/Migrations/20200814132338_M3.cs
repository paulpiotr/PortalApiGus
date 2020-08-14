using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.IO;
using System.Reflection;

namespace PortalApiGusApiRegonData.Migrations
{
    public partial class M3 : Migration
    {
        /// <summary>
        /// log4net
        /// </summary>
        private static readonly log4net.ILog _log4net = Log4netLogger.Log4netLogger.GetLog4netInstance(MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// Dodanie tabeli audytu i wyzwalaczy dla tabeli DaneSzukajPodmioty
        /// </summary>
        /// <param name="migrationBuilder"></param>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            try
            {
                string sql = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Migrations", "AuditCreateTableScript.sql")).Replace("%TableName%", "DaneSzukajPodmioty");
                _log4net.Info(sql);
                migrationBuilder.Sql(sql);
                sql = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Migrations", "AuditCreateTriggerScript.sql")).Replace("%TableName%", "DaneSzukajPodmioty");
                _log4net.Info(sql);
                migrationBuilder.Sql(sql);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}, {2}.", Assembly.GetExecutingAssembly().FullName, e.Message, e.StackTrace), e);
            }
        }
        /// <summary>
        /// Usówanie tabeli audytu i wyzwalaczy dla tabeli DaneSzukajPodmioty
        /// </summary>
        /// <param name="migrationBuilder"></param>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            try
            {
                string sql = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Migrations", "AuditDropTableScript.sql")).Replace("%TableName%", "DaneSzukajPodmioty");
                _log4net.Info(sql);
                migrationBuilder.Sql(sql);
                sql = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Migrations", "AuditDropTriggerScript.sql")).Replace("%TableName%", "DaneSzukajPodmioty");
                _log4net.Info(sql);
                migrationBuilder.Sql(sql);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}, {2}.", Assembly.GetExecutingAssembly().FullName, e.Message, e.StackTrace), e);
            }
        }
    }
}