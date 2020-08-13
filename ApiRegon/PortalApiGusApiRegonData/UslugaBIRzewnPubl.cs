using System;
using System.IO;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using UslugaBIRzewnPublVer11Prod;

namespace PortalApiGusApiRegonData
{
    public class UslugaBIRzewnPubl
    {
        /// <summary>
        /// log4net
        /// </summary>
        private static readonly log4net.ILog _log4net = Log4netLogger.Log4netLogger.GetLog4netInstance(MethodBase.GetCurrentMethod().DeclaringType);
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
                    _log4net.Info(string.Format("{0} {1} {2} OK", Assembly.GetExecutingAssembly().FullName, MethodBase.GetCurrentMethod().Name, zalogujResult.ZalogujResult));
                    return zalogujResult.ZalogujResult.ToString();
                }
                _log4net.Info(string.Format("{0} {1} {2} FAIL", Assembly.GetExecutingAssembly().FullName, MethodBase.GetCurrentMethod().Name, zalogujResult.ZalogujResult));
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
                    _log4net.Info(string.Format("{0} {1} {2} OK", Assembly.GetExecutingAssembly().FullName, MethodBase.GetCurrentMethod().Name, wylogujResponse.WylogujResult));
                    return true;
                }
                _log4net.Info(string.Format("{0} {1} {2} FAIL", Assembly.GetExecutingAssembly().FullName, MethodBase.GetCurrentMethod().Name, wylogujResponse.WylogujResult));
                return false;
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}, {2}.", Assembly.GetExecutingAssembly().FullName, e.Message, e.StackTrace), e);
                return false;
            }
        }
        /// <summary>
        /// Ustaw odpowiednie parametry rządania w nagłówku
        /// Logowanie przy użyciu klucza użytkownika - z parametru
        /// Ustaw "sid", pIdentyfikatorSesji zwrócony w logowaniu
        /// </summary>
        /// <param name="pKluczUzytkownika">pKluczUzytkownika As String</param>
        /// <returns>uslugaBIRzewnPublClient As UslugaBIRzewnPublClient lub null jeśli wystąpił błąd</returns>
        public static async Task<UslugaBIRzewnPublClient> UslugaBIRzewnPublClientAsync(string pKluczUzytkownika)
        {
            UslugaBIRzewnPublClient uslugaBIRzewnPublClient = new UslugaBIRzewnPublClient();
            try
            {
                string pIdentyfikatorSesji = await ZalogujAsync(pKluczUzytkownika);
                if (!string.IsNullOrWhiteSpace(pIdentyfikatorSesji))
                {
                    OperationContextScope operationContextScope = new OperationContextScope(uslugaBIRzewnPublClient.InnerChannel);
                    HttpRequestMessageProperty httpRequestMessageProperty = new HttpRequestMessageProperty();
                    httpRequestMessageProperty.Headers.Add("sid", pIdentyfikatorSesji);
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = httpRequestMessageProperty;
                }
                return uslugaBIRzewnPublClient;
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}, {2}.", Assembly.GetExecutingAssembly().FullName, e.Message, e.StackTrace), e);
                return uslugaBIRzewnPublClient;
            }
        }
        /// <summary>
        /// Deserjalizuj string xml na listę obiektów Models.DaneSzukajPodmioty.DaneSzukajPodmiotyList<DaneSzukajPodmioty>
        /// </summary>
        /// <param name="xml">xml As string - ciąg xml</param>
        /// <returns>Models.DaneSzukajPodmioty.DaneSzukajPodmiotyList<DaneSzukajPodmioty> - lista obiektów DaneSzukajPodmioty</returns>
        public static Models.DaneSzukajPodmioty.DaneSzukajPodmiotyList DeserializeXmlAsDaneSzukajPodmiotyList(string xml)
        {
            try
            {
                Models.DaneSzukajPodmioty.DaneSzukajPodmiotyList daneSzukajPodmiotyList = DeserializeXml<Models.DaneSzukajPodmioty.DaneSzukajPodmiotyList>(xml);
                if (null != daneSzukajPodmiotyList && null != daneSzukajPodmiotyList.Dane && daneSzukajPodmiotyList.Dane.Count > 0)
                {
                    _log4net.Info(string.Format("{0} {1} count: {2} OK", Assembly.GetExecutingAssembly().FullName, MethodBase.GetCurrentMethod().Name, daneSzukajPodmiotyList.Dane.Count));
                    return daneSzukajPodmiotyList;
                }
                _log4net.Info(string.Format("{0} {1} empty", Assembly.GetExecutingAssembly().FullName, MethodBase.GetCurrentMethod().Name));
                return null;
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}, {2}.", Assembly.GetExecutingAssembly().FullName, e.Message, e.StackTrace), e);
                return null;
            }
        }
        /// <summary>
        /// Deserialize Xml - Deserializacja ciągu xml do typu T
        /// </summary>
        /// <typeparam name="T">Typ danych T</typeparam>
        /// <param name="xml">ciąg xml</param>
        /// <returns>Objekt typu danych T</returns>
        public static T DeserializeXml<T>(string xml)
        {
            try
            {
                XmlReader xmlReader = XmlReader.Create(new StringReader(xml));
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                T dane = (T)xmlSerializer.Deserialize(xmlReader);
                if (null != dane)
                {
                    _log4net.Info(string.Format("{0} {1} {2} OK", Assembly.GetExecutingAssembly().FullName, MethodBase.GetCurrentMethod().Name, dane));
                    return dane;
                }
                _log4net.Info(string.Format("{0} {1} empty", Assembly.GetExecutingAssembly().FullName, MethodBase.GetCurrentMethod().Name));
                return (T)Convert.ChangeType(null, typeof(T));
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}, {2}.", Assembly.GetExecutingAssembly().FullName, e.Message, e.StackTrace), e);
                return (T)Convert.ChangeType(null, typeof(T));
            }
        }
    }
}