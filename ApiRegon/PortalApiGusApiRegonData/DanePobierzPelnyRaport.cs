using PortalApiGusApiRegonData.Models.DaneSzukajPodmioty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using UslugaBIRzewnPublVer11Prod;

namespace PortalApiGusApiRegonData
{
    public class DanePobierzPelnyRaport
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
        /// <returns>[obiekt zwracany przez metodę DaneSzukajPodmioty] DaneSzukajPodmiotyList<DaneSzukajPodmioty> Lista obiektów DaneSzukajPodmioty, lub brak (null)</returns>
        public static async Task<string> DanePobierzPelnyRaportAsync(string pKluczUzytkownika, string krs = null, string krsy = null, string nip = null, string nipy = null, string regon = null, string regony14zn = null, string regony9zn = null)
        {
            try
            {
                List<Models.DaneSzukajPodmioty.DaneSzukajPodmioty> daneSzukajPodmiotyList = await DaneSzukajPodmioty.DaneSzukajPodmiotyAsync(pKluczUzytkownika, krs, krsy, nip, nipy, regon, regony14zn, regony9zn);
                if (null != daneSzukajPodmiotyList && daneSzukajPodmiotyList.Any())
                {
                    foreach (Models.DaneSzukajPodmioty.DaneSzukajPodmioty daneSzukajPodmioty in daneSzukajPodmiotyList)
                    {
                        if (null != daneSzukajPodmioty.Regon && !string.IsNullOrWhiteSpace(daneSzukajPodmioty.Regon) && null != daneSzukajPodmioty.Typ && !string.IsNullOrWhiteSpace(daneSzukajPodmioty.Typ) && null != daneSzukajPodmioty.SilosID && daneSzukajPodmioty.SilosID > 0)
                        {
                            UslugaBIRzewnPublClient uslugaBIRzewnPublClient = await UslugaBIRzewnPublClientAsync(pKluczUzytkownika);
                            if (null != uslugaBIRzewnPublClient)
                            {
                                //1) Dla osób prawnych – należy pobrać raport BIR11OsPrawna.
                                //Podmiot jest aktywny jeśli wszystkie poniższe pola NIE są wypełnione(mają wartości puste).
                                //< praw_dataZawieszeniaDzialalnosci />
                                //< praw_dataZakonczeniaDzialalnosci />
                                //< praw_dataSkresleniaZRegon />
                                //< praw_dataOrzeczeniaOUpadlosci />
                                //< praw_dataZakonczeniaPostepowaniaUpadlosciowego />
                                //2) Dla osób fizycznych trzeba rozróżnić aktywność podmiotu i aktywność konkretnej działalności podmiotu. Mianowicie osoba fizyczna może prowadzić do trzech rodzajów działalności jednocześnie(w BIR technicznie określane jako „silosy”).
                                //I) Sprawdzenie aktywności działalności
                                //a) zarejestrowanej w CEIDG(jeśli istnieje) - raport BIR11OsFizycznaDzialalnoscCeidg,
                                //b) rolniczej(jeśli istnieje) - raport BIR11OsFizycznaDzialalnoscRolnicza,
                                //c) tzw.pozostałej(jeśli istnieje) - raport BIR11OsFizycznaDzialalnoscPozostala,
                                DanePobierzPelnyRaportResponse danePobierzPelnyRaportResponse = await uslugaBIRzewnPublClient.DanePobierzPelnyRaportAsync(daneSzukajPodmioty.Regon, "BIR11OsFizycznaDaneOgolne");
                                if (null != danePobierzPelnyRaportResponse && null != danePobierzPelnyRaportResponse.DanePobierzPelnyRaportResult && !string.IsNullOrWhiteSpace(danePobierzPelnyRaportResponse.DanePobierzPelnyRaportResult))
                                {
                                    Models.DanePobierzPelnyRaport.OsFizycznaDaneOgolneList osFizycznaDaneOgolneList = UslugaBIRzewnPubl.DeserializeXml<Models.DanePobierzPelnyRaport.OsFizycznaDaneOgolneList>(danePobierzPelnyRaportResponse.DanePobierzPelnyRaportResult);
                                    if (null != osFizycznaDaneOgolneList && null != osFizycznaDaneOgolneList.Dane && osFizycznaDaneOgolneList.Dane.Count > 0)
                                    {
                                        _log4net.Info(danePobierzPelnyRaportResponse.DanePobierzPelnyRaportResult);
                                        _log4net.Info(osFizycznaDaneOgolneList.Dane.FirstOrDefault().Imie1);
                                    }
                                }
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}, {2}.", Assembly.GetExecutingAssembly().FullName, e.Message, e.StackTrace), e);
                return null;
            }
        }
    }
}