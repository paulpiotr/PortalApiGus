#region using

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport;

#endregion

namespace PortalApiGus.ApiRegon.DataBase.Data.EntityTypeConfiguration
{
    public class BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspectorConfiguration : IEntityTypeConfiguration<
        BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector>
    {
        public void Configure(EntityTypeBuilder<BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector> builder) =>
            builder.HasKey(hk => new {hk.BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id, hk.MessageInspectorId});
    }
}
