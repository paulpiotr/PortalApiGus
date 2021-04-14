#region using

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using NetAppCommon.Helpers;
using NetAppCommon.Logging;
using NetAppCommon.Models;
using PortalApiGus.ApiRegon.Core.Models;
using PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport;
using PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmioty;
using PortalApiGus.ApiRegon.DataBase.Data.EntityTypeConfiguration;
using AppSettings = PortalApiGus.ApiRegon.DataBase.Models.AppSettings;

#endregion

#nullable enable annotations

namespace PortalApiGus.ApiRegon.DataBase.Data
{
    public sealed class DataBaseContext : DbContext
    {
        #region private static DatabaseFacade _databaseFacade;

        /// <summary>
        ///     Statyczna referencja do obiektu DatabaseFacade
        ///     A static reference to the DatabaseFacade object
        /// </summary>
        private static DatabaseFacade _databaseFacade;

        #endregion

        #region private readonly AppSettings _appSettings

        /// <summary>
        ///     Instancja do klasy ustawień BibleApp.Core.DataBase.Models.AppSettings
        ///     Instance to the BibleApp.Core.DataBase.Models.AppSettings settings class
        /// </summary>
        private readonly AppSettings _appSettings = new();

        #endregion

        #region private readonly log4net.ILog _log4Net

        /// <summary>
        ///     Referencja klasy Log4NetLogger
        ///     Reference to the Log4NetLogger class
        /// </summary>
        private readonly ILog _log4Net =
            Log4NetLogger.GetLog4NetInstance(MethodBase.GetCurrentMethod()?.DeclaringType);

        #endregion

        //#region public DataBaseContext()

        ///// <summary>
        /////     Konstruktor
        /////     Constructor
        ///// </summary>
        //public DataBaseContext()
        //{
        //    CheckAndMigrate();
        //    _databaseFacade = Database;
        //}

        //#endregion

        #region public DataBaseContext(DbContextOptions<DataBaseContext> options)

        /// <summary>
        ///     Konstruktor klasy kontekstu bazy danych
        ///     Constructor database context classes
        /// </summary>
        /// <param name="options">
        ///     Opcje połączenia do bazy danych options jako DbContextOptions z DataBaseContext
        ///     Database connection options options as DbContextOptions from DataBaseContext
        /// </param>
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
            CheckAndMigrate();
            _databaseFacade = Database;
        }

        #endregion

        #region public DbSet<DaneSzukajPodmioty> DaneSzukajPodmioty { get; set; }

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmioty jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmioty as DbSet
        /// </summary>
        public DbSet<DaneSzukajPodmioty> DaneSzukajPodmioty { get; set; }

        #endregion

        #region public DbSet<DaneSzukajPodmiotyKomunikatyOBledach> DaneSzukajPodmiotyKomunikatyOBledach { get; set; }

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmiotyKomunikatyOBledach jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmiotyKomunikatyOBledach as DbSet
        /// </summary>
        public DbSet<DaneSzukajPodmiotyKomunikatyOBledach> DaneSzukajPodmiotyKomunikatyOBledach { get; set; }

        #endregion

        #region public DbSet<DaneSzukajPodmiotyMessageInspector> DaneSzukajPodmiotyMessageInspector { get; set; }

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmiotyMessageInspector jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmiotyMessageInspector as DbSet
        /// </summary>
        public DbSet<MessageInspector> DaneSzukajPodmiotyMessageInspector { get; set; }

        #endregion

        #region public DbSet<DaneSzukajPodmiotyParametryWyszukiwania> DaneSzukajPodmiotyParametryWyszukiwania { get; set; }

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmiotyParametryWyszukiwania jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmiotyParametryWyszukiwania as DbSet
        /// </summary>
        public DbSet<DaneSzukajPodmiotyParametryWyszukiwania> DaneSzukajPodmiotyParametryWyszukiwania { get; set; }

        #endregion

        #region public DbSet<BIR11JednLokalnaOsFizycznej> BIR11JednLokalnaOsFizycznej { get; set; }

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11JednLokalnaOsFizycznej jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11JednLokalnaOsFizycznej as DbSet
        /// </summary>
        public DbSet<BIR11JednLokalnaOsFizycznej> BIR11JednLokalnaOsFizycznej { get; set; }

        #endregion

        #region public DbSet<BIR11JednLokalnaOsFizycznejMessageInspector> BIR11JednLokalnaOsFizycznejMessageInspector...

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11JednLokalnaOsFizycznejMessageInspector jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11JednLokalnaOsFizycznejMessageInspector as DbSet
        /// </summary>
        public DbSet<BIR11JednLokalnaOsFizycznejMessageInspector> BIR11JednLokalnaOsFizycznejMessageInspector { get; set; }

        #endregion

        #region public DbSet<BIR11JednLokalnaOsFizycznejPkd> BIR11JednLokalnaOsFizycznejPkd { get; set; }

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11JednLokalnaOsFizycznejPkd jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11JednLokalnaOsFizycznejPkd as DbSet
        /// </summary>
        public DbSet<BIR11JednLokalnaOsFizycznejPkd> BIR11JednLokalnaOsFizycznejPkd { get; set; }

        #endregion

        #region public DbSet<BIR11JednLokalnaOsFizycznejPkdMessageInspector> BIR11JednLokalnaOsFizycznejPkdMessageInspector...

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11JednLokalnaOsFizycznejPkdMessageInspector jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11JednLokalnaOsFizycznejPkdMessageInspector as DbSet
        /// </summary>
        public DbSet<BIR11JednLokalnaOsFizycznejPkdMessageInspector> BIR11JednLokalnaOsFizycznejPkdMessageInspector { get; set; }

        #endregion

        #region public DbSet<BIR11JednLokalnaOsPrawnej> BIR11JednLokalnaOsPrawnej { get; set; }

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11JednLokalnaOsPrawnej jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11JednLokalnaOsPrawnej as DbSet
        /// </summary>
        public DbSet<BIR11JednLokalnaOsPrawnej> BIR11JednLokalnaOsPrawnej { get; set; }

        #endregion

        #region public DbSet<BIR11JednLokalnaOsPrawnejMessageInspector> BIR11JednLokalnaOsPrawnejMessageInspector...

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11JednLokalnaOsPrawnejMessageInspector jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11JednLokalnaOsPrawnejMessageInspector as DbSet
        /// </summary>
        public DbSet<BIR11JednLokalnaOsPrawnejMessageInspector> BIR11JednLokalnaOsPrawnejMessageInspector { get; set; }

        #endregion

        #region public DbSet<BIR11JednLokalnaOsPrawnejPkd> BIR11JednLokalnaOsPrawnejPkd { get; set; }

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11JednLokalnaOsPrawnejPkd jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11JednLokalnaOsPrawnejPkd as DbSet
        /// </summary>
        public DbSet<BIR11JednLokalnaOsPrawnejPkd> BIR11JednLokalnaOsPrawnejPkd { get; set; }

        #endregion

        #region public DbSet<BIR11JednLokalnaOsPrawnejPkdMessageInspector> BIR11JednLokalnaOsPrawnejPkdMessageInspector...

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11JednLokalnaOsPrawnejPkdMessageInspector jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11JednLokalnaOsPrawnejPkdMessageInspector as DbSet
        /// </summary>
        public DbSet<BIR11JednLokalnaOsPrawnejPkdMessageInspector> BIR11JednLokalnaOsPrawnejPkdMessageInspector { get; set; }

        #endregion

        #region public DbSet<BIR11OsFizycznaDaneOgolne> BIR11OsFizycznaDaneOgolne { get; set; }

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaDaneOgolne jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaDaneOgolne as DbSet
        /// </summary>
        public DbSet<BIR11OsFizycznaDaneOgolne> BIR11OsFizycznaDaneOgolne { get; set; }

        #endregion

        #region public DbSet<BIR11OsFizycznaDaneOgolneMessageInspector> BIR11OsFizycznaDaneOgolneMessageInspector...

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaDaneOgolneMessageInspector jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaDaneOgolneMessageInspector as DbSet
        /// </summary>
        public DbSet<BIR11OsFizycznaDaneOgolneMessageInspector> BIR11OsFizycznaDaneOgolneMessageInspector { get; set; }

        #endregion

        #region public DbSet<BIR11OsFizycznaDzialalnoscCeidg> BIR11OsFizycznaDzialalnoscCeidg { get; set; }

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaDzialalnoscCeidg jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaDzialalnoscCeidg as DbSet
        /// </summary>
        public DbSet<BIR11OsFizycznaDzialalnoscCeidg> BIR11OsFizycznaDzialalnoscCeidg { get; set; }

        #endregion

        #region public DbSet<BIR11OsFizycznaDzialalnoscCeidgMessageInspector> BIR11OsFizycznaDzialalnoscCeidgMessageInspector...

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaDzialalnoscCeidgMessageInspector jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaDzialalnoscCeidgMessageInspector as DbSet
        /// </summary>
        public DbSet<BIR11OsFizycznaDzialalnoscCeidgMessageInspector> BIR11OsFizycznaDzialalnoscCeidgMessageInspector { get; set; }

        #endregion

        #region public DbSet<BIR11OsFizycznaDzialalnoscPozostala> BIR11OsFizycznaDzialalnoscPozostala { get; set; }

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaDzialalnoscPozostala jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaDzialalnoscPozostala as DbSet
        /// </summary>
        public DbSet<BIR11OsFizycznaDzialalnoscPozostala> BIR11OsFizycznaDzialalnoscPozostala { get; set; }

        #endregion

        #region public DbSet<BIR11OsFizycznaDzialalnoscPozostalaMessageInspector> BIR11OsFizycznaDzialalnoscPozostalaMessageInspector...

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaDzialalnoscPozostalaMessageInspector jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaDzialalnoscPozostalaMessageInspector as DbSet
        /// </summary>
        public DbSet<BIR11OsFizycznaDzialalnoscPozostalaMessageInspector> BIR11OsFizycznaDzialalnoscPozostalaMessageInspector { get; set; }

        #endregion

        #region public DbSet<BIR11OsFizycznaDzialalnoscRolnicza> BIR11OsFizycznaDzialalnoscRolnicza { get; set; }

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaDzialalnoscRolnicza jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaDzialalnoscRolnicza as DbSet
        /// </summary>
        public DbSet<BIR11OsFizycznaDzialalnoscRolnicza> BIR11OsFizycznaDzialalnoscRolnicza { get; set; }

        #endregion

        #region public DbSet<BIR11OsFizycznaDzialalnoscRolniczaMessageInspector> BIR11OsFizycznaDzialalnoscRolniczaMessageInspector...

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaDzialalnoscRolniczaMessageInspector jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaDzialalnoscRolniczaMessageInspector as DbSet
        /// </summary>
        public DbSet<BIR11OsFizycznaDzialalnoscRolniczaMessageInspector> BIR11OsFizycznaDzialalnoscRolniczaMessageInspector { get; set; }

        #endregion

        #region public DbSet<BIR11OsFizycznaDzialalnoscSkreslonaDo20141108> BIR11OsFizycznaDzialalnoscSkreslonaDo20141108 { get; set; }

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaDzialalnoscSkreslonaDo20141108 jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaDzialalnoscSkreslonaDo20141108 as DbSet
        /// </summary>
        public DbSet<BIR11OsFizycznaDzialalnoscSkreslonaDo20141108> BIR11OsFizycznaDzialalnoscSkreslonaDo20141108 { get; set; }

        #endregion

        #region public DbSet<BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector> BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector...

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector as DbSet
        /// </summary>
        public DbSet<BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector> BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector { get; set; }

        #endregion

        #region public DbSet<BIR11OsFizycznaListaJednLokalnych> BIR11OsFizycznaListaJednLokalnych { get; set; }

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaListaJednLokalnych jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaListaJednLokalnych as DbSet
        /// </summary>
        public DbSet<BIR11OsFizycznaListaJednLokalnych> BIR11OsFizycznaListaJednLokalnych { get; set; }

        #endregion

        #region public DbSet<BIR11OsFizycznaListaJednLokalnychMessageInspector> BIR11OsFizycznaListaJednLokalnychMessageInspector...

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaListaJednLokalnychMessageInspector jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaListaJednLokalnychMessageInspector as DbSet
        /// </summary>
        public DbSet<BIR11OsFizycznaListaJednLokalnychMessageInspector> BIR11OsFizycznaListaJednLokalnychMessageInspector { get; set; }

        #endregion

        #region public DbSet<BIR11OsFizycznaPkd> BIR11OsFizycznaPkd { get; set; }

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaPkd jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaPkd as DbSet
        /// </summary>
        public DbSet<BIR11OsFizycznaPkd> BIR11OsFizycznaPkd { get; set; }

        #endregion

        #region public DbSet<BIR11OsFizycznaPkdMessageInspector> BIR11OsFizycznaPkdMessageInspector...

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaPkdMessageInspector jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaPkdMessageInspector as DbSet
        /// </summary>
        public DbSet<BIR11OsFizycznaPkdMessageInspector> BIR11OsFizycznaPkdMessageInspector { get; set; }

        #endregion

        #region public DbSet<BIR11OsPrawna> BIR11OsPrawna { get; set; }

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsPrawna jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11OsPrawna as DbSet
        /// </summary>
        public DbSet<BIR11OsPrawna> BIR11OsPrawna { get; set; }

        #endregion

        #region public DbSet<BIR11OsPrawnaMessageInspector> BIR11OsPrawnaMessageInspector...

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsPrawnaMessageInspector jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11OsPrawnaMessageInspector as DbSet
        /// </summary>
        public DbSet<BIR11OsPrawnaMessageInspector> BIR11OsPrawnaMessageInspector { get; set; }

        #endregion

        #region public DbSet<BIR11OsPrawnaListaJednLokalnych> BIR11OsPrawnaListaJednLokalnych { get; set; }

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsPrawnaListaJednLokalnych jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11OsPrawnaListaJednLokalnych as DbSet
        /// </summary>
        public DbSet<BIR11OsPrawnaListaJednLokalnych> BIR11OsPrawnaListaJednLokalnych { get; set; }

        #endregion

        #region public DbSet<BIR11OsPrawnaListaJednLokalnychMessageInspector> BIR11OsPrawnaListaJednLokalnychMessageInspector...

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsPrawnaListaJednLokalnychMessageInspector jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11OsPrawnaListaJednLokalnychMessageInspector as DbSet
        /// </summary>
        public DbSet<BIR11OsPrawnaListaJednLokalnychMessageInspector> BIR11OsPrawnaListaJednLokalnychMessageInspector { get; set; }

        #endregion

        #region public DbSet<BIR11OsPrawnaPkd> BIR11OsPrawnaPkd { get; set; }

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsPrawnaPkd jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11OsPrawnaPkd as DbSet
        /// </summary>
        public DbSet<BIR11OsPrawnaPkd> BIR11OsPrawnaPkd { get; set; }

        #endregion

        #region public DbSet<BIR11OsPrawnaPkdMessageInspector> BIR11OsPrawnaPkdMessageInspector...

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsPrawnaPkdMessageInspector jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11OsPrawnaPkdMessageInspector as DbSet
        /// </summary>
        public DbSet<BIR11OsPrawnaPkdMessageInspector> BIR11OsPrawnaPkdMessageInspector { get; set; }

        #endregion

        #region public DbSet<BIR11OsPrawnaSpCywilnaWspolnicy> BIR11OsPrawnaSpCywilnaWspolnicy { get; set; }

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsPrawnaSpCywilnaWspolnicy jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11OsPrawnaSpCywilnaWspolnicy as DbSet
        /// </summary>
        public DbSet<BIR11OsPrawnaSpCywilnaWspolnicy> BIR11OsPrawnaSpCywilnaWspolnicy { get; set; }

        #endregion

        #region public DbSet<BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector> BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector...

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector as DbSet
        /// </summary>
        public DbSet<BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector> BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector { get; set; }

        #endregion

        #region public DbSet<BIR11TypPodmiotu> BIR11TypPodmiotu { get; set; }

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11TypPodmiotu jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11TypPodmiotu as DbSet
        /// </summary>
        public DbSet<BIR11TypPodmiotu> BIR11TypPodmiotu { get; set; }

        #endregion

        #region public DbSet<BIR11TypPodmiotuMessageInspector> BIR11TypPodmiotuMessageInspector...

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11TypPodmiotuMessageInspector jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.BIR11TypPodmiotuMessageInspector as DbSet
        /// </summary>
        public DbSet<BIR11TypPodmiotuMessageInspector> BIR11TypPodmiotuMessageInspector { get; set; }

        #endregion

        #region public DbSet<MessageInspector> MessageInspector { get; set; }

        /// <summary>
        ///     Model danych PortalApiGus.ApiRegon.Core.Models.MessageInspector jako DbSet
        ///     Data model PortalApiGus.ApiRegon.Core.Models.MessageInspector as DbSet
        /// </summary>
        public DbSet<MessageInspector> MessageInspector { get; set; }

        #endregion

        #region public static DatabaseFacade GetDatabaseFacade()

        /// <summary>
        ///     Pobierz statyczną referencję do obiektu DatabaseFacade
        ///     Get a static reference to the DatabaseFacade object
        /// </summary>
        /// <returns>
        ///     Statyczna referencja do obiektu DatabaseFacade
        ///     A static reference to the DatabaseFacade object
        /// </returns>
        public static DatabaseFacade GetDatabaseFacade() => _databaseFacade;

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
                if (_appSettings.AppSettingsRepository != null)
                {
                    lastMigrateDateTime =
                        await _appSettings.AppSettingsRepository.GetValueAsync<DateTime>(_appSettings,
                            "LastMigrateDateTime");
                    var isCheckAndMigrate =
                        await _appSettings.AppSettingsRepository.GetValueAsync<bool>(_appSettings, "CheckAndMigrate");
                    var dateTimeDiffDays = (DateTime.Now - (DateTime)lastMigrateDateTime).Days;
                    if (!string.IsNullOrWhiteSpace(_appSettings.GetConnectionString()) &&
                        (isCheckAndMigrate || dateTimeDiffDays >= 1) &&
                        (await Database.GetPendingMigrationsAsync()).Any())
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
                            _log4Net.Warn(
                                $"\n{e.GetType()}\n{e.InnerException?.GetType()}\n{e.Message}\n{e.StackTrace}\n",
                                e);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                _log4Net.Error($"\n{e.GetType()}\n{e.InnerException?.GetType()}\n{e.Message}\n{e.StackTrace}\n", e);
            }
            finally
            {
                ///???
                if (null == lastMigrateDateTime || lastMigrateDateTime != DateTime.MinValue)
                {
                    _appSettings.LastMigrateDateTime = DateTime.Now;
                    if (_appSettings.AppSettingsRepository != null)
                    {
                        await _appSettings.AppSettingsRepository.MergeAndSaveAsync(_appSettings);
                    }
                }
            }
        }

        #endregion

        #region public override int SaveChanges(bool acceptAllChangesOnSuccess)

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            SetDateOfCreateAndDateOfModification();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        #endregion

        #region public override int SaveChanges()

        public override int SaveChanges()
        {
            SetDateOfCreateAndDateOfModification();
            return base.SaveChanges();
        }

        #endregion

        #region public override Task<int> SaveChangesAsync...

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
            CancellationToken cancellationToken = default)
        {
            SetDateOfCreateAndDateOfModification();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        #endregion

        #region public override Task<int> SaveChangesAsync...

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            SetDateOfCreateAndDateOfModification();
            return base.SaveChangesAsync(cancellationToken);
        }

        #endregion

        #region private void SetDateOfCreateAndDateOfModification()

        /// <summary>
        ///     Ustaw datę utworzenia i datę modyfikacji
        ///     Set creation date and modification date
        /// </summary>
        private void SetDateOfCreateAndDateOfModification()
        {
            IEnumerable<EntityEntry> iEnumerableEntityEntry = ChangeTracker.Entries().Where(x =>
                x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));
            foreach (EntityEntry entity in iEnumerableEntityEntry)
            {
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).DateOfCreate = DateTime.Now;
                    ((BaseEntity)entity.Entity).DateOfModification = DateTime.Now;
                }

                ((BaseEntity)entity.Entity).DateOfModification = DateTime.Now;
            }
        }

        #endregion

        #region protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                if (!optionsBuilder.IsConfigured)
                {
                    var connectionString = _appSettings.GetConnectionString();
                    if (!string.IsNullOrWhiteSpace(connectionString))
                    {
                        optionsBuilder.UseSqlServer(connectionString,
                            x => x.MigrationsHistoryTable("__EFMigrationsHistory", "pagard"));
                        //optionsBuilder.UseNpgsql(connectionString,
                        //    x => x.MigrationsHistoryTable("__EFMigrationsHistory", "pagard"));
                    }
                }
            }
            catch (Exception e)
            {
                _log4Net.Error($"\n{e.GetType()}\n{e.InnerException?.GetType()}\n{e.Message}\n{e.StackTrace}\n", e);
            }
        }

        #endregion

        #region protected override void OnModelCreating(ModelBuilder modelBuilder)

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DaneSzukajPodmiotyConfiguration());
            modelBuilder.ApplyConfiguration(new DaneSzukajPodmiotyKomunikatyOBledachConfiguration());
            modelBuilder.ApplyConfiguration(new DaneSzukajPodmiotyMessageInspectorConfiguration());
            modelBuilder.ApplyConfiguration(new DaneSzukajPodmiotyParametryWyszukiwaniaConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11JednLokalnaOsFizycznejConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11JednLokalnaOsFizycznejMessageInspectorConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11JednLokalnaOsFizycznejPkdConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11JednLokalnaOsFizycznejPkdMessageInspectorConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11JednLokalnaOsPrawnejConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11JednLokalnaOsPrawnejMessageInspectorConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11JednLokalnaOsPrawnejPkdConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11JednLokalnaOsPrawnejPkdMessageInspectorConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11OsFizycznaDaneOgolneConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11OsFizycznaDaneOgolneMessageInspectorConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11OsFizycznaDzialalnoscCeidgConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11OsFizycznaDzialalnoscCeidgMessageInspectorConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11OsFizycznaDzialalnoscPozostalaConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11OsFizycznaDzialalnoscPozostalaMessageInspectorConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11OsFizycznaDzialalnoscRolniczaConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11OsFizycznaDzialalnoscRolniczaMessageInspectorConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Configuration());
            modelBuilder.ApplyConfiguration(new BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspectorConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11OsFizycznaListaJednLokalnychConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11OsFizycznaListaJednLokalnychMessageInspectorConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11OsFizycznaPkdConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11OsFizycznaPkdMessageInspectorConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11OsPrawnaConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11OsPrawnaMessageInspectorConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11OsPrawnaListaJednLokalnychConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11OsPrawnaListaJednLokalnychMessageInspectorConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11OsPrawnaPkdConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11OsPrawnaPkdMessageInspectorConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11OsPrawnaSpCywilnaWspolnicyConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11OsPrawnaSpCywilnaWspolnicyMessageInspectorConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11TypPodmiotuConfiguration());
            modelBuilder.ApplyConfiguration(new BIR11TypPodmiotuMessageInspectorConfiguration());
            modelBuilder.ApplyConfiguration(new MessageInspectorConfiguration());
        }

        #endregion

        #region public object GetConnectionString()

        /// <summary>
        ///     Pobierz łańcuch połączenia do bazy danych
        ///     Get the connection string to the database
        /// </summary>
        /// <returns>
        ///     Łańcuch połączenia do bazy danych jako string
        ///     Database connection string as string
        /// </returns>
        public object GetConnectionString() => Database.GetConnectionString();

        #endregion

        #region public static bool IsNpgsql()

        /// <summary>
        ///     Sprawdź, czy baza danych jest obsługiwana przez rozszerzenie Npgsql, dla PostgreSQL
        ///     Check that the database is supported by the Npgsql extension for PostgreSQL
        /// </summary>
        /// <returns>
        ///     Prawda, jeżeli rozszerzenie jest zainstalowane i ustawione do obsługi bazy danych PostgreSQL, przeciwnie fałsz
        ///     True if the extension is installed and set to support PostgreSQL, not false
        /// </returns>
        public static bool IsNpgsql()
        {
            try
            {
                try
                {
                    DatabaseFacade databaseFacade = GetDatabaseFacade();
                    MethodInfo? methodInfo = databaseFacade?.GetType()?.GetMethod("IsNpgsql");
                    if (methodInfo is not null)
                    {
                        // ReSharper disable once PossibleNullReferenceException
                        return (bool)methodInfo?.Invoke(databaseFacade, Array.Empty<object>());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                if (null != e.InnerException)
                {
                    Console.WriteLine(e.InnerException);
                }
            }

            return false;
        }

        #endregion
    }
}
