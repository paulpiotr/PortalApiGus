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
    #region public class BIR11OsFizycznaListaJednLokalnych : DanePobierzPelnyRaport

    /// <summary>
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport BIR11OsFizycznaListaJednLokalnych
    ///     Data model of entities found in the basic report
    /// </summary>
    [Table(nameof(BIR11OsFizycznaListaJednLokalnych), Schema = "pagard")]
    [JsonObject(nameof(BIR11OsFizycznaListaJednLokalnych))]
    [Display(Name = "BIR11OsFizycznaListaJednLokalnych", Description = "BIR11OsFizycznaListaJednLokalnych")]
    [Serializable]
    [XmlRoot("dane")]
    [Index(nameof(LokfizRegon14))]
    [Index(nameof(LokfizNazwa))]
    [Index(nameof(LokfizSilosID))]
    [Index(nameof(LokfizSilosSymbol))]
    [Index(nameof(LokfizAdSiedzKrajSymbol))]
    [Index(nameof(LokfizAdSiedzWojewodztwoSymbol))]
    [Index(nameof(LokfizAdSiedzPowiatSymbol))]
    [Index(nameof(LokfizAdSiedzGminaSymbol))]
    [Index(nameof(LokfizAdSiedzKodPocztowy))]
    [Index(nameof(LokfizAdSiedzMiejscowoscPocztySymbol))]
    [Index(nameof(LokfizAdSiedzMiejscowoscSymbol))]
    [Index(nameof(LokfizAdSiedzUlicaSymbol))]
    [Index(nameof(LokfizAdSiedzNumerNieruchomosci))]
    [Index(nameof(LokfizAdSiedzNumerLokalu))]
    [Index(nameof(LokfizAdSiedzNietypoweMiejsceLokalizacji))]
    [Index(nameof(LokfizAdSiedzWojewodztwoNazwa))]
    [Index(nameof(LokfizAdSiedzPowiatNazwa))]
    [Index(nameof(LokfizAdSiedzGminaNazwa))]
    [Index(nameof(LokfizAdSiedzMiejscowoscNazwa))]
    [Index(nameof(LokfizAdSiedzMiejscowoscPocztyNazwa))]
    [Index(nameof(LokfizAdSiedzUlicaNazwa))]
    [Index(nameof(LokfizDataPowstania))]
    [Index(nameof(LokfizDataRozpoczeciaDzialalnosci))]
    [Index(nameof(LokfizDataWpisuDoRegon))]
    [Index(nameof(LokfizDataZawieszeniaDzialalnosci))]
    [Index(nameof(LokfizDataWznowieniaDzialalnosci))]
    [Index(nameof(LokfizDataZakonczeniaDzialalnosci))]
    [Index(nameof(LokfizDataSkresleniaZRegon))]
    public class BIR11OsFizycznaListaJednLokalnych : DanePobierzPelnyRaport
    {
        #region public override ICollection<TModel> CreateCollection<TModel>...

        public override ICollection<TModel> CreateCollection<TModel>(
            DaneSzukajPodmioty.DaneSzukajPodmioty daneSzukajPodmioty, string pRegon, string pNazwaRaportu, string xml,
            ICollection<MessageInspector> messageInspectorCollection = null!)
        {
            ICollection<BIR11OsFizycznaListaJednLokalnych> collection =
                (ICollection<BIR11OsFizycznaListaJednLokalnych>)XmlHelper
                    .DeserializeXmlFromString<DanePobierzPelnyRaportResult<BIR11OsFizycznaListaJednLokalnych>>(xml)
                    .Dane ??
                new Collection<BIR11OsFizycznaListaJednLokalnych> {new()};
            DaneSzukajPodmiotyKomunikatyOBledach error =
                XmlHelper.DeserializeXmlFromString<DaneSzukajPodmiotyKomunikatyOBledach>(
                    xml);
            foreach (BIR11OsFizycznaListaJednLokalnych item in collection)
            {
                item.DaneSzukajPodmiotyKomunikatyOBledach = error;
                if(null != messageInspectorCollection && messageInspectorCollection.Count > 0)
                {
                    item.BIR11OsFizycznaListaJednLokalnychMessageInspector =
                        new List<BIR11OsFizycznaListaJednLokalnychMessageInspector>();
                    foreach (MessageInspector messageInspector in messageInspectorCollection)
                    {
                        item.BIR11OsFizycznaListaJednLokalnychMessageInspector.Add(
                            new BIR11OsFizycznaListaJednLokalnychMessageInspector(item,
                                messageInspector));
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

        #region private ICollection<BIR11OsFizycznaListaJednLokalnychMessageInspector>...

        private ICollection<BIR11OsFizycznaListaJednLokalnychMessageInspector> _bir11OsFizycznaListaJednLokalnychMessageInspector;

        /// <summary>
        ///     Kolekcja elementów inspektora wiadomości usługi, relacja do encji DaneSzukajPodmioty, zawiera informacje dotyczące
        ///     przetwarzania żądań
        ///     Service Message Inspector Item Collection, DaneSzukajPodmioty relationship, contains information about request
        ///     processing
        /// </summary>
        [XmlIgnore]
        [JsonProperty(nameof(BIR11OsFizycznaListaJednLokalnychMessageInspector), Order = 2)]
        //[InverseProperty("DaneSzukajPodmioty")]
        //[ForeignKey("DaneSzukajPodmiotyId")]
        [Display(Name = "Inspektor wiadomości usługi",
            Prompt = "Wybierz elementy kolekcji inspektora wiadomości usługi",
            Description =
                "Kolekcja elementów inspektora wiadomości usługi")]
        public virtual ICollection<BIR11OsFizycznaListaJednLokalnychMessageInspector> BIR11OsFizycznaListaJednLokalnychMessageInspector
        {
            get => _bir11OsFizycznaListaJednLokalnychMessageInspector;
            set
            {
                if (!Equals(value, _bir11OsFizycznaListaJednLokalnychMessageInspector))
                {
                    _bir11OsFizycznaListaJednLokalnychMessageInspector = value;
                    OnPropertyChanged(nameof(BIR11OsFizycznaListaJednLokalnychMessageInspector));
                }
            }
        }

        #endregion

        #region private string? _lokfizRegon14; public string? LokfizRegon14

        private string? _lokfizRegon14;

        /// Lokfiz regon14
        /// Lokfiz regon14
        [Column(Order = 2)]
        [XmlElement("lokfiz_regon14")]
        [JsonProperty(nameof(LokfizRegon14), Order = 2)]
        [Display(Name = "Lokfiz regon14", Prompt = "Wpisz Lokfiz regon14", Description = "Lokfiz regon14")]
        [StringLength(14)]
        [MaxLength(14)]

        public string? LokfizRegon14
        {
            get => _lokfizRegon14;
            set
            {
                if (value != _lokfizRegon14)
                {
                    _lokfizRegon14 = value;
                    OnPropertyChanged(nameof(LokfizRegon14));
                }
            }
        }

        #endregion

        #region private string? _lokfizNazwa; public string? LokfizNazwa

        private string? _lokfizNazwa;

        /// Lokfiz nazwa
        /// Lokfiz nazwa
        [Column(Order = 2)]
        [XmlElement("lokfiz_nazwa")]
        [JsonProperty(nameof(LokfizNazwa), Order = 2)]
        [Display(Name = "Lokfiz nazwa", Prompt = "Wpisz Lokfiz nazwa", Description = "Lokfiz nazwa")]
        [StringLength(2000)]
        [MaxLength(2000)]

        public string? LokfizNazwa
        {
            get => _lokfizNazwa;
            set
            {
                if (value != _lokfizNazwa)
                {
                    _lokfizNazwa = value;
                    OnPropertyChanged(nameof(LokfizNazwa));
                }
            }
        }

        #endregion

        #region private int? _lokfizSilosID; public int? LokfizSilosID

        private int? _lokfizSilosID;

        /// Lokfiz silos i d
        /// Lokfiz silos i d
        [Column(Order = 2)]
        [XmlElement("lokfiz_silosID")]
        [JsonProperty(nameof(LokfizSilosID), Order = 2)]
        [Display(Name = "Lokfiz silos i d", Prompt = "Wpisz Lokfiz silos i d", Description = "Lokfiz silos i d")]
        [Range(int.MinValue, int.MaxValue)]
        public int? LokfizSilosID
        {
            get => _lokfizSilosID;
            set
            {
                if (value != _lokfizSilosID)
                {
                    _lokfizSilosID = value;
                    OnPropertyChanged(nameof(LokfizSilosID));
                }
            }
        }

        #endregion

        #region private string? _lokfizSilosSymbol; public string? LokfizSilosSymbol

        private string? _lokfizSilosSymbol;

        /// Lokfiz silos symbol
        /// Lokfiz silos symbol
        [Column(Order = 2)]
        [XmlElement("lokfiz_silos_Symbol")]
        [JsonProperty(nameof(LokfizSilosSymbol), Order = 2)]
        [Display(Name = "Lokfiz silos symbol", Prompt = "Wpisz Lokfiz silos symbol",
            Description = "Lokfiz silos symbol")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? LokfizSilosSymbol
        {
            get => _lokfizSilosSymbol;
            set
            {
                if (value != _lokfizSilosSymbol)
                {
                    _lokfizSilosSymbol = value;
                    OnPropertyChanged(nameof(LokfizSilosSymbol));
                }
            }
        }

        #endregion

        #region private string? _lokfizAdSiedzKrajSymbol; public string? LokfizAdSiedzKrajSymbol

        private string? _lokfizAdSiedzKrajSymbol;

        /// Lokfiz ad siedz kraj symbol
        /// Lokfiz ad siedz kraj symbol
        [Column(Order = 2)]
        [XmlElement("lokfiz_adSiedzKraj_Symbol")]
        [JsonProperty(nameof(LokfizAdSiedzKrajSymbol), Order = 2)]
        [Display(Name = "Lokfiz ad siedz kraj symbol", Prompt = "Wpisz Lokfiz ad siedz kraj symbol",
            Description = "Lokfiz ad siedz kraj symbol")]
        [StringLength(2)]
        [MaxLength(2)]

        public string? LokfizAdSiedzKrajSymbol
        {
            get => _lokfizAdSiedzKrajSymbol;
            set
            {
                if (value != _lokfizAdSiedzKrajSymbol)
                {
                    _lokfizAdSiedzKrajSymbol = value;
                    OnPropertyChanged(nameof(LokfizAdSiedzKrajSymbol));
                }
            }
        }

        #endregion

        #region private string? _lokfizAdSiedzWojewodztwoSymbol; public string? LokfizAdSiedzWojewodztwoSymbol

        private string? _lokfizAdSiedzWojewodztwoSymbol;

        /// Lokfiz ad siedz wojewodztwo symbol
        /// Lokfiz ad siedz wojewodztwo symbol
        [Column(Order = 2)]
        [XmlElement("lokfiz_adSiedzWojewodztwo_Symbol")]
        [JsonProperty(nameof(LokfizAdSiedzWojewodztwoSymbol), Order = 2)]
        [Display(Name = "Lokfiz ad siedz wojewodztwo symbol", Prompt = "Wpisz Lokfiz ad siedz wojewodztwo symbol",
            Description = "Lokfiz ad siedz wojewodztwo symbol")]
        [StringLength(2)]
        [MaxLength(2)]

        public string? LokfizAdSiedzWojewodztwoSymbol
        {
            get => _lokfizAdSiedzWojewodztwoSymbol;
            set
            {
                if (value != _lokfizAdSiedzWojewodztwoSymbol)
                {
                    _lokfizAdSiedzWojewodztwoSymbol = value;
                    OnPropertyChanged(nameof(LokfizAdSiedzWojewodztwoSymbol));
                }
            }
        }

        #endregion

        #region private string? _lokfizAdSiedzPowiatSymbol; public string? LokfizAdSiedzPowiatSymbol

        private string? _lokfizAdSiedzPowiatSymbol;

        /// Lokfiz ad siedz powiat symbol
        /// Lokfiz ad siedz powiat symbol
        [Column(Order = 2)]
        [XmlElement("lokfiz_adSiedzPowiat_Symbol")]
        [JsonProperty(nameof(LokfizAdSiedzPowiatSymbol), Order = 2)]
        [Display(Name = "Lokfiz ad siedz powiat symbol", Prompt = "Wpisz Lokfiz ad siedz powiat symbol",
            Description = "Lokfiz ad siedz powiat symbol")]
        [StringLength(2)]
        [MaxLength(2)]

        public string? LokfizAdSiedzPowiatSymbol
        {
            get => _lokfizAdSiedzPowiatSymbol;
            set
            {
                if (value != _lokfizAdSiedzPowiatSymbol)
                {
                    _lokfizAdSiedzPowiatSymbol = value;
                    OnPropertyChanged(nameof(LokfizAdSiedzPowiatSymbol));
                }
            }
        }

        #endregion

        #region private string? _lokfizAdSiedzGminaSymbol; public string? LokfizAdSiedzGminaSymbol

        private string? _lokfizAdSiedzGminaSymbol;

        /// Lokfiz ad siedz gmina symbol
        /// Lokfiz ad siedz gmina symbol
        [Column(Order = 2)]
        [XmlElement("lokfiz_adSiedzGmina_Symbol")]
        [JsonProperty(nameof(LokfizAdSiedzGminaSymbol), Order = 2)]
        [Display(Name = "Lokfiz ad siedz gmina symbol", Prompt = "Wpisz Lokfiz ad siedz gmina symbol",
            Description = "Lokfiz ad siedz gmina symbol")]
        [StringLength(3)]
        [MaxLength(3)]

        public string? LokfizAdSiedzGminaSymbol
        {
            get => _lokfizAdSiedzGminaSymbol;
            set
            {
                if (value != _lokfizAdSiedzGminaSymbol)
                {
                    _lokfizAdSiedzGminaSymbol = value;
                    OnPropertyChanged(nameof(LokfizAdSiedzGminaSymbol));
                }
            }
        }

        #endregion

        #region private string? _lokfizAdSiedzKodPocztowy; public string? LokfizAdSiedzKodPocztowy

        private string? _lokfizAdSiedzKodPocztowy;

        /// Lokfiz ad siedz kod pocztowy
        /// Lokfiz ad siedz kod pocztowy
        [Column(Order = 2)]
        [XmlElement("lokfiz_adSiedzKodPocztowy")]
        [JsonProperty(nameof(LokfizAdSiedzKodPocztowy), Order = 2)]
        [Display(Name = "Lokfiz ad siedz kod pocztowy", Prompt = "Wpisz Lokfiz ad siedz kod pocztowy",
            Description = "Lokfiz ad siedz kod pocztowy")]
        [StringLength(12)]
        [MaxLength(12)]

        public string? LokfizAdSiedzKodPocztowy
        {
            get => _lokfizAdSiedzKodPocztowy;
            set
            {
                if (value != _lokfizAdSiedzKodPocztowy)
                {
                    _lokfizAdSiedzKodPocztowy = value;
                    OnPropertyChanged(nameof(LokfizAdSiedzKodPocztowy));
                }
            }
        }

        #endregion

        #region private string? _lokfizAdSiedzMiejscowoscPocztySymbol; public string? LokfizAdSiedzMiejscowoscPocztySymbol

        private string? _lokfizAdSiedzMiejscowoscPocztySymbol;

        /// Lokfiz ad siedz miejscowosc poczty symbol
        /// Lokfiz ad siedz miejscowosc poczty symbol
        [Column(Order = 2)]
        [XmlElement("lokfiz_adSiedzMiejscowoscPoczty_Symbol")]
        [JsonProperty(nameof(LokfizAdSiedzMiejscowoscPocztySymbol), Order = 2)]
        [Display(Name = "Lokfiz ad siedz miejscowosc poczty symbol",
            Prompt = "Wpisz Lokfiz ad siedz miejscowosc poczty symbol",
            Description = "Lokfiz ad siedz miejscowosc poczty symbol")]
        [StringLength(7)]
        [MaxLength(7)]

        public string? LokfizAdSiedzMiejscowoscPocztySymbol
        {
            get => _lokfizAdSiedzMiejscowoscPocztySymbol;
            set
            {
                if (value != _lokfizAdSiedzMiejscowoscPocztySymbol)
                {
                    _lokfizAdSiedzMiejscowoscPocztySymbol = value;
                    OnPropertyChanged(nameof(LokfizAdSiedzMiejscowoscPocztySymbol));
                }
            }
        }

        #endregion

        #region private string? _lokfizAdSiedzMiejscowoscSymbol; public string? LokfizAdSiedzMiejscowoscSymbol

        private string? _lokfizAdSiedzMiejscowoscSymbol;

        /// Lokfiz ad siedz miejscowosc symbol
        /// Lokfiz ad siedz miejscowosc symbol
        [Column(Order = 2)]
        [XmlElement("lokfiz_adSiedzMiejscowosc_Symbol")]
        [JsonProperty(nameof(LokfizAdSiedzMiejscowoscSymbol), Order = 2)]
        [Display(Name = "Lokfiz ad siedz miejscowosc symbol", Prompt = "Wpisz Lokfiz ad siedz miejscowosc symbol",
            Description = "Lokfiz ad siedz miejscowosc symbol")]
        [StringLength(7)]
        [MaxLength(7)]

        public string? LokfizAdSiedzMiejscowoscSymbol
        {
            get => _lokfizAdSiedzMiejscowoscSymbol;
            set
            {
                if (value != _lokfizAdSiedzMiejscowoscSymbol)
                {
                    _lokfizAdSiedzMiejscowoscSymbol = value;
                    OnPropertyChanged(nameof(LokfizAdSiedzMiejscowoscSymbol));
                }
            }
        }

        #endregion

        #region private string? _lokfizAdSiedzUlicaSymbol; public string? LokfizAdSiedzUlicaSymbol

        private string? _lokfizAdSiedzUlicaSymbol;

        /// Lokfiz ad siedz ulica symbol
        /// Lokfiz ad siedz ulica symbol
        [Column(Order = 2)]
        [XmlElement("lokfiz_adSiedzUlica_Symbol")]
        [JsonProperty(nameof(LokfizAdSiedzUlicaSymbol), Order = 2)]
        [Display(Name = "Lokfiz ad siedz ulica symbol", Prompt = "Wpisz Lokfiz ad siedz ulica symbol",
            Description = "Lokfiz ad siedz ulica symbol")]
        [StringLength(5)]
        [MaxLength(5)]

        public string? LokfizAdSiedzUlicaSymbol
        {
            get => _lokfizAdSiedzUlicaSymbol;
            set
            {
                if (value != _lokfizAdSiedzUlicaSymbol)
                {
                    _lokfizAdSiedzUlicaSymbol = value;
                    OnPropertyChanged(nameof(LokfizAdSiedzUlicaSymbol));
                }
            }
        }

        #endregion

        #region private string? _lokfizAdSiedzNumerNieruchomosci; public string? LokfizAdSiedzNumerNieruchomosci

        private string? _lokfizAdSiedzNumerNieruchomosci;

        /// Lokfiz ad siedz numer nieruchomosci
        /// Lokfiz ad siedz numer nieruchomosci
        [Column(Order = 2)]
        [XmlElement("lokfiz_adSiedzNumerNieruchomosci")]
        [JsonProperty(nameof(LokfizAdSiedzNumerNieruchomosci), Order = 2)]
        [Display(Name = "Lokfiz ad siedz numer nieruchomosci", Prompt = "Wpisz Lokfiz ad siedz numer nieruchomosci",
            Description = "Lokfiz ad siedz numer nieruchomosci")]
        [StringLength(20)]
        [MaxLength(20)]

        public string? LokfizAdSiedzNumerNieruchomosci
        {
            get => _lokfizAdSiedzNumerNieruchomosci;
            set
            {
                if (value != _lokfizAdSiedzNumerNieruchomosci)
                {
                    _lokfizAdSiedzNumerNieruchomosci = value;
                    OnPropertyChanged(nameof(LokfizAdSiedzNumerNieruchomosci));
                }
            }
        }

        #endregion

        #region private string? _lokfizAdSiedzNumerLokalu; public string? LokfizAdSiedzNumerLokalu

        private string? _lokfizAdSiedzNumerLokalu;

        /// Lokfiz ad siedz numer lokalu
        /// Lokfiz ad siedz numer lokalu
        [Column(Order = 2)]
        [XmlElement("lokfiz_adSiedzNumerLokalu")]
        [JsonProperty(nameof(LokfizAdSiedzNumerLokalu), Order = 2)]
        [Display(Name = "Lokfiz ad siedz numer lokalu", Prompt = "Wpisz Lokfiz ad siedz numer lokalu",
            Description = "Lokfiz ad siedz numer lokalu")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? LokfizAdSiedzNumerLokalu
        {
            get => _lokfizAdSiedzNumerLokalu;
            set
            {
                if (value != _lokfizAdSiedzNumerLokalu)
                {
                    _lokfizAdSiedzNumerLokalu = value;
                    OnPropertyChanged(nameof(LokfizAdSiedzNumerLokalu));
                }
            }
        }

        #endregion

        #region private string? _lokfizAdSiedzNietypoweMiejsceLokalizacji; public string? LokfizAdSiedzNietypoweMiejsceLokalizacji

        private string? _lokfizAdSiedzNietypoweMiejsceLokalizacji;

        /// Lokfiz ad siedz nietypowe miejsce lokalizacji
        /// Lokfiz ad siedz nietypowe miejsce lokalizacji
        [Column(Order = 2)]
        [XmlElement("lokfiz_adSiedzNietypoweMiejsceLokalizacji")]
        [JsonProperty(nameof(LokfizAdSiedzNietypoweMiejsceLokalizacji), Order = 2)]
        [Display(Name = "Lokfiz ad siedz nietypowe miejsce lokalizacji",
            Prompt = "Wpisz Lokfiz ad siedz nietypowe miejsce lokalizacji",
            Description = "Lokfiz ad siedz nietypowe miejsce lokalizacji")]
        [StringLength(256)]
        [MaxLength(256)]

        public string? LokfizAdSiedzNietypoweMiejsceLokalizacji
        {
            get => _lokfizAdSiedzNietypoweMiejsceLokalizacji;
            set
            {
                if (value != _lokfizAdSiedzNietypoweMiejsceLokalizacji)
                {
                    _lokfizAdSiedzNietypoweMiejsceLokalizacji = value;
                    OnPropertyChanged(nameof(LokfizAdSiedzNietypoweMiejsceLokalizacji));
                }
            }
        }

        #endregion

        #region private string? _lokfizAdSiedzWojewodztwoNazwa; public string? LokfizAdSiedzWojewodztwoNazwa

        private string? _lokfizAdSiedzWojewodztwoNazwa;

        /// Lokfiz ad siedz wojewodztwo nazwa
        /// Lokfiz ad siedz wojewodztwo nazwa
        [Column(Order = 2)]
        [XmlElement("lokfiz_adSiedzWojewodztwo_Nazwa")]
        [JsonProperty(nameof(LokfizAdSiedzWojewodztwoNazwa), Order = 2)]
        [Display(Name = "Lokfiz ad siedz wojewodztwo nazwa", Prompt = "Wpisz Lokfiz ad siedz wojewodztwo nazwa",
            Description = "Lokfiz ad siedz wojewodztwo nazwa")]
        [StringLength(100)]
        [MaxLength(100)]

        public string? LokfizAdSiedzWojewodztwoNazwa
        {
            get => _lokfizAdSiedzWojewodztwoNazwa;
            set
            {
                if (value != _lokfizAdSiedzWojewodztwoNazwa)
                {
                    _lokfizAdSiedzWojewodztwoNazwa = value;
                    OnPropertyChanged(nameof(LokfizAdSiedzWojewodztwoNazwa));
                }
            }
        }

        #endregion

        #region private string? _lokfizAdSiedzPowiatNazwa; public string? LokfizAdSiedzPowiatNazwa

        private string? _lokfizAdSiedzPowiatNazwa;

        /// Lokfiz ad siedz powiat nazwa
        /// Lokfiz ad siedz powiat nazwa
        [Column(Order = 2)]
        [XmlElement("lokfiz_adSiedzPowiat_Nazwa")]
        [JsonProperty(nameof(LokfizAdSiedzPowiatNazwa), Order = 2)]
        [Display(Name = "Lokfiz ad siedz powiat nazwa", Prompt = "Wpisz Lokfiz ad siedz powiat nazwa",
            Description = "Lokfiz ad siedz powiat nazwa")]
        [StringLength(100)]
        [MaxLength(100)]

        public string? LokfizAdSiedzPowiatNazwa
        {
            get => _lokfizAdSiedzPowiatNazwa;
            set
            {
                if (value != _lokfizAdSiedzPowiatNazwa)
                {
                    _lokfizAdSiedzPowiatNazwa = value;
                    OnPropertyChanged(nameof(LokfizAdSiedzPowiatNazwa));
                }
            }
        }

        #endregion

        #region private string? _lokfizAdSiedzGminaNazwa; public string? LokfizAdSiedzGminaNazwa

        private string? _lokfizAdSiedzGminaNazwa;

        /// Lokfiz ad siedz gmina nazwa
        /// Lokfiz ad siedz gmina nazwa
        [Column(Order = 2)]
        [XmlElement("lokfiz_adSiedzGmina_Nazwa")]
        [JsonProperty(nameof(LokfizAdSiedzGminaNazwa), Order = 2)]
        [Display(Name = "Lokfiz ad siedz gmina nazwa", Prompt = "Wpisz Lokfiz ad siedz gmina nazwa",
            Description = "Lokfiz ad siedz gmina nazwa")]
        [StringLength(100)]
        [MaxLength(100)]

        public string? LokfizAdSiedzGminaNazwa
        {
            get => _lokfizAdSiedzGminaNazwa;
            set
            {
                if (value != _lokfizAdSiedzGminaNazwa)
                {
                    _lokfizAdSiedzGminaNazwa = value;
                    OnPropertyChanged(nameof(LokfizAdSiedzGminaNazwa));
                }
            }
        }

        #endregion

        #region private string? _lokfizAdSiedzMiejscowoscNazwa; public string? LokfizAdSiedzMiejscowoscNazwa

        private string? _lokfizAdSiedzMiejscowoscNazwa;

        /// Lokfiz ad siedz miejscowosc nazwa
        /// Lokfiz ad siedz miejscowosc nazwa
        [Column(Order = 2)]
        [XmlElement("lokfiz_adSiedzMiejscowosc_Nazwa")]
        [JsonProperty(nameof(LokfizAdSiedzMiejscowoscNazwa), Order = 2)]
        [Display(Name = "Lokfiz ad siedz miejscowosc nazwa", Prompt = "Wpisz Lokfiz ad siedz miejscowosc nazwa",
            Description = "Lokfiz ad siedz miejscowosc nazwa")]
        [StringLength(100)]
        [MaxLength(100)]

        public string? LokfizAdSiedzMiejscowoscNazwa
        {
            get => _lokfizAdSiedzMiejscowoscNazwa;
            set
            {
                if (value != _lokfizAdSiedzMiejscowoscNazwa)
                {
                    _lokfizAdSiedzMiejscowoscNazwa = value;
                    OnPropertyChanged(nameof(LokfizAdSiedzMiejscowoscNazwa));
                }
            }
        }

        #endregion

        #region private string? _lokfizAdSiedzMiejscowoscPocztyNazwa; public string? LokfizAdSiedzMiejscowoscPocztyNazwa

        private string? _lokfizAdSiedzMiejscowoscPocztyNazwa;

        /// Lokfiz ad siedz miejscowosc poczty nazwa
        /// Lokfiz ad siedz miejscowosc poczty nazwa
        [Column(Order = 2)]
        [XmlElement("lokfiz_adSiedzMiejscowoscPoczty_Nazwa")]
        [JsonProperty(nameof(LokfizAdSiedzMiejscowoscPocztyNazwa), Order = 2)]
        [Display(Name = "Lokfiz ad siedz miejscowosc poczty nazwa",
            Prompt = "Wpisz Lokfiz ad siedz miejscowosc poczty nazwa",
            Description = "Lokfiz ad siedz miejscowosc poczty nazwa")]
        [StringLength(100)]
        [MaxLength(100)]

        public string? LokfizAdSiedzMiejscowoscPocztyNazwa
        {
            get => _lokfizAdSiedzMiejscowoscPocztyNazwa;
            set
            {
                if (value != _lokfizAdSiedzMiejscowoscPocztyNazwa)
                {
                    _lokfizAdSiedzMiejscowoscPocztyNazwa = value;
                    OnPropertyChanged(nameof(LokfizAdSiedzMiejscowoscPocztyNazwa));
                }
            }
        }

        #endregion

        #region private string? _lokfizAdSiedzUlicaNazwa; public string? LokfizAdSiedzUlicaNazwa

        private string? _lokfizAdSiedzUlicaNazwa;

        /// Lokfiz ad siedz ulica nazwa
        /// Lokfiz ad siedz ulica nazwa
        [Column(Order = 2)]
        [XmlElement("lokfiz_adSiedzUlica_Nazwa")]
        [JsonProperty(nameof(LokfizAdSiedzUlicaNazwa), Order = 2)]
        [Display(Name = "Lokfiz ad siedz ulica nazwa", Prompt = "Wpisz Lokfiz ad siedz ulica nazwa",
            Description = "Lokfiz ad siedz ulica nazwa")]
        [StringLength(350)]
        [MaxLength(350)]

        public string? LokfizAdSiedzUlicaNazwa
        {
            get => _lokfizAdSiedzUlicaNazwa;
            set
            {
                if (value != _lokfizAdSiedzUlicaNazwa)
                {
                    _lokfizAdSiedzUlicaNazwa = value;
                    OnPropertyChanged(nameof(LokfizAdSiedzUlicaNazwa));
                }
            }
        }

        #endregion

        #region private string? _lokfizDataPowstania; public string? LokfizDataPowstania

        private string? _lokfizDataPowstania;

        /// Lokfiz data powstania
        /// Lokfiz data powstania
        [Column(Order = 2)]
        [XmlElement("lokfiz_dataPowstania")]
        [JsonProperty(nameof(LokfizDataPowstania), Order = 2)]
        [Display(Name = "Lokfiz data powstania", Prompt = "Wpisz Lokfiz data powstania",
            Description = "Lokfiz data powstania")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? LokfizDataPowstania
        {
            get => _lokfizDataPowstania;
            set
            {
                if (value != _lokfizDataPowstania)
                {
                    _lokfizDataPowstania = value;
                    OnPropertyChanged(nameof(LokfizDataPowstania));
                }
            }
        }

        #endregion

        #region private string? _lokfizDataRozpoczeciaDzialalnosci; public string? LokfizDataRozpoczeciaDzialalnosci

        private string? _lokfizDataRozpoczeciaDzialalnosci;

        /// Lokfiz data rozpoczecia dzialalnosci
        /// Lokfiz data rozpoczecia dzialalnosci
        [Column(Order = 2)]
        [XmlElement("lokfiz_dataRozpoczeciaDzialalnosci")]
        [JsonProperty(nameof(LokfizDataRozpoczeciaDzialalnosci), Order = 2)]
        [Display(Name = "Lokfiz data rozpoczecia dzialalnosci", Prompt = "Wpisz Lokfiz data rozpoczecia dzialalnosci",
            Description = "Lokfiz data rozpoczecia dzialalnosci")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? LokfizDataRozpoczeciaDzialalnosci
        {
            get => _lokfizDataRozpoczeciaDzialalnosci;
            set
            {
                if (value != _lokfizDataRozpoczeciaDzialalnosci)
                {
                    _lokfizDataRozpoczeciaDzialalnosci = value;
                    OnPropertyChanged(nameof(LokfizDataRozpoczeciaDzialalnosci));
                }
            }
        }

        #endregion

        #region private string? _lokfizDataWpisuDoRegon; public string? LokfizDataWpisuDoRegon

        private string? _lokfizDataWpisuDoRegon;

        /// Lokfiz data wpisu do regon
        /// Lokfiz data wpisu do regon
        [Column(Order = 2)]
        [XmlElement("lokfiz_dataWpisuDoRegon")]
        [JsonProperty(nameof(LokfizDataWpisuDoRegon), Order = 2)]
        [Display(Name = "Lokfiz data wpisu do regon", Prompt = "Wpisz Lokfiz data wpisu do regon",
            Description = "Lokfiz data wpisu do regon")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? LokfizDataWpisuDoRegon
        {
            get => _lokfizDataWpisuDoRegon;
            set
            {
                if (value != _lokfizDataWpisuDoRegon)
                {
                    _lokfizDataWpisuDoRegon = value;
                    OnPropertyChanged(nameof(LokfizDataWpisuDoRegon));
                }
            }
        }

        #endregion

        #region private string? _lokfizDataZawieszeniaDzialalnosci; public string? LokfizDataZawieszeniaDzialalnosci

        private string? _lokfizDataZawieszeniaDzialalnosci;

        /// Lokfiz data zawieszenia dzialalnosci
        /// Lokfiz data zawieszenia dzialalnosci
        [Column(Order = 2)]
        [XmlElement("lokfiz_dataZawieszeniaDzialalnosci")]
        [JsonProperty(nameof(LokfizDataZawieszeniaDzialalnosci), Order = 2)]
        [Display(Name = "Lokfiz data zawieszenia dzialalnosci", Prompt = "Wpisz Lokfiz data zawieszenia dzialalnosci",
            Description = "Lokfiz data zawieszenia dzialalnosci")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? LokfizDataZawieszeniaDzialalnosci
        {
            get => _lokfizDataZawieszeniaDzialalnosci;
            set
            {
                if (value != _lokfizDataZawieszeniaDzialalnosci)
                {
                    _lokfizDataZawieszeniaDzialalnosci = value;
                    OnPropertyChanged(nameof(LokfizDataZawieszeniaDzialalnosci));
                }
            }
        }

        #endregion

        #region private string? _lokfizDataWznowieniaDzialalnosci; public string? LokfizDataWznowieniaDzialalnosci

        private string? _lokfizDataWznowieniaDzialalnosci;

        /// Lokfiz data wznowienia dzialalnosci
        /// Lokfiz data wznowienia dzialalnosci
        [Column(Order = 2)]
        [XmlElement("lokfiz_dataWznowieniaDzialalnosci")]
        [JsonProperty(nameof(LokfizDataWznowieniaDzialalnosci), Order = 2)]
        [Display(Name = "Lokfiz data wznowienia dzialalnosci", Prompt = "Wpisz Lokfiz data wznowienia dzialalnosci",
            Description = "Lokfiz data wznowienia dzialalnosci")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? LokfizDataWznowieniaDzialalnosci
        {
            get => _lokfizDataWznowieniaDzialalnosci;
            set
            {
                if (value != _lokfizDataWznowieniaDzialalnosci)
                {
                    _lokfizDataWznowieniaDzialalnosci = value;
                    OnPropertyChanged(nameof(LokfizDataWznowieniaDzialalnosci));
                }
            }
        }

        #endregion

        #region private string? _lokfizDataZakonczeniaDzialalnosci; public string? LokfizDataZakonczeniaDzialalnosci

        private string? _lokfizDataZakonczeniaDzialalnosci;

        /// Lokfiz data zakonczenia dzialalnosci
        /// Lokfiz data zakonczenia dzialalnosci
        [Column(Order = 2)]
        [XmlElement("lokfiz_dataZakonczeniaDzialalnosci")]
        [JsonProperty(nameof(LokfizDataZakonczeniaDzialalnosci), Order = 2)]
        [Display(Name = "Lokfiz data zakonczenia dzialalnosci", Prompt = "Wpisz Lokfiz data zakonczenia dzialalnosci",
            Description = "Lokfiz data zakonczenia dzialalnosci")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? LokfizDataZakonczeniaDzialalnosci
        {
            get => _lokfizDataZakonczeniaDzialalnosci;
            set
            {
                if (value != _lokfizDataZakonczeniaDzialalnosci)
                {
                    _lokfizDataZakonczeniaDzialalnosci = value;
                    OnPropertyChanged(nameof(LokfizDataZakonczeniaDzialalnosci));
                }
            }
        }

        #endregion

        #region private string? _lokfizDataSkresleniaZRegon; public string? LokfizDataSkresleniaZRegon

        private string? _lokfizDataSkresleniaZRegon;

        /// Lokfiz data skreslenia z regon
        /// Lokfiz data skreslenia z regon
        [Column(Order = 2)]
        [XmlElement("lokfiz_dataSkresleniaZRegon")]
        [JsonProperty(nameof(LokfizDataSkresleniaZRegon), Order = 2)]
        [Display(Name = "Lokfiz data skreslenia z regon", Prompt = "Wpisz Lokfiz data skreslenia z regon",
            Description = "Lokfiz data skreslenia z regon")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? LokfizDataSkresleniaZRegon
        {
            get => _lokfizDataSkresleniaZRegon;
            set
            {
                if (value != _lokfizDataSkresleniaZRegon)
                {
                    _lokfizDataSkresleniaZRegon = value;
                    OnPropertyChanged(nameof(LokfizDataSkresleniaZRegon));
                }
            }
        }

        #endregion
    }

    #endregion
}

#endregion
