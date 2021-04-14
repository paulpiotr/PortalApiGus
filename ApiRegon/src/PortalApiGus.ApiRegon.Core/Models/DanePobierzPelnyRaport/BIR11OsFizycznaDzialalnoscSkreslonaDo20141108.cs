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
    #region public class BIR11OsFizycznaDzialalnoscSkreslonaDo20141108 : DanePobierzPelnyRaport

    /// <summary>
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport BIR11OsFizycznaDzialalnoscSkreslonaDo20141108
    ///     Data model of entities found in the basic report
    /// </summary>
    [Table(nameof(BIR11OsFizycznaDzialalnoscSkreslonaDo20141108), Schema = "pagard")]
    [JsonObject(nameof(BIR11OsFizycznaDzialalnoscSkreslonaDo20141108))]
    [Display(Name = "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
        Description = "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108")]
    [Serializable]
    [XmlRoot("dane")]
    [Index(nameof(FizRegon9))]
    [Index(nameof(FizNazwa))]
    [Index(nameof(FizNazwaSkrocona))]
    [Index(nameof(FizDataPowstania))]
    [Index(nameof(FizDataRozpoczeciaDzialalnosci))]
    [Index(nameof(FizDataWpisuDzialalnosciDoRegon))]
    [Index(nameof(FizDataZawieszeniaDzialalnosci))]
    [Index(nameof(FizDataWznowieniaDzialalnosci))]
    [Index(nameof(FizDataZaistnieniaZmianyDzialalnosci))]
    [Index(nameof(FizDataZakonczeniaDzialalnosci))]
    [Index(nameof(FizDataSkresleniaDzialalnosciZRegon))]
    [Index(nameof(FizAdSiedzKrajSymbol))]
    [Index(nameof(FizAdSiedzWojewodztwoSymbol))]
    [Index(nameof(FizAdSiedzPowiatSymbol))]
    [Index(nameof(FizAdSiedzGminaSymbol))]
    [Index(nameof(FizAdSiedzKodPocztowy))]
    [Index(nameof(FizAdSiedzMiejscowoscPocztySymbol))]
    [Index(nameof(FizAdSiedzMiejscowoscSymbol))]
    [Index(nameof(FizAdSiedzUlicaSymbol))]
    [Index(nameof(FizAdSiedzNumerNieruchomosci))]
    [Index(nameof(FizAdSiedzNumerLokalu))]
    [Index(nameof(FizAdSiedzNietypoweMiejsceLokalizacji))]
    [Index(nameof(FizNumerTelefonu))]
    [Index(nameof(FizNumerWewnetrznyTelefonu))]
    [Index(nameof(FizNumerFaksu))]
    [Index(nameof(FizAdresEmail))]
    [Index(nameof(FizAdresStronyinternetowej))]
    [Index(nameof(FizAdresEmail2))]
    [Index(nameof(FizAdSiedzKrajNazwa))]
    [Index(nameof(FizAdSiedzWojewodztwoNazwa))]
    [Index(nameof(FizAdSiedzPowiatNazwa))]
    [Index(nameof(FizAdSiedzGminaNazwa))]
    [Index(nameof(FizAdSiedzMiejscowoscNazwa))]
    [Index(nameof(FizAdSiedzMiejscowoscPocztyNazwa))]
    [Index(nameof(FizAdSiedzUlicaNazwa))]
    public class BIR11OsFizycznaDzialalnoscSkreslonaDo20141108 : DanePobierzPelnyRaport
    {
        #region public override TModel Create<TModel>...

        public override TModel Create<TModel>(string pRegon, string pNazwaRaportu, string xml,
            ICollection<MessageInspector> messageInspectorCollection = null!)
        {
            BIR11OsFizycznaDzialalnoscSkreslonaDo20141108 model =
                XmlHelper.DeserializeXmlFromString<BIR11OsFizycznaDzialalnoscSkreslonaDo20141108>(xml) ??
                new BIR11OsFizycznaDzialalnoscSkreslonaDo20141108();
            model.PRegon = pRegon;
            model.PNazwaRaportu = pNazwaRaportu;
            DaneSzukajPodmiotyKomunikatyOBledach error =
                XmlHelper.DeserializeXmlFromString<DaneSzukajPodmiotyKomunikatyOBledach>(
                    xml);
            model.DaneSzukajPodmiotyKomunikatyOBledach = error;
            if (null != messageInspectorCollection && messageInspectorCollection.Count > 0)
            {
                model.BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector =
                    new List<BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector>();
                foreach (MessageInspector messageInspector in messageInspectorCollection)
                {
                    model.BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector.Add(
                        new BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector(
                            model, messageInspector));
                }
            }

            return (model as TModel)!;
        }

        #endregion

        #region ICollection<DaneSzukajPodmioty>? _daneSzukajPodmioty...

        private ICollection<DaneSzukajPodmioty.DaneSzukajPodmioty>? _daneSzukajPodmioty;

        /// <summary>
        ///     Raport podstawowy
        ///     Raport podstawowy
        /// </summary>
        [Column(Order = 2)]
        [XmlIgnore]
        [JsonProperty(nameof(DaneSzukajPodmioty), Order = 2)]
        [InverseProperty("BIR11OsFizycznaDzialalnoscSkreslonaDo20141108")]
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

        #region private ICollection<BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector>...

        private ICollection<BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector> _modelMessageInspector;

        /// <summary>
        ///     Kolekcja elementów inspektora wiadomości usługi, relacja do encji DaneSzukajPodmioty, zawiera informacje dotyczące
        ///     przetwarzania żądań
        ///     Service Message Inspector Item Collection, DaneSzukajPodmioty relationship, contains information about request
        ///     processing
        /// </summary>
        [XmlIgnore]
        [JsonProperty(nameof(BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector), Order = 2)]
        [Display(Name = "Inspektor wiadomości usługi",
            Prompt = "Wybierz elementy kolekcji inspektora wiadomości usługi",
            Description =
                "Kolekcja elementów inspektora wiadomości usługi")]
        public virtual ICollection<BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector> BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector
        {
            get => _modelMessageInspector;
            set
            {
                if (!Equals(value, _modelMessageInspector))
                {
                    _modelMessageInspector = value;
                    OnPropertyChanged(nameof(BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector));
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

        #region private string? _fizNazwa; public string? FizNazwa

        private string? _fizNazwa;

        /// Fiz nazwa
        /// Fiz nazwa
        [Column(Order = 2)]
        [XmlElement("fiz_nazwa")]
        [JsonProperty(nameof(FizNazwa), Order = 2)]
        [Display(Name = "Fiz nazwa", Prompt = "Wpisz Fiz nazwa", Description = "Fiz nazwa")]
        [StringLength(2000)]
        [MaxLength(2000)]

        public string? FizNazwa
        {
            get => _fizNazwa;
            set
            {
                if (value != _fizNazwa)
                {
                    _fizNazwa = value;
                    OnPropertyChanged(nameof(FizNazwa));
                }
            }
        }

        #endregion

        #region private string? _fizNazwaSkrocona; public string? FizNazwaSkrocona

        private string? _fizNazwaSkrocona;

        /// Fiz nazwa skrocona
        /// Fiz nazwa skrocona
        [Column(Order = 2)]
        [XmlElement("fiz_nazwaSkrocona")]
        [JsonProperty(nameof(FizNazwaSkrocona), Order = 2)]
        [Display(Name = "Fiz nazwa skrocona", Prompt = "Wpisz Fiz nazwa skrocona", Description = "Fiz nazwa skrocona")]
        [StringLength(1)]
        [MaxLength(1)]

        public string? FizNazwaSkrocona
        {
            get => _fizNazwaSkrocona;
            set
            {
                if (value != _fizNazwaSkrocona)
                {
                    _fizNazwaSkrocona = value;
                    OnPropertyChanged(nameof(FizNazwaSkrocona));
                }
            }
        }

        #endregion

        #region private string? _fizDataPowstania; public string? FizDataPowstania

        private string? _fizDataPowstania;

        /// Fiz data powstania
        /// Fiz data powstania
        [Column(Order = 2)]
        [XmlElement("fiz_dataPowstania")]
        [JsonProperty(nameof(FizDataPowstania), Order = 2)]
        [Display(Name = "Fiz data powstania", Prompt = "Wpisz Fiz data powstania", Description = "Fiz data powstania")]
        [StringLength(1)]
        [MaxLength(1)]

        public string? FizDataPowstania
        {
            get => _fizDataPowstania;
            set
            {
                if (value != _fizDataPowstania)
                {
                    _fizDataPowstania = value;
                    OnPropertyChanged(nameof(FizDataPowstania));
                }
            }
        }

        #endregion

        #region private string? _fizDataRozpoczeciaDzialalnosci; public string? FizDataRozpoczeciaDzialalnosci

        private string? _fizDataRozpoczeciaDzialalnosci;

        /// Fiz data rozpoczecia dzialalnosci
        /// Fiz data rozpoczecia dzialalnosci
        [Column(Order = 2)]
        [XmlElement("fiz_dataRozpoczeciaDzialalnosci")]
        [JsonProperty(nameof(FizDataRozpoczeciaDzialalnosci), Order = 2)]
        [Display(Name = "Fiz data rozpoczecia dzialalnosci", Prompt = "Wpisz Fiz data rozpoczecia dzialalnosci",
            Description = "Fiz data rozpoczecia dzialalnosci")]
        [StringLength(1)]
        [MaxLength(1)]

        public string? FizDataRozpoczeciaDzialalnosci
        {
            get => _fizDataRozpoczeciaDzialalnosci;
            set
            {
                if (value != _fizDataRozpoczeciaDzialalnosci)
                {
                    _fizDataRozpoczeciaDzialalnosci = value;
                    OnPropertyChanged(nameof(FizDataRozpoczeciaDzialalnosci));
                }
            }
        }

        #endregion

        #region private string? _fizDataWpisuDzialalnosciDoRegon; public string? FizDataWpisuDzialalnosciDoRegon

        private string? _fizDataWpisuDzialalnosciDoRegon;

        /// Fiz data wpisu dzialalnosci do regon
        /// Fiz data wpisu dzialalnosci do regon
        [Column(Order = 2)]
        [XmlElement("fiz_dataWpisuDzialalnosciDoRegon")]
        [JsonProperty(nameof(FizDataWpisuDzialalnosciDoRegon), Order = 2)]
        [Display(Name = "Fiz data wpisu dzialalnosci do regon", Prompt = "Wpisz Fiz data wpisu dzialalnosci do regon",
            Description = "Fiz data wpisu dzialalnosci do regon")]
        [StringLength(1)]
        [MaxLength(1)]

        public string? FizDataWpisuDzialalnosciDoRegon
        {
            get => _fizDataWpisuDzialalnosciDoRegon;
            set
            {
                if (value != _fizDataWpisuDzialalnosciDoRegon)
                {
                    _fizDataWpisuDzialalnosciDoRegon = value;
                    OnPropertyChanged(nameof(FizDataWpisuDzialalnosciDoRegon));
                }
            }
        }

        #endregion

        #region private string? _fizDataZawieszeniaDzialalnosci; public string? FizDataZawieszeniaDzialalnosci

        private string? _fizDataZawieszeniaDzialalnosci;

        /// Fiz data zawieszenia dzialalnosci
        /// Fiz data zawieszenia dzialalnosci
        [Column(Order = 2)]
        [XmlElement("fiz_dataZawieszeniaDzialalnosci")]
        [JsonProperty(nameof(FizDataZawieszeniaDzialalnosci), Order = 2)]
        [Display(Name = "Fiz data zawieszenia dzialalnosci", Prompt = "Wpisz Fiz data zawieszenia dzialalnosci",
            Description = "Fiz data zawieszenia dzialalnosci")]
        [StringLength(1)]
        [MaxLength(1)]

        public string? FizDataZawieszeniaDzialalnosci
        {
            get => _fizDataZawieszeniaDzialalnosci;
            set
            {
                if (value != _fizDataZawieszeniaDzialalnosci)
                {
                    _fizDataZawieszeniaDzialalnosci = value;
                    OnPropertyChanged(nameof(FizDataZawieszeniaDzialalnosci));
                }
            }
        }

        #endregion

        #region private string? _fizDataWznowieniaDzialalnosci; public string? FizDataWznowieniaDzialalnosci

        private string? _fizDataWznowieniaDzialalnosci;

        /// Fiz data wznowienia dzialalnosci
        /// Fiz data wznowienia dzialalnosci
        [Column(Order = 2)]
        [XmlElement("fiz_dataWznowieniaDzialalnosci")]
        [JsonProperty(nameof(FizDataWznowieniaDzialalnosci), Order = 2)]
        [Display(Name = "Fiz data wznowienia dzialalnosci", Prompt = "Wpisz Fiz data wznowienia dzialalnosci",
            Description = "Fiz data wznowienia dzialalnosci")]
        [StringLength(1)]
        [MaxLength(1)]

        public string? FizDataWznowieniaDzialalnosci
        {
            get => _fizDataWznowieniaDzialalnosci;
            set
            {
                if (value != _fizDataWznowieniaDzialalnosci)
                {
                    _fizDataWznowieniaDzialalnosci = value;
                    OnPropertyChanged(nameof(FizDataWznowieniaDzialalnosci));
                }
            }
        }

        #endregion

        #region private string? _fizDataZaistnieniaZmianyDzialalnosci; public string? FizDataZaistnieniaZmianyDzialalnosci

        private string? _fizDataZaistnieniaZmianyDzialalnosci;

        /// Fiz data zaistnienia zmiany dzialalnosci
        /// Fiz data zaistnienia zmiany dzialalnosci
        [Column(Order = 2)]
        [XmlElement("fiz_dataZaistnieniaZmianyDzialalnosci")]
        [JsonProperty(nameof(FizDataZaistnieniaZmianyDzialalnosci), Order = 2)]
        [Display(Name = "Fiz data zaistnienia zmiany dzialalnosci",
            Prompt = "Wpisz Fiz data zaistnienia zmiany dzialalnosci",
            Description = "Fiz data zaistnienia zmiany dzialalnosci")]
        [StringLength(1)]
        [MaxLength(1)]

        public string? FizDataZaistnieniaZmianyDzialalnosci
        {
            get => _fizDataZaistnieniaZmianyDzialalnosci;
            set
            {
                if (value != _fizDataZaistnieniaZmianyDzialalnosci)
                {
                    _fizDataZaistnieniaZmianyDzialalnosci = value;
                    OnPropertyChanged(nameof(FizDataZaistnieniaZmianyDzialalnosci));
                }
            }
        }

        #endregion

        #region private string? _fizDataZakonczeniaDzialalnosci; public string? FizDataZakonczeniaDzialalnosci

        private string? _fizDataZakonczeniaDzialalnosci;

        /// Fiz data zakonczenia dzialalnosci
        /// Fiz data zakonczenia dzialalnosci
        [Column(Order = 2)]
        [XmlElement("fiz_dataZakonczeniaDzialalnosci")]
        [JsonProperty(nameof(FizDataZakonczeniaDzialalnosci), Order = 2)]
        [Display(Name = "Fiz data zakonczenia dzialalnosci", Prompt = "Wpisz Fiz data zakonczenia dzialalnosci",
            Description = "Fiz data zakonczenia dzialalnosci")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? FizDataZakonczeniaDzialalnosci
        {
            get => _fizDataZakonczeniaDzialalnosci;
            set
            {
                if (value != _fizDataZakonczeniaDzialalnosci)
                {
                    _fizDataZakonczeniaDzialalnosci = value;
                    OnPropertyChanged(nameof(FizDataZakonczeniaDzialalnosci));
                }
            }
        }

        #endregion

        #region private string? _fizDataSkresleniaDzialalnosciZRegon; public string? FizDataSkresleniaDzialalnosciZRegon

        private string? _fizDataSkresleniaDzialalnosciZRegon;

        /// Fiz data skreslenia dzialalnosci z regon
        /// Fiz data skreslenia dzialalnosci z regon
        [Column(Order = 2)]
        [XmlElement("fiz_dataSkresleniaDzialalnosciZRegon")]
        [JsonProperty(nameof(FizDataSkresleniaDzialalnosciZRegon), Order = 2)]
        [Display(Name = "Fiz data skreslenia dzialalnosci z regon",
            Prompt = "Wpisz Fiz data skreslenia dzialalnosci z regon",
            Description = "Fiz data skreslenia dzialalnosci z regon")]
        [StringLength(1)]
        [MaxLength(1)]

        public string? FizDataSkresleniaDzialalnosciZRegon
        {
            get => _fizDataSkresleniaDzialalnosciZRegon;
            set
            {
                if (value != _fizDataSkresleniaDzialalnosciZRegon)
                {
                    _fizDataSkresleniaDzialalnosciZRegon = value;
                    OnPropertyChanged(nameof(FizDataSkresleniaDzialalnosciZRegon));
                }
            }
        }

        #endregion

        #region private string? _fizAdSiedzKrajSymbol; public string? FizAdSiedzKrajSymbol

        private string? _fizAdSiedzKrajSymbol;

        /// Fiz ad siedz kraj symbol
        /// Fiz ad siedz kraj symbol
        [Column(Order = 2)]
        [XmlElement("fiz_adSiedzKraj_Symbol")]
        [JsonProperty(nameof(FizAdSiedzKrajSymbol), Order = 2)]
        [Display(Name = "Fiz ad siedz kraj symbol", Prompt = "Wpisz Fiz ad siedz kraj symbol",
            Description = "Fiz ad siedz kraj symbol")]
        [StringLength(2)]
        [MaxLength(2)]

        public string? FizAdSiedzKrajSymbol
        {
            get => _fizAdSiedzKrajSymbol;
            set
            {
                if (value != _fizAdSiedzKrajSymbol)
                {
                    _fizAdSiedzKrajSymbol = value;
                    OnPropertyChanged(nameof(FizAdSiedzKrajSymbol));
                }
            }
        }

        #endregion

        #region private string? _fizAdSiedzWojewodztwoSymbol; public string? FizAdSiedzWojewodztwoSymbol

        private string? _fizAdSiedzWojewodztwoSymbol;

        /// Fiz ad siedz wojewodztwo symbol
        /// Fiz ad siedz wojewodztwo symbol
        [Column(Order = 2)]
        [XmlElement("fiz_adSiedzWojewodztwo_Symbol")]
        [JsonProperty(nameof(FizAdSiedzWojewodztwoSymbol), Order = 2)]
        [Display(Name = "Fiz ad siedz wojewodztwo symbol", Prompt = "Wpisz Fiz ad siedz wojewodztwo symbol",
            Description = "Fiz ad siedz wojewodztwo symbol")]
        [StringLength(2)]
        [MaxLength(2)]

        public string? FizAdSiedzWojewodztwoSymbol
        {
            get => _fizAdSiedzWojewodztwoSymbol;
            set
            {
                if (value != _fizAdSiedzWojewodztwoSymbol)
                {
                    _fizAdSiedzWojewodztwoSymbol = value;
                    OnPropertyChanged(nameof(FizAdSiedzWojewodztwoSymbol));
                }
            }
        }

        #endregion

        #region private string? _fizAdSiedzPowiatSymbol; public string? FizAdSiedzPowiatSymbol

        private string? _fizAdSiedzPowiatSymbol;

        /// Fiz ad siedz powiat symbol
        /// Fiz ad siedz powiat symbol
        [Column(Order = 2)]
        [XmlElement("fiz_adSiedzPowiat_Symbol")]
        [JsonProperty(nameof(FizAdSiedzPowiatSymbol), Order = 2)]
        [Display(Name = "Fiz ad siedz powiat symbol", Prompt = "Wpisz Fiz ad siedz powiat symbol",
            Description = "Fiz ad siedz powiat symbol")]
        [StringLength(2)]
        [MaxLength(2)]

        public string? FizAdSiedzPowiatSymbol
        {
            get => _fizAdSiedzPowiatSymbol;
            set
            {
                if (value != _fizAdSiedzPowiatSymbol)
                {
                    _fizAdSiedzPowiatSymbol = value;
                    OnPropertyChanged(nameof(FizAdSiedzPowiatSymbol));
                }
            }
        }

        #endregion

        #region private string? _fizAdSiedzGminaSymbol; public string? FizAdSiedzGminaSymbol

        private string? _fizAdSiedzGminaSymbol;

        /// Fiz ad siedz gmina symbol
        /// Fiz ad siedz gmina symbol
        [Column(Order = 2)]
        [XmlElement("fiz_adSiedzGmina_Symbol")]
        [JsonProperty(nameof(FizAdSiedzGminaSymbol), Order = 2)]
        [Display(Name = "Fiz ad siedz gmina symbol", Prompt = "Wpisz Fiz ad siedz gmina symbol",
            Description = "Fiz ad siedz gmina symbol")]
        [StringLength(3)]
        [MaxLength(3)]

        public string? FizAdSiedzGminaSymbol
        {
            get => _fizAdSiedzGminaSymbol;
            set
            {
                if (value != _fizAdSiedzGminaSymbol)
                {
                    _fizAdSiedzGminaSymbol = value;
                    OnPropertyChanged(nameof(FizAdSiedzGminaSymbol));
                }
            }
        }

        #endregion

        #region private string? _fizAdSiedzKodPocztowy; public string? FizAdSiedzKodPocztowy

        private string? _fizAdSiedzKodPocztowy;

        /// Fiz ad siedz kod pocztowy
        /// Fiz ad siedz kod pocztowy
        [Column(Order = 2)]
        [XmlElement("fiz_adSiedzKodPocztowy")]
        [JsonProperty(nameof(FizAdSiedzKodPocztowy), Order = 2)]
        [Display(Name = "Fiz ad siedz kod pocztowy", Prompt = "Wpisz Fiz ad siedz kod pocztowy",
            Description = "Fiz ad siedz kod pocztowy")]
        [StringLength(12)]
        [MaxLength(12)]

        public string? FizAdSiedzKodPocztowy
        {
            get => _fizAdSiedzKodPocztowy;
            set
            {
                if (value != _fizAdSiedzKodPocztowy)
                {
                    _fizAdSiedzKodPocztowy = value;
                    OnPropertyChanged(nameof(FizAdSiedzKodPocztowy));
                }
            }
        }

        #endregion

        #region private string? _fizAdSiedzMiejscowoscPocztySymbol; public string? FizAdSiedzMiejscowoscPocztySymbol

        private string? _fizAdSiedzMiejscowoscPocztySymbol;

        /// Fiz ad siedz miejscowosc poczty symbol
        /// Fiz ad siedz miejscowosc poczty symbol
        [Column(Order = 2)]
        [XmlElement("fiz_adSiedzMiejscowoscPoczty_Symbol")]
        [JsonProperty(nameof(FizAdSiedzMiejscowoscPocztySymbol), Order = 2)]
        [Display(Name = "Fiz ad siedz miejscowosc poczty symbol",
            Prompt = "Wpisz Fiz ad siedz miejscowosc poczty symbol",
            Description = "Fiz ad siedz miejscowosc poczty symbol")]
        [StringLength(7)]
        [MaxLength(7)]

        public string? FizAdSiedzMiejscowoscPocztySymbol
        {
            get => _fizAdSiedzMiejscowoscPocztySymbol;
            set
            {
                if (value != _fizAdSiedzMiejscowoscPocztySymbol)
                {
                    _fizAdSiedzMiejscowoscPocztySymbol = value;
                    OnPropertyChanged(nameof(FizAdSiedzMiejscowoscPocztySymbol));
                }
            }
        }

        #endregion

        #region private string? _fizAdSiedzMiejscowoscSymbol; public string? FizAdSiedzMiejscowoscSymbol

        private string? _fizAdSiedzMiejscowoscSymbol;

        /// Fiz ad siedz miejscowosc symbol
        /// Fiz ad siedz miejscowosc symbol
        [Column(Order = 2)]
        [XmlElement("fiz_adSiedzMiejscowosc_Symbol")]
        [JsonProperty(nameof(FizAdSiedzMiejscowoscSymbol), Order = 2)]
        [Display(Name = "Fiz ad siedz miejscowosc symbol", Prompt = "Wpisz Fiz ad siedz miejscowosc symbol",
            Description = "Fiz ad siedz miejscowosc symbol")]
        [StringLength(7)]
        [MaxLength(7)]

        public string? FizAdSiedzMiejscowoscSymbol
        {
            get => _fizAdSiedzMiejscowoscSymbol;
            set
            {
                if (value != _fizAdSiedzMiejscowoscSymbol)
                {
                    _fizAdSiedzMiejscowoscSymbol = value;
                    OnPropertyChanged(nameof(FizAdSiedzMiejscowoscSymbol));
                }
            }
        }

        #endregion

        #region private string? _fizAdSiedzUlicaSymbol; public string? FizAdSiedzUlicaSymbol

        private string? _fizAdSiedzUlicaSymbol;

        /// Fiz ad siedz ulica symbol
        /// Fiz ad siedz ulica symbol
        [Column(Order = 2)]
        [XmlElement("fiz_adSiedzUlica_Symbol")]
        [JsonProperty(nameof(FizAdSiedzUlicaSymbol), Order = 2)]
        [Display(Name = "Fiz ad siedz ulica symbol", Prompt = "Wpisz Fiz ad siedz ulica symbol",
            Description = "Fiz ad siedz ulica symbol")]
        [StringLength(5)]
        [MaxLength(5)]

        public string? FizAdSiedzUlicaSymbol
        {
            get => _fizAdSiedzUlicaSymbol;
            set
            {
                if (value != _fizAdSiedzUlicaSymbol)
                {
                    _fizAdSiedzUlicaSymbol = value;
                    OnPropertyChanged(nameof(FizAdSiedzUlicaSymbol));
                }
            }
        }

        #endregion

        #region private string? _fizAdSiedzNumerNieruchomosci; public string? FizAdSiedzNumerNieruchomosci

        private string? _fizAdSiedzNumerNieruchomosci;

        /// Fiz ad siedz numer nieruchomosci
        /// Fiz ad siedz numer nieruchomosci
        [Column(Order = 2)]
        [XmlElement("fiz_adSiedzNumerNieruchomosci")]
        [JsonProperty(nameof(FizAdSiedzNumerNieruchomosci), Order = 2)]
        [Display(Name = "Fiz ad siedz numer nieruchomosci", Prompt = "Wpisz Fiz ad siedz numer nieruchomosci",
            Description = "Fiz ad siedz numer nieruchomosci")]
        [StringLength(20)]
        [MaxLength(20)]

        public string? FizAdSiedzNumerNieruchomosci
        {
            get => _fizAdSiedzNumerNieruchomosci;
            set
            {
                if (value != _fizAdSiedzNumerNieruchomosci)
                {
                    _fizAdSiedzNumerNieruchomosci = value;
                    OnPropertyChanged(nameof(FizAdSiedzNumerNieruchomosci));
                }
            }
        }

        #endregion

        #region private string? _fizAdSiedzNumerLokalu; public string? FizAdSiedzNumerLokalu

        private string? _fizAdSiedzNumerLokalu;

        /// Fiz ad siedz numer lokalu
        /// Fiz ad siedz numer lokalu
        [Column(Order = 2)]
        [XmlElement("fiz_adSiedzNumerLokalu")]
        [JsonProperty(nameof(FizAdSiedzNumerLokalu), Order = 2)]
        [Display(Name = "Fiz ad siedz numer lokalu", Prompt = "Wpisz Fiz ad siedz numer lokalu",
            Description = "Fiz ad siedz numer lokalu")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? FizAdSiedzNumerLokalu
        {
            get => _fizAdSiedzNumerLokalu;
            set
            {
                if (value != _fizAdSiedzNumerLokalu)
                {
                    _fizAdSiedzNumerLokalu = value;
                    OnPropertyChanged(nameof(FizAdSiedzNumerLokalu));
                }
            }
        }

        #endregion

        #region private string? _fizAdSiedzNietypoweMiejsceLokalizacji; public string? FizAdSiedzNietypoweMiejsceLokalizacji

        private string? _fizAdSiedzNietypoweMiejsceLokalizacji;

        /// Fiz ad siedz nietypowe miejsce lokalizacji
        /// Fiz ad siedz nietypowe miejsce lokalizacji
        [Column(Order = 2)]
        [XmlElement("fiz_adSiedzNietypoweMiejsceLokalizacji")]
        [JsonProperty(nameof(FizAdSiedzNietypoweMiejsceLokalizacji), Order = 2)]
        [Display(Name = "Fiz ad siedz nietypowe miejsce lokalizacji",
            Prompt = "Wpisz Fiz ad siedz nietypowe miejsce lokalizacji",
            Description = "Fiz ad siedz nietypowe miejsce lokalizacji")]
        [StringLength(160)]
        [MaxLength(160)]

        public string? FizAdSiedzNietypoweMiejsceLokalizacji
        {
            get => _fizAdSiedzNietypoweMiejsceLokalizacji;
            set
            {
                if (value != _fizAdSiedzNietypoweMiejsceLokalizacji)
                {
                    _fizAdSiedzNietypoweMiejsceLokalizacji = value;
                    OnPropertyChanged(nameof(FizAdSiedzNietypoweMiejsceLokalizacji));
                }
            }
        }

        #endregion

        #region private string? _fizNumerTelefonu; public string? FizNumerTelefonu

        private string? _fizNumerTelefonu;

        /// Fiz numer telefonu
        /// Fiz numer telefonu
        [Column(Order = 2)]
        [XmlElement("fiz_numerTelefonu")]
        [JsonProperty(nameof(FizNumerTelefonu), Order = 2)]
        [Display(Name = "Fiz numer telefonu", Prompt = "Wpisz Fiz numer telefonu", Description = "Fiz numer telefonu")]
        [StringLength(1)]
        [MaxLength(1)]

        public string? FizNumerTelefonu
        {
            get => _fizNumerTelefonu;
            set
            {
                if (value != _fizNumerTelefonu)
                {
                    _fizNumerTelefonu = value;
                    OnPropertyChanged(nameof(FizNumerTelefonu));
                }
            }
        }

        #endregion

        #region private string? _fizNumerWewnetrznyTelefonu; public string? FizNumerWewnetrznyTelefonu

        private string? _fizNumerWewnetrznyTelefonu;

        /// Fiz numer wewnetrzny telefonu
        /// Fiz numer wewnetrzny telefonu
        [Column(Order = 2)]
        [XmlElement("fiz_numerWewnetrznyTelefonu")]
        [JsonProperty(nameof(FizNumerWewnetrznyTelefonu), Order = 2)]
        [Display(Name = "Fiz numer wewnetrzny telefonu", Prompt = "Wpisz Fiz numer wewnetrzny telefonu",
            Description = "Fiz numer wewnetrzny telefonu")]
        [StringLength(1)]
        [MaxLength(1)]

        public string? FizNumerWewnetrznyTelefonu
        {
            get => _fizNumerWewnetrznyTelefonu;
            set
            {
                if (value != _fizNumerWewnetrznyTelefonu)
                {
                    _fizNumerWewnetrznyTelefonu = value;
                    OnPropertyChanged(nameof(FizNumerWewnetrznyTelefonu));
                }
            }
        }

        #endregion

        #region private string? _fizNumerFaksu; public string? FizNumerFaksu

        private string? _fizNumerFaksu;

        /// Fiz numer faksu
        /// Fiz numer faksu
        [Column(Order = 2)]
        [XmlElement("fiz_numerFaksu")]
        [JsonProperty(nameof(FizNumerFaksu), Order = 2)]
        [Display(Name = "Fiz numer faksu", Prompt = "Wpisz Fiz numer faksu", Description = "Fiz numer faksu")]
        [StringLength(1)]
        [MaxLength(1)]

        public string? FizNumerFaksu
        {
            get => _fizNumerFaksu;
            set
            {
                if (value != _fizNumerFaksu)
                {
                    _fizNumerFaksu = value;
                    OnPropertyChanged(nameof(FizNumerFaksu));
                }
            }
        }

        #endregion

        #region private string? _fizAdresEmail; public string? FizAdresEmail

        private string? _fizAdresEmail;

        /// Fiz adres email
        /// Fiz adres email
        [Column(Order = 2)]
        [XmlElement("fiz_adresEmail")]
        [JsonProperty(nameof(FizAdresEmail), Order = 2)]
        [Display(Name = "Fiz adres email", Prompt = "Wpisz Fiz adres email", Description = "Fiz adres email")]
        [StringLength(1)]
        [MaxLength(1)]

        public string? FizAdresEmail
        {
            get => _fizAdresEmail;
            set
            {
                if (value != _fizAdresEmail)
                {
                    _fizAdresEmail = value;
                    OnPropertyChanged(nameof(FizAdresEmail));
                }
            }
        }

        #endregion

        #region private string? _fizAdresStronyinternetowej; public string? FizAdresStronyinternetowej

        private string? _fizAdresStronyinternetowej;

        /// Fiz adres stronyinternetowej
        /// Fiz adres stronyinternetowej
        [Column(Order = 2)]
        [XmlElement("fiz_adresStronyinternetowej")]
        [JsonProperty(nameof(FizAdresStronyinternetowej), Order = 2)]
        [Display(Name = "Fiz adres stronyinternetowej", Prompt = "Wpisz Fiz adres stronyinternetowej",
            Description = "Fiz adres stronyinternetowej")]
        [StringLength(1)]
        [MaxLength(1)]

        public string? FizAdresStronyinternetowej
        {
            get => _fizAdresStronyinternetowej;
            set
            {
                if (value != _fizAdresStronyinternetowej)
                {
                    _fizAdresStronyinternetowej = value;
                    OnPropertyChanged(nameof(FizAdresStronyinternetowej));
                }
            }
        }

        #endregion

        #region private string? _fizAdresEmail2; public string? FizAdresEmail2

        private string? _fizAdresEmail2;

        /// Fiz adres email2
        /// Fiz adres email2
        [Column(Order = 2)]
        [XmlElement("fiz_adresEmail2")]
        [JsonProperty(nameof(FizAdresEmail2), Order = 2)]
        [Display(Name = "Fiz adres email2", Prompt = "Wpisz Fiz adres email2", Description = "Fiz adres email2")]
        [StringLength(1)]
        [MaxLength(1)]

        public string? FizAdresEmail2
        {
            get => _fizAdresEmail2;
            set
            {
                if (value != _fizAdresEmail2)
                {
                    _fizAdresEmail2 = value;
                    OnPropertyChanged(nameof(FizAdresEmail2));
                }
            }
        }

        #endregion

        #region private string? _fizAdSiedzKrajNazwa; public string? FizAdSiedzKrajNazwa

        private string? _fizAdSiedzKrajNazwa;

        /// Fiz ad siedz kraj nazwa
        /// Fiz ad siedz kraj nazwa
        [Column(Order = 2)]
        [XmlElement("fiz_adSiedzKraj_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzKrajNazwa), Order = 2)]
        [Display(Name = "Fiz ad siedz kraj nazwa", Prompt = "Wpisz Fiz ad siedz kraj nazwa",
            Description = "Fiz ad siedz kraj nazwa")]
        [StringLength(200)]
        [MaxLength(200)]

        public string? FizAdSiedzKrajNazwa
        {
            get => _fizAdSiedzKrajNazwa;
            set
            {
                if (value != _fizAdSiedzKrajNazwa)
                {
                    _fizAdSiedzKrajNazwa = value;
                    OnPropertyChanged(nameof(FizAdSiedzKrajNazwa));
                }
            }
        }

        #endregion

        #region private string? _fizAdSiedzWojewodztwoNazwa; public string? FizAdSiedzWojewodztwoNazwa

        private string? _fizAdSiedzWojewodztwoNazwa;

        /// Fiz ad siedz wojewodztwo nazwa
        /// Fiz ad siedz wojewodztwo nazwa
        [Column(Order = 2)]
        [XmlElement("fiz_adSiedzWojewodztwo_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzWojewodztwoNazwa), Order = 2)]
        [Display(Name = "Fiz ad siedz wojewodztwo nazwa", Prompt = "Wpisz Fiz ad siedz wojewodztwo nazwa",
            Description = "Fiz ad siedz wojewodztwo nazwa")]
        [StringLength(100)]
        [MaxLength(100)]

        public string? FizAdSiedzWojewodztwoNazwa
        {
            get => _fizAdSiedzWojewodztwoNazwa;
            set
            {
                if (value != _fizAdSiedzWojewodztwoNazwa)
                {
                    _fizAdSiedzWojewodztwoNazwa = value;
                    OnPropertyChanged(nameof(FizAdSiedzWojewodztwoNazwa));
                }
            }
        }

        #endregion

        #region private string? _fizAdSiedzPowiatNazwa; public string? FizAdSiedzPowiatNazwa

        private string? _fizAdSiedzPowiatNazwa;

        /// Fiz ad siedz powiat nazwa
        /// Fiz ad siedz powiat nazwa
        [Column(Order = 2)]
        [XmlElement("fiz_adSiedzPowiat_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzPowiatNazwa), Order = 2)]
        [Display(Name = "Fiz ad siedz powiat nazwa", Prompt = "Wpisz Fiz ad siedz powiat nazwa",
            Description = "Fiz ad siedz powiat nazwa")]
        [StringLength(100)]
        [MaxLength(100)]

        public string? FizAdSiedzPowiatNazwa
        {
            get => _fizAdSiedzPowiatNazwa;
            set
            {
                if (value != _fizAdSiedzPowiatNazwa)
                {
                    _fizAdSiedzPowiatNazwa = value;
                    OnPropertyChanged(nameof(FizAdSiedzPowiatNazwa));
                }
            }
        }

        #endregion

        #region private string? _fizAdSiedzGminaNazwa; public string? FizAdSiedzGminaNazwa

        private string? _fizAdSiedzGminaNazwa;

        /// Fiz ad siedz gmina nazwa
        /// Fiz ad siedz gmina nazwa
        [Column(Order = 2)]
        [XmlElement("fiz_adSiedzGmina_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzGminaNazwa), Order = 2)]
        [Display(Name = "Fiz ad siedz gmina nazwa", Prompt = "Wpisz Fiz ad siedz gmina nazwa",
            Description = "Fiz ad siedz gmina nazwa")]
        [StringLength(100)]
        [MaxLength(100)]

        public string? FizAdSiedzGminaNazwa
        {
            get => _fizAdSiedzGminaNazwa;
            set
            {
                if (value != _fizAdSiedzGminaNazwa)
                {
                    _fizAdSiedzGminaNazwa = value;
                    OnPropertyChanged(nameof(FizAdSiedzGminaNazwa));
                }
            }
        }

        #endregion

        #region private string? _fizAdSiedzMiejscowoscNazwa; public string? FizAdSiedzMiejscowoscNazwa

        private string? _fizAdSiedzMiejscowoscNazwa;

        /// Fiz ad siedz miejscowosc nazwa
        /// Fiz ad siedz miejscowosc nazwa
        [Column(Order = 2)]
        [XmlElement("fiz_adSiedzMiejscowosc_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzMiejscowoscNazwa), Order = 2)]
        [Display(Name = "Fiz ad siedz miejscowosc nazwa", Prompt = "Wpisz Fiz ad siedz miejscowosc nazwa",
            Description = "Fiz ad siedz miejscowosc nazwa")]
        [StringLength(100)]
        [MaxLength(100)]

        public string? FizAdSiedzMiejscowoscNazwa
        {
            get => _fizAdSiedzMiejscowoscNazwa;
            set
            {
                if (value != _fizAdSiedzMiejscowoscNazwa)
                {
                    _fizAdSiedzMiejscowoscNazwa = value;
                    OnPropertyChanged(nameof(FizAdSiedzMiejscowoscNazwa));
                }
            }
        }

        #endregion

        #region private string? _fizAdSiedzMiejscowoscPocztyNazwa; public string? FizAdSiedzMiejscowoscPocztyNazwa

        private string? _fizAdSiedzMiejscowoscPocztyNazwa;

        /// Fiz ad siedz miejscowosc poczty nazwa
        /// Fiz ad siedz miejscowosc poczty nazwa
        [Column(Order = 2)]
        [XmlElement("fiz_adSiedzMiejscowoscPoczty_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzMiejscowoscPocztyNazwa), Order = 2)]
        [Display(Name = "Fiz ad siedz miejscowosc poczty nazwa", Prompt = "Wpisz Fiz ad siedz miejscowosc poczty nazwa",
            Description = "Fiz ad siedz miejscowosc poczty nazwa")]
        [StringLength(100)]
        [MaxLength(100)]

        public string? FizAdSiedzMiejscowoscPocztyNazwa
        {
            get => _fizAdSiedzMiejscowoscPocztyNazwa;
            set
            {
                if (value != _fizAdSiedzMiejscowoscPocztyNazwa)
                {
                    _fizAdSiedzMiejscowoscPocztyNazwa = value;
                    OnPropertyChanged(nameof(FizAdSiedzMiejscowoscPocztyNazwa));
                }
            }
        }

        #endregion

        #region private string? _fizAdSiedzUlicaNazwa; public string? FizAdSiedzUlicaNazwa

        private string? _fizAdSiedzUlicaNazwa;

        /// Fiz ad siedz ulica nazwa
        /// Fiz ad siedz ulica nazwa
        [Column(Order = 2)]
        [XmlElement("fiz_adSiedzUlica_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzUlicaNazwa), Order = 2)]
        [Display(Name = "Fiz ad siedz ulica nazwa", Prompt = "Wpisz Fiz ad siedz ulica nazwa",
            Description = "Fiz ad siedz ulica nazwa")]
        [StringLength(351)]
        [MaxLength(351)]

        public string? FizAdSiedzUlicaNazwa
        {
            get => _fizAdSiedzUlicaNazwa;
            set
            {
                if (value != _fizAdSiedzUlicaNazwa)
                {
                    _fizAdSiedzUlicaNazwa = value;
                    OnPropertyChanged(nameof(FizAdSiedzUlicaNazwa));
                }
            }
        }

        #endregion
    }

    #endregion
}

#endregion
