#region using

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using NetAppCommon.Models;
using Newtonsoft.Json;
using PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport.Interface;
using PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmioty;

#endregion

#nullable enable annotations

namespace PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport
{
    /// <summary>
    ///     Bazowy model danych pełnego raportu
    ///     Base data model for the full report
    /// </summary>
    public class DanePobierzPelnyRaport : BaseEntity, IDanePobierzPelnyRaport
    {
        #region public virtual TModel Create<TModel>...

        public virtual TModel Create<TModel>(string pRegon, string pNazwaRaportu, string xml,
            ICollection<MessageInspector> messageInspectorCollection = null!)
            where TModel : DanePobierzPelnyRaport, new() =>
            new();

        #endregion

        #region public virtual ICollection<TModel> CreateCollection<TModel>...

        public virtual ICollection<TModel> CreateCollection<TModel>(
            DaneSzukajPodmioty.DaneSzukajPodmioty daneSzukajPodmioty, string pRegon, string pNazwaRaportu, string xml,
            ICollection<MessageInspector> messageInspectorCollection = null!)
            where TModel : DanePobierzPelnyRaport, new() =>
            new Collection<TModel> {new()};

        #endregion

        #region private string? _pRegon...

        private string? _pRegon;

        public string? PRegon
        {
            get => _pRegon;
            set
            {
                if (value != _pRegon)
                {
                    _pRegon = value;
                    OnPropertyChanged(nameof(PRegon));
                }
            }
        }

        #endregion

        #region private string? _pNazwaRaportu...

        private string? _pNazwaRaportu;

        public string? PNazwaRaportu
        {
            get => _pNazwaRaportu;
            set
            {
                if (value != _pNazwaRaportu)
                {
                    _pNazwaRaportu = value;
                    OnPropertyChanged(nameof(PNazwaRaportu));
                }
            }
        }

        #endregion

        #region private Guid? _daneSzukajPodmiotyParametryWyszukiwaniaId...

        private Guid? _daneSzukajPodmiotyParametryWyszukiwaniaId;

        /// <summary>
        ///     Identyfikator parametrów wyszukiwania, klucz obcy, relacja jeden do jednego do tabeli
        ///     DaneSzukajPodmiotyParametryWyszukiwania
        ///     ID search parameters, foreign key, one-to-one relationship to the table
        ///     DaneSzukajPodmiotyParametryWyszukiwania
        /// </summary>
        [XmlIgnore]
        [JsonProperty(nameof(DaneSzukajPodmiotyParametryWyszukiwaniaId), Order = 2)]
        [Display(Name = "Identyfikator parametrów wyszukiwania",
            Prompt = "Wpisz lub wybierz identyfikator parametrów wyszukiwania",
            Description = "Identyfikator parametrów wyszukiwania, klucz obcy")]
        public Guid? DaneSzukajPodmiotyParametryWyszukiwaniaId
        {
            get => _daneSzukajPodmiotyParametryWyszukiwaniaId;
            set
            {
                if (value != _daneSzukajPodmiotyParametryWyszukiwaniaId)
                {
                    _daneSzukajPodmiotyParametryWyszukiwaniaId = value;
                    OnPropertyChanged(nameof(DaneSzukajPodmiotyParametryWyszukiwaniaId));
                }
            }
        }

        #endregion

        #region private DaneSzukajPodmiotyParametryWyszukiwania? _daneSzukajPodmiotyParametryWyszukiwania...

        private DaneSzukajPodmiotyParametryWyszukiwania? _daneSzukajPodmiotyParametryWyszukiwania;

        /// <summary>
        ///     Parametry wyszukiwania, relacja do encji DaneSzukajPodmiotyParametryWyszukiwania
        ///     Search parameters, relation to the DataSearchObjectsParametrySearch entity
        /// </summary>
        [XmlIgnore]
        [ForeignKey(nameof(DaneSzukajPodmiotyParametryWyszukiwaniaId))]
        [JsonProperty(nameof(DaneSzukajPodmiotyParametryWyszukiwania), Order = 2)]
        [Display(Name = "Identyfikator parametrów wyszukiwania", Prompt = "Uzupełnij parametry wyszukiwania podmiotu",
            Description = "Parametry wyszukiwania, relacja do encji DaneSzukajPodmiotyParametryWyszukiwania")]
        public virtual DaneSzukajPodmiotyParametryWyszukiwania? DaneSzukajPodmiotyParametryWyszukiwania
        {
            get => _daneSzukajPodmiotyParametryWyszukiwania;
            set
            {
                if (value != _daneSzukajPodmiotyParametryWyszukiwania)
                {
                    _daneSzukajPodmiotyParametryWyszukiwania = value;
                    OnPropertyChanged(nameof(DaneSzukajPodmiotyParametryWyszukiwania));
                }
            }
        }

        #endregion

        #region private Guid? _daneSzukajPodmiotyKomunikatyOBledachId...

        private Guid? _daneSzukajPodmiotyKomunikatyOBledachId;

        /// <summary>
        ///     Identyfikator komunikatów o błędach , klucz obcy, relacja jeden do jednego do tabeli
        ///     DaneSzukajPodmiotyKomunikatyOBledach
        ///     Error message ID, foreign key, one-to-one relationship to the table
        ///     DaneSzukajPodmiotKomunikatyOBledach
        /// </summary>
        [XmlIgnore]
        [JsonProperty(nameof(DaneSzukajPodmiotyKomunikatyOBledachId), Order = 2)]
        [Display(Name = "Identyfikator komunikatów o błędach",
            Prompt = "Wpisz lub wybierz identyfikator komunikatów o błędach",
            Description = "Identyfikator komunikatów o błędach, klucz obcy")]
        public Guid? DaneSzukajPodmiotyKomunikatyOBledachId
        {
            get => _daneSzukajPodmiotyKomunikatyOBledachId;
            set
            {
                if (value != _daneSzukajPodmiotyKomunikatyOBledachId)
                {
                    _daneSzukajPodmiotyKomunikatyOBledachId = value;
                    OnPropertyChanged(nameof(DaneSzukajPodmiotyParametryWyszukiwaniaId));
                }
            }
        }

        #endregion

        #region private DaneSzukajPodmiotyKomunikatyOBledach? _daneSzukajPodmiotyKomunikatyOBledach...

        private DaneSzukajPodmiotyKomunikatyOBledach? _daneSzukajPodmiotyKomunikatyOBledach;

        /// <summary>
        ///     Komunikaty o błędach, relacja do encji DaneSzukajPodmiotyKomunikatyOBledach
        ///     Error messages, relation to the DataSzukajPodmiotKomunikatyOBledach entity
        /// </summary>
        [XmlIgnore]
        [ForeignKey(nameof(DaneSzukajPodmiotyKomunikatyOBledachId))]
        [JsonProperty(nameof(DaneSzukajPodmiotyKomunikatyOBledach), Order = 2)]
        [Display(Name = "Komunikaty o błędach", Prompt = "Uzupełnij komunikaty o błędach",
            Description = "Komunikaty o błędach, relacja do encji DaneSzukajPodmiotyKomunikatyOBledach")]
        public DaneSzukajPodmiotyKomunikatyOBledach? DaneSzukajPodmiotyKomunikatyOBledach
        {
            get => _daneSzukajPodmiotyKomunikatyOBledach;
            set
            {
                if (value != _daneSzukajPodmiotyKomunikatyOBledach)
                {
                    _daneSzukajPodmiotyKomunikatyOBledach = value;
                    OnPropertyChanged(nameof(DaneSzukajPodmiotyKomunikatyOBledach));
                }
            }
        }

        #endregion
    }
}
