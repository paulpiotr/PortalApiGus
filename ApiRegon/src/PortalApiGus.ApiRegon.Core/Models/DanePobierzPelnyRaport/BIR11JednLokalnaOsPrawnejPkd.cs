#region using

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;
using NetAppCommon.Helpers.Xmls;
using Newtonsoft.Json;
using PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmioty;

#endregion

#nullable enable annotations

#region namespace

namespace PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport
{
    #region public class BIR11JednLokalnaOsPrawnejPkd : DanePobierzPelnyRaport

    /// <summary>
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport BIR11JednLokalnaOsPrawnejPkd
    ///     Data model of entities found in the basic report
    /// </summary>
    [Table(nameof(BIR11JednLokalnaOsPrawnejPkd), Schema = "pagard")]
    [JsonObject(nameof(BIR11JednLokalnaOsPrawnejPkd))]
    [Display(Name = "BIR11JednLokalnaOsPrawnejPkd", Description = "BIR11JednLokalnaOsPrawnejPkd")]
    [Serializable]
    [XmlRoot("dane")]
    [Index(nameof(LokprawPkdKod))]
    [Index(nameof(LokprawPkdNazwa))]
    [Index(nameof(LokprawPkdPrzewazajace))]
    public class BIR11JednLokalnaOsPrawnejPkd : DanePobierzPelnyRaport
    {
        #region public override ICollection<TModel> CreateCollection<TModel>...

        public override ICollection<TModel> CreateCollection<TModel>(
            DaneSzukajPodmioty.DaneSzukajPodmioty daneSzukajPodmioty, string pRegon, string pNazwaRaportu, string xml,
            ICollection<MessageInspector> messageInspectorCollection = null!)
        {
            ICollection<BIR11JednLokalnaOsPrawnejPkd> collection =
                (ICollection<BIR11JednLokalnaOsPrawnejPkd>)XmlHelper
                    .DeserializeXmlFromString<DanePobierzPelnyRaportResult<BIR11JednLokalnaOsPrawnejPkd>>(xml).Dane ??
                new Collection<BIR11JednLokalnaOsPrawnejPkd> {new()};
            DaneSzukajPodmiotyKomunikatyOBledach error =
                XmlHelper.DeserializeXmlFromString<DaneSzukajPodmiotyKomunikatyOBledach>(
                    xml);
            foreach (BIR11JednLokalnaOsPrawnejPkd item in collection)
            {
                item.DaneSzukajPodmiotyKomunikatyOBledach = error;
                if (null != messageInspectorCollection && messageInspectorCollection.Count > 0)
                {
                    item.BIR11JednLokalnaOsPrawnejPkdMessageInspector =
                        new List<BIR11JednLokalnaOsPrawnejPkdMessageInspector>();
                    foreach (MessageInspector messageInspector in messageInspectorCollection)
                    {
                        item.BIR11JednLokalnaOsPrawnejPkdMessageInspector.Add(
                            new BIR11JednLokalnaOsPrawnejPkdMessageInspector(item, messageInspector));
                    }
                }
            }

            return (ICollection<TModel>)collection;
        }

        #endregion

        #region private Guid? _daneSzukajPodmiotyId...

        private Guid? _daneSzukajPodmiotyId;

        /// <summary>
        ///     Identyfikator podmiotu, relacja do encji DaneSzukajPodmioty
        ///     Entity identifier, relation to the entity DaneSzukajPodmioty
        /// </summary>
        [Column(Order = 2)]
        [XmlIgnore]
        [JsonProperty(nameof(DaneSzukajPodmiotyId), Order = 2)]
        [Display(Name = "Identyfikator podmiotu", Prompt = "Wybierz lub wpisz identyfikator podmiotu",
            Description = "Identyfikator podmiotu, relacja do encji DaneSzukajPodmioty")]
        public Guid? DaneSzukajPodmiotyId
        {
            get => _daneSzukajPodmiotyId;
            set
            {
                if (value != _daneSzukajPodmiotyId)
                {
                    _daneSzukajPodmiotyId = value;
                    OnPropertyChanged(nameof(DaneSzukajPodmiotyId));
                }
            }
        }

        #endregion

        #region private ICollection<BIR11JednLokalnaOsPrawnejPkdMessageInspector>...

        private ICollection<BIR11JednLokalnaOsPrawnejPkdMessageInspector> _bir11JednLokalnaOsPrawnejPkdMessageInspector;

        /// <summary>
        ///     Kolekcja elementów inspektora wiadomości usługi, relacja do encji DaneSzukajPodmioty, zawiera informacje dotyczące
        ///     przetwarzania żądań
        ///     Service Message Inspector Item Collection, DaneSzukajPodmioty relationship, contains information about request
        ///     processing
        /// </summary>
        [XmlIgnore]
        [JsonProperty(nameof(BIR11JednLokalnaOsPrawnejPkdMessageInspector), Order = 2)]
        //[InverseProperty("DaneSzukajPodmioty")]
        //[ForeignKey("DaneSzukajPodmiotyId")]
        [Display(Name = "Inspektor wiadomości usługi",
            Prompt = "Wybierz elementy kolekcji inspektora wiadomości usługi",
            Description =
                "Kolekcja elementów inspektora wiadomości usługi")]
        public virtual ICollection<BIR11JednLokalnaOsPrawnejPkdMessageInspector> BIR11JednLokalnaOsPrawnejPkdMessageInspector
        {
            get => _bir11JednLokalnaOsPrawnejPkdMessageInspector;
            set
            {
                if (!Equals(value, _bir11JednLokalnaOsPrawnejPkdMessageInspector))
                {
                    _bir11JednLokalnaOsPrawnejPkdMessageInspector = value;
                    OnPropertyChanged(nameof(BIR11JednLokalnaOsPrawnejPkdMessageInspector));
                }
            }
        }

        #endregion

        #region private DaneSzukajPodmioty? _daneSzukajPodmioty...

        private DaneSzukajPodmioty.DaneSzukajPodmioty? _daneSzukajPodmioty;

        /// <summary>
        ///     Podmiot, relacja do encji DaneSzukajPodmioty
        ///     The entity to entity relationship DaneSzukajPodmioty
        /// </summary>
        [Column(Order = 2)]
        [XmlIgnore]
        [ForeignKey(nameof(DaneSzukajPodmiotyId))]
        [JsonProperty(nameof(DaneSzukajPodmioty), Order = 2)]
        [Display(Name = "Podmiot", Prompt = "Uzupełnij lub wybierz podmiot",
            Description = "Podmiot, relacja do encji DaneSzukajPodmioty")]
        public virtual DaneSzukajPodmioty.DaneSzukajPodmioty? DaneSzukajPodmioty
        {
            get => _daneSzukajPodmioty;
            set
            {
                if (value != _daneSzukajPodmioty)
                {
                    _daneSzukajPodmioty = value;
                    OnPropertyChanged(nameof(DaneSzukajPodmioty));
                }
            }
        }

        #endregion

        #region private string? _lokprawPkdKod; public string? LokprawPkdKod

        private string? _lokprawPkdKod;

        /// Lokpraw pkd kod
        /// Lokpraw pkd kod
        [Column(Order = 2)]
        [XmlElement("lokpraw_pkdKod")]
        [JsonProperty(nameof(LokprawPkdKod), Order = 2)]
        [Display(Name = "Lokpraw pkd kod", Prompt = "Wpisz Lokpraw pkd kod", Description = "Lokpraw pkd kod")]
        [StringLength(5)]
        [MaxLength(5)]

        public string? LokprawPkdKod
        {
            get => _lokprawPkdKod;
            set
            {
                if (value != _lokprawPkdKod)
                {
                    _lokprawPkdKod = value;
                    OnPropertyChanged(nameof(LokprawPkdKod));
                }
            }
        }

        #endregion

        #region private string? _lokprawPkdNazwa; public string? LokprawPkdNazwa

        private string? _lokprawPkdNazwa;

        /// Lokpraw pkd nazwa
        /// Lokpraw pkd nazwa
        [Column(Order = 2)]
        [XmlElement("lokpraw_pkdNazwa")]
        [JsonProperty(nameof(LokprawPkdNazwa), Order = 2)]
        [Display(Name = "Lokpraw pkd nazwa", Prompt = "Wpisz Lokpraw pkd nazwa", Description = "Lokpraw pkd nazwa")]
        [StringLength(200)]
        [MaxLength(200)]

        public string? LokprawPkdNazwa
        {
            get => _lokprawPkdNazwa;
            set
            {
                if (value != _lokprawPkdNazwa)
                {
                    _lokprawPkdNazwa = value;
                    OnPropertyChanged(nameof(LokprawPkdNazwa));
                }
            }
        }

        #endregion

        #region private string? _lokprawPkdPrzewazajace; public string? LokprawPkdPrzewazajace

        private string? _lokprawPkdPrzewazajace;

        /// Lokpraw pkd przewazajace
        /// Lokpraw pkd przewazajace
        [Column(Order = 2)]
        [XmlElement("lokpraw_pkdPrzewazajace")]
        [JsonProperty(nameof(LokprawPkdPrzewazajace), Order = 2)]
        [Display(Name = "Lokpraw pkd przewazajace", Prompt = "Wpisz Lokpraw pkd przewazajace",
            Description = "Lokpraw pkd przewazajace")]
        [StringLength(1)]
        [MaxLength(1)]

        public string? LokprawPkdPrzewazajace
        {
            get => _lokprawPkdPrzewazajace;
            set
            {
                if (value != _lokprawPkdPrzewazajace)
                {
                    _lokprawPkdPrzewazajace = value;
                    OnPropertyChanged(nameof(LokprawPkdPrzewazajace));
                }
            }
        }

        #endregion
    }

    #endregion
}

#endregion
