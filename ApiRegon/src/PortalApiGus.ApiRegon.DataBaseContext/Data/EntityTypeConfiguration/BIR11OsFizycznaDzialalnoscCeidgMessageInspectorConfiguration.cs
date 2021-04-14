#region using

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport;

#endregion

namespace PortalApiGus.ApiRegon.DataBase.Data.EntityTypeConfiguration
{
    public class BIR11OsFizycznaDzialalnoscCeidgMessageInspectorConfiguration : IEntityTypeConfiguration<
        BIR11OsFizycznaDzialalnoscCeidgMessageInspector>
    {
        public void Configure(EntityTypeBuilder<BIR11OsFizycznaDzialalnoscCeidgMessageInspector> builder) =>
            builder.HasKey(hk => new {hk.BIR11OsFizycznaDzialalnoscCeidgId, hk.MessageInspectorId});
    }
}
