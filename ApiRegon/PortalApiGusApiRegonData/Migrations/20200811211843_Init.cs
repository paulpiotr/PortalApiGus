using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace PortalApiGusApiRegonData.Migrations
{
    public partial class Init : Migration
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="migrationBuilder"></param>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            try
            {
                Console.WriteLine("Init create DATABASE in PortalApiGusApiRegonDataDbContext.cs OnModelCreating(ModelBuilder modelBuilder)");
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("Sql command error: {0}, {1}.", e.Message, e.StackTrace));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="migrationBuilder"></param>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            try
            {
                PortalApiGusApiRegonDataContext.DatabaseMdfDrop();
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("Sql command error: {0}, {1}.", e.Message, e.StackTrace));
            }
        }
    }
}