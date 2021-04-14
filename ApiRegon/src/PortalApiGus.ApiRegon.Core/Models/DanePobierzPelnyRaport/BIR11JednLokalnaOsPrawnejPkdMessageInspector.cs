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
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11JednLokalnaOsPrawnejPkd
    ///     BIR11JednLokalnaOsPrawnejPkdMessageInspector
    /// </summary>
    [Table(nameof(BIR11JednLokalnaOsPrawnejPkdMessageInspector), Schema = "pagard")]
    [JsonObject(nameof(BIR11JednLokalnaOsPrawnejPkdMessageInspector))]
    [Display(Name = "Inspektor wiadomości soap",
        Description = "Inspektor wiadomości soap dla encji BIR11JednLokalnaOsPrawnejPkd")]
    [Index(nameof(BIR11JednLokalnaOsPrawnejPkdId))]
    [Index(nameof(MessageInspectorId))]
    public class BIR11JednLokalnaOsPrawnejPkdMessageInspector
    {
        #region public BIR11JednLokalnaOsPrawnejPkdMessageInspector...

        public BIR11JednLokalnaOsPrawnejPkdMessageInspector()
        {
        }

        #endregion 

        #region public BIR11JednLokalnaOsPrawnejPkdMessageInspector...

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="bir11JednLokalnaOsPrawnejPkd">
        /// Parametr BIR11JednLokalnaOsPrawnejPkd jako BIR11JednLokalnaOsPrawnejPkd
        /// </param>
        /// <param name="messageInspector">
        /// Parametr messageInspector jako MessageInspector
        /// </param>
        public BIR11JednLokalnaOsPrawnejPkdMessageInspector(BIR11JednLokalnaOsPrawnejPkd bir11JednLokalnaOsPrawnejPkd, MessageInspector messageInspector)
        {
            _bir11JednLokalnaOsPrawnejPkd = bir11JednLokalnaOsPrawnejPkd;
            _bir11JednLokalnaOsPrawnejPkdId = bir11JednLokalnaOsPrawnejPkd.Id;
            _messageInspector = messageInspector;
            _messageInspectorId = messageInspector.Id;
        }

        #endregion

        #region private Guid _bir11JednLokalnaOsPrawnejPkdId...

        private Guid _bir11JednLokalnaOsPrawnejPkdId;

        /// <summary>
        ///     Identyfikator w tabeli BIR11JednLokalnaOsPrawnejPkd
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11JednLokalnaOsPrawnejPkdId), Order = 1)]
        [Display(Name = "Identyfikator w tabeli BIR11JednLokalnaOsPrawnejPkd",
            Prompt = "Wpisz lub wybierz identyfikator w tabeli BIR11JednLokalnaOsPrawnejPkd",
            Description = "Identyfikator w tabeli BIR11JednLokalnaOsPrawnejPkd")]
        public Guid BIR11JednLokalnaOsPrawnejPkdId
        {
            get => _bir11JednLokalnaOsPrawnejPkdId;
            set
            {
                if (value != _bir11JednLokalnaOsPrawnejPkdId)
                {
                    _bir11JednLokalnaOsPrawnejPkdId = value;
                }
            }
        }

        #endregion

        #region private BIR11JednLokalnaOsPrawnejPkd _BIR11JednLokalnaOsPrawnejPkd...

        private BIR11JednLokalnaOsPrawnejPkd _bir11JednLokalnaOsPrawnejPkd;

        /// <summary>
        ///     Obiekt w tabeli BIR11JednLokalnaOsPrawnejPkd
        /// </summary>
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11JednLokalnaOsPrawnejPkd), Order = 1)]
        [Display(Name = "Obiekt w tabeli BIR11JednLokalnaOsPrawnejPkd",
            Prompt = "Wpisz lub wybierz Obiekt w tabeli BIR11JednLokalnaOsPrawnejPkd",
            Description = "Obiekt w tabeli BIR11JednLokalnaOsPrawnejPkd")]
        public BIR11JednLokalnaOsPrawnejPkd BIR11JednLokalnaOsPrawnejPkd
        {
            get => _bir11JednLokalnaOsPrawnejPkd;
            set
            {
                if (value != _bir11JednLokalnaOsPrawnejPkd)
                {
                    _bir11JednLokalnaOsPrawnejPkd = value;
                }
            }
        }

        #endregion

        #region private Guid _messageInspectorId...

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
