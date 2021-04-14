#region using

using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using log4net;
using Microsoft.EntityFrameworkCore;
using NetAppCommon.Helpers;
using PortalApiGusApiRegonData.Data.DaneSzukajPodmioty;
using PortalApiGusApiRegonData.Models;
using PortalApiGusApiRegonData.Models.DaneSzukajPodmioty;

#endregion

namespace PortalApiGusApiRegonData.Data
{
    public class PortalApiGusApiRegonDataDbContext : DbContext
    {
        #region private readonly AppSettings _appSettings = new AppSettings();

        /// <summary>
        ///     Instancja do klasy modelu ustawień jako AppSettings
        ///     Instance to the settings model class as AppSettings
        /// </summary>
        private readonly AppSettings _appSettings = new();

        #endregion

        #region private readonly log4net.ILog log4net

        /// <summary>
        ///     private readonly ILog _log4Net
        ///     private readonly ILog _log4Net
        /// </summary>
        private readonly ILog _log4Net =
            Log4netLogger.Log4netLogger.GetLog4netInstance(MethodBase.GetCurrentMethod()?.DeclaringType);

        #endregion

        #region public ViesCoreDatabaseContext(DbContextOptions<ViesCoreDatabaseContext> options)

        /// <summary>
        ///     Konstruktor klasy kontekstu bazy danych api wykazu podatników VAT
        ///     Constructor database context classes api list of VAT taxpayers
        /// </summary>
        /// <param name="options">
        ///     Opcje połączenia do bazy danych options jako DbContextOptions z ViesCoreDatabaseContext
        ///     Database connection options options as DbContextOptions from ViesCoreDatabaseContext
        /// </param>
        public PortalApiGusApiRegonDataDbContext(DbContextOptions<PortalApiGusApiRegonDataDbContext> options)
            : base(options)
        {
            CheckAndMigrate();
        }

        #endregion

        #region public virtual DbSet<Models.DaneSzukajPodmioty.DaneSzukajPodmiotyParametryWyszukiwania> DaneSzukajPodmiotyParametryWyszukiwania

        /// <summary>
        /// </summary>
        public virtual DbSet<DaneSzukajPodmiotyParametryWyszukiwania> DaneSzukajPodmiotyParametryWyszukiwania
        {
            get;
            set;
        }

        #endregion

        #region public virtual DbSet<Models.DaneSzukajPodmioty.DaneSzukajPodmioty> DaneSzukajPodmioty

        /// <summary>
        /// </summary>
        public virtual DbSet<Models.DaneSzukajPodmioty.DaneSzukajPodmioty> DaneSzukajPodmioty { get; set; }

        #endregion

        #region public void CheckAndMigrate()

        /// <summary>
        ///     Sprawdź ostatnią datę migracji bazy danych lub wymuś wykonanie, jeśli opcja CheckAndMigrate jest zaznaczona i
        ///     wykonaj migrację bazy danych.
        ///     Check the latest database migration date or force execution if CheckAndMigrate is selected and perform database
        ///     migration.
        /// </summary>
        public void CheckAndMigrate() =>
            Task.Run(async () =>
            {
                await CheckAndMigrateAsync();
            }).Wait();

        #endregion

        #region public async Task CheckAndMigrateAsync()

        /// <summary>
        ///     Sprawdź ostatnią datę migracji bazy danych lub wymuś wykonanie, jeśli opcja CheckAndMigrate jest zaznaczona i
        ///     wykonaj migrację bazy danych.
        ///     Check the latest database migration date or force execution if CheckAndMigrate is selected and perform database
        ///     migration.
        /// </summary>
        /// <returns>
        ///     async Task
        ///     async Task
        /// </returns>
        public async Task CheckAndMigrateAsync()
        {
            DateTime? lastMigrateDateTime = null;
            try
            {
                lastMigrateDateTime =
                    await _appSettings.AppSettingsRepository.GetValueAsync<DateTime>(_appSettings,
                        "LastMigrateDateTime");
                var isCheckAndMigrate =
                    await _appSettings.AppSettingsRepository.GetValueAsync<bool>(_appSettings, "CheckAndMigrate");
                var dateTimeDiffDays = (DateTime.Now - (DateTime)lastMigrateDateTime).Days;
                if ((isCheckAndMigrate || dateTimeDiffDays >= 1) && (await Database.GetPendingMigrationsAsync()).Any())
                {
                    try
                    {
#if DEBUG
                        _log4Net.Debug("Try CheckAndMigrateAsync...");
#endif
                        await EntityContextHelper.RunMigrationAsync(this);
#if DEBUG
                        _log4Net.Debug("Ok");
#endif
                    }
                    catch (Exception e)
                    {
                        _log4Net.Warn($"\n{e.GetType()}\n{e.InnerException?.GetType()}\n{e.Message}\n{e.StackTrace}\n",
                            e);
                    }

                    _appSettings.LastMigrateDateTime = DateTime.Now;
                    await _appSettings.AppSettingsRepository.MergeAndSaveAsync(_appSettings);
                }
            }
            catch (Exception e)
            {
                _log4Net.Error($"\n{e.GetType()}\n{e.InnerException?.GetType()}\n{e.Message}\n{e.StackTrace}\n", e);
            }
            finally
            {
                if (null == lastMigrateDateTime || lastMigrateDateTime == DateTime.MinValue)
                {
                    _appSettings.LastMigrateDateTime = DateTime.Now;
                    await _appSettings.AppSettingsRepository.MergeAndSaveAsync(_appSettings);
                }
            }
        }

        #endregion

        #region protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        /// <summary>
        ///     Zdarzenie wyzwalające konfigurację bazy danych
        ///     Database configuration triggering event
        /// </summary>
        /// <param name="optionsBuilder">
        ///     Fabryka budowania połączenia do bazy danych optionsBuilder jako DbContextOptionsBuilder
        ///     Factory building connection to the database optionsBuilder AS DbContextOptionsBuilder
        /// </param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer(_appSettings.GetConnectionString());
                }
            }
            catch (Exception e)
            {
                _log4Net.Error($"\n{e.GetType()}\n{e.InnerException?.GetType()}\n{e.Message}\n{e.StackTrace}\n", e);
            }
        }

        #endregion

        #region protected override void OnModelCreating(ModelBuilder modelBuilder)

        /// <summary>
        ///     Zdarzenie wyzwalające tworzenie modelu bazy danych
        ///     The event that triggers the creation of the database model
        /// </summary>
        /// <param name="modelBuilder">
        ///     Fabryka budowania modelu bazy danych modelBuilder jako ModelBuilder
        ///     ModelBuilder database model building as ModelBuilder
        /// </param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.ApplyConfiguration(new DaneSzukajPodmiotyConfiguration());
            _ = modelBuilder.ApplyConfiguration(new DaneSzukajPodmiotyParametryWyszukiwaniaConfiguration());
        }

        #endregion
    }
}
