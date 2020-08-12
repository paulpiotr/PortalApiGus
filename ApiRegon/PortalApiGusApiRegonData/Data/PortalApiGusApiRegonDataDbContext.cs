using Microsoft.EntityFrameworkCore;
using PortalApiGusApiRegonData.Models.DaneSzukajPodmioty;
using System;

//#nullable disable

namespace PortalApiGusApiRegonData.Data
{
    public partial class PortalApiGusApiRegonDataDbContext : DbContext
    {
        public PortalApiGusApiRegonDataDbContext()
        {
        }
        public PortalApiGusApiRegonDataDbContext(DbContextOptions<PortalApiGusApiRegonDataDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<DaneSzukajPodmioty> DaneSzukajPodmiotyParametryWyszukiwania { get; set; }
        public virtual DbSet<DaneSzukajPodmiotyParametryWyszukiwania> DaneSzukajPodmioty { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(PortalApiGusApiRegonDataContext.GetConnectionString());
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Console.WriteLine("OnModelCreating(ModelBuilder modelBuilder)");
            PortalApiGusApiRegonDataContext.DatabaseMdfCreate();
            //modelBuilder.ApplyConfiguration(new TmpTableConfiguration());
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}