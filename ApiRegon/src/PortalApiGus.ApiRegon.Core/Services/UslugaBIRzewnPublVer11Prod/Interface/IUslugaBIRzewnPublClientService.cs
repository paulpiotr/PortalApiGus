#region using

using System;
using System.Threading.Tasks;
using NetAppCommon.Logging.ClientMessageInspector.Repositories;
using UslugaBIRzewnPublVer11Prod;

#endregion

namespace PortalApiGus.ApiRegon.Core.Services.UslugaBIRzewnPublVer11Prod.Interface
{
    public interface IUslugaBiRzewnPublClientService
    {
        /// <summary>
        ///     Pobierz referencję klienta usługi UslugaBIRzewnPublClient
        ///     Get the client reference of the ServiceBIRzewnPublClient service
        ///     <para>
        ///         Jeśli klucz nie jest ustawiony pobierana jest wartość z ustawień aplikacji
        ///         If the key is not set, the value is taken from the application settings
        ///     </para>
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
        /// <returns>
        ///     Referencja klienta usługi UslugaBIRzewnPublClient lub null
        ///     Client reference of the service ServiceBIRzewnPublClient or null
        /// </returns>
        UslugaBIRzewnPublClient GetClient(string pKluczUzytkownika = null, bool canTrackRequests = false);

        /// <summary>
        ///     Pobierz referencję klienta usługi UslugaBIRzewnPublClient asynchronicznie
        ///     Get the client reference of the ServiceBIRzewnPublClient service asynchronously
        ///     <para>
        ///         Jeśli klucz nie jest ustawiony pobierana jest wartość z ustawień aplikacji
        ///         If the key is not set, the value is taken from the application settings
        ///     </para>
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
        /// <returns>
        ///     Referencja klienta usługi UslugaBIRzewnPublClient lub null
        ///     Client reference of the service ServiceBIRzewnPublClient or null
        /// </returns>
        Task<UslugaBIRzewnPublClient> GetClientAsync(string pKluczUzytkownika = null, bool canTrackRequests = false);

        /// <summary>
        ///     Zaloguj do serwisu usługi UslugaBIRzewnPublClient
        ///     Log in to the website of the UslugaBIRzewnPublClient service
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
        /// <returns>
        ///     Identyfikator sesji jako string lub null
        ///     Session id as string or null
        /// </returns>
        string Zaloguj(string pKluczUzytkownika = null);

        /// <summary>
        ///     Zaloguj do serwisu usługi UslugaBIRzewnPublClient asynchronicznie
        ///     Log in to the website of the UslugaBIRzewnPublClient service asynchronously
        /// </summary>
        /// <param name="pKluczUzytkownika">
        ///     Klucz użytkownika jako string lub null
        ///     User key as string or null
        ///     <para>
        ///         Jeśli klucz nie jest ustawiony pobierana jest wartość z ustawień aplikacji
        ///         If the key is not set, the value is taken from the application settings
        ///     </para>
        /// </param>
        /// <returns>
        ///     Identyfikator sesji jako string lub null
        ///     Session id as string or null
        /// </returns>
        Task<string> ZalogujAsync(string pKluczUzytkownika = null);

        /// <summary>
        ///     Wyloguj z serwisu usługi UslugaBIRzewnPublClient
        ///     Log out of the UslugaBIRzewnPublClient service
        /// </summary>
        /// <param name="pIdentyfikatorSesji">
        ///     Identyfikator sesji jako string
        ///     The session id as a string
        /// </param>
        /// <returns>
        ///     Prawda jeśli udane wylogowanie, przeciwnie fałsz
        ///     True if successful logout, otherwise false
        /// </returns>
        bool Wyloguj(string pIdentyfikatorSesji = null);

        /// <summary>
        ///     Wyloguj z serwisu usługi UslugaBIRzewnPublClient asynchronicznie
        ///     Log out of the UslugaBIRzewnPublClient service asynchronously
        /// </summary>
        /// <param name="pIdentyfikatorSesji">
        ///     Identyfikator sesji jako string
        ///     The session id as a string
        /// </param>
        /// <returns>
        ///     Prawda jeśli udane wylogowanie, przeciwnie fałsz
        ///     True if successful logout, otherwise false
        /// </returns>
        Task<bool> WylogujAsync(string pIdentyfikatorSesji = null);

        /// <summary>
        ///     Pobierz unikalny identyfikator rozproszonej pamięci podręcznej
        ///     Get a unique identifier for the distributed cache
        /// </summary>
        /// <returns>
        ///     Unikalny identyfikator pamięci podręcznej
        ///     Unique identifier for the cache
        /// </returns>
        public Guid GetGuid();

        /// <summary>
        ///     Pobierz instancję repozytorium pamięci rozproszonej
        ///     Get an instance of the distributed storage repository
        /// </summary>
        /// <returns>
        ///     Instancja repozytorium pamięci rozproszonej
        ///     Instance of the distributed memory repository
        /// </returns>
        public DistributedCacheRepository GetDistributedCacheRepository();
    }
}
