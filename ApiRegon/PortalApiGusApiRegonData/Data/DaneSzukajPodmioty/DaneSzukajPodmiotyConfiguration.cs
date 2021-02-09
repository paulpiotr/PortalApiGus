
/* Niescalona zmiana z projektu „PortalApiGusApiRegonData (netstandard2.1)”
Przed:
using PortalApiGusApiRegonData.Models.DaneSzukajPodmioty;
Po:
using Microsoft.EntityFrameworkCore;
*/

/* Niescalona zmiana z projektu „PortalApiGusApiRegonData (net5.0)”
Przed:
using PortalApiGusApiRegonData.Models.DaneSzukajPodmioty;
Po:
using Microsoft.EntityFrameworkCore;
*/
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
                .HasDatabaseName("IX_DaneSzukajPodmiotyId")
                .IsUnique(true);

            builder.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())");

            builder.HasIndex(e => e.UniqueIdentifierOfTheLoggedInUser)
                .HasDatabaseName("IX_DaneSzukajPodmiotyUniqueIdentifierOfTheLoggedInUser")
                .IsUnique(false);

            builder.HasIndex(e => e.Regon)
                .HasDatabaseName("IX_DaneSzukajPodmiotyRegon")
                .IsUnique(false);

            builder.HasIndex(e => e.Nip)
                .HasDatabaseName("IX_DaneSzukajPodmiotyNip")
                .IsUnique(false);

            builder.HasIndex(e => e.Nazwa)
                .HasDatabaseName("IX_DaneSzukajPodmiotyNazwa")
                .IsUnique(false);

            builder.HasIndex(e => e.Wojewodztwo)
                .HasDatabaseName("IX_DaneSzukajPodmiotyWojewodztwo")
                .IsUnique(false);

            builder.HasIndex(e => e.Powiat)
                .HasDatabaseName("IX_DaneSzukajPodmiotyPowiat")
                .IsUnique(false);

            builder.HasIndex(e => e.Gmina)
                .HasDatabaseName("IX_DaneSzukajPodmiotyGmina")
                .IsUnique(false);

            builder.HasIndex(e => e.Miejscowosc)
                .HasDatabaseName("IX_DaneSzukajPodmiotyMiejscowosc")
                .IsUnique(false);

            builder.HasIndex(e => e.KodPocztowy)
                .HasDatabaseName("IX_DaneSzukajPodmiotyKodPocztowy")
                .IsUnique(false);

            builder.HasIndex(e => e.Ulica)
                .HasDatabaseName("IX_DaneSzukajPodmiotyUlica")
                .IsUnique(false);

            builder.HasIndex(e => e.Typ)
                .HasDatabaseName("IX_DaneSzukajPodmiotyTyp")
                .IsUnique(false);

            builder.HasIndex(e => e.SilosID)
                .HasDatabaseName("IX_DaneSzukajPodmiotySilosID")
                .IsUnique(false);

            builder.HasIndex(e => e.MiejscowoscPoczty)
                .HasDatabaseName("IX_DaneSzukajPodmiotySilosMiejscowoscPoczty")
                .IsUnique(false);

            builder.Property(e => e.DataUtworzenia)
                .HasDefaultValueSql("(getdate())");
        }
    }
    #endregion
}
