using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace PortalApiGusApiRegonData.Models.DanePobierzPelnyRaport
{
    #region class OsFizycznaDzialalnoscPozostala
    /// <summary>
    /// Pozostała działalność osoby fizycznej
    /// Other activities of a natural person
    /// </summary>
    [Table("OsFizycznaDzialalnoscPozostala")]
    [Serializable, XmlRoot("dane")]
    public partial class OsFizycznaDzialalnoscPozostala
    {
        #region public string FizRegon9 { get; set; }
        /// <summary>
        /// REGON pozostałej działalności osoby fizycznej (string)
        /// REGON for other activities of a natural person (string)
        /// </summary>
        [XmlElement("fiz_regon9")]
        [JsonProperty(nameof(FizRegon9))]
        [Display(Name = "REGON pozostałej działalności osoby fizycznej", Prompt = "Wpisz REGON pozostałej działalności osoby fizycznej", Description = "REGON pozostałej działalności osoby fizycznej")]
        [Column("FizRegon9", TypeName = "varchar(9)")]
        [StringLength(9)]
        [MaxLength(9)]
        public string FizRegon9 { get; set; }
        #endregion

        #region public string FizNazwa { get; set; }
        /// <summary>
        /// Nazwa pozostałej działalności osoby fizycznej (string)
        /// Name for other activities of a natural person (string)
        /// </summary>
        [XmlElement("fiz_nazwa")]
        [JsonProperty(nameof(FizNazwa))]
        [Display(Name = "Nazwa pozostałej działalności osoby fizycznej", Prompt = "Wpisz nazwę pozostałej działalności osoby fizycznej", Description = "Nazwa pozostałej działalności osoby fizycznej")]
        [Column("FizNazwa", TypeName = "varchar(2000)")]
        [StringLength(2000)]
        [MaxLength(2000)]
        public string FizNazwa { get; set; }
        #endregion

        #region public string FizNazwaSkrocona { get; set; }
        /// <summary>
        /// Nazwa skrócona pozostałej działalności osoby fizycznej (string)
        /// Short name for other activities of a natural person (string)
        /// </summary>
        [XmlElement("fiz_nazwaSkrocona")]
        [JsonProperty(nameof(FizNazwaSkrocona))]
        [Display(Name = "Skrócona nazwa pozostałej działalności osoby fizycznej", Prompt = "Wpisz skróconą nazwę pozostałej działalności osoby fizycznej", Description = "Skrócona nazwa pozostałej działalności osoby fizycznej")]
        [Column("FizNazwaSkrocona", TypeName = "varchar(256)")]
        [StringLength(256)]
        [MaxLength(256)]
        public string FizNazwaSkrocona { get; set; }
        #endregion

        #region public string FizDataPowstania { get; set; }
        /// <summary>
        /// Data powstania pozostałej działalności osoby fizycznej (string)
        /// Date of the creation of the remaining activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_dataPowstania")]
        [JsonProperty(nameof(FizDataPowstania))]
        [Display(Name = "Data powstania pozostałej działalności osoby fizycznej", Prompt = "Wpisz datę powstania pozostałej działalności osoby fizycznej", Description = "Data powstania pozostałej działalności osoby fizycznej")]
        [Column("FizDataPowstania", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataPowstania { get; set; }
        #endregion

        #region public string FizDataRozpoczeciaDzialalnosci { get; set; }
        /// <summary>
        /// Data rozpoczęcia pozostałej działalności osoby fizycznej (string)
        /// Date of commencement of other activities of the natural person (string)
        /// </summary>
        [XmlElement("fiz_dataRozpoczeciaDzialalnosci")]
        [JsonProperty(nameof(FizDataRozpoczeciaDzialalnosci))]
        [Display(Name = "Data rozpoczęcia pozostałej działalności osoby fizycznej", Prompt = "Wpisz datę rozpoczęcia pozostałej działalności osoby fizycznej", Description = "Data rozpoczęcia pozostałej działalności osoby fizycznej")]
        [Column("FizDataRozpoczeciaDzialalnosci", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataRozpoczeciaDzialalnosci { get; set; }
        #endregion

        #region public string FizDataWpisuDzialalnosciDoRegon { get; set; }
        /// <summary>
        /// Data wpisu do REGON pozostałej działalności osoby fizycznej (string)
        /// Date of entry into REGON of other activities of a natural person (string)
        /// </summary>
        [XmlElement("fiz_dataWpisuDzialalnosciDoRegon")]
        [JsonProperty(nameof(FizDataWpisuDzialalnosciDoRegon))]
        [Display(Name = "Data wpisu do REGON pozostałej działalności osoby fizycznej", Prompt = "Wprowadź datę wpisu do REGON pozostałej działalności osoby fizycznej", Description = "Data wpisu do REGON pozostałej działalności osoby fizycznej")]
        [Column("FizDataWpisuDzialalnosciDoRegon", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataWpisuDzialalnosciDoRegon { get; set; }
        #endregion

        #region public string FizDataZawieszeniaDzialalnosci { get; set; }
        /// <summary>
        /// Data zawieszenia pozostałej działalności osoby fizycznej (string)
        /// Date of suspension of the remaining activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_dataZawieszeniaDzialalnosci")]
        [JsonProperty(nameof(FizDataZawieszeniaDzialalnosci))]
        [Display(Name = "Data zawieszenia pozostałej działalności osoby fizycznej", Prompt = "Wpisz datę zawieszenia pozostałej działalności osoby fizycznej", Description = "Data zawieszenia pozostałej działalności osoby fizycznej")]
        [Column("FizDataZawieszeniaDzialalnosci", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataZawieszeniaDzialalnosci { get; set; }
        #endregion

        #region public string FizDataWznowieniaDzialalnosci { get; set; }
        /// <summary>
        /// Data wznowienia pozostałej działalności osoby fizycznej (string)
        /// Date of resumption of the remaining activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_dataWznowieniaDzialalnosci")]
        [JsonProperty(nameof(FizDataWznowieniaDzialalnosci))]
        [Display(Name = "Data wznowienia pozostałej działalności osoby fizycznej", Prompt = "Wpisz datę wznowienia pozostałej działalności osoby fizycznej", Description = "Data wznowienia pozostałej działalności osoby fizycznej")]
        [Column("FizDataWznowieniaDzialalnosci", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataWznowieniaDzialalnosci { get; set; }
        #endregion

        #region public string FizDataZaistnieniaZmianyDzialalnosci { get; set; }
        /// <summary>
        /// Data zaistnienia zmiany pozostałej działalności osoby fizycznej (string)
        /// Date of the change of other activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_dataZaistnieniaZmianyDzialalnosci")]
        [JsonProperty(nameof(FizDataZaistnieniaZmianyDzialalnosci))]
        [Display(Name = "Data zaistnienia zmiany pozostałej działalności osoby fizycznej", Prompt = "Wpisz datę zaistnienia zmiany pozostałej działalności osoby fizycznej", Description = "Data zaistnienia zmiany pozostałej działalności osoby fizycznej")]
        [Column("FizDataZaistnieniaZmianyDzialalnosci", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataZaistnieniaZmianyDzialalnosci { get; set; }
        #endregion

        #region public string FizDataZakonczeniaDzialalnosci { get; set; }
        /// <summary>
        /// Data zakończenia pozostałej działalności osoby fizycznej (string)
        /// Date of termination of the remaining activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_dataZakonczeniaDzialalnosci")]
        [JsonProperty(nameof(FizDataZakonczeniaDzialalnosci))]
        [Display(Name = "Data zakończenia pozostałej działalności osoby fizycznej", Prompt = "Wpisz datę zakończenia pozostałej działalności osoby fizycznej", Description = "Data zakończenia pozostałej działalności osoby fizycznej")]
        [Column("FizDataZakonczeniaDzialalnosci", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataZakonczeniaDzialalnosci { get; set; }
        #endregion

        #region public string FizDataSkresleniaDzialalnosciZRegon { get; set; }
        /// <summary>
        /// Data skreślenia z REGON pozostałej działalności osoby fizycznej (string)
        /// Date of removing the remaining activity of a natural person from REGON (string)
        /// </summary>
        [XmlElement("fiz_dataSkresleniaDzialalnosciZRegon")]
        [JsonProperty(nameof(FizDataSkresleniaDzialalnosciZRegon))]
        [Display(Name = "Data skreślenia z REGON pozostałej działalności osoby fizycznej", Prompt = "Wpisz datę skreślenia z REGON pozostałej działalności osoby fizycznej", Description = "Data skreślenia z REGON pozostałej działalności osoby fizycznej")]
        [Column("FizDataSkresleniaDzialalnosciZRegon", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataSkresleniaDzialalnosciZRegon { get; set; }
        #endregion

        #region public string FizDataOrzeczeniaOUpadlosci { get; set; }
        /// <summary>
        /// Data orzeczenia o upadłości pozostałej działalności osoby fizycznej (string)
        /// Date of the declaration on bankruptcy of the remaining activities of the natural person (string)
        /// </summary>
        [XmlElement("fiz_dataOrzeczeniaOUpadlosci")]
        [JsonProperty(nameof(FizDataOrzeczeniaOUpadlosci))]
        [Display(Name = "Data orzeczenia o upadłości pozostałej działalności osoby fizycznej", Prompt = "Wpisz datę orzeczenia o upadłości pozostałej działalności osoby fizycznej", Description = "Data orzeczenia o upadłości pozostałej działalności osoby fizycznej")]
        [Column("FizDataOrzeczeniaOUpadlosci", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataOrzeczeniaOUpadlosci { get; set; }
        #endregion

        #region public string FizDataZakonczeniaPostepowaniaUpadlosciowego { get; set; }
        /// <summary>
        /// Data zakończenia postępowania upadłościowego pozostałej działalności osoby fizycznej (string)
        /// Date of completion of bankruptcy proceedings for the remaining activities of the natural person (string)
        /// </summary>
        [XmlElement("fiz_dataZakonczeniaPostepowaniaUpadlosciowego")]
        [JsonProperty(nameof(FizDataZakonczeniaPostepowaniaUpadlosciowego))]
        [Display(Name = "Data zakończenia postępowania upadłościowego pozostałej działalności osoby fizycznej", Prompt = "Wpisz datę zakończenia postępowania upadłościowego pozostałej działalności osoby fizycznej", Description = "Data zakończenia postępowania upadłościowego pozostałej działalności osoby fizycznej")]
        [Column("FizDataZakonczeniaPostepowaniaUpadlosciowego", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataZakonczeniaPostepowaniaUpadlosciowego { get; set; }
        #endregion

        #region public string FizAdSiedzKrajSymbol { get; set; }
        /// <summary>
        /// Symbol kraju pozostałej działalności osoby fizycznej (string)
        /// Symbol of the country of other activities of a natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzKraj_Symbol")]
        [JsonProperty(nameof(FizAdSiedzKrajSymbol))]
        [Display(Name = "Symbol kraju pozostałej siedziby działalności osoby fizycznej", Prompt = "Wpisz symbol kraju pozostałej działalności osoby fizycznej", Description = "Symbol kraju pozostałej działalności osoby fizycznej")]
        [Column("FizAdSiedzKrajSymbol", TypeName = "varchar(2)")]
        [StringLength(2)]
        [MaxLength(2)]
        public string FizAdSiedzKrajSymbol { get; set; }
        #endregion

        #region public string FizAdSiedzWojewodztwoSymbol { get; set; }
        /// <summary>
        /// Symbol województwa pozostałej działalności osoby fizycznej (string)
        /// Symbol of the province of other activities of a natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzWojewodztwo_Symbol")]
        [JsonProperty(nameof(FizAdSiedzWojewodztwoSymbol))]
        [Display(Name = "Symbol województwa siedziby pozostałej działalności osoby fizycznej", Prompt = "Wpisz symbol województwa pozostałej działalności osoby fizycznej", Description = "Symbol województwa pozostałej działalności osoby fizycznej")]
        [Column("FizAdSiedzWojewodztwoSymbol", TypeName = "varchar(2)")]
        [StringLength(2)]
        [MaxLength(2)]
        public string FizAdSiedzWojewodztwoSymbol { get; set; }
        #endregion

        #region public string FizAdSiedzPowiatSymbol { get; set; }
        /// <summary>
        /// Symbol powiatu pozostałej działalności osoby fizycznej (string)
        /// Symbol of the poviat of other activities of a natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzPowiat_Symbol")]
        [JsonProperty(nameof(FizAdSiedzPowiatSymbol))]
        [Display(Name = "Symbol powiatu siedziby pozostałej działalności osoby fizycznej", Prompt = "Wpisz symbol powiatu pozostałej działalności osoby fizycznej", Description = "Symbol powiatu pozostałej działalności osoby fizycznej")]
        [Column("FizAdSiedzPowiatSymbol", TypeName = "varchar(2)")]
        [StringLength(2)]
        [MaxLength(2)]
        public string FizAdSiedzPowiatSymbol { get; set; }
        #endregion

        #region public string FizAdSiedzGminaSymbol { get; set; }
        /// <summary>
        /// Symbol gminy pozostałej działalności osoby fizycznej (string)
        /// Symbol of the commune of other activities of a natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzGmina_Symbol")]
        [JsonProperty(nameof(FizAdSiedzGminaSymbol))]
        [Display(Name = "Symbol gminy siedziby pozostałej działalności osoby fizycznej", Prompt = "Wpisz symbol gminy pozostałej działalności osoby fizycznej", Description = "Symbol gminy pozostałej działalności osoby fizycznej")]
        [Column("FizAdSiedzGminaSymbol", TypeName = "varchar(3)")]
        [StringLength(3)]
        [MaxLength(3)]
        public string FizAdSiedzGminaSymbol { get; set; }
        #endregion

        #region public string FizAdSiedzKodPocztowy { get; set; }
        /// <summary>
        /// Kod pocztowy siedziby pozostałej działalności osoby fizycznej (string)
        /// Postal code of the registered office of the natural person's other activities (string)
        /// </summary>
        [XmlElement("fiz_adSiedzGmina_Symbol")]
        [JsonProperty(nameof(FizAdSiedzKodPocztowy))]
        [Display(Name = "Kod pocztowy siedziby pozostałej działalności osoby fizycznej", Prompt = "Wpisz kod pocztowy siedziby pozostałej działalności osoby fizycznej", Description = "Kod pocztowy siedziby pozostałej działalności osoby fizycznej")]
        [Column("FizAdSiedzKodPocztowy", TypeName = "varchar(12)")]
        [StringLength(12)]
        [MaxLength(12)]
        public string FizAdSiedzKodPocztowy { get; set; }
        #endregion

        #region public string FizAdSiedzMiejscowoscPocztySymbol { get; set; }
        /// <summary>
        /// Symbol miejscowości poczty dla siedziby pozostałej działalności osoby fizycznej (string)
        /// Symbol of the postal town for the seat of other activities of a natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzMiejscowoscPoczty_Symbol")]
        [JsonProperty(nameof(FizAdSiedzMiejscowoscPocztySymbol))]
        [Display(Name = "Symbol miejscowości poczty dla siedziby pozostałej działalności osoby fizycznej", Prompt = "Wpisz symbol miejscowości poczty dla siedziby pozostałej działalności osoby fizycznej", Description = "Symbol miejscowości poczty dla siedziby pozostałej działalności osoby fizycznej")]
        [Column("FizAdSiedzMiejscowoscPocztySymbol", TypeName = "varchar(7)")]
        [StringLength(7)]
        [MaxLength(7)]
        public string FizAdSiedzMiejscowoscPocztySymbol { get; set; }
        #endregion

        #region public string FizAdSiedzMiejscowoscSymbol { get; set; }
        /// <summary>
        /// Symbol miejscowości siedziby pozostałej działalności osoby fizycznej (string)
        /// Symbol of the place of residence of other activities of a natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzMiejscowosc_Symbol")]
        [JsonProperty(nameof(FizAdSiedzMiejscowoscSymbol))]
        [Display(Name = "Symbol miejscowości siedziby pozostałej działalności osoby fizycznej", Prompt = "Wpisz symbol miejscowości siedziby pozostałej działalności osoby fizycznej", Description = "Symbol miejscowości siedziby pozostałej działalności osoby fizycznej")]
        [Column("FizAdSiedzMiejscowoscSymbol", TypeName = "varchar(7)")]
        [StringLength(7)]
        [MaxLength(7)]
        public string FizAdSiedzMiejscowoscSymbol { get; set; }
        #endregion

        #region public string FizAdSiedzUlicaSymbol { get; set; }
        /// <summary>
        /// Symbol ulicy siedziby pozostałej działalności osoby fizycznej (string)
        /// Symbol of the street of the seat of other activities of a natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzUlica_Symbol")]
        [JsonProperty(nameof(FizAdSiedzUlicaSymbol))]
        [Display(Name = "Symbol ulicy siedziby pozostałej działalności osoby fizycznej", Prompt = "Wpisz symbol ulicy siedziby pozostałej działalności osoby fizycznej", Description = "Symbol ulicy siedziby pozostałej działalności osoby fizycznej")]
        [Column("FizAdSiedzUlicaSymbol", TypeName = "varchar(5)")]
        [StringLength(5)]
        [MaxLength(5)]
        public string FizAdSiedzUlicaSymbol { get; set; }
        #endregion

        #region public string FizAdSiedzNumerNieruchomosci { get; set; }
        /// <summary>
        /// Numer nieruchomości siedziby pozostałej działalności osoby fizycznej (string)
        /// Real estate number of the seat of the natural person's other business (string)
        /// </summary>
        [XmlElement("fiz_adSiedzNumerNieruchomosci")]
        [JsonProperty(nameof(FizAdSiedzNumerNieruchomosci))]
        [Display(Name = "Numer nieruchomości siedziby pozostałej działalności osoby fizycznej", Prompt = "Wpisz numer nieruchomości siedziby pozostałej działalności osoby fizycznej", Description = "Numer nieruchomości siedziby pozostałej działalności osoby fizycznej")]
        [Column("FizAdSiedzNumerNieruchomosci", TypeName = "varchar(20)")]
        [StringLength(20)]
        [MaxLength(20)]
        public string FizAdSiedzNumerNieruchomosci { get; set; }
        #endregion

        #region public string FizAdSiedzNumerLokalu { get; set; }
        /// <summary>
        /// Numer lokalu siedziby pozostałej działalności osoby fizycznej (string)
        /// Number of the seat of the other activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzNumerLokalu")]
        [JsonProperty(nameof(FizAdSiedzNumerLokalu))]
        [Display(Name = "Numer lokalu siedziby pozostałej działalności osoby fizycznej", Prompt = "Wpisz numer lokalu siedziby pozostałej działalności osoby fizycznej", Description = "Numer lokalu siedziby pozostałej działalności osoby fizycznej")]
        [Column("FizAdSiedzNumerLokalu", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizAdSiedzNumerLokalu { get; set; }
        #endregion

        #region public string FizAdSiedzNietypoweMiejsceLokalizacji { get; set; }
        /// <summary>
        /// Nietypowe miejsce siedziby pozostałej działalności osoby fizycznej (string)
        /// Atypical location of the seat of the remaining activity of a natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzNietypoweMiejsceLokalizacji")]
        [JsonProperty(nameof(FizAdSiedzNietypoweMiejsceLokalizacji))]
        [Display(Name = "Nietypowe miejsce siedziby pozostałej działalności osoby fizycznej", Prompt = "Wpisz nietypowe miejsce siedziby pozostałej działalności osoby fizycznej", Description = "Nietypowe miejsce siedziby pozostałej działalności osoby fizycznej")]
        [Column("FizAdSiedzNietypoweMiejsceLokalizacji", TypeName = "varchar(160)")]
        [StringLength(160)]
        [MaxLength(160)]
        public string FizAdSiedzNietypoweMiejsceLokalizacji { get; set; }
        #endregion

        #region public string FizNumerTelefonu { get; set; }
        /// <summary>
        /// Numer telefonu siedziby pozostałej działalności osoby fizycznej (string)
        /// Telephone number of the registered office of the natural person's other activities (string)
        /// </summary>
        [XmlElement("fiz_numerTelefonu")]
        [JsonProperty(nameof(FizNumerTelefonu))]
        [Display(Name = "Numer telefonu siedziby pozostałej działalności osoby fizycznej", Prompt = "Wpisz numer telefonu siedziby pozostałej działalności osoby fizycznej", Description = "Numer telefonu siedziby pozostałej działalności osoby fizycznej")]
        [Column("FizNumerTelefonu", TypeName = "varchar(18)")]
        [StringLength(18)]
        [MaxLength(18)]
        public string FizNumerTelefonu { get; set; }
        #endregion

        #region public string FizNumerWewnetrznyTelefonu { get; set; }
        /// <summary>
        /// Numer wenętrzny telefonu siedziby pozostałej działalności osoby fizycznej (string)
        /// Internal telephone number of the registered office of the natural person's other activities (string)
        /// </summary>
        [XmlElement("fiz_numerWewnetrznyTelefonu")]
        [JsonProperty(nameof(FizNumerWewnetrznyTelefonu))]
        [Display(Name = "Numer wenętrzny telefonu siedziby pozostałej działalności osoby fizycznej", Prompt = "Wpisz numer wenętrzny telefonu siedziby pozostałej działalności osoby fizycznej", Description = "Numer wenętrzny telefonu siedziby pozostałej działalności osoby fizycznej")]
        [Column("FizNumerWewnetrznyTelefonu", TypeName = "varchar(6)")]
        [StringLength(6)]
        [MaxLength(6)]
        public string FizNumerWewnetrznyTelefonu { get; set; }
        #endregion

        #region public string FizNumerFaksu { get; set; }
        /// <summary>
        /// Numer faksu siedziby pozostałej działalności osoby fizycznej (string)
        /// Fax number of the seat of other activities of natural persons (string)
        /// </summary>
        [XmlElement("fiz_numerFaksu")]
        [JsonProperty(nameof(FizNumerFaksu))]
        [Display(Name = "Numer faksu siedziby pozostałej działalności osoby fizycznej", Prompt = "Wpisz numer faksu siedziby pozostałej działalności osoby fizycznej", Description = "Numer faksu siedziby pozostałej działalności osoby fizycznej")]
        [Column("FizNumerFaksu", TypeName = "varchar(18)")]
        [StringLength(18)]
        [MaxLength(18)]
        public string FizNumerFaksu { get; set; }
        #endregion

        #region public string FizAdresEmail { get; set; }
        /// <summary>
        /// Adres email siedziby pozostałej działalności osoby fizycznej (string)
        /// Email adress of the seat of other activities of natural persons (string)
        /// </summary>
        [XmlElement("fiz_adresEmail")]
        [JsonProperty(nameof(FizAdresEmail))]
        [Display(Name = "Adres email siedziby pozostałej działalności osoby fizycznej", Prompt = "Wpisz adres email siedziby pozostałej działalności osoby fizycznej", Description = "Adres email siedziby pozostałej działalności osoby fizycznej")]
        [Column("FizAdresEmail", TypeName = "varchar(100)")]
        [StringLength(100)]
        [MaxLength(100)]
        public string FizAdresEmail { get; set; }
        #endregion

        #region public string FizAdresStronyinternetowej { get; set; }
        /// <summary>
        /// Adres strony internetowej siedziby pozostałej działalności osoby fizycznej (string)
        /// Website adress of the seat of other activities of natural persons (string)
        /// </summary>
        [XmlElement("fiz_adresStronyinternetowej")]
        [JsonProperty(nameof(FizAdresStronyinternetowej))]
        [Display(Name = "Adres strony internetowej siedziby pozostałej działalności osoby fizycznej", Prompt = "Wpisz adres strony internetowej siedziby pozostałej działalności osoby fizycznej", Description = "Adres strony internetowej siedziby pozostałej działalności osoby fizycznej")]
        [Column("FizAdresStronyinternetowej", TypeName = "varchar(100)")]
        [StringLength(100)]
        [MaxLength(100)]
        public string FizAdresStronyinternetowej { get; set; }
        #endregion

        #region public string FizAdSiedzKrajNazwa { get; set; }
        /// <summary>
        /// Nazwa kraju siedziby pozostałej działalności osoby fizycznej (string)
        /// Name of the country of residence of the natural person's other activities (string)
        /// </summary>
        [XmlElement("fiz_adSiedzKraj_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzKrajNazwa))]
        [Display(Name = "Nazwa kraju siedziby pozostałej działalności osoby fizycznej", Prompt = "Wpisz kraj siedziby pozostałej działalności osoby fizycznej", Description = "Nazwa kraju siedziby pozostałej działalności osoby fizycznej")]
        [Column("FizAdSiedzKrajNazwa", TypeName = "varchar(200)")]
        [StringLength(200)]
        [MaxLength(200)]
        public string FizAdSiedzKrajNazwa { get; set; }
        #endregion

        #region public string FizAdSiedzWojewodztwoNazwa { get; set; }
        /// <summary>
        /// Nazwa województwa siedziby pozostałej działalności osoby fizycznej (string)
        /// Name of the voivodeship of the seat of the remaining activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzWojewodztwo_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzWojewodztwoNazwa))]
        [Display(Name = "Nazwa województwa siedziby pozostałej działalności osoby fizycznej", Prompt = "Wpisz województwo siedziby pozostałej działalności osoby fizycznej", Description = "Nazwa województwa siedziby pozostałej działalności osoby fizycznej")]
        [Column("FizAdSiedzWojewodztwoNazwa", TypeName = "varchar(100)")]
        [StringLength(100)]
        [MaxLength(100)]
        public string FizAdSiedzWojewodztwoNazwa { get; set; }
        #endregion

        #region public string FizAdSiedzPowiatNazwa { get; set; }
        /// <summary>
        /// Nazwa powiatu siedziby pozostałej działalności osoby fizycznej (string)
        /// Name of the poviat of the seat of the remaining activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzPowiat_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzPowiatNazwa))]
        [Display(Name = "Nazwa powiatu siedziby pozostałej działalności osoby fizycznej", Prompt = "Wpisz powiat siedziby pozostałej działalności osoby fizycznej", Description = "Nazwa powiatu siedziby pozostałej działalności osoby fizycznej")]
        [Column("FizAdSiedzPowiatNazwa", TypeName = "varchar(100)")]
        [StringLength(100)]
        [MaxLength(100)]
        public string FizAdSiedzPowiatNazwa { get; set; }
        #endregion

        #region public string FizAdSiedzGminaNazwa { get; set; }
        /// <summary>
        /// Nazwa gaminy siedziby pozostałej działalności osoby fizycznej (string)
        /// Name of the commune of the seat of the remaining activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzGmina_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzGminaNazwa))]
        [Display(Name = "Nazwa gminy siedziby pozostałej działalności osoby fizycznej", Prompt = "Wpisz gminę siedziby pozostałej działalności osoby fizycznej", Description = "Nazwa gminy siedziby pozostałej działalności osoby fizycznej")]
        [Column("FizAdSiedzGminaNazwa", TypeName = "varchar(100)")]
        [StringLength(100)]
        [MaxLength(100)]
        public string FizAdSiedzGminaNazwa { get; set; }
        #endregion

        #region public string FizAdSiedzMiejscowoscNazwa { get; set; }
        /// <summary>
        /// Nazwa miejscowości siedziby pozostałej działalności osoby fizycznej (string)
        /// Name of the location of the seat of the remaining activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzMiejscowosc_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzMiejscowoscNazwa))]
        [Display(Name = "Nazwa miejscowości siedziby pozostałej działalności osoby fizycznej", Prompt = "Wpisz miejscowość siedziby pozostałej działalności osoby fizycznej", Description = "Nazwa miejscowości siedziby pozostałej działalności osoby fizycznej")]
        [Column("FizAdSiedzMiejscowoscNazwa", TypeName = "varchar(100)")]
        [StringLength(100)]
        [MaxLength(100)]
        public string FizAdSiedzMiejscowoscNazwa { get; set; }
        #endregion

        #region public string FizAdSiedzMiejscowoscPocztyNazwa { get; set; }
        /// <summary>
        /// Nazwa miejscowości poczty dla siedziby pozostałej działalności osoby fizycznej (string)
        /// Name of the postal town for the seat of other activities of a natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzMiejscowoscPoczty_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzMiejscowoscPocztyNazwa))]
        [Display(Name = "Nazwa miejscowości poczty dla siedziby pozostałej działalności osoby fizycznej", Prompt = "Wpisz miejscowość poczty dla siedziby pozostałej działalności osoby fizycznej", Description = "Nazwa miejscowości poczty dla siedziby pozostałej działalności osoby fizycznej")]
        [Column("FizAdSiedzMiejscowoscPocztyNazwa", TypeName = "varchar(100)")]
        [StringLength(100)]
        [MaxLength(100)]
        public string FizAdSiedzMiejscowoscPocztyNazwa { get; set; }
        #endregion

        #region public string FizAdSiedzUlicaNazwa { get; set; }
        /// <summary>
        /// Nazwa ulicy siedziby pozostałej działalności osoby fizycznej (string)
        /// Name of the street of the registered office of the natural person's other activities (string)
        /// </summary>
        [XmlElement("fiz_adSiedzUlica_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzUlicaNazwa))]
        [Display(Name = "Nazwa ulicy siedziby pozostałej działalności osoby fizycznej", Prompt = "Wpisz ulicę siedziby pozostałej działalności osoby fizycznej", Description = "Nazwa ulicy siedziby pozostałej działalności osoby fizycznej")]
        [Column("FizAdSiedzUlicaNazwa", TypeName = "varchar(351)")]
        [StringLength(351)]
        [MaxLength(351)]
        public string FizAdSiedzUlicaNazwa { get; set; }
        #endregion

        #region public string FizPdataWpisuDoRejestruEwidencji { get; set; }
        /// <summary>
        /// Data wpisu do rejestru ewidencji pozostałej działalności osoby fizycznej (string)
        /// Date of entry into the register of other activities of the natural person (string)
        /// </summary>
        [XmlElement("fizP_dataWpisuDoRejestruEwidencji")]
        [JsonProperty(nameof(FizPdataWpisuDoRejestruEwidencji))]
        [Display(Name = "Data wpisu do rejestru ewidencji pozostałej działalności osoby fizycznej", Prompt = "Wprowadź datę wpisu do rejestru ewidencji pozostałej działalności osoby fizycznej", Description = "Data wpisu do rejestru ewidencji pozostałej działalności osoby fizycznej")]
        [Column("FizPdataWpisuDoRejestruEwidencji", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizPdataWpisuDoRejestruEwidencji { get; set; }
        #endregion

        #region public string FizPnumerWRejestrzeEwidencji { get; set; }
        /// <summary>
        /// Numer w rejestrze ewidencji pozostałej działalności osoby fizycznej (string)
        /// Number in the register of records of other activities of the natural person (string)
        /// </summary>
        [XmlElement("fizP_numerWRejestrzeEwidencji")]
        [JsonProperty(nameof(FizPnumerWRejestrzeEwidencji))]
        [Display(Name = "Numer w rejestrze ewidencji pozostałej działalności osoby fizycznej", Prompt = "Wprowadź numer w rejestrze ewidencji pozostałej działalności osoby fizycznej", Description = "Numer w rejestrze ewidencji pozostałej działalności osoby fizycznej")]
        [Column("FizPnumerWRejestrzeEwidencji", TypeName = "varchar(50)")]
        [StringLength(50)]
        [MaxLength(50)]
        public string FizPnumerWRejestrzeEwidencji { get; set; }
        #endregion

        #region public string FizPOrganRejestrowySymbol { get; set; }
        /// <summary>
        /// Symbol organu rejestrowego pozostałej działalności osoby fizycznej (string)
        /// Symbol of the registration authority for other activities of a natural person (string)
        /// </summary>
        [XmlElement("fizP_OrganRejestrowy_Symbol")]
        [JsonProperty(nameof(FizPOrganRejestrowySymbol))]
        [Display(Name = "Symbol organu rejestrowego pozostałej działalności osoby fizycznej", Prompt = "Wprowadź symbol organu rejestrowego pozostałej działalności osoby fizycznej", Description = "Symbol organu rejestrowego pozostałej działalności osoby fizycznej")]
        [Column("FizPOrganRejestrowySymbol", TypeName = "varchar(9)")]
        [StringLength(9)]
        [MaxLength(9)]
        public string FizPOrganRejestrowySymbol { get; set; }
        #endregion

        #region public string FizPOrganRejestrowyNazwa { get; set; }
        /// <summary>
        /// Nazwa organu rejestrowego pozostałej działalności osoby fizycznej (string)
        /// Name of the registration authority for other activities of a natural person (string)
        /// </summary>
        [XmlElement("fizP_OrganRejestrowy_Nazwa")]
        [JsonProperty(nameof(FizPOrganRejestrowyNazwa))]
        [Display(Name = "Nazwa organu rejestrowego pozostałej działalności osoby fizycznej", Prompt = "Wprowadź nazwę organu rejestrowego pozostałej działalności osoby fizycznej", Description = "Nazwa organu rejestrowego pozostałej działalności osoby fizycznej")]
        [Column("FizPOrganRejestrowyNazwa", TypeName = "varchar(240)")]
        [StringLength(240)]
        [MaxLength(240)]
        public string FizPOrganRejestrowyNazwa { get; set; }
        #endregion

        #region public string FizPRodzajRejestruSymbol { get; set; }
        /// <summary>
        /// Symbol rodzaju rejestru pozostałej działalności osoby fizycznej (string)
        /// Symbol for the type of register of other activities of a natural person (string)
        /// </summary>
        [XmlElement("fizP_RodzajRejestru_Symbol")]
        [JsonProperty(nameof(FizPRodzajRejestruSymbol))]
        [Display(Name = "Symbol rodzaju rejestru pozostałej działalności osoby fizycznej", Prompt = "Wprowadź symbol rodzaju rejestru pozostałej działalności osoby fizycznej", Description = "Symbol rodzaju rejestru pozostałej działalności osoby fizycznej")]
        [Column("FizPRodzajRejestruSymbol", TypeName = "varchar(3)")]
        [StringLength(3)]
        [MaxLength(3)]
        public string FizPRodzajRejestruSymbol { get; set; }
        #endregion

        #region public string FizPRodzajRejestruNazwa { get; set; }
        /// <summary>
        /// Nazwa rodzaju rejestru pozostałej działalności osoby fizycznej (string)
        /// Name for the type of register of other activities of a natural person (string)
        /// </summary>
        [XmlElement("fizP_RodzajRejestru_Nazwa")]
        [JsonProperty(nameof(FizPRodzajRejestruNazwa))]
        [Display(Name = "Nazwa rodzaju rejestru pozostałej działalności osoby fizycznej", Prompt = "Wprowadź nazwę rodzaju rejestru pozostałej działalności osoby fizycznej", Description = "Nazwa rodzaju rejestru pozostałej działalności osoby fizycznej")]
        [Column("FizPRodzajRejestruNazwa", TypeName = "varchar(240)")]
        [StringLength(240)]
        [MaxLength(240)]
        public string FizPRodzajRejestruNazwa { get; set; }
        #endregion
    }
    #endregion
}
