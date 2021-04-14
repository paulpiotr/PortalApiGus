#region using

using System.Collections.Generic;
using System.Threading.Tasks;
using PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport;
using PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmioty;

#endregion

namespace PortalApiGus.ApiRegon.Core.Services.UslugaBIRzewnPublVer11Prod.Interface
{
    public interface IDanePobierzPelnyRaportService : IUslugaBiRzewnPublClientService
    {
        public DaneSzukajPodmiotyResult FindByKrs(string krs, string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true);

        public Task<DaneSzukajPodmiotyResult> FindByKrsAsync(string krs, string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true);

        public DaneSzukajPodmiotyResult FindByKrsy(string krsy, string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true);

        public Task<DaneSzukajPodmiotyResult> FindByKrsyAsync(string krsy, string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true);

        public DaneSzukajPodmiotyResult FindByNip(string nip, string pKluczUzytkownika = null,
            bool canTrackRequests = false, bool canLogout = true);

        public Task<DaneSzukajPodmiotyResult> FindByNipAsync(string nip, string pKluczUzytkownika = null,
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
