using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Data;
using System.IO;

namespace PortalApiGusApiRegonData.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            try
            {
                string envSpecialFolderAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string name = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                string dbLogOnName = string.Format("{0}_log", name);
                string directoryPath = Path.Combine(envSpecialFolderAppData, name);
                string dbFilename = Path.Combine(envSpecialFolderAppData, name, string.Format("{0}.mdf", name));
                string dbLogOnFilename = Path.Combine(envSpecialFolderAppData, name, string.Format("{0}.ldf", dbLogOnName));
                if (!Directory.Exists(directoryPath))
                {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
