#region using

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmioty;

#endregion

#nullable enable annotations

namespace PortalApiGus.ApiRegon.DataBase.Data.EntityTypeConfiguration
{
    internal class
        DaneSzukajPodmiotyParametryWyszukiwaniaConfiguration : IEntityTypeConfiguration<
            DaneSzukajPodmiotyParametryWyszukiwania>
    {
        public void Configure(EntityTypeBuilder<DaneSzukajPodmiotyParametryWyszukiwania> builder)
        {
            if (DataBaseContext.IsNpgsql())
            {
                builder.Property(e => e.Id).HasDefaultValueSql("(gen_random_uuid())");
                builder.Property(e => e.DateOfCreate).HasDefaultValueSql("(now())");
            }
            else
            {
                builder.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
                builder.Property(e => e.DateOfCreate).HasDefaultValueSql("(getdate())");
            }
        }
    }
}
