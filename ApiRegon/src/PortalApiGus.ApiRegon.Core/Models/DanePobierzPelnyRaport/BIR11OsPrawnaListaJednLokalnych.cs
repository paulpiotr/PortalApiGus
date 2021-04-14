#region using

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;
using NetAppCommon.Helpers.Xmls;
using Newtonsoft.Json;
using PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmioty;

#endregion

#nullable enable annotations

#region namespace

namespace PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport
{
    #region public class BIR11OsPrawnaListaJednLokalnych : BaseEntity

    /// <summary>
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport BIR11OsPrawnaListaJednLokalnych
    ///     Data model of entities found in the basic report
    /// </summary>
    [Table(nameof(BIR11OsPrawnaListaJednLokalnych), Schema = "pagard")]
    [JsonObject(nameof(BIR11OsPrawnaListaJednLokalnych))]
    [Display(Name = "BIR11OsPrawnaListaJednLokalnych", Description = "BIR11OsPrawnaListaJednLokalnych")]
    [Serializable]
    [XmlRoot("dane")]
    [Index(nameof(LokprawRegon14))]
    [Index(nameof(LokprawNazwa))]
    [Index(nameof(LokprawAdSiedzKrajSymbol))]
    [Index(nameof(LokprawAdSiedzWojewodztwoSymbol))]
    [Index(nameof(LokprawAdSiedzPowiatSymbol))]
    [Index(nameof(LokprawAdSiedzGminaSymbol))]
    [Index(nameof(LokprawAdSiedzKodPocztowy))]
    [Index(nameof(LokprawAdSiedzMiejscowoscPocztySymbol))]
    [Index(nameof(LokprawAdSiedzMiejscowoscSymbol))]
    [Index(nameof(LokprawAdSiedzUlicaSymbol))]
    [Index(nameof(LokprawAdSiedzNumerNieruchomosci))]
    [Index(nameof(LokprawAdSiedzNumerLokalu))]
    [Index(nameof(LokprawAdSiedzNietypoweMiejsceLokalizacji))]
    [Index(nameof(LokprawAdSiedzWojewodztwoNazwa))]
    [Index(nameof(LokprawAdSiedzPowiatNazwa))]
    [Index(nameof(LokprawAdSiedzGminaNazwa))]
    [Index(nameof(LokprawAdSiedzMiejscowoscNazwa))]
    [Index(nameof(LokprawAdSiedzMiejscowoscPocztyNazwa))]
    [Index(nameof(LokprawAdSiedzUlicaNazwa))]
    [Index(nameof(LokprawDataPowstania))]
    [Index(nameof(LokprawDataRozpoczeciaDzialalnosci))]
    [Index(nameof(LokprawDataWpisuDoRegon))]
    [Index(nameof(LokprawDataZawieszeniaDzialalnosci))]
    [Index(nameof(LokprawDataWznowieniaDzialalnosci))]
    [Index(nameof(LokprawDataZakonczeniaDzialalnosci))]
    [Index(nameof(LokprawDataSkresleniaZRegon))]
    public class BIR11OsPrawnaListaJednLokalnych : DanePobierzPelnyRaport
    {
        #region public override ICollection<TModel> CreateCollection<TModel>...

        public override ICollection<TModel> CreateCollection<TModel>(
            DaneSzukajPodmioty.DaneSzukajPodmioty daneSzukajPodmioty, string pRegon, string pNazwaRaportu, string xml,
            ICollection<MessageInspector> messageInspectorCollection = null!)
        {
            ICollection<BIR11OsPrawnaListaJednLokalnych> collection =
                (ICollection<BIR11OsPrawnaListaJednLokalnych>)XmlHelper
                    .DeserializeXmlFromString<DanePobierzPelnyRaportResult<BIR11OsPrawnaListaJednLokalnych>>(xml)
                    .Dane ??
                new Collection<BIR11OsPrawnaListaJednLokalnych> {new()};
            DaneSzukajPodmiotyKomunikatyOBledach error =
                XmlHelper.DeserializeXmlFromString<DaneSzukajPodmiotyKomunikatyOBledach>(
                    xml);
            foreach (BIR11OsPrawnaListaJednLokalnych item in collection)
            {
                item.DaneSzukajPodmiotyKomunikatyOBledach = error;
                if (null != messageInspectorCollection && messageInspectorCollection.Count > 0)
                {
                    item.BIR11OsPrawnaListaJednLokalnychMessageInspector =
                        new List<BIR11OsPrawnaListaJednLokalnychMessageInspector>();
                    foreach(MessageInspector messageInspector in messageInspectorCollection)
                    {
                        item.BIR11OsPrawnaListaJednLokalnychMessageInspector.Add(
                            new BIR11OsPrawnaListaJednLokalnychMessageInspector(item, messageInspector));
                    }
                }
            }

            return (ICollection<TModel>)collection;
        }

        #endregion

        #region private Guid? _daneSzukajPodmiotyId...

        private Guid? _daneSzukajPodmiotyId;

        /// <summary>
        ///     Identyfikator podmiotu, relacja do encji DaneSzukajPodmioty
        ///     Entity identifier, relation to the entity DaneSzukajPodmioty
        /// </summary>
        [Column(Order = 2)]
        [XmlIgnore]
        [JsonProperty(nameof(DaneSzukajPodmiotyId), Order = 2)]
        [Display(Name = "Identyfikator podmiotu", Prompt = "Wybierz lub wpisz identyfikator podmiotu",
            Description = "Identyfikator podmiotu, relacja do encji DaneSzukajPodmioty")]
        public Guid? DaneSzukajPodmiotyId
        {
            get => _daneSzukajPodmiotyId;
            set
            {
                if (value != _daneSzukajPodmiotyId)
                {
                    _daneSzukajPodmiotyId = value;
                    OnPropertyChanged(nameof(DaneSzukajPodmiotyId));
                }
            }
        }

        #endregion

        #region private DaneSzukajPodmioty? _daneSzukajPodmioty...

        private DaneSzukajPodmioty.DaneSzukajPodmioty? _daneSzukajPodmioty;

        /// <summary>
        ///     Podmiot, relacja do encji DaneSzukajPodmioty
        ///     The entity to entity relationship DaneSzukajPodmioty
        /// </summary>
        [Column(Order = 2)]
        [XmlIgnore]
        [ForeignKey(nameof(DaneSzukajPodmiotyId))]
        [JsonProperty(nameof(DaneSzukajPodmioty), Order = 2)]
        [Display(Name = "Podmiot", Prompt = "Uzupełnij lub wybierz podmiot",
            Description = "Podmiot, relacja do encji DaneSzukajPodmioty")]
        public virtual DaneSzukajPodmioty.DaneSzukajPodmioty? DaneSzukajPodmioty
        {
            get => _daneSzukajPodmioty;
            set
            {
                if (value != _daneSzukajPodmioty)
                {
                    _daneSzukajPodmioty = value;
                    OnPropertyChanged(nameof(DaneSzukajPodmioty));
                }
            }
        }

        #endregion

        #region private ICollection<BIR11OsPrawnaListaJednLokalnychMessageInspector>...

        private ICollection<BIR11OsPrawnaListaJednLokalnychMessageInspector> _bir11OsPrawnaListaJednLokalnychMessageInspector;

        /// <summary>
        ///     Kolekcja elementów inspektora wiadomości usługi, relacja do encji DaneSzukajPodmioty, zawiera informacje dotyczące
        ///     przetwarzania żądań
        ///     Service Message Inspector Item Collection, DaneSzukajPodmioty relationship, contains information about request
        ///     processing
        /// </summary>
        [XmlIgnore]
        [JsonProperty(nameof(BIR11OsPrawnaListaJednLokalnychMessageInspector), Order = 2)]
        //[InverseProperty("DaneSzukajPodmioty")]
        //[ForeignKey("DaneSzukajPodmiotyId")]
        [Display(Name = "Inspektor wiadomości usługi",
            Prompt = "Wybierz elementy kolekcji inspektora wiadomości usługi",
            Description =
                "Kolekcja elementów inspektora wiadomości usługi")]
        public virtual ICollection<BIR11OsPrawnaListaJednLokalnychMessageInspector> BIR11OsPrawnaListaJednLokalnychMessageInspector
        {
            get => _bir11OsPrawnaListaJednLokalnychMessageInspector;
            set
            {
                if (!Equals(value, _bir11OsPrawnaListaJednLokalnychMessageInspector))
                {
                    _bir11OsPrawnaListaJednLokalnychMessageInspector = value;
                    OnPropertyChanged(nameof(BIR11OsPrawnaListaJednLokalnychMessageInspector));
                }
            }
        }

        #endregion

        #region private string? _lokprawRegon14; public string? LokprawRegon14

        private string? _lokprawRegon14;

        /// Lokpraw regon14
        /// Lokpraw regon14
        [Column(Order = 2)]
        [XmlElement("lokpraw_regon14")]
        [JsonProperty(nameof(LokprawRegon14), Order = 2)]
        [Display(Name = "Lokpraw regon14", Prompt = "Wpisz Lokpraw regon14", Description = "Lokpraw regon14")]
        [StringLength(14)]
        [MaxLength(14)]

        public string? LokprawRegon14
        {
            get => _lokprawRegon14;
            set
            {
                if (value != _lokprawRegon14)
                {
                    _lokprawRegon14 = value;
                    OnPropertyChanged(nameof(LokprawRegon14));
                }
            }
        }

        #endregion

        #region private string? _lokprawNazwa; public string? LokprawNazwa

        private string? _lokprawNazwa;

        /// Lokpraw nazwa
        /// Lokpraw nazwa
        [Column(Order = 2)]
        [XmlElement("lokpraw_nazwa")]
        [JsonProperty(nameof(LokprawNazwa), Order = 2)]
        [Display(Name = "Lokpraw nazwa", Prompt = "Wpisz Lokpraw nazwa", Description = "Lokpraw nazwa")]
        [StringLength(254)]
        [MaxLength(254)]

        public string? LokprawNazwa
        {
            get => _lokprawNazwa;
            set
            {
                if (value != _lokprawNazwa)
                {
                    _lokprawNazwa = value;
                    OnPropertyChanged(nameof(LokprawNazwa));
                }
            }
        }

        #endregion

        #region private string? _lokprawAdSiedzKrajSymbol; public string? LokprawAdSiedzKrajSymbol

        private string? _lokprawAdSiedzKrajSymbol;

        /// Lokpraw ad siedz kraj symbol
        /// Lokpraw ad siedz kraj symbol
        [Column(Order = 2)]
        [XmlElement("lokpraw_adSiedzKraj_Symbol")]
        [JsonProperty(nameof(LokprawAdSiedzKrajSymbol), Order = 2)]
        [Display(Name = "Lokpraw ad siedz kraj symbol", Prompt = "Wpisz Lokpraw ad siedz kraj symbol",
            Description = "Lokpraw ad siedz kraj symbol")]
        [StringLength(2)]
        [MaxLength(2)]

        public string? LokprawAdSiedzKrajSymbol
        {
            get => _lokprawAdSiedzKrajSymbol;
            set
            {
                if (value != _lokprawAdSiedzKrajSymbol)
                {
                    _lokprawAdSiedzKrajSymbol = value;
                    OnPropertyChanged(nameof(LokprawAdSiedzKrajSymbol));
                }
            }
        }

        #endregion

        #region private string? _lokprawAdSiedzWojewodztwoSymbol; public string? LokprawAdSiedzWojewodztwoSymbol

        private string? _lokprawAdSiedzWojewodztwoSymbol;

        /// Lokpraw ad siedz wojewodztwo symbol
        /// Lokpraw ad siedz wojewodztwo symbol
        [Column(Order = 2)]
        [XmlElement("lokpraw_adSiedzWojewodztwo_Symbol")]
        [JsonProperty(nameof(LokprawAdSiedzWojewodztwoSymbol), Order = 2)]
        [Display(Name = "Lokpraw ad siedz wojewodztwo symbol", Prompt = "Wpisz Lokpraw ad siedz wojewodztwo symbol",
            Description = "Lokpraw ad siedz wojewodztwo symbol")]
        [StringLength(2)]
        [MaxLength(2)]

        public string? LokprawAdSiedzWojewodztwoSymbol
        {
            get => _lokprawAdSiedzWojewodztwoSymbol;
            set
            {
                if (value != _lokprawAdSiedzWojewodztwoSymbol)
                {
                    _lokprawAdSiedzWojewodztwoSymbol = value;
                    OnPropertyChanged(nameof(LokprawAdSiedzWojewodztwoSymbol));
                }
            }
        }

        #endregion

        #region private string? _lokprawAdSiedzPowiatSymbol; public string? LokprawAdSiedzPowiatSymbol

        private string? _lokprawAdSiedzPowiatSymbol;

        /// Lokpraw ad siedz powiat symbol
        /// Lokpraw ad siedz powiat symbol
        [Column(Order = 2)]
        [XmlElement("lokpraw_adSiedzPowiat_Symbol")]
        [JsonProperty(nameof(LokprawAdSiedzPowiatSymbol), Order = 2)]
        [Display(Name = "Lokpraw ad siedz powiat symbol", Prompt = "Wpisz Lokpraw ad siedz powiat symbol",
            Description = "Lokpraw ad siedz powiat symbol")]
        [StringLength(2)]
        [MaxLength(2)]

        public string? LokprawAdSiedzPowiatSymbol
        {
            get => _lokprawAdSiedzPowiatSymbol;
            set
            {
                if (value != _lokprawAdSiedzPowiatSymbol)
                {
                    _lokprawAdSiedzPowiatSymbol = value;
                    OnPropertyChanged(nameof(LokprawAdSiedzPowiatSymbol));
                }
            }
        }

        #endregion

        #region private string? _lokprawAdSiedzGminaSymbol; public string? LokprawAdSiedzGminaSymbol

        private string? _lokprawAdSiedzGminaSymbol;

        /// Lokpraw ad siedz gmina symbol
        /// Lokpraw ad siedz gmina symbol
        [Column(Order = 2)]
        [XmlElement("lokpraw_adSiedzGmina_Symbol")]
        [JsonProperty(nameof(LokprawAdSiedzGminaSymbol), Order = 2)]
        [Display(Name = "Lokpraw ad siedz gmina symbol", Prompt = "Wpisz Lokpraw ad siedz gmina symbol",
            Description = "Lokpraw ad siedz gmina symbol")]
        [StringLength(3)]
        [MaxLength(3)]

        public string? LokprawAdSiedzGminaSymbol
        {
            get => _lokprawAdSiedzGminaSymbol;
            set
            {
                if (value != _lokprawAdSiedzGminaSymbol)
                {
                    _lokprawAdSiedzGminaSymbol = value;
                    OnPropertyChanged(nameof(LokprawAdSiedzGminaSymbol));
                }
            }
        }

        #endregion

        #region private string? _lokprawAdSiedzKodPocztowy; public string? LokprawAdSiedzKodPocztowy

        private string? _lokprawAdSiedzKodPocztowy;

        /// Lokpraw ad siedz kod pocztowy
        /// Lokpraw ad siedz kod pocztowy
        [Column(Order = 2)]
        [XmlElement("lokpraw_adSiedzKodPocztowy")]
        [JsonProperty(nameof(LokprawAdSiedzKodPocztowy), Order = 2)]
        [Display(Name = "Lokpraw ad siedz kod pocztowy", Prompt = "Wpisz Lokpraw ad siedz kod pocztowy",
            Description = "Lokpraw ad siedz kod pocztowy")]
        [StringLength(12)]
        [MaxLength(12)]

        public string? LokprawAdSiedzKodPocztowy
        {
            get => _lokprawAdSiedzKodPocztowy;
            set
            {
                if (value != _lokprawAdSiedzKodPocztowy)
                {
                    _lokprawAdSiedzKodPocztowy = value;
                    OnPropertyChanged(nameof(LokprawAdSiedzKodPocztowy));
                }
            }
        }

        #endregion

        #region private string? _lokprawAdSiedzMiejscowoscPocztySymbol; public string? LokprawAdSiedzMiejscowoscPocztySymbol

        private string? _lokprawAdSiedzMiejscowoscPocztySymbol;

        /// Lokpraw ad siedz miejscowosc poczty symbol
        /// Lokpraw ad siedz miejscowosc poczty symbol
        [Column(Order = 2)]
        [XmlElement("lokpraw_adSiedzMiejscowoscPoczty_Symbol")]
        [JsonProperty(nameof(LokprawAdSiedzMiejscowoscPocztySymbol), Order = 2)]
        [Display(Name = "Lokpraw ad siedz miejscowosc poczty symbol",
            Prompt = "Wpisz Lokpraw ad siedz miejscowosc poczty symbol",
            Description = "Lokpraw ad siedz miejscowosc poczty symbol")]
        [StringLength(7)]
        [MaxLength(7)]

        public string? LokprawAdSiedzMiejscowoscPocztySymbol
        {
            get => _lokprawAdSiedzMiejscowoscPocztySymbol;
            set
            {
                if (value != _lokprawAdSiedzMiejscowoscPocztySymbol)
                {
                    _lokprawAdSiedzMiejscowoscPocztySymbol = value;
                    OnPropertyChanged(nameof(LokprawAdSiedzMiejscowoscPocztySymbol));
                }
            }
        }

        #endregion

        #region private string? _lokprawAdSiedzMiejscowoscSymbol; public string? LokprawAdSiedzMiejscowoscSymbol

        private string? _lokprawAdSiedzMiejscowoscSymbol;

        /// Lokpraw ad siedz miejscowosc symbol
        /// Lokpraw ad siedz miejscowosc symbol
        [Column(Order = 2)]
        [XmlElement("lokpraw_adSiedzMiejscowosc_Symbol")]
        [JsonProperty(nameof(LokprawAdSiedzMiejscowoscSymbol), Order = 2)]
        [Display(Name = "Lokpraw ad siedz miejscowosc symbol", Prompt = "Wpisz Lokpraw ad siedz miejscowosc symbol",
            Description = "Lokpraw ad siedz miejscowosc symbol")]
        [StringLength(7)]
        [MaxLength(7)]

        public string? LokprawAdSiedzMiejscowoscSymbol
        {
            get => _lokprawAdSiedzMiejscowoscSymbol;
            set
            {
                if (value != _lokprawAdSiedzMiejscowoscSymbol)
                {
                    _lokprawAdSiedzMiejscowoscSymbol = value;
                    OnPropertyChanged(nameof(LokprawAdSiedzMiejscowoscSymbol));
                }
            }
        }

        #endregion

        #region private string? _lokprawAdSiedzUlicaSymbol; public string? LokprawAdSiedzUlicaSymbol

        private string? _lokprawAdSiedzUlicaSymbol;

        /// Lokpraw ad siedz ulica symbol
        /// Lokpraw ad siedz ulica symbol
        [Column(Order = 2)]
        [XmlElement("lokpraw_adSiedzUlica_Symbol")]
        [JsonProperty(nameof(LokprawAdSiedzUlicaSymbol), Order = 2)]
        [Display(Name = "Lokpraw ad siedz ulica symbol", Prompt = "Wpisz Lokpraw ad siedz ulica symbol",
            Description = "Lokpraw ad siedz ulica symbol")]
        [StringLength(5)]
        [MaxLength(5)]

        public string? LokprawAdSiedzUlicaSymbol
        {
            get => _lokprawAdSiedzUlicaSymbol;
            set
            {
                if (value != _lokprawAdSiedzUlicaSymbol)
                {
                    _lokprawAdSiedzUlicaSymbol = value;
                    OnPropertyChanged(nameof(LokprawAdSiedzUlicaSymbol));
                }
            }
        }

        #endregion

        #region private string? _lokprawAdSiedzNumerNieruchomosci; public string? LokprawAdSiedzNumerNieruchomosci

        private string? _lokprawAdSiedzNumerNieruchomosci;

        /// Lokpraw ad siedz numer nieruchomosci
        /// Lokpraw ad siedz numer nieruchomosci
        [Column(Order = 2)]
        [XmlElement("lokpraw_adSiedzNumerNieruchomosci")]
        [JsonProperty(nameof(LokprawAdSiedzNumerNieruchomosci), Order = 2)]
        [Display(Name = "Lokpraw ad siedz numer nieruchomosci", Prompt = "Wpisz Lokpraw ad siedz numer nieruchomosci",
            Description = "Lokpraw ad siedz numer nieruchomosci")]
        [StringLength(20)]
        [MaxLength(20)]

        public string? LokprawAdSiedzNumerNieruchomosci
        {
            get => _lokprawAdSiedzNumerNieruchomosci;
            set
            {
                if (value != _lokprawAdSiedzNumerNieruchomosci)
                {
                    _lokprawAdSiedzNumerNieruchomosci = value;
                    OnPropertyChanged(nameof(LokprawAdSiedzNumerNieruchomosci));
                }
            }
        }

        #endregion

        #region private string? _lokprawAdSiedzNumerLokalu; public string? LokprawAdSiedzNumerLokalu

        private string? _lokprawAdSiedzNumerLokalu;

        /// Lokpraw ad siedz numer lokalu
        /// Lokpraw ad siedz numer lokalu
        [Column(Order = 2)]
        [XmlElement("lokpraw_adSiedzNumerLokalu")]
        [JsonProperty(nameof(LokprawAdSiedzNumerLokalu), Order = 2)]
        [Display(Name = "Lokpraw ad siedz numer lokalu", Prompt = "Wpisz Lokpraw ad siedz numer lokalu",
            Description = "Lokpraw ad siedz numer lokalu")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? LokprawAdSiedzNumerLokalu
        {
            get => _lokprawAdSiedzNumerLokalu;
            set
            {
                if (value != _lokprawAdSiedzNumerLokalu)
                {
                    _lokprawAdSiedzNumerLokalu = value;
                    OnPropertyChanged(nameof(LokprawAdSiedzNumerLokalu));
                }
            }
        }

        #endregion

        #region private string? _lokprawAdSiedzNietypoweMiejsceLokalizacji; public string? LokprawAdSiedzNietypoweMiejsceLokalizacji

        private string? _lokprawAdSiedzNietypoweMiejsceLokalizacji;

        /// Lokpraw ad siedz nietypowe miejsce lokalizacji
        /// Lokpraw ad siedz nietypowe miejsce lokalizacji
        [Column(Order = 2)]
        [XmlElement("lokpraw_adSiedzNietypoweMiejsceLokalizacji")]
        [JsonProperty(nameof(LokprawAdSiedzNietypoweMiejsceLokalizacji), Order = 2)]
        [Display(Name = "Lokpraw ad siedz nietypowe miejsce lokalizacji",
            Prompt = "Wpisz Lokpraw ad siedz nietypowe miejsce lokalizacji",
            Description = "Lokpraw ad siedz nietypowe miejsce lokalizacji")]
        [StringLength(160)]
        [MaxLength(160)]

        public string? LokprawAdSiedzNietypoweMiejsceLokalizacji
        {
            get => _lokprawAdSiedzNietypoweMiejsceLokalizacji;
            set
            {
                if (value != _lokprawAdSiedzNietypoweMiejsceLokalizacji)
                {
                    _lokprawAdSiedzNietypoweMiejsceLokalizacji = value;
                    OnPropertyChanged(nameof(LokprawAdSiedzNietypoweMiejsceLokalizacji));
                }
            }
        }

        #endregion

        #region private string? _lokprawAdSiedzWojewodztwoNazwa; public string? LokprawAdSiedzWojewodztwoNazwa

        private string? _lokprawAdSiedzWojewodztwoNazwa;

        /// Lokpraw ad siedz wojewodztwo nazwa
        /// Lokpraw ad siedz wojewodztwo nazwa
        [Column(Order = 2)]
        [XmlElement("lokpraw_adSiedzWojewodztwo_Nazwa")]
        [JsonProperty(nameof(LokprawAdSiedzWojewodztwoNazwa), Order = 2)]
        [Display(Name = "Lokpraw ad siedz wojewodztwo nazwa", Prompt = "Wpisz Lokpraw ad siedz wojewodztwo nazwa",
            Description = "Lokpraw ad siedz wojewodztwo nazwa")]
        [StringLength(100)]
        [MaxLength(100)]

        public string? LokprawAdSiedzWojewodztwoNazwa
        {
            get => _lokprawAdSiedzWojewodztwoNazwa;
            set
            {
                if (value != _lokprawAdSiedzWojewodztwoNazwa)
                {
                    _lokprawAdSiedzWojewodztwoNazwa = value;
                    OnPropertyChanged(nameof(LokprawAdSiedzWojewodztwoNazwa));
                }
            }
        }

        #endregion

        #region private string? _lokprawAdSiedzPowiatNazwa; public string? LokprawAdSiedzPowiatNazwa

        private string? _lokprawAdSiedzPowiatNazwa;

        /// Lokpraw ad siedz powiat nazwa
        /// Lokpraw ad siedz powiat nazwa
        [Column(Order = 2)]
        [XmlElement("lokpraw_adSiedzPowiat_Nazwa")]
        [JsonProperty(nameof(LokprawAdSiedzPowiatNazwa), Order = 2)]
        [Display(Name = "Lokpraw ad siedz powiat nazwa", Prompt = "Wpisz Lokpraw ad siedz powiat nazwa",
            Description = "Lokpraw ad siedz powiat nazwa")]
        [StringLength(100)]
        [MaxLength(100)]

        public string? LokprawAdSiedzPowiatNazwa
        {
            get => _lokprawAdSiedzPowiatNazwa;
            set
            {
                if (value != _lokprawAdSiedzPowiatNazwa)
                {
                    _lokprawAdSiedzPowiatNazwa = value;
                    OnPropertyChanged(nameof(LokprawAdSiedzPowiatNazwa));
                }
            }
        }

        #endregion

        #region private string? _lokprawAdSiedzGminaNazwa; public string? LokprawAdSiedzGminaNazwa

        private string? _lokprawAdSiedzGminaNazwa;

        /// Lokpraw ad siedz gmina nazwa
        /// Lokpraw ad siedz gmina nazwa
        [Column(Order = 2)]
        [XmlElement("lokpraw_adSiedzGmina_Nazwa")]
        [JsonProperty(nameof(LokprawAdSiedzGminaNazwa), Order = 2)]
        [Display(Name = "Lokpraw ad siedz gmina nazwa", Prompt = "Wpisz Lokpraw ad siedz gmina nazwa",
            Description = "Lokpraw ad siedz gmina nazwa")]
        [StringLength(100)]
        [MaxLength(100)]

        public string? LokprawAdSiedzGminaNazwa
        {
            get => _lokprawAdSiedzGminaNazwa;
            set
            {
                if (value != _lokprawAdSiedzGminaNazwa)
                {
                    _lokprawAdSiedzGminaNazwa = value;
                    OnPropertyChanged(nameof(LokprawAdSiedzGminaNazwa));
                }
            }
        }

        #endregion

        #region private string? _lokprawAdSiedzMiejscowoscNazwa; public string? LokprawAdSiedzMiejscowoscNazwa

        private string? _lokprawAdSiedzMiejscowoscNazwa;

        /// Lokpraw ad siedz miejscowosc nazwa
        /// Lokpraw ad siedz miejscowosc nazwa
        [Column(Order = 2)]
        [XmlElement("lokpraw_adSiedzMiejscowosc_Nazwa")]
        [JsonProperty(nameof(LokprawAdSiedzMiejscowoscNazwa), Order = 2)]
        [Display(Name = "Lokpraw ad siedz miejscowosc nazwa", Prompt = "Wpisz Lokpraw ad siedz miejscowosc nazwa",
            Description = "Lokpraw ad siedz miejscowosc nazwa")]
        [StringLength(100)]
        [MaxLength(100)]

        public string? LokprawAdSiedzMiejscowoscNazwa
        {
            get => _lokprawAdSiedzMiejscowoscNazwa;
            set
            {
                if (value != _lokprawAdSiedzMiejscowoscNazwa)
                {
                    _lokprawAdSiedzMiejscowoscNazwa = value;
                    OnPropertyChanged(nameof(LokprawAdSiedzMiejscowoscNazwa));
                }
            }
        }

        #endregion

        #region private string? _lokprawAdSiedzMiejscowoscPocztyNazwa; public string? LokprawAdSiedzMiejscowoscPocztyNazwa

        private string? _lokprawAdSiedzMiejscowoscPocztyNazwa;

        /// Lokpraw ad siedz miejscowosc poczty nazwa
        /// Lokpraw ad siedz miejscowosc poczty nazwa
        [Column(Order = 2)]
        [XmlElement("lokpraw_adSiedzMiejscowoscPoczty_Nazwa")]
        [JsonProperty(nameof(LokprawAdSiedzMiejscowoscPocztyNazwa), Order = 2)]
        [Display(Name = "Lokpraw ad siedz miejscowosc poczty nazwa",
            Prompt = "Wpisz Lokpraw ad siedz miejscowosc poczty nazwa",
            Description = "Lokpraw ad siedz miejscowosc poczty nazwa")]
        [StringLength(100)]
        [MaxLength(100)]

        public string? LokprawAdSiedzMiejscowoscPocztyNazwa
        {
            get => _lokprawAdSiedzMiejscowoscPocztyNazwa;
            set
            {
                if (value != _lokprawAdSiedzMiejscowoscPocztyNazwa)
                {
                    _lokprawAdSiedzMiejscowoscPocztyNazwa = value;
                    OnPropertyChanged(nameof(LokprawAdSiedzMiejscowoscPocztyNazwa));
                }
            }
        }

        #endregion

        #region private string? _lokprawAdSiedzUlicaNazwa; public string? LokprawAdSiedzUlicaNazwa

        private string? _lokprawAdSiedzUlicaNazwa;

        /// Lokpraw ad siedz ulica nazwa
        /// Lokpraw ad siedz ulica nazwa
        [Column(Order = 2)]
        [XmlElement("lokpraw_adSiedzUlica_Nazwa")]
        [JsonProperty(nameof(LokprawAdSiedzUlicaNazwa), Order = 2)]
        [Display(Name = "Lokpraw ad siedz ulica nazwa", Prompt = "Wpisz Lokpraw ad siedz ulica nazwa",
            Description = "Lokpraw ad siedz ulica nazwa")]
        [StringLength(351)]
        [MaxLength(351)]

        public string? LokprawAdSiedzUlicaNazwa
        {
            get => _lokprawAdSiedzUlicaNazwa;
            set
            {
                if (value != _lokprawAdSiedzUlicaNazwa)
                {
                    _lokprawAdSiedzUlicaNazwa = value;
                    OnPropertyChanged(nameof(LokprawAdSiedzUlicaNazwa));
                }
            }
        }

        #endregion

        #region private string? _lokprawDataPowstania; public string? LokprawDataPowstania

        private string? _lokprawDataPowstania;

        /// Lokpraw data powstania
        /// Lokpraw data powstania
        [Column(Order = 2)]
        [XmlElement("lokpraw_dataPowstania")]
        [JsonProperty(nameof(LokprawDataPowstania), Order = 2)]
        [Display(Name = "Lokpraw data powstania", Prompt = "Wpisz Lokpraw data powstania",
            Description = "Lokpraw data powstania")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? LokprawDataPowstania
        {
            get => _lokprawDataPowstania;
            set
            {
                if (value != _lokprawDataPowstania)
                {
                    _lokprawDataPowstania = value;
                    OnPropertyChanged(nameof(LokprawDataPowstania));
                }
            }
        }

        #endregion

        #region private string? _lokprawDataRozpoczeciaDzialalnosci; public string? LokprawDataRozpoczeciaDzialalnosci

        private string? _lokprawDataRozpoczeciaDzialalnosci;

        /// Lokpraw data rozpoczecia dzialalnosci
        /// Lokpraw data rozpoczecia dzialalnosci
        [Column(Order = 2)]
        [XmlElement("lokpraw_dataRozpoczeciaDzialalnosci")]
        [JsonProperty(nameof(LokprawDataRozpoczeciaDzialalnosci), Order = 2)]
        [Display(Name = "Lokpraw data rozpoczecia dzialalnosci", Prompt = "Wpisz Lokpraw data rozpoczecia dzialalnosci",
            Description = "Lokpraw data rozpoczecia dzialalnosci")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? LokprawDataRozpoczeciaDzialalnosci
        {
            get => _lokprawDataRozpoczeciaDzialalnosci;
            set
            {
                if (value != _lokprawDataRozpoczeciaDzialalnosci)
                {
                    _lokprawDataRozpoczeciaDzialalnosci = value;
                    OnPropertyChanged(nameof(LokprawDataRozpoczeciaDzialalnosci));
                }
            }
        }

        #endregion

        #region private string? _lokprawDataWpisuDoRegon; public string? LokprawDataWpisuDoRegon

        private string? _lokprawDataWpisuDoRegon;

        /// Lokpraw data wpisu do regon
        /// Lokpraw data wpisu do regon
        [Column(Order = 2)]
        [XmlElement("lokpraw_dataWpisuDoRegon")]
        [JsonProperty(nameof(LokprawDataWpisuDoRegon), Order = 2)]
        [Display(Name = "Lokpraw data wpisu do regon", Prompt = "Wpisz Lokpraw data wpisu do regon",
            Description = "Lokpraw data wpisu do regon")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? LokprawDataWpisuDoRegon
        {
            get => _lokprawDataWpisuDoRegon;
            set
            {
                if (value != _lokprawDataWpisuDoRegon)
                {
                    _lokprawDataWpisuDoRegon = value;
                    OnPropertyChanged(nameof(LokprawDataWpisuDoRegon));
                }
            }
        }

        #endregion

        #region private string? _lokprawDataZawieszeniaDzialalnosci; public string? LokprawDataZawieszeniaDzialalnosci

        private string? _lokprawDataZawieszeniaDzialalnosci;

        /// Lokpraw data zawieszenia dzialalnosci
        /// Lokpraw data zawieszenia dzialalnosci
        [Column(Order = 2)]
        [XmlElement("lokpraw_dataZawieszeniaDzialalnosci")]
        [JsonProperty(nameof(LokprawDataZawieszeniaDzialalnosci), Order = 2)]
        [Display(Name = "Lokpraw data zawieszenia dzialalnosci", Prompt = "Wpisz Lokpraw data zawieszenia dzialalnosci",
            Description = "Lokpraw data zawieszenia dzialalnosci")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? LokprawDataZawieszeniaDzialalnosci
        {
            get => _lokprawDataZawieszeniaDzialalnosci;
            set
            {
                if (value != _lokprawDataZawieszeniaDzialalnosci)
                {
                    _lokprawDataZawieszeniaDzialalnosci = value;
                    OnPropertyChanged(nameof(LokprawDataZawieszeniaDzialalnosci));
                }
            }
        }

        #endregion

        #region private string? _lokprawDataWznowieniaDzialalnosci; public string? LokprawDataWznowieniaDzialalnosci

        private string? _lokprawDataWznowieniaDzialalnosci;

        /// Lokpraw data wznowienia dzialalnosci
        /// Lokpraw data wznowienia dzialalnosci
        [Column(Order = 2)]
        [XmlElement("lokpraw_dataWznowieniaDzialalnosci")]
        [JsonProperty(nameof(LokprawDataWznowieniaDzialalnosci), Order = 2)]
        [Display(Name = "Lokpraw data wznowienia dzialalnosci", Prompt = "Wpisz Lokpraw data wznowienia dzialalnosci",
            Description = "Lokpraw data wznowienia dzialalnosci")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? LokprawDataWznowieniaDzialalnosci
        {
            get => _lokprawDataWznowieniaDzialalnosci;
            set
            {
                if (value != _lokprawDataWznowieniaDzialalnosci)
                {
                    _lokprawDataWznowieniaDzialalnosci = value;
                    OnPropertyChanged(nameof(LokprawDataWznowieniaDzialalnosci));
                }
            }
        }

        #endregion

        #region private string? _lokprawDataZakonczeniaDzialalnosci; public string? LokprawDataZakonczeniaDzialalnosci

        private string? _lokprawDataZakonczeniaDzialalnosci;

        /// Lokpraw data zakonczenia dzialalnosci
        /// Lokpraw data zakonczenia dzialalnosci
        [Column(Order = 2)]
        [XmlElement("lokpraw_dataZakonczeniaDzialalnosci")]
        [JsonProperty(nameof(LokprawDataZakonczeniaDzialalnosci), Order = 2)]
        [Display(Name = "Lokpraw data zakonczenia dzialalnosci", Prompt = "Wpisz Lokpraw data zakonczenia dzialalnosci",
            Description = "Lokpraw data zakonczenia dzialalnosci")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? LokprawDataZakonczeniaDzialalnosci
        {
            get => _lokprawDataZakonczeniaDzialalnosci;
            set
            {
                if (value != _lokprawDataZakonczeniaDzialalnosci)
                {
                    _lokprawDataZakonczeniaDzialalnosci = value;
                    OnPropertyChanged(nameof(LokprawDataZakonczeniaDzialalnosci));
                }
            }
        }

        #endregion

        #region private string? _lokprawDataSkresleniaZRegon; public string? LokprawDataSkresleniaZRegon

        private string? _lokprawDataSkresleniaZRegon;

        /// Lokpraw data skreslenia z regon
        /// Lokpraw data skreslenia z regon
        [Column(Order = 2)]
        [XmlElement("lokpraw_dataSkresleniaZRegon")]
        [JsonProperty(nameof(LokprawDataSkresleniaZRegon), Order = 2)]
        [Display(Name = "Lokpraw data skreslenia z regon", Prompt = "Wpisz Lokpraw data skreslenia z regon",
            Description = "Lokpraw data skreslenia z regon")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? LokprawDataSkresleniaZRegon
        {
            get => _lokprawDataSkresleniaZRegon;
            set
            {
                if (value != _lokprawDataSkresleniaZRegon)
                {
                    _lokprawDataSkresleniaZRegon = value;
                    OnPropertyChanged(nameof(LokprawDataSkresleniaZRegon));
                }
            }
        }

        #endregion
    }

    #endregion
}

#endregion
