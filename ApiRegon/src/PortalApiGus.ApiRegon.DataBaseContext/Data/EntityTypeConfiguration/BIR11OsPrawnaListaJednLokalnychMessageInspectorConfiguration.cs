#region using

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport;

#endregion

namespace PortalApiGus.ApiRegon.DataBase.Data.EntityTypeConfiguration
{
    public class BIR11OsPrawnaListaJednLokalnychMessageInspectorConfiguration : IEntityTypeConfiguration<
        BIR11OsPrawnaListaJednLokalnychMessageInspector>
    {
        public void Configure(EntityTypeBuilder<BIR11OsPrawnaListaJednLokalnychMessageInspector> builder) =>
            builder.HasKey(hk => new {hk.BIR11OsPrawnaListaJednLokalnychId, hk.MessageInspectorId});
    }
}
