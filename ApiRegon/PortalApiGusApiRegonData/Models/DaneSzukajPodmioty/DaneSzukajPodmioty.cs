using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace PortalApiGusApiRegonData.Models.DaneSzukajPodmioty
{
    /// <summary>
    /// Model wyszukiwanie podmiotów
    /// </summary>
    [Table("DaneSzukajPodmioty")]
    [Serializable, XmlRoot("dane")]
    public partial class DaneSzukajPodmioty
    {
        [Key]
        [XmlIgnore]
        public int Id { get; set; }

        [XmlIgnore]
        [StringLength(2147483647)]
        public string ParametryWyszukiwaniaSHA512 { get; set; }

        [XmlIgnore]
        [StringLength(2147483647)]
        public string ParametryWyszukiwaniaJson { get; set; }

        [XmlElement("Regon")]
        [StringLength(14)]
        public string Regon { get; set; }

        [XmlElement("Nip")]
        [StringLength(10)]
        public string Nip { get; set; }

        [XmlElement("StatusNip")]
        [StringLength(12)]
        public string StatusNip { get; set; }

        [XmlElement("Nazwa")]
        [StringLength(2000)]
        public string Nazwa { get; set; }

        [XmlElement("Wojewodztwo")]
        [StringLength(200)]
        public string Wojewodztwo { get; set; }

        [XmlElement("Powiat")]
        [StringLength(200)]
        public string Powiat { get; set; }

        [XmlElement("Gmina")]
        [StringLength(200)]
        public string Gmina { get; set; }

        [XmlElement("Miejscowosc")]
        [StringLength(200)]
        public string Miejscowosc { get; set; }

        [XmlElement("KodPocztowy")]
        [StringLength(12)]
        public string KodPocztowy { get; set; }

        [XmlElement("Ulica")]
        [StringLength(200)]
        public string Ulica { get; set; }

        [XmlElement("NrNieruchomosci")]
        [StringLength(20)]
        public string NrNieruchomosci { get; set; }

        [XmlElement("NrLokalu")]
        [StringLength(10)]
        public string NrLokalu { get; set; }

        [XmlElement("Typ")]
        [StringLength(2)]
        public string Typ { get; set; }

        [XmlElement("SilosID")]
        public int? SilosID { get; set; }

        [XmlElement("DataZakonczeniaDzialalnosci")]
        [StringLength(10)]
        public string DataZakonczeniaDzialalnosci { get; set; }

        [XmlElement("MiejscowoscPoczty")]
        [StringLength(200)]
        public string MiejscowoscPoczty { get; set; }

        [XmlIgnore]
        public DateTime DataUtworzenia { get; set; }

        [XmlIgnore]
        public DateTime DataModyfikacji { get; set; }
    }
}