using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Reflection;

namespace PortalApiGusApiRegonData
{
    public partial class PortalApiGusApiRegonDataConfiguration
    {
        /// <summary>
        /// log4net
        /// </summary>
        private static readonly log4net.ILog _log4net = Log4netLogger.Log4netLogger.GetLog4netInstance(MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// Pobierz konfigurację IConfigurationRoot
        /// </summary>
        /// <returns>IConfigurationRoot</returns>
        public static IConfigurationRoot GetConfigurationRoot()
        {
            try
            {
                string assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
                if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json")))
                {
                    IConfigurationBuilder configurationBuilder = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                    IConfigurationRoot configurationRoot = configurationBuilder.Build();
                    return configurationRoot;
                }
                else if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format("{0}.json", assemblyName))))
                {
                    IConfigurationBuilder configurationBuilder = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile(string.Format("{0}.json", assemblyName), optional: true, reloadOnChange: true);
                    IConfigurationRoot configurationRoot = configurationBuilder.Build();
                    return configurationRoot;
                }
                return null;
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}, {2}.", Assembly.GetExecutingAssembly().FullName, e.Message, e.StackTrace), e);
                return null;
            }
        }
        /// <summary>
        /// Wyszukaj ustawienia aplikacji w pliku appsettings.json lub w pliku {Assembly.GetExecutingAssembly().GetName().Name}
        /// </summary>
        /// <typeparam name="T">Typ parametru</typeparam>
        /// <param name="key">Szukany klucz</param>
        /// <returns>Wartość ustawień typu T</returns>
        public static T GetValue<T>(string key)
        {
            try
            {
                return (T)Convert.ChangeType(GetConfigurationRoot().GetValue<T>(key), typeof(T));
            }
            catch (Exception)
            {
                return (T)Convert.ChangeType(null, typeof(T));
            }
        }
    }
}