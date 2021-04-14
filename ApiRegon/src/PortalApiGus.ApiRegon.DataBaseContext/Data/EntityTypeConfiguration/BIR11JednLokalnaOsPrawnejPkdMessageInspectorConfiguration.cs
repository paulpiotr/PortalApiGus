#region using

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport;

#endregion

namespace PortalApiGus.ApiRegon.DataBase.Data.EntityTypeConfiguration
{
    public class BIR11JednLokalnaOsPrawnejPkdMessageInspectorConfiguration : IEntityTypeConfiguration<
        BIR11JednLokalnaOsPrawnejPkdMessageInspector>
    {
        public void Configure(EntityTypeBuilder<BIR11JednLokalnaOsPrawnejPkdMessageInspector> builder) =>
            builder.HasKey(hk => new {hk.BIR11JednLokalnaOsPrawnejPkdId, hk.MessageInspectorId});
    }
}
