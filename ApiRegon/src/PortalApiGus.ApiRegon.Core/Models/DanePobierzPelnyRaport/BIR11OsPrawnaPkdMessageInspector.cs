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
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsPrawnaPkd
    ///     BIR11OsPrawnaPkdMessageInspector
    /// </summary>
    [Table(nameof(BIR11OsPrawnaPkdMessageInspector), Schema = "pagard")]
    [JsonObject(nameof(BIR11OsPrawnaPkdMessageInspector))]
    [Display(Name = "Inspektor wiadomości soap",
        Description = "Inspektor wiadomości soap dla encji BIR11OsPrawnaPkd")]
    [Index(nameof(BIR11OsPrawnaPkdId))]
    [Index(nameof(MessageInspectorId))]
    public class BIR11OsPrawnaPkdMessageInspector
    {
        #region public BIR11OsPrawnaPkdMessageInspector...

        public BIR11OsPrawnaPkdMessageInspector()
        {
        }

        #endregion 

        #region public BIR11OsPrawnaPkdMessageInspector...

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="bir11OsPrawnaPkd">
        /// Parametr BIR11OsPrawnaPkd jako BIR11OsPrawnaPkd
        /// </param>
        /// <param name="messageInspector">
        /// Parametr messageInspector jako MessageInspector
        /// </param>
        public BIR11OsPrawnaPkdMessageInspector(BIR11OsPrawnaPkd bir11OsPrawnaPkd, MessageInspector messageInspector)
        {
            _bir11OsPrawnaPkd = bir11OsPrawnaPkd;
            _bir11OsPrawnaPkdId = bir11OsPrawnaPkd.Id;
            _messageInspector = messageInspector;
            _messageInspectorId = messageInspector.Id;
        }

        #endregion

        #region _BIR11OsPrawnaPkdId...

        private Guid _bir11OsPrawnaPkdId;

        /// <summary>
        ///     Identyfikator w tabeli BIR11OsPrawnaPkd
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11OsPrawnaPkdId), Order = 1)]
        [Display(Name = "Identyfikator w tabeli BIR11OsPrawnaPkd",
            Prompt = "Wpisz lub wybierz identyfikator w tabeli BIR11OsPrawnaPkd",
            Description = "Identyfikator w tabeli BIR11OsPrawnaPkd")]
        public Guid BIR11OsPrawnaPkdId
        {
            get => _bir11OsPrawnaPkdId;
            set
            {
                if (value != _bir11OsPrawnaPkdId)
                {
                    _bir11OsPrawnaPkdId = value;
                }
            }
        }

        #endregion

        #region private BIR11OsPrawnaPkd _BIR11OsPrawnaPkd...

        private BIR11OsPrawnaPkd _bir11OsPrawnaPkd;

        /// <summary>
        ///     Obiekt w tabeli BIR11OsPrawnaPkd
        /// </summary>
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11OsPrawnaPkd), Order = 1)]
        [Display(Name = "Obiekt w tabeli BIR11OsPrawnaPkd",
            Prompt = "Wpisz lub wybierz Obiekt w tabeli BIR11OsPrawnaPkd",
            Description = "Obiekt w tabeli BIR11OsPrawnaPkd")]
        public BIR11OsPrawnaPkd BIR11OsPrawnaPkd
        {
            get => _bir11OsPrawnaPkd;
            set
            {
                if (value != _bir11OsPrawnaPkd)
                {
                    _bir11OsPrawnaPkd = value;
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
