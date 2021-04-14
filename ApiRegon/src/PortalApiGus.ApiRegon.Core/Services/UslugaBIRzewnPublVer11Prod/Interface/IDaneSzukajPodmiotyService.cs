#region using

using System.Collections.Generic;
using System.Threading.Tasks;
using PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport;
using PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmioty;

#endregion

namespace PortalApiGus.ApiRegon.Core.Services.UslugaBIRzewnPublVer11Prod.Interface
{
    public interface IDaneSzukajPodmiotyService : IUslugaBiRzewnPublClientService
    {
        /// <summary>
        ///     Wyszukaj podmiot i pobierz raport podstawowy z serwisu UslugaBIRzewnPublVer11Prod
        ///     Search for the entity and download the basic report from UslugaBIRzewnPublVer11Prod
        /// </summary>
        /// <param name="pKluczUzytkownika">
        ///     Klucz użytkownika jako string lub null
        ///     User key as string or null
        ///     <para>
        ///         Jeśli klucz nie jest ustawiony pobierana jest wartość z ustawień aplikacji
        ///         If the key is not set, the value is taken from the application settings
        ///     </para>
        /// </param>
        /// <param name="canTrackRequests">
        ///     Czy można śledzić żądanie jako bool
        ///     Can I trace the request as a bool
        ///     <para>
        ///         Włącza śledzenie żądań usługi, zapis do bazy danych, log
        ///         Enables tracing of service requests, writing to the database, log
        ///     </para>
        /// </param>
        /// <param name="krs">
        ///     Numer krs jako string lub null
        ///     The krs number as a string or null
        /// </param>
        /// <param name="krsy">
        ///     Numery krs rozdzielone separatorem jako string lub null
        ///     Krs numbers separated by a separator as string or null
        /// </param>
        /// <param name="nip">
        ///     Numer nip jako string lub null
        ///     Tax ID number as string or null
        /// </param>
        /// <param name="nipy">
        ///     Numery nip rozdzielone separatorem jako string lub null
        ///     Nip numbers separated by a separator as string or null
        /// </param>
        /// <param name="regon">
        ///     Numer regon 9 lub 14 znaków jako string lub null
        ///     Regon number 9 or 14 characters as string or null
        /// </param>
        /// <param name="regony14Zn">
        ///     Numery regon 14 znakowe rozdzielone separatorem jako string lub null
        ///     Regon 14-character numbers separated by a separator as a string or null
        /// </param>
        /// <param name="regony9Zn">
        ///     Numery regon 9 znaków rozdzielone separatorem jako string lub null
        ///     Regon numbers 9 characters separated by a separator as a string or null
        /// </param>
        /// <returns>
        ///     String
        ///     String
        ///     <para>
        ///         Zwracany String w formacie XML
        ///         Returned String in XML format
        ///     </para>
        /// </returns>
        public string DaneSzukajPodmiotyAsXmlString(
            string pKluczUzytkownika = null, bool canTrackRequests = false, bool canLogout = true, string krs = null,
            string krsy = null,
            string nip = null, string nipy = null,
            string regon = null, string regony14Zn = null, string regony9Zn = null);

        /// <summary>
        ///     Wyszukaj podmiot i pobierz raport podstawowy z serwisu UslugaBIRzewnPublVer11Prod asynchronicznie
        ///     Search for the entity and download the basic report from UslugaBIRzewnPublVer11Prod asynchronously
        /// </summary>
        /// <param name="pKluczUzytkownika">
        ///     Klucz użytkownika jako string lub null
        ///     User key as string or null
        ///     <para>
        ///         Jeśli klucz nie jest ustawiony pobierana jest wartość z ustawień aplikacji
        ///         If the key is not set, the value is taken from the application settings
        ///     </para>
        /// </param>
        /// <param name="canTrackRequests">
        ///     Czy można śledzić żądanie jako bool
        ///     Can I trace the request as a bool
        ///     <para>
        ///         Włącza śledzenie żądań usługi, zapis do bazy danych, log
        ///         Enables tracing of service requests, writing to the database, log
        ///     </para>
        /// </param>
        /// <param name="krs">
        ///     Numer krs jako string lub null
        ///     The krs number as a string or null
        /// </param>
        /// <param name="krsy">
        ///     Numery krs rozdzielone separatorem jako string lub null
        ///     Krs numbers separated by a separator as string or null
        /// </param>
        /// <param name="nip">
        ///     Numer nip jako string lub null
        ///     Tax ID number as string or null
        /// </param>
        /// <param name="nipy">
        ///     Numery nip rozdzielone separatorem jako string lub null
        ///     Nip numbers separated by a separator as string or null
        /// </param>
        /// <param name="regon">
        ///     Numer regon 9 lub 14 znaków jako string lub null
        ///     Regon number 9 or 14 characters as string or null
        /// </param>
        /// <param name="regony14Zn">
        ///     Numery regon 14 znakowe rozdzielone separatorem jako string lub null
        ///     Regon 14-character numbers separated by a separator as a string or null
        /// </param>
        /// <param name="regony9Zn">
        ///     Numery regon 9 znaków rozdzielone separatorem jako string lub null
        ///     Regon numbers 9 characters separated by a separator as a string or null
        /// </param>
        /// <returns>
        ///     String
        ///     String
        ///     <para>
        ///         Zwracany String w formacie XML
        ///         Returned String in XML format
        ///     </para>
        /// </returns>
        public Task<string> DaneSzukajPodmiotyAsXmlStringAsync(
            string pKluczUzytkownika = null, bool canTrackRequests = false, bool canLogout = true, string krs = null,
            string krsy = null,
            string nip = null, string nipy = null,
            string regon = null, string regony14Zn = null, string regony9Zn = null);

        /// <summary>
        ///     Wyszukaj podmiot i pobierz raport podstawowy z serwisu UslugaBIRzewnPublVer11Prod
        ///     Search for the entity and download the basic report from UslugaBIRzewnPublVer11Prod
        /// </summary>
        /// <param name="pKluczUzytkownika">
        ///     Klucz użytkownika jako string lub null
        ///     User key as string or null
        ///     <para>
        ///         Jeśli klucz nie jest ustawiony pobierana jest wartość z ustawień aplikacji
        ///         If the key is not set, the value is taken from the application settings
        ///     </para>
        /// </param>
        /// <param name="canTrackRequests">
        ///     Czy można śledzić żądanie jako bool
        ///     Can I trace the request as a bool
        ///     <para>
        ///         Włącza śledzenie żądań usługi, zapis do bazy danych, log
        ///         Enables tracing of service requests, writing to the database, log
        ///     </para>
        /// </param>
        /// <param name="krs">
        ///     Numer krs jako string lub null
        ///     The krs number as a string or null
        /// </param>
        /// <param name="krsy">
        ///     Numery krs rozdzielone separatorem jako string lub null
        ///     Krs numbers separated by a separator as string or null
        /// </param>
        /// <param name="nip">
        ///     Numer nip jako string lub null
        ///     Tax ID number as string or null
        /// </param>
        /// <param name="nipy">
        ///     Numery nip rozdzielone separatorem jako string lub null
        ///     Nip numbers separated by a separator as string or null
        /// </param>
        /// <param name="regon">
        ///     Numer regon 9 lub 14 znaków jako string lub null
        ///     Regon number 9 or 14 characters as string or null
        /// </param>
        /// <param name="regony14Zn">
        ///     Numery regon 14 znakowe rozdzielone separatorem jako string lub null
        ///     Regon 14-character numbers separated by a separator as a string or null
        /// </param>
        /// <param name="regony9Zn">
        ///     Numery regon 9 znaków rozdzielone separatorem jako string lub null
        ///     Regon numbers 9 characters separated by a separator as a string or null
        /// </param>
        /// <returns>
        ///     String
        ///     String
        ///     <para>
        ///         Zwracany String w formacie XML
        ///         Returned String in XML format
        ///     </para>
        /// </returns>
        public DaneSzukajPodmiotyResult DaneSzukajPodmiotyAsObject(
            string pKluczUzytkownika = null, bool canTrackRequests = false, bool canLogout = true, string krs = null,
            string krsy = null,
            string nip = null, string nipy = null,
            string regon = null, string regony14Zn = null, string regony9Zn = null);

        /// <summary>
        ///     Wyszukaj podmiot i pobierz raport podstawowy z serwisu UslugaBIRzewnPublVer11Prod asynchronicznie
        ///     Search for the entity and download the basic report from UslugaBIRzewnPublVer11Prod asynchronously
        /// </summary>
        /// <param name="pKluczUzytkownika">
        ///     Klucz użytkownika jako string lub null
        ///     User key as string or null
        ///     <para>
        ///         Jeśli klucz nie jest ustawiony pobierana jest wartość z ustawień aplikacji
        ///         If the key is not set, the value is taken from the application settings
        ///     </para>
        /// </param>
        /// <param name="canTrackRequests">
        ///     Czy można śledzić żądanie jako bool
        ///     Can I trace the request as a bool
        ///     <para>
        ///         Włącza śledzenie żądań usługi, zapis do bazy danych, log
        ///         Enables tracing of service requests, writing to the database, log
        ///     </para>
        /// </param>
        /// <param name="canLogout">
        ///     Czy można wylogować się z serwisu po zakończeniu działania jako bool
        ///     Is it possible to log out of the website after completing the action as bool
        /// </param>
        /// <param name="krs">
        ///     Numer krs jako string lub null
        ///     The krs number as a string or null
        /// </param>
        /// <param name="krsy">
        ///     Numery krs rozdzielone separatorem jako string lub null
        ///     Krs numbers separated by a separator as string or null
        /// </param>
        /// <param name="nip">
        ///     Numer nip jako string lub null
        ///     Tax ID number as string or null
        /// </param>
        /// <param name="nipy">
        ///     Numery nip rozdzielone separatorem jako string lub null
        ///     Nip numbers separated by a separator as string or null
        /// </param>
        /// <param name="regon">
        ///     Numer regon 9 lub 14 znaków jako string lub null
        ///     Regon number 9 or 14 characters as string or null
        /// </param>
        /// <param name="regony14Zn">
        ///     Numery regon 14 znakowe rozdzielone separatorem jako string lub null
        ///     Regon 14-character numbers separated by a separator as a string or null
        /// </param>
        /// <param name="regony9Zn">
        ///     Numery regon 9 znaków rozdzielone separatorem jako string lub null
        ///     Regon numbers 9 characters separated by a separator as a string or null
        /// </param>
        /// <returns>
        ///     String
        ///     String
        ///     <para>
        ///         Zwracany String w formacie XML
        ///         Returned String in XML format
        ///     </para>
        /// </returns>
        public Task<DaneSzukajPodmiotyResult> DaneSzukajPodmiotyAsObjectAsync(
            string pKluczUzytkownika = null, bool canTrackRequests = false, bool canLogout = true, string krs = null,
            string krsy = null,
            string nip = null, string nipy = null,
            string regon = null, string regony14Zn = null, string regony9Zn = null);

        /// <summary>
        ///     Wyszukaj według numeru KRS
        ///     Find by KRS number
        /// </summary>
        /// <param name="krs">
        ///     Numer KRS jako string
        ///     KRS number as a string
        /// </param>
        /// <param name="pKluczUzytkownika">
        ///     Klucz użytkownika jako string lub null
        ///     User key as string or null
        ///     <para>
        ///         Jeśli klucz nie jest ustawiony pobierana jest wartość z ustawień aplikacji
        ///         If the key is not set, the value is taken from the application settings
        ///     </para>
        /// </param>
        /// <param name="canTrackRequests">
        ///     Czy można śledzić żądanie jako bool
        ///     Can I trace the request as a bool
        ///     <para>
        ///         Włącza śledzenie żądań usługi, zapis do bazy danych, log
        ///         Enables tracing of service requests, writing to the database, log
        ///     </para>
        /// </param>
        /// <param name="canLogout">
        ///     Czy można wylogować się z serwisu po zakończeniu działania jako bool
        ///     Is it possible to log out of the website after completing the action as bool
        /// </param>
        /// <returns>
        ///     Rezultat wyszukiwania jako DaneSzukajPodmiotyResult lub null
        ///     Search result as DataSearch EntitiesResult or null
        /// </returns>
        public DaneSzukajPodmiotyResult FindByKrs(string krs, string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true);

        /// <summary>
        ///     Wyszukaj według numeru KRS asynchronicznie
        ///     Find by KRS number asynchronously
        /// </summary>
        /// <param name="krs">
        ///     Numer KRS jako string
        ///     KRS number as a string
        /// </param>
        /// <param name="pKluczUzytkownika">
        ///     Klucz użytkownika jako string lub null
        ///     User key as string or null
        ///     <para>
        ///         Jeśli klucz nie jest ustawiony pobierana jest wartość z ustawień aplikacji
        ///         If the key is not set, the value is taken from the application settings
        ///     </para>
        /// </param>
        /// <param name="canTrackRequests">
        ///     Czy można śledzić żądanie jako bool
        ///     Can I trace the request as a bool
        ///     <para>
        ///         Włącza śledzenie żądań usługi, zapis do bazy danych, log
        ///         Enables tracing of service requests, writing to the database, log
        ///     </para>
        /// </param>
        /// <param name="canLogout">
        ///     Czy można wylogować się z serwisu po zakończeniu działania jako bool
        ///     Is it possible to log out of the website after completing the action as bool
        /// </param>
        /// <returns>
        ///     Rezultat wyszukiwania jako DaneSzukajPodmiotyResult lub null
        ///     Search result as DataSearch EntitiesResult or null
        /// </returns>
        public Task<DaneSzukajPodmiotyResult> FindByKrsAsync(string krs, string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true);

        /// <summary>
        ///     Wyszukaj według numerów KRS
        ///     Search by KRS numbers
        /// </summary>
        /// <param name="krsy">
        ///     Numery KRS oddzielone separatorem jako string
        ///     KRS numbers separated by a separator as a string
        /// </param>
        /// <param name="pKluczUzytkownika">
        ///     Klucz użytkownika jako string lub null
        ///     User key as string or null
        ///     <para>
        ///         Jeśli klucz nie jest ustawiony pobierana jest wartość z ustawień aplikacji
        ///         If the key is not set, the value is taken from the application settings
        ///     </para>
        /// </param>
        /// <param name="canTrackRequests">
        ///     Czy można śledzić żądanie jako bool
        ///     Can I trace the request as a bool
        ///     <para>
        ///         Włącza śledzenie żądań usługi, zapis do bazy danych, log
        ///         Enables tracing of service requests, writing to the database, log
        ///     </para>
        /// </param>
        /// <param name="canLogout">
        ///     Czy można wylogować się z serwisu po zakończeniu działania jako bool
        ///     Is it possible to log out of the website after completing the action as bool
        /// </param>
        /// <returns>
        ///     Rezultat wyszukiwania jako DaneSzukajPodmiotyResult lub null
        ///     Search result as DataSearch EntitiesResult or null
        /// </returns>
        public DaneSzukajPodmiotyResult FindByKrsy(string krsy, string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true);

        /// <summary>
        ///     Wyszukaj według numerów KRS asynchronicznie
        ///     Search by KRS numbers asynchronously
        /// </summary>
        /// <param name="krsy">
        ///     Numery KRS oddzielone separatorem jako string
        ///     KRS numbers separated by a separator as a string
        /// </param>
        /// <param name="pKluczUzytkownika">
        ///     Klucz użytkownika jako string lub null
        ///     User key as string or null
        ///     <para>
        ///         Jeśli klucz nie jest ustawiony pobierana jest wartość z ustawień aplikacji
        ///         If the key is not set, the value is taken from the application settings
        ///     </para>
        /// </param>
        /// <param name="canTrackRequests">
        ///     Czy można śledzić żądanie jako bool
        ///     Can I trace the request as a bool
        ///     <para>
        ///         Włącza śledzenie żądań usługi, zapis do bazy danych, log
        ///         Enables tracing of service requests, writing to the database, log
        ///     </para>
        /// </param>
        /// <param name="canLogout">
        ///     Czy można wylogować się z serwisu po zakończeniu działania jako bool
        ///     Is it possible to log out of the website after completing the action as bool
        /// </param>
        /// <returns>
        ///     Rezultat wyszukiwania jako DaneSzukajPodmiotyResult lub null
        ///     Search result as DataSearch EntitiesResult or null
        /// </returns>
        public Task<DaneSzukajPodmiotyResult> FindByKrsyAsync(string krsy, string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true);

        /// <summary>
        ///     Wyszukaj według numeru NIP
        ///     Find by NIP number
        /// </summary>
        /// <param name="nip">
        ///     Numer NIP jako string
        ///     NIP number as a string
        /// </param>
        /// <param name="pKluczUzytkownika">
        ///     Klucz użytkownika jako string lub null
        ///     User key as string or null
        ///     <para>
        ///         Jeśli klucz nie jest ustawiony pobierana jest wartość z ustawień aplikacji
        ///         If the key is not set, the value is taken from the application settings
        ///     </para>
        /// </param>
        /// <param name="canTrackRequests">
        ///     Czy można śledzić żądanie jako bool
        ///     Can I trace the request as a bool
        ///     <para>
        ///         Włącza śledzenie żądań usługi, zapis do bazy danych, log
        ///         Enables tracing of service requests, writing to the database, log
        ///     </para>
        /// </param>
        /// <param name="canLogout">
        ///     Czy można wylogować się z serwisu po zakończeniu działania jako bool
        ///     Is it possible to log out of the website after completing the action as bool
        /// </param>
        /// <returns>
        ///     Rezultat wyszukiwania jako DaneSzukajPodmiotyResult lub null
        ///     Search result as DataSearch EntitiesResult or null
        /// </returns>
        public DaneSzukajPodmiotyResult FindByNip(string nip, string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true);

        /// <summary>
        ///     Wyszukaj według numeru NIP asynchronicznie
        ///     Find by NIP number asynchronously
        /// </summary>
        /// <param name="nip">
        ///     Numer NIP jako string
        ///     NIP number as a string
        /// </param>
        /// <param name="pKluczUzytkownika">
        ///     Klucz użytkownika jako string lub null
        ///     User key as string or null
        ///     <para>
        ///         Jeśli klucz nie jest ustawiony pobierana jest wartość z ustawień aplikacji
        ///         If the key is not set, the value is taken from the application settings
        ///     </para>
        /// </param>
        /// <param name="canTrackRequests">
        ///     Czy można śledzić żądanie jako bool
        ///     Can I trace the request as a bool
        ///     <para>
        ///         Włącza śledzenie żądań usługi, zapis do bazy danych, log
        ///         Enables tracing of service requests, writing to the database, log
        ///     </para>
        /// </param>
        /// <param name="canLogout">
        ///     Czy można wylogować się z serwisu po zakończeniu działania jako bool
        ///     Is it possible to log out of the website after completing the action as bool
        /// </param>
        /// <returns>
        ///     Rezultat wyszukiwania jako DaneSzukajPodmiotyResult lub null
        ///     Search result as DataSearch EntitiesResult or null
        /// </returns>
        public Task<DaneSzukajPodmiotyResult> FindByNipAsync(string nip, string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true);

        public DaneSzukajPodmiotyResult FindByRegon(string regon, string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true);

        public Task<DaneSzukajPodmiotyResult> FindByRegonAsync(string regon, string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true);

        public List<DaneSzukajPodmioty> FindByRegony14Zn(string regony14Zn, string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true);

        public Task<List<DaneSzukajPodmioty>> FindByRegony14ZnAsync(string regony14Zn, string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true);

        public List<DaneSzukajPodmioty> FindByRegony9Zn(string regony9Zn, string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true);

        public Task<List<DaneSzukajPodmioty>> FindByRegony9ZnAsync(string regony9Zn, string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true);

        public TModel DanePobierzPelnyRaport<TModel>(string pRegon, string pNazwaRaportu,
            string pKluczUzytkownika = null, bool canTrackRequests = false, bool canLogout = true)
            where TModel : DanePobierzPelnyRaport, new();

        public Task<TModel> DanePobierzPelnyRaportAsync<TModel>(string pRegon, string pNazwaRaportu,
            string pKluczUzytkownika = null, bool canTrackRequests = false, bool canLogout = true)
            where TModel : DanePobierzPelnyRaport, new();

        /// <summary>
        ///     Pobierz dane podmiotu, pełny raport
        ///     Download entity details, full report
        /// </summary>
        /// <typeparam name="TModel">
        ///     Parametr typu zwracanych danych z typu bazowego DanePobierzPelnyRaport
        ///     A parameter of the type of returned data from the base type DanePobierzPelnyRaport
        /// </typeparam>
        /// <param name="daneSzukajPodmioty">
        ///     Model danych DaneSzukajPodmioty
        ///     The data model DaneSzukajPodmioty
        /// </param>
        /// <param name="pRegon">
        ///     Parametr regon jako string
        ///     Regon parameter as a string
        /// </param>
        /// <param name="pNazwaRaportu">
        ///     Parametr nazwa raportu jako string
        ///     Report name parameter as a string
        /// </param>
        /// <param name="pKluczUzytkownika">
        ///     Klucz użytkownika jako string lub null
        ///     User key as string or null
        ///     <para>
        ///         Jeśli klucz nie jest ustawiony pobierana jest wartość z ustawień aplikacji
        ///         If the key is not set, the value is taken from the application settings
        ///     </para>
        /// </param>
        /// <param name="canTrackRequests">
        ///     Czy można śledzić żądanie jako bool
        ///     Can I trace the request as a bool
        ///     <para>
        ///         Włącza śledzenie żądań usługi, zapis do bazy danych, log
        ///         Enables tracing of service requests, writing to the database, log
        ///     </para>
        /// </param>
        /// <param name="canLogout">
        ///     Można wykonać akcję wylogowania jako bool
        ///     You can perform the logout action as bool
        ///     <para>
        ///         Parametr określa, czy wykonać akcję wylogowania z serwisu po zakończeniu procesu
        ///         The parameter defines whether to perform the logout action after the process is finished
        ///     </para>
        /// </param>
        /// <returns>
        ///     Kolekcja elementów TModel jako ICollection lub null
        ///     Collection of TModels as ICollection or null
        /// </returns>
        public ICollection<TModel> DanePobierzPelnyRaport<TModel>(DaneSzukajPodmioty daneSzukajPodmioty,
            string pRegon, string pNazwaRaportu,
            string pKluczUzytkownika = null, bool canTrackRequests = false, bool canLogout = true)
            where TModel : DanePobierzPelnyRaport, new();

        public Task<ICollection<TModel>> DanePobierzPelnyRaportAsync<TModel>(
            DaneSzukajPodmioty daneSzukajPodmioty,
            string pRegon, string pNazwaRaportu,
            string pKluczUzytkownika = null, bool canTrackRequests = false, bool canLogout = true)
            where TModel : DanePobierzPelnyRaport, new();

        public DaneSzukajPodmiotyResult DanePobierzPelnyRaport(string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true, string krs = null, string krsy = null,
            string nip = null, string nipy = null,
            string regon = null, string regony14Zn = null, string regony9Zn = null
        );

        public Task<DaneSzukajPodmiotyResult> DanePobierzPelnyRaportAsync(string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true, string krs = null, string krsy = null,
            string nip = null, string nipy = null,
            string regon = null, string regony14Zn = null, string regony9Zn = null
        );
    }
}
