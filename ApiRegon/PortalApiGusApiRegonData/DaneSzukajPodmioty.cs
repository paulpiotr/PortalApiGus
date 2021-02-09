using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PortalApiGusApiRegonData.Data;
using PortalApiGusApiRegonData.Models;
using UslugaBIRzewnPublVer11Prod;

namespace PortalApiGusApiRegonData
{
    public class DaneSzukajPodmioty
    {
        # region private readonly log4net.ILog log4net
        /// <summary>
        /// Log4net Logger
        /// Log4net Logger
        /// </summary>
        private static readonly log4net.ILog Log4net = Log4netLogger.Log4netLogger.GetLog4netInstance(MethodBase.GetCurrentMethod()?.DeclaringType);
        #endregion

        #region private static readonly AppSettings AppSettings
        /// <summary>
        /// Instancja do modelu ustawień jako AppSettings
        /// Instance to the settings model as AppSettings
        /// </summary>
        private static readonly AppSettings AppSettings = new AppSettings();
        #endregion

        #region private static readonly PortalApiGusApiRegonDataDbContext PortalApiGusApiRegonDataDbContext
        /// <summary>
        /// Kontekst do bazy danych PortalApiGusApiRegonDataDbContext
        /// The context for the PortalApiGusApiRegonDataDbContext database
        /// </summary>
        private static readonly PortalApiGusApiRegonDataDbContext PortalApiGusApiRegonDataDbContext = new PortalApiGusApiRegonDataDbContext(AppSettings.GetDbContextOptions<PortalApiGusApiRegonDataDbContext>());
        #endregion

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
                Log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Ustaw odpowiednie parametry rządania w nagłówku - Ustaw "sid", pIdentyfikatorSesji zwrócony w logowaniu
        /// </summary>
        /// <param name="pKluczUzytkownika">pKluczUzytkownika As String</param>
        /// <returns>uslugaBIRzewnPublClient As UslugaBIRzewnPublClient lub null jeśli wystąpił błąd</returns>
        private static Task<UslugaBIRzewnPublClient> GetClientAsync(string pKluczUzytkownika)
        {
            try
            {
                return UslugaBIRzewnPubl.GetClientAsync(pKluczUzytkownika);
            }
            catch (Exception e)
            {
                Log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
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
                var parametryWyszukiwania = new ParametryWyszukiwania()
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
                    if (AppSettings.CacheLifeTime > 0)
                    {
                        var daneSzukajPodmiotyList = PortalApiGusApiRegonDataDbContext.DaneSzukajPodmioty.Where(w =>
                           w.ParametryWyszukiwaniaSHA512 == Helper.ObjectHelper.ObjectToSHA512(parametryWyszukiwania)
                           && w.DataModyfikacji >= DateTime.Now.AddSeconds((double)AppSettings.CacheLifeTime * -1)
                            ).ToList();
                        if (null != daneSzukajPodmiotyList && daneSzukajPodmiotyList.Any())
                        {
                            return daneSzukajPodmiotyList;
                        }
                    }
                }
                catch (Exception e)
                {
                    Log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                }
                UslugaBIRzewnPublClient uslugaBIRzewnPublClient = await GetClientAsync(pKluczUzytkownika);
                try
                {
                    DaneSzukajPodmiotyResponse daneSzukajPodmiotyResponse = await uslugaBIRzewnPublClient.DaneSzukajPodmiotyAsync(parametryWyszukiwania);
                    if (null != daneSzukajPodmiotyResponse && null != daneSzukajPodmiotyResponse.DaneSzukajPodmiotyResult && !string.IsNullOrWhiteSpace(daneSzukajPodmiotyResponse.DaneSzukajPodmiotyResult))
                    {
                        List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty> daneSzukajPodmiotyList = DeserializeXmlAsDaneSzukajPodmiotyList(daneSzukajPodmiotyResponse.DaneSzukajPodmiotyResult);
                        if (null != daneSzukajPodmiotyList && daneSzukajPodmiotyList.Any())
                        {
                            try
                            {
                                foreach (Models.DaneSzukajPodmioty.DaneSzukajPodmioty daneSzukajPodmioty in daneSzukajPodmiotyList)
                                {
                                    daneSzukajPodmioty.ParametryWyszukiwaniaSHA512 = Helper.ObjectHelper.ObjectToSHA512(parametryWyszukiwania);
                                    daneSzukajPodmioty.ParametryWyszukiwaniaJson = JsonSerializer.Serialize<ParametryWyszukiwania>(parametryWyszukiwania);
                                    daneSzukajPodmioty.DataUtworzenia = DateTime.Now;
                                    daneSzukajPodmioty.DataModyfikacji = DateTime.Now;
                                    daneSzukajPodmioty.UniqueIdentifierOfTheLoggedInUser = NetAppCommon.HttpContextAccessor.AppContext.GetCurrentUserIdentityName();
                                    try
                                    {
                                        Models.DaneSzukajPodmioty.DaneSzukajPodmioty daneSzukajPodmiotyWhere = PortalApiGusApiRegonDataDbContext.DaneSzukajPodmioty.Where(w => w.ParametryWyszukiwaniaSHA512 == Helper.ObjectHelper.ObjectToSHA512(parametryWyszukiwania) && w.Regon == daneSzukajPodmioty.Regon).FirstOrDefault();
                                        if (null != daneSzukajPodmiotyWhere)
                                        {
                                            daneSzukajPodmioty.Id = daneSzukajPodmiotyWhere.Id;
                                            PortalApiGusApiRegonDataDbContext.Entry(daneSzukajPodmiotyWhere).State = EntityState.Detached;
                                        }
                                        if (null != daneSzukajPodmioty)
                                        {
                                            PortalApiGusApiRegonDataDbContext.Entry(daneSzukajPodmioty).State = "00000000-0000-0000-0000-000000000000" != daneSzukajPodmioty.Id.ToString() ? EntityState.Modified : EntityState.Added;
                                            var result = await PortalApiGusApiRegonDataDbContext.SaveChangesAsync();
#if DEBUG
                                            Log4net.Debug($"Save Changes Async to database: { result } id: { daneSzukajPodmioty.Id }");
#endif
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        Log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                                    }
                                }
                            }
                            catch (Exception e)
                            {
                                Log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                            }
                            return daneSzukajPodmiotyList;
                        }
                    }
#if DEBUG
                    Log4net.Debug(string.Format("{0} {1} EMPTY", Assembly.GetExecutingAssembly().FullName, MethodBase.GetCurrentMethod().Name));
#endif
                    return null;
                }
                catch (Exception e)
                {
                    Log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                    return null;
                }
            }
            catch (Exception e)
            {
                Log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
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
                return await DaneSzukajPodmiotyAsync(AppSettings.PortalApiGusKey, krs, krsy, nip, nipy, regon, regony14zn, regony9zn);
            }
            catch (Exception e)
            {
                Log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po krs. Metoda przeszukuje bazę regon w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="pKluczUzytkownika">pKluczUzytkownika As String</param>
        /// <param name="krs">krs As string 10 znaków - Identyfikator podmiotu Numer KRS</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByKrsAsync(string pKluczUzytkownika, string krs)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(pKluczUzytkownika, krs: krs);
            }
            catch (Exception e)
            {
                Log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po krs. Metoda przeszukuje bazę regon w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="krs">krs As string 10 znaków - Identyfikator podmiotu Numer KRS</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByKrsAsync(string krs)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(krs: krs);
            }
            catch (Exception e)
            {
                Log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po krsy. Metoda przeszukuje bazę regon w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="pKluczUzytkownika">pKluczUzytkownika As String</param>
        /// <param name="krsy">krsy As string - Ciąg znaków, dziesięcioznakowe identyfikatory KRS, oddzielane dowolnym separatorem (za wyjątkiem cyfr), bądź bez separatora, maks. 20 identyfikatorów.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByKrsyAsync(string pKluczUzytkownika, string krsy)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(pKluczUzytkownika: pKluczUzytkownika, krsy: krsy);
            }
            catch (Exception e)
            {
                Log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po krsy. Metoda przeszukuje bazę regon w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="krsy">krsy As string - Ciąg znaków, dziesięcioznakowe identyfikatory KRS, oddzielane dowolnym separatorem (za wyjątkiem cyfr), bądź bez separatora, maks. 20 identyfikatorów.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByKrsyAsync(string krsy)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(krsy: krsy);
            }
            catch (Exception e)
            {
                Log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po Nip. Metoda przeszukuje bazę regon w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="pKluczUzytkownika">pKluczUzytkownika As String</param>
        /// <param name="Nip">Nip As string - Identyfikator podmiotu Nip.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByNipAsync(string pKluczUzytkownika, string nip)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(pKluczUzytkownika: pKluczUzytkownika, nip: nip);
            }
            catch (Exception e)
            {
                Log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po Nip. Metoda przeszukuje bazę regon w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="Nip">Nip As string - Identyfikator podmiotu Nip.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByNipAsync(string nip)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(nip: nip);
            }
            catch (Exception e)
            {
                Log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po Nipy. Metoda przeszukuje bazę regon w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="pKluczUzytkownika">pKluczUzytkownika As String</param>
        /// <param name="Nipy">Nipy As string - Identyfikator podmiotu Nipy. Nipy – ciąg znaków, dziesięcioznakowe identyfikatory NIP, oddzielane dowolnym separatorem (za wyjątkiem cyfr), bądź bez separatora, maks. 20 identyfikatorów.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByNipyAsync(string pKluczUzytkownika, string nipy)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(pKluczUzytkownika: pKluczUzytkownika, nipy: nipy);
            }
            catch (Exception e)
            {
                Log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po Nipy. Metoda przeszukuje bazę regon w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="Nipy">Nipy As string - Identyfikator podmiotu Nipy. Nipy – ciąg znaków, dziesięcioznakowe identyfikatory NIP, oddzielane dowolnym separatorem (za wyjątkiem cyfr), bądź bez separatora, maks. 20 identyfikatorów.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByNipyAsync(string nipy)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(nipy: nipy);
            }
            catch (Exception e)
            {
                Log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po Regon. Metoda przeszukuje bazę regon w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="pKluczUzytkownika">pKluczUzytkownika As String</param>
        /// <param name="Regon">Regon As string - Identyfikator podmiotu Regon.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByRegonAsync(string pKluczUzytkownika, string regon)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(pKluczUzytkownika: pKluczUzytkownika, regon: regon);
            }
            catch (Exception e)
            {
                Log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po Regon. Metoda przeszukuje bazę regon w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="Regon">Regon As string - Identyfikator podmiotu Regon.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByRegonAsync(string regon)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(regon: regon);
            }
            catch (Exception e)
            {
                Log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po Regony9zn. Metoda przeszukuje bazę Regony9zn w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="pKluczUzytkownika">pKluczUzytkownika As String</param>
        /// <param name="Regony9zn">Regony9zn As string - Identyfikator podmiotu Regony9zn. Regony9zn – ciąg znaków, dziewięcioznakowe identyfikatory REGON, oddzielane dowolnym separatorem (za wyjątkiem cyfr), bądź bez separatora, maks. 20 identyfikatorów.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByRegony9znAsync(string pKluczUzytkownika, string regony9zn)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(pKluczUzytkownika: pKluczUzytkownika, regony9zn: regony9zn);
            }
            catch (Exception e)
            {
                Log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po Regony9zn. Metoda przeszukuje bazę Regony9zn w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="Regony9zn">Regony9zn As string - Identyfikator podmiotu Regony9zn. Regony9zn – ciąg znaków, dziewięcioznakowe identyfikatory REGON, oddzielane dowolnym separatorem (za wyjątkiem cyfr), bądź bez separatora, maks. 20 identyfikatorów.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByRegony9znAsync(string regony9zn)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(regony9zn: regony9zn);
            }
            catch (Exception e)
            {
                Log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po Regony14zn. Metoda przeszukuje bazę Regony14zn w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="pKluczUzytkownika">pKluczUzytkownika As String</param>
        /// <param name="Regony14zn">Regony14zn As string - Identyfikator podmiotu Regony14zn. Regony14zn – ciąg znaków, czternastoznakowe identyfikatory REGON, oddzielane dowolnym separatorem (za wyjątkiem cyfr), bądź bez separatora, maks. 20 identyfikatorów.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByRegony14znAsync(string pKluczUzytkownika, string regony14zn)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(pKluczUzytkownika: pKluczUzytkownika, regony14zn: regony14zn);
            }
            catch (Exception e)
            {
                Log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }

        /// <summary>
        /// Wyszukaj podmiot po Regony14zn. Metoda przeszukuje bazę Regony14zn w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="Regony14zn">Regony14zn As string - Identyfikator podmiotu Regony14zn. Regony14zn – ciąg znaków, czternastoznakowe identyfikatory REGON, oddzielane dowolnym separatorem (za wyjątkiem cyfr), bądź bez separatora, maks. 20 identyfikatorów.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>> DaneSzukajPodmiotyAsyncByRegony14znAsync(string regony14zn)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(regony14zn: regony14zn);
            }
            catch (Exception e)
            {
                Log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }
    }
}
