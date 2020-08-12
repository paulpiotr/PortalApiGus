using System;
using System.Reflection;
using System.ServiceModel;
using System.Threading.Tasks;
using UslugaBIRzewnPublVer11Prod;

namespace PortalApiGusApiRegonData
{
    public class UslugaBIRzewnPubl
    {
        /// <summary>
        /// log4net
        /// </summary>
        private static readonly log4net.ILog _log4net = Log4netLogger.Log4netLogger.GetLog4netInstance(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public string pIdentyfikatorSesji { get; private set; }
        /// <summary>
        /// Logowanie przy użyciu klucza użytkownika - z ustawień
        /// </summary>
        /// <returns>String logowanie udane- zwracany jest 20 znakowy identyfikator sesji | logowanie nieudane- zwracany jest pusty string</returns>
        public static async Task<string> ZalogujAsync()
        {
            try
            {
                return await ZalogujAsync("??");
                //return pIdentyfikatorSesji;
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}, {2}.", Assembly.GetExecutingAssembly().FullName, e.Message, e.StackTrace), e);
                return null;
            }
        }
        /// <summary>
        /// Logowanie przy użyciu klucza użytkownika - z parametru
        /// </summary>
        /// <param name="pKluczUzytkownika">pKluczUzytkownika As String</param>
        /// <returns>String logowanie udane- zwracany jest 20 znakowy identyfikator sesji | logowanie nieudane- zwracany jest pusty string</returns>
        public static async Task<string> ZalogujAsync(string pKluczUzytkownika)
        {
            try
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                UslugaBIRzewnPublClient uslugaBIRzewnPublClient = new UslugaBIRzewnPublClient();
                ZalogujResponse zalogujResult = await uslugaBIRzewnPublClient.ZalogujAsync(pKluczUzytkownika);
                if (null != zalogujResult && !string.IsNullOrWhiteSpace(zalogujResult.ZalogujResult))
                {
                    _log4net.Info(string.Format("{0} {1} {2} OK", Assembly.GetExecutingAssembly().FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, zalogujResult.ZalogujResult));
                    return zalogujResult.ZalogujResult.ToString();
                }
                _log4net.Info(string.Format("{0} {1} {2} FAIL", Assembly.GetExecutingAssembly().FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, zalogujResult.ZalogujResult));
                return string.Empty;
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}, {2}.", Assembly.GetExecutingAssembly().FullName, e.Message, e.StackTrace), e);
                return string.Empty;
            }
        }
        /// <summary>
        /// Zakończenie aktywności sesji utworzonej metodą Zaloguj - z właściwości pIdentyfikatorSesji
        /// </summary>
        /// <returns></returns>
        public static async Task<bool> WylogujAsync()
        {
            try
            {
                return await WylogujAsync("??");
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}, {2}.", Assembly.GetExecutingAssembly().FullName, e.Message, e.StackTrace), e);
                return false;
            }
        }
        /// <summary>
        /// Zakończenie aktywności sesji utworzonej metodą Zaloguj - z parametru
        /// </summary>
        /// <param name="pIdentyfikatorSesji">pIdentyfikatorSesji As String</param>
        /// <returns>Zwraca wartość true jeśli metoda wykonała się poprawnie</returns>
        public static async Task<bool> WylogujAsync(string pIdentyfikatorSesji = null)
        {
            try
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                UslugaBIRzewnPublClient uslugaBIRzewnPublClient = new UslugaBIRzewnPublClient();
                WylogujResponse wylogujResponse = await uslugaBIRzewnPublClient.WylogujAsync(pIdentyfikatorSesji);
                if (null != wylogujResponse && wylogujResponse.WylogujResult)
                {
                    _log4net.Info(string.Format("{0} {1} {2} OK", Assembly.GetExecutingAssembly().FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, wylogujResponse.WylogujResult));
                    return true;
                }
                _log4net.Info(string.Format("{0} {1} {2} FAIL", Assembly.GetExecutingAssembly().FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, wylogujResponse.WylogujResult));
                return false;
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}, {2}.", Assembly.GetExecutingAssembly().FullName, e.Message, e.StackTrace), e);
                return false;
            }
        }
        public static async Task DaneSzukajPodmiotyAsync(string pKluczUzytkownika, string krs = null, string krsy = null, string nip = null, string nipy = null, string regon = null, string regony14zn = null, string regony9zn = null)
        {
            try
            {
                string pIdentyfikatorSesji = await ZalogujAsync(pKluczUzytkownika);
                if (!string.IsNullOrWhiteSpace(pIdentyfikatorSesji))
                {
                    try
                    {
                        UslugaBIRzewnPublClient uslugaBIRzewnPublClient = new UslugaBIRzewnPublClient();
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
                        _log4net.Info(string.Format("Info: {0}", parametryWyszukiwania.Regon));
                        DaneSzukajPodmiotyResponse daneSzukajPodmiotyResponse = await uslugaBIRzewnPublClient.DaneSzukajPodmiotyAsync(parametryWyszukiwania);
                        //daneSzukajPodmiotyResponse.DaneSzukajPodmiotyResult.
                        _log4net.Info(string.Format("Info: {0}", daneSzukajPodmiotyResponse.DaneSzukajPodmiotyResult));
                        DanePobierzPelnyRaportResponse danePobierzPelnyRaportResponse = await uslugaBIRzewnPublClient.DanePobierzPelnyRaportAsync(parametryWyszukiwania.Regon, "PublDaneRaportPrawna");
                        _log4net.Info(string.Format("Info: {0}", danePobierzPelnyRaportResponse.DanePobierzPelnyRaportResult));
                    }
                    catch (Exception e)
                    {
                        _log4net.Error(string.Format("{0}, {1}, {2}.", Assembly.GetExecutingAssembly().FullName, e.Message, e.StackTrace), e);
                    }
                    finally
                    {
                        if (null != pIdentyfikatorSesji && !string.IsNullOrWhiteSpace(pIdentyfikatorSesji))
                        {
                            await WylogujAsync(pIdentyfikatorSesji);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}, {2}.", Assembly.GetExecutingAssembly().FullName, e.Message, e.StackTrace), e);
                //return false;
            }
        }
    }
}
