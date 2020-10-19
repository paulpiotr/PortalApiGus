﻿using Microsoft.EntityFrameworkCore;
using PortalApiGusApiRegonData.Models;
using System;
using System.Reflection;
using NetAppCommon;

namespace PortalApiGusApiRegonData.Data
{
    public partial class PortalApiGusApiRegonDataDbContext : DbContext
    {
        #region private static readonly log4net.ILog _log4net
        /// <summary>
        /// Log4 Net Logger
        /// Log4 Net Logger
        /// </summary>
        private static readonly log4net.ILog _log4net = Log4netLogger.Log4netLogger.GetLog4netInstance(MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        #region private static readonly AppSettings appSettings...
        /// <summary>
        /// Instancja do klasy modelu ustawień jako AppSettings
        /// Instance to the settings model class as AppSettings
        /// </summary>
        private static readonly AppSettings appSettings = AppSettings.GetInstance();
        #endregion

        #region public PortalApiGusApiRegonDataDbContext()
        /// <summary>
        /// Konstruktor bez parametrów
        /// Constructor with no parameters
        /// </summary>
        public PortalApiGusApiRegonDataDbContext()
        {
        }
        #endregion

        #region public ApiWykazuPodatnikowVatDataDbContext(DbContextOptions<ApiWykazuPodatnikowVatDataDbContext> options)
        /// <summary>
        /// Konstruktor klasy kontekstu bazy danych api wykazu podatników VAT
        /// Constructor database context classes api list of VAT taxpayers
        /// </summary>
        /// <param name="options">
        /// Opcje połączenia da bazy danych options AS DbContextOptions<ApiWykazuPodatnikowVatDataDbContext>
        /// Connection options will give the options AS DbContextOptions<ApiWykazuPodatnikowVatDataDbContext>
        /// </param>
        public PortalApiGusApiRegonDataDbContext(DbContextOptions<PortalApiGusApiRegonDataDbContext> options)
            : base(options)
        {
        }
        #endregion

        # region public async System.Threading.Tasks.Task CheckForUpdateAndMigrateAsync()
        /// <summary>
        /// Sprawdź warunek daty ostatniej migracji i przeprowadź migrację jeśli warunek jest spełniony
        /// Check the condition of the last migration date and perform the migration if the condition is met
        /// </summary>
        /// <returns>
        /// Metoda asynchroniczna
        /// Asynchronous method
        /// </returns>
        public async System.Threading.Tasks.Task CheckForUpdateAndMigrateAsync()
        {
            try
            {
                int result = (DateTime.Now - appSettings.LastMigrateDateTime).Days;
                _log4net.Debug($"Check for update and migrate, compare { DateTime.Now } and { appSettings.LastMigrateDateTime } is { result } CheckForUpdateEveryDays is { appSettings.CheckForUpdateEveryDays }");
                if (/*CheckForUpdateEveryDays > 0 && */result >= appSettings.CheckForUpdateEveryDays)
                {
                    try
                    {
                        DatabaseMssqlMdf.GetInstance(Database.GetDbConnection().ConnectionString).Create();
                        await Database.MigrateAsync();
                    }
                    catch (Exception e)
                    {
                        _log4net.Error(string.Format("{0}, {1}.", e.Message, e.StackTrace), e);
                    }
                    finally
                    {
                        appSettings.LastMigrateDateTime = DateTime.Now;
                        await appSettings.SaveAsync();
                    }
                }
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}.", e.Message, e.StackTrace), e);
            }
        }
        #endregion

        #region public virtual DbSet<Models.DaneSzukajPodmioty.DaneSzukajPodmiotyParametryWyszukiwania> DaneSzukajPodmiotyParametryWyszukiwania
        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<Models.DaneSzukajPodmioty.DaneSzukajPodmiotyParametryWyszukiwania> DaneSzukajPodmiotyParametryWyszukiwania { get; set; }
        #endregion

        #region public virtual DbSet<Models.DaneSzukajPodmioty.DaneSzukajPodmioty> DaneSzukajPodmioty
        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<Models.DaneSzukajPodmioty.DaneSzukajPodmioty> DaneSzukajPodmioty { get; set; }
        #endregion

        #region protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        /// <summary>
        /// Zdarzenie wyzwalające konfigurację bazy danych
        /// Database configuration triggering event
        /// </summary>
        /// <param name="optionsBuilder">
        /// Fabryka budowania połączenia do bazy danych optionsBuilder jako DbContextOptionsBuilder
        /// Factory building connection to the database optionsBuilder AS DbContextOptionsBuilder
        /// </param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer(appSettings.GetConnectionString());
                }
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}.", e.Message, e.StackTrace), e);
            }
        }
        #endregion

        #region protected override void OnModelCreating(ModelBuilder modelBuilder)
        /// <summary>
        /// Zdarzenie wyzwalające tworzenie modelu bazy danych
        /// The event that triggers the creation of the database model
        /// </summary>
        /// <param name="modelBuilder">
        /// Fabryka budowania modelu bazy danych modelBuilder jako ModelBuilder
        /// ModelBuilder database model building as ModelBuilder
        /// </param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.ApplyConfiguration(new DaneSzukajPodmioty.DaneSzukajPodmiotyConfiguration());
            _ = modelBuilder.ApplyConfiguration(new DaneSzukajPodmioty.DaneSzukajPodmiotyParametryWyszukiwaniaConfiguration());
            OnModelCreatingPartial(modelBuilder);
        }
        #endregion

        #region partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        #endregion
    }
}