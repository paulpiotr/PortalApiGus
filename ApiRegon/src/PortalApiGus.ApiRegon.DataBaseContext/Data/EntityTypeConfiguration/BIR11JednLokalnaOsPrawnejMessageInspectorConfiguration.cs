#region using

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport;

#endregion

namespace PortalApiGus.ApiRegon.DataBase.Data.EntityTypeConfiguration
{
    public class BIR11JednLokalnaOsPrawnejMessageInspectorConfiguration : IEntityTypeConfiguration<
        BIR11JednLokalnaOsPrawnejMessageInspector>
    {
        public void Configure(EntityTypeBuilder<BIR11JednLokalnaOsPrawnejMessageInspector> builder) =>
            builder.HasKey(hk => new {hk.BIR11JednLokalnaOsPrawnejId, hk.MessageInspectorId});
    }
}
