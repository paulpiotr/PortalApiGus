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
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaListaJednLokalnych
    ///     BIR11OsFizycznaListaJednLokalnychMessageInspector
    /// </summary>
    [Table(nameof(BIR11OsFizycznaListaJednLokalnychMessageInspector), Schema = "pagard")]
    [JsonObject(nameof(BIR11OsFizycznaListaJednLokalnychMessageInspector))]
    [Display(Name = "Inspektor wiadomości soap",
        Description = "Inspektor wiadomości soap dla encji BIR11OsFizycznaListaJednLokalnych")]
    [Index(nameof(BIR11OsFizycznaListaJednLokalnychId))]
    [Index(nameof(MessageInspectorId))]
    public class BIR11OsFizycznaListaJednLokalnychMessageInspector
    {
        #region public BIR11OsFizycznaListaJednLokalnychMessageInspector...

        public BIR11OsFizycznaListaJednLokalnychMessageInspector()
        {
        }

        #endregion 

        #region public BIR11OsFizycznaListaJednLokalnychMessageInspector...

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="bir11OsFizycznaListaJednLokalnych">
        /// Parametr BIR11OsFizycznaListaJednLokalnych jako BIR11OsFizycznaListaJednLokalnych
        /// </param>
        /// <param name="messageInspector">
        /// Parametr messageInspector jako MessageInspector
        /// </param>
        public BIR11OsFizycznaListaJednLokalnychMessageInspector(BIR11OsFizycznaListaJednLokalnych bir11OsFizycznaListaJednLokalnych, MessageInspector messageInspector)
        {
            _bir11OsFizycznaListaJednLokalnych = bir11OsFizycznaListaJednLokalnych;
            _bir11OsFizycznaListaJednLokalnychId = bir11OsFizycznaListaJednLokalnych.Id;
            _messageInspector = messageInspector;
            _messageInspectorId = messageInspector.Id;
        }

        #endregion

        #region _BIR11OsFizycznaListaJednLokalnychId...

        private Guid _bir11OsFizycznaListaJednLokalnychId;

        /// <summary>
        ///     Identyfikator w tabeli BIR11OsFizycznaListaJednLokalnych
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11OsFizycznaListaJednLokalnychId), Order = 1)]
        [Display(Name = "Identyfikator w tabeli BIR11OsFizycznaListaJednLokalnych",
            Prompt = "Wpisz lub wybierz identyfikator w tabeli BIR11OsFizycznaListaJednLokalnych",
            Description = "Identyfikator w tabeli BIR11OsFizycznaListaJednLokalnych")]
        public Guid BIR11OsFizycznaListaJednLokalnychId
        {
            get => _bir11OsFizycznaListaJednLokalnychId;
            set
            {
                if (value != _bir11OsFizycznaListaJednLokalnychId)
                {
                    _bir11OsFizycznaListaJednLokalnychId = value;
                }
            }
        }

        #endregion

        #region private BIR11OsFizycznaListaJednLokalnych _BIR11OsFizycznaListaJednLokalnych...

        private BIR11OsFizycznaListaJednLokalnych _bir11OsFizycznaListaJednLokalnych;

        /// <summary>
        ///     Obiekt w tabeli BIR11OsFizycznaListaJednLokalnych
        /// </summary>
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11OsFizycznaListaJednLokalnych), Order = 1)]
        [Display(Name = "Obiekt w tabeli BIR11OsFizycznaListaJednLokalnych",
            Prompt = "Wpisz lub wybierz Obiekt w tabeli BIR11OsFizycznaListaJednLokalnych",
            Description = "Obiekt w tabeli BIR11OsFizycznaListaJednLokalnych")]
        public BIR11OsFizycznaListaJednLokalnych BIR11OsFizycznaListaJednLokalnych
        {
            get => _bir11OsFizycznaListaJednLokalnych;
            set
            {
                if (value != _bir11OsFizycznaListaJednLokalnych)
                {
                    _bir11OsFizycznaListaJednLokalnych = value;
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
