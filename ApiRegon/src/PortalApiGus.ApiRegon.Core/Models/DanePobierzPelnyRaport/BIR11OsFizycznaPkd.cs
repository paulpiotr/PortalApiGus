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
    #region public class BIR11OsFizycznaPkd : DanePobierzPelnyRaport

    /// <summary>
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport BIR11OsFizycznaPkd
    ///     Data model of entities found in the basic report
    /// </summary>
    [Table(nameof(BIR11OsFizycznaPkd), Schema = "pagard")]
    [JsonObject(nameof(BIR11OsFizycznaPkd))]
    [Display(Name = "BIR11OsFizycznaPkd", Description = "BIR11OsFizycznaPkd")]
    [Serializable]
    [XmlRoot("dane")]
    [Index(nameof(FizPkdKod))]
    [Index(nameof(FizPkdNazwa))]
    [Index(nameof(FizPkdPrzewazajace))]
    [Index(nameof(FizSilosID))]
    [Index(nameof(FizSilosSymbol))]
    [Index(nameof(FizDataSkresleniaDzialalnosciZRegon))]
    public class BIR11OsFizycznaPkd : DanePobierzPelnyRaport
    {
        #region public override ICollection<TModel> CreateCollection<TModel>...

        public override ICollection<TModel> CreateCollection<TModel>(
            DaneSzukajPodmioty.DaneSzukajPodmioty daneSzukajPodmioty, string pRegon, string pNazwaRaportu, string xml,
            ICollection<MessageInspector> messageInspectorCollection = null!)
        {
            ICollection<BIR11OsFizycznaPkd> collection =
                (ICollection<BIR11OsFizycznaPkd>)XmlHelper
                    .DeserializeXmlFromString<DanePobierzPelnyRaportResult<BIR11OsFizycznaPkd>>(xml).Dane ??
                new Collection<BIR11OsFizycznaPkd> {new()};
            DaneSzukajPodmiotyKomunikatyOBledach error =
                XmlHelper.DeserializeXmlFromString<DaneSzukajPodmiotyKomunikatyOBledach>(
                    xml);
            foreach (BIR11OsFizycznaPkd item in collection)
            {
                item.DaneSzukajPodmiotyKomunikatyOBledach = error;
                if(null != messageInspectorCollection && messageInspectorCollection.Count > 0)
                {
                    item.BIR11OsFizycznaPkdMessageInspector = new List<BIR11OsFizycznaPkdMessageInspector>();
                    foreach (MessageInspector messageInspector in messageInspectorCollection)
                    {
                        item.BIR11OsFizycznaPkdMessageInspector.Add(
                            new BIR11OsFizycznaPkdMessageInspector(item, messageInspector));
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

        #region private ICollection<BIR11OsFizycznaPkdMessageInspector>...

        private ICollection<BIR11OsFizycznaPkdMessageInspector> _bir11OsFizycznaPkdMessageInspector;

        /// <summary>
        ///     Kolekcja elementów inspektora wiadomości usługi, relacja do encji DaneSzukajPodmioty, zawiera informacje dotyczące
        ///     przetwarzania żądań
        ///     Service Message Inspector Item Collection, DaneSzukajPodmioty relationship, contains information about request
        ///     processing
        /// </summary>
        [XmlIgnore]
        [JsonProperty(nameof(BIR11OsFizycznaPkdMessageInspector), Order = 2)]
        //[InverseProperty("DaneSzukajPodmioty")]
        //[ForeignKey("DaneSzukajPodmiotyId")]
        [Display(Name = "Inspektor wiadomości usługi",
            Prompt = "Wybierz elementy kolekcji inspektora wiadomości usługi",
            Description =
                "Kolekcja elementów inspektora wiadomości usługi")]
        public virtual ICollection<BIR11OsFizycznaPkdMessageInspector> BIR11OsFizycznaPkdMessageInspector
        {
            get => _bir11OsFizycznaPkdMessageInspector;
            set
            {
                if (!Equals(value, _bir11OsFizycznaPkdMessageInspector))
                {
                    _bir11OsFizycznaPkdMessageInspector = value;
                    OnPropertyChanged(nameof(BIR11OsFizycznaPkdMessageInspector));
                }
            }
        }

        #endregion

        #region private string? _fizPkdKod; public string? FizPkdKod

        private string? _fizPkdKod;

        /// Fiz pkd kod
        /// Fiz pkd kod
        [Column(Order = 2)]
        [XmlElement("fiz_pkd_Kod")]
        [JsonProperty(nameof(FizPkdKod), Order = 2)]
        [Display(Name = "Fiz pkd kod", Prompt = "Wpisz Fiz pkd kod", Description = "Fiz pkd kod")]
        [StringLength(5)]
        [MaxLength(5)]

        public string? FizPkdKod
        {
            get => _fizPkdKod;
            set
            {
                if (value != _fizPkdKod)
                {
                    _fizPkdKod = value;
                    OnPropertyChanged(nameof(FizPkdKod));
                }
            }
        }

        #endregion

        #region private string? _fizPkdNazwa; public string? FizPkdNazwa

        private string? _fizPkdNazwa;

        /// Fiz pkd nazwa
        /// Fiz pkd nazwa
        [Column(Order = 2)]
        [XmlElement("fiz_pkd_Nazwa")]
        [JsonProperty(nameof(FizPkdNazwa), Order = 2)]
        [Display(Name = "Fiz pkd nazwa", Prompt = "Wpisz Fiz pkd nazwa", Description = "Fiz pkd nazwa")]
        [StringLength(200)]
        [MaxLength(200)]

        public string? FizPkdNazwa
        {
            get => _fizPkdNazwa;
            set
            {
                if (value != _fizPkdNazwa)
                {
                    _fizPkdNazwa = value;
                    OnPropertyChanged(nameof(FizPkdNazwa));
                }
            }
        }

        #endregion

        #region private string? _fizPkdPrzewazajace; public string? FizPkdPrzewazajace

        private string? _fizPkdPrzewazajace;

        /// Fiz pkd przewazajace
        /// Fiz pkd przewazajace
        [Column(Order = 2)]
        [XmlElement("fiz_pkd_Przewazajace")]
        [JsonProperty(nameof(FizPkdPrzewazajace), Order = 2)]
        [Display(Name = "Fiz pkd przewazajace", Prompt = "Wpisz Fiz pkd przewazajace",
            Description = "Fiz pkd przewazajace")]
        [StringLength(1)]
        [MaxLength(1)]

        public string? FizPkdPrzewazajace
        {
            get => _fizPkdPrzewazajace;
            set
            {
                if (value != _fizPkdPrzewazajace)
                {
                    _fizPkdPrzewazajace = value;
                    OnPropertyChanged(nameof(FizPkdPrzewazajace));
                }
            }
        }

        #endregion

        #region private int? _fizSilosID; public int? FizSilosID

        private int? _fizSilosID;

        /// Fiz silos i d
        /// Fiz silos i d
        [Column(Order = 2)]
        [XmlElement("fiz_SilosID")]
        [JsonProperty(nameof(FizSilosID), Order = 2)]
        [Display(Name = "Fiz silos i d", Prompt = "Wpisz Fiz silos i d", Description = "Fiz silos i d")]
        [Range(int.MinValue, int.MaxValue)]
        public int? FizSilosID
        {
            get => _fizSilosID;
            set
            {
                if (value != _fizSilosID)
                {
                    _fizSilosID = value;
                    OnPropertyChanged(nameof(FizSilosID));
                }
            }
        }

        #endregion

        #region private string? _fizSilosSymbol; public string? FizSilosSymbol

        private string? _fizSilosSymbol;

        /// Fiz silos symbol
        /// Fiz silos symbol
        [Column(Order = 2)]
        [XmlElement("fiz_Silos_Symbol")]
        [JsonProperty(nameof(FizSilosSymbol), Order = 2)]
        [Display(Name = "Fiz silos symbol", Prompt = "Wpisz Fiz silos symbol", Description = "Fiz silos symbol")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? FizSilosSymbol
        {
            get => _fizSilosSymbol;
            set
            {
                if (value != _fizSilosSymbol)
                {
                    _fizSilosSymbol = value;
                    OnPropertyChanged(nameof(FizSilosSymbol));
                }
            }
        }

        #endregion

        #region private string? _fizDataSkresleniaDzialalnosciZRegon; public string? FizDataSkresleniaDzialalnosciZRegon

        private string? _fizDataSkresleniaDzialalnosciZRegon;

        /// Fiz data skreslenia dzialalnosci z regon
        /// Fiz data skreslenia dzialalnosci z regon
        [Column(Order = 2)]
        [XmlElement("fiz_dataSkresleniaDzialalnosciZRegon")]
        [JsonProperty(nameof(FizDataSkresleniaDzialalnosciZRegon), Order = 2)]
        [Display(Name = "Fiz data skreslenia dzialalnosci z regon",
            Prompt = "Wpisz Fiz data skreslenia dzialalnosci z regon",
            Description = "Fiz data skreslenia dzialalnosci z regon")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? FizDataSkresleniaDzialalnosciZRegon
        {
            get => _fizDataSkresleniaDzialalnosciZRegon;
            set
            {
                if (value != _fizDataSkresleniaDzialalnosciZRegon)
                {
                    _fizDataSkresleniaDzialalnosciZRegon = value;
                    OnPropertyChanged(nameof(FizDataSkresleniaDzialalnosciZRegon));
                }
            }
        }

        #endregion
    }

    #endregion
}

#endregion
