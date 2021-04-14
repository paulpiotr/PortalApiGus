#region using

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Reflection;
using log4net;
using NetAppCommon.AppSettings.Models.Base;
using NetAppCommon.Helpers.Cache;
using NetAppCommon.Logging;

#endregion

namespace PortalApiGus.ApiRegon.DataBase.Models
{
    #region public partial class AppSettings : AppSettingsBaseModel

    /// <summary>
    ///     Klasa modelu ustawień
    ///     The settings model class
    /// </summary>
    [NotMapped]
    public sealed class AppSettings : AppSettingsWithDatabase
    {
        ///Important !!!

        #region AppSettingsModel()

        public AppSettings()
        {
            try
            {
                var memoryCacheProvider = MemoryCacheProvider.GetInstance();
                var filePathKey = $"{MethodBase.GetCurrentMethod()?.DeclaringType?.FullName}.FilePath";
                object filePath = memoryCacheProvider.Get(filePathKey);
                if (null == filePath)
                {
                    AppSettingsRepository?.MergeAndCopyToUserDirectory(this);
                    memoryCacheProvider.Put(filePathKey, FilePath, TimeSpan.FromDays(1));
                }

                if (null != UserProfileDirectory && null != FileName)
                {
                    FilePath = (string)(filePath ?? Path.Combine(UserProfileDirectory, FileName));
                }

                var useGlobalDatabaseConnectionSettingsKey =
                    $"{MethodBase.GetCurrentMethod()?.DeclaringType?.FullName}.UseGlobalDatabaseConnectionSettings";
                object useGlobalDatabaseConnectionSettings =
                    memoryCacheProvider.Get(useGlobalDatabaseConnectionSettingsKey);
                if (null == useGlobalDatabaseConnectionSettings)
                {
                    memoryCacheProvider.Put(useGlobalDatabaseConnectionSettingsKey, UseGlobalDatabaseConnectionSettings,
                        TimeSpan.FromDays(1));
                    if (UseGlobalDatabaseConnectionSettings)
                    {
                        var appSettingsModel = new NetAppCommon.AppSettings.Models.AppSettings();
                        ConnectionString = appSettingsModel.ConnectionString;
                        AppSettingsRepository?.MergeAndSave(this);
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
        ///     Pobierz statyczną referencję do instancji AppSettingsBaseModel
        ///     Get a static reference to the AppSettingsBaseModel instance
        /// </summary>
        /// <returns>
        ///     Statyczna referencja do instancji AppSettingsBaseModel
        ///     A static reference to the AppSettingsBaseModel instance
        /// </returns>
        public static AppSettings GetInstance() => new();

        #endregion

        #region private readonly log4net.ILog log4net

        /// <summary>
        ///     Instancja do klasy Log4netLogger
        ///     Instance to Log4netLogger class
        /// </summary>
        private readonly ILog _log4Net =
            Log4NetLogger.GetLog4NetInstance(MethodBase.GetCurrentMethod()?.DeclaringType);

        #endregion

        #region private string _fileName = Filename; public override string FileName

#if DEBUG
        private const string Filename = "portalapigus.apiregon.database.json";
#else
        private const string Filename = "portalapigus.apiregon.database.json";
#endif

        private string _fileName = Filename;

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

        #region private string _connectionStringName = Connectionstringname; public override string ConnectionStringName

#if DEBUG
        private const string Connectionstringname = "PortalApiGusApiRegonDataBase";
#else
        private const string Connectionstringname = "PortalApiGusApiRegonDataBase";
#endif

        private string _connectionStringName = Connectionstringname;

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
    }

    #endregion
}
