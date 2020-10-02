using System;
using System.Collections.Generic;
using System.Text;

namespace PortalApiGusApiRegonData.Models.DanePobierzPelnyRaport
{
    #region class JednLokalnaOsFizycznejPkd
    /// <summary>
    /// Model danych jednostka lokalna osoby fizycznej
    /// Data model local unit of a natural person
    /// </summary>
    [Table("JednLokalnaOsFizycznejPkd")]
    [Serializable, XmlRoot("dane")]
    public partial class JednLokalnaOsFizycznejPkd
    {
        #region  public string LokfizPkdKod { get; set; }
        /// <summary>
        /// Kod pkd jednostki lokalnej osoby fizycznej (string)
        /// The pkd code of the local unit of a natural person (string)
        /// </summary>
        [XmlElement("lokfiz_pkd_Kod")]
        [JsonProperty(nameof(LokfizPkdKod))]
        [Display(Name = "Kod PKD jednostki lokalnej osoby fizycznej", Prompt = "Wpisz kod PKD jednostki lokalnej osoby fizycznej", Description = "Kod PKD jednostki lokalnej osoby fizycznej")]
        [Column("LokfizPkdKod", TypeName = "varchar(5)")]
        [StringLength(5)]
        [MaxLength(5)]
        public string LokfizPkdKod { get; set; }
        #endregion

        #region  public string LokfizPkdNazwa { get; set; }
        /// <summary>
        /// Nazwa pkd jednostki lokalnej osoby fizycznej (string)
        /// The pkd name of the local unit of a natural person (string)
        /// </summary>
        [XmlElement("lokfiz_pkd_Nazwa")]
        [JsonProperty(nameof(LokfizPkdNazwa))]
        [Display(Name = "Nazwa PKD jednostki lokalnej osoby fizycznej", Prompt = "Wpisz nazwę PKD jednostki lokalnej osoby fizycznej", Description = "Nazwa PKD jednostki lokalnej osoby fizycznej")]
        [Column("LokfizPkdNazwa", TypeName = "varchar(200)")]
        [StringLength(200)]
        [MaxLength(200)]
        public string LokfizPkdNazwa { get; set; }
        #endregion

        #region  public string LokfizPkdPrzewazajace { get; set; }
        /// <summary>
        /// Przeważające PKD jednostki lokalnej osoby fizycznej (string)
        /// Prevailing PKD units of the local natural person (string)
        /// </summary>
        [XmlElement("lokfiz_pkd_Przewazajace")]
        [JsonProperty(nameof(LokfizPkdPrzewazajace))]
        [Display(Name = "PKD przeważające jednostki lokalnej osoby fizycznej", Prompt = "Wpisz PKD przeważające jednostki lokalnej osoby fizycznej", Description = "PKD przeważające jednostki lokalnej osoby fizycznej")]
        [Column("LokfizPkdPrzewazajace", TypeName = "varchar(1)")]
        [StringLength(1)]
        [MaxLength(1)]
        public string LokfizPkdPrzewazajace { get; set; }
        #endregion

        #region  public string LokfizSilosSymbol { get; set; }
        /// <summary>
        /// Symbol pkd jednostki lokalnej osoby fizycznej (string)
        /// The pkd symbol of the local unit of a natural person (string)
        /// </summary>
        [XmlElement("lokfiz_Silos_Symbol")]
        [JsonProperty(nameof(LokfizSilosSymbol))]
        [Display(Name = "Symbol PKD jednostki lokalnej osoby fizycznej", Prompt = "Wpisz symbol PKD jednostki lokalnej osoby fizycznej", Description = "Symbol PKD jednostki lokalnej osoby fizycznej")]
        [Column("LokfizSilosSymbol", TypeName = "varchar(10)")]
        [StringLength(10)]
        [MaxLength(10)]
        public string LokfizSilosSymbol { get; set; }
        #endregion

    }
    #endregion

}
