#region using

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using Newtonsoft.Json;

#endregion

namespace PortalApiGusApiRegonData.Models.DaneSzukajPodmioty
{
    /// <summary>
    ///     Model wyszukiwanie podmiotów Parametry Wyszukiwania
    /// </summary>
    [Table("DaneSzukajPodmiotyParametryWyszukiwania", Schema = "pagard")]
    public class DaneSzukajPodmiotyParametryWyszukiwania
    {
        #region public Guid Id { get; set; }

        /// <summary>
        ///     Guid Id identyfikator, klucz główny
        /// </summary>
        [XmlIgnore]
        [Key]
        [JsonProperty(nameof(Id))]
        [Display(Name = "Identyfikator", Prompt = "Wpisz identyfikator", Description = "Identyfikator klucz główny")]
        public Guid Id { get; set; }

        #endregion

        #region public string UniqueIdentifierOfTheLoggedInUser { get; set; }

        /// <summary>
        ///     Jednoznaczny identyfikator zalogowanego użytkownika
        ///     Unique identifier of the logged in user
        /// </summary>
        [XmlIgnore]
        [Column("UniqueIdentifierOfTheLoggedInUser", TypeName = "varchar(512)")]
        [JsonProperty(nameof(UniqueIdentifierOfTheLoggedInUser))]
        [Display(Name = "Identyfikator zalogowanego użytkownika",
            Prompt = "Wybierz identyfikator zalogowanego użytkownika",
            Description = "Identyfikator zalogowanego użytkownika")]
        [StringLength(512)]
        //[Required]
        public string UniqueIdentifierOfTheLoggedInUser { get; set; }

        #endregion

        [StringLength(2147483647)] public string SHA512 { get; set; }

        [StringLength(14)] public string Regon { get; set; }

        [StringLength(10)] public string Nip { get; set; }

        [StringLength(10)] public string Krs { get; set; }

        [StringLength(220)] public string Nipy { get; set; }

        [StringLength(300)] public string Regony14zn { get; set; }

        [StringLength(200)] public string Regony9zn { get; set; }

        [StringLength(220)] public string Krsy { get; set; }

        #region public DateTime DataUtworzenia { get; set; }

        /// <summary>
        ///     Data utworzenia
        /// </summary>
        [XmlIgnore]
        [Column("DataUtworzenia", TypeName = "datetime")]
        [JsonProperty(nameof(DataUtworzenia))]
        [Display(Name = "Data Utworzenia", Prompt = "Wpisz lub wybierz datę utworzenia",
            Description = "Data utworzenia")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DataUtworzenia { get; set; }

        #endregion

        #region public DateTime? DataModyfikacji { get; set; }

        /// <summary>
        ///     Data modyfikacji
        /// </summary>
        [XmlIgnore]
        [Column("DataModyfikacji", TypeName = "datetime")]
        [JsonProperty(nameof(DataModyfikacji))]
        [Display(Name = "Data Modyfikacji", Prompt = "Wpisz lub wybierz datę modyfikacji",
            Description = "Data modyfikacji")]
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DataModyfikacji { get; set; }

        #endregion
    }
}
