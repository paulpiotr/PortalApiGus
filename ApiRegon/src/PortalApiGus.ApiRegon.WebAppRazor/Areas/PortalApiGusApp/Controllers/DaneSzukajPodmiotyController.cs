#region using

using System;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using log4net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NetAppCommon.Logging;
using PortalApiGus.ApiRegon.Core.Models;
using PortalApiGus.ApiRegon.Core.ViewModels;

#endregion

namespace PortalApiGus.ApiRegon.WebAppRazor.Areas.PortalApiGusApp.Controllers
{
    [Authorize(AuthenticationSchemes = "Cookies")]
    [Area("PortalApiGusApp")]
    [Route("[area]/[controller]/[action]")]
    public class DaneSzukajPodmiotyController : Controller
    {
        #region private readonly log4net.ILog log4net

        /// <summary>
        ///     ILog _log4Net
        /// </summary>
        private readonly ILog _log4Net =
            Log4NetLogger.GetLog4NetInstance(MethodBase.GetCurrentMethod()?.DeclaringType);

        #endregion

        #region public IActionResult Index...

        [HttpGet]
        [ActionName(nameof(Index))]
        [Authorize(AuthenticationSchemes = "Cookies", Policy = null, Roles = "User")]
        public IActionResult Index() => View(new DaneSzukajPodmiotyViewModel());

        #endregion

        #region public IActionResult CoreAppSettings...

        [HttpGet]
        [ActionName(nameof(CoreAppSettings))]
        [Authorize(AuthenticationSchemes = "Cookies", Policy = null, Roles = "Administrator")]
        public IActionResult CoreAppSettings() => View(new AppSettings());

        #endregion

        #region public async Task<IActionResult> CoreAppSettingsAsync...

        [HttpPost]
        [ActionName(nameof(CoreAppSettings))]
        [ValidateAntiForgeryToken]
        [Authorize(AuthenticationSchemes = "Cookies", Policy = null, Roles = "Administrator")]
        public async Task<IActionResult> CoreAppSettingsAsync([Bind("PortalApiGusKey")] AppSettings model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (null != model.AppSettingsRepository)
                    {
                        await model.AppSettingsRepository?.MergeAndSaveAsync(model);
                        return RedirectToAction("RedirectAndRestartAsync", "Home", new { ReturnUrl = Url.Action("CoreAppSettings") });
                    }
                }
            }
            catch (Exception e)
            {
                _log4Net.Error(e.Message, e);
                if (null != e.InnerException)
                {
                    _log4Net.Error(e.InnerException.Message, e.InnerException);
                }

                return StatusCode(500, e);
            }

            return View(model);
        }

        #endregion

        #region public IActionResult DataBaseAppSettings...

        [HttpGet]
        [ActionName(nameof(DataBaseAppSettings))]
        [Authorize(AuthenticationSchemes = "Cookies", Policy = null, Roles = "Administrator")]
        public IActionResult DataBaseAppSettings() => View(new DataBase.Models.AppSettings());

        #endregion

        #region public async Task<IActionResult> DataBaseAppSettingsAsync...

        [HttpPost]
        [ActionName(nameof(DataBaseAppSettings))]
        [ValidateAntiForgeryToken]
        [Authorize(AuthenticationSchemes = "Cookies", Policy = null, Roles = "Administrator")]
        public async Task<IActionResult> DataBaseAppSettingsAsync([Bind("CacheLifeTime", "ConnectionString", "CheckForConnection", "CheckAndMigrate",
            "UseGlobalDatabaseConnectionSettings")] DataBase.Models.AppSettings model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (model.CheckAndMigrate)
                    {
                        model.LastMigrateDateTime = DateTime.MinValue;
                    }

                    if (model.UseGlobalDatabaseConnectionSettings)
                    {
                        model.ConnectionString = new NetAppCommon.AppSettings.Models.AppSettings().GetConnectionString();
                    }

                    if (null != model.AppSettingsRepository)
                    {
                        await model.AppSettingsRepository?.MergeAndSaveAsync(model);
                        return RedirectToAction("RedirectAndRestartAsync", "Home", new { ReturnUrl = Url.Action("DataBaseAppSettings") });
                    }
                }
            }
            catch (Exception e)
            {
                _log4Net.Error(e.Message, e);
                if (null != e.InnerException)
                {
                    _log4Net.Error(e.InnerException.Message, e.InnerException);
                }

                return StatusCode(500, e);
            }

            return View(model);
        }

        #endregion

        #region public IActionResult Route...

        [HttpGet]
        [ActionName(nameof(Route))]
        [Authorize(AuthenticationSchemes = "Cookies", Policy = null, Roles = "User")]
        public IActionResult Route() => View();

        #endregion
    }
}
