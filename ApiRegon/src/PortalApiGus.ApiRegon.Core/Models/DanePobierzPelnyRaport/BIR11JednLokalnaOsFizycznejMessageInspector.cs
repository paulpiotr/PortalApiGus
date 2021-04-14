#region using

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

#endregion

#region namespace

namespace PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport
{
    /// <summary>
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11JednLokalnaOsFizycznej
    ///     BIR11JednLokalnaOsFizycznejMessageInspector
    /// </summary>
    [Table(nameof(BIR11JednLokalnaOsFizycznejMessageInspector), Schema = "pagard")]
    [JsonObject(nameof(BIR11JednLokalnaOsFizycznejMessageInspector))]
    [Display(Name = "Inspektor wiadomości soap",
        Description = "Inspektor wiadomości soap dla encji BIR11JednLokalnaOsFizycznej")]
    [Index(nameof(BIR11JednLokalnaOsFizycznejId))]
    [Index(nameof(MessageInspectorId))]
    public class BIR11JednLokalnaOsFizycznejMessageInspector
    {
        #region public BIR11JednLokalnaOsFizycznejMessageInspector...

        public BIR11JednLokalnaOsFizycznejMessageInspector()
        {

        }

        #endregion 

        #region public BIR11JednLokalnaOsFizycznejMessageInspector...

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="bir11JednLokalnaOsFizycznej">
        /// Parametr bir11JednLokalnaOsFizycznej jako BIR11JednLokalnaOsFizycznej
        /// </param>
        /// <param name="messageInspector">
        /// Parametr messageInspector jako MessageInspector
        /// </param>
        public BIR11JednLokalnaOsFizycznejMessageInspector(BIR11JednLokalnaOsFizycznej bir11JednLokalnaOsFizycznej, MessageInspector messageInspector)
        {
            _bir11JednLokalnaOsFizycznej = bir11JednLokalnaOsFizycznej;
            _bir11JednLokalnaOsFizycznejId = bir11JednLokalnaOsFizycznej.Id;
            _messageInspector = messageInspector;
            _messageInspectorId = messageInspector.Id;
        }

        #endregion

        #region _BIR11JednLokalnaOsFizycznejId...

        private Guid _bir11JednLokalnaOsFizycznejId;

        /// <summary>
        ///     Identyfikator w tabeli BIR11JednLokalnaOsFizycznej
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11JednLokalnaOsFizycznejId), Order = 1)]
        [Display(Name = "Identyfikator w tabeli BIR11JednLokalnaOsFizycznej",
            Prompt = "Wpisz lub wybierz identyfikator w tabeli BIR11JednLokalnaOsFizycznej",
            Description = "Identyfikator w tabeli BIR11JednLokalnaOsFizycznej")]
        public Guid BIR11JednLokalnaOsFizycznejId
        {
            get => _bir11JednLokalnaOsFizycznejId;
            set
            {
                if (value != _bir11JednLokalnaOsFizycznejId)
                {
                    _bir11JednLokalnaOsFizycznejId = value;
                }
            }
        }

        #endregion

        #region private BIR11JednLokalnaOsFizycznej _BIR11JednLokalnaOsFizycznej...

        private BIR11JednLokalnaOsFizycznej _bir11JednLokalnaOsFizycznej;

        /// <summary>
        ///     Obiekt w tabeli BIR11JednLokalnaOsFizycznej
        /// </summary>
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11JednLokalnaOsFizycznej), Order = 1)]
        [Display(Name = "Obiekt w tabeli BIR11JednLokalnaOsFizycznej",
            Prompt = "Wpisz lub wybierz Obiekt w tabeli BIR11JednLokalnaOsFizycznej",
            Description = "Obiekt w tabeli BIR11JednLokalnaOsFizycznej")]
        public BIR11JednLokalnaOsFizycznej BIR11JednLokalnaOsFizycznej
        {
            get => _bir11JednLokalnaOsFizycznej;
            set
            {
                if (value != _bir11JednLokalnaOsFizycznej)
                {
                    _bir11JednLokalnaOsFizycznej = value;
                }
            }
        }

        #endregion

        #region _messageInspectorId...

        private Guid _messageInspectorId;

        /// <summary>
        ///     Identyfikator w tabeli MessageInspector
        /// </summary>
        [Key]
        [Column(Order = 2)]
        [JsonProperty(nameof(MessageInspectorId), Order = 2)]
        [Display(Name = "Identyfikator w tabeli MessageInspector",
            Prompt = "Wpisz lub wybierz identyfikator w tabeli MessageInspector",
            Description = "Identyfikator w tabeli MessageInspector")]
        public Guid MessageInspectorId
        {
            get => _messageInspectorId;
            set
            {
                if (value != _messageInspectorId)
                {
                    _messageInspectorId = value;
                }
            }
        }

        #endregion

        #region private MessageInspector _messageInspector...

        private MessageInspector _messageInspector;

        /// <summary>
        ///     Obiekt w tabeli MessageInspector
        /// </summary>
        [Column(Order = 2)]
        [JsonProperty(nameof(MessageInspector), Order = 2)]
        [Display(Name = "Obiekt w tabeli MessageInspector",
            Prompt = "Wpisz lub wybierz Obiekt w tabeli MessageInspector",
            Description = "Obiekt w tabeli MessageInspector")]
        public MessageInspector MessageInspector
        {
            get => _messageInspector;
            set
            {
                if (value != _messageInspector)
                {
                    _messageInspector = value;
                }
            }
        }

        #endregion
    }
}

#endregion
