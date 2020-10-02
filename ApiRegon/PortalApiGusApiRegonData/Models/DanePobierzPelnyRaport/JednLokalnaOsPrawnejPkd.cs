using System;
using System.Collections.Generic;
using System.Text;

namespace PortalApiGusApiRegonData.Models.DanePobierzPelnyRaport
{
    #region class JednLokalnaOsPrawnejPkd
    /// <summary>
    /// Model danych jednostka lokalna osoby prawnej PKD
    /// Data model local unit of legal entity PKD
    /// </summary>
    [Table("JednLokalnaIaPrawnejPkd")]
    [Serializable, XmlRoot("dane")]
    public partial class JednLokalnaOsPrawnejPkd
    {
        #region public string LokprawPkdKod { get; set; }
        /// <summary>
        /// Kod PKD lokalnej osoby prawnej (string)
        /// PKD code of the local legal entity (string)
        /// </summary>
        [XmlElement("lokpraw_pkdKod")]
        [JsonProperty(nameof(LokprawPkdKod))]
        [Display(Name = "Kod PKD lokalnej osoby prawnej", Prompt = "Wpisz kod PKD lokalnej osoby prawnej", Description = "Kod PKD lokalnej osoby prawnej")]
        [Column("LokprawPkdKod", TypeName = "varchar(5)")]
        [StringLength(5)]
        [MaxLength(5)]
        public string LokprawPkdKod { get; set; }
        #endregion

        #region public string LokprawPkdNazwa { get; set; }
        /// <summary>
        /// Nazwa PKD lokalnej osoby prawnej (string)
        /// PKD name of the local legal entity (string)
        /// </summary>
        [XmlElement("lokpraw_pkdNazwa")]
        [JsonProperty(nameof(LokprawPkdNazwa))]
        [Display(Name = "Nazwa PKD lokalnej osoby prawnej", Prompt = "Wpisz nazwę PKD lokalnej osoby prawnej", Description = "Nazwa PKD lokalnej osoby prawnej")]
        [Column("LokprawPkdNazwa", TypeName = "varchar(200)")]
        [StringLength(200)]
        [MaxLength(200)]
        public string LokprawPkdNazwa { get; set; }
        #endregion

        #region public string LokprawPkdPrzewazajace { get; set; }
        /// <summary>
        /// Przeważające PKD lokalnej osoby prawnej (string)
        /// Prevailing PKD of the local legal entity (string)
        /// </summary>
        [XmlElement("lokpraw_pkdPrzewazajace")]
        [JsonProperty(nameof(LokprawPkdPrzewazajace))]
        [Display(Name = "Przeważające PKD lokalnej osoby prawnej", Prompt = "Wpisz przeważające PKD lokalnej osoby prawnej", Description = "Przeważające PKD lokalnej osoby prawnej")]
        [Column("LokprawPkdPrzewazajace", TypeName = "varchar(1)")]
        [StringLength(1)]
        [MaxLength(1)]
        public string LokprawPkdPrzewazajace { get; set; }
        #endregion
    }
    #endregion
}
