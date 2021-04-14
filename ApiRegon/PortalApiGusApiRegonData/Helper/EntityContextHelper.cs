#region using

using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using log4net;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PortalApiGusApiRegonData.Data;

#endregion

namespace PortalApiGusApiRegonData.Helper
{
    /// <summary>
    ///     Entity Context Helper
    /// </summary>
    public class EntityContextHelper
    {
        #region private readonly log4net.ILog log4net

        /// <summary>
        ///     private readonly ILog _log4Net
        /// </summary>
        private static readonly ILog Log4net =
            Log4netLogger.Log4netLogger.GetLog4netInstance(MethodBase.GetCurrentMethod()?.DeclaringType);

        #endregion

        #region public static async Task RunMigrationAsync(IServiceProvider serviceProvider)

        /// <summary>
        ///     Uruchom migrację bazy danych.
        /// </summary>
        /// <param name="serviceProvider"></param>
        /// <returns></returns>
        public static async Task RunMigrationAsync(IServiceProvider serviceProvider)
        {
            try
            {
                using (IServiceScope serviceScope =
                    serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
                {
                    using (PortalApiGusApiRegonDataDbContext dbContext =
                        serviceScope.ServiceProvider.GetService<PortalApiGusApiRegonDataDbContext>())
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
                Log4net.Error($"\n{e.GetType()}\n{e.InnerException?.GetType()}\n{e.Message}\n{e.StackTrace}\n", e);
            }
        }

        #endregion
    }
}
