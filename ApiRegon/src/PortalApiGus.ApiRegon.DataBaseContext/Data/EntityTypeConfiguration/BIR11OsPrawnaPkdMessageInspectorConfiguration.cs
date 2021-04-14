#region using

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport;

#endregion

namespace PortalApiGus.ApiRegon.DataBase.Data.EntityTypeConfiguration
{
    public class BIR11OsPrawnaPkdMessageInspectorConfiguration : IEntityTypeConfiguration<
        BIR11OsPrawnaPkdMessageInspector>
    {
        public void Configure(EntityTypeBuilder<BIR11OsPrawnaPkdMessageInspector> builder) =>
            builder.HasKey(hk => new {hk.BIR11OsPrawnaPkdId, hk.MessageInspectorId});
    }
}
