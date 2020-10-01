using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace PortalApiGusApiRegonData.Models.DaneSzukajPodmioty
{
    #region public partial class DaneSzukajPodmioty
    /// <summary>
    /// Model danych dla wyszukiwanych podmiotów w raporcie podstawowym
    /// Data model for the searched entities in the basic report
    /// </summary>
    [Table("DaneSzukajPodmioty")]
    [Serializable, XmlRoot("dane")]
    public partial class DaneSzukajPodmioty
    {
        [Key]
        [XmlIgnore]
        [JsonProperty(nameof(Id))]
        public int Id { get; set; }

        [XmlIgnore]
        [StringLength(2147483647)]
        [JsonProperty(nameof(ParametryWyszukiwaniaSHA512))]
        public string ParametryWyszukiwaniaSHA512 { get; set; }

        [XmlIgnore]
        [JsonProperty(nameof(ParametryWyszukiwaniaJson))]
        [StringLength(2147483647)]
        public string ParametryWyszukiwaniaJson { get; set; }

        [XmlElement("Regon")]
        [JsonProperty(nameof(Regon))]
        [StringLength(14)]
        public string Regon { get; set; }

        [XmlElement("Nip")]
        [JsonProperty(nameof(Nip))]
        [StringLength(10)]
        public string Nip { get; set; }

        [XmlElement("StatusNip")]
        [JsonProperty(nameof(StatusNip))]
        [StringLength(12)]
        public string StatusNip { get; set; }

        [XmlElement("Nazwa")]
        [JsonProperty(nameof(Nazwa))]
        [StringLength(2000)]
        public string Nazwa { get; set; }

        [XmlElement("Wojewodztwo")]
        [JsonProperty(nameof(Wojewodztwo))]
        [StringLength(200)]
        public string Wojewodztwo { get; set; }

        [XmlElement("Powiat")]
        [JsonProperty(nameof(Powiat))]
        [StringLength(200)]
        public string Powiat { get; set; }

        [XmlElement("Gmina")]
        [JsonProperty(nameof(Gmina))]
        [StringLength(200)]
        public string Gmina { get; set; }

        [XmlElement("Miejscowosc")]
        [JsonProperty(nameof(Miejscowosc))]
        [StringLength(200)]
        public string Miejscowosc { get; set; }

        [XmlElement("KodPocztowy")]
        [JsonProperty(nameof(KodPocztowy))]
        [StringLength(12)]
        public string KodPocztowy { get; set; }

        [XmlElement("Ulica")]
        [JsonProperty(nameof(Ulica))]
        [StringLength(200)]
        public string Ulica { get; set; }

        [XmlElement("NrNieruchomosci")]
        [JsonProperty(nameof(NrNieruchomosci))]
        [StringLength(20)]
        public string NrNieruchomosci { get; set; }

        [XmlElement("NrLokalu")]
        [JsonProperty(nameof(NrLokalu))]
        [StringLength(10)]
        public string NrLokalu { get; set; }

        [XmlElement("Typ")]
        [JsonProperty(nameof(Typ))]
        [StringLength(2)]
        public string Typ { get; set; }

        [XmlElement("SilosID")]
        [JsonProperty(nameof(SilosID))]
        public int? SilosID { get; set; }

        [XmlElement("DataZakonczeniaDzialalnosci")]
        [JsonProperty(nameof(DataZakonczeniaDzialalnosci))]
        [StringLength(10)]
        public string DataZakonczeniaDzialalnosci { get; set; }

        [XmlElement("MiejscowoscPoczty")]
        [JsonProperty(nameof(MiejscowoscPoczty))]
        [StringLength(200)]
        public string MiejscowoscPoczty { get; set; }

        [XmlIgnore]
        [JsonProperty(nameof(DataUtworzenia))]
        public DateTime DataUtworzenia { get; set; }

        [XmlIgnore]
        [JsonProperty(nameof(DataModyfikacji))]
        public DateTime DataModyfikacji { get; set; }
    }
    #endregion
}