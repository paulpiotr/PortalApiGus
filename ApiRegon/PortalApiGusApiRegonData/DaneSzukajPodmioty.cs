using PortalApiGusApiRegonData.Models.DaneSzukajPodmioty;
using System;
using System.Reflection;
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
        /// 
        /// </summary>
        /// <param name="daneSzukajPodmiotyResult"></param>
        /// <returns></returns>
        private static DaneSzukajPodmiotyList DeserializeXmlAsDaneSzukajPodmiotyList(string daneSzukajPodmiotyResult)
        {
            try
            {
                return UslugaBIRzewnPubl.DeserializeXmlAsDaneSzukajPodmiotyList(daneSzukajPodmiotyResult);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}, {2}.", Assembly.GetExecutingAssembly().FullName, e.Message, e.StackTrace), e);
                throw new NotImplementedException();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pKluczUzytkownika"></param>
        /// <returns></returns>
        private static Task<UslugaBIRzewnPublClient> UslugaBIRzewnPublClientAsync(string pKluczUzytkownika)
        {
            try
            {
                return UslugaBIRzewnPubl.UslugaBIRzewnPublClientAsync(pKluczUzytkownika);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}, {2}.", Assembly.GetExecutingAssembly().FullName, e.Message, e.StackTrace), e);
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
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] Models.DaneSzukajPodmioty.DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<Models.DaneSzukajPodmioty.DaneSzukajPodmiotyList> DaneSzukajPodmiotyAsync(string pKluczUzytkownika, string krs = null, string krsy = null, string nip = null, string nipy = null, string regon = null, string regony14zn = null, string regony9zn = null)
        {
            try
            {
                UslugaBIRzewnPublClient uslugaBIRzewnPublClient = await UslugaBIRzewnPublClientAsync(pKluczUzytkownika);
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
                    DaneSzukajPodmiotyResponse daneSzukajPodmiotyResponse = await uslugaBIRzewnPublClient.DaneSzukajPodmiotyAsync(parametryWyszukiwania);
                    if (null != daneSzukajPodmiotyResponse && null != daneSzukajPodmiotyResponse.DaneSzukajPodmiotyResult && !string.IsNullOrWhiteSpace(daneSzukajPodmiotyResponse.DaneSzukajPodmiotyResult))
                    {
                        _log4net.Info(string.Format("{0} {1} OK", Assembly.GetExecutingAssembly().FullName, MethodBase.GetCurrentMethod().Name));
                        return DeserializeXmlAsDaneSzukajPodmiotyList(daneSzukajPodmiotyResponse.DaneSzukajPodmiotyResult);
                    }
                    _log4net.Info(string.Format("{0} {1} EMPTY", Assembly.GetExecutingAssembly().FullName, MethodBase.GetCurrentMethod().Name));
                    return null;
                }
                catch (Exception e)
                {
                    _log4net.Error(string.Format("{0}, {1}, {2}.", Assembly.GetExecutingAssembly().FullName, e.Message, e.StackTrace), e);
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
                _log4net.Error(string.Format("{0}, {1}, {2}.", Assembly.GetExecutingAssembly().FullName, e.Message, e.StackTrace), e);
                return null;
            }
        }
        /// <summary>
        /// Wyszukaj podmiot po krs. Metoda przeszukuje bazę regon w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="pKluczUzytkownika">pKluczUzytkownika As String</param>
        /// <param name="krs">krs As string 10 znaków - Identyfikator podmiotu Numer KRS</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] Models.DaneSzukajPodmioty.DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<Models.DaneSzukajPodmioty.DaneSzukajPodmiotyList> DaneSzukajPodmiotyAsyncByKrs(string pKluczUzytkownika, string krs)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(pKluczUzytkownika, krs: krs);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}, {2}.", Assembly.GetExecutingAssembly().FullName, e.Message, e.StackTrace), e);
                return null;
            }
        }
        /// <summary>
        /// Wyszukaj podmiot po krsy. Metoda przeszukuje bazę regon w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="pKluczUzytkownika">pKluczUzytkownika As String</param>
        /// <param name="krsy">krsy As string - Ciąg znaków, dziesięcioznakowe identyfikatory KRS, oddzielane dowolnym separatorem (za wyjątkiem cyfr), bądź bez separatora, maks. 20 identyfikatorów.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] Models.DaneSzukajPodmioty.DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<Models.DaneSzukajPodmioty.DaneSzukajPodmiotyList> DaneSzukajPodmiotyAsyncByKrsy(string pKluczUzytkownika, string krsy)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(pKluczUzytkownika, krsy: krsy);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}, {2}.", Assembly.GetExecutingAssembly().FullName, e.Message, e.StackTrace), e);
                return null;
            }
        }
        /// <summary>
        /// Wyszukaj podmiot po Nip. Metoda przeszukuje bazę regon w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="pKluczUzytkownika">pKluczUzytkownika As String</param>
        /// <param name="Nip">Nip As string - Identyfikator podmiotu Nip.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] Models.DaneSzukajPodmioty.DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<Models.DaneSzukajPodmioty.DaneSzukajPodmiotyList> DaneSzukajPodmiotyAsyncByNip(string pKluczUzytkownika, string nip)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(pKluczUzytkownika, nip: nip);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}, {2}.", Assembly.GetExecutingAssembly().FullName, e.Message, e.StackTrace), e);
                return null;
            }
        }
        /// <summary>
        /// Wyszukaj podmiot po Nipy. Metoda przeszukuje bazę regon w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="pKluczUzytkownika">pKluczUzytkownika As String</param>
        /// <param name="Nipy">Nipy As string - Identyfikator podmiotu Nipy. Nipy – ciąg znaków, dziesięcioznakowe identyfikatory NIP, oddzielane dowolnym separatorem (za wyjątkiem cyfr), bądź bez separatora, maks. 20 identyfikatorów.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] Models.DaneSzukajPodmioty.DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<Models.DaneSzukajPodmioty.DaneSzukajPodmiotyList> DaneSzukajPodmiotyAsyncByNipy(string pKluczUzytkownika, string nipy)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(pKluczUzytkownika, nipy: nipy);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}, {2}.", Assembly.GetExecutingAssembly().FullName, e.Message, e.StackTrace), e);
                return null;
            }
        }
        /// <summary>
        /// Wyszukaj podmiot po Regon. Metoda przeszukuje bazę regon w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="pKluczUzytkownika">pKluczUzytkownika As String</param>
        /// <param name="Regon">Regon As string - Identyfikator podmiotu Regon.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] Models.DaneSzukajPodmioty.DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<Models.DaneSzukajPodmioty.DaneSzukajPodmiotyList> DaneSzukajPodmiotyAsyncByRegon(string pKluczUzytkownika, string regon)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(pKluczUzytkownika, regon: regon);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}, {2}.", Assembly.GetExecutingAssembly().FullName, e.Message, e.StackTrace), e);
                return null;
            }
        }
        /// <summary>
        /// Wyszukaj podmiot po Regony9zn. Metoda przeszukuje bazę Regony9zn w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="pKluczUzytkownika">pKluczUzytkownika As String</param>
        /// <param name="Regony9zn">Regony9zn As string - Identyfikator podmiotu Regony9zn. Regony9zn – ciąg znaków, dziewięcioznakowe identyfikatory REGON, oddzielane dowolnym separatorem (za wyjątkiem cyfr), bądź bez separatora, maks. 20 identyfikatorów.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] Models.DaneSzukajPodmioty.DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<Models.DaneSzukajPodmioty.DaneSzukajPodmiotyList> DaneSzukajPodmiotyAsyncByRegony9zn(string pKluczUzytkownika, string regony9zn)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(pKluczUzytkownika, regony9zn: regony9zn);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}, {2}.", Assembly.GetExecutingAssembly().FullName, e.Message, e.StackTrace), e);
                return null;
            }
        }
        /// <summary>
        /// Wyszukaj podmiot po Regony14zn. Metoda przeszukuje bazę Regony14zn w poszukiwaniu rekordów zgodnych z określonymi parametrami wyszukiwania. Rekordy zwracane są w postaci listy.
        /// </summary>
        /// <param name="pKluczUzytkownika">pKluczUzytkownika As String</param>
        /// <param name="Regony14zn">Regony14zn As string - Identyfikator podmiotu Regony14zn. Regony14zn – ciąg znaków, czternastoznakowe identyfikatory REGON, oddzielane dowolnym separatorem (za wyjątkiem cyfr), bądź bez separatora, maks. 20 identyfikatorów.</param>
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] Models.DaneSzukajPodmioty.DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<Models.DaneSzukajPodmioty.DaneSzukajPodmiotyList> DaneSzukajPodmiotyAsyncByRegony14zn(string pKluczUzytkownika, string regony14zn)
        {
            try
            {
                return await DaneSzukajPodmiotyAsync(pKluczUzytkownika, regony14zn: regony14zn);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}, {2}.", Assembly.GetExecutingAssembly().FullName, e.Message, e.StackTrace), e);
                return null;
            }
        }
    }
}