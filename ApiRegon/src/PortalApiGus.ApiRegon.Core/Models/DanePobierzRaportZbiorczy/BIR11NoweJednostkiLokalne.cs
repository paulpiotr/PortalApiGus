#region using

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;
using NetAppCommon.Models;
using Newtonsoft.Json;

#endregion

#nullable enable annotations

#region namespace

namespace PortalApiGus.ApiRegon.Core.Models.DanePobierzRaportZbiorczy
{
    #region public class BIR11NoweJednostkiLokalne : BaseEntity

    /// <summary>
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.DanePobierzRaportZbiorczy BIR11NoweJednostkiLokalne
    ///     Data model of entities found in the basic report
    /// </summary>
    [Table(nameof(BIR11NoweJednostkiLokalne), Schema = "pagard")]
    [JsonObject(nameof(BIR11NoweJednostkiLokalne))]
    [Display(Name = "BIR11NoweJednostkiLokalne", Description = "BIR11NoweJednostkiLokalne")]
    [Serializable]
    [XmlRoot("dane")]
    [Index(nameof(Regon))]
    public class BIR11NoweJednostkiLokalne : BaseEntity
    {
        #region private string _regon; public string Regon

        private string _regon;

        /// Regon
        /// Regon
        [Column(Order = 2)]
        [XmlElement("regon")]
        [JsonProperty(nameof(Regon), Order = 2)]
        [Display(Name = "Regon", Prompt = "Wpisz Regon", Description = "Regon")]
        [StringLength(14)]
        [MaxLength(14)]

        public string Regon
        {
            get => _regon;
            set
            {
                if (value != _regon)
                {
                    _regon = value;
                    OnPropertyChanged(nameof(Regon));
                }
            }
        }

        #endregion
    }

    #endregion
}

#endregion
