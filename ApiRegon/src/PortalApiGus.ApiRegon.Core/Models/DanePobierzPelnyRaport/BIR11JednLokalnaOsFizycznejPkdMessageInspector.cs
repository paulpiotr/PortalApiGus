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
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11JednLokalnaOsFizycznejPkd
    ///     BIR11JednLokalnaOsFizycznejPkdMessageInspector
    /// </summary>
    [Table(nameof(BIR11JednLokalnaOsFizycznejPkdMessageInspector), Schema = "pagard")]
    [JsonObject(nameof(BIR11JednLokalnaOsFizycznejPkdMessageInspector))]
    [Display(Name = "Inspektor wiadomości soap",
        Description = "Inspektor wiadomości soap dla encji BIR11JednLokalnaOsFizycznejPkd")]
    [Index(nameof(BIR11JednLokalnaOsFizycznejPkdId))]
    [Index(nameof(MessageInspectorId))]
    public class BIR11JednLokalnaOsFizycznejPkdMessageInspector
    {
        #region public BIR11JednLokalnaOsFizycznejPkdMessageInspector...

        public BIR11JednLokalnaOsFizycznejPkdMessageInspector()
        {

        }

        #endregion 

        #region public BIR11JednLokalnaOsFizycznejPkdMessageInspector...

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="bir11JednLokalnaOsFizycznejPkd">
        /// Parametr BIR11JednLokalnaOsFizycznejPkd jako BIR11JednLokalnaOsFizycznejPkd
        /// </param>
        /// <param name="messageInspector">
        /// Parametr messageInspector jako MessageInspector
        /// </param>
        public BIR11JednLokalnaOsFizycznejPkdMessageInspector(BIR11JednLokalnaOsFizycznejPkd bir11JednLokalnaOsFizycznejPkd, MessageInspector messageInspector)
        {
            _bir11JednLokalnaOsFizycznejPkd = bir11JednLokalnaOsFizycznejPkd;
            _bir11JednLokalnaOsFizycznejPkdId = bir11JednLokalnaOsFizycznejPkd.Id;
            _messageInspector = messageInspector;
            _messageInspectorId = messageInspector.Id;
        }

        #endregion

        #region _BIR11JednLokalnaOsFizycznejPkdId...

        private Guid _bir11JednLokalnaOsFizycznejPkdId;

        /// <summary>
        ///     Identyfikator w tabeli BIR11JednLokalnaOsFizycznejPkd
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11JednLokalnaOsFizycznejPkdId), Order = 1)]
        [Display(Name = "Identyfikator w tabeli BIR11JednLokalnaOsFizycznejPkd",
            Prompt = "Wpisz lub wybierz identyfikator w tabeli BIR11JednLokalnaOsFizycznejPkd",
            Description = "Identyfikator w tabeli BIR11JednLokalnaOsFizycznejPkd")]
        public Guid BIR11JednLokalnaOsFizycznejPkdId
        {
            get => _bir11JednLokalnaOsFizycznejPkdId;
            set
            {
                if (value != _bir11JednLokalnaOsFizycznejPkdId)
                {
                    _bir11JednLokalnaOsFizycznejPkdId = value;
                }
            }
        }

        #endregion

        #region private BIR11JednLokalnaOsFizycznejPkd _BIR11JednLokalnaOsFizycznejPkd...

        private BIR11JednLokalnaOsFizycznejPkd _bir11JednLokalnaOsFizycznejPkd;

        /// <summary>
        ///     Obiekt w tabeli BIR11JednLokalnaOsFizycznejPkd
        /// </summary>
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11JednLokalnaOsFizycznejPkd), Order = 1)]
        [Display(Name = "Obiekt w tabeli BIR11JednLokalnaOsFizycznejPkd",
            Prompt = "Wpisz lub wybierz Obiekt w tabeli BIR11JednLokalnaOsFizycznejPkd",
            Description = "Obiekt w tabeli BIR11JednLokalnaOsFizycznejPkd")]
        public BIR11JednLokalnaOsFizycznejPkd BIR11JednLokalnaOsFizycznejPkd
        {
            get => _bir11JednLokalnaOsFizycznejPkd;
            set
            {
                if (value != _bir11JednLokalnaOsFizycznejPkd)
                {
                    _bir11JednLokalnaOsFizycznejPkd = value;
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
