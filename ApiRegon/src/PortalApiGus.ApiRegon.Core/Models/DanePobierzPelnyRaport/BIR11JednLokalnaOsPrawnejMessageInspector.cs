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
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11JednLokalnaOsPrawnej
    ///     BIR11JednLokalnaOsPrawnejMessageInspector
    /// </summary>
    [Table(nameof(BIR11JednLokalnaOsPrawnejMessageInspector), Schema = "pagard")]
    [JsonObject(nameof(BIR11JednLokalnaOsPrawnejMessageInspector))]
    [Display(Name = "Inspektor wiadomości soap",
        Description = "Inspektor wiadomości soap dla encji BIR11JednLokalnaOsPrawnej")]
    [Index(nameof(BIR11JednLokalnaOsPrawnejId))]
    [Index(nameof(MessageInspectorId))]
    public class BIR11JednLokalnaOsPrawnejMessageInspector
    {
        #region public BIR11JednLokalnaOsPrawnejMessageInspector...

        public BIR11JednLokalnaOsPrawnejMessageInspector()
        {

        }

        #endregion 

        #region public BIR11JednLokalnaOsPrawnejMessageInspector...

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="bir11JednLokalnaOsPrawnej">
        /// Parametr BIR11JednLokalnaOsPrawnej jako BIR11JednLokalnaOsPrawnej
        /// </param>
        /// <param name="messageInspector">
        /// Parametr messageInspector jako MessageInspector
        /// </param>
        public BIR11JednLokalnaOsPrawnejMessageInspector(BIR11JednLokalnaOsPrawnej bir11JednLokalnaOsPrawnej, MessageInspector messageInspector)
        {
            _bir11JednLokalnaOsPrawnej = bir11JednLokalnaOsPrawnej;
            _bir11JednLokalnaOsPrawnejId = bir11JednLokalnaOsPrawnej.Id;
            _messageInspector = messageInspector;
            _messageInspectorId = messageInspector.Id;
        }

        #endregion

        #region _BIR11JednLokalnaOsPrawnejId...

        private Guid _bir11JednLokalnaOsPrawnejId;

        /// <summary>
        ///     Identyfikator w tabeli BIR11JednLokalnaOsPrawnej
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11JednLokalnaOsPrawnejId), Order = 1)]
        [Display(Name = "Identyfikator w tabeli BIR11JednLokalnaOsPrawnej",
            Prompt = "Wpisz lub wybierz identyfikator w tabeli BIR11JednLokalnaOsPrawnej",
            Description = "Identyfikator w tabeli BIR11JednLokalnaOsPrawnej")]
        public Guid BIR11JednLokalnaOsPrawnejId
        {
            get => _bir11JednLokalnaOsPrawnejId;
            set
            {
                if (value != _bir11JednLokalnaOsPrawnejId)
                {
                    _bir11JednLokalnaOsPrawnejId = value;
                }
            }
        }

        #endregion

        #region private BIR11JednLokalnaOsPrawnej _BIR11JednLokalnaOsPrawnej...

        private BIR11JednLokalnaOsPrawnej _bir11JednLokalnaOsPrawnej;

        /// <summary>
        ///     Obiekt w tabeli BIR11JednLokalnaOsPrawnej
        /// </summary>
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11JednLokalnaOsPrawnej), Order = 1)]
        [Display(Name = "Obiekt w tabeli BIR11JednLokalnaOsPrawnej",
            Prompt = "Wpisz lub wybierz Obiekt w tabeli BIR11JednLokalnaOsPrawnej",
            Description = "Obiekt w tabeli BIR11JednLokalnaOsPrawnej")]
        public BIR11JednLokalnaOsPrawnej BIR11JednLokalnaOsPrawnej
        {
            get => _bir11JednLokalnaOsPrawnej;
            set
            {
                if (value != _bir11JednLokalnaOsPrawnej)
                {
                    _bir11JednLokalnaOsPrawnej = value;
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
