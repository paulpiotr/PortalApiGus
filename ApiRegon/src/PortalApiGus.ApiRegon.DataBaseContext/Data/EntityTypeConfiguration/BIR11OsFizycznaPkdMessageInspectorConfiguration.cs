#region using

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport;

#endregion

namespace PortalApiGus.ApiRegon.DataBase.Data.EntityTypeConfiguration
{
    public class BIR11OsFizycznaPkdMessageInspectorConfiguration : IEntityTypeConfiguration<
        BIR11OsFizycznaPkdMessageInspector>
    {
        public void Configure(EntityTypeBuilder<BIR11OsFizycznaPkdMessageInspector> builder) =>
            builder.HasKey(hk => new {hk.BIR11OsFizycznaPkdId, hk.MessageInspectorId});
    }
}
