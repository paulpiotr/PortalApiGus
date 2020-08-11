using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

/// <summary>
/// Advertising Campaign
/// </summary>
namespace PortalApiGusApiRegonData
{
    /// <summary>
    /// Advertising Campaign
    /// </summary>
    public static class PortalApiGusApiRegonData
    {
        /// <summary>
        /// log4net
        /// </summary>
        private static readonly log4net.ILog _log4net = Log4netLogger.Log4netLogger.GetLog4netInstance(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// String database connection
        /// </summary>
        private static readonly string connectionString = PortalApiGusApiRegonDataContext.GetConnectionString("PortalApiGusApiRegonDataContext");
        /// <summary>
        /// Listing Advertising Campaign
        /// </summary>
        /// <returns>List of Advertising Campaign Model or null</returns>
        public static List<Models.PortalApiGusApiRegonData> Index()
        {
            try
            {
                List<Models.PortalApiGusApiRegonData> advertisingCampaign = new List<Models.PortalApiGusApiRegonData>();
                using (IDbConnection dbConnection = new SqlConnection(connectionString))
                {
                    advertisingCampaign = dbConnection.QueryAsync<Models.PortalApiGusApiRegonData>("SELECT * FROM dbo.PortalApiGusApiRegonData").Result.ToList();
                    if (null != advertisingCampaign && advertisingCampaign.Count > 0)
                    {
                        return advertisingCampaign;
                    }
                }
                return null;
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }
        /// <summary>
        /// Create Async Advertising Campaign
        /// </summary>
        /// <param name="advertisingCampaign">Advertising Campaign Model</param>
        /// <returns>Advertising Campaign Model or null</returns>
        public static async System.Threading.Tasks.Task<Models.PortalApiGusApiRegonData> CreateAsync(Models.PortalApiGusApiRegonData advertisingCampaign)
        {
            try
            {
                using (IDbConnection dbConnection = new SqlConnection(connectionString))
                {
                    advertisingCampaign = await dbConnection.GetAsync<Models.PortalApiGusApiRegonData>(await dbConnection.InsertAsync<Models.PortalApiGusApiRegonData>(advertisingCampaign));
                    if (null != advertisingCampaign)
                    {
                        return advertisingCampaign;
                    }
                }
                return null;
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }
        /// <summary>
        /// Find Async Advertising Campaign
        /// </summary>
        /// <param name="id">Advertising Campaign Id</param>
        /// <returns>Advertising Campaign Model or null</returns>
        public static async System.Threading.Tasks.Task<Models.PortalApiGusApiRegonData> FindAsync(int? id = null)
        {
            try
            {
                using (IDbConnection dbConnection = new SqlConnection(connectionString))
                {
                    Models.PortalApiGusApiRegonData advertisingCampaign = await dbConnection.GetAsync<Models.PortalApiGusApiRegonData>(id);
                    if (null != advertisingCampaign)
                    {
                        return advertisingCampaign;
                    }
                }
                return null;
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }
        /// <summary>
        /// Update Async Advertising Campaign
        /// </summary>
        /// <param name="id">Advertising Campaign Id</param>
        /// <returns>Advertising Campaign Model or null</returns>
        public static async System.Threading.Tasks.Task<Models.PortalApiGusApiRegonData> UpdateAsync(int? id, Models.PortalApiGusApiRegonData advertisingCampaign)
        {
            try
            {
                using (IDbConnection dbConnection = new SqlConnection(connectionString))
                {
                    bool updateAsync = await dbConnection.UpdateAsync(advertisingCampaign);
                    if (updateAsync)
                    {
                        advertisingCampaign = await dbConnection.GetAsync<Models.PortalApiGusApiRegonData>(id);
                        if (null != advertisingCampaign)
                        {
                            return advertisingCampaign;
                        }
                    }
                }
                return null;
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }
        /// <summary>
        /// Delete Async Advertising Campaign
        /// </summary>
        /// <param name="id">Advertising Campaign Id</param>
        /// <param name="advertisingCampaign">Advertising Campaign Model </param>
        /// <returns>Advertising Campaign Model or null</returns>
        public static async System.Threading.Tasks.Task<Models.PortalApiGusApiRegonData> DeleteAsync(int? id, Models.PortalApiGusApiRegonData advertisingCampaign)
        {
            try
            {
                using (IDbConnection dbConnection = new SqlConnection(connectionString))
                {
                    bool deleteAsync = await dbConnection.DeleteAsync(advertisingCampaign);
                    if (deleteAsync)
                    {
                        return advertisingCampaign;
                    }
                }
                return null;
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }
    }
}