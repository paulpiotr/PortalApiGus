using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PortalApiGus.ApiRegon.DataBase.Data;

namespace PortalApiGus.ApiRegon.DataBase.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20201019000806_2")]
    partial class _2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PortalApiGusApiRegonData.Models.DaneSzukajPodmioty.DaneSzukajPodmioty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newsequentialid())");

                    b.Property<DateTime?>("DataModyfikacji")
                        .HasColumnName("DataModyfikacji")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DataUtworzenia")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("DataUtworzenia")
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("DataZakonczeniaDzialalnosci")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Gmina")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("KodPocztowy")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("Miejscowosc")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("MiejscowoscPoczty")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Nazwa")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<string>("Nip")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("NrLokalu")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("NrNieruchomosci")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("ParametryWyszukiwaniaJson")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(2147483647);

                    b.Property<string>("ParametryWyszukiwaniaSHA512")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(2147483647);

                    b.Property<string>("Powiat")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Regon")
                        .HasColumnType("nvarchar(14)")
                        .HasMaxLength(14);

                    b.Property<int?>("SilosID")
                        .HasColumnType("int");

                    b.Property<string>("StatusNip")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("Typ")
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Ulica")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("UniqueIdentifierOfTheLoggedInUser")
                        .HasColumnName("UniqueIdentifierOfTheLoggedInUser")
                        .HasColumnType("varchar(512)")
                        .HasMaxLength(512);

                    b.Property<string>("Wojewodztwo")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("Gmina")
                        .HasDatabaseName("IX_DaneSzukajPodmiotyGmina");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasDatabaseName("IX_DaneSzukajPodmiotyId");

                    b.HasIndex("KodPocztowy")
                        .HasDatabaseName("IX_DaneSzukajPodmiotyKodPocztowy");

                    b.HasIndex("Miejscowosc")
                        .HasDatabaseName("IX_DaneSzukajPodmiotyMiejscowosc");

                    b.HasIndex("MiejscowoscPoczty")
                        .HasDatabaseName("IX_DaneSzukajPodmiotySilosMiejscowoscPoczty");

                    b.HasIndex("Nazwa")
                        .HasDatabaseName("IX_DaneSzukajPodmiotyNazwa");

                    b.HasIndex("Nip")
                        .HasDatabaseName("IX_DaneSzukajPodmiotyNip");

                    b.HasIndex("Powiat")
                        .HasDatabaseName("IX_DaneSzukajPodmiotyPowiat");

                    b.HasIndex("Regon")
                        .HasDatabaseName("IX_DaneSzukajPodmiotyRegon");

                    b.HasIndex("SilosID")
                        .HasDatabaseName("IX_DaneSzukajPodmiotySilosID");

                    b.HasIndex("Typ")
                        .HasDatabaseName("IX_DaneSzukajPodmiotyTyp");

                    b.HasIndex("Ulica")
                        .HasDatabaseName("IX_DaneSzukajPodmiotyUlica");

                    b.HasIndex("UniqueIdentifierOfTheLoggedInUser")
                        .HasDatabaseName("IX_DaneSzukajPodmiotyUniqueIdentifierOfTheLoggedInUser");

                    b.HasIndex("Wojewodztwo")
                        .HasDatabaseName("IX_DaneSzukajPodmiotyWojewodztwo");

                    b.ToTable("DaneSzukajPodmioty","pagard");
                });

            modelBuilder.Entity("PortalApiGusApiRegonData.Models.DaneSzukajPodmioty.DaneSzukajPodmiotyParametryWyszukiwania", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newsequentialid())");

                    b.Property<DateTime?>("DataModyfikacji")
                        .HasColumnName("DataModyfikacji")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DataUtworzenia")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("DataUtworzenia")
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Krs")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Krsy")
                        .HasColumnType("nvarchar(220)")
                        .HasMaxLength(220);

                    b.Property<string>("Nip")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Nipy")
                        .HasColumnType("nvarchar(220)")
                        .HasMaxLength(220);

                    b.Property<string>("Regon")
                        .HasColumnType("nvarchar(14)")
                        .HasMaxLength(14);

                    b.Property<string>("Regony14zn")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("Regony9zn")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("SHA512")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(2147483647);

                    b.Property<string>("UniqueIdentifierOfTheLoggedInUser")
                        .HasColumnName("UniqueIdentifierOfTheLoggedInUser")
                        .HasColumnType("varchar(512)")
                        .HasMaxLength(512);

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasDatabaseName("IX_DaneSzukajPodmiotyParametryWyszukiwaniaId");

                    b.HasIndex("Krs")
                        .HasDatabaseName("IX_DaneSzukajPodmiotyParametryWyszukiwaniaKrs");

                    b.HasIndex("Krsy")
                        .HasDatabaseName("IX_DaneSzukajPodmiotyParametryWyszukiwaniaKrsy");

                    b.HasIndex("Nip")
                        .HasDatabaseName("IX_DaneSzukajPodmiotyParametryWyszukiwaniaNip");

                    b.HasIndex("Nipy")
                        .HasDatabaseName("IX_DaneSzukajPodmiotyParametryWyszukiwaniaNipy");

                    b.HasIndex("Regon")
                        .HasDatabaseName("IX_DaneSzukajPodmiotyParametryWyszukiwaniaRegon");

                    b.HasIndex("Regony14zn")
                        .HasDatabaseName("IX_DaneSzukajPodmiotyParametryWyszukiwaniaRegony14zn");

                    b.HasIndex("Regony9zn")
                        .HasDatabaseName("IX_DaneSzukajPodmiotyParametryWyszukiwaniaRegony9zn");

                    b.HasIndex("UniqueIdentifierOfTheLoggedInUser")
                        .HasDatabaseName("IX_DaneSzukajPodmiotyParametryWyszukiwaniaUniqueIdentifierOfTheLoggedInUser");

                    b.ToTable("DaneSzukajPodmiotyParametryWyszukiwania","pagard");
                });
#pragma warning restore 612, 618
        }
    }
}
