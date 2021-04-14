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
    #region public class BIR11JednLokalnaOsFizycznejPkd : DanePobierzPelnyRaport

    /// <summary>
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport BIR11JednLokalnaOsFizycznejPkd
    ///     Data model of entities found in the basic report
    /// </summary>
    [Table(nameof(BIR11JednLokalnaOsFizycznejPkd), Schema = "pagard")]
    [JsonObject(nameof(BIR11JednLokalnaOsFizycznejPkd))]
    [Display(Name = "BIR11JednLokalnaOsFizycznejPkd", Description = "BIR11JednLokalnaOsFizycznejPkd")]
    [Serializable]
    [XmlRoot("dane")]
    [Index(nameof(LokfizPkdKod))]
    [Index(nameof(LokfizPkdNazwa))]
    [Index(nameof(LokfizPkdPrzewazajace))]
    [Index(nameof(LokfizSilosSymbol))]
    public class BIR11JednLokalnaOsFizycznejPkd : DanePobierzPelnyRaport
    {
        #region public override ICollection<TModel> CreateCollection<TModel>...

        public override ICollection<TModel> CreateCollection<TModel>(
            DaneSzukajPodmioty.DaneSzukajPodmioty daneSzukajPodmioty, string pRegon, string pNazwaRaportu, string xml,
            ICollection<MessageInspector> messageInspectorCollection = null!)
        {
            ICollection<BIR11JednLokalnaOsFizycznejPkd> collection =
                (ICollection<BIR11JednLokalnaOsFizycznejPkd>)XmlHelper
                    .DeserializeXmlFromString<DanePobierzPelnyRaportResult<BIR11JednLokalnaOsFizycznejPkd>>(xml).Dane ??
                new Collection<BIR11JednLokalnaOsFizycznejPkd> {new()};
            DaneSzukajPodmiotyKomunikatyOBledach error =
                XmlHelper.DeserializeXmlFromString<DaneSzukajPodmiotyKomunikatyOBledach>(
                    xml);
            foreach (BIR11JednLokalnaOsFizycznejPkd item in collection)
            {
                item.DaneSzukajPodmiotyKomunikatyOBledach = error;
                if (null != messageInspectorCollection && messageInspectorCollection.Count > 0)
                {
                    item.BIR11JednLokalnaOsFizycznejPkdMessageInspector =
                        new List<BIR11JednLokalnaOsFizycznejPkdMessageInspector>();
                    foreach (MessageInspector messageInspector in messageInspectorCollection)
                    {
                        item.BIR11JednLokalnaOsFizycznejPkdMessageInspector.Add(
                            new BIR11JednLokalnaOsFizycznejPkdMessageInspector(item, messageInspector));
                    }
                }
            }

            return (ICollection<TModel>)collection;
        }

        #endregion

        #region private ICollection<BIR11JednLokalnaOsFizycznejPkdMessageInspector>...

        private ICollection<BIR11JednLokalnaOsFizycznejPkdMessageInspector> _bir11JednLokalnaOsFizycznejPkdMessageInspector;

        /// <summary>
        ///     Kolekcja elementów inspektora wiadomości usługi, relacja do encji DaneSzukajPodmioty, zawiera informacje dotyczące
        ///     przetwarzania żądań
        ///     Service Message Inspector Item Collection, DaneSzukajPodmioty relationship, contains information about request
        ///     processing
        /// </summary>
        [XmlIgnore]
        [JsonProperty(nameof(BIR11JednLokalnaOsFizycznejPkdMessageInspector), Order = 2)]
        [Display(Name = "Inspektor wiadomości usługi",
            Prompt = "Wybierz elementy kolekcji inspektora wiadomości usługi",
            Description =
                "Kolekcja elementów inspektora wiadomości usługi")]
        public virtual ICollection<BIR11JednLokalnaOsFizycznejPkdMessageInspector> BIR11JednLokalnaOsFizycznejPkdMessageInspector
        {
            get => _bir11JednLokalnaOsFizycznejPkdMessageInspector;
            set
            {
                if (!Equals(value, _bir11JednLokalnaOsFizycznejPkdMessageInspector))
                {
                    _bir11JednLokalnaOsFizycznejPkdMessageInspector = value;
                    OnPropertyChanged(nameof(BIR11JednLokalnaOsFizycznejPkdMessageInspector));
                }
            }
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

        #region private string? _lokfizPkdKod; public string? LokfizPkdKod

        private string? _lokfizPkdKod;

        /// Lokfiz pkd kod
        /// Lokfiz pkd kod
        [Column(Order = 2)]
        [XmlElement("lokfiz_pkd_Kod")]
        [JsonProperty(nameof(LokfizPkdKod), Order = 2)]
        [Display(Name = "Lokfiz pkd kod", Prompt = "Wpisz Lokfiz pkd kod", Description = "Lokfiz pkd kod")]
        [StringLength(5)]
        [MaxLength(5)]

        public string? LokfizPkdKod
        {
            get => _lokfizPkdKod;
            set
            {
                if (value != _lokfizPkdKod)
                {
                    _lokfizPkdKod = value;
                    OnPropertyChanged(nameof(LokfizPkdKod));
                }
            }
        }

        #endregion

        #region private string? _lokfizPkdNazwa; public string? LokfizPkdNazwa

        private string? _lokfizPkdNazwa;

        /// Lokfiz pkd nazwa
        /// Lokfiz pkd nazwa
        [Column(Order = 2)]
        [XmlElement("lokfiz_pkd_Nazwa")]
        [JsonProperty(nameof(LokfizPkdNazwa), Order = 2)]
        [Display(Name = "Lokfiz pkd nazwa", Prompt = "Wpisz Lokfiz pkd nazwa", Description = "Lokfiz pkd nazwa")]
        [StringLength(200)]
        [MaxLength(200)]

        public string? LokfizPkdNazwa
        {
            get => _lokfizPkdNazwa;
            set
            {
                if (value != _lokfizPkdNazwa)
                {
                    _lokfizPkdNazwa = value;
                    OnPropertyChanged(nameof(LokfizPkdNazwa));
                }
            }
        }

        #endregion

        #region private string? _lokfizPkdPrzewazajace; public string? LokfizPkdPrzewazajace

        private string? _lokfizPkdPrzewazajace;

        /// Lokfiz pkd przewazajace
        /// Lokfiz pkd przewazajace
        [Column(Order = 2)]
        [XmlElement("lokfiz_pkd_Przewazajace")]
        [JsonProperty(nameof(LokfizPkdPrzewazajace), Order = 2)]
        [Display(Name = "Lokfiz pkd przewazajace", Prompt = "Wpisz Lokfiz pkd przewazajace",
            Description = "Lokfiz pkd przewazajace")]
        [StringLength(1)]
        [MaxLength(1)]

        public string? LokfizPkdPrzewazajace
        {
            get => _lokfizPkdPrzewazajace;
            set
            {
                if (value != _lokfizPkdPrzewazajace)
                {
                    _lokfizPkdPrzewazajace = value;
                    OnPropertyChanged(nameof(LokfizPkdPrzewazajace));
                }
            }
        }

        #endregion

        #region private string? _lokfizSilosSymbol; public string? LokfizSilosSymbol

        private string? _lokfizSilosSymbol;

        /// Lokfiz silos symbol
        /// Lokfiz silos symbol
        [Column(Order = 2)]
        [XmlElement("lokfiz_Silos_Symbol")]
        [JsonProperty(nameof(LokfizSilosSymbol), Order = 2)]
        [Display(Name = "Lokfiz silos symbol", Prompt = "Wpisz Lokfiz silos symbol",
            Description = "Lokfiz silos symbol")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? LokfizSilosSymbol
        {
            get => _lokfizSilosSymbol;
            set
            {
                if (value != _lokfizSilosSymbol)
                {
                    _lokfizSilosSymbol = value;
                    OnPropertyChanged(nameof(LokfizSilosSymbol));
                }
            }
        }

        #endregion
    }

    #endregion
}

#endregion
