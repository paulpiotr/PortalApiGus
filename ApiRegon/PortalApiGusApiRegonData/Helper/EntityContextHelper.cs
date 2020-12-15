using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace PortalApiGusApiRegonData.Helper
{
    /// <summary>
    /// Entity Context Helper
    /// </summary>
    public class EntityContextHelper
    {
        #region private readonly log4net.ILog log4net
        /// <summary>
        /// Log4 Net Logger
        /// </summary>
        private static readonly log4net.ILog Log4net = Log4netLogger.Log4netLogger.GetLog4netInstance(MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        #region public static async Task RunMigrationAsync(IServiceProvider serviceProvider)
        /// <summary>
        /// Uruchom migrację bazy danych.
        /// </summary>
        /// <param name="serviceProvider"></param>
        /// <returns></returns>
        public static async Task RunMigrationAsync(IServiceProvider serviceProvider)
        {
            try
            {
                using (IServiceScope serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
                {
                    using (Data.PortalApiGusApiRegonDataDbContext dbContext = serviceScope.ServiceProvider.GetService<Data.PortalApiGusApiRegonDataDbContext>())
                    {
                        if ((await dbContext.Database.GetPendingMigrationsAsync().ConfigureAwait(false)).Any())
                        {
                            await dbContext.Database.MigrateAsync().ConfigureAwait(false);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Log4net.Error(string.Format("\n{0}\n{1}\n{2}\n{3}\n", e.GetType(), e.InnerException?.GetType(), e.Message, e.StackTrace), e);
            }
        }
        #endregion
    }
}
