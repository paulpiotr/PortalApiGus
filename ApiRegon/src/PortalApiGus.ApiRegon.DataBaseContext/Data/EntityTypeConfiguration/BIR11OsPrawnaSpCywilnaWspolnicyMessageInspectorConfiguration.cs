#region using

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport;

#endregion

namespace PortalApiGus.ApiRegon.DataBase.Data.EntityTypeConfiguration
{
    public class BIR11OsPrawnaSpCywilnaWspolnicyMessageInspectorConfiguration : IEntityTypeConfiguration<
        BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector>
    {
        public void Configure(EntityTypeBuilder<BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector> builder) =>
            builder.HasKey(hk => new {hk.BIR11OsPrawnaSpCywilnaWspolnicyId, hk.MessageInspectorId});
    }
}
