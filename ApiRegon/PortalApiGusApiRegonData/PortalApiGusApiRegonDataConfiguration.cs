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
        /// Pobierz ścieżkę do pliku konfiguracji 
        /// </summary>
        /// <returns>Ścieżka do pliku konfiguracji AS string</returns>
        public static string GetAppSettingsPath()
        {
            try
            {
                string assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
                if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json")))
                {
                    return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
                }
                else if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format("{0}.json", assemblyName))))
                {
                    return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format("{0}.json", assemblyName));
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
        /// Pobierz objekt konfiguracji ConfigurationRoot
        /// </summary>
        /// <returns>configurationRoot AS IConfigurationRoot</returns>
        public static IConfigurationRoot GetConfigurationRoot()
        {
            try
            {
                string getAppSettingsPath = GetAppSettingsPath();
                if (null != getAppSettingsPath && !string.IsNullOrWhiteSpace(getAppSettingsPath))
                {
                    IConfigurationBuilder configurationBuilder = new ConfigurationBuilder().SetBasePath(Path.GetDirectoryName(getAppSettingsPath)).AddJsonFile(Path.GetFileName(getAppSettingsPath), optional: true, reloadOnChange: true);
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

        /// <summary>
        /// Zapisz ustawienia do pliku ustawień
        /// </summary>
        /// <param name="key">Klucz AS string</param>
        /// <param name="value">Wartość AS T</param>
        /// <param name="appSettingsPath">Ścieżka do pliku AS string</param>
        public static void SetAppSettingValue<T>(string key, T value, string appSettingsPath = null)
        {
            try
            {
                if (appSettingsPath == null)
                {
                    appSettingsPath = GetAppSettingsPath();
                }
                string json = File.ReadAllText(appSettingsPath);
                dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject<Newtonsoft.Json.Linq.JObject>(json);
                jsonObj[key] = value;
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(appSettingsPath, output);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}, {2}.", Assembly.GetExecutingAssembly().FullName, e.Message, e.StackTrace), e);
            }
        }
    }
}