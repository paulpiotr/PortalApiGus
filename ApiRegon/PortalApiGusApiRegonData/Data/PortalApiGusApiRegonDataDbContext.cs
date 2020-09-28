using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

//#nullable disable

namespace PortalApiGusApiRegonData.Data
{
    public partial class PortalApiGusApiRegonDataDbContext : DbContext
    {
        /// <summary>
        /// Log4 Net Logger
        /// </summary>
        private static readonly log4net.ILog _log4net = Log4netLogger.Log4netLogger.GetLog4netInstance(MethodBase.GetCurrentMethod().DeclaringType);

        public PortalApiGusApiRegonDataDbContext()
        {
        }

        //public PortalApiGusApiRegonDataDbContext(DbContextOptions options)
        //    : base(options)
        //{
        //}

        public PortalApiGusApiRegonDataDbContext(DbContextOptions<PortalApiGusApiRegonDataDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Models.DaneSzukajPodmioty.DaneSzukajPodmiotyParametryWyszukiwania> DaneSzukajPodmiotyParametryWyszukiwania { get; set; }

        public virtual DbSet<Models.DaneSzukajPodmioty.DaneSzukajPodmioty> DaneSzukajPodmioty { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                if (!optionsBuilder.IsConfigured)
                {
                    //optionsBuilder.UseSqlServer(PortalApiGusApiRegonDataContext.GetConnectionString());
                    optionsBuilder.UseSqlServer(NetAppCommon.DatabaseMssql.GetConnectionString("PortalApiGusApiRegonDataDbContext"));
                }
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("{0}, {1}.", e.Message, e.StackTrace), e);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Console.WriteLine("OnModelCreating(ModelBuilder modelBuilder)");
            //PortalApiGusApiRegonDataContext.DatabaseMdfCreate();
            //modelBuilder.ApplyConfiguration(new TmpTableConfiguration());
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}