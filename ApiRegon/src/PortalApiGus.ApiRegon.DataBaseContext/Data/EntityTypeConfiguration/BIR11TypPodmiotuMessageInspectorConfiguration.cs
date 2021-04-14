#region using

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport;

#endregion

namespace PortalApiGus.ApiRegon.DataBase.Data.EntityTypeConfiguration
{
    public class BIR11TypPodmiotuMessageInspectorConfiguration : IEntityTypeConfiguration<
        BIR11TypPodmiotuMessageInspector>
    {
        public void Configure(EntityTypeBuilder<BIR11TypPodmiotuMessageInspector> builder) =>
            builder.HasKey(hk => new {hk.BIR11TypPodmiotuId, hk.MessageInspectorId});
    }
}
