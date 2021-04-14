#region using

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using log4net;
using NetAppCommon.Extensions.Caching.Distributed;
using NetAppCommon.Logging;
using PortalApiGus.ApiRegon.Core.Models;
using PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport;
using PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmioty;
using PortalApiGus.ApiRegon.Core.Services.UslugaBIRzewnPublVer11Prod.Interface;
using UslugaBIRzewnPublVer11Prod;

#endregion

namespace PortalApiGus.ApiRegon.Core.Services.UslugaBIRzewnPublVer11Prod
{
    public class DaneSzukajPodmiotyService : UslugaBIRzewnPublClientService, IDaneSzukajPodmiotyService
    {
        #region private readonly ICommonDistributedCache _commonDistributedCache

        private readonly ICommonDistributedCache _commonDistributedCache;

        #endregion

        #region private readonly log4net.ILog log4net

        /// <summary>
        ///     Instancja do klasy Log4netLogger
        ///     Instance to Log4netLogger class
        /// </summary>
        private readonly ILog _log4Net =
            Log4NetLogger.GetLog4NetInstance(MethodBase.GetCurrentMethod()?.DeclaringType);

        #endregion

        #region private DaneSzukajPodmiotyParametryWyszukiwania _daneSzukajPodmiotyParametryWyszukiwania;

        /// <summary>
        ///     Model danych DaneSzukajPodmiotyParametryWyszukiwania
        ///     Data Model Data Search Entities Search Parameters
        /// </summary>
        private DaneSzukajPodmiotyParametryWyszukiwania _daneSzukajPodmiotyParametryWyszukiwania;

        #endregion

        #region private ParametryWyszukiwania _parametryWyszukiwania;

        /// <summary>
        ///     Model danych ParametryWyszukiwania
        ///     Data Model Search Parameters
        /// </summary>
        private ParametryWyszukiwania _parametryWyszukiwania;

        #endregion

        #region public DaneSzukajPodmiotyService()

        public DaneSzukajPodmiotyService()
        {
        }

        #endregion

        #region public DaneSzukajPodmiotyService(ICommonDistributedCache commonDistributedCache)

        public DaneSzukajPodmiotyService(ICommonDistributedCache commonDistributedCache)
        {
            _commonDistributedCache = commonDistributedCache;
        }

        #endregion

        public string DaneSzukajPodmiotyAsXmlString(
            string pKluczUzytkownika = null, bool canTrackRequests = false, bool canLogout = true, string krs = null,
            string krsy = null,
            string nip = null, string nipy = null,
            string regon = null, string regony14Zn = null, string regony9Zn = null)
        {
            try
            {
                _daneSzukajPodmiotyParametryWyszukiwania = new DaneSzukajPodmiotyParametryWyszukiwania
                {
                    Krs = krs!,
                    Krsy = krsy!,
                    Nip = nip!,
                    Nipy = nipy!,
                    Regon = regon!,
                    Regony14zn = regony14Zn!,
                    Regony9zn = regony9Zn!
                };
                _parametryWyszukiwania = _daneSzukajPodmiotyParametryWyszukiwania.AsParametryWyszukiwania();

                return GetClient(pKluczUzytkownika, canTrackRequests)
                    .DaneSzukajPodmioty(_parametryWyszukiwania);
            }
            catch (Exception e)
            {
                _log4Net.Error(e);
                if (null != e.InnerException)
                {
                    _log4Net.Error(e.InnerException);
                }
            }

            finally
            {
                if (canLogout)
                {
                    Wyloguj();
                }
            }

            return null;
        }

        public async Task<string> DaneSzukajPodmiotyAsXmlStringAsync(string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true,
            string krs = null,
            string krsy = null, string nip = null, string nipy = null, string regon = null, string regony14Zn = null,
            string regony9Zn = null) => await Task.Run(async () =>

        {
            try
            {
                _daneSzukajPodmiotyParametryWyszukiwania = new DaneSzukajPodmiotyParametryWyszukiwania
                {
                    Krs = krs!,
                    Krsy = krsy!,
                    Nip = nip!,
                    Nipy = nipy!,
                    Regon = regon!,
                    Regony14zn = regony14Zn!,
                    Regony9zn = regony9Zn!
                };

                _parametryWyszukiwania = _daneSzukajPodmiotyParametryWyszukiwania.AsParametryWyszukiwania();

                UslugaBIRzewnPublClient client = await GetClientAsync(pKluczUzytkownika, canTrackRequests);
                if (null != client)
                {
                    DaneSzukajPodmiotyResponse value = await client.DaneSzukajPodmiotyAsync(_parametryWyszukiwania);
                    if (null != value)
                    {
                        return value.DaneSzukajPodmiotyResult;
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
            }

            finally
            {
                if (canLogout)
                {
                    await WylogujAsync();
                }
            }

            return null;
        });

        public DaneSzukajPodmiotyResult FindByKrs(string krs, string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true) => DaneSzukajPodmiotyAsObject(
            pKluczUzytkownika, canTrackRequests, canLogout,
            krs);

        public async Task<DaneSzukajPodmiotyResult> FindByKrsAsync(string krs, string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true) => await DaneSzukajPodmiotyAsObjectAsync(
            pKluczUzytkownika, canTrackRequests, canLogout,
            krs);

        public DaneSzukajPodmiotyResult FindByKrsy(string krsy, string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true) => DaneSzukajPodmiotyAsObject(
            pKluczUzytkownika, canTrackRequests, canLogout,
            krsy: krsy);

        public async Task<DaneSzukajPodmiotyResult> FindByKrsyAsync(string krsy, string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true) => await DaneSzukajPodmiotyAsObjectAsync(
            pKluczUzytkownika, canTrackRequests, canLogout,
            krsy: krsy);

        public DaneSzukajPodmiotyResult FindByNip(string nip, string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true) => DaneSzukajPodmiotyAsObject(
            pKluczUzytkownika, canTrackRequests, canLogout, nip: nip);

        public async Task<DaneSzukajPodmiotyResult> FindByNipAsync(string nip, string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true) => await DaneSzukajPodmiotyAsObjectAsync(
            pKluczUzytkownika, canTrackRequests, canLogout,
            nip: nip);

        public DaneSzukajPodmiotyResult FindByRegon(string regon, string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true) => DaneSzukajPodmiotyAsObject(
            pKluczUzytkownika, canTrackRequests, canLogout,
            regon: regon);

        public async Task<DaneSzukajPodmiotyResult> FindByRegonAsync(string regon, string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true) => await DaneSzukajPodmiotyAsObjectAsync(
            pKluczUzytkownika, canTrackRequests, canLogout,
            regon: regon);

        public List<DaneSzukajPodmioty> FindByRegony14Zn(string regony14Zn, string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true)
        {
            try
            {
                var xml =
                    DaneSzukajPodmiotyAsXmlString(pKluczUzytkownika, canTrackRequests, canLogout,
                        regony14Zn: regony14Zn);
                return new DaneSzukajPodmiotyResult(_daneSzukajPodmiotyParametryWyszukiwania,
                    xml).Data;
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
        }

        public async Task<List<DaneSzukajPodmioty>> FindByRegony14ZnAsync(string regony14Zn,
            string pKluczUzytkownika = null, bool canTrackRequests = false, bool canLogout = true) => await Task.Run(
            async () =>
            {
                try
                {
                    var xml = await DaneSzukajPodmiotyAsXmlStringAsync(pKluczUzytkownika,
                        canTrackRequests, canLogout, regony14Zn: regony14Zn);
                    return new DaneSzukajPodmiotyResult(_daneSzukajPodmiotyParametryWyszukiwania,
                        xml).Data;
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

        public List<DaneSzukajPodmioty> FindByRegony9Zn(string regony9Zn, string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true)
        {
            try
            {
                var xml =
                    DaneSzukajPodmiotyAsXmlString(pKluczUzytkownika, canTrackRequests, canLogout, regony9Zn: regony9Zn);
                return new DaneSzukajPodmiotyResult(_daneSzukajPodmiotyParametryWyszukiwania,
                    xml).Data;
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
        }

        public async Task<List<DaneSzukajPodmioty>> FindByRegony9ZnAsync(string regony9Zn,
            string pKluczUzytkownika = null, bool canTrackRequests = false, bool canLogout = true) => await Task.Run(
            async () =>
            {
                try
                {
                    var xml =
                        await DaneSzukajPodmiotyAsXmlStringAsync(pKluczUzytkownika, canTrackRequests, canLogout,
                            regony9Zn: regony9Zn);
                    return new DaneSzukajPodmiotyResult(_daneSzukajPodmiotyParametryWyszukiwania,
                        xml).Data;
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

        public DaneSzukajPodmiotyResult DaneSzukajPodmiotyAsObject(string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true, string krs = null, string krsy = null,
            string nip = null, string nipy = null,
            string regon = null, string regony14Zn = null, string regony9Zn = null)
        {
            try
            {
                var xml = DaneSzukajPodmiotyAsXmlString(pKluczUzytkownika,
                    canTrackRequests, canLogout, krs, krsy, nip, nipy,
                    regon, regony14Zn, regony9Zn);
                if (null != xml)
                {
                    return new DaneSzukajPodmiotyResult(_daneSzukajPodmiotyParametryWyszukiwania,
                        xml,
                        GetDistributedCacheRepository()?.ToList<MessageInspector>(GetGuid())!);
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
        }

        public async Task<DaneSzukajPodmiotyResult> DaneSzukajPodmiotyAsObjectAsync(string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true, string krs = null, string krsy = null,
            string nip = null, string nipy = null,
            string regon = null, string regony14Zn = null, string regony9Zn = null) => await Task.Run(async () =>
        {
            try
            {
                var xml = await DaneSzukajPodmiotyAsXmlStringAsync(pKluczUzytkownika,
                    canTrackRequests, canLogout, krs, krsy, nip, nipy,
                    regon, regony14Zn, regony9Zn);

                if (null != xml)
                {
                    return new DaneSzukajPodmiotyResult(
                        _daneSzukajPodmiotyParametryWyszukiwania,
                        xml,
                        GetDistributedCacheRepository()?.ToList<MessageInspector>(GetGuid())!);
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

        public TModel DanePobierzPelnyRaport<TModel>(string pRegon, string pNazwaRaportu,
            string pKluczUzytkownika = null, bool canTrackRequests = false, bool canLogout = true)
            where TModel : DanePobierzPelnyRaport, new()
        {
            try
            {
                var xml = GetClient(pKluczUzytkownika, canTrackRequests)
                    .DanePobierzPelnyRaport(pRegon, pNazwaRaportu);
                if (canLogout)
                {
                    Wyloguj();
                }

                return new TModel().Create<TModel>(
                    pRegon,
                    pNazwaRaportu,
                    xml,
                    GetDistributedCacheRepository()?.ToList<MessageInspector>(GetGuid())!);
            }

            catch (Exception e)
            {
                _log4Net.Error(e);
                if (null != e.InnerException)
                {
                    _log4Net.Error(e.InnerException);
                }
            }

            finally
            {
                if (canLogout)
                {
                    Wyloguj();
                }

                //GetDistributedCacheRepository()?.Remove(GetGuid());
            }

            return null;
        }

        public async Task<TModel> DanePobierzPelnyRaportAsync<TModel>(string pRegon, string pNazwaRaportu,
            string pKluczUzytkownika = null, bool canTrackRequests = false, bool canLogout = true)
            where TModel : DanePobierzPelnyRaport, new()
        {
            try
            {
                UslugaBIRzewnPublClient client = await GetClientAsync(pKluczUzytkownika, canTrackRequests);
                if (null != client)
                {
                    DanePobierzPelnyRaportResponse response =
                        await client.DanePobierzPelnyRaportAsync(pRegon, pNazwaRaportu);
                    if (canLogout)
                    {
                        await WylogujAsync();
                    }

                    var xml = response?.DanePobierzPelnyRaportResult;
                    if (xml != null && !string.IsNullOrWhiteSpace(xml))
                    {
                        return new TModel().Create<TModel>(
                            pRegon,
                            pNazwaRaportu,
                            xml,
                            GetDistributedCacheRepository()?.ToList<MessageInspector>(GetGuid())!);
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
            }

            finally
            {
                if (canLogout)
                {
                    await WylogujAsync();
                }

                //GetDistributedCacheRepository()?.Remove(GetGuid());
            }

            return null;
        }

        public ICollection<TModel> DanePobierzPelnyRaport<TModel>(DaneSzukajPodmioty daneSzukajPodmioty,
            string pRegon, string pNazwaRaportu,
            string pKluczUzytkownika = null, bool canTrackRequests = false, bool canLogout = true)
            where TModel : DanePobierzPelnyRaport, new()
        {
            try
            {
                var xml = GetClient(pKluczUzytkownika, canTrackRequests)
                    .DanePobierzPelnyRaport(pRegon, pNazwaRaportu);
                if (canLogout)
                {
                    Wyloguj();
                }

                return new TModel().CreateCollection<TModel>(
                    daneSzukajPodmioty,
                    pRegon,
                    pNazwaRaportu,
                    xml,
                    GetDistributedCacheRepository()?.ToList<MessageInspector>(GetGuid())!);
            }

            catch (Exception e)
            {
                _log4Net.Error(e);
                if (null != e.InnerException)
                {
                    _log4Net.Error(e.InnerException);
                }
            }

            finally
            {
                if (canLogout)
                {
                    Wyloguj();
                }

                //GetDistributedCacheRepository()?.Remove(GetGuid());
            }

            return null;
        }

        public async Task<ICollection<TModel>> DanePobierzPelnyRaportAsync<TModel>(
            DaneSzukajPodmioty daneSzukajPodmioty,
            string pRegon, string pNazwaRaportu,
            string pKluczUzytkownika = null, bool canTrackRequests = false, bool canLogout = true)
            where TModel : DanePobierzPelnyRaport, new() => await Task.Run(async () =>
        {
            try
            {
                UslugaBIRzewnPublClient client = await GetClientAsync(pKluczUzytkownika, canTrackRequests);
                if (null != client)
                {
                    DanePobierzPelnyRaportResponse response =
                        await client.DanePobierzPelnyRaportAsync(pRegon, pNazwaRaportu);
                    if (canLogout)
                    {
                        await WylogujAsync();
                    }

                    if (null != response)
                    {
                        var xml = response.DanePobierzPelnyRaportResult;
                        return new TModel().CreateCollection<TModel>(
                            daneSzukajPodmioty,
                            pRegon,
                            pNazwaRaportu,
                            xml,
                            GetDistributedCacheRepository()?.ToList<MessageInspector>(GetGuid())!);
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
            }

            finally
            {
                if (canLogout)
                {
                    await WylogujAsync();
                }

                //GetDistributedCacheRepository()?.Remove(GetGuid());
            }

            return null;
        });

        public Task<DaneSzukajPodmiotyResult> DanePobierzPelnyRaportAsync(string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true, string krs = null, string krsy = null,
            string nip = null, string nipy = null,
            string regon = null, string regony14Zn = null, string regony9Zn = null
        ) => Task.Run(async () =>
        {
            try
            {
                DaneSzukajPodmiotyResult daneSzukajPodmiotyResult =
                    await DaneSzukajPodmiotyAsObjectAsync(pKluczUzytkownika, canTrackRequests, canLogout, krs, krsy,
                        nip, nipy, regon, regony14Zn, regony9Zn);
                if (null != daneSzukajPodmiotyResult && daneSzukajPodmiotyResult.Data.Count > 0)
                {
                    foreach (DaneSzukajPodmioty daneSzukajPodmioty in daneSzukajPodmiotyResult.Data!)
                    {
                        switch (daneSzukajPodmioty?.Typ?.ToUpper())
                        {
                            case "F":
                                switch (daneSzukajPodmioty?.SilosID)
                                {
                                    case 1:
                                        //BIR11OsFizycznaDaneOgolne
                                        daneSzukajPodmioty.BIR11OsFizycznaDaneOgolne =
                                            await new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaportAsync<BIR11OsFizycznaDaneOgolne>(
                                                    daneSzukajPodmioty?.Regon,
                                                    "BIR11OsFizycznaDaneOgolne", pKluczUzytkownika, canTrackRequests);
                                        //BIR11OsFizycznaDzialalnoscCeidg
                                        daneSzukajPodmioty.BIR11OsFizycznaDzialalnoscCeidg =
                                            await new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaportAsync<BIR11OsFizycznaDzialalnoscCeidg>(
                                                    daneSzukajPodmioty?.Regon,
                                                    "BIR11OsFizycznaDzialalnoscCeidg", pKluczUzytkownika,
                                                    canTrackRequests);
                                        //BIR11OsFizycznaPkd
                                        daneSzukajPodmioty.BIR11OsFizycznaPkd =
                                            await new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaportAsync<BIR11OsFizycznaPkd>(
                                                    daneSzukajPodmioty,
                                                    daneSzukajPodmioty?.Regon, "BIR11OsFizycznaPkd", pKluczUzytkownika,
                                                    canTrackRequests);
                                        //BIR11OsFizycznaListaJednLokalnych
                                        daneSzukajPodmioty.BIR11OsFizycznaListaJednLokalnych =
                                            await new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaportAsync<
                                                    BIR11OsFizycznaListaJednLokalnych>(
                                                    daneSzukajPodmioty,
                                                    daneSzukajPodmioty?.Regon, "BIR11OsFizycznaListaJednLokalnych",
                                                    pKluczUzytkownika,
                                                    canTrackRequests);
                                        break;
                                    case 2:
                                        //BIR11OsFizycznaDaneOgolne
                                        daneSzukajPodmioty.BIR11OsFizycznaDaneOgolne =
                                            await new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaportAsync<BIR11OsFizycznaDaneOgolne>(
                                                    daneSzukajPodmioty?.Regon,
                                                    "BIR11OsFizycznaDaneOgolne", pKluczUzytkownika, canTrackRequests);
                                        //BIR11OsFizycznaDzialalnoscRolnicza
                                        daneSzukajPodmioty.BIR11OsFizycznaDzialalnoscRolnicza =
                                            await new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaportAsync<BIR11OsFizycznaDzialalnoscRolnicza
                                                >(
                                                    daneSzukajPodmioty?.Regon, "BIR11OsFizycznaDzialalnoscRolnicza",
                                                    pKluczUzytkownika,
                                                    canTrackRequests);
                                        //BIR11OsFizycznaPkd
                                        daneSzukajPodmioty.BIR11OsFizycznaPkd =
                                            await new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaportAsync<BIR11OsFizycznaPkd>(
                                                    daneSzukajPodmioty,
                                                    daneSzukajPodmioty?.Regon, "BIR11OsFizycznaPkd", pKluczUzytkownika,
                                                    canTrackRequests);
                                        //BIR11OsFizycznaListaJednLokalnych
                                        daneSzukajPodmioty.BIR11OsFizycznaListaJednLokalnych =
                                            await new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaportAsync<
                                                    BIR11OsFizycznaListaJednLokalnych>(
                                                    daneSzukajPodmioty,
                                                    daneSzukajPodmioty?.Regon, "BIR11OsFizycznaListaJednLokalnych",
                                                    pKluczUzytkownika,
                                                    canTrackRequests);
                                        break;
                                    case 3:
                                        //BIR11OsFizycznaDaneOgolne
                                        daneSzukajPodmioty.BIR11OsFizycznaDaneOgolne =
                                            await new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaportAsync<BIR11OsFizycznaDaneOgolne>(
                                                    daneSzukajPodmioty?.Regon,
                                                    "BIR11OsFizycznaDaneOgolne", pKluczUzytkownika, canTrackRequests);
                                        //BIR11OsFizycznaDzialalnoscPozostala
                                        daneSzukajPodmioty.BIR11OsFizycznaDzialalnoscPozostala =
                                            await new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaportAsync<BIR11OsFizycznaDzialalnoscPozostala
                                                >(
                                                    daneSzukajPodmioty?.Regon,
                                                    "BIR11OsFizycznaDzialalnoscPozostala", pKluczUzytkownika,
                                                    canTrackRequests);
                                        //BIR11OsFizycznaPkd
                                        daneSzukajPodmioty.BIR11OsFizycznaPkd =
                                            await new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaportAsync<BIR11OsFizycznaPkd>(
                                                    daneSzukajPodmioty,
                                                    daneSzukajPodmioty?.Regon, "BIR11OsFizycznaPkd", pKluczUzytkownika,
                                                    canTrackRequests);
                                        //BIR11OsFizycznaListaJednLokalnych
                                        daneSzukajPodmioty.BIR11OsFizycznaListaJednLokalnych =
                                            await new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaportAsync<
                                                    BIR11OsFizycznaListaJednLokalnych>(
                                                    daneSzukajPodmioty,
                                                    daneSzukajPodmioty?.Regon, "BIR11OsFizycznaListaJednLokalnych",
                                                    pKluczUzytkownika,
                                                    canTrackRequests);
                                        break;
                                    case 4:
                                        //BIR11OsFizycznaDzialalnoscSkreslona
                                        daneSzukajPodmioty.BIR11OsFizycznaDzialalnoscSkreslonaDo20141108 =
                                            await new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaportAsync<
                                                    BIR11OsFizycznaDzialalnoscSkreslonaDo20141108>(
                                                    daneSzukajPodmioty?.Regon,
                                                    "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108", pKluczUzytkownika,
                                                    canTrackRequests);
                                        break;
                                }

                                break;
                            case "P":
                                switch (daneSzukajPodmioty.SilosID)
                                {
                                    case 6:
                                        //BIR11OsPrawna
                                        daneSzukajPodmioty.BIR11OsPrawna =
                                            await new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaportAsync<BIR11OsPrawna>(daneSzukajPodmioty?.Regon,
                                                    "BIR11OsPrawna",
                                                    pKluczUzytkownika, canTrackRequests);
                                        //BIR11OsPrawnaPkd
                                        daneSzukajPodmioty.BIR11OsPrawnaPkd =
                                            await new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaportAsync<BIR11OsPrawnaPkd>(
                                                    daneSzukajPodmioty,
                                                    daneSzukajPodmioty?.Regon, "BIR11OsPrawnaPkd", pKluczUzytkownika,
                                                    canTrackRequests);
                                        //BIR11OsPrawnaListaJednLokalnych
                                        daneSzukajPodmioty.BIR11OsPrawnaListaJednLokalnych =
                                            await new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaportAsync<BIR11OsPrawnaListaJednLokalnych
                                                >(
                                                    daneSzukajPodmioty,
                                                    daneSzukajPodmioty?.Regon, "BIR11OsPrawnaListaJednLokalnych",
                                                    pKluczUzytkownika,
                                                    canTrackRequests);
                                        //BIR11OsPrawnaSpCywilnaWspolnicy
                                        daneSzukajPodmioty.BIR11OsPrawnaSpCywilnaWspolnicy =
                                            await new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaportAsync<BIR11OsPrawnaSpCywilnaWspolnicy
                                                >(
                                                    daneSzukajPodmioty,
                                                    daneSzukajPodmioty?.Regon, "BIR11OsPrawnaSpCywilnaWspolnicy",
                                                    pKluczUzytkownika,
                                                    canTrackRequests);
                                        //BIR11TypPodmiotu
                                        daneSzukajPodmioty.BIR11TypPodmiotu =
                                            await new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaportAsync<BIR11TypPodmiotu>(
                                                    daneSzukajPodmioty?.Regon,
                                                    "BIR11TypPodmiotu", pKluczUzytkownika, canTrackRequests);
                                        break;
                                }

                                break;
                            case "LF":
                                switch (daneSzukajPodmioty?.SilosID)
                                {
                                    case 1:
                                    case 2:
                                    case 3:
                                        //BIR11JednLokalnaOsFizycznej
                                        daneSzukajPodmioty.BIR11JednLokalnaOsFizycznej =
                                            await new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaportAsync<BIR11JednLokalnaOsFizycznej>(
                                                    daneSzukajPodmioty?.Regon,
                                                    "BIR11JednLokalnaOsFizycznej", pKluczUzytkownika, canTrackRequests);
                                        //BIR11JednLokalnaOsFizycznejPkd
                                        daneSzukajPodmioty.BIR11JednLokalnaOsFizycznejPkd =
                                            await new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaportAsync<BIR11JednLokalnaOsFizycznejPkd
                                                >(
                                                    daneSzukajPodmioty,
                                                    daneSzukajPodmioty?.Regon, "BIR11JednLokalnaOsFizycznejPkd",
                                                    pKluczUzytkownika,
                                                    canTrackRequests);
                                        break;
                                }

                                break;
                            case "LP":
                                switch (daneSzukajPodmioty?.SilosID)
                                {
                                    case 6:
                                        //BIR11JednLokalnaOsPrawnej
                                        daneSzukajPodmioty.BIR11JednLokalnaOsPrawnej =
                                            await new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaportAsync<BIR11JednLokalnaOsPrawnej>(
                                                    daneSzukajPodmioty?.Regon,
                                                    "BIR11JednLokalnaOsPrawnej", pKluczUzytkownika,
                                                    canTrackRequests);
                                        //BIR11JednLokalnaOsPrawnejPkd
                                        daneSzukajPodmioty.BIR11JednLokalnaOsPrawnejPkd =
                                            await new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaportAsync<BIR11JednLokalnaOsPrawnejPkd>(
                                                    daneSzukajPodmioty,
                                                    daneSzukajPodmioty?.Regon, "BIR11JednLokalnaOsPrawnejPkd",
                                                    pKluczUzytkownika,
                                                    canTrackRequests);
                                        break;
                                }

                                break;
                        }
                    }
                }

//#if DEBUG
//                var output = JsonConvert.SerializeObject(daneSzukajPodmiotyResult,
//                    Formatting.Indented,
//                    new JsonSerializerSettings
//                    {
//                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
//                        PreserveReferencesHandling = PreserveReferencesHandling.None
//                    });
//                await File.WriteAllTextAsync(
//                    @$"D:\Praca\NetCoreDev\PortalApiGus\ApiRegon\src\PortalApiGus.ApiRegon.Core\{daneSzukajPodmioty?.Regon}.json",
//                    output);
//#endif
                return daneSzukajPodmiotyResult;
            }
            catch (Exception e)
            {
                _log4Net.Error(e);
                if (null != e.InnerException)
                {
                    _log4Net.Error(e.InnerException);
                }
            }

            finally
            {
                await WylogujAsync();
                //GetDistributedCacheRepository()?.Remove(GetGuid());
            }

            return null;
        });

        public DaneSzukajPodmiotyResult DanePobierzPelnyRaport(string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true, string krs = null, string krsy = null,
            string nip = null, string nipy = null,
            string regon = null, string regony14Zn = null, string regony9Zn = null
        )
        {
            try
            {
                DaneSzukajPodmiotyResult daneSzukajPodmiotyResult =
                    DaneSzukajPodmiotyAsObject(pKluczUzytkownika, canTrackRequests, canLogout, krs, krsy, nip, nipy,
                        regon, regony14Zn, regony9Zn);
                if (null != daneSzukajPodmiotyResult && daneSzukajPodmiotyResult.Data.Count > 0)
                {
                    foreach (DaneSzukajPodmioty daneSzukajPodmioty in daneSzukajPodmiotyResult.Data!)
                    {
                        switch (daneSzukajPodmioty?.Typ?.ToUpper())
                        {
                            case "F":
                                switch (daneSzukajPodmioty?.SilosID)
                                {
                                    case 1:
                                        //BIR11OsFizycznaDaneOgolne
                                        daneSzukajPodmioty.BIR11OsFizycznaDaneOgolne =
                                            new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaport<BIR11OsFizycznaDaneOgolne>(
                                                    daneSzukajPodmioty?.Regon,
                                                    "BIR11OsFizycznaDaneOgolne", pKluczUzytkownika, canTrackRequests);
                                        //BIR11OsFizycznaDzialalnoscCeidg
                                        daneSzukajPodmioty.BIR11OsFizycznaDzialalnoscCeidg =
                                            new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaport<BIR11OsFizycznaDzialalnoscCeidg>(
                                                    daneSzukajPodmioty?.Regon,
                                                    "BIR11OsFizycznaDzialalnoscCeidg", pKluczUzytkownika,
                                                    canTrackRequests);
                                        //BIR11OsFizycznaPkd
                                        daneSzukajPodmioty.BIR11OsFizycznaPkd =
                                            new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaport<BIR11OsFizycznaPkd>(
                                                    daneSzukajPodmioty,
                                                    daneSzukajPodmioty?.Regon, "BIR11OsFizycznaPkd", pKluczUzytkownika,
                                                    canTrackRequests);
                                        //BIR11OsFizycznaListaJednLokalnych
                                        daneSzukajPodmioty.BIR11OsFizycznaListaJednLokalnych =
                                            new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaport<BIR11OsFizycznaListaJednLokalnych>(
                                                    daneSzukajPodmioty,
                                                    daneSzukajPodmioty?.Regon, "BIR11OsFizycznaListaJednLokalnych",
                                                    pKluczUzytkownika,
                                                    canTrackRequests);
                                        break;
                                    case 2:
                                        //BIR11OsFizycznaDaneOgolne
                                        daneSzukajPodmioty.BIR11OsFizycznaDaneOgolne =
                                            new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaport<BIR11OsFizycznaDaneOgolne>(
                                                    daneSzukajPodmioty?.Regon,
                                                    "BIR11OsFizycznaDaneOgolne", pKluczUzytkownika, canTrackRequests);
                                        //BIR11OsFizycznaDzialalnoscRolnicza
                                        daneSzukajPodmioty.BIR11OsFizycznaDzialalnoscRolnicza =
                                            new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaport<BIR11OsFizycznaDzialalnoscRolnicza>(
                                                    daneSzukajPodmioty?.Regon, "BIR11OsFizycznaDzialalnoscRolnicza",
                                                    pKluczUzytkownika,
                                                    canTrackRequests);
                                        //BIR11OsFizycznaPkd
                                        daneSzukajPodmioty.BIR11OsFizycznaPkd =
                                            new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaport<BIR11OsFizycznaPkd>(
                                                    daneSzukajPodmioty,
                                                    daneSzukajPodmioty?.Regon, "BIR11OsFizycznaPkd", pKluczUzytkownika,
                                                    canTrackRequests);
                                        //BIR11OsFizycznaListaJednLokalnych
                                        daneSzukajPodmioty.BIR11OsFizycznaListaJednLokalnych =
                                            new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaport<BIR11OsFizycznaListaJednLokalnych>(
                                                    daneSzukajPodmioty,
                                                    daneSzukajPodmioty?.Regon, "BIR11OsFizycznaListaJednLokalnych",
                                                    pKluczUzytkownika,
                                                    canTrackRequests);
                                        break;
                                    case 3:
                                        //BIR11OsFizycznaDaneOgolne
                                        daneSzukajPodmioty.BIR11OsFizycznaDaneOgolne =
                                            new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaport<BIR11OsFizycznaDaneOgolne>(
                                                    daneSzukajPodmioty?.Regon,
                                                    "BIR11OsFizycznaDaneOgolne", pKluczUzytkownika, canTrackRequests);
                                        //BIR11OsFizycznaDzialalnoscPozostala
                                        daneSzukajPodmioty.BIR11OsFizycznaDzialalnoscPozostala =
                                            new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaport<BIR11OsFizycznaDzialalnoscPozostala>(
                                                    daneSzukajPodmioty?.Regon,
                                                    "BIR11OsFizycznaDzialalnoscPozostala", pKluczUzytkownika,
                                                    canTrackRequests);
                                        //BIR11OsFizycznaPkd
                                        daneSzukajPodmioty.BIR11OsFizycznaPkd =
                                            new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaport<BIR11OsFizycznaPkd>(
                                                    daneSzukajPodmioty,
                                                    daneSzukajPodmioty?.Regon, "BIR11OsFizycznaPkd", pKluczUzytkownika,
                                                    canTrackRequests);
                                        //BIR11OsFizycznaListaJednLokalnych
                                        daneSzukajPodmioty.BIR11OsFizycznaListaJednLokalnych =
                                            new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaport<BIR11OsFizycznaListaJednLokalnych>(
                                                    daneSzukajPodmioty,
                                                    daneSzukajPodmioty?.Regon, "BIR11OsFizycznaListaJednLokalnych",
                                                    pKluczUzytkownika,
                                                    canTrackRequests);
                                        break;
                                    case 4:
                                        //BIR11OsFizycznaDzialalnoscSkreslona
                                        daneSzukajPodmioty.BIR11OsFizycznaDzialalnoscSkreslonaDo20141108 =
                                            new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaport<
                                                    BIR11OsFizycznaDzialalnoscSkreslonaDo20141108>(
                                                    daneSzukajPodmioty?.Regon,
                                                    "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108", pKluczUzytkownika,
                                                    canTrackRequests);
                                        break;
                                }

                                break;
                            case "P":
                                switch (daneSzukajPodmioty.SilosID)
                                {
                                    case 6:
                                        //BIR11OsPrawna
                                        daneSzukajPodmioty.BIR11OsPrawna =
                                            new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaport<BIR11OsPrawna>(daneSzukajPodmioty?.Regon,
                                                    "BIR11OsPrawna",
                                                    pKluczUzytkownika, canTrackRequests);
                                        //BIR11OsPrawnaPkd
                                        daneSzukajPodmioty.BIR11OsPrawnaPkd =
                                            new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaport<BIR11OsPrawnaPkd>(
                                                    daneSzukajPodmioty,
                                                    daneSzukajPodmioty?.Regon, "BIR11OsPrawnaPkd", pKluczUzytkownika,
                                                    canTrackRequests);
                                        //BIR11OsPrawnaListaJednLokalnych
                                        daneSzukajPodmioty.BIR11OsPrawnaListaJednLokalnych =
                                            new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaport<BIR11OsPrawnaListaJednLokalnych>(
                                                    daneSzukajPodmioty,
                                                    daneSzukajPodmioty?.Regon, "BIR11OsPrawnaListaJednLokalnych",
                                                    pKluczUzytkownika,
                                                    canTrackRequests);
                                        //BIR11OsPrawnaSpCywilnaWspolnicy
                                        daneSzukajPodmioty.BIR11OsPrawnaSpCywilnaWspolnicy =
                                            new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaport<BIR11OsPrawnaSpCywilnaWspolnicy>(
                                                    daneSzukajPodmioty,
                                                    daneSzukajPodmioty?.Regon, "BIR11OsPrawnaSpCywilnaWspolnicy",
                                                    pKluczUzytkownika,
                                                    canTrackRequests);
                                        //BIR11TypPodmiotu
                                        daneSzukajPodmioty.BIR11TypPodmiotu =
                                            new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaport<BIR11TypPodmiotu>(daneSzukajPodmioty?.Regon,
                                                    "BIR11TypPodmiotu", pKluczUzytkownika, canTrackRequests);
                                        break;
                                }

                                break;
                            case "LF":
                                switch (daneSzukajPodmioty?.SilosID)
                                {
                                    case 1:
                                    case 2:
                                    case 3:
                                        //BIR11JednLokalnaOsFizycznej
                                        daneSzukajPodmioty.BIR11JednLokalnaOsFizycznej =
                                            new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaport<BIR11JednLokalnaOsFizycznej>(
                                                    daneSzukajPodmioty?.Regon,
                                                    "BIR11JednLokalnaOsFizycznej", pKluczUzytkownika, canTrackRequests);
                                        //BIR11JednLokalnaOsFizycznejPkd
                                        daneSzukajPodmioty.BIR11JednLokalnaOsFizycznejPkd =
                                            new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaport<BIR11JednLokalnaOsFizycznejPkd>(
                                                    daneSzukajPodmioty,
                                                    daneSzukajPodmioty?.Regon, "BIR11JednLokalnaOsFizycznejPkd",
                                                    pKluczUzytkownika,
                                                    canTrackRequests);
                                        break;
                                }

                                break;
                            case "LP":
                                switch (daneSzukajPodmioty?.SilosID)
                                {
                                    case 6:
                                        //BIR11JednLokalnaOsPrawnej
                                        daneSzukajPodmioty.BIR11JednLokalnaOsPrawnej =
                                            new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaport<BIR11JednLokalnaOsPrawnej>(
                                                    daneSzukajPodmioty?.Regon,
                                                    "BIR11JednLokalnaOsPrawnej", pKluczUzytkownika,
                                                    canTrackRequests);
                                        //BIR11JednLokalnaOsPrawnejPkd
                                        daneSzukajPodmioty.BIR11JednLokalnaOsPrawnejPkd =
                                            new DaneSzukajPodmiotyService()
                                                .DanePobierzPelnyRaport<BIR11JednLokalnaOsPrawnejPkd>(
                                                    daneSzukajPodmioty,
                                                    daneSzukajPodmioty?.Regon, "BIR11JednLokalnaOsPrawnejPkd",
                                                    pKluczUzytkownika,
                                                    canTrackRequests);
                                        break;
                                }

                                break;
                        }

//#if DEBUG
//                        var output = JsonConvert.SerializeObject(daneSzukajPodmioty,
//                            Formatting.Indented,
//                            new JsonSerializerSettings
//                            {
//                                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
//                                PreserveReferencesHandling = PreserveReferencesHandling.None
//                            });
//                        File.WriteAllText(
//                            @$"D:\Praca\NetCoreDev\PortalApiGus\ApiRegon\src\PortalApiGus.ApiRegon.Core\{daneSzukajPodmioty?.Regon}.json",
//                            output);
//#endif
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
            }

            finally
            {
                Wyloguj();
                //GetDistributedCacheRepository()?.Remove(GetGuid());
            }

            return null;
        }
    }
}
