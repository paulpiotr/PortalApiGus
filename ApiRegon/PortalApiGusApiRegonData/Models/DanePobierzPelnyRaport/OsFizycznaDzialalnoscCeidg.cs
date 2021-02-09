using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace PortalApiGusApiRegonData.Models.DanePobierzPelnyRaport
{
    #region class OsFizycznaDzialalnoscCeidg
    /// <summary>
    /// Działalność osoby fizycznej
    /// Activities of a natural person
    /// </summary>
    [Table("OsFizycznaDzialalnoscCeidg")]
    [Serializable, XmlRoot("dane")]
    public partial class OsFizycznaDzialalnoscCeidg
    {
        #region public string FizRegon9 { get; set; }
        /// <summary>
        /// Regon działalności osoby fizycznej (string)
        /// Regon of the activity of a natural person (string)
        /// </summary>
        [XmlElement("fiz_regon9")]
        [JsonProperty(nameof(FizRegon9))]
        [Display(Name = "Regon działalności osoby fizycznej", Prompt = "Wpisz regon działalności osoby fizycznej", Description = "Regon działalności osoby fizycznej")]
        [Column("FizRegon9", TypeName = "varchar(9)")]
        [StringLength(9)]
        [MaxLength(9)]
        public string FizRegon9 { get; set; }
        #endregion

        #region public string FizNazwa { get; set; }
        /// <summary>
        /// Nazwa działalności osoby fizycznej (string)
        /// Name of the activity of a natural person (string)
        /// </summary>
        [XmlElement("fiz_nazwa")]
        [JsonProperty(nameof(FizNazwa))]
        [Display(Name = "Nazwa działalności osoby fizycznej", Prompt = "Wpisz nazwę działalności osoby fizycznej", Description = "Nazwa działalności osoby fizycznej")]
        [Column("FizNazwa", TypeName = "varchar(2000)")]
        [StringLength(2000)]
        [MaxLength(2000)]
        public string FizNazwa { get; set; }
        #endregion

        #region public string FizNazwaSkrocona { get; set; }
        /// <summary>
        /// Nazwa skrócona działalności osoby fizycznej (string)
        /// Short name of the activity of a natural person (string)
        /// </summary>
        [XmlElement("fiz_nazwaSkrocona")]
        [JsonProperty(nameof(FizNazwaSkrocona))]
        [Display(Name = "Nazwa skrócona działalności osoby fizycznej", Prompt = "Wpisz skróconą nazwę działalności osoby fizycznej", Description = "Nazwa skrócona działalności osoby fizycznej")]
        [Column("FizNazwaSkrocona", TypeName = "varchar(256)")]
        [StringLength(256)]
        [MaxLength(256)]
        public string FizNazwaSkrocona { get; set; }
        #endregion

        #region public string FizDataPowstania { get; set; }
        /// <summary>
        /// Data powstania działalności osoby fizycznej (string)
        /// Date of establishment of the activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_dataPowstania")]
        [JsonProperty(nameof(FizDataPowstania))]
        [Display(Name = "Data powstania działalności osoby fizycznej", Prompt = "Wpisz datę powstania działalności osoby fizycznej", Description = "Data powstania działalności osoby fizycznej")]
        [Column("FizDataPowstania", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataPowstania { get; set; }
        #endregion

        #region public string FizDataRozpoczeciaDzialalnosci { get; set; }
        /// <summary>
        /// Data rozpoczęcia działalności osoby fizycznej (string)
        /// Date of commencement of activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_dataRozpoczeciaDzialalnosci")]
        [JsonProperty(nameof(FizDataRozpoczeciaDzialalnosci))]
        [Display(Name = "Data rozpoczęcia działalności osoby fizycznej", Prompt = "Wpisz datę rozpoczęcia działalności osoby fizycznej", Description = "Data rozpoczęcia działalności osoby fizycznej")]
        [Column("FizDataRozpoczeciaDzialalnosci", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataRozpoczeciaDzialalnosci { get; set; }
        #endregion

        #region public string FizDataWpisuDzialalnosciDoRegon { get; set; }
        /// <summary>
        /// Data wpisu do Regon działalności osoby fizycznej (string)
        /// Date of entry into the Regon of the activity of a natural person (string)
        /// </summary>
        [XmlElement("fiz_dataWpisuDzialalnosciDoRegon")]
        [JsonProperty(nameof(FizDataWpisuDzialalnosciDoRegon))]
        [Display(Name = "Data wpisu do Regon działalności osoby fizycznej", Prompt = "Wpisz datę wpisu do Regon działalności osoby fizycznej", Description = "Data wpisu do Regon działalności osoby fizycznej")]
        [Column("FizDataWpisuDzialalnosciDoRegon", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataWpisuDzialalnosciDoRegon { get; set; }
        #endregion

        #region public string FizDataZawieszeniaDzialalnosci { get; set; }
        /// <summary>
        /// Data zawieszenia działalności osoby fizycznej (string)
        /// Date of suspension of the activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_dataZawieszeniaDzialalnosci")]
        [JsonProperty(nameof(FizDataZawieszeniaDzialalnosci))]
        [Display(Name = "Data zawieszenia działalności osoby fizycznej", Prompt = "Wpisz datę zawieszenia działalności osoby fizycznej", Description = "Data zawieszenia działalności osoby fizycznej")]
        [Column("FizDataZawieszeniaDzialalnosci", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataZawieszeniaDzialalnosci { get; set; }
        #endregion

        #region public string FizDataWznowieniaDzialalnosci { get; set; }
        /// <summary>
        /// Data wznowienia działalności osoby fizycznej (string)
        /// Date of resuming of the activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_dataWznowieniaDzialalnosci")]
        [JsonProperty(nameof(FizDataWznowieniaDzialalnosci))]
        [Display(Name = "Data wznowienia działalności osoby fizycznej", Prompt = "Wpisz datę wznowienia działalności osoby fizycznej", Description = "Data wznowienia działalności osoby fizycznej")]
        [Column("FizDataWznowieniaDzialalnosci", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataWznowieniaDzialalnosci { get; set; }
        #endregion

        #region public string FizDataZaistnieniaZmianyDzialalnosci { get; set; }
        /// <summary>
        /// Data zaistnienia zmiany działalności osoby fizycznej (string)
        /// Date of the change in the activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_dataZaistnieniaZmianyDzialalnosci")]
        [JsonProperty(nameof(FizDataZaistnieniaZmianyDzialalnosci))]
        [Display(Name = "Data zaistnienia zmiany działalności osoby fizycznej", Prompt = "Wpisz datę zaistnienia zmiany działalności osoby fizycznej", Description = "Data zaistnienia zmiany działalności osoby fizycznej")]
        [Column("FizDataZaistnieniaZmianyDzialalnosci", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataZaistnieniaZmianyDzialalnosci { get; set; }
        #endregion

        #region public string FizDataZakonczeniaDzialalnosci { get; set; }
        /// <summary>
        /// Data zakończenia działalności osoby fizycznej (string)
        /// Date of ending the activity of a natural person (string)
        /// </summary>
        [XmlElement("fiz_dataZakonczeniaDzialalnosci")]
        [JsonProperty(nameof(FizDataZakonczeniaDzialalnosci))]
        [Display(Name = "Data zakończenia działalności osoby fizycznej", Prompt = "Wpisz datę zakończenia działalności osoby fizycznej", Description = "Data zakończenia działalności osoby fizycznej")]
        [Column("FizDataZakonczeniaDzialalnosci", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataZakonczeniaDzialalnosci { get; set; }
        #endregion

        #region public string FizDataSkresleniaDzialalnosciZRegon { get; set; }
        /// <summary>
        /// Data skreślenia z Regon działalności osoby fizycznej (string)
        /// Date of removing the activity of a natural person from Regon (string)
        /// </summary>
        [XmlElement("fiz_dataSkresleniaDzialalnosciZRegon")]
        [JsonProperty(nameof(FizDataSkresleniaDzialalnosciZRegon))]
        [Display(Name = "Data skreślenia z Regon działalności osoby fizycznej", Prompt = "Wpisz datę skreślenia z Regon działalności osoby fizycznej", Description = "Data skreślenia z Regon działalności osoby fizycznej")]
        [Column("FizDataSkresleniaDzialalnosciZRegon", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataSkresleniaDzialalnosciZRegon { get; set; }
        #endregion

        #region public string FizDataOrzeczeniaOUpadlosci { get; set; }
        /// <summary>
        /// Data orzeczenia o upadłości działalności osoby fizycznej (string)
        /// Date of the declaration on the bankruptcy of the activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_dataOrzeczeniaOUpadlosci")]
        [JsonProperty(nameof(FizDataOrzeczeniaOUpadlosci))]
        [Display(Name = "Data orzeczenia o upadłości działalności osoby fizycznej", Prompt = "Wpisz datę orzeczenia o upadłości działalności osoby fizycznej", Description = "Data orzeczenia o upadłości działalności osoby fizycznej")]
        [Column("FizDataOrzeczeniaOUpadlosci", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataOrzeczeniaOUpadlosci { get; set; }
        #endregion

        #region public string FizDataZakonczeniaPostepowaniaUpadlosciowego { get; set; }
        /// <summary>
        /// Data zakończenia postępowania upadłościowego działalności osoby fizycznej (string)
        /// Date of completion of bankruptcy proceedings for the activity of a natural person (string)
        /// </summary>
        [XmlElement("fiz_dataZakonczeniaPostepowaniaUpadlosciowego")]
        [JsonProperty(nameof(FizDataZakonczeniaPostepowaniaUpadlosciowego))]
        [Display(Name = "Data zakończenia postępowania upadłościowego działalności osoby fizycznej", Prompt = "Wpisz datę zakończenia postępowania upadłościowego działalności osoby fizycznej", Description = "Data zakończenia postępowania upadłościowego działalności osoby fizycznej")]
        [Column("FizDataZakonczeniaPostepowaniaUpadlosciowego", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataZakonczeniaPostepowaniaUpadlosciowego { get; set; }
        #endregion

        #region public string FizAdSiedzKrajSymbol { get; set; }
        /// <summary>
        /// Symbol kraju działalności osoby fizycznej (string)
        /// Natural person's country of activity symbol (string)
        /// </summary>
        [XmlElement("fiz_adSiedzKraj_Symbol")]
        [JsonProperty(nameof(FizAdSiedzKrajSymbol))]
        [Display(Name = "Symbol kraju działalności osoby fizycznej", Prompt = "Wpisz symbol kraju działalności osoby fizycznej", Description = "Symbol kraju działalności osoby fizycznej")]
        [Column("FizAdSiedzKrajSymbol", TypeName = "varchar(2)")]
        [StringLength(2)]
        [MaxLength(2)]
        public string FizAdSiedzKrajSymbol { get; set; }
        #endregion

        #region public string FizAdSiedzWojewodztwoSymbol { get; set; }
        /// <summary>
        /// Symbol województwa działalności osoby fizycznej (string)
        /// A symbol of a voivodeship activity of a natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzWojewodztwo_Symbol")]
        [JsonProperty(nameof(FizAdSiedzWojewodztwoSymbol))]
        [Display(Name = "Symbol województwa działalności osoby fizycznej", Prompt = "Wpisz symbol województwa działalności osoby fizycznej", Description = "Symbol województwa działalności osoby fizycznej")]
        [Column("FizAdSiedzWojewodztwoSymbol", TypeName = "varchar(2)")]
        [StringLength(2)]
        [MaxLength(2)]
        public string FizAdSiedzWojewodztwoSymbol { get; set; }
        #endregion

        #region public string FizadSiedzPowiatSymbol { get; set; }
        /// <summary>
        /// Symbol powiatu działalności osoby fizycznej (string)
        /// A symbol of a district activity of a natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzPowiat_Symbol")]
        [JsonProperty(nameof(FizadSiedzPowiatSymbol))]
        [Display(Name = "Symbol powiatu działalności osoby fizycznej", Prompt = "Wpisz symbol powiatu działalności osoby fizycznej", Description = "Symbol powiatu działalności osoby fizycznej")]
        [Column("FizadSiedzPowiatSymbol", TypeName = "varchar(2)")]
        [StringLength(2)]
        [MaxLength(2)]
        public string FizadSiedzPowiatSymbol { get; set; }
        #endregion

        #region public string FizAdSiedzGminaSymbol { get; set; }
        /// <summary>
        /// Symbol gminy działalności osoby fizycznej (string)
        /// A symbol of a community activity of a natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzGmina_Symbol")]
        [JsonProperty(nameof(FizAdSiedzGminaSymbol))]
        [Display(Name = "Symbol gminy działalności osoby fizycznej", Prompt = "Wpisz symbol gminy działalności osoby fizycznej", Description = "Symbol gminy działalności osoby fizycznej")]
        [Column("FizAdSiedzGminaSymbol", TypeName = "varchar(3)")]
        [StringLength(3)]
        [MaxLength(3)]
        public string FizAdSiedzGminaSymbol { get; set; }
        #endregion

        #region public string FizAdSiedzKodPocztowy { get; set; }
        /// <summary>
        /// Kod pocztowy działalności osoby fizycznej (string)
        /// Postal code of the activity of a natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzKodPocztowy")]
        [JsonProperty(nameof(FizAdSiedzKodPocztowy))]
        [Display(Name = "Kod pocztowy działalności osoby fizycznej", Prompt = "Wpisz kod pocztowy działalności osoby fizycznej", Description = "Kod pocztowy działalności osoby fizycznej")]
        [Column("FizAdSiedzKodPocztowy", TypeName = "varchar(12)")]
        [StringLength(12)]
        [MaxLength(12)]
        public string FizAdSiedzKodPocztowy { get; set; }
        #endregion

        #region public string FizAdSiedzMiejscowoscPocztySymbol { get; set; }
        /// <summary>
        /// Symbol miejscowości poczty (string)
        /// Post town symbol (string)
        /// </summary>
        [XmlElement("fiz_adSiedzMiejscowoscPoczty_Symbol")]
        [JsonProperty(nameof(FizAdSiedzMiejscowoscPocztySymbol))]
        [Display(Name = "Symbol miejscowości poczty", Prompt = "Wpisz symbol miejscowości poczty", Description = "Symbol miejscowości poczty")]
        [Column("FizAdSiedzMiejscowoscPocztySymbol", TypeName = "varchar(7)")]
        [StringLength(7)]
        [MaxLength(7)]
        public string FizAdSiedzMiejscowoscPocztySymbol { get; set; }
        #endregion

        #region public string FizAdSiedzMiejscowoscSymbol { get; set; }
        /// <summary>
        /// Symbol miejscowości działalności osoby fizycznej (string)
        /// A symbol of a physical person's place of activity (string)
        /// </summary>
        [XmlElement("fiz_adSiedzMiejscowosc_Symbol")]
        [JsonProperty(nameof(FizAdSiedzMiejscowoscSymbol))]
        [Display(Name = "Symbol miejscowości działalności osoby fizycznej", Prompt = "Wpisz symbol miejscowości działalności osoby fizycznej", Description = "Symbol miejscowości działalności osoby fizycznej")]
        [Column("FizAdSiedzMiejscowoscSymbol", TypeName = "varchar(7)")]
        [StringLength(7)]
        [MaxLength(7)]
        public string FizAdSiedzMiejscowoscSymbol { get; set; }
        #endregion

        #region public string FizAdSiedzUlicaSymbol { get; set; }
        /// <summary>
        /// Symbol ulicy działalności osoby fizycznej (string)
        /// Natural person activity street symbol (string)
        /// </summary>
        [XmlElement("fiz_adSiedzUlica_Symbol")]
        [JsonProperty(nameof(FizAdSiedzUlicaSymbol))]
        [Display(Name = "Symbol ulicy działalności osoby fizycznej", Prompt = "Wpisz symbol ulicy działalności osoby fizycznej", Description = "Symbol ulicy działalności osoby fizycznej")]
        [Column("FizAdSiedzUlicaSymbol", TypeName = "varchar(5)")]
        [StringLength(5)]
        [MaxLength(5)]
        public string FizAdSiedzUlicaSymbol { get; set; }
        #endregion

        #region public string FizAdSiedzNumerNieruchomosci { get; set; }
        /// <summary>
        /// Numer nieruchomości siedziby działalności osoby fizycznej (string)
        /// Real estate number of the registered office of the natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzNumerNieruchomosci")]
        [JsonProperty(nameof(FizAdSiedzNumerNieruchomosci))]
        [Display(Name = "Numer nieruchomości siedziby działalności osoby fizycznej", Prompt = "Wpisz numer nieruchomości siedziby działalności osoby fizycznej", Description = "Numer nieruchomości siedziby działalności osoby fizycznej")]
        [Column("FizAdSiedzNumerNieruchomosci", TypeName = "varchar(20)")]
        [StringLength(20)]
        [MaxLength(20)]
        public string FizAdSiedzNumerNieruchomosci { get; set; }
        #endregion

        #region public string FizAdSiedzNumerLokalu { get; set; }
        /// <summary>
        /// Numer lokalu siedziby działalności osoby fizycznej (string)
        /// The number of the seat of the natural person's business (string)
        /// </summary>
        [XmlElement("fiz_adSiedzNumerLokalu")]
        [JsonProperty(nameof(FizAdSiedzNumerLokalu))]
        [Display(Name = "Numer lokalu siedziby działalności osoby fizycznej", Prompt = "Wpisz numer lokalu siedziby działalności osoby fizycznej", Description = "Numer lokalu siedziby działalności osoby fizycznej")]
        [Column("FizAdSiedzNumerLokalu", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizAdSiedzNumerLokalu { get; set; }
        #endregion

        #region public string FizAdSiedzNietypoweMiejsceLokalizacji { get; set; }
        /// <summary>
        /// Nietypowa lokalizacja działalności osoby fizycznej (string)
        /// Atypical location of the activity of a natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzNietypoweMiejsceLokalizacji")]
        [JsonProperty(nameof(FizAdSiedzNietypoweMiejsceLokalizacji))]
        [Display(Name = "Nietypowa lokalizacja działalności osoby fizycznej", Prompt = "Wpisz nietypowa lokalizacja działalności osoby fizycznej", Description = "Nietypowa lokalizacja działalności osoby fizycznej")]
        [Column("FizAdSiedzNietypoweMiejsceLokalizacji", TypeName = "varchar(160)")]
        [StringLength(160)]
        [MaxLength(160)]
        public string FizAdSiedzNietypoweMiejsceLokalizacji { get; set; }
        #endregion

        #region public string FizNumerTelefonu { get; set; }
        /// <summary>
        /// Numer telefonu osoby fizycznej (string)
        /// Telephone number of the natural person (string)
        /// </summary>
        [XmlElement("fiz_numerTelefonu")]
        [JsonProperty(nameof(FizNumerTelefonu))]
        [Display(Name = "Numer telefonu osoby fizycznej", Prompt = "Wpisz Numer telefonu osoby fizycznej", Description = "Numer telefonu osoby fizycznej")]
        [Column("FizNumerTelefonu", TypeName = "varchar(1)")]
        [StringLength(1)]
        [MaxLength(1)]
        public string FizNumerTelefonu { get; set; }
        #endregion

        #region public string FizNumerWewnetrznyTelefonu { get; set; }
        /// <summary>
        /// Numer telefonu wewnętrznego osoby fizycznej (string)
        /// Personal extension telephone number (string)
        /// </summary>
        [XmlElement("fiz_numerWewnetrznyTelefonu")]
        [JsonProperty(nameof(FizNumerWewnetrznyTelefonu))]
        [Display(Name = "Numer telefonu wewnętrznego osoby fizycznej", Prompt = "Wpisz numer telefonu wewnętrznego osoby fizycznej", Description = "Numer telefonu wewnętrznego osoby fizycznej")]
        [Column("FizNumerWewnetrznyTelefonu", TypeName = "varchar(1)")]
        [StringLength(1)]
        [MaxLength(1)]
        public string FizNumerWewnetrznyTelefonu { get; set; }
        #endregion

        #region public string FizNumerFaksu { get; set; }
        /// <summary>
        /// Numer faksu osoby fizycznej (string)
        /// Fax number (string)
        /// </summary>
        [XmlElement("fiz_numerFaksu")]
        [JsonProperty(nameof(FizNumerFaksu))]
        [Display(Name = "Numer faksu osoby fizycznej", Prompt = "Wpisz numer faksu osoby fizycznej", Description = "Numer faksu osoby fizycznej")]
        [Column("FizNumerFaksu", TypeName = "varchar(1)")]
        [StringLength(1)]
        [MaxLength(1)]
        public string FizNumerFaksu { get; set; }
        #endregion

        #region public string FizAdresEmail { get; set; }
        /// <summary>
        /// Adres email osoby fizycznej (string)
        /// Email adress (string)
        /// </summary>
        [XmlElement("fiz_adresEmail")]
        [JsonProperty(nameof(FizAdresEmail))]
        [Display(Name = "Adres email osoby fizycznej", Prompt = "Wpisz adres email osoby fizycznej", Description = "Adres email osoby fizycznej")]
        [Column("FizAdresEmail", TypeName = "varchar(100)")]
        [StringLength(100)]
        [MaxLength(100)]
        public string FizAdresEmail { get; set; }
        #endregion

        #region public string FizAdresStronyInternetowej { get; set; }
        /// <summary>
        /// Adres strony internetowej działalności osoby fizycznej (string)
        /// The website address of the natural person's activity (string)
        /// </summary>
        [XmlElement("fiz_adresStronyinternetowej")]
        [JsonProperty(nameof(FizAdresStronyInternetowej))]
        [Display(Name = "Adres strony internetowej działalności osoby fizycznej", Prompt = "Wpisz adres strony internetowej działalności osoby fizycznej", Description = "Adres strony internetowej działalności osoby fizycznej")]
        [Column("FizAdresStronyInternetowej", TypeName = "varchar(100)")]
        [StringLength(100)]
        [MaxLength(100)]
        public string FizAdresStronyInternetowej { get; set; }
        #endregion

        #region public string FizAdSiedzKrajNazwa { get; set; }
        /// <summary>
        /// Nazwa kraju działalności osoby fizycznej (string)
        /// Name of the country of activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzKraj_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzKrajNazwa))]
        [Display(Name = "Nazwa kraju działalności osoby fizycznej", Prompt = "Wpisz nazwę kraju działalności osoby fizycznej", Description = "Nazwa kraju działalności osoby fizycznej")]
        [Column("FizAdSiedzKrajNazwa", TypeName = "varchar(200)")]
        [StringLength(200)]
        [MaxLength(200)]
        public string FizAdSiedzKrajNazwa { get; set; }
        #endregion

        #region public string FizAdSiedzWojewodztwoNazwa { get; set; }
        /// <summary>
        /// Nazwa województwa działalności osoby fizycznej (string)
        /// Name of the voivodeship of the activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzWojewodztwo_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzWojewodztwoNazwa))]
        [Display(Name = "Nazwa województwa działalności osoby fizycznej", Prompt = "Wpisz nazwę województwa działalności osoby fizycznej", Description = "Nazwa województwa działalności osoby fizycznej")]
        [Column("FizAdSiedzWojewodztwoNazwa", TypeName = "varchar(100)")]
        [StringLength(100)]
        [MaxLength(100)]
        public string FizAdSiedzWojewodztwoNazwa { get; set; }
        #endregion

        #region public string FizAdSiedzPowiatNazwa { get; set; }
        /// <summary>
        /// Nazwa powiatu działalności osoby fizycznej (string)
        /// Name of the poviat of activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzPowiat_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzPowiatNazwa))]
        [Display(Name = "Nazwa powiatu działalności osoby fizycznej", Prompt = "Wpisz nazwę powiatu działalności osoby fizycznej", Description = "Nazwa powiatu działalności osoby fizycznej")]
        [Column("FizAdSiedzPowiatNazwa", TypeName = "varchar(100)")]
        [StringLength(100)]
        [MaxLength(100)]
        public string FizAdSiedzPowiatNazwa { get; set; }
        #endregion

        #region public string FizAdSiedzGminaNazwa { get; set; }
        /// <summary>
        /// Nazwa gminy działalności osoby fizycznej (string)
        /// Name of the commune of the activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzGmina_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzGminaNazwa))]
        [Display(Name = "Nazwa gminy działalności osoby fizycznej", Prompt = "Wpisz nazwę gminy działalności osoby fizycznej", Description = "Nazwa gminy działalności osoby fizycznej")]
        [Column("FizAdSiedzGminaNazwa", TypeName = "varchar(100)")]
        [StringLength(100)]
        [MaxLength(100)]
        public string FizAdSiedzGminaNazwa { get; set; }
        #endregion

        #region public string FizAdSiedzMiejscowoscNazwa { get; set; }
        /// <summary>
        /// Miejscowość siedziby działalności osoby fizycznej (string)
        /// Place of registered office of the natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzMiejscowosc_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzMiejscowoscNazwa))]
        [Display(Name = "Miejscowość siedziby działalności osoby fizycznej", Prompt = "Wpisz miejscowość siedziby działalności osoby fizycznej", Description = "Miejscowość siedziby działalności osoby fizycznej")]
        [Column("FizAdSiedzMiejscowoscNazwa", TypeName = "varchar(100)")]
        [StringLength(100)]
        [MaxLength(100)]
        public string FizAdSiedzMiejscowoscNazwa { get; set; }
        #endregion

        #region public string FizAdSiedzMiejscowoscPocztyNazwa { get; set; }
        /// <summary>
        /// Miejscowość poczty działalności osoby fizycznej (string)
        /// City of the post office of the natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzMiejscowoscPoczty_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzMiejscowoscPocztyNazwa))]
        [Display(Name = "Miejscowość poczty działalności osoby fizycznej", Prompt = "Wpisz miejscowość poczty działalności osoby fizycznej", Description = "Miejscowość poczty działalności osoby fizycznej")]
        [Column("FizAdSiedzMiejscowoscPocztyNazwa", TypeName = "varchar(100)")]
        [StringLength(100)]
        [MaxLength(100)]
        public string FizAdSiedzMiejscowoscPocztyNazwa { get; set; }
        #endregion

        #region public string FizAdSiedzUlicaNazwa { get; set; }
        /// <summary>
        /// Nazwa ulicy działalności osoby fizycznej (string)
        /// Name of the street of activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzUlica_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzUlicaNazwa))]
        [Display(Name = "Nazwa ulicy działalności osoby fizycznej", Prompt = "Wpisz nazwę ulicy działalności osoby fizycznej", Description = "Nazwa ulicy działalności osoby fizycznej")]
        [Column("FizAdSiedzUlicaNazwa", TypeName = "varchar(351)")]
        [StringLength(351)]
        [MaxLength(351)]
        public string FizAdSiedzUlicaNazwa { get; set; }
        #endregion

        #region public string FizCdataWpisuDoRejestruEwidencji { get; set; }
        /// <summary>
        /// Data wpisu do rejestru ewidencji działalności osoby fizycznej (string)
        /// Date of entry into the register of activity records of a natural person (string)
        /// </summary>
        [XmlElement("fizC_dataWpisuDoRejestruEwidencji")]
        [JsonProperty(nameof(FizCdataWpisuDoRejestruEwidencji))]
        [Display(Name = "Data wpisu do rejestru ewidencji działalności osoby fizycznej", Prompt = "Wpisz datę wpisu do rejestru ewidencji działalności osoby fizycznej", Description = "Data wpisu do rejestru ewidencji działalności osoby fizycznej")]
        [Column("FizCdataWpisuDoRejestruEwidencji", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizCdataWpisuDoRejestruEwidencji { get; set; }
        #endregion

        #region public string FizCdataSkresleniaZRejestruEwidencji { get; set; }
        /// <summary>
        /// Data skreślenia z ewidencji działalności osoby fizycznej (string)
        /// Date of removal from the register of natural person's activity (string)
        /// </summary>
        [XmlElement("fizC_dataSkresleniaZRejestruEwidencji")]
        [JsonProperty(nameof(FizCdataSkresleniaZRejestruEwidencji))]
        [Display(Name = "Data skreślenia z ewidencji działalności osoby fizycznej", Prompt = "Wpisz datę skreślenia z ewidencji działalności osoby fizycznej", Description = "Data skreślenia z ewidencji działalności osoby fizycznej")]
        [Column("FizCdataSkresleniaZRejestruEwidencji", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizCdataSkresleniaZRejestruEwidencji { get; set; }
        #endregion

        #region public string FizCnumerWRejestrzeEwidencji { get; set; }
        /// <summary>
        /// Numer w rejestrze ewidencji działalności osoby fizycznej (string)
        /// Number in the register of activity records of a natural person (string)
        /// </summary>
        [XmlElement("fizC_numerWRejestrzeEwidencji")]
        [JsonProperty(nameof(FizCnumerWRejestrzeEwidencji))]
        [Display(Name = "Numer w rejestrze ewidencji działalności osoby fizycznej", Prompt = "Wpisz numer w rejestrze ewidencji działalności osoby fizycznej", Description = "Numer w rejestrze ewidencji działalności osoby fizycznej")]
        [Column("FizCnumerWRejestrzeEwidencji", TypeName = "varchar(50)")]
        [StringLength(50)]
        [MaxLength(50)]
        public string FizCnumerWRejestrzeEwidencji { get; set; }
        #endregion

        #region public string FizCOrganRejestrowySymbol { get; set; }
        /// <summary>
        /// Symbol organu rejestrowego działalności osoby fizycznej (string)
        /// Symbol of the registration authority for the activity of a natural person (string)
        /// </summary>
        [XmlElement("fizC_OrganRejestrowy_Symbol")]
        [JsonProperty(nameof(FizCOrganRejestrowySymbol))]
        [Display(Name = "Symbol organu rejestrowego działalności osoby fizycznej", Prompt = "Wpisz symbol organu rejestrowego działalności osoby fizycznej", Description = "Symbol organu rejestrowego działalności osoby fizycznej")]
        [Column("FizCOrganRejestrowySymbol", TypeName = "varchar(9)")]
        [StringLength(9)]
        [MaxLength(9)]
        public string FizCOrganRejestrowySymbol { get; set; }
        #endregion

        #region public string FizCOrganRejestrowyNazwa { get; set; }
        /// <summary>
        /// Nazwa organu rejestrowego działalności osoby fizycznej (string)
        /// Name of the registration authority for the activity of a natural person (string)
        /// </summary>
        [XmlElement("fizC_OrganRejestrowy_Nazwa")]
        [JsonProperty(nameof(FizCOrganRejestrowyNazwa))]
        [Display(Name = "Nazwa organu rejestrowego działalności osoby fizycznej", Prompt = "Wpisz nazwę organu rejestrowego działalności osoby fizycznej", Description = "Nazwa organu rejestrowego działalności osoby fizycznej")]
        [Column("FizCOrganRejestrowyNazwa", TypeName = "varchar(240)")]
        [StringLength(240)]
        [MaxLength(240)]
        public string FizCOrganRejestrowyNazwa { get; set; }
        #endregion

        #region public string FizCRodzajRejestruSymbol { get; set; }
        /// <summary>
        /// Symbol rodzaju rejestru działalności osoby fizycznej (string)
        /// Symbol of the type of business register of a natural person (string)
        /// </summary>
        [XmlElement("fizC_RodzajRejestru_Symbol")]
        [JsonProperty(nameof(FizCRodzajRejestruSymbol))]
        [Display(Name = "Symbol rodzaju rejestru działalności osoby fizycznej", Prompt = "Wpisz symbol rodzaju rejestru działalności osoby fizycznej", Description = "Symbol rodzaju rejestru działalności osoby fizycznej")]
        [Column("FizCRodzajRejestruSymbol", TypeName = "varchar(3)")]
        [StringLength(3)]
        [MaxLength(3)]
        public string FizCRodzajRejestruSymbol { get; set; }
        #endregion

        #region public string FizCRodzajRejestruNazwa { get; set; }
        /// <summary>
        /// Nazwa rodzaju rejestru działalności osoby fizycznej (string)
        /// Name of the type of business register of a natural person (string)
        /// </summary>
        [XmlElement("fizC_RodzajRejestru_Nazwa")]
        [JsonProperty(nameof(FizCRodzajRejestruNazwa))]
        [Display(Name = "Nazwa rodzaju rejestru działalności osoby fizycznej", Prompt = "Wpisz nazwę rodzaju rejestru działalności osoby fizycznej", Description = "Nazwa rodzaju rejestru działalności osoby fizycznej")]
        [Column("FizCRodzajRejestruNazwa", TypeName = "varchar(240)")]
        [StringLength(240)]
        [MaxLength(240)]
        public string FizCRodzajRejestruNazwa { get; set; }
        #endregion

        #region public string FizCNiePodjetoDzialalnosci { get; set; }
        /// <summary>
        /// Nie podjęto działalności osoby fizycznej (boolean)
        /// The activity of a natural person was not undertaken (boolean)
        /// </summary>
        [XmlElement("fizC_NiePodjetoDzialalnosci")]
        [JsonProperty(nameof(FizCNiePodjetoDzialalnosci))]
        [Display(Name = "Nie podjęto działalności osoby fizycznej", Prompt = "Nie podjęto działalności osoby fizycznej", Description = "Nie podjęto działalności osoby fizycznej")]
        [Column("FizCNiePodjetoDzialalnosci", TypeName = "boolean")]
        public string FizCNiePodjetoDzialalnosci { get; set; }
        #endregion
    }
    #endregion
}
