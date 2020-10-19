using PortalApiGusApiRegonData.Models.DaneSzukajPodmioty;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PortalApiGusApiRegonData.Data.DaneSzukajPodmioty
{
    #region internal class DaneSzukajPodmiotyConfiguration : IEntityTypeConfiguration<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>
    /// <summary>
    /// Klasa konfiguracji dodatkowych ustawień bazy danych dla modelu encji Models.DaneSzukajPodmioty.DaneSzukajPodmioty
    /// Configuration class for additional database settings for the entity model Models.DataSearch Entities.DataSearchAutons
    /// </summary>
    internal class DaneSzukajPodmiotyConfiguration : IEntityTypeConfiguration<Models.DaneSzukajPodmioty.DaneSzukajPodmioty>
    {
        /// <summary>
        /// Konfiguruj encję DaneSzukajPodmioty
        /// Configure the DataSearch Entities entity
        /// </summary>
        /// <param name="builder">
        /// Kreator typów jednostek jako EntityTypeBuilder dla modelu Models.DaneSzukajPodmioty.DaneSzukajPodmioty
        /// Entity Type Creator as EntityTypeBuilder for Models.DataSearch Entities.DataSearch Entities
        /// </param>
        public void Configure(EntityTypeBuilder<Models.DaneSzukajPodmioty.DaneSzukajPodmioty> builder)
        {
            builder.HasIndex(e => e.Id)
                .HasName("IX_DaneSzukajPodmiotyId")
                .IsUnique(true);

            builder.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())");

            builder.HasIndex(e => e.UniqueIdentifierOfTheLoggedInUser)
                .HasName("IX_DaneSzukajPodmiotyUniqueIdentifierOfTheLoggedInUser")
                .IsUnique(false);

            builder.HasIndex(e => e.Regon)
                .HasName("IX_DaneSzukajPodmiotyRegon")
                .IsUnique(false);

            builder.HasIndex(e => e.Nip)
                .HasName("IX_DaneSzukajPodmiotyNip")
                .IsUnique(false);

            builder.HasIndex(e => e.Nazwa)
                .HasName("IX_DaneSzukajPodmiotyNazwa")
                .IsUnique(false);

            builder.HasIndex(e => e.Wojewodztwo)
                .HasName("IX_DaneSzukajPodmiotyWojewodztwo")
                .IsUnique(false);

            builder.HasIndex(e => e.Powiat)
                .HasName("IX_DaneSzukajPodmiotyPowiat")
                .IsUnique(false);

            builder.HasIndex(e => e.Gmina)
                .HasName("IX_DaneSzukajPodmiotyGmina")
                .IsUnique(false);

            builder.HasIndex(e => e.Miejscowosc)
                .HasName("IX_DaneSzukajPodmiotyMiejscowosc")
                .IsUnique(false);

            builder.HasIndex(e => e.KodPocztowy)
                .HasName("IX_DaneSzukajPodmiotyKodPocztowy")
                .IsUnique(false);

            builder.HasIndex(e => e.Ulica)
                .HasName("IX_DaneSzukajPodmiotyUlica")
                .IsUnique(false);

            builder.HasIndex(e => e.Typ)
                .HasName("IX_DaneSzukajPodmiotyTyp")
                .IsUnique(false);

            builder.HasIndex(e => e.SilosID)
                .HasName("IX_DaneSzukajPodmiotySilosID")
                .IsUnique(false);

            builder.HasIndex(e => e.MiejscowoscPoczty)
                .HasName("IX_DaneSzukajPodmiotySilosMiejscowoscPoczty")
                .IsUnique(false);

            builder.Property(e => e.DataUtworzenia)
                .HasDefaultValueSql("(getdate())");
        }
    }
    #endregion
}