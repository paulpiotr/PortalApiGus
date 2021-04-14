#region using

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport;

#endregion

namespace PortalApiGus.ApiRegon.DataBase.Data.EntityTypeConfiguration
{
    public class BIR11OsFizycznaListaJednLokalnychMessageInspectorConfiguration : IEntityTypeConfiguration<
        BIR11OsFizycznaListaJednLokalnychMessageInspector>
    {
        public void Configure(EntityTypeBuilder<BIR11OsFizycznaListaJednLokalnychMessageInspector> builder) =>
            builder.HasKey(hk => new {hk.BIR11OsFizycznaListaJednLokalnychId, hk.MessageInspectorId});
    }
}
