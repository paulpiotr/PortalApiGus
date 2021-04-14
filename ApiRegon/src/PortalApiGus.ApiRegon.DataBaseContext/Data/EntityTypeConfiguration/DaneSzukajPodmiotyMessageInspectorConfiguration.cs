#region using

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmioty;

#endregion

namespace PortalApiGus.ApiRegon.DataBase.Data.EntityTypeConfiguration
{
    public class DaneSzukajPodmiotyMessageInspectorConfiguration : IEntityTypeConfiguration<
        DaneSzukajPodmiotyMessageInspector>
    {
        public void Configure(EntityTypeBuilder<DaneSzukajPodmiotyMessageInspector> builder) =>
            builder.HasKey(hk => new {hk.DaneSzukajPodmiotyId, hk.MessageInspectorId});
    }
}
