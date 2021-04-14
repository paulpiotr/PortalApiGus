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
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaDzialalnoscCeidg
    ///     BIR11OsFizycznaDzialalnoscCeidgMessageInspector
    /// </summary>
    [Table(nameof(BIR11OsFizycznaDzialalnoscCeidgMessageInspector), Schema = "pagard")]
    [JsonObject(nameof(BIR11OsFizycznaDzialalnoscCeidgMessageInspector))]
    [Display(Name = "Inspektor wiadomości soap",
        Description = "Inspektor wiadomości soap dla encji BIR11OsFizycznaDzialalnoscCeidg")]
    [Index(nameof(BIR11OsFizycznaDzialalnoscCeidgId))]
    [Index(nameof(MessageInspectorId))]
    public class BIR11OsFizycznaDzialalnoscCeidgMessageInspector
    {
        #region public BIR11OsFizycznaDzialalnoscCeidgMessageInspector...

        public BIR11OsFizycznaDzialalnoscCeidgMessageInspector()
        {
        }

        #endregion 

        #region public BIR11OsFizycznaDzialalnoscCeidgMessageInspector...

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="bir11OsFizycznaDzialalnoscCeidg">
        /// Parametr BIR11OsFizycznaDzialalnoscCeidg jako BIR11OsFizycznaDzialalnoscCeidg
        /// </param>
        /// <param name="messageInspector">
        /// Parametr messageInspector jako MessageInspector
        /// </param>
        public BIR11OsFizycznaDzialalnoscCeidgMessageInspector(BIR11OsFizycznaDzialalnoscCeidg bir11OsFizycznaDzialalnoscCeidg, MessageInspector messageInspector)
        {
            _bir11OsFizycznaDzialalnoscCeidg = bir11OsFizycznaDzialalnoscCeidg;
            _bir11OsFizycznaDzialalnoscCeidgId = bir11OsFizycznaDzialalnoscCeidg.Id;
            _messageInspector = messageInspector;
            _messageInspectorId = messageInspector.Id;
        }

        #endregion

        #region _BIR11OsFizycznaDzialalnoscCeidgId...

        private Guid _bir11OsFizycznaDzialalnoscCeidgId;

        /// <summary>
        ///     Identyfikator w tabeli BIR11OsFizycznaDzialalnoscCeidg
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11OsFizycznaDzialalnoscCeidgId), Order = 1)]
        [Display(Name = "Identyfikator w tabeli BIR11OsFizycznaDzialalnoscCeidg",
            Prompt = "Wpisz lub wybierz identyfikator w tabeli BIR11OsFizycznaDzialalnoscCeidg",
            Description = "Identyfikator w tabeli BIR11OsFizycznaDzialalnoscCeidg")]
        public Guid BIR11OsFizycznaDzialalnoscCeidgId
        {
            get => _bir11OsFizycznaDzialalnoscCeidgId;
            set
            {
                if (value != _bir11OsFizycznaDzialalnoscCeidgId)
                {
                    _bir11OsFizycznaDzialalnoscCeidgId = value;
                }
            }
        }

        #endregion

        #region private BIR11OsFizycznaDzialalnoscCeidg _BIR11OsFizycznaDzialalnoscCeidg...

        private BIR11OsFizycznaDzialalnoscCeidg _bir11OsFizycznaDzialalnoscCeidg;

        /// <summary>
        ///     Obiekt w tabeli BIR11OsFizycznaDzialalnoscCeidg
        /// </summary>
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11OsFizycznaDzialalnoscCeidg), Order = 1)]
        [Display(Name = "Obiekt w tabeli BIR11OsFizycznaDzialalnoscCeidg",
            Prompt = "Wpisz lub wybierz Obiekt w tabeli BIR11OsFizycznaDzialalnoscCeidg",
            Description = "Obiekt w tabeli BIR11OsFizycznaDzialalnoscCeidg")]
        public BIR11OsFizycznaDzialalnoscCeidg BIR11OsFizycznaDzialalnoscCeidg
        {
            get => _bir11OsFizycznaDzialalnoscCeidg;
            set
            {
                if (value != _bir11OsFizycznaDzialalnoscCeidg)
                {
                    _bir11OsFizycznaDzialalnoscCeidg = value;
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
