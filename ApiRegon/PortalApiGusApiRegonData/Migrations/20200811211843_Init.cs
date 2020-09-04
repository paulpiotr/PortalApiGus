using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Reflection;

namespace PortalApiGusApiRegonData.Migrations
{
    public partial class Init : Migration
    {
        /// <summary>
        /// Log4 Net Logger
        /// </summary>
        protected static readonly log4net.ILog _log4net = Log4netLogger.Log4netLogger.GetLog4netInstance(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Migracja inicjująca bazę danych w formie pliku .MDF
        /// Database initialization migration as a .MDF file
        /// </summary>
        /// <param name="migrationBuilder">MigrationBuilder</param>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            try
            {
                _log4net.Info("Init create DATABASE in PortalApiGusApiRegonDataDbContext.cs OnModelCreating(ModelBuilder modelBuilder)");
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}.", e.Message, e.StackTrace), e);
            }
        }

        /// <summary>
        /// Migracja usuwająca bazę danych w formie pliku .MDF
        /// Migration to delete database as .MDF file
        /// </summary>
        /// <param name="migrationBuilder">MigrationBuilder</param>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            try
            {
                PortalApiGusApiRegonDataContext.DatabaseMdfDrop();
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}.", e.Message, e.StackTrace), e);
            }
        }
    }
}