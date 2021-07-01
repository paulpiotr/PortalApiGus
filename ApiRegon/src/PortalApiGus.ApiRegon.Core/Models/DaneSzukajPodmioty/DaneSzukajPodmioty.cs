#region using

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;
using NetAppCommon.Models;
using Newtonsoft.Json;
using PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport;

#endregion

#nullable enable annotations

#region namespace

namespace PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmioty
{
    #region public class DaneSzukajPodmioty : BaseEntity

    /// <summary>
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmioty DaneSzukajPodmioty
    ///     Data model of entities found in the basic report
    /// </summary>
    [Table(nameof(DaneSzukajPodmioty), Schema = "pagard")]
    [JsonObject(nameof(DaneSzukajPodmioty))]
    [Display(Name = "DaneSzukajPodmioty", Description = "DaneSzukajPodmioty")]
    [Serializable]
    [XmlRoot("dane")]
    [Index(nameof(Regon))]
    [Index(nameof(Nip))]
    [Index(nameof(StatusNip))]
    [Index(nameof(Nazwa))]
    [Index(nameof(Wojewodztwo))]
    [Index(nameof(Powiat))]
    [Index(nameof(Gmina))]
    [Index(nameof(Miejscowosc))]
    [Index(nameof(KodPocztowy))]
    [Index(nameof(Ulica))]
    [Index(nameof(NrNieruchomosci))]
    [Index(nameof(NrLokalu))]
    [Index(nameof(Typ))]
    [Index(nameof(SilosID))]
    [Index(nameof(DataZakonczeniaDzialalnosci))]
    [Index(nameof(MiejscowoscPoczty))]
    public class DaneSzukajPodmioty : BaseEntity
    {
        #region public override Guid Id...

        /// <summary>
        ///     Guid Id identyfikator klucz główny
        ///     Guid Id identifier of the primary key
        /// </summary>
        [XmlIgnore]
        [Key]
        [JsonProperty(nameof(Id), Order = -1)]
        [Display(Name = "Identyfikator", Prompt = "Wpisz identyfikator",
            Description = "Identyfikator, klucz główny w bazie danych jako Guid")]
        public override Guid Id => base.Id;

        #endregion

        #region public override string? UniqueIdentifierOfTheLoggedInUser...

        /// <summary>
        ///     Jednoznaczny identyfikator zalogowanego użytkownika
        ///     Unique identifier of the logged in user
        /// </summary>
        [XmlIgnore]
        [JsonProperty(nameof(UniqueIdentifierOfTheLoggedInUser), Order = -1)]
        [Display(Name = "Użytkownik",
            Prompt = "Wybierz identyfikator zalogowanego użytkownika",
            Description = "Użytkownik")]
        [MinLength(1)]
        [MaxLength(256)]
        [StringLength(256)]
        public override string? UniqueIdentifierOfTheLoggedInUser => base.UniqueIdentifierOfTheLoggedInUser;

        #endregion

        #region private DateTime _dateOfCreate; public DateTime DateOfCreate

        /// <summary>
        ///     Data utworzenia
        ///     Date of create
        /// </summary>
        [XmlIgnore]
        [Column("DataUtworzenia", Order = 3)]
        [JsonProperty("DataUtworzenia", Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "Data utworzenia", Prompt = "Wpisz lub wybierz datę utworzenia",
            Description = "Data utworzenia")]
        [DataType(DataType.Date)]
        public override DateTime DateOfCreate => base.DateOfCreate;

        #endregion

        #region private DateTime? _dateOfModification; public DateTime? DateOfModification

        /// <summary>
        ///     Data modyfikacji
        ///     Date of modification
        /// </summary>
        [XmlIgnore]
        [Column("DataModyfikacji", Order = 3)]
        [JsonProperty("DataModyfikacji", Order = 3)]
        [Display(Name = "Data modyfikacji", Prompt = "Wpisz lub wybierz datę modyfikacji",
            Description = "Data modyfikacji")]
        [DataType(DataType.Date)]
        public override DateTime? DateOfModification => base.DateOfModification;

        #endregion

        #region private Guid? _daneSzukajPodmiotyParametryWyszukiwaniaId...

        private Guid? _daneSzukajPodmiotyParametryWyszukiwaniaId;

        /// <summary>
        ///     Identyfikator parametrów wyszukiwania, klucz obcy, relacja jeden do jednego do tabeli
        ///     DaneSzukajPodmiotyParametryWyszukiwania
        ///     ID search parameters, foreign key, one-to-one relationship to the table
        ///     DaneSzukajPodmiotyParametryWyszukiwania
        /// </summary>
        [XmlIgnore]
        [JsonProperty(nameof(DaneSzukajPodmiotyParametryWyszukiwaniaId), Order = 2)]
        [Display(Name = "Identyfikator parametrów wyszukiwania",
            Prompt = "Wpisz lub wybierz identyfikator parametrów wyszukiwania",
            Description = "Identyfikator parametrów wyszukiwania, klucz obcy")]
        public Guid? DaneSzukajPodmiotyParametryWyszukiwaniaId
        {
            get => _daneSzukajPodmiotyParametryWyszukiwaniaId;
            set
            {
                if (value != _daneSzukajPodmiotyParametryWyszukiwaniaId)
                {
                    _daneSzukajPodmiotyParametryWyszukiwaniaId = value;
                    OnPropertyChanged(nameof(DaneSzukajPodmiotyParametryWyszukiwaniaId));
                }
            }
        }

        #endregion

        #region private DaneSzukajPodmiotyParametryWyszukiwania? _daneSzukajPodmiotyParametryWyszukiwania...

        private DaneSzukajPodmiotyParametryWyszukiwania? _daneSzukajPodmiotyParametryWyszukiwania;

        /// <summary>
        ///     Parametry wyszukiwania, relacja do encji DaneSzukajPodmiotyParametryWyszukiwania
        ///     Search parameters, relation to the DataSearchObjectsParametrySearch entity
        /// </summary>
        [XmlIgnore]
        [ForeignKey(nameof(DaneSzukajPodmiotyParametryWyszukiwaniaId))]
        [JsonProperty(nameof(DaneSzukajPodmiotyParametryWyszukiwania), Order = 2)]
        [Display(Name = "Identyfikator parametrów wyszukiwania", Prompt = "Uzupełnij parametry wyszukiwania podmiotu",
            Description = "Parametry wyszukiwania, relacja do encji DaneSzukajPodmiotyParametryWyszukiwania")]
        public virtual DaneSzukajPodmiotyParametryWyszukiwania? DaneSzukajPodmiotyParametryWyszukiwania
        {
            get => _daneSzukajPodmiotyParametryWyszukiwania;
            set
            {
                if (value != _daneSzukajPodmiotyParametryWyszukiwania)
                {
                    _daneSzukajPodmiotyParametryWyszukiwania = value;
                    OnPropertyChanged(nameof(DaneSzukajPodmiotyParametryWyszukiwania));
                }
            }
        }

        #endregion

        #region private Guid? _daneSzukajPodmiotyKomunikatyOBledachId...

        private Guid? _daneSzukajPodmiotyKomunikatyOBledachId;

        /// <summary>
        ///     Identyfikator komunikatów o błędach , klucz obcy, relacja jeden do jednego do tabeli
        ///     DaneSzukajPodmiotyKomunikatyOBledach
        ///     Error message ID, foreign key, one-to-one relationship to the table
        ///     DaneSzukajPodmiotKomunikatyOBledach
        /// </summary>
        [XmlIgnore]
        [JsonProperty(nameof(DaneSzukajPodmiotyKomunikatyOBledachId), Order = 2)]
        [Display(Name = "Identyfikator komunikatów o błędach",
            Prompt = "Wpisz lub wybierz identyfikator komunikatów o błędach",
            Description = "Identyfikator komunikatów o błędach, klucz obcy")]
        public Guid? DaneSzukajPodmiotyKomunikatyOBledachId
        {
            get => _daneSzukajPodmiotyKomunikatyOBledachId;
            set
            {
                if (value != _daneSzukajPodmiotyKomunikatyOBledachId)
                {
                    _daneSzukajPodmiotyKomunikatyOBledachId = value;
                    OnPropertyChanged(nameof(DaneSzukajPodmiotyKomunikatyOBledachId));
                }
            }
        }

        #endregion

        #region private DaneSzukajPodmiotyKomunikatyOBledach? _daneSzukajPodmiotyKomunikatyOBledach...

        private DaneSzukajPodmiotyKomunikatyOBledach? _daneSzukajPodmiotyKomunikatyOBledach;

        /// <summary>
        ///     Komunikaty o błędach, relacja do encji DaneSzukajPodmiotyKomunikatyOBledach
        ///     Error messages, relation to the DataSzukajPodmiotKomunikatyOBledach entity
        /// </summary>
        [XmlIgnore]
        [ForeignKey(nameof(DaneSzukajPodmiotyKomunikatyOBledachId))]
        [JsonProperty(nameof(DaneSzukajPodmiotyKomunikatyOBledach), Order = 2)]
        [Display(Name = "Komunikaty o błędach", Prompt = "Uzupełnij komunikaty o błędach",
            Description = "Komunikaty o błędach, relacja do encji DaneSzukajPodmiotyKomunikatyOBledach")]
        public DaneSzukajPodmiotyKomunikatyOBledach? DaneSzukajPodmiotyKomunikatyOBledach
        {
            get => _daneSzukajPodmiotyKomunikatyOBledach;
            set
            {
                if (value != _daneSzukajPodmiotyKomunikatyOBledach)
                {
                    _daneSzukajPodmiotyKomunikatyOBledach = value;
                    OnPropertyChanged(nameof(DaneSzukajPodmiotyKomunikatyOBledach));
                }
            }
        }

        #endregion

        #region private ICollection<DaneSzukajPodmiotyMessageInspector>...

        private ICollection<DaneSzukajPodmiotyMessageInspector> _daneSzukajPodmiotyMessageInspector;

        /// <summary>
        ///     Kolekcja elementów inspektora wiadomości usługi, relacja do encji DaneSzukajPodmioty, zawiera informacje dotyczące
        ///     przetwarzania żądań
        ///     Service Message Inspector Item Collection, DaneSzukajPodmioty relationship, contains information about request
        ///     processing
        /// </summary>
        [XmlIgnore]
        [JsonProperty(nameof(DaneSzukajPodmiotyMessageInspector), Order = 2)]
        [ForeignKey("DaneSzukajPodmiotyId")]
        [Display(Name = "Inspektor wiadomości usługi",
            Prompt = "Wybierz elementy kolekcji inspektora wiadomości usługi",
            Description =
                "Kolekcja elementów inspektora wiadomości usługi, relacja do encji DaneSzukajPodmioty, zawiera informacje dotyczące przetwarzania żądań")]
        public virtual ICollection<DaneSzukajPodmiotyMessageInspector> DaneSzukajPodmiotyMessageInspector
        {
            get => _daneSzukajPodmiotyMessageInspector;
            set
            {
                if (!Equals(value, _daneSzukajPodmiotyMessageInspector))
                {
                    _daneSzukajPodmiotyMessageInspector = value;
                    OnPropertyChanged(nameof(DaneSzukajPodmiotyMessageInspector));
                }
            }
        }

        #endregion

        #region private Guid? _bIr11OsPrawnaId...

        private Guid? _bIr11OsPrawnaId;

        [Column(Order = 2)]
        [XmlIgnore]
        [JsonProperty(nameof(BIR11OsPrawnaId), Order = 2)]
        public Guid? BIR11OsPrawnaId
        {
            get => _bIr11OsPrawnaId;
            set
            {
                if (value != _bIr11OsPrawnaId)
                {
                    _bIr11OsPrawnaId = value;
                    OnPropertyChanged(nameof(BIR11OsPrawnaId));
                }
            }
        }

        #endregion

        #region private BIR11OsPrawna? _bIr11OsPrawna...

        private BIR11OsPrawna? _bIr11OsPrawna;

        [Column(Order = 2)]
        [XmlIgnore]
        [ForeignKey(nameof(BIR11OsPrawnaId))]
        [JsonProperty(nameof(BIR11OsPrawna), Order = 2)]
        public BIR11OsPrawna? BIR11OsPrawna
        {
            get => _bIr11OsPrawna;
            set
            {
                if (value != _bIr11OsPrawna)
                {
                    _bIr11OsPrawna = value;
                    OnPropertyChanged(nameof(BIR11OsPrawna));
                }
            }
        }

        #endregion

        #region ICollection<BIR11OsPrawnaPkd>...

        private ICollection<BIR11OsPrawnaPkd> _bir11OsPrawnaPkd;

        /// <summary>
        ///     Kolekcja elementów BIR11OsPrawnaPkd, relacja do encji BIR11OsPrawnaPkd
        ///     Collection of BIR11OsPrawnaPkd elements, relation to the BIR11OsPrawnaPkd entity
        /// </summary>
        [XmlIgnore]
        [JsonProperty(nameof(BIR11OsPrawnaPkd), Order = 2)]
        [InverseProperty("DaneSzukajPodmioty")]
        [Display(Name = "Elementy kolekcji BIR11OsPrawnaPkd",
            Prompt = "Wybierz elementy kolekcji BIR11OsPrawnaPkd",
            Description =
                "Kolekcja elementów BIR11OsPrawnaPkd, relacja do encji BIR11OsPrawnaPkd")]
        public virtual ICollection<BIR11OsPrawnaPkd> BIR11OsPrawnaPkd
        {
            get => _bir11OsPrawnaPkd;
            set
            {
                if (!Equals(value, _bir11OsPrawnaPkd))
                {
                    _bir11OsPrawnaPkd = value;
                    OnPropertyChanged(nameof(BIR11OsPrawnaPkd));
                }
            }
        }

        #endregion

        #region ICollection<BIR11OsPrawnaListaJednLokalnych>...

        private ICollection<BIR11OsPrawnaListaJednLokalnych> _bir11OsPrawnaListaJednLokalnych;

        /// <summary>
        ///     Kolekcja elementów BIR11OsPrawnaListaJednLokalnych, relacja do encji BIR11OsPrawnaListaJednLokalnych
        ///     Collection of BIR11OsPrawnaListaJednLokalnych elements, relation to the BIR11OsPrawnaListaJednLokalnych entity
        /// </summary>
        [XmlIgnore]
        [JsonProperty(nameof(BIR11OsPrawnaListaJednLokalnych), Order = 2)]
        [InverseProperty("DaneSzukajPodmioty")]
        [Display(Name = "Elementy kolekcji BIR11OsPrawnaListaJednLokalnych",
            Prompt = "Wybierz elementy kolekcji BIR11OsPrawnaListaJednLokalnych",
            Description =
                "Kolekcja elementów BIR11OsPrawnaListaJednLokalnych, relacja do encji BIR11OsPrawnaListaJednLokalnych")]
        public virtual ICollection<BIR11OsPrawnaListaJednLokalnych> BIR11OsPrawnaListaJednLokalnych
        {
            get => _bir11OsPrawnaListaJednLokalnych;
            set
            {
                if (!Equals(value, _bir11OsPrawnaListaJednLokalnych))
                {
                    _bir11OsPrawnaListaJednLokalnych = value;
                    OnPropertyChanged(nameof(BIR11OsPrawnaListaJednLokalnych));
                }
            }
        }

        #endregion

        #region ICollection<BIR11OsPrawnaSpCywilnaWspolnicy>...

        private ICollection<BIR11OsPrawnaSpCywilnaWspolnicy> _bir11OsPrawnaSpCywilnaWspolnicy;

        /// <summary>
        ///     Kolekcja elementów BIR11OsPrawnaSpCywilnaWspolnicy, relacja do encji BIR11OsPrawnaSpCywilnaWspolnicy
        ///     Collection of BIR11OsPrawnaSpCywilnaWspolnicy elements, relation to the BIR11OsPrawnaSpCywilnaWspolnicy entity
        /// </summary>
        [XmlIgnore]
        [JsonProperty(nameof(BIR11OsPrawnaSpCywilnaWspolnicy), Order = 2)]
        [InverseProperty("DaneSzukajPodmioty")]
        [Display(Name = "Elementy kolekcji BIR11OsPrawnaSpCywilnaWspolnicy",
            Prompt = "Wybierz elementy kolekcji BIR11OsPrawnaSpCywilnaWspolnicy",
            Description =
                "Kolekcja elementów BIR11OsPrawnaSpCywilnaWspolnicy, relacja do encji BIR11OsPrawnaSpCywilnaWspolnicy")]
        public virtual ICollection<BIR11OsPrawnaSpCywilnaWspolnicy> BIR11OsPrawnaSpCywilnaWspolnicy
        {
            get => _bir11OsPrawnaSpCywilnaWspolnicy;
            set
            {
                if (!Equals(value, _bir11OsPrawnaSpCywilnaWspolnicy))
                {
                    _bir11OsPrawnaSpCywilnaWspolnicy = value;
                    OnPropertyChanged(nameof(BIR11OsPrawnaSpCywilnaWspolnicy));
                }
            }
        }

        #endregion

        #region private Guid? _BIR11TypPodmiotuId...

        private Guid? _bir11TypPodmiotuId;

        [Column(Order = 2)]
        [XmlIgnore]
        [JsonProperty(nameof(BIR11TypPodmiotuId), Order = 2)]
        public Guid? BIR11TypPodmiotuId
        {
            get => _bir11TypPodmiotuId;
            set
            {
                if (value != _bir11TypPodmiotuId)
                {
                    _bir11TypPodmiotuId = value;
                    OnPropertyChanged(nameof(BIR11TypPodmiotuId));
                }
            }
        }

        #endregion

        #region private BIR11TypPodmiotu? _BIR11TypPodmiotu...

        private BIR11TypPodmiotu? _bir11TypPodmiotu;

        [Column(Order = 2)]
        [XmlIgnore]
        [ForeignKey(nameof(BIR11TypPodmiotuId))]
        [JsonProperty(nameof(BIR11TypPodmiotu), Order = 2)]
        public BIR11TypPodmiotu? BIR11TypPodmiotu
        {
            get => _bir11TypPodmiotu;
            set
            {
                if (value != _bir11TypPodmiotu)
                {
                    _bir11TypPodmiotu = value;
                    OnPropertyChanged(nameof(BIR11TypPodmiotu));
                }
            }
        }

        #endregion

        #region private Guid? _BIR11OsFizycznaDaneOgolneId...

        private Guid? _bir11OsFizycznaDaneOgolneId;

        [Column(Order = 2)]
        [XmlIgnore]
        [JsonProperty(nameof(BIR11OsFizycznaDaneOgolneId), Order = 2)]
        public Guid? BIR11OsFizycznaDaneOgolneId
        {
            get => _bir11OsFizycznaDaneOgolneId;
            set
            {
                if (value != _bir11OsFizycznaDaneOgolneId)
                {
                    _bir11OsFizycznaDaneOgolneId = value;
                    OnPropertyChanged(nameof(BIR11OsFizycznaDaneOgolneId));
                }
            }
        }

        #endregion

        #region private BIR11OsFizycznaDaneOgolne? _BIR11OsFizycznaDaneOgolne...

        private BIR11OsFizycznaDaneOgolne? _bir11OsFizycznaDaneOgolne;

        [Column(Order = 2)]
        [XmlIgnore]
        [ForeignKey(nameof(BIR11OsFizycznaDaneOgolneId))]
        [JsonProperty(nameof(BIR11OsFizycznaDaneOgolne), Order = 2)]
        public BIR11OsFizycznaDaneOgolne? BIR11OsFizycznaDaneOgolne
        {
            get => _bir11OsFizycznaDaneOgolne;
            set
            {
                if (value != _bir11OsFizycznaDaneOgolne)
                {
                    _bir11OsFizycznaDaneOgolne = value;
                    OnPropertyChanged(nameof(BIR11OsFizycznaDaneOgolne));
                }
            }
        }

        #endregion

        #region private Guid? _BIR11OsFizycznaDzialalnoscCeidgId...

        private Guid? _bir11OsFizycznaDzialalnoscCeidgId;

        [Column(Order = 2)]
        [XmlIgnore]
        [JsonProperty(nameof(BIR11OsFizycznaDzialalnoscCeidgId), Order = 2)]
        public Guid? BIR11OsFizycznaDzialalnoscCeidgId
        {
            get => _bir11OsFizycznaDzialalnoscCeidgId;
            set
            {
                if (value != _bir11OsFizycznaDzialalnoscCeidgId)
                {
                    _bir11OsFizycznaDzialalnoscCeidgId = value;
                    OnPropertyChanged(nameof(BIR11OsFizycznaDzialalnoscCeidgId));
                }
            }
        }

        #endregion

        #region private BIR11OsFizycznaDzialalnoscCeidg? _BIR11OsFizycznaDzialalnoscCeidg...

        private BIR11OsFizycznaDzialalnoscCeidg? _bir11OsFizycznaDzialalnoscCeidg;

        [Column(Order = 2)]
        [XmlIgnore]
        [ForeignKey(nameof(BIR11OsFizycznaDzialalnoscCeidgId))]
        [JsonProperty(nameof(BIR11OsFizycznaDzialalnoscCeidg), Order = 2)]
        public BIR11OsFizycznaDzialalnoscCeidg? BIR11OsFizycznaDzialalnoscCeidg
        {
            get => _bir11OsFizycznaDzialalnoscCeidg;
            set
            {
                if (value != _bir11OsFizycznaDzialalnoscCeidg)
                {
                    _bir11OsFizycznaDzialalnoscCeidg = value;
                    OnPropertyChanged(nameof(BIR11OsFizycznaDzialalnoscCeidg));
                }
            }
        }

        #endregion

        #region ICollection<BIR11OsFizycznaPkd>...

        private ICollection<BIR11OsFizycznaPkd> _bir11OsFizycznaPkd;

        /// <summary>
        ///     Kolekcja elementów BIR11OsFizycznaPkd, relacja do encji BIR11OsFizycznaPkd
        ///     Collection of BIR11OsFizycznaPkd elements, relation to the BIR11OsFizycznaPkd entity
        /// </summary>
        [XmlIgnore]
        [JsonProperty(nameof(BIR11OsFizycznaPkd), Order = 2)]
        [InverseProperty("DaneSzukajPodmioty")]
        [Display(Name = "Elementy kolekcji BIR11OsFizycznaPkd",
            Prompt = "Wybierz elementy kolekcji BIR11OsFizycznaPkd",
            Description =
                "Kolekcja elementów BIR11OsFizycznaPkd, relacja do encji BIR11OsFizycznaPkd")]
        public virtual ICollection<BIR11OsFizycznaPkd> BIR11OsFizycznaPkd
        {
            get => _bir11OsFizycznaPkd;
            set
            {
                if (!Equals(value, _bir11OsFizycznaPkd))
                {
                    _bir11OsFizycznaPkd = value;
                    OnPropertyChanged(nameof(BIR11OsFizycznaPkd));
                }
            }
        }

        #endregion

        #region ICollection<BIR11OsFizycznaListaJednLokalnych>...

        private ICollection<BIR11OsFizycznaListaJednLokalnych> _bir11OsFizycznaListaJednLokalnych;

        /// <summary>
        ///     Kolekcja elementów BIR11OsFizycznaListaJednLokalnych, relacja do encji BIR11OsFizycznaListaJednLokalnych
        ///     Collection of BIR11OsFizycznaListaJednLokalnych elements, relation to the BIR11OsFizycznaListaJednLokalnych entity
        /// </summary>
        [XmlIgnore]
        [JsonProperty(nameof(BIR11OsFizycznaListaJednLokalnych), Order = 2)]
        [InverseProperty("DaneSzukajPodmioty")]
        [Display(Name = "Elementy kolekcji BIR11OsFizycznaListaJednLokalnych",
            Prompt = "Wybierz elementy kolekcji BIR11OsFizycznaListaJednLokalnych",
            Description =
                "Kolekcja elementów BIR11OsFizycznaListaJednLokalnych, relacja do encji BIR11OsFizycznaListaJednLokalnych")]
        public virtual ICollection<BIR11OsFizycznaListaJednLokalnych> BIR11OsFizycznaListaJednLokalnych
        {
            get => _bir11OsFizycznaListaJednLokalnych;
            set
            {
                if (!Equals(value, _bir11OsFizycznaListaJednLokalnych))
                {
                    _bir11OsFizycznaListaJednLokalnych = value;
                    OnPropertyChanged(nameof(BIR11OsFizycznaListaJednLokalnych));
                }
            }
        }

        #endregion

        #region private Guid? _BIR11OsFizycznaDzialalnoscRolniczaId...

        private Guid? _bir11OsFizycznaDzialalnoscRolniczaId;

        [Column(Order = 2)]
        [XmlIgnore]
        [JsonProperty(nameof(BIR11OsFizycznaDzialalnoscRolniczaId), Order = 2)]
        public Guid? BIR11OsFizycznaDzialalnoscRolniczaId
        {
            get => _bir11OsFizycznaDzialalnoscRolniczaId;
            set
            {
                if (value != _bir11OsFizycznaDzialalnoscRolniczaId)
                {
                    _bir11OsFizycznaDzialalnoscRolniczaId = value;
                    OnPropertyChanged(nameof(BIR11OsFizycznaDzialalnoscRolniczaId));
                }
            }
        }

        #endregion

        #region private BIR11OsFizycznaDzialalnoscRolnicza? _BIR11OsFizycznaDzialalnoscRolnicza...

        private BIR11OsFizycznaDzialalnoscRolnicza? _bir11OsFizycznaDzialalnoscRolnicza;

        [Column(Order = 2)]
        [XmlIgnore]
        [ForeignKey(nameof(BIR11OsFizycznaDzialalnoscRolniczaId))]
        [JsonProperty(nameof(BIR11OsFizycznaDzialalnoscRolnicza), Order = 2)]
        public BIR11OsFizycznaDzialalnoscRolnicza? BIR11OsFizycznaDzialalnoscRolnicza
        {
            get => _bir11OsFizycznaDzialalnoscRolnicza;
            set
            {
                if (value != _bir11OsFizycznaDzialalnoscRolnicza)
                {
                    _bir11OsFizycznaDzialalnoscRolnicza = value;
                    OnPropertyChanged(nameof(BIR11OsFizycznaDzialalnoscRolnicza));
                }
            }
        }

        #endregion

        #region private Guid? _BIR11OsFizycznaDzialalnoscPozostalaId...

        private Guid? _bir11OsFizycznaDzialalnoscPozostalaId;

        [Column(Order = 2)]
        [XmlIgnore]
        [JsonProperty(nameof(BIR11OsFizycznaDzialalnoscPozostalaId), Order = 2)]
        public Guid? BIR11OsFizycznaDzialalnoscPozostalaId
        {
            get => _bir11OsFizycznaDzialalnoscPozostalaId;
            set
            {
                if (value != _bir11OsFizycznaDzialalnoscPozostalaId)
                {
                    _bir11OsFizycznaDzialalnoscPozostalaId = value;
                    OnPropertyChanged(nameof(BIR11OsFizycznaDzialalnoscPozostalaId));
                }
            }
        }

        #endregion

        #region private BIR11OsFizycznaDzialalnoscPozostala? _BIR11OsFizycznaDzialalnoscPozostala...

        private BIR11OsFizycznaDzialalnoscPozostala? _bir11OsFizycznaDzialalnoscPozostala;

        [Column(Order = 2)]
        [XmlIgnore]
        [ForeignKey(nameof(BIR11OsFizycznaDzialalnoscPozostalaId))]
        [JsonProperty(nameof(BIR11OsFizycznaDzialalnoscPozostala), Order = 2)]
        public BIR11OsFizycznaDzialalnoscPozostala? BIR11OsFizycznaDzialalnoscPozostala
        {
            get => _bir11OsFizycznaDzialalnoscPozostala;
            set
            {
                if (value != _bir11OsFizycznaDzialalnoscPozostala)
                {
                    _bir11OsFizycznaDzialalnoscPozostala = value;
                    OnPropertyChanged(nameof(BIR11OsFizycznaDzialalnoscPozostala));
                }
            }
        }

        #endregion

        #region private Guid? _BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id...

        private Guid? _bir11OsFizycznaDzialalnoscSkreslonaDo20141108Id;

        [Column(Order = 2)]
        [XmlIgnore]
        [JsonProperty(nameof(BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id), Order = 2)]
        public Guid? BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id
        {
            get => _bir11OsFizycznaDzialalnoscSkreslonaDo20141108Id;
            set
            {
                if (value != _bir11OsFizycznaDzialalnoscSkreslonaDo20141108Id)
                {
                    _bir11OsFizycznaDzialalnoscSkreslonaDo20141108Id = value;
                    OnPropertyChanged(nameof(BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id));
                }
            }
        }

        #endregion

        #region private BIR11OsFizycznaDzialalnoscSkreslonaDo20141108?...

        private BIR11OsFizycznaDzialalnoscSkreslonaDo20141108? _bir11OsFizycznaDzialalnoscSkreslonaDo20141108;

        [Column(Order = 2)]
        [XmlIgnore]
        [ForeignKey(nameof(BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id))]
        [JsonProperty(nameof(BIR11OsFizycznaDzialalnoscSkreslonaDo20141108), Order = 2)]
        public BIR11OsFizycznaDzialalnoscSkreslonaDo20141108? BIR11OsFizycznaDzialalnoscSkreslonaDo20141108
        {
            get => _bir11OsFizycznaDzialalnoscSkreslonaDo20141108;
            set
            {
                if (value != _bir11OsFizycznaDzialalnoscSkreslonaDo20141108)
                {
                    _bir11OsFizycznaDzialalnoscSkreslonaDo20141108 = value;
                    OnPropertyChanged(nameof(BIR11OsFizycznaDzialalnoscSkreslonaDo20141108));
                }
            }
        }

        #endregion

        #region private Guid? _BIR11JednLokalnaOsPrawnejId...

        private Guid? _bir11JednLokalnaOsPrawnejId;

        [Column(Order = 2)]
        [XmlIgnore]
        [JsonProperty(nameof(BIR11JednLokalnaOsPrawnejId), Order = 2)]
        public Guid? BIR11JednLokalnaOsPrawnejId
        {
            get => _bir11JednLokalnaOsPrawnejId;
            set
            {
                if (value != _bir11JednLokalnaOsPrawnejId)
                {
                    _bir11JednLokalnaOsPrawnejId = value;
                    OnPropertyChanged(nameof(BIR11JednLokalnaOsPrawnejId));
                }
            }
        }

        #endregion

        #region private BIR11JednLokalnaOsPrawnej? _BIR11JednLokalnaOsPrawnej...

        private BIR11JednLokalnaOsPrawnej? _bir11JednLokalnaOsPrawnej;

        [Column(Order = 2)]
        [XmlIgnore]
        [ForeignKey(nameof(BIR11JednLokalnaOsPrawnejId))]
        [JsonProperty(nameof(BIR11JednLokalnaOsPrawnej), Order = 2)]
        public BIR11JednLokalnaOsPrawnej? BIR11JednLokalnaOsPrawnej
        {
            get => _bir11JednLokalnaOsPrawnej;
            set
            {
                if (value != _bir11JednLokalnaOsPrawnej)
                {
                    _bir11JednLokalnaOsPrawnej = value;
                    OnPropertyChanged(nameof(BIR11JednLokalnaOsPrawnej));
                }
            }
        }

        #endregion

        #region ICollection<BIR11JednLokalnaOsPrawnejPkd>...

        private ICollection<BIR11JednLokalnaOsPrawnejPkd> _bir11JednLokalnaOsPrawnejPkd;

        /// <summary>
        ///     Kolekcja elementów BIR11JednLokalnaOsPrawnejPkd, relacja do encji BIR11JednLokalnaOsPrawnejPkd
        ///     Collection of BIR11JednLokalnaOsPrawnejPkd elements, relation to the BIR11JednLokalnaOsPrawnejPkd entity
        /// </summary>
        [XmlIgnore]
        [JsonProperty(nameof(BIR11JednLokalnaOsPrawnejPkd), Order = 2)]
        [InverseProperty("DaneSzukajPodmioty")]
        [Display(Name = "Elementy kolekcji BIR11JednLokalnaOsPrawnejPkd",
            Prompt = "Wybierz elementy kolekcji BIR11JednLokalnaOsPrawnejPkd",
            Description =
                "Kolekcja elementów BIR11JednLokalnaOsPrawnejPkd, relacja do encji BIR11JednLokalnaOsPrawnejPkd")]
        public virtual ICollection<BIR11JednLokalnaOsPrawnejPkd> BIR11JednLokalnaOsPrawnejPkd
        {
            get => _bir11JednLokalnaOsPrawnejPkd;
            set
            {
                if (!Equals(value, _bir11JednLokalnaOsPrawnejPkd))
                {
                    _bir11JednLokalnaOsPrawnejPkd = value;
                    OnPropertyChanged(nameof(BIR11JednLokalnaOsPrawnejPkd));
                }
            }
        }

        #endregion

        #region private Guid? _BIR11JednLokalnaOsFizycznejId...

        private Guid? _bir11JednLokalnaOsFizycznejId;

        [Column(Order = 2)]
        [XmlIgnore]
        [JsonProperty(nameof(BIR11JednLokalnaOsFizycznejId), Order = 2)]
        public Guid? BIR11JednLokalnaOsFizycznejId
        {
            get => _bir11JednLokalnaOsFizycznejId;
            set
            {
                if (value != _bir11JednLokalnaOsFizycznejId)
                {
                    _bir11JednLokalnaOsFizycznejId = value;
                    OnPropertyChanged(nameof(BIR11JednLokalnaOsFizycznejId));
                }
            }
        }

        #endregion

        #region private BIR11JednLokalnaOsFizycznej? _BIR11JednLokalnaOsFizycznej...

        private BIR11JednLokalnaOsFizycznej? _bir11JednLokalnaOsFizycznej;

        [Column(Order = 2)]
        [XmlIgnore]
        [ForeignKey(nameof(BIR11JednLokalnaOsFizycznejId))]
        [JsonProperty(nameof(BIR11JednLokalnaOsFizycznej), Order = 2)]
        public BIR11JednLokalnaOsFizycznej? BIR11JednLokalnaOsFizycznej
        {
            get => _bir11JednLokalnaOsFizycznej;
            set
            {
                if (value != _bir11JednLokalnaOsFizycznej)
                {
                    _bir11JednLokalnaOsFizycznej = value;
                    OnPropertyChanged(nameof(BIR11JednLokalnaOsFizycznej));
                }
            }
        }

        #endregion

        #region ICollection<BIR11JednLokalnaOsFizycznejPkd>...

        private ICollection<BIR11JednLokalnaOsFizycznejPkd> _bir11JednLokalnaOsFizycznejPkd;

        /// <summary>
        ///     Kolekcja elementów BIR11JednLokalnaOsFizycznejPkd, relacja do encji BIR11JednLokalnaOsFizycznejPkd
        ///     Collection of BIR11JednLokalnaOsFizycznejPkd elements, relation to the BIR11JednLokalnaOsFizycznejPkd entity
        /// </summary>
        [XmlIgnore]
        [JsonProperty(nameof(BIR11JednLokalnaOsFizycznejPkd), Order = 2)]
        [InverseProperty("DaneSzukajPodmioty")]
        [Display(Name = "Elementy kolekcji BIR11JednLokalnaOsFizycznejPkd",
            Prompt = "Wybierz elementy kolekcji BIR11JednLokalnaOsFizycznejPkd",
            Description =
                "Kolekcja elementów BIR11JednLokalnaOsFizycznejPkd, relacja do encji BIR11JednLokalnaOsFizycznejPkd")]
        public virtual ICollection<BIR11JednLokalnaOsFizycznejPkd> BIR11JednLokalnaOsFizycznejPkd
        {
            get => _bir11JednLokalnaOsFizycznejPkd;
            set
            {
                if (!Equals(value, _bir11JednLokalnaOsFizycznejPkd))
                {
                    _bir11JednLokalnaOsFizycznejPkd = value;
                    OnPropertyChanged(nameof(BIR11JednLokalnaOsFizycznejPkd));
                }
            }
        }

        #endregion

        #region private string? _regon; public string? Regon

        private string? _regon;

        /// Regon
        /// Regon
        [Column(Order = 2)]
        [XmlElement("Regon")]
        [JsonProperty(nameof(Regon), Order = 2)]
        [Display(Name = "Regon", Prompt = "Wpisz Regon", Description = "Regon")]
        [StringLength(14)]
        [MaxLength(14)]

        public string? Regon
        {
            get => _regon;
            set
            {
                if (value != _regon)
                {
                    _regon = value;
                    OnPropertyChanged(nameof(Regon));
                }
            }
        }

        #endregion

        #region private string? _nip; public string? Nip

        private string? _nip;

        /// Nip
        /// Nip
        [Column(Order = 2)]
        [XmlElement("Nip")]
        [JsonProperty(nameof(Nip), Order = 2)]
        [Display(Name = "Nip", Prompt = "Wpisz Nip", Description = "Nip")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? Nip
        {
            get => _nip;
            set
            {
                if (value != _nip)
                {
                    _nip = value;
                    OnPropertyChanged(nameof(Nip));
                }
            }
        }

        #endregion

        #region private string? _statusnip; public string? StatusNip

        private string? _statusnip;

        /// Status nip
        /// Status nip
        [Column(Order = 2)]
        [XmlElement("StatusNip")]
        [JsonProperty(nameof(StatusNip), Order = 2)]
        [Display(Name = "Status nip", Prompt = "Wpisz Status nip", Description = "Status nip")]
        [StringLength(12)]
        [MaxLength(12)]

        public string? StatusNip
        {
            get => _statusnip;
            set
            {
                if (value != _statusnip)
                {
                    _statusnip = value;
                    OnPropertyChanged(nameof(StatusNip));
                }
            }
        }

        #endregion

        #region private string? _nazwa; public string? Nazwa

        private string? _nazwa;

        /// Nazwa
        /// Nazwa
        [Column(Order = 2)]
        [XmlElement("Nazwa")]
        [JsonProperty(nameof(Nazwa), Order = 2)]
        [Display(Name = "Nazwa", Prompt = "Wpisz Nazwa", Description = "Nazwa")]
        [StringLength(2000)]
        [MaxLength(2000)]

        public string? Nazwa
        {
            get => _nazwa;
            set
            {
                if (value != _nazwa)
                {
                    _nazwa = value;
                    OnPropertyChanged(nameof(Nazwa));
                }
            }
        }

        #endregion

        #region private string? _wojewodztwo; public string? Wojewodztwo

        private string? _wojewodztwo;

        /// Wojewodztwo
        /// Wojewodztwo
        [Column(Order = 2)]
        [XmlElement("Wojewodztwo")]
        [JsonProperty(nameof(Wojewodztwo), Order = 2)]
        [Display(Name = "Wojewodztwo", Prompt = "Wpisz Wojewodztwo", Description = "Wojewodztwo")]
        [StringLength(200)]
        [MaxLength(200)]

        public string? Wojewodztwo
        {
            get => _wojewodztwo;
            set
            {
                if (value != _wojewodztwo)
                {
                    _wojewodztwo = value;
                    OnPropertyChanged(nameof(Wojewodztwo));
                }
            }
        }

        #endregion

        #region private string? _powiat; public string? Powiat

        private string? _powiat;

        /// Powiat
        /// Powiat
        [Column(Order = 2)]
        [XmlElement("Powiat")]
        [JsonProperty(nameof(Powiat), Order = 2)]
        [Display(Name = "Powiat", Prompt = "Wpisz Powiat", Description = "Powiat")]
        [StringLength(200)]
        [MaxLength(200)]

        public string? Powiat
        {
            get => _powiat;
            set
            {
                if (value != _powiat)
                {
                    _powiat = value;
                    OnPropertyChanged(nameof(Powiat));
                }
            }
        }

        #endregion

        #region private string? _gmina; public string? Gmina

        private string? _gmina;

        /// Gmina
        /// Gmina
        [Column(Order = 2)]
        [XmlElement("Gmina")]
        [JsonProperty(nameof(Gmina), Order = 2)]
        [Display(Name = "Gmina", Prompt = "Wpisz Gmina", Description = "Gmina")]
        [StringLength(200)]
        [MaxLength(200)]

        public string? Gmina
        {
            get => _gmina;
            set
            {
                if (value != _gmina)
                {
                    _gmina = value;
                    OnPropertyChanged(nameof(Gmina));
                }
            }
        }

        #endregion

        #region private string? _miejscowosc; public string? Miejscowosc

        private string? _miejscowosc;

        /// Miejscowosc
        /// Miejscowosc
        [Column(Order = 2)]
        [XmlElement("Miejscowosc")]
        [JsonProperty(nameof(Miejscowosc), Order = 2)]
        [Display(Name = "Miejscowosc", Prompt = "Wpisz Miejscowosc", Description = "Miejscowosc")]
        [StringLength(200)]
        [MaxLength(200)]

        public string? Miejscowosc
        {
            get => _miejscowosc;
            set
            {
                if (value != _miejscowosc)
                {
                    _miejscowosc = value;
                    OnPropertyChanged(nameof(Miejscowosc));
                }
            }
        }

        #endregion

        #region private string? _kodpocztowy; public string? KodPocztowy

        private string? _kodpocztowy;

        /// Kod pocztowy
        /// Kod pocztowy
        [Column(Order = 2)]
        [XmlElement("KodPocztowy")]
        [JsonProperty(nameof(KodPocztowy), Order = 2)]
        [Display(Name = "Kod pocztowy", Prompt = "Wpisz Kod pocztowy", Description = "Kod pocztowy")]
        [StringLength(12)]
        [MaxLength(12)]

        public string? KodPocztowy
        {
            get => _kodpocztowy;
            set
            {
                if (value != _kodpocztowy)
                {
                    _kodpocztowy = value;
                    OnPropertyChanged(nameof(KodPocztowy));
                }
            }
        }

        #endregion

        #region private string? _ulica; public string? Ulica

        private string? _ulica;

        /// Ulica
        /// Ulica
        [Column(Order = 2)]
        [XmlElement("Ulica")]
        [JsonProperty(nameof(Ulica), Order = 2)]
        [Display(Name = "Ulica", Prompt = "Wpisz Ulica", Description = "Ulica")]
        [StringLength(200)]
        [MaxLength(200)]

        public string? Ulica
        {
            get => _ulica;
            set
            {
                if (value != _ulica)
                {
                    _ulica = value;
                    OnPropertyChanged(nameof(Ulica));
                }
            }
        }

        #endregion

        #region private string? _nrnieruchomosci; public string? NrNieruchomosci

        private string? _nrnieruchomosci;

        /// Nr nieruchomosci
        /// Nr nieruchomosci
        [Column(Order = 2)]
        [XmlElement("NrNieruchomosci")]
        [JsonProperty(nameof(NrNieruchomosci), Order = 2)]
        [Display(Name = "Nr nieruchomosci", Prompt = "Wpisz Nr nieruchomosci", Description = "Nr nieruchomosci")]
        [StringLength(20)]
        [MaxLength(20)]

        public string? NrNieruchomosci
        {
            get => _nrnieruchomosci;
            set
            {
                if (value != _nrnieruchomosci)
                {
                    _nrnieruchomosci = value;
                    OnPropertyChanged(nameof(NrNieruchomosci));
                }
            }
        }

        #endregion

        #region private string? _nrlokalu; public string? NrLokalu

        private string? _nrlokalu;

        /// Nr lokalu
        /// Nr lokalu
        [Column(Order = 2)]
        [XmlElement("NrLokalu")]
        [JsonProperty(nameof(NrLokalu), Order = 2)]
        [Display(Name = "Nr lokalu", Prompt = "Wpisz Nr lokalu", Description = "Nr lokalu")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? NrLokalu
        {
            get => _nrlokalu;
            set
            {
                if (value != _nrlokalu)
                {
                    _nrlokalu = value;
                    OnPropertyChanged(nameof(NrLokalu));
                }
            }
        }

        #endregion

        #region private string? _typ; public string? Typ

        private string? _typ;

        /// Typ
        /// Typ
        [Column(Order = 2)]
        [XmlElement("Typ")]
        [JsonProperty(nameof(Typ), Order = 2)]
        [Display(Name = "Typ", Prompt = "Wpisz Typ", Description = "Typ")]
        [StringLength(2)]
        [MaxLength(2)]

        public string? Typ
        {
            get => _typ;
            set
            {
                if (value != _typ)
                {
                    _typ = value;
                    OnPropertyChanged(nameof(Typ));
                }
            }
        }

        #endregion

        #region private int? _silosid; public int? SilosID

        private int? _silosid;

        /// Silos i d
        /// Silos i d
        [Column(Order = 2)]
        [XmlElement("SilosID")]
        [JsonProperty(nameof(SilosID), Order = 2)]
        [Display(Name = "Silos id", Prompt = "Wpisz Silos id", Description = "Silos id")]
        [Range(int.MinValue, int.MaxValue)]
        public int? SilosID
        {
            get => _silosid;
            set
            {
                if (value != _silosid)
                {
                    _silosid = value;
                    OnPropertyChanged(nameof(SilosID));
                }
            }
        }

        #endregion

        #region private string? _datazakonczeniadzialalnosci; public string? DataZakonczeniaDzialalnosci

        private string? _datazakonczeniadzialalnosci;

        /// Data zakonczenia dzialalnosci
        /// Data zakonczenia dzialalnosci
        [Column(Order = 2)]
        [XmlElement("DataZakonczeniaDzialalnosci")]
        [JsonProperty(nameof(DataZakonczeniaDzialalnosci), Order = 2)]
        [Display(Name = "Data zakonczenia dzialalnosci", Prompt = "Wpisz Data zakonczenia dzialalnosci",
            Description = "Data zakonczenia dzialalnosci")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? DataZakonczeniaDzialalnosci
        {
            get => _datazakonczeniadzialalnosci;
            set
            {
                if (value != _datazakonczeniadzialalnosci)
                {
                    _datazakonczeniadzialalnosci = value;
                    OnPropertyChanged(nameof(DataZakonczeniaDzialalnosci));
                }
            }
        }

        #endregion

        #region private string? _miejscowoscpoczty; public string? MiejscowoscPoczty

        private string? _miejscowoscpoczty;

        /// Miejscowosc poczty
        /// Miejscowosc poczty
        [Column(Order = 2)]
        [XmlElement("MiejscowoscPoczty")]
        [JsonProperty(nameof(MiejscowoscPoczty), Order = 2)]
        [Display(Name = "Miejscowosc poczty", Prompt = "Wpisz Miejscowosc poczty", Description = "Miejscowosc poczty")]
        [StringLength(200)]
        [MaxLength(200)]

        public string? MiejscowoscPoczty
        {
            get => _miejscowoscpoczty;
            set
            {
                if (value != _miejscowoscpoczty)
                {
                    _miejscowoscpoczty = value;
                    OnPropertyChanged(nameof(MiejscowoscPoczty));
                }
            }
        }

        #endregion
    }

    #endregion
}

#endregion
