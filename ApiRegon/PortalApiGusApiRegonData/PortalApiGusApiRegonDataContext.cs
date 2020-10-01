using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.IO;
using System.Reflection;

namespace PortalApiGusApiRegonData
{
    public partial class PortalApiGusApiRegonDataContext
    {
        /// <summary>
        /// Log4 Net Logger
        /// </summary>
        private static readonly log4net.ILog _log4net = Log4netLogger.Log4netLogger.GetLog4netInstance(MethodBase.GetCurrentMethod().DeclaringType);

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
                _log4net.Error(string.Format("{0}, {1}.", e.Message, e.StackTrace), e);
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
                    _log4net.Error(string.Format("{0}, {1}.", e.Message, e.StackTrace), e);
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
                    _log4net.Error(string.Format("{0}, {1}.", e.Message, e.StackTrace), e);
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
                    _log4net.Error(string.Format("{0}, {1}.", e.Message, e.StackTrace), e);
                }
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}.", e.Message, e.StackTrace), e);
            }
        }
    }
}