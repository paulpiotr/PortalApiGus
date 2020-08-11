using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace PortalApiGusApiRegonData
{
    internal class PortalApiGusApiRegonDataContext
    {
        /// <summary>
        /// Stała - nazwa połączenia do bazy danych
        /// </summary>
        private const string connectionStringName = "PortalApiGusApiRegonDataContext";
        /// <summary>
        /// Konfiguracja zaszyfrowanego połączenia do bazy danych kontekstu Models.PortalApiGusApiRegonDataContext
        /// </summary>
        /// <returns></returns>
        public static string GetConnectionString()
        {
            try
            {
                return GetConnectionString(connectionStringName);
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Konfiguracja zaszyfrowanego połączenia do bazy danych kontekstu Models.PortalApiGusApiRegonDataContext
        /// </summary>
        /// <param name="connectionStringName"></param>
        /// <returns></returns>
        public static string GetConnectionString(string connectionStringName)
        {
            try
            {
                IConfigurationBuilder configurationBuilder = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                IConfigurationRoot configurationRoot = configurationBuilder.Build();
                string connectionString = configurationRoot.GetConnectionString(connectionStringName);
                if (!string.IsNullOrWhiteSpace(connectionString) && connectionString.Contains("%AppDomain.CurrentDomain.BaseDirectory%"))
                {
                    return connectionString.Replace("%AppDomain.CurrentDomain.BaseDirectory%", AppDomain.CurrentDomain.BaseDirectory);
                }
                else if (!string.IsNullOrWhiteSpace(connectionString))
                {
                    return connectionString;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Konfiguracja zaszyfrowanego połączenia do bazy danych kontekstu Models.PortalApiGusApiRegonDataContext
        /// </summary>
        /// <returns></returns>
        public static string GetDecryptConnectionString()
        {
            try
            {
                return GetDecryptConnectionString(connectionStringName);
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Konfiguracja zaszyfrowanego połączenia do bazy danych kontekstu Models.PortalApiGusApiRegonDataContext
        /// </summary>
        /// <param name="connectionStringName"></param>
        /// <returns></returns>
        public static string GetDecryptConnectionString(string connectionStringName)
        {
            try
            {
                string rsaFileContent = EncryptDecrypt.EncryptDecrypt.GetRsaFileContent();
                IConfigurationBuilder configurationBuilder = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                IConfigurationRoot configurationRoot = configurationBuilder.Build();
                string connectionString = configurationRoot.GetConnectionString(connectionStringName);
                connectionString = EncryptDecrypt.EncryptDecrypt.DecryptString(connectionString, rsaFileContent);
                if (!string.IsNullOrWhiteSpace(connectionString) && connectionString.Contains("%AppDomain.CurrentDomain.BaseDirectory%"))
                {
                    return connectionString.Replace("%AppDomain.CurrentDomain.BaseDirectory%", AppDomain.CurrentDomain.BaseDirectory);
                }
                else if (!string.IsNullOrWhiteSpace(connectionString))
                {
                    return connectionString;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Konfiguracja zaszyfrowanego połączenia do bazy danych kontekstu Models.PortalApiGusApiRegonDataContext
        /// </summary>
        /// <returns></returns>
        public static DbContextOptions<Models.PortalApiGusApiRegonDataContext> GetDecryptConnectionOptionsBuilder()
        {
            try
            {
                DbContextOptionsBuilder dbContextOptionsBuilder = new DbContextOptionsBuilder<Models.PortalApiGusApiRegonDataContext>();
                dbContextOptionsBuilder.UseSqlServer(GetDecryptConnectionString());
                return (DbContextOptions<Models.PortalApiGusApiRegonDataContext>)dbContextOptionsBuilder.Options;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Konfiguracja zaszyfrowanego połączenia do bazy danych kontekstu Models.PortalApiGusApiRegonDataContext
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public static DbContextOptions<Models.PortalApiGusApiRegonDataContext> GetConnectionOptionsBuilder(string connectionString)
        {
            try
            {
                DbContextOptionsBuilder dbContextOptionsBuilder = new DbContextOptionsBuilder<Models.PortalApiGusApiRegonDataContext>();
                dbContextOptionsBuilder.UseSqlServer(connectionString);
                return (DbContextOptions<Models.PortalApiGusApiRegonDataContext>)dbContextOptionsBuilder.Options;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Testowanie połączenia SQL
        /// </summary>
        /// <param name="connectionString">The sqlConnection string</param>
        /// <returns>true if the sqlConnection is opened</returns>
        public static bool IsServerConnected(string connectionString)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    try
                    {
                        sqlConnection.Close();
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }
    }
}
