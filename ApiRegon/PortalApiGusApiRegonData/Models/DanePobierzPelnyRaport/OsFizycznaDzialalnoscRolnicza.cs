using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace PortalApiGusApiRegonData.Models.DanePobierzPelnyRaport
{
    #region class OsFizycznaDzialalnoscRolnicza
    /// <summary>
    /// Model danych działalności rolniczej osoby fizycznej
    /// Data model of agricultural activity of a natural person
    /// </summary>
    [Table("OsFizycznaDzialalnoscRolnicza")]
    [Serializable, XmlRoot("dane")]
    public partial class OsFizycznaDzialalnoscRolnicza
    {
        #region public string FizRegon9 { get; set; }
        /// <summary>
        /// REGON działalności rolniczej osoby fizycznej (string)
        /// REGON for agricultural activity of a natural person (string)
        /// </summary>
        [XmlElement("fiz_regon9")]
        [JsonProperty(nameof(FizRegon9))]
        [Display(Name = "REGON działalności rolniczej osoby fizycznej", Prompt = "Wpisz REGON działalności rolniczej osoby fizycznej", Description = "REGON działalności rolniczej osoby fizycznej")]
        [Column("FizRegon9", TypeName = "varchar(9)")]
        [StringLength(9)]
        [MaxLength(9)]
        public string FizRegon9 { get; set; }
        #endregion

        #region public string FizNazwa { get; set; }
        /// <summary>
        /// Nazwa działalności rolniczej osoby fizycznej (string)
        /// Name of agricultural activity of a natural person (string)
        /// </summary>
        [XmlElement("fiz_nazwa")]
        [JsonProperty(nameof(FizNazwa))]
        [Display(Name = "Nazwa działalności rolniczej osoby fizycznej", Prompt = "Wpisz nazwę działalności rolniczej osoby fizycznej", Description = "Nazwa działalności rolniczej osoby fizycznej")]
        [Column("FizNazwa", TypeName = "varchar(2000)")]
        [StringLength(2000)]
        [MaxLength(2000)]
        public string FizNazwa { get; set; }
        #endregion

        #region public string FizNazwaSkrocona { get; set; }
        /// <summary>
        /// Nazwa skrócona działalności rolniczej osoby fizycznej (string)
        /// Short name of agricultural activity of a natural person (string)
        /// </summary>
        [XmlElement("fiz_nazwaSkrocona")]
        [JsonProperty(nameof(FizNazwaSkrocona))]
        [Display(Name = "Skrócona nazwa działalności rolniczej osoby fizycznej", Prompt = "Wpisz skróconą nazwę działalności rolniczej osoby fizycznej", Description = "Skrócona nazwa działalności rolniczej osoby fizycznej")]
        [Column("FizNazwaSkrocona", TypeName = "varchar(256)")]
        [StringLength(256)]
        [MaxLength(256)]
        public string FizNazwaSkrocona { get; set; }
        #endregion

        #region public string FizDataPowstania { get; set; }
        /// <summary>
        /// Data powstania działalności rolniczej osoby fizycznej (string)
        /// Date of establishing the agricultural activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_dataPowstania")]
        [JsonProperty(nameof(FizDataPowstania))]
        [Display(Name = "Data powstania działalności rolniczej osoby fizycznej", Prompt = "Wpisz datę powstania działalności rolniczej osoby fizycznej", Description = "Data powstania działalności rolniczej osoby fizycznej")]
        [Column("FizDataPowstania", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataPowstania { get; set; }
        #endregion

        #region public string FizDataRozpoczeciaDzialalnosci { get; set; }
        /// <summary>
        /// Data rozpoczęcia działalności rolniczej osoby fizycznej (string)
        /// Date of commencement of agricultural activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_dataRozpoczeciaDzialalnosci")]
        [JsonProperty(nameof(FizDataRozpoczeciaDzialalnosci))]
        [Display(Name = "Data rozpoczęcia działalności rolniczej osoby fizycznej", Prompt = "Wpisz datę rozpoczęcia działalności rolniczej osoby fizycznej", Description = "Data rozpoczęcia działalności rolniczej osoby fizycznej")]
        [Column("FizDataRozpoczeciaDzialalnosci", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataRozpoczeciaDzialalnosci { get; set; }
        #endregion

        #region public string FizDataWpisuDzialalnosciDoRegon { get; set; }
        /// <summary>
        /// Data wpisu do REGON dla działalności rolniczej osoby fizycznej (string)
        /// Date of entry into REGON for agricultural activity of a natural person (string)
        /// </summary>
        [XmlElement("fiz_dataWpisuDzialalnosciDoRegon")]
        [JsonProperty(nameof(FizDataWpisuDzialalnosciDoRegon))]
        [Display(Name = "Data wpisu do REGON dla działalności rolniczej osoby fizycznej", Prompt = "Wprowadź datę wpisu do REGON dla działalności rolniczej osoby fizycznej", Description = "Data wpisu do REGON dla działalności rolniczej osoby fizycznej")]
        [Column("FizDataWpisuDzialalnosciDoRegon", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataWpisuDzialalnosciDoRegon { get; set; }
        #endregion

        #region public string FizDataZawieszeniaDzialalnosci { get; set; }
        /// <summary>
        /// Data zawieszenia działalności rolniczej osoby fizycznej (string)
        /// Date of suspension of the agricultural activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_dataZawieszeniaDzialalnosci")]
        [JsonProperty(nameof(FizDataZawieszeniaDzialalnosci))]
        [Display(Name = "Data zawieszenia działalności rolniczej osoby fizycznej", Prompt = "Wprowadź datę zawieszenia działalności rolniczej osoby fizycznej", Description = "Data zawieszenia działalności rolniczej osoby fizycznej")]
        [Column("FizDataZawieszeniaDzialalnosci", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataZawieszeniaDzialalnosci { get; set; }
        #endregion

        #region public string FizDataWznowieniaDzialalnosci { get; set; }
        /// <summary>
        /// Data wznowienia działalności rolniczej osoby fizycznej (string)
        /// Date of resuming agricultural activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_dataWznowieniaDzialalnosci")]
        [JsonProperty(nameof(FizDataWznowieniaDzialalnosci))]
        [Display(Name = "Data wznowienia działalności rolniczej osoby fizycznej", Prompt = "Wprowadź datę wznowienia działalności rolniczej osoby fizycznej", Description = "Data wznowienia działalności rolniczej osoby fizycznej")]
        [Column("FizDataWznowieniaDzialalnosci", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataWznowieniaDzialalnosci { get; set; }
        #endregion

        #region public string FizDataZaistnieniaZmianyDzialalnosci { get; set; }
        /// <summary>
        /// Data zaistnienia zmiany działalności rolniczej osoby fizycznej (string)
        /// Date when the agricultural activity of the natural person changed (string)
        /// </summary>
        [XmlElement("fiz_dataZaistnieniaZmianyDzialalnosci")]
        [JsonProperty(nameof(FizDataZaistnieniaZmianyDzialalnosci))]
        [Display(Name = "Data zaistnienia zmiany działalności rolniczej osoby fizycznej", Prompt = "Wprowadź datę zaistnienia zmiany działalności rolniczej osoby fizycznej", Description = "Data zaistnienia zmiany działalności rolniczej osoby fizycznej")]
        [Column("FizDataZaistnieniaZmianyDzialalnosci", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataZaistnieniaZmianyDzialalnosci { get; set; }
        #endregion

        #region public string FizDataZakonczeniaDzialalnosci { get; set; }
        /// <summary>
        /// Data zakończenia działalności rolniczej osoby fizycznej (string)
        /// Date of ending the agricultural activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_dataZakonczeniaDzialalnosci")]
        [JsonProperty(nameof(FizDataZakonczeniaDzialalnosci))]
        [Display(Name = "Data zakończenia działalności rolniczej osoby fizycznej", Prompt = "Wprowadź datę zakończenia działalności rolniczej osoby fizycznej", Description = "Data zakończenia działalności rolniczej osoby fizycznej")]
        [Column("FizDataZakonczeniaDzialalnosci", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataZakonczeniaDzialalnosci { get; set; }
        #endregion

        #region public string FizDataSkresleniaDzialalanosciZRegon { get; set; }
        /// <summary>
        /// Data skreślenia działalności rolniczej z REGON osoby fizycznej (string)
        /// The date when the agricultural activity was removed from the REGON number of a natural person (string)
        /// </summary>
        [XmlElement("fiz_dataSkresleniaDzialalanosciZRegon")]
        [JsonProperty(nameof(FizDataSkresleniaDzialalanosciZRegon))]
        [Display(Name = "Data skreślenia działalności rolniczej z REGON osoby fizycznej", Prompt = "Wprowadź datę skreślenia działalności rolniczej z REGON osoby fizycznej", Description = "Data skreślenia działalności rolniczej z REGON osoby fizycznej")]
        [Column("FizDataSkresleniaDzialalanosciZRegon", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataSkresleniaDzialalanosciZRegon { get; set; }
        #endregion

        #region public string FizDataOrzeczeniaOUpadlosci { get; set; }
        /// <summary>
        /// Data orzeczenia o upadłości działalności rolniczej osoby fizycznej (string)
        /// Date of the decision on the bankruptcy of the agricultural activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_dataOrzeczeniaOUpadlosci")]
        [JsonProperty(nameof(FizDataOrzeczeniaOUpadlosci))]
        [Display(Name = "Data orzeczenia o upadłości działalności rolniczej osoby fizycznej", Prompt = "Wprowadź datę orzeczenia o upadłości działalności rolniczej osoby fizycznej", Description = "Data orzeczenia o upadłości działalności rolniczej osoby fizycznej")]
        [Column("FizDataOrzeczeniaOUpadlosci", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataOrzeczeniaOUpadlosci { get; set; }
        #endregion

        #region public string FizDataZakonczeniaPostepowaniaUpadlosciowego { get; set; }
        /// <summary>
        /// Data zakończenia postępowania upadłościowego działalności rolniczej osoby fizycznej (string)
        /// Date of completion of the bankruptcy proceedings of a natural person's agricultural activity (string)
        /// </summary>
        [XmlElement("fiz_dataZakonczeniaPostepowaniaUpadlosciowego")]
        [JsonProperty(nameof(FizDataZakonczeniaPostepowaniaUpadlosciowego))]
        [Display(Name = "Data zakończenia postępowania upadłościowego działalności rolniczej osoby fizycznej", Prompt = "Wprowadź datę zakończenia postępowania upadłościowego działalności rolniczej osoby fizycznej", Description = "Data zakończenia postępowania upadłościowego działalności rolniczej osoby fizycznej")]
        [Column("FizDataZakonczeniaPostepowaniaUpadlosciowego", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizDataZakonczeniaPostepowaniaUpadlosciowego { get; set; }
        #endregion

        #region public string FizAdSiedzKrajSymbol { get; set; }
        /// <summary>
        /// Symbol kraju dla siedziby działalności rolniczej osoby fizycznej (string)
        /// Country symbol for a natural person's agricultural activity (string)
        /// </summary>
        [XmlElement("fiz_adSiedzKraj_Symbol")]
        [JsonProperty(nameof(FizAdSiedzKrajSymbol))]
        [Display(Name = "Symbol kraju dla siedziby działalności rolniczej osoby fizycznej", Prompt = "Wprowadź symbol kraju dla siedziby działalności rolniczej osoby fizycznej", Description = "Symbol kraju dla siedziby działalności rolniczej osoby fizycznej")]
        [Column("FizAdSiedzKrajSymbol", TypeName = "varchar(2)")]
        [StringLength(2)]
        [MaxLength(2)]
        public string FizAdSiedzKrajSymbol { get; set; }
        #endregion

        #region public string FizAdSiedzWojewodztwoSymbol { get; set; }
        /// <summary>
        /// Symbol województwa dla siedziby działalności rolniczej osoby fizycznej (string)
        /// Voivodeship symbol for a natural person's agricultural activity (string)
        /// </summary>
        [XmlElement("fiz_adSiedzWojewodztwo_Symbol")]
        [JsonProperty(nameof(FizAdSiedzWojewodztwoSymbol))]
        [Display(Name = "Symbol województwa dla siedziby działalności rolniczej osoby fizycznej", Prompt = "Wprowadź symbol województwa dla siedziby działalności rolniczej osoby fizycznej", Description = "Symbol województwa dla siedziby działalności rolniczej osoby fizycznej")]
        [Column("FizAdSiedzWojewodztwoSymbol", TypeName = "varchar(2)")]
        [StringLength(2)]
        [MaxLength(2)]
        public string FizAdSiedzWojewodztwoSymbol { get; set; }
        #endregion

        #region public string FizAdSiedzPowiatSymbol { get; set; }
        /// <summary>
        /// Symbol powiatu dla siedziby działalności rolniczej osoby fizycznej (string)
        /// Symbol of the poviat for a natural person's agricultural activity (string)
        /// </summary>
        [XmlElement("fiz_adSiedzPowiat_Symbol")]
        [JsonProperty(nameof(FizAdSiedzPowiatSymbol))]
        [Display(Name = "Symbol powiatu dla siedziby działalności rolniczej osoby fizycznej", Prompt = "Wprowadź symbol powiatu dla siedziby działalności rolniczej osoby fizycznej", Description = "Symbol powiatu dla siedziby działalności rolniczej osoby fizycznej")]
        [Column("FizAdSiedzPowiatSymbol", TypeName = "varchar(2)")]
        [StringLength(2)]
        [MaxLength(2)]
        public string FizAdSiedzPowiatSymbol { get; set; }
        #endregion

        #region public string FizAdSiedzGminaSymbol { get; set; }
        /// <summary>
        /// Symbol gminy dla siedziby działalności rolniczej osoby fizycznej (string)
        /// Symbol of the commune for a natural person's agricultural activity (string)
        /// </summary>
        [XmlElement("fiz_adSiedzGmina_Symbol")]
        [JsonProperty(nameof(FizAdSiedzGminaSymbol))]
        [Display(Name = "Symbol gminy dla siedziby działalności rolniczej osoby fizycznej", Prompt = "Wprowadź symbol gminy dla siedziby działalności rolniczej osoby fizycznej", Description = "Symbol gminy dla siedziby działalności rolniczej osoby fizycznej")]
        [Column("FizAdSiedzGminaSymbol", TypeName = "varchar(3)")]
        [StringLength(3)]
        [MaxLength(3)]
        public string FizAdSiedzGminaSymbol { get; set; }
        #endregion

        #region public string FizAdSiedzKodPocztowy { get; set; }
        /// <summary>
        /// Kod pocztowy dla siedziby działalności rolniczej osoby fizycznej (string)
        /// Postal code for a natural person's agricultural activity (string)
        /// </summary>
        [XmlElement("fiz_adSiedzKodPocztowy")]
        [JsonProperty(nameof(FizAdSiedzKodPocztowy))]
        [Display(Name = "Kod pocztowy dla siedziby działalności rolniczej osoby fizycznej", Prompt = "Wprowadź kod pocztowy dla siedziby działalności rolniczej osoby fizycznej", Description = "Kod pocztowy dla siedziby działalności rolniczej osoby fizycznej")]
        [Column("FizAdSiedzKodPocztowy", TypeName = "varchar(12)")]
        [StringLength(12)]
        [MaxLength(12)]
        public string FizAdSiedzKodPocztowy { get; set; }
        #endregion

        #region public string FizAdSiedzMiejscowoscPocztySymbol { get; set; }
        /// <summary>
        /// Symbol miejscowości poczty dla siedziby działalności rolniczej osoby fizycznej (string)
        /// Symbol of a postal town for a natural person's agricultural activity (string)
        /// </summary>
        [XmlElement("fiz_adSiedzMiejscowoscPoczty_Symbol")]
        [JsonProperty(nameof(FizAdSiedzMiejscowoscPocztySymbol))]
        [Display(Name = "Symbol miejscowości poczty dla siedziby działalności rolniczej osoby fizycznej", Prompt = "Wprowadź symbol miejscowości poczty dla siedziby działalności rolniczej osoby fizycznej", Description = "Symbol miejscowości poczty dla siedziby działalności rolniczej osoby fizycznej")]
        [Column("FizAdSiedzMiejscowoscPocztySymbol", TypeName = "varchar(7)")]
        [StringLength(7)]
        [MaxLength(7)]
        public string FizAdSiedzMiejscowoscPocztySymbol { get; set; }
        #endregion

        #region public string FizAdSiedzMiejscowoscSymbol { get; set; }
        /// <summary>
        /// Symbol miejscowości siedziby działalności rolniczej osoby fizycznej (string)
        /// The symbol of the locality of the agricultural activity of a natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzMiejscowosc_Symbol")]
        [JsonProperty(nameof(FizAdSiedzMiejscowoscSymbol))]
        [Display(Name = "Symbol miejscowości siedziby działalności rolniczej osoby fizycznej", Prompt = "Wprowadź symbol miejscowości siedziby działalności rolniczej osoby fizycznej", Description = "Symbol miejscowości siedziby działalności rolniczej osoby fizycznej")]
        [Column("FizAdSiedzMiejscowoscSymbol", TypeName = "varchar(7)")]
        [StringLength(7)]
        [MaxLength(7)]
        public string FizAdSiedzMiejscowoscSymbol { get; set; }
        #endregion

        #region public string FizAdSiedzUlicaSymbol { get; set; }
        /// <summary>
        /// Symbol ulicy siedziby działalności rolniczej osoby fizycznej (string)
        /// The symbol of the street of the agricultural activity of a natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzUlica_Symbol")]
        [JsonProperty(nameof(FizAdSiedzUlicaSymbol))]
        [Display(Name = "Symbol ulicy siedziby działalności rolniczej osoby fizycznej", Prompt = "Wprowadź symbol ulicy siedziby działalności rolniczej osoby fizycznej", Description = "Symbol ulicy siedziby działalności rolniczej osoby fizycznej")]
        [Column("FizAdSiedzUlicaSymbol", TypeName = "varchar(5)")]
        [StringLength(5)]
        [MaxLength(5)]
        public string FizAdSiedzUlicaSymbol { get; set; }
        #endregion

        #region public string FizAdSiedzNumerNieruchomosci { get; set; }
        /// <summary>
        /// Numer nieruchomości siedziby działalności rolniczej osoby fizycznej (string)
        /// Real estate number of the natural person's agricultural activity (string)
        /// </summary>
        [XmlElement("fiz_adSiedzNumerNieruchomosci")]
        [JsonProperty(nameof(FizAdSiedzNumerNieruchomosci))]
        [Display(Name = "Numer nieruchomości siedziby działalności rolniczej osoby fizycznej", Prompt = "Wprowadź numer nieruchomości siedziby działalności rolniczej osoby fizycznej", Description = "Numer nieruchomości siedziby działalności rolniczej osoby fizycznej")]
        [Column("FizAdSiedzNumerNieruchomosci", TypeName = "varchar(20)")]
        [StringLength(20)]
        [MaxLength(20)]
        public string FizAdSiedzNumerNieruchomosci { get; set; }
        #endregion

        #region public string FizAdSiedzNumerLokalu { get; set; }
        /// <summary>
        /// Numer lokalu siedziby działalności rolniczej osoby fizycznej (string)
        /// Number of the premises of the agricultural activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzNumerLokalu")]
        [JsonProperty(nameof(FizAdSiedzNumerLokalu))]
        [Display(Name = "Numer lokalu siedziby działalności rolniczej osoby fizycznej", Prompt = "Wprowadź numer lokalu siedziby działalności rolniczej osoby fizycznej", Description = "Numer lokalu siedziby działalności rolniczej osoby fizycznej")]
        [Column("FizAdSiedzNumerLokalu", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string FizAdSiedzNumerLokalu { get; set; }
        #endregion

        #region public string FizAdSiedzNietypoweMiejsceLokalizacji { get; set; }
        /// <summary>
        /// Nietypowe miejsce lokalizacji siedziby działalności rolniczej osoby fizycznej (string)
        /// Atypical location for a natural person's agricultural activity (string)
        /// </summary>
        [XmlElement("fiz_adSiedzNietypoweMiejsceLokalizacji")]
        [JsonProperty(nameof(FizAdSiedzNietypoweMiejsceLokalizacji))]
        [Display(Name = "Nietypowe miejsce lokalizacji siedziby działalności rolniczej osoby fizycznej", Prompt = "Wprowadź nietypowe miejsce lokalizacji siedziby działalności rolniczej osoby fizycznej", Description = "Nietypowe miejsce lokalizacji siedziby działalności rolniczej osoby fizycznej")]
        [Column("FizAdSiedzNietypoweMiejsceLokalizacji", TypeName = "varchar(160)")]
        [StringLength(160)]
        [MaxLength(160)]
        public string FizAdSiedzNietypoweMiejsceLokalizacji { get; set; }
        #endregion

        #region public string FizNumerTelefonu { get; set; }
        /// <summary>
        /// Numer telefonu siedziby działalności rolniczej osoby fizycznej (string)
        /// Telephone number of the agricultural activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_numerTelefonu")]
        [JsonProperty(nameof(FizNumerTelefonu))]
        [Display(Name = "Numer telefonu siedziby działalności rolniczej osoby fizycznej", Prompt = "Wprowadź numer telefonu siedziby działalności rolniczej osoby fizycznej", Description = "Numer telefonu siedziby działalności rolniczej osoby fizycznej")]
        [Column("FizNumerTelefonu", TypeName = "varchar(18)")]
        [StringLength(18)]
        [MaxLength(18)]
        public string FizNumerTelefonu { get; set; }
        #endregion

        #region public string FizNumerWewnetrznyTelefonu { get; set; }
        /// <summary>
        /// Wewnętrzny numer telefonu siedziby działalności rolniczej osoby fizycznej (string)
        /// Internal telephone number of the agricultural activity of a natural person (string)
        /// </summary>
        [XmlElement("fiz_numerWewnetrznyTelefonu")]
        [JsonProperty(nameof(FizNumerWewnetrznyTelefonu))]
        [Display(Name = "Wewnętrzny numer telefonu siedziby działalności rolniczej osoby fizycznej", Prompt = "Wprowadź wewnętrzny numer telefonu siedziby działalności rolniczej osoby fizycznej", Description = "Wewnętrzny numer telefonu siedziby działalności rolniczej osoby fizycznej")]
        [Column("FizNumerWewnetrznyTelefonu", TypeName = "varchar(6)")]
        [StringLength(6)]
        [MaxLength(6)]
        public string FizNumerWewnetrznyTelefonu { get; set; }
        #endregion

        #region public string FizNumerFaksu { get; set; }
        /// <summary>
        /// Numer faksu siedziby działalności rolniczej osoby fizycznej (string)
        /// Fax number of the agricultural activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_numerFaksu")]
        [JsonProperty(nameof(FizNumerFaksu))]
        [Display(Name = "Numer faksu siedziby działalności rolniczej osoby fizycznej", Prompt = "Wprowadź numer faksu siedziby działalności rolniczej osoby fizycznej", Description = "Numer faksu siedziby działalności rolniczej osoby fizycznej")]
        [Column("FizNumerFaksu", TypeName = "varchar(18)")]
        [StringLength(18)]
        [MaxLength(18)]
        public string FizNumerFaksu { get; set; }
        #endregion

        #region public string FizAdresEmail { get; set; }
        /// <summary>
        /// Adres email siedziby działalności rolniczej osoby fizycznej (string)
        /// E-mail address of the agricultural activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_adresEmail")]
        [JsonProperty(nameof(FizAdresEmail))]
        [Display(Name = "Adres email siedziby działalności rolniczej osoby fizycznej", Prompt = "Wprowadź adres email siedziby działalności rolniczej osoby fizycznej", Description = "Adres email siedziby działalności rolniczej osoby fizycznej")]
        [Column("FizAdresEmail", TypeName = "varchar(100)")]
        [StringLength(100)]
        [MaxLength(100)]
        public string FizAdresEmail { get; set; }
        #endregion

        #region public string FizAdresStronyInternetowej { get; set; }
        /// <summary>
        /// Adres strony internetowej siedziby działalności rolniczej osoby fizycznej (string)
        /// Website address of the natural person's agricultural activity (string)
        /// </summary>
        [XmlElement("fiz_adresStronyinternetowej")]
        [JsonProperty(nameof(FizAdresStronyInternetowej))]
        [Display(Name = "Adres strony internetowej siedziby działalności rolniczej osoby fizycznej", Prompt = "Wprowadź adres strony internetowej siedziby działalności rolniczej osoby fizycznej", Description = "Adres strony internetowej siedziby działalności rolniczej osoby fizycznej")]
        [Column("FizAdresStronyInternetowej", TypeName = "varchar(100)")]
        [StringLength(100)]
        [MaxLength(100)]
        public string FizAdresStronyInternetowej { get; set; }
        #endregion

        #region public string FizAdSiedzKrajNazwa { get; set; }
        /// <summary>
        /// Kraj siedziby działalności rolniczej osoby fizycznej (string)
        /// Country of agricultural activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzKraj_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzKrajNazwa))]
        [Display(Name = "Kraj siedziby działalności rolniczej osoby fizycznej", Prompt = "Wprowadź kraj siedziby działalności rolniczej osoby fizycznej", Description = "Kraj siedziby działalności rolniczej osoby fizycznej")]
        [Column("FizAdSiedzKrajNazwa", TypeName = "varchar(200)")]
        [StringLength(200)]
        [MaxLength(200)]
        public string FizAdSiedzKrajNazwa { get; set; }
        #endregion

        #region public string FizAdSiedzWojewodztwoNazwa { get; set; }
        /// <summary>
        /// Województwo siedziby działalności rolniczej osoby fizycznej (string)
        /// Voivodship of the agricultural activity of the field field (string)
        /// </summary>
        [XmlElement("fiz_adSiedzWojewodztwo_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzWojewodztwoNazwa))]
        [Display(Name = "Województwo siedziby działalności rolniczej osoby fizycznej", Prompt = "Wprowadź województwo siedziby działalności rolniczej osoby fizycznej", Description = "Województwo siedziby działalności rolniczej osoby fizycznej")]
        [Column("FizAdSiedzWojewodztwoNazwa", TypeName = "varchar(100)")]
        [StringLength(100)]
        [MaxLength(100)]
        public string FizAdSiedzWojewodztwoNazwa { get; set; }
        #endregion

        #region public string FizAdSiedzPowiatNazwa { get; set; }
        /// <summary>
        /// Powiat siedziby działalności rolniczej osoby fizycznej (string)
        /// Poviat of the agricultural activity of the field field (string)
        /// </summary>
        [XmlElement("fiz_adSiedzPowiat_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzPowiatNazwa))]
        [Display(Name = "Powiat siedziby działalności rolniczej osoby fizycznej", Prompt = "Wprowadź powiat siedziby działalności rolniczej osoby fizycznej", Description = "Powiat siedziby działalności rolniczej osoby fizycznej")]
        [Column("FizAdSiedzPowiatNazwa", TypeName = "varchar(100)")]
        [StringLength(100)]
        [MaxLength(100)]
        public string FizAdSiedzPowiatNazwa { get; set; }
        #endregion

        #region public string FizAdSiedzGminaNazwa { get; set; }
        /// <summary>
        /// Gmina siedziby działalności rolniczej osoby fizycznej (string)
        /// Commune of the agricultural activity of the field field (string)
        /// </summary>
        [XmlElement("fiz_adSiedzGmina_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzGminaNazwa))]
        [Display(Name = "Gmina siedziby działalności rolniczej osoby fizycznej", Prompt = "Wprowadź gminę siedziby działalności rolniczej osoby fizycznej", Description = "Gmina siedziby działalności rolniczej osoby fizycznej")]
        [Column("FizAdSiedzGminaNazwa", TypeName = "varchar(100)")]
        [StringLength(100)]
        [MaxLength(100)]
        public string FizAdSiedzGminaNazwa { get; set; }
        #endregion

        #region public string FizAdSiedzMiejscowoscNazwa { get; set; }
        /// <summary>
        /// Miejscowość siedziby działalności rolniczej osoby fizycznej (string)
        /// Place of the seat of the agricultural activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzMiejscowosc_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzMiejscowoscNazwa))]
        [Display(Name = "Miejscowość siedziby działalności rolniczej osoby fizycznej", Prompt = "Wprowadź miejscowość siedziby działalności rolniczej osoby fizycznej", Description = "Miejscowość siedziby działalności rolniczej osoby fizycznej")]
        [Column("FizAdSiedzMiejscowoscNazwa", TypeName = "varchar(100)")]
        [StringLength(100)]
        [MaxLength(100)]
        public string FizAdSiedzMiejscowoscNazwa { get; set; }
        #endregion

        #region public string FizAdSiedzMiejscowoscPocztyNazwa { get; set; }
        /// <summary>
        /// Nazwa miejscowości poczty dla siedziby działalności rolniczej osoby fizycznej (string)
        /// Name of the postal town for the farm seat of a natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzMiejscowoscPoczty_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzMiejscowoscPocztyNazwa))]
        [Display(Name = "Nazwa miejscowości poczty dla siedziby działalności rolniczej osoby fizycznej", Prompt = "Wprowadź nazwę miejscowości poczty dla siedziby działalności rolniczej osoby fizycznej", Description = "Nazwa miejscowości poczty dla siedziby działalności rolniczej osoby fizycznej")]
        [Column("FizAdSiedzMiejscowoscPocztyNazwa", TypeName = "varchar(100)")]
        [StringLength(100)]
        [MaxLength(100)]
        public string FizAdSiedzMiejscowoscPocztyNazwa { get; set; }
        #endregion

        #region public string FizAdSiedzUlicaNazwa { get; set; }
        /// <summary>
        /// Ulica siedziby działalności rolniczej osoby fizycznej (string)
        /// Street of the agricultural activity of the natural person (string)
        /// </summary>
        [XmlElement("fiz_adSiedzUlica_Nazwa")]
        [JsonProperty(nameof(FizAdSiedzUlicaNazwa))]
        [Display(Name = "Ulica siedziby działalności rolniczej osoby fizycznej", Prompt = "Wprowadź ulicę siedziby działalności rolniczej osoby fizycznej", Description = "Ulica siedziby działalności rolniczej osoby fizycznej")]
        [Column("FizAdSiedzUlicaNazwa", TypeName = "varchar(351)")]
        [StringLength(351)]
        [MaxLength(351)]
        public string FizAdSiedzUlicaNazwa { get; set; }
        #endregion
    }
    #endregion
}
