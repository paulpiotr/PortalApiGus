#region using

using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using log4net;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NetAppCommon.Logging;
using PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmioty;
using PortalApiGus.ApiRegon.DataBase.Data;
using PortalApiGus.ApiRegon.DataBase.Models;
using PortalApiGus.ApiRegon.DataBase.Repositories.Interface;

#endregion

#nullable enable annotations

namespace PortalApiGus.ApiRegon.DataBase.Repositories
{
    public class DaneSzukajPodmiotyRepository : IDaneSzukajPodmiotyRepository
    {
        #region private readonly AppSettings _appSettings

        /// <summary>
        ///     Instancja do klasy ustawień Vies.Core.Database.Models.AppSettings
        ///     Instance to the Vies.Core.Database.Models.AppSettings settings class
        /// </summary>
        private readonly AppSettings _appSettings = new();

        #endregion

        #region private readonly ViesCoreDatabaseContext _context

        /// <summary>
        ///     Instancja do klasy ustawień Vies.Core.Database.Models.ViesCoreDatabaseContext
        ///     Instance to the Vies.Core.Database.Models.ViesCoreDatabaseContext settings class
        /// </summary>
        private readonly DataBaseContext _context;

        #endregion

        #region private readonly log4net.ILog _log4Net

        /// <summary>
        ///     Referencja klasy Log4NetLogger
        ///     Reference to the Log4NetLogger class
        /// </summary>
        private readonly ILog _log4Net =
            Log4NetLogger.GetLog4NetInstance(MethodBase.GetCurrentMethod()?.DeclaringType);

        #endregion

        #region public DaneSzukajPodmiotyRepository...

        public DaneSzukajPodmiotyRepository()
        {
            _context = new DataBaseContext(_appSettings.GetDbContextOptions<DataBaseContext>());
        }

        #endregion

        #region public DaneSzukajPodmiotyRepository...

        public DaneSzukajPodmiotyRepository(DataBaseContext context)
        {
            _context = context;
        }

        #endregion

        #region public DaneSzukajPodmiotyRepository...

        public DaneSzukajPodmiotyRepository(IServiceProvider serviceProvider)
        {
            try
            {
                IServiceScope serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope();
                DataBaseContext context = serviceScope.ServiceProvider.GetService<DataBaseContext>();
                if (null != context)
                {
                    _context = context;
                }
            }
            catch (Exception e)
            {
                _log4Net.Error($"\n{e.GetType()}\n{e.InnerException?.GetType()}\n{e.Message}\n{e.StackTrace}\n", e);
            }
        }

        #endregion

        #region public DaneSzukajPodmiotyRepository...

        public DaneSzukajPodmiotyRepository(IServiceScopeFactory serviceScopeFactory)
        {
            try
            {
                IServiceScope serviceScope = serviceScopeFactory.CreateScope();
                DataBaseContext context = serviceScope.ServiceProvider.GetService<DataBaseContext>();
                if (null != context)
                {
                    _context = context;
                }
            }
            catch (Exception e)
            {
                _log4Net.Error($"\n{e.GetType()}\n{e.InnerException?.GetType()}\n{e.Message}\n{e.StackTrace}\n", e);
            }
        }

        #endregion

        #region public async Task<DaneSzukajPodmiotyResult>? FindByKrsAsync(string krs, int cacheLifeTime = 0)

        public async Task<DaneSzukajPodmiotyResult>? FindByKrsAsync(string krs, int cacheLifeTime = 0) =>
            await FindAsync(krs, cacheLifeTime: cacheLifeTime)!;

        #endregion

        #region public DaneSzukajPodmiotyResult? FindByKrs(string krs, int cacheLifeTime = 0)

        public DaneSzukajPodmiotyResult? FindByKrs(string krs, int cacheLifeTime = 0) =>
            Find(krs, cacheLifeTime: cacheLifeTime);

        #endregion

        #region public async Task<DaneSzukajPodmiotyResult>? FindByKrsyAsync(string krsy, int cacheLifeTime = 0)

        public async Task<DaneSzukajPodmiotyResult>? FindByKrsyAsync(string krsy, int cacheLifeTime = 0) =>
            await FindAsync(krsy, cacheLifeTime: cacheLifeTime)!;

        #endregion

        #region public DaneSzukajPodmiotyResult? FindByKrsy(string krsy, int cacheLifeTime = 0)

        public DaneSzukajPodmiotyResult? FindByKrsy(string krsy, int cacheLifeTime = 0) =>
            Find(krsy, cacheLifeTime: cacheLifeTime);

        #endregion

        #region public async Task<DaneSzukajPodmiotyResult>? FindByNipAsync(string nip, int cacheLifeTime = 0)

        public async Task<DaneSzukajPodmiotyResult>? FindByNipAsync(string nip, int cacheLifeTime = 0) =>
            await FindAsync(nip, cacheLifeTime: cacheLifeTime)!;

        #endregion

        #region public DaneSzukajPodmiotyResult? FindByNip(string nip, int cacheLifeTime = 0)

        public DaneSzukajPodmiotyResult? FindByNip(string nip, int cacheLifeTime = 0) =>
            Find(nip, cacheLifeTime: cacheLifeTime);

        #endregion

        #region public async Task<DaneSzukajPodmiotyResult>? FindByRegonAsync(string regon, int cacheLifeTime = 0)

        public async Task<DaneSzukajPodmiotyResult>? FindByRegonAsync(string regon, int cacheLifeTime = 0) =>
            await FindAsync(regon, cacheLifeTime: cacheLifeTime)!;

        #endregion

        #region public DaneSzukajPodmiotyResult? FindByRegon(string regon, int cacheLifeTime = 0)

        public DaneSzukajPodmiotyResult? FindByRegon(string regon, int cacheLifeTime = 0) =>
            Find(regon, cacheLifeTime: cacheLifeTime);

        #endregion

        #region public async Task<DaneSzukajPodmiotyResult>? AddRangeAsync(DaneSzukajPodmiotyResult daneSzukajPodmiotyResult)

        public async Task<DaneSzukajPodmiotyResult>? AddRangeAsync(DaneSzukajPodmiotyResult daneSzukajPodmiotyResult) =>
            await Task.Run(async () =>
            {
                try
                {
                    if (daneSzukajPodmiotyResult.Data.Count > 0)
                    {
                        await _context.AddRangeAsync(daneSzukajPodmiotyResult.Data);
                        await _context.SaveChangesAsync();
                    }
                }
                catch (Exception e)
                {
                    _log4Net.Error(e);
                    if (null != e.InnerException)
                    {
                        _log4Net.Error(e.InnerException);
                    }
                }

                return daneSzukajPodmiotyResult;
            });
        #endregion

        #region public DaneSzukajPodmiotyResult? AddRange(DaneSzukajPodmiotyResult daneSzukajPodmiotyResult)

        public DaneSzukajPodmiotyResult? AddRange(DaneSzukajPodmiotyResult daneSzukajPodmiotyResult) =>
            AddRangeAsync(daneSzukajPodmiotyResult)?.Result!;

        #endregion

        #region private DaneSzukajPodmiotyResult? Find

        private DaneSzukajPodmiotyResult? Find(string krs = null!,
            string krsy = null!, string nip = null!, string nipy = null!, string regon = null!,
            string regony14Zn = null!,
            string regony9Zn = null!, int cacheLifeTime = 0) => FindAsync(krs!,
                krsy!, nip!, nipy!, regon!,
                regony14Zn!,
                regony9Zn!, cacheLifeTime)
            ?.Result!;

        #endregion

        #region private async Task<DaneSzukajPodmiotyResult>? FindAsync...

        private async Task<DaneSzukajPodmiotyResult>? FindAsync(string krs = null!,
            string krsy = null!, string nip = null!, string nipy = null!, string regon = null!,
            string regony14Zn = null!,
            string regony9Zn = null!, int cacheLifeTime = 0) => await Task.Run(async () =>
        {
            try
            {
                Guid guid = (await _context.DaneSzukajPodmiotyParametryWyszukiwania.Where(w =>
                        (null == krs || w.Krs == krs) &&
                        (null == krsy || w.Krsy == krsy) &&
                        (null == nip || w.Nip == nip) &&
                        (null == nipy || w.Nipy == nipy) &&
                        (null == regon || w.Regon == regon) &&
                        (null == regony14Zn || w.Regony14zn == regony14Zn) &&
                        (null == regony9Zn || w.Regony9zn == regony9Zn) &&
                        (cacheLifeTime == 0 || w.DateOfCreate >= DateTime.Now.AddSeconds((double)cacheLifeTime * -1))
                    )
                    .IgnoreAutoIncludes()
                    .AsNoTracking()
                    .FirstOrDefaultAsync()).Id;

                if (guid != Guid.Empty)
                {
                    return new DaneSzukajPodmiotyResult(await _context.DaneSzukajPodmioty.Where(w =>
                            w.DaneSzukajPodmiotyParametryWyszukiwaniaId == guid
                        )
                        .Include(i => i.DaneSzukajPodmiotyParametryWyszukiwania)
                        .Include(i => i.DaneSzukajPodmiotyKomunikatyOBledach)
                        .Include(i => i.DaneSzukajPodmiotyMessageInspector)
                        .ThenInclude(ti => ti.MessageInspector)
                        .OrderByDescending(o => o.DateOfCreate)
                        .IgnoreAutoIncludes()
                        .AsNoTracking()
                        .ToListAsync());
                }
            }
            catch (Exception e)
            {
                _log4Net.Error(e);
                if (null != e.InnerException)
                {
                    _log4Net.Error(e.InnerException);
                }
            }

            return null;
        });

        #endregion
    }
}
