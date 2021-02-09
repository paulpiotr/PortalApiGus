using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Reflection;
using NetAppCommon.AppSettings.Models;
using NetAppCommon.AppSettings.Models.Base;
using Newtonsoft.Json;

namespace PortalApiGusApiRegonData.Models
{
    #region public partial class AppSettings : AppSettingsBaseModel
    /// <summary>
    /// Klasa modelu ustawień aplikacji ApiWykazuPodatnikowVatData
    /// The settings model class of the ApiWykazuPodatnikowVatData
    /// </summary>
    [NotMapped]
    public partial class AppSettings : AppSettingsBaseModel
    {
        ///Important !!!
        #region AppSettingsModel()
        public AppSettings()
        {
            try
            {
                var memoryCacheProvider = NetAppCommon.Helpers.Cache.MemoryCacheProvider.GetInstance();
                var filePathKey = string.Format("{0}{1}", MethodBase.GetCurrentMethod()?.DeclaringType.FullName, ".FilePath");
                var filePath = memoryCacheProvider.Get(filePathKey);
                if (null == filePath)
                {
                    AppSettingsRepository.MergeAndCopyToUserDirectory(this);
                    memoryCacheProvider.Put(filePathKey, FilePath, TimeSpan.FromDays(1));
                }
                if (null != UserProfileDirectory && null != FileName)
                {
                    FilePath = (string)(filePath ?? Path.Combine(UserProfileDirectory, FileName));
                }
                var useGlobalDatabaseConnectionSettingsKey = string.Format("{0}{1}", MethodBase.GetCurrentMethod()?.DeclaringType.FullName, ".UseGlobalDatabaseConnectionSettings");
                var useGlobalDatabaseConnectionSettings = memoryCacheProvider.Get(useGlobalDatabaseConnectionSettingsKey);
                if (null == useGlobalDatabaseConnectionSettings)
                {
                    memoryCacheProvider.Put(useGlobalDatabaseConnectionSettingsKey, UseGlobalDatabaseConnectionSettings, TimeSpan.FromDays(1));
                    if (UseGlobalDatabaseConnectionSettings)
                    {
                        var appSettingsModel = new AppSettingsModel();
                        ConnectionString = appSettingsModel.ConnectionString;
                        AppSettingsRepository.MergeAndSave(this);
                    }
                }
            }
            catch (Exception e)
            {
                _log4Net.Error($"\n{e.GetType()}\n{e.InnerException?.GetType()}\n{e.Message}\n{e.StackTrace}\n", e);
            }
        }
        #endregion

        ///Important !!!
        #region public static AppSettingsBaseModel GetInstance()
        /// <summary>
        /// Pobierz statyczną referencję do instancji AppSettingsBaseModel
        /// Get a static reference to the AppSettingsBaseModel instance
        /// </summary>
        /// <returns>
        /// Statyczna referencja do instancji AppSettingsBaseModel
        /// A static reference to the AppSettingsBaseModel instance
        /// </returns>
        public static AppSettings GetInstance()
        {
            return new AppSettings();
        }
        #endregion

        #region private readonly log4net.ILog log4net
        /// <summary>
        /// Instancja do klasy Log4netLogger
        /// Instance to Log4netLogger class
        /// </summary>
        private readonly log4net.ILog _log4Net = Log4netLogger.Log4netLogger.GetLog4netInstance(MethodBase.GetCurrentMethod()?.DeclaringType);
        #endregion

        #region protected new string _fileName = FILENAME;
#if DEBUG
        protected const string FILENAME = "portalapigusapiregondata.appsettings.json";
#else
        protected const string FILENAME = "portalapigusapiregondata.appsettings.json";
#endif

        protected new string _fileName = FILENAME;

        public override string FileName
        {
            get => _fileName;
            protected set
            {
                if (value != _fileName)
                {
                    _fileName = value;
                    OnPropertyChanged("FileName");
                }
            }
        }
        #endregion

        #region protected new string _connectionStringName = CONNECTIONSTRINGNAME;
#if DEBUG
        protected const string CONNECTIONSTRINGNAME = "PortalApiGusApiRegonDataDbContext";
#else
        protected const string CONNECTIONSTRINGNAME = "PortalApiGusApiRegonDataDbContext";
#endif

        protected new string _connectionStringName = CONNECTIONSTRINGNAME;

        public override string ConnectionStringName
        {
            get => _connectionStringName;
            set
            {
                if (value != _connectionStringName)
                {
                    _connectionStringName = value;
                }
            }
        }
        #endregion

        #region private string _portalApiGusKey; public string PortalApiGusKey

        private string _portalApiGusKey;

        /// <summary>
        /// Klucz api do serwisu https://wyszukiwarkaregon.stat.gov.pl/wsBIR/wsdl/UslugaBIRzewnPubl-ver11-prod.wsdl więcej na https://api.stat.gov.pl/Home/RegonApi
        /// API key to the website https://wyszukikujeregon.stat.gov.pl/wsBIR/wsdl/UslugaBIRzewnPubl-ver11-prod.wsdl more at https://api.stat.gov.pl/Home/RegonApi
        /// </summary>
        [JsonProperty(nameof(PortalApiGusKey))]
        [Display(Name = "Klucz api do serwisu", Prompt = "Wpisz klucz api do serwisu", Description = "Klucz api do serwisu")]
        [Required]
        public string PortalApiGusKey
        {
            get
            {
                if (null == _portalApiGusKey)
                {
                    _portalApiGusKey = AppSettingsRepository.GetValue<string>(this, nameof(PortalApiGusKey));
                }
                return _portalApiGusKey;
            }
            set
            {
                if (value != _portalApiGusKey)
                {
                    _portalApiGusKey = value;
                    OnPropertyChanged(nameof(PortalApiGusKey));
                }
            }
        }
        #endregion
    }
    #endregion
}
