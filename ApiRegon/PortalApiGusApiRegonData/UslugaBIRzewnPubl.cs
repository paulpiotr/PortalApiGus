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
    #region public class UslugaBIRzewnPubl
    /// <summary>
    /// Klasa podstawowa dla serwisu usługi UslugaBIRzewnPublVer11Prod
    /// Base class for the service service UslugaBIRzewnPublVer11Prod
    /// </summary>
    public class UslugaBIRzewnPubl
    {
        #region private static readonly log4net.ILog log4net
        /// <summary>
        /// Log4net Logger
        /// Log4net Logger
        /// </summary>
        private static readonly log4net.ILog log4net = Log4netLogger.Log4netLogger.GetLog4netInstance(MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        #region public static async Task<string> ZalogujAsync(string pKluczUzytkownika)
        /// <summary>
        /// Zaloguj do serwisu i zwróć identyfikator sesji
        /// Log in to the site and return the session ID
        /// </summary>
        /// <param name="pKluczUzytkownika">
        /// Klucz użytkownika pKluczUzytkownika jako string
        /// User key pKluczUzytkownika as a string
        /// </param>
        /// <returns>
        /// Logowanie udane, zwracany jest 20 znakowy identyfikator sesji lub logowanie nieudane, zwracany jest pusty string
        /// Login successful, a 20-character session ID is returned or login failed, an empty string is returned
        /// </returns>
        public static async Task<string> ZalogujAsync(string pKluczUzytkownika)
        {
            return await Task.Run(async () =>
             {
                 try
                 {
                     UslugaBIRzewnPublClient uslugaBIRzewnPublClient = new UslugaBIRzewnPublClient();
                     ZalogujResponse zalogujResult = await uslugaBIRzewnPublClient.ZalogujAsync(pKluczUzytkownika);
                     if (null != zalogujResult && !string.IsNullOrWhiteSpace(zalogujResult.ZalogujResult))
                     {
                         log4net.Debug(string.Format("{0} {1} {2} OK", Assembly.GetExecutingAssembly().FullName, MethodBase.GetCurrentMethod().Name, zalogujResult.ZalogujResult));
                         return zalogujResult.ZalogujResult.ToString();
                     }
                     log4net.Debug(string.Format("{0} {1} {2} FAIL", Assembly.GetExecutingAssembly().FullName, MethodBase.GetCurrentMethod().Name, zalogujResult.ZalogujResult));
                 }
                 catch (Exception e)
                 {
                     log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                 }
                 return string.Empty;
             });
        }
        #endregion

        #region public static async Task<bool> WylogujAsync(string pIdentyfikatorSesji = null)
        /// <summary>
        /// Zakończenie aktywności sesji utworzonej metodą Zaloguj
        /// Ending the activity of the session created with the Login method
        /// </summary>
        /// <param name="pKluczUzytkownika">
        /// Klucz użytkownika pKluczUzytkownika jako string
        /// User key pKluczUzytkownika as a string
        /// </param>
        /// <returns>
        /// Zwraca true jeśli metoda wykonała się poprawnie w przeciwnym wypadku false
        /// Returns true if the method was successful, otherwise false
        /// </returns>
        public static async Task<bool> WylogujAsync(string pIdentyfikatorSesji = null)
        {
            return await Task.Run(async () =>
             {
                 try
                 {
                     UslugaBIRzewnPublClient uslugaBIRzewnPublClient = new UslugaBIRzewnPublClient();
                     WylogujResponse wylogujResponse = await uslugaBIRzewnPublClient.WylogujAsync(pIdentyfikatorSesji);
                     if (null != wylogujResponse && wylogujResponse.WylogujResult)
                     {
                         log4net.Debug(string.Format("{0} {1} {2} OK", Assembly.GetExecutingAssembly().FullName, MethodBase.GetCurrentMethod().Name, wylogujResponse.WylogujResult));
                         return true;
                     }
                     log4net.Debug(string.Format("{0} {1} {2} FAIL", Assembly.GetExecutingAssembly().FullName, MethodBase.GetCurrentMethod().Name, wylogujResponse.WylogujResult));
                 }
                 catch (Exception e)
                 {
                     log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                 }
                 return false;
             });
        }
        #endregion

        #region public static async Task<UslugaBIRzewnPublClient> GetClientAsync(string pKluczUzytkownika)
        /// <summary>
        /// Zaloguj, ustaw odpowiednie parametry żądania w nagłówku i pobierz referencje do serwisu
        /// Log in, set the appropriate request parameters in the header and get the site references
        /// </summary>
        /// <param name="pKluczUzytkownika">
        /// Klucz użytkownika pKluczUzytkownika jako string
        /// User key pKluczUzytkownika as a string
        /// </param>
        /// <returns>
        /// Referencja do usług jako obiekt UslugaBIRzewnPublClient lub null
        /// </returns>
        public static async Task<UslugaBIRzewnPublClient> GetClientAsync(string pKluczUzytkownika)
        {
            return await Task.Run(async () =>
             {
                 UslugaBIRzewnPublClient uslugaBIRzewnPublClient = new UslugaBIRzewnPublClient();
                 ///Śledzenie usługi 
                 ///uslugaBIRzewnPublClient.Endpoint.EndpointBehaviors.Add(new NetAppCommon.Logging.SoapEndpointBehavior());
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
                 }
                 catch (Exception e)
                 {
                     log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                 }
                 return uslugaBIRzewnPublClient;
             });
        }
        #endregion

        #region public static Models.DaneSzukajPodmioty.DaneSzukajPodmiotyList DeserializeXmlAsDaneSzukajPodmiotyList(string xml)
        /// <summary>
        /// Deserjalizuj string xml na listę obiektów DaneSzukajPodmioty
        /// Deserialize the xml string to the list of DataSearchEntities
        /// </summary>
        /// <param name="xml">
        /// ciąg xml jako string
        /// xml string as string
        /// </param>
        /// <returns>
        /// Lsta obiektów jako DaneSzukajPodmiotyList
        /// List of objects as DataSearchObjectsList
        /// </returns>
        public static Models.DaneSzukajPodmioty.DaneSzukajPodmiotyList DeserializeXmlAsDaneSzukajPodmiotyList(string xml)
        {
            try
            {
                Models.DaneSzukajPodmioty.DaneSzukajPodmiotyList daneSzukajPodmiotyList = DeserializeXml<Models.DaneSzukajPodmioty.DaneSzukajPodmiotyList>(xml);
                if (null != daneSzukajPodmiotyList && null != daneSzukajPodmiotyList.Dane && daneSzukajPodmiotyList.Dane.Count > 0)
                {
                    log4net.Debug(string.Format("{0} {1} count: {2} OK", Assembly.GetExecutingAssembly().FullName, MethodBase.GetCurrentMethod().Name, daneSzukajPodmiotyList.Dane.Count));
                    return daneSzukajPodmiotyList;
                }
                log4net.Debug(string.Format("{0} {1} empty", Assembly.GetExecutingAssembly().FullName, MethodBase.GetCurrentMethod().Name));
            }
            catch (Exception e)
            {
                log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
            }
            return null;
        }
        #endregion

        #region public static T DeserializeXml<T>(string xml)
        /// <summary>
        /// Ogólna metoda deserializacja ciągu xml do typu T
        /// General method to deserialize the xml string to type T
        /// </summary>
        /// <typeparam name="T">
        /// Typ danych T
        /// T data type
        /// </typeparam>
        /// <param name="xml">
        /// Ciąg xml jako string
        /// The xml string as a string
        /// </param>
        /// <returns>
        /// Objekt typu danych T
        /// Object of the data type T
        /// </returns>
        public static T DeserializeXml<T>(string xml)
        {
            try
            {
                XmlReader xmlReader = XmlReader.Create(new StringReader(xml));
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                T _object = (T)xmlSerializer.Deserialize(xmlReader);
                if (null != _object)
                {
                    log4net.Debug(string.Format("{0} {1} {2} OK", Assembly.GetExecutingAssembly().FullName, MethodBase.GetCurrentMethod().Name, _object));
                    return _object;
                }
                log4net.Debug(string.Format("{0} {1} empty", Assembly.GetExecutingAssembly().FullName, MethodBase.GetCurrentMethod().Name));
            }
            catch (Exception e)
            {
                log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
            }
            return (T)Convert.ChangeType(null, typeof(T));
        }
        #endregion
    }
    #endregion
}