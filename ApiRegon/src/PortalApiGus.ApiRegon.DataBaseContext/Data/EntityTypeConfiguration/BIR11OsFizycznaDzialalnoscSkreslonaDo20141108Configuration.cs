#region using

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport;

#endregion

namespace PortalApiGus.ApiRegon.DataBase.Data.EntityTypeConfiguration
{
    public class BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Configuration : IEntityTypeConfiguration<
        BIR11OsFizycznaDzialalnoscSkreslonaDo20141108>
    {
        public void Configure(EntityTypeBuilder<BIR11OsFizycznaDzialalnoscSkreslonaDo20141108> builder)
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
