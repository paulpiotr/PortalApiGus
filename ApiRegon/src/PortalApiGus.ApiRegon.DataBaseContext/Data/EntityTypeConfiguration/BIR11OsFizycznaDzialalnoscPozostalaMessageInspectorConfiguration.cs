#region using

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport;

#endregion

namespace PortalApiGus.ApiRegon.DataBase.Data.EntityTypeConfiguration
{
    public class BIR11OsFizycznaDzialalnoscPozostalaMessageInspectorConfiguration : IEntityTypeConfiguration<
        BIR11OsFizycznaDzialalnoscPozostalaMessageInspector>
    {
        public void Configure(EntityTypeBuilder<BIR11OsFizycznaDzialalnoscPozostalaMessageInspector> builder) =>
            builder.HasKey(hk => new {hk.BIR11OsFizycznaDzialalnoscPozostalaId, hk.MessageInspectorId});
    }
}
