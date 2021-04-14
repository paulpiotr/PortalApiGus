#region using

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport;

#endregion

namespace PortalApiGus.ApiRegon.DataBase.Data.EntityTypeConfiguration
{
    public class BIR11OsFizycznaDaneOgolneMessageInspectorConfiguration : IEntityTypeConfiguration<
        BIR11OsFizycznaDaneOgolneMessageInspector>
    {
        public void Configure(EntityTypeBuilder<BIR11OsFizycznaDaneOgolneMessageInspector> builder) =>
            builder.HasKey(hk => new {hk.BIR11OsFizycznaDaneOgolneId, hk.MessageInspectorId});
    }
}
