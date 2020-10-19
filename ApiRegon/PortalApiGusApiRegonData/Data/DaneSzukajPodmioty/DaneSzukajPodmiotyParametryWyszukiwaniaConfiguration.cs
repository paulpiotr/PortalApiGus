using PortalApiGusApiRegonData.Models.DaneSzukajPodmioty;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PortalApiGusApiRegonData.Data.DaneSzukajPodmioty
{
    #region internal class DaneSzukajPodmiotyParametryWyszukiwaniaConfiguration : IEntityTypeConfiguration<Models.DaneSzukajPodmioty.DaneSzukajPodmiotyParametryWyszukiwania>
    /// <summary>
    /// Klasa konfiguracji dodatkowych ustawień bazy danych dla modelu encji Models.DaneSzukajPodmioty.DaneSzukajPodmiotyParametryWyszukiwania
    /// Configuration class for additional database settings for the entity model Models.DaneSzukajPodmioty.DaneSzukajPodmiotyParametryWyszukiwania
    /// </summary>
    internal class DaneSzukajPodmiotyParametryWyszukiwaniaConfiguration : IEntityTypeConfiguration<Models.DaneSzukajPodmioty.DaneSzukajPodmiotyParametryWyszukiwania>
    {
        /// <summary>
        /// Konfiguruj encję DaneSzukajPodmiotyParametryWyszukiwania
        /// Configure the DataSearch Entities entity
        /// </summary>
        /// <param name="builder">
        /// Kreator typów jednostek jako EntityTypeBuilder dla modelu Models.DaneSzukajPodmioty.DaneSzukajPodmiotyParametryWyszukiwania
        /// Entity Type Creator as EntityTypeBuilder for Models.DaneSzukajPodmioty.DaneSzukajPodmiotyParametryWyszukiwania Entities
        /// </param>
        public void Configure(EntityTypeBuilder<Models.DaneSzukajPodmioty.DaneSzukajPodmiotyParametryWyszukiwania> builder)
        {
            builder.HasIndex(e => e.Id)
                .HasName("IX_DaneSzukajPodmiotyParametryWyszukiwaniaId")
                .IsUnique(true);

            builder.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())");

            builder.HasIndex(e => e.UniqueIdentifierOfTheLoggedInUser)
                .HasName("IX_DaneSzukajPodmiotyParametryWyszukiwaniaUniqueIdentifierOfTheLoggedInUser")
                .IsUnique(false);

            builder.HasIndex(e => e.Regon)
                .HasName("IX_DaneSzukajPodmiotyParametryWyszukiwaniaRegon")
                .IsUnique(false);

            builder.HasIndex(e => e.Nip)
                .HasName("IX_DaneSzukajPodmiotyParametryWyszukiwaniaNip")
                .IsUnique(false);

            builder.HasIndex(e => e.Krs)
                .HasName("IX_DaneSzukajPodmiotyParametryWyszukiwaniaKrs")
                .IsUnique(false);

            builder.HasIndex(e => e.Nipy)
                .HasName("IX_DaneSzukajPodmiotyParametryWyszukiwaniaNipy")
                .IsUnique(false);

            builder.HasIndex(e => e.Regony14zn)
                .HasName("IX_DaneSzukajPodmiotyParametryWyszukiwaniaRegony14zn")
                .IsUnique(false);

            builder.HasIndex(e => e.Regony9zn)
                .HasName("IX_DaneSzukajPodmiotyParametryWyszukiwaniaRegony9zn")
                .IsUnique(false);

            builder.HasIndex(e => e.Krsy)
                .HasName("IX_DaneSzukajPodmiotyParametryWyszukiwaniaKrsy")
                .IsUnique(false);

            builder.Property(e => e.DataUtworzenia)
                .HasDefaultValueSql("(getdate())");
        }
    }
    #endregion
}