using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApiGusApiRegonData.Helper
{
    /// <summary>
    /// Entity Context Helper
    /// </summary>
    public class EntityContextHelper
    {
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
            catch (Exception)
            {

            }
        }
    }
}
