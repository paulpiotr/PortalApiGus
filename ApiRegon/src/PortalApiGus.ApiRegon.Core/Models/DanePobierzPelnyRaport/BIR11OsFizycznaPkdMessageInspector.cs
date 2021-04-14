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
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaPkd
    ///     BIR11OsFizycznaPkdMessageInspector
    /// </summary>
    [Table(nameof(BIR11OsFizycznaPkdMessageInspector), Schema = "pagard")]
    [JsonObject(nameof(BIR11OsFizycznaPkdMessageInspector))]
    [Display(Name = "Inspektor wiadomości soap",
        Description = "Inspektor wiadomości soap dla encji BIR11OsFizycznaPkd")]
    [Index(nameof(BIR11OsFizycznaPkdId))]
    [Index(nameof(MessageInspectorId))]
    public class BIR11OsFizycznaPkdMessageInspector
    {
        #region public BIR11OsFizycznaPkdMessageInspector...

        public BIR11OsFizycznaPkdMessageInspector()
        {
        }

        #endregion 

        #region public BIR11OsFizycznaPkdMessageInspector...

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="bir11OsFizycznaPkd">
        /// Parametr BIR11OsFizycznaPkd jako BIR11OsFizycznaPkd
        /// </param>
        /// <param name="messageInspector">
        /// Parametr messageInspector jako MessageInspector
        /// </param>
        public BIR11OsFizycznaPkdMessageInspector(BIR11OsFizycznaPkd bir11OsFizycznaPkd, MessageInspector messageInspector)
        {
            _bir11OsFizycznaPkd = bir11OsFizycznaPkd;
            _bir11OsFizycznaPkdId = bir11OsFizycznaPkd.Id;
            _messageInspector = messageInspector;
            _messageInspectorId = messageInspector.Id;
        }

        #endregion

        #region _BIR11OsFizycznaPkdId...

        private Guid _bir11OsFizycznaPkdId;

        /// <summary>
        ///     Identyfikator w tabeli BIR11OsFizycznaPkd
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11OsFizycznaPkdId), Order = 1)]
        [Display(Name = "Identyfikator w tabeli BIR11OsFizycznaPkd",
            Prompt = "Wpisz lub wybierz identyfikator w tabeli BIR11OsFizycznaPkd",
            Description = "Identyfikator w tabeli BIR11OsFizycznaPkd")]
        public Guid BIR11OsFizycznaPkdId
        {
            get => _bir11OsFizycznaPkdId;
            set
            {
                if (value != _bir11OsFizycznaPkdId)
                {
                    _bir11OsFizycznaPkdId = value;
                }
            }
        }

        #endregion

        #region private BIR11OsFizycznaPkd _BIR11OsFizycznaPkd...

        private BIR11OsFizycznaPkd _bir11OsFizycznaPkd;

        /// <summary>
        ///     Obiekt w tabeli BIR11OsFizycznaPkd
        /// </summary>
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11OsFizycznaPkd), Order = 1)]
        [Display(Name = "Obiekt w tabeli BIR11OsFizycznaPkd",
            Prompt = "Wpisz lub wybierz Obiekt w tabeli BIR11OsFizycznaPkd",
            Description = "Obiekt w tabeli BIR11OsFizycznaPkd")]
        public BIR11OsFizycznaPkd BIR11OsFizycznaPkd
        {
            get => _bir11OsFizycznaPkd;
            set
            {
                if (value != _bir11OsFizycznaPkd)
                {
                    _bir11OsFizycznaPkd = value;
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
