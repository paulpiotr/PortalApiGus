#region using

using System;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using log4net;
using NetAppCommon.Logging;
using NetAppCommon.Logging.ClientMessageInspector.Repositories;
using NetAppCommon.Logging.ClientMessageInspector.Repositories.Interface;
using PortalApiGus.ApiRegon.Core.Logging;
using PortalApiGus.ApiRegon.Core.Models;
using PortalApiGus.ApiRegon.Core.Services.UslugaBIRzewnPublVer11Prod.Interface;
using UslugaBIRzewnPublVer11Prod;

#endregion

namespace PortalApiGus.ApiRegon.Core.Services.UslugaBIRzewnPublVer11Prod
{
    #region public class UslugaBIRzewnPublClientService : IUslugaBIRzewnPublClientService

    /// <summary>
    ///     Implementacja usługi BIR zewn Publ Ver 11 Prod
    ///     Implementation of the BIR service external Publ Ver 11 Prod
    /// </summary>
    public class UslugaBiRzewnPublClientService : IUslugaBiRzewnPublClientService
    {
        #region private readonly AppSettings _appSettings = new();

        /// <summary>
        ///     Referencja do ustawień jako AppSettings
        ///     Reference to the settings as AppSettings
        /// </summary>
        private readonly AppSettings _appSettings = new();

        #endregion

        #region private readonly Guid _guid...

        /// <summary>
        ///     Unikalny identyfikator pamięci rozproszonej jako Guid
        ///     Unique identifier for distributed memory as Guid
        /// </summary>
        private readonly Guid _guid = Guid.NewGuid();

        #endregion

        #region private readonly log4net.ILog log4net

        /// <summary>
        ///     Instancja do klasy Log4netLogger
        ///     Instance to Log4netLogger class
        /// </summary>
        private readonly ILog _log4Net =
            Log4NetLogger.GetLog4NetInstance(MethodBase.GetCurrentMethod()?.DeclaringType);

        #endregion

        #region private readonly IDistributedCacheRepository _repository

        /// <summary>
        ///     private readonly IDistributedCacheRepository _repository;
        /// </summary>
        private readonly IDistributedCacheRepository _repository;

        #endregion

        #region private string _pIdentyfikatorSesji

        /// <summary>
        ///     Identyfikator sesji zalogowanego użytkownika do usługi jako string
        ///     Session ID of the logged in user to the service as a string
        /// </summary>
        private string _pIdentyfikatorSesji;

        #endregion

        #region private string _pKluczUzytkownika

        private string _pKluczUzytkownika;

        #endregion

        #region private UslugaBIRzewnPublClient _uslugaBiRzewnPublClient

        /// <summary>
        ///     Referencja do usługi jako UslugaBIRzewnPublClient
        ///     Reference to the service as UslugaBIRzewnPublClient
        /// </summary>
        private UslugaBIRzewnPublClient _uslugaBiRzewnPublClient;

        #endregion

        #region public UslugaBIRzewnPublClientService(IDistributedCacheRepository repository)

        /// <summary>
        ///     Konstruktor
        ///     Constructor
        /// </summary>
        /// <param name="repository">
        ///     IDistributedCacheRepository repository
        /// </param>
        public UslugaBiRzewnPublClientService(IDistributedCacheRepository repository)
        {
            _repository = repository;
        }

        #endregion

        #region public UslugaBIRzewnPublClientService()

        /// <summary>
        ///     Konstruktor
        ///     Constructor
        /// </summary>
        public UslugaBiRzewnPublClientService()
        {
            _repository = new DistributedCacheRepository();
        }

        #endregion

        public UslugaBIRzewnPublClient GetClient(string pKluczUzytkownika = null, bool canTrackRequests = false)
        {
            try
            {
                if (null == _uslugaBiRzewnPublClient)
                {
                    _pKluczUzytkownika = pKluczUzytkownika ?? _appSettings.PortalApiGusKey;
                    _uslugaBiRzewnPublClient = new UslugaBIRzewnPublClient();
                    if (canTrackRequests)
                    {
                        _uslugaBiRzewnPublClient.Endpoint.EndpointBehaviors.Add(new SoapEndpointBehavior(_guid));
                    }

                    _pIdentyfikatorSesji = Zaloguj(_pKluczUzytkownika);
                    if (null != _pIdentyfikatorSesji && !string.IsNullOrWhiteSpace(_pIdentyfikatorSesji))
                    {
                        var operationContextScope = new OperationContextScope(_uslugaBiRzewnPublClient.InnerChannel);
                        var httpRequestMessageProperty = new HttpRequestMessageProperty();
                        httpRequestMessageProperty.Headers.Add("sid", _pIdentyfikatorSesji);
                        OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] =
                            httpRequestMessageProperty;

                        return _uslugaBiRzewnPublClient;
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
            }

            return _uslugaBiRzewnPublClient;
        }

        public async Task<UslugaBIRzewnPublClient> GetClientAsync(string pKluczUzytkownika = null,
            bool canTrackRequests = false) => await Task.Run(async () =>
        {
            try
            {
                _pKluczUzytkownika = pKluczUzytkownika ?? _appSettings.PortalApiGusKey;
                _uslugaBiRzewnPublClient = new UslugaBIRzewnPublClient();
                if (canTrackRequests)
                {
                    _uslugaBiRzewnPublClient.Endpoint.EndpointBehaviors.Add(new SoapEndpointBehavior(_guid));
                }

                _pIdentyfikatorSesji = await ZalogujAsync(_pKluczUzytkownika);
                if (null != _pIdentyfikatorSesji && !string.IsNullOrWhiteSpace(_pIdentyfikatorSesji))
                {
                    var operationContextScope = new OperationContextScope(_uslugaBiRzewnPublClient.InnerChannel);
                    var httpRequestMessageProperty = new HttpRequestMessageProperty();
                    httpRequestMessageProperty.Headers.Add("sid", _pIdentyfikatorSesji);
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] =
                        httpRequestMessageProperty;

                    return _uslugaBiRzewnPublClient;
                }
            }
            catch (Exception e)
            {
                _log4Net.Error(e.Message, e);
                if (null != e.InnerException)
                {
                    _log4Net.Error(e.InnerException.Message, e.InnerException);
                }
            }

            return _uslugaBiRzewnPublClient;
        });

        public bool Wyloguj(string pIdentyfikatorSesji = null)
        {
            try
            {
                _pIdentyfikatorSesji ??= pIdentyfikatorSesji;
                if (null != _pIdentyfikatorSesji && !string.IsNullOrWhiteSpace(_pIdentyfikatorSesji))
                {
                    _uslugaBiRzewnPublClient ??= new UslugaBIRzewnPublClient();
                    return _uslugaBiRzewnPublClient.Wyloguj(_pIdentyfikatorSesji);
                }
            }
            catch (Exception e)
            {
                _log4Net.Error(e.Message, e);
                if (null != e.InnerException)
                {
                    _log4Net.Error(e.InnerException.Message, e.InnerException);
                }
            }

            finally
            {
                _pIdentyfikatorSesji = null;
            }

            return false;
        }

        public async Task<bool> WylogujAsync(string pIdentyfikatorSesji = null) =>
            await Task.Run(() =>
            {
                try
                {
                    _pIdentyfikatorSesji ??= pIdentyfikatorSesji;
                    if (null != _pIdentyfikatorSesji && !string.IsNullOrWhiteSpace(_pIdentyfikatorSesji))
                    {
                        _uslugaBiRzewnPublClient ??= new UslugaBIRzewnPublClient();
                        return _uslugaBiRzewnPublClient.WylogujAsync(_pIdentyfikatorSesji).Result.WylogujResult;
                    }
                }
                catch (Exception e)
                {
                    _log4Net.Error(e.Message, e);
                    if (null != e.InnerException)
                    {
                        _log4Net.Error(e.InnerException.Message, e.InnerException);
                    }
                }

                finally
                {
                    _pIdentyfikatorSesji = null;
                }

                return false;
            });

        public string Zaloguj(string pKluczUzytkownika = null)
        {
            try
            {
                _pKluczUzytkownika ??= pKluczUzytkownika ?? _appSettings.PortalApiGusKey;
                _uslugaBiRzewnPublClient ??= new UslugaBIRzewnPublClient();
                var zalogujResult = _uslugaBiRzewnPublClient.Zaloguj(_pKluczUzytkownika);
                if (null != zalogujResult && !string.IsNullOrWhiteSpace(zalogujResult))
                {
//#if DEBUG
//                    _log4Net.Debug(
//                        $"Logowanie do serwisu aplikacji [{_uslugaBiRzewnPublClient?.State}] [{zalogujResult}] OK");
//#endif
                    return zalogujResult;
                }
//#if DEBUG
//                _log4Net.Debug($"Logowanie do serwisu aplikacji [{_uslugaBiRzewnPublClient?.State}] BŁĄD");
//#endif
            }
            catch (Exception e)
            {
                _log4Net.Error(e.Message, e);
                if (null != e.InnerException)
                {
                    _log4Net.Error(e.InnerException.Message, e.InnerException);
                }
            }

            return string.Empty;
        }

        public async Task<string> ZalogujAsync(string pKluczUzytkownika = null) =>
            await Task.Run(async () =>
            {
                try
                {
                    _pKluczUzytkownika ??= pKluczUzytkownika ?? _appSettings.PortalApiGusKey;
                    _uslugaBiRzewnPublClient ??= new UslugaBIRzewnPublClient();
                    ZalogujResponse zalogujResponse = await _uslugaBiRzewnPublClient.ZalogujAsync(pKluczUzytkownika);
                    if (null != zalogujResponse && !string.IsNullOrWhiteSpace(zalogujResponse.ZalogujResult))
                    {
//#if DEBUG
//                        _log4Net.Debug(
//                            $"Logowanie do serwisu aplikacji [{_uslugaBiRzewnPublClient?.State}] [{zalogujResponse.ZalogujResult}] OK");
//#endif
                        return zalogujResponse.ZalogujResult;
                    }
//#if DEBUG
//                    _log4Net.Debug($"Logowanie do serwisu aplikacji [{_uslugaBiRzewnPublClient?.State}] BŁĄD");
//#endif
                }

                catch (Exception e)
                {
                    _log4Net.Error(e.Message, e);
                    if (null != e.InnerException)
                    {
                        _log4Net.Error(e.InnerException.Message, e.InnerException);
                    }
                }

                return string.Empty;
            });

        public Guid GetGuid() => _guid;

        public DistributedCacheRepository GetDistributedCacheRepository() => (DistributedCacheRepository)_repository;
    }

    #endregion
}
