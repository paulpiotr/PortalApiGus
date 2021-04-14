#region using

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

#endregion

namespace PortalApiGusApiRegonData.Models.DanePobierzPelnyRaport
{
    [Table("JednLokalnaOsFizycznej")]
    [Serializable]
    [XmlRoot("dane")]
    public class JednLokalnaOsFizycznej
    {
        public string lokfiz_adSiedzGmina_NazwaField;
        public string lokfiz_adSiedzGmina_SymbolField;
        public string lokfiz_adSiedzKodPocztowyField;
        public string lokfiz_adSiedzKraj_NazwaField;
        public string lokfiz_adSiedzKraj_SymbolField;
        public string lokfiz_adSiedzMiejscowosc_NazwaField;
        public string lokfiz_adSiedzMiejscowosc_SymbolField;
        public string lokfiz_adSiedzMiejscowoscPoczty_NazwaField;
        public string lokfiz_adSiedzMiejscowoscPoczty_SymbolField;
        public string lokfiz_adSiedzNietypoweMiejsceLokalizacjiField;
        public string lokfiz_adSiedzNumerLokaluField;
        public string lokfiz_adSiedzNumerNieruchomosciField;
        public string lokfiz_adSiedzPowiat_NazwaField;
        public string lokfiz_adSiedzPowiat_SymbolField;
        public string lokfiz_adSiedzUlica_NazwaField;
        public string lokfiz_adSiedzUlica_SymbolField;
        public string lokfiz_adSiedzWojewodztwo_NazwaField;
        public string lokfiz_adSiedzWojewodztwo_SymbolField;
        public string lokfiz_dataPowstaniaField;
        public string lokfiz_dataRozpoczeciaDzialalnosciField;
        public string lokfiz_dataSkresleniaZRegonField;
        public string lokfiz_dataWpisuDoRegonField;
        public string lokfiz_dataWpisuDoRejestruEwidencjiField;
        public string lokfiz_dataWznowieniaDzialalnosciField;
        public string lokfiz_dataZaistnieniaZmianyField;
        public string lokfiz_dataZakonczeniaDzialalnosciField;
        public string lokfiz_dataZawieszeniaDzialalnosciField;
        public string lokfiz_FormaFinansowania_NazwaField;
        public string lokfiz_FormaFinansowania_SymbolField;
        public string lokfiz_numerwRejestrzeEwidencjiField;
        public string lokfiz_OrganRejestrowy_NazwaField;
        public string lokfiz_OrganRejestrowy_SymbolField;
        public string lokfiz_RodzajRejestru_NazwaField;
        public string lokfiz_RodzajRejestru_SymbolField;
        public string lokfiz_silos_NazwaField;

        [XmlElement("lokfiz_regon14Field")]
        [StringLength(14)]
        public string LokFizRegon14Field { get; set; }

        [XmlElement("lokfiz_regon14Field")] [StringLength(2000)]
        public string LokFizNazwaField;

        [XmlElement("lokfiz_silosIDField")] public int lokfiz_silosIDField;

        public bool lokfiz_silosIDFieldSpecified;
        public bool lokfizC_NiePodjetoDzialalnosciField;
        public bool lokfizC_NiePodjetoDzialalnosciFieldSpecified;


        [Key] [XmlIgnore] public int Id { get; set; }
    }
}
