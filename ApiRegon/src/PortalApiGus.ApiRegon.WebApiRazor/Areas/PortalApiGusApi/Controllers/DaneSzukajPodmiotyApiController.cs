#region using

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using NetAppCommon;
using NetAppCommon.Extensions.Caching.Distributed;
using NetAppCommon.Logging;
using NetAppCommon.Models;
using PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmioty;
using PortalApiGus.ApiRegon.Core.Services.UslugaBIRzewnPublVer11Prod;
using PortalApiGus.ApiRegon.Core.ViewModels;
using PortalApiGus.ApiRegon.DataBase.Data;
using PortalApiGus.ApiRegon.DataBase.Repositories;

#endregion

namespace PortalApiGus.ApiRegon.WebApiRazor.Areas.PortalApiGusApi.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Authorize(AuthenticationSchemes = "Cookies")]
    [Area("PortalApiGusApi")]
    [Route("api/[area]/[controller]/[action]")]
    [ApiController]
    public class DaneSzukajPodmiotyApiController : ControllerBase
    {
        #region private readonly DataBaseContext _context

        /// <summary>
        ///     Context do bazy danych as DataBaseContext
        /// </summary>
        private readonly DataBaseContext _context;

        #endregion

        #region private readonly log4net.ILog log4net

        /// <summary>
        ///     private readonly ILog _log4Net
        /// </summary>
        private readonly ILog _log4Net =
            Log4NetLogger.GetLog4NetInstance(MethodBase.GetCurrentMethod()?.DeclaringType);

        #endregion

        #region private readonly IActionDescriptorCollectionProvider _provider

        /// <summary>
        ///     Action Descriptor Collection Provider
        /// </summary>
        private readonly IActionDescriptorCollectionProvider _provider;

        #endregion

        #region private readonly ICommonDistributedCache _cache

#pragma warning disable 169
        private readonly ICommonDistributedCache _cache;
#pragma warning restore 169

        #endregion

        #region public DaneSzukajPodmiotyApiController...

        /// <summary>
        ///     Konstruktor
        ///     Constructor
        /// </summary>
        /// <param name="context">
        ///     Kontekst do bazy danych as DataBaseContext
        ///     Database context as DataBaseContext
        /// </param>
        /// <param name="provider">
        ///     Dostawca kolekcji deskryptorów akcji jako IActionDescriptorCollectionProvider
        ///     Action descriptor collection provider as IActionDescriptorCollectionProvider
        /// </param>
        /// <param name="cache">
        ///     Wspólna rozproszona pamięć podręczna jako ICommonDistributedCache
        ///     Common Distributed Cache as ICommonDistributedCache
        /// </param>
        public DaneSzukajPodmiotyApiController(DataBaseContext context,
            IActionDescriptorCollectionProvider provider/*, ICommonDistributedCache cache*/)
        {
            _context = context;
            _provider = provider;
            //_cache = cache;
        }

        #endregion

        #region public async Task<ActionResult<List<ControllerRoutingActions>>> GetRouteAsync()

        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(AuthenticationSchemes = "Cookies")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(KendoGrid<ControllerRoutingActions>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Exception))]
        [HttpGet]
        public async Task<ActionResult<KendoGrid<List<ControllerRoutingActions>>>> GetRouteAsync()
        {
            try
            {
                List<ControllerRoutingActions> controllerRoutingActionsList = await ControllerRoute.GetRouteActionAsync(_provider,
                    ControllerContext.ActionDescriptor.ControllerName, Url, this);
                if (null != controllerRoutingActionsList && controllerRoutingActionsList.Count > 0)
                {
                    return new KendoGrid<List<ControllerRoutingActions>>
                    {
                        Total = controllerRoutingActionsList.Count, Data = controllerRoutingActionsList
                    };
                }
            }
            catch (Exception e)
            {
                _log4Net.Error(e);
                if (null != e.InnerException)
                {
                    _log4Net.Error(e.InnerException);
                }
                return StatusCode(500, e);
            }

            return NotFound();
        }

        #endregion

        #region public async Task<ActionResult<DaneSzukajPodmiotyViewModel>> GetDaneSzukajPodmiotyAsync...

        [Authorize(AuthenticationSchemes = "Cookies")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DaneSzukajPodmiotyViewModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ModelStateDictionary))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(DaneSzukajPodmiotyViewModel))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Exception))]
        [HttpGet("{dateOfCreateFrom:DateTime?}/{dateOfCreateTo:DateTime?}")]
        public async Task<ActionResult<DaneSzukajPodmiotyViewModel>> GetAllAsync(
            DateTime? dateOfCreateFrom = null, DateTime? dateOfCreateTo = null) => await GetAllAsync(
            new DaneSzukajPodmiotyViewModel { DateOfCreateFrom = dateOfCreateFrom, DateOfCreateTo = dateOfCreateTo });

        #endregion

        #region public async Task<ActionResult<DaneSzukajPodmiotyViewModel>> PostDaneSzukajPodmiotyAsync...

        [Authorize(AuthenticationSchemes = "Cookies")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DaneSzukajPodmiotyViewModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ModelStateDictionary))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(DaneSzukajPodmiotyViewModel))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Exception))]
        [HttpPost]
        public async Task<ActionResult<DaneSzukajPodmiotyViewModel>>
            GetAllAsync(
                DaneSzukajPodmiotyViewModel daneSzukajPodmiotyViewModel)
        {
            try
            {
                if (daneSzukajPodmiotyViewModel != null)
                {
                    //_log4Net.Info(
                    //    $"{daneSzukajPodmiotyViewModel.DateOfCreateFrom}, {daneSzukajPodmiotyViewModel.DateOfCreateTo}");
                    if (ModelState.IsValid)
                    {
                        List<DaneSzukajPodmioty> daneSzukajPodmiotyList = await _context.DaneSzukajPodmioty
                            .Where(w => (null == daneSzukajPodmiotyViewModel.DateOfCreateFrom ||
                                         w.DateOfCreate >= daneSzukajPodmiotyViewModel.DateOfCreateFrom) &&
                                        (null == daneSzukajPodmiotyViewModel.DateOfCreateTo ||
                                         w.DateOfCreate < daneSzukajPodmiotyViewModel.DateOfCreateTo))
                            .Include(i => i.DaneSzukajPodmiotyKomunikatyOBledach)
                            .Include(i => i.DaneSzukajPodmiotyParametryWyszukiwania)
                            .Include(i => i.DaneSzukajPodmiotyMessageInspector)
                            .OrderByDescending(o => o.DateOfCreate)
                            .IgnoreAutoIncludes()
                            .AsNoTracking()
                            .ToListAsync();
                        if (null != daneSzukajPodmiotyList && daneSzukajPodmiotyList.Count > 0)
                        {
                            return new DaneSzukajPodmiotyViewModel
                            (
                                daneSzukajPodmiotyViewModel.DateOfCreateFrom,
                                daneSzukajPodmiotyViewModel.DateOfCreateTo,
                                daneSzukajPodmiotyList.Count,
                                daneSzukajPodmiotyList
                            );
                        }
                    }
                    else
                    {
                        return BadRequest(ModelState);
                    }
                }
            }
            catch (Exception e)
            {
                _log4Net.Error(e);
                if (null != e.InnerException)
                {
                    _log4Net.Error(e.InnerException);
                }
                return StatusCode(500, e);
            }

            return NotFound(daneSzukajPodmiotyViewModel);
        }

        #endregion

        #region public async Task<ActionResult<DaneSzukajPodmiotyResult>> FindByKrsAsResultAsync...

        [Authorize(AuthenticationSchemes = "Cookies")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DaneSzukajPodmiotyResult))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Exception))]
        [HttpGet("{krs}/{canTrackRequests:bool?}/{cacheLifeTime:int?}/{pKluczUzytkownika?}")]
        public async Task<ActionResult<DaneSzukajPodmiotyResult>> FindByKrsAsResultAsync(
            string krs,
            bool canTrackRequests = false,
            int cacheLifeTime = 0,
            string pKluczUzytkownika = null
            )
        {
            try
            {
                if (cacheLifeTime > 0)
                {
                    return await new DaneSzukajPodmiotyRepository(_context).FindByKrsAsync(krs: krs, cacheLifeTime: cacheLifeTime)! ??
                           await new DaneSzukajPodmiotyRepository().AddRangeAsync(
                               await new DaneSzukajPodmiotyService().FindByKrsAsync(
                                   krs: krs,
                                   pKluczUzytkownika: pKluczUzytkownika,
                                   canTrackRequests: canTrackRequests
                               ))!;
                }
                return await new DaneSzukajPodmiotyRepository().AddRangeAsync(
                    await new DaneSzukajPodmiotyService().FindByKrsAsync(
                        krs: krs,
                        pKluczUzytkownika: pKluczUzytkownika,
                        canTrackRequests: canTrackRequests
                    ))!;
            }
            catch (Exception e)
            {
                _log4Net.Error(e);
                if (null != e.InnerException)
                {
                    _log4Net.Error(e.InnerException);
                }
                return StatusCode(500, e);
            }
        }

        #endregion

        #region public async Task<ActionResult<DaneSzukajPodmiotyResult>> FindByKrsAsync...

        [Authorize(AuthenticationSchemes = "Cookies")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DaneSzukajPodmioty))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Exception))]
        [HttpGet("{krs}/{canTrackRequests:bool?}/{cacheLifeTime:int?}/{pKluczUzytkownika?}")]
        public async Task<ActionResult<DaneSzukajPodmioty>> FindByKrsAsync(
            string krs,
            bool canTrackRequests = false,
            int cacheLifeTime = 0,
            string pKluczUzytkownika = null
        ) => await Task.FromResult(FindByKrsAsResultAsync(krs, canTrackRequests, cacheLifeTime, pKluczUzytkownika).Result.Value.Data.FirstOrDefault());

        #endregion

        #region public async Task<ActionResult<DaneSzukajPodmiotyResult>> FindByKrsyAsResultAsync...

        [Authorize(AuthenticationSchemes = "Cookies")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DaneSzukajPodmiotyResult))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Exception))]
        [HttpGet("{krsy}/{canTrackRequests:bool?}/{cacheLifeTime:int?}/{pKluczUzytkownika?}")]
        public async Task<ActionResult<DaneSzukajPodmiotyResult>> FindByKrsyAsResultAsync(
            string krsy,
            bool canTrackRequests = false,
            int cacheLifeTime = 0,
            string pKluczUzytkownika = null
            )
        {
            try
            {
                if (cacheLifeTime > 0)
                {
                    return await new DaneSzukajPodmiotyRepository(_context).FindByKrsyAsync(krsy: krsy, cacheLifeTime: cacheLifeTime)! ??
                           await new DaneSzukajPodmiotyRepository().AddRangeAsync(
                               await new DaneSzukajPodmiotyService().FindByKrsyAsync(
                                   krsy: krsy,
                                   pKluczUzytkownika: pKluczUzytkownika,
                                   canTrackRequests: canTrackRequests
                               ))!;
                }
                return await new DaneSzukajPodmiotyRepository().AddRangeAsync(
                    await new DaneSzukajPodmiotyService().FindByKrsyAsync(
                        krsy: krsy,
                        pKluczUzytkownika: pKluczUzytkownika,
                        canTrackRequests: canTrackRequests
                    ))!;
            }
            catch (Exception e)
            {
                _log4Net.Error(e);
                if (null != e.InnerException)
                {
                    _log4Net.Error(e.InnerException);
                }
                return StatusCode(500, e);
            }
        }

        #endregion

        #region public async Task<ActionResult<DaneSzukajPodmiotyResult>> FindByKrsyAsync...

        [Authorize(AuthenticationSchemes = "Cookies")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DaneSzukajPodmioty))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Exception))]
        [HttpGet("{krsy}/{canTrackRequests:bool?}/{cacheLifeTime:int?}/{pKluczUzytkownika?}")]
        public async Task<ActionResult<DaneSzukajPodmioty>> FindByKrsyAsync(
            string krsy,
            bool canTrackRequests = false,
            int cacheLifeTime = 0,
            string pKluczUzytkownika = null
        ) => await Task.FromResult(FindByKrsyAsResultAsync(krsy, canTrackRequests, cacheLifeTime, pKluczUzytkownika).Result.Value.Data.FirstOrDefault());

        #endregion

        #region public async Task<ActionResult<DaneSzukajPodmiotyResult>> FindByNipAsResultAsync...

        [Authorize(AuthenticationSchemes = "Cookies")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DaneSzukajPodmiotyResult))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Exception))]
        [HttpGet("{nip}/{canTrackRequests:bool?}/{cacheLifeTime:int?}/{pKluczUzytkownika?}")]
        public async Task<ActionResult<DaneSzukajPodmiotyResult>> FindByNipAsResultAsync(
            string nip,
            bool canTrackRequests = false,
            int cacheLifeTime = 0,
            string pKluczUzytkownika = null
            )
        {
            try
            {
                if (cacheLifeTime > 0)
                {
                    return await new DaneSzukajPodmiotyRepository(_context).FindByNipAsync(nip: nip, cacheLifeTime: cacheLifeTime)! ??
                           await new DaneSzukajPodmiotyRepository().AddRangeAsync(
                               await new DaneSzukajPodmiotyService().FindByNipAsync(
                                   nip: nip,
                                   pKluczUzytkownika: pKluczUzytkownika,
                                   canTrackRequests: canTrackRequests
                               ))!;
                }
                return await new DaneSzukajPodmiotyRepository().AddRangeAsync(
                    await new DaneSzukajPodmiotyService().FindByNipAsync(
                        nip: nip,
                        pKluczUzytkownika: pKluczUzytkownika,
                        canTrackRequests: canTrackRequests
                    ))!;
            }
            catch (Exception e)
            {
                _log4Net.Error(e);
                if (null != e.InnerException)
                {
                    _log4Net.Error(e.InnerException);
                }
                return StatusCode(500, e);
            }
        }

        #endregion

        #region public async Task<ActionResult<DaneSzukajPodmiotyResult>> FindByNipAsync...

        [Authorize(AuthenticationSchemes = "Cookies")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DaneSzukajPodmioty))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Exception))]
        [HttpGet("{nip}/{canTrackRequests:bool?}/{cacheLifeTime:int?}/{pKluczUzytkownika?}")]
        public async Task<ActionResult<DaneSzukajPodmioty>> FindByNipAsync(
            string nip,
            bool canTrackRequests = false,
            int cacheLifeTime = 0,
            string pKluczUzytkownika = null
        ) => await Task.FromResult(FindByNipAsResultAsync(nip, canTrackRequests, cacheLifeTime, pKluczUzytkownika).Result.Value.Data.FirstOrDefault());

        #endregion

        #region public async Task<ActionResult<DaneSzukajPodmiotyResult>> FindByRegonAsResultAsync...

        [Authorize(AuthenticationSchemes = "Cookies")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DaneSzukajPodmiotyResult))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Exception))]
        [HttpGet("{regon}/{canTrackRequests:bool?}/{cacheLifeTime:int?}/{pKluczUzytkownika?}")]
        public async Task<ActionResult<DaneSzukajPodmiotyResult>> FindByRegonAsResultAsync(
            string regon,
            bool canTrackRequests = false,
            int cacheLifeTime = 0,
            string pKluczUzytkownika = null
            )
        {
            try
            {
                if (cacheLifeTime > 0)
                {
                    return await new DaneSzukajPodmiotyRepository(_context).FindByRegonAsync(regon: regon, cacheLifeTime: cacheLifeTime)! ??
                           await new DaneSzukajPodmiotyRepository().AddRangeAsync(
                               await new DaneSzukajPodmiotyService().FindByRegonAsync(
                                   regon: regon,
                                   pKluczUzytkownika: pKluczUzytkownika,
                                   canTrackRequests: canTrackRequests
                               ))!;
                }
                return await new DaneSzukajPodmiotyRepository().AddRangeAsync(
                    await new DaneSzukajPodmiotyService().FindByRegonAsync(
                        regon: regon,
                        pKluczUzytkownika: pKluczUzytkownika,
                        canTrackRequests: canTrackRequests
                    ))!;
            }
            catch (Exception e)
            {
                _log4Net.Error(e);
                if (null != e.InnerException)
                {
                    _log4Net.Error(e.InnerException);
                }
                return StatusCode(500, e);
            }
        }

        #endregion

        #region public async Task<ActionResult<DaneSzukajPodmiotyResult>> FindByRegonAsync...

        [Authorize(AuthenticationSchemes = "Cookies")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DaneSzukajPodmioty))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Exception))]
        [HttpGet("{regon}/{canTrackRequests:bool?}/{cacheLifeTime:int?}/{pKluczUzytkownika?}")]
        public async Task<ActionResult<DaneSzukajPodmioty>> FindByRegonAsync(
            string regon,
            bool canTrackRequests = false,
            int cacheLifeTime = 0,
            string pKluczUzytkownika = null
        ) => await Task.FromResult(FindByRegonAsResultAsync(regon, canTrackRequests, cacheLifeTime, pKluczUzytkownika).Result.Value.Data.FirstOrDefault());

        #endregion
    }
}
