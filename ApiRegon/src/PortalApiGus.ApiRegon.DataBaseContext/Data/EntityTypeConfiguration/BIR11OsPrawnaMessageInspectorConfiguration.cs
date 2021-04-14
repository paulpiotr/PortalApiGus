#region using

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport;

#endregion

namespace PortalApiGus.ApiRegon.DataBase.Data.EntityTypeConfiguration
{
    public class BIR11OsPrawnaMessageInspectorConfiguration : IEntityTypeConfiguration<
        BIR11OsPrawnaMessageInspector>
    {
        public void Configure(EntityTypeBuilder<BIR11OsPrawnaMessageInspector> builder) =>
            builder.HasKey(hk => new {hk.BIR11OsPrawnaId, hk.MessageInspectorId});
    }
}
