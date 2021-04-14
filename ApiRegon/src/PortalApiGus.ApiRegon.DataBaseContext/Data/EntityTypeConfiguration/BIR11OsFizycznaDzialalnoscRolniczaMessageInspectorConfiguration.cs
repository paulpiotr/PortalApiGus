#region using

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport;

#endregion

namespace PortalApiGus.ApiRegon.DataBase.Data.EntityTypeConfiguration
{
    public class BIR11OsFizycznaDzialalnoscRolniczaMessageInspectorConfiguration : IEntityTypeConfiguration<
        BIR11OsFizycznaDzialalnoscRolniczaMessageInspector>
    {
        public void Configure(EntityTypeBuilder<BIR11OsFizycznaDzialalnoscRolniczaMessageInspector> builder) =>
            builder.HasKey(hk => new {hk.BIR11OsFizycznaDzialalnoscRolniczaId, hk.MessageInspectorId});
    }
}
