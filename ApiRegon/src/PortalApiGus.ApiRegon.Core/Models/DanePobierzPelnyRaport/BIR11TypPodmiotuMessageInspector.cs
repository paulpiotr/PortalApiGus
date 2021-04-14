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
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11TypPodmiotu
    ///     BIR11TypPodmiotuMessageInspector
    /// </summary>
    [Table(nameof(BIR11TypPodmiotuMessageInspector), Schema = "pagard")]
    [JsonObject(nameof(BIR11TypPodmiotuMessageInspector))]
    [Display(Name = "Inspektor wiadomości soap",
        Description = "Inspektor wiadomości soap dla encji BIR11TypPodmiotu")]
    [Index(nameof(BIR11TypPodmiotuId))]
    [Index(nameof(MessageInspectorId))]
    public class BIR11TypPodmiotuMessageInspector
    {
        #region public BIR11TypPodmiotuMessageInspector...

        public BIR11TypPodmiotuMessageInspector()
        {
        }

        #endregion 

        #region public BIR11TypPodmiotuMessageInspector...

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="bir11TypPodmiotu">
        /// Parametr BIR11TypPodmiotu jako BIR11TypPodmiotu
        /// </param>
        /// <param name="messageInspector">
        /// Parametr messageInspector jako MessageInspector
        /// </param>
        public BIR11TypPodmiotuMessageInspector(BIR11TypPodmiotu bir11TypPodmiotu, MessageInspector messageInspector)
        {
            _bir11TypPodmiotu = bir11TypPodmiotu;
            _bir11TypPodmiotuId = bir11TypPodmiotu.Id;
            _messageInspector = messageInspector;
            _messageInspectorId = messageInspector.Id;
        }

        #endregion

        #region _BIR11TypPodmiotuId...

        private Guid _bir11TypPodmiotuId;

        /// <summary>
        ///     Identyfikator w tabeli BIR11TypPodmiotu
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11TypPodmiotuId), Order = 1)]
        [Display(Name = "Identyfikator w tabeli BIR11TypPodmiotu",
            Prompt = "Wpisz lub wybierz identyfikator w tabeli BIR11TypPodmiotu",
            Description = "Identyfikator w tabeli BIR11TypPodmiotu")]
        public Guid BIR11TypPodmiotuId
        {
            get => _bir11TypPodmiotuId;
            set
            {
                if (value != _bir11TypPodmiotuId)
                {
                    _bir11TypPodmiotuId = value;
                }
            }
        }

        #endregion

        #region private BIR11TypPodmiotu _BIR11TypPodmiotu...

        private BIR11TypPodmiotu _bir11TypPodmiotu;

        /// <summary>
        ///     Obiekt w tabeli BIR11TypPodmiotu
        /// </summary>
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11TypPodmiotu), Order = 1)]
        [Display(Name = "Obiekt w tabeli BIR11TypPodmiotu",
            Prompt = "Wpisz lub wybierz Obiekt w tabeli BIR11TypPodmiotu",
            Description = "Obiekt w tabeli BIR11TypPodmiotu")]
        public BIR11TypPodmiotu BIR11TypPodmiotu
        {
            get => _bir11TypPodmiotu;
            set
            {
                if (value != _bir11TypPodmiotu)
                {
                    _bir11TypPodmiotu = value;
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
