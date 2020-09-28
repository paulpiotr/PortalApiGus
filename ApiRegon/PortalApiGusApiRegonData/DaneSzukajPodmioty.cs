using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using UslugaBIRzewnPublVer11Prod;

namespace PortalApiGusApiRegonData
{
    public class DaneSzukajPodmioty
    {
        /// <summary>
        /// log4net
        /// </summary>
        private static readonly log4net.ILog _log4net = Log4netLogger.Log4netLogger.GetLog4netInstance(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Klucz Api
        /// </summary>
        private static readonly string portalApiGusKey = NetAppCommon.Configuration.GetValue<string>("PortalApiGusKey");

        /// <summary>
        /// Czas życia cache wyszukiwania
        /// </summary>
        private static readonly int portalApiGusSearchCacheLifetime = NetAppCommon.Configuration.GetValue<int>("PortalApiGusSearchCacheLifetime");

        /// <summary>
        /// Deserializuj dane
        /// </summary>
        /// <param name="daneSzukajPodmiotyResult"></param>
        /// <returns></returns>
        private static List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty> DeserializeXmlAsDaneSzukajPodmiotyList(string daneSzukajPodmiotyResult)
        {
            try
            {
                return UslugaBIRzewnPubl.DeserializeXmlAsDaneSzukajPodmiotyList(daneSzukajPodmiotyResult).Dane;
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Ustaw odpowiednie parametry rządania w nagłówku - Ustaw "sid", pIdentyfikatorSesji zwrócony w logowaniu
        /// </summary>
        /// <param name="pKluczUzytkownika">pKluczUzytkownika As String</param>
        /// <returns>uslugaBIRzewnPublClient As UslugaBIRzewnPublClient lub null jeśli wystąpił błąd</returns>
        private static Task<UslugaBIRzewnPublClient> UslugaBIRzewnPublClientAsync(string pKluczUzytkownika)
        {
            try
            {
                return UslugaBIRzewnPubl.UslugaBIRzewnPublClientAsync(pKluczUzytkownika);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Wyszukaj podmiot spełniający jedno z kryteriów krs krsy nip nipy regon regony14zn regony9zn Metoda przeszukuje bazę regon w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="pKluczUzytkownika">pKluczUzytkownika As String</param>
        /// <param name="krs"></param>
        /// <param name="krsy"></param>
        /// <param name="nip"></param>
        /// <param name="nipy"></param>
        /// <param name="regon"></param>
        /// <param name="regony14zn"></param>
        /// <param name="regony9zn"></param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsync(string pKluczUzytkownika, string krs = null, string krsy = null, string nip = null, string nipy = null, string regon = null, string regony14zn = null, string regony9zn = null)
        {
            try
            {
                ParametryWyszukiwania parametryWyszukiwania = new ParametryWyszukiwania()
                {
                    Krs = krs,
                    Krsy = krsy,
                    Nip = nip,
                    Nipy = nipy,
                    Regon = regon,
                    Regony14zn = regony14zn,
                    Regony9zn = regony9zn
                };
                try
                {
                    if (portalApiGusSearchCacheLifetime > 0)
                    {
                        //using (Data.PortalApiGusApiRegonDataDbContext context = new Data.PortalApiGusApiRegonDataDbContext(PortalApiGusApiRegonDataContext.GetConnectionOptionsBuilder()))
                        using (Data.PortalApiGusApiRegonDataDbContext context = await NetAppCommon.DatabaseMssql.CreateInstancesForDatabaseContextClassAsync<Data.PortalApiGusApiRegonDataDbContext>())
                        {
                            if (context.Database.CanConnect())
                            {
                                List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty> daneSzukajPodmiotyList = context.DaneSzukajPodmioty.Where(w =>
                                   w.ParametryWyszukiwaniaSHA512 == Helper.ObjectHelper.ObjectToSHA512(parametryWyszukiwania)
                                   && w.DataModyfikacji >= DateTime.Now.AddSeconds((double)portalApiGusSearchCacheLifetime * -1)
                                    ).ToList();
                                if (null != daneSzukajPodmiotyList && daneSzukajPodmiotyList.Any())
                                {
                                    _log4net.Info(string.Format("{0} {1} OK", Assembly.GetExecutingAssembly().FullName, MethodBase.GetCurrentMethod().Name));
                                    return daneSzukajPodmiotyList;
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    _log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                }
                UslugaBIRzewnPublClient uslugaBIRzewnPublClient = await UslugaBIRzewnPublClientAsync(pKluczUzytkownika);
                try
                {
                    DaneSzukajPodmiotyResponse daneSzukajPodmiotyResponse = await uslugaBIRzewnPublClient.DaneSzukajPodmiotyAsync(parametryWyszukiwania);
                    if (null != daneSzukajPodmiotyResponse && null != daneSzukajPodmiotyResponse.DaneSzukajPodmiotyResult && !string.IsNullOrWhiteSpace(daneSzukajPodmiotyResponse.DaneSzukajPodmiotyResult))
                    {
                        List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty> daneSzukajPodmiotyList = DeserializeXmlAsDaneSzukajPodmiotyList(daneSzukajPodmiotyResponse.DaneSzukajPodmiotyResult);
                        if (null != daneSzukajPodmiotyList && daneSzukajPodmiotyList.Any())
                        {
                            _log4net.Info(string.Format("{0} {1} OK", Assembly.GetExecutingAssembly().FullName, MethodBase.GetCurrentMethod().Name));
                            try
                            {
                                foreach (Models.DaneSzukajPodmioty.DaneSzukajPodmioty daneSzukajPodmioty in daneSzukajPodmiotyList)
                                {
                                    daneSzukajPodmioty.ParametryWyszukiwaniaSHA512 = Helper.ObjectHelper.ObjectToSHA512(parametryWyszukiwania);
                                    daneSzukajPodmioty.ParametryWyszukiwaniaJson = JsonSerializer.Serialize<ParametryWyszukiwania>(parametryWyszukiwania);
                                    daneSzukajPodmioty.DataUtworzenia = DateTime.Now;
                                    daneSzukajPodmioty.DataModyfikacji = DateTime.Now;
                                    //using (Data.PortalApiGusApiRegonDataDbContext context = new Data.PortalApiGusApiRegonDataDbContext(PortalApiGusApiRegonDataContext.GetConnectionOptionsBuilder()))
                                    using (Data.PortalApiGusApiRegonDataDbContext context = await NetAppCommon.DatabaseMssql.CreateInstancesForDatabaseContextClassAsync<Data.PortalApiGusApiRegonDataDbContext>())
                                    {
                                        if (context.Database.CanConnect())
                                        {
                                            Models.DaneSzukajPodmioty.DaneSzukajPodmioty daneSzukajPodmiotyWhere = context.DaneSzukajPodmioty.Where(w => w.ParametryWyszukiwaniaSHA512 == Helper.ObjectHelper.ObjectToSHA512(parametryWyszukiwania) && w.Regon == daneSzukajPodmioty.Regon).FirstOrDefault();
                                            if (null != daneSzukajPodmiotyWhere)
                                            {
                                                daneSzukajPodmioty.Id = daneSzukajPodmiotyWhere.Id;
                                                daneSzukajPodmioty.DataUtworzenia = daneSzukajPodmiotyWhere.DataUtworzenia;
                                                context.Entry(daneSzukajPodmiotyWhere).State = EntityState.Detached;
                                            }
                                            //MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg => { cfg.CreateMap<Models.DaneSzukajPodmioty.DaneSzukajPodmioty, Models.DaneSzukajPodmioty.DaneSzukajPodmioty>(); });
                                            //IMapper iMapper = mapperConfiguration.CreateMapper();
                                            //daneSzukajPodmiotyWhere = iMapper.Map(daneSzukajPodmioty, daneSzukajPodmiotyWhere);
                                            if (null != daneSzukajPodmioty)
                                            {
                                                context.Entry(daneSzukajPodmioty).State = daneSzukajPodmioty.Id == 0 ? EntityState.Added : EntityState.Modified;
                                                int result = await context.SaveChangesAsync();
                                                _log4net.Info($"Save Changes Async to database: { result } id: { daneSzukajPodmioty.Id }");
                                            }
                                        }
                                    }
                                }
                            }
                            catch (Exception e)
                            {
                                _log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                            }
                            return daneSzukajPodmiotyList;
                        }
                    }
                    _log4net.Info(string.Format("{0} {1} EMPTY", Assembly.GetExecutingAssembly().FullName, MethodBase.GetCurrentMethod().Name));
                    return null;
                }
                catch (Exception e)
                {
                    _log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                    return null;
                }
                finally
                {
                    //if (null != pIdentyfikatorSesji && !string.IsNullOrWhiteSpace(pIdentyfikatorSesji))
                    //{
                    //    await WylogujAsync(pIdentyfikatorSesji);
                    //}
                }
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot spełniający jedno z kryteriów krs krsy nip nipy regon regony14zn regony9zn Metoda przeszukuje bazę regon w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="krs"></param>
        /// <param name="krsy"></param>
        /// <param name="nip"></param>
        /// <param name="nipy"></param>
        /// <param name="regon"></param>
        /// <param name="regony14zn"></param>
        /// <param name="regony9zn"></param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsync(string krs = null, string krsy = null, string nip = null, string nipy = null, string regon = null, string regony14zn = null, string regony9zn = null)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(NetAppCommon.Configuration.GetValue<string>("PortalApiGusKey"), krs, krsy, nip, nipy, regon, regony14zn, regony9zn);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po krs. Metoda przeszukuje bazę regon w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="pKluczUzytkownika">pKluczUzytkownika As String</param>
        /// <param name="krs">krs As string 10 znaków - Identyfikator podmiotu Numer KRS</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByKrs(string pKluczUzytkownika, string krs)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(pKluczUzytkownika, krs: krs);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po krs. Metoda przeszukuje bazę regon w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="krs">krs As string 10 znaków - Identyfikator podmiotu Numer KRS</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByKrs(string krs)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(krs: krs);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po krsy. Metoda przeszukuje bazę regon w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="pKluczUzytkownika">pKluczUzytkownika As String</param>
        /// <param name="krsy">krsy As string - Ciąg znaków, dziesięcioznakowe identyfikatory KRS, oddzielane dowolnym separatorem (za wyjątkiem cyfr), bądź bez separatora, maks. 20 identyfikatorów.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByKrsy(string pKluczUzytkownika, string krsy)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(pKluczUzytkownika: pKluczUzytkownika, krsy: krsy);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po krsy. Metoda przeszukuje bazę regon w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="krsy">krsy As string - Ciąg znaków, dziesięcioznakowe identyfikatory KRS, oddzielane dowolnym separatorem (za wyjątkiem cyfr), bądź bez separatora, maks. 20 identyfikatorów.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByKrsy(string krsy)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(krsy: krsy);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po Nip. Metoda przeszukuje bazę regon w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="pKluczUzytkownika">pKluczUzytkownika As String</param>
        /// <param name="Nip">Nip As string - Identyfikator podmiotu Nip.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByNip(string pKluczUzytkownika, string nip)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(pKluczUzytkownika: pKluczUzytkownika, nip: nip);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po Nip. Metoda przeszukuje bazę regon w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="Nip">Nip As string - Identyfikator podmiotu Nip.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByNip(string nip)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(nip: nip);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po Nipy. Metoda przeszukuje bazę regon w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="pKluczUzytkownika">pKluczUzytkownika As String</param>
        /// <param name="Nipy">Nipy As string - Identyfikator podmiotu Nipy. Nipy – ciąg znaków, dziesięcioznakowe identyfikatory NIP, oddzielane dowolnym separatorem (za wyjątkiem cyfr), bądź bez separatora, maks. 20 identyfikatorów.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByNipy(string pKluczUzytkownika, string nipy)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(pKluczUzytkownika: pKluczUzytkownika, nipy: nipy);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po Nipy. Metoda przeszukuje bazę regon w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="Nipy">Nipy As string - Identyfikator podmiotu Nipy. Nipy – ciąg znaków, dziesięcioznakowe identyfikatory NIP, oddzielane dowolnym separatorem (za wyjątkiem cyfr), bądź bez separatora, maks. 20 identyfikatorów.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByNipy(string nipy)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(nipy: nipy);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po Regon. Metoda przeszukuje bazę regon w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="pKluczUzytkownika">pKluczUzytkownika As String</param>
        /// <param name="Regon">Regon As string - Identyfikator podmiotu Regon.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByRegon(string pKluczUzytkownika, string regon)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(pKluczUzytkownika: pKluczUzytkownika, regon: regon);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po Regon. Metoda przeszukuje bazę regon w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="Regon">Regon As string - Identyfikator podmiotu Regon.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByRegon(string regon)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(regon: regon);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po Regony9zn. Metoda przeszukuje bazę Regony9zn w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="pKluczUzytkownika">pKluczUzytkownika As String</param>
        /// <param name="Regony9zn">Regony9zn As string - Identyfikator podmiotu Regony9zn. Regony9zn – ciąg znaków, dziewięcioznakowe identyfikatory REGON, oddzielane dowolnym separatorem (za wyjątkiem cyfr), bądź bez separatora, maks. 20 identyfikatorów.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByRegony9zn(string pKluczUzytkownika, string regony9zn)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(pKluczUzytkownika: pKluczUzytkownika, regony9zn: regony9zn);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po Regony9zn. Metoda przeszukuje bazę Regony9zn w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="Regony9zn">Regony9zn As string - Identyfikator podmiotu Regony9zn. Regony9zn – ciąg znaków, dziewięcioznakowe identyfikatory REGON, oddzielane dowolnym separatorem (za wyjątkiem cyfr), bądź bez separatora, maks. 20 identyfikatorów.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByRegony9zn(string regony9zn)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(regony9zn: regony9zn);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po Regony14zn. Metoda przeszukuje bazę Regony14zn w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="pKluczUzytkownika">pKluczUzytkownika As String</param>
        /// <param name="Regony14zn">Regony14zn As string - Identyfikator podmiotu Regony14zn. Regony14zn – ciąg znaków, czternastoznakowe identyfikatory REGON, oddzielane dowolnym separatorem (za wyjątkiem cyfr), bądź bez separatora, maks. 20 identyfikatorów.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByRegony14zn(string pKluczUzytkownika, string regony14zn)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(pKluczUzytkownika: pKluczUzytkownika, regony14zn: regony14zn);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po Regony14zn. Metoda przeszukuje bazę Regony14zn w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="Regony14zn">Regony14zn As string - Identyfikator podmiotu Regony14zn. Regony14zn – ciąg znaków, czternastoznakowe identyfikatory REGON, oddzielane dowolnym separatorem (za wyjątkiem cyfr), bądź bez separatora, maks. 20 identyfikatorów.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByRegony14zn(string regony14zn)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(regony14zn: regony14zn);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }
    }
}