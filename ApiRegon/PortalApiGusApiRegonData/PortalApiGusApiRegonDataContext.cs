using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.IO;

namespace PortalApiGusApiRegonData
{
    public partial class PortalApiGusApiRegonDataContext
    {
        /// <summary>
        /// Stała - nazwa połączenia do bazy danych
        /// </summary>
        private const string connectionStringName = "PortalApiGusApiRegonData";
        /// <summary>
        /// Konfiguracja zaszyfrowanego połączenia do bazy danych kontekstu Models.AdvertisingCampaignContext
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
        /// Konfiguracja zaszyfrowanego połączenia do bazy danych kontekstu Models.AdvertisingCampaignContext
        /// </summary>
        /// <param name="connectionStringName"></param>
        /// <returns></returns>
        public static string GetConnectionString(string connectionStringName)
        {
            try
            {
                string connectionString = null;
                string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                IConfigurationBuilder configurationBuilder = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                IConfigurationRoot configurationRoot = configurationBuilder.Build();
                connectionString = configurationRoot.GetConnectionString(connectionStringName);
                if (null == connectionString || string.IsNullOrWhiteSpace(connectionString))
                {
                    configurationBuilder = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile(string.Format("{0}.json", assemblyName), optional: true, reloadOnChange: true);
                    configurationRoot = configurationBuilder.Build();
                    connectionString = configurationRoot.GetConnectionString(connectionStringName);
                }
                if (!string.IsNullOrWhiteSpace(connectionString) && connectionString.Contains("%AppDomain.CurrentDomain.BaseDirectory%"))
                {
                    connectionString = connectionString.Replace("%AppDomain.CurrentDomain.BaseDirectory%", AppDomain.CurrentDomain.BaseDirectory);
                }
                if (!string.IsNullOrWhiteSpace(connectionString) && connectionString.Contains("%Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)%"))
                {
                    connectionString = connectionString.Replace("%Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)%", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
                }
                if (!string.IsNullOrWhiteSpace(connectionString) && connectionString.Contains("%System.Reflection.Assembly.GetExecutingAssembly().GetName().Name%"))
                {
                    connectionString = connectionString.Replace("%System.Reflection.Assembly.GetExecutingAssembly().GetName().Name%", System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);
                }
                return connectionString;
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("Sql command error: {0}, {1}.", e.Message, e.StackTrace));
                return null;
            }
        }
        /// <summary>
        /// Konfiguracja zaszyfrowanego połączenia do bazy danych kontekstu Models.AdvertisingCampaignContext
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
        /// Konfiguracja zaszyfrowanego połączenia do bazy danych kontekstu Models.AdvertisingCampaignContext
        /// </summary>
        /// <param name="connectionStringName"></param>
        /// <returns></returns>
        public static string GetDecryptConnectionString(string connectionStringName)
        {
            try
            {
                string connectionString = null;
                string rsaFileContent = EncryptDecrypt.EncryptDecrypt.GetRsaFileContent();
                string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                IConfigurationBuilder configurationBuilder = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                IConfigurationRoot configurationRoot = configurationBuilder.Build();
                connectionString = EncryptDecrypt.EncryptDecrypt.DecryptString(configurationRoot.GetConnectionString(connectionStringName), rsaFileContent);
                if (null == connectionString || string.IsNullOrWhiteSpace(connectionString))
                {
                    configurationBuilder = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile(string.Format("{0}.json", assemblyName), optional: true, reloadOnChange: true);
                    configurationRoot = configurationBuilder.Build();
                    connectionString = EncryptDecrypt.EncryptDecrypt.DecryptString(configurationRoot.GetConnectionString(connectionStringName), rsaFileContent);
                }
                if (!string.IsNullOrWhiteSpace(connectionString) && connectionString.Contains("%AppDomain.CurrentDomain.BaseDirectory%"))
                {
                    connectionString = connectionString.Replace("%AppDomain.CurrentDomain.BaseDirectory%", AppDomain.CurrentDomain.BaseDirectory);
                }
                if (!string.IsNullOrWhiteSpace(connectionString) && connectionString.Contains("%Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)%"))
                {
                    connectionString = connectionString.Replace("%Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)%", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
                }
                if (!string.IsNullOrWhiteSpace(connectionString) && connectionString.Contains("%System.Reflection.Assembly.GetExecutingAssembly().GetName().Name%"))
                {
                    connectionString = connectionString.Replace("%System.Reflection.Assembly.GetExecutingAssembly().GetName().Name%", System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);
                }
                return connectionString;
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("Sql command error: {0}, {1}.", e.Message, e.StackTrace));
                return null;
            }
        }
        /// <summary>
        /// Konfiguracja zaszyfrowanego połączenia do bazy danych kontekstu Models.AdvertisingCampaignContext
        /// </summary>
        /// <returns></returns>
        public static DbContextOptions<Data.PortalApiGusApiRegonDataDbContext> GetDecryptConnectionOptionsBuilder()
        {
            try
            {
                DbContextOptionsBuilder dbContextOptionsBuilder = new DbContextOptionsBuilder<Data.PortalApiGusApiRegonDataDbContext>();
                dbContextOptionsBuilder.UseSqlServer(GetDecryptConnectionString());
                return (DbContextOptions<Data.PortalApiGusApiRegonDataDbContext>)dbContextOptionsBuilder.Options;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Konfiguracja połączenia do bazy danych kontekstu Models.AdvertisingCampaignContext
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public static DbContextOptions<Data.PortalApiGusApiRegonDataDbContext> GetConnectionOptionsBuilder(string connectionString)
        {
            try
            {
                DbContextOptionsBuilder dbContextOptionsBuilder = new DbContextOptionsBuilder<Data.PortalApiGusApiRegonDataDbContext>();
                dbContextOptionsBuilder.UseSqlServer(connectionString);
                return (DbContextOptions<Data.PortalApiGusApiRegonDataDbContext>)dbContextOptionsBuilder.Options;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Konfiguracja połączenia do bazy danych kontekstu Models.AdvertisingCampaignContext
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public static DbContextOptions<Data.PortalApiGusApiRegonDataDbContext> GetConnectionOptionsBuilder()
        {
            try
            {
                DbContextOptionsBuilder dbContextOptionsBuilder = new DbContextOptionsBuilder<Data.PortalApiGusApiRegonDataDbContext>();
                dbContextOptionsBuilder.UseSqlServer(GetConnectionString());
                return (DbContextOptions<Data.PortalApiGusApiRegonDataDbContext>)dbContextOptionsBuilder.Options;
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
        /// <summary>
        /// Create local MDF database in Environment.SpecialFolder.ApplicationData location use System.Reflection.Assembly.GetExecutingAssembly().GetName().Name DB name
        /// </summary>
        public static void DatabaseMdfCreate()
        {
            try
            {
                string envSpecialFolderAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string name = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                string dbLogOnName = string.Format("{0}_log", name);
                string directoryPath = Path.Combine(envSpecialFolderAppData, name);
                string dbFilename = Path.Combine(envSpecialFolderAppData, name, string.Format("{0}.mdf", name));
                string dbLogOnFilename = Path.Combine(envSpecialFolderAppData, name, string.Format("{0}.ldf", dbLogOnName));
                Console.WriteLine(directoryPath);
                if (!Directory.Exists(directoryPath))
                {
                    Console.WriteLine(directoryPath);
                    Directory.CreateDirectory(directoryPath);
                }
                if (!File.Exists(dbFilename))
                {
                    SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB; Integrated Security=True");
                    string sql = $"" +
                        $"CREATE DATABASE {name} ON PRIMARY " +
                        $"(" +
                            $"NAME = {name}, " +
                            $"FILENAME = '{dbFilename}', " +
                            $"SIZE = 8MB," +
                            $"MAXSIZE = 131072MB," +
                            $"FILEGROWTH = 1%" +
                        $") " +
                        $"LOG ON" +
                        $"(" +
                            $"NAME = {dbLogOnName}, " +
                            $"FILENAME = '{dbLogOnFilename}', " +
                            $"SIZE = 8MB, " +
                            $"MAXSIZE = 8192MB, " +
                            $"FILEGROWTH = 1%" +
                        $")";
                    SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                    //IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
                    //BEGIN
                    //    CREATE TABLE[__EFMigrationsHistory](
                    //        [MigrationId] nvarchar(150) NOT NULL,
                    //        [ProductVersion] nvarchar(32) NOT NULL,
                    //        CONSTRAINT[PK___EFMigrationsHistory] PRIMARY KEY([MigrationId])
                    //);
                    //END;
                    //GO
                    //INSERT INTO[__EFMigrationsHistory]([MigrationId], [ProductVersion])
                    //VALUES(N'20200811211843_Init', N'3.1.7');
                    //GO
                    try
                    {
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        Console.WriteLine(string.Format("Sql command {0} ok.", sql));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(string.Format("Sql command error: {0}, {1}, {2}.", sql, e.Message, e.StackTrace));
                    }
                    finally
                    {
                        if (sqlConnection.State == ConnectionState.Open)
                        {
                            sqlConnection.Close();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("Sql command error: {0}, {1}.", e.Message, e.StackTrace));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public static void DatabaseMdfDrop()
        {
            try
            {
                string envSpecialFolderAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string name = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                string dbLogOnName = string.Format("{0}_log", name);
                string directoryPath = Path.Combine(envSpecialFolderAppData, name);
                string dbFilename = Path.Combine(envSpecialFolderAppData, name, string.Format("{0}.mdf", name));
                string dbLogOnFilename = Path.Combine(envSpecialFolderAppData, name, string.Format("{0}.ldf", dbLogOnName));
                SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB; Integrated Security=True");
                string sql = $"DROP DATABASE {name}";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                try
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    Console.WriteLine(string.Format("Sql command {0} ok.", sql));
                }
                catch (Exception e)
                {
                    Console.WriteLine(string.Format("Sql command error: {0}, {1}, {2}.", sql, e.Message, e.StackTrace));
                }
                finally
                {
                    if (sqlConnection.State == ConnectionState.Open)
                    {
                        sqlConnection.Close();
                    }
                }
                try
                {
                    if (File.Exists(dbFilename))
                    {
                        File.Delete(dbFilename);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(string.Format("Sql command error: {0}, {1}.", e.Message, e.StackTrace));
                }
                try
                {
                    if (File.Exists(dbLogOnFilename))
                    {
                        File.Delete(dbLogOnFilename);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(string.Format("Sql command error: {0}, {1}.", e.Message, e.StackTrace));
                }
                try
                {
                    if (Directory.Exists(directoryPath))
                    {
                        Directory.Delete(directoryPath);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(string.Format("Sql command error: {0}, {1}.", e.Message, e.StackTrace));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("Sql command error: {0}, {1}.", e.Message, e.StackTrace));
            }
        }
    }
}