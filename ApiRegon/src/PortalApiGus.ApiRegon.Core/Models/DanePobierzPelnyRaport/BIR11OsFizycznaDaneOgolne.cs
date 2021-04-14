#region using

using System;
using System.Collections.Generic;
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
    #region public class BIR11OsFizycznaDaneOgolne : DanePobierzPelnyRaport

    /// <summary>
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport BIR11OsFizycznaDaneOgolne
    ///     Data model of entities found in the basic report
    /// </summary>
    [Table(nameof(BIR11OsFizycznaDaneOgolne), Schema = "pagard")]
    [JsonObject(nameof(BIR11OsFizycznaDaneOgolne))]
    [Display(Name = "BIR11OsFizycznaDaneOgolne", Description = "BIR11OsFizycznaDaneOgolne")]
    [Serializable]
    [XmlRoot("dane")]
    [Index(nameof(FizRegon9))]
    [Index(nameof(FizNip))]
    [Index(nameof(FizStatusNip))]
    [Index(nameof(FizNazwisko))]
    [Index(nameof(FizImie1))]
    [Index(nameof(FizImie2))]
    [Index(nameof(FizDataWpisuPodmiotuDoRegon))]
    [Index(nameof(FizDataZaistnieniaZmiany))]
    [Index(nameof(FizDataSkresleniaPodmiotuZRegon))]
    [Index(nameof(FizPodstawowaFormaPrawnaSymbol))]
    [Index(nameof(FizSzczegolnaFormaPrawnaSymbol))]
    [Index(nameof(FizFormaFinansowaniaSymbol))]
    [Index(nameof(FizFormaWlasnosciSymbol))]
    [Index(nameof(FizPodstawowaFormaPrawnaNazwa))]
    [Index(nameof(FizSzczegolnaFormaPrawnaNazwa))]
    [Index(nameof(FizFormaFinansowaniaNazwa))]
    [Index(nameof(FizFormaWlasnosciNazwa))]
    [Index(nameof(FizDzialalnoscCeidg))]
    [Index(nameof(FizDzialalnoscRolnicza))]
    [Index(nameof(FizDzialalnoscPozostala))]
    [Index(nameof(FizDzialalnoscSkreslonaDo20141108))]
    [Index(nameof(FizLiczbaJednLokalnych))]
    public class BIR11OsFizycznaDaneOgolne : DanePobierzPelnyRaport
    {
        #region public override TModel Create<TModel>...

        public override TModel Create<TModel>(string pRegon, string pNazwaRaportu, string xml,
            ICollection<MessageInspector> messageInspectorCollection = null!)
        {
            BIR11OsFizycznaDaneOgolne model =
                XmlHelper.DeserializeXmlFromString<BIR11OsFizycznaDaneOgolne>(xml) ?? new BIR11OsFizycznaDaneOgolne();
            model.PRegon = pRegon;
            model.PNazwaRaportu = pNazwaRaportu;
            DaneSzukajPodmiotyKomunikatyOBledach error =
                XmlHelper.DeserializeXmlFromString<DaneSzukajPodmiotyKomunikatyOBledach>(
                    xml);
            model.DaneSzukajPodmiotyKomunikatyOBledach = error;
            if (null != messageInspectorCollection && messageInspectorCollection.Count > 0)
            {
                model.BIR11OsFizycznaDaneOgolneMessageInspector = new List<BIR11OsFizycznaDaneOgolneMessageInspector>();
                foreach(MessageInspector messageInspector in messageInspectorCollection)
                {
                    model.BIR11OsFizycznaDaneOgolneMessageInspector.Add(
                        new BIR11OsFizycznaDaneOgolneMessageInspector(
                            model, messageInspector));
                }
            }

            return (model as TModel)!;
        }

        #endregion

        #region private ICollection<DaneSzukajPodmioty>? _daneSzukajPodmioty...

        private ICollection<DaneSzukajPodmioty.DaneSzukajPodmioty>? _daneSzukajPodmioty;

        /// <summary>
        ///     Raport podstawowy
        ///     Raport podstawowy
        /// </summary>
        [Column(Order = 2)]
        [XmlIgnore]
        [JsonProperty(nameof(DaneSzukajPodmioty), Order = 2)]
        [InverseProperty("BIR11OsFizycznaDaneOgolne")]
        [Display(Name = "Raport podstawowy", Prompt = "Wybierz raport podstawowy",
            Description = "Dane wyszukanych podmiotów w raporcie podstawowym")]
        public virtual ICollection<DaneSzukajPodmioty.DaneSzukajPodmioty>? DaneSzukajPodmioty
        {
            get => _daneSzukajPodmioty;
            set
            {
                if (!Equals(value, _daneSzukajPodmioty))
                {
                    _daneSzukajPodmioty = value;
                    OnPropertyChanged(nameof(DaneSzukajPodmioty));
                }
            }
        }

        #endregion

        #region private ICollection<BIR11OsFizycznaDaneOgolneMessageInspector>...

        private ICollection<BIR11OsFizycznaDaneOgolneMessageInspector> _modelMessageInspector;

        /// <summary>
        ///     Kolekcja elementów inspektora wiadomości usługi, relacja do encji DaneSzukajPodmioty, zawiera informacje dotyczące
        ///     przetwarzania żądań
        ///     Service Message Inspector Item Collection, DaneSzukajPodmioty relationship, contains information about request
        ///     processing
        /// </summary>
        [XmlIgnore]
        [JsonProperty(nameof(BIR11OsFizycznaDaneOgolneMessageInspector), Order = 2)]
        //[InverseProperty("DaneSzukajPodmioty")]
        //[ForeignKey("DaneSzukajPodmiotyId")]
        [Display(Name = "Inspektor wiadomości usługi",
            Prompt = "Wybierz elementy kolekcji inspektora wiadomości usługi",
            Description =
                "Kolekcja elementów inspektora wiadomości usługi")]
        public virtual ICollection<BIR11OsFizycznaDaneOgolneMessageInspector> BIR11OsFizycznaDaneOgolneMessageInspector
        {
            get => _modelMessageInspector;
            set
            {
                if (!Equals(value, _modelMessageInspector))
                {
                    _modelMessageInspector = value;
                    OnPropertyChanged(nameof(BIR11OsFizycznaDaneOgolneMessageInspector));
                }
            }
        }

        #endregion

        #region private string? _fizRegon9; public string? FizRegon9

        private string? _fizRegon9;

        /// Fiz regon9
        /// Fiz regon9
        [Column(Order = 2)]
        [XmlElement("fiz_regon9")]
        [JsonProperty(nameof(FizRegon9), Order = 2)]
        [Display(Name = "Fiz regon9", Prompt = "Wpisz Fiz regon9", Description = "Fiz regon9")]
        [StringLength(9)]
        [MaxLength(9)]

        public string? FizRegon9
        {
            get => _fizRegon9;
            set
            {
                if (value != _fizRegon9)
                {
                    _fizRegon9 = value;
                    OnPropertyChanged(nameof(FizRegon9));
                }
            }
        }

        #endregion

        #region private string? _fizNip; public string? FizNip

        private string? _fizNip;

        /// Fiz nip
        /// Fiz nip
        [Column(Order = 2)]
        [XmlElement("fiz_nip")]
        [JsonProperty(nameof(FizNip), Order = 2)]
        [Display(Name = "Fiz nip", Prompt = "Wpisz Fiz nip", Description = "Fiz nip")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? FizNip
        {
            get => _fizNip;
            set
            {
                if (value != _fizNip)
                {
                    _fizNip = value;
                    OnPropertyChanged(nameof(FizNip));
                }
            }
        }

        #endregion

        #region private string? _fizStatusNip; public string? FizStatusNip

        private string? _fizStatusNip;

        /// Fiz status nip
        /// Fiz status nip
        [Column(Order = 2)]
        [XmlElement("fiz_statusNip")]
        [JsonProperty(nameof(FizStatusNip), Order = 2)]
        [Display(Name = "Fiz status nip", Prompt = "Wpisz Fiz status nip", Description = "Fiz status nip")]
        [StringLength(12)]
        [MaxLength(12)]

        public string? FizStatusNip
        {
            get => _fizStatusNip;
            set
            {
                if (value != _fizStatusNip)
                {
                    _fizStatusNip = value;
                    OnPropertyChanged(nameof(FizStatusNip));
                }
            }
        }

        #endregion

        #region private string? _fizNazwisko; public string? FizNazwisko

        private string? _fizNazwisko;

        /// Fiz nazwisko
        /// Fiz nazwisko
        [Column(Order = 2)]
        [XmlElement("fiz_nazwisko")]
        [JsonProperty(nameof(FizNazwisko), Order = 2)]
        [Display(Name = "Fiz nazwisko", Prompt = "Wpisz Fiz nazwisko", Description = "Fiz nazwisko")]
        [StringLength(100)]
        [MaxLength(100)]

        public string? FizNazwisko
        {
            get => _fizNazwisko;
            set
            {
                if (value != _fizNazwisko)
                {
                    _fizNazwisko = value;
                    OnPropertyChanged(nameof(FizNazwisko));
                }
            }
        }

        #endregion

        #region private string? _fizImie1; public string? FizImie1

        private string? _fizImie1;

        /// Fiz imie1
        /// Fiz imie1
        [Column(Order = 2)]
        [XmlElement("fiz_imie1")]
        [JsonProperty(nameof(FizImie1), Order = 2)]
        [Display(Name = "Fiz imie1", Prompt = "Wpisz Fiz imie1", Description = "Fiz imie1")]
        [StringLength(50)]
        [MaxLength(50)]

        public string? FizImie1
        {
            get => _fizImie1;
            set
            {
                if (value != _fizImie1)
                {
                    _fizImie1 = value;
                    OnPropertyChanged(nameof(FizImie1));
                }
            }
        }

        #endregion

        #region private string? _fizImie2; public string? FizImie2

        private string? _fizImie2;

        /// Fiz imie2
        /// Fiz imie2
        [Column(Order = 2)]
        [XmlElement("fiz_imie2")]
        [JsonProperty(nameof(FizImie2), Order = 2)]
        [Display(Name = "Fiz imie2", Prompt = "Wpisz Fiz imie2", Description = "Fiz imie2")]
        [StringLength(50)]
        [MaxLength(50)]

        public string? FizImie2
        {
            get => _fizImie2;
            set
            {
                if (value != _fizImie2)
                {
                    _fizImie2 = value;
                    OnPropertyChanged(nameof(FizImie2));
                }
            }
        }

        #endregion

        #region private string? _fizDataWpisuPodmiotuDoRegon; public string? FizDataWpisuPodmiotuDoRegon

        private string? _fizDataWpisuPodmiotuDoRegon;

        /// Fiz data wpisu podmiotu do regon
        /// Fiz data wpisu podmiotu do regon
        [Column(Order = 2)]
        [XmlElement("fiz_dataWpisuPodmiotuDoRegon")]
        [JsonProperty(nameof(FizDataWpisuPodmiotuDoRegon), Order = 2)]
        [Display(Name = "Fiz data wpisu podmiotu do regon", Prompt = "Wpisz Fiz data wpisu podmiotu do regon",
            Description = "Fiz data wpisu podmiotu do regon")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? FizDataWpisuPodmiotuDoRegon
        {
            get => _fizDataWpisuPodmiotuDoRegon;
            set
            {
                if (value != _fizDataWpisuPodmiotuDoRegon)
                {
                    _fizDataWpisuPodmiotuDoRegon = value;
                    OnPropertyChanged(nameof(FizDataWpisuPodmiotuDoRegon));
                }
            }
        }

        #endregion

        #region private string? _fizDataZaistnieniaZmiany; public string? FizDataZaistnieniaZmiany

        private string? _fizDataZaistnieniaZmiany;

        /// Fiz data zaistnienia zmiany
        /// Fiz data zaistnienia zmiany
        [Column(Order = 2)]
        [XmlElement("fiz_dataZaistnieniaZmiany")]
        [JsonProperty(nameof(FizDataZaistnieniaZmiany), Order = 2)]
        [Display(Name = "Fiz data zaistnienia zmiany", Prompt = "Wpisz Fiz data zaistnienia zmiany",
            Description = "Fiz data zaistnienia zmiany")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? FizDataZaistnieniaZmiany
        {
            get => _fizDataZaistnieniaZmiany;
            set
            {
                if (value != _fizDataZaistnieniaZmiany)
                {
                    _fizDataZaistnieniaZmiany = value;
                    OnPropertyChanged(nameof(FizDataZaistnieniaZmiany));
                }
            }
        }

        #endregion

        #region private string? _fizDataSkresleniaPodmiotuZRegon; public string? FizDataSkresleniaPodmiotuZRegon

        private string? _fizDataSkresleniaPodmiotuZRegon;

        /// Fiz data skreslenia podmiotu z regon
        /// Fiz data skreslenia podmiotu z regon
        [Column(Order = 2)]
        [XmlElement("fiz_dataSkresleniaPodmiotuZRegon")]
        [JsonProperty(nameof(FizDataSkresleniaPodmiotuZRegon), Order = 2)]
        [Display(Name = "Fiz data skreslenia podmiotu z regon", Prompt = "Wpisz Fiz data skreslenia podmiotu z regon",
            Description = "Fiz data skreslenia podmiotu z regon")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? FizDataSkresleniaPodmiotuZRegon
        {
            get => _fizDataSkresleniaPodmiotuZRegon;
            set
            {
                if (value != _fizDataSkresleniaPodmiotuZRegon)
                {
                    _fizDataSkresleniaPodmiotuZRegon = value;
                    OnPropertyChanged(nameof(FizDataSkresleniaPodmiotuZRegon));
                }
            }
        }

        #endregion

        #region private string? _fizPodstawowaFormaPrawnaSymbol; public string? FizPodstawowaFormaPrawnaSymbol

        private string? _fizPodstawowaFormaPrawnaSymbol;

        /// Fiz podstawowa forma prawna symbol
        /// Fiz podstawowa forma prawna symbol
        [Column(Order = 2)]
        [XmlElement("fiz_podstawowaFormaPrawna_Symbol")]
        [JsonProperty(nameof(FizPodstawowaFormaPrawnaSymbol), Order = 2)]
        [Display(Name = "Fiz podstawowa forma prawna symbol", Prompt = "Wpisz Fiz podstawowa forma prawna symbol",
            Description = "Fiz podstawowa forma prawna symbol")]
        [StringLength(3)]
        [MaxLength(3)]

        public string? FizPodstawowaFormaPrawnaSymbol
        {
            get => _fizPodstawowaFormaPrawnaSymbol;
            set
            {
                if (value != _fizPodstawowaFormaPrawnaSymbol)
                {
                    _fizPodstawowaFormaPrawnaSymbol = value;
                    OnPropertyChanged(nameof(FizPodstawowaFormaPrawnaSymbol));
                }
            }
        }

        #endregion

        #region private string? _fizSzczegolnaFormaPrawnaSymbol; public string? FizSzczegolnaFormaPrawnaSymbol

        private string? _fizSzczegolnaFormaPrawnaSymbol;

        /// Fiz szczegolna forma prawna symbol
        /// Fiz szczegolna forma prawna symbol
        [Column(Order = 2)]
        [XmlElement("fiz_szczegolnaFormaPrawna_Symbol")]
        [JsonProperty(nameof(FizSzczegolnaFormaPrawnaSymbol), Order = 2)]
        [Display(Name = "Fiz szczegolna forma prawna symbol", Prompt = "Wpisz Fiz szczegolna forma prawna symbol",
            Description = "Fiz szczegolna forma prawna symbol")]
        [StringLength(3)]
        [MaxLength(3)]

        public string? FizSzczegolnaFormaPrawnaSymbol
        {
            get => _fizSzczegolnaFormaPrawnaSymbol;
            set
            {
                if (value != _fizSzczegolnaFormaPrawnaSymbol)
                {
                    _fizSzczegolnaFormaPrawnaSymbol = value;
                    OnPropertyChanged(nameof(FizSzczegolnaFormaPrawnaSymbol));
                }
            }
        }

        #endregion

        #region private string? _fizFormaFinansowaniaSymbol; public string? FizFormaFinansowaniaSymbol

        private string? _fizFormaFinansowaniaSymbol;

        /// Fiz forma finansowania symbol
        /// Fiz forma finansowania symbol
        [Column(Order = 2)]
        [XmlElement("fiz_formaFinansowania_Symbol")]
        [JsonProperty(nameof(FizFormaFinansowaniaSymbol), Order = 2)]
        [Display(Name = "Fiz forma finansowania symbol", Prompt = "Wpisz Fiz forma finansowania symbol",
            Description = "Fiz forma finansowania symbol")]
        [StringLength(1)]
        [MaxLength(1)]

        public string? FizFormaFinansowaniaSymbol
        {
            get => _fizFormaFinansowaniaSymbol;
            set
            {
                if (value != _fizFormaFinansowaniaSymbol)
                {
                    _fizFormaFinansowaniaSymbol = value;
                    OnPropertyChanged(nameof(FizFormaFinansowaniaSymbol));
                }
            }
        }

        #endregion

        #region private string? _fizFormaWlasnosciSymbol; public string? FizFormaWlasnosciSymbol

        private string? _fizFormaWlasnosciSymbol;

        /// Fiz forma wlasnosci symbol
        /// Fiz forma wlasnosci symbol
        [Column(Order = 2)]
        [XmlElement("fiz_formaWlasnosci_Symbol")]
        [JsonProperty(nameof(FizFormaWlasnosciSymbol), Order = 2)]
        [Display(Name = "Fiz forma wlasnosci symbol", Prompt = "Wpisz Fiz forma wlasnosci symbol",
            Description = "Fiz forma wlasnosci symbol")]
        [StringLength(50)]
        [MaxLength(50)]

        public string? FizFormaWlasnosciSymbol
        {
            get => _fizFormaWlasnosciSymbol;
            set
            {
                if (value != _fizFormaWlasnosciSymbol)
                {
                    _fizFormaWlasnosciSymbol = value;
                    OnPropertyChanged(nameof(FizFormaWlasnosciSymbol));
                }
            }
        }

        #endregion

        #region private string? _fizPodstawowaFormaPrawnaNazwa; public string? FizPodstawowaFormaPrawnaNazwa

        private string? _fizPodstawowaFormaPrawnaNazwa;

        /// Fiz podstawowa forma prawna nazwa
        /// Fiz podstawowa forma prawna nazwa
        [Column(Order = 2)]
        [XmlElement("fiz_podstawowaFormaPrawna_Nazwa")]
        [JsonProperty(nameof(FizPodstawowaFormaPrawnaNazwa), Order = 2)]
        [Display(Name = "Fiz podstawowa forma prawna nazwa", Prompt = "Wpisz Fiz podstawowa forma prawna nazwa",
            Description = "Fiz podstawowa forma prawna nazwa")]
        [StringLength(200)]
        [MaxLength(200)]

        public string? FizPodstawowaFormaPrawnaNazwa
        {
            get => _fizPodstawowaFormaPrawnaNazwa;
            set
            {
                if (value != _fizPodstawowaFormaPrawnaNazwa)
                {
                    _fizPodstawowaFormaPrawnaNazwa = value;
                    OnPropertyChanged(nameof(FizPodstawowaFormaPrawnaNazwa));
                }
            }
        }

        #endregion

        #region private string? _fizSzczegolnaFormaPrawnaNazwa; public string? FizSzczegolnaFormaPrawnaNazwa

        private string? _fizSzczegolnaFormaPrawnaNazwa;

        /// Fiz szczegolna forma prawna nazwa
        /// Fiz szczegolna forma prawna nazwa
        [Column(Order = 2)]
        [XmlElement("fiz_szczegolnaFormaPrawna_Nazwa")]
        [JsonProperty(nameof(FizSzczegolnaFormaPrawnaNazwa), Order = 2)]
        [Display(Name = "Fiz szczegolna forma prawna nazwa", Prompt = "Wpisz Fiz szczegolna forma prawna nazwa",
            Description = "Fiz szczegolna forma prawna nazwa")]
        [StringLength(200)]
        [MaxLength(200)]

        public string? FizSzczegolnaFormaPrawnaNazwa
        {
            get => _fizSzczegolnaFormaPrawnaNazwa;
            set
            {
                if (value != _fizSzczegolnaFormaPrawnaNazwa)
                {
                    _fizSzczegolnaFormaPrawnaNazwa = value;
                    OnPropertyChanged(nameof(FizSzczegolnaFormaPrawnaNazwa));
                }
            }
        }

        #endregion

        #region private string? _fizFormaFinansowaniaNazwa; public string? FizFormaFinansowaniaNazwa

        private string? _fizFormaFinansowaniaNazwa;

        /// Fiz forma finansowania nazwa
        /// Fiz forma finansowania nazwa
        [Column(Order = 2)]
        [XmlElement("fiz_formaFinansowania_Nazwa")]
        [JsonProperty(nameof(FizFormaFinansowaniaNazwa), Order = 2)]
        [Display(Name = "Fiz forma finansowania nazwa", Prompt = "Wpisz Fiz forma finansowania nazwa",
            Description = "Fiz forma finansowania nazwa")]
        [StringLength(240)]
        [MaxLength(240)]

        public string? FizFormaFinansowaniaNazwa
        {
            get => _fizFormaFinansowaniaNazwa;
            set
            {
                if (value != _fizFormaFinansowaniaNazwa)
                {
                    _fizFormaFinansowaniaNazwa = value;
                    OnPropertyChanged(nameof(FizFormaFinansowaniaNazwa));
                }
            }
        }

        #endregion

        #region private string? _fizFormaWlasnosciNazwa; public string? FizFormaWlasnosciNazwa

        private string? _fizFormaWlasnosciNazwa;

        /// Fiz forma wlasnosci nazwa
        /// Fiz forma wlasnosci nazwa
        [Column(Order = 2)]
        [XmlElement("fiz_formaWlasnosci_Nazwa")]
        [JsonProperty(nameof(FizFormaWlasnosciNazwa), Order = 2)]
        [Display(Name = "Fiz forma wlasnosci nazwa", Prompt = "Wpisz Fiz forma wlasnosci nazwa",
            Description = "Fiz forma wlasnosci nazwa")]
        [StringLength(240)]
        [MaxLength(240)]

        public string? FizFormaWlasnosciNazwa
        {
            get => _fizFormaWlasnosciNazwa;
            set
            {
                if (value != _fizFormaWlasnosciNazwa)
                {
                    _fizFormaWlasnosciNazwa = value;
                    OnPropertyChanged(nameof(FizFormaWlasnosciNazwa));
                }
            }
        }

        #endregion

        #region private int? _fizDzialalnoscCeidg; public int? FizDzialalnoscCeidg

        private int? _fizDzialalnoscCeidg;

        /// Fiz dzialalnosc ceidg
        /// Fiz dzialalnosc ceidg
        [Column(Order = 2)]
        [XmlElement("fiz_dzialalnoscCeidg")]
        [JsonProperty(nameof(FizDzialalnoscCeidg), Order = 2)]
        [Display(Name = "Fiz dzialalnosc ceidg", Prompt = "Wpisz Fiz dzialalnosc ceidg",
            Description = "Fiz dzialalnosc ceidg")]
        [Range(int.MinValue, int.MaxValue)]
        public int? FizDzialalnoscCeidg
        {
            get => _fizDzialalnoscCeidg;
            set
            {
                if (value != _fizDzialalnoscCeidg)
                {
                    _fizDzialalnoscCeidg = value;
                    OnPropertyChanged(nameof(FizDzialalnoscCeidg));
                }
            }
        }

        #endregion

        #region private int? _fizDzialalnoscRolnicza; public int? FizDzialalnoscRolnicza

        private int? _fizDzialalnoscRolnicza;

        /// Fiz dzialalnosc rolnicza
        /// Fiz dzialalnosc rolnicza
        [Column(Order = 2)]
        [XmlElement("fiz_dzialalnoscRolnicza")]
        [JsonProperty(nameof(FizDzialalnoscRolnicza), Order = 2)]
        [Display(Name = "Fiz dzialalnosc rolnicza", Prompt = "Wpisz Fiz dzialalnosc rolnicza",
            Description = "Fiz dzialalnosc rolnicza")]
        [Range(int.MinValue, int.MaxValue)]
        public int? FizDzialalnoscRolnicza
        {
            get => _fizDzialalnoscRolnicza;
            set
            {
                if (value != _fizDzialalnoscRolnicza)
                {
                    _fizDzialalnoscRolnicza = value;
                    OnPropertyChanged(nameof(FizDzialalnoscRolnicza));
                }
            }
        }

        #endregion

        #region private int? _fizDzialalnoscPozostala; public int? FizDzialalnoscPozostala

        private int? _fizDzialalnoscPozostala;

        /// Fiz dzialalnosc pozostala
        /// Fiz dzialalnosc pozostala
        [Column(Order = 2)]
        [XmlElement("fiz_dzialalnoscPozostala")]
        [JsonProperty(nameof(FizDzialalnoscPozostala), Order = 2)]
        [Display(Name = "Fiz dzialalnosc pozostala", Prompt = "Wpisz Fiz dzialalnosc pozostala",
            Description = "Fiz dzialalnosc pozostala")]
        [Range(int.MinValue, int.MaxValue)]
        public int? FizDzialalnoscPozostala
        {
            get => _fizDzialalnoscPozostala;
            set
            {
                if (value != _fizDzialalnoscPozostala)
                {
                    _fizDzialalnoscPozostala = value;
                    OnPropertyChanged(nameof(FizDzialalnoscPozostala));
                }
            }
        }

        #endregion

        #region private int? _fizDzialalnoscSkreslonaDo20141108; public int? FizDzialalnoscSkreslonaDo20141108

        private int? _fizDzialalnoscSkreslonaDo20141108;

        /// Fiz dzialalnosc skreslona do20141108
        /// Fiz dzialalnosc skreslona do20141108
        [Column(Order = 2)]
        [XmlElement("fiz_dzialalnoscSkreslonaDo20141108")]
        [JsonProperty(nameof(FizDzialalnoscSkreslonaDo20141108), Order = 2)]
        [Display(Name = "Fiz dzialalnosc skreslona do20141108", Prompt = "Wpisz Fiz dzialalnosc skreslona do20141108",
            Description = "Fiz dzialalnosc skreslona do20141108")]
        [Range(int.MinValue, int.MaxValue)]
        public int? FizDzialalnoscSkreslonaDo20141108
        {
            get => _fizDzialalnoscSkreslonaDo20141108;
            set
            {
                if (value != _fizDzialalnoscSkreslonaDo20141108)
                {
                    _fizDzialalnoscSkreslonaDo20141108 = value;
                    OnPropertyChanged(nameof(FizDzialalnoscSkreslonaDo20141108));
                }
            }
        }

        #endregion

        #region private int? _fizLiczbaJednLokalnych; public int? FizLiczbaJednLokalnych

        private int? _fizLiczbaJednLokalnych;

        /// Fiz liczba jedn lokalnych
        /// Fiz liczba jedn lokalnych
        [Column(Order = 2)]
        [XmlElement("fiz_liczbaJednLokalnych")]
        [JsonProperty(nameof(FizLiczbaJednLokalnych), Order = 2)]
        [Display(Name = "Fiz liczba jedn lokalnych", Prompt = "Wpisz Fiz liczba jedn lokalnych",
            Description = "Fiz liczba jedn lokalnych")]
        [Range(int.MinValue, int.MaxValue)]
        public int? FizLiczbaJednLokalnych
        {
            get => _fizLiczbaJednLokalnych;
            set
            {
                if (value != _fizLiczbaJednLokalnych)
                {
                    _fizLiczbaJednLokalnych = value;
                    OnPropertyChanged(nameof(FizLiczbaJednLokalnych));
                }
            }
        }

        #endregion
    }

    #endregion
}

#endregion
