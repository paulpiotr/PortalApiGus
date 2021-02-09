using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace PortalApiGusApiRegonData.Models.DanePobierzPelnyRaport
{
    #region public partial class JednLokalnaOsPrawnej
    /// <summary>
    /// Model danych jednostka lokalna osoby prawnej
    /// Data model local unit of legal entity
    /// </summary>
    [Table("JednLokalnaIaPrawnej")]
    [Serializable, XmlRoot("dane")]
    public partial class JednLokalnaOsPrawnej
    {
        #region public string LokprawRegon14 { get; set; }
        /// <summary>
        /// Regon jednostki lokalnej osoby prawnej (string)
        /// Regon of the local legal entity (string)
        /// </summary>
        [XmlElement("lokpraw_regon14")]
        [JsonProperty(nameof(LokprawRegon14))]
        [Display(Name = "Regon jednostki lokalnej osoby prawnej", Prompt = "Wpisz regon jednostki lokalnej osoby prawnej", Description = "Regon jednostki lokalnej osoby prawnej")]
        [Column("LokprawRegon14", TypeName = "varchar(14)")]
        [StringLength(14)]
        [MaxLength(14)]
        public string LokprawRegon14 { get; set; }
        #endregion

        #region public string LokprawNazwa { get; set; }
        /// <summary>
        /// Nazwa jednostki lokalnej osoby prawnej (string)
        /// Name of the local legal entity (string)
        /// </summary>
        [XmlElement("lokpraw_nazwa")]
        [JsonProperty(nameof(LokprawNazwa))]
        [Display(Name = "Nazwa jednostki lokalnej osoby prawnej", Prompt = "Wpisz nazwę jednostki lokalnej osoby prawnej", Description = "Nazwa jednostki lokalnej osoby prawnej")]
        [Column("LokprawNazwa", TypeName = "varchar(254)")]
        [StringLength(254)]
        [MaxLength(254)]
        public string LokprawNazwa { get; set; }
        #endregion

        #region public string LokprawNumerWrejestrzeEwidencji { get; set; }
        /// <summary>
        /// Numer ewidencji w rejestrze ewidencji jednostki lokalnej osoby prawnej (string)
        /// Registration number in the register of the local unit register of the legal entity (string)
        /// </summary>
        [XmlElement("lokpraw_numerWrejestrzeEwidencji")]
        [JsonProperty(nameof(LokprawNumerWrejestrzeEwidencji))]
        [Display(Name = "Numer w rejestrze ewidencji", Prompt = "Wpisz numer w rejestrze ewidencji", Description = "Numer w rejestrze ewidencji jednostki lokalnej osoby prawnej")]
        [Column("LokprawNumerWrejestrzeEwidencji", TypeName = "varchar(50)")]
        [StringLength(50)]
        [MaxLength(50)]
        public string LokprawNumerWrejestrzeEwidencji { get; set; }
        #endregion

        #region public string LokprawDataWpisuDoRejestruEwidencji { get; set; }
        /// <summary>
        /// Data wpisu ewidencji w rejestrze ewidencji jednostki lokalnej osoby prawnej (string)
        /// Date of entry of the records in the register of the local legal entity's local unit records (string)
        /// </summary>
        [XmlElement("lokpraw_dataWpisuDoRejestruEwidencji")]
        [JsonProperty(nameof(LokprawDataWpisuDoRejestruEwidencji))]
        [Display(Name = "Data wpisu w rejestrze ewidencji", Prompt = "Wpisz datę w rejestrze ewidencji", Description = "Data wpisu w rejestrze ewidencji jednostki lokalnej osoby prawnej")]
        [Column("LokprawDataWpisuDoRejestruEwidencji", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string LokprawDataWpisuDoRejestruEwidencji { get; set; }
        #endregion

        #region public string LokprawDataPowstania { get; set; }
        /// <summary>
        /// Data wpisania wpisu ewidencji w rejestrze ewidencji jednostki lokalnej osoby prawnej (string)
        /// Date of entry of the register in the register of the local unit of the legal entity (string)
        /// </summary>
        [XmlElement("lokpraw_dataPowstania")]
        [JsonProperty(nameof(LokprawDataPowstania))]
        [Display(Name = "Data powstania wpisu w rejestrze ewidencji", Prompt = "Wpisz datę powstania wpisu w rejestrze ewidencji", Description = "Data wpisania wpisu w rejestrze ewidencji jednostki lokalnej osoby prawnej")]
        [Column("LokprawDataPowstania", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string LokprawDataPowstania { get; set; }
        #endregion

        //#region public string LokprawDataPowstania { get; set; }
        ///// <summary>
        ///// Data powstania jednostki lokalnej osoby prawnej (string)
        ///// Date of establishment of the local unit of the legal entity (string)
        ///// </summary>
        //[XmlElement("lokpraw_dataPowstania")]
        //[JsonProperty(nameof(LokprawDataPowstania))]
        //[Display(Name = "Data powstania jednostki lokalnej osoby prawnej", Prompt = "Wpisz datę powstania jednostki lokalnej osoby prawnej", Description = "Data powstania jednostki lokalnej osoby prawnej")]
        //[Column("LokprawDataPowstania", TypeName = "varchar(10)")]
        //[StringLength(10)]
        //[MaxLength(10)]
        //public string LokprawDataPowstania { get; set; }
        //#endregion

        #region public string LokprawDataRozpoczeciaDzialalnosci { get; set; }
        /// <summary>
        /// Data rozpoczęcia działalności jednostki lokalnej osoby prawnej (string)
        /// The start date of the local unit of the legal entity (string)
        /// </summary>
        [XmlElement("lokpraw_dataRozpoczeciaDzialalnosci")]
        [JsonProperty(nameof(LokprawDataRozpoczeciaDzialalnosci))]
        [Display(Name = "Data rozpoczęcia działalności jednostki lokalnej osoby prawnej", Prompt = "Wpisz datę rozpoczęcia działalności jednostki lokalnej osoby prawnej", Description = "Data rozpoczęcia działalności jednostki lokalnej osoby prawnej")]
        [Column("LokprawDataRozpoczeciaDzialalnosci", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string LokprawDataRozpoczeciaDzialalnosci { get; set; }
        #endregion

        #region public string LokprawDataWpisuDoRegon { get; set; }
        /// <summary>
        /// Data wpisu do regon jednostki lokalnej osoby prawnej (string)
        /// Date of entry into the regional unit of the local legal entity  (string)
        /// </summary>
        [XmlElement("lokpraw_dataWpisuDoRegon")]
        [JsonProperty(nameof(LokprawDataWpisuDoRegon))]
        [Display(Name = "Data wpisu do regon jednostki lokalnej osoby prawnej", Prompt = "Wpisz datę wpisu do regon jednostki lokalnej osoby prawnej ", Description = "Data wpisu do regon jednostki lokalnej osoby prawnej ")]
        [Column("LokprawDataWpisuDoRegon", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string LokprawDataWpisuDoRegon { get; set; }
        #endregion

        #region public string LokprawDataZawieszeniaDzialalnosci { get; set; }
        /// <summary>
        /// Data zawieszenia działalności jednostki lokalnej osoby prawnej (string)
        /// Date when the local unit of the legal entity was suspended  (string)
        /// </summary>
        [XmlElement("lokpraw_dataZawieszeniaDzialalnosci")]
        [JsonProperty(nameof(LokprawDataZawieszeniaDzialalnosci))]
        [Display(Name = "Data zawieszenia działalności jednostki lokalnej osoby prawnej", Prompt = "Wpisz datę zawieszenia działalności jednostki lokalnej osoby prawnej ", Description = "Data zawieszenia działalności jednostki lokalnej osoby prawnej ")]
        [Column("LokprawDataZawieszeniaDzialalnosci", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string LokprawDataZawieszeniaDzialalnosci { get; set; }
        #endregion

        #region public string LokprawDataWznowieniaDzialalnosci { get; set; }
        /// <summary>
        /// Data wznowienia działalności jednostki lokalnej osoby prawnej (string)
        /// The date on which the local unit of the legal entity resumes operation (string)
        /// </summary>
        [XmlElement("lokpraw_dataWznowieniaDzialalnosci")]
        [JsonProperty(nameof(LokprawDataWznowieniaDzialalnosci))]
        [Display(Name = "Data wznowienia działalności jednostki lokalnej osoby prawnej", Prompt = "Wpisz datę wznowienia działalności jednostki lokalnej osoby prawnej ", Description = "Data wznowienia działalności jednostki lokalnej osoby prawnej")]
        [Column("LokprawDataWznowieniaDzialalnosci", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string LokprawDataWznowieniaDzialalnosci { get; set; }
        #endregion

        #region public string LokprawDataZaistnieniaZmiany { get; set; }
        /// <summary>
        /// Data zaistnienia zmiany w działalności jednostki lokalnej osoby prawnej (string)
        /// Date of the change in the activity of the local unit of the legal entity (string)
        /// </summary>
        [XmlElement("lokpraw_dataZaistnieniaZmiany")]
        [JsonProperty(nameof(LokprawDataZaistnieniaZmiany))]
        [Display(Name = "Data zaistnienia zmiany w działalności jednostki lokalnej osoby prawnej ", Prompt = "Wpisz datę zaistnienia zmiany w działalności jednostki lokalnej osoby prawnej", Description = "Data zaistnienia zmiany w działalności jednostki lokalnej osoby prawnej")]
        [Column("LokprawDataZaistnieniaZmiany", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string LokprawDataZaistnieniaZmiany { get; set; }
        #endregion

        #region public string LokprawDataZakonczeniaDzialalnosci { get; set; }
        /// <summary>
        /// Data zakończenia działalności jednostki lokalnej osoby prawnej (string)
        /// End date of the activity of the local legal entity (string)
        /// </summary>
        [XmlElement("lokpraw_dataZakonczeniaDzialalnosci")]
        [JsonProperty(nameof(LokprawDataZakonczeniaDzialalnosci))]
        [Display(Name = "Data zakończenia działalności jednostki lokalnej osoby prawnej", Prompt = "Wpisz datę zakończenia działalności jednostki lokalnej osoby prawnej", Description = "Data zakończenia działalności jednostki lokalnej osoby prawnej")]
        [Column("LokprawDataZakonczeniaDzialalnosci", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string LokprawDataZakonczeniaDzialalnosci { get; set; }
        #endregion

        #region public string LokprawDataSkresleniaZRegon { get; set; }
        /// <summary>
        /// Data skreślenia z REGON jednostki lokalnej osoby prawnej (string)
        /// Date of removal from REGON of the local legal entity unit (string)
        /// </summary>
        [XmlElement("lokpraw_dataSkresleniaZRegon")]
        [JsonProperty(nameof(LokprawDataSkresleniaZRegon))]
        [Display(Name = "Data skreślenia z REGON jednostki lokalnej osoby prawnej", Prompt = "Wpisz datę skreślenia z REGON jednostki lokalnej osoby prawnej", Description = "Data skreślenia z REGON jednostki lokalnej osoby prawnej")]
        [Column("LokprawDataSkresleniaZRegon", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string LokprawDataSkresleniaZRegon { get; set; }
        #endregion

        #region public string LokprawAdSiedzKrajSymbol { get; set; }
        /// <summary>
        /// Symbol kraju jednostki lokalnej osoby prawnej (string)
        /// Symbol of the country of the local legal entity unit (string)
        /// </summary>
        [XmlElement("lokpraw_adSiedzKraj_Symbol")]
        [JsonProperty(nameof(LokprawAdSiedzKrajSymbol))]
        [Display(Name = "Symbol kraju jednostki lokalnej osoby prawnej", Prompt = "Wpisz symbol kraju jednostki lokalnej osoby prawnej", Description = "Symbol kraju jednostki lokalnej osoby prawnej")]
        [Column("LokprawAdSiedzKrajSymbol", TypeName = "varchar(2)")]
        [StringLength(2)]
        [MaxLength(2)]
        public string LokprawAdSiedzKrajSymbol { get; set; }
        #endregion

        #region public string LokprawAdSiedzWojewodztwoSymbol { get; set; }
        /// <summary>
        /// Symbol województwa jednostki lokalnej osoby prawnej (string)
        /// The symbol of the voivodeship of the local legal entity unit (string)
        /// </summary>
        [XmlElement("lokpraw_adSiedzWojewodztwo_Symbol")]
        [JsonProperty(nameof(LokprawAdSiedzWojewodztwoSymbol))]
        [Display(Name = "Symbol województwa jednostki lokalnej osoby prawnej", Prompt = "Wpisz symbol województwa jednostki lokalnej osoby prawnej", Description = "Symbol województwa jednostki lokalnej osoby prawnej")]
        [Column("LokprawAdSiedzWojewodztwoSymbol", TypeName = "varchar(2)")]
        [StringLength(2)]
        [MaxLength(2)]
        public string LokprawAdSiedzWojewodztwoSymbol { get; set; }
        #endregion

        #region public string LokprawAdSiedzPowiatSymbol { get; set; }
        /// <summary>
        /// Symbol powiatu jednostki lokalnej osoby prawnej (string)
        /// Symbol of the poviat unit of the local legal entity (string)
        /// </summary>
        [XmlElement("lokpraw_adSiedzPowiat_Symbol")]
        [JsonProperty(nameof(LokprawAdSiedzPowiatSymbol))]
        [Display(Name = "Symbol powiatu jednostki lokalnej osoby prawnej", Prompt = "Wpisz symbol powiatu jednostki lokalnej osoby prawnej", Description = "Symbol powiatu jednostki lokalnej osoby prawnej")]
        [Column("LokprawAdSiedzPowiatSymbol", TypeName = "varchar(2)")]
        [StringLength(2)]
        [MaxLength(2)]
        public string LokprawAdSiedzPowiatSymbol { get; set; }
        #endregion

        #region public string LokprawAdSiedzGminaSymbol { get; set; }
        /// <summary>
        /// Symbol gminy jednostki lokalnej osoby prawnej (string)
        /// Symbol of the commune of the local legal entity unit (string)
        /// </summary>
        [XmlElement("lokpraw_adSiedzGmina_Symbol")]
        [JsonProperty(nameof(LokprawAdSiedzGminaSymbol))]
        [Display(Name = "Symbol gminy jednostki lokalnej osoby prawnej", Prompt = "Wpisz symbol gminy jednostki lokalnej osoby prawnej", Description = "Symbol gminy jednostki lokalnej osoby prawnej")]
        [Column("LokprawAdSiedzGminaSymbol", TypeName = "varchar(3)")]
        [StringLength(3)]
        [MaxLength(3)]
        public string LokprawAdSiedzGminaSymbol { get; set; }
        #endregion

        #region public string LokprawAdSiedzKodPocztowy { get; set; }
        /// <summary>
        /// Kod pocztowy jednostki lokalnej osoby prawnej (string)
        /// Postal code of the local legal entity unit (string)
        /// </summary>
        [XmlElement("lokpraw_adSiedzKodPocztowy")]
        [JsonProperty(nameof(LokprawAdSiedzKodPocztowy))]
        [Display(Name = "Kod pocztowy jednostki lokalnej osoby prawnej", Prompt = "Wpisz kod pocztowy jednostki lokalnej osoby prawnej", Description = "Kod pocztowy jednostki lokalnej osoby prawnej")]
        [Column("LokprawAdSiedzKodPocztowy", TypeName = "varchar(12)")]
        [StringLength(12)]
        [MaxLength(12)]
        public string LokprawAdSiedzKodPocztowy { get; set; }
        #endregion

        #region public string LokprawAdSiedzMiejscowoscPocztySymbol { get; set; }
        /// <summary>
        /// Miejscowość poczty jednostki lokalnej osoby prawnej (string)
        /// City of the post office of the local unit of the legal entity (string)
        /// </summary>
        [XmlElement("lokpraw_adSiedzMiejscowoscPoczty_Symbol")]
        [JsonProperty(nameof(LokprawAdSiedzMiejscowoscPocztySymbol))]
        [Display(Name = "Miejscowość poczty jednostki lokalnej osoby prawnej", Prompt = "Wpisz miejscowość poczty jednostki lokalnej osoby prawnej", Description = "Miejscowość poczty jednostki lokalnej osoby prawnej")]
        [Column("LokprawAdSiedzMiejscowoscPocztySymbol", TypeName = "varchar(7)")]
        [StringLength(7)]
        [MaxLength(7)]
        public string LokprawAdSiedzMiejscowoscPocztySymbol { get; set; }
        #endregion

        #region public string LokprawAdSiedzMiejscowoscSymbol { get; set; }
        /// <summary>
        /// Miejscowość jednostki lokalnej osoby prawnej (string)
        /// City of the local unit of the legal entity (string)
        /// </summary>
        [XmlElement("lokpraw_adSiedzMiejscowosc_Symbol")]
        [JsonProperty(nameof(LokprawAdSiedzMiejscowoscSymbol))]
        [Display(Name = "Miejscowość jednostki lokalnej osoby prawnej", Prompt = "Wpisz miejscowość jednostki lokalnej osoby prawnej", Description = "Miejscowość jednostki lokalnej osoby prawnej")]
        [Column("LokprawAdSiedzMiejscowoscSymbol", TypeName = "varchar(7)")]
        [StringLength(7)]
        [MaxLength(7)]
        public string LokprawAdSiedzMiejscowoscSymbol { get; set; }
        #endregion

        #region public string LokprawAdSiedzUlicaSymbol { get; set; }
        /// <summary>
        /// Ulica jednostki lokalnej osoby prawnej (string)
        /// Street of the local unit of the legal entity (string)
        /// </summary>
        [XmlElement("lokpraw_adSiedzUlica_Symbol")]
        [JsonProperty(nameof(LokprawAdSiedzUlicaSymbol))]
        [Display(Name = "Ulica jednostki lokalnej osoby prawnej", Prompt = "Wpisz ulicę jednostki lokalnej osoby prawnej", Description = "Ulica jednostki lokalnej osoby prawnej")]
        [Column("LokprawAdSiedzUlicaSymbol", TypeName = "varchar(5)")]
        [StringLength(5)]
        [MaxLength(5)]
        public string LokprawAdSiedzUlicaSymbol { get; set; }
        #endregion

        #region public string LokprawAdSiedzNumerNieruchomosci { get; set; }
        /// <summary>
        /// Numer lokalu jednostki lokalnej osoby prawnej (string)
        /// Property number of the local legal entity (string)
        /// </summary>
        [XmlElement("lokpraw_adSiedzNumerNieruchomosci")]
        [JsonProperty(nameof(LokprawAdSiedzNumerNieruchomosci))]
        [Display(Name = "Numer nieruchomości jednostki lokalnej osoby prawnej", Prompt = "Wpisz numer nieruchomości jednostki lokalnej osoby prawnej", Description = "Numer nieruchomości jednostki lokalnej osoby prawnej")]
        [Column("LokprawAdSiedzNumerNieruchomosci", TypeName = "varchar(20)")]
        [StringLength(20)]
        [MaxLength(20)]
        public string LokprawAdSiedzNumerNieruchomosci { get; set; }
        #endregion

        #region public string LokprawAdSiedzNumerLokalu { get; set; }
        /// <summary>
        /// Numer lokalu jednostki lokalnej osoby prawnej (string)
        /// Apartment number of the local legal entity (string)
        /// </summary>
        [XmlElement("lokpraw_adSiedzNumerLokalu")]
        [JsonProperty(nameof(LokprawAdSiedzNumerLokalu))]
        [Display(Name = "Numer lokalu jednostki lokalnej osoby prawnej", Prompt = "Wpisz numer lokalu jednostki lokalnej osoby prawnej", Description = "Numer lokalu jednostki lokalnej osoby prawnej")]
        [Column("LokprawAdSiedzNumerLokalu", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string LokprawAdSiedzNumerLokalu { get; set; }
        #endregion

        #region public string LokprawAdSiedzNietypoweMiejsceLokalizacji { get; set; }
        /// <summary>
        /// Nietypowa lokalizacja siedziby jednostki lokalnej osoby prawnej (string)
        /// Atypical location of the seat of a local legal entity unit (string)
        /// </summary>
        [XmlElement("lokpraw_adSiedzNietypoweMiejsceLokalizacji")]
        [JsonProperty(nameof(LokprawAdSiedzNietypoweMiejsceLokalizacji))]
        [Display(Name = "Nietypowa lokalizacja siedziby jednostki lokalnej osoby prawnej", Prompt = "Wpisz nietypową lokalizacja siedziby jednostki lokalnej osoby prawnej", Description = "Nietypowa lokalizacja siedziby jednostki lokalnej osoby prawnej")]
        [Column("LokprawAdSiedzNietypoweMiejsceLokalizacji", TypeName = "varchar(160)")]
        [StringLength(160)]
        [MaxLength(160)]
        public string LokprawAdSiedzNietypoweMiejsceLokalizacji { get; set; }
        #endregion

        #region public string LokprawAdSiedzKrajNazwa { get; set; }
        /// <summary>
        /// Kraj siedziby jednostki lokalnej osoby prawnej (string)
        /// Country of the seat of the local unit of the legal entity (string)
        /// </summary>
        [XmlElement("lokpraw_adSiedzKraj_Nazwa")]
        [JsonProperty(nameof(LokprawAdSiedzKrajNazwa))]
        [Display(Name = "Kraj siedziby jednostki lokalnej osoby prawnej", Prompt = "Wpisz kraj siedziby jednostki lokalnej osoby prawnej", Description = "Kraj siedziby jednostki lokalnej osoby prawnej")]
        [Column("LokprawAdSiedzKrajNazwa", TypeName = "varchar(200)")]
        [StringLength(200)]
        [MaxLength(200)]
        public string LokprawAdSiedzKrajNazwa { get; set; }
        #endregion

        #region public string LokprawAdSiedzWojewodztwoNazwa { get; set; }
        /// <summary>
        /// Województwo siedziby jednostki lokalnej osoby prawnej (string)
        /// Voivodship of the seat of a local legal entity (string)
        /// </summary>
        [XmlElement("lokpraw_adSiedzWojewodztwo_Nazwa")]
        [JsonProperty(nameof(LokprawAdSiedzWojewodztwoNazwa))]
        [Display(Name = "Województwo siedziby jednostki lokalnej osoby prawnej", Prompt = "Wpisz województwo siedziby jednostki lokalnej osoby prawnej", Description = "Województwo siedziby jednostki lokalnej osoby prawnej")]
        [Column("LokprawAdSiedzWojewodztwoNazwa", TypeName = "varchar(100)")]
        [StringLength(100)]
        [MaxLength(100)]
        public string LokprawAdSiedzWojewodztwoNazwa { get; set; }
        #endregion

        #region public string LokprawAdSiedzPowiatNazwa { get; set; }
        /// <summary>
        /// Powiat siedziby jednostki lokalnej osoby prawnej (string)
        /// Poviat of the seat of a local legal entity (string)
        /// </summary>
        [XmlElement("lokpraw_adSiedzPowiat_Nazwa")]
        [JsonProperty(nameof(LokprawAdSiedzPowiatNazwa))]
        [Display(Name = "Powiat siedziby jednostki lokalnej osoby prawnej", Prompt = "Wpisz powiat siedziby jednostki lokalnej osoby prawnej", Description = "Powiat siedziby jednostki lokalnej osoby prawnej")]
        [Column("LokprawAdSiedzPowiatNazwa", TypeName = "varchar(100)")]
        [StringLength(100)]
        [MaxLength(100)]
        public string LokprawAdSiedzPowiatNazwa { get; set; }
        #endregion

        #region public string LokprawAdSiedzGminaNazwa { get; set; }
        /// <summary>
        /// Gmina siedziby jednostki lokalnej osoby prawnej (string)
        /// Commune of the seat of a local legal entity (string)
        /// </summary>
        [XmlElement("lokpraw_adSiedzGmina_Nazwa")]
        [JsonProperty(nameof(LokprawAdSiedzGminaNazwa))]
        [Display(Name = "Gmina siedziby jednostki lokalnej osoby prawnej", Prompt = "Wpisz gminę siedziby jednostki lokalnej osoby prawnej", Description = "Gmina siedziby jednostki lokalnej osoby prawnej")]
        [Column("LokprawAdSiedzGminaNazwa", TypeName = "varchar(100)")]
        [StringLength(100)]
        [MaxLength(100)]
        public string LokprawAdSiedzGminaNazwa { get; set; }
        #endregion

        #region public string LokprawAdSiedzMiejscowoscNazwa { get; set; }
        /// <summary>
        /// Miejscowość siedziby jednostki lokalnej osoby prawnej (string)
        /// Locality of the seat of a local legal entity (string)
        /// </summary>
        [XmlElement("lokpraw_adSiedzMiejscowosc_Nazwa")]
        [JsonProperty(nameof(LokprawAdSiedzMiejscowoscNazwa))]
        [Display(Name = "Miejscowość siedziby jednostki lokalnej osoby prawnej", Prompt = "Wpisz miejscowość siedziby jednostki lokalnej osoby prawnej", Description = "Miejscowość siedziby jednostki lokalnej osoby prawnej")]
        [Column("LokprawAdSiedzMiejscowoscNazwa", TypeName = "varchar(100)")]
        [StringLength(100)]
        [MaxLength(100)]
        public string LokprawAdSiedzMiejscowoscNazwa { get; set; }
        #endregion

        #region public string LokprawAdSiedzMiejscowoscPocztyNazwa { get; set; }
        /// <summary>
        /// Miejscowość poczty siedziby jednostki lokalnej osoby prawnej (string)
        /// City od the ost office of the seat of a local legal entity (string)
        /// </summary>
        [XmlElement("lokpraw_adSiedzMiejscowoscPoczty_Nazwa")]
        [JsonProperty(nameof(LokprawAdSiedzMiejscowoscPocztyNazwa))]
        [Display(Name = "Miejscowość poczty siedziby jednostki lokalnej osoby prawnej", Prompt = "Wpisz miejscowość poczty siedziby jednostki lokalnej osoby prawnej", Description = "Miejscowość poczty siedziby jednostki lokalnej osoby prawnej")]
        [Column("LokprawAdSiedzMiejscowoscPocztyNazwa", TypeName = "varchar(100)")]
        [StringLength(100)]
        [MaxLength(100)]
        public string LokprawAdSiedzMiejscowoscPocztyNazwa { get; set; }
        #endregion

        #region public string LokprawAdSiedzUlicaNazwa { get; set; }
        /// <summary>
        /// Nazwa ulicy siedziby jednostki lokalnej osoby prawnej (string)
        /// Street name of the seat of a local legal entity (string)
        /// </summary>
        [XmlElement("lokpraw_adSiedzUlica_Nazwa")]
        [JsonProperty(nameof(LokprawAdSiedzUlicaNazwa))]
        [Display(Name = "Nazwa ulicy siedziby jednostki lokalnej osoby prawnej", Prompt = "Wpisz nazwę ulicy siedziby jednostki lokalnej osoby prawnej", Description = "Nazwa ulicy siedziby jednostki lokalnej osoby prawnej")]
        [Column("LokprawAdSiedzUlicaNazwa", TypeName = "varchar(351)")]
        [StringLength(351)]
        [MaxLength(351)]
        public string LokprawAdSiedzUlicaNazwa { get; set; }
        #endregion

        #region public string LokprawFormaFinansowaniaSymbol { get; set; }
        /// <summary>
        /// Symbol formy finansowania jednostki lokalnej osoby prawnej (string)
        /// Symbol of the form of financing of a local legal entity unit (string)
        /// </summary>
        [XmlElement("lokpraw_formaFinansowania_Symbol")]
        [JsonProperty(nameof(LokprawFormaFinansowaniaSymbol))]
        [Display(Name = "Symbol formy finansowania jednostki lokalnej osoby prawnej", Prompt = "Wpisz symbol formy finansowania jednostki lokalnej osoby prawnej", Description = "Symbol formy finansowania jednostki lokalnej osoby prawnej")]
        [Column("LokprawFormaFinansowaniaSymbol", TypeName = "varchar(1)")]
        [StringLength(1)]
        [MaxLength(1)]
        public string LokprawFormaFinansowaniaSymbol { get; set; }
        #endregion

        #region public string LokprawOrganRejestrowySymbol { get; set; }
        /// <summary>
        /// Symbol organu rejestrowego jednostki lokalnej osoby prawnej (string)
        /// Symbol of the registration authority of the local legal entity unit (string)
        /// </summary>
        [XmlElement("lokpraw_organRejestrowy_Symbol")]
        [JsonProperty(nameof(LokprawOrganRejestrowySymbol))]
        [Display(Name = "Symbol organu rejestrowego jednostki lokalnej osoby prawnej", Prompt = "Wpisz symbol organu rejestrowego jednostki lokalnej osoby prawnej", Description = "Symbol organu rejestrowego jednostki lokalnej osoby prawnej")]
        [Column("LokprawOrganRejestrowySymbol", TypeName = "varchar(9)")]
        [StringLength(9)]
        [MaxLength(9)]
        public string LokprawOrganRejestrowySymbol { get; set; }
        #endregion

        #region public string LokprawRodzajRejestruEwidencjiSymbol { get; set; }
        /// <summary>
        /// Symbol rodzaju rejastracji ewidencji jednostki lokalnej osoby prawnej (string)
        /// Symbol of the type of registration of the local legal entity's records (string)
        /// </summary>
        [XmlElement("lokpraw_rodzajRejestruEwidencji_Symbol")]
        [JsonProperty(nameof(LokprawRodzajRejestruEwidencjiSymbol))]
        [Display(Name = "Symbol rodzaju rejastracji ewidencji jednostki lokalnej osoby prawnej", Prompt = "Wpisz symbol rodzaju rejastracji ewidencji jednostki lokalnej osoby prawnej", Description = "Symbol rodzaju rejastracji ewidencji jednostki lokalnej osoby prawnej")]
        [Column("LokprawRodzajRejestruEwidencjiSymbol", TypeName = "varchar(3)")]
        [StringLength(3)]
        [MaxLength(3)]
        public string LokprawRodzajRejestruEwidencjiSymbol { get; set; }
        #endregion

        #region public string LokprawFormaFinansowaniaNazwa { get; set; }
        /// <summary>
        /// Format finansowania jednostki lokalnej osoby prawnej (string)
        /// Funding format of the local legal entity unit (string)
        /// </summary>
        [XmlElement("lokpraw_formaFinansowania_Nazwa")]
        [JsonProperty(nameof(LokprawFormaFinansowaniaNazwa))]
        [Display(Name = "Format finansowania jednostki lokalnej osoby prawnej", Prompt = "Wpisz format finansowania jednostki lokalnej osoby prawnej", Description = "Format finansowania jednostki lokalnej osoby prawnej")]
        [Column("LokprawFormaFinansowaniaNazwa", TypeName = "varchar(240)")]
        [StringLength(240)]
        [MaxLength(240)]
        public string LokprawFormaFinansowaniaNazwa { get; set; }
        #endregion

        #region public string LokprawOrganRejestrowyNazwa { get; set; }
        /// <summary>
        /// Nazwa organu rejestrowego jednostki lokalnej osoby prawnej (string)
        /// Name of the registration authority of the local legal entity unit (string)
        /// </summary>
        [XmlElement("lokpraw_organRejestrowy_Nazwa")]
        [JsonProperty(nameof(LokprawOrganRejestrowyNazwa))]
        [Display(Name = "Nazwa organu rejestrowego jednostki lokalnej osoby prawnej", Prompt = "Wpisz nazwę organu rejestrowego jednostki lokalnej osoby prawnej", Description = "Nazwa organu rejestrowego jednostki lokalnej osoby prawnej")]
        [Column("LokprawOrganRejestrowyNazwa", TypeName = "varchar(240)")]
        [StringLength(240)]
        [MaxLength(240)]
        public string LokprawOrganRejestrowyNazwa { get; set; }
        #endregion

        #region public string LokprawRodzajRejestruEwidencjiNazwa { get; set; }
        /// <summary>
        /// Nazwa rodzaju rejestru ewidencji jednostki lokalnej osoby prawnej (string)
        /// Name of the register type of the local legal entity unit (string)
        /// </summary>
        [XmlElement("lokpraw_rodzajRejestruEwidencji_Nazwa")]
        [JsonProperty(nameof(LokprawRodzajRejestruEwidencjiNazwa))]
        [Display(Name = "Nazwa rodzaju rejestru ewidencji jednostki lokalnej osoby prawnej", Prompt = "Wpisz nazwę rodzaju rejestru ewidencji jednostki lokalnej osoby prawnej", Description = "Nazwa rodzaju rejestru ewidencji jednostki lokalnej osoby prawnej")]
        [Column("LokprawRodzajRejestruEwidencjiNazwa", TypeName = "varchar(240)")]
        [StringLength(240)]
        [MaxLength(240)]
        public string LokprawRodzajRejestruEwidencjiNazwa { get; set; }
        #endregion
    }
    #endregion
}
