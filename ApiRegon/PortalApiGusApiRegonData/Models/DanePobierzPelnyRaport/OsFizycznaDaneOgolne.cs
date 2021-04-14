#region using

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

#endregion

namespace PortalApiGusApiRegonData.Models.DanePobierzPelnyRaport
{
    /// <summary>
    ///     Model Osoba Fizyczna Dane ogólne
    /// </summary>
    [Table("OsFizycznaDaneOgolne")]
    [Serializable]
    [XmlRoot("dane")]
    public class OsFizycznaDaneOgolne
    {
        [Key] [XmlIgnore] public int Id { get; set; }

        [XmlElement("fiz_regon9")]
        [StringLength(9)]
        public string Regon9 { get; set; }

        [XmlElement("fiz_nip")]
        [StringLength(10)]
        public string Nip { get; set; }

        //public rootDaneFiz_statusNip fiz_statusNip { get; set; }
        [XmlElement("fiz_statusNipSpecified")]
        [StringLength(12)]
        public bool StatusNip { get; set; }

        [XmlElement("fiz_nazwisko")]
        [StringLength(100)]
        public string Nazwisko { get; set; }

        [XmlElement("fiz_imie1")]
        [StringLength(50)]
        public string Imie1 { get; set; }

        [XmlElement("fiz_imie2")]
        [StringLength(50)]
        public string Imie2 { get; set; }

        [XmlElement("fiz_dataWpisuPodmiotuDoRegon")]
        [StringLength(10)]
        public string DataWpisuPodmiotuDoRegon { get; set; }

        [XmlElement("fiz_dataZaistnieniaZmiany")]
        [StringLength(10)]
        public string DataZaistnieniaZmiany { get; set; }

        [XmlElement("fiz_dataSkresleniaPodmiotuZRegon")]
        [StringLength(10)]
        public string DataSkresleniaPodmiotuZRegon { get; set; }

        [XmlElement("fiz_podstawowaFormaPrawna_Symbol")]
        [StringLength(3)]
        public string PodstawowaFormaPrawnaSymbol { get; set; }

        [XmlElement("fiz_szczegolnaFormaPrawna_Symbol")]
        [StringLength(3)]
        public string SzczegolnaFormaPrawnaSymbol { get; set; }

        [XmlElement("fiz_formaFinansowania_Symbol")]
        [StringLength(1)]
        public string FormaFinansowaniaSymbol { get; set; }

        [XmlElement("fiz_formaWlasnosci_Symbol")]
        [StringLength(50)]
        public string FormaWlasnosciSymbol { get; set; }

        [XmlElement("fiz_podstawowaFormaPrawna_Nazwa")]
        [StringLength(200)]
        public string PodstawowaFormaPrawnaNazwa { get; set; }

        [XmlElement("fiz_szczegolnaFormaPrawna_Nazwa")]
        [StringLength(200)]
        public string SzczegolnaFormaPrawnaNazwa { get; set; }

        [XmlElement("fiz_formaFinansowania_Nazwa")]
        [StringLength(240)]
        public string FormaFinansowania_Nazwa { get; set; }

        [XmlElement("fiz_formaWlasnosci_Nazwa")]
        [StringLength(240)]
        public string FormaWlasnosciNazwa { get; set; }

        [XmlElement("fiz_dzialalnoscCeidg")] public int DzialalnoscCeidg { get; set; }

        //public bool fiz_dzialalnoscCeidgSpecified { get; set; }
        [XmlElement("fiz_dzialalnoscRolnicza")]
        public int DzialalnoscRolnicza { get; set; }

        //public bool fiz_dzialalnoscRolniczaSpecified { get; set; }
        [XmlElement("fiz_dzialalnoscPozostala")]
        public int DzialalnoscPozostala { get; set; }

        //public bool fiz_dzialalnoscPozostalaSpecified { get; set; }
        [XmlElement("fiz_dzialalnoscSkreslonaDo20141108")]
        public int DzialalnoscSkreslonaDo20141108 { get; set; }

        //public bool fiz_dzialalnoscSkreslonaDo20141108Specified { get; set; }
        [XmlElement("fiz_liczbaJednLokalnych")]
        public int LiczbaJednLokalnych { get; set; }

        //public bool fiz_liczbaJednLokalnychSpecified { get; set; }
        //public enum rootDaneFiz_statusNip {
        //    /// <remarks/>
        //    [System.Xml.Serialization.XmlEnumAttribute("")]
        //    Item,
        //    /// <remarks/>
        //    Uchylony,
        //    /// <remarks/>
        //    Unieważniony,
        //}
    }
}
