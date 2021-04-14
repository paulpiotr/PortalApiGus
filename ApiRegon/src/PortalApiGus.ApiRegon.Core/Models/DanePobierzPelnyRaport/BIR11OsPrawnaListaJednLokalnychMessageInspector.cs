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
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsPrawnaListaJednLokalnych
    ///     BIR11OsPrawnaListaJednLokalnychMessageInspector
    /// </summary>
    [Table(nameof(BIR11OsPrawnaListaJednLokalnychMessageInspector), Schema = "pagard")]
    [JsonObject(nameof(BIR11OsPrawnaListaJednLokalnychMessageInspector))]
    [Display(Name = "Inspektor wiadomości soap",
        Description = "Inspektor wiadomości soap dla encji BIR11OsPrawnaListaJednLokalnych")]
    [Index(nameof(BIR11OsPrawnaListaJednLokalnychId))]
    [Index(nameof(MessageInspectorId))]
    public class BIR11OsPrawnaListaJednLokalnychMessageInspector
    {
        #region public BIR11OsPrawnaListaJednLokalnychMessageInspector...

        public BIR11OsPrawnaListaJednLokalnychMessageInspector()
        {
        }

        #endregion 

        #region public BIR11OsPrawnaListaJednLokalnychMessageInspector...

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="bir11OsPrawnaListaJednLokalnych">
        /// Parametr BIR11OsPrawnaListaJednLokalnych jako BIR11OsPrawnaListaJednLokalnych
        /// </param>
        /// <param name="messageInspector">
        /// Parametr messageInspector jako MessageInspector
        /// </param>
        public BIR11OsPrawnaListaJednLokalnychMessageInspector(BIR11OsPrawnaListaJednLokalnych bir11OsPrawnaListaJednLokalnych, MessageInspector messageInspector)
        {
            _bir11OsPrawnaListaJednLokalnych = bir11OsPrawnaListaJednLokalnych;
            _bir11OsPrawnaListaJednLokalnychId = bir11OsPrawnaListaJednLokalnych.Id;
            _messageInspector = messageInspector;
            _messageInspectorId = messageInspector.Id;
        }

        #endregion

        #region _BIR11OsPrawnaListaJednLokalnychId...

        private Guid _bir11OsPrawnaListaJednLokalnychId;

        /// <summary>
        ///     Identyfikator w tabeli BIR11OsPrawnaListaJednLokalnych
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11OsPrawnaListaJednLokalnychId), Order = 1)]
        [Display(Name = "Identyfikator w tabeli BIR11OsPrawnaListaJednLokalnych",
            Prompt = "Wpisz lub wybierz identyfikator w tabeli BIR11OsPrawnaListaJednLokalnych",
            Description = "Identyfikator w tabeli BIR11OsPrawnaListaJednLokalnych")]
        public Guid BIR11OsPrawnaListaJednLokalnychId
        {
            get => _bir11OsPrawnaListaJednLokalnychId;
            set
            {
                if (value != _bir11OsPrawnaListaJednLokalnychId)
                {
                    _bir11OsPrawnaListaJednLokalnychId = value;
                }
            }
        }

        #endregion

        #region private BIR11OsPrawnaListaJednLokalnych _BIR11OsPrawnaListaJednLokalnych...

        private BIR11OsPrawnaListaJednLokalnych _bir11OsPrawnaListaJednLokalnych;

        /// <summary>
        ///     Obiekt w tabeli BIR11OsPrawnaListaJednLokalnych
        /// </summary>
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11OsPrawnaListaJednLokalnych), Order = 1)]
        [Display(Name = "Obiekt w tabeli BIR11OsPrawnaListaJednLokalnych",
            Prompt = "Wpisz lub wybierz Obiekt w tabeli BIR11OsPrawnaListaJednLokalnych",
            Description = "Obiekt w tabeli BIR11OsPrawnaListaJednLokalnych")]
        public BIR11OsPrawnaListaJednLokalnych BIR11OsPrawnaListaJednLokalnych
        {
            get => _bir11OsPrawnaListaJednLokalnych;
            set
            {
                if (value != _bir11OsPrawnaListaJednLokalnych)
                {
                    _bir11OsPrawnaListaJednLokalnych = value;
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
