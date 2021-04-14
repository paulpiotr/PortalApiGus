#region using

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport;

#endregion

namespace PortalApiGus.ApiRegon.DataBase.Data.EntityTypeConfiguration
{
    public class BIR11OsFizycznaDaneOgolneConfiguration : IEntityTypeConfiguration<
        BIR11OsFizycznaDaneOgolne>
    {
        public void Configure(EntityTypeBuilder<BIR11OsFizycznaDaneOgolne> builder)
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
