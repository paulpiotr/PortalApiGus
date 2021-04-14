#region using

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport;

#endregion

namespace PortalApiGus.ApiRegon.DataBase.Data.EntityTypeConfiguration
{
    public class BIR11JednLokalnaOsFizycznejPkdMessageInspectorConfiguration : IEntityTypeConfiguration<
        BIR11JednLokalnaOsFizycznejPkdMessageInspector>
    {
        public void Configure(EntityTypeBuilder<BIR11JednLokalnaOsFizycznejPkdMessageInspector> builder) =>
            builder.HasKey(hk => new {hk.BIR11JednLokalnaOsFizycznejPkdId, hk.MessageInspectorId});
    }
}
