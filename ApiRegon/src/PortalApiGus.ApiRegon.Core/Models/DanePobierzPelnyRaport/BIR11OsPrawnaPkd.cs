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
    #region public class BIR11OsPrawnaPkd : DanePobierzPelnyRaport

    /// <summary>
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport BIR11OsPrawnaPkd
    ///     Data model of entities found in the basic report
    /// </summary>
    [Table(nameof(BIR11OsPrawnaPkd), Schema = "pagard")]
    [JsonObject(nameof(BIR11OsPrawnaPkd))]
    [Display(Name = "BIR11OsPrawnaPkd", Description = "BIR11OsPrawnaPkd")]
    [Serializable]
    [XmlRoot("dane")]
    [Index(nameof(PrawPkdKod))]
    [Index(nameof(PrawPkdNazwa))]
    [Index(nameof(PrawPkdPrzewazajace))]
    public class BIR11OsPrawnaPkd : DanePobierzPelnyRaport
    {
        #region public override ICollection<TModel> CreateCollection<TModel>...

        public override ICollection<TModel> CreateCollection<TModel>(
            DaneSzukajPodmioty.DaneSzukajPodmioty daneSzukajPodmioty, string pRegon, string pNazwaRaportu, string xml,
            ICollection<MessageInspector> messageInspectorCollection = null!)
        {
            ICollection<BIR11OsPrawnaPkd> collection =
                (ICollection<BIR11OsPrawnaPkd>)XmlHelper
                    .DeserializeXmlFromString<DanePobierzPelnyRaportResult<BIR11OsPrawnaPkd>>(xml).Dane ??
                new Collection<BIR11OsPrawnaPkd> {new()};
            DaneSzukajPodmiotyKomunikatyOBledach error =
                XmlHelper.DeserializeXmlFromString<DaneSzukajPodmiotyKomunikatyOBledach>(
                    xml);
            foreach (BIR11OsPrawnaPkd item in collection)
            {
                item.DaneSzukajPodmiotyKomunikatyOBledach = error;
                if (null != messageInspectorCollection && messageInspectorCollection.Count > 0)
                {
                    item.BIR11OsPrawnaPkdMessageInspector = new List<BIR11OsPrawnaPkdMessageInspector>();
                    foreach (MessageInspector messageInspector in messageInspectorCollection)
                    {
                        item.BIR11OsPrawnaPkdMessageInspector.Add(
                            new BIR11OsPrawnaPkdMessageInspector(item, messageInspector));
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

        #region private ICollection<BIR11OsPrawnaPkdMessageInspector>...

        private ICollection<BIR11OsPrawnaPkdMessageInspector> _bir11OsPrawnaPkdMessageInspector;

        /// <summary>
        ///     Kolekcja elementów inspektora wiadomości usługi, relacja do encji DaneSzukajPodmioty, zawiera informacje dotyczące
        ///     przetwarzania żądań
        ///     Service Message Inspector Item Collection, DaneSzukajPodmioty relationship, contains information about request
        ///     processing
        /// </summary>
        [XmlIgnore]
        [JsonProperty(nameof(BIR11OsPrawnaPkdMessageInspector), Order = 2)]
        //[InverseProperty("DaneSzukajPodmioty")]
        //[ForeignKey("DaneSzukajPodmiotyId")]
        [Display(Name = "Inspektor wiadomości usługi",
            Prompt = "Wybierz elementy kolekcji inspektora wiadomości usługi",
            Description =
                "Kolekcja elementów inspektora wiadomości usługi")]
        public virtual ICollection<BIR11OsPrawnaPkdMessageInspector> BIR11OsPrawnaPkdMessageInspector
        {
            get => _bir11OsPrawnaPkdMessageInspector;
            set
            {
                if (!Equals(value, _bir11OsPrawnaPkdMessageInspector))
                {
                    _bir11OsPrawnaPkdMessageInspector = value;
                    OnPropertyChanged(nameof(BIR11OsPrawnaPkdMessageInspector));
                }
            }
        }

        #endregion

        #region private string? _prawPkdKod; public string? PrawPkdKod

        private string? _prawPkdKod;

        /// Praw pkd kod
        /// Praw pkd kod
        [Column(Order = 2)]
        [XmlElement("praw_pkdKod")]
        [JsonProperty(nameof(PrawPkdKod), Order = 2)]
        [Display(Name = "Praw pkd kod", Prompt = "Wpisz Praw pkd kod", Description = "Praw pkd kod")]
        [StringLength(5)]
        [MaxLength(5)]

        public string? PrawPkdKod
        {
            get => _prawPkdKod;
            set
            {
                if (value != _prawPkdKod)
                {
                    _prawPkdKod = value;
                    OnPropertyChanged(nameof(PrawPkdKod));
                }
            }
        }

        #endregion

        #region private string? _prawPkdNazwa; public string? PrawPkdNazwa

        private string? _prawPkdNazwa;

        /// Praw pkd nazwa
        /// Praw pkd nazwa
        [Column(Order = 2)]
        [XmlElement("praw_pkdNazwa")]
        [JsonProperty(nameof(PrawPkdNazwa), Order = 2)]
        [Display(Name = "Praw pkd nazwa", Prompt = "Wpisz Praw pkd nazwa", Description = "Praw pkd nazwa")]
        [StringLength(200)]
        [MaxLength(200)]

        public string? PrawPkdNazwa
        {
            get => _prawPkdNazwa;
            set
            {
                if (value != _prawPkdNazwa)
                {
                    _prawPkdNazwa = value;
                    OnPropertyChanged(nameof(PrawPkdNazwa));
                }
            }
        }

        #endregion

        #region private string? _prawPkdPrzewazajace; public string? PrawPkdPrzewazajace

        private string? _prawPkdPrzewazajace;

        /// Praw pkd przewazajace
        /// Praw pkd przewazajace
        [Column(Order = 2)]
        [XmlElement("praw_pkdPrzewazajace")]
        [JsonProperty(nameof(PrawPkdPrzewazajace), Order = 2)]
        [Display(Name = "Praw pkd przewazajace", Prompt = "Wpisz Praw pkd przewazajace",
            Description = "Praw pkd przewazajace")]
        [StringLength(1)]
        [MaxLength(1)]

        public string? PrawPkdPrzewazajace
        {
            get => _prawPkdPrzewazajace;
            set
            {
                if (value != _prawPkdPrzewazajace)
                {
                    _prawPkdPrzewazajace = value;
                    OnPropertyChanged(nameof(PrawPkdPrzewazajace));
                }
            }
        }

        #endregion
    }

    #endregion
}

#endregion
